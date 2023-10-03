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
    #region ClampKindEnum Enumeration
    #if (!OPCUA_EXCLUDE_ClampKindEnum)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = UAModel.FXAC.Namespaces.FXAC)]
    public enum ClampKindEnum
    {
        /// <remarks />
        [EnumMember(Value = "Screw_0")]
        Screw = 0,

        /// <remarks />
        [EnumMember(Value = "Thumb_1")]
        Thumb = 1,
    }

    #region ClampKindEnumCollection Class
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfClampKindEnum", Namespace = UAModel.FXAC.Namespaces.FXAC, ItemName = "ClampKindEnum")]
    #if !NET_STANDARD
    public partial class ClampKindEnumCollection : List<ClampKindEnum>, ICloneable
    #else
    public partial class ClampKindEnumCollection : List<ClampKindEnum>
    #endif
    {
        #region Constructors
        /// <remarks />
        public ClampKindEnumCollection() {}

        /// <remarks />
        public ClampKindEnumCollection(int capacity) : base(capacity) {}

        /// <remarks />
        public ClampKindEnumCollection(IEnumerable<ClampKindEnum> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <remarks />
        public static implicit operator ClampKindEnumCollection(ClampKindEnum[] values)
        {
            if (values != null)
            {
                return new ClampKindEnumCollection(values);
            }

            return new ClampKindEnumCollection();
        }

        /// <remarks />
        public static explicit operator ClampKindEnum[](ClampKindEnumCollection values)
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
            return (ClampKindEnumCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            ClampKindEnumCollection clone = new ClampKindEnumCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((ClampKindEnum)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region ConnectionEndpointStatusEnum Enumeration
    #if (!OPCUA_EXCLUDE_ConnectionEndpointStatusEnum)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = UAModel.FXAC.Namespaces.FXAC)]
    public enum ConnectionEndpointStatusEnum
    {
        /// <remarks />
        [EnumMember(Value = "Initial_0")]
        Initial = 0,

        /// <remarks />
        [EnumMember(Value = "Ready_1")]
        Ready = 1,

        /// <remarks />
        [EnumMember(Value = "PreOperational_2")]
        PreOperational = 2,

        /// <remarks />
        [EnumMember(Value = "Operational_3")]
        Operational = 3,

        /// <remarks />
        [EnumMember(Value = "Error_4")]
        Error = 4,
    }

    #region ConnectionEndpointStatusEnumCollection Class
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfConnectionEndpointStatusEnum", Namespace = UAModel.FXAC.Namespaces.FXAC, ItemName = "ConnectionEndpointStatusEnum")]
    #if !NET_STANDARD
    public partial class ConnectionEndpointStatusEnumCollection : List<ConnectionEndpointStatusEnum>, ICloneable
    #else
    public partial class ConnectionEndpointStatusEnumCollection : List<ConnectionEndpointStatusEnum>
    #endif
    {
        #region Constructors
        /// <remarks />
        public ConnectionEndpointStatusEnumCollection() {}

        /// <remarks />
        public ConnectionEndpointStatusEnumCollection(int capacity) : base(capacity) {}

        /// <remarks />
        public ConnectionEndpointStatusEnumCollection(IEnumerable<ConnectionEndpointStatusEnum> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <remarks />
        public static implicit operator ConnectionEndpointStatusEnumCollection(ConnectionEndpointStatusEnum[] values)
        {
            if (values != null)
            {
                return new ConnectionEndpointStatusEnumCollection(values);
            }

            return new ConnectionEndpointStatusEnumCollection();
        }

        /// <remarks />
        public static explicit operator ConnectionEndpointStatusEnum[](ConnectionEndpointStatusEnumCollection values)
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
            return (ConnectionEndpointStatusEnumCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            ConnectionEndpointStatusEnumCollection clone = new ConnectionEndpointStatusEnumCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((ConnectionEndpointStatusEnum)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region FxTimeUnitsEnum Enumeration
    #if (!OPCUA_EXCLUDE_FxTimeUnitsEnum)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = UAModel.FXAC.Namespaces.FXAC)]
    public enum FxTimeUnitsEnum
    {
        /// <remarks />
        [EnumMember(Value = "Nanosecond_0")]
        Nanosecond = 0,

        /// <remarks />
        [EnumMember(Value = "Microsecond_1")]
        Microsecond = 1,

        /// <remarks />
        [EnumMember(Value = "Millisecond_2")]
        Millisecond = 2,

        /// <remarks />
        [EnumMember(Value = "Second_3")]
        Second = 3,
    }

    #region FxTimeUnitsEnumCollection Class
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfFxTimeUnitsEnum", Namespace = UAModel.FXAC.Namespaces.FXAC, ItemName = "FxTimeUnitsEnum")]
    #if !NET_STANDARD
    public partial class FxTimeUnitsEnumCollection : List<FxTimeUnitsEnum>, ICloneable
    #else
    public partial class FxTimeUnitsEnumCollection : List<FxTimeUnitsEnum>
    #endif
    {
        #region Constructors
        /// <remarks />
        public FxTimeUnitsEnumCollection() {}

        /// <remarks />
        public FxTimeUnitsEnumCollection(int capacity) : base(capacity) {}

        /// <remarks />
        public FxTimeUnitsEnumCollection(IEnumerable<FxTimeUnitsEnum> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <remarks />
        public static implicit operator FxTimeUnitsEnumCollection(FxTimeUnitsEnum[] values)
        {
            if (values != null)
            {
                return new FxTimeUnitsEnumCollection(values);
            }

            return new FxTimeUnitsEnumCollection();
        }

        /// <remarks />
        public static explicit operator FxTimeUnitsEnum[](FxTimeUnitsEnumCollection values)
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
            return (FxTimeUnitsEnumCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            FxTimeUnitsEnumCollection clone = new FxTimeUnitsEnumCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((FxTimeUnitsEnum)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region SocketKindEnum Enumeration
    #if (!OPCUA_EXCLUDE_SocketKindEnum)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = UAModel.FXAC.Namespaces.FXAC)]
    public enum SocketKindEnum
    {
        /// <remarks />
        [EnumMember(Value = "RJ45_0")]
        RJ45 = 0,

        /// <remarks />
        [EnumMember(Value = "M12_1")]
        M12 = 1,
    }

    #region SocketKindEnumCollection Class
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfSocketKindEnum", Namespace = UAModel.FXAC.Namespaces.FXAC, ItemName = "SocketKindEnum")]
    #if !NET_STANDARD
    public partial class SocketKindEnumCollection : List<SocketKindEnum>, ICloneable
    #else
    public partial class SocketKindEnumCollection : List<SocketKindEnum>
    #endif
    {
        #region Constructors
        /// <remarks />
        public SocketKindEnumCollection() {}

        /// <remarks />
        public SocketKindEnumCollection(int capacity) : base(capacity) {}

        /// <remarks />
        public SocketKindEnumCollection(IEnumerable<SocketKindEnum> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <remarks />
        public static implicit operator SocketKindEnumCollection(SocketKindEnum[] values)
        {
            if (values != null)
            {
                return new SocketKindEnumCollection(values);
            }

            return new SocketKindEnumCollection();
        }

        /// <remarks />
        public static explicit operator SocketKindEnum[](SocketKindEnumCollection values)
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
            return (SocketKindEnumCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            SocketKindEnumCollection clone = new SocketKindEnumCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((SocketKindEnum)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region CommHealthOptionSet Enumeration
    #if (!OPCUA_EXCLUDE_CommHealthOptionSet)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = UAModel.FXAC.Namespaces.FXAC)][Flags]
    public enum CommHealthOptionSet : UInt16
    {
        /// <remarks />
        [EnumMember(Value = "None_0")]
        None = 0,

        /// <remarks />
        [EnumMember(Value = "CommInitial_1")]
        CommInitial = 1,

        /// <remarks />
        [EnumMember(Value = "CommPreOperational_2")]
        CommPreOperational = 2,

        /// <remarks />
        [EnumMember(Value = "CommError_4")]
        CommError = 4,
    }

    #region CommHealthOptionSetCollection Class
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfCommHealthOptionSet", Namespace = UAModel.FXAC.Namespaces.FXAC, ItemName = "CommHealthOptionSet")]
    #if !NET_STANDARD
    public partial class CommHealthOptionSetCollection : List<CommHealthOptionSet>, ICloneable
    #else
    public partial class CommHealthOptionSetCollection : List<CommHealthOptionSet>
    #endif
    {
        #region Constructors
        /// <remarks />
        public CommHealthOptionSetCollection() {}

        /// <remarks />
        public CommHealthOptionSetCollection(int capacity) : base(capacity) {}

        /// <remarks />
        public CommHealthOptionSetCollection(IEnumerable<CommHealthOptionSet> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <remarks />
        public static implicit operator CommHealthOptionSetCollection(CommHealthOptionSet[] values)
        {
            if (values != null)
            {
                return new CommHealthOptionSetCollection(values);
            }

            return new CommHealthOptionSetCollection();
        }

        /// <remarks />
        public static explicit operator CommHealthOptionSet[](CommHealthOptionSetCollection values)
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
            return (CommHealthOptionSetCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            CommHealthOptionSetCollection clone = new CommHealthOptionSetCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((CommHealthOptionSet)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region DeviceHealthOptionSet Enumeration
    #if (!OPCUA_EXCLUDE_DeviceHealthOptionSet)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = UAModel.FXAC.Namespaces.FXAC)][Flags]
    public enum DeviceHealthOptionSet : UInt16
    {
        /// <remarks />
        [EnumMember(Value = "None_0")]
        None = 0,

        /// <remarks />
        [EnumMember(Value = "DeviceFailure_1")]
        DeviceFailure = 1,

        /// <remarks />
        [EnumMember(Value = "DeviceCheckFunction_2")]
        DeviceCheckFunction = 2,

        /// <remarks />
        [EnumMember(Value = "DeviceMaintenanceRequired_4")]
        DeviceMaintenanceRequired = 4,

        /// <remarks />
        [EnumMember(Value = "DeviceOffSpec_8")]
        DeviceOffSpec = 8,
    }

    #region DeviceHealthOptionSetCollection Class
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfDeviceHealthOptionSet", Namespace = UAModel.FXAC.Namespaces.FXAC, ItemName = "DeviceHealthOptionSet")]
    #if !NET_STANDARD
    public partial class DeviceHealthOptionSetCollection : List<DeviceHealthOptionSet>, ICloneable
    #else
    public partial class DeviceHealthOptionSetCollection : List<DeviceHealthOptionSet>
    #endif
    {
        #region Constructors
        /// <remarks />
        public DeviceHealthOptionSetCollection() {}

        /// <remarks />
        public DeviceHealthOptionSetCollection(int capacity) : base(capacity) {}

        /// <remarks />
        public DeviceHealthOptionSetCollection(IEnumerable<DeviceHealthOptionSet> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <remarks />
        public static implicit operator DeviceHealthOptionSetCollection(DeviceHealthOptionSet[] values)
        {
            if (values != null)
            {
                return new DeviceHealthOptionSetCollection(values);
            }

            return new DeviceHealthOptionSetCollection();
        }

        /// <remarks />
        public static explicit operator DeviceHealthOptionSet[](DeviceHealthOptionSetCollection values)
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
            return (DeviceHealthOptionSetCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            DeviceHealthOptionSetCollection clone = new DeviceHealthOptionSetCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((DeviceHealthOptionSet)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region OperationalHealthOptionSet Enumeration
    #if (!OPCUA_EXCLUDE_OperationalHealthOptionSet)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = UAModel.FXAC.Namespaces.FXAC)][Flags]
    public enum OperationalHealthOptionSet : UInt32
    {
        /// <remarks />
        [EnumMember(Value = "None_0")]
        None = 0,

        /// <remarks />
        [EnumMember(Value = "OperationalWarning_65536")]
        OperationalWarning = 65536,

        /// <remarks />
        [EnumMember(Value = "OperationalError_131072")]
        OperationalError = 131072,

        /// <remarks />
        [EnumMember(Value = "SubOperationalWarning_262144")]
        SubOperationalWarning = 262144,

        /// <remarks />
        [EnumMember(Value = "SubOperationalError_524288")]
        SubOperationalError = 524288,
    }

    #region OperationalHealthOptionSetCollection Class
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfOperationalHealthOptionSet", Namespace = UAModel.FXAC.Namespaces.FXAC, ItemName = "OperationalHealthOptionSet")]
    #if !NET_STANDARD
    public partial class OperationalHealthOptionSetCollection : List<OperationalHealthOptionSet>, ICloneable
    #else
    public partial class OperationalHealthOptionSetCollection : List<OperationalHealthOptionSet>
    #endif
    {
        #region Constructors
        /// <remarks />
        public OperationalHealthOptionSetCollection() {}

        /// <remarks />
        public OperationalHealthOptionSetCollection(int capacity) : base(capacity) {}

        /// <remarks />
        public OperationalHealthOptionSetCollection(IEnumerable<OperationalHealthOptionSet> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <remarks />
        public static implicit operator OperationalHealthOptionSetCollection(OperationalHealthOptionSet[] values)
        {
            if (values != null)
            {
                return new OperationalHealthOptionSetCollection(values);
            }

            return new OperationalHealthOptionSetCollection();
        }

        /// <remarks />
        public static explicit operator OperationalHealthOptionSet[](OperationalHealthOptionSetCollection values)
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
            return (OperationalHealthOptionSetCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            OperationalHealthOptionSetCollection clone = new OperationalHealthOptionSetCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((OperationalHealthOptionSet)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region AggregatedHealthDataType Class
    #if (!OPCUA_EXCLUDE_AggregatedHealthDataType)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = UAModel.FXAC.Namespaces.FXAC)]
    public partial class AggregatedHealthDataType : IEncodeable, IJsonEncodeable
    {
        #region Constructors
        /// <remarks />
        public AggregatedHealthDataType()
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
            m_aggregatedDeviceHealth = 0;
            m_aggregatedOperationalHealth = 0;
        }
        #endregion

        #region Public Properties
        /// <remarks />
        [DataMember(Name = "AggregatedDeviceHealth", IsRequired = false, Order = 1)]
        public ushort AggregatedDeviceHealth
        {
            get { return m_aggregatedDeviceHealth;  }
            set { m_aggregatedDeviceHealth = value; }
        }

        /// <remarks />
        [DataMember(Name = "AggregatedOperationalHealth", IsRequired = false, Order = 2)]
        public uint AggregatedOperationalHealth
        {
            get { return m_aggregatedOperationalHealth;  }
            set { m_aggregatedOperationalHealth = value; }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public virtual ExpandedNodeId TypeId => DataTypeIds.AggregatedHealthDataType; 

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public virtual ExpandedNodeId BinaryEncodingId => ObjectIds.AggregatedHealthDataType_Encoding_DefaultBinary;

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public virtual ExpandedNodeId XmlEncodingId => ObjectIds.AggregatedHealthDataType_Encoding_DefaultXml;
                    
        /// <summary cref="IJsonEncodeable.JsonEncodingId" />
        public virtual ExpandedNodeId JsonEncodingId => ObjectIds.AggregatedHealthDataType_Encoding_DefaultJson; 

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public virtual void Encode(IEncoder encoder)
        {
            encoder.PushNamespace(UAModel.FXAC.Namespaces.FXAC);

            encoder.WriteUInt16("AggregatedDeviceHealth", AggregatedDeviceHealth);
            encoder.WriteUInt32("AggregatedOperationalHealth", AggregatedOperationalHealth);

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public virtual void Decode(IDecoder decoder)
        {
            decoder.PushNamespace(UAModel.FXAC.Namespaces.FXAC);

            AggregatedDeviceHealth = decoder.ReadUInt16("AggregatedDeviceHealth");
            AggregatedOperationalHealth = decoder.ReadUInt32("AggregatedOperationalHealth");

            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public virtual bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            AggregatedHealthDataType value = encodeable as AggregatedHealthDataType;

            if (value == null)
            {
                return false;
            }

            if (!Utils.IsEqual(m_aggregatedDeviceHealth, value.m_aggregatedDeviceHealth)) return false;
            if (!Utils.IsEqual(m_aggregatedOperationalHealth, value.m_aggregatedOperationalHealth)) return false;

            return true;
        }

        #if !NET_STANDARD
        /// <summary cref="ICloneable.Clone" />
        public virtual object Clone()
        {
            return (AggregatedHealthDataType)this.MemberwiseClone();
        }
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            AggregatedHealthDataType clone = (AggregatedHealthDataType)base.MemberwiseClone();

            clone.m_aggregatedDeviceHealth = (ushort)Utils.Clone(this.m_aggregatedDeviceHealth);
            clone.m_aggregatedOperationalHealth = (uint)Utils.Clone(this.m_aggregatedOperationalHealth);

            return clone;
        }
        #endregion

        #region Private Fields
        private ushort m_aggregatedDeviceHealth;
        private uint m_aggregatedOperationalHealth;
        #endregion
    }

    #region AggregatedHealthDataTypeCollection Class
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfAggregatedHealthDataType", Namespace = UAModel.FXAC.Namespaces.FXAC, ItemName = "AggregatedHealthDataType")]
    #if !NET_STANDARD
    public partial class AggregatedHealthDataTypeCollection : List<AggregatedHealthDataType>, ICloneable
    #else
    public partial class AggregatedHealthDataTypeCollection : List<AggregatedHealthDataType>
    #endif
    {
        #region Constructors
        /// <remarks />
        public AggregatedHealthDataTypeCollection() {}

        /// <remarks />
        public AggregatedHealthDataTypeCollection(int capacity) : base(capacity) {}

        /// <remarks />
        public AggregatedHealthDataTypeCollection(IEnumerable<AggregatedHealthDataType> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <remarks />
        public static implicit operator AggregatedHealthDataTypeCollection(AggregatedHealthDataType[] values)
        {
            if (values != null)
            {
                return new AggregatedHealthDataTypeCollection(values);
            }

            return new AggregatedHealthDataTypeCollection();
        }

        /// <remarks />
        public static explicit operator AggregatedHealthDataType[](AggregatedHealthDataTypeCollection values)
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
            return (AggregatedHealthDataTypeCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            AggregatedHealthDataTypeCollection clone = new AggregatedHealthDataTypeCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((AggregatedHealthDataType)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region ApplicationIdentifierDataType Class
    #if (!OPCUA_EXCLUDE_ApplicationIdentifierDataType)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = UAModel.FXAC.Namespaces.FXAC)]
    public partial class ApplicationIdentifierDataType : IEncodeable, IJsonEncodeable
    {
        #region Constructors
        /// <remarks />
        public ApplicationIdentifierDataType()
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
            m_uniqueIdentifier = new ApplicationId();
        }
        #endregion

        #region Public Properties
        /// <remarks />
        [DataMember(Name = "Name", IsRequired = false, Order = 1)]
        public LocalizedText Name
        {
            get { return m_name;  }
            set { m_name = value; }
        }

        /// <remarks />
        [DataMember(Name = "UniqueIdentifier", IsRequired = false, Order = 2)]
        public ApplicationId UniqueIdentifier
        {
            get
            {
                return m_uniqueIdentifier;
            }

            set
            {
                m_uniqueIdentifier = value;

                if (value == null)
                {
                    m_uniqueIdentifier = new ApplicationId();
                }
            }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public virtual ExpandedNodeId TypeId => DataTypeIds.ApplicationIdentifierDataType; 

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public virtual ExpandedNodeId BinaryEncodingId => ObjectIds.ApplicationIdentifierDataType_Encoding_DefaultBinary;

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public virtual ExpandedNodeId XmlEncodingId => ObjectIds.ApplicationIdentifierDataType_Encoding_DefaultXml;
                    
        /// <summary cref="IJsonEncodeable.JsonEncodingId" />
        public virtual ExpandedNodeId JsonEncodingId => ObjectIds.ApplicationIdentifierDataType_Encoding_DefaultJson; 

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public virtual void Encode(IEncoder encoder)
        {
            encoder.PushNamespace(UAModel.FXAC.Namespaces.FXAC);

            encoder.WriteLocalizedText("Name", Name);
            encoder.WriteEncodeable("UniqueIdentifier", UniqueIdentifier, typeof(ApplicationId));

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public virtual void Decode(IDecoder decoder)
        {
            decoder.PushNamespace(UAModel.FXAC.Namespaces.FXAC);

            Name = decoder.ReadLocalizedText("Name");
            UniqueIdentifier = (ApplicationId)decoder.ReadEncodeable("UniqueIdentifier", typeof(ApplicationId));

            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public virtual bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            ApplicationIdentifierDataType value = encodeable as ApplicationIdentifierDataType;

            if (value == null)
            {
                return false;
            }

            if (!Utils.IsEqual(m_name, value.m_name)) return false;
            if (!Utils.IsEqual(m_uniqueIdentifier, value.m_uniqueIdentifier)) return false;

            return true;
        }

        #if !NET_STANDARD
        /// <summary cref="ICloneable.Clone" />
        public virtual object Clone()
        {
            return (ApplicationIdentifierDataType)this.MemberwiseClone();
        }
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            ApplicationIdentifierDataType clone = (ApplicationIdentifierDataType)base.MemberwiseClone();

            clone.m_name = (LocalizedText)Utils.Clone(this.m_name);
            clone.m_uniqueIdentifier = (ApplicationId)Utils.Clone(this.m_uniqueIdentifier);

            return clone;
        }
        #endregion

        #region Private Fields
        private LocalizedText m_name;
        private ApplicationId m_uniqueIdentifier;
        #endregion
    }

    #region ApplicationIdentifierDataTypeCollection Class
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfApplicationIdentifierDataType", Namespace = UAModel.FXAC.Namespaces.FXAC, ItemName = "ApplicationIdentifierDataType")]
    #if !NET_STANDARD
    public partial class ApplicationIdentifierDataTypeCollection : List<ApplicationIdentifierDataType>, ICloneable
    #else
    public partial class ApplicationIdentifierDataTypeCollection : List<ApplicationIdentifierDataType>
    #endif
    {
        #region Constructors
        /// <remarks />
        public ApplicationIdentifierDataTypeCollection() {}

        /// <remarks />
        public ApplicationIdentifierDataTypeCollection(int capacity) : base(capacity) {}

        /// <remarks />
        public ApplicationIdentifierDataTypeCollection(IEnumerable<ApplicationIdentifierDataType> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <remarks />
        public static implicit operator ApplicationIdentifierDataTypeCollection(ApplicationIdentifierDataType[] values)
        {
            if (values != null)
            {
                return new ApplicationIdentifierDataTypeCollection(values);
            }

            return new ApplicationIdentifierDataTypeCollection();
        }

        /// <remarks />
        public static explicit operator ApplicationIdentifierDataType[](ApplicationIdentifierDataTypeCollection values)
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
            return (ApplicationIdentifierDataTypeCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            ApplicationIdentifierDataTypeCollection clone = new ApplicationIdentifierDataTypeCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((ApplicationIdentifierDataType)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region FxVersion Class
    #if (!OPCUA_EXCLUDE_FxVersion)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = UAModel.FXAC.Namespaces.FXAC)]
    public partial class FxVersion : IEncodeable, IJsonEncodeable
    {
        #region Constructors
        /// <remarks />
        public FxVersion()
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
            m_major = (ushort)0;
            m_minor = (ushort)0;
            m_build = (ushort)0;
            m_subBuild = (ushort)0;
        }
        #endregion

        #region Public Properties
        /// <remarks />
        [DataMember(Name = "Major", IsRequired = false, Order = 1)]
        public ushort Major
        {
            get { return m_major;  }
            set { m_major = value; }
        }

        /// <remarks />
        [DataMember(Name = "Minor", IsRequired = false, Order = 2)]
        public ushort Minor
        {
            get { return m_minor;  }
            set { m_minor = value; }
        }

        /// <remarks />
        [DataMember(Name = "Build", IsRequired = false, Order = 3)]
        public ushort Build
        {
            get { return m_build;  }
            set { m_build = value; }
        }

        /// <remarks />
        [DataMember(Name = "SubBuild", IsRequired = false, Order = 4)]
        public ushort SubBuild
        {
            get { return m_subBuild;  }
            set { m_subBuild = value; }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public virtual ExpandedNodeId TypeId => DataTypeIds.FxVersion; 

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public virtual ExpandedNodeId BinaryEncodingId => ObjectIds.FxVersion_Encoding_DefaultBinary;

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public virtual ExpandedNodeId XmlEncodingId => ObjectIds.FxVersion_Encoding_DefaultXml;
                    
        /// <summary cref="IJsonEncodeable.JsonEncodingId" />
        public virtual ExpandedNodeId JsonEncodingId => ObjectIds.FxVersion_Encoding_DefaultJson; 

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public virtual void Encode(IEncoder encoder)
        {
            encoder.PushNamespace(UAModel.FXAC.Namespaces.FXAC);

            encoder.WriteUInt16("Major", Major);
            encoder.WriteUInt16("Minor", Minor);
            encoder.WriteUInt16("Build", Build);
            encoder.WriteUInt16("SubBuild", SubBuild);

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public virtual void Decode(IDecoder decoder)
        {
            decoder.PushNamespace(UAModel.FXAC.Namespaces.FXAC);

            Major = decoder.ReadUInt16("Major");
            Minor = decoder.ReadUInt16("Minor");
            Build = decoder.ReadUInt16("Build");
            SubBuild = decoder.ReadUInt16("SubBuild");

            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public virtual bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            FxVersion value = encodeable as FxVersion;

            if (value == null)
            {
                return false;
            }

            if (!Utils.IsEqual(m_major, value.m_major)) return false;
            if (!Utils.IsEqual(m_minor, value.m_minor)) return false;
            if (!Utils.IsEqual(m_build, value.m_build)) return false;
            if (!Utils.IsEqual(m_subBuild, value.m_subBuild)) return false;

            return true;
        }

        #if !NET_STANDARD
        /// <summary cref="ICloneable.Clone" />
        public virtual object Clone()
        {
            return (FxVersion)this.MemberwiseClone();
        }
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            FxVersion clone = (FxVersion)base.MemberwiseClone();

            clone.m_major = (ushort)Utils.Clone(this.m_major);
            clone.m_minor = (ushort)Utils.Clone(this.m_minor);
            clone.m_build = (ushort)Utils.Clone(this.m_build);
            clone.m_subBuild = (ushort)Utils.Clone(this.m_subBuild);

            return clone;
        }
        #endregion

        #region Private Fields
        private ushort m_major;
        private ushort m_minor;
        private ushort m_build;
        private ushort m_subBuild;
        #endregion
    }

    #region FxVersionCollection Class
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfFxVersion", Namespace = UAModel.FXAC.Namespaces.FXAC, ItemName = "FxVersion")]
    #if !NET_STANDARD
    public partial class FxVersionCollection : List<FxVersion>, ICloneable
    #else
    public partial class FxVersionCollection : List<FxVersion>
    #endif
    {
        #region Constructors
        /// <remarks />
        public FxVersionCollection() {}

        /// <remarks />
        public FxVersionCollection(int capacity) : base(capacity) {}

        /// <remarks />
        public FxVersionCollection(IEnumerable<FxVersion> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <remarks />
        public static implicit operator FxVersionCollection(FxVersion[] values)
        {
            if (values != null)
            {
                return new FxVersionCollection(values);
            }

            return new FxVersionCollection();
        }

        /// <remarks />
        public static explicit operator FxVersion[](FxVersionCollection values)
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
            return (FxVersionCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            FxVersionCollection clone = new FxVersionCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((FxVersion)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region IntervalRange Class
    #if (!OPCUA_EXCLUDE_IntervalRange)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = UAModel.FXAC.Namespaces.FXAC)]
    public partial class IntervalRange : IEncodeable, IJsonEncodeable
    {
        #region Constructors
        /// <remarks />
        public IntervalRange()
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
            m_min = (uint)0;
            m_max = (uint)0;
            m_increment = (ushort)0;
            m_multiplier = (ushort)0;
            m_unit = FxTimeUnitsEnum.Nanosecond;
        }
        #endregion

        #region Public Properties
        /// <remarks />
        [DataMember(Name = "Min", IsRequired = false, Order = 1)]
        public uint Min
        {
            get { return m_min;  }
            set { m_min = value; }
        }

        /// <remarks />
        [DataMember(Name = "Max", IsRequired = false, Order = 2)]
        public uint Max
        {
            get { return m_max;  }
            set { m_max = value; }
        }

        /// <remarks />
        [DataMember(Name = "Increment", IsRequired = false, Order = 3)]
        public ushort Increment
        {
            get { return m_increment;  }
            set { m_increment = value; }
        }

        /// <remarks />
        [DataMember(Name = "Multiplier", IsRequired = false, Order = 4)]
        public ushort Multiplier
        {
            get { return m_multiplier;  }
            set { m_multiplier = value; }
        }

        /// <remarks />
        [DataMember(Name = "Unit", IsRequired = false, Order = 5)]
        public FxTimeUnitsEnum Unit
        {
            get { return m_unit;  }
            set { m_unit = value; }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public virtual ExpandedNodeId TypeId => DataTypeIds.IntervalRange; 

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public virtual ExpandedNodeId BinaryEncodingId => ObjectIds.IntervalRange_Encoding_DefaultBinary;

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public virtual ExpandedNodeId XmlEncodingId => ObjectIds.IntervalRange_Encoding_DefaultXml;
                    
        /// <summary cref="IJsonEncodeable.JsonEncodingId" />
        public virtual ExpandedNodeId JsonEncodingId => ObjectIds.IntervalRange_Encoding_DefaultJson; 

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public virtual void Encode(IEncoder encoder)
        {
            encoder.PushNamespace(UAModel.FXAC.Namespaces.FXAC);

            encoder.WriteUInt32("Min", Min);
            encoder.WriteUInt32("Max", Max);
            encoder.WriteUInt16("Increment", Increment);
            encoder.WriteUInt16("Multiplier", Multiplier);
            encoder.WriteEnumerated("Unit", Unit);

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public virtual void Decode(IDecoder decoder)
        {
            decoder.PushNamespace(UAModel.FXAC.Namespaces.FXAC);

            Min = decoder.ReadUInt32("Min");
            Max = decoder.ReadUInt32("Max");
            Increment = decoder.ReadUInt16("Increment");
            Multiplier = decoder.ReadUInt16("Multiplier");
            Unit = (FxTimeUnitsEnum)decoder.ReadEnumerated("Unit", typeof(FxTimeUnitsEnum));

            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public virtual bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            IntervalRange value = encodeable as IntervalRange;

            if (value == null)
            {
                return false;
            }

            if (!Utils.IsEqual(m_min, value.m_min)) return false;
            if (!Utils.IsEqual(m_max, value.m_max)) return false;
            if (!Utils.IsEqual(m_increment, value.m_increment)) return false;
            if (!Utils.IsEqual(m_multiplier, value.m_multiplier)) return false;
            if (!Utils.IsEqual(m_unit, value.m_unit)) return false;

            return true;
        }

        #if !NET_STANDARD
        /// <summary cref="ICloneable.Clone" />
        public virtual object Clone()
        {
            return (IntervalRange)this.MemberwiseClone();
        }
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            IntervalRange clone = (IntervalRange)base.MemberwiseClone();

            clone.m_min = (uint)Utils.Clone(this.m_min);
            clone.m_max = (uint)Utils.Clone(this.m_max);
            clone.m_increment = (ushort)Utils.Clone(this.m_increment);
            clone.m_multiplier = (ushort)Utils.Clone(this.m_multiplier);
            clone.m_unit = (FxTimeUnitsEnum)Utils.Clone(this.m_unit);

            return clone;
        }
        #endregion

        #region Private Fields
        private uint m_min;
        private uint m_max;
        private ushort m_increment;
        private ushort m_multiplier;
        private FxTimeUnitsEnum m_unit;
        #endregion
    }

    #region IntervalRangeCollection Class
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfIntervalRange", Namespace = UAModel.FXAC.Namespaces.FXAC, ItemName = "IntervalRange")]
    #if !NET_STANDARD
    public partial class IntervalRangeCollection : List<IntervalRange>, ICloneable
    #else
    public partial class IntervalRangeCollection : List<IntervalRange>
    #endif
    {
        #region Constructors
        /// <remarks />
        public IntervalRangeCollection() {}

        /// <remarks />
        public IntervalRangeCollection(int capacity) : base(capacity) {}

        /// <remarks />
        public IntervalRangeCollection(IEnumerable<IntervalRange> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <remarks />
        public static implicit operator IntervalRangeCollection(IntervalRange[] values)
        {
            if (values != null)
            {
                return new IntervalRangeCollection(values);
            }

            return new IntervalRangeCollection();
        }

        /// <remarks />
        public static explicit operator IntervalRange[](IntervalRangeCollection values)
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
            return (IntervalRangeCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            IntervalRangeCollection clone = new IntervalRangeCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((IntervalRange)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region PublisherQosDataType Class
    #if (!OPCUA_EXCLUDE_PublisherQosDataType)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = UAModel.FXAC.Namespaces.FXAC)]
    public partial class PublisherQosDataType : IEncodeable, IJsonEncodeable
    {
        #region Constructors
        /// <remarks />
        public PublisherQosDataType()
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
            m_qosCategory = null;
            m_datagramQos = new TransmitQosDataTypeCollection();
        }
        #endregion

        #region Public Properties
        /// <remarks />
        [DataMember(Name = "QosCategory", IsRequired = false, Order = 1)]
        public string QosCategory
        {
            get { return m_qosCategory;  }
            set { m_qosCategory = value; }
        }

        /// <remarks />
        [DataMember(Name = "DatagramQos", IsRequired = false, Order = 2)]
        public TransmitQosDataTypeCollection DatagramQos
        {
            get { return m_datagramQos;  }
            set { m_datagramQos = value; }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public virtual ExpandedNodeId TypeId => DataTypeIds.PublisherQosDataType; 

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public virtual ExpandedNodeId BinaryEncodingId => ObjectIds.PublisherQosDataType_Encoding_DefaultBinary;

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public virtual ExpandedNodeId XmlEncodingId => ObjectIds.PublisherQosDataType_Encoding_DefaultXml;
                    
        /// <summary cref="IJsonEncodeable.JsonEncodingId" />
        public virtual ExpandedNodeId JsonEncodingId => ObjectIds.PublisherQosDataType_Encoding_DefaultJson; 

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public virtual void Encode(IEncoder encoder)
        {
            encoder.PushNamespace(UAModel.FXAC.Namespaces.FXAC);

            encoder.WriteString("QosCategory", QosCategory);
            encoder.WriteExtensionObjectArray("DatagramQos", ExtensionObjectCollection.ToExtensionObjects(DatagramQos));

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public virtual void Decode(IDecoder decoder)
        {
            decoder.PushNamespace(UAModel.FXAC.Namespaces.FXAC);

            QosCategory = decoder.ReadString("QosCategory");
            DatagramQos = (Opc.Ua.TransmitQosDataType[])ExtensionObject.ToArray(decoder.ReadExtensionObjectArray("DatagramQos"), typeof(Opc.Ua.TransmitQosDataType));

            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public virtual bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            PublisherQosDataType value = encodeable as PublisherQosDataType;

            if (value == null)
            {
                return false;
            }

            if (!Utils.IsEqual(m_qosCategory, value.m_qosCategory)) return false;
            if (!Utils.IsEqual(m_datagramQos, value.m_datagramQos)) return false;

            return true;
        }

        #if !NET_STANDARD
        /// <summary cref="ICloneable.Clone" />
        public virtual object Clone()
        {
            return (PublisherQosDataType)this.MemberwiseClone();
        }
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            PublisherQosDataType clone = (PublisherQosDataType)base.MemberwiseClone();

            clone.m_qosCategory = (string)Utils.Clone(this.m_qosCategory);
            clone.m_datagramQos = (TransmitQosDataTypeCollection)Utils.Clone(this.m_datagramQos);

            return clone;
        }
        #endregion

        #region Private Fields
        private string m_qosCategory;
        private TransmitQosDataTypeCollection m_datagramQos;
        #endregion
    }

    #region PublisherQosDataTypeCollection Class
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfPublisherQosDataType", Namespace = UAModel.FXAC.Namespaces.FXAC, ItemName = "PublisherQosDataType")]
    #if !NET_STANDARD
    public partial class PublisherQosDataTypeCollection : List<PublisherQosDataType>, ICloneable
    #else
    public partial class PublisherQosDataTypeCollection : List<PublisherQosDataType>
    #endif
    {
        #region Constructors
        /// <remarks />
        public PublisherQosDataTypeCollection() {}

        /// <remarks />
        public PublisherQosDataTypeCollection(int capacity) : base(capacity) {}

        /// <remarks />
        public PublisherQosDataTypeCollection(IEnumerable<PublisherQosDataType> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <remarks />
        public static implicit operator PublisherQosDataTypeCollection(PublisherQosDataType[] values)
        {
            if (values != null)
            {
                return new PublisherQosDataTypeCollection(values);
            }

            return new PublisherQosDataTypeCollection();
        }

        /// <remarks />
        public static explicit operator PublisherQosDataType[](PublisherQosDataTypeCollection values)
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
            return (PublisherQosDataTypeCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            PublisherQosDataTypeCollection clone = new PublisherQosDataTypeCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((PublisherQosDataType)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region SubscriberQosDataType Class
    #if (!OPCUA_EXCLUDE_SubscriberQosDataType)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = UAModel.FXAC.Namespaces.FXAC)]
    public partial class SubscriberQosDataType : IEncodeable, IJsonEncodeable
    {
        #region Constructors
        /// <remarks />
        public SubscriberQosDataType()
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
            m_qosCategory = null;
            m_datagramQos = new ReceiveQosDataTypeCollection();
        }
        #endregion

        #region Public Properties
        /// <remarks />
        [DataMember(Name = "QosCategory", IsRequired = false, Order = 1)]
        public string QosCategory
        {
            get { return m_qosCategory;  }
            set { m_qosCategory = value; }
        }

        /// <remarks />
        [DataMember(Name = "DatagramQos", IsRequired = false, Order = 2)]
        public ReceiveQosDataTypeCollection DatagramQos
        {
            get { return m_datagramQos;  }
            set { m_datagramQos = value; }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public virtual ExpandedNodeId TypeId => DataTypeIds.SubscriberQosDataType; 

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public virtual ExpandedNodeId BinaryEncodingId => ObjectIds.SubscriberQosDataType_Encoding_DefaultBinary;

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public virtual ExpandedNodeId XmlEncodingId => ObjectIds.SubscriberQosDataType_Encoding_DefaultXml;
                    
        /// <summary cref="IJsonEncodeable.JsonEncodingId" />
        public virtual ExpandedNodeId JsonEncodingId => ObjectIds.SubscriberQosDataType_Encoding_DefaultJson; 

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public virtual void Encode(IEncoder encoder)
        {
            encoder.PushNamespace(UAModel.FXAC.Namespaces.FXAC);

            encoder.WriteString("QosCategory", QosCategory);
            encoder.WriteExtensionObjectArray("DatagramQos", ExtensionObjectCollection.ToExtensionObjects(DatagramQos));

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public virtual void Decode(IDecoder decoder)
        {
            decoder.PushNamespace(UAModel.FXAC.Namespaces.FXAC);

            QosCategory = decoder.ReadString("QosCategory");
            DatagramQos = (Opc.Ua.ReceiveQosDataType[])ExtensionObject.ToArray(decoder.ReadExtensionObjectArray("DatagramQos"), typeof(Opc.Ua.ReceiveQosDataType));

            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public virtual bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            SubscriberQosDataType value = encodeable as SubscriberQosDataType;

            if (value == null)
            {
                return false;
            }

            if (!Utils.IsEqual(m_qosCategory, value.m_qosCategory)) return false;
            if (!Utils.IsEqual(m_datagramQos, value.m_datagramQos)) return false;

            return true;
        }

        #if !NET_STANDARD
        /// <summary cref="ICloneable.Clone" />
        public virtual object Clone()
        {
            return (SubscriberQosDataType)this.MemberwiseClone();
        }
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            SubscriberQosDataType clone = (SubscriberQosDataType)base.MemberwiseClone();

            clone.m_qosCategory = (string)Utils.Clone(this.m_qosCategory);
            clone.m_datagramQos = (ReceiveQosDataTypeCollection)Utils.Clone(this.m_datagramQos);

            return clone;
        }
        #endregion

        #region Private Fields
        private string m_qosCategory;
        private ReceiveQosDataTypeCollection m_datagramQos;
        #endregion
    }

    #region SubscriberQosDataTypeCollection Class
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfSubscriberQosDataType", Namespace = UAModel.FXAC.Namespaces.FXAC, ItemName = "SubscriberQosDataType")]
    #if !NET_STANDARD
    public partial class SubscriberQosDataTypeCollection : List<SubscriberQosDataType>, ICloneable
    #else
    public partial class SubscriberQosDataTypeCollection : List<SubscriberQosDataType>
    #endif
    {
        #region Constructors
        /// <remarks />
        public SubscriberQosDataTypeCollection() {}

        /// <remarks />
        public SubscriberQosDataTypeCollection(int capacity) : base(capacity) {}

        /// <remarks />
        public SubscriberQosDataTypeCollection(IEnumerable<SubscriberQosDataType> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <remarks />
        public static implicit operator SubscriberQosDataTypeCollection(SubscriberQosDataType[] values)
        {
            if (values != null)
            {
                return new SubscriberQosDataTypeCollection(values);
            }

            return new SubscriberQosDataTypeCollection();
        }

        /// <remarks />
        public static explicit operator SubscriberQosDataType[](SubscriberQosDataTypeCollection values)
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
            return (SubscriberQosDataTypeCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            SubscriberQosDataTypeCollection clone = new SubscriberQosDataTypeCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((SubscriberQosDataType)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region ApplicationId Class
    #if (!OPCUA_EXCLUDE_ApplicationId)
    /// <remarks />
    /// <exclude />
    public enum ApplicationIdFields : uint
    {
        /// <remarks />
        None = 0,
        /// <remarks />
        IdNumeric = 1,
        /// <remarks />
        IdString = 2,
        /// <remarks />
        IdGuid = 3,
        /// <remarks />
        IdByteString = 4
    }

    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = UAModel.FXAC.Namespaces.FXAC)]
    public partial class ApplicationId : IEncodeable, IJsonEncodeable
    {
        #region Constructors
        /// <remarks />
        public ApplicationId()
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
            SwitchField = ApplicationIdFields.None;
            m_idNumeric = (uint)0;
            m_idString = null;
            m_idGuid = Uuid.Empty;
            m_idByteString = null;
        }
        #endregion

        #region Public Properties
        // <remarks />
        [DataMember(Name = "SwitchField", IsRequired = true, Order = 0)]
        public ApplicationIdFields SwitchField { get; set; }

        /// <remarks />
        [DataMember(Name = "IdNumeric", IsRequired = false, Order = 1)]
        public uint IdNumeric
        {
            get { return m_idNumeric;  }
            set { m_idNumeric = value; }
        }

        /// <remarks />
        [DataMember(Name = "IdString", IsRequired = false, Order = 2)]
        public string IdString
        {
            get { return m_idString;  }
            set { m_idString = value; }
        }

        /// <remarks />
        [DataMember(Name = "IdGuid", IsRequired = false, Order = 3)]
        public Uuid IdGuid
        {
            get { return m_idGuid;  }
            set { m_idGuid = value; }
        }

        /// <remarks />
        [DataMember(Name = "IdByteString", IsRequired = false, Order = 4)]
        public byte[] IdByteString
        {
            get { return m_idByteString;  }
            set { m_idByteString = value; }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public virtual ExpandedNodeId TypeId => DataTypeIds.ApplicationId; 

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public virtual ExpandedNodeId BinaryEncodingId => ObjectIds.ApplicationId_Encoding_DefaultBinary;

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public virtual ExpandedNodeId XmlEncodingId => ObjectIds.ApplicationId_Encoding_DefaultXml;

        /// <summary cref="IJsonEncodeable.JsonEncodingId" />
        public virtual ExpandedNodeId JsonEncodingId => ObjectIds.ApplicationId_Encoding_DefaultJson; 

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public virtual void Encode(IEncoder encoder)
        {
            encoder.PushNamespace(UAModel.FXAC.Namespaces.FXAC);
            encoder.WriteUInt32(nameof(SwitchField), (uint)SwitchField);

            switch (SwitchField)
            {
                default: { break; }
                case ApplicationIdFields.IdNumeric: { encoder.WriteUInt32("IdNumeric", IdNumeric); break; }
                case ApplicationIdFields.IdString: { encoder.WriteString("IdString", IdString); break; }
                case ApplicationIdFields.IdGuid: { encoder.WriteGuid("IdGuid", IdGuid); break; }
                case ApplicationIdFields.IdByteString: { encoder.WriteByteString("IdByteString", IdByteString); break; }
            }
            
            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public virtual void Decode(IDecoder decoder)
        {
            decoder.PushNamespace(UAModel.FXAC.Namespaces.FXAC);

            SwitchField = (ApplicationIdFields)decoder.ReadUInt32(nameof(SwitchField));
                
            switch (SwitchField)
            {
                default: { break; }
                case ApplicationIdFields.IdNumeric: { IdNumeric = decoder.ReadUInt32("IdNumeric"); break; }
                case ApplicationIdFields.IdString: { IdString = decoder.ReadString("IdString"); break; }
                case ApplicationIdFields.IdGuid: { IdGuid = decoder.ReadGuid("IdGuid"); break; }
                case ApplicationIdFields.IdByteString: { IdByteString = decoder.ReadByteString("IdByteString"); break; }
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

            ApplicationId value = encodeable as ApplicationId;

            if (value == null)
            {
                return false;
            }

            if (value.SwitchField != this.SwitchField) return false;

            switch (SwitchField)
            {
                default: { break; }
                case ApplicationIdFields.IdNumeric: { if (!Utils.IsEqual(m_idNumeric, value.m_idNumeric)) return false; break; }
                case ApplicationIdFields.IdString: { if (!Utils.IsEqual(m_idString, value.m_idString)) return false; break; }
                case ApplicationIdFields.IdGuid: { if (!Utils.IsEqual(m_idGuid, value.m_idGuid)) return false; break; }
                case ApplicationIdFields.IdByteString: { if (!Utils.IsEqual(m_idByteString, value.m_idByteString)) return false; break; }
            }

            return true;
        }

        #if !NET_STANDARD
        /// <summary cref="ICloneable.Clone" />
        public virtual object Clone()
        {
            return (ApplicationId)this.MemberwiseClone();
        }
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            ApplicationId clone = (ApplicationId)base.MemberwiseClone();

            clone.SwitchField = this.SwitchField;

            switch (SwitchField)
            {
                default: { break; }
                case ApplicationIdFields.IdNumeric: { clone.m_idNumeric = (uint)Utils.Clone(this.m_idNumeric); break; }
                case ApplicationIdFields.IdString: { clone.m_idString = (string)Utils.Clone(this.m_idString); break; }
                case ApplicationIdFields.IdGuid: { clone.m_idGuid = (Uuid)Utils.Clone(this.m_idGuid); break; }
                case ApplicationIdFields.IdByteString: { clone.m_idByteString = (byte[])Utils.Clone(this.m_idByteString); break; }
            }

            return clone;
        }
        #endregion

        #region Private Fields
        private uint m_idNumeric;
        private string m_idString;
        private Uuid m_idGuid;
        private byte[] m_idByteString;
        #endregion
    }

    #region ApplicationIdCollection Class
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfApplicationId", Namespace = UAModel.FXAC.Namespaces.FXAC, ItemName = "ApplicationId")]
    #if !NET_STANDARD
    public partial class ApplicationIdCollection : List<ApplicationId>, ICloneable
    #else
    public partial class ApplicationIdCollection : List<ApplicationId>
    #endif
    {
        #region Constructors
        /// <remarks />
        public ApplicationIdCollection() {}

        /// <remarks />
        public ApplicationIdCollection(int capacity) : base(capacity) {}

        /// <remarks />
        public ApplicationIdCollection(IEnumerable<ApplicationId> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <remarks />
        public static implicit operator ApplicationIdCollection(ApplicationId[] values)
        {
            if (values != null)
            {
                return new ApplicationIdCollection(values);
            }

            return new ApplicationIdCollection();
        }

        /// <remarks />
        public static explicit operator ApplicationId[](ApplicationIdCollection values)
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
            return (ApplicationIdCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            ApplicationIdCollection clone = new ApplicationIdCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((ApplicationId)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion
}