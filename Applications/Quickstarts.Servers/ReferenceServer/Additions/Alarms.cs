#define RUN_DISCRETE
#define RUN_ALARM
#define RUN_CERTIFICATES
#define RUN_ACKNOWLEDGEABLE
#define RUN_OFFNORMAL
#define RUN_SYSTEMOFFNORMAL
//#define RUN_DERIVEDSYSTEMOFFNORMAL
#define RUN_CERTIFICATE
#define RUN_LIMIT
#define RUN_LEVEL

using System;
using System.Collections.Generic;
using System.Diagnostics;

using Opc.Ua;
using Opc.Ua.Server;

#pragma warning disable CS0219

namespace Quickstarts.ReferenceServer
{
    /// <summary>
    /// Alarm Implementation
    /// </summary>

    public class Alarms
    {
        private ReferenceNodeManager m_nodeManager;
        private ushort NameSpaceIndex = 0;
        Dictionary<string, AlarmHolder> m_alarms = new Dictionary<string, AlarmHolder>();

        Dictionary<string, Dictionary<string, SourceController>> m_triggerMap =
            new Dictionary<string, Dictionary<string, SourceController>>();

        CertificateExpirationTypeHolder m_expired = null;
        CertificateExpirationTypeHolder m_inside = null;
        CertificateExpirationTypeHolder m_outside = null;

        SourceController m_sineController = null;
        BaseDataVariableState m_sine = null;
        BaseDataVariableState m_differential = null;
        bool m_runTest = true;
        DateTime m_sineRestart = DateTime.Now;

        private bool m_allowEntry = false;

        private string[] m_conformanceUnits = {
            "Basic",
            "Alarm",
            "Enable",
            "Acknowledge",
            "Confirm",
            "Shelve",
            "Comment",
            "Suppression",
            "OffNormal",
            "SystemOffNormal",
            "Refresh",
            "Refresh2",
            "Discrete",
            "ExclusiveLimit",
            "ExclusiveLevel",
            "ExclusiveDeviation",
            "ExclusiveRateOfChange",
            "NonExclusiveLimit",
            "NonExclusiveLevel",
            "NonExclusiveDeviation",
            "NonExclusiveRateOfChange"
        };

        private SupportedAlarmConditionType[] m_ConditionTypes = {
                    new SupportedAlarmConditionType( "Process", "ProcessConditionClassType",  ObjectTypeIds.ProcessConditionClassType ),
                    new SupportedAlarmConditionType( "Maintenance", "MaintenanceConditionClassType",  ObjectTypeIds.MaintenanceConditionClassType ),
                    new SupportedAlarmConditionType( "System", "SystemConditionClassType",  ObjectTypeIds.SystemConditionClassType ) };

        public Alarms(ReferenceNodeManager nodeManager )
        {
            m_nodeManager = nodeManager;
            NameSpaceIndex = m_nodeManager.NamespaceIndex;
        }

        public ReferenceNodeManager GetNodeManager()
        {
            return m_nodeManager;
        }

