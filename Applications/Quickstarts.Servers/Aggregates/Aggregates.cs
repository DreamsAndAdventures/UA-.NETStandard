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
using System.Xml.Linq;
using System.Runtime.CompilerServices;
using System.Data;

#pragma warning disable CS0219 // Variable is assigned but its value is never used

namespace Aggregates
{
    #region Namespace Declarations
    /// <summary>
    /// Defines constants for all namespaces referenced by the model design.
    /// </summary>
    public static partial class Namespaces
    {
        /// <summary>
        /// The URI for the Aggregates namespace (.NET code namespace is 'Aggregates').
        /// </summary>
        public const string Aggregates = "http://dreamsandadventures.org/UA/Aggregates/";
    }
    #endregion

    /// <summary>
    /// The factory for the Aggregates Node Manager.
    /// </summary>
    public class AggregatesManagerFactory : INodeManagerFactory
    {
        /// <inheritdoc/>
        public INodeManager Create(IServerInternal server, ApplicationConfiguration configuration)
        {
            return new AggregatesNodeManager(server, configuration, NamespacesUris.ToArray());
        }

        /// <inheritdoc/>
        public StringCollection NamespacesUris
        {
            get
            {
                var uri = Namespaces.Aggregates;
                var instanceUri = uri + "Instance";
                return new StringCollection { uri, instanceUri };
            }
        }

    }

