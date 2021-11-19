using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Opc.Ua;

#pragma warning disable CS1591

namespace DreamsAndAdventures.ReferenceServer
{
    public class SteadyIntervalAlarmController : AlarmController
    {
        public SteadyIntervalAlarmController(BaseDataVariableState variable, int interval, bool isBoolean) :
            base(variable, interval, isBoolean: isBoolean)
        {
            m_value = m_midpoint;
        }

        protected override void GetValue(ref int intValue, ref bool boolValue)
        {
            int alarmValue = 75;
            int nonAlarmValue = m_midpoint;

            if (m_value == alarmValue)
            {
                m_value = nonAlarmValue;
                boolValue = true;
            }
            else
            {
                boolValue = false;
                m_value = alarmValue;
            }

            intValue = m_value;
            boolValue = false;
        }
    }
}
