using System;
using System.Collections.Generic;

using Opc.Ua;


#pragma warning disable CS1591


namespace Alarms
{
    // Ignore all Optionals for Confirm, as it should be supported.  For this object, that means remove all Optional conditions

    public class AcknowledgeableConditionTypeHolder : ConditionTypeHolder
    {
        public AcknowledgeableConditionTypeHolder(
            AlarmNodeManager alarmNodeManager,
            FolderState parent,
            SourceController trigger,
            string name,
            SupportedAlarmConditionType alarmConditionType,
            Type controllerType,
            int interval,
            bool optional = true,
            bool create = true) :
            base(alarmNodeManager, parent, trigger, name, alarmConditionType, controllerType, interval, optional)
        {
            if (create)
            {
                Initialize(Opc.Ua.ObjectTypes.AcknowledgeableConditionType, name);
            }
        }

        protected new void Initialize(
            uint alarmTypeIdentifier,
            string name)
        {
            // Create an alarm and trigger name - Create a base method for creating the trigger, just provide the name

            if (m_alarm == null)
            {
                m_alarm = new AcknowledgeableConditionState(m_parent);
            }

            AcknowledgeableConditionState alarm = GetAlarm();
            InitializeInternal(alarm);

            // Call the base class to set parameters
            base.Initialize(alarmTypeIdentifier, name);

            alarm.SetAcknowledgedState(SystemContext, acknowledged: true);

            alarm.SetConfirmedState(SystemContext, confirmed: true);
            alarm.OnConfirm = OnConfirm;

            alarm.Retain.Value = GetRetainState();
            alarm.AutoReportStateChanges = true;
        }

        private void InitializeInternal(AcknowledgeableConditionState alarm)
        {
            alarm.OnAcknowledge = OnAcknowledge;

            // Create any optional 
            if (alarm.ConfirmedState == null)
            {
                alarm.ConfirmedState = new TwoStateVariableState(alarm);
            }

            alarm.Confirm = new AddCommentMethodState(alarm);
        }



        #region Overrides 

        public override void SetValue(string message = "")
        {
            bool requiresUpdate = false;

            if (ShouldEvent() || message.Length > 0)
            {
                requiresUpdate = true;
                AcknowledgeableConditionState alarm = GetAlarm();
                if (IsActive())
                {
                    Log("AcknowledgeableConditionTypeHolder", "Setting Acked State to false");
                    alarm.SetAcknowledgedState(SystemContext, acknowledged: false);
                    alarm.Retain.Value = true;

                }
                else
                {
                    alarm.Retain.Value = GetRetainState();
                }
            }

            if (requiresUpdate)
            {
                base.SetValue(message);
            }
        }

        protected override bool GetRetainState()
        {
            AcknowledgeableConditionState alarm = GetAlarm();

            bool retainState = true;
            if (alarm.AckedState.Id.Value)
            {
                if (alarm.ConfirmedState.Id.Value)
                {
                    retainState = false;
                }
            }

            return retainState;
        }


        #endregion

        #region Helpers

        private AcknowledgeableConditionState GetAlarm(BaseEventState alarm = null)
        {
            if (alarm == null)
            {
                alarm = m_alarm;
            }
            return (AcknowledgeableConditionState)alarm;
        }

        private AcknowledgeableConditionState GetAlarmOrBranch(byte[] eventId)
        {
            AcknowledgeableConditionState alarmOrBranch = null;

            AcknowledgeableConditionState alarm = GetAlarm();
            ConditionState alarmOrBranchConditionState = alarm.GetEventByEventId(eventId);
            if (alarmOrBranchConditionState != null)
            {
                alarmOrBranch = (AcknowledgeableConditionState)alarmOrBranchConditionState;
            }
            return alarmOrBranch;
        }




        #endregion

        #region Methods

        private ServiceResult OnAcknowledge(
            ISystemContext context,
            ConditionState condition,
            byte[] eventId,
            LocalizedText comment)
        {
            string eventIdString = Utils.ToHexString(eventId);

            if ( m_acked.Contains( eventIdString ))
            {
                LogError("OnAcknowledge", EventErrorMessage(eventId) + " already acknowledged");
                return StatusCodes.BadConditionBranchAlreadyAcked;
            }

            AcknowledgeableConditionState alarm = GetAlarmOrBranch(eventId);

            if (alarm == null)
            {
                LogError("OnAcknowledge", EventErrorMessage(eventId));
                return StatusCodes.BadEventIdUnknown;
            }

            m_acked.Add(eventIdString);
           
            if (alarm.AckedState.Id.Value)
            {
                return StatusCodes.BadConditionBranchAlreadyAcked;
            }

            // No Confirming on Acknowledge tests
            if (m_alarmNodeManager.GetUnitFromNodeState(alarm) == "Acknowledge")
            {
                alarm.SetConfirmedState(SystemContext, confirmed: true);
                Log("OnAcknowledge", "Ignore Confirmed State, setting confirmed to true");
            }
            else
            {
                alarm.Message.Value = "User Acknowledged Event " + DateTime.Now.ToShortTimeString();
                Log("OnAcknowledge", "Setting Confirmed State to False");
                alarm.SetConfirmedState(SystemContext, confirmed: false);
            }

            m_alarmController.OnAcknowledge();

            // TODO This will need to go away
            alarm.Retain.Value = GetRetainState();

            return ServiceResult.Good;
        }


        private ServiceResult OnConfirm(
            ISystemContext context,
            ConditionState condition,
            byte[] eventId,
            LocalizedText comment)
        {

            string eventIdString = Utils.ToHexString(eventId);

            Log("OnConfirm", "Called with eventId " + eventIdString + " Comment " + comment.Text );

            if (m_confirmed.Contains(eventIdString))
            {
                LogError("OnConfirm", EventErrorMessage(eventId) + " already confirmed");
                return StatusCodes.BadConditionBranchAlreadyConfirmed;
            }

            AcknowledgeableConditionState alarm = GetAlarmOrBranch( eventId );

            if (alarm == null)
            {
                LogError("OnConfirm", EventErrorMessage(eventId));

                return StatusCodes.BadEventIdUnknown;
            }

            m_confirmed.Add(eventIdString);

            alarm.Message.Value = "User Confirmed Event " + DateTime.Now.ToShortTimeString();

            m_alarmController.OnAcknowledge();

            // TODO Go Away?
            alarm.Retain.Value = GetRetainState();

            return ServiceResult.Good;
        }

        #endregion

        #region Private

        protected HashSet<string> m_acked = new HashSet<string>();
        protected HashSet<string> m_confirmed = new HashSet<string>();

        #endregion



    }
}
