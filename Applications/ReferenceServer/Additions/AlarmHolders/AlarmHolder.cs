using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Serilog;

using Opc.Ua;

namespace Quickstarts.ReferenceServer
{
    public class AlarmHolder
    {
        public AlarmHolder(Alarms alarms, FolderState parent, Type controllerType, int interval)
        {
            m_alarms = alarms;
            m_parent = parent;
            m_alarmControllerType = controllerType;
            m_alarmController = null;
            m_interval = interval;
            m_branches = new Dictionary<string, BaseEventState>();
        }

        protected void Initialize(uint alarmTypeIdentifier, string name)
        {
            m_alarmTypeIdentifier = alarmTypeIdentifier;
            m_alarmTypeName = GetAlarmTypeName(m_alarmTypeIdentifier);

            string extraName = "";
            if (name.Length > 0)
            {
                extraName = "." + name;
            }

            m_alarmRootName = m_alarmTypeName + extraName;
            m_mapName = (string)m_parent.NodeId.Identifier + "." + m_alarmRootName;
            Debug.WriteLine("Creating " + m_mapName);


            InitializeInternal(m_alarm);
        }

        public bool HasBranches()
        {
            return m_branches.Count > 0;
        }

        public BaseEventState GetBranch( byte[] eventId )
        {
            BaseEventState state = null;
            string eventIdString = Utils.ToHexString(eventId);
            m_branches.TryGetValue(eventIdString, out state);

            return state;
        }

        public void ClearBranches()
        {
            m_branches.Clear();
            m_alarmController.SetBranchCount(m_branches.Count);
        }

        public void GetBranchesForConditionRefresh(List<IFilterTarget> events)
        {
            // Don't look at Certificates, they won't have branches
            foreach (BaseEventState alarm in m_branches.Values)
            {
                events.Add(alarm);
            }
        }


        protected virtual void CreateBranch()
        {
        }

        public virtual BaseEventState CreateBranch(BaseEventState alarm, NodeId branchId)
        {
            InitializeInternal(alarm, branchId);
            return alarm;
        }

        private void InitializeInternal(BaseEventState alarm, NodeId branchId = null )
        {
            string triggerNodeId = (string)m_parent.NodeId.Identifier + "." + TriggerName;

            string alarmName = AlarmName/* + GetBranchNodeIdString(branchId)*/;
            string alarmNodeId = (string)m_parent.NodeId.Identifier + "." + AlarmName;

            alarm.SymbolicName = alarmName;

            NodeId createNodeId = null;
            QualifiedName createQualifiedName = new QualifiedName(alarmName, NamespaceIndex);
            LocalizedText createLocalizedText = null;


            bool isBranch = IsBranch(branchId);
                createNodeId = new NodeId(alarmNodeId, NamespaceIndex);
                createLocalizedText = new LocalizedText(alarmName);

            alarm.ReferenceTypeId = ReferenceTypeIds.HasComponent;
            alarm.Create(
                SystemContext,
                createNodeId,
                createQualifiedName,
                createLocalizedText,
                true);


            if (!isBranch)
            {
                m_trigger = Helpers.CreateVariable(m_parent, NamespaceIndex, triggerNodeId, TriggerName, !Analog);
                m_trigger.OnWriteValue = OnWriteAlarmTrigger;

                m_parent.AddChild(alarm);
                m_alarmController = (AlarmController)Activator.CreateInstance(m_alarmControllerType, m_trigger, m_interval, !Analog);
            }

        }

        private bool IsBranch( NodeId branchId )
        {
            bool isBranch = false;
            if ( branchId != null && !branchId.IsNullNodeId )
            {
                isBranch = true;
            }
            return isBranch;
        }

        public NodeId GetNewBranchId()
        {
            return new NodeId(++m_branchCounter, NamespaceIndex);
        }

        public virtual string GetBranchNodeIdString(NodeId branchId)
        {
            string nodeIdString = "";

            if ( IsBranch(branchId) )
            {
                // Just the numeric
                nodeIdString = "." + branchId.Identifier.ToString();
            }
            return nodeIdString;
        }

        public virtual void Update()
        {
            DelayedEvents();
            SetValue(m_alarmController.Update(SystemContext));
        }

