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
using System.Reflection;
using System.Xml;
using System.Runtime.Serialization;
using Opc.Ua;

namespace UAModel.FXData
{
    #region DataType Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class DataTypes
    {
        /// <remarks />
        public const uint AssetVerificationModeEnum = 1029;

        /// <remarks />
        public const uint AssetVerificationResultEnum = 1037;

        /// <remarks />
        public const uint FunctionalEntityVerificationResultEnum = 3002;

        /// <remarks />
        public const uint PubSubConnectionEndpointModeEnum = 31;

        /// <remarks />
        public const uint FxCommandMask = 1024;

        /// <remarks />
        public const uint AssetVerificationDataType = 1048;

        /// <remarks />
        public const uint AssetVerificationResultDataType = 1038;

        /// <remarks />
        public const uint CommunicationConfigurationDataType = 1046;

        /// <remarks />
        public const uint PubSubCommunicationConfigurationDataType = 1045;

        /// <remarks />
        public const uint CommunicationConfigurationResultDataType = 1033;

        /// <remarks />
        public const uint PubSubCommunicationConfigurationResultDataType = 1039;

        /// <remarks />
        public const uint CommunicationLinkConfigurationDataType = 3007;

        /// <remarks />
        public const uint PubSubCommunicationLinkConfigurationDataType = 1031;

        /// <remarks />
        public const uint ConnectionEndpointConfigurationDataType = 1044;

        /// <remarks />
        public const uint ConnectionEndpointConfigurationResultDataType = 3008;

        /// <remarks />
        public const uint ConnectionEndpointParameterDataType = 3009;

        /// <remarks />
        public const uint PubSubConnectionEndpointParameterDataType = 3006;

        /// <remarks />
        public const uint NodeIdArray = 1034;

        /// <remarks />
        public const uint NodeIdValuePair = 1028;

        /// <remarks />
        public const uint RelatedEndpointDataType = 3003;

        /// <remarks />
        public const uint ReserveCommunicationIdsDataType = 3017;

        /// <remarks />
        public const uint PubSubReserveCommunicationIdsDataType = 3018;

        /// <remarks />
        public const uint ReserveCommunicationIdsResultDataType = 3019;

        /// <remarks />
        public const uint PubSubReserveCommunicationIdsResultDataType = 3020;

        /// <remarks />
        public const uint ConnectionEndpointDefinitionDataType = 3011;
    }
    #endregion

    #region Object Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Objects
    {
        /// <remarks />
        public const uint FxRoot = 71;

        /// <remarks />
        public const uint http___opcfoundation_org_UA_FX_Data_ = 81;

        /// <remarks />
        public const uint ConnectionAdmin = 5019;

        /// <remarks />
        public const uint NodeIdValuePair_Encoding_DefaultBinary = 1093;

        /// <remarks />
        public const uint NodeIdValuePair_Encoding_DefaultXml = 1094;

        /// <remarks />
        public const uint NodeIdValuePair_Encoding_DefaultJson = 1095;

        /// <remarks />
        public const uint PubSubCommunicationLinkConfigurationDataType_Encoding_DefaultBinary = 1102;

        /// <remarks />
        public const uint PubSubCommunicationLinkConfigurationDataType_Encoding_DefaultXml = 1103;

        /// <remarks />
        public const uint PubSubCommunicationLinkConfigurationDataType_Encoding_DefaultJson = 1104;

        /// <remarks />
        public const uint CommunicationConfigurationResultDataType_Encoding_DefaultBinary = 1108;

        /// <remarks />
        public const uint CommunicationConfigurationResultDataType_Encoding_DefaultXml = 1109;

        /// <remarks />
        public const uint CommunicationConfigurationResultDataType_Encoding_DefaultJson = 1110;

        /// <remarks />
        public const uint NodeIdArray_Encoding_DefaultBinary = 1111;

        /// <remarks />
        public const uint NodeIdArray_Encoding_DefaultXml = 1112;

        /// <remarks />
        public const uint NodeIdArray_Encoding_DefaultJson = 1113;

        /// <remarks />
        public const uint ConnectionEndpointConfigurationDataType_Encoding_DefaultBinary = 1141;

        /// <remarks />
        public const uint ConnectionEndpointConfigurationDataType_Encoding_DefaultXml = 1142;

        /// <remarks />
        public const uint ConnectionEndpointConfigurationDataType_Encoding_DefaultJson = 1143;

        /// <remarks />
        public const uint PubSubCommunicationConfigurationDataType_Encoding_DefaultBinary = 1144;

        /// <remarks />
        public const uint PubSubCommunicationConfigurationDataType_Encoding_DefaultXml = 1145;

        /// <remarks />
        public const uint PubSubCommunicationConfigurationDataType_Encoding_DefaultJson = 1146;

        /// <remarks />
        public const uint CommunicationConfigurationDataType_Encoding_DefaultBinary = 1147;

        /// <remarks />
        public const uint CommunicationConfigurationDataType_Encoding_DefaultXml = 1148;

        /// <remarks />
        public const uint CommunicationConfigurationDataType_Encoding_DefaultJson = 1149;

        /// <remarks />
        public const uint AssetVerificationDataType_Encoding_DefaultBinary = 1153;

        /// <remarks />
        public const uint AssetVerificationDataType_Encoding_DefaultXml = 1154;

        /// <remarks />
        public const uint AssetVerificationDataType_Encoding_DefaultJson = 1155;

        /// <remarks />
        public const uint AssetVerificationResultDataType_Encoding_DefaultBinary = 1205;

        /// <remarks />
        public const uint AssetVerificationResultDataType_Encoding_DefaultXml = 1206;

        /// <remarks />
        public const uint AssetVerificationResultDataType_Encoding_DefaultJson = 1207;

        /// <remarks />
        public const uint PubSubCommunicationConfigurationResultDataType_Encoding_DefaultBinary = 1208;

        /// <remarks />
        public const uint PubSubCommunicationConfigurationResultDataType_Encoding_DefaultXml = 1209;

        /// <remarks />
        public const uint PubSubCommunicationConfigurationResultDataType_Encoding_DefaultJson = 1210;

        /// <remarks />
        public const uint RelatedEndpointDataType_Encoding_DefaultBinary = 5001;

        /// <remarks />
        public const uint RelatedEndpointDataType_Encoding_DefaultXml = 5002;

        /// <remarks />
        public const uint RelatedEndpointDataType_Encoding_DefaultJson = 5003;

        /// <remarks />
        public const uint CommunicationLinkConfigurationDataType_Encoding_DefaultBinary = 5033;

        /// <remarks />
        public const uint CommunicationLinkConfigurationDataType_Encoding_DefaultXml = 5034;

        /// <remarks />
        public const uint CommunicationLinkConfigurationDataType_Encoding_DefaultJson = 5035;

        /// <remarks />
        public const uint ConnectionEndpointConfigurationResultDataType_Encoding_DefaultBinary = 5036;

        /// <remarks />
        public const uint ConnectionEndpointConfigurationResultDataType_Encoding_DefaultXml = 5037;

        /// <remarks />
        public const uint ConnectionEndpointConfigurationResultDataType_Encoding_DefaultJson = 5038;

        /// <remarks />
        public const uint ConnectionEndpointParameterDataType_Encoding_DefaultBinary = 5039;

        /// <remarks />
        public const uint ConnectionEndpointParameterDataType_Encoding_DefaultXml = 5040;

        /// <remarks />
        public const uint ConnectionEndpointParameterDataType_Encoding_DefaultJson = 5041;

        /// <remarks />
        public const uint ConnectionEndpointDefinitionDataType_Encoding_DefaultBinary = 5054;

        /// <remarks />
        public const uint ConnectionEndpointDefinitionDataType_Encoding_DefaultXml = 5055;

        /// <remarks />
        public const uint ConnectionEndpointDefinitionDataType_Encoding_DefaultJson = 5056;

        /// <remarks />
        public const uint PubSubConnectionEndpointParameterDataType_Encoding_DefaultBinary = 5060;

        /// <remarks />
        public const uint PubSubConnectionEndpointParameterDataType_Encoding_DefaultXml = 5061;

        /// <remarks />
        public const uint PubSubConnectionEndpointParameterDataType_Encoding_DefaultJson = 5062;

        /// <remarks />
        public const uint ReserveCommunicationIdsDataType_Encoding_DefaultBinary = 5064;

        /// <remarks />
        public const uint ReserveCommunicationIdsDataType_Encoding_DefaultXml = 5065;

        /// <remarks />
        public const uint ReserveCommunicationIdsDataType_Encoding_DefaultJson = 5081;

        /// <remarks />
        public const uint PubSubReserveCommunicationIdsDataType_Encoding_DefaultBinary = 5082;

        /// <remarks />
        public const uint PubSubReserveCommunicationIdsDataType_Encoding_DefaultXml = 5083;

        /// <remarks />
        public const uint PubSubReserveCommunicationIdsDataType_Encoding_DefaultJson = 5084;

        /// <remarks />
        public const uint ReserveCommunicationIdsResultDataType_Encoding_DefaultBinary = 5085;

        /// <remarks />
        public const uint ReserveCommunicationIdsResultDataType_Encoding_DefaultXml = 5086;

        /// <remarks />
        public const uint ReserveCommunicationIdsResultDataType_Encoding_DefaultJson = 5087;

        /// <remarks />
        public const uint PubSubReserveCommunicationIdsResultDataType_Encoding_DefaultBinary = 5088;

        /// <remarks />
        public const uint PubSubReserveCommunicationIdsResultDataType_Encoding_DefaultXml = 5089;

        /// <remarks />
        public const uint PubSubReserveCommunicationIdsResultDataType_Encoding_DefaultJson = 5090;
    }
    #endregion

