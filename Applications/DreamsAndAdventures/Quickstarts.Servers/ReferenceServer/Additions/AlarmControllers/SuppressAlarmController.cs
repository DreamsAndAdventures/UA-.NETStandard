using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Opc.Ua;

#pragma warning disable CS1591

namespace DreamsAndAdventures.ReferenceServer
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

        public override bool ShouldSuppress()
        {
            bool shouldSuppress = false;

            if (m_value == Defines.HIGH_ALARM && m_increment ||
                m_value == Defines.LOW_ALARM && !m_increment)
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
