using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Opc.Ua;

namespace Quickstarts.ReferenceServer
{
    public class AlarmController
    {
        #region Variables

        protected BaseDataVariableState m_variable = null;
        protected int m_value = 0;
        protected bool m_increment = true;
        protected DateTime m_nextTime = DateTime.Now;
        protected int m_interval = 0;
        protected bool m_isBoolean = false;
        protected bool m_allowChanges = false;

        #endregion


        public AlarmController(BaseDataVariableState variable, int interval, bool isBoolean)
        {
            m_variable = variable;
            m_interval = interval;
            m_isBoolean = isBoolean;
            m_increment = true;

            m_value = 50;

            m_nextTime = DateTime.Now;
            if (m_interval == 0)
            {
                m_allowChanges = false;
            }
            else
            {
                m_allowChanges = true;
            }

            // Change this.  for 2000 the goal was to get to alarm in two seconds, and get out of alarm two seconds later.
            // That means I need to change my values much faster, as my interval is max one second.


            m_nextTime = m_nextTime.AddMilliseconds(m_interval);
        }

        public bool Update(ISystemContext systemContext)
        {
            bool valueSet = false;
            if (CanSetValue())
            {
                int value = 0;
                bool boolValue = false;
                GetValue(ref value, ref boolValue);

                if (m_isBoolean)
                {
                    if ( this.GetType().Name == "AlarmController" && boolValue == false )
                    {
                        bool waiting = true;
                    }
                    m_variable.Value = boolValue;
                }
                else
                {
                    m_variable.Value = value;
                }
                m_variable.Timestamp = DateTime.UtcNow;
                m_variable.ClearChangeMasks(systemContext, false);

                valueSet = true;
            }

            return valueSet;
        }

        private void SetNextInterval()
        {
            m_nextTime = DateTime.Now;

            m_nextTime = m_nextTime.AddMilliseconds(m_interval);
        }

        protected virtual bool CanSetValue()
        {
            bool setValue = false;

            if (m_allowChanges)
            {
                if (DateTime.Now > m_nextTime)
                {
                    SetNextInterval();
                    setValue = true;
                }
            }

            return setValue;
        }

        protected virtual void GetValue(ref int intValue, ref bool boolValue)
        {
            int maxValue = 100;
            int minValue = 0;

            TypicalGetValue(minValue, maxValue, ref intValue, ref boolValue);
        }

        protected virtual bool SupportsBranching()
        {
            return false;
        }

        protected void TypicalGetValue(int minValue, int maxValue, ref int intValue, ref bool boolValue)
        {
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

        public bool IsBooleanActive()
        {
            bool isActive = false;
            if (m_value > 50)
            {
                isActive = true;
            }
            return isActive;
        }

        public int GetValue()
        {
            return m_value;
        }

        public virtual bool ShouldSuppress()
        {
            return false;
        }

        public virtual bool ShouldUnsuppress()
        {
            return false;
        }
    }
}
