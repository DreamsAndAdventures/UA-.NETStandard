using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Opc.Ua;

namespace Quickstarts.ReferenceServer
{
    class DeviationController : AlarmController
    {
        private BaseDataVariableState m_setpointVariable = null;
        private int m_setpointValue = 0;
        private int m_actualValue = 0;

        public DeviationController(BaseDataVariableState variable, int interval, bool isBoolean = false ) :
            base(variable, interval, isBoolean )
        {
            m_actualValue = m_value;
            m_setpointValue = m_value;
        }

        public BaseDataVariableState Setpoint
        {
            set { m_setpointVariable = value; }
        }

        public int DeviationActualValue
        {
            get { return m_actualValue; }
        }

        public int DeviationSetpointValue
        {
            get { return m_setpointValue; }
        }

        public int Deviation
        {
            get
            {
                return m_actualValue - m_setpointValue;
            }
        }

        public override bool Update(ISystemContext systemContext)
        {
            bool valueSet = false;
            if (CanSetValue())
            {
                int value = 0;
                bool boolValue = false;
                GetValue(ref value, ref boolValue);

                int sineValue = CalcSine(0, 100, value);

                m_setpointValue = value;
                m_setpointVariable.Value = value;
                m_setpointVariable.Timestamp = DateTime.UtcNow;
                m_setpointVariable.ClearChangeMasks(systemContext, false);

                m_actualValue = sineValue;
                m_variable.Value = sineValue;
                m_variable.Timestamp = DateTime.UtcNow;
                m_variable.ClearChangeMasks(systemContext, false);

                valueSet = true;
            }

            return valueSet;
        }

    }
}
