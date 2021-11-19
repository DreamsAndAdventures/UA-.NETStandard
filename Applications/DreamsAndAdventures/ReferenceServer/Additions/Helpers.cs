using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Opc.Ua;
using Opc.Ua.Server;


namespace Quickstarts.ReferenceServer
{
    public class Helpers
    {

        public static FolderState CreateFolder(NodeState parent, ushort nameSpaceIndex, string path, string name )
        {
            FolderState folder = new FolderState(parent);

            folder.SymbolicName = name;
            folder.ReferenceTypeId = ReferenceTypes.Organizes;
            folder.TypeDefinitionId = ObjectTypeIds.FolderType;
            folder.NodeId = new NodeId(path, nameSpaceIndex);
            folder.BrowseName = new QualifiedName(path, nameSpaceIndex);
            folder.DisplayName = new LocalizedText("en", name);
            folder.WriteMask = AttributeWriteMask.None;
            folder.UserWriteMask = AttributeWriteMask.None;
            folder.EventNotifier = EventNotifiers.None;

            if (parent != null)
            {
                parent.AddChild(folder);
            }

            return folder;
        }

        public static BaseDataVariableState CreateVariable(NodeState parent, ushort nameSpaceIndex, string path, string name, bool boolValue = false)
        {
            uint dataTypeIdentifier = Opc.Ua.DataTypes.Int32;
            if ( boolValue )
            {
                dataTypeIdentifier = Opc.Ua.DataTypes.Boolean;
            }
            return CreateVariable(parent, nameSpaceIndex, path, name, dataTypeIdentifier);
        }

        public static BaseDataVariableState CreateVariable(NodeState parent, ushort nameSpaceIndex, string path, string name, uint dataTypeIdentifier)
        {
            BaseDataVariableState variable = new BaseDataVariableState(parent);

            variable.SymbolicName = name;
            variable.ReferenceTypeId = ReferenceTypes.Organizes;
            variable.TypeDefinitionId = VariableTypeIds.BaseDataVariableType;
            variable.NodeId = new NodeId(path, nameSpaceIndex);
            variable.BrowseName = new QualifiedName(name, nameSpaceIndex);
            variable.DisplayName = new LocalizedText("en", name);
            variable.WriteMask = AttributeWriteMask.DisplayName | AttributeWriteMask.Description;
            variable.UserWriteMask = AttributeWriteMask.DisplayName | AttributeWriteMask.Description;
            switch(dataTypeIdentifier)
            {
                case Opc.Ua.DataTypes.Boolean:
                    variable.DataType = DataTypeIds.Boolean;
                    variable.Value = false;
                    break;
                case Opc.Ua.DataTypes.Int32:
                    variable.DataType = DataTypeIds.Int32;
                    variable.Value = 50;
                    break;
                case Opc.Ua.DataTypes.Double:
                    variable.DataType = DataTypeIds.Int32;
                    variable.Value = 50.0;
                    break;

            }
            variable.ValueRank = ValueRanks.Scalar;
            variable.AccessLevel = AccessLevels.CurrentReadOrWrite;
            variable.UserAccessLevel = AccessLevels.CurrentReadOrWrite;
            variable.Historizing = false;
            variable.StatusCode = StatusCodes.Good;
            variable.Timestamp = DateTime.UtcNow;

            if (parent != null)
            {
                parent.AddChild(variable);
            }

            return variable;
        }

        public static MethodState CreateMethod(NodeState parent, ushort nameSpaceIndex, string path, string name)
        {
            MethodState method = new MethodState(parent);

            method.SymbolicName = name;
            method.ReferenceTypeId = ReferenceTypeIds.HasComponent;
            method.NodeId = new NodeId(path, nameSpaceIndex);
            method.BrowseName = new QualifiedName(path, nameSpaceIndex);
            method.DisplayName = new LocalizedText("en", name);
            method.WriteMask = AttributeWriteMask.None;
            method.UserWriteMask = AttributeWriteMask.None;
            method.Executable = true;
            method.UserExecutable = true;

            if (parent != null)
            {
                parent.AddChild(method);
            }

            return method;
        }

        public static BaseObjectTypeState CreateType(ReferenceNodeManager nodeManager, NodeId parentTypeNodeId)
        {
            BaseObjectTypeState type = null;

            ConfigurationNodeManager configurationNodeManager =
                nodeManager.Server.NodeManager.ConfigurationNodeManager;

            NodeState parent = configurationNodeManager.FindPredefinedNode(parentTypeNodeId, null);
            if (parent.NodeId.IdType == IdType.Numeric)
            {
                UInt32 parentId = (UInt32)parent.NodeId.Identifier;
                UInt32 derivedId = Defines.DERIVED_TYPE_OFFSET + parentId;
                NodeId derivedNodeId = new NodeId(derivedId, nodeManager.NamespaceIndex);

                if (parent != null)
                {
                    type = new BaseObjectTypeState();

                    type.SymbolicName = Defines.DERIVED_NAME + parent.SymbolicName;
                    type.SuperTypeId = parentTypeNodeId;
                    type.NodeId = new NodeId(derivedId, nodeManager.NamespaceIndex);
                    type.BrowseName = new QualifiedName(Defines.DERIVED_NAME + parent.BrowseName, nodeManager.NamespaceIndex);
                    type.DisplayName = type.BrowseName.Name;
                    type.WriteMask = AttributeWriteMask.None;
                    type.UserWriteMask = AttributeWriteMask.None;
                    type.IsAbstract = false;
//                    type.Is

                    nodeManager.PublicAddPredefinedNode(type);
                }
            }

            return type;
        }

        public static NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris, NodeId parentTypeNodeId, string parentTypeName )
        {
            if (parentTypeNodeId.IdType == IdType.Numeric)
            {
                UInt32 parentId = (UInt32)parentTypeNodeId.Identifier;
                UInt32 derivedId = Defines.DERIVED_TYPE_OFFSET + parentId;

                return Opc.Ua.NodeId.Create(
                    derivedId,
                    Namespaces.ReferenceApplications,
                    namespaceUris);
            }
            return Opc.Ua.NodeId.Create(0, "", namespaceUris);
        }

        public static UInt32 GetDerivedIdentifier(NodeId parent)
        {
            UInt32 id = 0;

            if (parent.IdType == IdType.Numeric)
            {
                id = GetDerivedIdentifier((UInt32)parent.Identifier);
            }

            return id;
        }


        public static UInt32 GetDerivedIdentifier( UInt32 parentIdentifier )
        {
            return parentIdentifier + Defines.DERIVED_TYPE_OFFSET;
        }

        public static NodeId GetDerivedNodeId( NodeId parent )
        {
            ushort yesThisIsBad = 2;
            return new NodeId(GetDerivedIdentifier(parent), yesThisIsBad);
        }

        public static NodeId GetDerivedNodeId(UInt32 parentIdentifier)
        {
            ushort yesThisIsBad = 2;
            return new NodeId(GetDerivedIdentifier(parentIdentifier), yesThisIsBad);
        }

    }
}
