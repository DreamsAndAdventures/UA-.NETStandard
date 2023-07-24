using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Opc.Ua;
#pragma warning disable CS0219

namespace Quickstarts.ReferenceServer
{
    class ExclusiveLimitHolder : LimitAlarmTypeHolder
    {
        public ExclusiveLimitHolder(
            Alarms alarms,
            FolderState parent,
            SourceController trigger,
            string name,
            SupportedAlarmConditionType alarmConditionType,
            Type controllerType,
            int interval,
            bool optional = true,
            double maxShelveTime = Defines.NORMAL_MAX_TIME_SHELVED,
            bool create = true) :
            base(alarms, parent, trigger, name, alarmConditionType, controllerType, interval, optional, maxShelveTime, false)
        {
            if (create)
            {
                Initialize(Opc.Ua.ObjectTypes.ExclusiveLimitAlarmType, name, maxShelveTime);
            }
        }

        public new void Initialize(
            uint alarmTypeIdentifier,
            string name,
            double maxTimeShelved = Defines.NORMAL_MAX_TIME_SHELVED)
        {
            // Create an alarm and trigger name - Create a base method for creating the trigger, just provide the name

            if (m_alarm == null)
            {
                m_alarm = new ExclusiveLimitAlarmState(m_parent);
            }

            ExclusiveLimitAlarmState alarm = GetAlarm();

//            alarm.LimitState.LastTransition


            // Call the base class to set parameters
            base.Initialize(alarmTypeIdentifier, name, maxTimeShelved);

            alarm.SetLimitState(SystemContext, LimitAlarmStates.Inactive);
        }

        protected override ushort GetSeverity()
        {
            ushort severity = Defines.INACTIVE_SEVERITY;

            if ( Optional )
            {
                severity = base.GetSeverity();
            }
            else
            {
                int level = m_alarmController.GetValue();

                if ( level >= Defines.HIGH_ALARM && Analog )
                {
                    severity = Defines.HIGH_SEVERITY;
                }
            }

            return severity;
        }


        public override void SetValue(string message = "")
        {
            ExclusiveLimitAlarmState alarm = GetAlarm();
            int newSeverity = GetSeverity();
            int currentSeverity = alarm.Severity.Value;

            if (newSeverity != currentSeverity)
            {
                LimitAlarmStates state = LimitAlarmStates.Inactive;

                if ( Optional )
                {
                    if (newSeverity == Defines.HIGHHIGH_SEVERITY)
                    {
                        state = LimitAlarmStates.HighHigh;
                    }
                    else if (newSeverity == Defines.HIGH_SEVERITY)
                    {
                        state = LimitAlarmStates.High;
                    }
                    else if (newSeverity == Defines.LOW_SEVERITY)
                    {
                        state = LimitAlarmStates.Low;
                    }
                    else if (newSeverity == Defines.LOWLOW_SEVERITY)
                    {
                        state = LimitAlarmStates.LowLow;
                    }
                }
                else
                {
                    if (newSeverity == Defines.HIGH_SEVERITY || newSeverity == Defines.HIGHHIGH_SEVERITY )
                    {
                        state = LimitAlarmStates.High;
                    }
                }

                alarm.SetLimitState(SystemContext, state);
            }

            base.SetValue();
        }

        private ExclusiveLimitAlarmState GetAlarm()
        {
            return (ExclusiveLimitAlarmState)m_alarm;
        }

    }
}