        public void CreateAlarms(FolderState root)
        {
            NodeState derivedSystemOffNormalAlarmType = DerivedSystemOffNormalAlarmType.CreateType(GetNodeManager());
            NodeState derivedExclusiveLevelAlarmType = DerivedExclusiveLevelAlarmType.CreateType(GetNodeManager());
            NodeState derivedNonExclusiveLevelAlarmType = DerivedNonExclusiveLevelAlarmType.CreateType(GetNodeManager());

            string alarmsName = "Alarms";
            string alarmsNodeName = alarmsName;
            FolderState alarmsFolder = Helpers.CreateFolder(root, NameSpaceIndex, alarmsNodeName, alarmsName);

            CreateTestItems(alarmsFolder);

            Type alarmControllerType = Type.GetType("Quickstarts.ReferenceServer.AlarmController");
            int defaultInterval = 1000;
            string defaultIntervalString = defaultInterval.ToString();

            int conditionTypeIndex = 0;
            bool useOptional = true;
            foreach( string unitName in m_conformanceUnits )
            {
                Debug.WriteLine("Adding alarms for " + unitName);
                string unitNodeName = alarmsName + "." + unitName;
                FolderState unitFolder = Helpers.CreateFolder(alarmsFolder, NameSpaceIndex,
                    unitNodeName, unitName);

                // Create EnableDisable Method

                string startMethodName = "Start";
                string startMethodNodeName = unitNodeName + "." + startMethodName;
                MethodState startMethod = Helpers.CreateMethod(unitFolder, NameSpaceIndex, startMethodNodeName, startMethodName);
                startMethod.OnCallMethod = new GenericMethodCalledEventHandler(OnStart);

                string endMethodName = "End";
                string endMethodNodeName = unitNodeName + "." + endMethodName;
                MethodState endMethod = Helpers.CreateMethod(unitFolder, NameSpaceIndex, endMethodNodeName, endMethodName);
                endMethod.OnCallMethod = new GenericMethodCalledEventHandler(OnEnd);

                Type controllerType = alarmControllerType;
                int interval = defaultInterval;
                string intervalString = defaultIntervalString;

                if (unitName == "Acknowledge")
                {
                    controllerType = Type.GetType("Quickstarts.ReferenceServer.AcknowledgeableTestAlarmController");
                }
                else if (unitName == "Confirm" || unitName == "Comment" )
                {
                    controllerType = Type.GetType("Quickstarts.ReferenceServer.ConfirmTestAlarmController");
                }

                // Create Triggers.
                Dictionary<string, SourceController> triggerMap = new Dictionary<string, SourceController>();
                m_triggerMap.Add(unitName, triggerMap);

                string analogTriggerName = "AnalogSource";
                string analogTriggerNodeName = unitNodeName + "." + analogTriggerName;
                BaseDataVariableState analogTrigger = Helpers.CreateVariable(unitFolder,
                    NameSpaceIndex, analogTriggerNodeName, analogTriggerName);
                analogTrigger.OnWriteValue = OnWriteAlarmTrigger;
                AlarmController analogAlarmController = (AlarmController)Activator.CreateInstance(controllerType, analogTrigger, interval, false);
                SourceController analogSourceController = new SourceController(analogTrigger, analogAlarmController);
                triggerMap.Add("Analog", analogSourceController);

                string booleanTriggerName = "BooleanSource";
                string booleanTriggerNodeName = unitNodeName + "." + booleanTriggerName;
                BaseDataVariableState booleanTrigger = Helpers.CreateVariable(unitFolder,
                    NameSpaceIndex, booleanTriggerNodeName, booleanTriggerName, boolValue: true);
                booleanTrigger.OnWriteValue = OnWriteAlarmTrigger;
                AlarmController booleanAlarmController = (AlarmController)Activator.CreateInstance(controllerType, booleanTrigger, interval, true);
                SourceController booleanSourceController = new SourceController(booleanTrigger, booleanAlarmController);
                triggerMap.Add("Boolean", booleanSourceController);

                string deviationTriggerName = "DeviationSource";
                string deviationTriggerNodeName = unitNodeName + "." + deviationTriggerName;
                BaseDataVariableState deviationTrigger = Helpers.CreateVariable(unitFolder,
                    NameSpaceIndex, deviationTriggerNodeName, deviationTriggerName);
                analogTrigger.OnWriteValue = OnWriteAlarmTrigger;
                AlarmController deviationAlarmController = (AlarmController)Activator.CreateInstance(controllerType, deviationTrigger, interval, false);
                SourceController deviationSourceController = new SourceController(deviationTrigger, deviationAlarmController);
                triggerMap.Add("Deviation", deviationSourceController);

                string rateOfChangeTriggerName = "RateOfChangeSource";
                string rateOfChangeTriggerNodeName = unitNodeName + "." + rateOfChangeTriggerName;
                BaseDataVariableState rateOfChangeTrigger = Helpers.CreateVariable(unitFolder,
                    NameSpaceIndex, rateOfChangeTriggerNodeName, rateOfChangeTriggerName);
                rateOfChangeTrigger.OnWriteValue = OnWriteAlarmTrigger;
                AlarmController rateOfChangeAlarmController = (AlarmController)Activator.CreateInstance(controllerType, rateOfChangeTrigger, interval, false);
                SourceController rateOfChangeSourceController = new SourceController(rateOfChangeTrigger, rateOfChangeAlarmController);
                triggerMap.Add("RateOfChange", rateOfChangeSourceController);

                // Deviation Setpoint
                string deviationSetpointName = "DeviationSetpoint";
                string deviationSetpointNodeName = unitNodeName + "." + deviationSetpointName;

                BaseDataVariableState deviationSetpoint = Helpers.CreateVariable(unitFolder, NameSpaceIndex, deviationSetpointNodeName, deviationSetpointName );
                deviationSetpoint.AccessLevel = AccessLevels.CurrentRead;
                deviationSetpoint.UserAccessLevel = AccessLevels.CurrentRead;
                deviationSetpoint.Value = 50;


                AlarmHolder ackAlarmType = new AcknowledgeableConditionTypeHolder(
                    this,
                    unitFolder,
                    analogSourceController,
                    intervalString,
                    GetSupportedAlarmConditionType( ref conditionTypeIndex ),
                    controllerType,
                    interval,
                    optional: GetUseOptional(unitName, ref useOptional ) );
                m_alarms.Add(ackAlarmType.AlarmNodeName, ackAlarmType);

                AlarmHolder alarmConditionType = new AlarmConditionTypeHolder(
                    this,
                    unitFolder,
                    analogSourceController,
                    intervalString,
                    GetSupportedAlarmConditionType( ref conditionTypeIndex ),
                    controllerType,
                    interval,
                    optional: GetUseOptional(unitName, ref useOptional));
                m_alarms.Add(alarmConditionType.AlarmNodeName, alarmConditionType);

                // Need to disable this until the AlarmHolder is updated.
                // Provides limited value at this time

                // Discrepancy TargetValue NodeId
                string discrepancyName = Defines.DISCREPANCY_TARGET_NAME;
                string discrepancyNodeId = unitNodeName + "." + discrepancyName;
                BaseDataVariableState discrepancyTargetValue = Helpers.CreateVariable(unitFolder, NameSpaceIndex, discrepancyNodeId, discrepancyName);
                discrepancyTargetValue.AccessLevel = AccessLevels.CurrentRead;
                discrepancyTargetValue.UserAccessLevel = AccessLevels.CurrentRead;
                discrepancyTargetValue.Value = 50;

                AlarmHolder discrepancy = new DiscrepancyAlarmTypeHolder(
                    this,
                    unitFolder,
                    analogSourceController,
                    intervalString,
                    GetSupportedAlarmConditionType(ref conditionTypeIndex),
                    controllerType,
                    interval,
                    optional: GetUseOptional(unitName, ref useOptional));
                m_alarms.Add(discrepancy.AlarmNodeName, discrepancy);

                AlarmHolder discrete = new DiscreteHolder(
                    this,
                    unitFolder,
                    booleanSourceController,
                    intervalString,
                    GetSupportedAlarmConditionType(ref conditionTypeIndex),
                    controllerType,
                    interval,
                    optional: GetUseOptional(unitName, ref useOptional));
                m_alarms.Add(discrete.AlarmNodeName, discrete);

                AlarmHolder limit = new LimitAlarmTypeHolder(
                    this,
                    unitFolder,
                    analogSourceController,
                    intervalString,
                    GetSupportedAlarmConditionType(ref conditionTypeIndex),
                    controllerType,
                    interval,
                    optional: GetUseOptional(unitName, ref useOptional));
                m_alarms.Add(limit.AlarmNodeName, limit);

                string optionalName = intervalString + "Optional";
                string mandatoryName = intervalString + "Mandatory";
                AlarmHolder mandatoryExclusiveLimit = new ExclusiveLimitHolder(
                    this,
                    unitFolder,
                    analogSourceController,
                    mandatoryName,
                    GetSupportedAlarmConditionType(ref conditionTypeIndex),
                    controllerType,
                    interval,
                    optional: false);
                m_alarms.Add(mandatoryExclusiveLimit.AlarmNodeName, mandatoryExclusiveLimit);

                AlarmHolder optionalExclusiveLimit = new ExclusiveLimitHolder(
                    this,
                    unitFolder,
                    analogSourceController,
                    optionalName,
                    GetSupportedAlarmConditionType(ref conditionTypeIndex),
                    controllerType,
                    interval,
                    optional: true);
                m_alarms.Add(optionalExclusiveLimit.AlarmNodeName, optionalExclusiveLimit);

                AlarmHolder mandatoryExclusiveLevel = new ExclusiveLevelHolder(
                    this,
                    unitFolder,
                    analogSourceController,
                    mandatoryName,
                    GetSupportedAlarmConditionType(ref conditionTypeIndex),
                    controllerType,
                    interval,
                    optional: false);

                m_alarms.Add(mandatoryExclusiveLevel.AlarmNodeName, mandatoryExclusiveLevel);

                AlarmHolder optionalExclusiveLevel = new ExclusiveLevelHolder(
                    this,
                    unitFolder,
                    analogSourceController,
                    optionalName,
                    GetSupportedAlarmConditionType(ref conditionTypeIndex),
                    controllerType,
                    interval,
                    optional: true);
                m_alarms.Add(optionalExclusiveLevel.AlarmNodeName, optionalExclusiveLevel);

                AlarmHolder mandatoryDerivedExclusiveLevel = new DerivedExclusiveLevelHolder(
                    this,
                    unitFolder,
                    analogSourceController,
                    mandatoryName,
                    GetSupportedAlarmConditionType(ref conditionTypeIndex),
                    controllerType,
                    interval,
                    optional: false);

                m_alarms.Add(mandatoryDerivedExclusiveLevel.AlarmNodeName, mandatoryDerivedExclusiveLevel);

                AlarmHolder optionalDerivedExclusiveLevel = new DerivedExclusiveLevelHolder(
                    this,
                    unitFolder,
                    analogSourceController,
                    optionalName,
                    GetSupportedAlarmConditionType(ref conditionTypeIndex),
                    controllerType,
                    interval,
                    optional: true);
                m_alarms.Add(optionalDerivedExclusiveLevel.AlarmNodeName, optionalDerivedExclusiveLevel);

                AlarmHolder exclusiveRateOfChange = new ExclusiveRateOfChangeHolder(
                    this,
                    unitFolder,
                    rateOfChangeSourceController,
                    intervalString,
                    GetSupportedAlarmConditionType(ref conditionTypeIndex),
                    controllerType,
                    interval,
                    optional: GetUseOptional(unitName, ref useOptional));
                m_alarms.Add(exclusiveRateOfChange.AlarmNodeName, exclusiveRateOfChange);

                AlarmHolder exclusiveDeviation = new ExclusiveDeviationHolder(
                    this,
                    unitFolder,
                    deviationSourceController,
                    intervalString,
                    GetSupportedAlarmConditionType(ref conditionTypeIndex),
                    controllerType,
                    interval,
                    deviationSetpoint.NodeId,
                    optional: GetUseOptional(unitName, ref useOptional));
                m_alarms.Add(exclusiveDeviation.AlarmNodeName, exclusiveDeviation);

                AlarmHolder mandatoryNonExclusiveLimit = new NonExclusiveLimitHolder(
                    this,
                    unitFolder,
                    analogSourceController,
                    mandatoryName,
                    GetSupportedAlarmConditionType(ref conditionTypeIndex),
                    controllerType,
                    interval,
                    optional: false);
                m_alarms.Add(mandatoryNonExclusiveLimit.AlarmNodeName, mandatoryNonExclusiveLimit);

                AlarmHolder optionalNonExclusiveLimit = new NonExclusiveLimitHolder(
                    this,
                    unitFolder,
                    analogSourceController,
                    optionalName,
                    GetSupportedAlarmConditionType(ref conditionTypeIndex),
                    controllerType,
                    interval,
                    optional: true);
                m_alarms.Add(optionalNonExclusiveLimit.AlarmNodeName, optionalNonExclusiveLimit);

                AlarmHolder mandatoryNonExclusiveLevel = new NonExclusiveLevelHolder(
                    this,
                    unitFolder,
                    analogSourceController,
                    mandatoryName,
                    GetSupportedAlarmConditionType(ref conditionTypeIndex),
                    controllerType,
                    interval,
                    optional: false);
                m_alarms.Add(mandatoryNonExclusiveLevel.AlarmNodeName, mandatoryNonExclusiveLevel);

                AlarmHolder optionalNonExclusiveLevel = new NonExclusiveLevelHolder(
                    this,
                    unitFolder,
                    analogSourceController,
                    optionalName,
                    GetSupportedAlarmConditionType(ref conditionTypeIndex),
                    controllerType,
                    interval,
                    optional: true);
                m_alarms.Add(optionalNonExclusiveLevel.AlarmNodeName, optionalNonExclusiveLevel);

                AlarmHolder mandatoryDerivedNonExclusiveLevel = new DerivedNonExclusiveLevelHolder(
                    this,
                    unitFolder,
                    analogSourceController,
                    mandatoryName,
                    GetSupportedAlarmConditionType(ref conditionTypeIndex),
                    controllerType,
                    interval,
                    optional: false);
                m_alarms.Add(mandatoryDerivedNonExclusiveLevel.AlarmNodeName, mandatoryDerivedNonExclusiveLevel);

                AlarmHolder optionalDerivedNonExclusiveLevel = new DerivedNonExclusiveLevelHolder(
                    this,
                    unitFolder,
                    analogSourceController,
                    optionalName,
                    GetSupportedAlarmConditionType(ref conditionTypeIndex),
                    controllerType,
                    interval,
                    optional: true);
                m_alarms.Add(optionalDerivedNonExclusiveLevel.AlarmNodeName, optionalDerivedNonExclusiveLevel);

                AlarmHolder nonExclusiveRateOfChange = new NonExclusiveRateOfChangeHolder(
                    this,
                    unitFolder,
                    rateOfChangeSourceController,
                    intervalString,
                    GetSupportedAlarmConditionType(ref conditionTypeIndex),
                    controllerType,
                    interval,
                    optional: GetUseOptional(unitName, ref useOptional));
                m_alarms.Add(nonExclusiveRateOfChange.AlarmNodeName, nonExclusiveRateOfChange);

                AlarmHolder nonExclusiveDeviation = new NonExclusiveDeviationHolder(
                    this,
                    unitFolder,
                    deviationSourceController,
                    intervalString,
                    GetSupportedAlarmConditionType(ref conditionTypeIndex),
                    controllerType,
                    interval,
                    deviationSetpoint.NodeId,
                    optional: GetUseOptional(unitName, ref useOptional));
                m_alarms.Add(nonExclusiveDeviation.AlarmNodeName, nonExclusiveDeviation);


                AlarmHolder offNormal = new OffNormalAlarmTypeHolder(
                    this,
                    unitFolder,
                    booleanSourceController,
                    intervalString,
                    GetSupportedAlarmConditionType(ref conditionTypeIndex),
                    controllerType,
                    interval,
                    optional: GetUseOptional(unitName, ref useOptional));
                m_alarms.Add(offNormal.AlarmNodeName, offNormal);

                AlarmHolder systemOff = new SystemOffNormalAlarmTypeHolder(
                    this,
                    unitFolder,
                    booleanSourceController,
                    intervalString,
                    GetSupportedAlarmConditionType(ref conditionTypeIndex),
                    controllerType,
                    interval,
                    optional: GetUseOptional(unitName, ref useOptional));
                m_alarms.Add(systemOff.AlarmNodeName, systemOff);


                AlarmHolder derivedSystemOff = new DerivedSystemOffNormalAlarmTypeHolder(
                    this,
                    unitFolder,
                    booleanSourceController,
                    intervalString,
                    GetSupportedAlarmConditionType(ref conditionTypeIndex),
                    controllerType,
                    interval,
                    optional: GetUseOptional(unitName, ref useOptional));
                m_alarms.Add(derivedSystemOff.AlarmNodeName, derivedSystemOff);


                Debug.WriteLine("Completed alarms for " + unitName);

            }

            m_allowEntry = true;

        }

