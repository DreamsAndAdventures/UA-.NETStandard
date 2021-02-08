using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Opc.Ua;

namespace Quickstarts.ReferenceServer
{
    class NonExclusiveLimitHolder : LimitAlarmTypeHolder
    {
        public NonExclusiveLimitHolder(
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
                Initialize(parent, Opc.Ua.ObjectTypes.NonExclusiveLimitAlarmType, name, alarmConditionType, optional, maxShelveTime);
            }
        }

        public void Initialize(
            FolderState parent,
            uint alarmTypeIdentifier,
            string name,
            SupportedAlarmConditionType alarmConditionType,
            bool optional = true,
            double maxTimeShelved = Defines.NORMAL_MAX_TIME_SHELVED,
            bool isLimit = true )
        {
            // Create an alarm and trigger name - Create a base method for creating the trigger, just provide the name

            if (m_alarm == null)
            {
                m_alarm = new NonExclusiveLimitAlarmState(parent);
            }

            NonExclusiveLimitAlarmState alarm = GetAlarm();

            alarm.HighState = new TwoStateVariableState(alarm);

            if ( Optional )
            {
                alarm.HighHighState = new TwoStateVariableState(alarm);
                alarm.LowState = new TwoStateVariableState(alarm);
                alarm.LowLowState = new TwoStateVariableState(alarm);
            }

            // Call the base class to set parameters
            base.Initialize(parent, alarmTypeIdentifier, name, alarmConditionType, optional, maxTimeShelved, isLimit);

            alarm.SetLimitState(SystemContext, LimitAlarmStates.Inactive);

        }

        public override void SetValue(bool valueUpdated, string message = "")
        {
            if (valueUpdated)
            {
                NonExclusiveLimitAlarmState alarm = GetAlarm();
                int newSeverity = GetSeverity();
                int currentSeverity = alarm.Severity.Value;

                LimitAlarmStates state = LimitAlarmStates.Inactive;

                if (newSeverity == Defines.HIGHHIGH_SEVERITY)
                {
                    state = LimitAlarmStates.HighHigh;
                }
                else if (newSeverity == Defines.HIGH_SEVERITY )
                {
                    state = LimitAlarmStates.High;
                }
                else if( Optional )
                {
                    if (newSeverity == Defines.LOWLOW_SEVERITY)
                    {
                        state = LimitAlarmStates.LowLow;
                    }
                    else if (newSeverity == Defines.LOW_SEVERITY)
                    {
                        state = LimitAlarmStates.Low;
                    }
                }

                alarm.SetLimitState(SystemContext, state);

                base.SetValue(valueUpdated, message);
            }
        }

        private NonExclusiveLimitAlarmState GetAlarm()
        {
            return (NonExclusiveLimitAlarmState)m_alarm;
        }

    }
}
