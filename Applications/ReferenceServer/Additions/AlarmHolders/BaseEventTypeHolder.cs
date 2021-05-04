using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Opc.Ua;

namespace Quickstarts.ReferenceServer
{
    public class BaseEventTypeHolder : AlarmHolder
    {
        protected BaseEventTypeHolder(
            Alarms alarms,
            FolderState parent,
            string name,
            SupportedAlarmConditionType alarmConditionType,
            Type controllerType,
            int interval,
            bool optional) :
            base(alarms, parent, controllerType, interval)
        {
            m_optional = optional;
        }

        protected new void Initialize(
            uint alarmTypeIdentifier,
            string name)
        {
            m_alarmTypeIdentifier = alarmTypeIdentifier;

            if (m_alarm != null)
            {
                // Call the base class to set parameters
                base.Initialize(alarmTypeIdentifier, name);

                BaseEventState alarm = GetAlarm();

                alarm.EventId.Value = Guid.NewGuid().ToByteArray();
                alarm.EventType.Value = new NodeId( alarmTypeIdentifier, GetNameSpaceIndex( alarmTypeIdentifier ) );
                alarm.SourceNode.Value = m_trigger.NodeId;
                alarm.SourceName.Value = m_trigger.SymbolicName;
                alarm.Time.Value = DateTime.UtcNow;
                alarm.ReceiveTime.Value = alarm.Time.Value;
                alarm.Message.Value = name + " Initialized";
                alarm.Severity.Value = Defines.INACTIVE_SEVERITY;
            }
        }

        public override BaseEventState CreateBranch(BaseEventState branch, NodeId branchId)
        {
            BaseEventState branchEvent = base.CreateBranch(branch, branchId);

            BaseEventState alarm = GetAlarm();

            branchEvent.EventId.Value = Guid.NewGuid().ToByteArray();
            branchEvent.EventType.Value = new NodeId(alarm.EventType.Value);
            branchEvent.SourceNode.Value = m_trigger.NodeId;
            branchEvent.SourceName.Value = m_trigger.SymbolicName;
            branchEvent.Time.Value = DateTime.UtcNow;
            branchEvent.ReceiveTime.Value = alarm.Time.Value;
            // Do the Message in the ConditionType, as it has the branchId
            //branchEvent.Message.Value = MapName + " Branch  " + branchEvent.Br.ToString() + " Created";
            branchEvent.Severity.Value = alarm.Severity.Value;

            return branchEvent;
        }

        #region Overrides

        public override void SetValue(bool valueUpdated, string message = "")
        {
            
        }

        #endregion

        #region Helpers

        private BaseEventState GetAlarm(BaseEventState alarm = null)
        {
            if ( alarm == null )
            {
                alarm = m_alarm;
            }
            return (BaseEventState)alarm;
        }


        #endregion

        #region Child Helpers

        protected bool IsEvent( byte[] eventId )
        {
            bool isEvent = false;
            if (GetAlarm().EventId.Value.SequenceEqual(eventId) )
            {
                isEvent = true;
            }

            return isEvent;
        }

        protected BaseEventState GetEventByEventId(byte[] eventId)
        {
            BaseEventState alarm = null;

            BaseEventState originalAlarm = GetAlarm();
            if ( originalAlarm.EventId.Value.SequenceEqual(eventId))
            {
                alarm = originalAlarm;
            }
            else
            {
                foreach( BaseEventState branchEvent in m_branches.Values )
                {
                    if (branchEvent.EventId.Value.SequenceEqual(eventId))
                    {
                        alarm = branchEvent;
                        break;
                    }
                }
            }
            return alarm;
        }

        #endregion

    }
}