        public virtual void DelayedEvents()
        {
            // Method calls are done by the core.  Delayed events are expected events to be logged to file.
            while( m_delayedMessages.Count > 0 )
            {
                string message = GetMessage("Delayed:" + m_delayedMessages[0], " Event Time: " + m_alarm.Time.Value.ToString());
                Logger.Information(message);
                m_delayedMessages.RemoveAt(0);
            }
        }

        protected void Log(string caller, string message, BaseEventState alarm = null)
        {
            Logger.Information(GetMessage(caller, message));
        }

        protected void LogError(string caller, string message, BaseEventState alarm = null)
        {
            Logger.Error(GetMessage(caller, message));
        }

        protected string GetMessage(string caller, string message)
        {
            return caller + ": " + m_mapName + " EventId " +
                Utils.ToHexString(m_alarm.EventId.Value) + " " + message;
        }


        public virtual void SetValue(bool valueUpdated, string message = "")
        {
            Debug.WriteLine("AlarmHolder.SetValue() - Should not be called");
        }

        public void Start()
        {
            ClearBranches();
            m_alarmController.Start();
        }

        public void Stop()
        {
            ClearBranches();
            m_alarmController.Stop();
        }

        protected virtual bool UpdateShelving()
        {
            Debug.WriteLine("AlarmHolder.UpdateShelving() - Should not be called");
            return false;
        }

        protected virtual bool UpdateSuppression()
        {
            Debug.WriteLine("AlarmHolder.UpdateSuppression() - Should not be called");
            return false;
        }

        protected virtual void SetActive(BaseEventState state, bool activeState)
        {

        }

        #region Methods

        public ServiceResult OnWriteAlarmTrigger(
            ISystemContext context,
            NodeState node,
            NumericRange indexRange,
            QualifiedName dataEncoding,
            ref object value,
            ref StatusCode statusCode,
            ref DateTime timestamp)
        {
            if (Trigger.Value != value)
            {
                Trigger.Value = value;
                SetValue(true, "Manual Write to trigger " + value.ToString());
            }




            return Opc.Ua.StatusCodes.Good;
        }

        #endregion

        #region Properties

        public ISystemContext SystemContext
        {
            get { return GetNodeManager().SystemContext; }
        }

        public ushort NamespaceIndex
        {
            get { return GetNodeManager().NamespaceIndex; }
        }

        public BaseEventState Alarm
        {
            get { return m_alarm; }
        }

        public AlarmController Controller
        {
            get { return m_alarmController; }
        }

        public BaseDataVariableState Trigger
        {
            get { return m_trigger; }
        }

        public string MapName
        {
            get { return m_mapName; }
        }

        public string TriggerName
        {
            get { return m_alarmRootName + Defines.TRIGGER_EXTENSION; }
        }

        public string AlarmName
        {
            get { return m_alarmRootName + Defines.ALARM_EXTENSION; }
        }

        public bool Analog
        {
            get { return m_analog; }
        }
        public bool Optional
        {
            get { return m_optional; }
        }

        public Serilog.Core.Logger Logger
        {
            get { return GetNodeManager().m_logger; }
        }

        #endregion

        #region Helpers

        public PropertyState<NodeId> GetEventType()
        {
            return m_alarm.EventType;
        }

        protected ReferenceNodeManager GetNodeManager()
        {
            return m_alarms.GetNodeManager();
        }