    #region ObjectType Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectTypes
    {
        /// <remarks />
        public const uint AuditUpdateMethodResultEventType = 1025;
    }
    #endregion

    #region Variable Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Variables
    {
        /// <remarks />
        public const uint AssetVerificationModeEnum_EnumValues = 6327;

        /// <remarks />
        public const uint AssetVerificationResultEnum_EnumValues = 6326;

        /// <remarks />
        public const uint FunctionalEntityVerificationResultEnum_EnumValues = 6532;

        /// <remarks />
        public const uint PubSubConnectionEndpointModeEnum_EnumValues = 6240;

        /// <remarks />
        public const uint FxCommandMask_OptionSetValues = 1225;

        /// <remarks />
        public const uint Opc_Ua_Fx_BinarySchema = 6022;

        /// <remarks />
        public const uint TypeDictionary_XmlSchema = 6024;

        /// <remarks />
        public const uint AuditUpdateMethodResultEventType_OutputArguments = 6325;

        /// <remarks />
        public const uint AuditUpdateMethodResultEventType_StatusCodeId = 6324;

        /// <remarks />
        public const uint http___opcfoundation_org_UA_FX_Data__NamespaceUri = 179;

        /// <remarks />
        public const uint http___opcfoundation_org_UA_FX_Data__NamespaceVersion = 180;

        /// <remarks />
        public const uint http___opcfoundation_org_UA_FX_Data__NamespacePublicationDate = 178;

        /// <remarks />
        public const uint http___opcfoundation_org_UA_FX_Data__IsNamespaceSubset = 177;

        /// <remarks />
        public const uint http___opcfoundation_org_UA_FX_Data__StaticNodeIdTypes = 181;

        /// <remarks />
        public const uint http___opcfoundation_org_UA_FX_Data__StaticNumericNodeIdRange = 182;

        /// <remarks />
        public const uint http___opcfoundation_org_UA_FX_Data__StaticStringNodeIdPattern = 183;

        /// <remarks />
        public const uint ConnectionAdmin_Identities = 6405;

        /// <remarks />
        public const uint ConnectionAdmin_AddIdentity_InputArguments = 6332;

        /// <remarks />
        public const uint ConnectionAdmin_RemoveIdentity_InputArguments = 6408;

        /// <remarks />
        public const uint ConnectionAdmin_AddApplication_InputArguments = 6170;

        /// <remarks />
        public const uint ConnectionAdmin_RemoveApplication_InputArguments = 6406;

        /// <remarks />
        public const uint ConnectionAdmin_AddEndpoint_InputArguments = 6331;

        /// <remarks />
        public const uint ConnectionAdmin_RemoveEndpoint_InputArguments = 6407;
    }
    #endregion

