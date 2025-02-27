#pragma warning disable CS0219 // Variable is assigned but its value is never used
#pragma warning disable CS0168 // Variable is declared but never used
#pragma warning disable CS0414


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Opc.Ua;

namespace Quickstarts.Servers.Aggregates
{
    internal class AggregateData
    {
        public AggregateData( string name, NodeId dataType, bool one )
        {
            string suffix = "Two";
            if (one)
            {
                suffix = "One";
            }

            m_name = name + suffix;
            m_dataName = name + "StartOfBadData" + suffix;
            m_dataType = dataType;
            m_one = one;


        }


        private string m_name;
        private string m_dataName;
        private NodeId m_dataType;
        private bool m_one;
        BaseDataVariableState m_variable = null;
        BaseDataVariableState m_badDataVariable = null;
        private int m_intervalLimit = 0;
        private int m_currentInterval = 0;
        private int m_badLimit = 0;
        private int m_currentBad = 0;
        Dictionary<string, DataValue> m_historian = null;

    }
}
