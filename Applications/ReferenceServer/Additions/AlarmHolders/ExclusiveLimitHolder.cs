using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Opc.Ua;

namespace Quickstarts.ReferenceServer
{
    class ExclusiveLimitHolder : LimitAlarmTypeHolder
    {
        public ExclusiveLimitHolder(
            Alarms alarms,
            FolderState parent,
            string name,
            SupportedAlarmConditionType alarmConditionType,
            Type controllerType,
            int interval,
            bool optional = true,
            double maxShelveTime = Defines.NORMAL_MAX_TIME_SHELVED,
            bool create = true) :
            base(alarms, parent, name, alarmConditionType, controllerType, interval, optional, maxShelveTime, false)
        {
            if (create)
            {
                Initialize(parent, Opc.Ua.ObjectTypes.ExclusiveLimitAlarmType, name, alarmConditionType, optional, maxShelveTime);
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
                m_alarm = new ExclusiveLimitAlarmState(parent);
            }

            ExclusiveLimitAlarmState alarm = GetAlarm();

//            alarm.LimitState.LastTransition


            // Call the base class to set parameters
            base.Initialize(parent, alarmTypeIdentifier, name, alarmConditionType, optional, maxTimeShelved);

            alarm.SetLimitState(SystemContext, LimitAlarmStates.Inactive);
        }

        public override void SetValue(bool valueUpdated, string message = "")
        {
            if (valueUpdated)
            {
                ExclusiveLimitAlarmState alarm = GetAlarm();
                int newSeverity = GetSeverity();
                int currentSeverity = alarm.Severity.Value;

                if (newSeverity != currentSeverity)
                {
                    bool setState = true;

                    LimitAlarmStates state = LimitAlarmStates.Inactive;

                    if (newSeverity == Defines.HIGHHIGH_SEVERITY)
                    {
                        state = LimitAlarmStates.HighHigh;
                    }
                    else if (newSeverity == Defines.HIGH_SEVERITY)
                    {
                        state = LimitAlarmStates.High;
                    }
                    else if( Optional )
                    {
                        if (newSeverity == Defines.LOW_SEVERITY)
                        {
                            state = LimitAlarmStates.Low;
                        }
                        else if ( newSeverity == Defines.LOWLOW_SEVERITY )
                        {
                            state = LimitAlarmStates.LowLow;
                        }
                    }

                    alarm.SetLimitState(SystemContext, state);
                }

                base.SetValue(valueUpdated, message);
            }
        }

        private ExclusiveLimitAlarmState GetAlarm()
        {
            return (ExclusiveLimitAlarmState)m_alarm;
        }

    }
}
