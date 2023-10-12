using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Opc.Ua;
using Opc.Ua.Server;

#pragma warning disable CS1591

namespace FullAlarms
{
    public class DerivedNonExclusiveLevelAlarmType : NonExclusiveLevelAlarmState
    {

        public DerivedNonExclusiveLevelAlarmType(NodeState parent) : base(parent)
        {
        }

        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return AlarmHelpers.GetDefaultTypeDefinitionId(
                namespaceUris,
                Opc.Ua.ObjectTypeIds.NonExclusiveLevelAlarmType,
                Opc.Ua.BrowseNames.NonExclusiveLevelAlarmType);
        }

        public static BaseObjectTypeState CreateType(AlarmNodeManager nodeManager )
        {
            return AlarmHelpers.CreateType(nodeManager, Opc.Ua.ObjectTypeIds.NonExclusiveLevelAlarmType, Opc.Ua.BrowseNames.NonExclusiveLevelAlarmType);
        }
    }
}
