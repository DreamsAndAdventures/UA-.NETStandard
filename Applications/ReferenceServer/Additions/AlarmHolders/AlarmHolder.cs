using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Opc.Ua;

namespace Quickstarts.ReferenceServer
{
    public class AlarmHolder
    {
        public AlarmHolder(Alarms alarms, Type controllerType, int interval)
        {
            m_alarms = alarms;
            m_alarmControllerType = controllerType;
            m_alarmController = null;
            m_interval = interval;
        }

        public void Initialize(FolderState parent, string alarmTypeName, string name )
        {
            string extraName = "";
            if (name.Length > 0)
            {
                extraName = "." + name;
            }

            m_alarmRootName = alarmTypeName + extraName;
            m_mapName = (string)parent.NodeId.Identifier + "." + m_alarmRootName;
            Debug.WriteLine("Creating " + m_mapName);

            string triggerNodeId = (string)parent.NodeId.Identifier + "." + TriggerName;
            string alarmNodeId = (string)parent.NodeId.Identifier + "." + AlarmName;

            ReferenceNodeManager manager = m_alarms.GetNodeManager();

            m_trigger = Helpers.CreateVariable(parent, manager.NamespaceIndex, triggerNodeId, TriggerName, !Analog);
            m_trigger.OnWriteValue = OnWriteAlarmTrigger;
            m_alarm.SymbolicName = AlarmName;
            m_alarm.ReferenceTypeId = ReferenceTypeIds.HasComponent;
            m_alarm.Create(
                manager.SystemContext,
                new NodeId( alarmNodeId, manager.NamespaceIndex ),
                new QualifiedName(AlarmName, manager.NamespaceIndex ),
                new LocalizedText( AlarmName ),
                true);

            parent.AddChild(m_alarm);

            m_alarmController = (AlarmController)Activator.CreateInstance(m_alarmControllerType, m_trigger, m_interval, !Analog );
        }

        public virtual void Update( )
        {
            SetValue(m_alarmController.Update(SystemContext));
        }

        public virtual void SetValue(bool valueUpdated, string message = "")
        {
            Debug.WriteLine("AlarmHolder.SetValue() - Should not be called");
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
            get { return m_alarmRootName + ".Trigger"; }
        }

        public string AlarmName
        {
            get { return m_alarmRootName + ".Alarm"; }
        }

        public bool Analog
        {
            get { return m_analog; }
        }
        public bool Optional
        {
            get { return m_optional; }
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
        #endregion


    }
}