    #region DataType Node Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class DataTypeIds
    {
        /// <remarks />
        public static readonly ExpandedNodeId AssetVerificationModeEnum = new ExpandedNodeId(UAModel.FXData.DataTypes.AssetVerificationModeEnum, UAModel.FXData.Namespaces.FXData);

        /// <remarks />
        public static readonly ExpandedNodeId AssetVerificationResultEnum = new ExpandedNodeId(UAModel.FXData.DataTypes.AssetVerificationResultEnum, UAModel.FXData.Namespaces.FXData);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalEntityVerificationResultEnum = new ExpandedNodeId(UAModel.FXData.DataTypes.FunctionalEntityVerificationResultEnum, UAModel.FXData.Namespaces.FXData);

        /// <remarks />
        public static readonly ExpandedNodeId PubSubConnectionEndpointModeEnum = new ExpandedNodeId(UAModel.FXData.DataTypes.PubSubConnectionEndpointModeEnum, UAModel.FXData.Namespaces.FXData);

        /// <remarks />
        public static readonly ExpandedNodeId FxCommandMask = new ExpandedNodeId(UAModel.FXData.DataTypes.FxCommandMask, UAModel.FXData.Namespaces.FXData);

        /// <remarks />
        public static readonly ExpandedNodeId AssetVerificationDataType = new ExpandedNodeId(UAModel.FXData.DataTypes.AssetVerificationDataType, UAModel.FXData.Namespaces.FXData);

        /// <remarks />
        public static readonly ExpandedNodeId AssetVerificationResultDataType = new ExpandedNodeId(UAModel.FXData.DataTypes.AssetVerificationResultDataType, UAModel.FXData.Namespaces.FXData);

        /// <remarks />
        public static readonly ExpandedNodeId CommunicationConfigurationDataType = new ExpandedNodeId(UAModel.FXData.DataTypes.CommunicationConfigurationDataType, UAModel.FXData.Namespaces.FXData);

        /// <remarks />
        public static readonly ExpandedNodeId PubSubCommunicationConfigurationDataType = new ExpandedNodeId(UAModel.FXData.DataTypes.PubSubCommunicationConfigurationDataType, UAModel.FXData.Namespaces.FXData);

        /// <remarks />
        public static readonly ExpandedNodeId CommunicationConfigurationResultDataType = new ExpandedNodeId(UAModel.FXData.DataTypes.CommunicationConfigurationResultDataType, UAModel.FXData.Namespaces.FXData);

        /// <remarks />
        public static readonly ExpandedNodeId PubSubCommunicationConfigurationResultDataType = new ExpandedNodeId(UAModel.FXData.DataTypes.PubSubCommunicationConfigurationResultDataType, UAModel.FXData.Namespaces.FXData);

        /// <remarks />
        public static readonly ExpandedNodeId CommunicationLinkConfigurationDataType = new ExpandedNodeId(UAModel.FXData.DataTypes.CommunicationLinkConfigurationDataType, UAModel.FXData.Namespaces.FXData);

        /// <remarks />
        public static readonly ExpandedNodeId PubSubCommunicationLinkConfigurationDataType = new ExpandedNodeId(UAModel.FXData.DataTypes.PubSubCommunicationLinkConfigurationDataType, UAModel.FXData.Namespaces.FXData);

        /// <remarks />
        public static readonly ExpandedNodeId ConnectionEndpointConfigurationDataType = new ExpandedNodeId(UAModel.FXData.DataTypes.ConnectionEndpointConfigurationDataType, UAModel.FXData.Namespaces.FXData);

        /// <remarks />
        public static readonly ExpandedNodeId ConnectionEndpointConfigurationResultDataType = new ExpandedNodeId(UAModel.FXData.DataTypes.ConnectionEndpointConfigurationResultDataType, UAModel.FXData.Namespaces.FXData);

        /// <remarks />
        public static readonly ExpandedNodeId ConnectionEndpointParameterDataType = new ExpandedNodeId(UAModel.FXData.DataTypes.ConnectionEndpointParameterDataType, UAModel.FXData.Namespaces.FXData);

        /// <remarks />
        public static readonly ExpandedNodeId PubSubConnectionEndpointParameterDataType = new ExpandedNodeId(UAModel.FXData.DataTypes.PubSubConnectionEndpointParameterDataType, UAModel.FXData.Namespaces.FXData);

        /// <remarks />
        public static readonly ExpandedNodeId NodeIdArray = new ExpandedNodeId(UAModel.FXData.DataTypes.NodeIdArray, UAModel.FXData.Namespaces.FXData);

        /// <remarks />
        public static readonly ExpandedNodeId NodeIdValuePair = new ExpandedNodeId(UAModel.FXData.DataTypes.NodeIdValuePair, UAModel.FXData.Namespaces.FXData);

        /// <remarks />
        public static readonly ExpandedNodeId RelatedEndpointDataType = new ExpandedNodeId(UAModel.FXData.DataTypes.RelatedEndpointDataType, UAModel.FXData.Namespaces.FXData);

        /// <remarks />
        public static readonly ExpandedNodeId ReserveCommunicationIdsDataType = new ExpandedNodeId(UAModel.FXData.DataTypes.ReserveCommunicationIdsDataType, UAModel.FXData.Namespaces.FXData);

        /// <remarks />
        public static readonly ExpandedNodeId PubSubReserveCommunicationIdsDataType = new ExpandedNodeId(UAModel.FXData.DataTypes.PubSubReserveCommunicationIdsDataType, UAModel.FXData.Namespaces.FXData);

        /// <remarks />
        public static readonly ExpandedNodeId ReserveCommunicationIdsResultDataType = new ExpandedNodeId(UAModel.FXData.DataTypes.ReserveCommunicationIdsResultDataType, UAModel.FXData.Namespaces.FXData);

        /// <remarks />
        public static readonly ExpandedNodeId PubSubReserveCommunicationIdsResultDataType = new ExpandedNodeId(UAModel.FXData.DataTypes.PubSubReserveCommunicationIdsResultDataType, UAModel.FXData.Namespaces.FXData);

        /// <remarks />
        public static readonly ExpandedNodeId ConnectionEndpointDefinitionDataType = new ExpandedNodeId(UAModel.FXData.DataTypes.ConnectionEndpointDefinitionDataType, UAModel.FXData.Namespaces.FXData);
    }
    #endregion

