using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Opc.Ua;

#pragma warning disable CS1591

namespace DreamsAndAdventures.ReferenceServer
{
    public class SuppressWhileActiveAlarmController : SuppressAlarmController
    {
        public SuppressWhileActiveAlarmController(BaseDataVariableState variable, int interval, bool isBoolean )
            : base ( variable, interval, isBoolean, unsuppressWhenActive: true )
        {
        }
    }
}