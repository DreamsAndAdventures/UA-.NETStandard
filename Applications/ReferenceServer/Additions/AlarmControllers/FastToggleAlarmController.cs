using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Opc.Ua;

namespace Quickstarts.ReferenceServer
{
    public class FastToggleAlarmController : AlarmController
    {
        public FastToggleAlarmController(BaseDataVariableState variable, int interval, bool isBoolean) :
            base(variable, interval, isBoolean: true)
        {
            bool yup = true;
        }

        protected override bool CanSetValue()
        {
            return true;
        }


        protected override void GetValue(ref int intValue, ref bool boolValue)
        {
            if ( m_value != 100 )
            {
                m_value = 100;
                boolValue = true;
            }
            else
            {
                m_value = 50;
                boolValue = false;
            }

            intValue = m_value;
        }
    }
}
