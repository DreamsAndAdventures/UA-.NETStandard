using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Alarms;
using Opc.Ua.Server;
using Opc.Ua;
using System.IO;
using System.Diagnostics;

namespace WorkOnImport
{
    #region Namespace Declarations
    /// <summary>
    /// Defines constants for all namespaces referenced by the model design.
    /// </summary>
    public static partial class Namespaces
    {
        /// <summary>
        /// The URI for the Alarms namespace (.NET code namespace is 'Alarms').
        /// </summary>
        public const string WorkOnImport = "http://dreamsandadventures.org/UA/WorkOnImport/";

        public const string DI = "http://opcfoundation.org/UA/DI/";
        public const string FxData = "http://opcfoundation.org/UA/FX/Data/";
        public const string FxAc = "http://opcfoundation.org/UA/FX/AC/";

    }
    #endregion

    /// <summary>
    /// The factory for the Alarm Node Manager.
    /// </summary>
    public class WorkOnImportManagerFactory : INodeManagerFactory
    {
        /// <inheritdoc/>
        public INodeManager Create(IServerInternal server, ApplicationConfiguration configuration)
        {
            return new WorkOnImportNodeManager(server, configuration, NamespacesUris.ToArray());
        }

        /// <inheritdoc/>
        public StringCollection NamespacesUris
        {
            get
            {
                StringCollection strings = new StringCollection();
                strings.Add(Namespaces.WorkOnImport);
                strings.Add(Namespaces.WorkOnImport + "Instance");
                strings.Add(Namespaces.DI);
                strings.Add(Namespaces.DI + "Instance");
                strings.Add(Namespaces.FxData);
                strings.Add(Namespaces.FxData + "Instance");
                strings.Add(Namespaces.FxAc);
                strings.Add(Namespaces.FxAc + "Instance");

                return strings;
            }
        }

    }

    public class WorkOnImportNodeManager : CustomNodeManager2
    {
        #region Constructors
        /// <summary>
        /// Initializes the node manager.
        /// </summary>
        public WorkOnImportNodeManager(IServerInternal server,
            ApplicationConfiguration configuration,
            string[] namespaceUris) :
            base(server, configuration, namespaceUris)
        {
        }
        #endregion

