using System;
using System.Collections.Generic;
using System.Device.Gpio;
using System.Diagnostics;
using System.IO;
using System.Threading;

using Opc.Ua.Server;
using Opc.Ua;


namespace PiNameSpace
{
    #region Notes

    /*
     * https://learn.microsoft.com/en-us/dotnet/iot/deployment
     * 
     * Secure Copy https://www.raspberrypi.com/documentation/computers/remote-access.html#using-secure-copy
     * scp -r /publish-location/* pi@raspberrypi:/home/pi/deployment-location/
     * or in my case... 
     * 
     * scp -r E:/repos/forks/UA-.NETStandard/Applications/ConsoleReferenceServer/bin/Release/net6.0/linux-arm64/* archie@raspberrypi:/home/archie/Server/
     * chmod +x ./ConsoleReferenceServer
     * ./ConsoleReferenceServer
     * 
     * When hooking up the Motion sensor, remember that the image is a mirror!  THis affects the power/gnd
     * Add SSH
     * sudo apt-get upgrade
     * sudo apt-get update
     * curl -sSL https://dot.net/v1/dotnet-install.sh | bash /dev/stdin --channel STS
     * 
     */

    #endregion


    #region Namespace Declarations
    /// <summary>
    /// Defines constants for all namespaces referenced by the model design.
    /// </summary>
    public static partial class Namespaces
    {
        /// <summary>
        /// The URI for the Alarms namespace (.NET code namespace is 'Alarms').
        /// </summary>
        public const string Pi = "http://dreamsandadventures.org/UA/Pi/";
    }
    #endregion

    /// <summary>
    /// The factory for the Alarm Node Manager.
    /// </summary>
    public class PiManagerFactory : INodeManagerFactory
    {
        /// <inheritdoc/>
        public INodeManager Create(IServerInternal server, ApplicationConfiguration configuration)
        {
            return new PiNodeManager(server, configuration, NamespacesUris.ToArray());
        }

        /// <inheritdoc/>
        public StringCollection NamespacesUris
        {
            get
            {
                var uri = Namespaces.Pi;
                var instanceUri = uri + "Instance";
                return new StringCollection { uri, instanceUri };
            }
        }

    }

    public class PiNodeManager : CustomNodeManager2
    {
        private const int FanControlPin = 18; //1
        private const int MotionPin = 17; //0

        private const string VideoName = "NotFunnyCatVid";
        private const string VideoDirectory = "Vids";
        private const string VideoExe = "libcamera-vid";
        private const int VideoTimeInMilliseconds = 10000;

