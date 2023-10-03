/* ========================================================================
 * Copyright (c) 2005-2021 The OPC Foundation, Inc. All rights reserved.
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

using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Runtime.Serialization;
using Opc.Ua;
using UAModel.DI;
using UAModel.FXData;

namespace UAModel.FXAC
{
    #region AggregatedHealthTypeState Class
    #if (!OPCUA_EXCLUDE_AggregatedHealthTypeState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class AggregatedHealthTypeState : BaseDataVariableState<UAModel.FXAC.AggregatedHealthDataType>
    {
        #region Constructors
        /// <remarks />
        public AggregatedHealthTypeState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(UAModel.FXAC.VariableTypes.AggregatedHealthType, UAModel.FXAC.Namespaces.FXAC, namespaceUris);
        }

        /// <remarks />
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(UAModel.FXAC.DataTypes.AggregatedHealthDataType, UAModel.FXAC.Namespaces.FXAC, namespaceUris);
        }

        /// <remarks />
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AwAAACIAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvRlgvQUMvHwAAAGh0dHA6Ly9vcGNmb3Vu" +
           "ZGF0aW9uLm9yZy9VQS9ESS8kAAAAaHR0cDovL29wY2ZvdW5kYXRpb24ub3JnL1VBL0ZYL0RhdGEv////" +
           "/xVgqQICAAAAAQAcAAAAQWdncmVnYXRlZEhlYWx0aFR5cGVJbnN0YW5jZQEB0QcBAdEH0QcAABYBAY0T" +
           "AtcAAAA8QWdncmVnYXRlZEhlYWx0aERhdGFUeXBlIHhtbG5zPSJodHRwOi8vb3BjZm91bmRhdGlvbi5v" +
           "cmcvVUEvRlgvQUMvVHlwZXMueHNkIj48QWdncmVnYXRlZERldmljZUhlYWx0aD4wPC9BZ2dyZWdhdGVk" +
           "RGV2aWNlSGVhbHRoPjxBZ2dyZWdhdGVkT3BlcmF0aW9uYWxIZWFsdGg+MDwvQWdncmVnYXRlZE9wZXJh" +
           "dGlvbmFsSGVhbHRoPjwvQWdncmVnYXRlZEhlYWx0aERhdGFUeXBlPgEBuwv/////AQH/////AgAAABVg" +
           "iQoCAAAAAQAWAAAAQWdncmVnYXRlZERldmljZUhlYWx0aAEBpBcALwA/pBcAAAEBvQv/////AQH/////" +
           "AAAAABVgiQoCAAAAAQAbAAAAQWdncmVnYXRlZE9wZXJhdGlvbmFsSGVhbHRoAQGlFwAvAD+lFwAAAQHC" +
           "C/////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public BaseDataVariableState<ushort> AggregatedDeviceHealth
        {
            get
            {
                return m_aggregatedDeviceHealth;
            }

            set
            {
                if (!Object.ReferenceEquals(m_aggregatedDeviceHealth, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_aggregatedDeviceHealth = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<uint> AggregatedOperationalHealth
        {
            get
            {
                return m_aggregatedOperationalHealth;
            }

            set
            {
                if (!Object.ReferenceEquals(m_aggregatedOperationalHealth, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_aggregatedOperationalHealth = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_aggregatedDeviceHealth != null)
            {
                children.Add(m_aggregatedDeviceHealth);
            }

            if (m_aggregatedOperationalHealth != null)
            {
                children.Add(m_aggregatedOperationalHealth);
            }

            base.GetChildren(context, children);
        }
            
        /// <remarks />
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case UAModel.FXAC.BrowseNames.AggregatedDeviceHealth:
                {
                    if (createOrReplace)
                    {
                        if (AggregatedDeviceHealth == null)
                        {
                            if (replacement == null)
                            {
                                AggregatedDeviceHealth = new BaseDataVariableState<ushort>(this);
                            }
                            else
                            {
                                AggregatedDeviceHealth = (BaseDataVariableState<ushort>)replacement;
                            }
                        }
                    }

                    instance = AggregatedDeviceHealth;
                    break;
                }

                case UAModel.FXAC.BrowseNames.AggregatedOperationalHealth:
                {
                    if (createOrReplace)
                    {
                        if (AggregatedOperationalHealth == null)
                        {
                            if (replacement == null)
                            {
                                AggregatedOperationalHealth = new BaseDataVariableState<uint>(this);
                            }
                            else
                            {
                                AggregatedOperationalHealth = (BaseDataVariableState<uint>)replacement;
                            }
                        }
                    }

                    instance = AggregatedOperationalHealth;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private BaseDataVariableState<ushort> m_aggregatedDeviceHealth;
        private BaseDataVariableState<uint> m_aggregatedOperationalHealth;
        #endregion
    }

    #region AggregatedHealthTypeValue Class
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public class AggregatedHealthTypeValue : BaseVariableValue
    {
        #region Constructors
        /// <remarks />
        public AggregatedHealthTypeValue(AggregatedHealthTypeState variable, AggregatedHealthDataType value, object dataLock) : base(dataLock)
        {
            m_value = value;

            if (m_value == null)
            {
                m_value = new AggregatedHealthDataType();
            }

            Initialize(variable);
        }
        #endregion

        #region Public Members
        /// <remarks />
        public AggregatedHealthTypeState Variable
        {
            get { return m_variable; }
        }

        /// <remarks />
        public AggregatedHealthDataType Value
        {
            get { return m_value;  }
            set { m_value = value; }
        }
        #endregion

        #region Private Methods
        private void Initialize(AggregatedHealthTypeState variable)
        {
            lock (Lock)
            {
                m_variable = variable;

                variable.Value = m_value;

                variable.OnReadValue = OnReadValue;
                variable.OnSimpleWriteValue = OnWriteValue;

                BaseVariableState instance = null;
                List<BaseInstanceState> updateList = new List<BaseInstanceState>();
                updateList.Add(variable);

                instance = m_variable.AggregatedDeviceHealth;
                instance.OnReadValue = OnRead_AggregatedDeviceHealth;
                instance.OnSimpleWriteValue = OnWrite_AggregatedDeviceHealth;
                updateList.Add(instance);
                instance = m_variable.AggregatedOperationalHealth;
                instance.OnReadValue = OnRead_AggregatedOperationalHealth;
                instance.OnSimpleWriteValue = OnWrite_AggregatedOperationalHealth;
                updateList.Add(instance);

                SetUpdateList(updateList);
            }
        }

        /// <remarks />
        protected ServiceResult OnReadValue(
            ISystemContext context,
            NodeState node,
            NumericRange indexRange,
            QualifiedName dataEncoding,
            ref object value,
            ref StatusCode statusCode,
            ref DateTime timestamp)
        {
            lock (Lock)
            {
                DoBeforeReadProcessing(context, node);

                if (m_value != null)
                {
                    value = m_value;
                }

                return Read(context, node, indexRange, dataEncoding, ref value, ref statusCode, ref timestamp);
            }
        }

        private ServiceResult OnWriteValue(ISystemContext context, NodeState node, ref object value)
        {
            lock (Lock)
            {
                m_value = (AggregatedHealthDataType)Write(value);
            }

            return ServiceResult.Good;
        }

        #region AggregatedDeviceHealth Access Methods
        /// <remarks />
        private ServiceResult OnRead_AggregatedDeviceHealth(
            ISystemContext context,
            NodeState node,
            NumericRange indexRange,
            QualifiedName dataEncoding,
            ref object value,
            ref StatusCode statusCode,
            ref DateTime timestamp)
        {
            lock (Lock)
            {
                DoBeforeReadProcessing(context, node);

                if (m_value != null)
                {
                    value = m_value.AggregatedDeviceHealth;
                }

                return Read(context, node, indexRange, dataEncoding, ref value, ref statusCode, ref timestamp);
            }
        }

        /// <remarks />
        private ServiceResult OnWrite_AggregatedDeviceHealth(ISystemContext context, NodeState node, ref object value)
        {
            lock (Lock)
            {
                m_value.AggregatedDeviceHealth = (ushort)Write(value);
            }

            return ServiceResult.Good;
        }
        #endregion

        #region AggregatedOperationalHealth Access Methods
        /// <remarks />
        private ServiceResult OnRead_AggregatedOperationalHealth(
            ISystemContext context,
            NodeState node,
            NumericRange indexRange,
            QualifiedName dataEncoding,
            ref object value,
            ref StatusCode statusCode,
            ref DateTime timestamp)
        {
            lock (Lock)
            {
                DoBeforeReadProcessing(context, node);

                if (m_value != null)
                {
                    value = m_value.AggregatedOperationalHealth;
                }

                return Read(context, node, indexRange, dataEncoding, ref value, ref statusCode, ref timestamp);
            }
        }

        /// <remarks />
        private ServiceResult OnWrite_AggregatedOperationalHealth(ISystemContext context, NodeState node, ref object value)
        {
            lock (Lock)
            {
                m_value.AggregatedOperationalHealth = (uint)Write(value);
            }

            return ServiceResult.Good;
        }
        #endregion
        #endregion

        #region Private Fields
        private AggregatedHealthDataType m_value;
        private AggregatedHealthTypeState m_variable;
        #endregion
    }
    #endregion
    #endif
    #endregion

    #region AcDescriptorTypeState Class
    #if (!OPCUA_EXCLUDE_AcDescriptorTypeState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class AcDescriptorTypeState : BaseObjectState
    {
        #region Constructors
        /// <remarks />
        public AcDescriptorTypeState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(UAModel.FXAC.ObjectTypes.AcDescriptorType, UAModel.FXAC.Namespaces.FXAC, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);

            if (DescriptorFile != null)
            {
                DescriptorFile.Initialize(context, DescriptorFile_InitializationString);
            }

            if (DescriptorIdentifier != null)
            {
                DescriptorIdentifier.Initialize(context, DescriptorIdentifier_InitializationString);
            }

            if (DescriptorVersion != null)
            {
                DescriptorVersion.Initialize(context, DescriptorVersion_InitializationString);
            }
        }

        #region Initialization String
        private const string DescriptorFile_InitializationString =
           "AwAAACIAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvRlgvQUMvHwAAAGh0dHA6Ly9vcGNmb3Vu" +
           "ZGF0aW9uLm9yZy9VQS9ESS8kAAAAaHR0cDovL29wY2ZvdW5kYXRpb24ub3JnL1VBL0ZYL0RhdGEv////" +
           "/wRggAoBAAAAAQAOAAAARGVzY3JpcHRvckZpbGUBAdATAC8BADct0BMAAP////8KAAAAFWCJCgIAAAAA" +
           "AAQAAABTaXplAQHKGAAuAETKGAAAAAn/////AQH/////AAAAABVgiQoCAAAAAAAIAAAAV3JpdGFibGUB" +
           "AcwYAC4ARMwYAAAAAf////8BAf////8AAAAAFWCJCgIAAAAAAAwAAABVc2VyV3JpdGFibGUBAcsYAC4A" +
           "RMsYAAAAAf////8BAf////8AAAAAFWCJCgIAAAAAAAkAAABPcGVuQ291bnQBAcYYAC4ARMYYAAAABf//" +
           "//8BAf////8AAAAABGGCCgQAAAAAAAQAAABPcGVuAQFfGwAvAQA8LV8bAAABAf////8CAAAAF2CpCgIA" +
           "AAAAAA4AAABJbnB1dEFyZ3VtZW50cwEBxBgALgBExBgAAJYBAAAAAQAqAQETAAAABAAAAE1vZGUAA///" +
           "//8AAAAAAAEAKAEBAAAAAQAAAAAAAAABAf////8AAAAAF2CpCgIAAAAAAA8AAABPdXRwdXRBcmd1bWVu" +
           "dHMBAcUYAC4ARMUYAACWAQAAAAEAKgEBGQAAAAoAAABGaWxlSGFuZGxlAAf/////AAAAAAABACgBAQAA" +
           "AAEAAAAAAAAAAQH/////AAAAAARhggoEAAAAAAAFAAAAQ2xvc2UBAVkbAC8BAD8tWRsAAAEB/////wEA" +
           "AAAXYKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQHBGAAuAETBGAAAlgEAAAABACoBARkAAAAKAAAA" +
           "RmlsZUhhbmRsZQAH/////wAAAAAAAQAoAQEAAAABAAAAAAAAAAEB/////wAAAAAEYYIKBAAAAAAABAAA" +
           "AFJlYWQBAWAbAC8BAEEtYBsAAAEB/////wIAAAAXYKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQHH" +
           "GAAuAETHGAAAlgIAAAABACoBARkAAAAKAAAARmlsZUhhbmRsZQAH/////wAAAAAAAQAqAQEVAAAABgAA" +
           "AExlbmd0aAAG/////wAAAAAAAQAoAQEAAAABAAAAAAAAAAEB/////wAAAAAXYKkKAgAAAAAADwAAAE91" +
           "dHB1dEFyZ3VtZW50cwEByBgALgBEyBgAAJYBAAAAAQAqAQETAAAABAAAAERhdGEAD/////8AAAAAAAEA" +
           "KAEBAAAAAQAAAAAAAAABAf////8AAAAABGGCCgQAAAAAAAUAAABXcml0ZQEBYhsALwEARC1iGwAAAQH/" +
           "////AQAAABdgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAc0YAC4ARM0YAACWAgAAAAEAKgEBGQAA" +
           "AAoAAABGaWxlSGFuZGxlAAf/////AAAAAAABACoBARMAAAAEAAAARGF0YQAP/////wAAAAAAAQAoAQEA" +
           "AAABAAAAAAAAAAEB/////wAAAAAEYYIKBAAAAAAACwAAAEdldFBvc2l0aW9uAQFaGwAvAQBGLVobAAAB" +
           "Af////8CAAAAF2CpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEBwhgALgBEwhgAAJYBAAAAAQAqAQEZ" +
           "AAAACgAAAEZpbGVIYW5kbGUAB/////8AAAAAAAEAKAEBAAAAAQAAAAAAAAABAf////8AAAAAF2CpCgIA" +
           "AAAAAA8AAABPdXRwdXRBcmd1bWVudHMBAcMYAC4ARMMYAACWAQAAAAEAKgEBFwAAAAgAAABQb3NpdGlv" +
           "bgAJ/////wAAAAAAAQAoAQEAAAABAAAAAAAAAAEB/////wAAAAAEYYIKBAAAAAAACwAAAFNldFBvc2l0" +
           "aW9uAQFhGwAvAQBJLWEbAAABAf////8BAAAAF2CpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEByRgA" +
           "LgBEyRgAAJYCAAAAAQAqAQEZAAAACgAAAEZpbGVIYW5kbGUAB/////8AAAAAAAEAKgEBFwAAAAgAAABQ" +
           "b3NpdGlvbgAJ/////wAAAAAAAQAoAQEAAAABAAAAAAAAAAEB/////wAAAAA=";

        private const string DescriptorIdentifier_InitializationString =
           "AwAAACIAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvRlgvQUMvHwAAAGh0dHA6Ly9vcGNmb3Vu" +
           "ZGF0aW9uLm9yZy9VQS9ESS8kAAAAaHR0cDovL29wY2ZvdW5kYXRpb24ub3JnL1VBL0ZYL0RhdGEv////" +
           "/xVgiQoCAAAAAQAUAAAARGVzY3JpcHRvcklkZW50aWZpZXIBAb8YAC4ARL8YAAABAMdc/////wMD////" +
           "/wAAAAA=";

        private const string DescriptorVersion_InitializationString =
           "AwAAACIAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvRlgvQUMvHwAAAGh0dHA6Ly9vcGNmb3Vu" +
           "ZGF0aW9uLm9yZy9VQS9ESS8kAAAAaHR0cDovL29wY2ZvdW5kYXRpb24ub3JnL1VBL0ZYL0RhdGEv////" +
           "/xVgqQoCAAAAAQARAAAARGVzY3JpcHRvclZlcnNpb24BAcAYAC4ARMAYAAAWAQFcAAKRAAAAPEZ4VmVy" +
           "c2lvbiB4bWxucz0iaHR0cDovL29wY2ZvdW5kYXRpb24ub3JnL1VBL0ZYL0FDL1R5cGVzLnhzZCI+PE1h" +
           "am9yPjA8L01ham9yPjxNaW5vcj4wPC9NaW5vcj48QnVpbGQ+MDwvQnVpbGQ+PFN1YkJ1aWxkPjA8L1N1" +
           "YkJ1aWxkPjwvRnhWZXJzaW9uPgEBGQD/////AwP/////AAAAAA==";

        private const string InitializationString =
           "AwAAACIAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvRlgvQUMvHwAAAGh0dHA6Ly9vcGNmb3Vu" +
           "ZGF0aW9uLm9yZy9VQS9ESS8kAAAAaHR0cDovL29wY2ZvdW5kYXRpb24ub3JnL1VBL0ZYL0RhdGEv////" +
           "/wRggAIBAAAAAQAYAAAAQWNEZXNjcmlwdG9yVHlwZUluc3RhbmNlAQEDBAEBAwQDBAAA/////wMAAAAE" +
           "YIAKAQAAAAEADgAAAERlc2NyaXB0b3JGaWxlAQHQEwAvAQA3LdATAAD/////CgAAABVgiQoCAAAAAAAE" +
           "AAAAU2l6ZQEByhgALgBEyhgAAAAJ/////wEB/////wAAAAAVYIkKAgAAAAAACAAAAFdyaXRhYmxlAQHM" +
           "GAAuAETMGAAAAAH/////AQH/////AAAAABVgiQoCAAAAAAAMAAAAVXNlcldyaXRhYmxlAQHLGAAuAETL" +
           "GAAAAAH/////AQH/////AAAAABVgiQoCAAAAAAAJAAAAT3BlbkNvdW50AQHGGAAuAETGGAAAAAX/////" +
           "AQH/////AAAAAARhggoEAAAAAAAEAAAAT3BlbgEBXxsALwEAPC1fGwAAAQH/////AgAAABdgqQoCAAAA" +
           "AAAOAAAASW5wdXRBcmd1bWVudHMBAcQYAC4ARMQYAACWAQAAAAEAKgEBEwAAAAQAAABNb2RlAAP/////" +
           "AAAAAAABACgBAQAAAAEAAAAAAAAAAQH/////AAAAABdgqQoCAAAAAAAPAAAAT3V0cHV0QXJndW1lbnRz" +
           "AQHFGAAuAETFGAAAlgEAAAABACoBARkAAAAKAAAARmlsZUhhbmRsZQAH/////wAAAAAAAQAoAQEAAAAB" +
           "AAAAAAAAAAEB/////wAAAAAEYYIKBAAAAAAABQAAAENsb3NlAQFZGwAvAQA/LVkbAAABAf////8BAAAA" +
           "F2CpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEBwRgALgBEwRgAAJYBAAAAAQAqAQEZAAAACgAAAEZp" +
           "bGVIYW5kbGUAB/////8AAAAAAAEAKAEBAAAAAQAAAAAAAAABAf////8AAAAABGGCCgQAAAAAAAQAAABS" +
           "ZWFkAQFgGwAvAQBBLWAbAAABAf////8CAAAAF2CpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEBxxgA" +
           "LgBExxgAAJYCAAAAAQAqAQEZAAAACgAAAEZpbGVIYW5kbGUAB/////8AAAAAAAEAKgEBFQAAAAYAAABM" +
           "ZW5ndGgABv////8AAAAAAAEAKAEBAAAAAQAAAAAAAAABAf////8AAAAAF2CpCgIAAAAAAA8AAABPdXRw" +
           "dXRBcmd1bWVudHMBAcgYAC4ARMgYAACWAQAAAAEAKgEBEwAAAAQAAABEYXRhAA//////AAAAAAABACgB" +
           "AQAAAAEAAAAAAAAAAQH/////AAAAAARhggoEAAAAAAAFAAAAV3JpdGUBAWIbAC8BAEQtYhsAAAEB////" +
           "/wEAAAAXYKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQHNGAAuAETNGAAAlgIAAAABACoBARkAAAAK" +
           "AAAARmlsZUhhbmRsZQAH/////wAAAAAAAQAqAQETAAAABAAAAERhdGEAD/////8AAAAAAAEAKAEBAAAA" +
           "AQAAAAAAAAABAf////8AAAAABGGCCgQAAAAAAAsAAABHZXRQb3NpdGlvbgEBWhsALwEARi1aGwAAAQH/" +
           "////AgAAABdgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAcIYAC4ARMIYAACWAQAAAAEAKgEBGQAA" +
           "AAoAAABGaWxlSGFuZGxlAAf/////AAAAAAABACgBAQAAAAEAAAAAAAAAAQH/////AAAAABdgqQoCAAAA" +
           "AAAPAAAAT3V0cHV0QXJndW1lbnRzAQHDGAAuAETDGAAAlgEAAAABACoBARcAAAAIAAAAUG9zaXRpb24A" +
           "Cf////8AAAAAAAEAKAEBAAAAAQAAAAAAAAABAf////8AAAAABGGCCgQAAAAAAAsAAABTZXRQb3NpdGlv" +
           "bgEBYRsALwEASS1hGwAAAQH/////AQAAABdgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAckYAC4A" +
           "RMkYAACWAgAAAAEAKgEBGQAAAAoAAABGaWxlSGFuZGxlAAf/////AAAAAAABACoBARcAAAAIAAAAUG9z" +
           "aXRpb24ACf////8AAAAAAAEAKAEBAAAAAQAAAAAAAAABAf////8AAAAAFWCJCgIAAAABABQAAABEZXNj" +
           "cmlwdG9ySWRlbnRpZmllcgEBvxgALgBEvxgAAAEAx1z/////AwP/////AAAAABVgqQoCAAAAAQARAAAA" +
           "RGVzY3JpcHRvclZlcnNpb24BAcAYAC4ARMAYAAAWAQFcAAKRAAAAPEZ4VmVyc2lvbiB4bWxucz0iaHR0" +
           "cDovL29wY2ZvdW5kYXRpb24ub3JnL1VBL0ZYL0FDL1R5cGVzLnhzZCI+PE1ham9yPjA8L01ham9yPjxN" +
           "aW5vcj4wPC9NaW5vcj48QnVpbGQ+MDwvQnVpbGQ+PFN1YkJ1aWxkPjA8L1N1YkJ1aWxkPjwvRnhWZXJz" +
           "aW9uPgEBGQD/////AwP/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public FileState DescriptorFile
        {
            get
            {
                return m_descriptorFile;
            }

            set
            {
                if (!Object.ReferenceEquals(m_descriptorFile, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_descriptorFile = value;
            }
        }

        /// <remarks />
        public PropertyState<string> DescriptorIdentifier
        {
            get
            {
                return m_descriptorIdentifier;
            }

            set
            {
                if (!Object.ReferenceEquals(m_descriptorIdentifier, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_descriptorIdentifier = value;
            }
        }

        /// <remarks />
        public PropertyState<FxVersion> DescriptorVersion
        {
            get
            {
                return m_descriptorVersion;
            }

            set
            {
                if (!Object.ReferenceEquals(m_descriptorVersion, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_descriptorVersion = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_descriptorFile != null)
            {
                children.Add(m_descriptorFile);
            }

            if (m_descriptorIdentifier != null)
            {
                children.Add(m_descriptorIdentifier);
            }

            if (m_descriptorVersion != null)
            {
                children.Add(m_descriptorVersion);
            }

            base.GetChildren(context, children);
        }
            
        /// <remarks />
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case UAModel.FXAC.BrowseNames.DescriptorFile:
                {
                    if (createOrReplace)
                    {
                        if (DescriptorFile == null)
                        {
                            if (replacement == null)
                            {
                                DescriptorFile = new FileState(this);
                            }
                            else
                            {
                                DescriptorFile = (FileState)replacement;
                            }
                        }
                    }

                    instance = DescriptorFile;
                    break;
                }

                case UAModel.FXAC.BrowseNames.DescriptorIdentifier:
                {
                    if (createOrReplace)
                    {
                        if (DescriptorIdentifier == null)
                        {
                            if (replacement == null)
                            {
                                DescriptorIdentifier = new PropertyState<string>(this);
                            }
                            else
                            {
                                DescriptorIdentifier = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = DescriptorIdentifier;
                    break;
                }

                case UAModel.FXAC.BrowseNames.DescriptorVersion:
                {
                    if (createOrReplace)
                    {
                        if (DescriptorVersion == null)
                        {
                            if (replacement == null)
                            {
                                DescriptorVersion = new PropertyState<FxVersion>(this);
                            }
                            else
                            {
                                DescriptorVersion = (PropertyState<FxVersion>)replacement;
                            }
                        }
                    }

                    instance = DescriptorVersion;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private FileState m_descriptorFile;
        private PropertyState<string> m_descriptorIdentifier;
        private PropertyState<FxVersion> m_descriptorVersion;
        #endregion
    }
    #endif
    #endregion

    #region AssetConnectorTypeState Class
    #if (!OPCUA_EXCLUDE_AssetConnectorTypeState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class AssetConnectorTypeState : BaseObjectState
    {
        #region Constructors
        /// <remarks />
        public AssetConnectorTypeState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(UAModel.FXAC.ObjectTypes.AssetConnectorType, UAModel.FXAC.Namespaces.FXAC, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);

            if (Id != null)
            {
                Id.Initialize(context, Id_InitializationString);
            }

            if (Name != null)
            {
                Name.Initialize(context, Name_InitializationString);
            }
        }

        #region Initialization String
        private const string Id_InitializationString =
           "AwAAACIAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvRlgvQUMvHwAAAGh0dHA6Ly9vcGNmb3Vu" +
           "ZGF0aW9uLm9yZy9VQS9ESS8kAAAAaHR0cDovL29wY2ZvdW5kYXRpb24ub3JnL1VBL0ZYL0RhdGEv////" +
           "/xVgiQoCAAAAAQACAAAASWQBAXIAAC4ARHIAAAAABf////8DA/////8AAAAA";

        private const string Name_InitializationString =
           "AwAAACIAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvRlgvQUMvHwAAAGh0dHA6Ly9vcGNmb3Vu" +
           "ZGF0aW9uLm9yZy9VQS9ESS8kAAAAaHR0cDovL29wY2ZvdW5kYXRpb24ub3JnL1VBL0ZYL0RhdGEv////" +
           "/xVgiQoCAAAAAQAEAAAATmFtZQEBdAAALgBEdAAAAAAM/////wMD/////wAAAAA=";

        private const string InitializationString =
           "AwAAACIAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvRlgvQUMvHwAAAGh0dHA6Ly9vcGNmb3Vu" +
           "ZGF0aW9uLm9yZy9VQS9ESS8kAAAAaHR0cDovL29wY2ZvdW5kYXRpb24ub3JnL1VBL0ZYL0RhdGEv////" +
           "/wRggAIBAAAAAQAaAAAAQXNzZXRDb25uZWN0b3JUeXBlSW5zdGFuY2UBAQUAAQEFAAUAAAD/////AgAA" +
           "ABVgiQoCAAAAAQACAAAASWQBAXIAAC4ARHIAAAAABf////8DA/////8AAAAAFWCJCgIAAAABAAQAAABO" +
           "YW1lAQF0AAAuAER0AAAAAAz/////AwP/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public PropertyState<ushort> Id
        {
            get
            {
                return m_id;
            }

            set
            {
                if (!Object.ReferenceEquals(m_id, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_id = value;
            }
        }

        /// <remarks />
        public PropertyState<string> Name
        {
            get
            {
                return m_name;
            }

            set
            {
                if (!Object.ReferenceEquals(m_name, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_name = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_id != null)
            {
                children.Add(m_id);
            }

            if (m_name != null)
            {
                children.Add(m_name);
            }

            base.GetChildren(context, children);
        }
            
        /// <remarks />
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case UAModel.FXAC.BrowseNames.Id:
                {
                    if (createOrReplace)
                    {
                        if (Id == null)
                        {
                            if (replacement == null)
                            {
                                Id = new PropertyState<ushort>(this);
                            }
                            else
                            {
                                Id = (PropertyState<ushort>)replacement;
                            }
                        }
                    }

                    instance = Id;
                    break;
                }

                case UAModel.FXAC.BrowseNames.Name:
                {
                    if (createOrReplace)
                    {
                        if (Name == null)
                        {
                            if (replacement == null)
                            {
                                Name = new PropertyState<string>(this);
                            }
                            else
                            {
                                Name = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = Name;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private PropertyState<ushort> m_id;
        private PropertyState<string> m_name;
        #endregion
    }
    #endif
    #endregion

    #region ClampBlockTypeState Class
    #if (!OPCUA_EXCLUDE_ClampBlockTypeState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ClampBlockTypeState : AssetConnectorTypeState
    {
        #region Constructors
        /// <remarks />
        public ClampBlockTypeState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(UAModel.FXAC.ObjectTypes.ClampBlockType, UAModel.FXAC.Namespaces.FXAC, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);

            if (BlockSize != null)
            {
                BlockSize.Initialize(context, BlockSize_InitializationString);
            }

            if (Kind != null)
            {
                Kind.Initialize(context, Kind_InitializationString);
            }
        }

        #region Initialization String
        private const string BlockSize_InitializationString =
           "AwAAACIAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvRlgvQUMvHwAAAGh0dHA6Ly9vcGNmb3Vu" +
           "ZGF0aW9uLm9yZy9VQS9ESS8kAAAAaHR0cDovL29wY2ZvdW5kYXRpb24ub3JnL1VBL0ZYL0RhdGEv////" +
           "/xVgiQoCAAAAAQAJAAAAQmxvY2tTaXplAQHaAAAuAETaAAAAAAX/////AwP/////AAAAAA==";

        private const string Kind_InitializationString =
           "AwAAACIAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvRlgvQUMvHwAAAGh0dHA6Ly9vcGNmb3Vu" +
           "ZGF0aW9uLm9yZy9VQS9ESS8kAAAAaHR0cDovL29wY2ZvdW5kYXRpb24ub3JnL1VBL0ZYL0RhdGEv////" +
           "/xVgiQoCAAAAAQAEAAAAS2luZAEB4gQALwEA5iviBAAAAAX/////AwP/////AgAAABdgqQoCAAAAAAAK" +
           "AAAARW51bVZhbHVlcwEB4wQALgBE4wQAAJYCAAAAAQA7IAEcAAAAAAAAAAAAAAACBQAAAFNjcmV3AgUA" +
           "AABTY3JldwEAOyABHAAAAAAAAAAAAAAAAgUAAABUaHVtYgIFAAAAVGh1bWIBAKodAQAAAAEAAAAAAAAA" +
           "AQH/////AAAAABVgiQoCAAAAAAALAAAAVmFsdWVBc1RleHQBAeQEAC4AROQEAAAAFf////8BAf////8A" +
           "AAAA";

        private const string InitializationString =
           "AwAAACIAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvRlgvQUMvHwAAAGh0dHA6Ly9vcGNmb3Vu" +
           "ZGF0aW9uLm9yZy9VQS9ESS8kAAAAaHR0cDovL29wY2ZvdW5kYXRpb24ub3JnL1VBL0ZYL0RhdGEv////" +
           "/wRggAIBAAAAAQAWAAAAQ2xhbXBCbG9ja1R5cGVJbnN0YW5jZQEBBwABAQcABwAAAP////8EAAAAFWCJ" +
           "CgIAAAABAAQAAABOYW1lAQHZAAAuAETZAAAAAAz/////AwP/////AAAAAARgwAoBAAAABQAAAENsYW1w" +
           "AQAHAAAAPENsYW1wPgEBXgAALwEBCgBeAAAA/////wEAAAAVYIkKAgAAAAEABAAAAE5hbWUBAdwAAC4A" +
           "RNwAAAAADP////8DA/////8AAAAAFWCJCgIAAAABAAkAAABCbG9ja1NpemUBAdoAAC4ARNoAAAAABf//" +
           "//8DA/////8AAAAAFWCJCgIAAAABAAQAAABLaW5kAQHiBAAvAQDmK+IEAAAABf////8DA/////8CAAAA" +
           "F2CpCgIAAAAAAAoAAABFbnVtVmFsdWVzAQHjBAAuAETjBAAAlgIAAAABADsgARwAAAAAAAAAAAAAAAIF" +
           "AAAAU2NyZXcCBQAAAFNjcmV3AQA7IAEcAAAAAAAAAAAAAAACBQAAAFRodW1iAgUAAABUaHVtYgEAqh0B" +
           "AAAAAQAAAAAAAAABAf////8AAAAAFWCJCgIAAAAAAAsAAABWYWx1ZUFzVGV4dAEB5AQALgBE5AQAAAAV" +
           "/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public PropertyState<ushort> BlockSize
        {
            get
            {
                return m_blockSize;
            }

            set
            {
                if (!Object.ReferenceEquals(m_blockSize, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_blockSize = value;
            }
        }

        /// <remarks />
        public MultiStateValueDiscreteState<ushort> Kind
        {
            get
            {
                return m_kind;
            }

            set
            {
                if (!Object.ReferenceEquals(m_kind, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_kind = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_blockSize != null)
            {
                children.Add(m_blockSize);
            }

            if (m_kind != null)
            {
                children.Add(m_kind);
            }

            base.GetChildren(context, children);
        }
            
        /// <remarks />
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case UAModel.FXAC.BrowseNames.BlockSize:
                {
                    if (createOrReplace)
                    {
                        if (BlockSize == null)
                        {
                            if (replacement == null)
                            {
                                BlockSize = new PropertyState<ushort>(this);
                            }
                            else
                            {
                                BlockSize = (PropertyState<ushort>)replacement;
                            }
                        }
                    }

                    instance = BlockSize;
                    break;
                }

                case UAModel.FXAC.BrowseNames.Kind:
                {
                    if (createOrReplace)
                    {
                        if (Kind == null)
                        {
                            if (replacement == null)
                            {
                                Kind = new MultiStateValueDiscreteState<ushort>(this);
                            }
                            else
                            {
                                Kind = (MultiStateValueDiscreteState<ushort>)replacement;
                            }
                        }
                    }

                    instance = Kind;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private PropertyState<ushort> m_blockSize;
        private MultiStateValueDiscreteState<ushort> m_kind;
        #endregion
    }
    #endif
    #endregion

    #region ClampTypeState Class
    #if (!OPCUA_EXCLUDE_ClampTypeState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ClampTypeState : AssetConnectorTypeState
    {
        #region Constructors
        /// <remarks />
        public ClampTypeState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(UAModel.FXAC.ObjectTypes.ClampType, UAModel.FXAC.Namespaces.FXAC, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);

            if (Kind != null)
            {
                Kind.Initialize(context, Kind_InitializationString);
            }
        }

        #region Initialization String
        private const string Kind_InitializationString =
           "AwAAACIAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvRlgvQUMvHwAAAGh0dHA6Ly9vcGNmb3Vu" +
           "ZGF0aW9uLm9yZy9VQS9ESS8kAAAAaHR0cDovL29wY2ZvdW5kYXRpb24ub3JnL1VBL0ZYL0RhdGEv////" +
           "/xVgiQoCAAAAAQAEAAAAS2luZAEB1wAALwEA5ivXAAAAAAX/////AwP/////AgAAABdgqQoCAAAAAAAK" +
           "AAAARW51bVZhbHVlcwEB5gQALgBE5gQAAJYCAAAAAQA7IAEcAAAAAAAAAAAAAAACBQAAAFNjcmV3AgUA" +
           "AABTY3JldwEAOyABHAAAAAAAAAAAAAAAAgUAAABUaHVtYgIFAAAAVGh1bWIBAKodAQAAAAEAAAAAAAAA" +
           "AQH/////AAAAABVgiQoCAAAAAAALAAAAVmFsdWVBc1RleHQBAecEAC4AROcEAAAAFf////8BAf////8A" +
           "AAAA";

        private const string InitializationString =
           "AwAAACIAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvRlgvQUMvHwAAAGh0dHA6Ly9vcGNmb3Vu" +
           "ZGF0aW9uLm9yZy9VQS9ESS8kAAAAaHR0cDovL29wY2ZvdW5kYXRpb24ub3JnL1VBL0ZYL0RhdGEv////" +
           "/wRggAIBAAAAAQARAAAAQ2xhbXBUeXBlSW5zdGFuY2UBAQoAAQEKAAoAAAD/////AgAAABVgiQoCAAAA" +
           "AQAEAAAATmFtZQEB1gAALgBE1gAAAAAM/////wMD/////wAAAAAVYIkKAgAAAAEABAAAAEtpbmQBAdcA" +
           "AC8BAOYr1wAAAAAF/////wMD/////wIAAAAXYKkKAgAAAAAACgAAAEVudW1WYWx1ZXMBAeYEAC4AROYE" +
           "AACWAgAAAAEAOyABHAAAAAAAAAAAAAAAAgUAAABTY3JldwIFAAAAU2NyZXcBADsgARwAAAAAAAAAAAAA" +
           "AAIFAAAAVGh1bWICBQAAAFRodW1iAQCqHQEAAAABAAAAAAAAAAEB/////wAAAAAVYIkKAgAAAAAACwAA" +
           "AFZhbHVlQXNUZXh0AQHnBAAuAETnBAAAABX/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public MultiStateValueDiscreteState<ushort> Kind
        {
            get
            {
                return m_kind;
            }

            set
            {
                if (!Object.ReferenceEquals(m_kind, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_kind = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_kind != null)
            {
                children.Add(m_kind);
            }

            base.GetChildren(context, children);
        }
            
        /// <remarks />
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case UAModel.FXAC.BrowseNames.Kind:
                {
                    if (createOrReplace)
                    {
                        if (Kind == null)
                        {
                            if (replacement == null)
                            {
                                Kind = new MultiStateValueDiscreteState<ushort>(this);
                            }
                            else
                            {
                                Kind = (MultiStateValueDiscreteState<ushort>)replacement;
                            }
                        }
                    }

                    instance = Kind;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private MultiStateValueDiscreteState<ushort> m_kind;
        #endregion
    }
    #endif
    #endregion

    #region SlotTypeState Class
    #if (!OPCUA_EXCLUDE_SlotTypeState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class SlotTypeState : AssetConnectorTypeState
    {
        #region Constructors
        /// <remarks />
        public SlotTypeState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(UAModel.FXAC.ObjectTypes.SlotType, UAModel.FXAC.Namespaces.FXAC, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);

            if (LogicalId != null)
            {
                LogicalId.Initialize(context, LogicalId_InitializationString);
            }
        }

        #region Initialization String
        private const string LogicalId_InitializationString =
           "AwAAACIAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvRlgvQUMvHwAAAGh0dHA6Ly9vcGNmb3Vu" +
           "ZGF0aW9uLm9yZy9VQS9ESS8kAAAAaHR0cDovL29wY2ZvdW5kYXRpb24ub3JnL1VBL0ZYL0RhdGEv////" +
           "/xVgiQoCAAAAAQAJAAAATG9naWNhbElkAQGfAAAuAESfAAAAAAX/////AwP/////AAAAAA==";

        private const string InitializationString =
           "AwAAACIAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvRlgvQUMvHwAAAGh0dHA6Ly9vcGNmb3Vu" +
           "ZGF0aW9uLm9yZy9VQS9ESS8kAAAAaHR0cDovL29wY2ZvdW5kYXRpb24ub3JnL1VBL0ZYL0RhdGEv////" +
           "/wRggAIBAAAAAQAQAAAAU2xvdFR5cGVJbnN0YW5jZQEBBgABAQYABgAAAP////8CAAAAFWCJCgIAAAAB" +
           "AAIAAABJZAEBcwAALgBEcwAAAAAF/////wMD/////wAAAAAVYIkKAgAAAAEACQAAAExvZ2ljYWxJZAEB" +
           "nwAALgBEnwAAAAAF/////wMD/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public PropertyState<ushort> LogicalId
        {
            get
            {
                return m_logicalId;
            }

            set
            {
                if (!Object.ReferenceEquals(m_logicalId, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_logicalId = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_logicalId != null)
            {
                children.Add(m_logicalId);
            }

            base.GetChildren(context, children);
        }
            
        /// <remarks />
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case UAModel.FXAC.BrowseNames.LogicalId:
                {
                    if (createOrReplace)
                    {
                        if (LogicalId == null)
                        {
                            if (replacement == null)
                            {
                                LogicalId = new PropertyState<ushort>(this);
                            }
                            else
                            {
                                LogicalId = (PropertyState<ushort>)replacement;
                            }
                        }
                    }

                    instance = LogicalId;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private PropertyState<ushort> m_logicalId;
        #endregion
    }
    #endif
    #endregion

    #region SocketTypeState Class
    #if (!OPCUA_EXCLUDE_SocketTypeState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class SocketTypeState : AssetConnectorTypeState
    {
        #region Constructors
        /// <remarks />
        public SocketTypeState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(UAModel.FXAC.ObjectTypes.SocketType, UAModel.FXAC.Namespaces.FXAC, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);

            if (Kind != null)
            {
                Kind.Initialize(context, Kind_InitializationString);
            }
        }

        #region Initialization String
        private const string Kind_InitializationString =
           "AwAAACIAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvRlgvQUMvHwAAAGh0dHA6Ly9vcGNmb3Vu" +
           "ZGF0aW9uLm9yZy9VQS9ESS8kAAAAaHR0cDovL29wY2ZvdW5kYXRpb24ub3JnL1VBL0ZYL0RhdGEv////" +
           "/xVgiQoCAAAAAQAEAAAAS2luZAEBeBcALwEA5it4FwAAAAX/////AwP/////AgAAABdgiQoCAAAAAAAK" +
           "AAAARW51bVZhbHVlcwEBeRcALgBEeRcAAAEAqh0BAAAAAQAAAAAAAAABAf////8AAAAAFWCJCgIAAAAA" +
           "AAsAAABWYWx1ZUFzVGV4dAEBehcALgBEehcAAAAV/////wEB/////wAAAAA=";

        private const string InitializationString =
           "AwAAACIAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvRlgvQUMvHwAAAGh0dHA6Ly9vcGNmb3Vu" +
           "ZGF0aW9uLm9yZy9VQS9ESS8kAAAAaHR0cDovL29wY2ZvdW5kYXRpb24ub3JnL1VBL0ZYL0RhdGEv////" +
           "/wRggAIBAAAAAQASAAAAU29ja2V0VHlwZUluc3RhbmNlAQEIAAEBCAAIAAAA/////wIAAAAVYIkKAgAA" +
           "AAEABAAAAE5hbWUBAdMAAC4ARNMAAAAADP////8DA/////8AAAAAFWCJCgIAAAABAAQAAABLaW5kAQF4" +
           "FwAvAQDmK3gXAAAABf////8DA/////8CAAAAF2CJCgIAAAAAAAoAAABFbnVtVmFsdWVzAQF5FwAuAER5" +
           "FwAAAQCqHQEAAAABAAAAAAAAAAEB/////wAAAAAVYIkKAgAAAAAACwAAAFZhbHVlQXNUZXh0AQF6FwAu" +
           "AER6FwAAABX/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public MultiStateValueDiscreteState<ushort> Kind
        {
            get
            {
                return m_kind;
            }

            set
            {
                if (!Object.ReferenceEquals(m_kind, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_kind = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_kind != null)
            {
                children.Add(m_kind);
            }

            base.GetChildren(context, children);
        }
            
        /// <remarks />
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case UAModel.FXAC.BrowseNames.Kind:
                {
                    if (createOrReplace)
                    {
                        if (Kind == null)
                        {
                            if (replacement == null)
                            {
                                Kind = new MultiStateValueDiscreteState<ushort>(this);
                            }
                            else
                            {
                                Kind = (MultiStateValueDiscreteState<ushort>)replacement;
                            }
                        }
                    }

                    instance = Kind;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private MultiStateValueDiscreteState<ushort> m_kind;
        #endregion
    }
    #endif
    #endregion

    #region AutomationComponentTypeState Class
    #if (!OPCUA_EXCLUDE_AutomationComponentTypeState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class AutomationComponentTypeState : BaseObjectState
    {
        #region Constructors
        /// <remarks />
        public AutomationComponentTypeState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(UAModel.FXAC.ObjectTypes.AutomationComponentType, UAModel.FXAC.Namespaces.FXAC, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);

            if (ConformanceName != null)
            {
                ConformanceName.Initialize(context, ConformanceName_InitializationString);
            }

            if (PublisherCapabilities != null)
            {
                PublisherCapabilities.Initialize(context, PublisherCapabilities_InitializationString);
            }

            if (SubscriberCapabilities != null)
            {
                SubscriberCapabilities.Initialize(context, SubscriberCapabilities_InitializationString);
            }
        }

        #region Initialization String
        private const string ConformanceName_InitializationString =
           "AwAAACIAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvRlgvQUMvHwAAAGh0dHA6Ly9vcGNmb3Vu" +
           "ZGF0aW9uLm9yZy9VQS9ESS8kAAAAaHR0cDovL29wY2ZvdW5kYXRpb24ub3JnL1VBL0ZYL0RhdGEv////" +
           "/xVgiQoCAAAAAQAPAAAAQ29uZm9ybWFuY2VOYW1lAQHSAAAuAETSAAAAAQDHXP////8BAf////8AAAAA";

        private const string PublisherCapabilities_InitializationString =
           "AwAAACIAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvRlgvQUMvHwAAAGh0dHA6Ly9vcGNmb3Vu" +
           "ZGF0aW9uLm9yZy9VQS9ESS8kAAAAaHR0cDovL29wY2ZvdW5kYXRpb24ub3JnL1VBL0ZYL0RhdGEv////" +
           "/wRggAoBAAAAAQAVAAAAUHVibGlzaGVyQ2FwYWJpbGl0aWVzAQGREwAvAQHrA5ETAAD/////BAAAABdg" +
           "iQoCAAAAAQAYAAAAUHJlY29uZmlndXJlZERhdGFTZXRPbmx5AQGQFwAvAD+QFwAAAAEBAAAAAQAAAAAA" +
           "AAADA/////8AAAAAF2CJCgIAAAABAB4AAABQcmVjb25maWd1cmVkUHVibGlzaGVkRGF0YVNldHMBAZkX" +
           "AC8AP5kXAAAADAEAAAABAAAAAAAAAAMD/////wAAAAAXYIkKAgAAAAEAHAAAAFN1cHBvcnRlZFB1Ymxp" +
           "c2hpbmdJbnRlcnZhbHMBAZoXAC8AP5oXAAABAcALAQAAAAEAAAAAAAAAAwP/////AAAAABdgiQoCAAAA" +
           "AQAMAAAAU3VwcG9ydGVkUW9zAQGbFwAvAD+bFwAAAQHDCwEAAAABAAAAAAAAAAMD/////wAAAAA=";

        private const string SubscriberCapabilities_InitializationString =
           "AwAAACIAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvRlgvQUMvHwAAAGh0dHA6Ly9vcGNmb3Vu" +
           "ZGF0aW9uLm9yZy9VQS9ESS8kAAAAaHR0cDovL29wY2ZvdW5kYXRpb24ub3JnL1VBL0ZYL0RhdGEv////" +
           "/wRggAoBAAAAAQAWAAAAU3Vic2NyaWJlckNhcGFiaWxpdGllcwEBkhMALwEB7AOSEwAA/////wUAAAAV" +
           "YIkKAgAAAAEAGAAAAFByZWNvbmZpZ3VyZWREYXRhU2V0T25seQEBlBcALwA/lBcAAAAB/////wMD////" +
           "/wAAAAAXYIkKAgAAAAEAHwAAAFByZWNvbmZpZ3VyZWRTdWJzY3JpYmVkRGF0YVNldHMBAZwXAC8AP5wX" +
           "AAAADAEAAAABAAAAAAAAAAMD/////wAAAAAXYIkKAgAAAAEAHwAAAFN1cHBvcnRlZE1lc3NhZ2VSZWNl" +
           "aXZlVGltZW91dHMBAZ0XAC8AP50XAAABAcALAQAAAAEAAAAAAAAAAwP/////AAAAABdgiQoCAAAAAQAc" +
           "AAAAU3VwcG9ydGVkUHVibGlzaGluZ0ludGVydmFscwEBnhcALwA/nhcAAAEBwAsBAAAAAQAAAAAAAAAD" +
           "A/////8AAAAAF2CJCgIAAAABAAwAAABTdXBwb3J0ZWRRb3MBAZ8XAC8AP58XAAABAcQLAQAAAAEAAAAA" +
           "AAAAAwP/////AAAAAA==";

        private const string InitializationString =
           "AwAAACIAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvRlgvQUMvHwAAAGh0dHA6Ly9vcGNmb3Vu" +
           "ZGF0aW9uLm9yZy9VQS9ESS8kAAAAaHR0cDovL29wY2ZvdW5kYXRpb24ub3JnL1VBL0ZYL0RhdGEv////" +
           "/wRggAIBAAAAAQAfAAAAQXV0b21hdGlvbkNvbXBvbmVudFR5cGVJbnN0YW5jZQEBAgABAQIAAgAAAAEA" +
           "AAAAKQABALYsCgAAABVgqQoCAAAAAQAQAAAAQWdncmVnYXRlZEhlYWx0aAEBoBcALwEB0QegFwAAFgEB" +
           "jRMC1wAAADxBZ2dyZWdhdGVkSGVhbHRoRGF0YVR5cGUgeG1sbnM9Imh0dHA6Ly9vcGNmb3VuZGF0aW9u" +
           "Lm9yZy9VQS9GWC9BQy9UeXBlcy54c2QiPjxBZ2dyZWdhdGVkRGV2aWNlSGVhbHRoPjA8L0FnZ3JlZ2F0" +
           "ZWREZXZpY2VIZWFsdGg+PEFnZ3JlZ2F0ZWRPcGVyYXRpb25hbEhlYWx0aD4wPC9BZ2dyZWdhdGVkT3Bl" +
           "cmF0aW9uYWxIZWFsdGg+PC9BZ2dyZWdhdGVkSGVhbHRoRGF0YVR5cGU+AQG7C/////8DA/////8CAAAA" +
           "FWCJCgIAAAABABYAAABBZ2dyZWdhdGVkRGV2aWNlSGVhbHRoAQGjFwAvAD+jFwAAAQG9C/////8BAf//" +
           "//8AAAAAFWCJCgIAAAABABsAAABBZ2dyZWdhdGVkT3BlcmF0aW9uYWxIZWFsdGgBAbYXAC8AP7YXAAAB" +
           "AcIL/////wEB/////wAAAAAEYIAKAQAAAAEABgAAAEFzc2V0cwEBRAAALwA9RAAAAP////8BAAAABGDA" +
           "CgEAAAAFAAAAQXNzZXQBAAcAAAA8QXNzZXQ+AQFJAAAjAQEDAEkAAAAFAAAAAQDDRAABAQkAAQDDRAAB" +
           "Ass6AQDDRAABAsg6AQDDRAABArs6AQCtYgEBAVIAAgAAABVgqQoCAAAAAgAPAAAATWFudWZhY3R1cmVy" +
           "VXJpAQHIAAAuAETIAAAADAAAAAAADP////8DA/////8AAAAAFWCJCgIAAAACAAsAAABQcm9kdWN0Q29k" +
           "ZQEByQAALgBEyQAAAAAM/////wMD/////wAAAAAEYYIKBAAAAAEAEAAAAENsb3NlQ29ubmVjdGlvbnMB" +
           "ASUBAC8BASUBJQEAAAEBAQAAAAApAAEDAQQCAAAAF2CpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEB" +
           "GQUALgBEGQUAAJYCAAAAAQAqAQEmAAAAEwAAAENvbm5lY3Rpb25FbmRwb2ludHMAEQEAAAABAAAAAAAA" +
           "AAABACoBARUAAAAGAAAAUmVtb3ZlAAH/////AAAAAAABACgBAQAAAAEAAAACAAAAAQH/////AAAAABdg" +
           "qQoCAAAAAAAPAAAAT3V0cHV0QXJndW1lbnRzAQEaBQAuAEQaBQAAlgEAAAABACoBARoAAAAHAAAAUmVz" +
           "dWx0cwATAQAAAAEAAAAAAAAAAAEAKAEBAAAAAQAAAAEAAAABAf////8AAAAABGCACgEAAAABABUAAABD" +
           "b21wb25lbnRDYXBhYmlsaXRpZXMBASoEAC8BAekDKgQAAP////8CAAAAFWCJCgIAAAABAA4AAABNYXhD" +
           "b25uZWN0aW9ucwEB2BgBAaIPAD/YGAAAAAf/////AwP/////AAAAABVgiQoCAAAAAQATAAAAU3VwcG9y" +
           "dHNQZXJzaXN0ZW5jZQEB1xgBAaIPAD/XGAAAAAH/////AwP/////AAAAABVgiQoCAAAAAQAPAAAAQ29u" +
           "Zm9ybWFuY2VOYW1lAQHSAAAuAETSAAAAAQDHXP////8BAf////8AAAAABGCACgEAAAABAAsAAABEZXNj" +
           "cmlwdG9ycwEB0RMALwA90RMAAP////8AAAAABGGCCgQAAAABABQAAABFc3RhYmxpc2hDb25uZWN0aW9u" +
           "cwEBJAEALwEBJAEkAQAAAQEBAAAAACkAAQMBBAIAAAAXYKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRz" +
           "AQEXBQAuAEQXBQAAlgUAAAABACoBARwAAAALAAAAQ29tbWFuZE1hc2sBAwAE/////wAAAAAAAQAqAQEn" +
           "AAAAEgAAAEFzc2V0VmVyaWZpY2F0aW9ucwEDGAQBAAAAAQAAAAAAAAAAAQAqAQE1AAAAIAAAAENvbm5l" +
           "Y3Rpb25FbmRwb2ludENvbmZpZ3VyYXRpb25zAQMUBAEAAAABAAAAAAAAAAABACoBASwAAAAXAAAAUmVz" +
           "ZXJ2ZUNvbW11bmljYXRpb25JZHMBA8kLAQAAAAEAAAAAAAAAAAEAKgEBMAAAABsAAABDb21tdW5pY2F0" +
           "aW9uQ29uZmlndXJhdGlvbnMBAxYEAQAAAAEAAAAAAAAAAAEAKAEBAAAAAQAAAAUAAAABAf////8AAAAA" +
           "F2CpCgIAAAAAAA8AAABPdXRwdXRBcmd1bWVudHMBARgFAC4ARBgFAACWBAAAAAEAKgEBLQAAABgAAABB" +
           "c3NldFZlcmlmaWNhdGlvblJlc3VsdHMBAw4EAQAAAAEAAAAAAAAAAAEAKgEBOwAAACYAAABDb25uZWN0" +
           "aW9uRW5kcG9pbnRDb25maWd1cmF0aW9uUmVzdWx0cwEDwAsBAAAAAQAAAAAAAAAAAQAqAQEzAAAAHgAA" +
           "AFJlc2VydmVDb21tdW5pY2F0aW9uSWRzUmVzdWx0cwEDywsBAAAAAQAAAAAAAAAAAQAqAQE2AAAAIQAA" +
           "AENvbW11bmljYXRpb25Db25maWd1cmF0aW9uUmVzdWx0cwEDCQQBAAAAAQAAAAAAAAAAAQAoAQEAAAAB" +
           "AAAABAAAAAEB/////wAAAAAEYIAKAQAAAAEAEgAAAEZ1bmN0aW9uYWxFbnRpdGllcwEBQwAALwA9QwAA" +
           "AP////8BAAAABGDACgEAAAAQAAAARnVuY3Rpb25hbEVudGl0eQEAEgAAADxGdW5jdGlvbmFsRW50aXR5" +
           "PgEBUgAAIwEBBABSAAAAAgAAAAEArWIAAQFJAAEAw0QAAQELAAAAAAAEYIAKAQAAAAEAFQAAAFB1Ymxp" +
           "c2hlckNhcGFiaWxpdGllcwEBkRMALwEB6wOREwAA/////wQAAAAXYIkKAgAAAAEAGAAAAFByZWNvbmZp" +
           "Z3VyZWREYXRhU2V0T25seQEBkBcALwA/kBcAAAABAQAAAAEAAAAAAAAAAwP/////AAAAABdgiQoCAAAA" +
           "AQAeAAAAUHJlY29uZmlndXJlZFB1Ymxpc2hlZERhdGFTZXRzAQGZFwAvAD+ZFwAAAAwBAAAAAQAAAAAA" +
           "AAADA/////8AAAAAF2CJCgIAAAABABwAAABTdXBwb3J0ZWRQdWJsaXNoaW5nSW50ZXJ2YWxzAQGaFwAv" +
           "AD+aFwAAAQHACwEAAAABAAAAAAAAAAMD/////wAAAAAXYIkKAgAAAAEADAAAAFN1cHBvcnRlZFFvcwEB" +
           "mxcALwA/mxcAAAEBwwsBAAAAAQAAAAAAAAADA/////8AAAAABGCACgEAAAABABYAAABTdWJzY3JpYmVy" +
           "Q2FwYWJpbGl0aWVzAQGSEwAvAQHsA5ITAAD/////BQAAABVgiQoCAAAAAQAYAAAAUHJlY29uZmlndXJl" +
           "ZERhdGFTZXRPbmx5AQGUFwAvAD+UFwAAAAH/////AwP/////AAAAABdgiQoCAAAAAQAfAAAAUHJlY29u" +
           "ZmlndXJlZFN1YnNjcmliZWREYXRhU2V0cwEBnBcALwA/nBcAAAAMAQAAAAEAAAAAAAAAAwP/////AAAA" +
           "ABdgiQoCAAAAAQAfAAAAU3VwcG9ydGVkTWVzc2FnZVJlY2VpdmVUaW1lb3V0cwEBnRcALwA/nRcAAAEB" +
           "wAsBAAAAAQAAAAAAAAADA/////8AAAAAF2CJCgIAAAABABwAAABTdXBwb3J0ZWRQdWJsaXNoaW5nSW50" +
           "ZXJ2YWxzAQGeFwAvAD+eFwAAAQHACwEAAAABAAAAAAAAAAMD/////wAAAAAXYIkKAgAAAAEADAAAAFN1" +
           "cHBvcnRlZFFvcwEBnxcALwA/nxcAAAEBxAsBAAAAAQAAAAAAAAADA/////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public AggregatedHealthTypeState AggregatedHealth
        {
            get
            {
                return m_aggregatedHealth;
            }

            set
            {
                if (!Object.ReferenceEquals(m_aggregatedHealth, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_aggregatedHealth = value;
            }
        }

        /// <remarks />
        public FolderState Assets
        {
            get
            {
                return m_assets;
            }

            set
            {
                if (!Object.ReferenceEquals(m_assets, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_assets = value;
            }
        }

        /// <remarks />
        public CloseConnectionsMethodState CloseConnections
        {
            get
            {
                return m_closeConnectionsMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_closeConnectionsMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_closeConnectionsMethod = value;
            }
        }

        /// <remarks />
        public AutomationComponentCapabilitiesTypeState ComponentCapabilities
        {
            get
            {
                return m_componentCapabilities;
            }

            set
            {
                if (!Object.ReferenceEquals(m_componentCapabilities, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_componentCapabilities = value;
            }
        }

        /// <remarks />
        public PropertyState<string> ConformanceName
        {
            get
            {
                return m_conformanceName;
            }

            set
            {
                if (!Object.ReferenceEquals(m_conformanceName, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_conformanceName = value;
            }
        }

        /// <remarks />
        public FolderState Descriptors
        {
            get
            {
                return m_descriptors;
            }

            set
            {
                if (!Object.ReferenceEquals(m_descriptors, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_descriptors = value;
            }
        }

        /// <remarks />
        public EstablishConnectionsMethodState EstablishConnections
        {
            get
            {
                return m_establishConnectionsMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_establishConnectionsMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_establishConnectionsMethod = value;
            }
        }

        /// <remarks />
        public FolderState FunctionalEntities
        {
            get
            {
                return m_functionalEntities;
            }

            set
            {
                if (!Object.ReferenceEquals(m_functionalEntities, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_functionalEntities = value;
            }
        }

        /// <remarks />
        public PublisherCapabilitiesTypeState PublisherCapabilities
        {
            get
            {
                return m_publisherCapabilities;
            }

            set
            {
                if (!Object.ReferenceEquals(m_publisherCapabilities, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_publisherCapabilities = value;
            }
        }

        /// <remarks />
        public SubscriberCapabilitiesTypeState SubscriberCapabilities
        {
            get
            {
                return m_subscriberCapabilities;
            }

            set
            {
                if (!Object.ReferenceEquals(m_subscriberCapabilities, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_subscriberCapabilities = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_aggregatedHealth != null)
            {
                children.Add(m_aggregatedHealth);
            }

            if (m_assets != null)
            {
                children.Add(m_assets);
            }

            if (m_closeConnectionsMethod != null)
            {
                children.Add(m_closeConnectionsMethod);
            }

            if (m_componentCapabilities != null)
            {
                children.Add(m_componentCapabilities);
            }

            if (m_conformanceName != null)
            {
                children.Add(m_conformanceName);
            }

            if (m_descriptors != null)
            {
                children.Add(m_descriptors);
            }

            if (m_establishConnectionsMethod != null)
            {
                children.Add(m_establishConnectionsMethod);
            }

            if (m_functionalEntities != null)
            {
                children.Add(m_functionalEntities);
            }

            if (m_publisherCapabilities != null)
            {
                children.Add(m_publisherCapabilities);
            }

            if (m_subscriberCapabilities != null)
            {
                children.Add(m_subscriberCapabilities);
            }

            base.GetChildren(context, children);
        }
            
        /// <remarks />
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case UAModel.FXAC.BrowseNames.AggregatedHealth:
                {
                    if (createOrReplace)
                    {
                        if (AggregatedHealth == null)
                        {
                            if (replacement == null)
                            {
                                AggregatedHealth = new AggregatedHealthTypeState(this);
                            }
                            else
                            {
                                AggregatedHealth = (AggregatedHealthTypeState)replacement;
                            }
                        }
                    }

                    instance = AggregatedHealth;
                    break;
                }

                case UAModel.FXAC.BrowseNames.Assets:
                {
                    if (createOrReplace)
                    {
                        if (Assets == null)
                        {
                            if (replacement == null)
                            {
                                Assets = new FolderState(this);
                            }
                            else
                            {
                                Assets = (FolderState)replacement;
                            }
                        }
                    }

                    instance = Assets;
                    break;
                }

                case UAModel.FXAC.BrowseNames.CloseConnections:
                {
                    if (createOrReplace)
                    {
                        if (CloseConnections == null)
                        {
                            if (replacement == null)
                            {
                                CloseConnections = new CloseConnectionsMethodState(this);
                            }
                            else
                            {
                                CloseConnections = (CloseConnectionsMethodState)replacement;
                            }
                        }
                    }

                    instance = CloseConnections;
                    break;
                }

                case UAModel.FXAC.BrowseNames.ComponentCapabilities:
                {
                    if (createOrReplace)
                    {
                        if (ComponentCapabilities == null)
                        {
                            if (replacement == null)
                            {
                                ComponentCapabilities = new AutomationComponentCapabilitiesTypeState(this);
                            }
                            else
                            {
                                ComponentCapabilities = (AutomationComponentCapabilitiesTypeState)replacement;
                            }
                        }
                    }

                    instance = ComponentCapabilities;
                    break;
                }

                case UAModel.FXAC.BrowseNames.ConformanceName:
                {
                    if (createOrReplace)
                    {
                        if (ConformanceName == null)
                        {
                            if (replacement == null)
                            {
                                ConformanceName = new PropertyState<string>(this);
                            }
                            else
                            {
                                ConformanceName = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = ConformanceName;
                    break;
                }

                case UAModel.FXAC.BrowseNames.Descriptors:
                {
                    if (createOrReplace)
                    {
                        if (Descriptors == null)
                        {
                            if (replacement == null)
                            {
                                Descriptors = new FolderState(this);
                            }
                            else
                            {
                                Descriptors = (FolderState)replacement;
                            }
                        }
                    }

                    instance = Descriptors;
                    break;
                }

                case UAModel.FXAC.BrowseNames.EstablishConnections:
                {
                    if (createOrReplace)
                    {
                        if (EstablishConnections == null)
                        {
                            if (replacement == null)
                            {
                                EstablishConnections = new EstablishConnectionsMethodState(this);
                            }
                            else
                            {
                                EstablishConnections = (EstablishConnectionsMethodState)replacement;
                            }
                        }
                    }

                    instance = EstablishConnections;
                    break;
                }

                case UAModel.FXAC.BrowseNames.FunctionalEntities:
                {
                    if (createOrReplace)
                    {
                        if (FunctionalEntities == null)
                        {
                            if (replacement == null)
                            {
                                FunctionalEntities = new FolderState(this);
                            }
                            else
                            {
                                FunctionalEntities = (FolderState)replacement;
                            }
                        }
                    }

                    instance = FunctionalEntities;
                    break;
                }

                case UAModel.FXAC.BrowseNames.PublisherCapabilities:
                {
                    if (createOrReplace)
                    {
                        if (PublisherCapabilities == null)
                        {
                            if (replacement == null)
                            {
                                PublisherCapabilities = new PublisherCapabilitiesTypeState(this);
                            }
                            else
                            {
                                PublisherCapabilities = (PublisherCapabilitiesTypeState)replacement;
                            }
                        }
                    }

                    instance = PublisherCapabilities;
                    break;
                }

                case UAModel.FXAC.BrowseNames.SubscriberCapabilities:
                {
                    if (createOrReplace)
                    {
                        if (SubscriberCapabilities == null)
                        {
                            if (replacement == null)
                            {
                                SubscriberCapabilities = new SubscriberCapabilitiesTypeState(this);
                            }
                            else
                            {
                                SubscriberCapabilities = (SubscriberCapabilitiesTypeState)replacement;
                            }
                        }
                    }

                    instance = SubscriberCapabilities;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private AggregatedHealthTypeState m_aggregatedHealth;
        private FolderState m_assets;
        private CloseConnectionsMethodState m_closeConnectionsMethod;
        private AutomationComponentCapabilitiesTypeState m_componentCapabilities;
        private PropertyState<string> m_conformanceName;
        private FolderState m_descriptors;
        private EstablishConnectionsMethodState m_establishConnectionsMethod;
        private FolderState m_functionalEntities;
        private PublisherCapabilitiesTypeState m_publisherCapabilities;
        private SubscriberCapabilitiesTypeState m_subscriberCapabilities;
        #endregion
    }
    #endif
    #endregion

    #region AuditUaFxEventTypeState Class
    #if (!OPCUA_EXCLUDE_AuditUaFxEventTypeState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class AuditUaFxEventTypeState : AuditEventState
    {
        #region Constructors
        /// <remarks />
        public AuditUaFxEventTypeState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(UAModel.FXAC.ObjectTypes.AuditUaFxEventType, UAModel.FXAC.Namespaces.FXAC, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AwAAACIAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvRlgvQUMvHwAAAGh0dHA6Ly9vcGNmb3Vu" +
           "ZGF0aW9uLm9yZy9VQS9ESS8kAAAAaHR0cDovL29wY2ZvdW5kYXRpb24ub3JnL1VBL0ZYL0RhdGEv////" +
           "/wRggAIBAAAAAQAaAAAAQXVkaXRVYUZ4RXZlbnRUeXBlSW5zdGFuY2UBAQYEAQEGBAYEAAD/////DQAA" +
           "ABVgiQgCAAAAAAAHAAAARXZlbnRJZAEBAAAALgBEAA//////AQH/////AAAAABVgiQgCAAAAAAAJAAAA" +
           "RXZlbnRUeXBlAQEAAAAuAEQAEf////8BAf////8AAAAAFWCJCAIAAAAAAAoAAABTb3VyY2VOb2RlAQEA" +
           "AAAuAEQAEf////8BAf////8AAAAAFWCJCAIAAAAAAAoAAABTb3VyY2VOYW1lAQEAAAAuAEQADP////8B" +
           "Af////8AAAAAFWCJCAIAAAAAAAQAAABUaW1lAQEAAAAuAEQBACYB/////wEB/////wAAAAAVYIkIAgAA" +
           "AAAACwAAAFJlY2VpdmVUaW1lAQEAAAAuAEQBACYB/////wEB/////wAAAAAVYIkIAgAAAAAABwAAAE1l" +
           "c3NhZ2UBAQAAAC4ARAAV/////wEB/////wAAAAAVYIkIAgAAAAAACAAAAFNldmVyaXR5AQEAAAAuAEQA" +
           "Bf////8BAf////8AAAAAFWCJCAIAAAAAAA8AAABBY3Rpb25UaW1lU3RhbXABAQAAAC4ARAEAJgH/////" +
           "AQH/////AAAAABVgiQgCAAAAAAAGAAAAU3RhdHVzAQEAAAAuAEQAAf////8BAf////8AAAAAFWCJCAIA" +
           "AAAAAAgAAABTZXJ2ZXJJZAEBAAAALgBEAAz/////AQH/////AAAAABVgiQgCAAAAAAASAAAAQ2xpZW50" +
           "QXVkaXRFbnRyeUlkAQEAAAAuAEQADP////8BAf////8AAAAAFWCJCAIAAAAAAAwAAABDbGllbnRVc2Vy" +
           "SWQBAQAAAC4ARAAM/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region AuditConnectionCleanupEventTypeState Class
    #if (!OPCUA_EXCLUDE_AuditConnectionCleanupEventTypeState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class AuditConnectionCleanupEventTypeState : AuditUaFxEventTypeState
    {
        #region Constructors
        /// <remarks />
        public AuditConnectionCleanupEventTypeState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(UAModel.FXAC.ObjectTypes.AuditConnectionCleanupEventType, UAModel.FXAC.Namespaces.FXAC, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AwAAACIAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvRlgvQUMvHwAAAGh0dHA6Ly9vcGNmb3Vu" +
           "ZGF0aW9uLm9yZy9VQS9ESS8kAAAAaHR0cDovL29wY2ZvdW5kYXRpb24ub3JnL1VBL0ZYL0RhdGEv////" +
           "/wRggAIBAAAAAQAnAAAAQXVkaXRDb25uZWN0aW9uQ2xlYW51cEV2ZW50VHlwZUluc3RhbmNlAQEQBAEB" +
           "EAQQBAAA/////w8AAAAVYIkIAgAAAAAABwAAAEV2ZW50SWQBAQAAAC4ARAAP/////wEB/////wAAAAAV" +
           "YIkIAgAAAAAACQAAAEV2ZW50VHlwZQEBAAAALgBEABH/////AQH/////AAAAABVgiQgCAAAAAAAKAAAA" +
           "U291cmNlTm9kZQEBAAAALgBEABH/////AQH/////AAAAABVgiQgCAAAAAAAKAAAAU291cmNlTmFtZQEB" +
           "AAAALgBEAAz/////AQH/////AAAAABVgiQgCAAAAAAAEAAAAVGltZQEBAAAALgBEAQAmAf////8BAf//" +
           "//8AAAAAFWCJCAIAAAAAAAsAAABSZWNlaXZlVGltZQEBAAAALgBEAQAmAf////8BAf////8AAAAAFWCJ" +
           "CAIAAAAAAAcAAABNZXNzYWdlAQEAAAAuAEQAFf////8BAf////8AAAAAFWCJCAIAAAAAAAgAAABTZXZl" +
           "cml0eQEBAAAALgBEAAX/////AQH/////AAAAABVgiQgCAAAAAAAPAAAAQWN0aW9uVGltZVN0YW1wAQEA" +
           "AAAuAEQBACYB/////wEB/////wAAAAAVYIkIAgAAAAAABgAAAFN0YXR1cwEBAAAALgBEAAH/////AQH/" +
           "////AAAAABVgiQgCAAAAAAAIAAAAU2VydmVySWQBAQAAAC4ARAAM/////wEB/////wAAAAAVYIkIAgAA" +
           "AAAAEgAAAENsaWVudEF1ZGl0RW50cnlJZAEBAAAALgBEAAz/////AQH/////AAAAABVgiQgCAAAAAAAM" +
           "AAAAQ2xpZW50VXNlcklkAQEAAAAuAEQADP////8BAf////8AAAAAFWCpCgIAAAABAA8AAABSZWxhdGVk" +
           "RW5kcG9pbnQBAc8YAC4ARM8YAAAWAQOKEwLHAAAAPFJlbGF0ZWRFbmRwb2ludERhdGFUeXBlIHhtbG5z" +
           "PSJodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvRlgvRGF0YS9UeXBlcy54c2QiPjxBZGRyZXNzPjwv" +
           "QWRkcmVzcz48Q29ubmVjdGlvbkVuZHBvaW50UGF0aCAvPjxDb25uZWN0aW9uRW5kcG9pbnROYW1lPjwv" +
           "Q29ubmVjdGlvbkVuZHBvaW50TmFtZT48L1JlbGF0ZWRFbmRwb2ludERhdGFUeXBlPgEDuwv/////AwP/" +
           "////AAAAABVgiQoCAAAAAQAPAAAAUmVtb3ZlZEVuZHBvaW50AQHOGAAuAETOGAAAAAz/////AwP/////" +
           "AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public PropertyState<RelatedEndpointDataType> RelatedEndpoint
        {
            get
            {
                return m_relatedEndpoint;
            }

            set
            {
                if (!Object.ReferenceEquals(m_relatedEndpoint, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_relatedEndpoint = value;
            }
        }

        /// <remarks />
        public PropertyState<string> RemovedEndpoint
        {
            get
            {
                return m_removedEndpoint;
            }

            set
            {
                if (!Object.ReferenceEquals(m_removedEndpoint, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_removedEndpoint = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_relatedEndpoint != null)
            {
                children.Add(m_relatedEndpoint);
            }

            if (m_removedEndpoint != null)
            {
                children.Add(m_removedEndpoint);
            }

            base.GetChildren(context, children);
        }
            
        /// <remarks />
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case UAModel.FXAC.BrowseNames.RelatedEndpoint:
                {
                    if (createOrReplace)
                    {
                        if (RelatedEndpoint == null)
                        {
                            if (replacement == null)
                            {
                                RelatedEndpoint = new PropertyState<RelatedEndpointDataType>(this);
                            }
                            else
                            {
                                RelatedEndpoint = (PropertyState<RelatedEndpointDataType>)replacement;
                            }
                        }
                    }

                    instance = RelatedEndpoint;
                    break;
                }

                case UAModel.FXAC.BrowseNames.RemovedEndpoint:
                {
                    if (createOrReplace)
                    {
                        if (RemovedEndpoint == null)
                        {
                            if (replacement == null)
                            {
                                RemovedEndpoint = new PropertyState<string>(this);
                            }
                            else
                            {
                                RemovedEndpoint = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = RemovedEndpoint;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private PropertyState<RelatedEndpointDataType> m_relatedEndpoint;
        private PropertyState<string> m_removedEndpoint;
        #endregion
    }
    #endif
    #endregion

    #region IAssetRevisionTypeState Class
    #if (!OPCUA_EXCLUDE_IAssetRevisionTypeState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class IAssetRevisionTypeState : BaseInterfaceState
    {
        #region Constructors
        /// <remarks />
        public IAssetRevisionTypeState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(UAModel.FXAC.ObjectTypes.IAssetRevisionType, UAModel.FXAC.Namespaces.FXAC, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);

            if (BuildAssetNumber != null)
            {
                BuildAssetNumber.Initialize(context, BuildAssetNumber_InitializationString);
            }

            if (MajorAssetVersion != null)
            {
                MajorAssetVersion.Initialize(context, MajorAssetVersion_InitializationString);
            }

            if (MinorAssetVersion != null)
            {
                MinorAssetVersion.Initialize(context, MinorAssetVersion_InitializationString);
            }

            if (SubBuildAssetNumber != null)
            {
                SubBuildAssetNumber.Initialize(context, SubBuildAssetNumber_InitializationString);
            }

            if (VerifyAsset != null)
            {
                VerifyAsset.Initialize(context, VerifyAsset_InitializationString);
            }
        }

        #region Initialization String
        private const string BuildAssetNumber_InitializationString =
           "AwAAACIAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvRlgvQUMvHwAAAGh0dHA6Ly9vcGNmb3Vu" +
           "ZGF0aW9uLm9yZy9VQS9ESS8kAAAAaHR0cDovL29wY2ZvdW5kYXRpb24ub3JnL1VBL0ZYL0RhdGEv////" +
           "/xVgiQoCAAAAAQAQAAAAQnVpbGRBc3NldE51bWJlcgEBdwAALgBEdwAAAAAF/////wMD/////wAAAAA=";

        private const string MajorAssetVersion_InitializationString =
           "AwAAACIAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvRlgvQUMvHwAAAGh0dHA6Ly9vcGNmb3Vu" +
           "ZGF0aW9uLm9yZy9VQS9ESS8kAAAAaHR0cDovL29wY2ZvdW5kYXRpb24ub3JnL1VBL0ZYL0RhdGEv////" +
           "/xVgiQoCAAAAAQARAAAATWFqb3JBc3NldFZlcnNpb24BAXUAAC4ARHUAAAAABf////8DA/////8AAAAA";

        private const string MinorAssetVersion_InitializationString =
           "AwAAACIAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvRlgvQUMvHwAAAGh0dHA6Ly9vcGNmb3Vu" +
           "ZGF0aW9uLm9yZy9VQS9ESS8kAAAAaHR0cDovL29wY2ZvdW5kYXRpb24ub3JnL1VBL0ZYL0RhdGEv////" +
           "/xVgiQoCAAAAAQARAAAATWlub3JBc3NldFZlcnNpb24BAXYAAC4ARHYAAAAABf////8DA/////8AAAAA";

        private const string SubBuildAssetNumber_InitializationString =
           "AwAAACIAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvRlgvQUMvHwAAAGh0dHA6Ly9vcGNmb3Vu" +
           "ZGF0aW9uLm9yZy9VQS9ESS8kAAAAaHR0cDovL29wY2ZvdW5kYXRpb24ub3JnL1VBL0ZYL0RhdGEv////" +
           "/xVgiQoCAAAAAQATAAAAU3ViQnVpbGRBc3NldE51bWJlcgEBeAAALgBEeAAAAAAF/////wMD/////wAA" +
           "AAA=";

        private const string VerifyAsset_InitializationString =
           "AwAAACIAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvRlgvQUMvHwAAAGh0dHA6Ly9vcGNmb3Vu" +
           "ZGF0aW9uLm9yZy9VQS9ESS8kAAAAaHR0cDovL29wY2ZvdW5kYXRpb24ub3JnL1VBL0ZYL0RhdGEv////" +
           "/wRhggoEAAAAAQALAAAAVmVyaWZ5QXNzZXQBAcQFAC8BAcQFxAUAAAEB/////wIAAAAXYKkKAgAAAAAA" +
           "DgAAAElucHV0QXJndW1lbnRzAQGOBQAuAESOBQAAlgIAAAABACoBASUAAAAQAAAAVmVyaWZpY2F0aW9u" +
           "TW9kZQEDBQQBAAAAAQAAAAAAAAAAAQAqAQEyAAAAHQAAAEV4cGVjdGVkVmVyaWZpY2F0aW9uVmFyaWFi" +
           "bGVzAQDFOAEAAAABAAAAAAAAAAABACgBAQAAAAEAAAACAAAAAQH/////AAAAABdgqQoCAAAAAAAPAAAA" +
           "T3V0cHV0QXJndW1lbnRzAQGPBQAuAESPBQAAlgIAAAABACoBASMAAAASAAAAVmVyaWZpY2F0aW9uUmVz" +
           "dWx0AQMNBP////8AAAAAAAEAKgEBLgAAABsAAABWZXJpZmljYXRpb25WYXJpYWJsZXNFcnJvcnMAEwEA" +
           "AAABAAAAAAAAAAABACgBAQAAAAEAAAACAAAAAQH/////AAAAAA==";

        private const string InitializationString =
           "AwAAACIAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvRlgvQUMvHwAAAGh0dHA6Ly9vcGNmb3Vu" +
           "ZGF0aW9uLm9yZy9VQS9ESS8kAAAAaHR0cDovL29wY2ZvdW5kYXRpb24ub3JnL1VBL0ZYL0RhdGEv////" +
           "/wRggAIBAAAAAQAaAAAASUFzc2V0UmV2aXNpb25UeXBlSW5zdGFuY2UBAQkAAQEJAAkAAAABAAAAAQDD" +
           "RAEBAQMABQAAABVgiQoCAAAAAQAQAAAAQnVpbGRBc3NldE51bWJlcgEBdwAALgBEdwAAAAAF/////wMD" +
           "/////wAAAAAVYIkKAgAAAAEAEQAAAE1ham9yQXNzZXRWZXJzaW9uAQF1AAAuAER1AAAAAAX/////AwP/" +
           "////AAAAABVgiQoCAAAAAQARAAAATWlub3JBc3NldFZlcnNpb24BAXYAAC4ARHYAAAAABf////8DA///" +
           "//8AAAAAFWCJCgIAAAABABMAAABTdWJCdWlsZEFzc2V0TnVtYmVyAQF4AAAuAER4AAAAAAX/////AwP/" +
           "////AAAAAARhggoEAAAAAQALAAAAVmVyaWZ5QXNzZXQBAcQFAC8BAcQFxAUAAAEB/////wIAAAAXYKkK" +
           "AgAAAAAADgAAAElucHV0QXJndW1lbnRzAQGOBQAuAESOBQAAlgIAAAABACoBASUAAAAQAAAAVmVyaWZp" +
           "Y2F0aW9uTW9kZQEDBQQBAAAAAQAAAAAAAAAAAQAqAQEyAAAAHQAAAEV4cGVjdGVkVmVyaWZpY2F0aW9u" +
           "VmFyaWFibGVzAQDFOAEAAAABAAAAAAAAAAABACgBAQAAAAEAAAACAAAAAQH/////AAAAABdgqQoCAAAA" +
           "AAAPAAAAT3V0cHV0QXJndW1lbnRzAQGPBQAuAESPBQAAlgIAAAABACoBASMAAAASAAAAVmVyaWZpY2F0" +
           "aW9uUmVzdWx0AQMNBP////8AAAAAAAEAKgEBLgAAABsAAABWZXJpZmljYXRpb25WYXJpYWJsZXNFcnJv" +
           "cnMAEwEAAAABAAAAAAAAAAABACgBAQAAAAEAAAACAAAAAQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public PropertyState<ushort> BuildAssetNumber
        {
            get
            {
                return m_buildAssetNumber;
            }

            set
            {
                if (!Object.ReferenceEquals(m_buildAssetNumber, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_buildAssetNumber = value;
            }
        }

        /// <remarks />
        public PropertyState<ushort> MajorAssetVersion
        {
            get
            {
                return m_majorAssetVersion;
            }

            set
            {
                if (!Object.ReferenceEquals(m_majorAssetVersion, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_majorAssetVersion = value;
            }
        }

        /// <remarks />
        public PropertyState<ushort> MinorAssetVersion
        {
            get
            {
                return m_minorAssetVersion;
            }

            set
            {
                if (!Object.ReferenceEquals(m_minorAssetVersion, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_minorAssetVersion = value;
            }
        }

        /// <remarks />
        public PropertyState<ushort> SubBuildAssetNumber
        {
            get
            {
                return m_subBuildAssetNumber;
            }

            set
            {
                if (!Object.ReferenceEquals(m_subBuildAssetNumber, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_subBuildAssetNumber = value;
            }
        }

        /// <remarks />
        public VerifyAssetMethodState VerifyAsset
        {
            get
            {
                return m_verifyAssetMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_verifyAssetMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_verifyAssetMethod = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_buildAssetNumber != null)
            {
                children.Add(m_buildAssetNumber);
            }

            if (m_majorAssetVersion != null)
            {
                children.Add(m_majorAssetVersion);
            }

            if (m_minorAssetVersion != null)
            {
                children.Add(m_minorAssetVersion);
            }

            if (m_subBuildAssetNumber != null)
            {
                children.Add(m_subBuildAssetNumber);
            }

            if (m_verifyAssetMethod != null)
            {
                children.Add(m_verifyAssetMethod);
            }

            base.GetChildren(context, children);
        }
            
        /// <remarks />
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case UAModel.FXAC.BrowseNames.BuildAssetNumber:
                {
                    if (createOrReplace)
                    {
                        if (BuildAssetNumber == null)
                        {
                            if (replacement == null)
                            {
                                BuildAssetNumber = new PropertyState<ushort>(this);
                            }
                            else
                            {
                                BuildAssetNumber = (PropertyState<ushort>)replacement;
                            }
                        }
                    }

                    instance = BuildAssetNumber;
                    break;
                }

                case UAModel.FXAC.BrowseNames.MajorAssetVersion:
                {
                    if (createOrReplace)
                    {
                        if (MajorAssetVersion == null)
                        {
                            if (replacement == null)
                            {
                                MajorAssetVersion = new PropertyState<ushort>(this);
                            }
                            else
                            {
                                MajorAssetVersion = (PropertyState<ushort>)replacement;
                            }
                        }
                    }

                    instance = MajorAssetVersion;
                    break;
                }

                case UAModel.FXAC.BrowseNames.MinorAssetVersion:
                {
                    if (createOrReplace)
                    {
                        if (MinorAssetVersion == null)
                        {
                            if (replacement == null)
                            {
                                MinorAssetVersion = new PropertyState<ushort>(this);
                            }
                            else
                            {
                                MinorAssetVersion = (PropertyState<ushort>)replacement;
                            }
                        }
                    }

                    instance = MinorAssetVersion;
                    break;
                }

                case UAModel.FXAC.BrowseNames.SubBuildAssetNumber:
                {
                    if (createOrReplace)
                    {
                        if (SubBuildAssetNumber == null)
                        {
                            if (replacement == null)
                            {
                                SubBuildAssetNumber = new PropertyState<ushort>(this);
                            }
                            else
                            {
                                SubBuildAssetNumber = (PropertyState<ushort>)replacement;
                            }
                        }
                    }

                    instance = SubBuildAssetNumber;
                    break;
                }

                case UAModel.FXAC.BrowseNames.VerifyAsset:
                {
                    if (createOrReplace)
                    {
                        if (VerifyAsset == null)
                        {
                            if (replacement == null)
                            {
                                VerifyAsset = new VerifyAssetMethodState(this);
                            }
                            else
                            {
                                VerifyAsset = (VerifyAssetMethodState)replacement;
                            }
                        }
                    }

                    instance = VerifyAsset;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private PropertyState<ushort> m_buildAssetNumber;
        private PropertyState<ushort> m_majorAssetVersion;
        private PropertyState<ushort> m_minorAssetVersion;
        private PropertyState<ushort> m_subBuildAssetNumber;
        private VerifyAssetMethodState m_verifyAssetMethod;
        #endregion
    }
    #endif
    #endregion

    #region IFunctionalEntityTypeState Class
    #if (!OPCUA_EXCLUDE_IFunctionalEntityTypeState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class IFunctionalEntityTypeState : BaseInterfaceState
    {
        #region Constructors
        /// <remarks />
        public IFunctionalEntityTypeState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(UAModel.FXAC.ObjectTypes.IFunctionalEntityType, UAModel.FXAC.Namespaces.FXAC, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);

            if (ApplicationIdentifier != null)
            {
                ApplicationIdentifier.Initialize(context, ApplicationIdentifier_InitializationString);
            }

            if (AuthorAssignedIdentifier != null)
            {
                AuthorAssignedIdentifier.Initialize(context, AuthorAssignedIdentifier_InitializationString);
            }

            if (AuthorAssignedVersion != null)
            {
                AuthorAssignedVersion.Initialize(context, AuthorAssignedVersion_InitializationString);
            }

            if (AuthorUri != null)
            {
                AuthorUri.Initialize(context, AuthorUri_InitializationString);
            }

            if (Capabilities != null)
            {
                Capabilities.Initialize(context, Capabilities_InitializationString);
            }

            if (ConfigurationData != null)
            {
                ConfigurationData.Initialize(context, ConfigurationData_InitializationString);
            }

            if (ConnectionEndpoints != null)
            {
                ConnectionEndpoints.Initialize(context, ConnectionEndpoints_InitializationString);
            }

            if (ControlGroups != null)
            {
                ControlGroups.Initialize(context, ControlGroups_InitializationString);
            }

            if (InputData != null)
            {
                InputData.Initialize(context, InputData_InitializationString);
            }

            if (OperationalHealth != null)
            {
                OperationalHealth.Initialize(context, OperationalHealth_InitializationString);
            }

            if (OperationalHealthAlarms != null)
            {
                OperationalHealthAlarms.Initialize(context, OperationalHealthAlarms_InitializationString);
            }

            if (OutputData != null)
            {
                OutputData.Initialize(context, OutputData_InitializationString);
            }

            if (PublisherCapabilities != null)
            {
                PublisherCapabilities.Initialize(context, PublisherCapabilities_InitializationString);
            }

            if (SubscriberCapabilities != null)
            {
                SubscriberCapabilities.Initialize(context, SubscriberCapabilities_InitializationString);
            }

            if (Verify != null)
            {
                Verify.Initialize(context, Verify_InitializationString);
            }
        }

        #region Initialization String
        private const string ApplicationIdentifier_InitializationString =
           "AwAAACIAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvRlgvQUMvHwAAAGh0dHA6Ly9vcGNmb3Vu" +
           "ZGF0aW9uLm9yZy9VQS9ESS8kAAAAaHR0cDovL29wY2ZvdW5kYXRpb24ub3JnL1VBL0ZYL0RhdGEv////" +
           "/xdgiQoCAAAAAQAVAAAAQXBwbGljYXRpb25JZGVudGlmaWVyAQGBAAAuAESBAAAAAQEcAAEAAAABAAAA" +
           "AAAAAAMD/////wAAAAA=";

        private const string AuthorAssignedIdentifier_InitializationString =
           "AwAAACIAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvRlgvQUMvHwAAAGh0dHA6Ly9vcGNmb3Vu" +
           "ZGF0aW9uLm9yZy9VQS9ESS8kAAAAaHR0cDovL29wY2ZvdW5kYXRpb24ub3JnL1VBL0ZYL0RhdGEv////" +
           "/xVgiQoCAAAAAQAYAAAAQXV0aG9yQXNzaWduZWRJZGVudGlmaWVyAQF/AAAuAER/AAAAAAz/////AwP/" +
           "////AAAAAA==";

        private const string AuthorAssignedVersion_InitializationString =
           "AwAAACIAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvRlgvQUMvHwAAAGh0dHA6Ly9vcGNmb3Vu" +
           "ZGF0aW9uLm9yZy9VQS9ESS8kAAAAaHR0cDovL29wY2ZvdW5kYXRpb24ub3JnL1VBL0ZYL0RhdGEv////" +
           "/xVgqQoCAAAAAQAVAAAAQXV0aG9yQXNzaWduZWRWZXJzaW9uAQGAAAAuAESAAAAAFgEBXAACkQAAADxG" +
           "eFZlcnNpb24geG1sbnM9Imh0dHA6Ly9vcGNmb3VuZGF0aW9uLm9yZy9VQS9GWC9BQy9UeXBlcy54c2Qi" +
           "PjxNYWpvcj4wPC9NYWpvcj48TWlub3I+MDwvTWlub3I+PEJ1aWxkPjA8L0J1aWxkPjxTdWJCdWlsZD4w" +
           "PC9TdWJCdWlsZD48L0Z4VmVyc2lvbj4BARkA/////wMD/////wAAAAA=";

        private const string AuthorUri_InitializationString =
           "AwAAACIAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvRlgvQUMvHwAAAGh0dHA6Ly9vcGNmb3Vu" +
           "ZGF0aW9uLm9yZy9VQS9ESS8kAAAAaHR0cDovL29wY2ZvdW5kYXRpb24ub3JnL1VBL0ZYL0RhdGEv////" +
           "/xVgiQoCAAAAAQAJAAAAQXV0aG9yVXJpAQF+AAAuAER+AAAAAQDHXP////8DA/////8AAAAA";

        private const string Capabilities_InitializationString =
           "AwAAACIAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvRlgvQUMvHwAAAGh0dHA6Ly9vcGNmb3Vu" +
           "ZGF0aW9uLm9yZy9VQS9ESS8kAAAAaHR0cDovL29wY2ZvdW5kYXRpb24ub3JnL1VBL0ZYL0RhdGEv////" +
           "/wRggAoBAAAAAQAMAAAAQ2FwYWJpbGl0aWVzAQGvEwAvAQHwA68TAAD/////AQAAABVgiQoCAAAAAQAW" +
           "AAAARmVlZGJhY2tTaWduYWxSZXF1aXJlZAEB6RcBAaIPAD/pFwAAAAH/////AwP/////AAAAAA==";

        private const string ConfigurationData_InitializationString =
           "AwAAACIAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvRlgvQUMvHwAAAGh0dHA6Ly9vcGNmb3Vu" +
           "ZGF0aW9uLm9yZy9VQS9ESS8kAAAAaHR0cDovL29wY2ZvdW5kYXRpb24ub3JnL1VBL0ZYL0RhdGEv////" +
           "/wRggAoBAAAAAQARAAAAQ29uZmlndXJhdGlvbkRhdGEBAfATAC8BAREE8BMAAP////8AAAAA";

        private const string ConnectionEndpoints_InitializationString =
           "AwAAACIAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvRlgvQUMvHwAAAGh0dHA6Ly9vcGNmb3Vu" +
           "ZGF0aW9uLm9yZy9VQS9ESS8kAAAAaHR0cDovL29wY2ZvdW5kYXRpb24ub3JnL1VBL0ZYL0RhdGEv////" +
           "/wRggAoBAAAAAQATAAAAQ29ubmVjdGlvbkVuZHBvaW50cwEBNAAALwEBFAA0AAAA/////wAAAAA=";

        private const string ControlGroups_InitializationString =
           "AwAAACIAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvRlgvQUMvHwAAAGh0dHA6Ly9vcGNmb3Vu" +
           "ZGF0aW9uLm9yZy9VQS9ESS8kAAAAaHR0cDovL29wY2ZvdW5kYXRpb24ub3JnL1VBL0ZYL0RhdGEv////" +
           "/wRggAoBAAAAAQANAAAAQ29udHJvbEdyb3VwcwEBKAQALwEB8gMoBAAA/////wAAAAA=";

        private const string InputData_InitializationString =
           "AwAAACIAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvRlgvQUMvHwAAAGh0dHA6Ly9vcGNmb3Vu" +
           "ZGF0aW9uLm9yZy9VQS9ESS8kAAAAaHR0cDovL29wY2ZvdW5kYXRpb24ub3JnL1VBL0ZYL0RhdGEv////" +
           "/wRggAoBAAAAAQAJAAAASW5wdXREYXRhAQGzBAAvAQHoA7MEAAD/////AAAAAA==";

        private const string OperationalHealth_InitializationString =
           "AwAAACIAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvRlgvQUMvHwAAAGh0dHA6Ly9vcGNmb3Vu" +
           "ZGF0aW9uLm9yZy9VQS9ESS8kAAAAaHR0cDovL29wY2ZvdW5kYXRpb24ub3JnL1VBL0ZYL0RhdGEv////" +
           "/xVgiQoCAAAAAQARAAAAT3BlcmF0aW9uYWxIZWFsdGgBAdUXAC8AP9UXAAABAcIL/////wEB/////wAA" +
           "AAA=";

        private const string OperationalHealthAlarms_InitializationString =
           "AwAAACIAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvRlgvQUMvHwAAAGh0dHA6Ly9vcGNmb3Vu" +
           "ZGF0aW9uLm9yZy9VQS9ESS8kAAAAaHR0cDovL29wY2ZvdW5kYXRpb24ub3JnL1VBL0ZYL0RhdGEv////" +
           "/wRggAoBAAAAAQAXAAAAT3BlcmF0aW9uYWxIZWFsdGhBbGFybXMBAasTAC8APasTAAD/////AAAAAA==";

        private const string OutputData_InitializationString =
           "AwAAACIAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvRlgvQUMvHwAAAGh0dHA6Ly9vcGNmb3Vu" +
           "ZGF0aW9uLm9yZy9VQS9ESS8kAAAAaHR0cDovL29wY2ZvdW5kYXRpb24ub3JnL1VBL0ZYL0RhdGEv////" +
           "/wRggAoBAAAAAQAKAAAAT3V0cHV0RGF0YQEBtAQALwEB+wO0BAAA/////wAAAAA=";

        private const string PublisherCapabilities_InitializationString =
           "AwAAACIAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvRlgvQUMvHwAAAGh0dHA6Ly9vcGNmb3Vu" +
           "ZGF0aW9uLm9yZy9VQS9ESS8kAAAAaHR0cDovL29wY2ZvdW5kYXRpb24ub3JnL1VBL0ZYL0RhdGEv////" +
           "/wRggAoBAAAAAQAVAAAAUHVibGlzaGVyQ2FwYWJpbGl0aWVzAQGPEwAvAQHrA48TAAD/////BAAAABdg" +
           "iQoCAAAAAQAYAAAAUHJlY29uZmlndXJlZERhdGFTZXRPbmx5AQGOFwAvAD+OFwAAAAEBAAAAAQAAAAAA" +
           "AAADA/////8AAAAAF2CJCgIAAAABAB4AAABQcmVjb25maWd1cmVkUHVibGlzaGVkRGF0YVNldHMBAY8X" +
           "AC8AP48XAAAADAEAAAABAAAAAAAAAAMD/////wAAAAAXYIkKAgAAAAEAHAAAAFN1cHBvcnRlZFB1Ymxp" +
           "c2hpbmdJbnRlcnZhbHMBAZEXAC8AP5EXAAABAcALAQAAAAEAAAAAAAAAAwP/////AAAAABdgiQoCAAAA" +
           "AQAMAAAAU3VwcG9ydGVkUW9zAQGSFwAvAD+SFwAAAQHDCwEAAAABAAAAAAAAAAMD/////wAAAAA=";

        private const string SubscriberCapabilities_InitializationString =
           "AwAAACIAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvRlgvQUMvHwAAAGh0dHA6Ly9vcGNmb3Vu" +
           "ZGF0aW9uLm9yZy9VQS9ESS8kAAAAaHR0cDovL29wY2ZvdW5kYXRpb24ub3JnL1VBL0ZYL0RhdGEv////" +
           "/wRggAoBAAAAAQAWAAAAU3Vic2NyaWJlckNhcGFiaWxpdGllcwEBkBMALwEB7AOQEwAA/////wUAAAAV" +
           "YIkKAgAAAAEAGAAAAFByZWNvbmZpZ3VyZWREYXRhU2V0T25seQEBkxcALwA/kxcAAAAB/////wMD////" +
           "/wAAAAAXYIkKAgAAAAEAHwAAAFByZWNvbmZpZ3VyZWRTdWJzY3JpYmVkRGF0YVNldHMBAZUXAC8AP5UX" +
           "AAAADAEAAAABAAAAAAAAAAMD/////wAAAAAXYIkKAgAAAAEAHwAAAFN1cHBvcnRlZE1lc3NhZ2VSZWNl" +
           "aXZlVGltZW91dHMBAZYXAC8AP5YXAAABAcALAQAAAAEAAAAAAAAAAwP/////AAAAABdgiQoCAAAAAQAc" +
           "AAAAU3VwcG9ydGVkUHVibGlzaGluZ0ludGVydmFscwEBlxcALwA/lxcAAAEBwAsBAAAAAQAAAAAAAAAD" +
           "A/////8AAAAAF2CJCgIAAAABAAwAAABTdXBwb3J0ZWRRb3MBAZgXAC8AP5gXAAABAcQLAQAAAAEAAAAA" +
           "AAAAAwP/////AAAAAA==";

        private const string Verify_InitializationString =
           "AwAAACIAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvRlgvQUMvHwAAAGh0dHA6Ly9vcGNmb3Vu" +
           "ZGF0aW9uLm9yZy9VQS9ESS8kAAAAaHR0cDovL29wY2ZvdW5kYXRpb24ub3JnL1VBL0ZYL0RhdGEv////" +
           "/wRhggoEAAAAAQAGAAAAVmVyaWZ5AQEhAQAvAQEhASEBAAABAf////8CAAAAF2CpCgIAAAAAAA4AAABJ" +
           "bnB1dEFyZ3VtZW50cwEBjAUALgBEjAUAAJYBAAAAAQAqAQEyAAAAHQAAAEV4cGVjdGVkVmVyaWZpY2F0" +
           "aW9uVmFyaWFibGVzAQMEBAEAAAABAAAAAAAAAAABACgBAQAAAAEAAAABAAAAAQH/////AAAAABdgqQoC" +
           "AAAAAAAPAAAAT3V0cHV0QXJndW1lbnRzAQGNBQAuAESNBQAAlgIAAAABACoBASMAAAASAAAAVmVyaWZp" +
           "Y2F0aW9uUmVzdWx0AQO6C/////8AAAAAAAEAKgEBLgAAABsAAABWZXJpZmljYXRpb25WYXJpYWJsZXNF" +
           "cnJvcnMAEwEAAAABAAAAAAAAAAABACgBAQAAAAEAAAACAAAAAQH/////AAAAAA==";

        private const string InitializationString =
           "AwAAACIAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvRlgvQUMvHwAAAGh0dHA6Ly9vcGNmb3Vu" +
           "ZGF0aW9uLm9yZy9VQS9ESS8kAAAAaHR0cDovL29wY2ZvdW5kYXRpb24ub3JnL1VBL0ZYL0RhdGEv////" +
           "/wRggAIBAAAAAQAdAAAASUZ1bmN0aW9uYWxFbnRpdHlUeXBlSW5zdGFuY2UBAQsAAQELAAsAAAABAAAA" +
           "AQDDRAEBAQQADwAAABdgiQoCAAAAAQAVAAAAQXBwbGljYXRpb25JZGVudGlmaWVyAQGBAAAuAESBAAAA" +
           "AQEcAAEAAAABAAAAAAAAAAMD/////wAAAAAVYIkKAgAAAAEAGAAAAEF1dGhvckFzc2lnbmVkSWRlbnRp" +
           "ZmllcgEBfwAALgBEfwAAAAAM/////wMD/////wAAAAAVYKkKAgAAAAEAFQAAAEF1dGhvckFzc2lnbmVk" +
           "VmVyc2lvbgEBgAAALgBEgAAAABYBAVwAApEAAAA8RnhWZXJzaW9uIHhtbG5zPSJodHRwOi8vb3BjZm91" +
           "bmRhdGlvbi5vcmcvVUEvRlgvQUMvVHlwZXMueHNkIj48TWFqb3I+MDwvTWFqb3I+PE1pbm9yPjA8L01p" +
           "bm9yPjxCdWlsZD4wPC9CdWlsZD48U3ViQnVpbGQ+MDwvU3ViQnVpbGQ+PC9GeFZlcnNpb24+AQEZAP//" +
           "//8DA/////8AAAAAFWCJCgIAAAABAAkAAABBdXRob3JVcmkBAX4AAC4ARH4AAAABAMdc/////wMD////" +
           "/wAAAAAEYIAKAQAAAAEADAAAAENhcGFiaWxpdGllcwEBrxMALwEB8AOvEwAA/////wEAAAAVYIkKAgAA" +
           "AAEAFgAAAEZlZWRiYWNrU2lnbmFsUmVxdWlyZWQBAekXAQGiDwA/6RcAAAAB/////wMD/////wAAAAAE" +
           "YIAKAQAAAAEAEQAAAENvbmZpZ3VyYXRpb25EYXRhAQHwEwAvAQERBPATAAD/////AAAAAARggAoBAAAA" +
           "AQATAAAAQ29ubmVjdGlvbkVuZHBvaW50cwEBNAAALwEBFAA0AAAA/////wAAAAAEYIAKAQAAAAEADQAA" +
           "AENvbnRyb2xHcm91cHMBASgEAC8BAfIDKAQAAP////8AAAAABGCACgEAAAABAAkAAABJbnB1dERhdGEB" +
           "AbMEAC8BAegDswQAAP////8AAAAAFWCJCgIAAAABABEAAABPcGVyYXRpb25hbEhlYWx0aAEB1RcALwA/" +
           "1RcAAAEBwgv/////AQH/////AAAAAARggAoBAAAAAQAXAAAAT3BlcmF0aW9uYWxIZWFsdGhBbGFybXMB" +
           "AasTAC8APasTAAD/////AAAAAARggAoBAAAAAQAKAAAAT3V0cHV0RGF0YQEBtAQALwEB+wO0BAAA////" +
           "/wAAAAAEYIAKAQAAAAEAFQAAAFB1Ymxpc2hlckNhcGFiaWxpdGllcwEBjxMALwEB6wOPEwAA/////wQA" +
           "AAAXYIkKAgAAAAEAGAAAAFByZWNvbmZpZ3VyZWREYXRhU2V0T25seQEBjhcALwA/jhcAAAABAQAAAAEA" +
           "AAAAAAAAAwP/////AAAAABdgiQoCAAAAAQAeAAAAUHJlY29uZmlndXJlZFB1Ymxpc2hlZERhdGFTZXRz" +
           "AQGPFwAvAD+PFwAAAAwBAAAAAQAAAAAAAAADA/////8AAAAAF2CJCgIAAAABABwAAABTdXBwb3J0ZWRQ" +
           "dWJsaXNoaW5nSW50ZXJ2YWxzAQGRFwAvAD+RFwAAAQHACwEAAAABAAAAAAAAAAMD/////wAAAAAXYIkK" +
           "AgAAAAEADAAAAFN1cHBvcnRlZFFvcwEBkhcALwA/khcAAAEBwwsBAAAAAQAAAAAAAAADA/////8AAAAA" +
           "BGCACgEAAAABABYAAABTdWJzY3JpYmVyQ2FwYWJpbGl0aWVzAQGQEwAvAQHsA5ATAAD/////BQAAABVg" +
           "iQoCAAAAAQAYAAAAUHJlY29uZmlndXJlZERhdGFTZXRPbmx5AQGTFwAvAD+TFwAAAAH/////AwP/////" +
           "AAAAABdgiQoCAAAAAQAfAAAAUHJlY29uZmlndXJlZFN1YnNjcmliZWREYXRhU2V0cwEBlRcALwA/lRcA" +
           "AAAMAQAAAAEAAAAAAAAAAwP/////AAAAABdgiQoCAAAAAQAfAAAAU3VwcG9ydGVkTWVzc2FnZVJlY2Vp" +
           "dmVUaW1lb3V0cwEBlhcALwA/lhcAAAEBwAsBAAAAAQAAAAAAAAADA/////8AAAAAF2CJCgIAAAABABwA" +
           "AABTdXBwb3J0ZWRQdWJsaXNoaW5nSW50ZXJ2YWxzAQGXFwAvAD+XFwAAAQHACwEAAAABAAAAAAAAAAMD" +
           "/////wAAAAAXYIkKAgAAAAEADAAAAFN1cHBvcnRlZFFvcwEBmBcALwA/mBcAAAEBxAsBAAAAAQAAAAAA" +
           "AAADA/////8AAAAABGGCCgQAAAABAAYAAABWZXJpZnkBASEBAC8BASEBIQEAAAEB/////wIAAAAXYKkK" +
           "AgAAAAAADgAAAElucHV0QXJndW1lbnRzAQGMBQAuAESMBQAAlgEAAAABACoBATIAAAAdAAAARXhwZWN0" +
           "ZWRWZXJpZmljYXRpb25WYXJpYWJsZXMBAwQEAQAAAAEAAAAAAAAAAAEAKAEBAAAAAQAAAAEAAAABAf//" +
           "//8AAAAAF2CpCgIAAAAAAA8AAABPdXRwdXRBcmd1bWVudHMBAY0FAC4ARI0FAACWAgAAAAEAKgEBIwAA" +
           "ABIAAABWZXJpZmljYXRpb25SZXN1bHQBA7oL/////wAAAAAAAQAqAQEuAAAAGwAAAFZlcmlmaWNhdGlv" +
           "blZhcmlhYmxlc0Vycm9ycwATAQAAAAEAAAAAAAAAAAEAKAEBAAAAAQAAAAIAAAABAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public PropertyState<ApplicationIdentifierDataType[]> ApplicationIdentifier
        {
            get
            {
                return m_applicationIdentifier;
            }

            set
            {
                if (!Object.ReferenceEquals(m_applicationIdentifier, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_applicationIdentifier = value;
            }
        }

        /// <remarks />
        public PropertyState<string> AuthorAssignedIdentifier
        {
            get
            {
                return m_authorAssignedIdentifier;
            }

            set
            {
                if (!Object.ReferenceEquals(m_authorAssignedIdentifier, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_authorAssignedIdentifier = value;
            }
        }

        /// <remarks />
        public PropertyState<FxVersion> AuthorAssignedVersion
        {
            get
            {
                return m_authorAssignedVersion;
            }

            set
            {
                if (!Object.ReferenceEquals(m_authorAssignedVersion, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_authorAssignedVersion = value;
            }
        }

        /// <remarks />
        public PropertyState<string> AuthorUri
        {
            get
            {
                return m_authorUri;
            }

            set
            {
                if (!Object.ReferenceEquals(m_authorUri, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_authorUri = value;
            }
        }

        /// <remarks />
        public FunctionalEntityCapabilitiesTypeState Capabilities
        {
            get
            {
                return m_capabilities;
            }

            set
            {
                if (!Object.ReferenceEquals(m_capabilities, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_capabilities = value;
            }
        }

        /// <remarks />
        public ConfigurationDataFolderTypeState ConfigurationData
        {
            get
            {
                return m_configurationData;
            }

            set
            {
                if (!Object.ReferenceEquals(m_configurationData, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_configurationData = value;
            }
        }

        /// <remarks />
        public ConnectionEndpointsFolderTypeState ConnectionEndpoints
        {
            get
            {
                return m_connectionEndpoints;
            }

            set
            {
                if (!Object.ReferenceEquals(m_connectionEndpoints, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_connectionEndpoints = value;
            }
        }

        /// <remarks />
        public ControlGroupsFolderTypeState ControlGroups
        {
            get
            {
                return m_controlGroups;
            }

            set
            {
                if (!Object.ReferenceEquals(m_controlGroups, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_controlGroups = value;
            }
        }

        /// <remarks />
        public InputsFolderTypeState InputData
        {
            get
            {
                return m_inputData;
            }

            set
            {
                if (!Object.ReferenceEquals(m_inputData, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_inputData = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<uint> OperationalHealth
        {
            get
            {
                return m_operationalHealth;
            }

            set
            {
                if (!Object.ReferenceEquals(m_operationalHealth, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_operationalHealth = value;
            }
        }

        /// <remarks />
        public FolderState OperationalHealthAlarms
        {
            get
            {
                return m_operationalHealthAlarms;
            }

            set
            {
                if (!Object.ReferenceEquals(m_operationalHealthAlarms, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_operationalHealthAlarms = value;
            }
        }

        /// <remarks />
        public OutputsFolderTypeState OutputData
        {
            get
            {
                return m_outputData;
            }

            set
            {
                if (!Object.ReferenceEquals(m_outputData, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_outputData = value;
            }
        }

        /// <remarks />
        public PublisherCapabilitiesTypeState PublisherCapabilities
        {
            get
            {
                return m_publisherCapabilities;
            }

            set
            {
                if (!Object.ReferenceEquals(m_publisherCapabilities, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_publisherCapabilities = value;
            }
        }

        /// <remarks />
        public SubscriberCapabilitiesTypeState SubscriberCapabilities
        {
            get
            {
                return m_subscriberCapabilities;
            }

            set
            {
                if (!Object.ReferenceEquals(m_subscriberCapabilities, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_subscriberCapabilities = value;
            }
        }

        /// <remarks />
        public VerifyMethodState Verify
        {
            get
            {
                return m_verifyMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_verifyMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_verifyMethod = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_applicationIdentifier != null)
            {
                children.Add(m_applicationIdentifier);
            }

            if (m_authorAssignedIdentifier != null)
            {
                children.Add(m_authorAssignedIdentifier);
            }

            if (m_authorAssignedVersion != null)
            {
                children.Add(m_authorAssignedVersion);
            }

            if (m_authorUri != null)
            {
                children.Add(m_authorUri);
            }

            if (m_capabilities != null)
            {
                children.Add(m_capabilities);
            }

            if (m_configurationData != null)
            {
                children.Add(m_configurationData);
            }

            if (m_connectionEndpoints != null)
            {
                children.Add(m_connectionEndpoints);
            }

            if (m_controlGroups != null)
            {
                children.Add(m_controlGroups);
            }

            if (m_inputData != null)
            {
                children.Add(m_inputData);
            }

            if (m_operationalHealth != null)
            {
                children.Add(m_operationalHealth);
            }

            if (m_operationalHealthAlarms != null)
            {
                children.Add(m_operationalHealthAlarms);
            }

            if (m_outputData != null)
            {
                children.Add(m_outputData);
            }

            if (m_publisherCapabilities != null)
            {
                children.Add(m_publisherCapabilities);
            }

            if (m_subscriberCapabilities != null)
            {
                children.Add(m_subscriberCapabilities);
            }

            if (m_verifyMethod != null)
            {
                children.Add(m_verifyMethod);
            }

            base.GetChildren(context, children);
        }
            
        /// <remarks />
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case UAModel.FXAC.BrowseNames.ApplicationIdentifier:
                {
                    if (createOrReplace)
                    {
                        if (ApplicationIdentifier == null)
                        {
                            if (replacement == null)
                            {
                                ApplicationIdentifier = new PropertyState<ApplicationIdentifierDataType[]>(this);
                            }
                            else
                            {
                                ApplicationIdentifier = (PropertyState<ApplicationIdentifierDataType[]>)replacement;
                            }
                        }
                    }

                    instance = ApplicationIdentifier;
                    break;
                }

                case UAModel.FXAC.BrowseNames.AuthorAssignedIdentifier:
                {
                    if (createOrReplace)
                    {
                        if (AuthorAssignedIdentifier == null)
                        {
                            if (replacement == null)
                            {
                                AuthorAssignedIdentifier = new PropertyState<string>(this);
                            }
                            else
                            {
                                AuthorAssignedIdentifier = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = AuthorAssignedIdentifier;
                    break;
                }

                case UAModel.FXAC.BrowseNames.AuthorAssignedVersion:
                {
                    if (createOrReplace)
                    {
                        if (AuthorAssignedVersion == null)
                        {
                            if (replacement == null)
                            {
                                AuthorAssignedVersion = new PropertyState<FxVersion>(this);
                            }
                            else
                            {
                                AuthorAssignedVersion = (PropertyState<FxVersion>)replacement;
                            }
                        }
                    }

                    instance = AuthorAssignedVersion;
                    break;
                }

                case UAModel.FXAC.BrowseNames.AuthorUri:
                {
                    if (createOrReplace)
                    {
                        if (AuthorUri == null)
                        {
                            if (replacement == null)
                            {
                                AuthorUri = new PropertyState<string>(this);
                            }
                            else
                            {
                                AuthorUri = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = AuthorUri;
                    break;
                }

                case UAModel.FXAC.BrowseNames.Capabilities:
                {
                    if (createOrReplace)
                    {
                        if (Capabilities == null)
                        {
                            if (replacement == null)
                            {
                                Capabilities = new FunctionalEntityCapabilitiesTypeState(this);
                            }
                            else
                            {
                                Capabilities = (FunctionalEntityCapabilitiesTypeState)replacement;
                            }
                        }
                    }

                    instance = Capabilities;
                    break;
                }

                case UAModel.FXAC.BrowseNames.ConfigurationData:
                {
                    if (createOrReplace)
                    {
                        if (ConfigurationData == null)
                        {
                            if (replacement == null)
                            {
                                ConfigurationData = new ConfigurationDataFolderTypeState(this);
                            }
                            else
                            {
                                ConfigurationData = (ConfigurationDataFolderTypeState)replacement;
                            }
                        }
                    }

                    instance = ConfigurationData;
                    break;
                }

                case UAModel.FXAC.BrowseNames.ConnectionEndpoints:
                {
                    if (createOrReplace)
                    {
                        if (ConnectionEndpoints == null)
                        {
                            if (replacement == null)
                            {
                                ConnectionEndpoints = new ConnectionEndpointsFolderTypeState(this);
                            }
                            else
                            {
                                ConnectionEndpoints = (ConnectionEndpointsFolderTypeState)replacement;
                            }
                        }
                    }

                    instance = ConnectionEndpoints;
                    break;
                }

                case UAModel.FXAC.BrowseNames.ControlGroups:
                {
                    if (createOrReplace)
                    {
                        if (ControlGroups == null)
                        {
                            if (replacement == null)
                            {
                                ControlGroups = new ControlGroupsFolderTypeState(this);
                            }
                            else
                            {
                                ControlGroups = (ControlGroupsFolderTypeState)replacement;
                            }
                        }
                    }

                    instance = ControlGroups;
                    break;
                }

                case UAModel.FXAC.BrowseNames.InputData:
                {
                    if (createOrReplace)
                    {
                        if (InputData == null)
                        {
                            if (replacement == null)
                            {
                                InputData = new InputsFolderTypeState(this);
                            }
                            else
                            {
                                InputData = (InputsFolderTypeState)replacement;
                            }
                        }
                    }

                    instance = InputData;
                    break;
                }

                case UAModel.FXAC.BrowseNames.OperationalHealth:
                {
                    if (createOrReplace)
                    {
                        if (OperationalHealth == null)
                        {
                            if (replacement == null)
                            {
                                OperationalHealth = new BaseDataVariableState<uint>(this);
                            }
                            else
                            {
                                OperationalHealth = (BaseDataVariableState<uint>)replacement;
                            }
                        }
                    }

                    instance = OperationalHealth;
                    break;
                }

                case UAModel.FXAC.BrowseNames.OperationalHealthAlarms:
                {
                    if (createOrReplace)
                    {
                        if (OperationalHealthAlarms == null)
                        {
                            if (replacement == null)
                            {
                                OperationalHealthAlarms = new FolderState(this);
                            }
                            else
                            {
                                OperationalHealthAlarms = (FolderState)replacement;
                            }
                        }
                    }

                    instance = OperationalHealthAlarms;
                    break;
                }

                case UAModel.FXAC.BrowseNames.OutputData:
                {
                    if (createOrReplace)
                    {
                        if (OutputData == null)
                        {
                            if (replacement == null)
                            {
                                OutputData = new OutputsFolderTypeState(this);
                            }
                            else
                            {
                                OutputData = (OutputsFolderTypeState)replacement;
                            }
                        }
                    }

                    instance = OutputData;
                    break;
                }

                case UAModel.FXAC.BrowseNames.PublisherCapabilities:
                {
                    if (createOrReplace)
                    {
                        if (PublisherCapabilities == null)
                        {
                            if (replacement == null)
                            {
                                PublisherCapabilities = new PublisherCapabilitiesTypeState(this);
                            }
                            else
                            {
                                PublisherCapabilities = (PublisherCapabilitiesTypeState)replacement;
                            }
                        }
                    }

                    instance = PublisherCapabilities;
                    break;
                }

                case UAModel.FXAC.BrowseNames.SubscriberCapabilities:
                {
                    if (createOrReplace)
                    {
                        if (SubscriberCapabilities == null)
                        {
                            if (replacement == null)
                            {
                                SubscriberCapabilities = new SubscriberCapabilitiesTypeState(this);
                            }
                            else
                            {
                                SubscriberCapabilities = (SubscriberCapabilitiesTypeState)replacement;
                            }
                        }
                    }

                    instance = SubscriberCapabilities;
                    break;
                }

                case UAModel.FXAC.BrowseNames.Verify:
                {
                    if (createOrReplace)
                    {
                        if (Verify == null)
                        {
                            if (replacement == null)
                            {
                                Verify = new VerifyMethodState(this);
                            }
                            else
                            {
                                Verify = (VerifyMethodState)replacement;
                            }
                        }
                    }

                    instance = Verify;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private PropertyState<ApplicationIdentifierDataType[]> m_applicationIdentifier;
        private PropertyState<string> m_authorAssignedIdentifier;
        private PropertyState<FxVersion> m_authorAssignedVersion;
        private PropertyState<string> m_authorUri;
        private FunctionalEntityCapabilitiesTypeState m_capabilities;
        private ConfigurationDataFolderTypeState m_configurationData;
        private ConnectionEndpointsFolderTypeState m_connectionEndpoints;
        private ControlGroupsFolderTypeState m_controlGroups;
        private InputsFolderTypeState m_inputData;
        private BaseDataVariableState<uint> m_operationalHealth;
        private FolderState m_operationalHealthAlarms;
        private OutputsFolderTypeState m_outputData;
        private PublisherCapabilitiesTypeState m_publisherCapabilities;
        private SubscriberCapabilitiesTypeState m_subscriberCapabilities;
        private VerifyMethodState m_verifyMethod;
        #endregion
    }
    #endif
    #endregion

    #region ConnectionEndpointTypeState Class
    #if (!OPCUA_EXCLUDE_ConnectionEndpointTypeState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ConnectionEndpointTypeState : BaseObjectState
    {
        #region Constructors
        /// <remarks />
        public ConnectionEndpointTypeState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(UAModel.FXAC.ObjectTypes.ConnectionEndpointType, UAModel.FXAC.Namespaces.FXAC, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);

            if (InputVariables != null)
            {
                InputVariables.Initialize(context, InputVariables_InitializationString);
            }

            if (OutputVariables != null)
            {
                OutputVariables.Initialize(context, OutputVariables_InitializationString);
            }
        }

        #region Initialization String
        private const string InputVariables_InitializationString =
           "AwAAACIAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvRlgvQUMvHwAAAGh0dHA6Ly9vcGNmb3Vu" +
           "ZGF0aW9uLm9yZy9VQS9ESS8kAAAAaHR0cDovL29wY2ZvdW5kYXRpb24ub3JnL1VBL0ZYL0RhdGEv////" +
           "/xdgiQoCAAAAAQAOAAAASW5wdXRWYXJpYWJsZXMBATUYAC8APzUYAAAAEQEAAAABAAAAAAAAAAMD////" +
           "/wAAAAA=";

        private const string OutputVariables_InitializationString =
           "AwAAACIAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvRlgvQUMvHwAAAGh0dHA6Ly9vcGNmb3Vu" +
           "ZGF0aW9uLm9yZy9VQS9ESS8kAAAAaHR0cDovL29wY2ZvdW5kYXRpb24ub3JnL1VBL0ZYL0RhdGEv////" +
           "/xdgiQoCAAAAAQAPAAAAT3V0cHV0VmFyaWFibGVzAQE2GAAvAD82GAAAABEBAAAAAQAAAAAAAAADA///" +
           "//8AAAAA";

        private const string InitializationString =
           "AwAAACIAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvRlgvQUMvHwAAAGh0dHA6Ly9vcGNmb3Vu" +
           "ZGF0aW9uLm9yZy9VQS9ESS8kAAAAaHR0cDovL29wY2ZvdW5kYXRpb24ub3JnL1VBL0ZYL0RhdGEv////" +
           "/wRggAIBAAAAAQAeAAAAQ29ubmVjdGlvbkVuZHBvaW50VHlwZUluc3RhbmNlAQHqAwEB6gPqAwAA////" +
           "/wYAAAAVYIkKAgAAAAEADgAAAENsZWFudXBUaW1lb3V0AQEkBQAvAD8kBQAAAQAiAf////8DA/////8A" +
           "AAAAF2CJCgIAAAABAA4AAABJbnB1dFZhcmlhYmxlcwEBNRgALwA/NRgAAAARAQAAAAEAAAAAAAAAAwP/" +
           "////AAAAABVgiQoCAAAAAQAMAAAASXNQZXJzaXN0ZW50AQEcBQAvAD8cBQAAAAH/////AwP/////AAAA" +
           "ABdgiQoCAAAAAQAPAAAAT3V0cHV0VmFyaWFibGVzAQE2GAAvAD82GAAAABEBAAAAAQAAAAAAAAADA///" +
           "//8AAAAAFWCJCgIAAAABAA8AAABSZWxhdGVkRW5kcG9pbnQBAbUXAC8AP7UXAAABA7sL/////wMD////" +
           "/wAAAAAVYIkKAgAAAAEABgAAAFN0YXR1cwEBFAUALwA/FAUAAAEBvwv/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public BaseDataVariableState<double> CleanupTimeout
        {
            get
            {
                return m_cleanupTimeout;
            }

            set
            {
                if (!Object.ReferenceEquals(m_cleanupTimeout, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_cleanupTimeout = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<NodeId[]> InputVariables
        {
            get
            {
                return m_inputVariables;
            }

            set
            {
                if (!Object.ReferenceEquals(m_inputVariables, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_inputVariables = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<bool> IsPersistent
        {
            get
            {
                return m_isPersistent;
            }

            set
            {
                if (!Object.ReferenceEquals(m_isPersistent, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_isPersistent = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<NodeId[]> OutputVariables
        {
            get
            {
                return m_outputVariables;
            }

            set
            {
                if (!Object.ReferenceEquals(m_outputVariables, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_outputVariables = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<RelatedEndpointDataType> RelatedEndpoint
        {
            get
            {
                return m_relatedEndpoint;
            }

            set
            {
                if (!Object.ReferenceEquals(m_relatedEndpoint, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_relatedEndpoint = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<ConnectionEndpointStatusEnum> Status
        {
            get
            {
                return m_status;
            }

            set
            {
                if (!Object.ReferenceEquals(m_status, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_status = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_cleanupTimeout != null)
            {
                children.Add(m_cleanupTimeout);
            }

            if (m_inputVariables != null)
            {
                children.Add(m_inputVariables);
            }

            if (m_isPersistent != null)
            {
                children.Add(m_isPersistent);
            }

            if (m_outputVariables != null)
            {
                children.Add(m_outputVariables);
            }

            if (m_relatedEndpoint != null)
            {
                children.Add(m_relatedEndpoint);
            }

            if (m_status != null)
            {
                children.Add(m_status);
            }

            base.GetChildren(context, children);
        }
            
        /// <remarks />
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case UAModel.FXAC.BrowseNames.CleanupTimeout:
                {
                    if (createOrReplace)
                    {
                        if (CleanupTimeout == null)
                        {
                            if (replacement == null)
                            {
                                CleanupTimeout = new BaseDataVariableState<double>(this);
                            }
                            else
                            {
                                CleanupTimeout = (BaseDataVariableState<double>)replacement;
                            }
                        }
                    }

                    instance = CleanupTimeout;
                    break;
                }

                case UAModel.FXAC.BrowseNames.InputVariables:
                {
                    if (createOrReplace)
                    {
                        if (InputVariables == null)
                        {
                            if (replacement == null)
                            {
                                InputVariables = new BaseDataVariableState<NodeId[]>(this);
                            }
                            else
                            {
                                InputVariables = (BaseDataVariableState<NodeId[]>)replacement;
                            }
                        }
                    }

                    instance = InputVariables;
                    break;
                }

                case UAModel.FXAC.BrowseNames.IsPersistent:
                {
                    if (createOrReplace)
                    {
                        if (IsPersistent == null)
                        {
                            if (replacement == null)
                            {
                                IsPersistent = new BaseDataVariableState<bool>(this);
                            }
                            else
                            {
                                IsPersistent = (BaseDataVariableState<bool>)replacement;
                            }
                        }
                    }

                    instance = IsPersistent;
                    break;
                }

                case UAModel.FXAC.BrowseNames.OutputVariables:
                {
                    if (createOrReplace)
                    {
                        if (OutputVariables == null)
                        {
                            if (replacement == null)
                            {
                                OutputVariables = new BaseDataVariableState<NodeId[]>(this);
                            }
                            else
                            {
                                OutputVariables = (BaseDataVariableState<NodeId[]>)replacement;
                            }
                        }
                    }

                    instance = OutputVariables;
                    break;
                }

                case UAModel.FXAC.BrowseNames.RelatedEndpoint:
                {
                    if (createOrReplace)
                    {
                        if (RelatedEndpoint == null)
                        {
                            if (replacement == null)
                            {
                                RelatedEndpoint = new BaseDataVariableState<RelatedEndpointDataType>(this);
                            }
                            else
                            {
                                RelatedEndpoint = (BaseDataVariableState<RelatedEndpointDataType>)replacement;
                            }
                        }
                    }

                    instance = RelatedEndpoint;
                    break;
                }

                case UAModel.FXAC.BrowseNames.Status:
                {
                    if (createOrReplace)
                    {
                        if (Status == null)
                        {
                            if (replacement == null)
                            {
                                Status = new BaseDataVariableState<ConnectionEndpointStatusEnum>(this);
                            }
                            else
                            {
                                Status = (BaseDataVariableState<ConnectionEndpointStatusEnum>)replacement;
                            }
                        }
                    }

                    instance = Status;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private BaseDataVariableState<double> m_cleanupTimeout;
        private BaseDataVariableState<NodeId[]> m_inputVariables;
        private BaseDataVariableState<bool> m_isPersistent;
        private BaseDataVariableState<NodeId[]> m_outputVariables;
        private BaseDataVariableState<RelatedEndpointDataType> m_relatedEndpoint;
        private BaseDataVariableState<ConnectionEndpointStatusEnum> m_status;
        #endregion
    }
    #endif
    #endregion

    #region PubSubConnectionEndpointTypeState Class
    #if (!OPCUA_EXCLUDE_PubSubConnectionEndpointTypeState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class PubSubConnectionEndpointTypeState : ConnectionEndpointTypeState
    {
        #region Constructors
        /// <remarks />
        public PubSubConnectionEndpointTypeState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(UAModel.FXAC.ObjectTypes.PubSubConnectionEndpointType, UAModel.FXAC.Namespaces.FXAC, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AwAAACIAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvRlgvQUMvHwAAAGh0dHA6Ly9vcGNmb3Vu" +
           "ZGF0aW9uLm9yZy9VQS9ESS8kAAAAaHR0cDovL29wY2ZvdW5kYXRpb24ub3JnL1VBL0ZYL0RhdGEv////" +
           "/wRggAIBAAAAAQAkAAAAUHViU3ViQ29ubmVjdGlvbkVuZHBvaW50VHlwZUluc3RhbmNlAQHtAwEB7QPt" +
           "AwAA/////wUAAAAVYIkKAgAAAAEADgAAAENsZWFudXBUaW1lb3V0AQEkBQAvAD8kBQAAAQAiAf////8D" +
           "A/////8AAAAAFWCJCgIAAAABAAwAAABJc1BlcnNpc3RlbnQBARwFAC8APxwFAAAAAf////8DA/////8A" +
           "AAAAFWCJCgIAAAABAA8AAABSZWxhdGVkRW5kcG9pbnQBAbUXAC8AP7UXAAABA7sL/////wMD/////wAA" +
           "AAAVYIkKAgAAAAEABgAAAFN0YXR1cwEBFAUALwA/FAUAAAEBvwv/////AQH/////AAAAABVgiQoCAAAA" +
           "AQAEAAAATW9kZQEBSAUALwA/SAUAAAEDHwD/////AwP/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public BaseDataVariableState<PubSubConnectionEndpointModeEnum> Mode
        {
            get
            {
                return m_mode;
            }

            set
            {
                if (!Object.ReferenceEquals(m_mode, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_mode = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_mode != null)
            {
                children.Add(m_mode);
            }

            base.GetChildren(context, children);
        }
            
        /// <remarks />
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case UAModel.FXAC.BrowseNames.Mode:
                {
                    if (createOrReplace)
                    {
                        if (Mode == null)
                        {
                            if (replacement == null)
                            {
                                Mode = new BaseDataVariableState<PubSubConnectionEndpointModeEnum>(this);
                            }
                            else
                            {
                                Mode = (BaseDataVariableState<PubSubConnectionEndpointModeEnum>)replacement;
                            }
                        }
                    }

                    instance = Mode;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private BaseDataVariableState<PubSubConnectionEndpointModeEnum> m_mode;
        #endregion
    }
    #endif
    #endregion

    #region ControlGroupTypeState Class
    #if (!OPCUA_EXCLUDE_ControlGroupTypeState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ControlGroupTypeState : BaseObjectState
    {
        #region Constructors
        /// <remarks />
        public ControlGroupTypeState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(UAModel.FXAC.ObjectTypes.ControlGroupType, UAModel.FXAC.Namespaces.FXAC, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);

            if (EstablishControl != null)
            {
                EstablishControl.Initialize(context, EstablishControl_InitializationString);
            }

            if (ReassignControl != null)
            {
                ReassignControl.Initialize(context, ReassignControl_InitializationString);
            }

            if (ReleaseControl != null)
            {
                ReleaseControl.Initialize(context, ReleaseControl_InitializationString);
            }
        }

        #region Initialization String
        private const string EstablishControl_InitializationString =
           "AwAAACIAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvRlgvQUMvHwAAAGh0dHA6Ly9vcGNmb3Vu" +
           "ZGF0aW9uLm9yZy9VQS9ESS8kAAAAaHR0cDovL29wY2ZvdW5kYXRpb24ub3JnL1VBL0ZYL0RhdGEv////" +
           "/wRhggoEAAAAAQAQAAAARXN0YWJsaXNoQ29udHJvbAEBIgEALwEBIgEiAQAAAQH/////AgAAABdgqQoC" +
           "AAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAc0XAC4ARM0XAACWAQAAAAEAKgEBGgAAAAsAAABMb2NrQ29u" +
           "dGV4dAAM/////wAAAAAAAQAoAQEAAAABAAAAAQAAAAEB/////wAAAAAXYKkKAgAAAAAADwAAAE91dHB1" +
           "dEFyZ3VtZW50cwEBzhcALgBEzhcAAJYBAAAAAQAqAQEZAAAACgAAAExvY2tTdGF0dXMABv////8AAAAA" +
           "AAEAKAEBAAAAAQAAAAEAAAABAf////8AAAAA";

        private const string ReassignControl_InitializationString =
           "AwAAACIAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvRlgvQUMvHwAAAGh0dHA6Ly9vcGNmb3Vu" +
           "ZGF0aW9uLm9yZy9VQS9ESS8kAAAAaHR0cDovL29wY2ZvdW5kYXRpb24ub3JnL1VBL0ZYL0RhdGEv////" +
           "/wRhggoEAAAAAQAPAAAAUmVhc3NpZ25Db250cm9sAQFjGwAvAQFjG2MbAAABAf////8CAAAAF2CpCgIA" +
           "AAAAAA4AAABJbnB1dEFyZ3VtZW50cwEB3hgALgBE3hgAAJYBAAAAAQAqAQEaAAAACwAAAExvY2tDb250" +
           "ZXh0AAz/////AAAAAAABACgBAQAAAAEAAAABAAAAAQH/////AAAAABdgqQoCAAAAAAAPAAAAT3V0cHV0" +
           "QXJndW1lbnRzAQHfGAAuAETfGAAAlgEAAAABACoBARkAAAAKAAAATG9ja1N0YXR1cwAG/////wAAAAAA" +
           "AQAoAQEAAAABAAAAAQAAAAEB/////wAAAAA=";

        private const string ReleaseControl_InitializationString =
           "AwAAACIAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvRlgvQUMvHwAAAGh0dHA6Ly9vcGNmb3Vu" +
           "ZGF0aW9uLm9yZy9VQS9ESS8kAAAAaHR0cDovL29wY2ZvdW5kYXRpb24ub3JnL1VBL0ZYL0RhdGEv////" +
           "/wRhggoEAAAAAQAOAAAAUmVsZWFzZUNvbnRyb2wBAdUFAC8BAdUF1QUAAAEB/////wAAAAA=";

        private const string InitializationString =
           "AwAAACIAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvRlgvQUMvHwAAAGh0dHA6Ly9vcGNmb3Vu" +
           "ZGF0aW9uLm9yZy9VQS9ESS8kAAAAaHR0cDovL29wY2ZvdW5kYXRpb24ub3JnL1VBL0ZYL0RhdGEv////" +
           "/wRggAIBAAAAAQAYAAAAQ29udHJvbEdyb3VwVHlwZUluc3RhbmNlAQEPAAEBDwAPAAAA/////wgAAAAE" +
           "YMAKAQAAAAwAAABDb250cm9sR3JvdXABAA4AAAA8Q29udHJvbEdyb3VwPgEBmhMALwEBDwCaEwAA////" +
           "/wcAAAAEYYIKBAAAAAEAEAAAAEVzdGFibGlzaENvbnRyb2wBASIBAC8BASIBIgEAAAEB/////wIAAAAX" +
           "YKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQHNFwAuAETNFwAAlgEAAAABACoBARoAAAALAAAATG9j" +
           "a0NvbnRleHQADP////8AAAAAAAEAKAEBAAAAAQAAAAEAAAABAf////8AAAAAF2CpCgIAAAAAAA8AAABP" +
           "dXRwdXRBcmd1bWVudHMBAc4XAC4ARM4XAACWAQAAAAEAKgEBGQAAAAoAAABMb2NrU3RhdHVzAAb/////" +
           "AAAAAAABACgBAQAAAAEAAAABAAAAAQH/////AAAAABVgiQoCAAAAAQAMAAAASXNDb250cm9sbGVkAQHJ" +
           "FwAuAETJFwAAAAH/////AwP/////AAAAAARggAoBAAAAAQANAAAATGlzdE9mUmVsYXRlZAEBphMALwA9" +
           "phMAAP////8AAAAABGCACgEAAAABAAsAAABMaXN0VG9CbG9jawEBqRMALwEB8wOpEwAA/////wEAAAAE" +
           "YIAKAQAAAAEABAAAAExvY2sBAaoTAC8BAvQYqhMAAP////8IAAAAFWCJCgIAAAACAAYAAABMb2NrZWQB" +
           "AdkXAC4ARNkXAAAAAf////8BAf////8AAAAAFWCJCgIAAAACAA0AAABMb2NraW5nQ2xpZW50AQHaFwAu" +
           "AETaFwAAAAz/////AQH/////AAAAABVgiQoCAAAAAgALAAAATG9ja2luZ1VzZXIBAdsXAC4ARNsXAAAA" +
           "DP////8BAf////8AAAAAFWCJCgIAAAACABEAAABSZW1haW5pbmdMb2NrVGltZQEB3BcALgBE3BcAAAEA" +
           "IgH/////AQH/////AAAAAARhggoEAAAAAgAIAAAASW5pdExvY2sBAV0bAC8BAvkYXRsAAAEB/////wIA" +
           "AAAXYKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQHXFwAuAETXFwAAlgEAAAABACoBARYAAAAHAAAA" +
           "Q29udGV4dAAM/////wAAAAAAAQAoAQEAAAABAAAAAQAAAAEB/////wAAAAAXYKkKAgAAAAAADwAAAE91" +
           "dHB1dEFyZ3VtZW50cwEB2BcALgBE2BcAAJYBAAAAAQAqAQEdAAAADgAAAEluaXRMb2NrU3RhdHVzAAb/" +
           "////AAAAAAABACgBAQAAAAEAAAABAAAAAQH/////AAAAAARhggoEAAAAAgAJAAAAUmVuZXdMb2NrAQFe" +
           "GwAvAQL8GF4bAAABAf////8BAAAAF2CpCgIAAAAAAA8AAABPdXRwdXRBcmd1bWVudHMBAd0XAC4ARN0X" +
           "AACWAQAAAAEAKgEBHgAAAA8AAABSZW5ld0xvY2tTdGF0dXMABv////8AAAAAAAEAKAEBAAAAAQAAAAEA" +
           "AAABAf////8AAAAABGGCCgQAAAACAAgAAABFeGl0TG9jawEBXBsALwEC/hhcGwAAAQH/////AQAAABdg" +
           "qQoCAAAAAAAPAAAAT3V0cHV0QXJndW1lbnRzAQHWFwAuAETWFwAAlgEAAAABACoBAR0AAAAOAAAARXhp" +
           "dExvY2tTdGF0dXMABv////8AAAAAAAEAKAEBAAAAAQAAAAEAAAABAf////8AAAAABGGCCgQAAAACAAkA" +
           "AABCcmVha0xvY2sBAVsbAC8BAgAZWxsAAAEB/////wEAAAAXYKkKAgAAAAAADwAAAE91dHB1dEFyZ3Vt" +
           "ZW50cwEByhcALgBEyhcAAJYBAAAAAQAqAQEeAAAADwAAAEJyZWFrTG9ja1N0YXR1cwAG/////wAAAAAA" +
           "AQAoAQEAAAABAAAAAQAAAAEB/////wAAAAAEYIAKAQAAAAEADgAAAExpc3RUb1Jlc3RyaWN0AQGsEwAv" +
           "AQHzA6wTAAD/////AQAAAARggAoBAAAAAQAEAAAATG9jawEBrRMALwEC9BitEwAA/////wgAAAAVYIkK" +
           "AgAAAAIABgAAAExvY2tlZAEB4hcALgBE4hcAAAAB/////wEB/////wAAAAAVYIkKAgAAAAIADQAAAExv" +
           "Y2tpbmdDbGllbnQBAeMXAC4AROMXAAAADP////8BAf////8AAAAAFWCJCgIAAAACAAsAAABMb2NraW5n" +
           "VXNlcgEB5BcALgBE5BcAAAAM/////wEB/////wAAAAAVYIkKAgAAAAIAEQAAAFJlbWFpbmluZ0xvY2tU" +
           "aW1lAQHlFwAuAETlFwAAAQAiAf////8BAf////8AAAAABGGCCgQAAAACAAgAAABJbml0TG9jawEBdRsA" +
           "LwEC+Rh1GwAAAQH/////AgAAABdgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAeAXAC4AROAXAACW" +
           "AQAAAAEAKgEBFgAAAAcAAABDb250ZXh0AAz/////AAAAAAABACgBAQAAAAEAAAABAAAAAQH/////AAAA" +
           "ABdgqQoCAAAAAAAPAAAAT3V0cHV0QXJndW1lbnRzAQHhFwAuAEThFwAAlgEAAAABACoBAR0AAAAOAAAA" +
           "SW5pdExvY2tTdGF0dXMABv////8AAAAAAAEAKAEBAAAAAQAAAAEAAAABAf////8AAAAABGGCCgQAAAAC" +
           "AAkAAABSZW5ld0xvY2sBAXYbAC8BAvwYdhsAAAEB/////wEAAAAXYKkKAgAAAAAADwAAAE91dHB1dEFy" +
           "Z3VtZW50cwEB5hcALgBE5hcAAJYBAAAAAQAqAQEeAAAADwAAAFJlbmV3TG9ja1N0YXR1cwAG/////wAA" +
           "AAAAAQAoAQEAAAABAAAAAQAAAAEB/////wAAAAAEYYIKBAAAAAIACAAAAEV4aXRMb2NrAQF0GwAvAQL+" +
           "GHQbAAABAf////8BAAAAF2CpCgIAAAAAAA8AAABPdXRwdXRBcmd1bWVudHMBAd8XAC4ARN8XAACWAQAA" +
           "AAEAKgEBHQAAAA4AAABFeGl0TG9ja1N0YXR1cwAG/////wAAAAAAAQAoAQEAAAABAAAAAQAAAAEB////" +
           "/wAAAAAEYYIKBAAAAAIACQAAAEJyZWFrTG9jawEBcxsALwECABlzGwAAAQH/////AQAAABdgqQoCAAAA" +
           "AAAPAAAAT3V0cHV0QXJndW1lbnRzAQHeFwAuAETeFwAAlgEAAAABACoBAR4AAAAPAAAAQnJlYWtMb2Nr" +
           "U3RhdHVzAAb/////AAAAAAABACgBAQAAAAEAAAABAAAAAQH/////AAAAAARhggoEAAAAAQAPAAAAUmVh" +
           "c3NpZ25Db250cm9sAQFjGwAvAQFjG2MbAAABAf////8CAAAAF2CpCgIAAAAAAA4AAABJbnB1dEFyZ3Vt" +
           "ZW50cwEB3hgALgBE3hgAAJYBAAAAAQAqAQEaAAAACwAAAExvY2tDb250ZXh0AAz/////AAAAAAABACgB" +
           "AQAAAAEAAAABAAAAAQH/////AAAAABdgqQoCAAAAAAAPAAAAT3V0cHV0QXJndW1lbnRzAQHfGAAuAETf" +
           "GAAAlgEAAAABACoBARkAAAAKAAAATG9ja1N0YXR1cwAG/////wAAAAAAAQAoAQEAAAABAAAAAQAAAAEB" +
           "/////wAAAAAEYYIKBAAAAAEADgAAAFJlbGVhc2VDb250cm9sAQHVBQAvAQHVBdUFAAABAf////8AAAAA" +
           "BGGCCgQAAAABABAAAABFc3RhYmxpc2hDb250cm9sAQEiAQAvAQEiASIBAAABAf////8CAAAAF2CpCgIA" +
           "AAAAAA4AAABJbnB1dEFyZ3VtZW50cwEBzRcALgBEzRcAAJYBAAAAAQAqAQEaAAAACwAAAExvY2tDb250" +
           "ZXh0AAz/////AAAAAAABACgBAQAAAAEAAAABAAAAAQH/////AAAAABdgqQoCAAAAAAAPAAAAT3V0cHV0" +
           "QXJndW1lbnRzAQHOFwAuAETOFwAAlgEAAAABACoBARkAAAAKAAAATG9ja1N0YXR1cwAG/////wAAAAAA" +
           "AQAoAQEAAAABAAAAAQAAAAEB/////wAAAAAVYIkKAgAAAAEADAAAAElzQ29udHJvbGxlZAEBzxcALgBE" +
           "zxcAAAAB/////wMD/////wAAAAAEYIAKAQAAAAEADQAAAExpc3RPZlJlbGF0ZWQBAdMTAC8APdMTAAD/" +
           "////AAAAAARggAoBAAAAAQALAAAATGlzdFRvQmxvY2sBAS0EAC8BAfMDLQQAAP////8BAAAABGCACgEA" +
           "AAABAAQAAABMb2NrAQHWEwAvAQL0GNYTAAD/////CAAAABVgiQoCAAAAAgAGAAAATG9ja2VkAQF/GAAu" +
           "AER/GAAAAAH/////AQH/////AAAAABVgiQoCAAAAAgANAAAATG9ja2luZ0NsaWVudAEBgBgALgBEgBgA" +
           "AAAM/////wEB/////wAAAAAVYIkKAgAAAAIACwAAAExvY2tpbmdVc2VyAQGBGAAuAESBGAAAAAz/////" +
           "AQH/////AAAAABVgiQoCAAAAAgARAAAAUmVtYWluaW5nTG9ja1RpbWUBAYIYAC4ARIIYAAABACIB////" +
           "/wEB/////wAAAAAEYYIKBAAAAAIACAAAAEluaXRMb2NrAQFqGwAvAQL5GGobAAABAf////8CAAAAF2Cp" +
           "CgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEBeRgALgBEeRgAAJYBAAAAAQAqAQEWAAAABwAAAENvbnRl" +
           "eHQADP////8AAAAAAAEAKAEBAAAAAQAAAAEAAAABAf////8AAAAAF2CpCgIAAAAAAA8AAABPdXRwdXRB" +
           "cmd1bWVudHMBAXoYAC4ARHoYAACWAQAAAAEAKgEBHQAAAA4AAABJbml0TG9ja1N0YXR1cwAG/////wAA" +
           "AAAAAQAoAQEAAAABAAAAAQAAAAEB/////wAAAAAEYYIKBAAAAAIACQAAAFJlbmV3TG9jawEBaxsALwEC" +
           "/BhrGwAAAQH/////AQAAABdgqQoCAAAAAAAPAAAAT3V0cHV0QXJndW1lbnRzAQGDGAAuAESDGAAAlgEA" +
           "AAABACoBAR4AAAAPAAAAUmVuZXdMb2NrU3RhdHVzAAb/////AAAAAAABACgBAQAAAAEAAAABAAAAAQH/" +
           "////AAAAAARhggoEAAAAAgAIAAAARXhpdExvY2sBAWkbAC8BAv4YaRsAAAEB/////wEAAAAXYKkKAgAA" +
           "AAAADwAAAE91dHB1dEFyZ3VtZW50cwEBeBgALgBEeBgAAJYBAAAAAQAqAQEdAAAADgAAAEV4aXRMb2Nr" +
           "U3RhdHVzAAb/////AAAAAAABACgBAQAAAAEAAAABAAAAAQH/////AAAAAARhggoEAAAAAgAJAAAAQnJl" +
           "YWtMb2NrAQFoGwAvAQIAGWgbAAABAf////8BAAAAF2CpCgIAAAAAAA8AAABPdXRwdXRBcmd1bWVudHMB" +
           "AW0YAC4ARG0YAACWAQAAAAEAKgEBHgAAAA8AAABCcmVha0xvY2tTdGF0dXMABv////8AAAAAAAEAKAEB" +
           "AAAAAQAAAAEAAAABAf////8AAAAABGCACgEAAAABAA4AAABMaXN0VG9SZXN0cmljdAEBLgQALwEB8wMu" +
           "BAAA/////wEAAAAEYIAKAQAAAAEABAAAAExvY2sBAdgTAC8BAvQY2BMAAP////8IAAAAFWCJCgIAAAAC" +
           "AAYAAABMb2NrZWQBAa0YAC4ARK0YAAAAAf////8BAf////8AAAAAFWCJCgIAAAACAA0AAABMb2NraW5n" +
           "Q2xpZW50AQHgGAAuAETgGAAAAAz/////AQH/////AAAAABVgiQoCAAAAAgALAAAATG9ja2luZ1VzZXIB" +
           "AeEYAC4AROEYAAAADP////8BAf////8AAAAAFWCJCgIAAAACABEAAABSZW1haW5pbmdMb2NrVGltZQEB" +
           "4hgALgBE4hgAAAEAIgH/////AQH/////AAAAAARhggoEAAAAAgAIAAAASW5pdExvY2sBAW4bAC8BAvkY" +
           "bhsAAAEB/////wIAAAAXYKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQGpGAAuAESpGAAAlgEAAAAB" +
           "ACoBARYAAAAHAAAAQ29udGV4dAAM/////wAAAAAAAQAoAQEAAAABAAAAAQAAAAEB/////wAAAAAXYKkK" +
           "AgAAAAAADwAAAE91dHB1dEFyZ3VtZW50cwEBqhgALgBEqhgAAJYBAAAAAQAqAQEdAAAADgAAAEluaXRM" +
           "b2NrU3RhdHVzAAb/////AAAAAAABACgBAQAAAAEAAAABAAAAAQH/////AAAAAARhggoEAAAAAgAJAAAA" +
           "UmVuZXdMb2NrAQFvGwAvAQL8GG8bAAABAf////8BAAAAF2CpCgIAAAAAAA8AAABPdXRwdXRBcmd1bWVu" +
           "dHMBAeMYAC4AROMYAACWAQAAAAEAKgEBHgAAAA8AAABSZW5ld0xvY2tTdGF0dXMABv////8AAAAAAAEA" +
           "KAEBAAAAAQAAAAEAAAABAf////8AAAAABGGCCgQAAAACAAgAAABFeGl0TG9jawEBbRsALwEC/hhtGwAA" +
           "AQH/////AQAAABdgqQoCAAAAAAAPAAAAT3V0cHV0QXJndW1lbnRzAQGoGAAuAESoGAAAlgEAAAABACoB" +
           "AR0AAAAOAAAARXhpdExvY2tTdGF0dXMABv////8AAAAAAAEAKAEBAAAAAQAAAAEAAAABAf////8AAAAA" +
           "BGGCCgQAAAACAAkAAABCcmVha0xvY2sBAWwbAC8BAgAZbBsAAAEB/////wEAAAAXYKkKAgAAAAAADwAA" +
           "AE91dHB1dEFyZ3VtZW50cwEBohgALgBEohgAAJYBAAAAAQAqAQEeAAAADwAAAEJyZWFrTG9ja1N0YXR1" +
           "cwAG/////wAAAAAAAQAoAQEAAAABAAAAAQAAAAEB/////wAAAAAEYYIKBAAAAAEADwAAAFJlYXNzaWdu" +
           "Q29udHJvbAEBYxsALwEBYxtjGwAAAQH/////AgAAABdgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMB" +
           "Ad4YAC4ARN4YAACWAQAAAAEAKgEBGgAAAAsAAABMb2NrQ29udGV4dAAM/////wAAAAAAAQAoAQEAAAAB" +
           "AAAAAQAAAAEB/////wAAAAAXYKkKAgAAAAAADwAAAE91dHB1dEFyZ3VtZW50cwEB3xgALgBE3xgAAJYB" +
           "AAAAAQAqAQEZAAAACgAAAExvY2tTdGF0dXMABv////8AAAAAAAEAKAEBAAAAAQAAAAEAAAABAf////8A" +
           "AAAABGGCCgQAAAABAA4AAABSZWxlYXNlQ29udHJvbAEB1QUALwEB1QXVBQAAAQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public EstablishControlMethodState EstablishControl
        {
            get
            {
                return m_establishControlMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_establishControlMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_establishControlMethod = value;
            }
        }

        /// <remarks />
        public PropertyState<bool> IsControlled
        {
            get
            {
                return m_isControlled;
            }

            set
            {
                if (!Object.ReferenceEquals(m_isControlled, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_isControlled = value;
            }
        }

        /// <remarks />
        public FolderState ListOfRelated
        {
            get
            {
                return m_listOfRelated;
            }

            set
            {
                if (!Object.ReferenceEquals(m_listOfRelated, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_listOfRelated = value;
            }
        }

        /// <remarks />
        public ControlItemFolderTypeState ListToBlock
        {
            get
            {
                return m_listToBlock;
            }

            set
            {
                if (!Object.ReferenceEquals(m_listToBlock, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_listToBlock = value;
            }
        }

        /// <remarks />
        public ControlItemFolderTypeState ListToRestrict
        {
            get
            {
                return m_listToRestrict;
            }

            set
            {
                if (!Object.ReferenceEquals(m_listToRestrict, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_listToRestrict = value;
            }
        }

        /// <remarks />
        public ReassignControlMethodState ReassignControl
        {
            get
            {
                return m_reassignControlMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_reassignControlMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_reassignControlMethod = value;
            }
        }

        /// <remarks />
        public MethodState ReleaseControl
        {
            get
            {
                return m_releaseControlMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_releaseControlMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_releaseControlMethod = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_establishControlMethod != null)
            {
                children.Add(m_establishControlMethod);
            }

            if (m_isControlled != null)
            {
                children.Add(m_isControlled);
            }

            if (m_listOfRelated != null)
            {
                children.Add(m_listOfRelated);
            }

            if (m_listToBlock != null)
            {
                children.Add(m_listToBlock);
            }

            if (m_listToRestrict != null)
            {
                children.Add(m_listToRestrict);
            }

            if (m_reassignControlMethod != null)
            {
                children.Add(m_reassignControlMethod);
            }

            if (m_releaseControlMethod != null)
            {
                children.Add(m_releaseControlMethod);
            }

            base.GetChildren(context, children);
        }
            
        /// <remarks />
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case UAModel.FXAC.BrowseNames.EstablishControl:
                {
                    if (createOrReplace)
                    {
                        if (EstablishControl == null)
                        {
                            if (replacement == null)
                            {
                                EstablishControl = new EstablishControlMethodState(this);
                            }
                            else
                            {
                                EstablishControl = (EstablishControlMethodState)replacement;
                            }
                        }
                    }

                    instance = EstablishControl;
                    break;
                }

                case UAModel.FXAC.BrowseNames.IsControlled:
                {
                    if (createOrReplace)
                    {
                        if (IsControlled == null)
                        {
                            if (replacement == null)
                            {
                                IsControlled = new PropertyState<bool>(this);
                            }
                            else
                            {
                                IsControlled = (PropertyState<bool>)replacement;
                            }
                        }
                    }

                    instance = IsControlled;
                    break;
                }

                case UAModel.FXAC.BrowseNames.ListOfRelated:
                {
                    if (createOrReplace)
                    {
                        if (ListOfRelated == null)
                        {
                            if (replacement == null)
                            {
                                ListOfRelated = new FolderState(this);
                            }
                            else
                            {
                                ListOfRelated = (FolderState)replacement;
                            }
                        }
                    }

                    instance = ListOfRelated;
                    break;
                }

                case UAModel.FXAC.BrowseNames.ListToBlock:
                {
                    if (createOrReplace)
                    {
                        if (ListToBlock == null)
                        {
                            if (replacement == null)
                            {
                                ListToBlock = new ControlItemFolderTypeState(this);
                            }
                            else
                            {
                                ListToBlock = (ControlItemFolderTypeState)replacement;
                            }
                        }
                    }

                    instance = ListToBlock;
                    break;
                }

                case UAModel.FXAC.BrowseNames.ListToRestrict:
                {
                    if (createOrReplace)
                    {
                        if (ListToRestrict == null)
                        {
                            if (replacement == null)
                            {
                                ListToRestrict = new ControlItemFolderTypeState(this);
                            }
                            else
                            {
                                ListToRestrict = (ControlItemFolderTypeState)replacement;
                            }
                        }
                    }

                    instance = ListToRestrict;
                    break;
                }

                case UAModel.FXAC.BrowseNames.ReassignControl:
                {
                    if (createOrReplace)
                    {
                        if (ReassignControl == null)
                        {
                            if (replacement == null)
                            {
                                ReassignControl = new ReassignControlMethodState(this);
                            }
                            else
                            {
                                ReassignControl = (ReassignControlMethodState)replacement;
                            }
                        }
                    }

                    instance = ReassignControl;
                    break;
                }

                case UAModel.FXAC.BrowseNames.ReleaseControl:
                {
                    if (createOrReplace)
                    {
                        if (ReleaseControl == null)
                        {
                            if (replacement == null)
                            {
                                ReleaseControl = new MethodState(this);
                            }
                            else
                            {
                                ReleaseControl = (MethodState)replacement;
                            }
                        }
                    }

                    instance = ReleaseControl;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private EstablishControlMethodState m_establishControlMethod;
        private PropertyState<bool> m_isControlled;
        private FolderState m_listOfRelated;
        private ControlItemFolderTypeState m_listToBlock;
        private ControlItemFolderTypeState m_listToRestrict;
        private ReassignControlMethodState m_reassignControlMethod;
        private MethodState m_releaseControlMethod;
        #endregion
    }
    #endif
    #endregion

    #region AutomationComponentCapabilitiesTypeState Class
    #if (!OPCUA_EXCLUDE_AutomationComponentCapabilitiesTypeState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class AutomationComponentCapabilitiesTypeState : FolderState
    {
        #region Constructors
        /// <remarks />
        public AutomationComponentCapabilitiesTypeState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(UAModel.FXAC.ObjectTypes.AutomationComponentCapabilitiesType, UAModel.FXAC.Namespaces.FXAC, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);

            if (CommandBundleRequired != null)
            {
                CommandBundleRequired.Initialize(context, CommandBundleRequired_InitializationString);
            }

            if (MaxConnections != null)
            {
                MaxConnections.Initialize(context, MaxConnections_InitializationString);
            }

            if (MaxConnectionsPerCall != null)
            {
                MaxConnectionsPerCall.Initialize(context, MaxConnectionsPerCall_InitializationString);
            }

            if (MaxFunctionalEntities != null)
            {
                MaxFunctionalEntities.Initialize(context, MaxFunctionalEntities_InitializationString);
            }

            if (SupportsPersistence != null)
            {
                SupportsPersistence.Initialize(context, SupportsPersistence_InitializationString);
            }
        }

        #region Initialization String
        private const string CommandBundleRequired_InitializationString =
           "AwAAACIAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvRlgvQUMvHwAAAGh0dHA6Ly9vcGNmb3Vu" +
           "ZGF0aW9uLm9yZy9VQS9ESS8kAAAAaHR0cDovL29wY2ZvdW5kYXRpb24ub3JnL1VBL0ZYL0RhdGEv////" +
           "/xVgiQoCAAAAAQAVAAAAQ29tbWFuZEJ1bmRsZVJlcXVpcmVkAQG9FwEBog8AP70XAAAAAf////8DA///" +
           "//8AAAAA";

        private const string MaxConnections_InitializationString =
           "AwAAACIAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvRlgvQUMvHwAAAGh0dHA6Ly9vcGNmb3Vu" +
           "ZGF0aW9uLm9yZy9VQS9ESS8kAAAAaHR0cDovL29wY2ZvdW5kYXRpb24ub3JnL1VBL0ZYL0RhdGEv////" +
           "/xVgiQoCAAAAAQAOAAAATWF4Q29ubmVjdGlvbnMBAdYYAQGiDwA/1hgAAAAH/////wMD/////wAAAAA=";

        private const string MaxConnectionsPerCall_InitializationString =
           "AwAAACIAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvRlgvQUMvHwAAAGh0dHA6Ly9vcGNmb3Vu" +
           "ZGF0aW9uLm9yZy9VQS9ESS8kAAAAaHR0cDovL29wY2ZvdW5kYXRpb24ub3JnL1VBL0ZYL0RhdGEv////" +
           "/xVgiQoCAAAAAQAVAAAATWF4Q29ubmVjdGlvbnNQZXJDYWxsAQG8FwEBog8AP7wXAAAAB/////8DA///" +
           "//8AAAAA";

        private const string MaxFunctionalEntities_InitializationString =
           "AwAAACIAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvRlgvQUMvHwAAAGh0dHA6Ly9vcGNmb3Vu" +
           "ZGF0aW9uLm9yZy9VQS9ESS8kAAAAaHR0cDovL29wY2ZvdW5kYXRpb24ub3JnL1VBL0ZYL0RhdGEv////" +
           "/xVgiQoCAAAAAQAVAAAATWF4RnVuY3Rpb25hbEVudGl0aWVzAQHVGAEBog8AP9UYAAAAB/////8DA///" +
           "//8AAAAA";

        private const string SupportsPersistence_InitializationString =
           "AwAAACIAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvRlgvQUMvHwAAAGh0dHA6Ly9vcGNmb3Vu" +
           "ZGF0aW9uLm9yZy9VQS9ESS8kAAAAaHR0cDovL29wY2ZvdW5kYXRpb24ub3JnL1VBL0ZYL0RhdGEv////" +
           "/xVgiQoCAAAAAQATAAAAU3VwcG9ydHNQZXJzaXN0ZW5jZQEB1BgBAaIPAD/UGAAAAAH/////AwP/////" +
           "AAAAAA==";

        private const string InitializationString =
           "AwAAACIAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvRlgvQUMvHwAAAGh0dHA6Ly9vcGNmb3Vu" +
           "ZGF0aW9uLm9yZy9VQS9ESS8kAAAAaHR0cDovL29wY2ZvdW5kYXRpb24ub3JnL1VBL0ZYL0RhdGEv////" +
           "/wRggAIBAAAAAQArAAAAQXV0b21hdGlvbkNvbXBvbmVudENhcGFiaWxpdGllc1R5cGVJbnN0YW5jZQEB" +
           "6QMBAekD6QMAAP////8GAAAAFWDJCgIAAAAKAAAAQ2FwYWJpbGl0eQEADAAAADxDYXBhYmlsaXR5PgEB" +
           "4QQBAaIPAD/hBAAAABj/////AwP/////AAAAABVgiQoCAAAAAQAVAAAAQ29tbWFuZEJ1bmRsZVJlcXVp" +
           "cmVkAQG9FwEBog8AP70XAAAAAf////8DA/////8AAAAAFWCJCgIAAAABAA4AAABNYXhDb25uZWN0aW9u" +
           "cwEB1hgBAaIPAD/WGAAAAAf/////AwP/////AAAAABVgiQoCAAAAAQAVAAAATWF4Q29ubmVjdGlvbnNQ" +
           "ZXJDYWxsAQG8FwEBog8AP7wXAAAAB/////8DA/////8AAAAAFWCJCgIAAAABABUAAABNYXhGdW5jdGlv" +
           "bmFsRW50aXRpZXMBAdUYAQGiDwA/1RgAAAAH/////wMD/////wAAAAAVYIkKAgAAAAEAEwAAAFN1cHBv" +
           "cnRzUGVyc2lzdGVuY2UBAdQYAQGiDwA/1BgAAAAB/////wMD/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public BaseDataVariableState<bool> CommandBundleRequired
        {
            get
            {
                return m_commandBundleRequired;
            }

            set
            {
                if (!Object.ReferenceEquals(m_commandBundleRequired, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_commandBundleRequired = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<uint> MaxConnections
        {
            get
            {
                return m_maxConnections;
            }

            set
            {
                if (!Object.ReferenceEquals(m_maxConnections, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_maxConnections = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<uint> MaxConnectionsPerCall
        {
            get
            {
                return m_maxConnectionsPerCall;
            }

            set
            {
                if (!Object.ReferenceEquals(m_maxConnectionsPerCall, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_maxConnectionsPerCall = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<uint> MaxFunctionalEntities
        {
            get
            {
                return m_maxFunctionalEntities;
            }

            set
            {
                if (!Object.ReferenceEquals(m_maxFunctionalEntities, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_maxFunctionalEntities = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<bool> SupportsPersistence
        {
            get
            {
                return m_supportsPersistence;
            }

            set
            {
                if (!Object.ReferenceEquals(m_supportsPersistence, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_supportsPersistence = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_commandBundleRequired != null)
            {
                children.Add(m_commandBundleRequired);
            }

            if (m_maxConnections != null)
            {
                children.Add(m_maxConnections);
            }

            if (m_maxConnectionsPerCall != null)
            {
                children.Add(m_maxConnectionsPerCall);
            }

            if (m_maxFunctionalEntities != null)
            {
                children.Add(m_maxFunctionalEntities);
            }

            if (m_supportsPersistence != null)
            {
                children.Add(m_supportsPersistence);
            }

            base.GetChildren(context, children);
        }
            
        /// <remarks />
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case UAModel.FXAC.BrowseNames.CommandBundleRequired:
                {
                    if (createOrReplace)
                    {
                        if (CommandBundleRequired == null)
                        {
                            if (replacement == null)
                            {
                                CommandBundleRequired = new BaseDataVariableState<bool>(this);
                            }
                            else
                            {
                                CommandBundleRequired = (BaseDataVariableState<bool>)replacement;
                            }
                        }
                    }

                    instance = CommandBundleRequired;
                    break;
                }

                case UAModel.FXAC.BrowseNames.MaxConnections:
                {
                    if (createOrReplace)
                    {
                        if (MaxConnections == null)
                        {
                            if (replacement == null)
                            {
                                MaxConnections = new BaseDataVariableState<uint>(this);
                            }
                            else
                            {
                                MaxConnections = (BaseDataVariableState<uint>)replacement;
                            }
                        }
                    }

                    instance = MaxConnections;
                    break;
                }

                case UAModel.FXAC.BrowseNames.MaxConnectionsPerCall:
                {
                    if (createOrReplace)
                    {
                        if (MaxConnectionsPerCall == null)
                        {
                            if (replacement == null)
                            {
                                MaxConnectionsPerCall = new BaseDataVariableState<uint>(this);
                            }
                            else
                            {
                                MaxConnectionsPerCall = (BaseDataVariableState<uint>)replacement;
                            }
                        }
                    }

                    instance = MaxConnectionsPerCall;
                    break;
                }

                case UAModel.FXAC.BrowseNames.MaxFunctionalEntities:
                {
                    if (createOrReplace)
                    {
                        if (MaxFunctionalEntities == null)
                        {
                            if (replacement == null)
                            {
                                MaxFunctionalEntities = new BaseDataVariableState<uint>(this);
                            }
                            else
                            {
                                MaxFunctionalEntities = (BaseDataVariableState<uint>)replacement;
                            }
                        }
                    }

                    instance = MaxFunctionalEntities;
                    break;
                }

                case UAModel.FXAC.BrowseNames.SupportsPersistence:
                {
                    if (createOrReplace)
                    {
                        if (SupportsPersistence == null)
                        {
                            if (replacement == null)
                            {
                                SupportsPersistence = new BaseDataVariableState<bool>(this);
                            }
                            else
                            {
                                SupportsPersistence = (BaseDataVariableState<bool>)replacement;
                            }
                        }
                    }

                    instance = SupportsPersistence;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private BaseDataVariableState<bool> m_commandBundleRequired;
        private BaseDataVariableState<uint> m_maxConnections;
        private BaseDataVariableState<uint> m_maxConnectionsPerCall;
        private BaseDataVariableState<uint> m_maxFunctionalEntities;
        private BaseDataVariableState<bool> m_supportsPersistence;
        #endregion
    }
    #endif
    #endregion

    #region ConnectionEndpointsFolderTypeState Class
    #if (!OPCUA_EXCLUDE_ConnectionEndpointsFolderTypeState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ConnectionEndpointsFolderTypeState : FolderState
    {
        #region Constructors
        /// <remarks />
        public ConnectionEndpointsFolderTypeState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(UAModel.FXAC.ObjectTypes.ConnectionEndpointsFolderType, UAModel.FXAC.Namespaces.FXAC, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);

            if (CommHealth != null)
            {
                CommHealth.Initialize(context, CommHealth_InitializationString);
            }
        }

        #region Initialization String
        private const string CommHealth_InitializationString =
           "AwAAACIAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvRlgvQUMvHwAAAGh0dHA6Ly9vcGNmb3Vu" +
           "ZGF0aW9uLm9yZy9VQS9ESS8kAAAAaHR0cDovL29wY2ZvdW5kYXRpb24ub3JnL1VBL0ZYL0RhdGEv////" +
           "/xVgiQoCAAAAAQAKAAAAQ29tbUhlYWx0aAEB0BcALwA/0BcAAAEBvAv/////AQH/////AAAAAA==";

        private const string InitializationString =
           "AwAAACIAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvRlgvQUMvHwAAAGh0dHA6Ly9vcGNmb3Vu" +
           "ZGF0aW9uLm9yZy9VQS9ESS8kAAAAaHR0cDovL29wY2ZvdW5kYXRpb24ub3JnL1VBL0ZYL0RhdGEv////" +
           "/wRggAIBAAAAAQAlAAAAQ29ubmVjdGlvbkVuZHBvaW50c0ZvbGRlclR5cGVJbnN0YW5jZQEBFAABARQA" +
           "FAAAAP////8CAAAABGDACgEAAAASAAAAQ29ubmVjdGlvbkVuZHBvaW50AQAUAAAAPENvbm5lY3Rpb25F" +
           "bmRwb2ludD4BATUEAQEpAAEB6gM1BAAA/////wQAAAAVYIkKAgAAAAEADgAAAENsZWFudXBUaW1lb3V0" +
           "AQG5FwAvAD+5FwAAAQAiAf////8DA/////8AAAAAFWCJCgIAAAABAAwAAABJc1BlcnNpc3RlbnQBAR0F" +
           "AC8APx0FAAAAAf////8DA/////8AAAAAFWCJCgIAAAABAA8AAABSZWxhdGVkRW5kcG9pbnQBAcwXAC8A" +
           "P8wXAAABA7sL/////wMD/////wAAAAAVYIkKAgAAAAEABgAAAFN0YXR1cwEBMwUALwA/MwUAAAEBvwv/" +
           "////AQH/////AAAAABVgiQoCAAAAAQAKAAAAQ29tbUhlYWx0aAEB0BcALwA/0BcAAAEBvAv/////AQH/" +
           "////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public BaseDataVariableState<ushort> CommHealth
        {
            get
            {
                return m_commHealth;
            }

            set
            {
                if (!Object.ReferenceEquals(m_commHealth, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_commHealth = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_commHealth != null)
            {
                children.Add(m_commHealth);
            }

            base.GetChildren(context, children);
        }
            
        /// <remarks />
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case UAModel.FXAC.BrowseNames.CommHealth:
                {
                    if (createOrReplace)
                    {
                        if (CommHealth == null)
                        {
                            if (replacement == null)
                            {
                                CommHealth = new BaseDataVariableState<ushort>(this);
                            }
                            else
                            {
                                CommHealth = (BaseDataVariableState<ushort>)replacement;
                            }
                        }
                    }

                    instance = CommHealth;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private BaseDataVariableState<ushort> m_commHealth;
        #endregion
    }
    #endif
    #endregion

    #region ControlGroupsFolderTypeState Class
    #if (!OPCUA_EXCLUDE_ControlGroupsFolderTypeState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ControlGroupsFolderTypeState : FolderState
    {
        #region Constructors
        /// <remarks />
        public ControlGroupsFolderTypeState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(UAModel.FXAC.ObjectTypes.ControlGroupsFolderType, UAModel.FXAC.Namespaces.FXAC, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AwAAACIAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvRlgvQUMvHwAAAGh0dHA6Ly9vcGNmb3Vu" +
           "ZGF0aW9uLm9yZy9VQS9ESS8kAAAAaHR0cDovL29wY2ZvdW5kYXRpb24ub3JnL1VBL0ZYL0RhdGEv////" +
           "/wRggAIBAAAAAQAfAAAAQ29udHJvbEdyb3Vwc0ZvbGRlclR5cGVJbnN0YW5jZQEB8gMBAfID8gMAAP//" +
           "//8BAAAABGDACgEAAAAMAAAAQ29udHJvbEdyb3VwAQAOAAAAPENvbnRyb2xHcm91cD4BATIEAQEsAAEB" +
           "DwAyBAAA/////wQAAAAVYIkKAgAAAAEADAAAAElzQ29udHJvbGxlZAEB3RgALgBE3RgAAAAB/////wMD" +
           "/////wAAAAAEYIAKAQAAAAEADQAAAExpc3RPZlJlbGF0ZWQBAdUTAC8APdUTAAD/////AAAAAARggAoB" +
           "AAAAAQALAAAATGlzdFRvQmxvY2sBATkEAC8BAfMDOQQAAP////8BAAAABGCACgEAAAABAAQAAABMb2Nr" +
           "AQHrEwAvAQL0GOsTAAD/////CAAAABVgiQoCAAAAAgAGAAAATG9ja2VkAQE9GQAuAEQ9GQAAAAH/////" +
           "AQH/////AAAAABVgiQoCAAAAAgANAAAATG9ja2luZ0NsaWVudAEBPhkALgBEPhkAAAAM/////wEB////" +
           "/wAAAAAVYIkKAgAAAAIACwAAAExvY2tpbmdVc2VyAQE/GQAuAEQ/GQAAAAz/////AQH/////AAAAABVg" +
           "iQoCAAAAAgARAAAAUmVtYWluaW5nTG9ja1RpbWUBAUAZAC4AREAZAAABACIB/////wEB/////wAAAAAE" +
           "YYIKBAAAAAIACAAAAEluaXRMb2NrAQGPGwAvAQL5GI8bAAABAf////8CAAAAF2CpCgIAAAAAAA4AAABJ" +
           "bnB1dEFyZ3VtZW50cwEBOxkALgBEOxkAAJYBAAAAAQAqAQEWAAAABwAAAENvbnRleHQADP////8AAAAA" +
           "AAEAKAEBAAAAAQAAAAEAAAABAf////8AAAAAF2CpCgIAAAAAAA8AAABPdXRwdXRBcmd1bWVudHMBATwZ" +
           "AC4ARDwZAACWAQAAAAEAKgEBHQAAAA4AAABJbml0TG9ja1N0YXR1cwAG/////wAAAAAAAQAoAQEAAAAB" +
           "AAAAAQAAAAEB/////wAAAAAEYYIKBAAAAAIACQAAAFJlbmV3TG9jawEBkBsALwEC/BiQGwAAAQH/////" +
           "AQAAABdgqQoCAAAAAAAPAAAAT3V0cHV0QXJndW1lbnRzAQFBGQAuAERBGQAAlgEAAAABACoBAR4AAAAP" +
           "AAAAUmVuZXdMb2NrU3RhdHVzAAb/////AAAAAAABACgBAQAAAAEAAAABAAAAAQH/////AAAAAARhggoE" +
           "AAAAAgAIAAAARXhpdExvY2sBAY4bAC8BAv4YjhsAAAEB/////wEAAAAXYKkKAgAAAAAADwAAAE91dHB1" +
           "dEFyZ3VtZW50cwEBOhkALgBEOhkAAJYBAAAAAQAqAQEdAAAADgAAAEV4aXRMb2NrU3RhdHVzAAb/////" +
           "AAAAAAABACgBAQAAAAEAAAABAAAAAQH/////AAAAAARhggoEAAAAAgAJAAAAQnJlYWtMb2NrAQGNGwAv" +
           "AQIAGY0bAAABAf////8BAAAAF2CpCgIAAAAAAA8AAABPdXRwdXRBcmd1bWVudHMBATkZAC4ARDkZAACW" +
           "AQAAAAEAKgEBHgAAAA8AAABCcmVha0xvY2tTdGF0dXMABv////8AAAAAAAEAKAEBAAAAAQAAAAEAAAAB" +
           "Af////8AAAAABGCACgEAAAABAA4AAABMaXN0VG9SZXN0cmljdAEBOgQALwEB8wM6BAAA/////wEAAAAE" +
           "YIAKAQAAAAEABAAAAExvY2sBAe8TAC8BAvQY7xMAAP////8IAAAAFWCJCgIAAAACAAYAAABMb2NrZWQB" +
           "AUYZAC4AREYZAAAAAf////8BAf////8AAAAAFWCJCgIAAAACAA0AAABMb2NraW5nQ2xpZW50AQFHGQAu" +
           "AERHGQAAAAz/////AQH/////AAAAABVgiQoCAAAAAgALAAAATG9ja2luZ1VzZXIBAUgZAC4AREgZAAAA" +
           "DP////8BAf////8AAAAAFWCJCgIAAAACABEAAABSZW1haW5pbmdMb2NrVGltZQEBSRkALgBESRkAAAEA" +
           "IgH/////AQH/////AAAAAARhggoEAAAAAgAIAAAASW5pdExvY2sBAZMbAC8BAvkYkxsAAAEB/////wIA" +
           "AAAXYKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQFEGQAuAEREGQAAlgEAAAABACoBARYAAAAHAAAA" +
           "Q29udGV4dAAM/////wAAAAAAAQAoAQEAAAABAAAAAQAAAAEB/////wAAAAAXYKkKAgAAAAAADwAAAE91" +
           "dHB1dEFyZ3VtZW50cwEBRRkALgBERRkAAJYBAAAAAQAqAQEdAAAADgAAAEluaXRMb2NrU3RhdHVzAAb/" +
           "////AAAAAAABACgBAQAAAAEAAAABAAAAAQH/////AAAAAARhggoEAAAAAgAJAAAAUmVuZXdMb2NrAQGU" +
           "GwAvAQL8GJQbAAABAf////8BAAAAF2CpCgIAAAAAAA8AAABPdXRwdXRBcmd1bWVudHMBAUoZAC4AREoZ" +
           "AACWAQAAAAEAKgEBHgAAAA8AAABSZW5ld0xvY2tTdGF0dXMABv////8AAAAAAAEAKAEBAAAAAQAAAAEA" +
           "AAABAf////8AAAAABGGCCgQAAAACAAgAAABFeGl0TG9jawEBkhsALwEC/hiSGwAAAQH/////AQAAABdg" +
           "qQoCAAAAAAAPAAAAT3V0cHV0QXJndW1lbnRzAQFDGQAuAERDGQAAlgEAAAABACoBAR0AAAAOAAAARXhp" +
           "dExvY2tTdGF0dXMABv////8AAAAAAAEAKAEBAAAAAQAAAAEAAAABAf////8AAAAABGGCCgQAAAACAAkA" +
           "AABCcmVha0xvY2sBAZEbAC8BAgAZkRsAAAEB/////wEAAAAXYKkKAgAAAAAADwAAAE91dHB1dEFyZ3Vt" +
           "ZW50cwEBQhkALgBEQhkAAJYBAAAAAQAqAQEeAAAADwAAAEJyZWFrTG9ja1N0YXR1cwAG/////wAAAAAA" +
           "AQAoAQEAAAABAAAAAQAAAAEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region FunctionalEntityCapabilitiesTypeState Class
    #if (!OPCUA_EXCLUDE_FunctionalEntityCapabilitiesTypeState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class FunctionalEntityCapabilitiesTypeState : FolderState
    {
        #region Constructors
        /// <remarks />
        public FunctionalEntityCapabilitiesTypeState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(UAModel.FXAC.ObjectTypes.FunctionalEntityCapabilitiesType, UAModel.FXAC.Namespaces.FXAC, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);

            if (FeedbackSignalRequired != null)
            {
                FeedbackSignalRequired.Initialize(context, FeedbackSignalRequired_InitializationString);
            }
        }

        #region Initialization String
        private const string FeedbackSignalRequired_InitializationString =
           "AwAAACIAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvRlgvQUMvHwAAAGh0dHA6Ly9vcGNmb3Vu" +
           "ZGF0aW9uLm9yZy9VQS9ESS8kAAAAaHR0cDovL29wY2ZvdW5kYXRpb24ub3JnL1VBL0ZYL0RhdGEv////" +
           "/xVgiQoCAAAAAQAWAAAARmVlZGJhY2tTaWduYWxSZXF1aXJlZAEB5xcBAaIPAD/nFwAAAAH/////AwP/" +
           "////AAAAAA==";

        private const string InitializationString =
           "AwAAACIAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvRlgvQUMvHwAAAGh0dHA6Ly9vcGNmb3Vu" +
           "ZGF0aW9uLm9yZy9VQS9ESS8kAAAAaHR0cDovL29wY2ZvdW5kYXRpb24ub3JnL1VBL0ZYL0RhdGEv////" +
           "/wRggAIBAAAAAQAoAAAARnVuY3Rpb25hbEVudGl0eUNhcGFiaWxpdGllc1R5cGVJbnN0YW5jZQEB8AMB" +
           "AfAD8AMAAP////8CAAAAFWDJCgIAAAAKAAAAQ2FwYWJpbGl0eQEADAAAADxDYXBhYmlsaXR5PgEB6BcB" +
           "AaIPAD/oFwAAABj/////AwP/////AAAAABVgiQoCAAAAAQAWAAAARmVlZGJhY2tTaWduYWxSZXF1aXJl" +
           "ZAEB5xcBAaIPAD/nFwAAAAH/////AwP/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public BaseDataVariableState<bool> FeedbackSignalRequired
        {
            get
            {
                return m_feedbackSignalRequired;
            }

            set
            {
                if (!Object.ReferenceEquals(m_feedbackSignalRequired, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_feedbackSignalRequired = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_feedbackSignalRequired != null)
            {
                children.Add(m_feedbackSignalRequired);
            }

            base.GetChildren(context, children);
        }
            
        /// <remarks />
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case UAModel.FXAC.BrowseNames.FeedbackSignalRequired:
                {
                    if (createOrReplace)
                    {
                        if (FeedbackSignalRequired == null)
                        {
                            if (replacement == null)
                            {
                                FeedbackSignalRequired = new BaseDataVariableState<bool>(this);
                            }
                            else
                            {
                                FeedbackSignalRequired = (BaseDataVariableState<bool>)replacement;
                            }
                        }
                    }

                    instance = FeedbackSignalRequired;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private BaseDataVariableState<bool> m_feedbackSignalRequired;
        #endregion
    }
    #endif
    #endregion

    #region ConfigurationDataFolderTypeState Class
    #if (!OPCUA_EXCLUDE_ConfigurationDataFolderTypeState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ConfigurationDataFolderTypeState : FunctionalGroupTypeState
    {
        #region Constructors
        /// <remarks />
        public ConfigurationDataFolderTypeState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(UAModel.FXAC.ObjectTypes.ConfigurationDataFolderType, UAModel.FXAC.Namespaces.FXAC, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);

            if (ClearStoredVariables != null)
            {
                ClearStoredVariables.Initialize(context, ClearStoredVariables_InitializationString);
            }

            if (ListStoredVariables != null)
            {
                ListStoredVariables.Initialize(context, ListStoredVariables_InitializationString);
            }

            if (SetStoredVariables != null)
            {
                SetStoredVariables.Initialize(context, SetStoredVariables_InitializationString);
            }
        }

        #region Initialization String
        private const string ClearStoredVariables_InitializationString =
           "AwAAACIAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvRlgvQUMvHwAAAGh0dHA6Ly9vcGNmb3Vu" +
           "ZGF0aW9uLm9yZy9VQS9ESS8kAAAAaHR0cDovL29wY2ZvdW5kYXRpb24ub3JnL1VBL0ZYL0RhdGEv////" +
           "/wRhggoEAAAAAQAUAAAAQ2xlYXJTdG9yZWRWYXJpYWJsZXMBAXEbAC8BAXEbcRsAAAEB/////wIAAAAX" +
           "YKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQH+GAAuAET+GAAAlgEAAAABACoBASMAAAAQAAAAVmFy" +
           "aWFibGVzVG9DbGVhcgARAQAAAAEAAAAAAAAAAAEAKAEBAAAAAQAAAAEAAAABAf////8AAAAAF2CpCgIA" +
           "AAAAAA8AAABPdXRwdXRBcmd1bWVudHMBAf8YAC4ARP8YAACWAQAAAAEAKgEBGgAAAAcAAABSZXN1bHRz" +
           "ABMBAAAAAQAAAAAAAAAAAQAoAQEAAAABAAAAAQAAAAEB/////wAAAAA=";

        private const string ListStoredVariables_InitializationString =
           "AwAAACIAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvRlgvQUMvHwAAAGh0dHA6Ly9vcGNmb3Vu" +
           "ZGF0aW9uLm9yZy9VQS9ESS8kAAAAaHR0cDovL29wY2ZvdW5kYXRpb24ub3JnL1VBL0ZYL0RhdGEv////" +
           "/wRhggoEAAAAAQATAAAATGlzdFN0b3JlZFZhcmlhYmxlcwEBchsALwEBchtyGwAAAQH/////AQAAABdg" +
           "qQoCAAAAAAAPAAAAT3V0cHV0QXJndW1lbnRzAQEBGQAuAEQBGQAAlgEAAAABACoBASQAAAAPAAAAU3Rv" +
           "cmVkVmFyaWFibGVzAQMEBAEAAAABAAAAAAAAAAABACgBAQAAAAEAAAABAAAAAQH/////AAAAAA==";

        private const string SetStoredVariables_InitializationString =
           "AwAAACIAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvRlgvQUMvHwAAAGh0dHA6Ly9vcGNmb3Vu" +
           "ZGF0aW9uLm9yZy9VQS9ESS8kAAAAaHR0cDovL29wY2ZvdW5kYXRpb24ub3JnL1VBL0ZYL0RhdGEv////" +
           "/wRhggoEAAAAAQASAAAAU2V0U3RvcmVkVmFyaWFibGVzAQFwGwAvAQFwG3AbAAABAf////8CAAAAF2Cp" +
           "CgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEB/BgALgBE/BgAAJYBAAAAAQAqAQEjAAAAEAAAAFZhcmlh" +
           "Ymxlc1RvU3RvcmUAEQEAAAABAAAAAAAAAAABACgBAQAAAAEAAAABAAAAAQH/////AAAAABdgqQoCAAAA" +
           "AAAPAAAAT3V0cHV0QXJndW1lbnRzAQH9GAAuAET9GAAAlgEAAAABACoBARoAAAAHAAAAUmVzdWx0cwAT" +
           "AQAAAAEAAAAAAAAAAAEAKAEBAAAAAQAAAAEAAAABAf////8AAAAA";

        private const string InitializationString =
           "AwAAACIAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvRlgvQUMvHwAAAGh0dHA6Ly9vcGNmb3Vu" +
           "ZGF0aW9uLm9yZy9VQS9ESS8kAAAAaHR0cDovL29wY2ZvdW5kYXRpb24ub3JnL1VBL0ZYL0RhdGEv////" +
           "/wRggAIBAAAAAQAjAAAAQ29uZmlndXJhdGlvbkRhdGFGb2xkZXJUeXBlSW5zdGFuY2UBAREEAQERBBEE" +
           "AAD/////BAAAABVgyQoCAAAAFQAAAENvbmZpZ3VyYXRpb25WYXJpYWJsZQEAFwAAADxDb25maWd1cmF0" +
           "aW9uVmFyaWFibGU+AQGhFwAjAD+hFwAAABj/////AwP/////AAAAAARhggoEAAAAAQAUAAAAQ2xlYXJT" +
           "dG9yZWRWYXJpYWJsZXMBAXEbAC8BAXEbcRsAAAEB/////wIAAAAXYKkKAgAAAAAADgAAAElucHV0QXJn" +
           "dW1lbnRzAQH+GAAuAET+GAAAlgEAAAABACoBASMAAAAQAAAAVmFyaWFibGVzVG9DbGVhcgARAQAAAAEA" +
           "AAAAAAAAAAEAKAEBAAAAAQAAAAEAAAABAf////8AAAAAF2CpCgIAAAAAAA8AAABPdXRwdXRBcmd1bWVu" +
           "dHMBAf8YAC4ARP8YAACWAQAAAAEAKgEBGgAAAAcAAABSZXN1bHRzABMBAAAAAQAAAAAAAAAAAQAoAQEA" +
           "AAABAAAAAQAAAAEB/////wAAAAAEYYIKBAAAAAEAEwAAAExpc3RTdG9yZWRWYXJpYWJsZXMBAXIbAC8B" +
           "AXIbchsAAAEB/////wEAAAAXYKkKAgAAAAAADwAAAE91dHB1dEFyZ3VtZW50cwEBARkALgBEARkAAJYB" +
           "AAAAAQAqAQEkAAAADwAAAFN0b3JlZFZhcmlhYmxlcwEDBAQBAAAAAQAAAAAAAAAAAQAoAQEAAAABAAAA" +
           "AQAAAAEB/////wAAAAAEYYIKBAAAAAEAEgAAAFNldFN0b3JlZFZhcmlhYmxlcwEBcBsALwEBcBtwGwAA" +
           "AQH/////AgAAABdgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAfwYAC4ARPwYAACWAQAAAAEAKgEB" +
           "IwAAABAAAABWYXJpYWJsZXNUb1N0b3JlABEBAAAAAQAAAAAAAAAAAQAoAQEAAAABAAAAAQAAAAEB////" +
           "/wAAAAAXYKkKAgAAAAAADwAAAE91dHB1dEFyZ3VtZW50cwEB/RgALgBE/RgAAJYBAAAAAQAqAQEaAAAA" +
           "BwAAAFJlc3VsdHMAEwEAAAABAAAAAAAAAAABACgBAQAAAAEAAAABAAAAAQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public ClearStoredVariablesMethodState ClearStoredVariables
        {
            get
            {
                return m_clearStoredVariablesMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_clearStoredVariablesMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_clearStoredVariablesMethod = value;
            }
        }

        /// <remarks />
        public ListStoredVariablesMethodState ListStoredVariables
        {
            get
            {
                return m_listStoredVariablesMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_listStoredVariablesMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_listStoredVariablesMethod = value;
            }
        }

        /// <remarks />
        public SetStoredVariablesMethodState SetStoredVariables
        {
            get
            {
                return m_setStoredVariablesMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_setStoredVariablesMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_setStoredVariablesMethod = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_clearStoredVariablesMethod != null)
            {
                children.Add(m_clearStoredVariablesMethod);
            }

            if (m_listStoredVariablesMethod != null)
            {
                children.Add(m_listStoredVariablesMethod);
            }

            if (m_setStoredVariablesMethod != null)
            {
                children.Add(m_setStoredVariablesMethod);
            }

            base.GetChildren(context, children);
        }
            
        /// <remarks />
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case UAModel.FXAC.BrowseNames.ClearStoredVariables:
                {
                    if (createOrReplace)
                    {
                        if (ClearStoredVariables == null)
                        {
                            if (replacement == null)
                            {
                                ClearStoredVariables = new ClearStoredVariablesMethodState(this);
                            }
                            else
                            {
                                ClearStoredVariables = (ClearStoredVariablesMethodState)replacement;
                            }
                        }
                    }

                    instance = ClearStoredVariables;
                    break;
                }

                case UAModel.FXAC.BrowseNames.ListStoredVariables:
                {
                    if (createOrReplace)
                    {
                        if (ListStoredVariables == null)
                        {
                            if (replacement == null)
                            {
                                ListStoredVariables = new ListStoredVariablesMethodState(this);
                            }
                            else
                            {
                                ListStoredVariables = (ListStoredVariablesMethodState)replacement;
                            }
                        }
                    }

                    instance = ListStoredVariables;
                    break;
                }

                case UAModel.FXAC.BrowseNames.SetStoredVariables:
                {
                    if (createOrReplace)
                    {
                        if (SetStoredVariables == null)
                        {
                            if (replacement == null)
                            {
                                SetStoredVariables = new SetStoredVariablesMethodState(this);
                            }
                            else
                            {
                                SetStoredVariables = (SetStoredVariablesMethodState)replacement;
                            }
                        }
                    }

                    instance = SetStoredVariables;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private ClearStoredVariablesMethodState m_clearStoredVariablesMethod;
        private ListStoredVariablesMethodState m_listStoredVariablesMethod;
        private SetStoredVariablesMethodState m_setStoredVariablesMethod;
        #endregion
    }
    #endif
    #endregion

    #region ControlItemFolderTypeState Class
    #if (!OPCUA_EXCLUDE_ControlItemFolderTypeState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ControlItemFolderTypeState : FunctionalGroupTypeState
    {
        #region Constructors
        /// <remarks />
        public ControlItemFolderTypeState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(UAModel.FXAC.ObjectTypes.ControlItemFolderType, UAModel.FXAC.Namespaces.FXAC, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);

            if (MaxInactiveLockTime != null)
            {
                MaxInactiveLockTime.Initialize(context, MaxInactiveLockTime_InitializationString);
            }
        }

        #region Initialization String
        private const string MaxInactiveLockTime_InitializationString =
           "AwAAACIAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvRlgvQUMvHwAAAGh0dHA6Ly9vcGNmb3Vu" +
           "ZGF0aW9uLm9yZy9VQS9ESS8kAAAAaHR0cDovL29wY2ZvdW5kYXRpb24ub3JnL1VBL0ZYL0RhdGEv////" +
           "/xVgiQoCAAAAAQATAAAATWF4SW5hY3RpdmVMb2NrVGltZQEBVRkALgBEVRkAAAEAIgH/////AwP/////" +
           "AAAAAA==";

        private const string InitializationString =
           "AwAAACIAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvRlgvQUMvHwAAAGh0dHA6Ly9vcGNmb3Vu" +
           "ZGF0aW9uLm9yZy9VQS9ESS8kAAAAaHR0cDovL29wY2ZvdW5kYXRpb24ub3JnL1VBL0ZYL0RhdGEv////" +
           "/wRggAIBAAAAAQAdAAAAQ29udHJvbEl0ZW1Gb2xkZXJUeXBlSW5zdGFuY2UBAfMDAQHzA/MDAAD/////" +
           "AgAAAARggAoBAAAAAQAEAAAATG9jawEBuxMALwEC9Bi7EwAA/////wgAAAAVYIkKAgAAAAIABgAAAExv" +
           "Y2tlZAEBaBgALgBEaBgAAAAB/////wEB/////wAAAAAVYIkKAgAAAAIADQAAAExvY2tpbmdDbGllbnQB" +
           "AWkYAC4ARGkYAAAADP////8BAf////8AAAAAFWCJCgIAAAACAAsAAABMb2NraW5nVXNlcgEBahgALgBE" +
           "ahgAAAAM/////wEB/////wAAAAAVYIkKAgAAAAIAEQAAAFJlbWFpbmluZ0xvY2tUaW1lAQFrGAAuAERr" +
           "GAAAAQAiAf////8BAf////8AAAAABGGCCgQAAAACAAgAAABJbml0TG9jawEBZhsALwEC+RhmGwAAAQH/" +
           "////AgAAABdgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAWYYAC4ARGYYAACWAQAAAAEAKgEBFgAA" +
           "AAcAAABDb250ZXh0AAz/////AAAAAAABACgBAQAAAAEAAAABAAAAAQH/////AAAAABdgqQoCAAAAAAAP" +
           "AAAAT3V0cHV0QXJndW1lbnRzAQFnGAAuAERnGAAAlgEAAAABACoBAR0AAAAOAAAASW5pdExvY2tTdGF0" +
           "dXMABv////8AAAAAAAEAKAEBAAAAAQAAAAEAAAABAf////8AAAAABGGCCgQAAAACAAkAAABSZW5ld0xv" +
           "Y2sBAWcbAC8BAvwYZxsAAAEB/////wEAAAAXYKkKAgAAAAAADwAAAE91dHB1dEFyZ3VtZW50cwEBbBgA" +
           "LgBEbBgAAJYBAAAAAQAqAQEeAAAADwAAAFJlbmV3TG9ja1N0YXR1cwAG/////wAAAAAAAQAoAQEAAAAB" +
           "AAAAAQAAAAEB/////wAAAAAEYYIKBAAAAAIACAAAAEV4aXRMb2NrAQFlGwAvAQL+GGUbAAABAf////8B" +
           "AAAAF2CpCgIAAAAAAA8AAABPdXRwdXRBcmd1bWVudHMBAWUYAC4ARGUYAACWAQAAAAEAKgEBHQAAAA4A" +
           "AABFeGl0TG9ja1N0YXR1cwAG/////wAAAAAAAQAoAQEAAAABAAAAAQAAAAEB/////wAAAAAEYYIKBAAA" +
           "AAIACQAAAEJyZWFrTG9jawEBZBsALwECABlkGwAAAQH/////AQAAABdgqQoCAAAAAAAPAAAAT3V0cHV0" +
           "QXJndW1lbnRzAQHLFwAuAETLFwAAlgEAAAABACoBAR4AAAAPAAAAQnJlYWtMb2NrU3RhdHVzAAb/////" +
           "AAAAAAABACgBAQAAAAEAAAABAAAAAQH/////AAAAABVgiQoCAAAAAQATAAAATWF4SW5hY3RpdmVMb2Nr" +
           "VGltZQEBVRkALgBEVRkAAAEAIgH/////AwP/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public LockingServicesTypeState Lock
        {
            get
            {
                return m_lock;
            }

            set
            {
                if (!Object.ReferenceEquals(m_lock, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_lock = value;
            }
        }

        /// <remarks />
        public PropertyState<double> MaxInactiveLockTime
        {
            get
            {
                return m_maxInactiveLockTime;
            }

            set
            {
                if (!Object.ReferenceEquals(m_maxInactiveLockTime, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_maxInactiveLockTime = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_lock != null)
            {
                children.Add(m_lock);
            }

            if (m_maxInactiveLockTime != null)
            {
                children.Add(m_maxInactiveLockTime);
            }

            base.GetChildren(context, children);
        }
            
        /// <remarks />
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case UAModel.FXAC.BrowseNames.Lock:
                {
                    if (createOrReplace)
                    {
                        if (Lock == null)
                        {
                            if (replacement == null)
                            {
                                Lock = new LockingServicesTypeState(this);
                            }
                            else
                            {
                                Lock = (LockingServicesTypeState)replacement;
                            }
                        }
                    }

                    instance = Lock;
                    break;
                }

                case UAModel.FXAC.BrowseNames.MaxInactiveLockTime:
                {
                    if (createOrReplace)
                    {
                        if (MaxInactiveLockTime == null)
                        {
                            if (replacement == null)
                            {
                                MaxInactiveLockTime = new PropertyState<double>(this);
                            }
                            else
                            {
                                MaxInactiveLockTime = (PropertyState<double>)replacement;
                            }
                        }
                    }

                    instance = MaxInactiveLockTime;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private LockingServicesTypeState m_lock;
        private PropertyState<double> m_maxInactiveLockTime;
        #endregion
    }
    #endif
    #endregion

    #region InputsFolderTypeState Class
    #if (!OPCUA_EXCLUDE_InputsFolderTypeState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class InputsFolderTypeState : FolderState
    {
        #region Constructors
        /// <remarks />
        public InputsFolderTypeState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(UAModel.FXAC.ObjectTypes.InputsFolderType, UAModel.FXAC.Namespaces.FXAC, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);

            if (SubscriberCapabilities != null)
            {
                SubscriberCapabilities.Initialize(context, SubscriberCapabilities_InitializationString);
            }
        }

        #region Initialization String
        private const string SubscriberCapabilities_InitializationString =
           "AwAAACIAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvRlgvQUMvHwAAAGh0dHA6Ly9vcGNmb3Vu" +
           "ZGF0aW9uLm9yZy9VQS9ESS8kAAAAaHR0cDovL29wY2ZvdW5kYXRpb24ub3JnL1VBL0ZYL0RhdGEv////" +
           "/wRggAoBAAAAAQAWAAAAU3Vic2NyaWJlckNhcGFiaWxpdGllcwEBmRMALwEB7AOZEwAA/////wUAAAAV" +
           "YIkKAgAAAAEAGAAAAFByZWNvbmZpZ3VyZWREYXRhU2V0T25seQEBsBcALwA/sBcAAAAB/////wMD////" +
           "/wAAAAAXYIkKAgAAAAEAHwAAAFByZWNvbmZpZ3VyZWRTdWJzY3JpYmVkRGF0YVNldHMBAbEXAC8AP7EX" +
           "AAAADAEAAAABAAAAAAAAAAMD/////wAAAAAXYIkKAgAAAAEAHwAAAFN1cHBvcnRlZE1lc3NhZ2VSZWNl" +
           "aXZlVGltZW91dHMBAbIXAC8AP7IXAAABAcALAQAAAAEAAAAAAAAAAwP/////AAAAABdgiQoCAAAAAQAc" +
           "AAAAU3VwcG9ydGVkUHVibGlzaGluZ0ludGVydmFscwEBsxcALwA/sxcAAAEBwAsBAAAAAQAAAAAAAAAD" +
           "A/////8AAAAAF2CJCgIAAAABAAwAAABTdXBwb3J0ZWRRb3MBAbQXAC8AP7QXAAABAcQLAQAAAAEAAAAA" +
           "AAAAAwP/////AAAAAA==";

        private const string InitializationString =
           "AwAAACIAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvRlgvQUMvHwAAAGh0dHA6Ly9vcGNmb3Vu" +
           "ZGF0aW9uLm9yZy9VQS9ESS8kAAAAaHR0cDovL29wY2ZvdW5kYXRpb24ub3JnL1VBL0ZYL0RhdGEv////" +
           "/wRggAIBAAAAAQAYAAAASW5wdXRzRm9sZGVyVHlwZUluc3RhbmNlAQHoAwEB6APoAwAA/////wMAAAAE" +
           "YMAKAQAAAAoAAABJbnB1dEdyb3VwAQAMAAAAPElucHV0R3JvdXA+AQGYEwEBIAQBAegDmBMAAP////8B" +
           "AAAABGCACgEAAAABABYAAABTdWJzY3JpYmVyQ2FwYWJpbGl0aWVzAQGZEwAvAQHsA5kTAAD/////BQAA" +
           "ABVgiQoCAAAAAQAYAAAAUHJlY29uZmlndXJlZERhdGFTZXRPbmx5AQGwFwAvAD+wFwAAAAH/////AwP/" +
           "////AAAAABdgiQoCAAAAAQAfAAAAUHJlY29uZmlndXJlZFN1YnNjcmliZWREYXRhU2V0cwEBsRcALwA/" +
           "sRcAAAAMAQAAAAEAAAAAAAAAAwP/////AAAAABdgiQoCAAAAAQAfAAAAU3VwcG9ydGVkTWVzc2FnZVJl" +
           "Y2VpdmVUaW1lb3V0cwEBshcALwA/shcAAAEBwAsBAAAAAQAAAAAAAAADA/////8AAAAAF2CJCgIAAAAB" +
           "ABwAAABTdXBwb3J0ZWRQdWJsaXNoaW5nSW50ZXJ2YWxzAQGzFwAvAD+zFwAAAQHACwEAAAABAAAAAAAA" +
           "AAMD/////wAAAAAXYIkKAgAAAAEADAAAAFN1cHBvcnRlZFFvcwEBtBcALwA/tBcAAAEBxAsBAAAAAQAA" +
           "AAAAAAADA/////8AAAAAFWDJCgIAAAANAAAASW5wdXRWYXJpYWJsZQEADwAAADxJbnB1dFZhcmlhYmxl" +
           "PgEBJwUAIwA/JwUAAAAY/////wMD/////wAAAAAEYIAKAQAAAAEAFgAAAFN1YnNjcmliZXJDYXBhYmls" +
           "aXRpZXMBAZkTAC8BAewDmRMAAP////8FAAAAFWCJCgIAAAABABgAAABQcmVjb25maWd1cmVkRGF0YVNl" +
           "dE9ubHkBAbAXAC8AP7AXAAAAAf////8DA/////8AAAAAF2CJCgIAAAABAB8AAABQcmVjb25maWd1cmVk" +
           "U3Vic2NyaWJlZERhdGFTZXRzAQGxFwAvAD+xFwAAAAwBAAAAAQAAAAAAAAADA/////8AAAAAF2CJCgIA" +
           "AAABAB8AAABTdXBwb3J0ZWRNZXNzYWdlUmVjZWl2ZVRpbWVvdXRzAQGyFwAvAD+yFwAAAQHACwEAAAAB" +
           "AAAAAAAAAAMD/////wAAAAAXYIkKAgAAAAEAHAAAAFN1cHBvcnRlZFB1Ymxpc2hpbmdJbnRlcnZhbHMB" +
           "AbMXAC8AP7MXAAABAcALAQAAAAEAAAAAAAAAAwP/////AAAAABdgiQoCAAAAAQAMAAAAU3VwcG9ydGVk" +
           "UW9zAQG0FwAvAD+0FwAAAQHECwEAAAABAAAAAAAAAAMD/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public SubscriberCapabilitiesTypeState SubscriberCapabilities
        {
            get
            {
                return m_subscriberCapabilities;
            }

            set
            {
                if (!Object.ReferenceEquals(m_subscriberCapabilities, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_subscriberCapabilities = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_subscriberCapabilities != null)
            {
                children.Add(m_subscriberCapabilities);
            }

            base.GetChildren(context, children);
        }
            
        /// <remarks />
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case UAModel.FXAC.BrowseNames.SubscriberCapabilities:
                {
                    if (createOrReplace)
                    {
                        if (SubscriberCapabilities == null)
                        {
                            if (replacement == null)
                            {
                                SubscriberCapabilities = new SubscriberCapabilitiesTypeState(this);
                            }
                            else
                            {
                                SubscriberCapabilities = (SubscriberCapabilitiesTypeState)replacement;
                            }
                        }
                    }

                    instance = SubscriberCapabilities;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private SubscriberCapabilitiesTypeState m_subscriberCapabilities;
        #endregion
    }
    #endif
    #endregion

    #region OutputsFolderTypeState Class
    #if (!OPCUA_EXCLUDE_OutputsFolderTypeState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class OutputsFolderTypeState : FolderState
    {
        #region Constructors
        /// <remarks />
        public OutputsFolderTypeState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(UAModel.FXAC.ObjectTypes.OutputsFolderType, UAModel.FXAC.Namespaces.FXAC, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);

            if (PublisherCapabilities != null)
            {
                PublisherCapabilities.Initialize(context, PublisherCapabilities_InitializationString);
            }
        }

        #region Initialization String
        private const string PublisherCapabilities_InitializationString =
           "AwAAACIAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvRlgvQUMvHwAAAGh0dHA6Ly9vcGNmb3Vu" +
           "ZGF0aW9uLm9yZy9VQS9ESS8kAAAAaHR0cDovL29wY2ZvdW5kYXRpb24ub3JnL1VBL0ZYL0RhdGEv////" +
           "/wRggAoBAAAAAQAVAAAAUHVibGlzaGVyQ2FwYWJpbGl0aWVzAQGXEwAvAQHrA5cTAAD/////BAAAABVg" +
           "iQoCAAAAAQAYAAAAUHJlY29uZmlndXJlZERhdGFTZXRPbmx5AQHRFwAvAD/RFwAAAAH/////AwP/////" +
           "AAAAABdgiQoCAAAAAQAeAAAAUHJlY29uZmlndXJlZFB1Ymxpc2hlZERhdGFTZXRzAQHSFwAvAD/SFwAA" +
           "AAwBAAAAAQAAAAAAAAADA/////8AAAAAF2CJCgIAAAABABwAAABTdXBwb3J0ZWRQdWJsaXNoaW5nSW50" +
           "ZXJ2YWxzAQHTFwAvAD/TFwAAAQHACwEAAAABAAAAAAAAAAMD/////wAAAAAXYIkKAgAAAAEADAAAAFN1" +
           "cHBvcnRlZFFvcwEB1BcALwA/1BcAAAEBwwsBAAAAAQAAAAAAAAADA/////8AAAAA";

        private const string InitializationString =
           "AwAAACIAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvRlgvQUMvHwAAAGh0dHA6Ly9vcGNmb3Vu" +
           "ZGF0aW9uLm9yZy9VQS9ESS8kAAAAaHR0cDovL29wY2ZvdW5kYXRpb24ub3JnL1VBL0ZYL0RhdGEv////" +
           "/wRggAIBAAAAAQAZAAAAT3V0cHV0c0ZvbGRlclR5cGVJbnN0YW5jZQEB+wMBAfsD+wMAAP////8DAAAA" +
           "BGDACgEAAAALAAAAT3V0cHV0R3JvdXABAA0AAAA8T3V0cHV0R3JvdXA+AQGWEwEBIgQBAfsDlhMAAP//" +
           "//8BAAAABGCACgEAAAABABUAAABQdWJsaXNoZXJDYXBhYmlsaXRpZXMBAZcTAC8BAesDlxMAAP////8E" +
           "AAAAFWCJCgIAAAABABgAAABQcmVjb25maWd1cmVkRGF0YVNldE9ubHkBAdEXAC8AP9EXAAAAAf////8D" +
           "A/////8AAAAAF2CJCgIAAAABAB4AAABQcmVjb25maWd1cmVkUHVibGlzaGVkRGF0YVNldHMBAdIXAC8A" +
           "P9IXAAAADAEAAAABAAAAAAAAAAMD/////wAAAAAXYIkKAgAAAAEAHAAAAFN1cHBvcnRlZFB1Ymxpc2hp" +
           "bmdJbnRlcnZhbHMBAdMXAC8AP9MXAAABAcALAQAAAAEAAAAAAAAAAwP/////AAAAABdgiQoCAAAAAQAM" +
           "AAAAU3VwcG9ydGVkUW9zAQHUFwAvAD/UFwAAAQHDCwEAAAABAAAAAAAAAAMD/////wAAAAAVYMkKAgAA" +
           "AA4AAABPdXRwdXRWYXJpYWJsZQEAEAAAADxPdXRwdXRWYXJpYWJsZT4BAZEFACMAP5EFAAAAGP////8D" +
           "A/////8AAAAABGCACgEAAAABABUAAABQdWJsaXNoZXJDYXBhYmlsaXRpZXMBAZcTAC8BAesDlxMAAP//" +
           "//8EAAAAFWCJCgIAAAABABgAAABQcmVjb25maWd1cmVkRGF0YVNldE9ubHkBAdEXAC8AP9EXAAAAAf//" +
           "//8DA/////8AAAAAF2CJCgIAAAABAB4AAABQcmVjb25maWd1cmVkUHVibGlzaGVkRGF0YVNldHMBAdIX" +
           "AC8AP9IXAAAADAEAAAABAAAAAAAAAAMD/////wAAAAAXYIkKAgAAAAEAHAAAAFN1cHBvcnRlZFB1Ymxp" +
           "c2hpbmdJbnRlcnZhbHMBAdMXAC8AP9MXAAABAcALAQAAAAEAAAAAAAAAAwP/////AAAAABdgiQoCAAAA" +
           "AQAMAAAAU3VwcG9ydGVkUW9zAQHUFwAvAD/UFwAAAQHDCwEAAAABAAAAAAAAAAMD/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public PublisherCapabilitiesTypeState PublisherCapabilities
        {
            get
            {
                return m_publisherCapabilities;
            }

            set
            {
                if (!Object.ReferenceEquals(m_publisherCapabilities, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_publisherCapabilities = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_publisherCapabilities != null)
            {
                children.Add(m_publisherCapabilities);
            }

            base.GetChildren(context, children);
        }
            
        /// <remarks />
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case UAModel.FXAC.BrowseNames.PublisherCapabilities:
                {
                    if (createOrReplace)
                    {
                        if (PublisherCapabilities == null)
                        {
                            if (replacement == null)
                            {
                                PublisherCapabilities = new PublisherCapabilitiesTypeState(this);
                            }
                            else
                            {
                                PublisherCapabilities = (PublisherCapabilitiesTypeState)replacement;
                            }
                        }
                    }

                    instance = PublisherCapabilities;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private PublisherCapabilitiesTypeState m_publisherCapabilities;
        #endregion
    }
    #endif
    #endregion

    #region FunctionalEntityTypeState Class
    #if (!OPCUA_EXCLUDE_FunctionalEntityTypeState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class FunctionalEntityTypeState : BaseObjectState
    {
        #region Constructors
        /// <remarks />
        public FunctionalEntityTypeState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(UAModel.FXAC.ObjectTypes.FunctionalEntityType, UAModel.FXAC.Namespaces.FXAC, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);

            if (ApplicationIdentifier != null)
            {
                ApplicationIdentifier.Initialize(context, ApplicationIdentifier_InitializationString);
            }

            if (AuthorAssignedIdentifier != null)
            {
                AuthorAssignedIdentifier.Initialize(context, AuthorAssignedIdentifier_InitializationString);
            }

            if (AuthorAssignedVersion != null)
            {
                AuthorAssignedVersion.Initialize(context, AuthorAssignedVersion_InitializationString);
            }

            if (AuthorUri != null)
            {
                AuthorUri.Initialize(context, AuthorUri_InitializationString);
            }

            if (Capabilities != null)
            {
                Capabilities.Initialize(context, Capabilities_InitializationString);
            }

            if (ConfigurationData != null)
            {
                ConfigurationData.Initialize(context, ConfigurationData_InitializationString);
            }

            if (ConnectionEndpoints != null)
            {
                ConnectionEndpoints.Initialize(context, ConnectionEndpoints_InitializationString);
            }

            if (ControlGroups != null)
            {
                ControlGroups.Initialize(context, ControlGroups_InitializationString);
            }

            if (InputData != null)
            {
                InputData.Initialize(context, InputData_InitializationString);
            }

            if (OperationalHealth != null)
            {
                OperationalHealth.Initialize(context, OperationalHealth_InitializationString);
            }

            if (OperationalHealthAlarms != null)
            {
                OperationalHealthAlarms.Initialize(context, OperationalHealthAlarms_InitializationString);
            }

            if (OutputData != null)
            {
                OutputData.Initialize(context, OutputData_InitializationString);
            }

            if (PublisherCapabilities != null)
            {
                PublisherCapabilities.Initialize(context, PublisherCapabilities_InitializationString);
            }

            if (SubscriberCapabilities != null)
            {
                SubscriberCapabilities.Initialize(context, SubscriberCapabilities_InitializationString);
            }

            if (Verify != null)
            {
                Verify.Initialize(context, Verify_InitializationString);
            }
        }

        #region Initialization String
        private const string ApplicationIdentifier_InitializationString =
           "AwAAACIAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvRlgvQUMvHwAAAGh0dHA6Ly9vcGNmb3Vu" +
           "ZGF0aW9uLm9yZy9VQS9ESS8kAAAAaHR0cDovL29wY2ZvdW5kYXRpb24ub3JnL1VBL0ZYL0RhdGEv////" +
           "/xdgiQoCAAAAAQAVAAAAQXBwbGljYXRpb25JZGVudGlmaWVyAQHNAAAuAETNAAAAAQEcAAEAAAABAAAA" +
           "AAAAAAMD/////wAAAAA=";

        private const string AuthorAssignedIdentifier_InitializationString =
           "AwAAACIAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvRlgvQUMvHwAAAGh0dHA6Ly9vcGNmb3Vu" +
           "ZGF0aW9uLm9yZy9VQS9ESS8kAAAAaHR0cDovL29wY2ZvdW5kYXRpb24ub3JnL1VBL0ZYL0RhdGEv////" +
           "/xVgiQoCAAAAAQAYAAAAQXV0aG9yQXNzaWduZWRJZGVudGlmaWVyAQHLAAAuAETLAAAAAAz/////AwP/" +
           "////AAAAAA==";

        private const string AuthorAssignedVersion_InitializationString =
           "AwAAACIAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvRlgvQUMvHwAAAGh0dHA6Ly9vcGNmb3Vu" +
           "ZGF0aW9uLm9yZy9VQS9ESS8kAAAAaHR0cDovL29wY2ZvdW5kYXRpb24ub3JnL1VBL0ZYL0RhdGEv////" +
           "/xVgqQoCAAAAAQAVAAAAQXV0aG9yQXNzaWduZWRWZXJzaW9uAQHMAAAuAETMAAAAFgEBXAACkQAAADxG" +
           "eFZlcnNpb24geG1sbnM9Imh0dHA6Ly9vcGNmb3VuZGF0aW9uLm9yZy9VQS9GWC9BQy9UeXBlcy54c2Qi" +
           "PjxNYWpvcj4wPC9NYWpvcj48TWlub3I+MDwvTWlub3I+PEJ1aWxkPjA8L0J1aWxkPjxTdWJCdWlsZD4w" +
           "PC9TdWJCdWlsZD48L0Z4VmVyc2lvbj4BARkA/////wMD/////wAAAAA=";

        private const string AuthorUri_InitializationString =
           "AwAAACIAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvRlgvQUMvHwAAAGh0dHA6Ly9vcGNmb3Vu" +
           "ZGF0aW9uLm9yZy9VQS9ESS8kAAAAaHR0cDovL29wY2ZvdW5kYXRpb24ub3JnL1VBL0ZYL0RhdGEv////" +
           "/xVgiQoCAAAAAQAJAAAAQXV0aG9yVXJpAQHKAAAuAETKAAAAAQDHXP////8DA/////8AAAAA";

        private const string Capabilities_InitializationString =
           "AwAAACIAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvRlgvQUMvHwAAAGh0dHA6Ly9vcGNmb3Vu" +
           "ZGF0aW9uLm9yZy9VQS9ESS8kAAAAaHR0cDovL29wY2ZvdW5kYXRpb24ub3JnL1VBL0ZYL0RhdGEv////" +
           "/wRggAoBAAAAAQAMAAAAQ2FwYWJpbGl0aWVzAQGwEwAvAQHwA7ATAAD/////AQAAABVgiQoCAAAAAQAW" +
           "AAAARmVlZGJhY2tTaWduYWxSZXF1aXJlZAEB6hcBAaIPAD/qFwAAAAH/////AwP/////AAAAAA==";

        private const string ConfigurationData_InitializationString =
           "AwAAACIAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvRlgvQUMvHwAAAGh0dHA6Ly9vcGNmb3Vu" +
           "ZGF0aW9uLm9yZy9VQS9ESS8kAAAAaHR0cDovL29wY2ZvdW5kYXRpb24ub3JnL1VBL0ZYL0RhdGEv////" +
           "/wRggAoBAAAAAQARAAAAQ29uZmlndXJhdGlvbkRhdGEBAacTAC8BAREEpxMAAP////8AAAAA";

        private const string ConnectionEndpoints_InitializationString =
           "AwAAACIAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvRlgvQUMvHwAAAGh0dHA6Ly9vcGNmb3Vu" +
           "ZGF0aW9uLm9yZy9VQS9ESS8kAAAAaHR0cDovL29wY2ZvdW5kYXRpb24ub3JnL1VBL0ZYL0RhdGEv////" +
           "/wRggAoBAAAAAQATAAAAQ29ubmVjdGlvbkVuZHBvaW50cwEBqBMALwEBFACoEwAA/////wAAAAA=";

        private const string ControlGroups_InitializationString =
           "AwAAACIAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvRlgvQUMvHwAAAGh0dHA6Ly9vcGNmb3Vu" +
           "ZGF0aW9uLm9yZy9VQS9ESS8kAAAAaHR0cDovL29wY2ZvdW5kYXRpb24ub3JnL1VBL0ZYL0RhdGEv////" +
           "/wRggAoBAAAAAQANAAAAQ29udHJvbEdyb3VwcwEBKQQALwEB8gMpBAAA/////wAAAAA=";

        private const string InputData_InitializationString =
           "AwAAACIAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvRlgvQUMvHwAAAGh0dHA6Ly9vcGNmb3Vu" +
           "ZGF0aW9uLm9yZy9VQS9ESS8kAAAAaHR0cDovL29wY2ZvdW5kYXRpb24ub3JnL1VBL0ZYL0RhdGEv////" +
           "/wRggAoBAAAAAQAJAAAASW5wdXREYXRhAQFlBAAvAQHoA2UEAAD/////AAAAAA==";

        private const string OperationalHealth_InitializationString =
           "AwAAACIAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvRlgvQUMvHwAAAGh0dHA6Ly9vcGNmb3Vu" +
           "ZGF0aW9uLm9yZy9VQS9ESS8kAAAAaHR0cDovL29wY2ZvdW5kYXRpb24ub3JnL1VBL0ZYL0RhdGEv////" +
           "/xVgiQoCAAAAAQARAAAAT3BlcmF0aW9uYWxIZWFsdGgBAagXAC8AP6gXAAABAcIL/////wEB/////wAA" +
           "AAA=";

        private const string OperationalHealthAlarms_InitializationString =
           "AwAAACIAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvRlgvQUMvHwAAAGh0dHA6Ly9vcGNmb3Vu" +
           "ZGF0aW9uLm9yZy9VQS9ESS8kAAAAaHR0cDovL29wY2ZvdW5kYXRpb24ub3JnL1VBL0ZYL0RhdGEv////" +
           "/wRggAoBAAAAAQAXAAAAT3BlcmF0aW9uYWxIZWFsdGhBbGFybXMBAbETAC8APbETAAD/////AAAAAA==";

        private const string OutputData_InitializationString =
           "AwAAACIAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvRlgvQUMvHwAAAGh0dHA6Ly9vcGNmb3Vu" +
           "ZGF0aW9uLm9yZy9VQS9ESS8kAAAAaHR0cDovL29wY2ZvdW5kYXRpb24ub3JnL1VBL0ZYL0RhdGEv////" +
           "/wRggAoBAAAAAQAKAAAAT3V0cHV0RGF0YQEBZgQALwEB+wNmBAAA/////wAAAAA=";

        private const string PublisherCapabilities_InitializationString =
           "AwAAACIAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvRlgvQUMvHwAAAGh0dHA6Ly9vcGNmb3Vu" +
           "ZGF0aW9uLm9yZy9VQS9ESS8kAAAAaHR0cDovL29wY2ZvdW5kYXRpb24ub3JnL1VBL0ZYL0RhdGEv////" +
           "/wRggAoBAAAAAQAVAAAAUHVibGlzaGVyQ2FwYWJpbGl0aWVzAQGUEwAvAQHrA5QTAAD/////BAAAABdg" +
           "iQoCAAAAAQAYAAAAUHJlY29uZmlndXJlZERhdGFTZXRPbmx5AQGmFwAvAD+mFwAAAAEBAAAAAQAAAAAA" +
           "AAADA/////8AAAAAF2CJCgIAAAABAB4AAABQcmVjb25maWd1cmVkUHVibGlzaGVkRGF0YVNldHMBAakX" +
           "AC8AP6kXAAAADAEAAAABAAAAAAAAAAMD/////wAAAAAXYIkKAgAAAAEAHAAAAFN1cHBvcnRlZFB1Ymxp" +
           "c2hpbmdJbnRlcnZhbHMBAaoXAC8AP6oXAAABAcALAQAAAAEAAAAAAAAAAwP/////AAAAABdgiQoCAAAA" +
           "AQAMAAAAU3VwcG9ydGVkUW9zAQGrFwAvAD+rFwAAAQHDCwEAAAABAAAAAAAAAAMD/////wAAAAA=";

        private const string SubscriberCapabilities_InitializationString =
           "AwAAACIAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvRlgvQUMvHwAAAGh0dHA6Ly9vcGNmb3Vu" +
           "ZGF0aW9uLm9yZy9VQS9ESS8kAAAAaHR0cDovL29wY2ZvdW5kYXRpb24ub3JnL1VBL0ZYL0RhdGEv////" +
           "/wRggAoBAAAAAQAWAAAAU3Vic2NyaWJlckNhcGFiaWxpdGllcwEBlRMALwEB7AOVEwAA/////wUAAAAV" +
           "YIkKAgAAAAEAGAAAAFByZWNvbmZpZ3VyZWREYXRhU2V0T25seQEBpxcALwA/pxcAAAAB/////wMD////" +
           "/wAAAAAXYIkKAgAAAAEAHwAAAFByZWNvbmZpZ3VyZWRTdWJzY3JpYmVkRGF0YVNldHMBAawXAC8AP6wX" +
           "AAAADAEAAAABAAAAAAAAAAMD/////wAAAAAXYIkKAgAAAAEAHwAAAFN1cHBvcnRlZE1lc3NhZ2VSZWNl" +
           "aXZlVGltZW91dHMBAa0XAC8AP60XAAABAcALAQAAAAEAAAAAAAAAAwP/////AAAAABdgiQoCAAAAAQAc" +
           "AAAAU3VwcG9ydGVkUHVibGlzaGluZ0ludGVydmFscwEBrhcALwA/rhcAAAEBwAsBAAAAAQAAAAAAAAAD" +
           "A/////8AAAAAF2CJCgIAAAABAAwAAABTdXBwb3J0ZWRRb3MBAa8XAC8AP68XAAABAcQLAQAAAAEAAAAA" +
           "AAAAAwP/////AAAAAA==";

        private const string Verify_InitializationString =
           "AwAAACIAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvRlgvQUMvHwAAAGh0dHA6Ly9vcGNmb3Vu" +
           "ZGF0aW9uLm9yZy9VQS9ESS8kAAAAaHR0cDovL29wY2ZvdW5kYXRpb24ub3JnL1VBL0ZYL0RhdGEv////" +
           "/wRhggoEAAAAAQAGAAAAVmVyaWZ5AQEtAQAvAQEtAS0BAAABAf////8CAAAAF2CpCgIAAAAAAA4AAABJ" +
           "bnB1dEFyZ3VtZW50cwEBTgUALgBETgUAAJYBAAAAAQAqAQEyAAAAHQAAAEV4cGVjdGVkVmVyaWZpY2F0" +
           "aW9uVmFyaWFibGVzAQMEBAEAAAABAAAAAAAAAAABACgBAQAAAAEAAAABAAAAAQH/////AAAAABdgqQoC" +
           "AAAAAAAPAAAAT3V0cHV0QXJndW1lbnRzAQFPBQAuAERPBQAAlgIAAAABACoBASMAAAASAAAAVmVyaWZp" +
           "Y2F0aW9uUmVzdWx0AQO6C/////8AAAAAAAEAKgEBLgAAABsAAABWZXJpZmljYXRpb25WYXJpYWJsZXNF" +
           "cnJvcnMAEwEAAAABAAAAAAAAAAABACgBAQAAAAEAAAACAAAAAQH/////AAAAAA==";

        private const string InitializationString =
           "AwAAACIAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvRlgvQUMvHwAAAGh0dHA6Ly9vcGNmb3Vu" +
           "ZGF0aW9uLm9yZy9VQS9ESS8kAAAAaHR0cDovL29wY2ZvdW5kYXRpb24ub3JnL1VBL0ZYL0RhdGEv////" +
           "/wRggAIBAAAAAQAcAAAARnVuY3Rpb25hbEVudGl0eVR5cGVJbnN0YW5jZQEBBAABAQQABAAAAAEAAAAB" +
           "AMNEAAEBCwAQAAAABGDACgEAAAATAAAAU3ViRnVuY3Rpb25hbEVudGl0eQEAFQAAADxTdWJGdW5jdGlv" +
           "bmFsRW50aXR5PgEBkxMBASsAAQEEAJMTAAABAAAAAQDDRAABAQsADwAAABdgiQoCAAAAAQAVAAAAQXBw" +
           "bGljYXRpb25JZGVudGlmaWVyAQHNAAAuAETNAAAAAQEcAAEAAAABAAAAAAAAAAMD/////wAAAAAVYIkK" +
           "AgAAAAEAGAAAAEF1dGhvckFzc2lnbmVkSWRlbnRpZmllcgEBywAALgBEywAAAAAM/////wMD/////wAA" +
           "AAAVYKkKAgAAAAEAFQAAAEF1dGhvckFzc2lnbmVkVmVyc2lvbgEBzAAALgBEzAAAABYBAVwAApEAAAA8" +
           "RnhWZXJzaW9uIHhtbG5zPSJodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvRlgvQUMvVHlwZXMueHNk" +
           "Ij48TWFqb3I+MDwvTWFqb3I+PE1pbm9yPjA8L01pbm9yPjxCdWlsZD4wPC9CdWlsZD48U3ViQnVpbGQ+" +
           "MDwvU3ViQnVpbGQ+PC9GeFZlcnNpb24+AQEZAP////8DA/////8AAAAAFWCJCgIAAAABAAkAAABBdXRo" +
           "b3JVcmkBAcoAAC4ARMoAAAABAMdc/////wMD/////wAAAAAEYIAKAQAAAAEADAAAAENhcGFiaWxpdGll" +
           "cwEBsBMALwEB8AOwEwAA/////wEAAAAVYIkKAgAAAAEAFgAAAEZlZWRiYWNrU2lnbmFsUmVxdWlyZWQB" +
           "AeoXAQGiDwA/6hcAAAAB/////wMD/////wAAAAAEYIAKAQAAAAEAEQAAAENvbmZpZ3VyYXRpb25EYXRh" +
           "AQGnEwAvAQERBKcTAAD/////AAAAAARggAoBAAAAAQATAAAAQ29ubmVjdGlvbkVuZHBvaW50cwEBqBMA" +
           "LwEBFACoEwAA/////wAAAAAEYIAKAQAAAAEADQAAAENvbnRyb2xHcm91cHMBASkEAC8BAfIDKQQAAP//" +
           "//8AAAAABGCACgEAAAABAAkAAABJbnB1dERhdGEBAWUEAC8BAegDZQQAAP////8AAAAAFWCJCgIAAAAB" +
           "ABEAAABPcGVyYXRpb25hbEhlYWx0aAEBqBcALwA/qBcAAAEBwgv/////AQH/////AAAAAARggAoBAAAA" +
           "AQAXAAAAT3BlcmF0aW9uYWxIZWFsdGhBbGFybXMBAbETAC8APbETAAD/////AAAAAARggAoBAAAAAQAK" +
           "AAAAT3V0cHV0RGF0YQEBZgQALwEB+wNmBAAA/////wAAAAAEYIAKAQAAAAEAFQAAAFB1Ymxpc2hlckNh" +
           "cGFiaWxpdGllcwEBlBMALwEB6wOUEwAA/////wQAAAAXYIkKAgAAAAEAGAAAAFByZWNvbmZpZ3VyZWRE" +
           "YXRhU2V0T25seQEBphcALwA/phcAAAABAQAAAAEAAAAAAAAAAwP/////AAAAABdgiQoCAAAAAQAeAAAA" +
           "UHJlY29uZmlndXJlZFB1Ymxpc2hlZERhdGFTZXRzAQGpFwAvAD+pFwAAAAwBAAAAAQAAAAAAAAADA///" +
           "//8AAAAAF2CJCgIAAAABABwAAABTdXBwb3J0ZWRQdWJsaXNoaW5nSW50ZXJ2YWxzAQGqFwAvAD+qFwAA" +
           "AQHACwEAAAABAAAAAAAAAAMD/////wAAAAAXYIkKAgAAAAEADAAAAFN1cHBvcnRlZFFvcwEBqxcALwA/" +
           "qxcAAAEBwwsBAAAAAQAAAAAAAAADA/////8AAAAABGCACgEAAAABABYAAABTdWJzY3JpYmVyQ2FwYWJp" +
           "bGl0aWVzAQGVEwAvAQHsA5UTAAD/////BQAAABVgiQoCAAAAAQAYAAAAUHJlY29uZmlndXJlZERhdGFT" +
           "ZXRPbmx5AQGnFwAvAD+nFwAAAAH/////AwP/////AAAAABdgiQoCAAAAAQAfAAAAUHJlY29uZmlndXJl" +
           "ZFN1YnNjcmliZWREYXRhU2V0cwEBrBcALwA/rBcAAAAMAQAAAAEAAAAAAAAAAwP/////AAAAABdgiQoC" +
           "AAAAAQAfAAAAU3VwcG9ydGVkTWVzc2FnZVJlY2VpdmVUaW1lb3V0cwEBrRcALwA/rRcAAAEBwAsBAAAA" +
           "AQAAAAAAAAADA/////8AAAAAF2CJCgIAAAABABwAAABTdXBwb3J0ZWRQdWJsaXNoaW5nSW50ZXJ2YWxz" +
           "AQGuFwAvAD+uFwAAAQHACwEAAAABAAAAAAAAAAMD/////wAAAAAXYIkKAgAAAAEADAAAAFN1cHBvcnRl" +
           "ZFFvcwEBrxcALwA/rxcAAAEBxAsBAAAAAQAAAAAAAAADA/////8AAAAABGGCCgQAAAABAAYAAABWZXJp" +
           "ZnkBAS0BAC8BAS0BLQEAAAEB/////wIAAAAXYKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQFOBQAu" +
           "AEROBQAAlgEAAAABACoBATIAAAAdAAAARXhwZWN0ZWRWZXJpZmljYXRpb25WYXJpYWJsZXMBAwQEAQAA" +
           "AAEAAAAAAAAAAAEAKAEBAAAAAQAAAAEAAAABAf////8AAAAAF2CpCgIAAAAAAA8AAABPdXRwdXRBcmd1" +
           "bWVudHMBAU8FAC4ARE8FAACWAgAAAAEAKgEBIwAAABIAAABWZXJpZmljYXRpb25SZXN1bHQBA7oL////" +
           "/wAAAAAAAQAqAQEuAAAAGwAAAFZlcmlmaWNhdGlvblZhcmlhYmxlc0Vycm9ycwATAQAAAAEAAAAAAAAA" +
           "AAEAKAEBAAAAAQAAAAIAAAABAf////8AAAAAF2CJCgIAAAABABUAAABBcHBsaWNhdGlvbklkZW50aWZp" +
           "ZXIBAc0AAC4ARM0AAAABARwAAQAAAAEAAAAAAAAAAwP/////AAAAABVgiQoCAAAAAQAYAAAAQXV0aG9y" +
           "QXNzaWduZWRJZGVudGlmaWVyAQHLAAAuAETLAAAAAAz/////AwP/////AAAAABVgqQoCAAAAAQAVAAAA" +
           "QXV0aG9yQXNzaWduZWRWZXJzaW9uAQHMAAAuAETMAAAAFgEBXAACkQAAADxGeFZlcnNpb24geG1sbnM9" +
           "Imh0dHA6Ly9vcGNmb3VuZGF0aW9uLm9yZy9VQS9GWC9BQy9UeXBlcy54c2QiPjxNYWpvcj4wPC9NYWpv" +
           "cj48TWlub3I+MDwvTWlub3I+PEJ1aWxkPjA8L0J1aWxkPjxTdWJCdWlsZD4wPC9TdWJCdWlsZD48L0Z4" +
           "VmVyc2lvbj4BARkA/////wMD/////wAAAAAVYIkKAgAAAAEACQAAAEF1dGhvclVyaQEBygAALgBEygAA" +
           "AAEAx1z/////AwP/////AAAAAARggAoBAAAAAQAMAAAAQ2FwYWJpbGl0aWVzAQGwEwAvAQHwA7ATAAD/" +
           "////AQAAABVgiQoCAAAAAQAWAAAARmVlZGJhY2tTaWduYWxSZXF1aXJlZAEB6hcBAaIPAD/qFwAAAAH/" +
           "////AwP/////AAAAAARggAoBAAAAAQARAAAAQ29uZmlndXJhdGlvbkRhdGEBAacTAC8BAREEpxMAAP//" +
           "//8AAAAABGCACgEAAAABABMAAABDb25uZWN0aW9uRW5kcG9pbnRzAQGoEwAvAQEUAKgTAAD/////AAAA" +
           "AARggAoBAAAAAQANAAAAQ29udHJvbEdyb3VwcwEBKQQALwEB8gMpBAAA/////wAAAAAEYIAKAQAAAAEA" +
           "CQAAAElucHV0RGF0YQEBZQQALwEB6ANlBAAA/////wAAAAAVYIkKAgAAAAEAEQAAAE9wZXJhdGlvbmFs" +
           "SGVhbHRoAQGoFwAvAD+oFwAAAQHCC/////8BAf////8AAAAABGCACgEAAAABABcAAABPcGVyYXRpb25h" +
           "bEhlYWx0aEFsYXJtcwEBsRMALwA9sRMAAP////8AAAAABGCACgEAAAABAAoAAABPdXRwdXREYXRhAQFm" +
           "BAAvAQH7A2YEAAD/////AAAAAARggAoBAAAAAQAVAAAAUHVibGlzaGVyQ2FwYWJpbGl0aWVzAQGUEwAv" +
           "AQHrA5QTAAD/////BAAAABdgiQoCAAAAAQAYAAAAUHJlY29uZmlndXJlZERhdGFTZXRPbmx5AQGmFwAv" +
           "AD+mFwAAAAEBAAAAAQAAAAAAAAADA/////8AAAAAF2CJCgIAAAABAB4AAABQcmVjb25maWd1cmVkUHVi" +
           "bGlzaGVkRGF0YVNldHMBAakXAC8AP6kXAAAADAEAAAABAAAAAAAAAAMD/////wAAAAAXYIkKAgAAAAEA" +
           "HAAAAFN1cHBvcnRlZFB1Ymxpc2hpbmdJbnRlcnZhbHMBAaoXAC8AP6oXAAABAcALAQAAAAEAAAAAAAAA" +
           "AwP/////AAAAABdgiQoCAAAAAQAMAAAAU3VwcG9ydGVkUW9zAQGrFwAvAD+rFwAAAQHDCwEAAAABAAAA" +
           "AAAAAAMD/////wAAAAAEYIAKAQAAAAEAFgAAAFN1YnNjcmliZXJDYXBhYmlsaXRpZXMBAZUTAC8BAewD" +
           "lRMAAP////8FAAAAFWCJCgIAAAABABgAAABQcmVjb25maWd1cmVkRGF0YVNldE9ubHkBAacXAC8AP6cX" +
           "AAAAAf////8DA/////8AAAAAF2CJCgIAAAABAB8AAABQcmVjb25maWd1cmVkU3Vic2NyaWJlZERhdGFT" +
           "ZXRzAQGsFwAvAD+sFwAAAAwBAAAAAQAAAAAAAAADA/////8AAAAAF2CJCgIAAAABAB8AAABTdXBwb3J0" +
           "ZWRNZXNzYWdlUmVjZWl2ZVRpbWVvdXRzAQGtFwAvAD+tFwAAAQHACwEAAAABAAAAAAAAAAMD/////wAA" +
           "AAAXYIkKAgAAAAEAHAAAAFN1cHBvcnRlZFB1Ymxpc2hpbmdJbnRlcnZhbHMBAa4XAC8AP64XAAABAcAL" +
           "AQAAAAEAAAAAAAAAAwP/////AAAAABdgiQoCAAAAAQAMAAAAU3VwcG9ydGVkUW9zAQGvFwAvAD+vFwAA" +
           "AQHECwEAAAABAAAAAAAAAAMD/////wAAAAAEYYIKBAAAAAEABgAAAFZlcmlmeQEBLQEALwEBLQEtAQAA" +
           "AQH/////AgAAABdgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAU4FAC4ARE4FAACWAQAAAAEAKgEB" +
           "MgAAAB0AAABFeHBlY3RlZFZlcmlmaWNhdGlvblZhcmlhYmxlcwEDBAQBAAAAAQAAAAAAAAAAAQAoAQEA" +
           "AAABAAAAAQAAAAEB/////wAAAAAXYKkKAgAAAAAADwAAAE91dHB1dEFyZ3VtZW50cwEBTwUALgBETwUA" +
           "AJYCAAAAAQAqAQEjAAAAEgAAAFZlcmlmaWNhdGlvblJlc3VsdAEDugv/////AAAAAAABACoBAS4AAAAb" +
           "AAAAVmVyaWZpY2F0aW9uVmFyaWFibGVzRXJyb3JzABMBAAAAAQAAAAAAAAAAAQAoAQEAAAABAAAAAgAA" +
           "AAEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public PropertyState<ApplicationIdentifierDataType[]> ApplicationIdentifier
        {
            get
            {
                return m_applicationIdentifier;
            }

            set
            {
                if (!Object.ReferenceEquals(m_applicationIdentifier, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_applicationIdentifier = value;
            }
        }

        /// <remarks />
        public PropertyState<string> AuthorAssignedIdentifier
        {
            get
            {
                return m_authorAssignedIdentifier;
            }

            set
            {
                if (!Object.ReferenceEquals(m_authorAssignedIdentifier, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_authorAssignedIdentifier = value;
            }
        }

        /// <remarks />
        public PropertyState<FxVersion> AuthorAssignedVersion
        {
            get
            {
                return m_authorAssignedVersion;
            }

            set
            {
                if (!Object.ReferenceEquals(m_authorAssignedVersion, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_authorAssignedVersion = value;
            }
        }

        /// <remarks />
        public PropertyState<string> AuthorUri
        {
            get
            {
                return m_authorUri;
            }

            set
            {
                if (!Object.ReferenceEquals(m_authorUri, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_authorUri = value;
            }
        }

        /// <remarks />
        public FunctionalEntityCapabilitiesTypeState Capabilities
        {
            get
            {
                return m_capabilities;
            }

            set
            {
                if (!Object.ReferenceEquals(m_capabilities, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_capabilities = value;
            }
        }

        /// <remarks />
        public ConfigurationDataFolderTypeState ConfigurationData
        {
            get
            {
                return m_configurationData;
            }

            set
            {
                if (!Object.ReferenceEquals(m_configurationData, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_configurationData = value;
            }
        }

        /// <remarks />
        public ConnectionEndpointsFolderTypeState ConnectionEndpoints
        {
            get
            {
                return m_connectionEndpoints;
            }

            set
            {
                if (!Object.ReferenceEquals(m_connectionEndpoints, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_connectionEndpoints = value;
            }
        }

        /// <remarks />
        public ControlGroupsFolderTypeState ControlGroups
        {
            get
            {
                return m_controlGroups;
            }

            set
            {
                if (!Object.ReferenceEquals(m_controlGroups, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_controlGroups = value;
            }
        }

        /// <remarks />
        public InputsFolderTypeState InputData
        {
            get
            {
                return m_inputData;
            }

            set
            {
                if (!Object.ReferenceEquals(m_inputData, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_inputData = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<uint> OperationalHealth
        {
            get
            {
                return m_operationalHealth;
            }

            set
            {
                if (!Object.ReferenceEquals(m_operationalHealth, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_operationalHealth = value;
            }
        }

        /// <remarks />
        public FolderState OperationalHealthAlarms
        {
            get
            {
                return m_operationalHealthAlarms;
            }

            set
            {
                if (!Object.ReferenceEquals(m_operationalHealthAlarms, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_operationalHealthAlarms = value;
            }
        }

        /// <remarks />
        public OutputsFolderTypeState OutputData
        {
            get
            {
                return m_outputData;
            }

            set
            {
                if (!Object.ReferenceEquals(m_outputData, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_outputData = value;
            }
        }

        /// <remarks />
        public PublisherCapabilitiesTypeState PublisherCapabilities
        {
            get
            {
                return m_publisherCapabilities;
            }

            set
            {
                if (!Object.ReferenceEquals(m_publisherCapabilities, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_publisherCapabilities = value;
            }
        }

        /// <remarks />
        public SubscriberCapabilitiesTypeState SubscriberCapabilities
        {
            get
            {
                return m_subscriberCapabilities;
            }

            set
            {
                if (!Object.ReferenceEquals(m_subscriberCapabilities, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_subscriberCapabilities = value;
            }
        }

        /// <remarks />
        public VerifyMethodState Verify
        {
            get
            {
                return m_verifyMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_verifyMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_verifyMethod = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_applicationIdentifier != null)
            {
                children.Add(m_applicationIdentifier);
            }

            if (m_authorAssignedIdentifier != null)
            {
                children.Add(m_authorAssignedIdentifier);
            }

            if (m_authorAssignedVersion != null)
            {
                children.Add(m_authorAssignedVersion);
            }

            if (m_authorUri != null)
            {
                children.Add(m_authorUri);
            }

            if (m_capabilities != null)
            {
                children.Add(m_capabilities);
            }

            if (m_configurationData != null)
            {
                children.Add(m_configurationData);
            }

            if (m_connectionEndpoints != null)
            {
                children.Add(m_connectionEndpoints);
            }

            if (m_controlGroups != null)
            {
                children.Add(m_controlGroups);
            }

            if (m_inputData != null)
            {
                children.Add(m_inputData);
            }

            if (m_operationalHealth != null)
            {
                children.Add(m_operationalHealth);
            }

            if (m_operationalHealthAlarms != null)
            {
                children.Add(m_operationalHealthAlarms);
            }

            if (m_outputData != null)
            {
                children.Add(m_outputData);
            }

            if (m_publisherCapabilities != null)
            {
                children.Add(m_publisherCapabilities);
            }

            if (m_subscriberCapabilities != null)
            {
                children.Add(m_subscriberCapabilities);
            }

            if (m_verifyMethod != null)
            {
                children.Add(m_verifyMethod);
            }

            base.GetChildren(context, children);
        }
            
        /// <remarks />
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case UAModel.FXAC.BrowseNames.ApplicationIdentifier:
                {
                    if (createOrReplace)
                    {
                        if (ApplicationIdentifier == null)
                        {
                            if (replacement == null)
                            {
                                ApplicationIdentifier = new PropertyState<ApplicationIdentifierDataType[]>(this);
                            }
                            else
                            {
                                ApplicationIdentifier = (PropertyState<ApplicationIdentifierDataType[]>)replacement;
                            }
                        }
                    }

                    instance = ApplicationIdentifier;
                    break;
                }

                case UAModel.FXAC.BrowseNames.AuthorAssignedIdentifier:
                {
                    if (createOrReplace)
                    {
                        if (AuthorAssignedIdentifier == null)
                        {
                            if (replacement == null)
                            {
                                AuthorAssignedIdentifier = new PropertyState<string>(this);
                            }
                            else
                            {
                                AuthorAssignedIdentifier = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = AuthorAssignedIdentifier;
                    break;
                }

                case UAModel.FXAC.BrowseNames.AuthorAssignedVersion:
                {
                    if (createOrReplace)
                    {
                        if (AuthorAssignedVersion == null)
                        {
                            if (replacement == null)
                            {
                                AuthorAssignedVersion = new PropertyState<FxVersion>(this);
                            }
                            else
                            {
                                AuthorAssignedVersion = (PropertyState<FxVersion>)replacement;
                            }
                        }
                    }

                    instance = AuthorAssignedVersion;
                    break;
                }

                case UAModel.FXAC.BrowseNames.AuthorUri:
                {
                    if (createOrReplace)
                    {
                        if (AuthorUri == null)
                        {
                            if (replacement == null)
                            {
                                AuthorUri = new PropertyState<string>(this);
                            }
                            else
                            {
                                AuthorUri = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = AuthorUri;
                    break;
                }

                case UAModel.FXAC.BrowseNames.Capabilities:
                {
                    if (createOrReplace)
                    {
                        if (Capabilities == null)
                        {
                            if (replacement == null)
                            {
                                Capabilities = new FunctionalEntityCapabilitiesTypeState(this);
                            }
                            else
                            {
                                Capabilities = (FunctionalEntityCapabilitiesTypeState)replacement;
                            }
                        }
                    }

                    instance = Capabilities;
                    break;
                }

                case UAModel.FXAC.BrowseNames.ConfigurationData:
                {
                    if (createOrReplace)
                    {
                        if (ConfigurationData == null)
                        {
                            if (replacement == null)
                            {
                                ConfigurationData = new ConfigurationDataFolderTypeState(this);
                            }
                            else
                            {
                                ConfigurationData = (ConfigurationDataFolderTypeState)replacement;
                            }
                        }
                    }

                    instance = ConfigurationData;
                    break;
                }

                case UAModel.FXAC.BrowseNames.ConnectionEndpoints:
                {
                    if (createOrReplace)
                    {
                        if (ConnectionEndpoints == null)
                        {
                            if (replacement == null)
                            {
                                ConnectionEndpoints = new ConnectionEndpointsFolderTypeState(this);
                            }
                            else
                            {
                                ConnectionEndpoints = (ConnectionEndpointsFolderTypeState)replacement;
                            }
                        }
                    }

                    instance = ConnectionEndpoints;
                    break;
                }

                case UAModel.FXAC.BrowseNames.ControlGroups:
                {
                    if (createOrReplace)
                    {
                        if (ControlGroups == null)
                        {
                            if (replacement == null)
                            {
                                ControlGroups = new ControlGroupsFolderTypeState(this);
                            }
                            else
                            {
                                ControlGroups = (ControlGroupsFolderTypeState)replacement;
                            }
                        }
                    }

                    instance = ControlGroups;
                    break;
                }

                case UAModel.FXAC.BrowseNames.InputData:
                {
                    if (createOrReplace)
                    {
                        if (InputData == null)
                        {
                            if (replacement == null)
                            {
                                InputData = new InputsFolderTypeState(this);
                            }
                            else
                            {
                                InputData = (InputsFolderTypeState)replacement;
                            }
                        }
                    }

                    instance = InputData;
                    break;
                }

                case UAModel.FXAC.BrowseNames.OperationalHealth:
                {
                    if (createOrReplace)
                    {
                        if (OperationalHealth == null)
                        {
                            if (replacement == null)
                            {
                                OperationalHealth = new BaseDataVariableState<uint>(this);
                            }
                            else
                            {
                                OperationalHealth = (BaseDataVariableState<uint>)replacement;
                            }
                        }
                    }

                    instance = OperationalHealth;
                    break;
                }

                case UAModel.FXAC.BrowseNames.OperationalHealthAlarms:
                {
                    if (createOrReplace)
                    {
                        if (OperationalHealthAlarms == null)
                        {
                            if (replacement == null)
                            {
                                OperationalHealthAlarms = new FolderState(this);
                            }
                            else
                            {
                                OperationalHealthAlarms = (FolderState)replacement;
                            }
                        }
                    }

                    instance = OperationalHealthAlarms;
                    break;
                }

                case UAModel.FXAC.BrowseNames.OutputData:
                {
                    if (createOrReplace)
                    {
                        if (OutputData == null)
                        {
                            if (replacement == null)
                            {
                                OutputData = new OutputsFolderTypeState(this);
                            }
                            else
                            {
                                OutputData = (OutputsFolderTypeState)replacement;
                            }
                        }
                    }

                    instance = OutputData;
                    break;
                }

                case UAModel.FXAC.BrowseNames.PublisherCapabilities:
                {
                    if (createOrReplace)
                    {
                        if (PublisherCapabilities == null)
                        {
                            if (replacement == null)
                            {
                                PublisherCapabilities = new PublisherCapabilitiesTypeState(this);
                            }
                            else
                            {
                                PublisherCapabilities = (PublisherCapabilitiesTypeState)replacement;
                            }
                        }
                    }

                    instance = PublisherCapabilities;
                    break;
                }

                case UAModel.FXAC.BrowseNames.SubscriberCapabilities:
                {
                    if (createOrReplace)
                    {
                        if (SubscriberCapabilities == null)
                        {
                            if (replacement == null)
                            {
                                SubscriberCapabilities = new SubscriberCapabilitiesTypeState(this);
                            }
                            else
                            {
                                SubscriberCapabilities = (SubscriberCapabilitiesTypeState)replacement;
                            }
                        }
                    }

                    instance = SubscriberCapabilities;
                    break;
                }

                case UAModel.FXAC.BrowseNames.Verify:
                {
                    if (createOrReplace)
                    {
                        if (Verify == null)
                        {
                            if (replacement == null)
                            {
                                Verify = new VerifyMethodState(this);
                            }
                            else
                            {
                                Verify = (VerifyMethodState)replacement;
                            }
                        }
                    }

                    instance = Verify;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private PropertyState<ApplicationIdentifierDataType[]> m_applicationIdentifier;
        private PropertyState<string> m_authorAssignedIdentifier;
        private PropertyState<FxVersion> m_authorAssignedVersion;
        private PropertyState<string> m_authorUri;
        private FunctionalEntityCapabilitiesTypeState m_capabilities;
        private ConfigurationDataFolderTypeState m_configurationData;
        private ConnectionEndpointsFolderTypeState m_connectionEndpoints;
        private ControlGroupsFolderTypeState m_controlGroups;
        private InputsFolderTypeState m_inputData;
        private BaseDataVariableState<uint> m_operationalHealth;
        private FolderState m_operationalHealthAlarms;
        private OutputsFolderTypeState m_outputData;
        private PublisherCapabilitiesTypeState m_publisherCapabilities;
        private SubscriberCapabilitiesTypeState m_subscriberCapabilities;
        private VerifyMethodState m_verifyMethod;
        #endregion
    }
    #endif
    #endregion

    #region FxAssetTypeState Class
    #if (!OPCUA_EXCLUDE_FxAssetTypeState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class FxAssetTypeState : BaseObjectState
    {
        #region Constructors
        /// <remarks />
        public FxAssetTypeState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(UAModel.FXAC.ObjectTypes.FxAssetType, UAModel.FXAC.Namespaces.FXAC, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);

            if (AssetId != null)
            {
                AssetId.Initialize(context, AssetId_InitializationString);
            }

            if (BuildAssetNumber != null)
            {
                BuildAssetNumber.Initialize(context, BuildAssetNumber_InitializationString);
            }

            if (ComponentName != null)
            {
                ComponentName.Initialize(context, ComponentName_InitializationString);
            }

            if (Connectors != null)
            {
                Connectors.Initialize(context, Connectors_InitializationString);
            }

            if (DeviceClass != null)
            {
                DeviceClass.Initialize(context, DeviceClass_InitializationString);
            }

            if (DeviceHealth != null)
            {
                DeviceHealth.Initialize(context, DeviceHealth_InitializationString);
            }

            if (DeviceHealthAlarms != null)
            {
                DeviceHealthAlarms.Initialize(context, DeviceHealthAlarms_InitializationString);
            }

            if (DeviceManual != null)
            {
                DeviceManual.Initialize(context, DeviceManual_InitializationString);
            }

            if (DeviceRevision != null)
            {
                DeviceRevision.Initialize(context, DeviceRevision_InitializationString);
            }

            if (HardwareRevision != null)
            {
                HardwareRevision.Initialize(context, HardwareRevision_InitializationString);
            }

            if (MajorAssetVersion != null)
            {
                MajorAssetVersion.Initialize(context, MajorAssetVersion_InitializationString);
            }

            if (Manufacturer != null)
            {
                Manufacturer.Initialize(context, Manufacturer_InitializationString);
            }

            if (ManufacturerUri != null)
            {
                ManufacturerUri.Initialize(context, ManufacturerUri_InitializationString);
            }

            if (MinorAssetVersion != null)
            {
                MinorAssetVersion.Initialize(context, MinorAssetVersion_InitializationString);
            }

            if (Model != null)
            {
                Model.Initialize(context, Model_InitializationString);
            }

            if (ProductCode != null)
            {
                ProductCode.Initialize(context, ProductCode_InitializationString);
            }

            if (ProductInstanceUri != null)
            {
                ProductInstanceUri.Initialize(context, ProductInstanceUri_InitializationString);
            }

            if (RevisionCounter != null)
            {
                RevisionCounter.Initialize(context, RevisionCounter_InitializationString);
            }

            if (SerialNumber != null)
            {
                SerialNumber.Initialize(context, SerialNumber_InitializationString);
            }

            if (SoftwareRevision != null)
            {
                SoftwareRevision.Initialize(context, SoftwareRevision_InitializationString);
            }

            if (SoftwareUpdate != null)
            {
                SoftwareUpdate.Initialize(context, SoftwareUpdate_InitializationString);
            }

            if (SubBuildAssetNumber != null)
            {
                SubBuildAssetNumber.Initialize(context, SubBuildAssetNumber_InitializationString);
            }

            if (VerifyAsset != null)
            {
                VerifyAsset.Initialize(context, VerifyAsset_InitializationString);
            }
        }

        #region Initialization String
        private const string AssetId_InitializationString =
           "AwAAACIAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvRlgvQUMvHwAAAGh0dHA6Ly9vcGNmb3Vu" +
           "ZGF0aW9uLm9yZy9VQS9ESS8kAAAAaHR0cDovL29wY2ZvdW5kYXRpb24ub3JnL1VBL0ZYL0RhdGEv////" +
           "/xVgiQoCAAAAAgAHAAAAQXNzZXRJZAEBwwAALgBEwwAAAAAM/////wMD/////wAAAAA=";

        private const string BuildAssetNumber_InitializationString =
           "AwAAACIAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvRlgvQUMvHwAAAGh0dHA6Ly9vcGNmb3Vu" +
           "ZGF0aW9uLm9yZy9VQS9ESS8kAAAAaHR0cDovL29wY2ZvdW5kYXRpb24ub3JnL1VBL0ZYL0RhdGEv////" +
           "/xVgiQoCAAAAAQAQAAAAQnVpbGRBc3NldE51bWJlcgEBxgAALgBExgAAAAAF/////wMD/////wAAAAA=";

        private const string ComponentName_InitializationString =
           "AwAAACIAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvRlgvQUMvHwAAAGh0dHA6Ly9vcGNmb3Vu" +
           "ZGF0aW9uLm9yZy9VQS9ESS8kAAAAaHR0cDovL29wY2ZvdW5kYXRpb24ub3JnL1VBL0ZYL0RhdGEv////" +
           "/xVgiQoCAAAAAgANAAAAQ29tcG9uZW50TmFtZQEBuAAALgBEuAAAAAAV/////wMD/////wAAAAA=";

        private const string Connectors_InitializationString =
           "AwAAACIAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvRlgvQUMvHwAAAGh0dHA6Ly9vcGNmb3Vu" +
           "ZGF0aW9uLm9yZy9VQS9ESS8kAAAAaHR0cDovL29wY2ZvdW5kYXRpb24ub3JnL1VBL0ZYL0RhdGEv////" +
           "/wRggAoBAAAAAQAKAAAAQ29ubmVjdG9ycwEBSAAALwA9SAAAAP////8BAAAABGDACgEAAAAOAAAAQXNz" +
           "ZXRDb25uZWN0b3IBABAAAAA8QXNzZXRDb25uZWN0b3I+AQFMAAAvAQEFAEwAAAD/////AQAAABVgiQoC" +
           "AAAAAQAEAAAATmFtZQEB5QQALgBE5QQAAAAM/////wMD/////wAAAAA=";

        private const string DeviceClass_InitializationString =
           "AwAAACIAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvRlgvQUMvHwAAAGh0dHA6Ly9vcGNmb3Vu" +
           "ZGF0aW9uLm9yZy9VQS9ESS8kAAAAaHR0cDovL29wY2ZvdW5kYXRpb24ub3JnL1VBL0ZYL0RhdGEv////" +
           "/xVgiQoCAAAAAgALAAAARGV2aWNlQ2xhc3MBAb8AAC4ARL8AAAAADP////8DA/////8AAAAA";

        private const string DeviceHealth_InitializationString =
           "AwAAACIAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvRlgvQUMvHwAAAGh0dHA6Ly9vcGNmb3Vu" +
           "ZGF0aW9uLm9yZy9VQS9ESS8kAAAAaHR0cDovL29wY2ZvdW5kYXRpb24ub3JnL1VBL0ZYL0RhdGEv////" +
           "/xVgiQoCAAAAAgAMAAAARGV2aWNlSGVhbHRoAQHBFwAvAD/BFwAAAQJkGP////8DA/////8AAAAA";

        private const string DeviceHealthAlarms_InitializationString =
           "AwAAACIAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvRlgvQUMvHwAAAGh0dHA6Ly9vcGNmb3Vu" +
           "ZGF0aW9uLm9yZy9VQS9ESS8kAAAAaHR0cDovL29wY2ZvdW5kYXRpb24ub3JnL1VBL0ZYL0RhdGEv////" +
           "/wRggAoBAAAAAgASAAAARGV2aWNlSGVhbHRoQWxhcm1zAQGfEwAvAD2fEwAA/////wAAAAA=";

        private const string DeviceManual_InitializationString =
           "AwAAACIAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvRlgvQUMvHwAAAGh0dHA6Ly9vcGNmb3Vu" +
           "ZGF0aW9uLm9yZy9VQS9ESS8kAAAAaHR0cDovL29wY2ZvdW5kYXRpb24ub3JnL1VBL0ZYL0RhdGEv////" +
           "/xVgiQoCAAAAAgAMAAAARGV2aWNlTWFudWFsAQG+AAAuAES+AAAAAAz/////AwP/////AAAAAA==";

        private const string DeviceRevision_InitializationString =
           "AwAAACIAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvRlgvQUMvHwAAAGh0dHA6Ly9vcGNmb3Vu" +
           "ZGF0aW9uLm9yZy9VQS9ESS8kAAAAaHR0cDovL29wY2ZvdW5kYXRpb24ub3JnL1VBL0ZYL0RhdGEv////" +
           "/xVgiQoCAAAAAgAOAAAARGV2aWNlUmV2aXNpb24BAb0AAC4ARL0AAAAADP////8DA/////8AAAAA";

        private const string HardwareRevision_InitializationString =
           "AwAAACIAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvRlgvQUMvHwAAAGh0dHA6Ly9vcGNmb3Vu" +
           "ZGF0aW9uLm9yZy9VQS9ESS8kAAAAaHR0cDovL29wY2ZvdW5kYXRpb24ub3JnL1VBL0ZYL0RhdGEv////" +
           "/xVgiQoCAAAAAgAQAAAASGFyZHdhcmVSZXZpc2lvbgEBuwAALgBEuwAAAAAM/////wMD/////wAAAAA=";

        private const string MajorAssetVersion_InitializationString =
           "AwAAACIAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvRlgvQUMvHwAAAGh0dHA6Ly9vcGNmb3Vu" +
           "ZGF0aW9uLm9yZy9VQS9ESS8kAAAAaHR0cDovL29wY2ZvdW5kYXRpb24ub3JnL1VBL0ZYL0RhdGEv////" +
           "/xVgiQoCAAAAAQARAAAATWFqb3JBc3NldFZlcnNpb24BAcQAAC4ARMQAAAAABf////8DA/////8AAAAA";

        private const string Manufacturer_InitializationString =
           "AwAAACIAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvRlgvQUMvHwAAAGh0dHA6Ly9vcGNmb3Vu" +
           "ZGF0aW9uLm9yZy9VQS9ESS8kAAAAaHR0cDovL29wY2ZvdW5kYXRpb24ub3JnL1VBL0ZYL0RhdGEv////" +
           "/xVgiQoCAAAAAgAMAAAATWFudWZhY3R1cmVyAQGvAAAuAESvAAAAABX/////AwP/////AAAAAA==";

        private const string ManufacturerUri_InitializationString =
           "AwAAACIAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvRlgvQUMvHwAAAGh0dHA6Ly9vcGNmb3Vu" +
           "ZGF0aW9uLm9yZy9VQS9ESS8kAAAAaHR0cDovL29wY2ZvdW5kYXRpb24ub3JnL1VBL0ZYL0RhdGEv////" +
           "/xVgqQoCAAAAAgAPAAAATWFudWZhY3R1cmVyVXJpAQG5AAAuAES5AAAADAAAAAAADP////8DA/////8A" +
           "AAAA";

        private const string MinorAssetVersion_InitializationString =
           "AwAAACIAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvRlgvQUMvHwAAAGh0dHA6Ly9vcGNmb3Vu" +
           "ZGF0aW9uLm9yZy9VQS9ESS8kAAAAaHR0cDovL29wY2ZvdW5kYXRpb24ub3JnL1VBL0ZYL0RhdGEv////" +
           "/xVgiQoCAAAAAQARAAAATWlub3JBc3NldFZlcnNpb24BAcUAAC4ARMUAAAAABf////8DA/////8AAAAA";

        private const string Model_InitializationString =
           "AwAAACIAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvRlgvQUMvHwAAAGh0dHA6Ly9vcGNmb3Vu" +
           "ZGF0aW9uLm9yZy9VQS9ESS8kAAAAaHR0cDovL29wY2ZvdW5kYXRpb24ub3JnL1VBL0ZYL0RhdGEv////" +
           "/xVgiQoCAAAAAgAFAAAATW9kZWwBAbAAAC4ARLAAAAAAFf////8DA/////8AAAAA";

        private const string ProductCode_InitializationString =
           "AwAAACIAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvRlgvQUMvHwAAAGh0dHA6Ly9vcGNmb3Vu" +
           "ZGF0aW9uLm9yZy9VQS9ESS8kAAAAaHR0cDovL29wY2ZvdW5kYXRpb24ub3JnL1VBL0ZYL0RhdGEv////" +
           "/xVgiQoCAAAAAgALAAAAUHJvZHVjdENvZGUBAboAAC4ARLoAAAAADP////8DA/////8AAAAA";

        private const string ProductInstanceUri_InitializationString =
           "AwAAACIAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvRlgvQUMvHwAAAGh0dHA6Ly9vcGNmb3Vu" +
           "ZGF0aW9uLm9yZy9VQS9ESS8kAAAAaHR0cDovL29wY2ZvdW5kYXRpb24ub3JnL1VBL0ZYL0RhdGEv////" +
           "/xVgiQoCAAAAAgASAAAAUHJvZHVjdEluc3RhbmNlVXJpAQHBAAAuAETBAAAAAAz/////AwP/////AAAA" +
           "AA==";

        private const string RevisionCounter_InitializationString =
           "AwAAACIAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvRlgvQUMvHwAAAGh0dHA6Ly9vcGNmb3Vu" +
           "ZGF0aW9uLm9yZy9VQS9ESS8kAAAAaHR0cDovL29wY2ZvdW5kYXRpb24ub3JnL1VBL0ZYL0RhdGEv////" +
           "/xVgiQoCAAAAAgAPAAAAUmV2aXNpb25Db3VudGVyAQHCAAAuAETCAAAAAAb/////AwP/////AAAAAA==";

        private const string SerialNumber_InitializationString =
           "AwAAACIAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvRlgvQUMvHwAAAGh0dHA6Ly9vcGNmb3Vu" +
           "ZGF0aW9uLm9yZy9VQS9ESS8kAAAAaHR0cDovL29wY2ZvdW5kYXRpb24ub3JnL1VBL0ZYL0RhdGEv////" +
           "/xVgiQoCAAAAAgAMAAAAU2VyaWFsTnVtYmVyAQHAAAAuAETAAAAAAAz/////AwP/////AAAAAA==";

        private const string SoftwareRevision_InitializationString =
           "AwAAACIAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvRlgvQUMvHwAAAGh0dHA6Ly9vcGNmb3Vu" +
           "ZGF0aW9uLm9yZy9VQS9ESS8kAAAAaHR0cDovL29wY2ZvdW5kYXRpb24ub3JnL1VBL0ZYL0RhdGEv////" +
           "/xVgiQoCAAAAAgAQAAAAU29mdHdhcmVSZXZpc2lvbgEBvAAALgBEvAAAAAAM/////wMD/////wAAAAA=";

        private const string SoftwareUpdate_InitializationString =
           "AwAAACIAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvRlgvQUMvHwAAAGh0dHA6Ly9vcGNmb3Vu" +
           "ZGF0aW9uLm9yZy9VQS9ESS8kAAAAaHR0cDovL29wY2ZvdW5kYXRpb24ub3JnL1VBL0ZYL0RhdGEv////" +
           "/wRggAoBAAAAAgAOAAAAU29mdHdhcmVVcGRhdGUBAYoTAQDERAECAQCKEwAA/////wAAAAA=";

        private const string SubBuildAssetNumber_InitializationString =
           "AwAAACIAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvRlgvQUMvHwAAAGh0dHA6Ly9vcGNmb3Vu" +
           "ZGF0aW9uLm9yZy9VQS9ESS8kAAAAaHR0cDovL29wY2ZvdW5kYXRpb24ub3JnL1VBL0ZYL0RhdGEv////" +
           "/xVgiQoCAAAAAQATAAAAU3ViQnVpbGRBc3NldE51bWJlcgEBxwAALgBExwAAAAAF/////wMD/////wAA" +
           "AAA=";

        private const string VerifyAsset_InitializationString =
           "AwAAACIAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvRlgvQUMvHwAAAGh0dHA6Ly9vcGNmb3Vu" +
           "ZGF0aW9uLm9yZy9VQS9ESS8kAAAAaHR0cDovL29wY2ZvdW5kYXRpb24ub3JnL1VBL0ZYL0RhdGEv////" +
           "/wRhggoEAAAAAQALAAAAVmVyaWZ5QXNzZXQBAd4FAC8BAd4F3gUAAAEB/////wIAAAAXYKkKAgAAAAAA" +
           "DgAAAElucHV0QXJndW1lbnRzAQFMBQAuAERMBQAAlgMAAAABACoBASEAAAAQAAAAVmVyaWZpY2F0aW9u" +
           "TW9kZQEDBQT/////AAAAAAABACoBATIAAAAdAAAARXhwZWN0ZWRWZXJpZmljYXRpb25WYXJpYWJsZXMB" +
           "AMU4AQAAAAEAAAAAAAAAAAEAKgEBPAAAACcAAABFeHBlY3RlZEFkZGl0aW9uYWxWZXJpZmljYXRpb25W" +
           "YXJpYWJsZXMBAwQEAQAAAAEAAAAAAAAAAAEAKAEBAAAAAQAAAAMAAAABAf////8AAAAAF2CpCgIAAAAA" +
           "AA8AAABPdXRwdXRBcmd1bWVudHMBAU0FAC4ARE0FAACWAwAAAAEAKgEBIwAAABIAAABWZXJpZmljYXRp" +
           "b25SZXN1bHQBAw0E/////wAAAAAAAQAqAQEuAAAAGwAAAFZlcmlmaWNhdGlvblZhcmlhYmxlc0Vycm9y" +
           "cwATAQAAAAEAAAAAAAAAAAEAKgEBOAAAACUAAABWZXJpZmljYXRpb25BZGRpdGlvbmFsVmFyaWFibGVz" +
           "RXJyb3JzABMBAAAAAQAAAAAAAAAAAQAoAQEAAAABAAAAAwAAAAEB/////wAAAAA=";

        private const string InitializationString =
           "AwAAACIAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvRlgvQUMvHwAAAGh0dHA6Ly9vcGNmb3Vu" +
           "ZGF0aW9uLm9yZy9VQS9ESS8kAAAAaHR0cDovL29wY2ZvdW5kYXRpb24ub3JnL1VBL0ZYL0RhdGEv////" +
           "/wRggAIBAAAAAQATAAAARnhBc3NldFR5cGVJbnN0YW5jZQEBAwABAQMAAwAAAAQAAAABAMNEAAEBCQAB" +
           "AMNEAAECyzoBAMNEAAECyDoBAMNEAAECuzoXAAAAFWCJCgIAAAACAAcAAABBc3NldElkAQHDAAAuAETD" +
           "AAAAAAz/////AwP/////AAAAABVgiQoCAAAAAQAQAAAAQnVpbGRBc3NldE51bWJlcgEBxgAALgBExgAA" +
           "AAAF/////wMD/////wAAAAAVYIkKAgAAAAIADQAAAENvbXBvbmVudE5hbWUBAbgAAC4ARLgAAAAAFf//" +
           "//8DA/////8AAAAABGCACgEAAAABAAoAAABDb25uZWN0b3JzAQFIAAAvAD1IAAAA/////wEAAAAEYMAK" +
           "AQAAAA4AAABBc3NldENvbm5lY3RvcgEAEAAAADxBc3NldENvbm5lY3Rvcj4BAUwAAC8BAQUATAAAAP//" +
           "//8BAAAAFWCJCgIAAAABAAQAAABOYW1lAQHlBAAuAETlBAAAAAz/////AwP/////AAAAABVgiQoCAAAA" +
           "AgALAAAARGV2aWNlQ2xhc3MBAb8AAC4ARL8AAAAADP////8DA/////8AAAAAFWCJCgIAAAACAAwAAABE" +
           "ZXZpY2VIZWFsdGgBAcEXAC8AP8EXAAABAmQY/////wMD/////wAAAAAEYIAKAQAAAAIAEgAAAERldmlj" +
           "ZUhlYWx0aEFsYXJtcwEBnxMALwA9nxMAAP////8AAAAAFWCJCgIAAAACAAwAAABEZXZpY2VNYW51YWwB" +
           "Ab4AAC4ARL4AAAAADP////8DA/////8AAAAAFWCJCgIAAAACAA4AAABEZXZpY2VSZXZpc2lvbgEBvQAA" +
           "LgBEvQAAAAAM/////wMD/////wAAAAAVYIkKAgAAAAIAEAAAAEhhcmR3YXJlUmV2aXNpb24BAbsAAC4A" +
           "RLsAAAAADP////8DA/////8AAAAAFWCJCgIAAAABABEAAABNYWpvckFzc2V0VmVyc2lvbgEBxAAALgBE" +
           "xAAAAAAF/////wMD/////wAAAAAVYIkKAgAAAAIADAAAAE1hbnVmYWN0dXJlcgEBrwAALgBErwAAAAAV" +
           "/////wMD/////wAAAAAVYKkKAgAAAAIADwAAAE1hbnVmYWN0dXJlclVyaQEBuQAALgBEuQAAAAwAAAAA" +
           "AAz/////AwP/////AAAAABVgiQoCAAAAAQARAAAATWlub3JBc3NldFZlcnNpb24BAcUAAC4ARMUAAAAA" +
           "Bf////8DA/////8AAAAAFWCJCgIAAAACAAUAAABNb2RlbAEBsAAALgBEsAAAAAAV/////wMD/////wAA" +
           "AAAVYIkKAgAAAAIACwAAAFByb2R1Y3RDb2RlAQG6AAAuAES6AAAAAAz/////AwP/////AAAAABVgiQoC" +
           "AAAAAgASAAAAUHJvZHVjdEluc3RhbmNlVXJpAQHBAAAuAETBAAAAAAz/////AwP/////AAAAABVgiQoC" +
           "AAAAAgAPAAAAUmV2aXNpb25Db3VudGVyAQHCAAAuAETCAAAAAAb/////AwP/////AAAAABVgiQoCAAAA" +
           "AgAMAAAAU2VyaWFsTnVtYmVyAQHAAAAuAETAAAAAAAz/////AwP/////AAAAABVgiQoCAAAAAgAQAAAA" +
           "U29mdHdhcmVSZXZpc2lvbgEBvAAALgBEvAAAAAAM/////wMD/////wAAAAAEYIAKAQAAAAIADgAAAFNv" +
           "ZnR3YXJlVXBkYXRlAQGKEwEAxEQBAgEAihMAAP////8AAAAAFWCJCgIAAAABABMAAABTdWJCdWlsZEFz" +
           "c2V0TnVtYmVyAQHHAAAuAETHAAAAAAX/////AwP/////AAAAAARhggoEAAAAAQALAAAAVmVyaWZ5QXNz" +
           "ZXQBAd4FAC8BAd4F3gUAAAEB/////wIAAAAXYKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQFMBQAu" +
           "AERMBQAAlgMAAAABACoBASEAAAAQAAAAVmVyaWZpY2F0aW9uTW9kZQEDBQT/////AAAAAAABACoBATIA" +
           "AAAdAAAARXhwZWN0ZWRWZXJpZmljYXRpb25WYXJpYWJsZXMBAMU4AQAAAAEAAAAAAAAAAAEAKgEBPAAA" +
           "ACcAAABFeHBlY3RlZEFkZGl0aW9uYWxWZXJpZmljYXRpb25WYXJpYWJsZXMBAwQEAQAAAAEAAAAAAAAA" +
           "AAEAKAEBAAAAAQAAAAMAAAABAf////8AAAAAF2CpCgIAAAAAAA8AAABPdXRwdXRBcmd1bWVudHMBAU0F" +
           "AC4ARE0FAACWAwAAAAEAKgEBIwAAABIAAABWZXJpZmljYXRpb25SZXN1bHQBAw0E/////wAAAAAAAQAq" +
           "AQEuAAAAGwAAAFZlcmlmaWNhdGlvblZhcmlhYmxlc0Vycm9ycwATAQAAAAEAAAAAAAAAAAEAKgEBOAAA" +
           "ACUAAABWZXJpZmljYXRpb25BZGRpdGlvbmFsVmFyaWFibGVzRXJyb3JzABMBAAAAAQAAAAAAAAAAAQAo" +
           "AQEAAAABAAAAAwAAAAEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public PropertyState<string> AssetId
        {
            get
            {
                return m_assetId;
            }

            set
            {
                if (!Object.ReferenceEquals(m_assetId, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_assetId = value;
            }
        }

        /// <remarks />
        public PropertyState<ushort> BuildAssetNumber
        {
            get
            {
                return m_buildAssetNumber;
            }

            set
            {
                if (!Object.ReferenceEquals(m_buildAssetNumber, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_buildAssetNumber = value;
            }
        }

        /// <remarks />
        public PropertyState<LocalizedText> ComponentName
        {
            get
            {
                return m_componentName;
            }

            set
            {
                if (!Object.ReferenceEquals(m_componentName, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_componentName = value;
            }
        }

        /// <remarks />
        public FolderState Connectors
        {
            get
            {
                return m_connectors;
            }

            set
            {
                if (!Object.ReferenceEquals(m_connectors, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_connectors = value;
            }
        }

        /// <remarks />
        public PropertyState<string> DeviceClass
        {
            get
            {
                return m_deviceClass;
            }

            set
            {
                if (!Object.ReferenceEquals(m_deviceClass, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_deviceClass = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<DeviceHealthEnumeration> DeviceHealth
        {
            get
            {
                return m_deviceHealth;
            }

            set
            {
                if (!Object.ReferenceEquals(m_deviceHealth, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_deviceHealth = value;
            }
        }

        /// <remarks />
        public FolderState DeviceHealthAlarms
        {
            get
            {
                return m_deviceHealthAlarms;
            }

            set
            {
                if (!Object.ReferenceEquals(m_deviceHealthAlarms, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_deviceHealthAlarms = value;
            }
        }

        /// <remarks />
        public PropertyState<string> DeviceManual
        {
            get
            {
                return m_deviceManual;
            }

            set
            {
                if (!Object.ReferenceEquals(m_deviceManual, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_deviceManual = value;
            }
        }

        /// <remarks />
        public PropertyState<string> DeviceRevision
        {
            get
            {
                return m_deviceRevision;
            }

            set
            {
                if (!Object.ReferenceEquals(m_deviceRevision, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_deviceRevision = value;
            }
        }

        /// <remarks />
        public PropertyState<string> HardwareRevision
        {
            get
            {
                return m_hardwareRevision;
            }

            set
            {
                if (!Object.ReferenceEquals(m_hardwareRevision, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_hardwareRevision = value;
            }
        }

        /// <remarks />
        public PropertyState<ushort> MajorAssetVersion
        {
            get
            {
                return m_majorAssetVersion;
            }

            set
            {
                if (!Object.ReferenceEquals(m_majorAssetVersion, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_majorAssetVersion = value;
            }
        }

        /// <remarks />
        public PropertyState<LocalizedText> Manufacturer
        {
            get
            {
                return m_manufacturer;
            }

            set
            {
                if (!Object.ReferenceEquals(m_manufacturer, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_manufacturer = value;
            }
        }

        /// <remarks />
        public PropertyState<string> ManufacturerUri
        {
            get
            {
                return m_manufacturerUri;
            }

            set
            {
                if (!Object.ReferenceEquals(m_manufacturerUri, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_manufacturerUri = value;
            }
        }

        /// <remarks />
        public PropertyState<ushort> MinorAssetVersion
        {
            get
            {
                return m_minorAssetVersion;
            }

            set
            {
                if (!Object.ReferenceEquals(m_minorAssetVersion, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_minorAssetVersion = value;
            }
        }

        /// <remarks />
        public PropertyState<LocalizedText> Model
        {
            get
            {
                return m_model;
            }

            set
            {
                if (!Object.ReferenceEquals(m_model, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_model = value;
            }
        }

        /// <remarks />
        public PropertyState<string> ProductCode
        {
            get
            {
                return m_productCode;
            }

            set
            {
                if (!Object.ReferenceEquals(m_productCode, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_productCode = value;
            }
        }

        /// <remarks />
        public PropertyState<string> ProductInstanceUri
        {
            get
            {
                return m_productInstanceUri;
            }

            set
            {
                if (!Object.ReferenceEquals(m_productInstanceUri, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_productInstanceUri = value;
            }
        }

        /// <remarks />
        public PropertyState<int> RevisionCounter
        {
            get
            {
                return m_revisionCounter;
            }

            set
            {
                if (!Object.ReferenceEquals(m_revisionCounter, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_revisionCounter = value;
            }
        }

        /// <remarks />
        public PropertyState<string> SerialNumber
        {
            get
            {
                return m_serialNumber;
            }

            set
            {
                if (!Object.ReferenceEquals(m_serialNumber, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_serialNumber = value;
            }
        }

        /// <remarks />
        public PropertyState<string> SoftwareRevision
        {
            get
            {
                return m_softwareRevision;
            }

            set
            {
                if (!Object.ReferenceEquals(m_softwareRevision, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_softwareRevision = value;
            }
        }

        /// <remarks />
        public SoftwareUpdateTypeState SoftwareUpdate
        {
            get
            {
                return m_softwareUpdate;
            }

            set
            {
                if (!Object.ReferenceEquals(m_softwareUpdate, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_softwareUpdate = value;
            }
        }

        /// <remarks />
        public PropertyState<ushort> SubBuildAssetNumber
        {
            get
            {
                return m_subBuildAssetNumber;
            }

            set
            {
                if (!Object.ReferenceEquals(m_subBuildAssetNumber, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_subBuildAssetNumber = value;
            }
        }

        /// <remarks />
        public VerifyAssetMethodState VerifyAsset
        {
            get
            {
                return m_verifyAssetMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_verifyAssetMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_verifyAssetMethod = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_assetId != null)
            {
                children.Add(m_assetId);
            }

            if (m_buildAssetNumber != null)
            {
                children.Add(m_buildAssetNumber);
            }

            if (m_componentName != null)
            {
                children.Add(m_componentName);
            }

            if (m_connectors != null)
            {
                children.Add(m_connectors);
            }

            if (m_deviceClass != null)
            {
                children.Add(m_deviceClass);
            }

            if (m_deviceHealth != null)
            {
                children.Add(m_deviceHealth);
            }

            if (m_deviceHealthAlarms != null)
            {
                children.Add(m_deviceHealthAlarms);
            }

            if (m_deviceManual != null)
            {
                children.Add(m_deviceManual);
            }

            if (m_deviceRevision != null)
            {
                children.Add(m_deviceRevision);
            }

            if (m_hardwareRevision != null)
            {
                children.Add(m_hardwareRevision);
            }

            if (m_majorAssetVersion != null)
            {
                children.Add(m_majorAssetVersion);
            }

            if (m_manufacturer != null)
            {
                children.Add(m_manufacturer);
            }

            if (m_manufacturerUri != null)
            {
                children.Add(m_manufacturerUri);
            }

            if (m_minorAssetVersion != null)
            {
                children.Add(m_minorAssetVersion);
            }

            if (m_model != null)
            {
                children.Add(m_model);
            }

            if (m_productCode != null)
            {
                children.Add(m_productCode);
            }

            if (m_productInstanceUri != null)
            {
                children.Add(m_productInstanceUri);
            }

            if (m_revisionCounter != null)
            {
                children.Add(m_revisionCounter);
            }

            if (m_serialNumber != null)
            {
                children.Add(m_serialNumber);
            }

            if (m_softwareRevision != null)
            {
                children.Add(m_softwareRevision);
            }

            if (m_softwareUpdate != null)
            {
                children.Add(m_softwareUpdate);
            }

            if (m_subBuildAssetNumber != null)
            {
                children.Add(m_subBuildAssetNumber);
            }

            if (m_verifyAssetMethod != null)
            {
                children.Add(m_verifyAssetMethod);
            }

            base.GetChildren(context, children);
        }
            
        /// <remarks />
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case UAModel.DI.BrowseNames.AssetId:
                {
                    if (createOrReplace)
                    {
                        if (AssetId == null)
                        {
                            if (replacement == null)
                            {
                                AssetId = new PropertyState<string>(this);
                            }
                            else
                            {
                                AssetId = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = AssetId;
                    break;
                }

                case UAModel.FXAC.BrowseNames.BuildAssetNumber:
                {
                    if (createOrReplace)
                    {
                        if (BuildAssetNumber == null)
                        {
                            if (replacement == null)
                            {
                                BuildAssetNumber = new PropertyState<ushort>(this);
                            }
                            else
                            {
                                BuildAssetNumber = (PropertyState<ushort>)replacement;
                            }
                        }
                    }

                    instance = BuildAssetNumber;
                    break;
                }

                case UAModel.DI.BrowseNames.ComponentName:
                {
                    if (createOrReplace)
                    {
                        if (ComponentName == null)
                        {
                            if (replacement == null)
                            {
                                ComponentName = new PropertyState<LocalizedText>(this);
                            }
                            else
                            {
                                ComponentName = (PropertyState<LocalizedText>)replacement;
                            }
                        }
                    }

                    instance = ComponentName;
                    break;
                }

                case UAModel.FXAC.BrowseNames.Connectors:
                {
                    if (createOrReplace)
                    {
                        if (Connectors == null)
                        {
                            if (replacement == null)
                            {
                                Connectors = new FolderState(this);
                            }
                            else
                            {
                                Connectors = (FolderState)replacement;
                            }
                        }
                    }

                    instance = Connectors;
                    break;
                }

                case UAModel.DI.BrowseNames.DeviceClass:
                {
                    if (createOrReplace)
                    {
                        if (DeviceClass == null)
                        {
                            if (replacement == null)
                            {
                                DeviceClass = new PropertyState<string>(this);
                            }
                            else
                            {
                                DeviceClass = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = DeviceClass;
                    break;
                }

                case UAModel.DI.BrowseNames.DeviceHealth:
                {
                    if (createOrReplace)
                    {
                        if (DeviceHealth == null)
                        {
                            if (replacement == null)
                            {
                                DeviceHealth = new BaseDataVariableState<DeviceHealthEnumeration>(this);
                            }
                            else
                            {
                                DeviceHealth = (BaseDataVariableState<DeviceHealthEnumeration>)replacement;
                            }
                        }
                    }

                    instance = DeviceHealth;
                    break;
                }

                case UAModel.DI.BrowseNames.DeviceHealthAlarms:
                {
                    if (createOrReplace)
                    {
                        if (DeviceHealthAlarms == null)
                        {
                            if (replacement == null)
                            {
                                DeviceHealthAlarms = new FolderState(this);
                            }
                            else
                            {
                                DeviceHealthAlarms = (FolderState)replacement;
                            }
                        }
                    }

                    instance = DeviceHealthAlarms;
                    break;
                }

                case UAModel.DI.BrowseNames.DeviceManual:
                {
                    if (createOrReplace)
                    {
                        if (DeviceManual == null)
                        {
                            if (replacement == null)
                            {
                                DeviceManual = new PropertyState<string>(this);
                            }
                            else
                            {
                                DeviceManual = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = DeviceManual;
                    break;
                }

                case UAModel.DI.BrowseNames.DeviceRevision:
                {
                    if (createOrReplace)
                    {
                        if (DeviceRevision == null)
                        {
                            if (replacement == null)
                            {
                                DeviceRevision = new PropertyState<string>(this);
                            }
                            else
                            {
                                DeviceRevision = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = DeviceRevision;
                    break;
                }

                case UAModel.DI.BrowseNames.HardwareRevision:
                {
                    if (createOrReplace)
                    {
                        if (HardwareRevision == null)
                        {
                            if (replacement == null)
                            {
                                HardwareRevision = new PropertyState<string>(this);
                            }
                            else
                            {
                                HardwareRevision = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = HardwareRevision;
                    break;
                }

                case UAModel.FXAC.BrowseNames.MajorAssetVersion:
                {
                    if (createOrReplace)
                    {
                        if (MajorAssetVersion == null)
                        {
                            if (replacement == null)
                            {
                                MajorAssetVersion = new PropertyState<ushort>(this);
                            }
                            else
                            {
                                MajorAssetVersion = (PropertyState<ushort>)replacement;
                            }
                        }
                    }

                    instance = MajorAssetVersion;
                    break;
                }

                case UAModel.DI.BrowseNames.Manufacturer:
                {
                    if (createOrReplace)
                    {
                        if (Manufacturer == null)
                        {
                            if (replacement == null)
                            {
                                Manufacturer = new PropertyState<LocalizedText>(this);
                            }
                            else
                            {
                                Manufacturer = (PropertyState<LocalizedText>)replacement;
                            }
                        }
                    }

                    instance = Manufacturer;
                    break;
                }

                case UAModel.DI.BrowseNames.ManufacturerUri:
                {
                    if (createOrReplace)
                    {
                        if (ManufacturerUri == null)
                        {
                            if (replacement == null)
                            {
                                ManufacturerUri = new PropertyState<string>(this);
                            }
                            else
                            {
                                ManufacturerUri = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = ManufacturerUri;
                    break;
                }

                case UAModel.FXAC.BrowseNames.MinorAssetVersion:
                {
                    if (createOrReplace)
                    {
                        if (MinorAssetVersion == null)
                        {
                            if (replacement == null)
                            {
                                MinorAssetVersion = new PropertyState<ushort>(this);
                            }
                            else
                            {
                                MinorAssetVersion = (PropertyState<ushort>)replacement;
                            }
                        }
                    }

                    instance = MinorAssetVersion;
                    break;
                }

                case UAModel.DI.BrowseNames.Model:
                {
                    if (createOrReplace)
                    {
                        if (Model == null)
                        {
                            if (replacement == null)
                            {
                                Model = new PropertyState<LocalizedText>(this);
                            }
                            else
                            {
                                Model = (PropertyState<LocalizedText>)replacement;
                            }
                        }
                    }

                    instance = Model;
                    break;
                }

                case UAModel.DI.BrowseNames.ProductCode:
                {
                    if (createOrReplace)
                    {
                        if (ProductCode == null)
                        {
                            if (replacement == null)
                            {
                                ProductCode = new PropertyState<string>(this);
                            }
                            else
                            {
                                ProductCode = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = ProductCode;
                    break;
                }

                case UAModel.DI.BrowseNames.ProductInstanceUri:
                {
                    if (createOrReplace)
                    {
                        if (ProductInstanceUri == null)
                        {
                            if (replacement == null)
                            {
                                ProductInstanceUri = new PropertyState<string>(this);
                            }
                            else
                            {
                                ProductInstanceUri = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = ProductInstanceUri;
                    break;
                }

                case UAModel.DI.BrowseNames.RevisionCounter:
                {
                    if (createOrReplace)
                    {
                        if (RevisionCounter == null)
                        {
                            if (replacement == null)
                            {
                                RevisionCounter = new PropertyState<int>(this);
                            }
                            else
                            {
                                RevisionCounter = (PropertyState<int>)replacement;
                            }
                        }
                    }

                    instance = RevisionCounter;
                    break;
                }

                case UAModel.DI.BrowseNames.SerialNumber:
                {
                    if (createOrReplace)
                    {
                        if (SerialNumber == null)
                        {
                            if (replacement == null)
                            {
                                SerialNumber = new PropertyState<string>(this);
                            }
                            else
                            {
                                SerialNumber = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = SerialNumber;
                    break;
                }

                case UAModel.DI.BrowseNames.SoftwareRevision:
                {
                    if (createOrReplace)
                    {
                        if (SoftwareRevision == null)
                        {
                            if (replacement == null)
                            {
                                SoftwareRevision = new PropertyState<string>(this);
                            }
                            else
                            {
                                SoftwareRevision = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = SoftwareRevision;
                    break;
                }

                case UAModel.DI.BrowseNames.SoftwareUpdate:
                {
                    if (createOrReplace)
                    {
                        if (SoftwareUpdate == null)
                        {
                            if (replacement == null)
                            {
                                SoftwareUpdate = new SoftwareUpdateTypeState(this);
                            }
                            else
                            {
                                SoftwareUpdate = (SoftwareUpdateTypeState)replacement;
                            }
                        }
                    }

                    instance = SoftwareUpdate;
                    break;
                }

                case UAModel.FXAC.BrowseNames.SubBuildAssetNumber:
                {
                    if (createOrReplace)
                    {
                        if (SubBuildAssetNumber == null)
                        {
                            if (replacement == null)
                            {
                                SubBuildAssetNumber = new PropertyState<ushort>(this);
                            }
                            else
                            {
                                SubBuildAssetNumber = (PropertyState<ushort>)replacement;
                            }
                        }
                    }

                    instance = SubBuildAssetNumber;
                    break;
                }

                case UAModel.FXAC.BrowseNames.VerifyAsset:
                {
                    if (createOrReplace)
                    {
                        if (VerifyAsset == null)
                        {
                            if (replacement == null)
                            {
                                VerifyAsset = new VerifyAssetMethodState(this);
                            }
                            else
                            {
                                VerifyAsset = (VerifyAssetMethodState)replacement;
                            }
                        }
                    }

                    instance = VerifyAsset;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private PropertyState<string> m_assetId;
        private PropertyState<ushort> m_buildAssetNumber;
        private PropertyState<LocalizedText> m_componentName;
        private FolderState m_connectors;
        private PropertyState<string> m_deviceClass;
        private BaseDataVariableState<DeviceHealthEnumeration> m_deviceHealth;
        private FolderState m_deviceHealthAlarms;
        private PropertyState<string> m_deviceManual;
        private PropertyState<string> m_deviceRevision;
        private PropertyState<string> m_hardwareRevision;
        private PropertyState<ushort> m_majorAssetVersion;
        private PropertyState<LocalizedText> m_manufacturer;
        private PropertyState<string> m_manufacturerUri;
        private PropertyState<ushort> m_minorAssetVersion;
        private PropertyState<LocalizedText> m_model;
        private PropertyState<string> m_productCode;
        private PropertyState<string> m_productInstanceUri;
        private PropertyState<int> m_revisionCounter;
        private PropertyState<string> m_serialNumber;
        private PropertyState<string> m_softwareRevision;
        private SoftwareUpdateTypeState m_softwareUpdate;
        private PropertyState<ushort> m_subBuildAssetNumber;
        private VerifyAssetMethodState m_verifyAssetMethod;
        #endregion
    }
    #endif
    #endregion

    #region PublisherCapabilitiesTypeState Class
    #if (!OPCUA_EXCLUDE_PublisherCapabilitiesTypeState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class PublisherCapabilitiesTypeState : BaseObjectState
    {
        #region Constructors
        /// <remarks />
        public PublisherCapabilitiesTypeState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(UAModel.FXAC.ObjectTypes.PublisherCapabilitiesType, UAModel.FXAC.Namespaces.FXAC, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AwAAACIAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvRlgvQUMvHwAAAGh0dHA6Ly9vcGNmb3Vu" +
           "ZGF0aW9uLm9yZy9VQS9ESS8kAAAAaHR0cDovL29wY2ZvdW5kYXRpb24ub3JnL1VBL0ZYL0RhdGEv////" +
           "/wRggAIBAAAAAQAhAAAAUHVibGlzaGVyQ2FwYWJpbGl0aWVzVHlwZUluc3RhbmNlAQHrAwEB6wPrAwAA" +
           "/////wQAAAAVYIkKAgAAAAEAGAAAAFByZWNvbmZpZ3VyZWREYXRhU2V0T25seQEBhxcALwA/hxcAAAAB" +
           "/////wMD/////wAAAAAXYIkKAgAAAAEAHgAAAFByZWNvbmZpZ3VyZWRQdWJsaXNoZWREYXRhU2V0cwEB" +
           "hhcALwA/hhcAAAAMAQAAAAEAAAAAAAAAAwP/////AAAAABdgiQoCAAAAAQAcAAAAU3VwcG9ydGVkUHVi" +
           "bGlzaGluZ0ludGVydmFscwEBhBcALwA/hBcAAAEBwAsBAAAAAQAAAAAAAAADA/////8AAAAAF2CJCgIA" +
           "AAABAAwAAABTdXBwb3J0ZWRRb3MBAYUXAC8AP4UXAAABAcMLAQAAAAEAAAAAAAAAAwP/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public BaseDataVariableState<bool> PreconfiguredDataSetOnly
        {
            get
            {
                return m_preconfiguredDataSetOnly;
            }

            set
            {
                if (!Object.ReferenceEquals(m_preconfiguredDataSetOnly, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_preconfiguredDataSetOnly = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<string[]> PreconfiguredPublishedDataSets
        {
            get
            {
                return m_preconfiguredPublishedDataSets;
            }

            set
            {
                if (!Object.ReferenceEquals(m_preconfiguredPublishedDataSets, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_preconfiguredPublishedDataSets = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<IntervalRange[]> SupportedPublishingIntervals
        {
            get
            {
                return m_supportedPublishingIntervals;
            }

            set
            {
                if (!Object.ReferenceEquals(m_supportedPublishingIntervals, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_supportedPublishingIntervals = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<PublisherQosDataType[]> SupportedQos
        {
            get
            {
                return m_supportedQos;
            }

            set
            {
                if (!Object.ReferenceEquals(m_supportedQos, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_supportedQos = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_preconfiguredDataSetOnly != null)
            {
                children.Add(m_preconfiguredDataSetOnly);
            }

            if (m_preconfiguredPublishedDataSets != null)
            {
                children.Add(m_preconfiguredPublishedDataSets);
            }

            if (m_supportedPublishingIntervals != null)
            {
                children.Add(m_supportedPublishingIntervals);
            }

            if (m_supportedQos != null)
            {
                children.Add(m_supportedQos);
            }

            base.GetChildren(context, children);
        }
            
        /// <remarks />
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case UAModel.FXAC.BrowseNames.PreconfiguredDataSetOnly:
                {
                    if (createOrReplace)
                    {
                        if (PreconfiguredDataSetOnly == null)
                        {
                            if (replacement == null)
                            {
                                PreconfiguredDataSetOnly = new BaseDataVariableState<bool>(this);
                            }
                            else
                            {
                                PreconfiguredDataSetOnly = (BaseDataVariableState<bool>)replacement;
                            }
                        }
                    }

                    instance = PreconfiguredDataSetOnly;
                    break;
                }

                case UAModel.FXAC.BrowseNames.PreconfiguredPublishedDataSets:
                {
                    if (createOrReplace)
                    {
                        if (PreconfiguredPublishedDataSets == null)
                        {
                            if (replacement == null)
                            {
                                PreconfiguredPublishedDataSets = new BaseDataVariableState<string[]>(this);
                            }
                            else
                            {
                                PreconfiguredPublishedDataSets = (BaseDataVariableState<string[]>)replacement;
                            }
                        }
                    }

                    instance = PreconfiguredPublishedDataSets;
                    break;
                }

                case UAModel.FXAC.BrowseNames.SupportedPublishingIntervals:
                {
                    if (createOrReplace)
                    {
                        if (SupportedPublishingIntervals == null)
                        {
                            if (replacement == null)
                            {
                                SupportedPublishingIntervals = new BaseDataVariableState<IntervalRange[]>(this);
                            }
                            else
                            {
                                SupportedPublishingIntervals = (BaseDataVariableState<IntervalRange[]>)replacement;
                            }
                        }
                    }

                    instance = SupportedPublishingIntervals;
                    break;
                }

                case UAModel.FXAC.BrowseNames.SupportedQos:
                {
                    if (createOrReplace)
                    {
                        if (SupportedQos == null)
                        {
                            if (replacement == null)
                            {
                                SupportedQos = new BaseDataVariableState<PublisherQosDataType[]>(this);
                            }
                            else
                            {
                                SupportedQos = (BaseDataVariableState<PublisherQosDataType[]>)replacement;
                            }
                        }
                    }

                    instance = SupportedQos;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private BaseDataVariableState<bool> m_preconfiguredDataSetOnly;
        private BaseDataVariableState<string[]> m_preconfiguredPublishedDataSets;
        private BaseDataVariableState<IntervalRange[]> m_supportedPublishingIntervals;
        private BaseDataVariableState<PublisherQosDataType[]> m_supportedQos;
        #endregion
    }
    #endif
    #endregion

    #region SubscriberCapabilitiesTypeState Class
    #if (!OPCUA_EXCLUDE_SubscriberCapabilitiesTypeState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class SubscriberCapabilitiesTypeState : BaseObjectState
    {
        #region Constructors
        /// <remarks />
        public SubscriberCapabilitiesTypeState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(UAModel.FXAC.ObjectTypes.SubscriberCapabilitiesType, UAModel.FXAC.Namespaces.FXAC, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AwAAACIAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvRlgvQUMvHwAAAGh0dHA6Ly9vcGNmb3Vu" +
           "ZGF0aW9uLm9yZy9VQS9ESS8kAAAAaHR0cDovL29wY2ZvdW5kYXRpb24ub3JnL1VBL0ZYL0RhdGEv////" +
           "/wRggAIBAAAAAQAiAAAAU3Vic2NyaWJlckNhcGFiaWxpdGllc1R5cGVJbnN0YW5jZQEB7AMBAewD7AMA" +
           "AP////8FAAAAFWCJCgIAAAABABgAAABQcmVjb25maWd1cmVkRGF0YVNldE9ubHkBAYwXAC8AP4wXAAAA" +
           "Af////8DA/////8AAAAAF2CJCgIAAAABAB8AAABQcmVjb25maWd1cmVkU3Vic2NyaWJlZERhdGFTZXRz" +
           "AQGLFwAvAD+LFwAAAAwBAAAAAQAAAAAAAAADA/////8AAAAAF2CJCgIAAAABAB8AAABTdXBwb3J0ZWRN" +
           "ZXNzYWdlUmVjZWl2ZVRpbWVvdXRzAQGKFwAvAD+KFwAAAQHACwEAAAABAAAAAAAAAAMD/////wAAAAAX" +
           "YIkKAgAAAAEAHAAAAFN1cHBvcnRlZFB1Ymxpc2hpbmdJbnRlcnZhbHMBAYgXAC8AP4gXAAABAcALAQAA" +
           "AAEAAAAAAAAAAwP/////AAAAABdgiQoCAAAAAQAMAAAAU3VwcG9ydGVkUW9zAQGJFwAvAD+JFwAAAQHE" +
           "CwEAAAABAAAAAAAAAAMD/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public BaseDataVariableState<bool> PreconfiguredDataSetOnly
        {
            get
            {
                return m_preconfiguredDataSetOnly;
            }

            set
            {
                if (!Object.ReferenceEquals(m_preconfiguredDataSetOnly, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_preconfiguredDataSetOnly = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<string[]> PreconfiguredSubscribedDataSets
        {
            get
            {
                return m_preconfiguredSubscribedDataSets;
            }

            set
            {
                if (!Object.ReferenceEquals(m_preconfiguredSubscribedDataSets, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_preconfiguredSubscribedDataSets = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<IntervalRange[]> SupportedMessageReceiveTimeouts
        {
            get
            {
                return m_supportedMessageReceiveTimeouts;
            }

            set
            {
                if (!Object.ReferenceEquals(m_supportedMessageReceiveTimeouts, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_supportedMessageReceiveTimeouts = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<IntervalRange[]> SupportedPublishingIntervals
        {
            get
            {
                return m_supportedPublishingIntervals;
            }

            set
            {
                if (!Object.ReferenceEquals(m_supportedPublishingIntervals, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_supportedPublishingIntervals = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<SubscriberQosDataType[]> SupportedQos
        {
            get
            {
                return m_supportedQos;
            }

            set
            {
                if (!Object.ReferenceEquals(m_supportedQos, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_supportedQos = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_preconfiguredDataSetOnly != null)
            {
                children.Add(m_preconfiguredDataSetOnly);
            }

            if (m_preconfiguredSubscribedDataSets != null)
            {
                children.Add(m_preconfiguredSubscribedDataSets);
            }

            if (m_supportedMessageReceiveTimeouts != null)
            {
                children.Add(m_supportedMessageReceiveTimeouts);
            }

            if (m_supportedPublishingIntervals != null)
            {
                children.Add(m_supportedPublishingIntervals);
            }

            if (m_supportedQos != null)
            {
                children.Add(m_supportedQos);
            }

            base.GetChildren(context, children);
        }
            
        /// <remarks />
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case UAModel.FXAC.BrowseNames.PreconfiguredDataSetOnly:
                {
                    if (createOrReplace)
                    {
                        if (PreconfiguredDataSetOnly == null)
                        {
                            if (replacement == null)
                            {
                                PreconfiguredDataSetOnly = new BaseDataVariableState<bool>(this);
                            }
                            else
                            {
                                PreconfiguredDataSetOnly = (BaseDataVariableState<bool>)replacement;
                            }
                        }
                    }

                    instance = PreconfiguredDataSetOnly;
                    break;
                }

                case UAModel.FXAC.BrowseNames.PreconfiguredSubscribedDataSets:
                {
                    if (createOrReplace)
                    {
                        if (PreconfiguredSubscribedDataSets == null)
                        {
                            if (replacement == null)
                            {
                                PreconfiguredSubscribedDataSets = new BaseDataVariableState<string[]>(this);
                            }
                            else
                            {
                                PreconfiguredSubscribedDataSets = (BaseDataVariableState<string[]>)replacement;
                            }
                        }
                    }

                    instance = PreconfiguredSubscribedDataSets;
                    break;
                }

                case UAModel.FXAC.BrowseNames.SupportedMessageReceiveTimeouts:
                {
                    if (createOrReplace)
                    {
                        if (SupportedMessageReceiveTimeouts == null)
                        {
                            if (replacement == null)
                            {
                                SupportedMessageReceiveTimeouts = new BaseDataVariableState<IntervalRange[]>(this);
                            }
                            else
                            {
                                SupportedMessageReceiveTimeouts = (BaseDataVariableState<IntervalRange[]>)replacement;
                            }
                        }
                    }

                    instance = SupportedMessageReceiveTimeouts;
                    break;
                }

                case UAModel.FXAC.BrowseNames.SupportedPublishingIntervals:
                {
                    if (createOrReplace)
                    {
                        if (SupportedPublishingIntervals == null)
                        {
                            if (replacement == null)
                            {
                                SupportedPublishingIntervals = new BaseDataVariableState<IntervalRange[]>(this);
                            }
                            else
                            {
                                SupportedPublishingIntervals = (BaseDataVariableState<IntervalRange[]>)replacement;
                            }
                        }
                    }

                    instance = SupportedPublishingIntervals;
                    break;
                }

                case UAModel.FXAC.BrowseNames.SupportedQos:
                {
                    if (createOrReplace)
                    {
                        if (SupportedQos == null)
                        {
                            if (replacement == null)
                            {
                                SupportedQos = new BaseDataVariableState<SubscriberQosDataType[]>(this);
                            }
                            else
                            {
                                SupportedQos = (BaseDataVariableState<SubscriberQosDataType[]>)replacement;
                            }
                        }
                    }

                    instance = SupportedQos;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private BaseDataVariableState<bool> m_preconfiguredDataSetOnly;
        private BaseDataVariableState<string[]> m_preconfiguredSubscribedDataSets;
        private BaseDataVariableState<IntervalRange[]> m_supportedMessageReceiveTimeouts;
        private BaseDataVariableState<IntervalRange[]> m_supportedPublishingIntervals;
        private BaseDataVariableState<SubscriberQosDataType[]> m_supportedQos;
        #endregion
    }
    #endif
    #endregion

    #region CloseConnectionsMethodState Class
    #if (!OPCUA_EXCLUDE_CloseConnectionsMethodState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class CloseConnectionsMethodState : MethodState
    {
        #region Constructors
        /// <remarks />
        public CloseConnectionsMethodState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        public new static NodeState Construct(NodeState parent)
        {
            return new CloseConnectionsMethodState(parent);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AwAAACIAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvRlgvQUMvHwAAAGh0dHA6Ly9vcGNmb3Vu" +
           "ZGF0aW9uLm9yZy9VQS9ESS8kAAAAaHR0cDovL29wY2ZvdW5kYXRpb24ub3JnL1VBL0ZYL0RhdGEv////" +
           "/wRhggAEAAAAAQAaAAAAQ2xvc2VDb25uZWN0aW9uc01ldGhvZFR5cGUBAQAAAQEAAAEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Event Callbacks
        /// <remarks />
        public CloseConnectionsMethodStateMethodCallHandler OnCall;
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        /// <remarks />
        protected override ServiceResult Call(
            ISystemContext _context,
            NodeId _objectId,
            IList<object> _inputArguments,
            IList<object> _outputArguments)
        {
            if (OnCall == null)
            {
                return base.Call(_context, _objectId, _inputArguments, _outputArguments);
            }

            ServiceResult _result = null;

            NodeId[] connectionEndpoints = (NodeId[])_inputArguments[0];
            bool remove = (bool)_inputArguments[1];

            StatusCode[] results = (StatusCode[])_outputArguments[0];

            if (OnCall != null)
            {
                _result = OnCall(
                    _context,
                    this,
                    _objectId,
                    connectionEndpoints,
                    remove,
                    ref results);
            }

            _outputArguments[0] = results;

            return _result;
        }
        #endregion

        #region Private Fields
        #endregion
    }

    /// <remarks />
    /// <exclude />
    public delegate ServiceResult CloseConnectionsMethodStateMethodCallHandler(
        ISystemContext _context,
        MethodState _method,
        NodeId _objectId,
        NodeId[] connectionEndpoints,
        bool remove,
        ref StatusCode[] results);
    #endif
    #endregion

    #region EstablishConnectionsMethodState Class
    #if (!OPCUA_EXCLUDE_EstablishConnectionsMethodState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class EstablishConnectionsMethodState : MethodState
    {
        #region Constructors
        /// <remarks />
        public EstablishConnectionsMethodState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        public new static NodeState Construct(NodeState parent)
        {
            return new EstablishConnectionsMethodState(parent);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AwAAACIAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvRlgvQUMvHwAAAGh0dHA6Ly9vcGNmb3Vu" +
           "ZGF0aW9uLm9yZy9VQS9ESS8kAAAAaHR0cDovL29wY2ZvdW5kYXRpb24ub3JnL1VBL0ZYL0RhdGEv////" +
           "/wRhggAEAAAAAQAeAAAARXN0YWJsaXNoQ29ubmVjdGlvbnNNZXRob2RUeXBlAQEAAAEBAAABAf////8A" +
           "AAAA";
        #endregion
        #endif
        #endregion

        #region Event Callbacks
        /// <remarks />
        public EstablishConnectionsMethodStateMethodCallHandler OnCall;
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        /// <remarks />
        protected override ServiceResult Call(
            ISystemContext _context,
            NodeId _objectId,
            IList<object> _inputArguments,
            IList<object> _outputArguments)
        {
            if (OnCall == null)
            {
                return base.Call(_context, _objectId, _inputArguments, _outputArguments);
            }

            ServiceResult _result = null;

            uint commandMask = (uint)_inputArguments[0];
            UAModel.FXData.AssetVerificationDataType[] assetVerifications = (UAModel.FXData.AssetVerificationDataType[])ExtensionObject.ToArray(_inputArguments[1], typeof(UAModel.FXData.AssetVerificationDataType));
            UAModel.FXData.ConnectionEndpointConfigurationDataType[] connectionEndpointConfigurations = (UAModel.FXData.ConnectionEndpointConfigurationDataType[])ExtensionObject.ToArray(_inputArguments[2], typeof(UAModel.FXData.ConnectionEndpointConfigurationDataType));
            UAModel.FXData.ReserveCommunicationIdsDataType[] reserveCommunicationIds = (UAModel.FXData.ReserveCommunicationIdsDataType[])ExtensionObject.ToArray(_inputArguments[3], typeof(UAModel.FXData.ReserveCommunicationIdsDataType));
            UAModel.FXData.CommunicationConfigurationDataType[] communicationConfigurations = (UAModel.FXData.CommunicationConfigurationDataType[])ExtensionObject.ToArray(_inputArguments[4], typeof(UAModel.FXData.CommunicationConfigurationDataType));

            UAModel.FXData.AssetVerificationResultDataType[] assetVerificationResults = (UAModel.FXData.AssetVerificationResultDataType[])_outputArguments[0];
            UAModel.FXData.ConnectionEndpointConfigurationResultDataType[] connectionEndpointConfigurationResults = (UAModel.FXData.ConnectionEndpointConfigurationResultDataType[])_outputArguments[1];
            UAModel.FXData.ReserveCommunicationIdsResultDataType[] reserveCommunicationIdsResults = (UAModel.FXData.ReserveCommunicationIdsResultDataType[])_outputArguments[2];
            UAModel.FXData.CommunicationConfigurationResultDataType[] communicationConfigurationResults = (UAModel.FXData.CommunicationConfigurationResultDataType[])_outputArguments[3];

            if (OnCall != null)
            {
                _result = OnCall(
                    _context,
                    this,
                    _objectId,
                    commandMask,
                    assetVerifications,
                    connectionEndpointConfigurations,
                    reserveCommunicationIds,
                    communicationConfigurations,
                    ref assetVerificationResults,
                    ref connectionEndpointConfigurationResults,
                    ref reserveCommunicationIdsResults,
                    ref communicationConfigurationResults);
            }

            _outputArguments[0] = assetVerificationResults;
            _outputArguments[1] = connectionEndpointConfigurationResults;
            _outputArguments[2] = reserveCommunicationIdsResults;
            _outputArguments[3] = communicationConfigurationResults;

            return _result;
        }
        #endregion

        #region Private Fields
        #endregion
    }

    /// <remarks />
    /// <exclude />
    public delegate ServiceResult EstablishConnectionsMethodStateMethodCallHandler(
        ISystemContext _context,
        MethodState _method,
        NodeId _objectId,
        uint commandMask,
        UAModel.FXData.AssetVerificationDataType[] assetVerifications,
        UAModel.FXData.ConnectionEndpointConfigurationDataType[] connectionEndpointConfigurations,
        UAModel.FXData.ReserveCommunicationIdsDataType[] reserveCommunicationIds,
        UAModel.FXData.CommunicationConfigurationDataType[] communicationConfigurations,
        ref UAModel.FXData.AssetVerificationResultDataType[] assetVerificationResults,
        ref UAModel.FXData.ConnectionEndpointConfigurationResultDataType[] connectionEndpointConfigurationResults,
        ref UAModel.FXData.ReserveCommunicationIdsResultDataType[] reserveCommunicationIdsResults,
        ref UAModel.FXData.CommunicationConfigurationResultDataType[] communicationConfigurationResults);
    #endif
    #endregion

    #region VerifyAssetMethodState Class
    #if (!OPCUA_EXCLUDE_VerifyAssetMethodState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class VerifyAssetMethodState : MethodState
    {
        #region Constructors
        /// <remarks />
        public VerifyAssetMethodState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        public new static NodeState Construct(NodeState parent)
        {
            return new VerifyAssetMethodState(parent);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AwAAACIAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvRlgvQUMvHwAAAGh0dHA6Ly9vcGNmb3Vu" +
           "ZGF0aW9uLm9yZy9VQS9ESS8kAAAAaHR0cDovL29wY2ZvdW5kYXRpb24ub3JnL1VBL0ZYL0RhdGEv////" +
           "/wRhggAEAAAAAQAVAAAAVmVyaWZ5QXNzZXRNZXRob2RUeXBlAQEAAAEBAAABAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Event Callbacks
        /// <remarks />
        public VerifyAssetMethodStateMethodCallHandler OnCall;
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        /// <remarks />
        protected override ServiceResult Call(
            ISystemContext _context,
            NodeId _objectId,
            IList<object> _inputArguments,
            IList<object> _outputArguments)
        {
            if (OnCall == null)
            {
                return base.Call(_context, _objectId, _inputArguments, _outputArguments);
            }

            ServiceResult _result = null;

            AssetVerificationModeEnum[] verificationMode = (AssetVerificationModeEnum[])_inputArguments[0];
            Opc.Ua.KeyValuePair[] expectedVerificationVariables = (Opc.Ua.KeyValuePair[])ExtensionObject.ToArray(_inputArguments[1], typeof(Opc.Ua.KeyValuePair));

            AssetVerificationResultEnum verificationResult = (AssetVerificationResultEnum)_outputArguments[0];
            StatusCode[] verificationVariablesErrors = (StatusCode[])_outputArguments[1];

            if (OnCall != null)
            {
                _result = OnCall(
                    _context,
                    this,
                    _objectId,
                    verificationMode,
                    expectedVerificationVariables,
                    ref verificationResult,
                    ref verificationVariablesErrors);
            }

            _outputArguments[0] = verificationResult;
            _outputArguments[1] = verificationVariablesErrors;

            return _result;
        }
        #endregion

        #region Private Fields
        #endregion
    }

    /// <remarks />
    /// <exclude />
    public delegate ServiceResult VerifyAssetMethodStateMethodCallHandler(
        ISystemContext _context,
        MethodState _method,
        NodeId _objectId,
        AssetVerificationModeEnum[] verificationMode,
        Opc.Ua.KeyValuePair[] expectedVerificationVariables,
        ref AssetVerificationResultEnum verificationResult,
        ref StatusCode[] verificationVariablesErrors);
    #endif
    #endregion

    #region VerifyMethodState Class
    #if (!OPCUA_EXCLUDE_VerifyMethodState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class VerifyMethodState : MethodState
    {
        #region Constructors
        /// <remarks />
        public VerifyMethodState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        public new static NodeState Construct(NodeState parent)
        {
            return new VerifyMethodState(parent);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AwAAACIAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvRlgvQUMvHwAAAGh0dHA6Ly9vcGNmb3Vu" +
           "ZGF0aW9uLm9yZy9VQS9ESS8kAAAAaHR0cDovL29wY2ZvdW5kYXRpb24ub3JnL1VBL0ZYL0RhdGEv////" +
           "/wRhggAEAAAAAQAQAAAAVmVyaWZ5TWV0aG9kVHlwZQEBAAABAQAAAQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Event Callbacks
        /// <remarks />
        public VerifyMethodStateMethodCallHandler OnCall;
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        /// <remarks />
        protected override ServiceResult Call(
            ISystemContext _context,
            NodeId _objectId,
            IList<object> _inputArguments,
            IList<object> _outputArguments)
        {
            if (OnCall == null)
            {
                return base.Call(_context, _objectId, _inputArguments, _outputArguments);
            }

            ServiceResult _result = null;

            UAModel.FXData.NodeIdValuePair[] expectedVerificationVariables = (UAModel.FXData.NodeIdValuePair[])ExtensionObject.ToArray(_inputArguments[0], typeof(UAModel.FXData.NodeIdValuePair));

            FunctionalEntityVerificationResultEnum verificationResult = (FunctionalEntityVerificationResultEnum)_outputArguments[0];
            StatusCode[] verificationVariablesErrors = (StatusCode[])_outputArguments[1];

            if (OnCall != null)
            {
                _result = OnCall(
                    _context,
                    this,
                    _objectId,
                    expectedVerificationVariables,
                    ref verificationResult,
                    ref verificationVariablesErrors);
            }

            _outputArguments[0] = verificationResult;
            _outputArguments[1] = verificationVariablesErrors;

            return _result;
        }
        #endregion

        #region Private Fields
        #endregion
    }

    /// <remarks />
    /// <exclude />
    public delegate ServiceResult VerifyMethodStateMethodCallHandler(
        ISystemContext _context,
        MethodState _method,
        NodeId _objectId,
        UAModel.FXData.NodeIdValuePair[] expectedVerificationVariables,
        ref FunctionalEntityVerificationResultEnum verificationResult,
        ref StatusCode[] verificationVariablesErrors);
    #endif
    #endregion

    #region EstablishControlMethodState Class
    #if (!OPCUA_EXCLUDE_EstablishControlMethodState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class EstablishControlMethodState : MethodState
    {
        #region Constructors
        /// <remarks />
        public EstablishControlMethodState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        public new static NodeState Construct(NodeState parent)
        {
            return new EstablishControlMethodState(parent);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AwAAACIAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvRlgvQUMvHwAAAGh0dHA6Ly9vcGNmb3Vu" +
           "ZGF0aW9uLm9yZy9VQS9ESS8kAAAAaHR0cDovL29wY2ZvdW5kYXRpb24ub3JnL1VBL0ZYL0RhdGEv////" +
           "/wRhggAEAAAAAQAaAAAARXN0YWJsaXNoQ29udHJvbE1ldGhvZFR5cGUBAQAAAQEAAAEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Event Callbacks
        /// <remarks />
        public EstablishControlMethodStateMethodCallHandler OnCall;
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        /// <remarks />
        protected override ServiceResult Call(
            ISystemContext _context,
            NodeId _objectId,
            IList<object> _inputArguments,
            IList<object> _outputArguments)
        {
            if (OnCall == null)
            {
                return base.Call(_context, _objectId, _inputArguments, _outputArguments);
            }

            ServiceResult _result = null;

            string lockContext = (string)_inputArguments[0];

            int lockStatus = (int)_outputArguments[0];

            if (OnCall != null)
            {
                _result = OnCall(
                    _context,
                    this,
                    _objectId,
                    lockContext,
                    ref lockStatus);
            }

            _outputArguments[0] = lockStatus;

            return _result;
        }
        #endregion

        #region Private Fields
        #endregion
    }

    /// <remarks />
    /// <exclude />
    public delegate ServiceResult EstablishControlMethodStateMethodCallHandler(
        ISystemContext _context,
        MethodState _method,
        NodeId _objectId,
        string lockContext,
        ref int lockStatus);
    #endif
    #endregion

    #region ReassignControlMethodState Class
    #if (!OPCUA_EXCLUDE_ReassignControlMethodState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ReassignControlMethodState : MethodState
    {
        #region Constructors
        /// <remarks />
        public ReassignControlMethodState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        public new static NodeState Construct(NodeState parent)
        {
            return new ReassignControlMethodState(parent);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AwAAACIAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvRlgvQUMvHwAAAGh0dHA6Ly9vcGNmb3Vu" +
           "ZGF0aW9uLm9yZy9VQS9ESS8kAAAAaHR0cDovL29wY2ZvdW5kYXRpb24ub3JnL1VBL0ZYL0RhdGEv////" +
           "/wRhggAEAAAAAQAZAAAAUmVhc3NpZ25Db250cm9sTWV0aG9kVHlwZQEBAAABAQAAAQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Event Callbacks
        /// <remarks />
        public ReassignControlMethodStateMethodCallHandler OnCall;
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        /// <remarks />
        protected override ServiceResult Call(
            ISystemContext _context,
            NodeId _objectId,
            IList<object> _inputArguments,
            IList<object> _outputArguments)
        {
            if (OnCall == null)
            {
                return base.Call(_context, _objectId, _inputArguments, _outputArguments);
            }

            ServiceResult _result = null;

            string lockContext = (string)_inputArguments[0];

            int lockStatus = (int)_outputArguments[0];

            if (OnCall != null)
            {
                _result = OnCall(
                    _context,
                    this,
                    _objectId,
                    lockContext,
                    ref lockStatus);
            }

            _outputArguments[0] = lockStatus;

            return _result;
        }
        #endregion

        #region Private Fields
        #endregion
    }

    /// <remarks />
    /// <exclude />
    public delegate ServiceResult ReassignControlMethodStateMethodCallHandler(
        ISystemContext _context,
        MethodState _method,
        NodeId _objectId,
        string lockContext,
        ref int lockStatus);
    #endif
    #endregion

    #region ClearStoredVariablesMethodState Class
    #if (!OPCUA_EXCLUDE_ClearStoredVariablesMethodState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ClearStoredVariablesMethodState : MethodState
    {
        #region Constructors
        /// <remarks />
        public ClearStoredVariablesMethodState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        public new static NodeState Construct(NodeState parent)
        {
            return new ClearStoredVariablesMethodState(parent);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AwAAACIAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvRlgvQUMvHwAAAGh0dHA6Ly9vcGNmb3Vu" +
           "ZGF0aW9uLm9yZy9VQS9ESS8kAAAAaHR0cDovL29wY2ZvdW5kYXRpb24ub3JnL1VBL0ZYL0RhdGEv////" +
           "/wRhggAEAAAAAQAeAAAAQ2xlYXJTdG9yZWRWYXJpYWJsZXNNZXRob2RUeXBlAQEAAAEBAAABAf////8A" +
           "AAAA";
        #endregion
        #endif
        #endregion

        #region Event Callbacks
        /// <remarks />
        public ClearStoredVariablesMethodStateMethodCallHandler OnCall;
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        /// <remarks />
        protected override ServiceResult Call(
            ISystemContext _context,
            NodeId _objectId,
            IList<object> _inputArguments,
            IList<object> _outputArguments)
        {
            if (OnCall == null)
            {
                return base.Call(_context, _objectId, _inputArguments, _outputArguments);
            }

            ServiceResult _result = null;

            NodeId[] variablesToClear = (NodeId[])_inputArguments[0];

            StatusCode[] results = (StatusCode[])_outputArguments[0];

            if (OnCall != null)
            {
                _result = OnCall(
                    _context,
                    this,
                    _objectId,
                    variablesToClear,
                    ref results);
            }

            _outputArguments[0] = results;

            return _result;
        }
        #endregion

        #region Private Fields
        #endregion
    }

    /// <remarks />
    /// <exclude />
    public delegate ServiceResult ClearStoredVariablesMethodStateMethodCallHandler(
        ISystemContext _context,
        MethodState _method,
        NodeId _objectId,
        NodeId[] variablesToClear,
        ref StatusCode[] results);
    #endif
    #endregion

    #region ListStoredVariablesMethodState Class
    #if (!OPCUA_EXCLUDE_ListStoredVariablesMethodState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ListStoredVariablesMethodState : MethodState
    {
        #region Constructors
        /// <remarks />
        public ListStoredVariablesMethodState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        public new static NodeState Construct(NodeState parent)
        {
            return new ListStoredVariablesMethodState(parent);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AwAAACIAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvRlgvQUMvHwAAAGh0dHA6Ly9vcGNmb3Vu" +
           "ZGF0aW9uLm9yZy9VQS9ESS8kAAAAaHR0cDovL29wY2ZvdW5kYXRpb24ub3JnL1VBL0ZYL0RhdGEv////" +
           "/wRhggAEAAAAAQAdAAAATGlzdFN0b3JlZFZhcmlhYmxlc01ldGhvZFR5cGUBAQAAAQEAAAEB/////wAA" +
           "AAA=";
        #endregion
        #endif
        #endregion

        #region Event Callbacks
        /// <remarks />
        public ListStoredVariablesMethodStateMethodCallHandler OnCall;
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        /// <remarks />
        protected override ServiceResult Call(
            ISystemContext _context,
            NodeId _objectId,
            IList<object> _inputArguments,
            IList<object> _outputArguments)
        {
            if (OnCall == null)
            {
                return base.Call(_context, _objectId, _inputArguments, _outputArguments);
            }

            ServiceResult _result = null;

            UAModel.FXData.NodeIdValuePair[] storedVariables = (UAModel.FXData.NodeIdValuePair[])_outputArguments[0];

            if (OnCall != null)
            {
                _result = OnCall(
                    _context,
                    this,
                    _objectId,
                    ref storedVariables);
            }

            _outputArguments[0] = storedVariables;

            return _result;
        }
        #endregion

        #region Private Fields
        #endregion
    }

    /// <remarks />
    /// <exclude />
    public delegate ServiceResult ListStoredVariablesMethodStateMethodCallHandler(
        ISystemContext _context,
        MethodState _method,
        NodeId _objectId,
        ref UAModel.FXData.NodeIdValuePair[] storedVariables);
    #endif
    #endregion

    #region SetStoredVariablesMethodState Class
    #if (!OPCUA_EXCLUDE_SetStoredVariablesMethodState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class SetStoredVariablesMethodState : MethodState
    {
        #region Constructors
        /// <remarks />
        public SetStoredVariablesMethodState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        public new static NodeState Construct(NodeState parent)
        {
            return new SetStoredVariablesMethodState(parent);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AwAAACIAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvRlgvQUMvHwAAAGh0dHA6Ly9vcGNmb3Vu" +
           "ZGF0aW9uLm9yZy9VQS9ESS8kAAAAaHR0cDovL29wY2ZvdW5kYXRpb24ub3JnL1VBL0ZYL0RhdGEv////" +
           "/wRhggAEAAAAAQAcAAAAU2V0U3RvcmVkVmFyaWFibGVzTWV0aG9kVHlwZQEBAAABAQAAAQH/////AAAA" +
           "AA==";
        #endregion
        #endif
        #endregion

        #region Event Callbacks
        /// <remarks />
        public SetStoredVariablesMethodStateMethodCallHandler OnCall;
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        /// <remarks />
        protected override ServiceResult Call(
            ISystemContext _context,
            NodeId _objectId,
            IList<object> _inputArguments,
            IList<object> _outputArguments)
        {
            if (OnCall == null)
            {
                return base.Call(_context, _objectId, _inputArguments, _outputArguments);
            }

            ServiceResult _result = null;

            NodeId[] variablesToStore = (NodeId[])_inputArguments[0];

            StatusCode[] results = (StatusCode[])_outputArguments[0];

            if (OnCall != null)
            {
                _result = OnCall(
                    _context,
                    this,
                    _objectId,
                    variablesToStore,
                    ref results);
            }

            _outputArguments[0] = results;

            return _result;
        }
        #endregion

        #region Private Fields
        #endregion
    }

    /// <remarks />
    /// <exclude />
    public delegate ServiceResult SetStoredVariablesMethodStateMethodCallHandler(
        ISystemContext _context,
        MethodState _method,
        NodeId _objectId,
        NodeId[] variablesToStore,
        ref StatusCode[] results);
    #endif
    #endregion
}