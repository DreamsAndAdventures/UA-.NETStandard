using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Opc.Ua;

namespace Quickstarts.ReferenceServer
{
    class RateOfChangeController : AlarmController
    {
        private const int m_baseIncrementValue = 5;
        private int m_nextIncrementValue = m_baseIncrementValue;
        private const int m_startValue = Defines.RATEOFCHANGE_MAXIMUM / 2;
        private int m_previousValue = m_startValue;
        private double m_spanInSeconds = 0.0;
        private DateTime m_previousTime;
        private int m_rateOfChange = 0;
        private bool m_canCalculateRateOfChange = false;

        public RateOfChangeController(BaseDataVariableState variable, int interval, bool isBoolean = false ) :
            base(variable, interval, isBoolean )
        {
            m_value = m_startValue;
            m_canCalculateRateOfChange = false;
            m_rateOfChange = 0;
            m_previousTime = DateTime.Now;
        }

        public override void Stop()
        {
            m_value = m_startValue;
            m_previousValue = m_startValue;
            m_previousTime = DateTime.Now;
            m_canCalculateRateOfChange = false;
            m_rateOfChange = 0;
            m_nextIncrementValue = m_baseIncrementValue;
            m_increment = true;
            m_allowChanges = false;

            m_reset = true;
        }



        public void WriteCurrentValue( ISystemContext systemContext )
        {
            m_variable.Value = m_value;
            m_variable.Timestamp = DateTime.UtcNow;
            m_variable.ClearChangeMasks(systemContext, false);
        }

        public int PreviousValue
        {
            get { return m_previousValue; }
        }

        public DateTime PreviousTime
        {
            get { return m_previousTime; }
        }

        public double SpanTime
        {
            get { return m_spanInSeconds;  }
        }

        public int RateOfChange
        {
            get { return m_rateOfChange; }
        }

        protected override void GetValue(ref int intValue, ref bool boolValue)
        {
            int maxValue = Defines.RATEOFCHANGE_MAXIMUM;
            int minValue = Defines.RATEOFCHANGE_MINIMUM;

            int incrementValue = m_nextIncrementValue;
            DateTime nowTime = DateTime.Now;
            m_spanInSeconds = (nowTime - m_previousTime).TotalSeconds;
            m_previousValue = m_value;
            m_previousTime = nowTime;


            if (m_increment)
            {
                m_value += incrementValue;
                if (m_value >= maxValue)
                {
                    m_increment = false;
                }
            }
            else
            {
                m_value -= incrementValue;
                if (m_value <= minValue)
                {
                    m_increment = true;
                }
            }

            if (m_canCalculateRateOfChange)
            {
                m_rateOfChange = (int)((m_value - m_previousValue) / m_spanInSeconds);
            }
            else
            {
                m_canCalculateRateOfChange = true;
            }


            int nextIncrementValue = m_baseIncrementValue;

            if (m_value >= Defines.RATEOFCHANGE_HIGHHIGH_THRESHOLD)
            {
                nextIncrementValue = m_baseIncrementValue * 4;
            }
            else if (m_value > Defines.RATEOFCHANGE_HIGH_THRESHOLD)
            {
                nextIncrementValue = m_baseIncrementValue * 2;
            }
            else if (m_value <= Defines.RATEOFCHANGE_LOWLOW_THRESHOLD)
            {
                nextIncrementValue = m_baseIncrementValue * 4;
            }
            else if (m_value <= Defines.RATEOFCHANGE_LOW_THRESHOLD)
            {
                nextIncrementValue = m_baseIncrementValue * 2;
            }

            m_nextIncrementValue = nextIncrementValue;

            Debug.WriteLine("RateOfChangeController::GetValue() Start Value " + m_previousValue.ToString() +
                "  Increment " + incrementValue + " Current Value " + m_value.ToString() + " next Increment " + m_nextIncrementValue.ToString() );


            intValue = m_value;
            boolValue = false;
            if (m_value >= Defines.RATEOFCHANGE_HIGH_THRESHOLD || m_value <= Defines.RATEOFCHANGE_LOW_THRESHOLD)
            {
                boolValue = true;
            }
        }

    }
}