    #region Object Node Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectIds
    {
        /// <remarks />
        public static readonly ExpandedNodeId FxRoot = new ExpandedNodeId(UAModel.FXData.Objects.FxRoot, UAModel.FXData.Namespaces.FXData);

        /// <remarks />
        public static readonly ExpandedNodeId http___opcfoundation_org_UA_FX_Data_ = new ExpandedNodeId(UAModel.FXData.Objects.http___opcfoundation_org_UA_FX_Data_, UAModel.FXData.Namespaces.FXData);

        /// <remarks />
        public static readonly ExpandedNodeId ConnectionAdmin = new ExpandedNodeId(UAModel.FXData.Objects.ConnectionAdmin, UAModel.FXData.Namespaces.FXData);

        /// <remarks />
        public static readonly ExpandedNodeId NodeIdValuePair_Encoding_DefaultBinary = new ExpandedNodeId(UAModel.FXData.Objects.NodeIdValuePair_Encoding_DefaultBinary, UAModel.FXData.Namespaces.FXData);

        /// <remarks />
        public static readonly ExpandedNodeId NodeIdValuePair_Encoding_DefaultXml = new ExpandedNodeId(UAModel.FXData.Objects.NodeIdValuePair_Encoding_DefaultXml, UAModel.FXData.Namespaces.FXData);

        /// <remarks />
        public static readonly ExpandedNodeId NodeIdValuePair_Encoding_DefaultJson = new ExpandedNodeId(UAModel.FXData.Objects.NodeIdValuePair_Encoding_DefaultJson, UAModel.FXData.Namespaces.FXData);

        /// <remarks />
        public static readonly ExpandedNodeId PubSubCommunicationLinkConfigurationDataType_Encoding_DefaultBinary = new ExpandedNodeId(UAModel.FXData.Objects.PubSubCommunicationLinkConfigurationDataType_Encoding_DefaultBinary, UAModel.FXData.Namespaces.FXData);

        /// <remarks />
        public static readonly ExpandedNodeId PubSubCommunicationLinkConfigurationDataType_Encoding_DefaultXml = new ExpandedNodeId(UAModel.FXData.Objects.PubSubCommunicationLinkConfigurationDataType_Encoding_DefaultXml, UAModel.FXData.Namespaces.FXData);

        /// <remarks />
        public static readonly ExpandedNodeId PubSubCommunicationLinkConfigurationDataType_Encoding_DefaultJson = new ExpandedNodeId(UAModel.FXData.Objects.PubSubCommunicationLinkConfigurationDataType_Encoding_DefaultJson, UAModel.FXData.Namespaces.FXData);

        /// <remarks />
        public static readonly ExpandedNodeId CommunicationConfigurationResultDataType_Encoding_DefaultBinary = new ExpandedNodeId(UAModel.FXData.Objects.CommunicationConfigurationResultDataType_Encoding_DefaultBinary, UAModel.FXData.Namespaces.FXData);

        /// <remarks />
        public static readonly ExpandedNodeId CommunicationConfigurationResultDataType_Encoding_DefaultXml = new ExpandedNodeId(UAModel.FXData.Objects.CommunicationConfigurationResultDataType_Encoding_DefaultXml, UAModel.FXData.Namespaces.FXData);

        /// <remarks />
        public static readonly ExpandedNodeId CommunicationConfigurationResultDataType_Encoding_DefaultJson = new ExpandedNodeId(UAModel.FXData.Objects.CommunicationConfigurationResultDataType_Encoding_DefaultJson, UAModel.FXData.Namespaces.FXData);

        /// <remarks />
        public static readonly ExpandedNodeId NodeIdArray_Encoding_DefaultBinary = new ExpandedNodeId(UAModel.FXData.Objects.NodeIdArray_Encoding_DefaultBinary, UAModel.FXData.Namespaces.FXData);

        /// <remarks />
        public static readonly ExpandedNodeId NodeIdArray_Encoding_DefaultXml = new ExpandedNodeId(UAModel.FXData.Objects.NodeIdArray_Encoding_DefaultXml, UAModel.FXData.Namespaces.FXData);

        /// <remarks />
        public static readonly ExpandedNodeId NodeIdArray_Encoding_DefaultJson = new ExpandedNodeId(UAModel.FXData.Objects.NodeIdArray_Encoding_DefaultJson, UAModel.FXData.Namespaces.FXData);

        /// <remarks />
        public static readonly ExpandedNodeId ConnectionEndpointConfigurationDataType_Encoding_DefaultBinary = new ExpandedNodeId(UAModel.FXData.Objects.ConnectionEndpointConfigurationDataType_Encoding_DefaultBinary, UAModel.FXData.Namespaces.FXData);

        /// <remarks />
        public static readonly ExpandedNodeId ConnectionEndpointConfigurationDataType_Encoding_DefaultXml = new ExpandedNodeId(UAModel.FXData.Objects.ConnectionEndpointConfigurationDataType_Encoding_DefaultXml, UAModel.FXData.Namespaces.FXData);

        /// <remarks />
        public static readonly ExpandedNodeId ConnectionEndpointConfigurationDataType_Encoding_DefaultJson = new ExpandedNodeId(UAModel.FXData.Objects.ConnectionEndpointConfigurationDataType_Encoding_DefaultJson, UAModel.FXData.Namespaces.FXData);

        /// <remarks />
        public static readonly ExpandedNodeId PubSubCommunicationConfigurationDataType_Encoding_DefaultBinary = new ExpandedNodeId(UAModel.FXData.Objects.PubSubCommunicationConfigurationDataType_Encoding_DefaultBinary, UAModel.FXData.Namespaces.FXData);

        /// <remarks />
        public static readonly ExpandedNodeId PubSubCommunicationConfigurationDataType_Encoding_DefaultXml = new ExpandedNodeId(UAModel.FXData.Objects.PubSubCommunicationConfigurationDataType_Encoding_DefaultXml, UAModel.FXData.Namespaces.FXData);

        /// <remarks />
        public static readonly ExpandedNodeId PubSubCommunicationConfigurationDataType_Encoding_DefaultJson = new ExpandedNodeId(UAModel.FXData.Objects.PubSubCommunicationConfigurationDataType_Encoding_DefaultJson, UAModel.FXData.Namespaces.FXData);

        /// <remarks />
        public static readonly ExpandedNodeId CommunicationConfigurationDataType_Encoding_DefaultBinary = new ExpandedNodeId(UAModel.FXData.Objects.CommunicationConfigurationDataType_Encoding_DefaultBinary, UAModel.FXData.Namespaces.FXData);

        /// <remarks />
        public static readonly ExpandedNodeId CommunicationConfigurationDataType_Encoding_DefaultXml = new ExpandedNodeId(UAModel.FXData.Objects.CommunicationConfigurationDataType_Encoding_DefaultXml, UAModel.FXData.Namespaces.FXData);

        /// <remarks />
        public static readonly ExpandedNodeId CommunicationConfigurationDataType_Encoding_DefaultJson = new ExpandedNodeId(UAModel.FXData.Objects.CommunicationConfigurationDataType_Encoding_DefaultJson, UAModel.FXData.Namespaces.FXData);

        /// <remarks />
        public static readonly ExpandedNodeId AssetVerificationDataType_Encoding_DefaultBinary = new ExpandedNodeId(UAModel.FXData.Objects.AssetVerificationDataType_Encoding_DefaultBinary, UAModel.FXData.Namespaces.FXData);

        /// <remarks />
        public static readonly ExpandedNodeId AssetVerificationDataType_Encoding_DefaultXml = new ExpandedNodeId(UAModel.FXData.Objects.AssetVerificationDataType_Encoding_DefaultXml, UAModel.FXData.Namespaces.FXData);

        /// <remarks />
        public static readonly ExpandedNodeId AssetVerificationDataType_Encoding_DefaultJson = new ExpandedNodeId(UAModel.FXData.Objects.AssetVerificationDataType_Encoding_DefaultJson, UAModel.FXData.Namespaces.FXData);

        /// <remarks />
        public static readonly ExpandedNodeId AssetVerificationResultDataType_Encoding_DefaultBinary = new ExpandedNodeId(UAModel.FXData.Objects.AssetVerificationResultDataType_Encoding_DefaultBinary, UAModel.FXData.Namespaces.FXData);

        /// <remarks />
        public static readonly ExpandedNodeId AssetVerificationResultDataType_Encoding_DefaultXml = new ExpandedNodeId(UAModel.FXData.Objects.AssetVerificationResultDataType_Encoding_DefaultXml, UAModel.FXData.Namespaces.FXData);

        /// <remarks />
        public static readonly ExpandedNodeId AssetVerificationResultDataType_Encoding_DefaultJson = new ExpandedNodeId(UAModel.FXData.Objects.AssetVerificationResultDataType_Encoding_DefaultJson, UAModel.FXData.Namespaces.FXData);

        /// <remarks />
        public static readonly ExpandedNodeId PubSubCommunicationConfigurationResultDataType_Encoding_DefaultBinary = new ExpandedNodeId(UAModel.FXData.Objects.PubSubCommunicationConfigurationResultDataType_Encoding_DefaultBinary, UAModel.FXData.Namespaces.FXData);

        /// <remarks />
        public static readonly ExpandedNodeId PubSubCommunicationConfigurationResultDataType_Encoding_DefaultXml = new ExpandedNodeId(UAModel.FXData.Objects.PubSubCommunicationConfigurationResultDataType_Encoding_DefaultXml, UAModel.FXData.Namespaces.FXData);

        /// <remarks />
        public static readonly ExpandedNodeId PubSubCommunicationConfigurationResultDataType_Encoding_DefaultJson = new ExpandedNodeId(UAModel.FXData.Objects.PubSubCommunicationConfigurationResultDataType_Encoding_DefaultJson, UAModel.FXData.Namespaces.FXData);

        /// <remarks />
        public static readonly ExpandedNodeId RelatedEndpointDataType_Encoding_DefaultBinary = new ExpandedNodeId(UAModel.FXData.Objects.RelatedEndpointDataType_Encoding_DefaultBinary, UAModel.FXData.Namespaces.FXData);

        /// <remarks />
        public static readonly ExpandedNodeId RelatedEndpointDataType_Encoding_DefaultXml = new ExpandedNodeId(UAModel.FXData.Objects.RelatedEndpointDataType_Encoding_DefaultXml, UAModel.FXData.Namespaces.FXData);

        /// <remarks />
        public static readonly ExpandedNodeId RelatedEndpointDataType_Encoding_DefaultJson = new ExpandedNodeId(UAModel.FXData.Objects.RelatedEndpointDataType_Encoding_DefaultJson, UAModel.FXData.Namespaces.FXData);

        /// <remarks />
        public static readonly ExpandedNodeId CommunicationLinkConfigurationDataType_Encoding_DefaultBinary = new ExpandedNodeId(UAModel.FXData.Objects.CommunicationLinkConfigurationDataType_Encoding_DefaultBinary, UAModel.FXData.Namespaces.FXData);

        /// <remarks />
        public static readonly ExpandedNodeId CommunicationLinkConfigurationDataType_Encoding_DefaultXml = new ExpandedNodeId(UAModel.FXData.Objects.CommunicationLinkConfigurationDataType_Encoding_DefaultXml, UAModel.FXData.Namespaces.FXData);

        /// <remarks />
        public static readonly ExpandedNodeId CommunicationLinkConfigurationDataType_Encoding_DefaultJson = new ExpandedNodeId(UAModel.FXData.Objects.CommunicationLinkConfigurationDataType_Encoding_DefaultJson, UAModel.FXData.Namespaces.FXData);

        /// <remarks />
        public static readonly ExpandedNodeId ConnectionEndpointConfigurationResultDataType_Encoding_DefaultBinary = new ExpandedNodeId(UAModel.FXData.Objects.ConnectionEndpointConfigurationResultDataType_Encoding_DefaultBinary, UAModel.FXData.Namespaces.FXData);

        /// <remarks />
        public static readonly ExpandedNodeId ConnectionEndpointConfigurationResultDataType_Encoding_DefaultXml = new ExpandedNodeId(UAModel.FXData.Objects.ConnectionEndpointConfigurationResultDataType_Encoding_DefaultXml, UAModel.FXData.Namespaces.FXData);

        /// <remarks />
        public static readonly ExpandedNodeId ConnectionEndpointConfigurationResultDataType_Encoding_DefaultJson = new ExpandedNodeId(UAModel.FXData.Objects.ConnectionEndpointConfigurationResultDataType_Encoding_DefaultJson, UAModel.FXData.Namespaces.FXData);

        /// <remarks />
        public static readonly ExpandedNodeId ConnectionEndpointParameterDataType_Encoding_DefaultBinary = new ExpandedNodeId(UAModel.FXData.Objects.ConnectionEndpointParameterDataType_Encoding_DefaultBinary, UAModel.FXData.Namespaces.FXData);

        /// <remarks />
        public static readonly ExpandedNodeId ConnectionEndpointParameterDataType_Encoding_DefaultXml = new ExpandedNodeId(UAModel.FXData.Objects.ConnectionEndpointParameterDataType_Encoding_DefaultXml, UAModel.FXData.Namespaces.FXData);

        /// <remarks />
        public static readonly ExpandedNodeId ConnectionEndpointParameterDataType_Encoding_DefaultJson = new ExpandedNodeId(UAModel.FXData.Objects.ConnectionEndpointParameterDataType_Encoding_DefaultJson, UAModel.FXData.Namespaces.FXData);

        /// <remarks />
        public static readonly ExpandedNodeId ConnectionEndpointDefinitionDataType_Encoding_DefaultBinary = new ExpandedNodeId(UAModel.FXData.Objects.ConnectionEndpointDefinitionDataType_Encoding_DefaultBinary, UAModel.FXData.Namespaces.FXData);

        /// <remarks />
        public static readonly ExpandedNodeId ConnectionEndpointDefinitionDataType_Encoding_DefaultXml = new ExpandedNodeId(UAModel.FXData.Objects.ConnectionEndpointDefinitionDataType_Encoding_DefaultXml, UAModel.FXData.Namespaces.FXData);

        /// <remarks />
        public static readonly ExpandedNodeId ConnectionEndpointDefinitionDataType_Encoding_DefaultJson = new ExpandedNodeId(UAModel.FXData.Objects.ConnectionEndpointDefinitionDataType_Encoding_DefaultJson, UAModel.FXData.Namespaces.FXData);

        /// <remarks />
        public static readonly ExpandedNodeId PubSubConnectionEndpointParameterDataType_Encoding_DefaultBinary = new ExpandedNodeId(UAModel.FXData.Objects.PubSubConnectionEndpointParameterDataType_Encoding_DefaultBinary, UAModel.FXData.Namespaces.FXData);

        /// <remarks />
        public static readonly ExpandedNodeId PubSubConnectionEndpointParameterDataType_Encoding_DefaultXml = new ExpandedNodeId(UAModel.FXData.Objects.PubSubConnectionEndpointParameterDataType_Encoding_DefaultXml, UAModel.FXData.Namespaces.FXData);

        /// <remarks />
        public static readonly ExpandedNodeId PubSubConnectionEndpointParameterDataType_Encoding_DefaultJson = new ExpandedNodeId(UAModel.FXData.Objects.PubSubConnectionEndpointParameterDataType_Encoding_DefaultJson, UAModel.FXData.Namespaces.FXData);

        /// <remarks />
        public static readonly ExpandedNodeId ReserveCommunicationIdsDataType_Encoding_DefaultBinary = new ExpandedNodeId(UAModel.FXData.Objects.ReserveCommunicationIdsDataType_Encoding_DefaultBinary, UAModel.FXData.Namespaces.FXData);

        /// <remarks />
        public static readonly ExpandedNodeId ReserveCommunicationIdsDataType_Encoding_DefaultXml = new ExpandedNodeId(UAModel.FXData.Objects.ReserveCommunicationIdsDataType_Encoding_DefaultXml, UAModel.FXData.Namespaces.FXData);

        /// <remarks />
        public static readonly ExpandedNodeId ReserveCommunicationIdsDataType_Encoding_DefaultJson = new ExpandedNodeId(UAModel.FXData.Objects.ReserveCommunicationIdsDataType_Encoding_DefaultJson, UAModel.FXData.Namespaces.FXData);

        /// <remarks />
        public static readonly ExpandedNodeId PubSubReserveCommunicationIdsDataType_Encoding_DefaultBinary = new ExpandedNodeId(UAModel.FXData.Objects.PubSubReserveCommunicationIdsDataType_Encoding_DefaultBinary, UAModel.FXData.Namespaces.FXData);

        /// <remarks />
        public static readonly ExpandedNodeId PubSubReserveCommunicationIdsDataType_Encoding_DefaultXml = new ExpandedNodeId(UAModel.FXData.Objects.PubSubReserveCommunicationIdsDataType_Encoding_DefaultXml, UAModel.FXData.Namespaces.FXData);

        /// <remarks />
        public static readonly ExpandedNodeId PubSubReserveCommunicationIdsDataType_Encoding_DefaultJson = new ExpandedNodeId(UAModel.FXData.Objects.PubSubReserveCommunicationIdsDataType_Encoding_DefaultJson, UAModel.FXData.Namespaces.FXData);

        /// <remarks />
        public static readonly ExpandedNodeId ReserveCommunicationIdsResultDataType_Encoding_DefaultBinary = new ExpandedNodeId(UAModel.FXData.Objects.ReserveCommunicationIdsResultDataType_Encoding_DefaultBinary, UAModel.FXData.Namespaces.FXData);

        /// <remarks />
        public static readonly ExpandedNodeId ReserveCommunicationIdsResultDataType_Encoding_DefaultXml = new ExpandedNodeId(UAModel.FXData.Objects.ReserveCommunicationIdsResultDataType_Encoding_DefaultXml, UAModel.FXData.Namespaces.FXData);

        /// <remarks />
        public static readonly ExpandedNodeId ReserveCommunicationIdsResultDataType_Encoding_DefaultJson = new ExpandedNodeId(UAModel.FXData.Objects.ReserveCommunicationIdsResultDataType_Encoding_DefaultJson, UAModel.FXData.Namespaces.FXData);

        /// <remarks />
        public static readonly ExpandedNodeId PubSubReserveCommunicationIdsResultDataType_Encoding_DefaultBinary = new ExpandedNodeId(UAModel.FXData.Objects.PubSubReserveCommunicationIdsResultDataType_Encoding_DefaultBinary, UAModel.FXData.Namespaces.FXData);

        /// <remarks />
        public static readonly ExpandedNodeId PubSubReserveCommunicationIdsResultDataType_Encoding_DefaultXml = new ExpandedNodeId(UAModel.FXData.Objects.PubSubReserveCommunicationIdsResultDataType_Encoding_DefaultXml, UAModel.FXData.Namespaces.FXData);

        /// <remarks />
        public static readonly ExpandedNodeId PubSubReserveCommunicationIdsResultDataType_Encoding_DefaultJson = new ExpandedNodeId(UAModel.FXData.Objects.PubSubReserveCommunicationIdsResultDataType_Encoding_DefaultJson, UAModel.FXData.Namespaces.FXData);
    }
    #endregion

