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
            m_alarmConditionType = alarmConditionType;
        }

        protected new void Initialize(
            uint alarmTypeIdentifier,
            string name)
        {
            if ( m_alarm == null )
            {
                // this is invalid
                m_alarm = new ConditionState(m_parent);
            }

            ConditionState alarm = GetAlarm();

            // Call the base class to set parameters
            base.Initialize(alarmTypeIdentifier, name);

            // Set all ConditionType Parameters
            alarm.ClientUserId.Value = "Anonymous";
            alarm.ConditionClassId.Value = m_alarmConditionType.Node;
            alarm.ConditionClassName.Value = new LocalizedText("", m_alarmConditionType.ConditionName);
            alarm.ConditionName.Value = m_alarmRootName;
            Debug.WriteLine("Alarm ConditionName = " + alarm.ConditionName.Value);

            alarm.BranchId.Value = new NodeId();
            alarm.Retain.Value = false;

            alarm.SetEnableState(SystemContext, true);
            alarm.Quality.Value = Opc.Ua.StatusCodes.Good;
            alarm.LastSeverity.Value = 0;
            alarm.Comment.Value = new LocalizedText("en", "");

            // Set Method Handlers
            alarm.OnEnableDisable = OnEnableDisableAlarm;
            alarm.OnAddComment = OnAddComment;

            if (Optional)
            {
                //alarm.ConditionSubClassId.Value = new List<NodeId>().ToArray();
                //alarm.ConditionSubClassName.Value = new List<LocalizedText>().ToArray();
            }
        }


        public BaseEventState FindBranch( )
        {
            BaseEventState state = null;

            return state;
        }

        protected override void CreateBranch()
        {
            ConditionState empty = null;

            if (m_alarmController.SupportBranch())
            {
                ConditionState alarm = GetAlarm();
                int currentSeverity = alarm.Severity.Value;
                int newSeverity = GetSeverity();
                // A branch is created at the end of an active cycle
                // This could be a transition between alarm states,
                // or a transition to inactive
                // So a branch can only be created when the severity changes
                if (currentSeverity > Defines.INACTIVE_SEVERITY &&
                    newSeverity != currentSeverity)
                {
                    NodeId branchId = GetNewBranchId();
                    ConditionState branch = (ConditionState)CreateBranch((BaseEventState)empty, branchId);
                    if ( branch != null )
                    {
                        // Report the event.  Then grab the event id!
                        ReportEvent( branch );
                        string postEventId = Utils.ToHexString(branch.EventId.Value as byte[]);

                        lock (GetNodeManager().Lock)
                        {
                            m_branches.Add(postEventId, branch);
                            m_alarmController.SetBranchCount(m_branches.Count);
                        }
                    }
                }
            }
        }

        public override BaseEventState CreateBranch(BaseEventState branch, NodeId branchId)
        {
            if (branch == null)
            {
                // this is invalid
                branch = new ConditionState(m_parent);
            }

            BaseEventState baseBranchEvent = base.CreateBranch(branch, branchId);

            ConditionState branchEvent = GetAlarm(baseBranchEvent);
            ConditionState alarm = GetAlarm();

            // Set all ConditionType Parameters
            branchEvent.ClientUserId.Value = String.Copy(alarm.ClientUserId.Value);
            branchEvent.ConditionClassId.Value = new NodeId(alarm.ConditionClassId.Value);
            branchEvent.ConditionClassName.Value = new LocalizedText(alarm.ConditionClassName.Value);
            branchEvent.ConditionName.Value = String.Copy(alarm.ConditionName.Value);
            Debug.WriteLine("Branch conditionName = " + branchEvent.ConditionName.Value);
            branchEvent.BranchId.Value = branchId;
            // Message part of BaseAlarmState - adding here to deal with branch
            branchEvent.Message.Value = "Branch  " + branchEvent.BranchId.Value.ToString() + " Created, new Value = " + m_alarmController.GetValue().ToString();
            Debug.WriteLine(branchEvent.Message.Value);
            branchEvent.Retain.Value = alarm.Retain.Value;

            branchEvent.SetEnableState(SystemContext, alarm.EnabledState.Id.Value);
            branchEvent.Quality.Value = alarm.Quality.Value;
            branchEvent.LastSeverity.Value = alarm.LastSeverity.Value;
            branchEvent.Comment.Value = new LocalizedText(alarm.Comment.Value);

            // Set Method Handlers
            branchEvent.OnEnableDisable = OnEnableDisableAlarm;
            branchEvent.OnAddComment = OnAddComment;

            if (Optional)
            {
                //branchEvent.ConditionSubClassId.Value = alarm.ConditionSubClassId.Value.ToArray();
                //branchEvent.ConditionSubClassName.Value = alarm.ConditionSubClassName.Value.ToArray();
            }

            return branchEvent;
        }




        #region Overrides

        public override void SetValue(bool valueUpdated, string message = "")
        {
            ConditionState alarm = GetAlarm();

            if (ShouldEvent() || valueUpdated || message.Length > 0)
            {
                CreateBranch();

                int newSeverity = GetSeverity();

                alarm.SetSeverity(SystemContext, (EventSeverity)newSeverity);
                if (message.Length == 0)
                {
                    message = "Alarm Event Value = " + m_trigger.Value.ToString();
                }

                alarm.Message.Value = new LocalizedText("en", message);

                ReportEvent();
            }
        }

        //public override string GetBranchNodeIdString(BaseEventState baseEvent)
        //{
        //    string nodeIdString = "";

        //    ConditionState alarm = GetAlarm(baseEvent);
        //    if ( alarm.BranchId != null && alarm.BranchId.Value != null &&  !alarm.BranchId.Value.IsNullNodeId )
        //    {
        //        nodeIdString = alarm.BranchId.Value.ToString();
        //    }

        //    return nodeIdString;
        //}


        #endregion

        #region Child Helpers

        public void ReportEvent(ConditionState alarm = null)
        {
            if ( alarm == null )
            {
                alarm = GetAlarm();
            }

            if (alarm.EnabledState.Id.Value)
            {
                alarm.EventId.Value = Guid.NewGuid().ToByteArray();
                alarm.Time.Value = DateTime.UtcNow;
                alarm.ReceiveTime.Value = alarm.Time.Value;

                alarm.ClearChangeMasks(SystemContext, true);

                InstanceStateSnapshot eventSnapshot = new InstanceStateSnapshot();
                eventSnapshot.Initialize(SystemContext, alarm);
                alarm.ReportEvent(SystemContext, eventSnapshot);
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

        private ConditionState GetAlarm(BaseEventState alarm = null)
        {
            if (alarm == null)
            {
                alarm = m_alarm;
            }
            return (ConditionState)alarm;
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


            m_alarmController.OnAddComment();

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
