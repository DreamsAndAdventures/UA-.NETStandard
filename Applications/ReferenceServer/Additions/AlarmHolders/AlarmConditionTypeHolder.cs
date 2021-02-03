using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Opc.Ua;

namespace Quickstarts.ReferenceServer
{
    public class AlarmConditionTypeHolder : AcknowledgeableConditionTypeHolder
    {
        public AlarmConditionTypeHolder(
            Alarms alarms,
            FolderState parent,
            string name,
            SupportedAlarmConditionType alarmConditionType,
            Type controllerType,
            int interval,
            bool optional = true,
            double maxShelveTime = Defines.NORMAL_MAX_TIME_SHELVED,
            bool create = true) :
            base(alarms, parent, name, alarmConditionType, controllerType, interval, optional, false)
        {
            if (create)
            {
                Initialize(parent, Opc.Ua.ObjectTypes.AlarmConditionType, name, alarmConditionType, optional, maxShelveTime);
            }
        }

        public void Initialize(
            FolderState parent,
            uint alarmTypeIdentifier,
            string name,
            SupportedAlarmConditionType alarmConditionType,
            bool optional = true,
            double maxTimeShelved = Defines.NORMAL_MAX_TIME_SHELVED)
        {
            // Create an alarm and trigger name - Create a base method for creating the trigger, just provide the name

            if (m_alarm == null)
            {
                m_alarm = new AlarmConditionState(parent);
            }

            AlarmConditionState alarm = (AlarmConditionState)m_alarm;

            if (optional)
            {
                if (alarm.SuppressedState == null)
                {
                    alarm.SuppressedState = new TwoStateVariableState(alarm);
                    //alarm.SuppressedState.Create(SystemContext,
                    //    null,
                    //    BrowseNames.SuppressedState,
                    //    BrowseNames.SuppressedState,
                    //    false);
                }


                if (alarm.OutOfServiceState == null)
                {
                    alarm.OutOfServiceState = new TwoStateVariableState(alarm);
                    alarm.OutOfServiceState.Create(SystemContext,
                        null,
                        BrowseNames.OutOfServiceState,
                        BrowseNames.OutOfServiceState,
                        false);
                }

                if (alarm.ShelvingState == null)
                {
                    alarm.ShelvingState = new ShelvedStateMachineState(alarm);
                    alarm.ShelvingState.Create(SystemContext,
                        null,
                        BrowseNames.ShelvingState,
                        BrowseNames.ShelvingState,
                        false);
                }
            }

            if (alarm.MaxTimeShelved == null)
            {
                // Off normal does not create MaxTimeShelved.
                alarm.MaxTimeShelved = new PropertyState<double>(alarm);
            }

            // Call the base class to set parameters
            base.Initialize(parent, alarmTypeIdentifier, name, alarmConditionType, optional);

            alarm.SetActiveState(SystemContext, active: false);
            alarm.InputNode.Value = new NodeId(m_trigger.NodeId);

            alarm.MaxTimeShelved.Value = maxTimeShelved;

            if (optional)
            {
                // This should not be working
                alarm.SetSuppressedState(SystemContext, suppressed: false);
                alarm.SetShelvingState(SystemContext, shelved: false, oneShot: false, shelvingTime: Double.MaxValue);
                
                alarm.OnShelve = OnShelve;
                alarm.OnTimedUnshelve = OnTimedUnshelve;
                alarm.UnshelveTimeUpdateRate = 2000;
            }
            else
            {
                //MemoryStream strm = new MemoryStream();
                //m_alarm.SaveAsBinary(SystemContext, strm);
                //string result = System.Text.Encoding.UTF8.GetString(strm.GetBuffer());
                //MemoryStream xmlStrm = new MemoryStream();
                //m_alarm.SaveAsXml(SystemContext, xmlStrm);
                //string xmlResult = System.Text.Encoding.UTF8.GetString(xmlStrm.GetBuffer());

                //bool wait = true;
            }
        }

        #region Overrides

        public override void SetValue(bool valueUpdated, string message = "")
        {
            bool setValue = false;
            if (ShouldEvent())
            {
                AlarmConditionState alarm = GetAlarm();
                alarm.SetActiveState(SystemContext, IsActive());

                setValue = true;
            }

            if ( UpdateShelving() || UpdateSuppression() )
            {
                setValue = true;
            }

            if (setValue)
            {
                base.SetValue(true, message);
            }
        }

        protected override bool GetRetainState()
        {
            AlarmConditionState alarm = GetAlarm();

            bool retainState = true;

            if (!alarm.ActiveState.Id.Value)
            {
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
            }

            return retainState;
        }

        protected override bool UpdateShelving()
        {
            // Don't have to worry about changing state to Unshelved, there is an SDK timer to deal with that.
            bool update = false;

            //if (Optional)
            //{
            //    AlarmConditionState alarm = GetAlarm();
            //    if (alarm.ShelvingState.UnshelveTime.Value > 0)
            //    {
            //        bool waiting = true;
            //    }

            //    object unshelveTimeObject = new object();
            //    alarm.OnReadUnshelveTime(SystemContext, null, ref unshelveTimeObject);
            //    double unshelveTime = (double)unshelveTimeObject;

            //    if (alarm.ShelvingState.UnshelveTime.Value > 0)
            //    {
            //        bool waiting = true;
            //    }

            //    if (unshelveTime != alarm.ShelvingState.UnshelveTime.Value)
            //    {
            //        alarm.ShelvingState.UnshelveTime.Value = unshelveTime;
            //        update = true;
            //    }
            //}

            return update;
        }

        protected override bool UpdateSuppression()
        {
            bool update = false;
            if ( Optional )
            {
                AlarmConditionState alarm = GetAlarm();

                if ( m_alarmController.ShouldSuppress() )
                {
                    alarm.SetSuppressedState(SystemContext, true);
                    update = true;
                }

                if (m_alarmController.ShouldUnsuppress())
                {
                    alarm.SetSuppressedState(SystemContext, false);
                    update = true;
                }
            }
            return update;
        }

        #endregion

        #region Helpers

        private AlarmConditionState GetAlarm()
        {
            return (AlarmConditionState)m_alarm;
        }

        #endregion

        #region Methods

        private ServiceResult OnShelve(
            ISystemContext context,
            AlarmConditionState alarm,
            bool shelving,
            bool oneShot,
            double shelvingTime)
        {
            alarm.Message.Value = "The alarm is shelved";
            alarm.SetShelvingState(context, shelving, oneShot, shelvingTime);

            return ServiceResult.Good;
        }

        /// <summary>
        /// Called when the alarm is shelved.
        /// </summary>
        private ServiceResult OnTimedUnshelve(
            ISystemContext context,
            AlarmConditionState alarm)
        {
            // update the alarm state and produce and event.
            alarm.Message.Value = "The timed shelving period expired.";
            alarm.SetShelvingState(context, false, false, 0);

            base.SetValue(true, alarm.Message.Value.Text );

            return ServiceResult.Good;
        }

        #endregion
    }
}
