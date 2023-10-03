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

namespace ArchieDataTypes
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
        public const string ArchieDataTypes = "http://dreamsandadventures.org/UA/ArchieDataTypes/";
    }
    #endregion

    /// <summary>
    /// The factory for the Alarm Node Manager.
    /// </summary>
    public class ArchieDataTypesManagerFactory : INodeManagerFactory
    {
        /// <inheritdoc/>
        public INodeManager Create(IServerInternal server, ApplicationConfiguration configuration)
        {
            return new ArchieDataTypesNodeManager(server, configuration, NamespacesUris.ToArray());
        }

        /// <inheritdoc/>
        public StringCollection NamespacesUris
        {
            get
            {
                var uri = Namespaces.ArchieDataTypes;
                var instanceUri = uri + "Instance";
                return new StringCollection { uri, instanceUri };
            }
        }

    }

    public class ArchieDataTypesNodeManager : CustomNodeManager2
    {
        #region Constructors
        /// <summary>
        /// Initializes the node manager.
        /// </summary>
        public ArchieDataTypesNodeManager(IServerInternal server,
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

                #endregion

                try
                {
                    #region Initialize
                        
                    string FolderName = "ArchieDataTypes";
                    string FolderNodeName = FolderName;

                    #endregion

                    #region Create Folder

                    FolderState Folder = CreateFolder(null, FolderNodeName, FolderName);
                    Folder.AddReference(ReferenceTypes.Organizes, true, ObjectIds.ObjectsFolder);
                    references.Add(
                        new NodeStateReference(ReferenceTypes.Organizes, false, Folder.NodeId));
                    Folder.EventNotifier = EventNotifiers.SubscribeToEvents;
                    AddRootNotifier(Folder);

                    #endregion

                    #region Create Variable

                    /*
                    string statusCodeVariableName = "StatusCode";
                    string statusCodeVariableNodeName = FolderNodeName + "." + statusCodeVariableName;

                    BaseDataVariableState statusCodeVariable = CreateVariable(Folder,
                        statusCodeVariableNodeName, statusCodeVariableName, DataTypeIds.StatusCode, ValueRanks.Scalar);

                    statusCodeVariable.Value = new StatusCode(StatusCodes.BadNodeIdInvalid);

                    string guidVariableName = "Guid";
                    string guidVariableNodeName = FolderNodeName + "." + guidVariableName;

                    BaseDataVariableState guidVariable = CreateVariable(Folder,
                        guidVariableNodeName, guidVariableName, DataTypeIds.Guid, ValueRanks.Scalar);

                    guidVariable.Value = Guid.NewGuid();

                    string qualifiedVariableName = "Qualified";
                    string qualifiedVariableNodeName = FolderNodeName + "." + qualifiedVariableName;

                    BaseDataVariableState qualifiedVariable = CreateVariable(Folder,
                        qualifiedVariableNodeName, qualifiedVariableName, DataTypeIds.QualifiedName, ValueRanks.Scalar);

                    qualifiedVariable.Value = new QualifiedName("MyQualifiedName", NamespaceIndex);

                    string nodeVariableName = "NodeId";
                    string nodeVariableNodeName = FolderNodeName + "." + nodeVariableName;

                    BaseDataVariableState nodeVariable = CreateVariable(Folder,
                        nodeVariableNodeName, nodeVariableName, DataTypeIds.NodeId, ValueRanks.Scalar);

                    nodeVariable.Value = new NodeId("AnyNodeId",NamespaceIndex);

                    string xnodeVariableName = "ExpandedNodeId";
                    string xnodeVariableNodeName = FolderNodeName + "." + xnodeVariableName;

                    BaseDataVariableState xnodeVariable = CreateVariable(Folder,
                        xnodeVariableNodeName, xnodeVariableName, DataTypeIds.ExpandedNodeId, ValueRanks.Scalar);

                    xnodeVariable.Value = new ExpandedNodeId("AnyExpandedNodeId", NamespaceIndex, Namespaces.ArchieDataTypes, NamespaceIndex);


                    string dataValueVariableName = "DataValue";
                    string dataValueVariableNodeName = FolderNodeName + "." + dataValueVariableName;

                    BaseDataVariableState dataValueVariable = CreateVariable(Folder,
                        dataValueVariableNodeName, dataValueVariableName, DataTypeIds.DataValue, ValueRanks.Scalar);

                    DataValue dataValue = new DataValue(new Variant(12345), new StatusCode(StatusCodes.BadAlreadyExists), DateTime.UtcNow, DateTime.UtcNow );
                    dataValue.SourcePicoseconds = 10;
                    dataValue.ServerPicoseconds = 5;

                    dataValueVariable.Value = dataValue;

                    string dateTimeVariableName = "DateTime";
                    string dateTimeVariableNodeName = FolderNodeName + "." + dateTimeVariableName;

                    BaseDataVariableState dateTimeVariable = CreateVariable(Folder,
                        dateTimeVariableNodeName, dateTimeVariableName, DataTypeIds.DateTime, ValueRanks.Scalar);

                    dateTimeVariable.Value = DateTime.UtcNow;


                    string complexDataValueVariableName = "ComplexDataValue";
                    string complexDataValueVariableNodeName = FolderNodeName + "." + complexDataValueVariableName;

                    BaseDataVariableState complexDataValueVariable = CreateVariable(Folder,
                        complexDataValueVariableNodeName, complexDataValueVariableName, DataTypeIds.DataValue, ValueRanks.Scalar);

                    DataValue complexDataValue = new DataValue(
                        new Variant(dataValue),
                        new StatusCode(StatusCodes.BadLicenseExpired),
                        DateTime.UtcNow,
                        DateTime.UtcNow);
                    complexDataValue.SourcePicoseconds = 10;
                    complexDataValue.ServerPicoseconds = 5;

                    complexDataValueVariable.Value = complexDataValue;
                    */


                    //string variantVariableName = "Variant";
                    //string variantVariableNodeName = FolderNodeName + "." + variantVariableName;

                    //BaseDataVariableState variantVariable = CreateVariable(Folder,
                    //    variantVariableNodeName, variantVariableName, DataTypeIds.Variant, ValueRanks.Scalar);

                    //variantVariable.Value = Guid.NewGuid();

                    //string diagnosticInfoVariableName = "DiagnosticInfo";
                    //string diagnosticInfoVariableNodeName = FolderNodeName + "." + diagnosticInfoVariableName;

                    //BaseDataVariableState diagnosticInfoVariable = CreateVariable(Folder,
                    //    diagnosticInfoVariableNodeName, diagnosticInfoVariableName, DataTypeIds.DiagnosticInfo, ValueRanks.Scalar);

                    //List<string> strings = new List<string>();
                    //strings.Add("A");
                    //strings.Add("list");
                    //strings.Add("of");
                    //strings.Add("strings");
                    //strings.Add("for");
                    //strings.Add("DiagnosticInfo");


                    //DiagnosticInfo help = new DiagnosticInfo();
                    //help.AdditionalInfo = "Whatever";
                    //help.InnerStatusCode = StatusCodes.BadTimeout;
                    //help.Locale = 11;
                    //help.LocalizedText = 22;
                    //help.NamespaceUri = 33;
                    //help.SymbolicId = 44;

                    //Variant embedDiagnosticVariant = new Variant(help);

                    //string embedDataValueVariableName = "EmbedDataValue";
                    //string embedDataValueVariableNodeName = FolderNodeName + "." + embedDataValueVariableName;

                    //BaseDataVariableState embedDataValueVariable = CreateVariable(Folder,
                    //    embedDataValueVariableNodeName, embedDataValueVariableName, DataTypeIds.DataValue, ValueRanks.Scalar);

                    //DataValue embedDataValue = new DataValue(embedDiagnosticVariant, new StatusCode(StatusCodes.BadAlreadyExists), DateTime.UtcNow, DateTime.UtcNow);

                    //embedDataValueVariable.Value = embedDataValue;


                    string enumerationVariableName = "Enumeration";
                    string enumerationVariableNodeName = FolderNodeName + "." + enumerationVariableName;

                    BaseDataVariableState enumerationVariable = CreateVariable(Folder,
                        enumerationVariableNodeName, enumerationVariableName, DataTypeIds.NodeClass, ValueRanks.Scalar);

                    enumerationVariable.Value = NodeClass.Variable;


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

                    //string complexNumberHolderVariableName = "complexNumberHolderDataValue";
                    //string complexNumberHolderVariableNodeName = FolderNodeName + "." + complexNumberHolderVariableName;

                    //BaseDataVariableState complexDataValueVariable = CreateVariable(Folder,
                    //    complexNumberHolderVariableNodeName, complexNumberHolderVariableName, DataTypeIds.DataValue, ValueRanks.Scalar);

                    //DataValue complexNumberHolderDataValue = new DataValue(
                    //    new Variant(complexNumberType),
                    //    new StatusCode(StatusCodes.BadLicenseExpired),
                    //    DateTime.UtcNow,
                    //    DateTime.UtcNow);

                    //complexDataValueVariable.Value = complexNumberHolderDataValue;


                    //string XXXVariableName = "XXX";
                    //string XXXVariableNodeName = FolderNodeName + "." + XXXVariableName;

                    //BaseDataVariableState XXXVariable = CreateVariable(Folder,
                    //    XXXVariableNodeName, XXXVariableName, DataTypeIds.XXX, ValueRanks.Scalar);

                    //XXXVariable.Value = Guid.NewGuid();

                    //string YYYVariableName = "YYYDataValue";
                    //string YYYVariableNodeName = FolderNodeName + "." + YYYVariableName;

                    //BaseDataVariableState complexDataValueVariable = CreateVariable(Folder,
                    //    YYYVariableNodeName, YYYVariableName, DataTypeIds.DataValue, ValueRanks.Scalar);

                    //DataValue YYYDataValue = new DataValue(
                    //    new Variant(XXX),
                    //    new StatusCode(StatusCodes.BadLicenseExpired),
                    //    DateTime.UtcNow,
                    //    DateTime.UtcNow);

                    //YYYVariable.Value = YYYDataValue;









                    //string XXXVariableName = "XXX";
                    //string XXXVariableNodeName = FolderNodeName + "." + XXXVariableName;

                    //BaseDataVariableState XXXVariable = CreateVariable(Folder,
                    //    XXXVariableNodeName, XXXVariableName, DataTypeIds.XXX, ValueRanks.Scalar);

                    //XXXVariable.Value = Guid.NewGuid();

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
