#define RUN_DISCRETE
#define RUN_ALARM
#define RUN_CERTIFICATES
#define RUN_ACKNOWLEDGEABLE
#define RUN_OFFNORMAL
#define RUN_SYSTEMOFFNORMAL
#define RUN_DERIVEDSYSTEMOFFNORMAL
#define RUN_CERTIFICATE

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
        CertificateExpirationTypeHolder m_expired = null;
        CertificateExpirationTypeHolder m_inside = null;
        CertificateExpirationTypeHolder m_outside = null;
        private bool m_allowEntry = false;
        private bool m_autoRun = false;

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

            string alarmsName = "Alarms";
            string alarmsNodeName = alarmsName;
            FolderState alarmsFolder = Helpers.CreateFolder(root, NameSpaceIndex, alarmsNodeName, alarmsName);

            MethodState enableAutoRun = Helpers.CreateMethod(alarmsFolder, NameSpaceIndex, "EnableAutoRun", "EnableAutoRun");
            enableAutoRun.OnCallMethod = new GenericMethodCalledEventHandler(OnEnableAutoRun);

            MethodState disableAutoRun = Helpers.CreateMethod(alarmsFolder, NameSpaceIndex, "DisableAutoRun", "DisableAutoRun");
            disableAutoRun.OnCallMethod = new GenericMethodCalledEventHandler(OnDisableAutoRun);

            SupportedAlarmConditionType[] conditionTypes = {
                new SupportedAlarmConditionType( "Process", "ProcessConditionClassType",  ObjectTypeIds.ProcessConditionClassType ),
                new SupportedAlarmConditionType( "Maintenance", "MaintenanceConditionClassType",  ObjectTypeIds.MaintenanceConditionClassType ),
                new SupportedAlarmConditionType( "System", "SystemConditionClassType",  ObjectTypeIds.SystemConditionClassType )
            };

#if RUN_CERTIFICATES

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

            m_expired = new CertificateExpirationTypeHolder(
                this,
                certificateFolder,
                Defines.EXPIRED_LIMIT_NAME,
                conditionTypes[2],
                Type.GetType("Quickstarts.ReferenceServer.FastToggleAlarmController"),
                1000,
                optional: false);
            m_alarms.Add(m_expired.MapName, m_expired);

            m_inside = new CertificateExpirationTypeHolder(
                this,
                certificateFolder,
                Defines.INSIDE_LIMIT_NAME,
                conditionTypes[2],
                Type.GetType("Quickstarts.ReferenceServer.FastToggleAlarmController"),
                1000,
                optional: false);
            m_alarms.Add(m_inside.MapName, m_inside);

            m_outside = new CertificateExpirationTypeHolder(
                this,
                certificateFolder,
                Defines.OUTSIDE_LIMIT_NAME,
                conditionTypes[2],
                Type.GetType("Quickstarts.ReferenceServer.FastToggleAlarmController"),
                1000,
                optional: false);
            m_alarms.Add(m_outside.MapName, m_outside);

#endif 


            string[] manualAuto = { "Manual", "Auto" };
//            string[] manualAuto = { "Manual"/*, "Auto"*/ };
            string[] optionalMandatory = { "Optional", "Mandatory" };

            for (int manualIndex = 0; manualIndex < manualAuto.Length; manualIndex++)
            {
                string manualAutoName = manualAuto[manualIndex];
                string manualAutoNodeName = alarmsNodeName + "." + manualAutoName;
                FolderState manualAutoFolder = Helpers.CreateFolder(alarmsFolder, NameSpaceIndex, manualAutoNodeName, manualAutoName);
                bool useManual = manualIndex == 0;

                for (int optionalIndex = 0; optionalIndex < optionalMandatory.Length; optionalIndex++)
                {
                    string optionalName = optionalMandatory[optionalIndex];
                    string optionalNodeName = manualAutoNodeName + "." + optionalName;
                    FolderState optionalFolder = Helpers.CreateFolder(manualAutoFolder, NameSpaceIndex, optionalNodeName, optionalName);
                    bool useOptional = optionalIndex == 0;

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

                        int start = 1;
                        int desired = start + 2;
                        if (useManual)
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
                            AlarmHolder ackAlarmType = new AcknowledgeableConditionTypeHolder(
                                this,
                                acknowledgeableConditionFolder,
                                intervalString,
                                conditionType,
                                Type.GetType("Quickstarts.ReferenceServer.AlarmController"),
                                interval,
                                optional: useOptional);
                            m_alarms.Add(ackAlarmType.MapName, ackAlarmType);
#endif

#if RUN_ALARM

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

#endif

#if RUN_DISCRETE
                            AlarmHolder discrete = new DiscreteHolder(
                                this,
                                discreteFolder,
                                intervalString,
                                conditionType,
                                Type.GetType("Quickstarts.ReferenceServer.AlarmController"),
                                interval,
                                optional: useOptional);
                            m_alarms.Add(discrete.MapName, discrete);

#endif
#if RUN_OFFNORMAL

                            AlarmHolder offNormal = new OffNormalAlarmTypeHolder(
                                this,
                                offNormalConditionFolder,
                                intervalString,
                                conditionType,
                                Type.GetType("Quickstarts.ReferenceServer.AlarmController"),
                                interval,
                                optional: useOptional);
                            m_alarms.Add(offNormal.MapName, offNormal);
#endif

#if RUN_SYSTEMOFFNORMAL

                            AlarmHolder systemOff = new SystemOffNormalAlarmTypeHolder(
                                this,
                                systemOffNormalFolder,
                                intervalString,
                                conditionType,
                                Type.GetType("Quickstarts.ReferenceServer.AlarmController"),
                                interval,
                                optional: useOptional);
                            m_alarms.Add(systemOff.MapName, systemOff);
#endif


#if RUN_DERIVEDSYSTEMOFFNORMAL

                            AlarmHolder derived = new DerivedSystemOffNormalAlarmTypeHolder(
                                this,
                                derivedSystemOffNormalFolder,
                                intervalString,
                                conditionType,
                                Type.GetType("Quickstarts.ReferenceServer.AlarmController"),
                                interval,
                                optional: useOptional);
                            m_alarms.Add(derived.MapName, derived);
#endif

                        }
                    }
                }
            }


            m_allowEntry = true;

        }

        public void Loop()
        {
            if (m_allowEntry)
            {
                m_allowEntry = false;
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
                m_allowEntry = true;
            }
            else
            {
                Debug.WriteLine(DateTime.UtcNow.ToLocalTime().ToLongTimeString() + " Missed Loop");
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
                string triggerName = node.Identifier.ToString();
                string mapName = triggerName.Replace(".Trigger", "");
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

    }
}
