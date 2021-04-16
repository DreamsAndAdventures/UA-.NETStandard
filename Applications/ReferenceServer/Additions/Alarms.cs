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
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Opc.Ua;
using Opc.Ua.Server;


namespace Quickstarts.ReferenceServer
{
    public class Alarms
    {
        private ReferenceNodeManager m_nodeManager;
        private ushort NameSpaceIndex = 0;
        Dictionary<string, AlarmHolder> m_alarms = new Dictionary<string, AlarmHolder>();
        Dictionary<string, Dictionary<string, AlarmHolder>> m_alarmMap = new Dictionary<string, Dictionary<string, AlarmHolder>>();
        CertificateExpirationTypeHolder m_expired = null;
        CertificateExpirationTypeHolder m_inside = null;
        CertificateExpirationTypeHolder m_outside = null;
        private bool m_allowEntry = false;
        private bool m_autoRun = false;

        private string[] m_conformanceUnits = {
            "Basic",
            "Alarm",
            "Acknowledge",
            "Confirm",
            "Alarm",
            "Shelve",
            "Comment",
            "Suppression",
            "OffNormal",
            "SystemOffNormal",
            "CertificateExpiration",
            "Refresh",
            "Refresh2",
            "Discrete",
            "ConditionClasses"
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
            string alarmsName = "Alarms";
            string alarmsNodeName = alarmsName;
            FolderState alarmsFolder = Helpers.CreateFolder(root, NameSpaceIndex, alarmsNodeName, alarmsName);

            // Setpoint NodeId
            BaseDataVariableState deviationSetpoint = Helpers.CreateVariable(alarmsFolder, NameSpaceIndex, "DeviationSetpoint", "DeviationSetpoint");
            deviationSetpoint.AccessLevel = AccessLevels.CurrentRead;
            deviationSetpoint.UserAccessLevel = AccessLevels.CurrentRead;
            deviationSetpoint.Value = 50;


            int interval = 0;
            string intervalString = interval.ToString();

            int conditionTypeIndex = 0;
            bool useOptional = true;
            foreach( string unitName in m_conformanceUnits )
            {
                string unitNodeName = alarmsName + "." + unitName;
                FolderState unitFolder = Helpers.CreateFolder(alarmsFolder, NameSpaceIndex,
                    unitNodeName, unitName);

                Dictionary<string, AlarmHolder> alarmMap = new Dictionary<string, AlarmHolder>();

                m_alarmMap.Add(unitName, alarmMap);

                AlarmHolder ackAlarmType = new AcknowledgeableConditionTypeHolder(
                    this,
                    unitFolder,
                    intervalString,
                    GetSupportedAlarmConditionType( ref conditionTypeIndex ),
                    Type.GetType("Quickstarts.ReferenceServer.AlarmController"),
                    interval,
                    optional: GetUseOptional( ref useOptional ) );
                alarmMap.Add(ackAlarmType.MapName, ackAlarmType);

                AlarmHolder alarmConditionType = new AlarmConditionTypeHolder(
                    this,
                    unitFolder,
                    intervalString,
                    GetSupportedAlarmConditionType( ref conditionTypeIndex ),
                    Type.GetType("Quickstarts.ReferenceServer.AlarmController"),
                    interval,
                    optional: GetUseOptional(ref useOptional));
                alarmMap.Add(alarmConditionType.MapName, alarmConditionType);

                AlarmHolder discrepancy = new DiscrepancyAlarmTypeHolder(
                    this,
                    unitFolder,
                    intervalString,
                    GetSupportedAlarmConditionType(ref conditionTypeIndex),
                    Type.GetType("Quickstarts.ReferenceServer.AlarmController"),
                    interval,
                    optional: GetUseOptional(ref useOptional));
                alarmMap.Add(discrepancy.MapName, discrepancy);

                AlarmHolder discrete = new DiscreteHolder(
                    this,
                    unitFolder,
                    intervalString,
                    GetSupportedAlarmConditionType(ref conditionTypeIndex),
                    Type.GetType("Quickstarts.ReferenceServer.AlarmController"),
                    interval,
                    optional: GetUseOptional(ref useOptional));
                alarmMap.Add(discrete.MapName, discrete);

                AlarmHolder limit = new LimitAlarmTypeHolder(
                    this,
                    unitFolder,
                    intervalString,
                    GetSupportedAlarmConditionType(ref conditionTypeIndex),
                    Type.GetType("Quickstarts.ReferenceServer.AlarmController"),
                    interval,
                    optional: GetUseOptional(ref useOptional));
                alarmMap.Add(limit.MapName, limit);

                AlarmHolder exclusiveLimit = new ExclusiveLimitHolder(
                    this,
                    unitFolder,
                    intervalString,
                    GetSupportedAlarmConditionType(ref conditionTypeIndex),
                    Type.GetType("Quickstarts.ReferenceServer.AlarmController"),
                    interval,
                    optional: GetUseOptional(ref useOptional));
                alarmMap.Add(exclusiveLimit.MapName, exclusiveLimit);

                AlarmHolder exclusiveLevel = new ExclusiveLevelHolder(
                    this,
                    unitFolder,
                    intervalString,
                    GetSupportedAlarmConditionType(ref conditionTypeIndex),
                    Type.GetType("Quickstarts.ReferenceServer.AlarmController"),
                    interval,
                    optional: GetUseOptional(ref useOptional));
                alarmMap.Add(exclusiveLevel.MapName, exclusiveLevel);

                AlarmHolder exclusiveRateOfChange = new ExclusiveRateOfChangeHolder(
                    this,
                    unitFolder,
                    intervalString,
                    GetSupportedAlarmConditionType(ref conditionTypeIndex),
                    Type.GetType("Quickstarts.ReferenceServer.AlarmController"),
                    interval,
                    optional: GetUseOptional(ref useOptional));
                alarmMap.Add(exclusiveRateOfChange.MapName, exclusiveRateOfChange);

                AlarmHolder exclusiveDeviation = new ExclusiveDeviationHolder(
                    this,
                    unitFolder,
                    intervalString,
                    GetSupportedAlarmConditionType(ref conditionTypeIndex),
                    Type.GetType("Quickstarts.ReferenceServer.AlarmController"),
                    interval,
                    deviationSetpoint.NodeId,
                    optional: GetUseOptional(ref useOptional));
                alarmMap.Add(exclusiveDeviation.MapName, exclusiveDeviation);

                AlarmHolder nonExclusiveLimit = new NonExclusiveLimitHolder(
                    this,
                    unitFolder,
                    intervalString,
                    GetSupportedAlarmConditionType(ref conditionTypeIndex),
                    Type.GetType("Quickstarts.ReferenceServer.AlarmController"),
                    interval,
                    optional: GetUseOptional(ref useOptional));
                alarmMap.Add(nonExclusiveLimit.MapName, nonExclusiveLimit);

                AlarmHolder nonExclusiveLevel = new NonExclusiveLevelHolder(
                    this,
                    unitFolder,
                    intervalString,
                    GetSupportedAlarmConditionType(ref conditionTypeIndex),
                    Type.GetType("Quickstarts.ReferenceServer.AlarmController"),
                    interval,
                    optional: GetUseOptional(ref useOptional));
                alarmMap.Add(nonExclusiveLevel.MapName, nonExclusiveLevel);

                AlarmHolder nonExclusiveRateOfChange = new NonExclusiveRateOfChangeHolder(
                    this,
                    unitFolder,
                    intervalString,
                    GetSupportedAlarmConditionType(ref conditionTypeIndex),
                    Type.GetType("Quickstarts.ReferenceServer.AlarmController"),
                    interval,
                    optional: GetUseOptional(ref useOptional));
                alarmMap.Add(nonExclusiveRateOfChange.MapName, nonExclusiveRateOfChange);

                AlarmHolder nonExclusiveDeviation = new NonExclusiveDeviationHolder(
                    this,
                    unitFolder,
                    intervalString,
                    GetSupportedAlarmConditionType(ref conditionTypeIndex),
                    Type.GetType("Quickstarts.ReferenceServer.AlarmController"),
                    interval,
                    deviationSetpoint.NodeId,
                    optional: GetUseOptional(ref useOptional));
                alarmMap.Add(nonExclusiveDeviation.MapName, nonExclusiveDeviation);
            }
       
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

        public bool GetUseOptional( ref bool optional )
        {
            bool returnValue = optional;
            optional = !optional;
            return returnValue;
        }

        public void CreateAlarms_Obsolete(FolderState root)
        {
            NodeState derivedSystemOffNormalAlarmType = DerivedSystemOffNormalAlarmType.CreateType(GetNodeManager());

            string alarmsName = "Alarms";
            string alarmsNodeName = alarmsName;
            FolderState alarmsFolder = Helpers.CreateFolder(root, NameSpaceIndex, alarmsNodeName, alarmsName);

            MethodState enableAutoRun = Helpers.CreateMethod(alarmsFolder, NameSpaceIndex, "EnableAutoRun", "EnableAutoRun");
            enableAutoRun.OnCallMethod = new GenericMethodCalledEventHandler(OnEnableAutoRun);

            MethodState disableAutoRun = Helpers.CreateMethod(alarmsFolder, NameSpaceIndex, "DisableAutoRun", "DisableAutoRun");
            disableAutoRun.OnCallMethod = new GenericMethodCalledEventHandler(OnDisableAutoRun);

            MethodState clearBranches = Helpers.CreateMethod(alarmsFolder, NameSpaceIndex, "ClearBranches", "ClearBranches");
            clearBranches.OnCallMethod = new GenericMethodCalledEventHandler(OnClearBranches);

            // Setpoint NodeId
            BaseDataVariableState deviationSetpoint = Helpers.CreateVariable(alarmsFolder, NameSpaceIndex, "DeviationSetpoint", "DeviationSetpoint");
            deviationSetpoint.AccessLevel = AccessLevels.CurrentRead;
            deviationSetpoint.UserAccessLevel = AccessLevels.CurrentRead;
            deviationSetpoint.Value = 50;

            SupportedAlarmConditionType[] conditionTypes = null;

            bool useFullConditionTypes = true;
            bool justBranch = false;

            if ( useFullConditionTypes )
            {
                SupportedAlarmConditionType[] tempConditionTypes = {
                    new SupportedAlarmConditionType( "Process", "ProcessConditionClassType",  ObjectTypeIds.ProcessConditionClassType ),
                    new SupportedAlarmConditionType( "Maintenance", "MaintenanceConditionClassType",  ObjectTypeIds.MaintenanceConditionClassType ),
                    new SupportedAlarmConditionType( "System", "SystemConditionClassType",  ObjectTypeIds.SystemConditionClassType ) };
                conditionTypes = tempConditionTypes;
            }
            else
            {
                SupportedAlarmConditionType[] tempConditionTypes = {
                    new SupportedAlarmConditionType( "Process", "ProcessConditionClassType",  ObjectTypeIds.ProcessConditionClassType ) };
                conditionTypes = tempConditionTypes;
            }

#if RUN_CERTIFICATES

            if (!justBranch)
            {
                string certificateName = "Certificate";
                string certificateNodeName = certificateName;
                FolderState certificateFolder = Helpers.CreateFolder(alarmsFolder, NameSpaceIndex,
                    certificateNodeName, certificateName);

                MethodState setCertificates = Helpers.CreateMethod(certificateFolder, NameSpaceIndex, Defines.SET_CERTIFICATE_EXPIRATION_NAME, Defines.SET_CERTIFICATE_EXPIRATION_NAME);
                setCertificates.OnCallMethod = new GenericMethodCalledEventHandler(OnSetCertificates);

                MethodState resetCertificates = Helpers.CreateMethod(certificateFolder, NameSpaceIndex, Defines.RESET_CERTIFICATE_EXPIRATIONS_NAME, Defines.RESET_CERTIFICATE_EXPIRATIONS_NAME);
                resetCertificates.OnCallMethod = new GenericMethodCalledEventHandler(OnResetCertificates);

                MethodState resetOutside = Helpers.CreateMethod(certificateFolder, NameSpaceIndex, Defines.RESET_OUTSIDE_CERTIFICATE_NAME, Defines.RESET_OUTSIDE_CERTIFICATE_NAME);
                resetOutside.OnCallMethod = new GenericMethodCalledEventHandler(OnResetOutsideCertificate);

                MethodState resetInside = Helpers.CreateMethod(certificateFolder, NameSpaceIndex, Defines.RESET_INSIDE_CERTIFICATE_NAME, Defines.RESET_INSIDE_CERTIFICATE_NAME);
                resetInside.OnCallMethod = new GenericMethodCalledEventHandler(OnResetInsideCertificate);

                MethodState resetExpired = Helpers.CreateMethod(certificateFolder, NameSpaceIndex, Defines.RESET_EXPIRED_CERTIFICATE_NAME, Defines.RESET_EXPIRED_CERTIFICATE_NAME);
                resetExpired.OnCallMethod = new GenericMethodCalledEventHandler(OnResetExpiredCertificate);

                SupportedAlarmConditionType certificateSupportedAlarmConditionType = conditionTypes[conditionTypes.Length - 1];
                m_expired = new CertificateExpirationTypeHolder(
                    this,
                    certificateFolder,
                    Defines.EXPIRED_LIMIT_NAME,
                    certificateSupportedAlarmConditionType,
                    Type.GetType("Quickstarts.ReferenceServer.FastToggleAlarmController"),
                    1000,
                    optional: false);
                m_alarms.Add(m_expired.MapName, m_expired);

                m_inside = new CertificateExpirationTypeHolder(
                    this,
                    certificateFolder,
                    Defines.INSIDE_LIMIT_NAME,
                    certificateSupportedAlarmConditionType,
                    Type.GetType("Quickstarts.ReferenceServer.FastToggleAlarmController"),
                    1000,
                    optional: false);
                m_alarms.Add(m_inside.MapName, m_inside);

                m_outside = new CertificateExpirationTypeHolder(
                    this,
                    certificateFolder,
                    Defines.OUTSIDE_LIMIT_NAME,
                    certificateSupportedAlarmConditionType,
                    Type.GetType("Quickstarts.ReferenceServer.FastToggleAlarmController"),
                    1000,
                    optional: false);
                m_alarms.Add(m_outside.MapName, m_outside);
            }

#endif

            string[] manualAuto = { "Manual", "Auto" };
            string[] optionalMandatory = { "Optional", "Mandatory" };

            for (int manualIndex = 0; manualIndex < manualAuto.Length; manualIndex++)
            {
                string manualAutoName = manualAuto[manualIndex];
                string manualAutoNodeName = alarmsNodeName + "." + manualAutoName;
                FolderState manualAutoFolder = Helpers.CreateFolder(alarmsFolder, NameSpaceIndex, manualAutoNodeName, manualAutoName);
                bool useManual = manualAutoName == "Manual";

                for (int optionalIndex = 0; optionalIndex < optionalMandatory.Length; optionalIndex++)
                {
                    string optionalName = optionalMandatory[optionalIndex];
                    string optionalNodeName = manualAutoNodeName + "." + optionalName;
                    FolderState optionalFolder = Helpers.CreateFolder(manualAutoFolder, NameSpaceIndex, optionalNodeName, optionalName);
                    bool useOptional = optionalName == "Optional";

                    for (int conditionTypeIndex = 0; conditionTypeIndex < conditionTypes.Length; conditionTypeIndex++)
                    {
                        SupportedAlarmConditionType conditionType = conditionTypes[conditionTypeIndex];
                        string conditionTypeName = conditionType.Name;
                        string conditionTypeNodeName = optionalNodeName + "." + conditionTypeName;
                        FolderState conditionTypeFolder = Helpers.CreateFolder(optionalFolder, NameSpaceIndex, conditionTypeNodeName, conditionTypeName);

                        string acknowledgeableConditionName = "AcknowledgeableCondition";
                        string acknowledgeableConditionNodeName = conditionTypeNodeName + "." + acknowledgeableConditionName;
                        FolderState acknowledgeableConditionFolder = Helpers.CreateFolder(conditionTypeFolder, NameSpaceIndex,
                            acknowledgeableConditionNodeName, acknowledgeableConditionName);

                        string alarmConditionName = "AlarmCondition";
                        string alarmConditionNodeName = conditionTypeNodeName + "." + alarmConditionName;
                        FolderState alarmConditionFolder = Helpers.CreateFolder(conditionTypeFolder, NameSpaceIndex,
                            alarmConditionNodeName, alarmConditionName);

                        string discreteName = "Discrete";
                        string discreteNodeName = conditionTypeNodeName + "." + discreteName;
                        FolderState discreteFolder = Helpers.CreateFolder(conditionTypeFolder, NameSpaceIndex,
                            discreteNodeName, discreteName);

                        string offNormalConditionName = "OffNormal";
                        string offNormalConditionNodeName = conditionTypeNodeName + "." + offNormalConditionName;
                        FolderState offNormalConditionFolder = Helpers.CreateFolder(conditionTypeFolder, NameSpaceIndex,
                            offNormalConditionNodeName, offNormalConditionName);

                        string systemOffNormalName = "SystemOffNormal";
                        string systemOffNormalNodeName = conditionTypeNodeName + "." + systemOffNormalName;
                        FolderState systemOffNormalFolder = Helpers.CreateFolder(conditionTypeFolder, NameSpaceIndex,
                            systemOffNormalNodeName, systemOffNormalName);

                        //string xxxName = "yyy";
                        //string xxxNodeName = conditionTypeNodeName + "." + xxxName;
                        //FolderState xxxFolder = Helpers.CreateFolder(conditionTypeFolder, NameSpaceIndex,
                        //    xxxNodeName, xxxName);

                        string derivedSystemOffNormalName = "DerivedSystem";
                        string derivedSystemOffNormalNodeName = conditionTypeNodeName + "." + derivedSystemOffNormalName;
                        FolderState derivedSystemOffNormalFolder = Helpers.CreateFolder(conditionTypeFolder, NameSpaceIndex,
                            derivedSystemOffNormalNodeName, derivedSystemOffNormalName);

                        string limitName = "Limit";
                        string limitNodeName = conditionTypeNodeName + "." + limitName;
                        FolderState limitFolder = Helpers.CreateFolder(conditionTypeFolder, NameSpaceIndex,
                            limitNodeName, limitName);

                        string exclusiveName = "Exclusive";
                        string exclusiveNodeName = conditionTypeNodeName + "." + exclusiveName;
                        FolderState exclusiveFolder = Helpers.CreateFolder(conditionTypeFolder, NameSpaceIndex,
                            exclusiveNodeName, exclusiveName);

                        string nonExclusiveName = "NonExclusive";
                        string nonExclusiveNodeName = conditionTypeNodeName + "." + nonExclusiveName;
                        FolderState nonExclusiveFolder = Helpers.CreateFolder(conditionTypeFolder, NameSpaceIndex,
                            nonExclusiveNodeName, nonExclusiveName);


                        int start = 1;
                        int desired = start + 2;
                        if (useManual || !useFullConditionTypes)
                        {
                            desired = start + 1;
                        }

                        for (int index = start; index < desired; index++)
                        {
                            int interval = index  * 1000;

                            if (useManual)
                            {
                                interval = 0;
                            }

                            string intervalString = interval.ToString();

#if RUN_ACKNOWLEDGEABLE
                            if (!justBranch)
                            {
                                AlarmHolder ackAlarmType = new AcknowledgeableConditionTypeHolder(
                                    this,
                                    acknowledgeableConditionFolder,
                                    intervalString,
                                    conditionType,
                                    Type.GetType("Quickstarts.ReferenceServer.AlarmController"),
                                    interval,
                                    optional: useOptional);
                                m_alarms.Add(ackAlarmType.MapName, ackAlarmType);
                            }
#endif

#if RUN_ALARM
                            if (!justBranch)
                            {

                                AlarmHolder alarmConditionType = new AlarmConditionTypeHolder(
                                this,
                                alarmConditionFolder,
                                intervalString,
                                conditionType,
                                Type.GetType("Quickstarts.ReferenceServer.AlarmController"),
                                interval,
                                optional: useOptional);
                                m_alarms.Add(alarmConditionType.MapName, alarmConditionType);

                                AlarmHolder alarmConditionChatter = new AlarmConditionTypeHolder(
                                    this,
                                    alarmConditionFolder,
                                    "Chatter." + intervalString,
                                    conditionType,
                                    Type.GetType("Quickstarts.ReferenceServer.ChatterAlarmController"),
                                    interval,
                                    optional: useOptional,
                                    maxShelveTime: Defines.SHORT_MAX_TIME_SHELVED);
                                m_alarms.Add(alarmConditionChatter.MapName, alarmConditionChatter);

                                AlarmHolder alarmConditionSteady = new AlarmConditionTypeHolder(
                                    this,
                                    alarmConditionFolder,
                                    "Steady." + intervalString,
                                    conditionType,
                                    Type.GetType("Quickstarts.ReferenceServer.SteadyIntervalAlarmController"),
                                    interval,
                                    optional: useOptional,
                                    maxShelveTime: Defines.SHORT_MAX_TIME_SHELVED);
                                m_alarms.Add(alarmConditionSteady.MapName, alarmConditionSteady);

                                AlarmHolder alarmConditionWhileActive = new AlarmConditionTypeHolder(
                                    this,
                                    alarmConditionFolder,
                                    "UnsuppressActive." + intervalString,
                                    conditionType,
                                    Type.GetType("Quickstarts.ReferenceServer.SuppressWhileActiveAlarmController"),
                                    interval,
                                    optional: useOptional);
                                m_alarms.Add(alarmConditionWhileActive.MapName, alarmConditionWhileActive);

                                AlarmHolder alarmConditionWhileInactive = new AlarmConditionTypeHolder(
                                    this,
                                    alarmConditionFolder,
                                    "UnsuppressInactive." + intervalString,
                                    conditionType,
                                    Type.GetType("Quickstarts.ReferenceServer.SuppressWhileInactiveAlarmController"),
                                    interval,
                                    optional: useOptional);
                                m_alarms.Add(alarmConditionWhileInactive.MapName, alarmConditionWhileInactive);
                            }

                            //AlarmHolder branching = new AlarmConditionTypeHolder(
                            //    this,
                            //    alarmConditionFolder,
                            //    "Branch." + intervalString,
                            //    conditionType,
                            //    Type.GetType("Quickstarts.ReferenceServer.BranchAlarmController"),
                            //    interval,
                            //    optional: useOptional); ;
                            //m_alarms.Add(branching.MapName, branching);


#endif

#if RUN_DISCRETE
                            if (!justBranch)
                            {
                                AlarmHolder discrete = new DiscreteHolder(
                                this,
                                discreteFolder,
                                intervalString,
                                conditionType,
                                Type.GetType("Quickstarts.ReferenceServer.AlarmController"),
                                interval,
                                optional: useOptional);
                                m_alarms.Add(discrete.MapName, discrete);
                            }

#endif
#if RUN_OFFNORMAL

                            if (!justBranch)
                            {
                                AlarmHolder offNormal = new OffNormalAlarmTypeHolder(
                                this,
                                offNormalConditionFolder,
                                intervalString,
                                conditionType,
                                Type.GetType("Quickstarts.ReferenceServer.AlarmController"),
                                interval,
                                optional: useOptional);
                                m_alarms.Add(offNormal.MapName, offNormal);
                            }
#endif

#if RUN_SYSTEMOFFNORMAL
                            if (!justBranch)
                            {
                                AlarmHolder systemOff = new SystemOffNormalAlarmTypeHolder(
                                this,
                                systemOffNormalFolder,
                                intervalString,
                                conditionType,
                                Type.GetType("Quickstarts.ReferenceServer.AlarmController"),
                                interval,
                                optional: useOptional);
                                m_alarms.Add(systemOff.MapName, systemOff);
                            }
#endif


#if RUN_DERIVEDSYSTEMOFFNORMAL

                            if (!justBranch)
                            {
                                AlarmHolder derived = new DerivedSystemOffNormalAlarmTypeHolder(
                                this,
                                derivedSystemOffNormalFolder,
                                intervalString,
                                conditionType,
                                Type.GetType("Quickstarts.ReferenceServer.AlarmController"),
                                interval,
                                optional: useOptional);
                                m_alarms.Add(derived.MapName, derived);
                            }
#endif


#if RUN_LIMIT
                            if (!justBranch)
                            {

                                AlarmHolder limit = new LimitAlarmTypeHolder(
                                this,
                                limitFolder,
                                intervalString,
                                conditionType,
                                Type.GetType("Quickstarts.ReferenceServer.LimitAlarmController"),
                                interval,
                                optional: useOptional);
                                m_alarms.Add(limit.MapName, limit);

                                AlarmHolder exclusiveLimit = new ExclusiveLimitHolder(
                                    this,
                                    exclusiveFolder,
                                    intervalString,
                                    conditionType,
                                    Type.GetType("Quickstarts.ReferenceServer.LimitAlarmController"),
                                    interval,
                                    optional: useOptional);
                                m_alarms.Add(exclusiveLimit.MapName, exclusiveLimit);


                                AlarmHolder nonExclusiveLimit = new NonExclusiveLimitHolder(
                                    this,
                                    nonExclusiveFolder,
                                    intervalString,
                                    conditionType,
                                    Type.GetType("Quickstarts.ReferenceServer.LimitAlarmController"),
                                    interval,
                                    optional: useOptional);
                                m_alarms.Add(nonExclusiveLimit.MapName, nonExclusiveLimit);
                            }
#endif


#if Run_LEVEL

                            if (!justBranch)
                            {

                            AlarmHolder exclusiveLevel = new ExclusiveLevelHolder(
                                this,
                                exclusiveFolder,
                                intervalString,
                                conditionType,
                                Type.GetType("Quickstarts.ReferenceServer.AlarmController"),
                                interval,
                                optional: useOptional);
                            m_alarms.Add(exclusiveLevel.MapName, exclusiveLevel);

                            AlarmHolder nonExclusiveLevel = new NonExclusiveLevelHolder(
                                this,
                                nonExclusiveFolder,
                                intervalString,
                                conditionType,
                                Type.GetType("Quickstarts.ReferenceServer.AlarmController"),
                                interval,
                                optional: useOptional);
                            m_alarms.Add(nonExclusiveLevel.MapName, nonExclusiveLevel);

                            AlarmHolder exclusiveRateOfChange = new ExclusiveRateOfChangeHolder(
                                this,
                                exclusiveFolder,
                                intervalString,
                                conditionType,
                                Type.GetType("Quickstarts.ReferenceServer.AlarmController"),
                                interval,
                                optional: useOptional);
                            m_alarms.Add(exclusiveRateOfChange.MapName, exclusiveRateOfChange);


                            AlarmHolder nonExclusiveRateOfChange = new NonExclusiveRateOfChangeHolder(
                                this,
                                nonExclusiveFolder,
                                intervalString,
                                conditionType,
                                Type.GetType("Quickstarts.ReferenceServer.AlarmController"),
                                interval,
                                optional: useOptional);
                            m_alarms.Add(nonExclusiveRateOfChange.MapName, nonExclusiveRateOfChange);

                            AlarmHolder exclusiveDeviation = new ExclusiveDeviationHolder(
                                this,
                                exclusiveFolder,
                                intervalString,
                                conditionType,
                                Type.GetType("Quickstarts.ReferenceServer.AlarmController"),
                                interval,
                                deviationSetpoint.NodeId,
                                optional: useOptional);
                            m_alarms.Add(exclusiveDeviation.MapName, exclusiveDeviation);


                            AlarmHolder nonExclusiveDeviation = new NonExclusiveDeviationHolder(
                                this,
                                nonExclusiveFolder,
                                intervalString,
                                conditionType,
                                Type.GetType("Quickstarts.ReferenceServer.AlarmController"),
                                interval,
                                deviationSetpoint.NodeId,
                                optional: useOptional);
                            m_alarms.Add(nonExclusiveDeviation.MapName, nonExclusiveDeviation);
                            }
#endif



                        }
                    }
                }
            }


            m_allowEntry = true;

        }

        public NodeState GetAlarmNodeState( NodeHandle handle )
        {
            NodeState alarmState = null;

            NodeId handleNodeId = handle.NodeId;
            if ( handleNodeId.IdType == IdType.String )
            {
                string nodeString = (string)handleNodeId.Identifier;
                //if ( m_alarms.Contains( nodeString ) )
                //{
                //    AlarmHolder holder = m_alarms[nodeString];
                //    if ( controller.HasBranches() )
                //    {
                //        BaseEventState ackState = holder.Alarm;
                //        ackState.EventId.Value 
                //        ackState.BranchId
                //        alarmState = 

                //    }
                // }
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
                        ConfigurationNodeManager configurationNodeManager =
                            GetNodeManager().Server.NodeManager.ConfigurationNodeManager;

                        NodeId parentNodeId = new NodeId(Opc.Ua.ObjectTypeIds.SystemOffNormalAlarmType);
                        NodeState parent = configurationNodeManager.FindPredefinedNode(parentNodeId,
                            null);


                        foreach (AlarmHolder alarmHolder in m_alarms.Values)
                        {
                            alarmHolder.Update();
                        }
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine("Loop Exception " + ex.Message);

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

        public void EnableAlarm(string alarmName, bool enabling)
        {
            //List<UnderlyingSystemAlarm> snapshots = new List<UnderlyingSystemAlarm>();

            //lock (m_alarms)
            //{
            //    UnderlyingSystemAlarm alarm = FindAlarm(alarmName, 0);

            //    if (alarm != null)
            //    {
            //        // enable/disable the alarm.
            //        if (alarm.SetStateBits(UnderlyingSystemAlarmStates.Enabled, enabling))
            //        {
            //            alarm.Time = alarm.EnableTime = DateTime.UtcNow;
            //            alarm.Reason = "The alarm was " + ((enabling) ? "enabled." : "disabled.");
            //            snapshots.Add(alarm.CreateSnapshot());
            //        }

            //        // enable/disable any archived records for the alarm.
            //        foreach (UnderlyingSystemAlarm record in m_archive.Values)
            //        {
            //            if (record.Name != alarmName)
            //            {
            //                continue;
            //            }

            //            if (record.SetStateBits(UnderlyingSystemAlarmStates.Enabled, enabling))
            //            {
            //                record.Time = alarm.EnableTime = DateTime.UtcNow;
            //                record.Reason = "The alarm was " + ((enabling) ? "enabled." : "disabled.");
            //                snapshots.Add(alarm.CreateSnapshot());
            //            }
            //        }
            //    }
            //}

            //// report any alarm changes after releasing the lock.
            //for (int ii = 0; ii < snapshots.Count; ii++)
            //{
            //    ReportAlarmChange(snapshots[ii]);
            //}
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
            AlarmHolder alarmHolder = GetAlarmHolder(node);
            if (alarmHolder == null)
            {
                return Opc.Ua.StatusCodes.Bad;
            }

            bool updated = false;
            if ( alarmHolder.Trigger.Value != value)
            {
                updated = true;
                alarmHolder.Trigger.Value = value;
            }

            alarmHolder.SetValue(updated);


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
            m_autoRun = true;
            return ServiceResult.Good;
        }

        public ServiceResult OnDisableAutoRun(
            ISystemContext context,
            NodeState node,
            IList<object> inputArguments,
            IList<object> outputArguments)
        {
            m_autoRun = false;
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

        public ServiceResult OnEnableBasic(
            ISystemContext context )
        {
            
            return ServiceResult.Good;
        }

    }
}
