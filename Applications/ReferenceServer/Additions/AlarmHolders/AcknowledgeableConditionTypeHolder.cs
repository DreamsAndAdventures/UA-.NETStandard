using System;
using System.Diagnostics;

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
            bool create = true) :
            base(alarms, parent, name, alarmConditionType, controllerType, interval, optional)
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
            if (Optional)
            {
                alarm.SetConfirmedState(SystemContext, confirmed: true);
                alarm.OnConfirm = OnConfirm;
            }

            alarm.Retain.Value = GetRetainState();
            alarm.AutoReportStateChanges = true;
        }

        public override BaseEventState CreateBranch(BaseEventState branch, NodeId branchId)
        {
            if (branch == null)
            {
                branch = new AcknowledgeableConditionState(m_parent);
            }

            AcknowledgeableConditionState branchEvent = GetAlarm(branch);
            InitializeInternal(branchEvent);
            base.CreateBranch(branch, branchId);

            AcknowledgeableConditionState alarm = GetAlarm();

            branchEvent.SetAcknowledgedState(SystemContext, alarm.AckedState.Id.Value);
            if (Optional)
            {
                branchEvent.SetConfirmedState(SystemContext, alarm.ConfirmedState.Id.Value);
                branchEvent.OnConfirm = OnConfirm;
            }

            branchEvent.Retain.Value = GetRetainState();
            branchEvent.AutoReportStateChanges = false;

            return branchEvent;
        }

        private void InitializeInternal(AcknowledgeableConditionState alarm)
        {
            alarm.OnAcknowledge = OnAcknowledge;

            // Create any optional 
            if (Optional)
            {
                if (alarm.ConfirmedState == null)
                {
                    alarm.ConfirmedState = new TwoStateVariableState(alarm);
                }
                alarm.Confirm = new AddCommentMethodState(alarm);
            }
        }



        #region Overrides 

        public override void SetValue(bool valueUpdated, string message = "")
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

            if (requiresUpdate || valueUpdated)
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

        protected void ReplaceBranchEvent(byte[] originalEventId, AcknowledgeableConditionState alarm)
        {
            string originalKey = Utils.ToHexString(originalEventId);
            string newKey = Utils.ToHexString(alarm.EventId.Value);

            m_branches.Remove(originalKey);
            m_branches.Add(newKey, alarm);
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


        #endregion

        #region Methods

        private ServiceResult OnAcknowledge(
            ISystemContext context,
            ConditionState condition,
            byte[] eventId,
            LocalizedText comment)
        {
            AcknowledgeableConditionState alarm = null;
            bool branchEvent = false;

            if (IsEvent(eventId))
            {
                alarm = GetAlarm();
            }
            else
            {
                BaseEventState branch = GetEventByEventId(eventId);
                if (branch != null)
                {
                    alarm = GetAlarm(branch);
                    branchEvent = true;
                }
            }

            if (alarm == null)
            {
                return StatusCodes.BadEventIdUnknown;
            }

            if (alarm.AckedState.Id.Value)
            {
                return StatusCodes.BadConditionBranchAlreadyAcked;
            }

            alarm.SetAcknowledgedState(SystemContext, acknowledged: true);
            if (Optional)
            {
                alarm.SetConfirmedState(SystemContext, confirmed: false);
            }

            if (CanSetComment(comment))
            {
                Debug.Print(m_mapName + " Ack Setting Comment to " + comment.ToString());
                alarm.Comment.Value = comment;
            }
            else
            {
                Debug.Print(m_mapName + " Ack Unable to set comment " + comment.ToString());
            }

            alarm.Retain.Value = GetRetainState();

            if (branchEvent)
            {
                if (!Optional)
                {
                    alarm.Retain.Value = false;
                    SetActive(alarm, false);
                }

                ReportEvent(alarm);

                if (Optional)
                {
                    ReplaceBranchEvent(eventId, alarm);
                }
                else
                {
                    lock (GetNodeManager().Lock)
                    {
                        m_branches.Remove(Utils.ToHexString(eventId));
                        m_alarmController.SetBranchCount(m_branches.Count);
                    }
                }
            }

            return ServiceResult.Good;
        }


        private ServiceResult OnConfirm(
            ISystemContext context,
            ConditionState condition,
            byte[] eventId,
            LocalizedText comment)
        {
            if (!Optional)
            {
                return StatusCodes.BadMethodInvalid;
            }

            AcknowledgeableConditionState alarm = null;
            bool branchEvent = false;

            if (IsEvent(eventId))
            {
                alarm = GetAlarm();
            }
            else
            {
                BaseEventState branch = GetEventByEventId(eventId);
                if (branch != null)
                {
                    alarm = GetAlarm(branch);
                    branchEvent = true;
                }
            }

            if (alarm == null)
            {
                return StatusCodes.BadEventIdUnknown;
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

            if (branchEvent)
            {
                SetActive(alarm, false);
                alarm.Retain.Value = false;

                ReportEvent(alarm);
                lock (GetNodeManager().Lock)
                {
                    m_branches.Remove(Utils.ToHexString(eventId));
                    m_alarmController.SetBranchCount(m_branches.Count);

                }
            }

            return ServiceResult.Good;
        }

        #endregion



    }
}