        #region Constructors
        /// <summary>
        /// Initializes the node manager.
        /// </summary>
        public PiNodeManager(IServerInternal server,
            ApplicationConfiguration configuration,
            string[] namespaceUris) :
            base(server, configuration, namespaceUris)
        {
            m_osDescription = System.Runtime.InteropServices.RuntimeInformation.OSDescription;

            m_isLinux = System.Runtime.InteropServices.RuntimeInformation.IsOSPlatform(
                System.Runtime.InteropServices.OSPlatform.Linux);

            if ( m_isLinux ) 
            {
                try
                {
                    DirectoryInfo directoryInfo = new DirectoryInfo(VideoDirectory);
                    if ( directoryInfo.Exists )
                    {
                        FileInfo[] files = directoryInfo.GetFiles();
                        int maxNumber = -1;
                        foreach ( FileInfo file in files )
                        {
                            string[] parts = file.Name.Split('_');
                            if ( parts.Length == 2 )
                            {
                                string[] partsTwo = parts[1].Split('.');
                                if ( partsTwo.Length == 2 )
                                {
                                    int number;
                                    if ( int.TryParse( partsTwo[0], out number ) )
                                    {
                                        if ( number > maxNumber )
                                        {
                                            maxNumber = number;
                                        }
                                    }
                                }
                            }
                        }
                        if ( maxNumber > 0 )
                        {
                            m_videoCounter = maxNumber + 1;
                        }
                    }

                    m_status = "Attempting BootStrap";

                    m_controller = new GpioController();
                    m_controller.OpenPin(FanControlPin, PinMode.Output);
                    m_controller.OpenPin(MotionPin, PinMode.Input);

                    m_status = "Pins Opened";
                }
                catch (Exception ex )
                {
                    m_exception = ex.Message;
                }
            }
            else
            {
                m_exception = "Not Linux, Namespace is Invalid";
            }
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

                    string PiName = "Pi";
                    string PiNodeName = PiName;

                    #endregion

                    #region Create Folder

                    FolderState PiFolder = CreateFolder(null, PiNodeName, PiName);
                    PiFolder.AddReference(ReferenceTypes.Organizes, true, ObjectIds.ObjectsFolder);
                    references.Add(
                        new NodeStateReference(ReferenceTypes.Organizes, false, PiFolder.NodeId));
                    PiFolder.EventNotifier = EventNotifiers.SubscribeToEvents;
                    AddRootNotifier(PiFolder);

                    #endregion

                    #region Create Variable

                    string osVariableName = "OperatingSystem";
                    string osVariableNodeName = PiNodeName + "." + osVariableName;

                    BaseDataVariableState osVariable = CreateVariable(PiFolder,
                        osVariableNodeName, osVariableName, DataTypeIds.String, ValueRanks.Scalar,
                        AccessLevels.CurrentRead );

                    string isLinuxVariableName = "IsLinux";
                    string isLinuxVariableNodeName = PiNodeName + "." + isLinuxVariableName;

                    BaseDataVariableState isLinuxVariable = CreateVariable(PiFolder,
                        isLinuxVariableNodeName, isLinuxVariableName, DataTypeIds.Boolean, ValueRanks.Scalar,
                        AccessLevels.CurrentRead);

                    string statusVariableName = "Status";
                    string statusVariableNodeName = PiNodeName + "." + statusVariableName;

                    BaseDataVariableState statusVariable = CreateVariable(PiFolder,
                        statusVariableNodeName, statusVariableName, DataTypeIds.String, ValueRanks.Scalar,
                        AccessLevels.CurrentRead);

                    string exceptionVariableName = "Exception";
                    string exceptionVariableNodeName = PiNodeName + "." + exceptionVariableName;

                    BaseDataVariableState exceptionVariable = CreateVariable(PiFolder,
                        exceptionVariableNodeName, exceptionVariableName, DataTypeIds.String, ValueRanks.Scalar,
                        AccessLevels.CurrentRead);

                    string singleVariableName = "SingleVariable";
                    string singleVariableNodeName = PiNodeName + "." + singleVariableName;

                    BaseDataVariableState singleVariable = CreateVariable(PiFolder,
                        singleVariableNodeName, singleVariableName, DataTypeIds.Int32, ValueRanks.Scalar);

                    string fanVariableName = "Fan";
                    string fanVariableNodeName = PiNodeName + "." + fanVariableName;

                    BaseDataVariableState fanVariable = CreateVariable(PiFolder,
                        fanVariableNodeName, fanVariableName, DataTypeIds.Boolean, ValueRanks.Scalar);

                    string fanSimulationVariableName = "FanSimulation";
                    string fanSimulationVariableNodeName = PiNodeName + "." + fanSimulationVariableName;

                    BaseDataVariableState fanSimulationVariable = CreateVariable(PiFolder,
                        fanSimulationVariableNodeName, fanSimulationVariableName, DataTypeIds.Boolean, ValueRanks.Scalar);

                    string motionVariableName = "Motion";
                    string motionVariableNodeName = PiNodeName + "." + motionVariableName;

                    BaseDataVariableState motionVariable = CreateVariable(PiFolder,
                        motionVariableNodeName, motionVariableName, DataTypeIds.Boolean, ValueRanks.Scalar,
                        AccessLevels.CurrentRead );

                    // Initialize it, as it is read regularly
                    motionVariable.Value = false;
                    motionVariable.Timestamp = DateTime.UtcNow;
                    motionVariable.ClearChangeMasks(SystemContext, false);

                    #endregion


                    AddPredefinedNode(SystemContext, PiFolder);
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
            string path, string name, NodeId dataType, int valueRank, byte accessLevels = AccessLevels.CurrentReadOrWrite)
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
            variable.AccessLevel = accessLevels;
            variable.UserAccessLevel = accessLevels;
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
                    if ( !m_isOsSet )
                    {
                        NodeState osVariable = Find(
                            new NodeId("Pi.OperatingSystem", NamespaceIndex));
                        BaseDataVariableState osVariableState = osVariable as BaseDataVariableState;
                        if (osVariableState != null)
                        {
                            osVariableState.Value = m_osDescription;
                            osVariableState.Timestamp = DateTime.UtcNow;
                            osVariableState.ClearChangeMasks(SystemContext, false);
                            
                        }

                        NodeState isLinux = Find(
                            new NodeId("Pi.IsLinux", NamespaceIndex));
                        BaseDataVariableState linux = isLinux as BaseDataVariableState;
                        if (linux != null)
                        {
                            linux.Value = m_isLinux;
                            linux.Timestamp = DateTime.UtcNow;
                            linux.ClearChangeMasks(SystemContext, false);

                        }

                        m_isOsSet = true;
                    }

