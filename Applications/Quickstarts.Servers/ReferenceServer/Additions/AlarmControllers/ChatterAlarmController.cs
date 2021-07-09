using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Opc.Ua;

#pragma warning disable CS1591

namespace Quickstarts.ReferenceServer
{
    public class ChatterAlarmController : AlarmController
    {
        public ChatterAlarmController(BaseDataVariableState variable, int interval, bool isBoolean) :
            base( variable, interval, isBoolean: false )
        {
            m_value = 80;
        }

        protected override void GetValue(ref int intValue, ref bool boolValue)
        {
            int maxValue = 100;
            int minValue = 70;

            TypicalGetValue(minValue, maxValue, ref intValue, ref boolValue);
        }
    }
}
