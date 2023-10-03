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

namespace UAModel.FXData
{
    #region AuditUpdateMethodResultEventTypeState Class
    #if (!OPCUA_EXCLUDE_AuditUpdateMethodResultEventTypeState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class AuditUpdateMethodResultEventTypeState : AuditUpdateMethodEventState
    {
        #region Constructors
        /// <remarks />
        public AuditUpdateMethodResultEventTypeState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(UAModel.FXData.ObjectTypes.AuditUpdateMethodResultEventType, UAModel.FXData.Namespaces.FXData, namespaceUris);
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
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvRlgvRGF0YS//////BGCAAgEAAAABACgA" +
           "AABBdWRpdFVwZGF0ZU1ldGhvZFJlc3VsdEV2ZW50VHlwZUluc3RhbmNlAQEBBAEBAQQBBAAA/////xEA" +
           "AAAVYIkIAgAAAAAABwAAAEV2ZW50SWQBAQAAAC4ARAAP/////wEB/////wAAAAAVYIkIAgAAAAAACQAA" +
           "AEV2ZW50VHlwZQEBAAAALgBEABH/////AQH/////AAAAABVgiQgCAAAAAAAKAAAAU291cmNlTm9kZQEB" +
           "AAAALgBEABH/////AQH/////AAAAABVgiQgCAAAAAAAKAAAAU291cmNlTmFtZQEBAAAALgBEAAz/////" +
           "AQH/////AAAAABVgiQgCAAAAAAAEAAAAVGltZQEBAAAALgBEAQAmAf////8BAf////8AAAAAFWCJCAIA" +
           "AAAAAAsAAABSZWNlaXZlVGltZQEBAAAALgBEAQAmAf////8BAf////8AAAAAFWCJCAIAAAAAAAcAAABN" +
           "ZXNzYWdlAQEAAAAuAEQAFf////8BAf////8AAAAAFWCJCAIAAAAAAAgAAABTZXZlcml0eQEBAAAALgBE" +
           "AAX/////AQH/////AAAAABVgiQgCAAAAAAAPAAAAQWN0aW9uVGltZVN0YW1wAQEAAAAuAEQBACYB////" +
           "/wEB/////wAAAAAVYIkIAgAAAAAABgAAAFN0YXR1cwEBAAAALgBEAAH/////AQH/////AAAAABVgiQgC" +
           "AAAAAAAIAAAAU2VydmVySWQBAQAAAC4ARAAM/////wEB/////wAAAAAVYIkIAgAAAAAAEgAAAENsaWVu" +
           "dEF1ZGl0RW50cnlJZAEBAAAALgBEAAz/////AQH/////AAAAABVgiQgCAAAAAAAMAAAAQ2xpZW50VXNl" +
           "cklkAQEAAAAuAEQADP////8BAf////8AAAAAFWCJCAIAAAAAAAgAAABNZXRob2RJZAEBAAAALgBEABH/" +
           "////AQH/////AAAAABdgiQgCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAQAAAC4ARAAYAQAAAAEAAAAA" +
           "AAAAAQH/////AAAAABdgiQoCAAAAAQAPAAAAT3V0cHV0QXJndW1lbnRzAQG1GAAuAES1GAAAAQAoAQEA" +
           "AAABAAAAAAAAAAMD/////wAAAAAVYIkKAgAAAAEADAAAAFN0YXR1c0NvZGVJZAEBtBgALgBEtBgAAAAT" +
           "/////wMD/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public PropertyState<Argument[]> OutputArguments
        {
            get
            {
                return m_outputArguments;
            }

            set
            {
                if (!Object.ReferenceEquals(m_outputArguments, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_outputArguments = value;
            }
        }

        /// <remarks />
        public PropertyState<StatusCode> StatusCodeId
        {
            get
            {
                return m_statusCodeId;
            }

            set
            {
                if (!Object.ReferenceEquals(m_statusCodeId, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_statusCodeId = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_outputArguments != null)
            {
                children.Add(m_outputArguments);
            }

            if (m_statusCodeId != null)
            {
                children.Add(m_statusCodeId);
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
                case UAModel.FXData.BrowseNames.OutputArguments:
                {
                    if (createOrReplace)
                    {
                        if (OutputArguments == null)
                        {
                            if (replacement == null)
                            {
                                OutputArguments = new PropertyState<Argument[]>(this);
                            }
                            else
                            {
                                OutputArguments = (PropertyState<Argument[]>)replacement;
                            }
                        }
                    }

                    instance = OutputArguments;
                    break;
                }

                case UAModel.FXData.BrowseNames.StatusCodeId:
                {
                    if (createOrReplace)
                    {
                        if (StatusCodeId == null)
                        {
                            if (replacement == null)
                            {
                                StatusCodeId = new PropertyState<StatusCode>(this);
                            }
                            else
                            {
                                StatusCodeId = (PropertyState<StatusCode>)replacement;
                            }
                        }
                    }

                    instance = StatusCodeId;
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
        private PropertyState<Argument[]> m_outputArguments;
        private PropertyState<StatusCode> m_statusCodeId;
        #endregion
    }
    #endif
    #endregion
}