        public void CreateTestItems( FolderState alarmsFolder)
        {
            BaseDataVariableState sawtooth = Helpers.CreateVariable(alarmsFolder, NameSpaceIndex, "Sawtooth", "Sawtooth");
            sawtooth.AccessLevel = AccessLevels.CurrentRead;
            sawtooth.UserAccessLevel = AccessLevels.CurrentRead;

            m_sine = Helpers.CreateVariable(alarmsFolder, NameSpaceIndex, "Sine", "Sine", Opc.Ua.DataTypes.Double);
            m_sine.AccessLevel = AccessLevels.CurrentRead;
            m_sine.UserAccessLevel = AccessLevels.CurrentRead;

            m_differential = Helpers.CreateVariable(alarmsFolder, NameSpaceIndex, "Differential", "Differential", Opc.Ua.DataTypes.Double);
            m_differential.AccessLevel = AccessLevels.CurrentRead;
            m_differential.UserAccessLevel = AccessLevels.CurrentRead;

            Type alarmControllerType = Type.GetType("Quickstarts.ReferenceServer.AlarmController");
            int defaultInterval = 1000;
            string defaultIntervalString = defaultInterval.ToString();

            AlarmController alarmController = (AlarmController)Activator.CreateInstance(alarmControllerType, sawtooth, defaultInterval, false);
            m_sineController = new SourceController(sawtooth, alarmController);
            m_sineController.Controller.Start();
            m_sineRestart = DateTime.Now.AddSeconds(150);
        }

