using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Opc.Ua;

namespace Quickstarts.ReferenceServer
{
    class LimitAlarmTypeHolder : AlarmConditionTypeHolder
    {
        private bool m_isLimit = true;

        public LimitAlarmTypeHolder(
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
                Initialize(parent, Opc.Ua.ObjectTypes.LimitAlarmType, name, alarmConditionType, optional, maxShelveTime);
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
                m_alarm = new LimitAlarmState(parent);
            }

            m_isLimit = isLimit;

            LimitAlarmState alarm = GetAlarm();

            if (alarm.HighLimit == null)
            {
                alarm.HighLimit = new PropertyState<double>(alarm);
            }

            if ( !m_isLimit)
            {
                if (alarm.HighHighLimit == null)
                {
                    alarm.HighHighLimit = new PropertyState<double>(alarm);
                }
                if (alarm.LowLimit == null)
                {
                    alarm.LowLimit = new PropertyState<double>(alarm);
                }
                if (alarm.LowLowLimit == null)
                {
                    alarm.LowLowLimit = new PropertyState<double>(alarm);
                }
            }

            if (optional)
            {
                alarm.BaseHighLimit = new PropertyState<double>(alarm);
                if (!m_isLimit)
                {
                    alarm.BaseHighHighLimit = new PropertyState<double>(alarm);
                    alarm.BaseLowLimit = new PropertyState<double>(alarm);
                    alarm.BaseLowLowLimit = new PropertyState<double>(alarm);
                }
            }

            // Call the base class to set parameters
            base.Initialize(parent, alarmTypeIdentifier, name, alarmConditionType, optional, maxTimeShelved);

            alarm.HighLimit.Value = Defines.HIGH_ALARM;

            if (!m_isLimit)
            {
                alarm.HighHighLimit.Value = Defines.HIGHHIGH_ALARM;
                alarm.LowLimit.Value = Defines.LOW_ALARM;
                alarm.LowLowLimit.Value = Defines.LOWLOW_ALARM;
            }

            if (optional)
            {
                alarm.BaseHighLimit.Value = Defines.HIGH_ALARM;

                if (!m_isLimit)
                {
                    alarm.BaseHighHighLimit.Value = Defines.HIGHHIGH_ALARM;
                    alarm.BaseLowLimit.Value = Defines.LOW_ALARM;
                    alarm.BaseLowLowLimit.Value = Defines.LOWLOW_ALARM;
                }
            }
        }

        #region Helpers

        private LimitAlarmState GetAlarm()
        {
            return (LimitAlarmState)m_alarm;
        }

        #endregion


    }
}