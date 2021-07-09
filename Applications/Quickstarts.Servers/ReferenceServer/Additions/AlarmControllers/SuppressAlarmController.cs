using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Opc.Ua;

#pragma warning disable CS1591

namespace Quickstarts.ReferenceServer
{
    public class SuppressAlarmController : AlarmController
    {
        #region Variables

        protected bool m_unsuppressWhenActive = true;

        #endregion

        public SuppressAlarmController(BaseDataVariableState variable, int interval, bool isBoolean, bool unsuppressWhenActive ) :
            base(variable, interval, isBoolean)
        {
            m_unsuppressWhenActive = unsuppressWhenActive;
        }

        protected override void GetValue(ref int intValue, ref bool boolValue)
        {
            int maxValue = 100;
            int minValue = 0;

            if (m_increment)
            {
                m_value += 5;
                if (m_value == maxValue)
                {
                    m_increment = false;
                }
            }
            else
            {
                m_value -= 5;
                if (m_value == minValue)
                {
                    m_increment = true;
                }
            }

            intValue = m_value;
            boolValue = false;
            if (m_value > 50)
            {
                boolValue = true;
            }

        }

        public override bool ShouldSuppress()
        {
            bool shouldSuppress = false;

            if (m_value == 70 && m_increment ||
                m_value == 30 && !m_increment)
            {
                shouldSuppress = true;
            }

            return shouldSuppress;
        }

        public override bool ShouldUnsuppress()
        {
            bool shouldUnsuppress = false;

            if (m_unsuppressWhenActive)
            {
                if (m_value % 100 == 0)
                {
                    shouldUnsuppress = true;
                }
            }
            else
            {
                if (m_increment && m_value == 40)
                {
                    shouldUnsuppress = true;
                }
                else if (!m_increment && m_value == 60)
                {
                    shouldUnsuppress = true;
                }
            }

            return shouldUnsuppress;
        }


    }

}
