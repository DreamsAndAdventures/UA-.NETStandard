using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Opc.Ua;

#pragma warning disable CS0219

namespace Quickstarts.ReferenceServer
{
    public class AlarmController
    {
        #region Variables

        protected BaseDataVariableState m_variable = null;
        protected int m_value = 0;
        protected bool m_increment = true;
        protected DateTime m_nextTime = DateTime.Now;
        protected DateTime m_stopTime = DateTime.Now;
        protected int m_interval = 0;
        protected bool m_isBoolean = false;
        protected bool m_allowChanges = false;
        protected bool m_reset = false;
        protected DateTime m_lastMaxValue = new DateTime();
        protected bool m_validLastMaxValue = false;

        #endregion


        public AlarmController(BaseDataVariableState variable, int interval, bool isBoolean)
        {
            m_variable = variable;
            m_interval = interval;
            m_isBoolean = isBoolean;
            m_increment = true;

            m_value = 50;
            m_stopTime = m_stopTime.AddYears(5);

            m_allowChanges = false;
        }

        public virtual void Start()
        {
            Stop();

            m_validLastMaxValue = false;

            m_nextTime = DateTime.Now;
            m_stopTime = DateTime.Now;
            m_stopTime = m_stopTime.AddMinutes(3);


            m_allowChanges = true;
        }

        public virtual void Stop()
        {
            m_value = 50;
            m_increment = true;
            m_allowChanges = false;

            m_reset = true;
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

        public void ManualWrite( object value )
        {
            if ( value.GetType().Name == "Int32" )
            {
                m_value = (Int32)value;
            }
            else
            {
                if ((bool)value )
                {
                    m_value = 70;
                    m_increment = true;
                }
                else
                {
                    m_value = 50;
                }
            }
            Type valueType = value.GetType();

//            m_value = value;
        }

        public virtual bool CanSetValue()
        {
            bool setValue = false;

            if ( DateTime.Now > m_stopTime )
            {
                Stop();
                m_stopTime = DateTime.Now;
                m_stopTime = m_stopTime.AddYears(5);
            }
            else if (m_allowChanges || m_reset)
            {
                m_reset = false;

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

        public virtual bool SupportBranch()
        {
            return false;
        }



        public virtual void SetBranchCount( int count )
        {

        }

        protected void TypicalGetValue(int minValue, int maxValue, ref int intValue, ref bool boolValue)
        {
            int incrementValue = 5;
            if (m_isBoolean)
            {
                incrementValue = 10;
            }
            if (m_increment)
            {
                m_value += incrementValue;
                if (m_value == maxValue)
                {
                    if ( m_validLastMaxValue )
                    {
                        Debug.WriteLine("Cycle Time " + (DateTime.Now - m_lastMaxValue).ToString() + " Interval " + m_interval.ToString());
                    }
                    m_lastMaxValue = DateTime.Now;
                    m_validLastMaxValue = true;

                    m_increment = false;
                }
            }
            else
            {
                m_value -= incrementValue;
                if (m_value == minValue)
                {
                    m_increment = true;
                }
            }

            intValue = m_value;
            boolValue = false;
            if (m_value >= 70 || m_value <= 30 )
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

        public virtual void OnAddComment()
        {

        }

        public virtual void OnAcknowledge()
        {

        }

        public virtual void OnConfirm()
        {

        }
    }
}