using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Opc.Ua;

namespace Quickstarts.ReferenceServer
{
    public class SteadyIntervalAlarmController : AlarmController
    {
        public SteadyIntervalAlarmController(BaseDataVariableState variable, int interval, bool isBoolean) :
            base(variable, interval, isBoolean: false)
        {
            m_value = 80;
        }

        protected override void GetValue(ref int intValue, ref bool boolValue)
        {
            int alarmValue = 75;
            int nonAlarmValue = 50;

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
