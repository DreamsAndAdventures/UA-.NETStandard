using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Opc.Ua;



namespace Quickstarts.ReferenceServer
{
    public class AcknowledgeableConditionTypeHolder : ConditionTypeHolder
    {
        public AcknowledgeableConditionTypeHolder(
            Alarms alarms,
            FolderState parent,
            string name,
            SupportedAlarmConditionType alarmConditionType,
            Type controllerType,
            int interval,
            bool optional = true,
            bool create = true ) :
            base( alarms, parent, name, alarmConditionType, controllerType, interval, optional )
        {
            if (create)
            {
                Initialize(parent, Opc.Ua.ObjectTypes.AcknowledgeableConditionType, name, alarmConditionType, optional);
            }
        }

        public void Initialize(
            FolderState parent,
            uint alarmTypeIdentifier,
            string name,
            SupportedAlarmConditionType alarmConditionType,
            bool optional = true)
        {
            // Create an alarm and trigger name - Create a base method for creating the trigger, just provide the name
            
            if (m_alarm == null)
            {
                m_alarm = new AcknowledgeableConditionState(parent);
            }

            AcknowledgeableConditionState alarm = GetAlarm();
            alarm.OnAcknowledge = OnAcknowledge;

            // Create any optional 
            if ( optional )
            {
                if (alarm.ConfirmedState == null)
                {
                    alarm.ConfirmedState = new TwoStateVariableState(alarm);
                    alarm.ConfirmedState.Create(SystemContext,
                        null,
                        BrowseNames.ConfirmedState,
                        BrowseNames.ConfirmedState,
                        false);
                }
                alarm.Confirm = new AddCommentMethodState(alarm);
            }

            // Call the base class to set parameters
            base.Initialize(parent, alarmTypeIdentifier, name, alarmConditionType, optional );

            // Set all AcknowledgeableConditionState Parameters
            alarm.SetAcknowledgedState(SystemContext, acknowledged: true);
            if (optional)
            {
                alarm.SetConfirmedState(SystemContext, confirmed: true);
                alarm.OnConfirm = OnConfirm;
            }
            alarm.Retain.Value = GetRetainState();
            alarm.AutoReportStateChanges = true;
        }

        #region Overrides 

        public override void SetValue(bool valueUpdated, string message = "" )
        {
            bool requiresUpdate = false;

            if (ShouldEvent())
            {
                requiresUpdate = true;
                AcknowledgeableConditionState alarm = GetAlarm();
                if (IsActive())
                {
                    alarm.SetAcknowledgedState(SystemContext, acknowledged: false);
                    alarm.Retain.Value = true;
                }
                else
                {
                    alarm.Retain.Value = GetRetainState();
                }
            }

            if ( requiresUpdate || valueUpdated )
            {
                base.SetValue(valueUpdated, message);
            }
        }

        protected override bool GetRetainState()
        {
            AcknowledgeableConditionState alarm = GetAlarm();

            bool retainState = true;
            if (alarm.AckedState.Id.Value)
            {
                if ((Optional))
                {
                    if (alarm.ConfirmedState.Id.Value)
                    {
                        retainState = false;
                    }
                }
                else
                {
                    retainState = false;
                }
            }

            return retainState;
        }

        #endregion

        #region Helpers

        private AcknowledgeableConditionState GetAlarm()
        {
            return (AcknowledgeableConditionState)m_alarm;
        }

        #endregion

        #region Methods

        private ServiceResult OnAcknowledge(
            ISystemContext context,
            ConditionState condition,
            byte[] eventId,
            LocalizedText comment)
        {
            if ( !IsEvent( eventId ) )
            {
                return StatusCodes.BadEventIdUnknown;
            }

            AcknowledgeableConditionState alarm = GetAlarm();

            if ( alarm.AckedState.Id.Value )
            {
                return StatusCodes.BadConditionBranchAlreadyAcked;
            }

            alarm.SetAcknowledgedState(SystemContext, acknowledged: true);
            if ( Optional )
            {
                alarm.SetConfirmedState(SystemContext, confirmed: false);
            }

            if ( CanSetComment( comment ) )
            {
                Debug.Print(m_mapName + " Ack Setting Comment to " + comment.ToString());
                alarm.Comment.Value = comment;
            }
            else
            {
                Debug.Print(m_mapName + " Ack Unable to set comment " + comment.ToString());
            }

            alarm.Retain.Value = GetRetainState();

            return ServiceResult.Good;
        }


        private ServiceResult OnConfirm(
            ISystemContext context,
            ConditionState condition,
            byte[] eventId,
            LocalizedText comment)
        {
            if (!IsEvent(eventId))
            {
                return StatusCodes.BadEventIdUnknown;
            }

            AcknowledgeableConditionState alarm = GetAlarm();

            if (!Optional)
            {
                return StatusCodes.BadMethodInvalid;
            }

            alarm.SetConfirmedState(SystemContext, confirmed: true);

            if (CanSetComment(comment))
            {
                Debug.Print(m_mapName + " Confirm Setting Comment to " + comment.ToString());
                alarm.Comment.Value = comment;
            }
            else
            {
                Debug.Print(m_mapName + " Confirm Unable to set comment " + comment.ToString());
            }

            alarm.Retain.Value = GetRetainState();

            return ServiceResult.Good;
        }

        #endregion



    }
}