        public SupportedAlarmConditionType GetSupportedAlarmConditionType( ref int index )
        {
            SupportedAlarmConditionType conditionType = m_ConditionTypes[index];
            index++;
            if ( index >= m_ConditionTypes.Length )
            {
                index = 0;
            }
            return conditionType;
        }

        public bool GetUseOptional(string unitName, ref bool optional )
        {
            bool returnValue = optional;
            if (unitName == "Confirm" || unitName == "ExclusiveLevel" )
            {
                returnValue = true;
            }
            else if ( unitName == "Acknowledge" )
            {
                returnValue = false;
            }
            else
            {
                optional = !optional;
            }
            return returnValue;
        }

        public NodeState GetAlarmNodeState( NodeHandle handle )
        {
            NodeState alarmState = null;

            NodeId handleNodeId = handle.NodeId;
            if ( handleNodeId.IdType == IdType.String )
            {
                string nodeString = (string)handleNodeId.Identifier;
            }

            return alarmState;
        }

        public NodeHandle FindBranchNodeHandle(ISystemContext systemContext, NodeHandle initialHandle, CallMethodRequest methodToCall)
        {
            NodeHandle nodeHandle = initialHandle;

            if ( IsAckConfirm( methodToCall.MethodId ) )
            {
                AlarmHolder holder = GetAlarmHolder(methodToCall.ObjectId);

                if ( holder != null )
                {
                    if ( holder.HasBranches() )
                    {
                        byte[] eventId = GetEventIdFromAckConfirmMethod(methodToCall);

                        if ( eventId != null )
                        {
                            BaseEventState state = holder.GetBranch(eventId);

                            if ( state != null )
                            {
                                nodeHandle = new NodeHandle();

                                nodeHandle.NodeId = methodToCall.ObjectId;
                                nodeHandle.Node = state;
                                nodeHandle.Validated = true;
                            }
                        }
                    }
                }
            }

            return nodeHandle;
        }

