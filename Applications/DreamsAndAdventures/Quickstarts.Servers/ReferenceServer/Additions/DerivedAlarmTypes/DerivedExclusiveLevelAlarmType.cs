using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Opc.Ua;
using Opc.Ua.Server;

#pragma warning disable CS1591

namespace DreamsAndAdventures.ReferenceServer
{
    public class DerivedExclusiveLevelAlarmType : ExclusiveLevelAlarmState
    {

        public DerivedExclusiveLevelAlarmType(NodeState parent) : base(parent)
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
            return Helpers.GetDefaultTypeDefinitionId(
                namespaceUris,
                Opc.Ua.ObjectTypeIds.ExclusiveLevelAlarmType,
                Opc.Ua.BrowseNames.ExclusiveLevelAlarmType);
        }

        public static BaseObjectTypeState CreateType( ReferenceNodeManager nodeManager )
        {
            return Helpers.CreateType(nodeManager, Opc.Ua.ObjectTypeIds.ExclusiveLevelAlarmType);
        }
    }
}
