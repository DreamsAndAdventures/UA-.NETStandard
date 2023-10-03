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
    #region AssetVerificationModeEnum Enumeration
    #if (!OPCUA_EXCLUDE_AssetVerificationModeEnum)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = UAModel.FXData.Namespaces.FXData)]
    public enum AssetVerificationModeEnum
    {
        /// <remarks />
        [EnumMember(Value = "AssetCompatibility_0")]
        AssetCompatibility = 0,

        /// <remarks />
        [EnumMember(Value = "AssetIdentity_1")]
        AssetIdentity = 1,

        /// <remarks />
        [EnumMember(Value = "AssetIdentityAndCompatibility_2")]
        AssetIdentityAndCompatibility = 2,
    }

    #region AssetVerificationModeEnumCollection Class
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfAssetVerificationModeEnum", Namespace = UAModel.FXData.Namespaces.FXData, ItemName = "AssetVerificationModeEnum")]
    #if !NET_STANDARD
    public partial class AssetVerificationModeEnumCollection : List<AssetVerificationModeEnum>, ICloneable
    #else
    public partial class AssetVerificationModeEnumCollection : List<AssetVerificationModeEnum>
    #endif
    {
        #region Constructors
        /// <remarks />
        public AssetVerificationModeEnumCollection() {}

        /// <remarks />
        public AssetVerificationModeEnumCollection(int capacity) : base(capacity) {}

        /// <remarks />
        public AssetVerificationModeEnumCollection(IEnumerable<AssetVerificationModeEnum> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <remarks />
        public static implicit operator AssetVerificationModeEnumCollection(AssetVerificationModeEnum[] values)
        {
            if (values != null)
            {
                return new AssetVerificationModeEnumCollection(values);
            }

            return new AssetVerificationModeEnumCollection();
        }

        /// <remarks />
        public static explicit operator AssetVerificationModeEnum[](AssetVerificationModeEnumCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <remarks />
        public object Clone()
        {
            return (AssetVerificationModeEnumCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            AssetVerificationModeEnumCollection clone = new AssetVerificationModeEnumCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((AssetVerificationModeEnum)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region AssetVerificationResultEnum Enumeration
    #if (!OPCUA_EXCLUDE_AssetVerificationResultEnum)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = UAModel.FXData.Namespaces.FXData)]
    public enum AssetVerificationResultEnum
    {
        /// <remarks />
        [EnumMember(Value = "NotSet_0")]
        NotSet = 0,

        /// <remarks />
        [EnumMember(Value = "Match_1")]
        Match = 1,

        /// <remarks />
        [EnumMember(Value = "Compatible_2")]
        Compatible = 2,

        /// <remarks />
        [EnumMember(Value = "Mismatch_3")]
        Mismatch = 3,
    }

    #region AssetVerificationResultEnumCollection Class
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfAssetVerificationResultEnum", Namespace = UAModel.FXData.Namespaces.FXData, ItemName = "AssetVerificationResultEnum")]
    #if !NET_STANDARD
    public partial class AssetVerificationResultEnumCollection : List<AssetVerificationResultEnum>, ICloneable
    #else
    public partial class AssetVerificationResultEnumCollection : List<AssetVerificationResultEnum>
    #endif
    {
        #region Constructors
        /// <remarks />
        public AssetVerificationResultEnumCollection() {}

        /// <remarks />
        public AssetVerificationResultEnumCollection(int capacity) : base(capacity) {}

        /// <remarks />
        public AssetVerificationResultEnumCollection(IEnumerable<AssetVerificationResultEnum> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <remarks />
        public static implicit operator AssetVerificationResultEnumCollection(AssetVerificationResultEnum[] values)
        {
            if (values != null)
            {
                return new AssetVerificationResultEnumCollection(values);
            }

            return new AssetVerificationResultEnumCollection();
        }

        /// <remarks />
        public static explicit operator AssetVerificationResultEnum[](AssetVerificationResultEnumCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <remarks />
        public object Clone()
        {
            return (AssetVerificationResultEnumCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            AssetVerificationResultEnumCollection clone = new AssetVerificationResultEnumCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((AssetVerificationResultEnum)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region FunctionalEntityVerificationResultEnum Enumeration
    #if (!OPCUA_EXCLUDE_FunctionalEntityVerificationResultEnum)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = UAModel.FXData.Namespaces.FXData)]
    public enum FunctionalEntityVerificationResultEnum
    {
        /// <remarks />
        [EnumMember(Value = "NotSet_0")]
        NotSet = 0,

        /// <remarks />
        [EnumMember(Value = "Match_1")]
        Match = 1,

        /// <remarks />
        [EnumMember(Value = "Mismatch_2")]
        Mismatch = 2,
    }

    #region FunctionalEntityVerificationResultEnumCollection Class
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfFunctionalEntityVerificationResultEnum", Namespace = UAModel.FXData.Namespaces.FXData, ItemName = "FunctionalEntityVerificationResultEnum")]
    #if !NET_STANDARD
    public partial class FunctionalEntityVerificationResultEnumCollection : List<FunctionalEntityVerificationResultEnum>, ICloneable
    #else
    public partial class FunctionalEntityVerificationResultEnumCollection : List<FunctionalEntityVerificationResultEnum>
    #endif
    {
        #region Constructors
        /// <remarks />
        public FunctionalEntityVerificationResultEnumCollection() {}

        /// <remarks />
        public FunctionalEntityVerificationResultEnumCollection(int capacity) : base(capacity) {}

        /// <remarks />
        public FunctionalEntityVerificationResultEnumCollection(IEnumerable<FunctionalEntityVerificationResultEnum> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <remarks />
        public static implicit operator FunctionalEntityVerificationResultEnumCollection(FunctionalEntityVerificationResultEnum[] values)
        {
            if (values != null)
            {
                return new FunctionalEntityVerificationResultEnumCollection(values);
            }

            return new FunctionalEntityVerificationResultEnumCollection();
        }

        /// <remarks />
        public static explicit operator FunctionalEntityVerificationResultEnum[](FunctionalEntityVerificationResultEnumCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <remarks />
        public object Clone()
        {
            return (FunctionalEntityVerificationResultEnumCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            FunctionalEntityVerificationResultEnumCollection clone = new FunctionalEntityVerificationResultEnumCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((FunctionalEntityVerificationResultEnum)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region PubSubConnectionEndpointModeEnum Enumeration
    #if (!OPCUA_EXCLUDE_PubSubConnectionEndpointModeEnum)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = UAModel.FXData.Namespaces.FXData)]
    public enum PubSubConnectionEndpointModeEnum
    {
        /// <remarks />
        [EnumMember(Value = "PublisherSubscriber_1")]
        PublisherSubscriber = 1,

        /// <remarks />
        [EnumMember(Value = "Publisher_2")]
        Publisher = 2,

        /// <remarks />
        [EnumMember(Value = "Subscriber_3")]
        Subscriber = 3,
    }

    #region PubSubConnectionEndpointModeEnumCollection Class
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfPubSubConnectionEndpointModeEnum", Namespace = UAModel.FXData.Namespaces.FXData, ItemName = "PubSubConnectionEndpointModeEnum")]
    #if !NET_STANDARD
    public partial class PubSubConnectionEndpointModeEnumCollection : List<PubSubConnectionEndpointModeEnum>, ICloneable
    #else
    public partial class PubSubConnectionEndpointModeEnumCollection : List<PubSubConnectionEndpointModeEnum>
    #endif
    {
        #region Constructors
        /// <remarks />
        public PubSubConnectionEndpointModeEnumCollection() {}

        /// <remarks />
        public PubSubConnectionEndpointModeEnumCollection(int capacity) : base(capacity) {}

        /// <remarks />
        public PubSubConnectionEndpointModeEnumCollection(IEnumerable<PubSubConnectionEndpointModeEnum> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <remarks />
        public static implicit operator PubSubConnectionEndpointModeEnumCollection(PubSubConnectionEndpointModeEnum[] values)
        {
            if (values != null)
            {
                return new PubSubConnectionEndpointModeEnumCollection(values);
            }

            return new PubSubConnectionEndpointModeEnumCollection();
        }

        /// <remarks />
        public static explicit operator PubSubConnectionEndpointModeEnum[](PubSubConnectionEndpointModeEnumCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <remarks />
        public object Clone()
        {
            return (PubSubConnectionEndpointModeEnumCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            PubSubConnectionEndpointModeEnumCollection clone = new PubSubConnectionEndpointModeEnumCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((PubSubConnectionEndpointModeEnum)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region FxCommandMask Enumeration
    #if (!OPCUA_EXCLUDE_FxCommandMask)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = UAModel.FXData.Namespaces.FXData)][Flags]
    public enum FxCommandMask : UInt32
    {
        /// <remarks />
        [EnumMember(Value = "None_0")]
        None = 0,

        /// <remarks />
        [EnumMember(Value = "VerifyAssetCmd_1")]
        VerifyAssetCmd = 1,

        /// <remarks />
        [EnumMember(Value = "VerifyFunctionalEntityCmd_2")]
        VerifyFunctionalEntityCmd = 2,

        /// <remarks />
        [EnumMember(Value = "CreateConnectionEndpointCmd_4")]
        CreateConnectionEndpointCmd = 4,

        /// <remarks />
        [EnumMember(Value = "EstablishControlCmd_8")]
        EstablishControlCmd = 8,

        /// <remarks />
        [EnumMember(Value = "SetConfigurationDataCmd_16")]
        SetConfigurationDataCmd = 16,

        /// <remarks />
        [EnumMember(Value = "ReassignControlCmd_32")]
        ReassignControlCmd = 32,

        /// <remarks />
        [EnumMember(Value = "ReserveCommunicationIdsCmd_64")]
        ReserveCommunicationIdsCmd = 64,

        /// <remarks />
        [EnumMember(Value = "SetCommunicationConfigurationCmd_128")]
        SetCommunicationConfigurationCmd = 128,

        /// <remarks />
        [EnumMember(Value = "EnableCommunicationCmd_256")]
        EnableCommunicationCmd = 256,
    }

    #region FxCommandMaskCollection Class
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfFxCommandMask", Namespace = UAModel.FXData.Namespaces.FXData, ItemName = "FxCommandMask")]
    #if !NET_STANDARD
    public partial class FxCommandMaskCollection : List<FxCommandMask>, ICloneable
    #else
    public partial class FxCommandMaskCollection : List<FxCommandMask>
    #endif
    {
        #region Constructors
        /// <remarks />
        public FxCommandMaskCollection() {}

        /// <remarks />
        public FxCommandMaskCollection(int capacity) : base(capacity) {}

        /// <remarks />
        public FxCommandMaskCollection(IEnumerable<FxCommandMask> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <remarks />
        public static implicit operator FxCommandMaskCollection(FxCommandMask[] values)
        {
            if (values != null)
            {
                return new FxCommandMaskCollection(values);
            }

            return new FxCommandMaskCollection();
        }

        /// <remarks />
        public static explicit operator FxCommandMask[](FxCommandMaskCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <remarks />
        public object Clone()
        {
            return (FxCommandMaskCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            FxCommandMaskCollection clone = new FxCommandMaskCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((FxCommandMask)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region AssetVerificationDataType Class
    #if (!OPCUA_EXCLUDE_AssetVerificationDataType)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = UAModel.FXData.Namespaces.FXData)]
    public partial class AssetVerificationDataType : IEncodeable, IJsonEncodeable
    {
        #region Constructors
        /// <remarks />
        public AssetVerificationDataType()
        {
            Initialize();
        }
            
        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }
            
        private void Initialize()
        {
            m_assetToVerify = null;
            m_verificationMode = AssetVerificationModeEnum.AssetCompatibility;
            m_expectedVerificationResult = AssetVerificationResultEnum.NotSet;
            m_expectedVerificationVariables = new KeyValuePairCollection();
            m_expectedAdditionalVerificationVariables = new NodeIdValuePairCollection();
        }
        #endregion

        #region Public Properties
        /// <remarks />
        [DataMember(Name = "AssetToVerify", IsRequired = false, Order = 1)]
        public NodeId AssetToVerify
        {
            get { return m_assetToVerify;  }
            set { m_assetToVerify = value; }
        }

        /// <remarks />
        [DataMember(Name = "VerificationMode", IsRequired = false, Order = 2)]
        public AssetVerificationModeEnum VerificationMode
        {
            get { return m_verificationMode;  }
            set { m_verificationMode = value; }
        }

        /// <remarks />
        [DataMember(Name = "ExpectedVerificationResult", IsRequired = false, Order = 3)]
        public AssetVerificationResultEnum ExpectedVerificationResult
        {
            get { return m_expectedVerificationResult;  }
            set { m_expectedVerificationResult = value; }
        }

        /// <remarks />
        [DataMember(Name = "ExpectedVerificationVariables", IsRequired = false, Order = 4)]
        public KeyValuePairCollection ExpectedVerificationVariables
        {
            get
            {
                return m_expectedVerificationVariables;
            }

            set
            {
                m_expectedVerificationVariables = value;

                if (value == null)
                {
                    m_expectedVerificationVariables = new KeyValuePairCollection();
                }
            }
        }

        /// <remarks />
        [DataMember(Name = "ExpectedAdditionalVerificationVariables", IsRequired = false, Order = 5)]
        public NodeIdValuePairCollection ExpectedAdditionalVerificationVariables
        {
            get
            {
                return m_expectedAdditionalVerificationVariables;
            }

            set
            {
                m_expectedAdditionalVerificationVariables = value;

                if (value == null)
                {
                    m_expectedAdditionalVerificationVariables = new NodeIdValuePairCollection();
                }
            }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public virtual ExpandedNodeId TypeId => DataTypeIds.AssetVerificationDataType; 

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public virtual ExpandedNodeId BinaryEncodingId => ObjectIds.AssetVerificationDataType_Encoding_DefaultBinary;

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public virtual ExpandedNodeId XmlEncodingId => ObjectIds.AssetVerificationDataType_Encoding_DefaultXml;
                    
        /// <summary cref="IJsonEncodeable.JsonEncodingId" />
        public virtual ExpandedNodeId JsonEncodingId => ObjectIds.AssetVerificationDataType_Encoding_DefaultJson; 

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public virtual void Encode(IEncoder encoder)
        {
            encoder.PushNamespace(UAModel.FXData.Namespaces.FXData);

            encoder.WriteNodeId("AssetToVerify", AssetToVerify);
            encoder.WriteEnumerated("VerificationMode", VerificationMode);
            encoder.WriteEnumerated("ExpectedVerificationResult", ExpectedVerificationResult);
            encoder.WriteEncodeableArray("ExpectedVerificationVariables", ExpectedVerificationVariables.ToArray(), typeof(Opc.Ua.KeyValuePair));
            encoder.WriteEncodeableArray("ExpectedAdditionalVerificationVariables", ExpectedAdditionalVerificationVariables.ToArray(), typeof(NodeIdValuePair));

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public virtual void Decode(IDecoder decoder)
        {
            decoder.PushNamespace(UAModel.FXData.Namespaces.FXData);

            AssetToVerify = decoder.ReadNodeId("AssetToVerify");
            VerificationMode = (AssetVerificationModeEnum)decoder.ReadEnumerated("VerificationMode", typeof(AssetVerificationModeEnum));
            ExpectedVerificationResult = (AssetVerificationResultEnum)decoder.ReadEnumerated("ExpectedVerificationResult", typeof(AssetVerificationResultEnum));
            ExpectedVerificationVariables = (Opc.Ua.KeyValuePairCollection)decoder.ReadEncodeableArray("ExpectedVerificationVariables", typeof(Opc.Ua.KeyValuePair));
            ExpectedAdditionalVerificationVariables = (NodeIdValuePairCollection)decoder.ReadEncodeableArray("ExpectedAdditionalVerificationVariables", typeof(NodeIdValuePair));

            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public virtual bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            AssetVerificationDataType value = encodeable as AssetVerificationDataType;

            if (value == null)
            {
                return false;
            }

            if (!Utils.IsEqual(m_assetToVerify, value.m_assetToVerify)) return false;
            if (!Utils.IsEqual(m_verificationMode, value.m_verificationMode)) return false;
            if (!Utils.IsEqual(m_expectedVerificationResult, value.m_expectedVerificationResult)) return false;
            if (!Utils.IsEqual(m_expectedVerificationVariables, value.m_expectedVerificationVariables)) return false;
            if (!Utils.IsEqual(m_expectedAdditionalVerificationVariables, value.m_expectedAdditionalVerificationVariables)) return false;

            return true;
        }

        #if !NET_STANDARD
        /// <summary cref="ICloneable.Clone" />
        public virtual object Clone()
        {
            return (AssetVerificationDataType)this.MemberwiseClone();
        }
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            AssetVerificationDataType clone = (AssetVerificationDataType)base.MemberwiseClone();

            clone.m_assetToVerify = (NodeId)Utils.Clone(this.m_assetToVerify);
            clone.m_verificationMode = (AssetVerificationModeEnum)Utils.Clone(this.m_verificationMode);
            clone.m_expectedVerificationResult = (AssetVerificationResultEnum)Utils.Clone(this.m_expectedVerificationResult);
            clone.m_expectedVerificationVariables = (KeyValuePairCollection)Utils.Clone(this.m_expectedVerificationVariables);
            clone.m_expectedAdditionalVerificationVariables = (NodeIdValuePairCollection)Utils.Clone(this.m_expectedAdditionalVerificationVariables);

            return clone;
        }
        #endregion

        #region Private Fields
        private NodeId m_assetToVerify;
        private AssetVerificationModeEnum m_verificationMode;
        private AssetVerificationResultEnum m_expectedVerificationResult;
        private KeyValuePairCollection m_expectedVerificationVariables;
        private NodeIdValuePairCollection m_expectedAdditionalVerificationVariables;
        #endregion
    }

    #region AssetVerificationDataTypeCollection Class
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfAssetVerificationDataType", Namespace = UAModel.FXData.Namespaces.FXData, ItemName = "AssetVerificationDataType")]
    #if !NET_STANDARD
    public partial class AssetVerificationDataTypeCollection : List<AssetVerificationDataType>, ICloneable
    #else
    public partial class AssetVerificationDataTypeCollection : List<AssetVerificationDataType>
    #endif
    {
        #region Constructors
        /// <remarks />
        public AssetVerificationDataTypeCollection() {}

        /// <remarks />
        public AssetVerificationDataTypeCollection(int capacity) : base(capacity) {}

        /// <remarks />
        public AssetVerificationDataTypeCollection(IEnumerable<AssetVerificationDataType> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <remarks />
        public static implicit operator AssetVerificationDataTypeCollection(AssetVerificationDataType[] values)
        {
            if (values != null)
            {
                return new AssetVerificationDataTypeCollection(values);
            }

            return new AssetVerificationDataTypeCollection();
        }

        /// <remarks />
        public static explicit operator AssetVerificationDataType[](AssetVerificationDataTypeCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <remarks />
        public object Clone()
        {
            return (AssetVerificationDataTypeCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            AssetVerificationDataTypeCollection clone = new AssetVerificationDataTypeCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((AssetVerificationDataType)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region AssetVerificationResultDataType Class
    #if (!OPCUA_EXCLUDE_AssetVerificationResultDataType)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = UAModel.FXData.Namespaces.FXData)]
    public partial class AssetVerificationResultDataType : IEncodeable, IJsonEncodeable
    {
        #region Constructors
        /// <remarks />
        public AssetVerificationResultDataType()
        {
            Initialize();
        }
            
        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }
            
        private void Initialize()
        {
            m_verificationStatus = StatusCodes.Good;
            m_verificationResult = AssetVerificationResultEnum.NotSet;
            m_verificationVariablesErrors = new StatusCodeCollection();
            m_verificationAdditionalVariablesErrors = new StatusCodeCollection();
        }
        #endregion

        #region Public Properties
        /// <remarks />
        [DataMember(Name = "VerificationStatus", IsRequired = false, Order = 1)]
        public StatusCode VerificationStatus
        {
            get { return m_verificationStatus;  }
            set { m_verificationStatus = value; }
        }

        /// <remarks />
        [DataMember(Name = "VerificationResult", IsRequired = false, Order = 2)]
        public AssetVerificationResultEnum VerificationResult
        {
            get { return m_verificationResult;  }
            set { m_verificationResult = value; }
        }

        /// <remarks />
        [DataMember(Name = "VerificationVariablesErrors", IsRequired = false, Order = 3)]
        public StatusCodeCollection VerificationVariablesErrors
        {
            get
            {
                return m_verificationVariablesErrors;
            }

            set
            {
                m_verificationVariablesErrors = value;

                if (value == null)
                {
                    m_verificationVariablesErrors = new StatusCodeCollection();
                }
            }
        }

        /// <remarks />
        [DataMember(Name = "VerificationAdditionalVariablesErrors", IsRequired = false, Order = 4)]
        public StatusCodeCollection VerificationAdditionalVariablesErrors
        {
            get
            {
                return m_verificationAdditionalVariablesErrors;
            }

            set
            {
                m_verificationAdditionalVariablesErrors = value;

                if (value == null)
                {
                    m_verificationAdditionalVariablesErrors = new StatusCodeCollection();
                }
            }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public virtual ExpandedNodeId TypeId => DataTypeIds.AssetVerificationResultDataType; 

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public virtual ExpandedNodeId BinaryEncodingId => ObjectIds.AssetVerificationResultDataType_Encoding_DefaultBinary;

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public virtual ExpandedNodeId XmlEncodingId => ObjectIds.AssetVerificationResultDataType_Encoding_DefaultXml;
                    
        /// <summary cref="IJsonEncodeable.JsonEncodingId" />
        public virtual ExpandedNodeId JsonEncodingId => ObjectIds.AssetVerificationResultDataType_Encoding_DefaultJson; 

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public virtual void Encode(IEncoder encoder)
        {
            encoder.PushNamespace(UAModel.FXData.Namespaces.FXData);

            encoder.WriteStatusCode("VerificationStatus", VerificationStatus);
            encoder.WriteEnumerated("VerificationResult", VerificationResult);
            encoder.WriteStatusCodeArray("VerificationVariablesErrors", VerificationVariablesErrors);
            encoder.WriteStatusCodeArray("VerificationAdditionalVariablesErrors", VerificationAdditionalVariablesErrors);

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public virtual void Decode(IDecoder decoder)
        {
            decoder.PushNamespace(UAModel.FXData.Namespaces.FXData);

            VerificationStatus = decoder.ReadStatusCode("VerificationStatus");
            VerificationResult = (AssetVerificationResultEnum)decoder.ReadEnumerated("VerificationResult", typeof(AssetVerificationResultEnum));
            VerificationVariablesErrors = decoder.ReadStatusCodeArray("VerificationVariablesErrors");
            VerificationAdditionalVariablesErrors = decoder.ReadStatusCodeArray("VerificationAdditionalVariablesErrors");

            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public virtual bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            AssetVerificationResultDataType value = encodeable as AssetVerificationResultDataType;

            if (value == null)
            {
                return false;
            }

            if (!Utils.IsEqual(m_verificationStatus, value.m_verificationStatus)) return false;
            if (!Utils.IsEqual(m_verificationResult, value.m_verificationResult)) return false;
            if (!Utils.IsEqual(m_verificationVariablesErrors, value.m_verificationVariablesErrors)) return false;
            if (!Utils.IsEqual(m_verificationAdditionalVariablesErrors, value.m_verificationAdditionalVariablesErrors)) return false;

            return true;
        }

        #if !NET_STANDARD
        /// <summary cref="ICloneable.Clone" />
        public virtual object Clone()
        {
            return (AssetVerificationResultDataType)this.MemberwiseClone();
        }
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            AssetVerificationResultDataType clone = (AssetVerificationResultDataType)base.MemberwiseClone();

            clone.m_verificationStatus = (StatusCode)Utils.Clone(this.m_verificationStatus);
            clone.m_verificationResult = (AssetVerificationResultEnum)Utils.Clone(this.m_verificationResult);
            clone.m_verificationVariablesErrors = (StatusCodeCollection)Utils.Clone(this.m_verificationVariablesErrors);
            clone.m_verificationAdditionalVariablesErrors = (StatusCodeCollection)Utils.Clone(this.m_verificationAdditionalVariablesErrors);

            return clone;
        }
        #endregion

        #region Private Fields
        private StatusCode m_verificationStatus;
        private AssetVerificationResultEnum m_verificationResult;
        private StatusCodeCollection m_verificationVariablesErrors;
        private StatusCodeCollection m_verificationAdditionalVariablesErrors;
        #endregion
    }

    #region AssetVerificationResultDataTypeCollection Class
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfAssetVerificationResultDataType", Namespace = UAModel.FXData.Namespaces.FXData, ItemName = "AssetVerificationResultDataType")]
    #if !NET_STANDARD
    public partial class AssetVerificationResultDataTypeCollection : List<AssetVerificationResultDataType>, ICloneable
    #else
    public partial class AssetVerificationResultDataTypeCollection : List<AssetVerificationResultDataType>
    #endif
    {
        #region Constructors
        /// <remarks />
        public AssetVerificationResultDataTypeCollection() {}

        /// <remarks />
        public AssetVerificationResultDataTypeCollection(int capacity) : base(capacity) {}

        /// <remarks />
        public AssetVerificationResultDataTypeCollection(IEnumerable<AssetVerificationResultDataType> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <remarks />
        public static implicit operator AssetVerificationResultDataTypeCollection(AssetVerificationResultDataType[] values)
        {
            if (values != null)
            {
                return new AssetVerificationResultDataTypeCollection(values);
            }

            return new AssetVerificationResultDataTypeCollection();
        }

        /// <remarks />
        public static explicit operator AssetVerificationResultDataType[](AssetVerificationResultDataTypeCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <remarks />
        public object Clone()
        {
            return (AssetVerificationResultDataTypeCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            AssetVerificationResultDataTypeCollection clone = new AssetVerificationResultDataTypeCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((AssetVerificationResultDataType)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region CommunicationConfigurationDataType Class
    #if (!OPCUA_EXCLUDE_CommunicationConfigurationDataType)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = UAModel.FXData.Namespaces.FXData)]
    public partial class CommunicationConfigurationDataType : IEncodeable, IJsonEncodeable
    {
        #region Constructors
        /// <remarks />
        public CommunicationConfigurationDataType()
        {
            Initialize();
        }
            
        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }
            
        private void Initialize()
        {
        }
        #endregion

        #region Public Properties
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public virtual ExpandedNodeId TypeId => DataTypeIds.CommunicationConfigurationDataType; 

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public virtual ExpandedNodeId BinaryEncodingId => ObjectIds.CommunicationConfigurationDataType_Encoding_DefaultBinary;

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public virtual ExpandedNodeId XmlEncodingId => ObjectIds.CommunicationConfigurationDataType_Encoding_DefaultXml;
                    
        /// <summary cref="IJsonEncodeable.JsonEncodingId" />
        public virtual ExpandedNodeId JsonEncodingId => ObjectIds.CommunicationConfigurationDataType_Encoding_DefaultJson; 

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public virtual void Encode(IEncoder encoder)
        {
            encoder.PushNamespace(UAModel.FXData.Namespaces.FXData);


            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public virtual void Decode(IDecoder decoder)
        {
            decoder.PushNamespace(UAModel.FXData.Namespaces.FXData);


            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public virtual bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            CommunicationConfigurationDataType value = encodeable as CommunicationConfigurationDataType;

            if (value == null)
            {
                return false;
            }


            return true;
        }

        #if !NET_STANDARD
        /// <summary cref="ICloneable.Clone" />
        public virtual object Clone()
        {
            return (CommunicationConfigurationDataType)this.MemberwiseClone();
        }
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            CommunicationConfigurationDataType clone = (CommunicationConfigurationDataType)base.MemberwiseClone();


            return clone;
        }
        #endregion

        #region Private Fields
        #endregion
    }

    #region CommunicationConfigurationDataTypeCollection Class
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfCommunicationConfigurationDataType", Namespace = UAModel.FXData.Namespaces.FXData, ItemName = "CommunicationConfigurationDataType")]
    #if !NET_STANDARD
    public partial class CommunicationConfigurationDataTypeCollection : List<CommunicationConfigurationDataType>, ICloneable
    #else
    public partial class CommunicationConfigurationDataTypeCollection : List<CommunicationConfigurationDataType>
    #endif
    {
        #region Constructors
        /// <remarks />
        public CommunicationConfigurationDataTypeCollection() {}

        /// <remarks />
        public CommunicationConfigurationDataTypeCollection(int capacity) : base(capacity) {}

        /// <remarks />
        public CommunicationConfigurationDataTypeCollection(IEnumerable<CommunicationConfigurationDataType> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <remarks />
        public static implicit operator CommunicationConfigurationDataTypeCollection(CommunicationConfigurationDataType[] values)
        {
            if (values != null)
            {
                return new CommunicationConfigurationDataTypeCollection(values);
            }

            return new CommunicationConfigurationDataTypeCollection();
        }

        /// <remarks />
        public static explicit operator CommunicationConfigurationDataType[](CommunicationConfigurationDataTypeCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <remarks />
        public object Clone()
        {
            return (CommunicationConfigurationDataTypeCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            CommunicationConfigurationDataTypeCollection clone = new CommunicationConfigurationDataTypeCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((CommunicationConfigurationDataType)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region PubSubCommunicationConfigurationDataType Class
    #if (!OPCUA_EXCLUDE_PubSubCommunicationConfigurationDataType)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = UAModel.FXData.Namespaces.FXData)]
    public partial class PubSubCommunicationConfigurationDataType : UAModel.FXData.CommunicationConfigurationDataType
    {
        #region Constructors
        /// <remarks />
        public PubSubCommunicationConfigurationDataType()
        {
            Initialize();
        }

        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }

        private void Initialize()
        {
            m_pubSubConfiguration = new Opc.Ua.PubSubConfiguration2DataType();
            m_requireCompleteUpdate = true;
            m_configurationReferences = new PubSubConfigurationRefDataTypeCollection();
        }
        #endregion

        #region Public Properties
        /// <remarks />
        [DataMember(Name = "PubSubConfiguration", IsRequired = false, Order = 1)]
        public Opc.Ua.PubSubConfiguration2DataType PubSubConfiguration
        {
            get
            {
                return m_pubSubConfiguration;
            }

            set
            {
                m_pubSubConfiguration = value;

                if (value == null)
                {
                    m_pubSubConfiguration = new Opc.Ua.PubSubConfiguration2DataType();
                }
            }
        }

        /// <remarks />
        [DataMember(Name = "RequireCompleteUpdate", IsRequired = false, Order = 2)]
        public bool RequireCompleteUpdate
        {
            get { return m_requireCompleteUpdate;  }
            set { m_requireCompleteUpdate = value; }
        }

        /// <remarks />
        [DataMember(Name = "ConfigurationReferences", IsRequired = false, Order = 3)]
        public PubSubConfigurationRefDataTypeCollection ConfigurationReferences
        {
            get
            {
                return m_configurationReferences;
            }

            set
            {
                m_configurationReferences = value;

                if (value == null)
                {
                    m_configurationReferences = new PubSubConfigurationRefDataTypeCollection();
                }
            }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public override ExpandedNodeId TypeId => DataTypeIds.PubSubCommunicationConfigurationDataType; 

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public override ExpandedNodeId BinaryEncodingId => ObjectIds.PubSubCommunicationConfigurationDataType_Encoding_DefaultBinary;

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public override ExpandedNodeId XmlEncodingId => ObjectIds.PubSubCommunicationConfigurationDataType_Encoding_DefaultXml;
            
        /// <summary cref="IJsonEncodeable.JsonEncodingId" />
        public override ExpandedNodeId JsonEncodingId => ObjectIds.PubSubCommunicationConfigurationDataType_Encoding_DefaultJson; 

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public override void Encode(IEncoder encoder)
        {
            base.Encode(encoder);

            encoder.PushNamespace(UAModel.FXData.Namespaces.FXData);

            encoder.WriteEncodeable("PubSubConfiguration", PubSubConfiguration, typeof(Opc.Ua.PubSubConfiguration2DataType));
            encoder.WriteBoolean("RequireCompleteUpdate", RequireCompleteUpdate);
            encoder.WriteEncodeableArray("ConfigurationReferences", ConfigurationReferences.ToArray(), typeof(Opc.Ua.PubSubConfigurationRefDataType));

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public override void Decode(IDecoder decoder)
        {
            base.Decode(decoder);

            decoder.PushNamespace(UAModel.FXData.Namespaces.FXData);

            PubSubConfiguration = (Opc.Ua.PubSubConfiguration2DataType)decoder.ReadEncodeable("PubSubConfiguration", typeof(Opc.Ua.PubSubConfiguration2DataType));
            RequireCompleteUpdate = decoder.ReadBoolean("RequireCompleteUpdate");
            ConfigurationReferences = (Opc.Ua.PubSubConfigurationRefDataTypeCollection)decoder.ReadEncodeableArray("ConfigurationReferences", typeof(Opc.Ua.PubSubConfigurationRefDataType));

            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public override bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            PubSubCommunicationConfigurationDataType value = encodeable as PubSubCommunicationConfigurationDataType;

            if (value == null)
            {
                return false;
            }

            if (!base.IsEqual(encodeable)) return false;
            if (!Utils.IsEqual(m_pubSubConfiguration, value.m_pubSubConfiguration)) return false;
            if (!Utils.IsEqual(m_requireCompleteUpdate, value.m_requireCompleteUpdate)) return false;
            if (!Utils.IsEqual(m_configurationReferences, value.m_configurationReferences)) return false;

            return base.IsEqual(encodeable);
        }    

        #if !NET_STANDARD
        /// <summary cref="ICloneable.Clone" />
        public override object Clone()
        {
            return (PubSubCommunicationConfigurationDataType)this.MemberwiseClone();
        }
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            PubSubCommunicationConfigurationDataType clone = (PubSubCommunicationConfigurationDataType)base.MemberwiseClone();

            clone.m_pubSubConfiguration = (Opc.Ua.PubSubConfiguration2DataType)Utils.Clone(this.m_pubSubConfiguration);
            clone.m_requireCompleteUpdate = (bool)Utils.Clone(this.m_requireCompleteUpdate);
            clone.m_configurationReferences = (PubSubConfigurationRefDataTypeCollection)Utils.Clone(this.m_configurationReferences);

            return clone;
        }
        #endregion

        #region Private Fields
        private Opc.Ua.PubSubConfiguration2DataType m_pubSubConfiguration;
        private bool m_requireCompleteUpdate;
        private PubSubConfigurationRefDataTypeCollection m_configurationReferences;
        #endregion
    }

    #region PubSubCommunicationConfigurationDataTypeCollection Class
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfPubSubCommunicationConfigurationDataType", Namespace = UAModel.FXData.Namespaces.FXData, ItemName = "PubSubCommunicationConfigurationDataType")]
    #if !NET_STANDARD
    public partial class PubSubCommunicationConfigurationDataTypeCollection : List<PubSubCommunicationConfigurationDataType>, ICloneable
    #else
    public partial class PubSubCommunicationConfigurationDataTypeCollection : List<PubSubCommunicationConfigurationDataType>
    #endif
    {
        #region Constructors
        /// <remarks />
        public PubSubCommunicationConfigurationDataTypeCollection() {}

        /// <remarks />
        public PubSubCommunicationConfigurationDataTypeCollection(int capacity) : base(capacity) {}

        /// <remarks />
        public PubSubCommunicationConfigurationDataTypeCollection(IEnumerable<PubSubCommunicationConfigurationDataType> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <remarks />
        public static implicit operator PubSubCommunicationConfigurationDataTypeCollection(PubSubCommunicationConfigurationDataType[] values)
        {
            if (values != null)
            {
                return new PubSubCommunicationConfigurationDataTypeCollection(values);
            }

            return new PubSubCommunicationConfigurationDataTypeCollection();
        }

        /// <remarks />
        public static explicit operator PubSubCommunicationConfigurationDataType[](PubSubCommunicationConfigurationDataTypeCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <remarks />
        public object Clone()
        {
            return (PubSubCommunicationConfigurationDataTypeCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            PubSubCommunicationConfigurationDataTypeCollection clone = new PubSubCommunicationConfigurationDataTypeCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((PubSubCommunicationConfigurationDataType)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region CommunicationConfigurationResultDataType Class
    #if (!OPCUA_EXCLUDE_CommunicationConfigurationResultDataType)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = UAModel.FXData.Namespaces.FXData)]
    public partial class CommunicationConfigurationResultDataType : IEncodeable, IJsonEncodeable
    {
        #region Constructors
        /// <remarks />
        public CommunicationConfigurationResultDataType()
        {
            Initialize();
        }
            
        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }
            
        private void Initialize()
        {
        }
        #endregion

        #region Public Properties
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public virtual ExpandedNodeId TypeId => DataTypeIds.CommunicationConfigurationResultDataType; 

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public virtual ExpandedNodeId BinaryEncodingId => ObjectIds.CommunicationConfigurationResultDataType_Encoding_DefaultBinary;

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public virtual ExpandedNodeId XmlEncodingId => ObjectIds.CommunicationConfigurationResultDataType_Encoding_DefaultXml;
                    
        /// <summary cref="IJsonEncodeable.JsonEncodingId" />
        public virtual ExpandedNodeId JsonEncodingId => ObjectIds.CommunicationConfigurationResultDataType_Encoding_DefaultJson; 

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public virtual void Encode(IEncoder encoder)
        {
            encoder.PushNamespace(UAModel.FXData.Namespaces.FXData);


            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public virtual void Decode(IDecoder decoder)
        {
            decoder.PushNamespace(UAModel.FXData.Namespaces.FXData);


            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public virtual bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            CommunicationConfigurationResultDataType value = encodeable as CommunicationConfigurationResultDataType;

            if (value == null)
            {
                return false;
            }


            return true;
        }

        #if !NET_STANDARD
        /// <summary cref="ICloneable.Clone" />
        public virtual object Clone()
        {
            return (CommunicationConfigurationResultDataType)this.MemberwiseClone();
        }
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            CommunicationConfigurationResultDataType clone = (CommunicationConfigurationResultDataType)base.MemberwiseClone();


            return clone;
        }
        #endregion

        #region Private Fields
        #endregion
    }

    #region CommunicationConfigurationResultDataTypeCollection Class
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfCommunicationConfigurationResultDataType", Namespace = UAModel.FXData.Namespaces.FXData, ItemName = "CommunicationConfigurationResultDataType")]
    #if !NET_STANDARD
    public partial class CommunicationConfigurationResultDataTypeCollection : List<CommunicationConfigurationResultDataType>, ICloneable
    #else
    public partial class CommunicationConfigurationResultDataTypeCollection : List<CommunicationConfigurationResultDataType>
    #endif
    {
        #region Constructors
        /// <remarks />
        public CommunicationConfigurationResultDataTypeCollection() {}

        /// <remarks />
        public CommunicationConfigurationResultDataTypeCollection(int capacity) : base(capacity) {}

        /// <remarks />
        public CommunicationConfigurationResultDataTypeCollection(IEnumerable<CommunicationConfigurationResultDataType> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <remarks />
        public static implicit operator CommunicationConfigurationResultDataTypeCollection(CommunicationConfigurationResultDataType[] values)
        {
            if (values != null)
            {
                return new CommunicationConfigurationResultDataTypeCollection(values);
            }

            return new CommunicationConfigurationResultDataTypeCollection();
        }

        /// <remarks />
        public static explicit operator CommunicationConfigurationResultDataType[](CommunicationConfigurationResultDataTypeCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <remarks />
        public object Clone()
        {
            return (CommunicationConfigurationResultDataTypeCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            CommunicationConfigurationResultDataTypeCollection clone = new CommunicationConfigurationResultDataTypeCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((CommunicationConfigurationResultDataType)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region PubSubCommunicationConfigurationResultDataType Class
    #if (!OPCUA_EXCLUDE_PubSubCommunicationConfigurationResultDataType)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = UAModel.FXData.Namespaces.FXData)]
    public partial class PubSubCommunicationConfigurationResultDataType : UAModel.FXData.CommunicationConfigurationResultDataType
    {
        #region Constructors
        /// <remarks />
        public PubSubCommunicationConfigurationResultDataType()
        {
            Initialize();
        }

        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }

        private void Initialize()
        {
            m_result = StatusCodes.Good;
            m_changesApplied = true;
            m_referenceResults = new StatusCodeCollection();
            m_configurationValues = new PubSubConfigurationValueDataTypeCollection();
            m_configurationObjects = new NodeIdCollection();
        }
        #endregion

        #region Public Properties
        /// <remarks />
        [DataMember(Name = "Result", IsRequired = false, Order = 1)]
        public StatusCode Result
        {
            get { return m_result;  }
            set { m_result = value; }
        }

        /// <remarks />
        [DataMember(Name = "ChangesApplied", IsRequired = false, Order = 2)]
        public bool ChangesApplied
        {
            get { return m_changesApplied;  }
            set { m_changesApplied = value; }
        }

        /// <remarks />
        [DataMember(Name = "ReferenceResults", IsRequired = false, Order = 3)]
        public StatusCodeCollection ReferenceResults
        {
            get
            {
                return m_referenceResults;
            }

            set
            {
                m_referenceResults = value;

                if (value == null)
                {
                    m_referenceResults = new StatusCodeCollection();
                }
            }
        }

        /// <remarks />
        [DataMember(Name = "ConfigurationValues", IsRequired = false, Order = 4)]
        public PubSubConfigurationValueDataTypeCollection ConfigurationValues
        {
            get
            {
                return m_configurationValues;
            }

            set
            {
                m_configurationValues = value;

                if (value == null)
                {
                    m_configurationValues = new PubSubConfigurationValueDataTypeCollection();
                }
            }
        }

        /// <remarks />
        [DataMember(Name = "ConfigurationObjects", IsRequired = false, Order = 5)]
        public NodeIdCollection ConfigurationObjects
        {
            get
            {
                return m_configurationObjects;
            }

            set
            {
                m_configurationObjects = value;

                if (value == null)
                {
                    m_configurationObjects = new NodeIdCollection();
                }
            }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public override ExpandedNodeId TypeId => DataTypeIds.PubSubCommunicationConfigurationResultDataType; 

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public override ExpandedNodeId BinaryEncodingId => ObjectIds.PubSubCommunicationConfigurationResultDataType_Encoding_DefaultBinary;

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public override ExpandedNodeId XmlEncodingId => ObjectIds.PubSubCommunicationConfigurationResultDataType_Encoding_DefaultXml;
            
        /// <summary cref="IJsonEncodeable.JsonEncodingId" />
        public override ExpandedNodeId JsonEncodingId => ObjectIds.PubSubCommunicationConfigurationResultDataType_Encoding_DefaultJson; 

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public override void Encode(IEncoder encoder)
        {
            base.Encode(encoder);

            encoder.PushNamespace(UAModel.FXData.Namespaces.FXData);

            encoder.WriteStatusCode("Result", Result);
            encoder.WriteBoolean("ChangesApplied", ChangesApplied);
            encoder.WriteStatusCodeArray("ReferenceResults", ReferenceResults);
            encoder.WriteEncodeableArray("ConfigurationValues", ConfigurationValues.ToArray(), typeof(Opc.Ua.PubSubConfigurationValueDataType));
            encoder.WriteNodeIdArray("ConfigurationObjects", ConfigurationObjects);

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public override void Decode(IDecoder decoder)
        {
            base.Decode(decoder);

            decoder.PushNamespace(UAModel.FXData.Namespaces.FXData);

            Result = decoder.ReadStatusCode("Result");
            ChangesApplied = decoder.ReadBoolean("ChangesApplied");
            ReferenceResults = decoder.ReadStatusCodeArray("ReferenceResults");
            ConfigurationValues = (Opc.Ua.PubSubConfigurationValueDataTypeCollection)decoder.ReadEncodeableArray("ConfigurationValues", typeof(Opc.Ua.PubSubConfigurationValueDataType));
            ConfigurationObjects = decoder.ReadNodeIdArray("ConfigurationObjects");

            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public override bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            PubSubCommunicationConfigurationResultDataType value = encodeable as PubSubCommunicationConfigurationResultDataType;

            if (value == null)
            {
                return false;
            }

            if (!base.IsEqual(encodeable)) return false;
            if (!Utils.IsEqual(m_result, value.m_result)) return false;
            if (!Utils.IsEqual(m_changesApplied, value.m_changesApplied)) return false;
            if (!Utils.IsEqual(m_referenceResults, value.m_referenceResults)) return false;
            if (!Utils.IsEqual(m_configurationValues, value.m_configurationValues)) return false;
            if (!Utils.IsEqual(m_configurationObjects, value.m_configurationObjects)) return false;

            return base.IsEqual(encodeable);
        }    

        #if !NET_STANDARD
        /// <summary cref="ICloneable.Clone" />
        public override object Clone()
        {
            return (PubSubCommunicationConfigurationResultDataType)this.MemberwiseClone();
        }
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            PubSubCommunicationConfigurationResultDataType clone = (PubSubCommunicationConfigurationResultDataType)base.MemberwiseClone();

            clone.m_result = (StatusCode)Utils.Clone(this.m_result);
            clone.m_changesApplied = (bool)Utils.Clone(this.m_changesApplied);
            clone.m_referenceResults = (StatusCodeCollection)Utils.Clone(this.m_referenceResults);
            clone.m_configurationValues = (PubSubConfigurationValueDataTypeCollection)Utils.Clone(this.m_configurationValues);
            clone.m_configurationObjects = (NodeIdCollection)Utils.Clone(this.m_configurationObjects);

            return clone;
        }
        #endregion

        #region Private Fields
        private StatusCode m_result;
        private bool m_changesApplied;
        private StatusCodeCollection m_referenceResults;
        private PubSubConfigurationValueDataTypeCollection m_configurationValues;
        private NodeIdCollection m_configurationObjects;
        #endregion
    }

    #region PubSubCommunicationConfigurationResultDataTypeCollection Class
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfPubSubCommunicationConfigurationResultDataType", Namespace = UAModel.FXData.Namespaces.FXData, ItemName = "PubSubCommunicationConfigurationResultDataType")]
    #if !NET_STANDARD
    public partial class PubSubCommunicationConfigurationResultDataTypeCollection : List<PubSubCommunicationConfigurationResultDataType>, ICloneable
    #else
    public partial class PubSubCommunicationConfigurationResultDataTypeCollection : List<PubSubCommunicationConfigurationResultDataType>
    #endif
    {
        #region Constructors
        /// <remarks />
        public PubSubCommunicationConfigurationResultDataTypeCollection() {}

        /// <remarks />
        public PubSubCommunicationConfigurationResultDataTypeCollection(int capacity) : base(capacity) {}

        /// <remarks />
        public PubSubCommunicationConfigurationResultDataTypeCollection(IEnumerable<PubSubCommunicationConfigurationResultDataType> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <remarks />
        public static implicit operator PubSubCommunicationConfigurationResultDataTypeCollection(PubSubCommunicationConfigurationResultDataType[] values)
        {
            if (values != null)
            {
                return new PubSubCommunicationConfigurationResultDataTypeCollection(values);
            }

            return new PubSubCommunicationConfigurationResultDataTypeCollection();
        }

        /// <remarks />
        public static explicit operator PubSubCommunicationConfigurationResultDataType[](PubSubCommunicationConfigurationResultDataTypeCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <remarks />
        public object Clone()
        {
            return (PubSubCommunicationConfigurationResultDataTypeCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            PubSubCommunicationConfigurationResultDataTypeCollection clone = new PubSubCommunicationConfigurationResultDataTypeCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((PubSubCommunicationConfigurationResultDataType)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region CommunicationLinkConfigurationDataType Class
    #if (!OPCUA_EXCLUDE_CommunicationLinkConfigurationDataType)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = UAModel.FXData.Namespaces.FXData)]
    public partial class CommunicationLinkConfigurationDataType : IEncodeable, IJsonEncodeable
    {
        #region Constructors
        /// <remarks />
        public CommunicationLinkConfigurationDataType()
        {
            Initialize();
        }
            
        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }
            
        private void Initialize()
        {
        }
        #endregion

        #region Public Properties
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public virtual ExpandedNodeId TypeId => DataTypeIds.CommunicationLinkConfigurationDataType; 

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public virtual ExpandedNodeId BinaryEncodingId => ObjectIds.CommunicationLinkConfigurationDataType_Encoding_DefaultBinary;

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public virtual ExpandedNodeId XmlEncodingId => ObjectIds.CommunicationLinkConfigurationDataType_Encoding_DefaultXml;
                    
        /// <summary cref="IJsonEncodeable.JsonEncodingId" />
        public virtual ExpandedNodeId JsonEncodingId => ObjectIds.CommunicationLinkConfigurationDataType_Encoding_DefaultJson; 

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public virtual void Encode(IEncoder encoder)
        {
            encoder.PushNamespace(UAModel.FXData.Namespaces.FXData);


            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public virtual void Decode(IDecoder decoder)
        {
            decoder.PushNamespace(UAModel.FXData.Namespaces.FXData);


            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public virtual bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            CommunicationLinkConfigurationDataType value = encodeable as CommunicationLinkConfigurationDataType;

            if (value == null)
            {
                return false;
            }


            return true;
        }

        #if !NET_STANDARD
        /// <summary cref="ICloneable.Clone" />
        public virtual object Clone()
        {
            return (CommunicationLinkConfigurationDataType)this.MemberwiseClone();
        }
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            CommunicationLinkConfigurationDataType clone = (CommunicationLinkConfigurationDataType)base.MemberwiseClone();


            return clone;
        }
        #endregion

        #region Private Fields
        #endregion
    }

    #region CommunicationLinkConfigurationDataTypeCollection Class
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfCommunicationLinkConfigurationDataType", Namespace = UAModel.FXData.Namespaces.FXData, ItemName = "CommunicationLinkConfigurationDataType")]
    #if !NET_STANDARD
    public partial class CommunicationLinkConfigurationDataTypeCollection : List<CommunicationLinkConfigurationDataType>, ICloneable
    #else
    public partial class CommunicationLinkConfigurationDataTypeCollection : List<CommunicationLinkConfigurationDataType>
    #endif
    {
        #region Constructors
        /// <remarks />
        public CommunicationLinkConfigurationDataTypeCollection() {}

        /// <remarks />
        public CommunicationLinkConfigurationDataTypeCollection(int capacity) : base(capacity) {}

        /// <remarks />
        public CommunicationLinkConfigurationDataTypeCollection(IEnumerable<CommunicationLinkConfigurationDataType> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <remarks />
        public static implicit operator CommunicationLinkConfigurationDataTypeCollection(CommunicationLinkConfigurationDataType[] values)
        {
            if (values != null)
            {
                return new CommunicationLinkConfigurationDataTypeCollection(values);
            }

            return new CommunicationLinkConfigurationDataTypeCollection();
        }

        /// <remarks />
        public static explicit operator CommunicationLinkConfigurationDataType[](CommunicationLinkConfigurationDataTypeCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <remarks />
        public object Clone()
        {
            return (CommunicationLinkConfigurationDataTypeCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            CommunicationLinkConfigurationDataTypeCollection clone = new CommunicationLinkConfigurationDataTypeCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((CommunicationLinkConfigurationDataType)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region PubSubCommunicationLinkConfigurationDataType Class
    #if (!OPCUA_EXCLUDE_PubSubCommunicationLinkConfigurationDataType)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = UAModel.FXData.Namespaces.FXData)]
    public partial class PubSubCommunicationLinkConfigurationDataType : UAModel.FXData.CommunicationLinkConfigurationDataType
    {
        #region Constructors
        /// <remarks />
        public PubSubCommunicationLinkConfigurationDataType()
        {
            Initialize();
        }

        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }

        private void Initialize()
        {
            m_dataSetReaderRef = new Opc.Ua.PubSubConfigurationRefDataType();
            m_expectedSubscribedDataSetVersion = new Opc.Ua.ConfigurationVersionDataType();
            m_dataSetWriterRef = new Opc.Ua.PubSubConfigurationRefDataType();
            m_expectedPublishedDataSetVersion = new Opc.Ua.ConfigurationVersionDataType();
        }
        #endregion

        #region Public Properties
        /// <remarks />
        [DataMember(Name = "DataSetReaderRef", IsRequired = false, Order = 1)]
        public Opc.Ua.PubSubConfigurationRefDataType DataSetReaderRef
        {
            get
            {
                return m_dataSetReaderRef;
            }

            set
            {
                m_dataSetReaderRef = value;

                if (value == null)
                {
                    m_dataSetReaderRef = new Opc.Ua.PubSubConfigurationRefDataType();
                }
            }
        }

        /// <remarks />
        [DataMember(Name = "ExpectedSubscribedDataSetVersion", IsRequired = false, Order = 2)]
        public Opc.Ua.ConfigurationVersionDataType ExpectedSubscribedDataSetVersion
        {
            get
            {
                return m_expectedSubscribedDataSetVersion;
            }

            set
            {
                m_expectedSubscribedDataSetVersion = value;

                if (value == null)
                {
                    m_expectedSubscribedDataSetVersion = new Opc.Ua.ConfigurationVersionDataType();
                }
            }
        }

        /// <remarks />
        [DataMember(Name = "DataSetWriterRef", IsRequired = false, Order = 3)]
        public Opc.Ua.PubSubConfigurationRefDataType DataSetWriterRef
        {
            get
            {
                return m_dataSetWriterRef;
            }

            set
            {
                m_dataSetWriterRef = value;

                if (value == null)
                {
                    m_dataSetWriterRef = new Opc.Ua.PubSubConfigurationRefDataType();
                }
            }
        }

        /// <remarks />
        [DataMember(Name = "ExpectedPublishedDataSetVersion", IsRequired = false, Order = 4)]
        public Opc.Ua.ConfigurationVersionDataType ExpectedPublishedDataSetVersion
        {
            get
            {
                return m_expectedPublishedDataSetVersion;
            }

            set
            {
                m_expectedPublishedDataSetVersion = value;

                if (value == null)
                {
                    m_expectedPublishedDataSetVersion = new Opc.Ua.ConfigurationVersionDataType();
                }
            }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public override ExpandedNodeId TypeId => DataTypeIds.PubSubCommunicationLinkConfigurationDataType; 

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public override ExpandedNodeId BinaryEncodingId => ObjectIds.PubSubCommunicationLinkConfigurationDataType_Encoding_DefaultBinary;

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public override ExpandedNodeId XmlEncodingId => ObjectIds.PubSubCommunicationLinkConfigurationDataType_Encoding_DefaultXml;
            
        /// <summary cref="IJsonEncodeable.JsonEncodingId" />
        public override ExpandedNodeId JsonEncodingId => ObjectIds.PubSubCommunicationLinkConfigurationDataType_Encoding_DefaultJson; 

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public override void Encode(IEncoder encoder)
        {
            base.Encode(encoder);

            encoder.PushNamespace(UAModel.FXData.Namespaces.FXData);

            encoder.WriteEncodeable("DataSetReaderRef", DataSetReaderRef, typeof(Opc.Ua.PubSubConfigurationRefDataType));
            encoder.WriteEncodeable("ExpectedSubscribedDataSetVersion", ExpectedSubscribedDataSetVersion, typeof(Opc.Ua.ConfigurationVersionDataType));
            encoder.WriteEncodeable("DataSetWriterRef", DataSetWriterRef, typeof(Opc.Ua.PubSubConfigurationRefDataType));
            encoder.WriteEncodeable("ExpectedPublishedDataSetVersion", ExpectedPublishedDataSetVersion, typeof(Opc.Ua.ConfigurationVersionDataType));

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public override void Decode(IDecoder decoder)
        {
            base.Decode(decoder);

            decoder.PushNamespace(UAModel.FXData.Namespaces.FXData);

            DataSetReaderRef = (Opc.Ua.PubSubConfigurationRefDataType)decoder.ReadEncodeable("DataSetReaderRef", typeof(Opc.Ua.PubSubConfigurationRefDataType));
            ExpectedSubscribedDataSetVersion = (Opc.Ua.ConfigurationVersionDataType)decoder.ReadEncodeable("ExpectedSubscribedDataSetVersion", typeof(Opc.Ua.ConfigurationVersionDataType));
            DataSetWriterRef = (Opc.Ua.PubSubConfigurationRefDataType)decoder.ReadEncodeable("DataSetWriterRef", typeof(Opc.Ua.PubSubConfigurationRefDataType));
            ExpectedPublishedDataSetVersion = (Opc.Ua.ConfigurationVersionDataType)decoder.ReadEncodeable("ExpectedPublishedDataSetVersion", typeof(Opc.Ua.ConfigurationVersionDataType));

            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public override bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            PubSubCommunicationLinkConfigurationDataType value = encodeable as PubSubCommunicationLinkConfigurationDataType;

            if (value == null)
            {
                return false;
            }

            if (!base.IsEqual(encodeable)) return false;
            if (!Utils.IsEqual(m_dataSetReaderRef, value.m_dataSetReaderRef)) return false;
            if (!Utils.IsEqual(m_expectedSubscribedDataSetVersion, value.m_expectedSubscribedDataSetVersion)) return false;
            if (!Utils.IsEqual(m_dataSetWriterRef, value.m_dataSetWriterRef)) return false;
            if (!Utils.IsEqual(m_expectedPublishedDataSetVersion, value.m_expectedPublishedDataSetVersion)) return false;

            return base.IsEqual(encodeable);
        }    

        #if !NET_STANDARD
        /// <summary cref="ICloneable.Clone" />
        public override object Clone()
        {
            return (PubSubCommunicationLinkConfigurationDataType)this.MemberwiseClone();
        }
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            PubSubCommunicationLinkConfigurationDataType clone = (PubSubCommunicationLinkConfigurationDataType)base.MemberwiseClone();

            clone.m_dataSetReaderRef = (Opc.Ua.PubSubConfigurationRefDataType)Utils.Clone(this.m_dataSetReaderRef);
            clone.m_expectedSubscribedDataSetVersion = (Opc.Ua.ConfigurationVersionDataType)Utils.Clone(this.m_expectedSubscribedDataSetVersion);
            clone.m_dataSetWriterRef = (Opc.Ua.PubSubConfigurationRefDataType)Utils.Clone(this.m_dataSetWriterRef);
            clone.m_expectedPublishedDataSetVersion = (Opc.Ua.ConfigurationVersionDataType)Utils.Clone(this.m_expectedPublishedDataSetVersion);

            return clone;
        }
        #endregion

        #region Private Fields
        private Opc.Ua.PubSubConfigurationRefDataType m_dataSetReaderRef;
        private Opc.Ua.ConfigurationVersionDataType m_expectedSubscribedDataSetVersion;
        private Opc.Ua.PubSubConfigurationRefDataType m_dataSetWriterRef;
        private Opc.Ua.ConfigurationVersionDataType m_expectedPublishedDataSetVersion;
        #endregion
    }

    #region PubSubCommunicationLinkConfigurationDataTypeCollection Class
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfPubSubCommunicationLinkConfigurationDataType", Namespace = UAModel.FXData.Namespaces.FXData, ItemName = "PubSubCommunicationLinkConfigurationDataType")]
    #if !NET_STANDARD
    public partial class PubSubCommunicationLinkConfigurationDataTypeCollection : List<PubSubCommunicationLinkConfigurationDataType>, ICloneable
    #else
    public partial class PubSubCommunicationLinkConfigurationDataTypeCollection : List<PubSubCommunicationLinkConfigurationDataType>
    #endif
    {
        #region Constructors
        /// <remarks />
        public PubSubCommunicationLinkConfigurationDataTypeCollection() {}

        /// <remarks />
        public PubSubCommunicationLinkConfigurationDataTypeCollection(int capacity) : base(capacity) {}

        /// <remarks />
        public PubSubCommunicationLinkConfigurationDataTypeCollection(IEnumerable<PubSubCommunicationLinkConfigurationDataType> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <remarks />
        public static implicit operator PubSubCommunicationLinkConfigurationDataTypeCollection(PubSubCommunicationLinkConfigurationDataType[] values)
        {
            if (values != null)
            {
                return new PubSubCommunicationLinkConfigurationDataTypeCollection(values);
            }

            return new PubSubCommunicationLinkConfigurationDataTypeCollection();
        }

        /// <remarks />
        public static explicit operator PubSubCommunicationLinkConfigurationDataType[](PubSubCommunicationLinkConfigurationDataTypeCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <remarks />
        public object Clone()
        {
            return (PubSubCommunicationLinkConfigurationDataTypeCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            PubSubCommunicationLinkConfigurationDataTypeCollection clone = new PubSubCommunicationLinkConfigurationDataTypeCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((PubSubCommunicationLinkConfigurationDataType)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region ConnectionEndpointConfigurationDataType Class
    #if (!OPCUA_EXCLUDE_ConnectionEndpointConfigurationDataType)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = UAModel.FXData.Namespaces.FXData)]
    public partial class ConnectionEndpointConfigurationDataType : IEncodeable, IJsonEncodeable
    {
        #region Constructors
        /// <remarks />
        public ConnectionEndpointConfigurationDataType()
        {
            Initialize();
        }
            
        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }
            
        private void Initialize()
        {
            m_functionalEntityNode = null;
            m_connectionEndpoint = new ConnectionEndpointDefinitionDataType();
            m_expectedVerificationVariables = new NodeIdValuePairCollection();
            m_controlGroups = new NodeIdCollection();
            m_configurationData = new NodeIdValuePairCollection();
            m_communicationLinks = new CommunicationLinkConfigurationDataType();
        }
        #endregion

        #region Public Properties
        /// <remarks />
        [DataMember(Name = "FunctionalEntityNode", IsRequired = false, Order = 1)]
        public NodeId FunctionalEntityNode
        {
            get { return m_functionalEntityNode;  }
            set { m_functionalEntityNode = value; }
        }

        /// <remarks />
        [DataMember(Name = "ConnectionEndpoint", IsRequired = false, Order = 2)]
        public ConnectionEndpointDefinitionDataType ConnectionEndpoint
        {
            get
            {
                return m_connectionEndpoint;
            }

            set
            {
                m_connectionEndpoint = value;

                if (value == null)
                {
                    m_connectionEndpoint = new ConnectionEndpointDefinitionDataType();
                }
            }
        }

        /// <remarks />
        [DataMember(Name = "ExpectedVerificationVariables", IsRequired = false, Order = 3)]
        public NodeIdValuePairCollection ExpectedVerificationVariables
        {
            get
            {
                return m_expectedVerificationVariables;
            }

            set
            {
                m_expectedVerificationVariables = value;

                if (value == null)
                {
                    m_expectedVerificationVariables = new NodeIdValuePairCollection();
                }
            }
        }

        /// <remarks />
        [DataMember(Name = "ControlGroups", IsRequired = false, Order = 4)]
        public NodeIdCollection ControlGroups
        {
            get
            {
                return m_controlGroups;
            }

            set
            {
                m_controlGroups = value;

                if (value == null)
                {
                    m_controlGroups = new NodeIdCollection();
                }
            }
        }

        /// <remarks />
        [DataMember(Name = "ConfigurationData", IsRequired = false, Order = 5)]
        public NodeIdValuePairCollection ConfigurationData
        {
            get
            {
                return m_configurationData;
            }

            set
            {
                m_configurationData = value;

                if (value == null)
                {
                    m_configurationData = new NodeIdValuePairCollection();
                }
            }
        }

        /// <remarks />
        [DataMember(Name = "CommunicationLinks", IsRequired = false, Order = 6)]
        public CommunicationLinkConfigurationDataType CommunicationLinks
        {
            get { return m_communicationLinks;  }
            set { m_communicationLinks = value; }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public virtual ExpandedNodeId TypeId => DataTypeIds.ConnectionEndpointConfigurationDataType; 

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public virtual ExpandedNodeId BinaryEncodingId => ObjectIds.ConnectionEndpointConfigurationDataType_Encoding_DefaultBinary;

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public virtual ExpandedNodeId XmlEncodingId => ObjectIds.ConnectionEndpointConfigurationDataType_Encoding_DefaultXml;
                    
        /// <summary cref="IJsonEncodeable.JsonEncodingId" />
        public virtual ExpandedNodeId JsonEncodingId => ObjectIds.ConnectionEndpointConfigurationDataType_Encoding_DefaultJson; 

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public virtual void Encode(IEncoder encoder)
        {
            encoder.PushNamespace(UAModel.FXData.Namespaces.FXData);

            encoder.WriteNodeId("FunctionalEntityNode", FunctionalEntityNode);
            encoder.WriteEncodeable("ConnectionEndpoint", ConnectionEndpoint, typeof(ConnectionEndpointDefinitionDataType));
            encoder.WriteEncodeableArray("ExpectedVerificationVariables", ExpectedVerificationVariables.ToArray(), typeof(NodeIdValuePair));
            encoder.WriteNodeIdArray("ControlGroups", ControlGroups);
            encoder.WriteEncodeableArray("ConfigurationData", ConfigurationData.ToArray(), typeof(NodeIdValuePair));
            encoder.WriteExtensionObject("CommunicationLinks", new ExtensionObject(CommunicationLinks));

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public virtual void Decode(IDecoder decoder)
        {
            decoder.PushNamespace(UAModel.FXData.Namespaces.FXData);

            FunctionalEntityNode = decoder.ReadNodeId("FunctionalEntityNode");
            ConnectionEndpoint = (ConnectionEndpointDefinitionDataType)decoder.ReadEncodeable("ConnectionEndpoint", typeof(ConnectionEndpointDefinitionDataType));
            ExpectedVerificationVariables = (NodeIdValuePairCollection)decoder.ReadEncodeableArray("ExpectedVerificationVariables", typeof(NodeIdValuePair));
            ControlGroups = decoder.ReadNodeIdArray("ControlGroups");
            ConfigurationData = (NodeIdValuePairCollection)decoder.ReadEncodeableArray("ConfigurationData", typeof(NodeIdValuePair));
            CommunicationLinks = (CommunicationLinkConfigurationDataType)ExtensionObject.ToEncodeable(decoder.ReadExtensionObject("CommunicationLinks"));

            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public virtual bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            ConnectionEndpointConfigurationDataType value = encodeable as ConnectionEndpointConfigurationDataType;

            if (value == null)
            {
                return false;
            }

            if (!Utils.IsEqual(m_functionalEntityNode, value.m_functionalEntityNode)) return false;
            if (!Utils.IsEqual(m_connectionEndpoint, value.m_connectionEndpoint)) return false;
            if (!Utils.IsEqual(m_expectedVerificationVariables, value.m_expectedVerificationVariables)) return false;
            if (!Utils.IsEqual(m_controlGroups, value.m_controlGroups)) return false;
            if (!Utils.IsEqual(m_configurationData, value.m_configurationData)) return false;
            if (!Utils.IsEqual(m_communicationLinks, value.m_communicationLinks)) return false;

            return true;
        }

        #if !NET_STANDARD
        /// <summary cref="ICloneable.Clone" />
        public virtual object Clone()
        {
            return (ConnectionEndpointConfigurationDataType)this.MemberwiseClone();
        }
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            ConnectionEndpointConfigurationDataType clone = (ConnectionEndpointConfigurationDataType)base.MemberwiseClone();

            clone.m_functionalEntityNode = (NodeId)Utils.Clone(this.m_functionalEntityNode);
            clone.m_connectionEndpoint = (ConnectionEndpointDefinitionDataType)Utils.Clone(this.m_connectionEndpoint);
            clone.m_expectedVerificationVariables = (NodeIdValuePairCollection)Utils.Clone(this.m_expectedVerificationVariables);
            clone.m_controlGroups = (NodeIdCollection)Utils.Clone(this.m_controlGroups);
            clone.m_configurationData = (NodeIdValuePairCollection)Utils.Clone(this.m_configurationData);
            clone.m_communicationLinks = (CommunicationLinkConfigurationDataType)Utils.Clone(this.m_communicationLinks);

            return clone;
        }
        #endregion

        #region Private Fields
        private NodeId m_functionalEntityNode;
        private ConnectionEndpointDefinitionDataType m_connectionEndpoint;
        private NodeIdValuePairCollection m_expectedVerificationVariables;
        private NodeIdCollection m_controlGroups;
        private NodeIdValuePairCollection m_configurationData;
        private CommunicationLinkConfigurationDataType m_communicationLinks;
        #endregion
    }

    #region ConnectionEndpointConfigurationDataTypeCollection Class
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfConnectionEndpointConfigurationDataType", Namespace = UAModel.FXData.Namespaces.FXData, ItemName = "ConnectionEndpointConfigurationDataType")]
    #if !NET_STANDARD
    public partial class ConnectionEndpointConfigurationDataTypeCollection : List<ConnectionEndpointConfigurationDataType>, ICloneable
    #else
    public partial class ConnectionEndpointConfigurationDataTypeCollection : List<ConnectionEndpointConfigurationDataType>
    #endif
    {
        #region Constructors
        /// <remarks />
        public ConnectionEndpointConfigurationDataTypeCollection() {}

        /// <remarks />
        public ConnectionEndpointConfigurationDataTypeCollection(int capacity) : base(capacity) {}

        /// <remarks />
        public ConnectionEndpointConfigurationDataTypeCollection(IEnumerable<ConnectionEndpointConfigurationDataType> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <remarks />
        public static implicit operator ConnectionEndpointConfigurationDataTypeCollection(ConnectionEndpointConfigurationDataType[] values)
        {
            if (values != null)
            {
                return new ConnectionEndpointConfigurationDataTypeCollection(values);
            }

            return new ConnectionEndpointConfigurationDataTypeCollection();
        }

        /// <remarks />
        public static explicit operator ConnectionEndpointConfigurationDataType[](ConnectionEndpointConfigurationDataTypeCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <remarks />
        public object Clone()
        {
            return (ConnectionEndpointConfigurationDataTypeCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            ConnectionEndpointConfigurationDataTypeCollection clone = new ConnectionEndpointConfigurationDataTypeCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((ConnectionEndpointConfigurationDataType)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region ConnectionEndpointConfigurationResultDataType Class
    #if (!OPCUA_EXCLUDE_ConnectionEndpointConfigurationResultDataType)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = UAModel.FXData.Namespaces.FXData)]
    public partial class ConnectionEndpointConfigurationResultDataType : IEncodeable, IJsonEncodeable
    {
        #region Constructors
        /// <remarks />
        public ConnectionEndpointConfigurationResultDataType()
        {
            Initialize();
        }
            
        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }
            
        private void Initialize()
        {
            m_connectionEndpointId = null;
            m_functionalEntityNodeResult = StatusCodes.Good;
            m_connectionEndpointResult = StatusCodes.Good;
            m_verificationResult = FunctionalEntityVerificationResultEnum.NotSet;
            m_verificationStatus = StatusCodes.Good;
            m_verificationVariablesErrors = new StatusCodeCollection();
            m_establishControlResult = new StatusCodeCollection();
            m_configurationDataResult = new StatusCodeCollection();
            m_reassignControlResult = new StatusCodeCollection();
            m_communicationLinksResult = StatusCodes.Good;
            m_enableCommunicationResult = StatusCodes.Good;
        }
        #endregion

        #region Public Properties
        /// <remarks />
        [DataMember(Name = "ConnectionEndpointId", IsRequired = false, Order = 1)]
        public NodeId ConnectionEndpointId
        {
            get { return m_connectionEndpointId;  }
            set { m_connectionEndpointId = value; }
        }

        /// <remarks />
        [DataMember(Name = "FunctionalEntityNodeResult", IsRequired = false, Order = 2)]
        public StatusCode FunctionalEntityNodeResult
        {
            get { return m_functionalEntityNodeResult;  }
            set { m_functionalEntityNodeResult = value; }
        }

        /// <remarks />
        [DataMember(Name = "ConnectionEndpointResult", IsRequired = false, Order = 3)]
        public StatusCode ConnectionEndpointResult
        {
            get { return m_connectionEndpointResult;  }
            set { m_connectionEndpointResult = value; }
        }

        /// <remarks />
        [DataMember(Name = "VerificationResult", IsRequired = false, Order = 4)]
        public FunctionalEntityVerificationResultEnum VerificationResult
        {
            get { return m_verificationResult;  }
            set { m_verificationResult = value; }
        }

        /// <remarks />
        [DataMember(Name = "VerificationStatus", IsRequired = false, Order = 5)]
        public StatusCode VerificationStatus
        {
            get { return m_verificationStatus;  }
            set { m_verificationStatus = value; }
        }

        /// <remarks />
        [DataMember(Name = "VerificationVariablesErrors", IsRequired = false, Order = 6)]
        public StatusCodeCollection VerificationVariablesErrors
        {
            get
            {
                return m_verificationVariablesErrors;
            }

            set
            {
                m_verificationVariablesErrors = value;

                if (value == null)
                {
                    m_verificationVariablesErrors = new StatusCodeCollection();
                }
            }
        }

        /// <remarks />
        [DataMember(Name = "EstablishControlResult", IsRequired = false, Order = 7)]
        public StatusCodeCollection EstablishControlResult
        {
            get
            {
                return m_establishControlResult;
            }

            set
            {
                m_establishControlResult = value;

                if (value == null)
                {
                    m_establishControlResult = new StatusCodeCollection();
                }
            }
        }

        /// <remarks />
        [DataMember(Name = "ConfigurationDataResult", IsRequired = false, Order = 8)]
        public StatusCodeCollection ConfigurationDataResult
        {
            get
            {
                return m_configurationDataResult;
            }

            set
            {
                m_configurationDataResult = value;

                if (value == null)
                {
                    m_configurationDataResult = new StatusCodeCollection();
                }
            }
        }

        /// <remarks />
        [DataMember(Name = "ReassignControlResult", IsRequired = false, Order = 9)]
        public StatusCodeCollection ReassignControlResult
        {
            get
            {
                return m_reassignControlResult;
            }

            set
            {
                m_reassignControlResult = value;

                if (value == null)
                {
                    m_reassignControlResult = new StatusCodeCollection();
                }
            }
        }

        /// <remarks />
        [DataMember(Name = "CommunicationLinksResult", IsRequired = false, Order = 10)]
        public StatusCode CommunicationLinksResult
        {
            get { return m_communicationLinksResult;  }
            set { m_communicationLinksResult = value; }
        }

        /// <remarks />
        [DataMember(Name = "EnableCommunicationResult", IsRequired = false, Order = 11)]
        public StatusCode EnableCommunicationResult
        {
            get { return m_enableCommunicationResult;  }
            set { m_enableCommunicationResult = value; }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public virtual ExpandedNodeId TypeId => DataTypeIds.ConnectionEndpointConfigurationResultDataType; 

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public virtual ExpandedNodeId BinaryEncodingId => ObjectIds.ConnectionEndpointConfigurationResultDataType_Encoding_DefaultBinary;

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public virtual ExpandedNodeId XmlEncodingId => ObjectIds.ConnectionEndpointConfigurationResultDataType_Encoding_DefaultXml;
                    
        /// <summary cref="IJsonEncodeable.JsonEncodingId" />
        public virtual ExpandedNodeId JsonEncodingId => ObjectIds.ConnectionEndpointConfigurationResultDataType_Encoding_DefaultJson; 

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public virtual void Encode(IEncoder encoder)
        {
            encoder.PushNamespace(UAModel.FXData.Namespaces.FXData);

            encoder.WriteNodeId("ConnectionEndpointId", ConnectionEndpointId);
            encoder.WriteStatusCode("FunctionalEntityNodeResult", FunctionalEntityNodeResult);
            encoder.WriteStatusCode("ConnectionEndpointResult", ConnectionEndpointResult);
            encoder.WriteEnumerated("VerificationResult", VerificationResult);
            encoder.WriteStatusCode("VerificationStatus", VerificationStatus);
            encoder.WriteStatusCodeArray("VerificationVariablesErrors", VerificationVariablesErrors);
            encoder.WriteStatusCodeArray("EstablishControlResult", EstablishControlResult);
            encoder.WriteStatusCodeArray("ConfigurationDataResult", ConfigurationDataResult);
            encoder.WriteStatusCodeArray("ReassignControlResult", ReassignControlResult);
            encoder.WriteStatusCode("CommunicationLinksResult", CommunicationLinksResult);
            encoder.WriteStatusCode("EnableCommunicationResult", EnableCommunicationResult);

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public virtual void Decode(IDecoder decoder)
        {
            decoder.PushNamespace(UAModel.FXData.Namespaces.FXData);

            ConnectionEndpointId = decoder.ReadNodeId("ConnectionEndpointId");
            FunctionalEntityNodeResult = decoder.ReadStatusCode("FunctionalEntityNodeResult");
            ConnectionEndpointResult = decoder.ReadStatusCode("ConnectionEndpointResult");
            VerificationResult = (FunctionalEntityVerificationResultEnum)decoder.ReadEnumerated("VerificationResult", typeof(FunctionalEntityVerificationResultEnum));
            VerificationStatus = decoder.ReadStatusCode("VerificationStatus");
            VerificationVariablesErrors = decoder.ReadStatusCodeArray("VerificationVariablesErrors");
            EstablishControlResult = decoder.ReadStatusCodeArray("EstablishControlResult");
            ConfigurationDataResult = decoder.ReadStatusCodeArray("ConfigurationDataResult");
            ReassignControlResult = decoder.ReadStatusCodeArray("ReassignControlResult");
            CommunicationLinksResult = decoder.ReadStatusCode("CommunicationLinksResult");
            EnableCommunicationResult = decoder.ReadStatusCode("EnableCommunicationResult");

            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public virtual bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            ConnectionEndpointConfigurationResultDataType value = encodeable as ConnectionEndpointConfigurationResultDataType;

            if (value == null)
            {
                return false;
            }

            if (!Utils.IsEqual(m_connectionEndpointId, value.m_connectionEndpointId)) return false;
            if (!Utils.IsEqual(m_functionalEntityNodeResult, value.m_functionalEntityNodeResult)) return false;
            if (!Utils.IsEqual(m_connectionEndpointResult, value.m_connectionEndpointResult)) return false;
            if (!Utils.IsEqual(m_verificationResult, value.m_verificationResult)) return false;
            if (!Utils.IsEqual(m_verificationStatus, value.m_verificationStatus)) return false;
            if (!Utils.IsEqual(m_verificationVariablesErrors, value.m_verificationVariablesErrors)) return false;
            if (!Utils.IsEqual(m_establishControlResult, value.m_establishControlResult)) return false;
            if (!Utils.IsEqual(m_configurationDataResult, value.m_configurationDataResult)) return false;
            if (!Utils.IsEqual(m_reassignControlResult, value.m_reassignControlResult)) return false;
            if (!Utils.IsEqual(m_communicationLinksResult, value.m_communicationLinksResult)) return false;
            if (!Utils.IsEqual(m_enableCommunicationResult, value.m_enableCommunicationResult)) return false;

            return true;
        }

        #if !NET_STANDARD
        /// <summary cref="ICloneable.Clone" />
        public virtual object Clone()
        {
            return (ConnectionEndpointConfigurationResultDataType)this.MemberwiseClone();
        }
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            ConnectionEndpointConfigurationResultDataType clone = (ConnectionEndpointConfigurationResultDataType)base.MemberwiseClone();

            clone.m_connectionEndpointId = (NodeId)Utils.Clone(this.m_connectionEndpointId);
            clone.m_functionalEntityNodeResult = (StatusCode)Utils.Clone(this.m_functionalEntityNodeResult);
            clone.m_connectionEndpointResult = (StatusCode)Utils.Clone(this.m_connectionEndpointResult);
            clone.m_verificationResult = (FunctionalEntityVerificationResultEnum)Utils.Clone(this.m_verificationResult);
            clone.m_verificationStatus = (StatusCode)Utils.Clone(this.m_verificationStatus);
            clone.m_verificationVariablesErrors = (StatusCodeCollection)Utils.Clone(this.m_verificationVariablesErrors);
            clone.m_establishControlResult = (StatusCodeCollection)Utils.Clone(this.m_establishControlResult);
            clone.m_configurationDataResult = (StatusCodeCollection)Utils.Clone(this.m_configurationDataResult);
            clone.m_reassignControlResult = (StatusCodeCollection)Utils.Clone(this.m_reassignControlResult);
            clone.m_communicationLinksResult = (StatusCode)Utils.Clone(this.m_communicationLinksResult);
            clone.m_enableCommunicationResult = (StatusCode)Utils.Clone(this.m_enableCommunicationResult);

            return clone;
        }
        #endregion

        #region Private Fields
        private NodeId m_connectionEndpointId;
        private StatusCode m_functionalEntityNodeResult;
        private StatusCode m_connectionEndpointResult;
        private FunctionalEntityVerificationResultEnum m_verificationResult;
        private StatusCode m_verificationStatus;
        private StatusCodeCollection m_verificationVariablesErrors;
        private StatusCodeCollection m_establishControlResult;
        private StatusCodeCollection m_configurationDataResult;
        private StatusCodeCollection m_reassignControlResult;
        private StatusCode m_communicationLinksResult;
        private StatusCode m_enableCommunicationResult;
        #endregion
    }

    #region ConnectionEndpointConfigurationResultDataTypeCollection Class
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfConnectionEndpointConfigurationResultDataType", Namespace = UAModel.FXData.Namespaces.FXData, ItemName = "ConnectionEndpointConfigurationResultDataType")]
    #if !NET_STANDARD
    public partial class ConnectionEndpointConfigurationResultDataTypeCollection : List<ConnectionEndpointConfigurationResultDataType>, ICloneable
    #else
    public partial class ConnectionEndpointConfigurationResultDataTypeCollection : List<ConnectionEndpointConfigurationResultDataType>
    #endif
    {
        #region Constructors
        /// <remarks />
        public ConnectionEndpointConfigurationResultDataTypeCollection() {}

        /// <remarks />
        public ConnectionEndpointConfigurationResultDataTypeCollection(int capacity) : base(capacity) {}

        /// <remarks />
        public ConnectionEndpointConfigurationResultDataTypeCollection(IEnumerable<ConnectionEndpointConfigurationResultDataType> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <remarks />
        public static implicit operator ConnectionEndpointConfigurationResultDataTypeCollection(ConnectionEndpointConfigurationResultDataType[] values)
        {
            if (values != null)
            {
                return new ConnectionEndpointConfigurationResultDataTypeCollection(values);
            }

            return new ConnectionEndpointConfigurationResultDataTypeCollection();
        }

        /// <remarks />
        public static explicit operator ConnectionEndpointConfigurationResultDataType[](ConnectionEndpointConfigurationResultDataTypeCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <remarks />
        public object Clone()
        {
            return (ConnectionEndpointConfigurationResultDataTypeCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            ConnectionEndpointConfigurationResultDataTypeCollection clone = new ConnectionEndpointConfigurationResultDataTypeCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((ConnectionEndpointConfigurationResultDataType)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region ConnectionEndpointParameterDataType Class
    #if (!OPCUA_EXCLUDE_ConnectionEndpointParameterDataType)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = UAModel.FXData.Namespaces.FXData)]
    public partial class ConnectionEndpointParameterDataType : IEncodeable, IJsonEncodeable
    {
        #region Constructors
        /// <remarks />
        public ConnectionEndpointParameterDataType()
        {
            Initialize();
        }
            
        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }
            
        private void Initialize()
        {
            m_name = null;
            m_connectionEndpointTypeId = null;
            m_inputVariableIds = new NodeIdCollection();
            m_outputVariableIds = new NodeIdCollection();
            m_isPersistent = true;
            m_cleanupTimeout = (double)0;
            m_relatedEndpoint = new RelatedEndpointDataType();
            m_isPreconfigured = true;
        }
        #endregion

        #region Public Properties
        /// <remarks />
        [DataMember(Name = "Name", IsRequired = false, Order = 1)]
        public string Name
        {
            get { return m_name;  }
            set { m_name = value; }
        }

        /// <remarks />
        [DataMember(Name = "ConnectionEndpointTypeId", IsRequired = false, Order = 2)]
        public NodeId ConnectionEndpointTypeId
        {
            get { return m_connectionEndpointTypeId;  }
            set { m_connectionEndpointTypeId = value; }
        }

        /// <remarks />
        [DataMember(Name = "InputVariableIds", IsRequired = false, Order = 3)]
        public NodeIdCollection InputVariableIds
        {
            get
            {
                return m_inputVariableIds;
            }

            set
            {
                m_inputVariableIds = value;

                if (value == null)
                {
                    m_inputVariableIds = new NodeIdCollection();
                }
            }
        }

        /// <remarks />
        [DataMember(Name = "OutputVariableIds", IsRequired = false, Order = 4)]
        public NodeIdCollection OutputVariableIds
        {
            get
            {
                return m_outputVariableIds;
            }

            set
            {
                m_outputVariableIds = value;

                if (value == null)
                {
                    m_outputVariableIds = new NodeIdCollection();
                }
            }
        }

        /// <remarks />
        [DataMember(Name = "IsPersistent", IsRequired = false, Order = 5)]
        public bool IsPersistent
        {
            get { return m_isPersistent;  }
            set { m_isPersistent = value; }
        }

        /// <remarks />
        [DataMember(Name = "CleanupTimeout", IsRequired = false, Order = 6)]
        public double CleanupTimeout
        {
            get { return m_cleanupTimeout;  }
            set { m_cleanupTimeout = value; }
        }

        /// <remarks />
        [DataMember(Name = "RelatedEndpoint", IsRequired = false, Order = 7)]
        public RelatedEndpointDataType RelatedEndpoint
        {
            get
            {
                return m_relatedEndpoint;
            }

            set
            {
                m_relatedEndpoint = value;

                if (value == null)
                {
                    m_relatedEndpoint = new RelatedEndpointDataType();
                }
            }
        }

        /// <remarks />
        [DataMember(Name = "IsPreconfigured", IsRequired = false, Order = 8)]
        public bool IsPreconfigured
        {
            get { return m_isPreconfigured;  }
            set { m_isPreconfigured = value; }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public virtual ExpandedNodeId TypeId => DataTypeIds.ConnectionEndpointParameterDataType; 

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public virtual ExpandedNodeId BinaryEncodingId => ObjectIds.ConnectionEndpointParameterDataType_Encoding_DefaultBinary;

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public virtual ExpandedNodeId XmlEncodingId => ObjectIds.ConnectionEndpointParameterDataType_Encoding_DefaultXml;
                    
        /// <summary cref="IJsonEncodeable.JsonEncodingId" />
        public virtual ExpandedNodeId JsonEncodingId => ObjectIds.ConnectionEndpointParameterDataType_Encoding_DefaultJson; 

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public virtual void Encode(IEncoder encoder)
        {
            encoder.PushNamespace(UAModel.FXData.Namespaces.FXData);

            encoder.WriteString("Name", Name);
            encoder.WriteNodeId("ConnectionEndpointTypeId", ConnectionEndpointTypeId);
            encoder.WriteNodeIdArray("InputVariableIds", InputVariableIds);
            encoder.WriteNodeIdArray("OutputVariableIds", OutputVariableIds);
            encoder.WriteBoolean("IsPersistent", IsPersistent);
            encoder.WriteDouble("CleanupTimeout", CleanupTimeout);
            encoder.WriteEncodeable("RelatedEndpoint", RelatedEndpoint, typeof(RelatedEndpointDataType));
            encoder.WriteBoolean("IsPreconfigured", IsPreconfigured);

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public virtual void Decode(IDecoder decoder)
        {
            decoder.PushNamespace(UAModel.FXData.Namespaces.FXData);

            Name = decoder.ReadString("Name");
            ConnectionEndpointTypeId = decoder.ReadNodeId("ConnectionEndpointTypeId");
            InputVariableIds = decoder.ReadNodeIdArray("InputVariableIds");
            OutputVariableIds = decoder.ReadNodeIdArray("OutputVariableIds");
            IsPersistent = decoder.ReadBoolean("IsPersistent");
            CleanupTimeout = decoder.ReadDouble("CleanupTimeout");
            RelatedEndpoint = (RelatedEndpointDataType)decoder.ReadEncodeable("RelatedEndpoint", typeof(RelatedEndpointDataType));
            IsPreconfigured = decoder.ReadBoolean("IsPreconfigured");

            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public virtual bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            ConnectionEndpointParameterDataType value = encodeable as ConnectionEndpointParameterDataType;

            if (value == null)
            {
                return false;
            }

            if (!Utils.IsEqual(m_name, value.m_name)) return false;
            if (!Utils.IsEqual(m_connectionEndpointTypeId, value.m_connectionEndpointTypeId)) return false;
            if (!Utils.IsEqual(m_inputVariableIds, value.m_inputVariableIds)) return false;
            if (!Utils.IsEqual(m_outputVariableIds, value.m_outputVariableIds)) return false;
            if (!Utils.IsEqual(m_isPersistent, value.m_isPersistent)) return false;
            if (!Utils.IsEqual(m_cleanupTimeout, value.m_cleanupTimeout)) return false;
            if (!Utils.IsEqual(m_relatedEndpoint, value.m_relatedEndpoint)) return false;
            if (!Utils.IsEqual(m_isPreconfigured, value.m_isPreconfigured)) return false;

            return true;
        }

        #if !NET_STANDARD
        /// <summary cref="ICloneable.Clone" />
        public virtual object Clone()
        {
            return (ConnectionEndpointParameterDataType)this.MemberwiseClone();
        }
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            ConnectionEndpointParameterDataType clone = (ConnectionEndpointParameterDataType)base.MemberwiseClone();

            clone.m_name = (string)Utils.Clone(this.m_name);
            clone.m_connectionEndpointTypeId = (NodeId)Utils.Clone(this.m_connectionEndpointTypeId);
            clone.m_inputVariableIds = (NodeIdCollection)Utils.Clone(this.m_inputVariableIds);
            clone.m_outputVariableIds = (NodeIdCollection)Utils.Clone(this.m_outputVariableIds);
            clone.m_isPersistent = (bool)Utils.Clone(this.m_isPersistent);
            clone.m_cleanupTimeout = (double)Utils.Clone(this.m_cleanupTimeout);
            clone.m_relatedEndpoint = (RelatedEndpointDataType)Utils.Clone(this.m_relatedEndpoint);
            clone.m_isPreconfigured = (bool)Utils.Clone(this.m_isPreconfigured);

            return clone;
        }
        #endregion

        #region Private Fields
        private string m_name;
        private NodeId m_connectionEndpointTypeId;
        private NodeIdCollection m_inputVariableIds;
        private NodeIdCollection m_outputVariableIds;
        private bool m_isPersistent;
        private double m_cleanupTimeout;
        private RelatedEndpointDataType m_relatedEndpoint;
        private bool m_isPreconfigured;
        #endregion
    }

    #region ConnectionEndpointParameterDataTypeCollection Class
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfConnectionEndpointParameterDataType", Namespace = UAModel.FXData.Namespaces.FXData, ItemName = "ConnectionEndpointParameterDataType")]
    #if !NET_STANDARD
    public partial class ConnectionEndpointParameterDataTypeCollection : List<ConnectionEndpointParameterDataType>, ICloneable
    #else
    public partial class ConnectionEndpointParameterDataTypeCollection : List<ConnectionEndpointParameterDataType>
    #endif
    {
        #region Constructors
        /// <remarks />
        public ConnectionEndpointParameterDataTypeCollection() {}

        /// <remarks />
        public ConnectionEndpointParameterDataTypeCollection(int capacity) : base(capacity) {}

        /// <remarks />
        public ConnectionEndpointParameterDataTypeCollection(IEnumerable<ConnectionEndpointParameterDataType> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <remarks />
        public static implicit operator ConnectionEndpointParameterDataTypeCollection(ConnectionEndpointParameterDataType[] values)
        {
            if (values != null)
            {
                return new ConnectionEndpointParameterDataTypeCollection(values);
            }

            return new ConnectionEndpointParameterDataTypeCollection();
        }

        /// <remarks />
        public static explicit operator ConnectionEndpointParameterDataType[](ConnectionEndpointParameterDataTypeCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <remarks />
        public object Clone()
        {
            return (ConnectionEndpointParameterDataTypeCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            ConnectionEndpointParameterDataTypeCollection clone = new ConnectionEndpointParameterDataTypeCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((ConnectionEndpointParameterDataType)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region PubSubConnectionEndpointParameterDataType Class
    #if (!OPCUA_EXCLUDE_PubSubConnectionEndpointParameterDataType)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = UAModel.FXData.Namespaces.FXData)]
    public partial class PubSubConnectionEndpointParameterDataType : UAModel.FXData.ConnectionEndpointParameterDataType
    {
        #region Constructors
        /// <remarks />
        public PubSubConnectionEndpointParameterDataType()
        {
            Initialize();
        }

        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }

        private void Initialize()
        {
            m_mode = PubSubConnectionEndpointModeEnum.PublisherSubscriber;
        }
        #endregion

        #region Public Properties
        /// <remarks />
        [DataMember(Name = "Mode", IsRequired = false, Order = 1)]
        public PubSubConnectionEndpointModeEnum Mode
        {
            get { return m_mode;  }
            set { m_mode = value; }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public override ExpandedNodeId TypeId => DataTypeIds.PubSubConnectionEndpointParameterDataType; 

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public override ExpandedNodeId BinaryEncodingId => ObjectIds.PubSubConnectionEndpointParameterDataType_Encoding_DefaultBinary;

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public override ExpandedNodeId XmlEncodingId => ObjectIds.PubSubConnectionEndpointParameterDataType_Encoding_DefaultXml;
            
        /// <summary cref="IJsonEncodeable.JsonEncodingId" />
        public override ExpandedNodeId JsonEncodingId => ObjectIds.PubSubConnectionEndpointParameterDataType_Encoding_DefaultJson; 

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public override void Encode(IEncoder encoder)
        {
            base.Encode(encoder);

            encoder.PushNamespace(UAModel.FXData.Namespaces.FXData);

            encoder.WriteEnumerated("Mode", Mode);

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public override void Decode(IDecoder decoder)
        {
            base.Decode(decoder);

            decoder.PushNamespace(UAModel.FXData.Namespaces.FXData);

            Mode = (PubSubConnectionEndpointModeEnum)decoder.ReadEnumerated("Mode", typeof(PubSubConnectionEndpointModeEnum));

            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public override bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            PubSubConnectionEndpointParameterDataType value = encodeable as PubSubConnectionEndpointParameterDataType;

            if (value == null)
            {
                return false;
            }

            if (!base.IsEqual(encodeable)) return false;
            if (!Utils.IsEqual(m_mode, value.m_mode)) return false;

            return base.IsEqual(encodeable);
        }    

        #if !NET_STANDARD
        /// <summary cref="ICloneable.Clone" />
        public override object Clone()
        {
            return (PubSubConnectionEndpointParameterDataType)this.MemberwiseClone();
        }
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            PubSubConnectionEndpointParameterDataType clone = (PubSubConnectionEndpointParameterDataType)base.MemberwiseClone();

            clone.m_mode = (PubSubConnectionEndpointModeEnum)Utils.Clone(this.m_mode);

            return clone;
        }
        #endregion

        #region Private Fields
        private PubSubConnectionEndpointModeEnum m_mode;
        #endregion
    }

    #region PubSubConnectionEndpointParameterDataTypeCollection Class
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfPubSubConnectionEndpointParameterDataType", Namespace = UAModel.FXData.Namespaces.FXData, ItemName = "PubSubConnectionEndpointParameterDataType")]
    #if !NET_STANDARD
    public partial class PubSubConnectionEndpointParameterDataTypeCollection : List<PubSubConnectionEndpointParameterDataType>, ICloneable
    #else
    public partial class PubSubConnectionEndpointParameterDataTypeCollection : List<PubSubConnectionEndpointParameterDataType>
    #endif
    {
        #region Constructors
        /// <remarks />
        public PubSubConnectionEndpointParameterDataTypeCollection() {}

        /// <remarks />
        public PubSubConnectionEndpointParameterDataTypeCollection(int capacity) : base(capacity) {}

        /// <remarks />
        public PubSubConnectionEndpointParameterDataTypeCollection(IEnumerable<PubSubConnectionEndpointParameterDataType> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <remarks />
        public static implicit operator PubSubConnectionEndpointParameterDataTypeCollection(PubSubConnectionEndpointParameterDataType[] values)
        {
            if (values != null)
            {
                return new PubSubConnectionEndpointParameterDataTypeCollection(values);
            }

            return new PubSubConnectionEndpointParameterDataTypeCollection();
        }

        /// <remarks />
        public static explicit operator PubSubConnectionEndpointParameterDataType[](PubSubConnectionEndpointParameterDataTypeCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <remarks />
        public object Clone()
        {
            return (PubSubConnectionEndpointParameterDataTypeCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            PubSubConnectionEndpointParameterDataTypeCollection clone = new PubSubConnectionEndpointParameterDataTypeCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((PubSubConnectionEndpointParameterDataType)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region NodeIdArray Class
    #if (!OPCUA_EXCLUDE_NodeIdArray)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = UAModel.FXData.Namespaces.FXData)]
    public partial class NodeIdArray : IEncodeable, IJsonEncodeable
    {
        #region Constructors
        /// <remarks />
        public NodeIdArray()
        {
            Initialize();
        }
            
        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }
            
        private void Initialize()
        {
            m_node = null;
            m_arrayIndex = new UInt32Collection();
        }
        #endregion

        #region Public Properties
        /// <remarks />
        [DataMember(Name = "Node", IsRequired = false, Order = 1)]
        public NodeId Node
        {
            get { return m_node;  }
            set { m_node = value; }
        }

        /// <remarks />
        [DataMember(Name = "ArrayIndex", IsRequired = false, Order = 2)]
        public UInt32Collection ArrayIndex
        {
            get
            {
                return m_arrayIndex;
            }

            set
            {
                m_arrayIndex = value;

                if (value == null)
                {
                    m_arrayIndex = new UInt32Collection();
                }
            }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public virtual ExpandedNodeId TypeId => DataTypeIds.NodeIdArray; 

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public virtual ExpandedNodeId BinaryEncodingId => ObjectIds.NodeIdArray_Encoding_DefaultBinary;

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public virtual ExpandedNodeId XmlEncodingId => ObjectIds.NodeIdArray_Encoding_DefaultXml;
                    
        /// <summary cref="IJsonEncodeable.JsonEncodingId" />
        public virtual ExpandedNodeId JsonEncodingId => ObjectIds.NodeIdArray_Encoding_DefaultJson; 

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public virtual void Encode(IEncoder encoder)
        {
            encoder.PushNamespace(UAModel.FXData.Namespaces.FXData);

            encoder.WriteNodeId("Node", Node);
            encoder.WriteUInt32Array("ArrayIndex", ArrayIndex);

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public virtual void Decode(IDecoder decoder)
        {
            decoder.PushNamespace(UAModel.FXData.Namespaces.FXData);

            Node = decoder.ReadNodeId("Node");
            ArrayIndex = decoder.ReadUInt32Array("ArrayIndex");

            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public virtual bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            NodeIdArray value = encodeable as NodeIdArray;

            if (value == null)
            {
                return false;
            }

            if (!Utils.IsEqual(m_node, value.m_node)) return false;
            if (!Utils.IsEqual(m_arrayIndex, value.m_arrayIndex)) return false;

            return true;
        }

        #if !NET_STANDARD
        /// <summary cref="ICloneable.Clone" />
        public virtual object Clone()
        {
            return (NodeIdArray)this.MemberwiseClone();
        }
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            NodeIdArray clone = (NodeIdArray)base.MemberwiseClone();

            clone.m_node = (NodeId)Utils.Clone(this.m_node);
            clone.m_arrayIndex = (UInt32Collection)Utils.Clone(this.m_arrayIndex);

            return clone;
        }
        #endregion

        #region Private Fields
        private NodeId m_node;
        private UInt32Collection m_arrayIndex;
        #endregion
    }

    #region NodeIdArrayCollection Class
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfNodeIdArray", Namespace = UAModel.FXData.Namespaces.FXData, ItemName = "NodeIdArray")]
    #if !NET_STANDARD
    public partial class NodeIdArrayCollection : List<NodeIdArray>, ICloneable
    #else
    public partial class NodeIdArrayCollection : List<NodeIdArray>
    #endif
    {
        #region Constructors
        /// <remarks />
        public NodeIdArrayCollection() {}

        /// <remarks />
        public NodeIdArrayCollection(int capacity) : base(capacity) {}

        /// <remarks />
        public NodeIdArrayCollection(IEnumerable<NodeIdArray> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <remarks />
        public static implicit operator NodeIdArrayCollection(NodeIdArray[] values)
        {
            if (values != null)
            {
                return new NodeIdArrayCollection(values);
            }

            return new NodeIdArrayCollection();
        }

        /// <remarks />
        public static explicit operator NodeIdArray[](NodeIdArrayCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <remarks />
        public object Clone()
        {
            return (NodeIdArrayCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            NodeIdArrayCollection clone = new NodeIdArrayCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((NodeIdArray)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region NodeIdValuePair Class
    #if (!OPCUA_EXCLUDE_NodeIdValuePair)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = UAModel.FXData.Namespaces.FXData)]
    public partial class NodeIdValuePair : IEncodeable, IJsonEncodeable
    {
        #region Constructors
        /// <remarks />
        public NodeIdValuePair()
        {
            Initialize();
        }
            
        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }
            
        private void Initialize()
        {
            m_key = new NodeIdArray();
            m_value = Variant.Null;
        }
        #endregion

        #region Public Properties
        /// <remarks />
        [DataMember(Name = "Key", IsRequired = false, Order = 1)]
        public NodeIdArray Key
        {
            get
            {
                return m_key;
            }

            set
            {
                m_key = value;

                if (value == null)
                {
                    m_key = new NodeIdArray();
                }
            }
        }

        /// <remarks />
        [DataMember(Name = "Value", IsRequired = false, Order = 2)]
        public Variant Value
        {
            get { return m_value;  }
            set { m_value = value; }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public virtual ExpandedNodeId TypeId => DataTypeIds.NodeIdValuePair; 

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public virtual ExpandedNodeId BinaryEncodingId => ObjectIds.NodeIdValuePair_Encoding_DefaultBinary;

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public virtual ExpandedNodeId XmlEncodingId => ObjectIds.NodeIdValuePair_Encoding_DefaultXml;
                    
        /// <summary cref="IJsonEncodeable.JsonEncodingId" />
        public virtual ExpandedNodeId JsonEncodingId => ObjectIds.NodeIdValuePair_Encoding_DefaultJson; 

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public virtual void Encode(IEncoder encoder)
        {
            encoder.PushNamespace(UAModel.FXData.Namespaces.FXData);

            encoder.WriteEncodeable("Key", Key, typeof(NodeIdArray));
            encoder.WriteVariant("Value", Value);

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public virtual void Decode(IDecoder decoder)
        {
            decoder.PushNamespace(UAModel.FXData.Namespaces.FXData);

            Key = (NodeIdArray)decoder.ReadEncodeable("Key", typeof(NodeIdArray));
            Value = decoder.ReadVariant("Value");

            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public virtual bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            NodeIdValuePair value = encodeable as NodeIdValuePair;

            if (value == null)
            {
                return false;
            }

            if (!Utils.IsEqual(m_key, value.m_key)) return false;
            if (!Utils.IsEqual(m_value, value.m_value)) return false;

            return true;
        }

        #if !NET_STANDARD
        /// <summary cref="ICloneable.Clone" />
        public virtual object Clone()
        {
            return (NodeIdValuePair)this.MemberwiseClone();
        }
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            NodeIdValuePair clone = (NodeIdValuePair)base.MemberwiseClone();

            clone.m_key = (NodeIdArray)Utils.Clone(this.m_key);
            clone.m_value = (Variant)Utils.Clone(this.m_value);

            return clone;
        }
        #endregion

        #region Private Fields
        private NodeIdArray m_key;
        private Variant m_value;
        #endregion
    }

    #region NodeIdValuePairCollection Class
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfNodeIdValuePair", Namespace = UAModel.FXData.Namespaces.FXData, ItemName = "NodeIdValuePair")]
    #if !NET_STANDARD
    public partial class NodeIdValuePairCollection : List<NodeIdValuePair>, ICloneable
    #else
    public partial class NodeIdValuePairCollection : List<NodeIdValuePair>
    #endif
    {
        #region Constructors
        /// <remarks />
        public NodeIdValuePairCollection() {}

        /// <remarks />
        public NodeIdValuePairCollection(int capacity) : base(capacity) {}

        /// <remarks />
        public NodeIdValuePairCollection(IEnumerable<NodeIdValuePair> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <remarks />
        public static implicit operator NodeIdValuePairCollection(NodeIdValuePair[] values)
        {
            if (values != null)
            {
                return new NodeIdValuePairCollection(values);
            }

            return new NodeIdValuePairCollection();
        }

        /// <remarks />
        public static explicit operator NodeIdValuePair[](NodeIdValuePairCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <remarks />
        public object Clone()
        {
            return (NodeIdValuePairCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            NodeIdValuePairCollection clone = new NodeIdValuePairCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((NodeIdValuePair)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region RelatedEndpointDataType Class
    #if (!OPCUA_EXCLUDE_RelatedEndpointDataType)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = UAModel.FXData.Namespaces.FXData)]
    public partial class RelatedEndpointDataType : IEncodeable, IJsonEncodeable
    {
        #region Constructors
        /// <remarks />
        public RelatedEndpointDataType()
        {
            Initialize();
        }
            
        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }
            
        private void Initialize()
        {
            m_address = null;
            m_connectionEndpointPath = new PortableQualifiedNameCollection();
            m_connectionEndpointName = null;
        }
        #endregion

        #region Public Properties
        /// <remarks />
        [DataMember(Name = "Address", IsRequired = false, Order = 1)]
        public string Address
        {
            get { return m_address;  }
            set { m_address = value; }
        }

        /// <remarks />
        [DataMember(Name = "ConnectionEndpointPath", IsRequired = false, Order = 2)]
        public PortableQualifiedNameCollection ConnectionEndpointPath
        {
            get
            {
                return m_connectionEndpointPath;
            }

            set
            {
                m_connectionEndpointPath = value;

                if (value == null)
                {
                    m_connectionEndpointPath = new PortableQualifiedNameCollection();
                }
            }
        }

        /// <remarks />
        [DataMember(Name = "ConnectionEndpointName", IsRequired = false, Order = 3)]
        public string ConnectionEndpointName
        {
            get { return m_connectionEndpointName;  }
            set { m_connectionEndpointName = value; }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public virtual ExpandedNodeId TypeId => DataTypeIds.RelatedEndpointDataType; 

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public virtual ExpandedNodeId BinaryEncodingId => ObjectIds.RelatedEndpointDataType_Encoding_DefaultBinary;

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public virtual ExpandedNodeId XmlEncodingId => ObjectIds.RelatedEndpointDataType_Encoding_DefaultXml;
                    
        /// <summary cref="IJsonEncodeable.JsonEncodingId" />
        public virtual ExpandedNodeId JsonEncodingId => ObjectIds.RelatedEndpointDataType_Encoding_DefaultJson; 

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public virtual void Encode(IEncoder encoder)
        {
            encoder.PushNamespace(UAModel.FXData.Namespaces.FXData);

            encoder.WriteString("Address", Address);
            encoder.WriteEncodeableArray("ConnectionEndpointPath", ConnectionEndpointPath.ToArray(), typeof(Opc.Ua.PortableQualifiedName));
            encoder.WriteString("ConnectionEndpointName", ConnectionEndpointName);

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public virtual void Decode(IDecoder decoder)
        {
            decoder.PushNamespace(UAModel.FXData.Namespaces.FXData);

            Address = decoder.ReadString("Address");
            ConnectionEndpointPath = (Opc.Ua.PortableQualifiedNameCollection)decoder.ReadEncodeableArray("ConnectionEndpointPath", typeof(Opc.Ua.PortableQualifiedName));
            ConnectionEndpointName = decoder.ReadString("ConnectionEndpointName");

            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public virtual bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            RelatedEndpointDataType value = encodeable as RelatedEndpointDataType;

            if (value == null)
            {
                return false;
            }

            if (!Utils.IsEqual(m_address, value.m_address)) return false;
            if (!Utils.IsEqual(m_connectionEndpointPath, value.m_connectionEndpointPath)) return false;
            if (!Utils.IsEqual(m_connectionEndpointName, value.m_connectionEndpointName)) return false;

            return true;
        }

        #if !NET_STANDARD
        /// <summary cref="ICloneable.Clone" />
        public virtual object Clone()
        {
            return (RelatedEndpointDataType)this.MemberwiseClone();
        }
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            RelatedEndpointDataType clone = (RelatedEndpointDataType)base.MemberwiseClone();

            clone.m_address = (string)Utils.Clone(this.m_address);
            clone.m_connectionEndpointPath = (PortableQualifiedNameCollection)Utils.Clone(this.m_connectionEndpointPath);
            clone.m_connectionEndpointName = (string)Utils.Clone(this.m_connectionEndpointName);

            return clone;
        }
        #endregion

        #region Private Fields
        private string m_address;
        private PortableQualifiedNameCollection m_connectionEndpointPath;
        private string m_connectionEndpointName;
        #endregion
    }

    #region RelatedEndpointDataTypeCollection Class
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfRelatedEndpointDataType", Namespace = UAModel.FXData.Namespaces.FXData, ItemName = "RelatedEndpointDataType")]
    #if !NET_STANDARD
    public partial class RelatedEndpointDataTypeCollection : List<RelatedEndpointDataType>, ICloneable
    #else
    public partial class RelatedEndpointDataTypeCollection : List<RelatedEndpointDataType>
    #endif
    {
        #region Constructors
        /// <remarks />
        public RelatedEndpointDataTypeCollection() {}

        /// <remarks />
        public RelatedEndpointDataTypeCollection(int capacity) : base(capacity) {}

        /// <remarks />
        public RelatedEndpointDataTypeCollection(IEnumerable<RelatedEndpointDataType> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <remarks />
        public static implicit operator RelatedEndpointDataTypeCollection(RelatedEndpointDataType[] values)
        {
            if (values != null)
            {
                return new RelatedEndpointDataTypeCollection(values);
            }

            return new RelatedEndpointDataTypeCollection();
        }

        /// <remarks />
        public static explicit operator RelatedEndpointDataType[](RelatedEndpointDataTypeCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <remarks />
        public object Clone()
        {
            return (RelatedEndpointDataTypeCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            RelatedEndpointDataTypeCollection clone = new RelatedEndpointDataTypeCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((RelatedEndpointDataType)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region ReserveCommunicationIdsDataType Class
    #if (!OPCUA_EXCLUDE_ReserveCommunicationIdsDataType)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = UAModel.FXData.Namespaces.FXData)]
    public partial class ReserveCommunicationIdsDataType : IEncodeable, IJsonEncodeable
    {
        #region Constructors
        /// <remarks />
        public ReserveCommunicationIdsDataType()
        {
            Initialize();
        }
            
        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }
            
        private void Initialize()
        {
        }
        #endregion

        #region Public Properties
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public virtual ExpandedNodeId TypeId => DataTypeIds.ReserveCommunicationIdsDataType; 

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public virtual ExpandedNodeId BinaryEncodingId => ObjectIds.ReserveCommunicationIdsDataType_Encoding_DefaultBinary;

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public virtual ExpandedNodeId XmlEncodingId => ObjectIds.ReserveCommunicationIdsDataType_Encoding_DefaultXml;
                    
        /// <summary cref="IJsonEncodeable.JsonEncodingId" />
        public virtual ExpandedNodeId JsonEncodingId => ObjectIds.ReserveCommunicationIdsDataType_Encoding_DefaultJson; 

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public virtual void Encode(IEncoder encoder)
        {
            encoder.PushNamespace(UAModel.FXData.Namespaces.FXData);


            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public virtual void Decode(IDecoder decoder)
        {
            decoder.PushNamespace(UAModel.FXData.Namespaces.FXData);


            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public virtual bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            ReserveCommunicationIdsDataType value = encodeable as ReserveCommunicationIdsDataType;

            if (value == null)
            {
                return false;
            }


            return true;
        }

        #if !NET_STANDARD
        /// <summary cref="ICloneable.Clone" />
        public virtual object Clone()
        {
            return (ReserveCommunicationIdsDataType)this.MemberwiseClone();
        }
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            ReserveCommunicationIdsDataType clone = (ReserveCommunicationIdsDataType)base.MemberwiseClone();


            return clone;
        }
        #endregion

        #region Private Fields
        #endregion
    }

    #region ReserveCommunicationIdsDataTypeCollection Class
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfReserveCommunicationIdsDataType", Namespace = UAModel.FXData.Namespaces.FXData, ItemName = "ReserveCommunicationIdsDataType")]
    #if !NET_STANDARD
    public partial class ReserveCommunicationIdsDataTypeCollection : List<ReserveCommunicationIdsDataType>, ICloneable
    #else
    public partial class ReserveCommunicationIdsDataTypeCollection : List<ReserveCommunicationIdsDataType>
    #endif
    {
        #region Constructors
        /// <remarks />
        public ReserveCommunicationIdsDataTypeCollection() {}

        /// <remarks />
        public ReserveCommunicationIdsDataTypeCollection(int capacity) : base(capacity) {}

        /// <remarks />
        public ReserveCommunicationIdsDataTypeCollection(IEnumerable<ReserveCommunicationIdsDataType> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <remarks />
        public static implicit operator ReserveCommunicationIdsDataTypeCollection(ReserveCommunicationIdsDataType[] values)
        {
            if (values != null)
            {
                return new ReserveCommunicationIdsDataTypeCollection(values);
            }

            return new ReserveCommunicationIdsDataTypeCollection();
        }

        /// <remarks />
        public static explicit operator ReserveCommunicationIdsDataType[](ReserveCommunicationIdsDataTypeCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <remarks />
        public object Clone()
        {
            return (ReserveCommunicationIdsDataTypeCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            ReserveCommunicationIdsDataTypeCollection clone = new ReserveCommunicationIdsDataTypeCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((ReserveCommunicationIdsDataType)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region PubSubReserveCommunicationIdsDataType Class
    #if (!OPCUA_EXCLUDE_PubSubReserveCommunicationIdsDataType)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = UAModel.FXData.Namespaces.FXData)]
    public partial class PubSubReserveCommunicationIdsDataType : UAModel.FXData.ReserveCommunicationIdsDataType
    {
        #region Constructors
        /// <remarks />
        public PubSubReserveCommunicationIdsDataType()
        {
            Initialize();
        }

        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }

        private void Initialize()
        {
            m_transportProfileUri = null;
            m_numReqWriterGroupIds = (ushort)0;
            m_numReqDataSetWriterIds = (ushort)0;
        }
        #endregion

        #region Public Properties
        /// <remarks />
        [DataMember(Name = "TransportProfileUri", IsRequired = false, Order = 1)]
        public string TransportProfileUri
        {
            get { return m_transportProfileUri;  }
            set { m_transportProfileUri = value; }
        }

        /// <remarks />
        [DataMember(Name = "NumReqWriterGroupIds", IsRequired = false, Order = 2)]
        public ushort NumReqWriterGroupIds
        {
            get { return m_numReqWriterGroupIds;  }
            set { m_numReqWriterGroupIds = value; }
        }

        /// <remarks />
        [DataMember(Name = "NumReqDataSetWriterIds", IsRequired = false, Order = 3)]
        public ushort NumReqDataSetWriterIds
        {
            get { return m_numReqDataSetWriterIds;  }
            set { m_numReqDataSetWriterIds = value; }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public override ExpandedNodeId TypeId => DataTypeIds.PubSubReserveCommunicationIdsDataType; 

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public override ExpandedNodeId BinaryEncodingId => ObjectIds.PubSubReserveCommunicationIdsDataType_Encoding_DefaultBinary;

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public override ExpandedNodeId XmlEncodingId => ObjectIds.PubSubReserveCommunicationIdsDataType_Encoding_DefaultXml;
            
        /// <summary cref="IJsonEncodeable.JsonEncodingId" />
        public override ExpandedNodeId JsonEncodingId => ObjectIds.PubSubReserveCommunicationIdsDataType_Encoding_DefaultJson; 

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public override void Encode(IEncoder encoder)
        {
            base.Encode(encoder);

            encoder.PushNamespace(UAModel.FXData.Namespaces.FXData);

            encoder.WriteString("TransportProfileUri", TransportProfileUri);
            encoder.WriteUInt16("NumReqWriterGroupIds", NumReqWriterGroupIds);
            encoder.WriteUInt16("NumReqDataSetWriterIds", NumReqDataSetWriterIds);

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public override void Decode(IDecoder decoder)
        {
            base.Decode(decoder);

            decoder.PushNamespace(UAModel.FXData.Namespaces.FXData);

            TransportProfileUri = decoder.ReadString("TransportProfileUri");
            NumReqWriterGroupIds = decoder.ReadUInt16("NumReqWriterGroupIds");
            NumReqDataSetWriterIds = decoder.ReadUInt16("NumReqDataSetWriterIds");

            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public override bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            PubSubReserveCommunicationIdsDataType value = encodeable as PubSubReserveCommunicationIdsDataType;

            if (value == null)
            {
                return false;
            }

            if (!base.IsEqual(encodeable)) return false;
            if (!Utils.IsEqual(m_transportProfileUri, value.m_transportProfileUri)) return false;
            if (!Utils.IsEqual(m_numReqWriterGroupIds, value.m_numReqWriterGroupIds)) return false;
            if (!Utils.IsEqual(m_numReqDataSetWriterIds, value.m_numReqDataSetWriterIds)) return false;

            return base.IsEqual(encodeable);
        }    

        #if !NET_STANDARD
        /// <summary cref="ICloneable.Clone" />
        public override object Clone()
        {
            return (PubSubReserveCommunicationIdsDataType)this.MemberwiseClone();
        }
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            PubSubReserveCommunicationIdsDataType clone = (PubSubReserveCommunicationIdsDataType)base.MemberwiseClone();

            clone.m_transportProfileUri = (string)Utils.Clone(this.m_transportProfileUri);
            clone.m_numReqWriterGroupIds = (ushort)Utils.Clone(this.m_numReqWriterGroupIds);
            clone.m_numReqDataSetWriterIds = (ushort)Utils.Clone(this.m_numReqDataSetWriterIds);

            return clone;
        }
        #endregion

        #region Private Fields
        private string m_transportProfileUri;
        private ushort m_numReqWriterGroupIds;
        private ushort m_numReqDataSetWriterIds;
        #endregion
    }

    #region PubSubReserveCommunicationIdsDataTypeCollection Class
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfPubSubReserveCommunicationIdsDataType", Namespace = UAModel.FXData.Namespaces.FXData, ItemName = "PubSubReserveCommunicationIdsDataType")]
    #if !NET_STANDARD
    public partial class PubSubReserveCommunicationIdsDataTypeCollection : List<PubSubReserveCommunicationIdsDataType>, ICloneable
    #else
    public partial class PubSubReserveCommunicationIdsDataTypeCollection : List<PubSubReserveCommunicationIdsDataType>
    #endif
    {
        #region Constructors
        /// <remarks />
        public PubSubReserveCommunicationIdsDataTypeCollection() {}

        /// <remarks />
        public PubSubReserveCommunicationIdsDataTypeCollection(int capacity) : base(capacity) {}

        /// <remarks />
        public PubSubReserveCommunicationIdsDataTypeCollection(IEnumerable<PubSubReserveCommunicationIdsDataType> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <remarks />
        public static implicit operator PubSubReserveCommunicationIdsDataTypeCollection(PubSubReserveCommunicationIdsDataType[] values)
        {
            if (values != null)
            {
                return new PubSubReserveCommunicationIdsDataTypeCollection(values);
            }

            return new PubSubReserveCommunicationIdsDataTypeCollection();
        }

        /// <remarks />
        public static explicit operator PubSubReserveCommunicationIdsDataType[](PubSubReserveCommunicationIdsDataTypeCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <remarks />
        public object Clone()
        {
            return (PubSubReserveCommunicationIdsDataTypeCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            PubSubReserveCommunicationIdsDataTypeCollection clone = new PubSubReserveCommunicationIdsDataTypeCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((PubSubReserveCommunicationIdsDataType)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region ReserveCommunicationIdsResultDataType Class
    #if (!OPCUA_EXCLUDE_ReserveCommunicationIdsResultDataType)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = UAModel.FXData.Namespaces.FXData)]
    public partial class ReserveCommunicationIdsResultDataType : IEncodeable, IJsonEncodeable
    {
        #region Constructors
        /// <remarks />
        public ReserveCommunicationIdsResultDataType()
        {
            Initialize();
        }
            
        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }
            
        private void Initialize()
        {
        }
        #endregion

        #region Public Properties
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public virtual ExpandedNodeId TypeId => DataTypeIds.ReserveCommunicationIdsResultDataType; 

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public virtual ExpandedNodeId BinaryEncodingId => ObjectIds.ReserveCommunicationIdsResultDataType_Encoding_DefaultBinary;

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public virtual ExpandedNodeId XmlEncodingId => ObjectIds.ReserveCommunicationIdsResultDataType_Encoding_DefaultXml;
                    
        /// <summary cref="IJsonEncodeable.JsonEncodingId" />
        public virtual ExpandedNodeId JsonEncodingId => ObjectIds.ReserveCommunicationIdsResultDataType_Encoding_DefaultJson; 

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public virtual void Encode(IEncoder encoder)
        {
            encoder.PushNamespace(UAModel.FXData.Namespaces.FXData);


            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public virtual void Decode(IDecoder decoder)
        {
            decoder.PushNamespace(UAModel.FXData.Namespaces.FXData);


            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public virtual bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            ReserveCommunicationIdsResultDataType value = encodeable as ReserveCommunicationIdsResultDataType;

            if (value == null)
            {
                return false;
            }


            return true;
        }

        #if !NET_STANDARD
        /// <summary cref="ICloneable.Clone" />
        public virtual object Clone()
        {
            return (ReserveCommunicationIdsResultDataType)this.MemberwiseClone();
        }
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            ReserveCommunicationIdsResultDataType clone = (ReserveCommunicationIdsResultDataType)base.MemberwiseClone();


            return clone;
        }
        #endregion

        #region Private Fields
        #endregion
    }

    #region ReserveCommunicationIdsResultDataTypeCollection Class
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfReserveCommunicationIdsResultDataType", Namespace = UAModel.FXData.Namespaces.FXData, ItemName = "ReserveCommunicationIdsResultDataType")]
    #if !NET_STANDARD
    public partial class ReserveCommunicationIdsResultDataTypeCollection : List<ReserveCommunicationIdsResultDataType>, ICloneable
    #else
    public partial class ReserveCommunicationIdsResultDataTypeCollection : List<ReserveCommunicationIdsResultDataType>
    #endif
    {
        #region Constructors
        /// <remarks />
        public ReserveCommunicationIdsResultDataTypeCollection() {}

        /// <remarks />
        public ReserveCommunicationIdsResultDataTypeCollection(int capacity) : base(capacity) {}

        /// <remarks />
        public ReserveCommunicationIdsResultDataTypeCollection(IEnumerable<ReserveCommunicationIdsResultDataType> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <remarks />
        public static implicit operator ReserveCommunicationIdsResultDataTypeCollection(ReserveCommunicationIdsResultDataType[] values)
        {
            if (values != null)
            {
                return new ReserveCommunicationIdsResultDataTypeCollection(values);
            }

            return new ReserveCommunicationIdsResultDataTypeCollection();
        }

        /// <remarks />
        public static explicit operator ReserveCommunicationIdsResultDataType[](ReserveCommunicationIdsResultDataTypeCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <remarks />
        public object Clone()
        {
            return (ReserveCommunicationIdsResultDataTypeCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            ReserveCommunicationIdsResultDataTypeCollection clone = new ReserveCommunicationIdsResultDataTypeCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((ReserveCommunicationIdsResultDataType)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region PubSubReserveCommunicationIdsResultDataType Class
    #if (!OPCUA_EXCLUDE_PubSubReserveCommunicationIdsResultDataType)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = UAModel.FXData.Namespaces.FXData)]
    public partial class PubSubReserveCommunicationIdsResultDataType : UAModel.FXData.ReserveCommunicationIdsResultDataType
    {
        #region Constructors
        /// <remarks />
        public PubSubReserveCommunicationIdsResultDataType()
        {
            Initialize();
        }

        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }

        private void Initialize()
        {
            m_result = StatusCodes.Good;
            m_defaultPublisherId = Variant.Null;
            m_writerGroupIds = new UInt16Collection();
            m_dataSetWriterIds = new UInt16Collection();
        }
        #endregion

        #region Public Properties
        /// <remarks />
        [DataMember(Name = "Result", IsRequired = false, Order = 1)]
        public StatusCode Result
        {
            get { return m_result;  }
            set { m_result = value; }
        }

        /// <remarks />
        [DataMember(Name = "DefaultPublisherId", IsRequired = false, Order = 2)]
        public Variant DefaultPublisherId
        {
            get { return m_defaultPublisherId;  }
            set { m_defaultPublisherId = value; }
        }

        /// <remarks />
        [DataMember(Name = "WriterGroupIds", IsRequired = false, Order = 3)]
        public UInt16Collection WriterGroupIds
        {
            get
            {
                return m_writerGroupIds;
            }

            set
            {
                m_writerGroupIds = value;

                if (value == null)
                {
                    m_writerGroupIds = new UInt16Collection();
                }
            }
        }

        /// <remarks />
        [DataMember(Name = "DataSetWriterIds", IsRequired = false, Order = 4)]
        public UInt16Collection DataSetWriterIds
        {
            get
            {
                return m_dataSetWriterIds;
            }

            set
            {
                m_dataSetWriterIds = value;

                if (value == null)
                {
                    m_dataSetWriterIds = new UInt16Collection();
                }
            }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public override ExpandedNodeId TypeId => DataTypeIds.PubSubReserveCommunicationIdsResultDataType; 

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public override ExpandedNodeId BinaryEncodingId => ObjectIds.PubSubReserveCommunicationIdsResultDataType_Encoding_DefaultBinary;

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public override ExpandedNodeId XmlEncodingId => ObjectIds.PubSubReserveCommunicationIdsResultDataType_Encoding_DefaultXml;
            
        /// <summary cref="IJsonEncodeable.JsonEncodingId" />
        public override ExpandedNodeId JsonEncodingId => ObjectIds.PubSubReserveCommunicationIdsResultDataType_Encoding_DefaultJson; 

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public override void Encode(IEncoder encoder)
        {
            base.Encode(encoder);

            encoder.PushNamespace(UAModel.FXData.Namespaces.FXData);

            encoder.WriteStatusCode("Result", Result);
            encoder.WriteVariant("DefaultPublisherId", DefaultPublisherId);
            encoder.WriteUInt16Array("WriterGroupIds", WriterGroupIds);
            encoder.WriteUInt16Array("DataSetWriterIds", DataSetWriterIds);

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public override void Decode(IDecoder decoder)
        {
            base.Decode(decoder);

            decoder.PushNamespace(UAModel.FXData.Namespaces.FXData);

            Result = decoder.ReadStatusCode("Result");
            DefaultPublisherId = decoder.ReadVariant("DefaultPublisherId");
            WriterGroupIds = decoder.ReadUInt16Array("WriterGroupIds");
            DataSetWriterIds = decoder.ReadUInt16Array("DataSetWriterIds");

            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public override bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            PubSubReserveCommunicationIdsResultDataType value = encodeable as PubSubReserveCommunicationIdsResultDataType;

            if (value == null)
            {
                return false;
            }

            if (!base.IsEqual(encodeable)) return false;
            if (!Utils.IsEqual(m_result, value.m_result)) return false;
            if (!Utils.IsEqual(m_defaultPublisherId, value.m_defaultPublisherId)) return false;
            if (!Utils.IsEqual(m_writerGroupIds, value.m_writerGroupIds)) return false;
            if (!Utils.IsEqual(m_dataSetWriterIds, value.m_dataSetWriterIds)) return false;

            return base.IsEqual(encodeable);
        }    

        #if !NET_STANDARD
        /// <summary cref="ICloneable.Clone" />
        public override object Clone()
        {
            return (PubSubReserveCommunicationIdsResultDataType)this.MemberwiseClone();
        }
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            PubSubReserveCommunicationIdsResultDataType clone = (PubSubReserveCommunicationIdsResultDataType)base.MemberwiseClone();

            clone.m_result = (StatusCode)Utils.Clone(this.m_result);
            clone.m_defaultPublisherId = (Variant)Utils.Clone(this.m_defaultPublisherId);
            clone.m_writerGroupIds = (UInt16Collection)Utils.Clone(this.m_writerGroupIds);
            clone.m_dataSetWriterIds = (UInt16Collection)Utils.Clone(this.m_dataSetWriterIds);

            return clone;
        }
        #endregion

        #region Private Fields
        private StatusCode m_result;
        private Variant m_defaultPublisherId;
        private UInt16Collection m_writerGroupIds;
        private UInt16Collection m_dataSetWriterIds;
        #endregion
    }

    #region PubSubReserveCommunicationIdsResultDataTypeCollection Class
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfPubSubReserveCommunicationIdsResultDataType", Namespace = UAModel.FXData.Namespaces.FXData, ItemName = "PubSubReserveCommunicationIdsResultDataType")]
    #if !NET_STANDARD
    public partial class PubSubReserveCommunicationIdsResultDataTypeCollection : List<PubSubReserveCommunicationIdsResultDataType>, ICloneable
    #else
    public partial class PubSubReserveCommunicationIdsResultDataTypeCollection : List<PubSubReserveCommunicationIdsResultDataType>
    #endif
    {
        #region Constructors
        /// <remarks />
        public PubSubReserveCommunicationIdsResultDataTypeCollection() {}

        /// <remarks />
        public PubSubReserveCommunicationIdsResultDataTypeCollection(int capacity) : base(capacity) {}

        /// <remarks />
        public PubSubReserveCommunicationIdsResultDataTypeCollection(IEnumerable<PubSubReserveCommunicationIdsResultDataType> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <remarks />
        public static implicit operator PubSubReserveCommunicationIdsResultDataTypeCollection(PubSubReserveCommunicationIdsResultDataType[] values)
        {
            if (values != null)
            {
                return new PubSubReserveCommunicationIdsResultDataTypeCollection(values);
            }

            return new PubSubReserveCommunicationIdsResultDataTypeCollection();
        }

        /// <remarks />
        public static explicit operator PubSubReserveCommunicationIdsResultDataType[](PubSubReserveCommunicationIdsResultDataTypeCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <remarks />
        public object Clone()
        {
            return (PubSubReserveCommunicationIdsResultDataTypeCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            PubSubReserveCommunicationIdsResultDataTypeCollection clone = new PubSubReserveCommunicationIdsResultDataTypeCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((PubSubReserveCommunicationIdsResultDataType)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region ConnectionEndpointDefinitionDataType Class
    #if (!OPCUA_EXCLUDE_ConnectionEndpointDefinitionDataType)
    /// <remarks />
    /// <exclude />
    public enum ConnectionEndpointDefinitionDataTypeFields : uint
    {
        /// <remarks />
        None = 0,
        /// <remarks />
        Parameter = 1,
        /// <remarks />
        Node = 2
    }

    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = UAModel.FXData.Namespaces.FXData)]
    public partial class ConnectionEndpointDefinitionDataType : IEncodeable, IJsonEncodeable
    {
        #region Constructors
        /// <remarks />
        public ConnectionEndpointDefinitionDataType()
        {
            Initialize();
        }

        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }

        private void Initialize()
        {
            SwitchField = ConnectionEndpointDefinitionDataTypeFields.None;
            m_parameter = new ConnectionEndpointParameterDataType();
            m_node = null;
        }
        #endregion

        #region Public Properties
        // <remarks />
        [DataMember(Name = "SwitchField", IsRequired = true, Order = 0)]
        public ConnectionEndpointDefinitionDataTypeFields SwitchField { get; set; }

        /// <remarks />
        [DataMember(Name = "Parameter", IsRequired = false, Order = 1)]
        public ConnectionEndpointParameterDataType Parameter
        {
            get { return m_parameter;  }
            set { m_parameter = value; }
        }

        /// <remarks />
        [DataMember(Name = "Node", IsRequired = false, Order = 2)]
        public NodeId Node
        {
            get { return m_node;  }
            set { m_node = value; }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public virtual ExpandedNodeId TypeId => DataTypeIds.ConnectionEndpointDefinitionDataType; 

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public virtual ExpandedNodeId BinaryEncodingId => ObjectIds.ConnectionEndpointDefinitionDataType_Encoding_DefaultBinary;

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public virtual ExpandedNodeId XmlEncodingId => ObjectIds.ConnectionEndpointDefinitionDataType_Encoding_DefaultXml;

        /// <summary cref="IJsonEncodeable.JsonEncodingId" />
        public virtual ExpandedNodeId JsonEncodingId => ObjectIds.ConnectionEndpointDefinitionDataType_Encoding_DefaultJson; 

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public virtual void Encode(IEncoder encoder)
        {
            encoder.PushNamespace(UAModel.FXData.Namespaces.FXData);
            encoder.WriteUInt32(nameof(SwitchField), (uint)SwitchField);

            switch (SwitchField)
            {
                default: { break; }
                case ConnectionEndpointDefinitionDataTypeFields.Parameter: { encoder.WriteExtensionObject("Parameter", new ExtensionObject(Parameter)); break; }
                case ConnectionEndpointDefinitionDataTypeFields.Node: { encoder.WriteNodeId("Node", Node); break; }
            }
            
            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public virtual void Decode(IDecoder decoder)
        {
            decoder.PushNamespace(UAModel.FXData.Namespaces.FXData);

            SwitchField = (ConnectionEndpointDefinitionDataTypeFields)decoder.ReadUInt32(nameof(SwitchField));
                
            switch (SwitchField)
            {
                default: { break; }
                case ConnectionEndpointDefinitionDataTypeFields.Parameter: { Parameter = (ConnectionEndpointParameterDataType)ExtensionObject.ToEncodeable(decoder.ReadExtensionObject("Parameter")); break; }
                case ConnectionEndpointDefinitionDataTypeFields.Node: { Node = decoder.ReadNodeId("Node"); break; }
            }

            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public virtual bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            ConnectionEndpointDefinitionDataType value = encodeable as ConnectionEndpointDefinitionDataType;

            if (value == null)
            {
                return false;
            }

            if (value.SwitchField != this.SwitchField) return false;

            switch (SwitchField)
            {
                default: { break; }
                case ConnectionEndpointDefinitionDataTypeFields.Parameter: { if (!Utils.IsEqual(m_parameter, value.m_parameter)) return false; break; }
                case ConnectionEndpointDefinitionDataTypeFields.Node: { if (!Utils.IsEqual(m_node, value.m_node)) return false; break; }
            }

            return true;
        }

        #if !NET_STANDARD
        /// <summary cref="ICloneable.Clone" />
        public virtual object Clone()
        {
            return (ConnectionEndpointDefinitionDataType)this.MemberwiseClone();
        }
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            ConnectionEndpointDefinitionDataType clone = (ConnectionEndpointDefinitionDataType)base.MemberwiseClone();

            clone.SwitchField = this.SwitchField;

            switch (SwitchField)
            {
                default: { break; }
                case ConnectionEndpointDefinitionDataTypeFields.Parameter: { clone.m_parameter = (ConnectionEndpointParameterDataType)Utils.Clone(this.m_parameter); break; }
                case ConnectionEndpointDefinitionDataTypeFields.Node: { clone.m_node = (NodeId)Utils.Clone(this.m_node); break; }
            }

            return clone;
        }
        #endregion

        #region Private Fields
        private ConnectionEndpointParameterDataType m_parameter;
        private NodeId m_node;
        #endregion
    }

    #region ConnectionEndpointDefinitionDataTypeCollection Class
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfConnectionEndpointDefinitionDataType", Namespace = UAModel.FXData.Namespaces.FXData, ItemName = "ConnectionEndpointDefinitionDataType")]
    #if !NET_STANDARD
    public partial class ConnectionEndpointDefinitionDataTypeCollection : List<ConnectionEndpointDefinitionDataType>, ICloneable
    #else
    public partial class ConnectionEndpointDefinitionDataTypeCollection : List<ConnectionEndpointDefinitionDataType>
    #endif
    {
        #region Constructors
        /// <remarks />
        public ConnectionEndpointDefinitionDataTypeCollection() {}

        /// <remarks />
        public ConnectionEndpointDefinitionDataTypeCollection(int capacity) : base(capacity) {}

        /// <remarks />
        public ConnectionEndpointDefinitionDataTypeCollection(IEnumerable<ConnectionEndpointDefinitionDataType> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <remarks />
        public static implicit operator ConnectionEndpointDefinitionDataTypeCollection(ConnectionEndpointDefinitionDataType[] values)
        {
            if (values != null)
            {
                return new ConnectionEndpointDefinitionDataTypeCollection(values);
            }

            return new ConnectionEndpointDefinitionDataTypeCollection();
        }

        /// <remarks />
        public static explicit operator ConnectionEndpointDefinitionDataType[](ConnectionEndpointDefinitionDataTypeCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <remarks />
        public object Clone()
        {
            return (ConnectionEndpointDefinitionDataTypeCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            ConnectionEndpointDefinitionDataTypeCollection clone = new ConnectionEndpointDefinitionDataTypeCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((ConnectionEndpointDefinitionDataType)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion
}