                    int second = DateTime.UtcNow.Second;
                    NodeState myOneVariable = Find(
                        new NodeId("Pi.SingleVariable", NamespaceIndex));
                    BaseDataVariableState variableState = myOneVariable as BaseDataVariableState;
                    if ( variableState != null )
                    {
                        variableState.Value = second;
                        variableState.Timestamp = DateTime.UtcNow;
                        variableState.ClearChangeMasks(SystemContext, false);
                    }

                    bool updateFan = false;
                    m_fanCounter++;
                    if (m_fanCounter % 50 == 0)
                    {
                        m_fanValue = !m_fanValue;
                        m_fanCounter = 0;
                        updateFan = true;
                    }

                    if ( updateFan )
                    {
                        NodeState fanSimulationVariable = Find(
                            new NodeId("Pi.FanSimulation", NamespaceIndex));
                        BaseDataVariableState fanSimulationVariableState = myOneVariable as BaseDataVariableState;
                        if (fanSimulationVariableState != null)
                        {
                            fanSimulationVariableState.Value = m_fanValue;
                            fanSimulationVariableState.Timestamp = DateTime.UtcNow;
                            fanSimulationVariableState.ClearChangeMasks(SystemContext, false);
                        }

                        NodeState fanVariable = Find(
                            new NodeId("Pi.Fan", NamespaceIndex));
                        BaseDataVariableState fanVariableState = fanVariable as BaseDataVariableState;
                        if (fanVariableState != null)
                        {
                            PinValue writeValue = PinValue.Low;
                            if ( m_fanValue)
                            {
                                writeValue = PinValue.High;
                            }
                            if ( m_isLinux )
                            {
                                m_controller.Write(FanControlPin, writeValue);
                            }
                            fanVariableState.Value = m_fanValue;
                            fanVariableState.Timestamp = DateTime.UtcNow;
                            fanVariableState.ClearChangeMasks(SystemContext, false);
                        }
                    }

                    NodeState motionSensorVariable = Find(
                        new NodeId("Pi.Motion", NamespaceIndex));
                    BaseDataVariableState motionSensorVariableState = motionSensorVariable as BaseDataVariableState;
                    if (motionSensorVariableState != null)
                    {
                        bool currentStoredValue = (bool)motionSensorVariableState.Value;
                        PinValue currentReading = PinValue.Low;
                        if (m_isLinux)
                        {
                            currentReading = m_controller.Read(MotionPin);
                        }
                        else 
                        {
                            if ( second % 2 == 0)
                            {
                                currentReading = PinValue.High;
                            }
                        }

                        bool currentValue = currentReading == PinValue.High ? true : false;

                        if (currentStoredValue != currentValue)
                        {
                            motionSensorVariableState.Value = !currentStoredValue;
                            motionSensorVariableState.Timestamp = DateTime.UtcNow;
                            motionSensorVariableState.ClearChangeMasks(SystemContext, false);

                            if ( m_isLinux && currentValue )
                            {
                                string arguments = string.Format("-t {0} -o ./{1}/{2}_{3}.h264",
                                    VideoTimeInMilliseconds, VideoDirectory,
                                    VideoName, m_videoCounter.ToString().PadLeft(2, '0'));

                                Process process = Process.Start(
                                    new ProcessStartInfo( VideoExe, arguments ) );

                                if ( process != null )
                                {
                                    process.WaitForExit();
                                    m_videoCounter++;
                                }
                                else
                                {
                                    m_exception = "Unable to launch Exe for " + arguments;
                                }
                            }
                        }
                    }

                    NodeState statusVariable = Find(
                        new NodeId("Pi.Status", NamespaceIndex));
                    BaseDataVariableState status = statusVariable as BaseDataVariableState;
                    if (status != null)
                    {
                        status.Value = m_status;
                        status.Timestamp = DateTime.UtcNow;
                        status.ClearChangeMasks(SystemContext, false);
                    }

                    NodeState exceptionVariable = Find(
                        new NodeId("Pi.Exception", NamespaceIndex));
                    BaseDataVariableState exception = exceptionVariable as BaseDataVariableState;
                    if (exception != null)
                    {
                        exception.Value = m_exception;
                        exception.Timestamp = DateTime.UtcNow;
                        exception.ClearChangeMasks(SystemContext, false);
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

        private int m_fanCounter = 0;
        private bool m_fanValue = false;

        private string m_osDescription;
        private bool m_isOsSet = false;
        private bool m_isLinux = false;
        private string m_status = "";
        private string m_exception = "";

        private int m_videoCounter = 0;

        private GpioController m_controller = null;

        #endregion

    }
}