    #region ObjectType Node Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectTypeIds
    {
        /// <remarks />
        public static readonly ExpandedNodeId AuditUpdateMethodResultEventType = new ExpandedNodeId(UAModel.FXData.ObjectTypes.AuditUpdateMethodResultEventType, UAModel.FXData.Namespaces.FXData);
    }
    #endregion

    #region Variable Node Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class VariableIds
    {
        /// <remarks />
        public static readonly ExpandedNodeId AssetVerificationModeEnum_EnumValues = new ExpandedNodeId(UAModel.FXData.Variables.AssetVerificationModeEnum_EnumValues, UAModel.FXData.Namespaces.FXData);

        /// <remarks />
        public static readonly ExpandedNodeId AssetVerificationResultEnum_EnumValues = new ExpandedNodeId(UAModel.FXData.Variables.AssetVerificationResultEnum_EnumValues, UAModel.FXData.Namespaces.FXData);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalEntityVerificationResultEnum_EnumValues = new ExpandedNodeId(UAModel.FXData.Variables.FunctionalEntityVerificationResultEnum_EnumValues, UAModel.FXData.Namespaces.FXData);

        /// <remarks />
        public static readonly ExpandedNodeId PubSubConnectionEndpointModeEnum_EnumValues = new ExpandedNodeId(UAModel.FXData.Variables.PubSubConnectionEndpointModeEnum_EnumValues, UAModel.FXData.Namespaces.FXData);

        /// <remarks />
        public static readonly ExpandedNodeId FxCommandMask_OptionSetValues = new ExpandedNodeId(UAModel.FXData.Variables.FxCommandMask_OptionSetValues, UAModel.FXData.Namespaces.FXData);

        /// <remarks />
        public static readonly ExpandedNodeId Opc_Ua_Fx_BinarySchema = new ExpandedNodeId(UAModel.FXData.Variables.Opc_Ua_Fx_BinarySchema, UAModel.FXData.Namespaces.FXData);

        /// <remarks />
        public static readonly ExpandedNodeId TypeDictionary_XmlSchema = new ExpandedNodeId(UAModel.FXData.Variables.TypeDictionary_XmlSchema, UAModel.FXData.Namespaces.FXData);

        /// <remarks />
        public static readonly ExpandedNodeId AuditUpdateMethodResultEventType_OutputArguments = new ExpandedNodeId(UAModel.FXData.Variables.AuditUpdateMethodResultEventType_OutputArguments, UAModel.FXData.Namespaces.FXData);

        /// <remarks />
        public static readonly ExpandedNodeId AuditUpdateMethodResultEventType_StatusCodeId = new ExpandedNodeId(UAModel.FXData.Variables.AuditUpdateMethodResultEventType_StatusCodeId, UAModel.FXData.Namespaces.FXData);

        /// <remarks />
        public static readonly ExpandedNodeId http___opcfoundation_org_UA_FX_Data__NamespaceUri = new ExpandedNodeId(UAModel.FXData.Variables.http___opcfoundation_org_UA_FX_Data__NamespaceUri, UAModel.FXData.Namespaces.FXData);

        /// <remarks />
        public static readonly ExpandedNodeId http___opcfoundation_org_UA_FX_Data__NamespaceVersion = new ExpandedNodeId(UAModel.FXData.Variables.http___opcfoundation_org_UA_FX_Data__NamespaceVersion, UAModel.FXData.Namespaces.FXData);

        /// <remarks />
        public static readonly ExpandedNodeId http___opcfoundation_org_UA_FX_Data__NamespacePublicationDate = new ExpandedNodeId(UAModel.FXData.Variables.http___opcfoundation_org_UA_FX_Data__NamespacePublicationDate, UAModel.FXData.Namespaces.FXData);

        /// <remarks />
        public static readonly ExpandedNodeId http___opcfoundation_org_UA_FX_Data__IsNamespaceSubset = new ExpandedNodeId(UAModel.FXData.Variables.http___opcfoundation_org_UA_FX_Data__IsNamespaceSubset, UAModel.FXData.Namespaces.FXData);

        /// <remarks />
        public static readonly ExpandedNodeId http___opcfoundation_org_UA_FX_Data__StaticNodeIdTypes = new ExpandedNodeId(UAModel.FXData.Variables.http___opcfoundation_org_UA_FX_Data__StaticNodeIdTypes, UAModel.FXData.Namespaces.FXData);

        /// <remarks />
        public static readonly ExpandedNodeId http___opcfoundation_org_UA_FX_Data__StaticNumericNodeIdRange = new ExpandedNodeId(UAModel.FXData.Variables.http___opcfoundation_org_UA_FX_Data__StaticNumericNodeIdRange, UAModel.FXData.Namespaces.FXData);

        /// <remarks />
        public static readonly ExpandedNodeId http___opcfoundation_org_UA_FX_Data__StaticStringNodeIdPattern = new ExpandedNodeId(UAModel.FXData.Variables.http___opcfoundation_org_UA_FX_Data__StaticStringNodeIdPattern, UAModel.FXData.Namespaces.FXData);

        /// <remarks />
        public static readonly ExpandedNodeId ConnectionAdmin_Identities = new ExpandedNodeId(UAModel.FXData.Variables.ConnectionAdmin_Identities, UAModel.FXData.Namespaces.FXData);

        /// <remarks />
        public static readonly ExpandedNodeId ConnectionAdmin_AddIdentity_InputArguments = new ExpandedNodeId(UAModel.FXData.Variables.ConnectionAdmin_AddIdentity_InputArguments, UAModel.FXData.Namespaces.FXData);

        /// <remarks />
        public static readonly ExpandedNodeId ConnectionAdmin_RemoveIdentity_InputArguments = new ExpandedNodeId(UAModel.FXData.Variables.ConnectionAdmin_RemoveIdentity_InputArguments, UAModel.FXData.Namespaces.FXData);

        /// <remarks />
        public static readonly ExpandedNodeId ConnectionAdmin_AddApplication_InputArguments = new ExpandedNodeId(UAModel.FXData.Variables.ConnectionAdmin_AddApplication_InputArguments, UAModel.FXData.Namespaces.FXData);

        /// <remarks />
        public static readonly ExpandedNodeId ConnectionAdmin_RemoveApplication_InputArguments = new ExpandedNodeId(UAModel.FXData.Variables.ConnectionAdmin_RemoveApplication_InputArguments, UAModel.FXData.Namespaces.FXData);

        /// <remarks />
        public static readonly ExpandedNodeId ConnectionAdmin_AddEndpoint_InputArguments = new ExpandedNodeId(UAModel.FXData.Variables.ConnectionAdmin_AddEndpoint_InputArguments, UAModel.FXData.Namespaces.FXData);

        /// <remarks />
        public static readonly ExpandedNodeId ConnectionAdmin_RemoveEndpoint_InputArguments = new ExpandedNodeId(UAModel.FXData.Variables.ConnectionAdmin_RemoveEndpoint_InputArguments, UAModel.FXData.Namespaces.FXData);
    }
    #endregion

