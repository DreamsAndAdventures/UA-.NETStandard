
using System;
using System.Collections.Generic;
using System.Diagnostics;

using Opc.Ua;
using Opc.Ua.Server;

#pragma warning disable CS0219

#pragma warning disable CS1591

namespace DreamsAndAdventures.ReferenceServer
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
            "NonExclusiveRateOfChange",
            "Branch",
            "Instances"
        };

        private SupportedAlarmConditionType[] m_ConditionTypes = {
                    new SupportedAlarmConditionType( "Process", "ProcessConditionClassType",  ObjectTypeIds.ProcessConditionClassType ),
                    new SupportedAlarmConditionType( "Maintenance", "MaintenanceConditionClassType",  ObjectTypeIds.MaintenanceConditionClassType ),
                    new SupportedAlarmConditionType( "System", "SystemConditionClassType",  ObjectTypeIds.SystemConditionClassType ) };

        public Alarms(ReferenceNodeManager nodeManager)
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

            Type alarmControllerType = Type.GetType("DreamsAndAdventures.ReferenceServer.AlarmController");
            int defaultInterval = 1000;
            string defaultIntervalString = defaultInterval.ToString();

            int conditionTypeIndex = 0;
            bool useOptional = true;
            foreach (string unitName in m_conformanceUnits)
            {
                bool branch = false;
                if (unitName == "Branch")
                {
                    branch = true;
                }

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

                bool createAll = true;
                bool justOne = false;
                if ( justOne )
                {
                    useOptional = false;
                }

                if (unitName == "Acknowledge")
                {
                    controllerType = Type.GetType("DreamsAndAdventures.ReferenceServer.AcknowledgeableTestAlarmController");
                }
                else if (unitName == "Confirm" || unitName == "Comment")
                {
                    controllerType = Type.GetType("DreamsAndAdventures.ReferenceServer.ConfirmTestAlarmController");
                }
                else if (unitName == "Suppression" || unitName == "Shelve" )
                {
                    createAll = false;
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
                analogAlarmController.SupportsBranching = branch;
                SourceController analogSourceController = new SourceController(analogTrigger, analogAlarmController);
                triggerMap.Add("Analog", analogSourceController);

                string booleanTriggerName = "BooleanSource";
                string booleanTriggerNodeName = unitNodeName + "." + booleanTriggerName;
                BaseDataVariableState booleanTrigger = Helpers.CreateVariable(unitFolder,
                    NameSpaceIndex, booleanTriggerNodeName, booleanTriggerName, boolValue: true);
                booleanTrigger.OnWriteValue = OnWriteAlarmTrigger;
                AlarmController booleanAlarmController = (AlarmController)Activator.CreateInstance(controllerType, booleanTrigger, interval, true);
                //booleanAlarmController.SupportsBranching = branch;
                SourceController booleanSourceController = new SourceController(booleanTrigger, booleanAlarmController);
                triggerMap.Add("Boolean", booleanSourceController);

                string deviationTriggerName = "DeviationSource";
                string deviationTriggerNodeName = unitNodeName + "." + deviationTriggerName;
                BaseDataVariableState deviationTrigger = Helpers.CreateVariable(unitFolder,
                    NameSpaceIndex, deviationTriggerNodeName, deviationTriggerName);
                analogTrigger.OnWriteValue = OnWriteAlarmTrigger;
                Type deviationControllerType = Type.GetType("DreamsAndAdventures.ReferenceServer.DeviationController");
                AlarmController deviationAlarmController = (AlarmController)Activator.CreateInstance(deviationControllerType, deviationTrigger, interval, false);
                //deviationAlarmController.SupportsBranching = branch;
                SourceController deviationSourceController = new SourceController(deviationTrigger, deviationAlarmController);
                triggerMap.Add("Deviation", deviationSourceController);

                int rateOfChangeInterval = interval;

                string rateOfChangeTriggerName = "RateOfChangeSource";
                string rateOfChangeTriggerNodeName = unitNodeName + "." + rateOfChangeTriggerName;

                // http://www.opcfoundation.org/UA/EngineeringUnits/UNECE/rec20_latest_08052015.zip
                // http://www.opcfoundation.org/UA/EngineeringUnits/UNECE/UNECE_to_OPCUA.csv
                EUInformation euInformation = new EUInformation("rad/s", "radian per second", "http://www.opcfoundation.org/UA/units/un/cefact");
                euInformation.UnitId = 12865; // "2A"	

                AnalogItemState rateOfChangeTrigger = m_nodeManager.CreateRateOfChangeSource(
                    unitFolder, rateOfChangeTriggerNodeName, rateOfChangeTriggerName, (uint)BuiltInType.Int32, ValueRanks.Scalar,
                    euInformation);
                rateOfChangeTrigger.OnWriteValue = OnWriteAlarmTrigger;

                Type rateOfChangeControllerType = Type.GetType("DreamsAndAdventures.ReferenceServer.RateOfChangeController");
                AlarmController rateOfChangeAlarmController = (AlarmController)Activator.CreateInstance(
                    rateOfChangeControllerType, rateOfChangeTrigger, rateOfChangeInterval, false);
                rateOfChangeAlarmController.SupportsBranching = branch;
                SourceController rateOfChangeSourceController = new SourceController(rateOfChangeTrigger, rateOfChangeAlarmController);
                triggerMap.Add("RateOfChange", rateOfChangeSourceController);

                // Deviation Setpoint
                string deviationSetpointName = "DeviationSetpoint";
                string deviationSetpointNodeName = unitNodeName + "." + deviationSetpointName;

                BaseDataVariableState deviationSetpoint = Helpers.CreateVariable(unitFolder, NameSpaceIndex, deviationSetpointNodeName, deviationSetpointName);
                deviationSetpoint.AccessLevel = AccessLevels.CurrentRead;
                deviationSetpoint.UserAccessLevel = AccessLevels.CurrentRead;
                deviationSetpoint.Value = Defines.NORMAL_START_VALUE;

                string optionalName = intervalString + "Optional";
                string mandatoryName = intervalString + "Mandatory";


                if (createAll)
                {
                    if (!justOne)
                    {
                        AlarmHolder ackAlarmType = new AcknowledgeableConditionTypeHolder(
                            this,
                            unitFolder,
                            analogSourceController,
                            intervalString,
                            GetSupportedAlarmConditionType(ref conditionTypeIndex),
                            controllerType,
                            interval,
                            optional: GetUseOptional(unitName, ref useOptional));
                        m_alarms.Add(ackAlarmType.AlarmNodeName, ackAlarmType);
                    }

                    AlarmHolder alarmConditionType = new AlarmConditionTypeHolder(
                        this,
                        unitFolder,
                        analogSourceController,
                        intervalString,
                        GetSupportedAlarmConditionType(ref conditionTypeIndex),
                        controllerType,
                        interval,
                        optional: GetUseOptional(unitName, ref useOptional));
                    m_alarms.Add(alarmConditionType.AlarmNodeName, alarmConditionType);


                    if (!justOne)
                    {
                        // Discrepancy TargetValue NodeId
                        string discrepancyName = Defines.DISCREPANCY_TARGET_NAME;
                        string discrepancyNodeId = unitNodeName + "." + discrepancyName;
                        BaseDataVariableState discrepancyTargetValue = Helpers.CreateVariable(unitFolder, NameSpaceIndex, discrepancyNodeId, discrepancyName);
                        discrepancyTargetValue.AccessLevel = AccessLevels.CurrentRead;
                        discrepancyTargetValue.UserAccessLevel = AccessLevels.CurrentRead;
                        discrepancyTargetValue.Value = Defines.NORMAL_START_VALUE;

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

                        // There is a real question about systemOffNormal - should it be abstract.
                        // I think the answer is yes, spec says no, Nodeset says no, but .net core says yes.
                        // DisplayName>SystemOffNormalAlarmType</DisplayName>
                        //     < Documentation > https://reference.opcfoundation.org/v104/Core/docs/Part9/5.8.17/#5.8.17.3</Documentation>
                        //AlarmHolder systemOff = new SystemOffNormalAlarmTypeHolder(
                        //    this,
                        //    unitFolder,
                        //    booleanSourceController,
                        //    intervalString,
                        //    GetSupportedAlarmConditionType(ref conditionTypeIndex),
                        //    controllerType,
                        //    interval,
                        //    optional: GetUseOptional(unitName, ref useOptional));
                        //m_alarms.Add(systemOff.AlarmNodeName, systemOff);


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
                    }
                }

                if (unitName.Contains("RateOfChange"))
                {
                    string rateOfChangeIntervalString = rateOfChangeInterval.ToString();
                    string mandatoryRateOfChange = rateOfChangeIntervalString + "Mandatory";
                    string optionalRateOfChange = rateOfChangeIntervalString + "Optional";

                    AlarmHolder exclusiveRateOfChangeMandatory = new ExclusiveRateOfChangeHolder(
                            this,
                            unitFolder,
                            rateOfChangeSourceController,
                            mandatoryRateOfChange,
                            GetSupportedAlarmConditionType(ref conditionTypeIndex),
                            rateOfChangeControllerType,
                            rateOfChangeInterval,
                            optional: false);
                    m_alarms.Add(exclusiveRateOfChangeMandatory.AlarmNodeName, exclusiveRateOfChangeMandatory);

                    AlarmHolder exclusiveRateOfChangeOptional = new ExclusiveRateOfChangeHolder(
                        this,
                        unitFolder,
                        rateOfChangeSourceController,
                        optionalRateOfChange,
                        GetSupportedAlarmConditionType(ref conditionTypeIndex),
                        rateOfChangeControllerType,
                        rateOfChangeInterval,
                        optional: true);
                    m_alarms.Add(exclusiveRateOfChangeOptional.AlarmNodeName, exclusiveRateOfChangeOptional);

                    AlarmHolder nonExclusiveRateOfChangeMandatory = new NonExclusiveRateOfChangeHolder(
                        this,
                        unitFolder,
                        rateOfChangeSourceController,
                        mandatoryRateOfChange,
                        GetSupportedAlarmConditionType(ref conditionTypeIndex),
                        rateOfChangeControllerType,
                        rateOfChangeInterval,
                        optional: false);
                    m_alarms.Add(nonExclusiveRateOfChangeMandatory.AlarmNodeName, nonExclusiveRateOfChangeMandatory);

                    AlarmHolder nonExclusiveRateOfChangeOptional = new NonExclusiveRateOfChangeHolder(
                        this,
                        unitFolder,
                        rateOfChangeSourceController,
                        optionalRateOfChange,
                        GetSupportedAlarmConditionType(ref conditionTypeIndex),
                        rateOfChangeControllerType,
                        rateOfChangeInterval,
                        optional: true);
                    m_alarms.Add(nonExclusiveRateOfChangeOptional.AlarmNodeName, nonExclusiveRateOfChangeOptional);

                }

                if (unitName.Contains("Deviation"))
                {
                    Type deviationController = Type.GetType("DreamsAndAdventures.ReferenceServer.DeviationController");

                    AlarmHolder exclusiveMandatoryDeviation = new ExclusiveDeviationHolder(
                        this,
                        unitFolder,
                        deviationSourceController,
                        mandatoryName,
                        GetSupportedAlarmConditionType(ref conditionTypeIndex),
                        deviationController,
                        interval,
                        deviationSetpoint,
                        optional: false);
                    m_alarms.Add(exclusiveMandatoryDeviation.AlarmNodeName, exclusiveMandatoryDeviation);


                    AlarmHolder exclusiveOptionalDeviation = new ExclusiveDeviationHolder(
                        this,
                        unitFolder,
                        deviationSourceController,
                        optionalName,
                        GetSupportedAlarmConditionType(ref conditionTypeIndex),
                        deviationController,
                        interval,
                        deviationSetpoint,
                        optional: true);
                    m_alarms.Add(exclusiveOptionalDeviation.AlarmNodeName, exclusiveOptionalDeviation);

                    // Deviation alarms change way to fast for the conformance units to handle it properly.
                    AlarmHolder nonExclusiveMandatoryDeviation = new NonExclusiveDeviationHolder(
                        this,
                        unitFolder,
                        deviationSourceController,
                        mandatoryName,
                        GetSupportedAlarmConditionType(ref conditionTypeIndex),
                        deviationController,
                        interval,
                        deviationSetpoint,
                        optional: false);
                    m_alarms.Add(nonExclusiveMandatoryDeviation.AlarmNodeName, nonExclusiveMandatoryDeviation);

                    AlarmHolder nonExclusiveOptionalDeviation = new NonExclusiveDeviationHolder(
                        this,
                        unitFolder,
                        deviationSourceController,
                        optionalName,
                        GetSupportedAlarmConditionType(ref conditionTypeIndex),
                        deviationController,
                        interval,
                        deviationSetpoint,
                        optional: true);
                    m_alarms.Add(nonExclusiveOptionalDeviation.AlarmNodeName, nonExclusiveOptionalDeviation);

                }

                if (unitName.Contains("Suppression"))
                {
                    string unsuppressActiveTriggerName = "UnsuppressActiveSource";
                    string unsuppressActiveTriggerNodeName = unitNodeName + "." + unsuppressActiveTriggerName;
                    BaseDataVariableState unsuppressActiveTrigger = Helpers.CreateVariable(unitFolder,
                        NameSpaceIndex, unsuppressActiveTriggerNodeName, unsuppressActiveTriggerName);
                    unsuppressActiveTrigger.OnWriteValue = OnWriteAlarmTrigger;

                    Type unsuppressActiveControllerType = Type.GetType("DreamsAndAdventures.ReferenceServer.SuppressWhileActiveAlarmController");

                    AlarmController unsuppressActiveController = (AlarmController)Activator.CreateInstance(
                        unsuppressActiveControllerType, unsuppressActiveTrigger, interval, false);
                    SourceController unsuppressActiveSourceController = new SourceController(unsuppressActiveTrigger, unsuppressActiveController);
                    triggerMap.Add("UnsuppressActiveAnalog", unsuppressActiveSourceController);

                    AlarmHolder unsuppressActiveAlarmConditionType = new AlarmConditionTypeHolder(
                        this,
                        unitFolder,
                        unsuppressActiveSourceController,
                        "UnsuppressActive" + intervalString,
                        GetSupportedAlarmConditionType(ref conditionTypeIndex),
                        unsuppressActiveControllerType,
                        interval,
                        optional: true);
                    m_alarms.Add(unsuppressActiveAlarmConditionType.AlarmNodeName, unsuppressActiveAlarmConditionType);


                    string unsuppressInactiveTriggerName = "UnsuppressInactiveSource";
                    string unsuppressInactiveTriggerNodeName = unitNodeName + "." + unsuppressInactiveTriggerName;
                    BaseDataVariableState unsuppressInactiveTrigger = Helpers.CreateVariable(unitFolder,
                        NameSpaceIndex, unsuppressInactiveTriggerNodeName, unsuppressInactiveTriggerName);
                    unsuppressInactiveTrigger.OnWriteValue = OnWriteAlarmTrigger;

                    Type unsuppressInactiveControllerType = Type.GetType("DreamsAndAdventures.ReferenceServer.SuppressWhileInactiveAlarmController");

                    AlarmController unsuppressInactiveAlarmController = (AlarmController)Activator.CreateInstance(
                        unsuppressInactiveControllerType, unsuppressInactiveTrigger, interval, false);
                    SourceController unsuppressInactiveSourceController = new SourceController(unsuppressInactiveTrigger, unsuppressInactiveAlarmController);
                    triggerMap.Add("UnsuppressInactiveAnalog", unsuppressInactiveSourceController);

                    AlarmHolder unsuppressInactiveAlarmConditionType = new AlarmConditionTypeHolder(
                        this,
                        unitFolder,
                        unsuppressInactiveSourceController,
                        "UnsuppressInactive" + intervalString,
                        GetSupportedAlarmConditionType(ref conditionTypeIndex),
                        unsuppressInactiveControllerType,
                        interval,
                        optional: true);
                    m_alarms.Add(unsuppressInactiveAlarmConditionType.AlarmNodeName, unsuppressInactiveAlarmConditionType);

                }

                if ( unitName.Contains("Shelve"))
                {
                    // All Optional
                    // Need:
                    // Regular Analog 2

                    AlarmHolder alarmConditionType = new AlarmConditionTypeHolder(
                        this,
                        unitFolder,
                        analogSourceController,
                        optionalName,
                        GetSupportedAlarmConditionType(ref conditionTypeIndex),
                        controllerType,
                        interval,
                        optional: true);
                    m_alarms.Add(alarmConditionType.AlarmNodeName, alarmConditionType);

                    // Has no effect on Shelve testing, more of a test for something that should not work.
                    AlarmHolder mandatoryAlarmConditionType = new AlarmConditionTypeHolder(
                        this,
                        unitFolder,
                        analogSourceController,
                        mandatoryName,
                        GetSupportedAlarmConditionType(ref conditionTypeIndex),
                        controllerType,
                        interval,
                        optional: false);
                    m_alarms.Add(mandatoryAlarmConditionType.AlarmNodeName, mandatoryAlarmConditionType);

                    // Regular Boolean 2

                    AlarmHolder discrete = new DiscreteHolder(
                        this,
                        unitFolder,
                        booleanSourceController,
                        intervalString,
                        GetSupportedAlarmConditionType(ref conditionTypeIndex),
                        controllerType,
                        interval,
                        optional: true);
                    m_alarms.Add(discrete.AlarmNodeName, discrete);

                    string stayInAlarmName = "StayInAlarmSource";
                    string stayInAlarmNodeName = unitNodeName + "." + stayInAlarmName;
                    BaseDataVariableState stayInTrigger = Helpers.CreateVariable(unitFolder,
                        NameSpaceIndex, stayInAlarmNodeName, stayInAlarmName);
                    analogTrigger.OnWriteValue = OnWriteAlarmTrigger;
                    Type stayInAlarmControllerType = Type.GetType("DreamsAndAdventures.ReferenceServer.ChatterAlarmController");
                    AlarmController stayInAlarmController = (AlarmController)Activator.CreateInstance(stayInAlarmControllerType, stayInTrigger, interval, false);
                    analogAlarmController.SupportsBranching = branch;
                    SourceController stayInSourceController = new SourceController(stayInTrigger, stayInAlarmController);
                    triggerMap.Add("StayIn", stayInSourceController);

                    // Alarms that transition between Hi and HiHi Unchanged MaxShelve Time 3, 5, 7, 8, 9, 10

                    AlarmHolder mandatoryExclusiveLevel = new ExclusiveLevelHolder(
                        this,
                        unitFolder,
                        stayInSourceController,
                        stayInAlarmName,
                        GetSupportedAlarmConditionType(ref conditionTypeIndex),
                        stayInAlarmControllerType,
                        interval,
                        optional: true);

                    m_alarms.Add(mandatoryExclusiveLevel.AlarmNodeName, mandatoryExclusiveLevel);

                    AlarmHolder mandatoryNonExclusiveLevel = new NonExclusiveLevelHolder(
                        this,
                        unitFolder,
                        stayInSourceController,
                        stayInAlarmName,
                        GetSupportedAlarmConditionType(ref conditionTypeIndex),
                        stayInAlarmControllerType,
                        interval,
                        optional: true);

                    m_alarms.Add(mandatoryNonExclusiveLevel.AlarmNodeName, mandatoryNonExclusiveLevel);

                    // Alarms that transition between Hi and HiHi Reduced MaxShelve Time 4, 11

                    AlarmHolder mandatoryExclusiveLimit = new ExclusiveLimitHolder(
                        this,
                        unitFolder,
                        stayInSourceController,
                        stayInAlarmName + "Short",
                        GetSupportedAlarmConditionType(ref conditionTypeIndex),
                        stayInAlarmControllerType,
                        interval,
                        optional: true,
                        maxShelveTime: Defines.SHORT_MAX_TIME_SHELVED );

                    m_alarms.Add(mandatoryExclusiveLimit.AlarmNodeName, mandatoryExclusiveLimit);

                    AlarmHolder mandatoryNonExclusiveLimit = new NonExclusiveLimitHolder(
                        this,
                        unitFolder,
                        stayInSourceController,
                        stayInAlarmName + "Short",
                        GetSupportedAlarmConditionType(ref conditionTypeIndex),
                        stayInAlarmControllerType,
                        interval,
                        optional: true,
                        maxShelveTime: Defines.SHORT_MAX_TIME_SHELVED);

                    m_alarms.Add(mandatoryNonExclusiveLimit.AlarmNodeName, mandatoryNonExclusiveLimit);

                    // Steady Interval unchanged MaxShelveTime 6

                    string regularIntervalAlarmName = "RegularInterval";
                    string regularIntervalAlarmNodeName = unitNodeName + "." + regularIntervalAlarmName;
                    BaseDataVariableState regularIntervalTrigger = Helpers.CreateVariable(unitFolder,
                        NameSpaceIndex, regularIntervalAlarmNodeName, regularIntervalAlarmName);
                    analogTrigger.OnWriteValue = OnWriteAlarmTrigger;
                    Type regularIntervalAlarmControllerType = Type.GetType("DreamsAndAdventures.ReferenceServer.SteadyIntervalAlarmController");
                    int regularInterval = 4000;
                    AlarmController regularIntervalAlarmController = (AlarmController)Activator.CreateInstance(regularIntervalAlarmControllerType, regularIntervalTrigger, regularInterval, false);
                    analogAlarmController.SupportsBranching = branch;
                    SourceController regularIntervalSourceController = new SourceController(regularIntervalTrigger, regularIntervalAlarmController);
                    triggerMap.Add("RegularInterval", regularIntervalSourceController);

                    AlarmHolder regularIntervalAlarmConditionType = new AlarmConditionTypeHolder(
                        this,
                        unitFolder,
                        regularIntervalSourceController,
                        "RegularIntervalAnalog",
                        GetSupportedAlarmConditionType(ref conditionTypeIndex),
                        regularIntervalAlarmControllerType,
                        regularInterval,
                        optional: true);
                    m_alarms.Add(regularIntervalAlarmConditionType.AlarmNodeName, regularIntervalAlarmConditionType);
                }

                Debug.WriteLine("Completed alarms for " + unitName);
            }

            CheckAlarms(alarmsFolder);

            m_allowEntry = true;

        }

        public void CheckAlarms(FolderState alarmsFolder)
        {
            Dictionary<string, List<AlarmCheck>> alarmChecks = new Dictionary<string, List<AlarmCheck>>();

            Dictionary<string, AlarmHolder>.ValueCollection values = m_alarms.Values;
            ISystemContext systemContext = null;
            foreach( AlarmHolder alarmHolder  in m_alarms.Values )
            {
                systemContext = alarmHolder.SystemContext;
                break;
            }

            DialogConditionState dialog = new DialogConditionState(alarmsFolder);

            dialog.Create(systemContext, new NodeId("Dialog", NameSpaceIndex),
                new QualifiedName("Dialog", NameSpaceIndex),
                new LocalizedText("Dialog"), true);

            List<BaseInstanceState> dialogChildren = new List<BaseInstanceState>();

            dialog.GetChildren(systemContext, dialogChildren);

            CheckAlarms(systemContext, alarmChecks, dialog, dialogChildren);


            foreach ( AlarmHolder alarmHolder in m_alarms.Values )
            {
                BaseEventState alarm = alarmHolder.Alarm;

                List<BaseInstanceState> children = new List<BaseInstanceState>();

                alarm.GetChildren(alarmHolder.SystemContext, children);

                CheckAlarms(alarmHolder.SystemContext, alarmChecks, alarm, children);
            }
            foreach( KeyValuePair< string, List<AlarmCheck>> pair in alarmChecks)
            {
                List<AlarmCheck> checks = pair.Value;
                string methodName = pair.Key;

                //GetNodeManager().m_logger.Information( "Method " + pair.Key.ToString() + ":" + methodName 
                //    + " has " + pair.Value.Count.ToString() + " checks" );
                uint existsCount = 0;
                uint nonExistsCount = 0;
                List<string> nonExistingAlarms = new List<string>();
                foreach( AlarmCheck check in pair.Value )
                {
                    if ( check.Exists )
                    {
                        existsCount++;
                    }
                    else
                    {
                        nonExistsCount++;
                        nonExistingAlarms.Add(check.AlarmName);
                    }
                }

                if ( existsCount > 0 )
                {
                    foreach( string name in nonExistingAlarms )
                    {
                        GetNodeManager().m_logger.Information("Unexpected Method " + methodName + " Alarm " +
                            name + " doesn't exist when there are successes ");
                    }
                }

                GetNodeManager().m_logger.Information("Method " + pair.Key + " Exists " + existsCount + " Non " + nonExistsCount.ToString() );
            }
        }

        public void CheckAlarms(
            ISystemContext systemContext,
            Dictionary<string, List<AlarmCheck>> alarmChecks,
            BaseEventState alarm,
            List<BaseInstanceState> children )
        {
            foreach (BaseInstanceState child in children)
            {
                string name = child.SymbolicName;

                MethodState possibleMethod = child as MethodState;
                if (possibleMethod != null)
                {
                    AlarmCheck alarmCheck = new AlarmCheck();
                    alarmCheck.AlarmName = alarm.NodeId.ToString();
                    alarmCheck.MethodName = name;
                    alarmCheck.Exists = false;

                    NodeId methodDeclarationId = possibleMethod.MethodDeclarationId;
                    alarmCheck.MethodDeclarationId = methodDeclarationId;
                    if (methodDeclarationId != null && !methodDeclarationId.IsNullNodeId)
                    {
                        alarmCheck.Exists = true;
                    }

                    uint id = possibleMethod.NumericId;
                    if (!alarmChecks.ContainsKey(name))
                    {
                        List<AlarmCheck> list = new List<AlarmCheck>();
                        alarmChecks.Add(name, list);
                    }

                    List<AlarmCheck> checkList = alarmChecks[name];
                    checkList.Add(alarmCheck);
                }
                else
                {
                    List<BaseInstanceState> subChildren = new List<BaseInstanceState>();
                    child.GetChildren(systemContext, subChildren);
                    CheckAlarms(systemContext, alarmChecks, alarm, subChildren);
                }
            }

        }


        public void CreateTestItems(FolderState alarmsFolder)
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

            Type alarmControllerType = Type.GetType("DreamsAndAdventures.ReferenceServer.AlarmController");
            int defaultInterval = 1000;
            string defaultIntervalString = defaultInterval.ToString();

            AlarmController alarmController = (AlarmController)Activator.CreateInstance(alarmControllerType, sawtooth, defaultInterval, false);
            m_sineController = new SourceController(sawtooth, alarmController);
            m_sineController.Controller.Start();
            m_sineRestart = DateTime.Now.AddSeconds(150);
        }

        public SupportedAlarmConditionType GetSupportedAlarmConditionType(ref int index)
        {
            SupportedAlarmConditionType conditionType = m_ConditionTypes[index];
            index++;
            if (index >= m_ConditionTypes.Length)
            {
                index = 0;
            }
            return conditionType;
        }

        public bool GetUseOptional(string unitName, ref bool optional)
        {
            bool returnValue = optional;
            if (unitName == "Confirm" || unitName == "ExclusiveLevel")
            {
                returnValue = true;
            }
            else if (unitName == "Acknowledge")
            {
                returnValue = false;
            }
            else
            {
                optional = !optional;
                returnValue = optional;
            }

            return returnValue;
        }

        public NodeState GetAlarmNodeState(NodeHandle handle)
        {
            NodeState alarmState = null;

            NodeId handleNodeId = handle.NodeId;
            if (handleNodeId.IdType == IdType.String)
            {
                string nodeString = (string)handleNodeId.Identifier;
            }

            return alarmState;
        }

        public NodeHandle FindBranchNodeHandle(ISystemContext systemContext, NodeHandle initialHandle, CallMethodRequest methodToCall)
        {
            NodeHandle nodeHandle = initialHandle;

            if (IsAckConfirm(methodToCall.MethodId))
            {
                AlarmHolder holder = GetAlarmHolder(methodToCall.ObjectId);

                if (holder != null)
                {

                    if (holder.HasBranches())
                    {
                        byte[] eventId = GetEventIdFromAckConfirmMethod(methodToCall);

                        if (eventId != null)
                        {
                            BaseEventState state = holder.GetBranch(eventId);

                            if (state != null)
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

        private bool IsAckConfirm(NodeId methodId)
        {
            bool isAckConfirm = false;
            if (methodId.Equals(Opc.Ua.MethodIds.AcknowledgeableConditionType_Acknowledge) ||
                 methodId.Equals(Opc.Ua.MethodIds.AcknowledgeableConditionType_Confirm))
            {
                isAckConfirm = true;

            }
            return isAckConfirm;
        }

        private byte[] GetEventIdFromAckConfirmMethod(CallMethodRequest request)
        {
            byte[] eventId = null;

            // Bad magic Numbers here
            if (request.InputArguments != null && request.InputArguments.Count == 2)
            {
                if (request.InputArguments[0].TypeInfo.BuiltInType.Equals(BuiltInType.ByteString))
                {
                    eventId = (byte[])request.InputArguments[0].Value;
                }
            }
            return eventId;
        }

        public void GetBranchesForConditionRefresh(List<IFilterTarget> events)
        {
            // Don't look at Certificates, they won't have branches
            foreach (AlarmHolder alarmHolder in m_alarms.Values)
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
                        foreach (Dictionary<string, SourceController> map in m_triggerMap.Values)
                        {
                            foreach (SourceController controller in map.Values)
                            {
                                bool updated = controller.Controller.Update(GetNodeManager().SystemContext);

                                IList<IReference> references = new List<IReference>();
                                controller.Source.GetReferences(GetNodeManager().SystemContext, references, ReferenceTypes.HasCondition, false);
                                foreach (IReference reference in references)
                                {
                                    string identifier = (string)reference.TargetId.ToString();
                                    if (m_alarms.ContainsKey(identifier))
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
                            double sine = 100 * Math.Sin(value) + Defines.NORMAL_START_VALUE;
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
                    Debug.WriteLine(DateTime.UtcNow.ToLocalTime().ToLongTimeString() + " Missed Loop " + m_missed.ToString() + " Success " + m_success.ToString());
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

                if (sourceController == null)
                {
                    return StatusCodes.BadNodeIdUnknown;
                }

                GetNodeManager().m_logger.Information("Manual Write " + value.ToString() + " to " + node.NodeId.ToString());

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
            if (alarmHolder != null)
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
                foreach (AlarmHolder alarmHolder in m_alarms.Values)
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

        private AlarmHolder GetAlarmHolder(NodeId node)
        {

            AlarmHolder alarmHolder = null;

            Type nodeIdType = node.Identifier.GetType();
            if (nodeIdType.Name == "String")
            {
                string unmodifiedName = node.Identifier.ToString();

                // This is bad, but I'm not sure why the NodeName is being attached with an underscore, it messes with this lookup.
                string name = unmodifiedName.Replace("Alarms_", "Alarms.");

                string mapName = name;
                if (name.EndsWith(Defines.TRIGGER_EXTENSION) || name.EndsWith(Defines.ALARM_EXTENSION))
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

        public Dictionary<string, SourceController> GetUnitAlarms(NodeState nodeState)
        {
            Dictionary<string, SourceController> alarms = null;

            string unit = GetUnitFromNodeState(nodeState);

            if (m_triggerMap.ContainsKey(unit))
            {
                alarms = m_triggerMap[unit];
            }

            return alarms;
        }


        public string GetUnitFromNodeState(NodeState nodeState)
        {
            return GetUnitFromNodeId(nodeState.NodeId);
        }

        public string GetUnitFromNodeId(NodeId nodeId)
        {
            string unit = "";

            if (nodeId.IdType == IdType.String)
            {
                string nodeIdString = (string)nodeId.Identifier;
                string[] splitString = nodeIdString.Split('.');
                // Alarms.UnitName.MethodName
                if (splitString.Length >= 1)
                {
                    unit = splitString[1];
                }
            }

            return unit;
        }

        public SourceController GetSourceControllerFromNodeState(NodeState nodeState, Dictionary<string, SourceController> map)
        {
            SourceController sourceController = null;

            string name = GetSourceNameFromNodeState(nodeState);
            if (map.ContainsKey(name))
            {
                sourceController = map[name];
            }

            return sourceController;
        }

        public string GetSourceNameFromNodeState(NodeState nodeState)
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
                    sourceName = splitString[splitString.Length - 1].Replace("Source", "");
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
            if (sourceControllers == null)
            {
                result = StatusCodes.BadNodeIdUnknown;
            }

            if (sourceControllers != null)
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
