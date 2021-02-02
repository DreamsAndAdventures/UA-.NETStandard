using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Opc.Ua;
using Opc.Ua.Server;

namespace Quickstarts.ReferenceServer
{
    public class DerivedSystemOffNormalAlarmType : SystemOffNormalAlarmState
    {

        public DerivedSystemOffNormalAlarmType(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(
                Defines.DERIVED_SYSTEM_OFF_NORMAL_ALARM_TYPE,
                Defines.DERIVED_SYSTEM_OFF_NORMAL_ALARM_TYPE_PRODUCT_URI,
                namespaceUris);
        }

        public static BaseObjectTypeState CreateType( ReferenceNodeManager nodeManager )
        {
            BaseObjectTypeState type = null;

            ConfigurationNodeManager configurationNodeManager =
                nodeManager.Server.NodeManager.ConfigurationNodeManager;

            NodeId parentNodeId = new NodeId(Opc.Ua.ObjectTypeIds.SystemOffNormalAlarmType);
            NodeState parent = configurationNodeManager.FindPredefinedNode(parentNodeId,
                null);

            if (parent != null)
            {
                type = new BaseObjectTypeState();

                type.SymbolicName = Defines.DERIVED_SYSTEM_OFF_NORMAL_ALARM_TYPE_NAME;
                type.SuperTypeId = parentNodeId;
                type.NodeId = new NodeId(Defines.DERIVED_SYSTEM_OFF_NORMAL_ALARM_TYPE, nodeManager.NamespaceIndex);
                type.BrowseName = new QualifiedName(Defines.DERIVED_SYSTEM_OFF_NORMAL_ALARM_TYPE_NAME, nodeManager.NamespaceIndex);
                type.DisplayName = type.BrowseName.Name;
                type.WriteMask = AttributeWriteMask.None;
                type.UserWriteMask = AttributeWriteMask.None;
                type.IsAbstract = false;

                nodeManager.PublicAddPredefinedNode(type);
            }

            return type;
        }
    }
}