        protected string GetAlarmTypeName(UInt32 alarmTypeIdentifier)
        {
            string alarmTypeName = "";

            switch (alarmTypeIdentifier)
            {
                case Opc.Ua.ObjectTypes.ConditionType:
                    alarmTypeName = "ConditionType";
                    break;

                case Opc.Ua.ObjectTypes.DialogConditionType:
                    alarmTypeName = "DialogConditionType";
                    break;

                case Opc.Ua.ObjectTypes.AcknowledgeableConditionType:
                    alarmTypeName = "AcknowledgeableConditionType";
                    break;

                case Opc.Ua.ObjectTypes.AlarmConditionType:
                    alarmTypeName = "AlarmConditionType";
                    break;

                case Opc.Ua.ObjectTypes.AlarmGroupType:
                    alarmTypeName = "AlarmGroupType";
                    break;

                case Opc.Ua.ObjectTypes.ShelvedStateMachineType:
                    alarmTypeName = "ShelvedStateMachineType";
                    break;

                case Opc.Ua.ObjectTypes.LimitAlarmType:
                    alarmTypeName = "LimitAlarmType";
                    break;

                case Opc.Ua.ObjectTypes.ExclusiveLimitStateMachineType:
                    alarmTypeName = "ExclusiveLimitStateMachineType";
                    break;

                case Opc.Ua.ObjectTypes.ExclusiveLimitAlarmType:
                    alarmTypeName = "ExclusiveLimitAlarmType";
                    break;

                case Opc.Ua.ObjectTypes.NonExclusiveLimitAlarmType:
                    alarmTypeName = "NonExclusiveLimitAlarmType";
                    break;

                case Opc.Ua.ObjectTypes.NonExclusiveLevelAlarmType:
                    alarmTypeName = "NonExclusiveLevelAlarmType";
                    break;

                case Opc.Ua.ObjectTypes.ExclusiveLevelAlarmType:
                    alarmTypeName = "ExclusiveLevelAlarmType";
                    break;

                case Opc.Ua.ObjectTypes.NonExclusiveDeviationAlarmType:
                    alarmTypeName = "NonExclusiveDeviationAlarmType";
                    break;

                case Opc.Ua.ObjectTypes.NonExclusiveRateOfChangeAlarmType:
                    alarmTypeName = "NonExclusiveRateOfChangeAlarmType";
                    break;

                case Opc.Ua.ObjectTypes.ExclusiveDeviationAlarmType:
                    alarmTypeName = "ExclusiveDeviationAlarmType";
                    break;

                case Opc.Ua.ObjectTypes.ExclusiveRateOfChangeAlarmType:
                    alarmTypeName = "ExclusiveRateOfChangeAlarmType";
                    break;

                case Opc.Ua.ObjectTypes.DiscreteAlarmType:
                    alarmTypeName = "DiscreteAlarmType";
                    break;

                case Opc.Ua.ObjectTypes.OffNormalAlarmType:
                    alarmTypeName = "OffNormalAlarmType";
                    break;

                case Opc.Ua.ObjectTypes.SystemOffNormalAlarmType:
                    alarmTypeName = "SystemOffNormalAlarmType";
                    break;

                case Opc.Ua.ObjectTypes.TripAlarmType:
                    alarmTypeName = "TripAlarmType";
                    break;

                case Opc.Ua.ObjectTypes.InstrumentDiagnosticAlarmType:
                    alarmTypeName = "InstrumentDiagnosticAlarmType";
                    break;

                case Opc.Ua.ObjectTypes.SystemDiagnosticAlarmType:
                    alarmTypeName = "SystemDiagnosticAlarmType";
                    break;

                case Opc.Ua.ObjectTypes.CertificateExpirationAlarmType:
                    alarmTypeName = "CertificateExpirationAlarmType";
                    break;

                case Opc.Ua.ObjectTypes.DiscrepancyAlarmType:
                    alarmTypeName = "DiscrepancyAlarmType";
                    break;
            }

            return alarmTypeName;
        }

        protected ushort GetNameSpaceIndex(UInt32 alarmTypeIdentifier)
        {
            ushort nameSpaceIndex = 0;

            switch (alarmTypeIdentifier)
            {
                case Defines.DERIVED_SYSTEM_OFF_NORMAL_ALARM_TYPE:
                    nameSpaceIndex = m_alarms.GetNodeManager().NamespaceIndex;
                    break;
            }

            return nameSpaceIndex;
        }

        #endregion

        #region Private Fields
        protected Alarms m_alarms = null;
        protected BaseEventState m_alarm = null;
        protected Type m_alarmControllerType = null;
        protected AlarmController m_alarmController = null;
        protected BaseDataVariableState m_trigger = null;
        protected string m_alarmRootName = "";
        protected string m_mapName = "";
        protected bool m_analog = true;
        protected bool m_optional = false;
        protected int m_interval = 0;
        protected uint m_branchCounter = 0;
        protected Dictionary<string, BaseEventState> m_branches = null;
        protected FolderState m_parent = null;
        protected uint m_alarmTypeIdentifier = 0;
        protected string m_alarmTypeName = "";
        protected SupportedAlarmConditionType m_alarmConditionType = null;
        protected List<string> m_delayedMessages = new List<string>(); 
        #endregion


    }
}