        #region IDisposable Members
        /// <summary>
        /// An overrideable version of the Dispose.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                DisposeTimer();
            }
            base.Dispose(disposing);
        }

        #endregion

        #region INodeIdFactory Members
        /// <summary>
        /// Creates the NodeId for the specified node.
        /// </summary>
        public override NodeId New(ISystemContext context, NodeState node)
        {
            BaseInstanceState instance = node as BaseInstanceState;

            if (instance != null && instance.Parent != null)
            {
                string id = instance.Parent.NodeId.Identifier as string;

                if (id != null)
                {
                    return new NodeId(id + "_" + instance.SymbolicName, instance.Parent.NodeId.NamespaceIndex);
                }
            }

            return node.NodeId;
        }
        #endregion


        #region INodeManager Members

        /// <summary>
        /// Does any initialization required before the address space can be used.
        /// </summary>
        /// <remarks>
        /// The externalReferences is an out parameter that allows the node manager to link to nodes
        /// in other node managers. For example, the 'Objects' node is managed by the CoreNodeManager and
        /// should have a reference to the root folder node(s) exposed by this node manager.  
        /// </remarks>
        public override void CreateAddressSpace(IDictionary<NodeId, IList<IReference>> externalReferences)
        {
            lock (Lock)
            {
                #region Setup

                IList<IReference> references = null;

                if (!externalReferences.TryGetValue(ObjectIds.ObjectsFolder, out references))
                {
                    externalReferences[ObjectIds.ObjectsFolder] = references = new List<IReference>();
                }

                List<NodeStateCollection> nodeStates = new List<NodeStateCollection>();

                #endregion

                try
                {
                    nodeStates.Add( ImportXml( externalReferences, "./NodeSets/Opc.Ua.Di.NodeSet2.Xml" ) );
                    nodeStates.Add( ImportXml( externalReferences, "./NodeSets/Opc.Ua.fx.data.NodeSet2.Xml" ) );
                    nodeStates.Add( ImportXml( externalReferences, "./NodeSets/Opc.Ua.fx.ac.NodeSet2.Xml" ) );

                    #region Initialize

        string FolderName = "WorkOnImport";
                    string FolderNodeName = FolderName;

                    #endregion

                    #region Create Folder

                    FolderState Folder = CreateFolder(null, FolderNodeName, FolderName);
                    Folder.AddReference(ReferenceTypes.Organizes, true, ObjectIds.ObjectsFolder);
                    references.Add(
                        new NodeStateReference(ReferenceTypes.Organizes, false, Folder.NodeId));

                    #endregion

                    #region Create Variable

                    string complexNumberVariableName = "ComplexNumber";
                    string complexNumberVariableNodeName = FolderNodeName + "." + complexNumberVariableName;

                    BaseDataVariableState complexNumberVariable = CreateVariable(Folder,
                        complexNumberVariableNodeName,
                        complexNumberVariableName,
                        DataTypeIds.ComplexNumberType,
                        ValueRanks.Scalar);

                    ComplexNumberType complexNumberType = new ComplexNumberType();
                    complexNumberType.Real = 123.456F;
                    complexNumberType.Imaginary = 789.012F;

                    complexNumberVariable.Value = new Variant(complexNumberType);

                    #endregion

                    AddPredefinedNode(SystemContext, Folder);

                    StartTimer();
                    m_allowEntry = true;

                }
                catch (Exception e)
                {
                    Utils.LogError(e, "Error creating the AlarmNodeManager address space.");
                }

            }
        }

        private NodeStateCollection ImportXml(IDictionary<NodeId, IList<IReference>> externalReferences, string resourcepath)
        {
            NodeStateCollection predefinedNodes = new NodeStateCollection();

            try
            {

                Stream stream = new FileStream(resourcepath, FileMode.Open);
                Opc.Ua.Export.UANodeSet nodeSet = Opc.Ua.Export.UANodeSet.Read(stream);

                ServerSystemContext context = SystemContext;
                NamespaceTable namespaceTable = SystemContext.NamespaceUris;
                

                foreach (string namespaceUri in nodeSet.NamespaceUris)
                {
                    ushort thisNamespaceIndex = SystemContext.NamespaceUris.GetIndexOrAppend(namespaceUri);
                }
                nodeSet.Import(SystemContext, predefinedNodes);

                for (int ii = 0; ii < predefinedNodes.Count; ii++)
                {
                    NodeState node = predefinedNodes[ii];
                    string nodeIdString = node.NodeId.ToString();

                    Debug.WriteLine(ii.ToString() + " Importing " + node.BrowseName.Name + " [" + nodeIdString + "] " + node.GetType().FullName);

                    try
                    {
                        AddPredefinedNode(SystemContext, node);
                    }
                    catch (Exception exception)
                    {
                        string superType = exception.Message;
                        BaseObjectTypeState baseObjectTypeState = node as BaseObjectTypeState;
                        ReferenceTypeState refState = node as ReferenceTypeState;

                        if (baseObjectTypeState != null)
                        {
                            superType = "SuperType " + baseObjectTypeState.SuperTypeId.ToString();
                        }
                        else if (refState != null)
                        {
                            superType = "Reference SuperType " + refState.SuperTypeId.ToString();
                        }

                        Debug.WriteLine("Unable to add item " +
                            node.BrowseName.Name + "[" + nodeIdString + "] " + superType );
                    }
                }
                // ensure the reverse refernces exist.
                AddReverseReferences(externalReferences);
            }
            catch (Exception ex)
            {
                Debug.WriteLine( ex.Message );
                throw;
            }

            return predefinedNodes;
        }

        /// <summary>
        /// Creates a new folder.
        /// </summary>
        private FolderState CreateFolder(NodeState parent, string path, string name)
        {
            FolderState folder = new FolderState(parent) {
                SymbolicName = name,
                ReferenceTypeId = ReferenceTypes.Organizes,
                TypeDefinitionId = ObjectTypeIds.FolderType,
                NodeId = new NodeId(path, NamespaceIndex),
                BrowseName = new QualifiedName(path, NamespaceIndex),
                DisplayName = new LocalizedText("en", name),
                WriteMask = AttributeWriteMask.None,
                UserWriteMask = AttributeWriteMask.None,
                EventNotifier = EventNotifiers.None
            };

            if (parent != null)
            {
                parent.AddChild(folder);
            }

            return folder;
        }

        /// <summary>
        /// Creates a new method.
        /// </summary>
        private MethodState CreateMethod(NodeState parent, string path, string name)
        {
            MethodState method = new MethodState(parent) {
                SymbolicName = name,
                ReferenceTypeId = ReferenceTypeIds.HasComponent,
                NodeId = new NodeId(path, NamespaceIndex),
                BrowseName = new QualifiedName(path, NamespaceIndex),
                DisplayName = new LocalizedText("en", name),
                WriteMask = AttributeWriteMask.None,
                UserWriteMask = AttributeWriteMask.None,
                Executable = true,
                UserExecutable = true
            };

            if (parent != null)
            {
                parent.AddChild(method);
            }

            return method;
        }

        private BaseDataVariableState CreateVariable(NodeState parent,
            string path, string name, NodeId dataType, int valueRank)
        {
            BaseDataVariableState variable = new BaseDataVariableState(parent);
            variable.SymbolicName = name;
            variable.ReferenceTypeId = ReferenceTypes.Organizes;
            variable.TypeDefinitionId = VariableTypeIds.BaseDataVariableType;
            variable.NodeId = new NodeId(path, NamespaceIndex);
            variable.BrowseName = new QualifiedName(path, NamespaceIndex);
            variable.DisplayName = new LocalizedText("en", name);
            variable.WriteMask = AttributeWriteMask.DisplayName | AttributeWriteMask.Description;
            variable.UserWriteMask = AttributeWriteMask.DisplayName | AttributeWriteMask.Description;
            variable.DataType = dataType;
            variable.ValueRank = valueRank;
            variable.AccessLevel = AccessLevels.CurrentReadOrWrite;
            variable.UserAccessLevel = AccessLevels.CurrentReadOrWrite;
            variable.Historizing = false;
            variable.Value = 0;
            variable.StatusCode = StatusCodes.Good;
            variable.Timestamp = DateTime.UtcNow;

            if (valueRank == ValueRanks.OneDimension)
            {
                variable.ArrayDimensions = new ReadOnlyList<uint>(new List<uint> { 0 });
            }
            else if (valueRank == ValueRanks.TwoDimensions)
            {
                variable.ArrayDimensions = new ReadOnlyList<uint>(new List<uint> { 0, 0 });
            }

            if (parent != null)
            {
                parent.AddChild(variable);
            }

            return variable;
        }

        private void DoSimulation(object state)
        {
            if (m_allowEntry)
            {
                m_allowEntry = false;

                try
                {

                    NodeState myOneVariable = Find(
                        new NodeId("Pi.SingleVariable", NamespaceIndex));
                    BaseDataVariableState variableState = myOneVariable as BaseDataVariableState;
                    if ( variableState != null )
                    {
                        variableState.Value = DateTime.UtcNow.Second;
                        variableState.Timestamp = DateTime.UtcNow;
                        variableState.ClearChangeMasks(SystemContext, false);
                    }
                }
                catch (Exception ex)
                {
                    Utils.LogInfo(ex, "Pi Loop Exception");
                }
                m_allowEntry = true;
            }
        }

        /// <summary>
        /// Starts the timer to detect Alarms.
        /// </summary>
        private void StartTimer()
        {
            Utils.SilentDispose(m_simulationTimer);
            m_simulationTimer = new Timer(DoSimulation, null, kSimulationInterval, kSimulationInterval);
        }

        /// <summary>
        /// Disposes the timer.
        /// </summary>
        private void DisposeTimer()
        {
            Utils.SilentDispose(m_simulationTimer);
            m_simulationTimer = null;
        }


        #endregion


        #region Private Fields

        private bool m_allowEntry = false;
        private const UInt16 kSimulationInterval = 100;
        private Timer m_simulationTimer;

        #endregion

    }
}
