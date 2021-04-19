using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Opc.Ua;

namespace Quickstarts.ReferenceServer
{
    class BranchAlarmController : AlarmController
    {
        // This is really temporary
        private int m_branchCount = 0;

        public BranchAlarmController(BaseDataVariableState variable, int interval, bool isBoolean = false) :
            base(variable, interval, isBoolean)
        {

        }

        protected override bool CanSetValue()
        {
            bool setValue = base.CanSetValue();

            if ( setValue )
            {
                if ( m_branchCount > 0 && m_value == 50 && m_increment == true )
                {
                    setValue = false;
                }
            }

            return setValue;
        }

        protected override void GetValue(ref int intValue, ref bool boolValue)
        {
            int maxValue = 100;
            int minValue = 0;

            TypicalGetValue(minValue, maxValue, ref intValue, ref boolValue);


        }

        public override bool SupportBranch( )
        {
            return true;
        }

        public override void SetBranchCount(int count)
        {
            m_branchCount = count;
        }

    }
}
