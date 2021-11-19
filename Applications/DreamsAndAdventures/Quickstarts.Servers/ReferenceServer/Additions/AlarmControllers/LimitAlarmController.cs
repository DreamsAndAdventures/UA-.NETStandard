using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Opc.Ua;

namespace DreamsAndAdventures.ReferenceServer
{
    class LimitAlarmController : AlarmController
    {
        public LimitAlarmController(BaseDataVariableState variable, int interval, bool isBoolean) :
            base(variable, interval, isBoolean: false)
        {
        }

        protected override void GetValue(ref int intValue, ref bool boolValue)
        {
            int maxValue = 100;
            int minValue = 40;

            TypicalGetValue(minValue, maxValue, ref intValue, ref boolValue);
        }
    }
}