    #region BrowseName Declarations
    /// <remarks />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class BrowseNames
    {
        /// <remarks />
        public const string AssetVerificationDataType = "AssetVerificationDataType";

        /// <remarks />
        public const string AssetVerificationModeEnum = "AssetVerificationModeEnum";

        /// <remarks />
        public const string AssetVerificationResultDataType = "AssetVerificationResultDataType";

        /// <remarks />
        public const string AssetVerificationResultEnum = "AssetVerificationResultEnum";

        /// <remarks />
        public const string AuditUpdateMethodResultEventType = "AuditUpdateMethodResultEventType";

        /// <remarks />
        public const string CommunicationConfigurationDataType = "CommunicationConfigurationDataType";

        /// <remarks />
        public const string CommunicationConfigurationResultDataType = "CommunicationConfigurationResultDataType";

        /// <remarks />
        public const string CommunicationLinkConfigurationDataType = "CommunicationLinkConfigurationDataType";

        /// <remarks />
        public const string ConnectionAdmin = "ConnectionAdmin";

        /// <remarks />
        public const string ConnectionEndpointConfigurationDataType = "ConnectionEndpointConfigurationDataType";

        /// <remarks />
        public const string ConnectionEndpointConfigurationResultDataType = "ConnectionEndpointConfigurationResultDataType";

        /// <remarks />
        public const string ConnectionEndpointDefinitionDataType = "ConnectionEndpointDefinitionDataType";

        /// <remarks />
        public const string ConnectionEndpointParameterDataType = "ConnectionEndpointParameterDataType";

        /// <remarks />
        public const string FunctionalEntityVerificationResultEnum = "FunctionalEntityVerificationResultEnum";

        /// <remarks />
        public const string FxCommandMask = "FxCommandMask";

        /// <remarks />
        public const string FxRoot = "FxRoot";

        /// <remarks />
        public const string http___opcfoundation_org_UA_FX_Data_ = "http://opcfoundation.org/UA/FX/Data/";

        /// <remarks />
        public const string NodeIdArray = "NodeIdArray";

        /// <remarks />
        public const string NodeIdValuePair = "NodeIdValuePair";

        /// <remarks />
        public const string Opc_Ua_Fx_BinarySchema = "Opc.Ua.Fx";

        /// <remarks />
        public const string OutputArguments = "OutputArguments";

        /// <remarks />
        public const string PubSubCommunicationConfigurationDataType = "PubSubCommunicationConfigurationDataType";

        /// <remarks />
        public const string PubSubCommunicationConfigurationResultDataType = "PubSubCommunicationConfigurationResultDataType";

        /// <remarks />
        public const string PubSubCommunicationLinkConfigurationDataType = "PubSubCommunicationLinkConfigurationDataType";

        /// <remarks />
        public const string PubSubConnectionEndpointModeEnum = "PubSubConnectionEndpointModeEnum";

        /// <remarks />
        public const string PubSubConnectionEndpointParameterDataType = "PubSubConnectionEndpointParameterDataType";

        /// <remarks />
        public const string PubSubReserveCommunicationIdsDataType = "PubSubReserveCommunicationIdsDataType";

        /// <remarks />
        public const string PubSubReserveCommunicationIdsResultDataType = "PubSubReserveCommunicationIdsResultDataType";

        /// <remarks />
        public const string RelatedEndpointDataType = "RelatedEndpointDataType";

        /// <remarks />
        public const string ReserveCommunicationIdsDataType = "ReserveCommunicationIdsDataType";

        /// <remarks />
        public const string ReserveCommunicationIdsResultDataType = "ReserveCommunicationIdsResultDataType";

        /// <remarks />
        public const string StatusCodeId = "StatusCodeId";

        /// <remarks />
        public const string TypeDictionary_XmlSchema = "TypeDictionary";
    }
    #endregion

    #region Namespace Declarations
    /// <remarks />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Namespaces
    {
        /// <summary>
        /// The URI for the FXData namespace (.NET code namespace is 'UAModel.FXData').
        /// </summary>
        public const string FXData = "http://opcfoundation.org/UA/FX/Data/";

        /// <summary>
        /// The URI for the OpcUa namespace (.NET code namespace is 'Opc.Ua').
        /// </summary>
        public const string OpcUa = "http://opcfoundation.org/UA/";

        /// <summary>
        /// The URI for the OpcUaXsd namespace (.NET code namespace is 'Opc.Ua').
        /// </summary>
        public const string OpcUaXsd = "http://opcfoundation.org/UA/2008/02/Types.xsd";
    }
    #endregion
}