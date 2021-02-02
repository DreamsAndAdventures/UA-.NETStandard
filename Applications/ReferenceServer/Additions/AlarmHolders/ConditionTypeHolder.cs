using System;
using System.Collections.Generic;
using System.Diagnostics;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Opc.Ua;

namespace Quickstarts.ReferenceServer
{
    public class ConditionTypeHolder : BaseEventTypeHolder
    {
        protected ConditionTypeHolder(
            Alarms alarms,
            FolderState parent,
            string name,
            SupportedAlarmConditionType alarmConditionType,
            Type controllerType,
            int interval,
            bool optional) :
            base( alarms, parent, name, alarmConditionType, controllerType, interval, optional )
        {

        }

        public void Initialize(
            FolderState parent,
            uint alarmTypeIdentifier,
            string name,
            SupportedAlarmConditionType alarmConditionType,
            bool optional = true)
        {
            if ( m_alarm == null )
            {
                // this is invalid
                m_alarm = new ConditionState(parent);
            }

            ConditionState alarm = GetAlarm();

            // Call the base class to set parameters
            base.Initialize(parent, alarmTypeIdentifier, name, alarmConditionType, optional);

            ReferenceNodeManager manager = GetNodeManager();

            // Set all ConditionType Parameters
            alarm.ClientUserId.Value = "Anonymous";
            alarm.ConditionClassId.Value = alarmConditionType.Node;
            alarm.ConditionClassName.Value = new LocalizedText("", alarmConditionType.ConditionName);
            alarm.ConditionName.Value = m_alarmRootName;
            alarm.BranchId.Value = new NodeId();
            alarm.Retain.Value = false;

            alarm.SetEnableState(manager.SystemContext, true);
            alarm.Quality.Value = Opc.Ua.StatusCodes.Good;
            alarm.LastSeverity.Value = 0;
            alarm.Comment.Value = new LocalizedText("en", "");
            // check validity of ClientUserId

            // Set Method Handlers
            alarm.OnEnableDisable = OnEnableDisableAlarm;
            alarm.OnAddComment = OnAddComment;

            if (optional)
            {
                //alarm.ConditionSubClassId.Value = new List<NodeId>().ToArray();
                //alarm.ConditionSubClassName.Value = new List<LocalizedText>().ToArray();
            }

           
        }

        #region Overrides

        public override void SetValue(bool valueUpdated, string message = "")
        {
            ConditionState alarm = GetAlarm();

            if (ShouldEvent() || valueUpdated || message.Length > 0 )
            {
                alarm.SetSeverity(SystemContext, (EventSeverity)GetSeverity());
                if (message.Length == 0)
                {
                    message = "Alarm Event Value = " + m_trigger.Value.ToString();
                }

                alarm.Message.Value = new LocalizedText("en", message);

                ReportEvent();
            }
        }

        #endregion

        #region Child Helpers

        public void ReportEvent( )
        {
            ConditionState alarm = GetAlarm();
            if (alarm.EnabledState.Id.Value)
            {
                alarm.EventId.Value = Guid.NewGuid().ToByteArray();
                alarm.Time.Value = DateTime.UtcNow;
                alarm.ReceiveTime.Value = alarm.Time.Value;

                alarm.ClearChangeMasks(SystemContext, true);

                InstanceStateSnapshot eventSnapshot = new InstanceStateSnapshot();
                eventSnapshot.Initialize(SystemContext, alarm);
                Alarm.ReportEvent(SystemContext, eventSnapshot);
            }
        }

        protected ushort GetSeverity()
        {
            ushort severity = Defines.INACTIVE_SEVERITY;

            if (Analog)
            {
                int level = (int)m_trigger.Value;

                if (level <= Defines.LOWLOW_ALARM)
                {
                    severity = Defines.LOWLOW_SEVERITY;
                }
                // Level is Low
                else if (level <= Defines.LOW_ALARM)
                {
                    severity = Defines.LOW_SEVERITY;
                }
                // Level is HighHigh
                else if (level >= Defines.HIGHHIGH_ALARM)
                {
                    severity = Defines.HIGHHIGH_SEVERITY;
                }
                // Level is High
                else if (level >= Defines.HIGH_ALARM)
                {
                    severity = Defines.HIGH_SEVERITY;
                }
            }
            else
            {
                bool active = (bool)m_trigger.Value;
                if ( active )
                {
                    severity = Defines.BOOL_SEVERITY;
                }
            }

            return severity;
        }

        protected bool IsActive()
        {
            bool isActive = false;
            if ( GetSeverity() > Defines.INACTIVE_SEVERITY )
            {
                isActive = true;
            }
            return isActive;
        }

        protected bool WasActive()
        {
            bool wasActive = false;
            ConditionState alarm = GetAlarm();
            if (alarm.Severity.Value > Defines.INACTIVE_SEVERITY)
            {
                wasActive = true;
            }
            return wasActive;
        }

        protected bool ShouldEvent()
        {
            bool shouldEvent = false;
            ConditionState alarm = GetAlarm();
            if (GetSeverity() != alarm.Severity.Value)
            {
                shouldEvent = true;
            }
            return shouldEvent;
        }

        #endregion

        #region Helpers

        private ConditionState GetAlarm()
        {
            return (ConditionState)m_alarm;
        }

        #endregion

        #region Method Handlers 
        public ServiceResult OnEnableDisableAlarm(
            ISystemContext context,
            ConditionState condition,
            bool enabling)
        {
            StatusCode status = StatusCodes.Good;

            ConditionState alarm = GetAlarm();
            if ( enabling != alarm.EnabledState.Id.Value )
            {
                alarm.SetEnableState(SystemContext, enabling);
                alarm.Message.Value = enabling ? "Enabling": "Disabling" + " alarm " + MapName;

                // if disabled, it will not fire
                ReportEvent();
            }
            else
            {
                if ( enabling )
                {
                    status = StatusCodes.BadConditionAlreadyEnabled;
                }
                else
                {
                    status = StatusCodes.BadConditionAlreadyDisabled;
                }
            }

            return status;
        }

        private ServiceResult OnAddComment(
            ISystemContext context,
            ConditionState condition,
            byte[] eventId,
            LocalizedText comment)
        {
            if (!IsEvent(eventId))
            {
                return StatusCodes.BadEventIdUnknown;
            }

            ConditionState alarm = GetAlarm();

            if (CanSetComment(comment))
            {
                Debug.Print(m_mapName + " AddComment Setting Comment to " + comment.ToString());
                alarm.Comment.Value = comment;
            }
            else
            {
                Debug.Print(m_mapName + " AddComment Unable to set comment " + comment.ToString());
            }

            return ServiceResult.Good;
        }

        protected bool CanSetComment(LocalizedText comment)
        {
            bool canSetComment = false;

            if (comment != null)
            {
                canSetComment = true;

                bool emptyComment = comment.Text == null || comment.Text.Length == 0;
                bool emptyLocale = comment.Locale == null || comment.Locale.Length == 0;

                if (emptyComment && emptyLocale)
                {
                    canSetComment = false;
                }
            }

            return canSetComment;
        }

        protected virtual bool GetRetainState()
        {
            return true;
        }

        #endregion
    }



}