    public class AggregatesNodeManager : CustomNodeManager2
    {
        #region Constructors
        /// <summary>
        /// Initializes the node manager.
        /// </summary>
        public AggregatesNodeManager(IServerInternal server,
            ApplicationConfiguration configuration,
            string[] namespaceUris) :
            base(server, configuration, namespaceUris)
        {
            QuoteOneValues = new List<string>(QuoteOne.Split(' '));
            QuoteTwoValues = new List<string>(QuoteTwo.Split(' '));
            QuoteThreeValues = new List<string>(QuoteThree.Split(' '));

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

                    string AggregatesName = "Aggregates";
                    string AggregatesNodeName = AggregatesName;

                    #endregion

                    #region Create Folder

                    FolderState AggregatesFolder = CreateFolder(null, AggregatesNodeName, AggregatesName);
                    AggregatesFolder.AddReference(ReferenceTypes.Organizes, true, ObjectIds.ObjectsFolder);
                    references.Add(
                        new NodeStateReference(ReferenceTypes.Organizes, false, AggregatesFolder.NodeId));

                    string SpecName = "Spec";
                    string SpecNodeName = AggregatesName + "." + SpecName;
                    FolderState SpecFolder = CreateFolder(AggregatesFolder, SpecNodeName, SpecName);

                    string definedHistoricalDataConfigurationName = "HA Configuration";
                    string historicalDataConfigurationType = "HistoricalDataConfigurationType";
                    string historicalDataConfigurationTypeName = AggregatesName + "." + historicalDataConfigurationType;

                    NodeState historicalDataConfigurationState = CreateConfig(AggregatesFolder,
                        historicalDataConfigurationTypeName,
                        definedHistoricalDataConfigurationName,
                        percentBad: 100,
                        percentGood: 100,
                        uncertainAsBad: false,
                        slopedExtrapolation: false,
                        stepped: false);

                    string subObjectType = "AnotherObject";
                    string subObjectTypeName = AggregatesName + "." + subObjectType;

                    BaseObjectState subObjectState = CreateObject(historicalDataConfigurationState,
                        subObjectTypeName,
                        subObjectType,
                        ReferenceTypes.Organizes,
                        ObjectTypeIds.BaseObjectType);

                    string noConfigurationName = "NoConfiguration";
                    string noConfigurationNodeName = AggregatesName + "." + noConfigurationName;

                    FolderState noConfigurationFolder = CreateFolder(AggregatesFolder, noConfigurationNodeName, noConfigurationName);

                    #endregion

                    #region Spec Variables

                    int historians = 5;
                    for (int index = 1; index <= historians; index++)
                    {
                        string name = "Historian_" + index.ToString();
                        string nodeName = SpecNodeName + "." + name;

                        NodeId dataType = DataTypeIds.Byte;
                        if (index == BoolVariableIndex)
                        {
                            dataType = DataTypeIds.Boolean;
                        }

                        BaseDataVariableState variable = CreateVariable(SpecFolder, nodeName, name, dataType, ValueRanks.Scalar);
                        variable.AccessLevel = AccessLevels.HistoryRead;
                        variable.UserAccessLevel = AccessLevels.HistoryRead;
                        variable.AccessLevelEx = AccessLevels.HistoryRead;

                        Variables.Add(name, variable);

                        string configName = "HistoricalDataConfiguration";
                        string configNodeName = nodeName + "." + configName;

                        switch (index)
                        {
                            case 1:
                            {
                                HistoricalDataConfigurationState state = CreateConfig(variable,
                                    configNodeName,
                                    definedHistoricalDataConfigurationName,
                                    percentBad: 100,
                                    percentGood: 100,
                                    uncertainAsBad: false,
                                    slopedExtrapolation: false,
                                    stepped: false);

                                state.ReferenceTypeId = Opc.Ua.ReferenceTypeIds.HasHistoricalConfiguration;

                                break;
                            }
                            case 2:
                            {
                                HistoricalDataConfigurationState state = CreateConfig(variable,
                                    configNodeName,
                                    definedHistoricalDataConfigurationName,
                                    percentBad: 100,
                                    percentGood: 100,
                                    uncertainAsBad: true,
                                    slopedExtrapolation: true,
                                    stepped: false);

                                state.ReferenceTypeId = Opc.Ua.ReferenceTypeIds.HasHistoricalConfiguration;


                                break;
                            }
                            case 3:
                            {
                                HistoricalDataConfigurationState state = CreateConfig(variable,
                                    configNodeName,
                                    definedHistoricalDataConfigurationName,
                                    percentBad: 50,
                                    percentGood: 50,
                                    uncertainAsBad: true,
                                    slopedExtrapolation: false,
                                    stepped: true);

                                state.ReferenceTypeId = Opc.Ua.ReferenceTypeIds.HasHistoricalConfiguration;

                                break;
                            }
                            case 4:
                            {
                                HistoricalDataConfigurationState state = CreateConfig(variable,
                                    configNodeName,
                                    definedHistoricalDataConfigurationName,
                                    percentBad: 100,
                                    percentGood: 100,
                                    uncertainAsBad: true,
                                    slopedExtrapolation: false,
                                    stepped: true);
                                state.ReferenceTypeId = Opc.Ua.ReferenceTypeIds.HasHistoricalConfiguration;

                                break;
                            }
                            case 5:
                            {
                                HistoricalDataConfigurationState state = CreateConfig(variable,
                                    configNodeName,
                                    definedHistoricalDataConfigurationName,
                                    percentBad: 100,
                                    percentGood: 100,
                                    uncertainAsBad: false,
                                    slopedExtrapolation: false,
                                    stepped: false);
                                state.ReferenceTypeId = Opc.Ua.ReferenceTypeIds.HasHistoricalConfiguration;

                                break;
                            }
                        }
                    }


                    #endregion

                    #region Configuration Parent

                    string historicalPropertyName = "HistoricalProperty";
                    string historicalPropertyNodeName = historicalDataConfigurationTypeName + "." + historicalPropertyName;

                    BaseDataVariableState historicalProperty = CreateProperty(
                        historicalDataConfigurationState,
                        historicalPropertyNodeName,
                        historicalPropertyName,
                        DataTypeIds.Double,
                        ValueRanks.Scalar);

                    historicalProperty.AccessLevel = AccessLevels.HistoryRead;
                    historicalProperty.UserAccessLevel = AccessLevels.HistoryRead;
                    historicalProperty.AccessLevelEx = AccessLevels.HistoryRead;


                    string subConfigName = "SubHistoricalProperty";
                    string subConfigTypeName = subObjectTypeName + "." + subConfigName;

                    BaseDataVariableState subHistoricalProperty = CreateProperty(
                        subObjectState,
                        subConfigTypeName,
                        subConfigName,
                        DataTypeIds.Double,
                        ValueRanks.Scalar);

                    subHistoricalProperty.AccessLevel = AccessLevels.HistoryRead;
                    subHistoricalProperty.UserAccessLevel = AccessLevels.HistoryRead;
                    subHistoricalProperty.AccessLevelEx = AccessLevels.HistoryRead;


                    string historicalVariableName = "HistoricalVariable";
                    string historicalVariableNodeName = historicalDataConfigurationTypeName + "." + historicalVariableName;

                    BaseDataVariableState historicalVariable = CreateVariable(
                        historicalDataConfigurationState,
                        historicalVariableNodeName,
                        historicalVariableName,
                        DataTypeIds.Double,
                        ValueRanks.Scalar);

                    historicalVariable.AccessLevel = AccessLevels.HistoryRead;
                    historicalVariable.UserAccessLevel = AccessLevels.HistoryRead;
                    historicalVariable.AccessLevelEx = AccessLevels.HistoryRead;


                    string subConfigVariableName = "SubHistoricalVariable";
                    string subConfigVariableTypeName = subObjectTypeName + "." + subConfigVariableName;

                    BaseDataVariableState subHistoricalVariable = CreateVariable(
                        subObjectState,
                        subConfigVariableTypeName,
                        subConfigVariableName,
                        DataTypeIds.Double,
                        ValueRanks.Scalar);

                    subHistoricalVariable.AccessLevel = AccessLevels.HistoryRead;
                    subHistoricalVariable.UserAccessLevel = AccessLevels.HistoryRead;
                    subHistoricalVariable.AccessLevelEx = AccessLevels.HistoryRead;


                    #endregion

                    #region No Configuration Parent

                    string noConfigurationPropertyName = "NoConfigProperty";
                    string noConfigurationPropertyNodeName = noConfigurationNodeName + "." + noConfigurationPropertyName;

                    BaseDataVariableState noConfigProperty = CreateProperty(
                        noConfigurationFolder,
                        noConfigurationPropertyNodeName,
                        noConfigurationPropertyName,
                        DataTypeIds.Double,
                        ValueRanks.Scalar);

                    noConfigProperty.AccessLevel = AccessLevels.HistoryRead;
                    noConfigProperty.UserAccessLevel = AccessLevels.HistoryRead;
                    noConfigProperty.AccessLevelEx = AccessLevels.HistoryRead;


                    string noConfigurationVariableName = "NoConfigVariable";
                    string noConfigurationVariableNodeName = noConfigurationNodeName + "." + noConfigurationVariableName;

                    BaseDataVariableState noConfigVariable = CreateVariable(
                        noConfigurationFolder,
                        noConfigurationVariableNodeName,
                        noConfigurationVariableName,
                        DataTypeIds.Double,
                        ValueRanks.Scalar);

                    noConfigVariable.AccessLevel = AccessLevels.HistoryRead;
                    noConfigVariable.UserAccessLevel = AccessLevels.HistoryRead;
                    noConfigVariable.AccessLevelEx = AccessLevels.HistoryRead;

                    #endregion

                    #region MyRegion

                    #endregion

                    #region Create Variable

                    //string singleVariableName = "SingleVariable";
                    //string singleVariableNodeName = AggregatesNodeName + "." + singleVariableName;

                    //BaseDataVariableState singleVariable = CreateVariable(AggregatesFolder,
                    //    singleVariableNodeName, singleVariableName, DataTypeIds.Int32, ValueRanks.Scalar);

                    //string singlePropertyName = "SingleProperty";
                    //string singlePropertyNodeName = AggregatesNodeName + "." + singlePropertyName;

                    //BaseDataVariableState singleProperty = CreateProperty(AggregatesFolder,
                    //    singlePropertyNodeName, singlePropertyName, DataTypeIds.Int32, ValueRanks.Scalar);

                    #endregion

                    #region MultipleConfig

                    string configs = "Configurations";
                    string configsNodeName = AggregatesName + "." + configs;
                    FolderState configsFolder = CreateFolder(AggregatesFolder, configsNodeName, configs);

                    string originalConfigs = "Original";
                    string originalConfigsNodeName = configsNodeName + "." + originalConfigs;
                    FolderState originalConfigsFolder = CreateFolder(configsFolder, originalConfigsNodeName, originalConfigs);


                    string haConfigName = "HA Configuration";
                    string haConfigNodeName = originalConfigsNodeName + "." + haConfigName;
                    DefaultConfig = CreateConfig(originalConfigsFolder,
                        haConfigNodeName,
                        haConfigName,
                        percentBad: 100,
                        percentGood: 100,
                        uncertainAsBad: false,
                        slopedExtrapolation: false,
                        stepped: true);

                    DefaultConfig.ReferenceTypeId = Opc.Ua.ReferenceTypeIds.HasHistoricalConfiguration;


                    string alternateConfigs = "Alternate";
                    string alternateConfigsNodeName = configsNodeName + "." + alternateConfigs;
                    FolderState alternateConfigsFolder = CreateFolder(configsFolder, alternateConfigsNodeName, alternateConfigs);

                     
                    haConfigNodeName = alternateConfigsNodeName + "." + haConfigName;
                    AlternateConfig = CreateConfig(alternateConfigsFolder,
                        haConfigNodeName,
                        haConfigName,
                        percentBad: 100,
                        percentGood: 100,
                        uncertainAsBad: false,
                        slopedExtrapolation: false,
                        stepped: true);

                    AlternateConfig.ReferenceTypeId = Opc.Ua.ReferenceTypeIds.HasHistoricalConfiguration;



                    string multipleConfig = "MultipleConfiguration";
                    string multipleConfigNodeName = AggregatesName + "." + multipleConfig;
                    FolderState multipleConfigFolder = CreateFolder(AggregatesFolder, multipleConfigNodeName, multipleConfig);

                    string parentConfig = "Parent";
                    string parentConfigNodeName = multipleConfigNodeName + "." + parentConfig;
                    FolderState parentConfigFolder = CreateFolder(multipleConfigFolder, parentConfigNodeName, parentConfig);

                    string childConfig = "Child";
                    string childConfigNodeName = multipleConfigNodeName + "." + childConfig;
                    FolderState childConfigFolder = CreateFolder(multipleConfigFolder, childConfigNodeName, childConfig);

                    string defaultParentConfigName = "HA Configuration";
                    string defaultParentConfigNodeName = parentConfigNodeName + "." + defaultParentConfigName;

                    NodeState defaultParentConfig = CreateConfig(
                        parentConfigFolder,
                        defaultParentConfigNodeName,
                        defaultParentConfigName,
                        percentBad: 100,
                        percentGood: 100,
                        uncertainAsBad: false,
                        slopedExtrapolation: false,
                        stepped: true
                    );

                    CreateChildProperties(defaultParentConfig, defaultParentConfigNodeName);

                    string secondParentConfigName = "Second Collection";
                    string secondParentConfigNodeName = parentConfigNodeName + "." + secondParentConfigName;

                    NodeState secondParentConfig = CreateConfig(
                        parentConfigFolder,
                        secondParentConfigNodeName,
                        secondParentConfigName,
                        percentBad: 100,
                        percentGood: 100,
                        uncertainAsBad: false,
                        slopedExtrapolation: false,
                        stepped: false
                    );

                    CreateChildProperties(secondParentConfig, secondParentConfigNodeName);

                    string longTermParentConfigName = "Long Term Collection";
                    string longTermParentConfigNodeName = parentConfigNodeName + "." + longTermParentConfigName;

                    NodeState longTermParentConfig = CreateConfig(
                        parentConfigFolder,
                        longTermParentConfigNodeName,
                        longTermParentConfigName,
                        percentBad: 100,
                        percentGood: 100,
                        uncertainAsBad: true,
                        slopedExtrapolation: false,
                        stepped: true
                    );

                    CreateChildProperties(longTermParentConfig, longTermParentConfigNodeName);

                    #region Child HA Configuration Status

                    string aggregateConfigurationStatusName = "ConfigurationStatus";
                    string aggregateConfigurationStatusNodeName = childConfigNodeName + "." + aggregateConfigurationStatusName;


                    ConfigurationStatus = CreateVariable(childConfigFolder,
                        aggregateConfigurationStatusNodeName, aggregateConfigurationStatusName, DataTypeIds.String, ValueRanks.Scalar);

                    ConfigurationStatus.Value = "Normal";

                    // Multiple Configurations Method

                    string multipleMethodName = "MultipleConfigurations";
                    string multipleMethodNodeName = childConfigNodeName + "." + multipleMethodName;
                    MethodState multipleMethod = AlarmHelpers.CreateMethod(childConfigFolder, NamespaceIndex, multipleMethodNodeName, multipleMethodName);
                    multipleMethod.OnCallMethod = new GenericMethodCalledEventHandler(MultipleConfigurationMethod);

                    string noConfigurationMethodName = "NoConfiguration";
                    string noConfigurationMethodNodeName = childConfigNodeName + "." + noConfigurationMethodName;
                    MethodState noConfigurationMethod = AlarmHelpers.CreateMethod(childConfigFolder, NamespaceIndex, noConfigurationMethodNodeName, noConfigurationMethodName);
                    noConfigurationMethod.OnCallMethod = new GenericMethodCalledEventHandler(NoConfigurationMethod);

                    string noConfigurationAllMethodName = "NoConfigurationAll";
                    string noConfigurationAllMethodNodeName = childConfigNodeName + "." + noConfigurationAllMethodName;
                    MethodState noConfigurationAllMethod = AlarmHelpers.CreateMethod(childConfigFolder,
                        NamespaceIndex, noConfigurationAllMethodNodeName, noConfigurationAllMethodName);
                    noConfigurationAllMethod.OnCallMethod = new GenericMethodCalledEventHandler(NoConfigurationMethodAll);

                    string resetConfigurationMethodName = "ResetConfiguration";
                    string resetConfigurationMethodNodeName = childConfigNodeName + "." + resetConfigurationMethodName;
                    MethodState resetConfigurationMethod = AlarmHelpers.CreateMethod(childConfigFolder, NamespaceIndex, resetConfigurationMethodNodeName, resetConfigurationMethodName);
                    resetConfigurationMethod.OnCallMethod = new GenericMethodCalledEventHandler(ResetConfigurationMethod);


                    // No Configurations Method

                    // Reset




                    #endregion


                    CreateParentVariables(childConfigFolder,
                        childConfigNodeName);

                    #endregion

                    string folder7773Name = "7773";
                    string folder7773NodeName = AggregatesName + "." + folder7773Name;
                    FolderState folder7773 = CreateFolder(AggregatesFolder, folder7773NodeName, folder7773Name);

                    #region 7773
                    {
                        string[] names = new string[] {
                            "GoodUncertainBadGood",
                            "GoodBadUncertainGood",
                            "GoodUncertainBad",
                            "GoodBadUncertain",
                        };

                        foreach( string name in names)
                        {
                            NodeId dataType = DataTypeIds.Double;
                            if ( name.EndsWith( "Good" ) )
                            {
                                dataType = DataTypeIds.Int32;
                            }

                            string nodeName = folder7773NodeName + "_" + name;
                            BaseDataVariableState variable = CreateVariable(folder7773,
                                nodeName, name, dataType, ValueRanks.Scalar);
                            variable.AccessLevel = AccessLevels.HistoryRead;
                            variable.UserAccessLevel = AccessLevels.HistoryRead;
                            variable.AccessLevelEx = AccessLevels.HistoryRead;

                            string startOfBadDataName = "StartOfBadData";
                            string startOfBadDataNodeName = nodeName + "." + startOfBadDataName;
                            CreateProperty(variable, startOfBadDataNodeName, startOfBadDataName,
                                Opc.Ua.DataTypeIds.DateTime, ValueRanks.Scalar);

                            variable.AddReference(ReferenceTypes.HasHistoricalConfiguration, isInverse: false, DefaultConfig.NodeId);
                            DefaultConfig.AddReference(ReferenceTypes.HasHistoricalConfiguration, isInverse: true, variable.NodeId);
                        }


                    }
                    #endregion

                    #region Customer Data 7773

                    {
                        string customerDataName = "CustomerData";
                        string nodeName = folder7773NodeName + "_" + customerDataName;
                        BaseDataVariableState variable = CreateVariable(folder7773,
                            nodeName, customerDataName, DataTypeIds.Int32, ValueRanks.Scalar);
                        variable.AccessLevel = AccessLevels.HistoryRead;
                        variable.UserAccessLevel = AccessLevels.HistoryRead;
                        variable.AccessLevelEx = AccessLevels.HistoryRead;

                        string startOfBadDataName = "StartOfBadData";
                        string startOfBadDataNodeName = nodeName + "." + startOfBadDataName;
                        CreateProperty(variable, startOfBadDataNodeName, startOfBadDataName,
                            Opc.Ua.DataTypeIds.DateTime, ValueRanks.Scalar);

                        variable.AddReference(ReferenceTypes.HasHistoricalConfiguration, isInverse: false, DefaultConfig.NodeId);
                        DefaultConfig.AddReference(ReferenceTypes.HasHistoricalConfiguration, isInverse: true, variable.NodeId);

                        Get7773CustomerData(variable);
                     }

                    // How do I insert annotation??


                    #endregion

                    AddPredefinedNode(SystemContext, AggregatesFolder);
                    StartTimer();
                    m_allowEntry = true;

                }
                catch (Exception e)
                {
                    Utils.LogError(e, "Error creating the AggregatesNodeManager address space.");
                }

            }
        }

        private void CreateChildProperties(NodeState parent, string parentName)
        {
            List<Tuple<string, NodeId>> tuples = GetTypeTuples();
            List<string> suffixes = new List<string>();
            suffixes.Add("First");
            suffixes.Add("Second");

            foreach (Tuple<string, NodeId> tuple in tuples)
            {
                foreach (string suffix in suffixes)
                {
                    string name = tuple.Item1 + "_" + suffix;
                    string nodeName = parentName + name;
                    BaseDataVariableState property = CreateProperty(parent, nodeName, name, tuple.Item2, ValueRanks.Scalar);
                    property.AccessLevel = AccessLevels.HistoryRead;
                    property.UserAccessLevel = AccessLevels.HistoryRead;
                    property.AccessLevelEx = AccessLevels.HistoryRead;

                }
            }
        }

        private void CreateParentVariables(NodeState parent,
            string parentName)
        {
            HistoricalDataConfigurationState secondParent = null;
            HistoricalDataConfigurationState longTermConfig = null;

            List<Tuple<string, NodeId>> tuples = GetTypeTuples();
            List<string> suffixes = new List<string>();
            suffixes.Add("First");
            suffixes.Add("Second");

            foreach (Tuple<string, NodeId> tuple in tuples)
            {
                foreach (string suffix in suffixes)
                {
                    string name = tuple.Item1 + "_" + suffix;
                    string nodeName = parentName + "_" + name;
                    BaseDataVariableState variable = CreateVariable(parent,
                        nodeName, name, tuple.Item2, ValueRanks.Scalar);
                    variable.AccessLevel = AccessLevels.HistoryRead;
                    variable.UserAccessLevel = AccessLevels.HistoryRead;
                    variable.AccessLevelEx = AccessLevels.HistoryRead;

                    string startOfBadDataName = "StartOfBadData";
                    string startOfBadDataNodeName = nodeName + "." + startOfBadDataName;
                    CreateProperty(variable, startOfBadDataNodeName, startOfBadDataName,
                        Opc.Ua.DataTypeIds.DateTime, ValueRanks.Scalar);

                    if ( suffix == "First" )
                    {
                        variable.AddReference(ReferenceTypes.HasHistoricalConfiguration, isInverse: false, DefaultConfig.NodeId);
                        DefaultConfig.AddReference(ReferenceTypes.HasHistoricalConfiguration, isInverse: true, variable.NodeId);
                    }
                    else
                    {
                        variable.AddReference(ReferenceTypes.HasHistoricalConfiguration, isInverse: false, AlternateConfig.NodeId);
                        AlternateConfig.AddReference(ReferenceTypes.HasHistoricalConfiguration, isInverse: true, variable.NodeId);
                    }

                    if (secondParent == null)
                    {
                        string configName = "Second Configuration";
                        string configNodeName = nodeName + "." + configName;
                        secondParent = CreateConfig(variable,
                            configNodeName,
                            configName,
                            percentBad: 100,
                            percentGood: 100,
                            uncertainAsBad: false,
                            slopedExtrapolation: false,
                            stepped: false);
                        secondParent.ReferenceTypeId = Opc.Ua.ReferenceTypeIds.HasHistoricalConfiguration;

                    }
                    else
                    {
                        variable.AddReference(ReferenceTypes.HasHistoricalConfiguration, isInverse: false, secondParent.NodeId);
                        secondParent.AddReference(ReferenceTypes.HasHistoricalConfiguration, isInverse: true, variable.NodeId);
                    }

                    if (longTermConfig == null)
                    {
                        string configName = "Long Term Collection";
                        string configNodeName = nodeName + "." + configName;
                        longTermConfig = CreateConfig(variable,
                            configNodeName,
                            configName,
                            percentBad: 100,
                            percentGood: 100,
                            uncertainAsBad: true,
                            slopedExtrapolation: false,
                            stepped: true);

                        longTermConfig.ReferenceTypeId = Opc.Ua.ReferenceTypeIds.HasHistoricalConfiguration;
                    }
                    else
                    {
                        variable.AddReference(ReferenceTypes.HasHistoricalConfiguration, isInverse: false, longTermConfig.NodeId);
                        longTermConfig.AddReference(ReferenceTypes.HasHistoricalConfiguration, isInverse: true, variable.NodeId);
                    }
                }
            }
        }

        private List<Tuple<string, NodeId>> GetTypeTuples()
        {
            List<Tuple<string, NodeId>> tuples = new List<Tuple<string, NodeId>>();
            tuples.Add(Tuple.Create<string, NodeId>("Boolean", DataTypeIds.Boolean));
            tuples.Add(Tuple.Create<string, NodeId>("Integer", DataTypeIds.Int32));
            tuples.Add(Tuple.Create<string, NodeId>("Float", DataTypeIds.Float));
            tuples.Add(Tuple.Create<string, NodeId>("Double", DataTypeIds.Double));
            tuples.Add(Tuple.Create<string, NodeId>("String", DataTypeIds.String));
            return tuples;
        }

        /// <summary>
        /// Stores the state of a call method operation.
        /// </summary>
        private struct ReadWriteOperationState
        {
            public NodeState Source;
            public int Index;
        }

        /// <summary>
        /// Verifies that the specified node exists.
        /// </summary>
        protected virtual bool ValidateNode(ServerSystemContext context, NodeState node)
        {
            // validate node only if required.
            if (node.ValidationRequired)
            {
                return node.Validate(context);
            }

            return true;
        }


        /// <summary>
        /// Blah blah blah summary
        /// </summary>
        public override void HistoryRead(
            OperationContext context,
            HistoryReadDetails details,
            TimestampsToReturn timestampsToReturn,
            bool releaseContinuationPoints,
            IList<HistoryReadValueId> nodesToRead,
            IList<HistoryReadResult> results,
            IList<ServiceResult> errors)
        {
            ServerSystemContext systemContext = SystemContext.Copy(context);
            IDictionary<NodeId, NodeState> operationCache = new NodeIdDictionary<NodeState>();
            IDictionary<NodeId, NodeState> unused = new NodeIdDictionary<NodeState>();
            List<ReadWriteOperationState> nodesToValidate = new List<ReadWriteOperationState>();
            List<ReadWriteOperationState> readsToComplete = new List<ReadWriteOperationState>();

            lock (Lock)
            {
                ReadProcessedDetails processed = details as ReadProcessedDetails;
                if ( processed != null)
                {
                    // check the list of aggregates.
                    if (processed.AggregateType == null || processed.AggregateType.Count != nodesToRead.Count)
                    {
                        throw new ServiceResultException(StatusCodes.BadAggregateListMismatch);
                    }

                    // check start/end time.
                    if (processed.StartTime == DateTime.MinValue || processed.EndTime == DateTime.MinValue)
                    {
                        throw new ServiceResultException(StatusCodes.BadInvalidTimestampArgument);
                    }
                }
                for (int ii = 0; ii < nodesToRead.Count; ii++)
                {
                    HistoryReadValueId nodeToRead = nodesToRead[ii];

                    // skip items that have already been processed.
                    if (nodeToRead.Processed)
                    {
                        continue;
                    }

                    NodeHandle nodeHandle = GetManagerHandle(systemContext, nodeToRead.NodeId, unused);
                    if (nodeHandle == null || nodeHandle.Node == null)
                    {
                        continue;
                    }

                    // owned by this node manager.
                    nodeToRead.Processed = true;

                    // only variables supported.
                    BaseVariableState variable = nodeHandle.Node as BaseVariableState;

                    if (variable == null)
                    {
                        errors[ii] = StatusCodes.BadHistoryOperationUnsupported;
                        continue;
                    }

                    results[ii] = new HistoryReadResult();

                    ReadWriteOperationState operation = new ReadWriteOperationState();

                    operation.Source = variable;
                    operation.Index = ii;

                    // check if the node is ready for reading.
                    if (variable.ValidationRequired)
                    {
                        // must validate node in a seperate operation.
                        errors[ii] = StatusCodes.BadNodeIdUnknown;
                        nodesToValidate.Add(operation);
                        continue;
                    }

                    // read the data.
                    readsToComplete.Add(operation);
                }

                // validates the nodes (reads values from the underlying data source if required).
                for (int ii = 0; ii < nodesToValidate.Count; ii++)
                {
                    ReadWriteOperationState operation = nodesToValidate[ii];

                    if (!ValidateNode(systemContext, operation.Source))
                    {
                        continue;
                    }

                    readsToComplete.Add(operation);
                }
            }

            // reads the data without holding onto the lock.
            for (int ii = 0; ii < readsToComplete.Count; ii++)
            {
                ReadWriteOperationState operation = readsToComplete[ii];

                errors[operation.Index] = HistoryRead(
                    systemContext,
                    operation.Source,
                    operation.Index,
                    details,
                    timestampsToReturn,
                    releaseContinuationPoints,
                    nodesToRead[operation.Index],
                    results[operation.Index]);
            }
        }

        /// <summary>
        /// Reads the history for a single node which has already been validated.
        /// </summary>
        protected virtual ServiceResult HistoryRead(
            ISystemContext context,
            NodeState source,
            int index,
            HistoryReadDetails details,
            TimestampsToReturn timestampsToReturn,
            bool releaseContinuationPoints,
            HistoryReadValueId nodesToRead,
            HistoryReadResult result)
        {
            // check for variable.
            BaseVariableState variable = source as BaseVariableState;

            if (variable == null)
            {
                return StatusCodes.BadHistoryOperationUnsupported;
            }

            // check for access.
            lock (Lock)
            {
                if ((variable.AccessLevel & AccessLevels.HistoryRead) == 0)
                {
                    return StatusCodes.BadNotReadable;
                }
            }

            // handle read raw.
            ReadRawModifiedDetails readRawDetails = details as ReadRawModifiedDetails;

            if (readRawDetails != null)
            {
                if ( readRawDetails.NumValuesPerNode == 360 )
                {
                    bool wait = true;
                }
                return HistoryReadRaw(
                    context,
                    variable,
                    readRawDetails,
                    timestampsToReturn,
                    releaseContinuationPoints,
                    nodesToRead,
                    result);
            }

            // handle read processed.
            ReadProcessedDetails readProcessedDetails = details as ReadProcessedDetails;

            if (readProcessedDetails != null)
            {
                // This is not going to be sufficient if there are multiple aggregates selected.
                // Actually it should be - node count needs to be equal to aggregate count
                return HistoryReadProcessed(
                    context,
                    variable,
                    index,
                    readProcessedDetails,
                    timestampsToReturn,
                    releaseContinuationPoints,
                    nodesToRead,
                    result);
            }

            return StatusCodes.BadHistoryOperationUnsupported;
        }

        /// <summary>
        /// Reads the raw history for the variable value.
        /// </summary>
        protected virtual ServiceResult HistoryReadRaw(
            ISystemContext context,
            BaseVariableState source,
            ReadRawModifiedDetails details,
            TimestampsToReturn timestampsToReturn,
            bool releaseContinuationPoints,
            HistoryReadValueId nodeToRead,
            HistoryReadResult result)
        {
            StatusCode status = new StatusCode(StatusCodes.BadHistoryOperationUnsupported);

            if ( releaseContinuationPoints )
            {
                // first I need a mechanism to save continuation points
                // Why do I care?  I don't have enough data for a continuation point
                status = new StatusCode(StatusCodes.BadContinuationPointInvalid);
                return status;
            }

            DataValueCollection dataValues = GetTestData(source);
            if (dataValues != null)
            {
                DataValueCollection timedCollection = GetTimedData( dataValues, details.StartTime, details.EndTime );
                DataValueCollection values = GetTimestampData(timedCollection, timestampsToReturn);
                DataValueCollection limitedValues = LimitValueCount(values, details.NumValuesPerNode);

                if ( timedCollection.Count <= 0 || values.Count <= 0 || limitedValues.Count <= 0 )
                {
                    bool errorCase = true;
                }

                HistoryData historyData = new HistoryData();
                historyData.DataValues = limitedValues;

                result.HistoryData = new ExtensionObject(historyData);
                result.StatusCode = StatusCodes.Good;
                result.ContinuationPoint = null;
                Utils.LogInfo("HistoryReadRaw {0} {1} - {2} Count {3}", source.SymbolicName,
                    FormatDateTime( details.StartTime ), FormatDateTime( details.EndTime ), historyData.DataValues.Count);

                if (limitedValues.Count < 500)
                {
                    PrintCollection("ReadRaw", source.SymbolicName, limitedValues);
                }

                status = new StatusCode(StatusCodes.Good);
                return status;
            }

            Utils.LogInfo("HistoryReadRaw {0} {1} - {2} Bad Status {3}", source.SymbolicName,
                FormatDateTime(details.StartTime), FormatDateTime(details.EndTime), status.ToString());

            return status;
        }

        /// <summary>
        /// Reads the processed history for the variable value.
        /// </summary>
        protected virtual ServiceResult HistoryReadProcessed(
            ISystemContext context,
            BaseVariableState source,
            int index,
            ReadProcessedDetails details,
            TimestampsToReturn timestampsToReturn,
            bool releaseContinuationPoints,
            HistoryReadValueId nodeToRead,
            HistoryReadResult result)
        {
            // Special Cases
            NodeId aggregateNodeId = details.AggregateType[index];
            if ( aggregateNodeId == null )
            {
                return new StatusCode( StatusCodes.BadAggregateNotSupported );
            }

            if ( details.StartTime.Equals( details.EndTime ))
            {
                return new StatusCode( StatusCodes.BadInvalidArgument );
            }

            bool oneInterval = false;
            TimeSpan timeSpan = details.EndTime - details.StartTime;
            double range = Math.Abs( timeSpan.TotalMilliseconds );
            if ( details.ProcessingInterval == 0 || details.ProcessingInterval >= range )
            {
                if ( details.ProcessingInterval > range )
                {
                    bool waiting = true;
                }
                /*
                 * One interval, starting at Start and ending at End. 
                 * Includes Start, excludes End, i.e., [Start, End).
                */
                oneInterval = true;
            }

            int specIndex = GetSpecIndex(source.NodeId);
            if (specIndex > 0)
            {
                string nodeIdString = nodeToRead.NodeId.ToString();
                //                ns = 15; s = Aggregates.Spec.Historian_1_HA Configuration
                string lookupNodeIdString = nodeIdString + "_HistoricalDataConfiguration";

                // Lookup the aggregate config
                NodeId configNodeId = new NodeId(lookupNodeIdString);
                IDictionary<NodeId, NodeState> unused = new NodeIdDictionary<NodeState>();

                NodeHandle nodeHandle = GetManagerHandle(SystemContext, configNodeId, unused);
                if (nodeHandle != null && nodeHandle.Node != null)
                {
                    HistoricalDataConfigurationState configState = nodeHandle.Node as HistoricalDataConfigurationState;
                    if (configState != null)
                    {
                        DataValueCollection dataValues = GetTestData(source);
                        DataValueCollection timedCollection = GetOrderedData(dataValues, details.StartTime, details.EndTime);

                        IAggregateCalculator aggregateCalculator = Aggregators.CreateStandardCalculator(
                            aggregateNodeId,
                            details.StartTime,
                            details.EndTime,
                            details.ProcessingInterval,
                            configState.Stepped.Value,
                            details.AggregateConfiguration);

                        Utils.LogInfo("HistoryReadProcessed Creating Calculator {0} {1} {2} {3} {4} {5} {6} {7} {8}",
                            aggregateNodeId.ToString(),
                            FormatDateTime( details.StartTime ),
                            FormatDateTime( details.EndTime ),
                            details.ProcessingInterval,
                            configState.Stepped.Value,
                            details.AggregateConfiguration.PercentDataBad,
                            details.AggregateConfiguration.PercentDataGood,
                            details.AggregateConfiguration.TreatUncertainAsBad,
                            details.AggregateConfiguration.UseSlopedExtrapolation);

                        DataValueCollection processed = new DataValueCollection();

                        for ( int timedIndex = 0; timedIndex < timedCollection.Count; timedIndex++ )
                        {
                            DataValue rawValue = timedCollection[timedIndex];

                            Utils.LogInfo("HistoryReadProcessing {0} of {1} [{}]",
                                timedIndex,
                                timedCollection.Count,
                                rawValue.ToString());

                            DataValue processedValue = aggregateCalculator.GetProcessedValue(false);

                            if (processedValue != null)
                            {
                                Utils.LogInfo("HistoryReadProcessing index {0} Got Processed value [{1}]",
                                timedIndex,
                                processedValue.ToString());

                                processed.Add(new DataValue(processedValue));
                            }
                        }

                        bool keepGoing = true;
                        while (keepGoing)
                        {
                            DataValue processedValue = aggregateCalculator.GetProcessedValue(true);
                            if (processedValue != null)
                            {
                                Utils.LogInfo("HistoryReadProcessing After Loop Got Processed value [{0}]",
                                    processedValue.ToString());

                                processed.Add(new DataValue(processedValue));
                            }
                            else
                            {
                                Utils.LogInfo("HistoryReadProcessing After Loop Complete");
                                keepGoing = false;
                            }
                        }

                        HistoryData historyData = new HistoryData();
                        historyData.DataValues = processed;
                        result.HistoryData = new ExtensionObject(historyData);
                        result.StatusCode = StatusCodes.Good;
                        result.ContinuationPoint = null;
                        Utils.LogInfo("HistoryReadProcessed {0} {1} - {2} for aggregate {3}",
                            source.SymbolicName,
                            details.StartTime, details.EndTime, aggregateNodeId.ToString());
                        return StatusCodes.Good;
                    }

                }
            }
            else
            {
                DataValueCollection rawData = GetTestData(source);
                if (rawData != null && rawData.Count > 0)
                {
                    // Get the default historical Configuration
                    HistoricalDataConfigurationState historicalDataConfiguration = null;

                    // Assume its the child for now.
                    List<BaseInstanceState> children = new List<BaseInstanceState>();
                    source.GetChildren(SystemContext, children);
                    foreach (BaseInstanceState child in children)
                    {
                        if (child.SymbolicName.Equals("HA Configuration"))
                        {
                            historicalDataConfiguration = child as HistoricalDataConfigurationState;

                            if (historicalDataConfiguration != null)
                            {
                                break;
                            }
                        }
                    }

                    bool steppedInterpolation = false;
                    if (historicalDataConfiguration != null)
                    {
                        steppedInterpolation = historicalDataConfiguration.Stepped.Value;
                    }

                    DataValueCollection timedCollection = GetOrderedData(rawData, details.StartTime, details.EndTime);

                    double processingInterval = details.ProcessingInterval;
                    if ( oneInterval )
                    {
                     //   processingInterval = 0;
                    }

                    IAggregateCalculator aggregateCalculator = Aggregators.CreateStandardCalculator(
                        aggregateNodeId,
                        details.StartTime,
                        details.EndTime,
                        processingInterval,
                        steppedInterpolation,
                        details.AggregateConfiguration);

                    if ( details.ProcessingInterval < 0 )
                    {
                        Utils.LogError("How do we get processing interval less than zero? "+ details.ProcessingInterval.ToString());
                        return StatusCodes.BadInvalidArgument;
                    }

                    Utils.LogInfo("HistoryReadProcessed Creating Calculator {0} {1} {2} {3} {4} {5} {6} {7} {8}",
                        aggregateNodeId.ToString(),
                        FormatDateTime(details.StartTime),
                        FormatDateTime(details.EndTime),
                        details.ProcessingInterval,
                        steppedInterpolation,
                        details.AggregateConfiguration.PercentDataBad,
                        details.AggregateConfiguration.PercentDataGood,
                        details.AggregateConfiguration.TreatUncertainAsBad,
                        details.AggregateConfiguration.UseSlopedExtrapolation);
                    Utils.LogInfo("HistoryReadProcessed Raw Data Count = {0}", timedCollection.Count.ToString());

                    DataValueCollection processed = new DataValueCollection();

                    int counter = 0;
                    foreach (DataValue rawValue in timedCollection)
                    {
                        if (!aggregateCalculator.QueueRawValue((Opc.Ua.DataValue)rawValue))
                        {
                            Utils.LogInfo("HistoryReadProcessing Breaking out of loop {0} out of {1}",
                                counter, timedCollection.Count);

                            PrintCollection("Break the Loop", source.SymbolicName, timedCollection);

                            break;
                        }

                        DataValue processedValue = aggregateCalculator.GetProcessedValue(false);

                        if (processedValue != null)
                        {
                            processed.Add(new DataValue(processedValue));
                        }
                        counter++;
                    }

                    bool keepGoing = true;
                    while (keepGoing)
                    {
                        DataValue processedValue = aggregateCalculator.GetProcessedValue(true);
                        if (processedValue != null)
                        {
                            processed.Add(new DataValue(processedValue));
                        }
                        else
                        {
                            keepGoing = false;
                        }
                    }

                    #region Test Tool
                    // From Test Tool
                    //for (DataValue processedValue = aggregateCalculator.GetProcessedValue(true);
                    //    processedValue != null;
                    //    processedValue = aggregateCalculator.GetProcessedValue(true))
                    //{
                    //    processed.Add(new DataValue(processedValue));
                    //}
                    #endregion

                    #region Stopped Working
                    //for (int timedIndex = 0; timedIndex < timedCollection.Count; timedIndex++)
                    //{
                    //    DataValue rawValue = timedCollection[timedIndex];

                    //    Utils.LogInfo("HistoryReadProcessing {0} of {1} [{2}]",
                    //        timedIndex,
                    //        timedCollection.Count,
                    //        rawValue.ToString());

                    //    if (!aggregateCalculator.QueueRawValue((Opc.Ua.DataValue)rawValue))
                    //    {
                    //        Utils.LogInfo("HistoryReadProcessing Breaking out of for loop");
                    //        break;
                    //    }

                    //    DataValue processedValue = aggregateCalculator.GetProcessedValue(false);

                    //    if (processedValue != null)
                    //    {
                    //        Utils.LogInfo("HistoryReadProcessing index {0} Got Processed value [{1}]",
                    //        timedIndex,
                    //        processedValue.ToString());

                    //        processed.Add(new DataValue(processedValue));
                    //    }
                    //}

                    //bool keepGoing = true;
                    //while (keepGoing)
                    //{
                    //    DataValue processedValue = aggregateCalculator.GetProcessedValue(true);
                    //    if (processedValue != null)
                    //    {
                    //        Utils.LogInfo("HistoryReadProcessing After Loop Got Processed value [{0}]",
                    //            processedValue.ToString());

                    //        processed.Add(new DataValue(processedValue));
                    //    }
                    //    else
                    //    {
                    //        Utils.LogInfo("HistoryReadProcessing After Loop Complete");
                    //        keepGoing = false;
                    //    }
                    //}
                    #endregion

                    HistoryData historyData = new HistoryData();
                    historyData.DataValues = processed;

                    Utils.LogInfo("HistoryReadProcessed {0} {1} - {2} for aggregate {3}",
                        source.SymbolicName,
                        FormatDateTime(details.StartTime),
                        FormatDateTime(details.EndTime),
                        aggregateNodeId.ToString());

                    PrintCollection("Processed Data ", source.SymbolicName, processed);
                    result.HistoryData = new ExtensionObject(historyData);
                    result.StatusCode = StatusCodes.Good;
                    result.ContinuationPoint = null;                    return StatusCodes.Good;
                }
            }

            return StatusCodes.BadHistoryOperationUnsupported;
        }


        public ServiceResult MultipleConfigurationMethod(
            ISystemContext context,
            NodeState node,
            IList<object> inputArguments,
            IList<object> outputArguments)
        {
            ServiceResult result = ServiceResult.Good;

            ModifyConfigReferences(context, node, enable: true, all: false);

            ModifyAlternateConfigParameters(context, true);

            UpdateConfigStatus(context, "Multiple Configurations");

            return result;
        }

        private void UpdateConfigStatus(ISystemContext context, string status )
        {
            ConfigurationStatus.Value = status;

            ConfigurationStatus.ClearChangeMasks(context, false);
        }

        private void ModifyConfigReferences( ISystemContext context, NodeState node, bool enable, bool all )
        {
            MethodState methodNode = node as MethodState;

            if (methodNode != null)
            {
                NodeState folderNodeState = methodNode.Parent;

                if (folderNodeState != null)
                {
                    List<Tuple<string, NodeId>> tuples = GetTypeTuples();
                    List<string> suffixes = new List<string>();
                    suffixes.Add("First");
                    suffixes.Add("Second");

                    foreach (Tuple<string, NodeId> tuple in tuples)
                    {
                        foreach (string suffix in suffixes)
                        {
                            NodeId nodeId = AlternateConfig.NodeId;
                            bool run = true;
                            if ( suffix.Equals("First") )
                            {
                                nodeId = DefaultConfig.NodeId;
                                if ( enable == false && all == false )
                                {
                                    run = false;
                                }
                            }

                            if (run)
                            {
                                string name = folderNodeState.BrowseName.Name + "_" + tuple.Item1 + "_" + suffix;
                                QualifiedName qualifiedName = new QualifiedName(name, NamespaceIndex);

                                BaseInstanceState baseInstanceState = folderNodeState.FindChild(context,
                                    qualifiedName);

                                BaseDataVariableState dataState = baseInstanceState as BaseDataVariableState;

                                if (dataState != null)
                                {
                                    if ( dataState.ReferenceExists( ReferenceTypes.HasHistoricalConfiguration, false, nodeId ) )
                                    {
                                        if ( !enable )
                                        {
                                            dataState.RemoveReference(ReferenceTypes.HasHistoricalConfiguration, false, nodeId);
                                        }
                                    }
                                    else
                                    {
                                        if ( enable )
                                        {
                                            dataState.AddReference(ReferenceTypes.HasHistoricalConfiguration, isInverse: false, nodeId);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void ModifyAlternateConfigParameters(ISystemContext context, bool value )
        {
            // Make sure the parameters are different now
            string aggConfig = AlternateConfig.BrowseName + "_AggregateConfiguration";
            string uncertainAsBad = aggConfig + "_TreatUncertainAsBad";
            string useSlopedExtrapolation = aggConfig + "_UseSlopedExtrapolation";
            BaseInstanceState aggregateConfig = AlternateConfig.FindChild(context, Opc.Ua.BrowseNames.AggregateConfiguration);
            if (aggregateConfig != null)
            {
                BaseInstanceState uncertainState = aggregateConfig.FindChild(context, Opc.Ua.BrowseNames.TreatUncertainAsBad);
                PropertyState<bool> uncertainPropertyState = uncertainState as PropertyState<bool>;
                if (uncertainPropertyState != null)
                {
                    uncertainPropertyState.Value = value;
                }

                BaseInstanceState slopedExtrapolation = aggregateConfig.FindChild(context, Opc.Ua.BrowseNames.UseSlopedExtrapolation);
                PropertyState<bool> slopedExtrapolationPropertyState = slopedExtrapolation as PropertyState<bool>;

                if (slopedExtrapolationPropertyState != null)
                {
                    slopedExtrapolationPropertyState.Value = value;

                }

                aggregateConfig.ClearChangeMasks(context, includeChildren: true);
            }
        }

        public ServiceResult NoConfigurationMethod(
            ISystemContext context,
            NodeState node,
            IList<object> inputArguments,
            IList<object> outputArguments)
        {
            ServiceResult result = ServiceResult.Good;

            ModifyConfigReferences(context, node, enable: false, all: false);

            UpdateConfigStatus(context, "Alternate Configurations have no references");


            return result;
        }

        public ServiceResult NoConfigurationMethodAll(
            ISystemContext context,
            NodeState node,
            IList<object> inputArguments,
            IList<object> outputArguments)
        {
            ServiceResult result = ServiceResult.Good;

            ModifyConfigReferences(context, node, enable: false, all: true);

            UpdateConfigStatus(context, "All Configurations have no references");


            return result;
        }

        public ServiceResult ResetConfigurationMethod(
            ISystemContext context,
            NodeState node,
            IList<object> inputArguments,
            IList<object> outputArguments)
        {
            ServiceResult result = ServiceResult.Good;

            ModifyConfigReferences(context, node, enable: true, all: true);

            ModifyAlternateConfigParameters(context, false);

            UpdateConfigStatus(context, "Normal");

            return result;
        }


        private string FormatDateTime(DateTime dateTime)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(dateTime.Hour.ToString("D2"));
            builder.Append(":");
            builder.Append(dateTime.Minute.ToString("D2"));
            builder.Append(":");
            builder.Append(dateTime.Second.ToString("D2"));
            builder.Append(".");
            builder.Append(dateTime.Millisecond.ToString("D3"));

            return builder.ToString();
        }

        private string FormatValue( object value )
        {
            string formattedValue = "NULL";

            if ( value != null )
            {
                formattedValue = value.ToString();
            }

            return formattedValue;
        }

        private void PrintCollection(string title, string symbolicName, DataValueCollection collection)
        {
            if ( collection != null )
            {
                if ( collection.Count > 0 )
                {
                    Utils.LogInfo("Collection " + title + " for " + symbolicName + " has " + collection.Count.ToString() + " entries");
                    for( int index = 0; index < collection.Count; index++ )
                    {
                        DataValue dataValue = collection[index];
                        Utils.LogInfo("\t[{0}] {1} {2} {3}",
                            index,
                            dataValue.StatusCode.ToString(),
                            FormatValue( dataValue.Value ),
                            FormatDateTime(dataValue.ServerTimestamp));
                    }
                }
                else
                {
                    Utils.LogInfo("Collection " + title + " for " + symbolicName + " has no entries");
                }
            }
        }

        private DataValueCollection GetOrderedData(DataValueCollection dataValues, DateTime startTime, DateTime endTime)
        {
            DataValueCollection collection = new DataValueCollection();

            bool forward = true;
            if (endTime < startTime)
            {
                forward = false;
            }

            DataValueCollection working = new DataValueCollection();

            if (dataValues != null)
            {
                DataValue[] dataValueArray = new DataValue[dataValues.Count];

                int lastIndex = dataValues.Count - 1;

                for (int index = 0; index < dataValues.Count; index++)
                {
                    if (forward)
                    {
                        dataValueArray[index] = dataValues[index];
                    }
                    else
                    {
                        int reverseIndex = lastIndex - index;
                        dataValueArray[reverseIndex] = dataValues[index];
                    }
                }

                collection = new DataValueCollection(dataValueArray);
            }

            return collection;
        }

        private DataValueCollection GetTimedData(DataValueCollection dataValues, DateTime startTime, DateTime endTime)
        {
            Utils.LogInfo("GetTimedData startTime {0} endTime {1} dataValues count {2} ",
                FormatDateTime(startTime),
                FormatDateTime(endTime),
                dataValues.Count.ToString());

            DataValueCollection collection = new DataValueCollection();

            DateTime localStartTime = startTime;
            DateTime localEndTime = endTime;

            bool forward = true;
            if ( endTime < startTime )
            {
                localEndTime = startTime;
                localStartTime = endTime;
                forward = false;
            }

            DataValueCollection working = new DataValueCollection();

            // Isolate the values first.
            foreach (DataValue dataValue in dataValues)
            {
                if (dataValue.SourceTimestamp >= localStartTime &&
                    dataValue.SourceTimestamp <= localEndTime)
                {
                    working.Add(dataValue);
                }
            }

            if (dataValues != null)
            {
                DataValue[] dataValueArray = new DataValue[working.Count];

                int lastIndex = working.Count - 1;

                for (int index = 0; index < working.Count; index++)
                {
                    if (forward)
                    {
                        dataValueArray[index] = working[index];
                    }
                    else
                    {
                        int reverseIndex = lastIndex - index;
                        dataValueArray[reverseIndex] = working[index];
                    }
                }

                collection = new DataValueCollection(dataValueArray);
            }

            for( int index = 0; index < collection.Count; index++ )
            {
                DataValue dataValue = collection[index];
                Utils.LogInfo("GetTimedData index [{0}] of [{1}] = {2}",
                    index,
                    collection.Count.ToString(),
                    FormatDataValue( dataValue ) );
            }

            return collection;
        }

        private string FormatDataValue( DataValue dataValue )
        {
            string value = "Null";
            if ( dataValue.Value != null )
            {
                value = dataValue.Value.ToString(); 
            }
            return string.Format( "{0} {1} {2}",
                dataValue.StatusCode.ToString(),
                value,
                FormatDateTime( dataValue.ServerTimestamp) );
        }

        #region Creation Helpers


        private HistoricalDataConfigurationState CreateConfig(NodeState parent,
            string path,
            string name,
            byte percentBad,
            byte percentGood,
            bool uncertainAsBad,
            bool slopedExtrapolation,
            bool stepped)
        {
            HistoricalDataConfigurationState historicalDataConfigurationState = new HistoricalDataConfigurationState(parent);

            historicalDataConfigurationState.Stepped = new PropertyState<bool>(historicalDataConfigurationState) { Value = stepped };
            historicalDataConfigurationState.AggregateConfiguration = new AggregateConfigurationState(historicalDataConfigurationState);
            historicalDataConfigurationState.AggregateConfiguration.PercentDataBad =
                new PropertyState<byte>(historicalDataConfigurationState.AggregateConfiguration) { Value = percentBad };
            historicalDataConfigurationState.AggregateConfiguration.PercentDataGood =
                new PropertyState<byte>(historicalDataConfigurationState.AggregateConfiguration) { Value = percentGood };
            historicalDataConfigurationState.AggregateConfiguration.TreatUncertainAsBad =
                new PropertyState<bool>(historicalDataConfigurationState.AggregateConfiguration) { Value = uncertainAsBad };
            historicalDataConfigurationState.AggregateConfiguration.UseSlopedExtrapolation =
                new PropertyState<bool>(historicalDataConfigurationState.AggregateConfiguration) { Value = slopedExtrapolation };

            NodeId desiredNodeId = new NodeId(path, NamespaceIndex);
            historicalDataConfigurationState.Create(
                SystemContext,
                desiredNodeId,
                new QualifiedName(name, NamespaceIndex),
                new LocalizedText(name),
                assignNodeIds: true);

            //historicalDataConfigurationState.NodeId = desiredNodeId;

            historicalDataConfigurationState.Definition = null;
            historicalDataConfigurationState.ExceptionDeviation = null;
            historicalDataConfigurationState.ExceptionDeviationFormat = null;
            historicalDataConfigurationState.MaxTimeInterval = null;
            historicalDataConfigurationState.MinTimeInterval = null;
            historicalDataConfigurationState.ServerTimestampSupported = null;
            historicalDataConfigurationState.StartOfArchive = null;
            historicalDataConfigurationState.StartOfOnlineArchive = null;
            historicalDataConfigurationState.AggregateFunctions = null;

            if (parent != null)
            {
                parent.AddChild(historicalDataConfigurationState);
            }

            return historicalDataConfigurationState;
        }

        private BaseObjectState CreateObject(NodeState parent,
            string path,
            string name,
            uint referenceTypeId,
            NodeId objectType)
        {
            BaseObjectState folder = new BaseObjectState(parent);

            folder.SymbolicName = name;
            folder.ReferenceTypeId = referenceTypeId;// ReferenceTypes.Organizes;
            folder.TypeDefinitionId = objectType;// ObjectTypeIds.BaseObjectType;
            folder.NodeId = new NodeId(path, NamespaceIndex);
            folder.BrowseName = new QualifiedName(name, NamespaceIndex);
            folder.DisplayName = folder.BrowseName.Name;
            folder.WriteMask = AttributeWriteMask.None;
            folder.UserWriteMask = AttributeWriteMask.None;
            folder.EventNotifier = EventNotifiers.None;

            if (parent != null)
            {
                parent.AddChild(folder);
            }

            return folder;
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

        private BaseDataVariableState CreateProperty(NodeState parent,
            string path, string name, NodeId dataType, int valueRank)
        {
            BaseDataVariableState variable = new BaseDataVariableState(parent);
            variable.SymbolicName = name;
            variable.ReferenceTypeId = ReferenceTypes.HasProperty;
            variable.TypeDefinitionId = VariableTypeIds.PropertyType;
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

        #endregion

        #region Simulation

        private void DoSimulation(object state)
        {
            if (m_allowEntry)
            {
                m_allowEntry = false;

                try
                {

                    NodeState myOneVariable = Find(
                        new NodeId("Aggregates.SingleVariable", NamespaceIndex));
                    BaseDataVariableState variableState = myOneVariable as BaseDataVariableState;
                    if (variableState != null)
                    {
                        variableState.Value = DateTime.UtcNow.Second;
                        variableState.Timestamp = DateTime.UtcNow;
                        variableState.ClearChangeMasks(SystemContext, false);
                    }
                }
                catch (Exception ex)
                {
                    Utils.LogInfo(ex, "Aggregates Loop Exception");
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

        private DataValueCollection GetValues(BaseVariableState nodeState)
        {
            DataValueCollection dataValues = null;
            int index = GetSpecIndex(nodeState.NodeId);
            if (index > 0)
            {
                dataValues = GetSpecData(nodeState);
            }
            else if ( nodeState.NodeId.ToString().Contains( "7773" ) )
            {
                dataValues = Get7773Data(nodeState);
            }
            else
            {
                dataValues = GetCTTData(nodeState);
            }

            return dataValues;
        }

        private DataValueCollection GetSpecData(BaseVariableState nodeState)
        {
            DataValueCollection collection = null;

            string nodeIdString = nodeState.NodeId.ToString();

            if (!Data.TryGetValue(nodeIdString, out collection))
            {
                int specIndex = GetSpecIndex(nodeState.NodeId);
                DateTime root = DateTime.UtcNow;

                switch (specIndex)
                {
                    case 1:
                    {
                        collection = new DataValueCollection();

                        byte value = 0;
                        collection.Add(new DataValue(
                            new Variant(),
                            new StatusCode(StatusCodes.BadNoData),
                            CreateTimestamp(root, minutes: 0, seconds: (int)value),
                            CreateTimestamp(root, minutes: 0, seconds: (int)value)));

                        value = 10;
                        collection.Add(new DataValue(
                            new Variant(value),
                            new StatusCode(StatusCodes.Good),
                            CreateTimestamp(root, minutes: 0, seconds: (int)value),
                            CreateTimestamp(root, minutes: 0, seconds: (int)value)));

                        value = 20;
                        collection.Add(new DataValue(
                            new Variant(value),
                            new StatusCode(StatusCodes.Good),
                            CreateTimestamp(root, minutes: 0, seconds: (int)value),
                            CreateTimestamp(root, minutes: 0, seconds: (int)value)));

                        value = 30;
                        collection.Add(new DataValue(
                            new Variant(value),
                            new StatusCode(StatusCodes.Good),
                            CreateTimestamp(root, minutes: 0, seconds: (int)value),
                            CreateTimestamp(root, minutes: 0, seconds: (int)value)));

                        value = 40;
                        collection.Add(new DataValue(
                            new Variant(),
                            new StatusCode(StatusCodes.Bad),
                            CreateTimestamp(root, minutes: 0, seconds: (int)value),
                            CreateTimestamp(root, minutes: 0, seconds: (int)value)));

                        value = 50;
                        collection.Add(new DataValue(
                            new Variant(value),
                            new StatusCode(StatusCodes.Good),
                            CreateTimestamp(root, minutes: 0, seconds: (int)value),
                            CreateTimestamp(root, minutes: 0, seconds: (int)value)));

                        value = 60;
                        collection.Add(new DataValue(
                            new Variant(value),
                            new StatusCode(StatusCodes.Good),
                            CreateTimestamp(root, minutes: 0, seconds: (int)value),
                            CreateTimestamp(root, minutes: 0, seconds: (int)value)));

                        value = 70;
                        collection.Add(new DataValue(
                            new Variant(value),
                            new StatusCode(StatusCodes.Uncertain),
                            CreateTimestamp(root, minutes: 0, seconds: (int)value),
                            CreateTimestamp(root, minutes: 0, seconds: (int)value)));

                        value = 80;
                        collection.Add(new DataValue(
                            new Variant(value),
                            new StatusCode(StatusCodes.Good),
                            CreateTimestamp(root, minutes: 0, seconds: (int)value),
                            CreateTimestamp(root, minutes: 0, seconds: (int)value)));

                        value = 90;
                        collection.Add(new DataValue(
                            new Variant(value),
                            new StatusCode(StatusCodes.Good),
                            CreateTimestamp(root, minutes: 0, seconds: (int)value),
                            CreateTimestamp(root, minutes: 0, seconds: (int)value)));

                        Data.Add(nodeIdString, collection);

                        break;
                    }

                    case 2:
                    {
                        collection = new DataValueCollection();

                        byte value = 0;
                        collection.Add(new DataValue(
                            new Variant(),
                            new StatusCode(StatusCodes.BadNoData),
                            CreateTimestamp(root, minutes: 0, seconds: 0),
                            CreateTimestamp(root, minutes: 0, seconds: 0)));

                        value = 10;
                        collection.Add(new DataValue(
                            new Variant(value),
                            new StatusCode(StatusCodes.Good),
                            CreateTimestamp(root, minutes: 0, seconds: 2),
                            CreateTimestamp(root, minutes: 0, seconds: 2)));

                        value = 20;
                        collection.Add(new DataValue(
                            new Variant(value),
                            new StatusCode(StatusCodes.Good),
                            CreateTimestamp(root, minutes: 0, seconds: 25),
                            CreateTimestamp(root, minutes: 0, seconds: 25)));

                        value = 25;
                        collection.Add(new DataValue(
                            new Variant(value),
                            new StatusCode(StatusCodes.Good),
                            CreateTimestamp(root, minutes: 0, seconds: 28),
                            CreateTimestamp(root, minutes: 0, seconds: 28)));

                        value = 30;
                        collection.Add(new DataValue(
                            new Variant(value),
                            new StatusCode(StatusCodes.Good),
                            CreateTimestamp(root, minutes: 0, seconds: 39),
                            CreateTimestamp(root, minutes: 0, seconds: 39)));

                        collection.Add(new DataValue(
                            new Variant(),
                            new StatusCode(StatusCodes.Bad),
                            CreateTimestamp(root, minutes: 0, seconds: 42),
                            CreateTimestamp(root, minutes: 0, seconds: 42)));

                        value = 40;
                        collection.Add(new DataValue(
                            new Variant(value),
                            new StatusCode(StatusCodes.Good),
                            CreateTimestamp(root, minutes: 0, seconds: 48),
                            CreateTimestamp(root, minutes: 0, seconds: 48)));

                        value = 50;
                        collection.Add(new DataValue(
                            new Variant(value),
                            new StatusCode(StatusCodes.Good),
                            CreateTimestamp(root, minutes: 0, seconds: 52),
                            CreateTimestamp(root, minutes: 0, seconds: 52)));

                        value = 60;
                        collection.Add(new DataValue(
                            new Variant(value),
                            new StatusCode(StatusCodes.Good),
                            CreateTimestamp(root, minutes: 1, seconds: 12),
                            CreateTimestamp(root, minutes: 1, seconds: 12)));

                        value = 70;
                        collection.Add(new DataValue(
                            new Variant(value),
                            new StatusCode(StatusCodes.Uncertain),
                            CreateTimestamp(root, minutes: 1, seconds: 17),
                            CreateTimestamp(root, minutes: 1, seconds: 17)));

                        value = 70;
                        collection.Add(new DataValue(
                            new Variant(value),
                            new StatusCode(StatusCodes.Good),
                            CreateTimestamp(root, minutes: 1, seconds: 23),
                            CreateTimestamp(root, minutes: 1, seconds: 23)));

                        value = 80;
                        collection.Add(new DataValue(
                            new Variant(value),
                            new StatusCode(StatusCodes.Good),
                            CreateTimestamp(root, minutes: 1, seconds: 26),
                            CreateTimestamp(root, minutes: 1, seconds: 26)));

                        value = 90;
                        collection.Add(new DataValue(
                            new Variant(value),
                            new StatusCode(StatusCodes.Good),
                            CreateTimestamp(root, minutes: 1, seconds: 30),
                            CreateTimestamp(root, minutes: 1, seconds: 30)));

                        Data.Add(nodeIdString, collection);

                        break;
                    }

                    case 3:
                    {
                        collection = new DataValueCollection();

                        byte value = 0;
                        collection.Add(new DataValue(
                            new Variant(),
                            new StatusCode(StatusCodes.BadNoData),
                            CreateTimestamp(root, minutes: 0, seconds: 0),
                            CreateTimestamp(root, minutes: 0, seconds: 0)));

                        value = 10;
                        collection.Add(new DataValue(
                            new Variant(value),
                            new StatusCode(StatusCodes.Good),
                            CreateTimestamp(root, minutes: 0, seconds: 2),
                            CreateTimestamp(root, minutes: 0, seconds: 2)));

                        value = 20;
                        collection.Add(new DataValue(
                            new Variant(value),
                            new StatusCode(StatusCodes.Good),
                            CreateTimestamp(root, minutes: 0, seconds: 25),
                            CreateTimestamp(root, minutes: 0, seconds: 25)));

                        value = 25;
                        collection.Add(new DataValue(
                            new Variant(value),
                            new StatusCode(StatusCodes.Good),
                            CreateTimestamp(root, minutes: 0, seconds: 28),
                            CreateTimestamp(root, minutes: 0, seconds: 28)));

                        value = 30;
                        collection.Add(new DataValue(
                            new Variant(value),
                            new StatusCode(StatusCodes.Good),
                            CreateTimestamp(root, minutes: 0, seconds: 39),
                            CreateTimestamp(root, minutes: 0, seconds: 39)));

                        collection.Add(new DataValue(
                            new Variant(),
                            new StatusCode(StatusCodes.Bad),
                            CreateTimestamp(root, minutes: 0, seconds: 42),
                            CreateTimestamp(root, minutes: 0, seconds: 42)));

                        value = 40;
                        collection.Add(new DataValue(
                            new Variant(value),
                            new StatusCode(StatusCodes.Good),
                            CreateTimestamp(root, minutes: 0, seconds: 48),
                            CreateTimestamp(root, minutes: 0, seconds: 48)));

                        value = 50;
                        collection.Add(new DataValue(
                            new Variant(value),
                            new StatusCode(StatusCodes.Good),
                            CreateTimestamp(root, minutes: 0, seconds: 52),
                            CreateTimestamp(root, minutes: 0, seconds: 52)));

                        value = 60;
                        collection.Add(new DataValue(
                            new Variant(value),
                            new StatusCode(StatusCodes.Good),
                            CreateTimestamp(root, minutes: 1, seconds: 12),
                            CreateTimestamp(root, minutes: 1, seconds: 12)));

                        value = 70;
                        collection.Add(new DataValue(
                            new Variant(value),
                            new StatusCode(StatusCodes.Uncertain),
                            CreateTimestamp(root, minutes: 1, seconds: 17),
                            CreateTimestamp(root, minutes: 1, seconds: 17)));

                        value = 70;
                        collection.Add(new DataValue(
                            new Variant(value),
                            new StatusCode(StatusCodes.Good),
                            CreateTimestamp(root, minutes: 1, seconds: 23),
                            CreateTimestamp(root, minutes: 1, seconds: 23)));

                        value = 80;
                        collection.Add(new DataValue(
                            new Variant(value),
                            new StatusCode(StatusCodes.Good),
                            CreateTimestamp(root, minutes: 1, seconds: 26),
                            CreateTimestamp(root, minutes: 1, seconds: 26)));

                        value = 90;
                        collection.Add(new DataValue(
                            new Variant(value),
                            new StatusCode(StatusCodes.Good),
                            CreateTimestamp(root, minutes: 1, seconds: 30),
                            CreateTimestamp(root, minutes: 1, seconds: 30)));

                        Data.Add(nodeIdString, collection);

                        break;
                    }

                    case 4:
                    {
                        collection = new DataValueCollection();

                        bool value = false;
                        collection.Add(new DataValue(
                            new Variant(),
                            new StatusCode(StatusCodes.BadNoData),
                            CreateTimestamp(root, minutes: 0, seconds: 0),
                            CreateTimestamp(root, minutes: 0, seconds: 0)));

                        value = true;
                        collection.Add(new DataValue(
                            new Variant(value),
                            new StatusCode(StatusCodes.Good),
                            CreateTimestamp(root, minutes: 0, seconds: 2),
                            CreateTimestamp(root, minutes: 0, seconds: 2)));

                        value = false;
                        collection.Add(new DataValue(
                            new Variant(value),
                            new StatusCode(StatusCodes.Good),
                            CreateTimestamp(root, minutes: 0, seconds: 25),
                            CreateTimestamp(root, minutes: 0, seconds: 25)));

                        value = true;
                        collection.Add(new DataValue(
                            new Variant(value),
                            new StatusCode(StatusCodes.Good),
                            CreateTimestamp(root, minutes: 0, seconds: 28),
                            CreateTimestamp(root, minutes: 0, seconds: 28)));

                        value = true;
                        collection.Add(new DataValue(
                            new Variant(value),
                            new StatusCode(StatusCodes.Good),
                            CreateTimestamp(root, minutes: 0, seconds: 39),
                            CreateTimestamp(root, minutes: 0, seconds: 39)));

                        collection.Add(new DataValue(
                            new Variant(),
                            new StatusCode(StatusCodes.Bad),
                            CreateTimestamp(root, minutes: 0, seconds: 42),
                            CreateTimestamp(root, minutes: 0, seconds: 42)));

                        value = true;
                        collection.Add(new DataValue(
                            new Variant(value),
                            new StatusCode(StatusCodes.Good),
                            CreateTimestamp(root, minutes: 0, seconds: 48),
                            CreateTimestamp(root, minutes: 0, seconds: 48)));

                        value = false;
                        collection.Add(new DataValue(
                            new Variant(value),
                            new StatusCode(StatusCodes.Good),
                            CreateTimestamp(root, minutes: 0, seconds: 52),
                            CreateTimestamp(root, minutes: 0, seconds: 52)));

                        value = false;
                        collection.Add(new DataValue(
                            new Variant(value),
                            new StatusCode(StatusCodes.Good),
                            CreateTimestamp(root, minutes: 1, seconds: 12),
                            CreateTimestamp(root, minutes: 1, seconds: 12)));

                        value = true;
                        collection.Add(new DataValue(
                            new Variant(value),
                            new StatusCode(StatusCodes.Uncertain),
                            CreateTimestamp(root, minutes: 1, seconds: 17),
                            CreateTimestamp(root, minutes: 1, seconds: 17)));

                        value = true;
                        collection.Add(new DataValue(
                            new Variant(value),
                            new StatusCode(StatusCodes.Good),
                            CreateTimestamp(root, minutes: 1, seconds: 23),
                            CreateTimestamp(root, minutes: 1, seconds: 23)));

                        value = false;
                        collection.Add(new DataValue(
                            new Variant(value),
                            new StatusCode(StatusCodes.Good),
                            CreateTimestamp(root, minutes: 1, seconds: 26),
                            CreateTimestamp(root, minutes: 1, seconds: 26)));

                        value = true;
                        collection.Add(new DataValue(
                            new Variant(value),
                            new StatusCode(StatusCodes.Good),
                            CreateTimestamp(root, minutes: 1, seconds: 30),
                            CreateTimestamp(root, minutes: 1, seconds: 30)));

                        Data.Add(nodeIdString, collection);

                        break;
                    }

                    case 5:
                    {
                        collection = new DataValueCollection();

                        byte value = 0;
                        collection.Add(new DataValue(
                            new Variant(),
                            new StatusCode(StatusCodes.BadNoData),
                            CreateTimestamp(root, minutes: 0, seconds: 0),
                            CreateTimestamp(root, minutes: 0, seconds: 0)));

                        value = 10;
                        collection.Add(new DataValue(
                            new Variant(value),
                            new StatusCode(StatusCodes.Good),
                            CreateTimestamp(root, minutes: 0, seconds: 2),
                            CreateTimestamp(root, minutes: 0, seconds: 2)));

                        value = 20;
                        collection.Add(new DataValue(
                            new Variant(value),
                            new StatusCode(StatusCodes.Good),
                            CreateTimestamp(root, minutes: 0, seconds: 25),
                            CreateTimestamp(root, minutes: 0, seconds: 25)));

                        value = 10;
                        collection.Add(new DataValue(
                            new Variant(value),
                            new StatusCode(StatusCodes.Good),
                            CreateTimestamp(root, minutes: 0, seconds: 28),
                            CreateTimestamp(root, minutes: 0, seconds: 28)));

                        value = 30;
                        collection.Add(new DataValue(
                            new Variant(value),
                            new StatusCode(StatusCodes.Good),
                            CreateTimestamp(root, minutes: 0, seconds: 39),
                            CreateTimestamp(root, minutes: 0, seconds: 39)));

                        collection.Add(new DataValue(
                            new Variant(),
                            new StatusCode(StatusCodes.Bad),
                            CreateTimestamp(root, minutes: 0, seconds: 42),
                            CreateTimestamp(root, minutes: 0, seconds: 42)));

                        value = 30;
                        collection.Add(new DataValue(
                            new Variant(value),
                            new StatusCode(StatusCodes.Good),
                            CreateTimestamp(root, minutes: 0, seconds: 48),
                            CreateTimestamp(root, minutes: 0, seconds: 48)));

                        value = 50;
                        collection.Add(new DataValue(
                            new Variant(value),
                            new StatusCode(StatusCodes.Good),
                            CreateTimestamp(root, minutes: 0, seconds: 52),
                            CreateTimestamp(root, minutes: 0, seconds: 52)));

                        value = 30;
                        collection.Add(new DataValue(
                            new Variant(value),
                            new StatusCode(StatusCodes.Good),
                            CreateTimestamp(root, minutes: 1, seconds: 12),
                            CreateTimestamp(root, minutes: 1, seconds: 12)));

                        value = 70;
                        collection.Add(new DataValue(
                            new Variant(value),
                            new StatusCode(StatusCodes.Uncertain),
                            CreateTimestamp(root, minutes: 1, seconds: 17),
                            CreateTimestamp(root, minutes: 1, seconds: 17)));

                        value = 70;
                        collection.Add(new DataValue(
                            new Variant(value),
                            new StatusCode(StatusCodes.Good),
                            CreateTimestamp(root, minutes: 1, seconds: 23),
                            CreateTimestamp(root, minutes: 1, seconds: 23)));

                        value = 80;
                        collection.Add(new DataValue(
                            new Variant(value),
                            new StatusCode(StatusCodes.Good),
                            CreateTimestamp(root, minutes: 1, seconds: 26),
                            CreateTimestamp(root, minutes: 1, seconds: 26)));

                        value = 70;
                        collection.Add(new DataValue(
                            new Variant(value),
                            new StatusCode(StatusCodes.Good),
                            CreateTimestamp(root, minutes: 1, seconds: 30),
                            CreateTimestamp(root, minutes: 1, seconds: 30)));

                        Data.Add(nodeIdString, collection);

                        break;
                    }
                }
            }

            return collection;
        }

        enum MultipleInstanceId
        {
            First,
            Second,
            Third
        }

        private DataValueCollection GetTestData(BaseVariableState nodeState)
        {
            DataValueCollection collection = null;

            string nodeIdString = nodeState.NodeId.ToString();

            int specIndex = GetSpecIndex(nodeState.NodeId);
            if (specIndex > 0)
            {
                collection = GetSpecData(nodeState);
            }
            else if ( nodeIdString.Contains( "7773_CustomerData" ) )
            {
                collection = Get7773CustomerData(nodeState);
            }
            else if (nodeIdString.Contains("7773") )
            {
                collection = Get7773Data(nodeState);
            }
            else
            {
                collection = GetCTTData(nodeState);
            }

            return collection;
        }


        private DataValueCollection GetCTTData(BaseVariableState nodeState)
        {
            DataValueCollection collection = null;

            string nodeIdString = nodeState.NodeId.ToString();

            if (!Data.TryGetValue(nodeIdString, out collection))
            {
                #region whichone

                MultipleInstanceId whichOne = MultipleInstanceId.Third;

                if (nodeIdString.EndsWith("_First"))
                {
                    whichOne = MultipleInstanceId.First;
                }
                else if (nodeIdString.EndsWith("_Second"))
                {
                    whichOne = MultipleInstanceId.Second;
                }

                #endregion

                uint dataTypeId = (uint)nodeState.DataType.Identifier;

                int numberOfValues = NUMBER_OF_VALUES_TO_ADD;
                collection = new DataValueCollection(numberOfValues);

                DateTime startTime = DateTime.UtcNow;
                int seed = startTime.Millisecond;
                if (seed > 10000)
                {
                    throw new Exception("Unexpected");
                }

                int numberOfSecondsToSubtract = numberOfValues * 1000;
                DateTime workingTime = startTime.AddMilliseconds(-numberOfSecondsToSubtract);

                bool setBadDataTime = true;
                int setBadAtMaximumBadCount = 2;

                int desiredErrorCount = 5;
                bool incrementErrorCount = true;
                int maximumDesiredErrorCount = 10;
                int timesAtMaximumBadCount = 3;
                int currentErrorCount = 0;
                int currentTimesAtMaximumBadCount = 0;
                bool badData = false;

                int badDataInterval = GetBadDataInterval(dataTypeId);
                int millisecondInterval = GetMillisecondInterval(dataTypeId);

                for (int index = 0; index < numberOfValues; index++)
                {
                    Variant variant = new Variant();
                    StatusCode valueStatus = StatusCodes.Good;

                    if (index > 0 && index % badDataInterval == 0)
                    {
                        badData = true;

                        currentErrorCount = 0;

                        if (incrementErrorCount)
                        {
                            desiredErrorCount++;
                            if (desiredErrorCount >= maximumDesiredErrorCount)
                            {
                                desiredErrorCount = maximumDesiredErrorCount;
                                currentTimesAtMaximumBadCount++;
                                if (currentTimesAtMaximumBadCount == setBadAtMaximumBadCount)
                                {
                                    if (setBadDataTime)
                                    {
                                        DateTime badDataTime = new DateTime(workingTime.Ticks);

                                        //DateTime usableBadDataTime = badDataTime.ToUniversalTime();
                                        //DateTime usableBadDataTime = badDataTime.ToLocalTime();
                                        List<BaseInstanceState> children = new List<BaseInstanceState>();
                                        nodeState.GetChildren(SystemContext, children);
                                        foreach (BaseInstanceState child in children)
                                        {
                                            if (child.SymbolicName.Equals("StartOfBadData"))
                                            {
                                                BaseDataVariableState childVariable = child as BaseDataVariableState;
                                                if (childVariable != null)
                                                {
                                                    Utils.LogInfo("Creating bad Data for {0} as {1}",
                                                        nodeIdString, FormatDateTime(workingTime) );
                                                    childVariable.Value = new Variant(workingTime);
                                                    childVariable.StatusCode = StatusCodes.Good;
                                                    childVariable.Timestamp = DateTime.UtcNow;

                                                    // notifies any monitored items that the value has changed.
                                                    childVariable.ClearChangeMasks(SystemContext, false);
                                                }
                                                break;
                                            }
                                        }

                                        setBadDataTime = false;
                                    }
                                }
                                else if (currentTimesAtMaximumBadCount == timesAtMaximumBadCount)
                                {
                                    incrementErrorCount = false;
                                    currentTimesAtMaximumBadCount = 0;
                                }
                            }
                        }
                        else
                        {
                            desiredErrorCount--;
                            if (desiredErrorCount == 0)
                            {
                                desiredErrorCount = 2;
                                incrementErrorCount = true;
                            }
                        }
                    }

                    if (badData)
                    {
                        bool useUncertain = false;
                        if (desiredErrorCount > 2)
                        {
                            //useUncertain = true;
                        }

                        valueStatus = StatusCodes.Bad;

                        if (useUncertain && currentErrorCount == 0)
                        {
                            // Make the first and last one uncertain
                            valueStatus = StatusCodes.Uncertain;
                        }

                        currentErrorCount++;

                        if (currentErrorCount == desiredErrorCount)
                        {
                            if (useUncertain)
                            {
                                valueStatus = StatusCodes.Uncertain;
                            }

                            badData = false;
                        }
                    }

                    if (valueStatus.Code != StatusCodes.Bad)
                    {
                        variant = GetVariant(dataTypeId, seed, index, whichOne);
                    }

                    collection.Add(new DataValue(variant, valueStatus, workingTime, workingTime));
                    workingTime = workingTime.AddMilliseconds(millisecondInterval);
                }

                if (collection.Count > 0)
                {
                    PrintCollection("Data Creation", nodeIdString, collection);
                    Data.Add(nodeIdString, collection);
                }


            }

            return collection;
        }

        private DataValueCollection Get7773Data(BaseVariableState nodeState)
        {
            DataValueCollection collection = null;

            string nodeIdString = nodeState.NodeId.ToString();

            if (!Data.TryGetValue(nodeIdString, out collection))
            {
                uint dataTypeId = (uint)nodeState.DataType.Identifier;

                int numberOfValues = MINIMAL_NUMBER_OF_VALUES_TO_ADD;
                collection = new DataValueCollection(numberOfValues);

                DateTime startTime = DateTime.UtcNow;
                double seed = startTime.Millisecond / startTime.Minute;

                if (seed < 1)
                {
                    seed += startTime.Second;
                }

                int numberOfSecondsToSubtract = numberOfValues * 1000;
                DateTime workingTime = startTime.AddMilliseconds(-numberOfSecondsToSubtract);
                int millisecondInterval = GetMillisecondInterval(dataTypeId);

                StatusCode firstStatus = StatusCodes.Bad;
                StatusCode secondStatus = StatusCodes.Uncertain;

                if (nodeIdString.Contains("GoodUncertain"))
                {
                    firstStatus = StatusCodes.Uncertain;
                    secondStatus = StatusCodes.Bad;
                }

                bool stayBad = false;

                if (!nodeIdString.EndsWith( "Good" ))
                {
                    stayBad = true;
                }

                bool startOfBadData = false;

                for (int index = 0; index < numberOfValues; index++)
                {
                    Variant variant = GetSineVariant(dataTypeId, seed, index);
                    Annotation annotation = new Annotation();
                    annotation.AnnotationTime = workingTime;
                    annotation.Message = "Any Annotation";
                    annotation.UserName = "Archie";

                    ExtensionObject extensionObject = new ExtensionObject(Opc.Ua.DataTypeIds.Annotation, annotation);

                    Variant anAnnotation = new Variant(extensionObject);

                    StatusCode valueStatus = StatusCodes.Good;

                    if (index == 50)
                    {
                        valueStatus = firstStatus;
                    }
                    else if (index > 50)
                    {
                        if (index == 51 || stayBad)
                        {
                            valueStatus = secondStatus;
                        }
                    }

                    if ( StatusCode.IsBad( valueStatus ))
                    {
                        variant = new Variant();

                        if ( !startOfBadData )
                        {
                            List<BaseInstanceState> children = new List<BaseInstanceState>();

                            nodeState.GetChildren(SystemContext, children);
                            foreach (BaseInstanceState child in children)
                            {
                                if (child.SymbolicName.Equals("StartOfBadData"))
                                {
                                    BaseDataVariableState childVariable = child as BaseDataVariableState;
                                    if (childVariable != null)
                                    {
                                        Utils.LogInfo("Creating bad Data for {0} as {1}",
                                            nodeIdString, FormatDateTime(workingTime) );
                                        childVariable.Value = new Variant(workingTime);
                                        childVariable.StatusCode = StatusCodes.Good;
                                        childVariable.Timestamp = DateTime.UtcNow;

                                        // notifies any monitored items that the value has changed.
                                        childVariable.ClearChangeMasks(SystemContext, false);
                                    }
                                    break;
                                }
                            }
                            startOfBadData = true;
                        }
                    }

                    collection.Add(new DataValue(variant, valueStatus, workingTime, workingTime));
                    workingTime = workingTime.AddMilliseconds(millisecondInterval);
                }

                if (collection.Count > 0)
                {
                    PrintCollection("Data Creation", nodeIdString, collection);
                    Data.Add(nodeIdString, collection);
                }
            }

            return collection;
        }

        private DataValueCollection Get7773CustomerData(BaseVariableState nodeState)
        {
            DataValueCollection collection = null;

            string nodeIdString = nodeState.NodeId.ToString();

            if (!Data.TryGetValue(nodeIdString, out collection))
            {
                collection = new DataValueCollection();

                uint dataTypeId = (uint)nodeState.DataType.Identifier;

                // Read the data from file, and insert it.
                List<string> lines = new MyIo().ReadFile("./Aggregates/HistorianInteger2.txt");

                bool startOfBadData = false;

                foreach ( string line in lines )
                {
                    string[] parts = line.Split(',');

                    if (parts.Length >= 6)
                    {
                        DateTime time = DateTime.Parse(parts[0]).ToUniversalTime();
                        //parseTime.Kind = DateTimeKind.Utc;
                        
                        //DateTime time = parseTime.ToUniversalTime();

                        string status = parts[2];
                        StatusCode statusCode = new StatusCode(StatusCodes.Good);
                        if (status.Contains("Bad"))
                        {
                            // Bad does have a value.  Keep it in
                            statusCode = new StatusCode(StatusCodes.Bad);
                            if ( !startOfBadData )
                            {
                                List<BaseInstanceState> children = new List<BaseInstanceState>();

                                nodeState.GetChildren(SystemContext, children);
                                foreach (BaseInstanceState child in children)
                                {
                                    if (child.SymbolicName.Equals("StartOfBadData"))
                                    {
                                        BaseDataVariableState childVariable = child as BaseDataVariableState;
                                        if (childVariable != null)
                                        {
                                            Utils.LogInfo("Creating bad Data for {0} as {1}",
                                                nodeIdString, FormatDateTime(time));
                                            childVariable.Value = new Variant(time);
                                            childVariable.StatusCode = StatusCodes.Good;
                                            childVariable.Timestamp = DateTime.UtcNow;

                                            // notifies any monitored items that the value has changed.
                                            childVariable.ClearChangeMasks(SystemContext, false);
                                        }
                                        break;
                                    }
                                }
                                startOfBadData = true;
                            }
                        }
                        else if (status.Contains("Uncertain"))
                        {
                            statusCode = new StatusCode(StatusCodes.Uncertain);
                        }

                        Variant variant = new Variant();

                        if (parts[3].Contains("Raw"))
                        {
                            if (Int32.TryParse(parts[5], out Int32 value))
                            {
                                variant = new Variant(value);
                            }
                            else
                            {
                                bool unexpected = true;
                            }
                        }
                        else
                        {
                            if ( parts.Length >= 7 )
                            {
                                DateTime annotationTime = DateTime.Parse(parts[4]).ToUniversalTime();
                                string message = "";
                                for (int index = 6; index < parts.Length; index++)
                                {
                                    message += parts[index];
                                    if (index < parts.Length - 1)
                                    {
                                        message += ",";
                                    }
                                }

                                Annotation annotation = new Annotation();
                                annotation.AnnotationTime = annotationTime;
                                annotation.UserName = parts[5];
                                annotation.Message = message;

                                ExtensionObject extensionObject = new ExtensionObject(
                                    Opc.Ua.DataTypeIds.Annotation, annotation);
                                variant = new Variant( extensionObject );
                            }
                            else
                            {
                                bool unexpected = true;
                            }
                        }

                        collection.Add(new DataValue(variant, statusCode, time, time));
                    }
                }

                if (collection.Count > 0)
                {
                    PrintCollection("Data Creation", nodeIdString, collection);
                    Data.Add(nodeIdString, collection);
                }
            }

            return collection;
        }

        private Variant GetVariant(uint dataTypeId, int seed, int index, MultipleInstanceId whichOne)
        {
            Variant variant = new Variant();

            switch (dataTypeId)
            {
                case Opc.Ua.DataTypes.Boolean:
                {
                    bool boolValue = false;

                    int boolValueSeed = index + seed;
                    if (boolValueSeed % 2 == 0)
                    {
                        boolValue = true;
                    }

                    variant = new Variant(boolValue);

                    break;
                }

                case Opc.Ua.DataTypes.Byte:
                {
                    byte byteValue = (byte)(seed + index);

                    variant = new Variant(byteValue);

                    break;
                }

                case Opc.Ua.DataTypes.Double:
                {
                    byte byteValue = (byte)(seed + index);

                    double doubleHelper = (double)(index + 0.125);
                    double doubleValue = (double)(byteValue) * doubleHelper;
                    variant = new Variant(doubleValue);

                    break;
                }

                case Opc.Ua.DataTypes.Float:
                {
                    byte byteValue = (byte)(seed + index);

                    float floatHelper = (float)(index + 0.0625);
                    float floatValue = (float)(byteValue) * floatHelper;
                    variant = new Variant(floatValue);
                    break;
                }

                case Opc.Ua.DataTypes.Int32:
                {
                    int intValue = seed + index;
                    int maxValue = 1234567;
                    while (intValue > maxValue)
                    {
                        intValue = -maxValue;
                    }
                    variant = new Variant(intValue);
                    break;
                }

                case Opc.Ua.DataTypes.String:
                {
                    List<string> parts = null;
                    switch (whichOne)
                    {
                        case MultipleInstanceId.First:
                            parts = QuoteOneValues;
                            break;
                        case MultipleInstanceId.Second:
                            parts = QuoteTwoValues;
                            break;
                        default:
                            parts = QuoteThreeValues;
                            break;
                    }

                    int max = parts.Count;

                    int ss = index % max;
                    variant = new Variant(parts[ss]);

                    break;
                }
            }

            return variant;
        }

        private Variant GetSineVariant( uint dataTypeId, double seed, int index )
        {
            Variant variant = new Variant();

            double twoPi = Math.PI * 2;
            int maxValue = 100;

            double normalSpan = maxValue;
            double amplitude = normalSpan / 2;

            double period = twoPi / 15;

            double calculated = (amplitude * Math.Sin(period * (index))) + seed;

            int intCalc = (int)calculated;

            if ( dataTypeId.Equals( Opc.Ua.DataTypes.Int32 ) )
            {
                variant = intCalc;
            }
            else
            {
                variant = calculated;
            }

            return variant;
        }

        private int GetBadDataInterval(uint dataTypeId)
        {
            int interval = 50;

            switch (dataTypeId)
            {
                case Opc.Ua.DataTypes.Boolean:
                    interval = 49;
                    break;

                case Opc.Ua.DataTypes.Byte:
                    interval = 48;
                    break;

                case Opc.Ua.DataTypes.Double:
                    interval = 47;
                    break;

                case Opc.Ua.DataTypes.Float:
                    interval = 46;
                    break;

                case Opc.Ua.DataTypes.Int32:
                    interval = 45;
                    break;

                case Opc.Ua.DataTypes.String:
                    interval = 45;
                    break;

            }
            return interval;
        }

        private int GetMillisecondInterval(uint dataTypeId)
        {
            int interval = 1000;

            switch (dataTypeId)
            {
                case Opc.Ua.DataTypes.Boolean:
                    interval = 999;
                    break;

                case Opc.Ua.DataTypes.Byte:
                    interval = 998;
                    break;

                case Opc.Ua.DataTypes.Double:
                    interval = 997;
                    break;

                case Opc.Ua.DataTypes.Float:
                    interval = 996;
                    break;

                case Opc.Ua.DataTypes.Int32:
                    interval = 995;
                    break;

                case Opc.Ua.DataTypes.String:
                    interval = 995;
                    break;

            }
            return interval;
        }

        private DataValueCollection GetTimestampData(DataValueCollection collection, TimestampsToReturn timestampsToReturn)
        {
            DataValueCollection dataValues = new DataValueCollection();

            if (timestampsToReturn == TimestampsToReturn.Both)
            {
                return collection;
            }

            foreach (DataValue value in collection)
            {
                if (timestampsToReturn == TimestampsToReturn.Source)
                {
                    dataValues.Add(new DataValue(new Variant(value.Value), value.StatusCode, value.SourceTimestamp));
                }
                else if (timestampsToReturn == TimestampsToReturn.Server)
                {
                    DataValue newValue = new DataValue(new Variant(value.Value), value.StatusCode);
                    newValue.ServerTimestamp = value.ServerTimestamp;
                    dataValues.Add(newValue);
                }
                else
                {
                    Debug.WriteLine("");
                }
            }

            return dataValues;
        }

        private DataValueCollection LimitValueCount( DataValueCollection values, uint maximumValues )
        {
            int maximum = ( int )maximumValues;

            if ( values.Count <= maximum )
            {
                return values;
            }

            DataValueCollection returnValues = new DataValueCollection( maximum );
            for( int index = 0; index < maximum; index ++ )
            {
                returnValues.Add(values[ index ] );
            }

            return returnValues;
        }

        private DateTime CreateTimestamp(DateTime root, int minutes, int seconds)
        {
            DateTime dateTime = new DateTime(root.Year, root.Month, root.Day);
            DateTime minute = dateTime.AddMinutes(minutes);
            DateTime second = minute.AddSeconds(seconds);
            return second.ToUniversalTime();
        }

        private int GetSpecIndex(NodeId nodeId)
        {
            int index = -1;

            string nodeIdString = nodeId.ToString();

            string lastChar = new string(nodeIdString[nodeIdString.Length - 1], 1);

            int potentialSpecId;
            int.TryParse(lastChar, out potentialSpecId);

            if (nodeIdString.Contains("Historian_"))
            {
                index = potentialSpecId;
            }

            return index;
        }

        #endregion

        #region Private Fields

        private bool m_allowEntry = false;
        private const UInt16 kSimulationInterval = 100;
        private Timer m_simulationTimer;

        Dictionary<string, BaseDataVariableState> Variables = new Dictionary<string, BaseDataVariableState>();
        Dictionary<string, DataValueCollection> Data = new Dictionary<string, DataValueCollection>();

        private uint BoolVariableIndex = 4;

        private const string QuoteOne = "Life is not measured by the number of breaths we take but by the moments that take our breath away";
        private const string QuoteTwo = "I never dreamed about success I worked for it";
        private const string QuoteThree = "It's not the mountain we conquer but ourselves";

        private List<string> QuoteOneValues = null;
        private List<string> QuoteTwoValues = null;
        private List<string> QuoteThreeValues = null;
        //private int QuoteOneIndex = 0;
        //private int QuoteTwoIndex = 0;
        //private int QuoteThreeIndex = 0;

        HistoricalDataConfigurationState DefaultConfig = null;
        HistoricalDataConfigurationState AlternateConfig = null;
        BaseDataVariableState ConfigurationStatus = null;


        private const int NUMBER_OF_VALUES_TO_ADD = 1000;
        private const int MINIMAL_NUMBER_OF_VALUES_TO_ADD = 200;

        #endregion

    }
}
