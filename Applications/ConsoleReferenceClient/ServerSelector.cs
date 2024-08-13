/* ========================================================================
 * Copyright (c) 2005-2024 The OPC Foundation, Inc. All rights reserved.
 *
 * OPC Foundation MIT License 1.00
 * 
 * Permission is hereby granted, free of charge, to any person
 * obtaining a copy of this software and associated documentation
 * files (the "Software"), to deal in the Software without
 * restriction, including without limitation the rights to use,
 * copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the
 * Software is furnished to do so, subject to the following
 * conditions:
 * 
 * The above copyright notice and this permission notice shall be
 * included in all copies or substantial portions of the Software.
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
 * EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
 * OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
 * NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
 * HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
 * WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
 * FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
 * OTHER DEALINGS IN THE SOFTWARE.
 *
 * The complete license agreement can be found here:
 * http://opcfoundation.org/License/MIT/1.00/
 * ======================================================================*/


#define Use_Reference_Server
//#define Use_Demo_Server

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Opc.Ua;

namespace Quickstarts.ConsoleReferenceClient
{
    internal class ServerSelector
    {
#if Use_Reference_Server

        // if using Demo Server to test SetDurableSubscription, it is necessary to use command line parameter -ds

        public static Uri serverUrl = new Uri("opc.tcp://localhost:62541/Quickstarts/ReferenceServer");

        public static readonly NodeId intWriteValueNodeId = new NodeId("ns=2;s=Scalar_Static_Int32");
        public static readonly NodeId floatWriteValueNodeId = new NodeId("ns=2;s=Scalar_Static_Float");
        public static readonly NodeId stringWriteValueNodeId = new NodeId("ns=2;s=Scalar_Static_String");

        public static readonly NodeId intMoniteredNodeId = new NodeId("ns=2;s=Scalar_Simulation_Int32");
        public static readonly NodeId floatMonitoredNodeId = new NodeId("ns=2;s=Scalar_Simulation_Float");
        public static readonly NodeId stringMonitoredNodeId = new NodeId("ns=2;s=Scalar_Simulation_String");

        public static readonly NodeId methodObjectIdNodeId = new NodeId("ns=2;s=Methods");
        public static readonly NodeId methodMethodIdNodeId = new NodeId("ns=2;s=Methods_Add");

        public static object[] GetMethodInputArguments()
        {
            return new object[] { (float)10.5, (uint)10 };
        }

        public static readonly NodeId enableEventObjectIdNodeId = new NodeId("ns=7;s=Alarms");
        public static readonly NodeId enableEventMethodIdNodeId = new NodeId("ns=7;s=Alarms.Start");

        public static object[] GetStartEventInputArguments(uint timeToRun)
        {
            return new object[] { timeToRun };
        }

        public static readonly bool FilterEvents = true;

#endif

#if Use_Demo_Server

        // if using Demo Server to test SetDurableSubscription, it is necessary to login with john/master
        // command line parameters: -un john -up master -ds 

        public static Uri serverUrl = new Uri("opc.tcp://localhost:48010");

        public static readonly NodeId intWriteValueNodeId = new NodeId("ns=3;s=Demo.Static.Scalar.Int32");
        public static readonly NodeId floatWriteValueNodeId = new NodeId("ns=3;s=Demo.Static.Scalar.Float");
        public static readonly NodeId stringWriteValueNodeId = new NodeId("ns=3;s=Demo.Static.Scalar.String");

        public static readonly NodeId intMoniteredNodeId = new NodeId("ns=3;s=Demo.Dynamic.Scalar.Int32");
        public static readonly NodeId floatMonitoredNodeId = new NodeId("ns=3;s=Demo.Dynamic.Scalar.Float");
        public static readonly NodeId stringMonitoredNodeId = new NodeId("ns=3;s=Demo.Dynamic.Scalar.String");

        public static readonly NodeId methodObjectIdNodeId = new NodeId("ns=3;s=Demo.Method");
        public static readonly NodeId methodMethodIdNodeId = new NodeId("ns=3;s=Demo.Method.Multiply");

        public static object[] GetMethodInputArguments()
        {
            return new object[] { (double)10.5, (double)10 };
        }

        public static readonly NodeId enableEventObjectIdNodeId = new NodeId("ns=3;s=Demo.Events");
        public static readonly NodeId enableEventMethodIdNodeId = new NodeId("ns=3;s=Demo.Events.TriggerMultipleEvents");

        public static object[] GetStartEventInputArguments(uint timeToRun)
        {
            uint triggerMultipleEventsCount = 10;

            return new object[] { triggerMultipleEventsCount };  
        }

        public static readonly bool FilterEvents = false;

#endif

    }
}