        private bool IsAckConfirm( NodeId methodId )
        {
            bool isAckConfirm = false;
            if ( methodId.Equals( Opc.Ua.MethodIds.AcknowledgeableConditionType_Acknowledge ) ||
                 methodId.Equals(Opc.Ua.MethodIds.AcknowledgeableConditionType_Confirm))
            {
                isAckConfirm = true;

            }
            return isAckConfirm;
        }

        private byte[] GetEventIdFromAckConfirmMethod( CallMethodRequest request)
        {
            byte[] eventId = null;

            // Bad magic Numbers here
            if ( request.InputArguments != null && request.InputArguments.Count == 2 )
            {
                if ( request.InputArguments[0].TypeInfo.BuiltInType.Equals( BuiltInType.ByteString ) )
                {
                    eventId = (byte[])request.InputArguments[0].Value;
                }
            }
            return eventId;
        }

        public void GetBranchesForConditionRefresh(List<IFilterTarget> events)
        {
            // Don't look at Certificates, they won't have branches
            foreach( AlarmHolder alarmHolder in m_alarms.Values )
            {
                alarmHolder.GetBranchesForConditionRefresh(events);
            }
        }


        private int m_missed = 0;
        private int m_success = 0;


        public void Loop()
        {
            if (m_allowEntry)
            {
                m_allowEntry = false;

                lock (m_alarms)
                {
                    m_success++;
                    try
                    {
                        foreach( Dictionary<string, SourceController> map in m_triggerMap.Values )
                        {
                            foreach( SourceController controller in map.Values )
                            {
                                bool updated = controller.Controller.Update(GetNodeManager().SystemContext);

                                IList<IReference> references = new List<IReference>();
                                controller.Source.GetReferences(GetNodeManager().SystemContext, references, ReferenceTypes.HasCondition, false);
                                foreach( IReference reference in references)
                                {
                                    string identifier = (string)reference.TargetId.ToString();
                                    if( m_alarms.ContainsKey( identifier ))
                                    {
                                        AlarmHolder holder = m_alarms[identifier];
                                        holder.Update(updated);
                                    }
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine("Loop Exception " + ex.Message);

                    }

                    if (m_sineController != null)
                    {
                        if (DateTime.Now > m_sineRestart)
                        {
                            m_sineController.Controller.Start();
                            m_sineRestart = DateTime.Now.AddSeconds(150);
                        }

                        if (m_sineController.Controller.Update(GetNodeManager().SystemContext))
                        {
                            if (m_runTest)
                            {
                                //m_sineController.Controller.Test();
                            }

                            double value = (double)m_sineController.Controller.GetValue();
                            double sine = 100 * Math.Sin(value) + 50;
                            m_sine.Value = sine;
                            m_differential.Value = Math.Abs(value - sine);

                            // Sine wave function y = Amplitude * sine( WaveNumber( x - Horizontal ) ) + Vertical )
                            // y = 100( ( x ) ) )
                            m_sine.Timestamp = DateTime.UtcNow;
                            m_sine.ClearChangeMasks(GetNodeManager().SystemContext, false);

                            //                        m_differential.Value = m_sine.Value;
                            m_differential.Timestamp = DateTime.UtcNow;
                            m_differential.ClearChangeMasks(GetNodeManager().SystemContext, false);
                        }
                    }

                }
                m_allowEntry = true;
            }
            else
            {
                if (m_success > 0)
                {
                    m_missed++; 
                    Debug.WriteLine(DateTime.UtcNow.ToLocalTime().ToLongTimeString() + " Missed Loop " + m_missed.ToString() + " Success " + m_success.ToString() );
                }
            }
        }

        public ServiceResult OnWriteAlarmTrigger(
            ISystemContext context,
            NodeState node,
            NumericRange indexRange,
            QualifiedName dataEncoding,
            ref object value,
            ref StatusCode statusCode,
            ref DateTime timestamp)
        {
            Dictionary<string, SourceController> sourceControllers = GetUnitAlarms(node);
            if (sourceControllers == null)
            {
                return StatusCodes.BadNodeIdUnknown;
            }

            if (sourceControllers != null)
            {
                SourceController sourceController = GetSourceControllerFromNodeState(node, sourceControllers);

                if ( sourceController == null )
                {
                    return StatusCodes.BadNodeIdUnknown;
                }

                GetNodeManager().m_logger.Information("Manual Write " + value.ToString() + " to " + node.NodeId.ToString() );

                lock (m_alarms)
                {
                    sourceController.Source.Value = value;
                    Type valueType = value.GetType();
                    sourceController.Controller.ManualWrite(value);
                    IList<IReference> references = new List<IReference>();
                    sourceController.Source.GetReferences(GetNodeManager().SystemContext, references, ReferenceTypes.HasCondition, false);
                    foreach (IReference reference in references)
                    {
                        string identifier = (string)reference.TargetId.ToString();
                        if (m_alarms.ContainsKey(identifier))
                        {
                            AlarmHolder holder = m_alarms[identifier];
                            holder.Update(true);
                        }
                    }
                }
            }

            return Opc.Ua.StatusCodes.Good;
        }


        public void OnStateChanged(
            ISystemContext context,
            NodeState node,
            NodeStateChangeMasks changeMasks)
        {
            AlarmHolder alarmHolder = GetAlarmHolder(node);
            if ( alarmHolder != null )
            {
                bool waiting = true;
            }
        }

        public ServiceResult OnEnableAutoRun(
            ISystemContext context,
            NodeState node,
            IList<object> inputArguments,
            IList<object> outputArguments)
        {
            return ServiceResult.Good;
        }

        public ServiceResult OnDisableAutoRun(
            ISystemContext context,
            NodeState node,
            IList<object> inputArguments,
            IList<object> outputArguments)
        {
            return ServiceResult.Good;
        }

        public ServiceResult OnSetCertificates(
            ISystemContext context,
            NodeState node,
            IList<object> inputArguments,
            IList<object> outputArguments)
        {
            m_outside.Set();
            m_inside.Set();
            m_expired.Set();
            return ServiceResult.Good;
        }

        public ServiceResult OnResetCertificates(
            ISystemContext context,
            NodeState node,
            IList<object> inputArguments,
            IList<object> outputArguments)
        {
            m_outside.Reset();
            m_inside.Reset();
            m_expired.Reset();

            return ServiceResult.Good;
        }

        public ServiceResult OnResetOutsideCertificate(
            ISystemContext context,
            NodeState node,
            IList<object> inputArguments,
            IList<object> outputArguments)
        {
            m_outside.Reset();

            return ServiceResult.Good;
        }

        public ServiceResult OnResetInsideCertificate(
            ISystemContext context,
            NodeState node,
            IList<object> inputArguments,
            IList<object> outputArguments)
        {
            m_inside.Reset();

            return ServiceResult.Good;
        }

        public ServiceResult OnResetExpiredCertificate(
            ISystemContext context,
            NodeState node,
            IList<object> inputArguments,
            IList<object> outputArguments)
        {
            m_expired.Reset();

            return ServiceResult.Good;
        }

        public ServiceResult OnClearBranches(
            ISystemContext context,
            NodeState node,
            IList<object> inputArguments,
            IList<object> outputArguments)
        {
            lock (m_alarms)
            {
                foreach( AlarmHolder alarmHolder in m_alarms.Values )
                {
                    alarmHolder.ClearBranches();
                }
            }

            return ServiceResult.Good;
        }





        private AlarmHolder GetAlarmHolder(NodeState node)
        {
            return GetAlarmHolder(node.NodeId);
        }

        private AlarmHolder GetAlarmHolder( NodeId node )
        {

            AlarmHolder alarmHolder = null;

            Type nodeIdType = node.Identifier.GetType();
            if (nodeIdType.Name == "String")
            {
                string unmodifiedName = node.Identifier.ToString();

                // This is bad, but I'm not sure why the NodeName is being attached with an underscore, it messes with this lookup.
                string name = unmodifiedName.Replace("Alarms_", "Alarms.");

                string mapName = name;
                if ( name.EndsWith(Defines.TRIGGER_EXTENSION ) || name.EndsWith( Defines.ALARM_EXTENSION ) )
                {
                    int lastDot = name.LastIndexOf(".");
                    mapName = name.Substring(0, lastDot);
                }
                
                if (m_alarms.ContainsKey(mapName))
                {
                    alarmHolder = m_alarms[mapName];
                }
            }

            return alarmHolder;
        }


        public ServiceResult OnEnableDisableAlarm(
            ISystemContext context,
            ConditionState condition,
            bool enabling)
        {
            return ServiceResult.Good;
        }

        public Dictionary<string, SourceController> GetUnitAlarms( NodeState nodeState )
        {
            Dictionary<string, SourceController> alarms = null;

            string unit = GetUnitFromNodeState(nodeState);

            if (m_triggerMap.ContainsKey(unit))
            {
                alarms = m_triggerMap[unit];
            }

            return alarms;
        }


        public string GetUnitFromNodeState( NodeState nodeState )
        {
            return GetUnitFromNodeId(nodeState.NodeId);
        }

        public string GetUnitFromNodeId( NodeId nodeId )
        {
            string unit = "";

            if (nodeId.IdType == IdType.String)
            {
                string nodeIdString = (string)nodeId.Identifier;
                string[] splitString = nodeIdString.Split('.');
                // Alarms.UnitName.MethodName
                if ( splitString.Length >= 1 )
                {
                    unit = splitString[1];
                }
            }

            return unit;
        }

        public SourceController GetSourceControllerFromNodeState( NodeState nodeState, Dictionary<string, SourceController> map )
        {
            SourceController sourceController = null;

            string name = GetSourceNameFromNodeState(nodeState);
            if ( map.ContainsKey( name ) )
            {
                sourceController = map[name];
            }

            return sourceController;
        }

        public string GetSourceNameFromNodeState( NodeState nodeState )
        {
            return GetSourceNameFromNodeId(nodeState.NodeId);
        }

        public string GetSourceNameFromNodeId(NodeId nodeId)
        {
            string sourceName = "";

            if (nodeId.IdType == IdType.String)
            {
                string nodeIdString = (string)nodeId.Identifier;
                string[] splitString = nodeIdString.Split('.');
                // Alarms.UnitName.AnalogSource
                if (splitString.Length >= 2)
                {
                    sourceName = splitString[splitString.Length-1].Replace("Source", "");
                }
            }

            return sourceName;


        }

        public ServiceResult OnStart(
            ISystemContext context,
            NodeState node,
            IList<object> inputArguments,
            IList<object> outputArguments)
        {
            ServiceResult result = ServiceResult.Good;

            Dictionary<string, SourceController> sourceControllers = GetUnitAlarms(node);
            if (sourceControllers == null )
            {
                result = StatusCodes.BadNodeIdUnknown;
            }

            if (sourceControllers != null )
            {
                GetNodeManager().m_logger.Information("Starting up alarm group " + GetUnitFromNodeId(node.NodeId));

                lock (m_alarms)
                {
                    foreach (SourceController sourceController in sourceControllers.Values)
                    {
                        IList<IReference> references = new List<IReference>();
                        sourceController.Source.GetReferences(GetNodeManager().SystemContext, references, ReferenceTypes.HasCondition, false);
                        foreach (IReference reference in references)
                        {
                            string identifier = (string)reference.TargetId.ToString();
                            if (m_alarms.ContainsKey(identifier))
                            {
                                AlarmHolder holder = m_alarms[identifier];
                                holder.Start();
                                bool updated = holder.Controller.Update(GetNodeManager().SystemContext);
                                holder.Update(updated);
                            }
                        }
                    }
                }
            }

           
            return result;
        }

        public ServiceResult OnEnd(
            ISystemContext context,
            NodeState node,
            IList<object> inputArguments,
            IList<object> outputArguments)
        {
            ServiceResult result = ServiceResult.Good;

            Dictionary<string, SourceController> sourceControllers = GetUnitAlarms(node);
            if (sourceControllers == null)
            {
                result = StatusCodes.BadNodeIdUnknown;
            }

            if (sourceControllers != null)
            {
                GetNodeManager().m_logger.Information("Stopping alarm group " + GetUnitFromNodeId(node.NodeId));

                lock (m_alarms)
                {
                    foreach (SourceController sourceController in sourceControllers.Values)
                    {
                        IList<IReference> references = new List<IReference>();
                        sourceController.Source.GetReferences(GetNodeManager().SystemContext, references, ReferenceTypes.HasCondition, false);
                        foreach (IReference reference in references)
                        {
                            string identifier = (string)reference.TargetId.ToString();
                            if (m_alarms.ContainsKey(identifier))
                            {
                                AlarmHolder holder = m_alarms[identifier];
                                holder.ClearBranches();
                            }
                        }

                        sourceController.Controller.Stop();
                    }
                }
            }

            return result;
        }

    }
}
