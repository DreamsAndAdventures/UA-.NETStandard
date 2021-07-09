using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Opc.Ua;
using Opc.Ua.Server;

#pragma warning disable CS1591

namespace Quickstarts.ReferenceServer
{
    public class DerivedSystemOffNormalAlarmType : SystemOffNormalAlarmState
    {

        public DerivedSystemOffNormalAlarmType(NodeState parent) : base(parent)
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
                Opc.Ua.ObjectTypeIds.SystemOffNormalAlarmType,
                Opc.Ua.BrowseNames.SystemOffNormalAlarmType);
        }

        public static BaseObjectTypeState CreateType( ReferenceNodeManager nodeManager )
        {
            return Helpers.CreateType(nodeManager, Opc.Ua.ObjectTypeIds.SystemOffNormalAlarmType);
        }
    }
}
