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
using UAModel.DI;
using UAModel.FXData;

namespace UAModel.FXAC
{
    #region DataType Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class DataTypes
    {
        /// <remarks />
        public const uint ClampKindEnum = 3001;

        /// <remarks />
        public const uint ConnectionEndpointStatusEnum = 3007;

        /// <remarks />
        public const uint FxTimeUnitsEnum = 3006;

        /// <remarks />
        public const uint SocketKindEnum = 3002;

        /// <remarks />
        public const uint CommHealthOptionSet = 3004;

        /// <remarks />
        public const uint DeviceHealthOptionSet = 3005;

        /// <remarks />
        public const uint OperationalHealthOptionSet = 3010;

        /// <remarks />
        public const uint AggregatedHealthDataType = 3003;

        /// <remarks />
        public const uint ApplicationIdentifierDataType = 28;

        /// <remarks />
        public const uint FxVersion = 25;

        /// <remarks />
        public const uint IntervalRange = 3008;

        /// <remarks />
        public const uint PublisherQosDataType = 3011;

        /// <remarks />
        public const uint SubscriberQosDataType = 3012;

        /// <remarks />
        public const uint ApplicationId = 3013;
    }
    #endregion

    #region Method Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Methods
    {
        /// <remarks />
        public const uint AcDescriptorType_DescriptorFile_Open = 7007;

        /// <remarks />
        public const uint AcDescriptorType_DescriptorFile_Close = 7001;

        /// <remarks />
        public const uint AcDescriptorType_DescriptorFile_Read = 7008;

        /// <remarks />
        public const uint AcDescriptorType_DescriptorFile_Write = 7010;

        /// <remarks />
        public const uint AcDescriptorType_DescriptorFile_GetPosition = 7002;

        /// <remarks />
        public const uint AcDescriptorType_DescriptorFile_SetPosition = 7009;

        /// <remarks />
        public const uint AutomationComponentType_Assets_Asset_SoftwareUpdate_PrepareForUpdate_Prepare = 19;

        /// <remarks />
        public const uint AutomationComponentType_Assets_Asset_SoftwareUpdate_PrepareForUpdate_Abort = 20;

        /// <remarks />
        public const uint AutomationComponentType_Assets_Asset_SoftwareUpdate_Installation_Resume = 61;

        /// <remarks />
        public const uint AutomationComponentType_Assets_Asset_SoftwareUpdate_Confirmation_Confirm = 112;

        /// <remarks />
        public const uint AutomationComponentType_Assets_Asset_SoftwareUpdate_Parameters_GenerateFileForRead = 124;

        /// <remarks />
        public const uint AutomationComponentType_Assets_Asset_SoftwareUpdate_Parameters_GenerateFileForWrite = 127;

        /// <remarks />
        public const uint AutomationComponentType_Assets_Asset_SoftwareUpdate_Parameters_CloseAndCommit = 130;

        /// <remarks />
        public const uint AutomationComponentType_CloseConnections = 293;

        /// <remarks />
        public const uint AutomationComponentType_EstablishConnections = 292;

        /// <remarks />
        public const uint IAssetRevisionType_VerifyAsset = 1476;

        /// <remarks />
        public const uint IFunctionalEntityType_Verify = 289;

        /// <remarks />
        public const uint ControlGroupType_ControlGroup_EstablishControl = 290;

        /// <remarks />
        public const uint ControlGroupType_ControlGroup_ListToBlock_Lock_InitLock = 7005;

        /// <remarks />
        public const uint ControlGroupType_ControlGroup_ListToBlock_Lock_RenewLock = 7006;

        /// <remarks />
        public const uint ControlGroupType_ControlGroup_ListToBlock_Lock_ExitLock = 7004;

        /// <remarks />
        public const uint ControlGroupType_ControlGroup_ListToBlock_Lock_BreakLock = 7003;

        /// <remarks />
        public const uint ControlGroupType_ControlGroup_ListToRestrict_Lock_InitLock = 7029;

        /// <remarks />
        public const uint ControlGroupType_ControlGroup_ListToRestrict_Lock_RenewLock = 7030;

        /// <remarks />
        public const uint ControlGroupType_ControlGroup_ListToRestrict_Lock_ExitLock = 7028;

        /// <remarks />
        public const uint ControlGroupType_ControlGroup_ListToRestrict_Lock_BreakLock = 7027;

        /// <remarks />
        public const uint ControlGroupType_ControlGroup_ReassignControl = 7011;

        /// <remarks />
        public const uint ControlGroupType_ControlGroup_ReleaseControl = 1493;

        /// <remarks />
        public const uint ControlGroupType_EstablishControl = 290;

        /// <remarks />
        public const uint ControlGroupType_ListToBlock_Lock_InitLock = 7018;

        /// <remarks />
        public const uint ControlGroupType_ListToBlock_Lock_RenewLock = 7019;

        /// <remarks />
        public const uint ControlGroupType_ListToBlock_Lock_ExitLock = 7017;

        /// <remarks />
        public const uint ControlGroupType_ListToBlock_Lock_BreakLock = 7016;

        /// <remarks />
        public const uint ControlGroupType_ListToRestrict_Lock_InitLock = 7022;

        /// <remarks />
        public const uint ControlGroupType_ListToRestrict_Lock_RenewLock = 7023;

        /// <remarks />
        public const uint ControlGroupType_ListToRestrict_Lock_ExitLock = 7021;

        /// <remarks />
        public const uint ControlGroupType_ListToRestrict_Lock_BreakLock = 7020;

        /// <remarks />
        public const uint ControlGroupType_ReassignControl = 7011;

        /// <remarks />
        public const uint ControlGroupType_ReleaseControl = 1493;

        /// <remarks />
        public const uint ControlGroupsFolderType_ControlGroup_ListToBlock_Lock_InitLock = 7055;

        /// <remarks />
        public const uint ControlGroupsFolderType_ControlGroup_ListToBlock_Lock_RenewLock = 7056;

        /// <remarks />
        public const uint ControlGroupsFolderType_ControlGroup_ListToBlock_Lock_ExitLock = 7054;

        /// <remarks />
        public const uint ControlGroupsFolderType_ControlGroup_ListToBlock_Lock_BreakLock = 7053;

        /// <remarks />
        public const uint ControlGroupsFolderType_ControlGroup_ListToRestrict_Lock_InitLock = 7059;

        /// <remarks />
        public const uint ControlGroupsFolderType_ControlGroup_ListToRestrict_Lock_RenewLock = 7060;

        /// <remarks />
        public const uint ControlGroupsFolderType_ControlGroup_ListToRestrict_Lock_ExitLock = 7058;

        /// <remarks />
        public const uint ControlGroupsFolderType_ControlGroup_ListToRestrict_Lock_BreakLock = 7057;

        /// <remarks />
        public const uint ConfigurationDataFolderType_ClearStoredVariables = 7025;

        /// <remarks />
        public const uint ConfigurationDataFolderType_ListStoredVariables = 7026;

        /// <remarks />
        public const uint ConfigurationDataFolderType_SetStoredVariables = 7024;

        /// <remarks />
        public const uint ControlItemFolderType_Lock_InitLock = 7014;

        /// <remarks />
        public const uint ControlItemFolderType_Lock_RenewLock = 7015;

        /// <remarks />
        public const uint ControlItemFolderType_Lock_ExitLock = 7013;

        /// <remarks />
        public const uint ControlItemFolderType_Lock_BreakLock = 7012;

        /// <remarks />
        public const uint FunctionalEntityType_SubFunctionalEntity_Verify = 301;

        /// <remarks />
        public const uint FunctionalEntityType_Verify = 301;

        /// <remarks />
        public const uint FxAssetType_SoftwareUpdate_PrepareForUpdate_Prepare = 19;

        /// <remarks />
        public const uint FxAssetType_SoftwareUpdate_PrepareForUpdate_Abort = 20;

        /// <remarks />
        public const uint FxAssetType_SoftwareUpdate_Installation_Resume = 61;

        /// <remarks />
        public const uint FxAssetType_SoftwareUpdate_Confirmation_Confirm = 112;

        /// <remarks />
        public const uint FxAssetType_SoftwareUpdate_Parameters_GenerateFileForRead = 124;

        /// <remarks />
        public const uint FxAssetType_SoftwareUpdate_Parameters_GenerateFileForWrite = 127;

        /// <remarks />
        public const uint FxAssetType_SoftwareUpdate_Parameters_CloseAndCommit = 130;

        /// <remarks />
        public const uint FxAssetType_VerifyAsset = 1502;

        /// <remarks />
        public const string AutomationComponentType_CloseConnectionsMethodType = "";

        /// <remarks />
        public const string AutomationComponentType_EstablishConnectionsMethodType = "";

        /// <remarks />
        public const string IAssetRevisionType_VerifyAssetMethodType = "";

        /// <remarks />
        public const string IFunctionalEntityType_VerifyMethodType = "";

        /// <remarks />
        public const string ControlGroupType_EstablishControlMethodType = "";

        /// <remarks />
        public const string ControlGroupType_ReassignControlMethodType = "";

        /// <remarks />
        public const string ConfigurationDataFolderType_ClearStoredVariablesMethodType = "";

        /// <remarks />
        public const string ConfigurationDataFolderType_ListStoredVariablesMethodType = "";

        /// <remarks />
        public const string ConfigurationDataFolderType_SetStoredVariablesMethodType = "";
    }
    #endregion

    #region Object Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Objects
    {
        /// <remarks />
        public const uint AcDescriptorType_DescriptorFile = 5072;

        /// <remarks />
        public const uint ClampBlockType_Clamp = 94;

        /// <remarks />
        public const uint AutomationComponentType_Assets = 68;

        /// <remarks />
        public const uint AutomationComponentType_Assets_Asset = 73;

        /// <remarks />
        public const uint AutomationComponentType_ComponentCapabilities = 1066;

        /// <remarks />
        public const uint AutomationComponentType_Descriptors = 5073;

        /// <remarks />
        public const uint AutomationComponentType_FunctionalEntities = 67;

        /// <remarks />
        public const uint AutomationComponentType_FunctionalEntities_FunctionalEntity = 82;

        /// <remarks />
        public const uint AutomationComponentType_PublisherCapabilities = 5009;

        /// <remarks />
        public const uint AutomationComponentType_SubscriberCapabilities = 5010;

        /// <remarks />
        public const uint IFunctionalEntityType_Capabilities = 5039;

        /// <remarks />
        public const uint IFunctionalEntityType_ConfigurationData = 5104;

        /// <remarks />
        public const uint IFunctionalEntityType_ConnectionEndpoints = 52;

        /// <remarks />
        public const uint IFunctionalEntityType_ControlGroups = 1064;

        /// <remarks />
        public const uint IFunctionalEntityType_InputData = 1203;

        /// <remarks />
        public const uint IFunctionalEntityType_OperationalHealthAlarms = 5035;

        /// <remarks />
        public const uint IFunctionalEntityType_OutputData = 1204;

        /// <remarks />
        public const uint IFunctionalEntityType_PublisherCapabilities = 5007;

        /// <remarks />
        public const uint IFunctionalEntityType_SubscriberCapabilities = 5008;

        /// <remarks />
        public const uint ControlGroupType_ControlGroup = 5018;

        /// <remarks />
        public const uint ControlGroupType_ControlGroup_ListOfRelated = 5030;

        /// <remarks />
        public const uint ControlGroupType_ControlGroup_ListToBlock = 5033;

        /// <remarks />
        public const uint ControlGroupType_ControlGroup_ListToBlock_Lock = 5034;

        /// <remarks />
        public const uint ControlGroupType_ControlGroup_ListToRestrict = 5036;

        /// <remarks />
        public const uint ControlGroupType_ControlGroup_ListToRestrict_Lock = 5037;

        /// <remarks />
        public const uint ControlGroupType_ListOfRelated = 5075;

        /// <remarks />
        public const uint ControlGroupType_ListToBlock = 1069;

        /// <remarks />
        public const uint ControlGroupType_ListToBlock_Lock = 5078;

        /// <remarks />
        public const uint ControlGroupType_ListToRestrict = 1070;

        /// <remarks />
        public const uint ControlGroupType_ListToRestrict_Lock = 5080;

        /// <remarks />
        public const uint ConnectionEndpointsFolderType_ConnectionEndpoint = 1077;

        /// <remarks />
        public const uint ControlGroupsFolderType_ControlGroup = 1074;

        /// <remarks />
        public const uint ControlGroupsFolderType_ControlGroup_ListOfRelated = 5077;

        /// <remarks />
        public const uint ControlGroupsFolderType_ControlGroup_ListToBlock = 1081;

        /// <remarks />
        public const uint ControlGroupsFolderType_ControlGroup_ListToBlock_Lock = 5099;

        /// <remarks />
        public const uint ControlGroupsFolderType_ControlGroup_ListToRestrict = 1082;

        /// <remarks />
        public const uint ControlGroupsFolderType_ControlGroup_ListToRestrict_Lock = 5103;

        /// <remarks />
        public const uint ControlItemFolderType_Lock = 5051;

        /// <remarks />
        public const uint InputsFolderType_InputGroup = 5016;

        /// <remarks />
        public const uint InputsFolderType_InputGroup_SubscriberCapabilities = 5017;

        /// <remarks />
        public const uint InputsFolderType_SubscriberCapabilities = 5017;

        /// <remarks />
        public const uint OutputsFolderType_OutputGroup = 5014;

        /// <remarks />
        public const uint OutputsFolderType_OutputGroup_PublisherCapabilities = 5015;

        /// <remarks />
        public const uint OutputsFolderType_PublisherCapabilities = 5015;

        /// <remarks />
        public const uint FunctionalEntityType_SubFunctionalEntity = 5011;

        /// <remarks />
        public const uint FunctionalEntityType_SubFunctionalEntity_Capabilities = 5040;

        /// <remarks />
        public const uint FunctionalEntityType_SubFunctionalEntity_ConfigurationData = 5031;

        /// <remarks />
        public const uint FunctionalEntityType_SubFunctionalEntity_ConnectionEndpoints = 5032;

        /// <remarks />
        public const uint FunctionalEntityType_SubFunctionalEntity_ControlGroups = 1065;

        /// <remarks />
        public const uint FunctionalEntityType_SubFunctionalEntity_InputData = 1125;

        /// <remarks />
        public const uint FunctionalEntityType_SubFunctionalEntity_OperationalHealthAlarms = 5041;

        /// <remarks />
        public const uint FunctionalEntityType_SubFunctionalEntity_OutputData = 1126;

        /// <remarks />
        public const uint FunctionalEntityType_SubFunctionalEntity_PublisherCapabilities = 5012;

        /// <remarks />
        public const uint FunctionalEntityType_SubFunctionalEntity_SubscriberCapabilities = 5013;

        /// <remarks />
        public const uint FunctionalEntityType_Capabilities = 5040;

        /// <remarks />
        public const uint FunctionalEntityType_ConfigurationData = 5031;

        /// <remarks />
        public const uint FunctionalEntityType_ConnectionEndpoints = 5032;

        /// <remarks />
        public const uint FunctionalEntityType_ControlGroups = 1065;

        /// <remarks />
        public const uint FunctionalEntityType_InputData = 1125;

        /// <remarks />
        public const uint FunctionalEntityType_OperationalHealthAlarms = 5041;

        /// <remarks />
        public const uint FunctionalEntityType_OutputData = 1126;

        /// <remarks />
        public const uint FunctionalEntityType_PublisherCapabilities = 5012;

        /// <remarks />
        public const uint FunctionalEntityType_SubscriberCapabilities = 5013;

        /// <remarks />
        public const uint FxAssetType_Connectors = 72;

        /// <remarks />
        public const uint FxAssetType_Connectors_AssetConnector = 76;

        /// <remarks />
        public const uint FxAssetType_DeviceHealthAlarms = 5023;

        /// <remarks />
        public const uint FxAssetType_SoftwareUpdate = 5002;

        /// <remarks />
        public const uint http___opcfoundation_org_UA_FX_AC_ = 5001;

        /// <remarks />
        public const uint ApplicationIdentifierDataType_Encoding_DefaultBinary = 60;

        /// <remarks />
        public const uint ApplicationIdentifierDataType_Encoding_DefaultXml = 62;

        /// <remarks />
        public const uint ApplicationIdentifierDataType_Encoding_DefaultJson = 69;

        /// <remarks />
        public const uint FxVersion_Encoding_DefaultBinary = 91;

        /// <remarks />
        public const uint FxVersion_Encoding_DefaultXml = 92;

        /// <remarks />
        public const uint FxVersion_Encoding_DefaultJson = 93;

        /// <remarks />
        public const uint ApplicationId_Encoding_DefaultBinary = 5003;

        /// <remarks />
        public const uint AggregatedHealthDataType_Encoding_DefaultBinary = 5004;

        /// <remarks />
        public const uint AggregatedHealthDataType_Encoding_DefaultXml = 5005;

        /// <remarks />
        public const uint AggregatedHealthDataType_Encoding_DefaultJson = 5006;

        /// <remarks />
        public const uint IntervalRange_Encoding_DefaultBinary = 5019;

        /// <remarks />
        public const uint IntervalRange_Encoding_DefaultXml = 5020;

        /// <remarks />
        public const uint ApplicationId_Encoding_DefaultXml = 5021;

        /// <remarks />
        public const uint IntervalRange_Encoding_DefaultJson = 5022;

        /// <remarks />
        public const uint PublisherQosDataType_Encoding_DefaultBinary = 5024;

        /// <remarks />
        public const uint PublisherQosDataType_Encoding_DefaultXml = 5025;

        /// <remarks />
        public const uint PublisherQosDataType_Encoding_DefaultJson = 5026;

        /// <remarks />
        public const uint SubscriberQosDataType_Encoding_DefaultBinary = 5027;

        /// <remarks />
        public const uint SubscriberQosDataType_Encoding_DefaultXml = 5028;

        /// <remarks />
        public const uint SubscriberQosDataType_Encoding_DefaultJson = 5029;

        /// <remarks />
        public const uint ApplicationId_Encoding_DefaultJson = 5038;
    }
    #endregion

    #region ObjectType Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectTypes
    {
        /// <remarks />
        public const uint AcDescriptorType = 1027;

        /// <remarks />
        public const uint AssetConnectorType = 5;

        /// <remarks />
        public const uint ClampBlockType = 7;

        /// <remarks />
        public const uint ClampType = 10;

        /// <remarks />
        public const uint SlotType = 6;

        /// <remarks />
        public const uint SocketType = 8;

        /// <remarks />
        public const uint AutomationComponentType = 2;

        /// <remarks />
        public const uint AuditUaFxEventType = 1030;

        /// <remarks />
        public const uint AuditConnectionCleanupEventType = 1040;

        /// <remarks />
        public const uint IAssetRevisionType = 9;

        /// <remarks />
        public const uint IFunctionalEntityType = 11;

        /// <remarks />
        public const uint ConnectionEndpointType = 1002;

        /// <remarks />
        public const uint PubSubConnectionEndpointType = 1005;

        /// <remarks />
        public const uint ControlGroupType = 15;

        /// <remarks />
        public const uint AutomationComponentCapabilitiesType = 1001;

        /// <remarks />
        public const uint ConnectionEndpointsFolderType = 20;

        /// <remarks />
        public const uint ControlGroupsFolderType = 1010;

        /// <remarks />
        public const uint FunctionalEntityCapabilitiesType = 1008;

        /// <remarks />
        public const uint ConfigurationDataFolderType = 1041;

        /// <remarks />
        public const uint ControlItemFolderType = 1011;

        /// <remarks />
        public const uint InputsFolderType = 1000;

        /// <remarks />
        public const uint OutputsFolderType = 1019;

        /// <remarks />
        public const uint FunctionalEntityType = 4;

        /// <remarks />
        public const uint FxAssetType = 3;

        /// <remarks />
        public const uint PublisherCapabilitiesType = 1003;

        /// <remarks />
        public const uint SubscriberCapabilitiesType = 1004;
    }
    #endregion

    #region ReferenceType Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ReferenceTypes
    {
        /// <remarks />
        public const uint HasCapability = 4002;

        /// <remarks />
        public const uint HasConnectionEndpoint = 41;

        /// <remarks />
        public const uint HasControlGroup = 44;

        /// <remarks />
        public const uint HasInputGroup = 1056;

        /// <remarks />
        public const uint HasOutputGroup = 1058;

        /// <remarks />
        public const uint HasBuiltInAsset = 34;

        /// <remarks />
        public const uint HasPart = 35;

        /// <remarks />
        public const uint HasSubFunctionalEntity = 43;

        /// <remarks />
        public const uint IsPartOfRedundantAssetSet = 4004;

        /// <remarks />
        public const uint ConnectedTo = 37;

        /// <remarks />
        public const uint ToDataSetReader = 42;

        /// <remarks />
        public const uint ToDataSetWriter = 46;
    }
    #endregion

    #region Variable Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Variables
    {
        /// <remarks />
        public const uint ClampKindEnum_EnumValues = 6011;

        /// <remarks />
        public const uint ConnectionEndpointStatusEnum_EnumValues = 6050;

        /// <remarks />
        public const uint FxTimeUnitsEnum_EnumStrings = 6078;

        /// <remarks />
        public const uint SocketKindEnum_EnumStrings = 6029;

        /// <remarks />
        public const uint CommHealthOptionSet_OptionSetValues = 6018;

        /// <remarks />
        public const uint DeviceHealthOptionSet_OptionSetValues = 6019;

        /// <remarks />
        public const uint OperationalHealthOptionSet_OptionSetValues = 6084;

        /// <remarks />
        public const uint TypeDictionary_BinarySchema = 6012;

        /// <remarks />
        public const uint TypeDictionary_XmlSchema = 6014;

        /// <remarks />
        public const uint AggregatedHealthType_AggregatedDeviceHealth = 6052;

        /// <remarks />
        public const uint AggregatedHealthType_AggregatedOperationalHealth = 6053;

        /// <remarks />
        public const uint AcDescriptorType_DescriptorFile_Size = 6346;

        /// <remarks />
        public const uint AcDescriptorType_DescriptorFile_Writable = 6348;

        /// <remarks />
        public const uint AcDescriptorType_DescriptorFile_UserWritable = 6347;

        /// <remarks />
        public const uint AcDescriptorType_DescriptorFile_OpenCount = 6342;

        /// <remarks />
        public const uint AcDescriptorType_DescriptorFile_Open_InputArguments = 6340;

        /// <remarks />
        public const uint AcDescriptorType_DescriptorFile_Open_OutputArguments = 6341;

        /// <remarks />
        public const uint AcDescriptorType_DescriptorFile_Close_InputArguments = 6337;

        /// <remarks />
        public const uint AcDescriptorType_DescriptorFile_Read_InputArguments = 6343;

        /// <remarks />
        public const uint AcDescriptorType_DescriptorFile_Read_OutputArguments = 6344;

        /// <remarks />
        public const uint AcDescriptorType_DescriptorFile_Write_InputArguments = 6349;

        /// <remarks />
        public const uint AcDescriptorType_DescriptorFile_GetPosition_InputArguments = 6338;

        /// <remarks />
        public const uint AcDescriptorType_DescriptorFile_GetPosition_OutputArguments = 6339;

        /// <remarks />
        public const uint AcDescriptorType_DescriptorFile_SetPosition_InputArguments = 6345;

        /// <remarks />
        public const uint AcDescriptorType_DescriptorIdentifier = 6335;

        /// <remarks />
        public const uint AcDescriptorType_DescriptorVersion = 6336;

        /// <remarks />
        public const uint AssetConnectorType_Id = 114;

        /// <remarks />
        public const uint AssetConnectorType_Name = 116;

        /// <remarks />
        public const uint ClampBlockType_Name = 217;

        /// <remarks />
        public const uint ClampBlockType_Clamp_Name = 220;

        /// <remarks />
        public const uint ClampBlockType_Clamp_Kind_EnumValues = 1254;

        /// <remarks />
        public const uint ClampBlockType_Clamp_Kind_ValueAsText = 1255;

        /// <remarks />
        public const uint ClampBlockType_BlockSize = 218;

        /// <remarks />
        public const uint ClampBlockType_Kind = 1250;

        /// <remarks />
        public const uint ClampBlockType_Kind_EnumValues = 1251;

        /// <remarks />
        public const uint ClampBlockType_Kind_ValueAsText = 1252;

        /// <remarks />
        public const uint ClampType_Name = 214;

        /// <remarks />
        public const uint ClampType_Kind = 215;

        /// <remarks />
        public const uint ClampType_Kind_EnumValues = 1254;

        /// <remarks />
        public const uint ClampType_Kind_ValueAsText = 1255;

        /// <remarks />
        public const uint SlotType_Id = 115;

        /// <remarks />
        public const uint SlotType_LogicalId = 159;

        /// <remarks />
        public const uint SocketType_Name = 211;

        /// <remarks />
        public const uint SocketType_Kind = 6008;

        /// <remarks />
        public const uint SocketType_Kind_EnumValues = 6009;

        /// <remarks />
        public const uint SocketType_Kind_ValueAsText = 6010;

        /// <remarks />
        public const uint AutomationComponentType_AggregatedHealth = 6048;

        /// <remarks />
        public const uint AutomationComponentType_AggregatedHealth_AggregatedDeviceHealth = 6051;

        /// <remarks />
        public const uint AutomationComponentType_AggregatedHealth_AggregatedOperationalHealth = 6070;

        /// <remarks />
        public const uint AutomationComponentType_Assets_Asset_ManufacturerUri = 200;

        /// <remarks />
        public const uint AutomationComponentType_Assets_Asset_ProductCode = 201;

        /// <remarks />
        public const uint AutomationComponentType_Assets_Asset_SoftwareUpdate_PrepareForUpdate_CurrentState = 5;

        /// <remarks />
        public const uint AutomationComponentType_Assets_Asset_SoftwareUpdate_PrepareForUpdate_CurrentState_Id = 6;

        /// <remarks />
        public const uint AutomationComponentType_Assets_Asset_SoftwareUpdate_Installation_CurrentState = 41;

        /// <remarks />
        public const uint AutomationComponentType_Assets_Asset_SoftwareUpdate_Installation_CurrentState_Id = 42;

        /// <remarks />
        public const uint AutomationComponentType_Assets_Asset_SoftwareUpdate_Installation_InstallSoftwarePackage_InputArguments = 266;

        /// <remarks />
        public const uint AutomationComponentType_Assets_Asset_SoftwareUpdate_Installation_InstallFiles_InputArguments = 269;

        /// <remarks />
        public const uint AutomationComponentType_Assets_Asset_SoftwareUpdate_PowerCycle_CurrentState = 77;

        /// <remarks />
        public const uint AutomationComponentType_Assets_Asset_SoftwareUpdate_PowerCycle_CurrentState_Id = 78;

        /// <remarks />
        public const uint AutomationComponentType_Assets_Asset_SoftwareUpdate_Confirmation_CurrentState = 99;

        /// <remarks />
        public const uint AutomationComponentType_Assets_Asset_SoftwareUpdate_Confirmation_CurrentState_Id = 100;

        /// <remarks />
        public const uint AutomationComponentType_Assets_Asset_SoftwareUpdate_Confirmation_ConfirmationTimeout = 113;

        /// <remarks />
        public const uint AutomationComponentType_Assets_Asset_SoftwareUpdate_Parameters_ClientProcessingTimeout = 123;

        /// <remarks />
        public const uint AutomationComponentType_Assets_Asset_SoftwareUpdate_Parameters_GenerateFileForRead_InputArguments = 125;

        /// <remarks />
        public const uint AutomationComponentType_Assets_Asset_SoftwareUpdate_Parameters_GenerateFileForRead_OutputArguments = 126;

        /// <remarks />
        public const uint AutomationComponentType_Assets_Asset_SoftwareUpdate_Parameters_GenerateFileForWrite_InputArguments = 128;

        /// <remarks />
        public const uint AutomationComponentType_Assets_Asset_SoftwareUpdate_Parameters_GenerateFileForWrite_OutputArguments = 129;

        /// <remarks />
        public const uint AutomationComponentType_Assets_Asset_SoftwareUpdate_Parameters_CloseAndCommit_InputArguments = 131;

        /// <remarks />
        public const uint AutomationComponentType_Assets_Asset_SoftwareUpdate_Parameters_CloseAndCommit_OutputArguments = 132;

        /// <remarks />
        public const uint AutomationComponentType_Assets_Asset_VerifyAsset_InputArguments = 1356;

        /// <remarks />
        public const uint AutomationComponentType_Assets_Asset_VerifyAsset_OutputArguments = 1357;

        /// <remarks />
        public const uint AutomationComponentType_CloseConnections_InputArguments = 1305;

        /// <remarks />
        public const uint AutomationComponentType_CloseConnections_OutputArguments = 1306;

        /// <remarks />
        public const uint AutomationComponentType_ComponentCapabilities_MaxConnections = 6360;

        /// <remarks />
        public const uint AutomationComponentType_ComponentCapabilities_SupportsPersistence = 6359;

        /// <remarks />
        public const uint AutomationComponentType_ConformanceName = 210;

        /// <remarks />
        public const uint AutomationComponentType_EstablishConnections_InputArguments = 1303;

        /// <remarks />
        public const uint AutomationComponentType_EstablishConnections_OutputArguments = 1304;

        /// <remarks />
        public const uint AutomationComponentType_FunctionalEntities_FunctionalEntity_ConfigurationData_ClearStoredVariables_InputArguments = 6398;

        /// <remarks />
        public const uint AutomationComponentType_FunctionalEntities_FunctionalEntity_ConfigurationData_ClearStoredVariables_OutputArguments = 6399;

        /// <remarks />
        public const uint AutomationComponentType_FunctionalEntities_FunctionalEntity_ConfigurationData_ListStoredVariables_OutputArguments = 6401;

        /// <remarks />
        public const uint AutomationComponentType_FunctionalEntities_FunctionalEntity_ConfigurationData_SetStoredVariables_InputArguments = 6396;

        /// <remarks />
        public const uint AutomationComponentType_FunctionalEntities_FunctionalEntity_ConfigurationData_SetStoredVariables_OutputArguments = 6397;

        /// <remarks />
        public const uint AutomationComponentType_FunctionalEntities_FunctionalEntity_InputData_SubscriberCapabilities_PreconfiguredDataSetOnly = 6064;

        /// <remarks />
        public const uint AutomationComponentType_FunctionalEntities_FunctionalEntity_InputData_SubscriberCapabilities_PreconfiguredSubscribedDataSets = 6065;

        /// <remarks />
        public const uint AutomationComponentType_FunctionalEntities_FunctionalEntity_InputData_SubscriberCapabilities_SupportedMessageReceiveTimeouts = 6066;

        /// <remarks />
        public const uint AutomationComponentType_FunctionalEntities_FunctionalEntity_InputData_SubscriberCapabilities_SupportedPublishingIntervals = 6067;

        /// <remarks />
        public const uint AutomationComponentType_FunctionalEntities_FunctionalEntity_InputData_SubscriberCapabilities_SupportedQos = 6068;

        /// <remarks />
        public const uint AutomationComponentType_FunctionalEntities_FunctionalEntity_OutputData_PublisherCapabilities_PreconfiguredDataSetOnly = 6097;

        /// <remarks />
        public const uint AutomationComponentType_FunctionalEntities_FunctionalEntity_OutputData_PublisherCapabilities_PreconfiguredPublishedDataSets = 6098;

        /// <remarks />
        public const uint AutomationComponentType_FunctionalEntities_FunctionalEntity_OutputData_PublisherCapabilities_SupportedPublishingIntervals = 6099;

        /// <remarks />
        public const uint AutomationComponentType_FunctionalEntities_FunctionalEntity_OutputData_PublisherCapabilities_SupportedQos = 6100;

        /// <remarks />
        public const uint AutomationComponentType_FunctionalEntities_FunctionalEntity_PublisherCapabilities_PreconfiguredDataSetOnly = 6054;

        /// <remarks />
        public const uint AutomationComponentType_FunctionalEntities_FunctionalEntity_PublisherCapabilities_PreconfiguredPublishedDataSets = 6057;

        /// <remarks />
        public const uint AutomationComponentType_FunctionalEntities_FunctionalEntity_PublisherCapabilities_SupportedPublishingIntervals = 6058;

        /// <remarks />
        public const uint AutomationComponentType_FunctionalEntities_FunctionalEntity_PublisherCapabilities_SupportedQos = 6059;

        /// <remarks />
        public const uint AutomationComponentType_FunctionalEntities_FunctionalEntity_SubscriberCapabilities_PreconfiguredDataSetOnly = 6055;

        /// <remarks />
        public const uint AutomationComponentType_FunctionalEntities_FunctionalEntity_SubscriberCapabilities_PreconfiguredSubscribedDataSets = 6060;

        /// <remarks />
        public const uint AutomationComponentType_FunctionalEntities_FunctionalEntity_SubscriberCapabilities_SupportedMessageReceiveTimeouts = 6061;

        /// <remarks />
        public const uint AutomationComponentType_FunctionalEntities_FunctionalEntity_SubscriberCapabilities_SupportedPublishingIntervals = 6062;

        /// <remarks />
        public const uint AutomationComponentType_FunctionalEntities_FunctionalEntity_SubscriberCapabilities_SupportedQos = 6063;

        /// <remarks />
        public const uint AutomationComponentType_FunctionalEntities_FunctionalEntity_Verify_InputArguments = 1358;

        /// <remarks />
        public const uint AutomationComponentType_FunctionalEntities_FunctionalEntity_Verify_OutputArguments = 1359;

        /// <remarks />
        public const uint AutomationComponentType_PublisherCapabilities_PreconfiguredDataSetOnly = 6032;

        /// <remarks />
        public const uint AutomationComponentType_PublisherCapabilities_PreconfiguredPublishedDataSets = 6041;

        /// <remarks />
        public const uint AutomationComponentType_PublisherCapabilities_SupportedPublishingIntervals = 6042;

        /// <remarks />
        public const uint AutomationComponentType_PublisherCapabilities_SupportedQos = 6043;

        /// <remarks />
        public const uint AutomationComponentType_SubscriberCapabilities_PreconfiguredDataSetOnly = 6036;

        /// <remarks />
        public const uint AutomationComponentType_SubscriberCapabilities_PreconfiguredSubscribedDataSets = 6044;

        /// <remarks />
        public const uint AutomationComponentType_SubscriberCapabilities_SupportedMessageReceiveTimeouts = 6045;

        /// <remarks />
        public const uint AutomationComponentType_SubscriberCapabilities_SupportedPublishingIntervals = 6046;

        /// <remarks />
        public const uint AutomationComponentType_SubscriberCapabilities_SupportedQos = 6047;

        /// <remarks />
        public const uint AuditConnectionCleanupEventType_RelatedEndpoint = 6351;

        /// <remarks />
        public const uint AuditConnectionCleanupEventType_RemovedEndpoint = 6350;

        /// <remarks />
        public const uint IAssetRevisionType_BuildAssetNumber = 119;

        /// <remarks />
        public const uint IAssetRevisionType_MajorAssetVersion = 117;

        /// <remarks />
        public const uint IAssetRevisionType_MinorAssetVersion = 118;

        /// <remarks />
        public const uint IAssetRevisionType_SubBuildAssetNumber = 120;

        /// <remarks />
        public const uint IAssetRevisionType_VerifyAsset_InputArguments = 1422;

        /// <remarks />
        public const uint IAssetRevisionType_VerifyAsset_OutputArguments = 1423;

        /// <remarks />
        public const uint IFunctionalEntityType_ApplicationIdentifier = 129;

        /// <remarks />
        public const uint IFunctionalEntityType_AuthorAssignedIdentifier = 127;

        /// <remarks />
        public const uint IFunctionalEntityType_AuthorAssignedVersion = 128;

        /// <remarks />
        public const uint IFunctionalEntityType_AuthorUri = 126;

        /// <remarks />
        public const uint IFunctionalEntityType_Capabilities_FeedbackSignalRequired = 6121;

        /// <remarks />
        public const uint IFunctionalEntityType_ConfigurationData_ClearStoredVariables_InputArguments = 6398;

        /// <remarks />
        public const uint IFunctionalEntityType_ConfigurationData_ClearStoredVariables_OutputArguments = 6399;

        /// <remarks />
        public const uint IFunctionalEntityType_ConfigurationData_ListStoredVariables_OutputArguments = 6401;

        /// <remarks />
        public const uint IFunctionalEntityType_ConfigurationData_SetStoredVariables_InputArguments = 6396;

        /// <remarks />
        public const uint IFunctionalEntityType_ConfigurationData_SetStoredVariables_OutputArguments = 6397;

        /// <remarks />
        public const uint IFunctionalEntityType_InputData_SubscriberCapabilities_PreconfiguredDataSetOnly = 6064;

        /// <remarks />
        public const uint IFunctionalEntityType_InputData_SubscriberCapabilities_PreconfiguredSubscribedDataSets = 6065;

        /// <remarks />
        public const uint IFunctionalEntityType_InputData_SubscriberCapabilities_SupportedMessageReceiveTimeouts = 6066;

        /// <remarks />
        public const uint IFunctionalEntityType_InputData_SubscriberCapabilities_SupportedPublishingIntervals = 6067;

        /// <remarks />
        public const uint IFunctionalEntityType_InputData_SubscriberCapabilities_SupportedQos = 6068;

        /// <remarks />
        public const uint IFunctionalEntityType_OperationalHealth = 6101;

        /// <remarks />
        public const uint IFunctionalEntityType_OutputData_PublisherCapabilities_PreconfiguredDataSetOnly = 6097;

        /// <remarks />
        public const uint IFunctionalEntityType_OutputData_PublisherCapabilities_PreconfiguredPublishedDataSets = 6098;

        /// <remarks />
        public const uint IFunctionalEntityType_OutputData_PublisherCapabilities_SupportedPublishingIntervals = 6099;

        /// <remarks />
        public const uint IFunctionalEntityType_OutputData_PublisherCapabilities_SupportedQos = 6100;

        /// <remarks />
        public const uint IFunctionalEntityType_PublisherCapabilities_PreconfiguredDataSetOnly = 6030;

        /// <remarks />
        public const uint IFunctionalEntityType_PublisherCapabilities_PreconfiguredPublishedDataSets = 6031;

        /// <remarks />
        public const uint IFunctionalEntityType_PublisherCapabilities_SupportedPublishingIntervals = 6033;

        /// <remarks />
        public const uint IFunctionalEntityType_PublisherCapabilities_SupportedQos = 6034;

        /// <remarks />
        public const uint IFunctionalEntityType_SubscriberCapabilities_PreconfiguredDataSetOnly = 6035;

        /// <remarks />
        public const uint IFunctionalEntityType_SubscriberCapabilities_PreconfiguredSubscribedDataSets = 6037;

        /// <remarks />
        public const uint IFunctionalEntityType_SubscriberCapabilities_SupportedMessageReceiveTimeouts = 6038;

        /// <remarks />
        public const uint IFunctionalEntityType_SubscriberCapabilities_SupportedPublishingIntervals = 6039;

        /// <remarks />
        public const uint IFunctionalEntityType_SubscriberCapabilities_SupportedQos = 6040;

        /// <remarks />
        public const uint IFunctionalEntityType_Verify_InputArguments = 1420;

        /// <remarks />
        public const uint IFunctionalEntityType_Verify_OutputArguments = 1421;

        /// <remarks />
        public const uint ConnectionEndpointType_CleanupTimeout = 1316;

        /// <remarks />
        public const uint ConnectionEndpointType_InputVariables = 6197;

        /// <remarks />
        public const uint ConnectionEndpointType_IsPersistent = 1308;

        /// <remarks />
        public const uint ConnectionEndpointType_OutputVariables = 6198;

        /// <remarks />
        public const uint ConnectionEndpointType_RelatedEndpoint = 6069;

        /// <remarks />
        public const uint ConnectionEndpointType_Status = 1300;

        /// <remarks />
        public const uint PubSubConnectionEndpointType_Mode = 1352;

        /// <remarks />
        public const uint ControlGroupType_ControlGroup_EstablishControl_InputArguments = 6093;

        /// <remarks />
        public const uint ControlGroupType_ControlGroup_EstablishControl_OutputArguments = 6094;

        /// <remarks />
        public const uint ControlGroupType_ControlGroup_IsControlled = 6089;

        /// <remarks />
        public const uint ControlGroupType_ControlGroup_ListToBlock_Lock_Locked = 6105;

        /// <remarks />
        public const uint ControlGroupType_ControlGroup_ListToBlock_Lock_LockingClient = 6106;

        /// <remarks />
        public const uint ControlGroupType_ControlGroup_ListToBlock_Lock_LockingUser = 6107;

        /// <remarks />
        public const uint ControlGroupType_ControlGroup_ListToBlock_Lock_RemainingLockTime = 6108;

        /// <remarks />
        public const uint ControlGroupType_ControlGroup_ListToBlock_Lock_InitLock_InputArguments = 6103;

        /// <remarks />
        public const uint ControlGroupType_ControlGroup_ListToBlock_Lock_InitLock_OutputArguments = 6104;

        /// <remarks />
        public const uint ControlGroupType_ControlGroup_ListToBlock_Lock_RenewLock_OutputArguments = 6109;

        /// <remarks />
        public const uint ControlGroupType_ControlGroup_ListToBlock_Lock_ExitLock_OutputArguments = 6102;

        /// <remarks />
        public const uint ControlGroupType_ControlGroup_ListToBlock_Lock_BreakLock_OutputArguments = 6090;

        /// <remarks />
        public const uint ControlGroupType_ControlGroup_ListToRestrict_Lock_Locked = 6114;

        /// <remarks />
        public const uint ControlGroupType_ControlGroup_ListToRestrict_Lock_LockingClient = 6115;

        /// <remarks />
        public const uint ControlGroupType_ControlGroup_ListToRestrict_Lock_LockingUser = 6116;

        /// <remarks />
        public const uint ControlGroupType_ControlGroup_ListToRestrict_Lock_RemainingLockTime = 6117;

        /// <remarks />
        public const uint ControlGroupType_ControlGroup_ListToRestrict_Lock_InitLock_InputArguments = 6112;

        /// <remarks />
        public const uint ControlGroupType_ControlGroup_ListToRestrict_Lock_InitLock_OutputArguments = 6113;

        /// <remarks />
        public const uint ControlGroupType_ControlGroup_ListToRestrict_Lock_RenewLock_OutputArguments = 6118;

        /// <remarks />
        public const uint ControlGroupType_ControlGroup_ListToRestrict_Lock_ExitLock_OutputArguments = 6111;

        /// <remarks />
        public const uint ControlGroupType_ControlGroup_ListToRestrict_Lock_BreakLock_OutputArguments = 6110;

        /// <remarks />
        public const uint ControlGroupType_ControlGroup_ReassignControl_InputArguments = 6366;

        /// <remarks />
        public const uint ControlGroupType_ControlGroup_ReassignControl_OutputArguments = 6367;

        /// <remarks />
        public const uint ControlGroupType_EstablishControl_InputArguments = 6093;

        /// <remarks />
        public const uint ControlGroupType_EstablishControl_OutputArguments = 6094;

        /// <remarks />
        public const uint ControlGroupType_IsControlled = 6095;

        /// <remarks />
        public const uint ControlGroupType_ListToBlock_Lock_Locked = 6271;

        /// <remarks />
        public const uint ControlGroupType_ListToBlock_Lock_LockingClient = 6272;

        /// <remarks />
        public const uint ControlGroupType_ListToBlock_Lock_LockingUser = 6273;

        /// <remarks />
        public const uint ControlGroupType_ListToBlock_Lock_RemainingLockTime = 6274;

        /// <remarks />
        public const uint ControlGroupType_ListToBlock_Lock_InitLock_InputArguments = 6265;

        /// <remarks />
        public const uint ControlGroupType_ListToBlock_Lock_InitLock_OutputArguments = 6266;

        /// <remarks />
        public const uint ControlGroupType_ListToBlock_Lock_RenewLock_OutputArguments = 6275;

        /// <remarks />
        public const uint ControlGroupType_ListToBlock_Lock_ExitLock_OutputArguments = 6264;

        /// <remarks />
        public const uint ControlGroupType_ListToBlock_Lock_BreakLock_OutputArguments = 6253;

        /// <remarks />
        public const uint ControlGroupType_ListToRestrict_Lock_Locked = 6317;

        /// <remarks />
        public const uint ControlGroupType_ListToRestrict_Lock_LockingClient = 6368;

        /// <remarks />
        public const uint ControlGroupType_ListToRestrict_Lock_LockingUser = 6369;

        /// <remarks />
        public const uint ControlGroupType_ListToRestrict_Lock_RemainingLockTime = 6370;

        /// <remarks />
        public const uint ControlGroupType_ListToRestrict_Lock_InitLock_InputArguments = 6313;

        /// <remarks />
        public const uint ControlGroupType_ListToRestrict_Lock_InitLock_OutputArguments = 6314;

        /// <remarks />
        public const uint ControlGroupType_ListToRestrict_Lock_RenewLock_OutputArguments = 6371;

        /// <remarks />
        public const uint ControlGroupType_ListToRestrict_Lock_ExitLock_OutputArguments = 6312;

        /// <remarks />
        public const uint ControlGroupType_ListToRestrict_Lock_BreakLock_OutputArguments = 6306;

        /// <remarks />
        public const uint ControlGroupType_ReassignControl_InputArguments = 6366;

        /// <remarks />
        public const uint ControlGroupType_ReassignControl_OutputArguments = 6367;

        /// <remarks />
        public const uint AutomationComponentCapabilitiesType_Capability = 1249;

        /// <remarks />
        public const uint AutomationComponentCapabilitiesType_CommandBundleRequired = 6077;

        /// <remarks />
        public const uint AutomationComponentCapabilitiesType_MaxConnections = 6358;

        /// <remarks />
        public const uint AutomationComponentCapabilitiesType_MaxConnectionsPerCall = 6076;

        /// <remarks />
        public const uint AutomationComponentCapabilitiesType_MaxFunctionalEntities = 6357;

        /// <remarks />
        public const uint AutomationComponentCapabilitiesType_SupportsPersistence = 6356;

        /// <remarks />
        public const uint ConnectionEndpointsFolderType_ConnectionEndpoint_CleanupTimeout = 6073;

        /// <remarks />
        public const uint ConnectionEndpointsFolderType_ConnectionEndpoint_IsPersistent = 1309;

        /// <remarks />
        public const uint ConnectionEndpointsFolderType_ConnectionEndpoint_RelatedEndpoint = 6092;

        /// <remarks />
        public const uint ConnectionEndpointsFolderType_ConnectionEndpoint_Status = 1331;

        /// <remarks />
        public const uint ConnectionEndpointsFolderType_CommHealth = 6096;

        /// <remarks />
        public const uint ControlGroupsFolderType_ControlGroup_EstablishControl_InputArguments = 6093;

        /// <remarks />
        public const uint ControlGroupsFolderType_ControlGroup_EstablishControl_OutputArguments = 6094;

        /// <remarks />
        public const uint ControlGroupsFolderType_ControlGroup_IsControlled = 6365;

        /// <remarks />
        public const uint ControlGroupsFolderType_ControlGroup_ListToBlock_Lock_Locked = 6461;

        /// <remarks />
        public const uint ControlGroupsFolderType_ControlGroup_ListToBlock_Lock_LockingClient = 6462;

        /// <remarks />
        public const uint ControlGroupsFolderType_ControlGroup_ListToBlock_Lock_LockingUser = 6463;

        /// <remarks />
        public const uint ControlGroupsFolderType_ControlGroup_ListToBlock_Lock_RemainingLockTime = 6464;

        /// <remarks />
        public const uint ControlGroupsFolderType_ControlGroup_ListToBlock_Lock_InitLock_InputArguments = 6459;

        /// <remarks />
        public const uint ControlGroupsFolderType_ControlGroup_ListToBlock_Lock_InitLock_OutputArguments = 6460;

        /// <remarks />
        public const uint ControlGroupsFolderType_ControlGroup_ListToBlock_Lock_RenewLock_OutputArguments = 6465;

        /// <remarks />
        public const uint ControlGroupsFolderType_ControlGroup_ListToBlock_Lock_ExitLock_OutputArguments = 6458;

        /// <remarks />
        public const uint ControlGroupsFolderType_ControlGroup_ListToBlock_Lock_BreakLock_OutputArguments = 6457;

        /// <remarks />
        public const uint ControlGroupsFolderType_ControlGroup_ListToRestrict_Lock_Locked = 6470;

        /// <remarks />
        public const uint ControlGroupsFolderType_ControlGroup_ListToRestrict_Lock_LockingClient = 6471;

        /// <remarks />
        public const uint ControlGroupsFolderType_ControlGroup_ListToRestrict_Lock_LockingUser = 6472;

        /// <remarks />
        public const uint ControlGroupsFolderType_ControlGroup_ListToRestrict_Lock_RemainingLockTime = 6473;

        /// <remarks />
        public const uint ControlGroupsFolderType_ControlGroup_ListToRestrict_Lock_InitLock_InputArguments = 6468;

        /// <remarks />
        public const uint ControlGroupsFolderType_ControlGroup_ListToRestrict_Lock_InitLock_OutputArguments = 6469;

        /// <remarks />
        public const uint ControlGroupsFolderType_ControlGroup_ListToRestrict_Lock_RenewLock_OutputArguments = 6474;

        /// <remarks />
        public const uint ControlGroupsFolderType_ControlGroup_ListToRestrict_Lock_ExitLock_OutputArguments = 6467;

        /// <remarks />
        public const uint ControlGroupsFolderType_ControlGroup_ListToRestrict_Lock_BreakLock_OutputArguments = 6466;

        /// <remarks />
        public const uint ControlGroupsFolderType_ControlGroup_ReassignControl_InputArguments = 6366;

        /// <remarks />
        public const uint ControlGroupsFolderType_ControlGroup_ReassignControl_OutputArguments = 6367;

        /// <remarks />
        public const uint FunctionalEntityCapabilitiesType_Capability = 6120;

        /// <remarks />
        public const uint FunctionalEntityCapabilitiesType_FeedbackSignalRequired = 6119;

        /// <remarks />
        public const uint ConfigurationDataFolderType_ConfigurationVariable = 6049;

        /// <remarks />
        public const uint ConfigurationDataFolderType_ClearStoredVariables_InputArguments = 6398;

        /// <remarks />
        public const uint ConfigurationDataFolderType_ClearStoredVariables_OutputArguments = 6399;

        /// <remarks />
        public const uint ConfigurationDataFolderType_ListStoredVariables_OutputArguments = 6401;

        /// <remarks />
        public const uint ConfigurationDataFolderType_SetStoredVariables_InputArguments = 6396;

        /// <remarks />
        public const uint ConfigurationDataFolderType_SetStoredVariables_OutputArguments = 6397;

        /// <remarks />
        public const uint ControlItemFolderType_Lock_Locked = 6248;

        /// <remarks />
        public const uint ControlItemFolderType_Lock_LockingClient = 6249;

        /// <remarks />
        public const uint ControlItemFolderType_Lock_LockingUser = 6250;

        /// <remarks />
        public const uint ControlItemFolderType_Lock_RemainingLockTime = 6251;

        /// <remarks />
        public const uint ControlItemFolderType_Lock_InitLock_InputArguments = 6246;

        /// <remarks />
        public const uint ControlItemFolderType_Lock_InitLock_OutputArguments = 6247;

        /// <remarks />
        public const uint ControlItemFolderType_Lock_RenewLock_OutputArguments = 6252;

        /// <remarks />
        public const uint ControlItemFolderType_Lock_ExitLock_OutputArguments = 6245;

        /// <remarks />
        public const uint ControlItemFolderType_Lock_BreakLock_OutputArguments = 6091;

        /// <remarks />
        public const uint ControlItemFolderType_MaxInactiveLockTime = 6485;

        /// <remarks />
        public const uint InputsFolderType_InputGroup_SubscriberCapabilities_PreconfiguredDataSetOnly = 6064;

        /// <remarks />
        public const uint InputsFolderType_InputGroup_SubscriberCapabilities_PreconfiguredSubscribedDataSets = 6065;

        /// <remarks />
        public const uint InputsFolderType_InputGroup_SubscriberCapabilities_SupportedMessageReceiveTimeouts = 6066;

        /// <remarks />
        public const uint InputsFolderType_InputGroup_SubscriberCapabilities_SupportedPublishingIntervals = 6067;

        /// <remarks />
        public const uint InputsFolderType_InputGroup_SubscriberCapabilities_SupportedQos = 6068;

        /// <remarks />
        public const uint InputsFolderType_InputVariable = 1319;

        /// <remarks />
        public const uint InputsFolderType_SubscriberCapabilities_PreconfiguredDataSetOnly = 6064;

        /// <remarks />
        public const uint InputsFolderType_SubscriberCapabilities_PreconfiguredSubscribedDataSets = 6065;

        /// <remarks />
        public const uint InputsFolderType_SubscriberCapabilities_SupportedMessageReceiveTimeouts = 6066;

        /// <remarks />
        public const uint InputsFolderType_SubscriberCapabilities_SupportedPublishingIntervals = 6067;

        /// <remarks />
        public const uint InputsFolderType_SubscriberCapabilities_SupportedQos = 6068;

        /// <remarks />
        public const uint OutputsFolderType_OutputGroup_PublisherCapabilities_PreconfiguredDataSetOnly = 6097;

        /// <remarks />
        public const uint OutputsFolderType_OutputGroup_PublisherCapabilities_PreconfiguredPublishedDataSets = 6098;

        /// <remarks />
        public const uint OutputsFolderType_OutputGroup_PublisherCapabilities_SupportedPublishingIntervals = 6099;

        /// <remarks />
        public const uint OutputsFolderType_OutputGroup_PublisherCapabilities_SupportedQos = 6100;

        /// <remarks />
        public const uint OutputsFolderType_OutputVariable = 1425;

        /// <remarks />
        public const uint OutputsFolderType_PublisherCapabilities_PreconfiguredDataSetOnly = 6097;

        /// <remarks />
        public const uint OutputsFolderType_PublisherCapabilities_PreconfiguredPublishedDataSets = 6098;

        /// <remarks />
        public const uint OutputsFolderType_PublisherCapabilities_SupportedPublishingIntervals = 6099;

        /// <remarks />
        public const uint OutputsFolderType_PublisherCapabilities_SupportedQos = 6100;

        /// <remarks />
        public const uint FunctionalEntityType_SubFunctionalEntity_ApplicationIdentifier = 205;

        /// <remarks />
        public const uint FunctionalEntityType_SubFunctionalEntity_AuthorAssignedIdentifier = 203;

        /// <remarks />
        public const uint FunctionalEntityType_SubFunctionalEntity_AuthorAssignedVersion = 204;

        /// <remarks />
        public const uint FunctionalEntityType_SubFunctionalEntity_AuthorUri = 202;

        /// <remarks />
        public const uint FunctionalEntityType_SubFunctionalEntity_Capabilities_FeedbackSignalRequired = 6122;

        /// <remarks />
        public const uint FunctionalEntityType_SubFunctionalEntity_ConfigurationData_ClearStoredVariables_InputArguments = 6398;

        /// <remarks />
        public const uint FunctionalEntityType_SubFunctionalEntity_ConfigurationData_ClearStoredVariables_OutputArguments = 6399;

        /// <remarks />
        public const uint FunctionalEntityType_SubFunctionalEntity_ConfigurationData_ListStoredVariables_OutputArguments = 6401;

        /// <remarks />
        public const uint FunctionalEntityType_SubFunctionalEntity_ConfigurationData_SetStoredVariables_InputArguments = 6396;

        /// <remarks />
        public const uint FunctionalEntityType_SubFunctionalEntity_ConfigurationData_SetStoredVariables_OutputArguments = 6397;

        /// <remarks />
        public const uint FunctionalEntityType_SubFunctionalEntity_InputData_SubscriberCapabilities_PreconfiguredDataSetOnly = 6064;

        /// <remarks />
        public const uint FunctionalEntityType_SubFunctionalEntity_InputData_SubscriberCapabilities_PreconfiguredSubscribedDataSets = 6065;

        /// <remarks />
        public const uint FunctionalEntityType_SubFunctionalEntity_InputData_SubscriberCapabilities_SupportedMessageReceiveTimeouts = 6066;

        /// <remarks />
        public const uint FunctionalEntityType_SubFunctionalEntity_InputData_SubscriberCapabilities_SupportedPublishingIntervals = 6067;

        /// <remarks />
        public const uint FunctionalEntityType_SubFunctionalEntity_InputData_SubscriberCapabilities_SupportedQos = 6068;

        /// <remarks />
        public const uint FunctionalEntityType_SubFunctionalEntity_OperationalHealth = 6056;

        /// <remarks />
        public const uint FunctionalEntityType_SubFunctionalEntity_OutputData_PublisherCapabilities_PreconfiguredDataSetOnly = 6097;

        /// <remarks />
        public const uint FunctionalEntityType_SubFunctionalEntity_OutputData_PublisherCapabilities_PreconfiguredPublishedDataSets = 6098;

        /// <remarks />
        public const uint FunctionalEntityType_SubFunctionalEntity_OutputData_PublisherCapabilities_SupportedPublishingIntervals = 6099;

        /// <remarks />
        public const uint FunctionalEntityType_SubFunctionalEntity_OutputData_PublisherCapabilities_SupportedQos = 6100;

        /// <remarks />
        public const uint FunctionalEntityType_SubFunctionalEntity_PublisherCapabilities_PreconfiguredDataSetOnly = 6054;

        /// <remarks />
        public const uint FunctionalEntityType_SubFunctionalEntity_PublisherCapabilities_PreconfiguredPublishedDataSets = 6057;

        /// <remarks />
        public const uint FunctionalEntityType_SubFunctionalEntity_PublisherCapabilities_SupportedPublishingIntervals = 6058;

        /// <remarks />
        public const uint FunctionalEntityType_SubFunctionalEntity_PublisherCapabilities_SupportedQos = 6059;

        /// <remarks />
        public const uint FunctionalEntityType_SubFunctionalEntity_SubscriberCapabilities_PreconfiguredDataSetOnly = 6055;

        /// <remarks />
        public const uint FunctionalEntityType_SubFunctionalEntity_SubscriberCapabilities_PreconfiguredSubscribedDataSets = 6060;

        /// <remarks />
        public const uint FunctionalEntityType_SubFunctionalEntity_SubscriberCapabilities_SupportedMessageReceiveTimeouts = 6061;

        /// <remarks />
        public const uint FunctionalEntityType_SubFunctionalEntity_SubscriberCapabilities_SupportedPublishingIntervals = 6062;

        /// <remarks />
        public const uint FunctionalEntityType_SubFunctionalEntity_SubscriberCapabilities_SupportedQos = 6063;

        /// <remarks />
        public const uint FunctionalEntityType_SubFunctionalEntity_Verify_InputArguments = 1358;

        /// <remarks />
        public const uint FunctionalEntityType_SubFunctionalEntity_Verify_OutputArguments = 1359;

        /// <remarks />
        public const uint FunctionalEntityType_ApplicationIdentifier = 205;

        /// <remarks />
        public const uint FunctionalEntityType_AuthorAssignedIdentifier = 203;

        /// <remarks />
        public const uint FunctionalEntityType_AuthorAssignedVersion = 204;

        /// <remarks />
        public const uint FunctionalEntityType_AuthorUri = 202;

        /// <remarks />
        public const uint FunctionalEntityType_Capabilities_FeedbackSignalRequired = 6122;

        /// <remarks />
        public const uint FunctionalEntityType_ConfigurationData_ClearStoredVariables_InputArguments = 6398;

        /// <remarks />
        public const uint FunctionalEntityType_ConfigurationData_ClearStoredVariables_OutputArguments = 6399;

        /// <remarks />
        public const uint FunctionalEntityType_ConfigurationData_ListStoredVariables_OutputArguments = 6401;

        /// <remarks />
        public const uint FunctionalEntityType_ConfigurationData_SetStoredVariables_InputArguments = 6396;

        /// <remarks />
        public const uint FunctionalEntityType_ConfigurationData_SetStoredVariables_OutputArguments = 6397;

        /// <remarks />
        public const uint FunctionalEntityType_InputData_SubscriberCapabilities_PreconfiguredDataSetOnly = 6064;

        /// <remarks />
        public const uint FunctionalEntityType_InputData_SubscriberCapabilities_PreconfiguredSubscribedDataSets = 6065;

        /// <remarks />
        public const uint FunctionalEntityType_InputData_SubscriberCapabilities_SupportedMessageReceiveTimeouts = 6066;

        /// <remarks />
        public const uint FunctionalEntityType_InputData_SubscriberCapabilities_SupportedPublishingIntervals = 6067;

        /// <remarks />
        public const uint FunctionalEntityType_InputData_SubscriberCapabilities_SupportedQos = 6068;

        /// <remarks />
        public const uint FunctionalEntityType_OperationalHealth = 6056;

        /// <remarks />
        public const uint FunctionalEntityType_OutputData_PublisherCapabilities_PreconfiguredDataSetOnly = 6097;

        /// <remarks />
        public const uint FunctionalEntityType_OutputData_PublisherCapabilities_PreconfiguredPublishedDataSets = 6098;

        /// <remarks />
        public const uint FunctionalEntityType_OutputData_PublisherCapabilities_SupportedPublishingIntervals = 6099;

        /// <remarks />
        public const uint FunctionalEntityType_OutputData_PublisherCapabilities_SupportedQos = 6100;

        /// <remarks />
        public const uint FunctionalEntityType_PublisherCapabilities_PreconfiguredDataSetOnly = 6054;

        /// <remarks />
        public const uint FunctionalEntityType_PublisherCapabilities_PreconfiguredPublishedDataSets = 6057;

        /// <remarks />
        public const uint FunctionalEntityType_PublisherCapabilities_SupportedPublishingIntervals = 6058;

        /// <remarks />
        public const uint FunctionalEntityType_PublisherCapabilities_SupportedQos = 6059;

        /// <remarks />
        public const uint FunctionalEntityType_SubscriberCapabilities_PreconfiguredDataSetOnly = 6055;

        /// <remarks />
        public const uint FunctionalEntityType_SubscriberCapabilities_PreconfiguredSubscribedDataSets = 6060;

        /// <remarks />
        public const uint FunctionalEntityType_SubscriberCapabilities_SupportedMessageReceiveTimeouts = 6061;

        /// <remarks />
        public const uint FunctionalEntityType_SubscriberCapabilities_SupportedPublishingIntervals = 6062;

        /// <remarks />
        public const uint FunctionalEntityType_SubscriberCapabilities_SupportedQos = 6063;

        /// <remarks />
        public const uint FunctionalEntityType_Verify_InputArguments = 1358;

        /// <remarks />
        public const uint FunctionalEntityType_Verify_OutputArguments = 1359;

        /// <remarks />
        public const uint FxAssetType_AssetId = 195;

        /// <remarks />
        public const uint FxAssetType_BuildAssetNumber = 198;

        /// <remarks />
        public const uint FxAssetType_ComponentName = 184;

        /// <remarks />
        public const uint FxAssetType_Connectors_AssetConnector_Name = 1253;

        /// <remarks />
        public const uint FxAssetType_DeviceClass = 191;

        /// <remarks />
        public const uint FxAssetType_DeviceHealth = 6081;

        /// <remarks />
        public const uint FxAssetType_DeviceManual = 190;

        /// <remarks />
        public const uint FxAssetType_DeviceRevision = 189;

        /// <remarks />
        public const uint FxAssetType_HardwareRevision = 187;

        /// <remarks />
        public const uint FxAssetType_MajorAssetVersion = 196;

        /// <remarks />
        public const uint FxAssetType_Manufacturer = 175;

        /// <remarks />
        public const uint FxAssetType_ManufacturerUri = 185;

        /// <remarks />
        public const uint FxAssetType_MinorAssetVersion = 197;

        /// <remarks />
        public const uint FxAssetType_Model = 176;

        /// <remarks />
        public const uint FxAssetType_ProductCode = 186;

        /// <remarks />
        public const uint FxAssetType_ProductInstanceUri = 193;

        /// <remarks />
        public const uint FxAssetType_RevisionCounter = 194;

        /// <remarks />
        public const uint FxAssetType_SerialNumber = 192;

        /// <remarks />
        public const uint FxAssetType_SoftwareRevision = 188;

        /// <remarks />
        public const uint FxAssetType_SoftwareUpdate_PrepareForUpdate_CurrentState = 5;

        /// <remarks />
        public const uint FxAssetType_SoftwareUpdate_PrepareForUpdate_CurrentState_Id = 6;

        /// <remarks />
        public const uint FxAssetType_SoftwareUpdate_Installation_CurrentState = 41;

        /// <remarks />
        public const uint FxAssetType_SoftwareUpdate_Installation_CurrentState_Id = 42;

        /// <remarks />
        public const uint FxAssetType_SoftwareUpdate_Installation_InstallSoftwarePackage_InputArguments = 266;

        /// <remarks />
        public const uint FxAssetType_SoftwareUpdate_Installation_InstallFiles_InputArguments = 269;

        /// <remarks />
        public const uint FxAssetType_SoftwareUpdate_PowerCycle_CurrentState = 77;

        /// <remarks />
        public const uint FxAssetType_SoftwareUpdate_PowerCycle_CurrentState_Id = 78;

        /// <remarks />
        public const uint FxAssetType_SoftwareUpdate_Confirmation_CurrentState = 99;

        /// <remarks />
        public const uint FxAssetType_SoftwareUpdate_Confirmation_CurrentState_Id = 100;

        /// <remarks />
        public const uint FxAssetType_SoftwareUpdate_Confirmation_ConfirmationTimeout = 113;

        /// <remarks />
        public const uint FxAssetType_SoftwareUpdate_Parameters_ClientProcessingTimeout = 123;

        /// <remarks />
        public const uint FxAssetType_SoftwareUpdate_Parameters_GenerateFileForRead_InputArguments = 125;

        /// <remarks />
        public const uint FxAssetType_SoftwareUpdate_Parameters_GenerateFileForRead_OutputArguments = 126;

        /// <remarks />
        public const uint FxAssetType_SoftwareUpdate_Parameters_GenerateFileForWrite_InputArguments = 128;

        /// <remarks />
        public const uint FxAssetType_SoftwareUpdate_Parameters_GenerateFileForWrite_OutputArguments = 129;

        /// <remarks />
        public const uint FxAssetType_SoftwareUpdate_Parameters_CloseAndCommit_InputArguments = 131;

        /// <remarks />
        public const uint FxAssetType_SoftwareUpdate_Parameters_CloseAndCommit_OutputArguments = 132;

        /// <remarks />
        public const uint FxAssetType_SubBuildAssetNumber = 199;

        /// <remarks />
        public const uint FxAssetType_VerifyAsset_InputArguments = 1356;

        /// <remarks />
        public const uint FxAssetType_VerifyAsset_OutputArguments = 1357;

        /// <remarks />
        public const uint PublisherCapabilitiesType_PreconfiguredDataSetOnly = 6023;

        /// <remarks />
        public const uint PublisherCapabilitiesType_PreconfiguredPublishedDataSets = 6022;

        /// <remarks />
        public const uint PublisherCapabilitiesType_SupportedPublishingIntervals = 6020;

        /// <remarks />
        public const uint PublisherCapabilitiesType_SupportedQos = 6021;

        /// <remarks />
        public const uint SubscriberCapabilitiesType_PreconfiguredDataSetOnly = 6028;

        /// <remarks />
        public const uint SubscriberCapabilitiesType_PreconfiguredSubscribedDataSets = 6027;

        /// <remarks />
        public const uint SubscriberCapabilitiesType_SupportedMessageReceiveTimeouts = 6026;

        /// <remarks />
        public const uint SubscriberCapabilitiesType_SupportedPublishingIntervals = 6024;

        /// <remarks />
        public const uint SubscriberCapabilitiesType_SupportedQos = 6025;

        /// <remarks />
        public const uint http___opcfoundation_org_UA_FX_AC__NamespaceUri = 6003;

        /// <remarks />
        public const uint http___opcfoundation_org_UA_FX_AC__NamespaceVersion = 6004;

        /// <remarks />
        public const uint http___opcfoundation_org_UA_FX_AC__NamespacePublicationDate = 6002;

        /// <remarks />
        public const uint http___opcfoundation_org_UA_FX_AC__IsNamespaceSubset = 6001;

        /// <remarks />
        public const uint http___opcfoundation_org_UA_FX_AC__StaticNodeIdTypes = 6005;

        /// <remarks />
        public const uint http___opcfoundation_org_UA_FX_AC__StaticNumericNodeIdRange = 6006;

        /// <remarks />
        public const uint http___opcfoundation_org_UA_FX_AC__StaticStringNodeIdPattern = 6007;
    }
    #endregion

    #region VariableType Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class VariableTypes
    {
        /// <remarks />
        public const uint AggregatedHealthType = 2001;
    }
    #endregion

    #region DataType Node Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class DataTypeIds
    {
        /// <remarks />
        public static readonly ExpandedNodeId ClampKindEnum = new ExpandedNodeId(UAModel.FXAC.DataTypes.ClampKindEnum, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId ConnectionEndpointStatusEnum = new ExpandedNodeId(UAModel.FXAC.DataTypes.ConnectionEndpointStatusEnum, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId FxTimeUnitsEnum = new ExpandedNodeId(UAModel.FXAC.DataTypes.FxTimeUnitsEnum, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId SocketKindEnum = new ExpandedNodeId(UAModel.FXAC.DataTypes.SocketKindEnum, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId CommHealthOptionSet = new ExpandedNodeId(UAModel.FXAC.DataTypes.CommHealthOptionSet, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId DeviceHealthOptionSet = new ExpandedNodeId(UAModel.FXAC.DataTypes.DeviceHealthOptionSet, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId OperationalHealthOptionSet = new ExpandedNodeId(UAModel.FXAC.DataTypes.OperationalHealthOptionSet, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId AggregatedHealthDataType = new ExpandedNodeId(UAModel.FXAC.DataTypes.AggregatedHealthDataType, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId ApplicationIdentifierDataType = new ExpandedNodeId(UAModel.FXAC.DataTypes.ApplicationIdentifierDataType, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId FxVersion = new ExpandedNodeId(UAModel.FXAC.DataTypes.FxVersion, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId IntervalRange = new ExpandedNodeId(UAModel.FXAC.DataTypes.IntervalRange, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId PublisherQosDataType = new ExpandedNodeId(UAModel.FXAC.DataTypes.PublisherQosDataType, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId SubscriberQosDataType = new ExpandedNodeId(UAModel.FXAC.DataTypes.SubscriberQosDataType, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId ApplicationId = new ExpandedNodeId(UAModel.FXAC.DataTypes.ApplicationId, UAModel.FXAC.Namespaces.FXAC);
    }
    #endregion

    #region Method Node Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class MethodIds
    {
        /// <remarks />
        public static readonly ExpandedNodeId AcDescriptorType_DescriptorFile_Open = new ExpandedNodeId(UAModel.FXAC.Methods.AcDescriptorType_DescriptorFile_Open, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId AcDescriptorType_DescriptorFile_Close = new ExpandedNodeId(UAModel.FXAC.Methods.AcDescriptorType_DescriptorFile_Close, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId AcDescriptorType_DescriptorFile_Read = new ExpandedNodeId(UAModel.FXAC.Methods.AcDescriptorType_DescriptorFile_Read, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId AcDescriptorType_DescriptorFile_Write = new ExpandedNodeId(UAModel.FXAC.Methods.AcDescriptorType_DescriptorFile_Write, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId AcDescriptorType_DescriptorFile_GetPosition = new ExpandedNodeId(UAModel.FXAC.Methods.AcDescriptorType_DescriptorFile_GetPosition, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId AcDescriptorType_DescriptorFile_SetPosition = new ExpandedNodeId(UAModel.FXAC.Methods.AcDescriptorType_DescriptorFile_SetPosition, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId AutomationComponentType_Assets_Asset_SoftwareUpdate_PrepareForUpdate_Prepare = new ExpandedNodeId(UAModel.FXAC.Methods.AutomationComponentType_Assets_Asset_SoftwareUpdate_PrepareForUpdate_Prepare, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId AutomationComponentType_Assets_Asset_SoftwareUpdate_PrepareForUpdate_Abort = new ExpandedNodeId(UAModel.FXAC.Methods.AutomationComponentType_Assets_Asset_SoftwareUpdate_PrepareForUpdate_Abort, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId AutomationComponentType_Assets_Asset_SoftwareUpdate_Installation_Resume = new ExpandedNodeId(UAModel.FXAC.Methods.AutomationComponentType_Assets_Asset_SoftwareUpdate_Installation_Resume, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId AutomationComponentType_Assets_Asset_SoftwareUpdate_Confirmation_Confirm = new ExpandedNodeId(UAModel.FXAC.Methods.AutomationComponentType_Assets_Asset_SoftwareUpdate_Confirmation_Confirm, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId AutomationComponentType_Assets_Asset_SoftwareUpdate_Parameters_GenerateFileForRead = new ExpandedNodeId(UAModel.FXAC.Methods.AutomationComponentType_Assets_Asset_SoftwareUpdate_Parameters_GenerateFileForRead, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId AutomationComponentType_Assets_Asset_SoftwareUpdate_Parameters_GenerateFileForWrite = new ExpandedNodeId(UAModel.FXAC.Methods.AutomationComponentType_Assets_Asset_SoftwareUpdate_Parameters_GenerateFileForWrite, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId AutomationComponentType_Assets_Asset_SoftwareUpdate_Parameters_CloseAndCommit = new ExpandedNodeId(UAModel.FXAC.Methods.AutomationComponentType_Assets_Asset_SoftwareUpdate_Parameters_CloseAndCommit, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId AutomationComponentType_CloseConnections = new ExpandedNodeId(UAModel.FXAC.Methods.AutomationComponentType_CloseConnections, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId AutomationComponentType_EstablishConnections = new ExpandedNodeId(UAModel.FXAC.Methods.AutomationComponentType_EstablishConnections, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId IAssetRevisionType_VerifyAsset = new ExpandedNodeId(UAModel.FXAC.Methods.IAssetRevisionType_VerifyAsset, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId IFunctionalEntityType_Verify = new ExpandedNodeId(UAModel.FXAC.Methods.IFunctionalEntityType_Verify, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId ControlGroupType_ControlGroup_EstablishControl = new ExpandedNodeId(UAModel.FXAC.Methods.ControlGroupType_ControlGroup_EstablishControl, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId ControlGroupType_ControlGroup_ListToBlock_Lock_InitLock = new ExpandedNodeId(UAModel.FXAC.Methods.ControlGroupType_ControlGroup_ListToBlock_Lock_InitLock, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId ControlGroupType_ControlGroup_ListToBlock_Lock_RenewLock = new ExpandedNodeId(UAModel.FXAC.Methods.ControlGroupType_ControlGroup_ListToBlock_Lock_RenewLock, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId ControlGroupType_ControlGroup_ListToBlock_Lock_ExitLock = new ExpandedNodeId(UAModel.FXAC.Methods.ControlGroupType_ControlGroup_ListToBlock_Lock_ExitLock, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId ControlGroupType_ControlGroup_ListToBlock_Lock_BreakLock = new ExpandedNodeId(UAModel.FXAC.Methods.ControlGroupType_ControlGroup_ListToBlock_Lock_BreakLock, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId ControlGroupType_ControlGroup_ListToRestrict_Lock_InitLock = new ExpandedNodeId(UAModel.FXAC.Methods.ControlGroupType_ControlGroup_ListToRestrict_Lock_InitLock, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId ControlGroupType_ControlGroup_ListToRestrict_Lock_RenewLock = new ExpandedNodeId(UAModel.FXAC.Methods.ControlGroupType_ControlGroup_ListToRestrict_Lock_RenewLock, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId ControlGroupType_ControlGroup_ListToRestrict_Lock_ExitLock = new ExpandedNodeId(UAModel.FXAC.Methods.ControlGroupType_ControlGroup_ListToRestrict_Lock_ExitLock, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId ControlGroupType_ControlGroup_ListToRestrict_Lock_BreakLock = new ExpandedNodeId(UAModel.FXAC.Methods.ControlGroupType_ControlGroup_ListToRestrict_Lock_BreakLock, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId ControlGroupType_ControlGroup_ReassignControl = new ExpandedNodeId(UAModel.FXAC.Methods.ControlGroupType_ControlGroup_ReassignControl, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId ControlGroupType_ControlGroup_ReleaseControl = new ExpandedNodeId(UAModel.FXAC.Methods.ControlGroupType_ControlGroup_ReleaseControl, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId ControlGroupType_EstablishControl = new ExpandedNodeId(UAModel.FXAC.Methods.ControlGroupType_EstablishControl, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId ControlGroupType_ListToBlock_Lock_InitLock = new ExpandedNodeId(UAModel.FXAC.Methods.ControlGroupType_ListToBlock_Lock_InitLock, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId ControlGroupType_ListToBlock_Lock_RenewLock = new ExpandedNodeId(UAModel.FXAC.Methods.ControlGroupType_ListToBlock_Lock_RenewLock, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId ControlGroupType_ListToBlock_Lock_ExitLock = new ExpandedNodeId(UAModel.FXAC.Methods.ControlGroupType_ListToBlock_Lock_ExitLock, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId ControlGroupType_ListToBlock_Lock_BreakLock = new ExpandedNodeId(UAModel.FXAC.Methods.ControlGroupType_ListToBlock_Lock_BreakLock, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId ControlGroupType_ListToRestrict_Lock_InitLock = new ExpandedNodeId(UAModel.FXAC.Methods.ControlGroupType_ListToRestrict_Lock_InitLock, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId ControlGroupType_ListToRestrict_Lock_RenewLock = new ExpandedNodeId(UAModel.FXAC.Methods.ControlGroupType_ListToRestrict_Lock_RenewLock, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId ControlGroupType_ListToRestrict_Lock_ExitLock = new ExpandedNodeId(UAModel.FXAC.Methods.ControlGroupType_ListToRestrict_Lock_ExitLock, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId ControlGroupType_ListToRestrict_Lock_BreakLock = new ExpandedNodeId(UAModel.FXAC.Methods.ControlGroupType_ListToRestrict_Lock_BreakLock, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId ControlGroupType_ReassignControl = new ExpandedNodeId(UAModel.FXAC.Methods.ControlGroupType_ReassignControl, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId ControlGroupType_ReleaseControl = new ExpandedNodeId(UAModel.FXAC.Methods.ControlGroupType_ReleaseControl, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId ControlGroupsFolderType_ControlGroup_ListToBlock_Lock_InitLock = new ExpandedNodeId(UAModel.FXAC.Methods.ControlGroupsFolderType_ControlGroup_ListToBlock_Lock_InitLock, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId ControlGroupsFolderType_ControlGroup_ListToBlock_Lock_RenewLock = new ExpandedNodeId(UAModel.FXAC.Methods.ControlGroupsFolderType_ControlGroup_ListToBlock_Lock_RenewLock, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId ControlGroupsFolderType_ControlGroup_ListToBlock_Lock_ExitLock = new ExpandedNodeId(UAModel.FXAC.Methods.ControlGroupsFolderType_ControlGroup_ListToBlock_Lock_ExitLock, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId ControlGroupsFolderType_ControlGroup_ListToBlock_Lock_BreakLock = new ExpandedNodeId(UAModel.FXAC.Methods.ControlGroupsFolderType_ControlGroup_ListToBlock_Lock_BreakLock, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId ControlGroupsFolderType_ControlGroup_ListToRestrict_Lock_InitLock = new ExpandedNodeId(UAModel.FXAC.Methods.ControlGroupsFolderType_ControlGroup_ListToRestrict_Lock_InitLock, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId ControlGroupsFolderType_ControlGroup_ListToRestrict_Lock_RenewLock = new ExpandedNodeId(UAModel.FXAC.Methods.ControlGroupsFolderType_ControlGroup_ListToRestrict_Lock_RenewLock, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId ControlGroupsFolderType_ControlGroup_ListToRestrict_Lock_ExitLock = new ExpandedNodeId(UAModel.FXAC.Methods.ControlGroupsFolderType_ControlGroup_ListToRestrict_Lock_ExitLock, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId ControlGroupsFolderType_ControlGroup_ListToRestrict_Lock_BreakLock = new ExpandedNodeId(UAModel.FXAC.Methods.ControlGroupsFolderType_ControlGroup_ListToRestrict_Lock_BreakLock, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId ConfigurationDataFolderType_ClearStoredVariables = new ExpandedNodeId(UAModel.FXAC.Methods.ConfigurationDataFolderType_ClearStoredVariables, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId ConfigurationDataFolderType_ListStoredVariables = new ExpandedNodeId(UAModel.FXAC.Methods.ConfigurationDataFolderType_ListStoredVariables, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId ConfigurationDataFolderType_SetStoredVariables = new ExpandedNodeId(UAModel.FXAC.Methods.ConfigurationDataFolderType_SetStoredVariables, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId ControlItemFolderType_Lock_InitLock = new ExpandedNodeId(UAModel.FXAC.Methods.ControlItemFolderType_Lock_InitLock, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId ControlItemFolderType_Lock_RenewLock = new ExpandedNodeId(UAModel.FXAC.Methods.ControlItemFolderType_Lock_RenewLock, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId ControlItemFolderType_Lock_ExitLock = new ExpandedNodeId(UAModel.FXAC.Methods.ControlItemFolderType_Lock_ExitLock, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId ControlItemFolderType_Lock_BreakLock = new ExpandedNodeId(UAModel.FXAC.Methods.ControlItemFolderType_Lock_BreakLock, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalEntityType_SubFunctionalEntity_Verify = new ExpandedNodeId(UAModel.FXAC.Methods.FunctionalEntityType_SubFunctionalEntity_Verify, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalEntityType_Verify = new ExpandedNodeId(UAModel.FXAC.Methods.FunctionalEntityType_Verify, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId FxAssetType_SoftwareUpdate_PrepareForUpdate_Prepare = new ExpandedNodeId(UAModel.FXAC.Methods.FxAssetType_SoftwareUpdate_PrepareForUpdate_Prepare, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId FxAssetType_SoftwareUpdate_PrepareForUpdate_Abort = new ExpandedNodeId(UAModel.FXAC.Methods.FxAssetType_SoftwareUpdate_PrepareForUpdate_Abort, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId FxAssetType_SoftwareUpdate_Installation_Resume = new ExpandedNodeId(UAModel.FXAC.Methods.FxAssetType_SoftwareUpdate_Installation_Resume, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId FxAssetType_SoftwareUpdate_Confirmation_Confirm = new ExpandedNodeId(UAModel.FXAC.Methods.FxAssetType_SoftwareUpdate_Confirmation_Confirm, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId FxAssetType_SoftwareUpdate_Parameters_GenerateFileForRead = new ExpandedNodeId(UAModel.FXAC.Methods.FxAssetType_SoftwareUpdate_Parameters_GenerateFileForRead, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId FxAssetType_SoftwareUpdate_Parameters_GenerateFileForWrite = new ExpandedNodeId(UAModel.FXAC.Methods.FxAssetType_SoftwareUpdate_Parameters_GenerateFileForWrite, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId FxAssetType_SoftwareUpdate_Parameters_CloseAndCommit = new ExpandedNodeId(UAModel.FXAC.Methods.FxAssetType_SoftwareUpdate_Parameters_CloseAndCommit, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId FxAssetType_VerifyAsset = new ExpandedNodeId(UAModel.FXAC.Methods.FxAssetType_VerifyAsset, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId AutomationComponentType_CloseConnectionsMethodType = new ExpandedNodeId(UAModel.FXAC.Methods.AutomationComponentType_CloseConnectionsMethodType, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId AutomationComponentType_EstablishConnectionsMethodType = new ExpandedNodeId(UAModel.FXAC.Methods.AutomationComponentType_EstablishConnectionsMethodType, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId IAssetRevisionType_VerifyAssetMethodType = new ExpandedNodeId(UAModel.FXAC.Methods.IAssetRevisionType_VerifyAssetMethodType, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId IFunctionalEntityType_VerifyMethodType = new ExpandedNodeId(UAModel.FXAC.Methods.IFunctionalEntityType_VerifyMethodType, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId ControlGroupType_EstablishControlMethodType = new ExpandedNodeId(UAModel.FXAC.Methods.ControlGroupType_EstablishControlMethodType, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId ControlGroupType_ReassignControlMethodType = new ExpandedNodeId(UAModel.FXAC.Methods.ControlGroupType_ReassignControlMethodType, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId ConfigurationDataFolderType_ClearStoredVariablesMethodType = new ExpandedNodeId(UAModel.FXAC.Methods.ConfigurationDataFolderType_ClearStoredVariablesMethodType, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId ConfigurationDataFolderType_ListStoredVariablesMethodType = new ExpandedNodeId(UAModel.FXAC.Methods.ConfigurationDataFolderType_ListStoredVariablesMethodType, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId ConfigurationDataFolderType_SetStoredVariablesMethodType = new ExpandedNodeId(UAModel.FXAC.Methods.ConfigurationDataFolderType_SetStoredVariablesMethodType, UAModel.FXAC.Namespaces.FXAC);
    }
    #endregion

    #region Object Node Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectIds
    {
        /// <remarks />
        public static readonly ExpandedNodeId AcDescriptorType_DescriptorFile = new ExpandedNodeId(UAModel.FXAC.Objects.AcDescriptorType_DescriptorFile, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId ClampBlockType_Clamp = new ExpandedNodeId(UAModel.FXAC.Objects.ClampBlockType_Clamp, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId AutomationComponentType_Assets = new ExpandedNodeId(UAModel.FXAC.Objects.AutomationComponentType_Assets, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId AutomationComponentType_Assets_Asset = new ExpandedNodeId(UAModel.FXAC.Objects.AutomationComponentType_Assets_Asset, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId AutomationComponentType_ComponentCapabilities = new ExpandedNodeId(UAModel.FXAC.Objects.AutomationComponentType_ComponentCapabilities, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId AutomationComponentType_Descriptors = new ExpandedNodeId(UAModel.FXAC.Objects.AutomationComponentType_Descriptors, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId AutomationComponentType_FunctionalEntities = new ExpandedNodeId(UAModel.FXAC.Objects.AutomationComponentType_FunctionalEntities, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId AutomationComponentType_FunctionalEntities_FunctionalEntity = new ExpandedNodeId(UAModel.FXAC.Objects.AutomationComponentType_FunctionalEntities_FunctionalEntity, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId AutomationComponentType_PublisherCapabilities = new ExpandedNodeId(UAModel.FXAC.Objects.AutomationComponentType_PublisherCapabilities, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId AutomationComponentType_SubscriberCapabilities = new ExpandedNodeId(UAModel.FXAC.Objects.AutomationComponentType_SubscriberCapabilities, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId IFunctionalEntityType_Capabilities = new ExpandedNodeId(UAModel.FXAC.Objects.IFunctionalEntityType_Capabilities, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId IFunctionalEntityType_ConfigurationData = new ExpandedNodeId(UAModel.FXAC.Objects.IFunctionalEntityType_ConfigurationData, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId IFunctionalEntityType_ConnectionEndpoints = new ExpandedNodeId(UAModel.FXAC.Objects.IFunctionalEntityType_ConnectionEndpoints, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId IFunctionalEntityType_ControlGroups = new ExpandedNodeId(UAModel.FXAC.Objects.IFunctionalEntityType_ControlGroups, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId IFunctionalEntityType_InputData = new ExpandedNodeId(UAModel.FXAC.Objects.IFunctionalEntityType_InputData, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId IFunctionalEntityType_OperationalHealthAlarms = new ExpandedNodeId(UAModel.FXAC.Objects.IFunctionalEntityType_OperationalHealthAlarms, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId IFunctionalEntityType_OutputData = new ExpandedNodeId(UAModel.FXAC.Objects.IFunctionalEntityType_OutputData, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId IFunctionalEntityType_PublisherCapabilities = new ExpandedNodeId(UAModel.FXAC.Objects.IFunctionalEntityType_PublisherCapabilities, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId IFunctionalEntityType_SubscriberCapabilities = new ExpandedNodeId(UAModel.FXAC.Objects.IFunctionalEntityType_SubscriberCapabilities, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId ControlGroupType_ControlGroup = new ExpandedNodeId(UAModel.FXAC.Objects.ControlGroupType_ControlGroup, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId ControlGroupType_ControlGroup_ListOfRelated = new ExpandedNodeId(UAModel.FXAC.Objects.ControlGroupType_ControlGroup_ListOfRelated, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId ControlGroupType_ControlGroup_ListToBlock = new ExpandedNodeId(UAModel.FXAC.Objects.ControlGroupType_ControlGroup_ListToBlock, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId ControlGroupType_ControlGroup_ListToBlock_Lock = new ExpandedNodeId(UAModel.FXAC.Objects.ControlGroupType_ControlGroup_ListToBlock_Lock, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId ControlGroupType_ControlGroup_ListToRestrict = new ExpandedNodeId(UAModel.FXAC.Objects.ControlGroupType_ControlGroup_ListToRestrict, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId ControlGroupType_ControlGroup_ListToRestrict_Lock = new ExpandedNodeId(UAModel.FXAC.Objects.ControlGroupType_ControlGroup_ListToRestrict_Lock, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId ControlGroupType_ListOfRelated = new ExpandedNodeId(UAModel.FXAC.Objects.ControlGroupType_ListOfRelated, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId ControlGroupType_ListToBlock = new ExpandedNodeId(UAModel.FXAC.Objects.ControlGroupType_ListToBlock, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId ControlGroupType_ListToBlock_Lock = new ExpandedNodeId(UAModel.FXAC.Objects.ControlGroupType_ListToBlock_Lock, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId ControlGroupType_ListToRestrict = new ExpandedNodeId(UAModel.FXAC.Objects.ControlGroupType_ListToRestrict, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId ControlGroupType_ListToRestrict_Lock = new ExpandedNodeId(UAModel.FXAC.Objects.ControlGroupType_ListToRestrict_Lock, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId ConnectionEndpointsFolderType_ConnectionEndpoint = new ExpandedNodeId(UAModel.FXAC.Objects.ConnectionEndpointsFolderType_ConnectionEndpoint, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId ControlGroupsFolderType_ControlGroup = new ExpandedNodeId(UAModel.FXAC.Objects.ControlGroupsFolderType_ControlGroup, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId ControlGroupsFolderType_ControlGroup_ListOfRelated = new ExpandedNodeId(UAModel.FXAC.Objects.ControlGroupsFolderType_ControlGroup_ListOfRelated, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId ControlGroupsFolderType_ControlGroup_ListToBlock = new ExpandedNodeId(UAModel.FXAC.Objects.ControlGroupsFolderType_ControlGroup_ListToBlock, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId ControlGroupsFolderType_ControlGroup_ListToBlock_Lock = new ExpandedNodeId(UAModel.FXAC.Objects.ControlGroupsFolderType_ControlGroup_ListToBlock_Lock, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId ControlGroupsFolderType_ControlGroup_ListToRestrict = new ExpandedNodeId(UAModel.FXAC.Objects.ControlGroupsFolderType_ControlGroup_ListToRestrict, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId ControlGroupsFolderType_ControlGroup_ListToRestrict_Lock = new ExpandedNodeId(UAModel.FXAC.Objects.ControlGroupsFolderType_ControlGroup_ListToRestrict_Lock, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId ControlItemFolderType_Lock = new ExpandedNodeId(UAModel.FXAC.Objects.ControlItemFolderType_Lock, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId InputsFolderType_InputGroup = new ExpandedNodeId(UAModel.FXAC.Objects.InputsFolderType_InputGroup, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId InputsFolderType_InputGroup_SubscriberCapabilities = new ExpandedNodeId(UAModel.FXAC.Objects.InputsFolderType_InputGroup_SubscriberCapabilities, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId InputsFolderType_SubscriberCapabilities = new ExpandedNodeId(UAModel.FXAC.Objects.InputsFolderType_SubscriberCapabilities, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId OutputsFolderType_OutputGroup = new ExpandedNodeId(UAModel.FXAC.Objects.OutputsFolderType_OutputGroup, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId OutputsFolderType_OutputGroup_PublisherCapabilities = new ExpandedNodeId(UAModel.FXAC.Objects.OutputsFolderType_OutputGroup_PublisherCapabilities, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId OutputsFolderType_PublisherCapabilities = new ExpandedNodeId(UAModel.FXAC.Objects.OutputsFolderType_PublisherCapabilities, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalEntityType_SubFunctionalEntity = new ExpandedNodeId(UAModel.FXAC.Objects.FunctionalEntityType_SubFunctionalEntity, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalEntityType_SubFunctionalEntity_Capabilities = new ExpandedNodeId(UAModel.FXAC.Objects.FunctionalEntityType_SubFunctionalEntity_Capabilities, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalEntityType_SubFunctionalEntity_ConfigurationData = new ExpandedNodeId(UAModel.FXAC.Objects.FunctionalEntityType_SubFunctionalEntity_ConfigurationData, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalEntityType_SubFunctionalEntity_ConnectionEndpoints = new ExpandedNodeId(UAModel.FXAC.Objects.FunctionalEntityType_SubFunctionalEntity_ConnectionEndpoints, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalEntityType_SubFunctionalEntity_ControlGroups = new ExpandedNodeId(UAModel.FXAC.Objects.FunctionalEntityType_SubFunctionalEntity_ControlGroups, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalEntityType_SubFunctionalEntity_InputData = new ExpandedNodeId(UAModel.FXAC.Objects.FunctionalEntityType_SubFunctionalEntity_InputData, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalEntityType_SubFunctionalEntity_OperationalHealthAlarms = new ExpandedNodeId(UAModel.FXAC.Objects.FunctionalEntityType_SubFunctionalEntity_OperationalHealthAlarms, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalEntityType_SubFunctionalEntity_OutputData = new ExpandedNodeId(UAModel.FXAC.Objects.FunctionalEntityType_SubFunctionalEntity_OutputData, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalEntityType_SubFunctionalEntity_PublisherCapabilities = new ExpandedNodeId(UAModel.FXAC.Objects.FunctionalEntityType_SubFunctionalEntity_PublisherCapabilities, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalEntityType_SubFunctionalEntity_SubscriberCapabilities = new ExpandedNodeId(UAModel.FXAC.Objects.FunctionalEntityType_SubFunctionalEntity_SubscriberCapabilities, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalEntityType_Capabilities = new ExpandedNodeId(UAModel.FXAC.Objects.FunctionalEntityType_Capabilities, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalEntityType_ConfigurationData = new ExpandedNodeId(UAModel.FXAC.Objects.FunctionalEntityType_ConfigurationData, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalEntityType_ConnectionEndpoints = new ExpandedNodeId(UAModel.FXAC.Objects.FunctionalEntityType_ConnectionEndpoints, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalEntityType_ControlGroups = new ExpandedNodeId(UAModel.FXAC.Objects.FunctionalEntityType_ControlGroups, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalEntityType_InputData = new ExpandedNodeId(UAModel.FXAC.Objects.FunctionalEntityType_InputData, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalEntityType_OperationalHealthAlarms = new ExpandedNodeId(UAModel.FXAC.Objects.FunctionalEntityType_OperationalHealthAlarms, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalEntityType_OutputData = new ExpandedNodeId(UAModel.FXAC.Objects.FunctionalEntityType_OutputData, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalEntityType_PublisherCapabilities = new ExpandedNodeId(UAModel.FXAC.Objects.FunctionalEntityType_PublisherCapabilities, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalEntityType_SubscriberCapabilities = new ExpandedNodeId(UAModel.FXAC.Objects.FunctionalEntityType_SubscriberCapabilities, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId FxAssetType_Connectors = new ExpandedNodeId(UAModel.FXAC.Objects.FxAssetType_Connectors, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId FxAssetType_Connectors_AssetConnector = new ExpandedNodeId(UAModel.FXAC.Objects.FxAssetType_Connectors_AssetConnector, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId FxAssetType_DeviceHealthAlarms = new ExpandedNodeId(UAModel.FXAC.Objects.FxAssetType_DeviceHealthAlarms, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId FxAssetType_SoftwareUpdate = new ExpandedNodeId(UAModel.FXAC.Objects.FxAssetType_SoftwareUpdate, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId http___opcfoundation_org_UA_FX_AC_ = new ExpandedNodeId(UAModel.FXAC.Objects.http___opcfoundation_org_UA_FX_AC_, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId ApplicationIdentifierDataType_Encoding_DefaultBinary = new ExpandedNodeId(UAModel.FXAC.Objects.ApplicationIdentifierDataType_Encoding_DefaultBinary, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId ApplicationIdentifierDataType_Encoding_DefaultXml = new ExpandedNodeId(UAModel.FXAC.Objects.ApplicationIdentifierDataType_Encoding_DefaultXml, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId ApplicationIdentifierDataType_Encoding_DefaultJson = new ExpandedNodeId(UAModel.FXAC.Objects.ApplicationIdentifierDataType_Encoding_DefaultJson, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId FxVersion_Encoding_DefaultBinary = new ExpandedNodeId(UAModel.FXAC.Objects.FxVersion_Encoding_DefaultBinary, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId FxVersion_Encoding_DefaultXml = new ExpandedNodeId(UAModel.FXAC.Objects.FxVersion_Encoding_DefaultXml, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId FxVersion_Encoding_DefaultJson = new ExpandedNodeId(UAModel.FXAC.Objects.FxVersion_Encoding_DefaultJson, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId ApplicationId_Encoding_DefaultBinary = new ExpandedNodeId(UAModel.FXAC.Objects.ApplicationId_Encoding_DefaultBinary, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId AggregatedHealthDataType_Encoding_DefaultBinary = new ExpandedNodeId(UAModel.FXAC.Objects.AggregatedHealthDataType_Encoding_DefaultBinary, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId AggregatedHealthDataType_Encoding_DefaultXml = new ExpandedNodeId(UAModel.FXAC.Objects.AggregatedHealthDataType_Encoding_DefaultXml, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId AggregatedHealthDataType_Encoding_DefaultJson = new ExpandedNodeId(UAModel.FXAC.Objects.AggregatedHealthDataType_Encoding_DefaultJson, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId IntervalRange_Encoding_DefaultBinary = new ExpandedNodeId(UAModel.FXAC.Objects.IntervalRange_Encoding_DefaultBinary, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId IntervalRange_Encoding_DefaultXml = new ExpandedNodeId(UAModel.FXAC.Objects.IntervalRange_Encoding_DefaultXml, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId ApplicationId_Encoding_DefaultXml = new ExpandedNodeId(UAModel.FXAC.Objects.ApplicationId_Encoding_DefaultXml, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId IntervalRange_Encoding_DefaultJson = new ExpandedNodeId(UAModel.FXAC.Objects.IntervalRange_Encoding_DefaultJson, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId PublisherQosDataType_Encoding_DefaultBinary = new ExpandedNodeId(UAModel.FXAC.Objects.PublisherQosDataType_Encoding_DefaultBinary, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId PublisherQosDataType_Encoding_DefaultXml = new ExpandedNodeId(UAModel.FXAC.Objects.PublisherQosDataType_Encoding_DefaultXml, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId PublisherQosDataType_Encoding_DefaultJson = new ExpandedNodeId(UAModel.FXAC.Objects.PublisherQosDataType_Encoding_DefaultJson, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId SubscriberQosDataType_Encoding_DefaultBinary = new ExpandedNodeId(UAModel.FXAC.Objects.SubscriberQosDataType_Encoding_DefaultBinary, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId SubscriberQosDataType_Encoding_DefaultXml = new ExpandedNodeId(UAModel.FXAC.Objects.SubscriberQosDataType_Encoding_DefaultXml, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId SubscriberQosDataType_Encoding_DefaultJson = new ExpandedNodeId(UAModel.FXAC.Objects.SubscriberQosDataType_Encoding_DefaultJson, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId ApplicationId_Encoding_DefaultJson = new ExpandedNodeId(UAModel.FXAC.Objects.ApplicationId_Encoding_DefaultJson, UAModel.FXAC.Namespaces.FXAC);
    }
    #endregion

    #region ObjectType Node Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectTypeIds
    {
        /// <remarks />
        public static readonly ExpandedNodeId AcDescriptorType = new ExpandedNodeId(UAModel.FXAC.ObjectTypes.AcDescriptorType, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId AssetConnectorType = new ExpandedNodeId(UAModel.FXAC.ObjectTypes.AssetConnectorType, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId ClampBlockType = new ExpandedNodeId(UAModel.FXAC.ObjectTypes.ClampBlockType, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId ClampType = new ExpandedNodeId(UAModel.FXAC.ObjectTypes.ClampType, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId SlotType = new ExpandedNodeId(UAModel.FXAC.ObjectTypes.SlotType, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId SocketType = new ExpandedNodeId(UAModel.FXAC.ObjectTypes.SocketType, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId AutomationComponentType = new ExpandedNodeId(UAModel.FXAC.ObjectTypes.AutomationComponentType, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId AuditUaFxEventType = new ExpandedNodeId(UAModel.FXAC.ObjectTypes.AuditUaFxEventType, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId AuditConnectionCleanupEventType = new ExpandedNodeId(UAModel.FXAC.ObjectTypes.AuditConnectionCleanupEventType, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId IAssetRevisionType = new ExpandedNodeId(UAModel.FXAC.ObjectTypes.IAssetRevisionType, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId IFunctionalEntityType = new ExpandedNodeId(UAModel.FXAC.ObjectTypes.IFunctionalEntityType, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId ConnectionEndpointType = new ExpandedNodeId(UAModel.FXAC.ObjectTypes.ConnectionEndpointType, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId PubSubConnectionEndpointType = new ExpandedNodeId(UAModel.FXAC.ObjectTypes.PubSubConnectionEndpointType, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId ControlGroupType = new ExpandedNodeId(UAModel.FXAC.ObjectTypes.ControlGroupType, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId AutomationComponentCapabilitiesType = new ExpandedNodeId(UAModel.FXAC.ObjectTypes.AutomationComponentCapabilitiesType, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId ConnectionEndpointsFolderType = new ExpandedNodeId(UAModel.FXAC.ObjectTypes.ConnectionEndpointsFolderType, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId ControlGroupsFolderType = new ExpandedNodeId(UAModel.FXAC.ObjectTypes.ControlGroupsFolderType, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalEntityCapabilitiesType = new ExpandedNodeId(UAModel.FXAC.ObjectTypes.FunctionalEntityCapabilitiesType, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId ConfigurationDataFolderType = new ExpandedNodeId(UAModel.FXAC.ObjectTypes.ConfigurationDataFolderType, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId ControlItemFolderType = new ExpandedNodeId(UAModel.FXAC.ObjectTypes.ControlItemFolderType, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId InputsFolderType = new ExpandedNodeId(UAModel.FXAC.ObjectTypes.InputsFolderType, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId OutputsFolderType = new ExpandedNodeId(UAModel.FXAC.ObjectTypes.OutputsFolderType, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalEntityType = new ExpandedNodeId(UAModel.FXAC.ObjectTypes.FunctionalEntityType, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId FxAssetType = new ExpandedNodeId(UAModel.FXAC.ObjectTypes.FxAssetType, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId PublisherCapabilitiesType = new ExpandedNodeId(UAModel.FXAC.ObjectTypes.PublisherCapabilitiesType, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId SubscriberCapabilitiesType = new ExpandedNodeId(UAModel.FXAC.ObjectTypes.SubscriberCapabilitiesType, UAModel.FXAC.Namespaces.FXAC);
    }
    #endregion

    #region ReferenceType Node Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ReferenceTypeIds
    {
        /// <remarks />
        public static readonly ExpandedNodeId HasCapability = new ExpandedNodeId(UAModel.FXAC.ReferenceTypes.HasCapability, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId HasConnectionEndpoint = new ExpandedNodeId(UAModel.FXAC.ReferenceTypes.HasConnectionEndpoint, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId HasControlGroup = new ExpandedNodeId(UAModel.FXAC.ReferenceTypes.HasControlGroup, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId HasInputGroup = new ExpandedNodeId(UAModel.FXAC.ReferenceTypes.HasInputGroup, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId HasOutputGroup = new ExpandedNodeId(UAModel.FXAC.ReferenceTypes.HasOutputGroup, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId HasBuiltInAsset = new ExpandedNodeId(UAModel.FXAC.ReferenceTypes.HasBuiltInAsset, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId HasPart = new ExpandedNodeId(UAModel.FXAC.ReferenceTypes.HasPart, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId HasSubFunctionalEntity = new ExpandedNodeId(UAModel.FXAC.ReferenceTypes.HasSubFunctionalEntity, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId IsPartOfRedundantAssetSet = new ExpandedNodeId(UAModel.FXAC.ReferenceTypes.IsPartOfRedundantAssetSet, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId ConnectedTo = new ExpandedNodeId(UAModel.FXAC.ReferenceTypes.ConnectedTo, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId ToDataSetReader = new ExpandedNodeId(UAModel.FXAC.ReferenceTypes.ToDataSetReader, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId ToDataSetWriter = new ExpandedNodeId(UAModel.FXAC.ReferenceTypes.ToDataSetWriter, UAModel.FXAC.Namespaces.FXAC);
    }
    #endregion

    #region Variable Node Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class VariableIds
    {
        /// <remarks />
        public static readonly ExpandedNodeId ClampKindEnum_EnumValues = new ExpandedNodeId(UAModel.FXAC.Variables.ClampKindEnum_EnumValues, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId ConnectionEndpointStatusEnum_EnumValues = new ExpandedNodeId(UAModel.FXAC.Variables.ConnectionEndpointStatusEnum_EnumValues, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId FxTimeUnitsEnum_EnumStrings = new ExpandedNodeId(UAModel.FXAC.Variables.FxTimeUnitsEnum_EnumStrings, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId SocketKindEnum_EnumStrings = new ExpandedNodeId(UAModel.FXAC.Variables.SocketKindEnum_EnumStrings, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId CommHealthOptionSet_OptionSetValues = new ExpandedNodeId(UAModel.FXAC.Variables.CommHealthOptionSet_OptionSetValues, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId DeviceHealthOptionSet_OptionSetValues = new ExpandedNodeId(UAModel.FXAC.Variables.DeviceHealthOptionSet_OptionSetValues, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId OperationalHealthOptionSet_OptionSetValues = new ExpandedNodeId(UAModel.FXAC.Variables.OperationalHealthOptionSet_OptionSetValues, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId TypeDictionary_BinarySchema = new ExpandedNodeId(UAModel.FXAC.Variables.TypeDictionary_BinarySchema, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId TypeDictionary_XmlSchema = new ExpandedNodeId(UAModel.FXAC.Variables.TypeDictionary_XmlSchema, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId AggregatedHealthType_AggregatedDeviceHealth = new ExpandedNodeId(UAModel.FXAC.Variables.AggregatedHealthType_AggregatedDeviceHealth, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId AggregatedHealthType_AggregatedOperationalHealth = new ExpandedNodeId(UAModel.FXAC.Variables.AggregatedHealthType_AggregatedOperationalHealth, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId AcDescriptorType_DescriptorFile_Size = new ExpandedNodeId(UAModel.FXAC.Variables.AcDescriptorType_DescriptorFile_Size, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId AcDescriptorType_DescriptorFile_Writable = new ExpandedNodeId(UAModel.FXAC.Variables.AcDescriptorType_DescriptorFile_Writable, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId AcDescriptorType_DescriptorFile_UserWritable = new ExpandedNodeId(UAModel.FXAC.Variables.AcDescriptorType_DescriptorFile_UserWritable, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId AcDescriptorType_DescriptorFile_OpenCount = new ExpandedNodeId(UAModel.FXAC.Variables.AcDescriptorType_DescriptorFile_OpenCount, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId AcDescriptorType_DescriptorFile_Open_InputArguments = new ExpandedNodeId(UAModel.FXAC.Variables.AcDescriptorType_DescriptorFile_Open_InputArguments, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId AcDescriptorType_DescriptorFile_Open_OutputArguments = new ExpandedNodeId(UAModel.FXAC.Variables.AcDescriptorType_DescriptorFile_Open_OutputArguments, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId AcDescriptorType_DescriptorFile_Close_InputArguments = new ExpandedNodeId(UAModel.FXAC.Variables.AcDescriptorType_DescriptorFile_Close_InputArguments, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId AcDescriptorType_DescriptorFile_Read_InputArguments = new ExpandedNodeId(UAModel.FXAC.Variables.AcDescriptorType_DescriptorFile_Read_InputArguments, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId AcDescriptorType_DescriptorFile_Read_OutputArguments = new ExpandedNodeId(UAModel.FXAC.Variables.AcDescriptorType_DescriptorFile_Read_OutputArguments, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId AcDescriptorType_DescriptorFile_Write_InputArguments = new ExpandedNodeId(UAModel.FXAC.Variables.AcDescriptorType_DescriptorFile_Write_InputArguments, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId AcDescriptorType_DescriptorFile_GetPosition_InputArguments = new ExpandedNodeId(UAModel.FXAC.Variables.AcDescriptorType_DescriptorFile_GetPosition_InputArguments, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId AcDescriptorType_DescriptorFile_GetPosition_OutputArguments = new ExpandedNodeId(UAModel.FXAC.Variables.AcDescriptorType_DescriptorFile_GetPosition_OutputArguments, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId AcDescriptorType_DescriptorFile_SetPosition_InputArguments = new ExpandedNodeId(UAModel.FXAC.Variables.AcDescriptorType_DescriptorFile_SetPosition_InputArguments, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId AcDescriptorType_DescriptorIdentifier = new ExpandedNodeId(UAModel.FXAC.Variables.AcDescriptorType_DescriptorIdentifier, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId AcDescriptorType_DescriptorVersion = new ExpandedNodeId(UAModel.FXAC.Variables.AcDescriptorType_DescriptorVersion, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId AssetConnectorType_Id = new ExpandedNodeId(UAModel.FXAC.Variables.AssetConnectorType_Id, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId AssetConnectorType_Name = new ExpandedNodeId(UAModel.FXAC.Variables.AssetConnectorType_Name, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId ClampBlockType_Name = new ExpandedNodeId(UAModel.FXAC.Variables.ClampBlockType_Name, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId ClampBlockType_Clamp_Name = new ExpandedNodeId(UAModel.FXAC.Variables.ClampBlockType_Clamp_Name, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId ClampBlockType_Clamp_Kind_EnumValues = new ExpandedNodeId(UAModel.FXAC.Variables.ClampBlockType_Clamp_Kind_EnumValues, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId ClampBlockType_Clamp_Kind_ValueAsText = new ExpandedNodeId(UAModel.FXAC.Variables.ClampBlockType_Clamp_Kind_ValueAsText, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId ClampBlockType_BlockSize = new ExpandedNodeId(UAModel.FXAC.Variables.ClampBlockType_BlockSize, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId ClampBlockType_Kind = new ExpandedNodeId(UAModel.FXAC.Variables.ClampBlockType_Kind, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId ClampBlockType_Kind_EnumValues = new ExpandedNodeId(UAModel.FXAC.Variables.ClampBlockType_Kind_EnumValues, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId ClampBlockType_Kind_ValueAsText = new ExpandedNodeId(UAModel.FXAC.Variables.ClampBlockType_Kind_ValueAsText, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId ClampType_Name = new ExpandedNodeId(UAModel.FXAC.Variables.ClampType_Name, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId ClampType_Kind = new ExpandedNodeId(UAModel.FXAC.Variables.ClampType_Kind, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId ClampType_Kind_EnumValues = new ExpandedNodeId(UAModel.FXAC.Variables.ClampType_Kind_EnumValues, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId ClampType_Kind_ValueAsText = new ExpandedNodeId(UAModel.FXAC.Variables.ClampType_Kind_ValueAsText, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId SlotType_Id = new ExpandedNodeId(UAModel.FXAC.Variables.SlotType_Id, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId SlotType_LogicalId = new ExpandedNodeId(UAModel.FXAC.Variables.SlotType_LogicalId, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId SocketType_Name = new ExpandedNodeId(UAModel.FXAC.Variables.SocketType_Name, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId SocketType_Kind = new ExpandedNodeId(UAModel.FXAC.Variables.SocketType_Kind, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId SocketType_Kind_EnumValues = new ExpandedNodeId(UAModel.FXAC.Variables.SocketType_Kind_EnumValues, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId SocketType_Kind_ValueAsText = new ExpandedNodeId(UAModel.FXAC.Variables.SocketType_Kind_ValueAsText, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId AutomationComponentType_AggregatedHealth = new ExpandedNodeId(UAModel.FXAC.Variables.AutomationComponentType_AggregatedHealth, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId AutomationComponentType_AggregatedHealth_AggregatedDeviceHealth = new ExpandedNodeId(UAModel.FXAC.Variables.AutomationComponentType_AggregatedHealth_AggregatedDeviceHealth, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId AutomationComponentType_AggregatedHealth_AggregatedOperationalHealth = new ExpandedNodeId(UAModel.FXAC.Variables.AutomationComponentType_AggregatedHealth_AggregatedOperationalHealth, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId AutomationComponentType_Assets_Asset_ManufacturerUri = new ExpandedNodeId(UAModel.FXAC.Variables.AutomationComponentType_Assets_Asset_ManufacturerUri, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId AutomationComponentType_Assets_Asset_ProductCode = new ExpandedNodeId(UAModel.FXAC.Variables.AutomationComponentType_Assets_Asset_ProductCode, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId AutomationComponentType_Assets_Asset_SoftwareUpdate_PrepareForUpdate_CurrentState = new ExpandedNodeId(UAModel.FXAC.Variables.AutomationComponentType_Assets_Asset_SoftwareUpdate_PrepareForUpdate_CurrentState, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId AutomationComponentType_Assets_Asset_SoftwareUpdate_PrepareForUpdate_CurrentState_Id = new ExpandedNodeId(UAModel.FXAC.Variables.AutomationComponentType_Assets_Asset_SoftwareUpdate_PrepareForUpdate_CurrentState_Id, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId AutomationComponentType_Assets_Asset_SoftwareUpdate_Installation_CurrentState = new ExpandedNodeId(UAModel.FXAC.Variables.AutomationComponentType_Assets_Asset_SoftwareUpdate_Installation_CurrentState, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId AutomationComponentType_Assets_Asset_SoftwareUpdate_Installation_CurrentState_Id = new ExpandedNodeId(UAModel.FXAC.Variables.AutomationComponentType_Assets_Asset_SoftwareUpdate_Installation_CurrentState_Id, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId AutomationComponentType_Assets_Asset_SoftwareUpdate_Installation_InstallSoftwarePackage_InputArguments = new ExpandedNodeId(UAModel.FXAC.Variables.AutomationComponentType_Assets_Asset_SoftwareUpdate_Installation_InstallSoftwarePackage_InputArguments, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId AutomationComponentType_Assets_Asset_SoftwareUpdate_Installation_InstallFiles_InputArguments = new ExpandedNodeId(UAModel.FXAC.Variables.AutomationComponentType_Assets_Asset_SoftwareUpdate_Installation_InstallFiles_InputArguments, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId AutomationComponentType_Assets_Asset_SoftwareUpdate_PowerCycle_CurrentState = new ExpandedNodeId(UAModel.FXAC.Variables.AutomationComponentType_Assets_Asset_SoftwareUpdate_PowerCycle_CurrentState, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId AutomationComponentType_Assets_Asset_SoftwareUpdate_PowerCycle_CurrentState_Id = new ExpandedNodeId(UAModel.FXAC.Variables.AutomationComponentType_Assets_Asset_SoftwareUpdate_PowerCycle_CurrentState_Id, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId AutomationComponentType_Assets_Asset_SoftwareUpdate_Confirmation_CurrentState = new ExpandedNodeId(UAModel.FXAC.Variables.AutomationComponentType_Assets_Asset_SoftwareUpdate_Confirmation_CurrentState, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId AutomationComponentType_Assets_Asset_SoftwareUpdate_Confirmation_CurrentState_Id = new ExpandedNodeId(UAModel.FXAC.Variables.AutomationComponentType_Assets_Asset_SoftwareUpdate_Confirmation_CurrentState_Id, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId AutomationComponentType_Assets_Asset_SoftwareUpdate_Confirmation_ConfirmationTimeout = new ExpandedNodeId(UAModel.FXAC.Variables.AutomationComponentType_Assets_Asset_SoftwareUpdate_Confirmation_ConfirmationTimeout, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId AutomationComponentType_Assets_Asset_SoftwareUpdate_Parameters_ClientProcessingTimeout = new ExpandedNodeId(UAModel.FXAC.Variables.AutomationComponentType_Assets_Asset_SoftwareUpdate_Parameters_ClientProcessingTimeout, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId AutomationComponentType_Assets_Asset_SoftwareUpdate_Parameters_GenerateFileForRead_InputArguments = new ExpandedNodeId(UAModel.FXAC.Variables.AutomationComponentType_Assets_Asset_SoftwareUpdate_Parameters_GenerateFileForRead_InputArguments, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId AutomationComponentType_Assets_Asset_SoftwareUpdate_Parameters_GenerateFileForRead_OutputArguments = new ExpandedNodeId(UAModel.FXAC.Variables.AutomationComponentType_Assets_Asset_SoftwareUpdate_Parameters_GenerateFileForRead_OutputArguments, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId AutomationComponentType_Assets_Asset_SoftwareUpdate_Parameters_GenerateFileForWrite_InputArguments = new ExpandedNodeId(UAModel.FXAC.Variables.AutomationComponentType_Assets_Asset_SoftwareUpdate_Parameters_GenerateFileForWrite_InputArguments, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId AutomationComponentType_Assets_Asset_SoftwareUpdate_Parameters_GenerateFileForWrite_OutputArguments = new ExpandedNodeId(UAModel.FXAC.Variables.AutomationComponentType_Assets_Asset_SoftwareUpdate_Parameters_GenerateFileForWrite_OutputArguments, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId AutomationComponentType_Assets_Asset_SoftwareUpdate_Parameters_CloseAndCommit_InputArguments = new ExpandedNodeId(UAModel.FXAC.Variables.AutomationComponentType_Assets_Asset_SoftwareUpdate_Parameters_CloseAndCommit_InputArguments, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId AutomationComponentType_Assets_Asset_SoftwareUpdate_Parameters_CloseAndCommit_OutputArguments = new ExpandedNodeId(UAModel.FXAC.Variables.AutomationComponentType_Assets_Asset_SoftwareUpdate_Parameters_CloseAndCommit_OutputArguments, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId AutomationComponentType_Assets_Asset_VerifyAsset_InputArguments = new ExpandedNodeId(UAModel.FXAC.Variables.AutomationComponentType_Assets_Asset_VerifyAsset_InputArguments, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId AutomationComponentType_Assets_Asset_VerifyAsset_OutputArguments = new ExpandedNodeId(UAModel.FXAC.Variables.AutomationComponentType_Assets_Asset_VerifyAsset_OutputArguments, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId AutomationComponentType_CloseConnections_InputArguments = new ExpandedNodeId(UAModel.FXAC.Variables.AutomationComponentType_CloseConnections_InputArguments, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId AutomationComponentType_CloseConnections_OutputArguments = new ExpandedNodeId(UAModel.FXAC.Variables.AutomationComponentType_CloseConnections_OutputArguments, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId AutomationComponentType_ComponentCapabilities_MaxConnections = new ExpandedNodeId(UAModel.FXAC.Variables.AutomationComponentType_ComponentCapabilities_MaxConnections, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId AutomationComponentType_ComponentCapabilities_SupportsPersistence = new ExpandedNodeId(UAModel.FXAC.Variables.AutomationComponentType_ComponentCapabilities_SupportsPersistence, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId AutomationComponentType_ConformanceName = new ExpandedNodeId(UAModel.FXAC.Variables.AutomationComponentType_ConformanceName, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId AutomationComponentType_EstablishConnections_InputArguments = new ExpandedNodeId(UAModel.FXAC.Variables.AutomationComponentType_EstablishConnections_InputArguments, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId AutomationComponentType_EstablishConnections_OutputArguments = new ExpandedNodeId(UAModel.FXAC.Variables.AutomationComponentType_EstablishConnections_OutputArguments, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId AutomationComponentType_FunctionalEntities_FunctionalEntity_ConfigurationData_ClearStoredVariables_InputArguments = new ExpandedNodeId(UAModel.FXAC.Variables.AutomationComponentType_FunctionalEntities_FunctionalEntity_ConfigurationData_ClearStoredVariables_InputArguments, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId AutomationComponentType_FunctionalEntities_FunctionalEntity_ConfigurationData_ClearStoredVariables_OutputArguments = new ExpandedNodeId(UAModel.FXAC.Variables.AutomationComponentType_FunctionalEntities_FunctionalEntity_ConfigurationData_ClearStoredVariables_OutputArguments, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId AutomationComponentType_FunctionalEntities_FunctionalEntity_ConfigurationData_ListStoredVariables_OutputArguments = new ExpandedNodeId(UAModel.FXAC.Variables.AutomationComponentType_FunctionalEntities_FunctionalEntity_ConfigurationData_ListStoredVariables_OutputArguments, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId AutomationComponentType_FunctionalEntities_FunctionalEntity_ConfigurationData_SetStoredVariables_InputArguments = new ExpandedNodeId(UAModel.FXAC.Variables.AutomationComponentType_FunctionalEntities_FunctionalEntity_ConfigurationData_SetStoredVariables_InputArguments, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId AutomationComponentType_FunctionalEntities_FunctionalEntity_ConfigurationData_SetStoredVariables_OutputArguments = new ExpandedNodeId(UAModel.FXAC.Variables.AutomationComponentType_FunctionalEntities_FunctionalEntity_ConfigurationData_SetStoredVariables_OutputArguments, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId AutomationComponentType_FunctionalEntities_FunctionalEntity_InputData_SubscriberCapabilities_PreconfiguredDataSetOnly = new ExpandedNodeId(UAModel.FXAC.Variables.AutomationComponentType_FunctionalEntities_FunctionalEntity_InputData_SubscriberCapabilities_PreconfiguredDataSetOnly, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId AutomationComponentType_FunctionalEntities_FunctionalEntity_InputData_SubscriberCapabilities_PreconfiguredSubscribedDataSets = new ExpandedNodeId(UAModel.FXAC.Variables.AutomationComponentType_FunctionalEntities_FunctionalEntity_InputData_SubscriberCapabilities_PreconfiguredSubscribedDataSets, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId AutomationComponentType_FunctionalEntities_FunctionalEntity_InputData_SubscriberCapabilities_SupportedMessageReceiveTimeouts = new ExpandedNodeId(UAModel.FXAC.Variables.AutomationComponentType_FunctionalEntities_FunctionalEntity_InputData_SubscriberCapabilities_SupportedMessageReceiveTimeouts, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId AutomationComponentType_FunctionalEntities_FunctionalEntity_InputData_SubscriberCapabilities_SupportedPublishingIntervals = new ExpandedNodeId(UAModel.FXAC.Variables.AutomationComponentType_FunctionalEntities_FunctionalEntity_InputData_SubscriberCapabilities_SupportedPublishingIntervals, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId AutomationComponentType_FunctionalEntities_FunctionalEntity_InputData_SubscriberCapabilities_SupportedQos = new ExpandedNodeId(UAModel.FXAC.Variables.AutomationComponentType_FunctionalEntities_FunctionalEntity_InputData_SubscriberCapabilities_SupportedQos, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId AutomationComponentType_FunctionalEntities_FunctionalEntity_OutputData_PublisherCapabilities_PreconfiguredDataSetOnly = new ExpandedNodeId(UAModel.FXAC.Variables.AutomationComponentType_FunctionalEntities_FunctionalEntity_OutputData_PublisherCapabilities_PreconfiguredDataSetOnly, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId AutomationComponentType_FunctionalEntities_FunctionalEntity_OutputData_PublisherCapabilities_PreconfiguredPublishedDataSets = new ExpandedNodeId(UAModel.FXAC.Variables.AutomationComponentType_FunctionalEntities_FunctionalEntity_OutputData_PublisherCapabilities_PreconfiguredPublishedDataSets, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId AutomationComponentType_FunctionalEntities_FunctionalEntity_OutputData_PublisherCapabilities_SupportedPublishingIntervals = new ExpandedNodeId(UAModel.FXAC.Variables.AutomationComponentType_FunctionalEntities_FunctionalEntity_OutputData_PublisherCapabilities_SupportedPublishingIntervals, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId AutomationComponentType_FunctionalEntities_FunctionalEntity_OutputData_PublisherCapabilities_SupportedQos = new ExpandedNodeId(UAModel.FXAC.Variables.AutomationComponentType_FunctionalEntities_FunctionalEntity_OutputData_PublisherCapabilities_SupportedQos, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId AutomationComponentType_FunctionalEntities_FunctionalEntity_PublisherCapabilities_PreconfiguredDataSetOnly = new ExpandedNodeId(UAModel.FXAC.Variables.AutomationComponentType_FunctionalEntities_FunctionalEntity_PublisherCapabilities_PreconfiguredDataSetOnly, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId AutomationComponentType_FunctionalEntities_FunctionalEntity_PublisherCapabilities_PreconfiguredPublishedDataSets = new ExpandedNodeId(UAModel.FXAC.Variables.AutomationComponentType_FunctionalEntities_FunctionalEntity_PublisherCapabilities_PreconfiguredPublishedDataSets, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId AutomationComponentType_FunctionalEntities_FunctionalEntity_PublisherCapabilities_SupportedPublishingIntervals = new ExpandedNodeId(UAModel.FXAC.Variables.AutomationComponentType_FunctionalEntities_FunctionalEntity_PublisherCapabilities_SupportedPublishingIntervals, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId AutomationComponentType_FunctionalEntities_FunctionalEntity_PublisherCapabilities_SupportedQos = new ExpandedNodeId(UAModel.FXAC.Variables.AutomationComponentType_FunctionalEntities_FunctionalEntity_PublisherCapabilities_SupportedQos, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId AutomationComponentType_FunctionalEntities_FunctionalEntity_SubscriberCapabilities_PreconfiguredDataSetOnly = new ExpandedNodeId(UAModel.FXAC.Variables.AutomationComponentType_FunctionalEntities_FunctionalEntity_SubscriberCapabilities_PreconfiguredDataSetOnly, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId AutomationComponentType_FunctionalEntities_FunctionalEntity_SubscriberCapabilities_PreconfiguredSubscribedDataSets = new ExpandedNodeId(UAModel.FXAC.Variables.AutomationComponentType_FunctionalEntities_FunctionalEntity_SubscriberCapabilities_PreconfiguredSubscribedDataSets, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId AutomationComponentType_FunctionalEntities_FunctionalEntity_SubscriberCapabilities_SupportedMessageReceiveTimeouts = new ExpandedNodeId(UAModel.FXAC.Variables.AutomationComponentType_FunctionalEntities_FunctionalEntity_SubscriberCapabilities_SupportedMessageReceiveTimeouts, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId AutomationComponentType_FunctionalEntities_FunctionalEntity_SubscriberCapabilities_SupportedPublishingIntervals = new ExpandedNodeId(UAModel.FXAC.Variables.AutomationComponentType_FunctionalEntities_FunctionalEntity_SubscriberCapabilities_SupportedPublishingIntervals, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId AutomationComponentType_FunctionalEntities_FunctionalEntity_SubscriberCapabilities_SupportedQos = new ExpandedNodeId(UAModel.FXAC.Variables.AutomationComponentType_FunctionalEntities_FunctionalEntity_SubscriberCapabilities_SupportedQos, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId AutomationComponentType_FunctionalEntities_FunctionalEntity_Verify_InputArguments = new ExpandedNodeId(UAModel.FXAC.Variables.AutomationComponentType_FunctionalEntities_FunctionalEntity_Verify_InputArguments, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId AutomationComponentType_FunctionalEntities_FunctionalEntity_Verify_OutputArguments = new ExpandedNodeId(UAModel.FXAC.Variables.AutomationComponentType_FunctionalEntities_FunctionalEntity_Verify_OutputArguments, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId AutomationComponentType_PublisherCapabilities_PreconfiguredDataSetOnly = new ExpandedNodeId(UAModel.FXAC.Variables.AutomationComponentType_PublisherCapabilities_PreconfiguredDataSetOnly, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId AutomationComponentType_PublisherCapabilities_PreconfiguredPublishedDataSets = new ExpandedNodeId(UAModel.FXAC.Variables.AutomationComponentType_PublisherCapabilities_PreconfiguredPublishedDataSets, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId AutomationComponentType_PublisherCapabilities_SupportedPublishingIntervals = new ExpandedNodeId(UAModel.FXAC.Variables.AutomationComponentType_PublisherCapabilities_SupportedPublishingIntervals, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId AutomationComponentType_PublisherCapabilities_SupportedQos = new ExpandedNodeId(UAModel.FXAC.Variables.AutomationComponentType_PublisherCapabilities_SupportedQos, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId AutomationComponentType_SubscriberCapabilities_PreconfiguredDataSetOnly = new ExpandedNodeId(UAModel.FXAC.Variables.AutomationComponentType_SubscriberCapabilities_PreconfiguredDataSetOnly, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId AutomationComponentType_SubscriberCapabilities_PreconfiguredSubscribedDataSets = new ExpandedNodeId(UAModel.FXAC.Variables.AutomationComponentType_SubscriberCapabilities_PreconfiguredSubscribedDataSets, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId AutomationComponentType_SubscriberCapabilities_SupportedMessageReceiveTimeouts = new ExpandedNodeId(UAModel.FXAC.Variables.AutomationComponentType_SubscriberCapabilities_SupportedMessageReceiveTimeouts, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId AutomationComponentType_SubscriberCapabilities_SupportedPublishingIntervals = new ExpandedNodeId(UAModel.FXAC.Variables.AutomationComponentType_SubscriberCapabilities_SupportedPublishingIntervals, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId AutomationComponentType_SubscriberCapabilities_SupportedQos = new ExpandedNodeId(UAModel.FXAC.Variables.AutomationComponentType_SubscriberCapabilities_SupportedQos, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId AuditConnectionCleanupEventType_RelatedEndpoint = new ExpandedNodeId(UAModel.FXAC.Variables.AuditConnectionCleanupEventType_RelatedEndpoint, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId AuditConnectionCleanupEventType_RemovedEndpoint = new ExpandedNodeId(UAModel.FXAC.Variables.AuditConnectionCleanupEventType_RemovedEndpoint, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId IAssetRevisionType_BuildAssetNumber = new ExpandedNodeId(UAModel.FXAC.Variables.IAssetRevisionType_BuildAssetNumber, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId IAssetRevisionType_MajorAssetVersion = new ExpandedNodeId(UAModel.FXAC.Variables.IAssetRevisionType_MajorAssetVersion, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId IAssetRevisionType_MinorAssetVersion = new ExpandedNodeId(UAModel.FXAC.Variables.IAssetRevisionType_MinorAssetVersion, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId IAssetRevisionType_SubBuildAssetNumber = new ExpandedNodeId(UAModel.FXAC.Variables.IAssetRevisionType_SubBuildAssetNumber, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId IAssetRevisionType_VerifyAsset_InputArguments = new ExpandedNodeId(UAModel.FXAC.Variables.IAssetRevisionType_VerifyAsset_InputArguments, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId IAssetRevisionType_VerifyAsset_OutputArguments = new ExpandedNodeId(UAModel.FXAC.Variables.IAssetRevisionType_VerifyAsset_OutputArguments, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId IFunctionalEntityType_ApplicationIdentifier = new ExpandedNodeId(UAModel.FXAC.Variables.IFunctionalEntityType_ApplicationIdentifier, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId IFunctionalEntityType_AuthorAssignedIdentifier = new ExpandedNodeId(UAModel.FXAC.Variables.IFunctionalEntityType_AuthorAssignedIdentifier, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId IFunctionalEntityType_AuthorAssignedVersion = new ExpandedNodeId(UAModel.FXAC.Variables.IFunctionalEntityType_AuthorAssignedVersion, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId IFunctionalEntityType_AuthorUri = new ExpandedNodeId(UAModel.FXAC.Variables.IFunctionalEntityType_AuthorUri, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId IFunctionalEntityType_Capabilities_FeedbackSignalRequired = new ExpandedNodeId(UAModel.FXAC.Variables.IFunctionalEntityType_Capabilities_FeedbackSignalRequired, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId IFunctionalEntityType_ConfigurationData_ClearStoredVariables_InputArguments = new ExpandedNodeId(UAModel.FXAC.Variables.IFunctionalEntityType_ConfigurationData_ClearStoredVariables_InputArguments, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId IFunctionalEntityType_ConfigurationData_ClearStoredVariables_OutputArguments = new ExpandedNodeId(UAModel.FXAC.Variables.IFunctionalEntityType_ConfigurationData_ClearStoredVariables_OutputArguments, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId IFunctionalEntityType_ConfigurationData_ListStoredVariables_OutputArguments = new ExpandedNodeId(UAModel.FXAC.Variables.IFunctionalEntityType_ConfigurationData_ListStoredVariables_OutputArguments, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId IFunctionalEntityType_ConfigurationData_SetStoredVariables_InputArguments = new ExpandedNodeId(UAModel.FXAC.Variables.IFunctionalEntityType_ConfigurationData_SetStoredVariables_InputArguments, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId IFunctionalEntityType_ConfigurationData_SetStoredVariables_OutputArguments = new ExpandedNodeId(UAModel.FXAC.Variables.IFunctionalEntityType_ConfigurationData_SetStoredVariables_OutputArguments, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId IFunctionalEntityType_InputData_SubscriberCapabilities_PreconfiguredDataSetOnly = new ExpandedNodeId(UAModel.FXAC.Variables.IFunctionalEntityType_InputData_SubscriberCapabilities_PreconfiguredDataSetOnly, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId IFunctionalEntityType_InputData_SubscriberCapabilities_PreconfiguredSubscribedDataSets = new ExpandedNodeId(UAModel.FXAC.Variables.IFunctionalEntityType_InputData_SubscriberCapabilities_PreconfiguredSubscribedDataSets, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId IFunctionalEntityType_InputData_SubscriberCapabilities_SupportedMessageReceiveTimeouts = new ExpandedNodeId(UAModel.FXAC.Variables.IFunctionalEntityType_InputData_SubscriberCapabilities_SupportedMessageReceiveTimeouts, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId IFunctionalEntityType_InputData_SubscriberCapabilities_SupportedPublishingIntervals = new ExpandedNodeId(UAModel.FXAC.Variables.IFunctionalEntityType_InputData_SubscriberCapabilities_SupportedPublishingIntervals, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId IFunctionalEntityType_InputData_SubscriberCapabilities_SupportedQos = new ExpandedNodeId(UAModel.FXAC.Variables.IFunctionalEntityType_InputData_SubscriberCapabilities_SupportedQos, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId IFunctionalEntityType_OperationalHealth = new ExpandedNodeId(UAModel.FXAC.Variables.IFunctionalEntityType_OperationalHealth, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId IFunctionalEntityType_OutputData_PublisherCapabilities_PreconfiguredDataSetOnly = new ExpandedNodeId(UAModel.FXAC.Variables.IFunctionalEntityType_OutputData_PublisherCapabilities_PreconfiguredDataSetOnly, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId IFunctionalEntityType_OutputData_PublisherCapabilities_PreconfiguredPublishedDataSets = new ExpandedNodeId(UAModel.FXAC.Variables.IFunctionalEntityType_OutputData_PublisherCapabilities_PreconfiguredPublishedDataSets, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId IFunctionalEntityType_OutputData_PublisherCapabilities_SupportedPublishingIntervals = new ExpandedNodeId(UAModel.FXAC.Variables.IFunctionalEntityType_OutputData_PublisherCapabilities_SupportedPublishingIntervals, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId IFunctionalEntityType_OutputData_PublisherCapabilities_SupportedQos = new ExpandedNodeId(UAModel.FXAC.Variables.IFunctionalEntityType_OutputData_PublisherCapabilities_SupportedQos, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId IFunctionalEntityType_PublisherCapabilities_PreconfiguredDataSetOnly = new ExpandedNodeId(UAModel.FXAC.Variables.IFunctionalEntityType_PublisherCapabilities_PreconfiguredDataSetOnly, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId IFunctionalEntityType_PublisherCapabilities_PreconfiguredPublishedDataSets = new ExpandedNodeId(UAModel.FXAC.Variables.IFunctionalEntityType_PublisherCapabilities_PreconfiguredPublishedDataSets, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId IFunctionalEntityType_PublisherCapabilities_SupportedPublishingIntervals = new ExpandedNodeId(UAModel.FXAC.Variables.IFunctionalEntityType_PublisherCapabilities_SupportedPublishingIntervals, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId IFunctionalEntityType_PublisherCapabilities_SupportedQos = new ExpandedNodeId(UAModel.FXAC.Variables.IFunctionalEntityType_PublisherCapabilities_SupportedQos, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId IFunctionalEntityType_SubscriberCapabilities_PreconfiguredDataSetOnly = new ExpandedNodeId(UAModel.FXAC.Variables.IFunctionalEntityType_SubscriberCapabilities_PreconfiguredDataSetOnly, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId IFunctionalEntityType_SubscriberCapabilities_PreconfiguredSubscribedDataSets = new ExpandedNodeId(UAModel.FXAC.Variables.IFunctionalEntityType_SubscriberCapabilities_PreconfiguredSubscribedDataSets, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId IFunctionalEntityType_SubscriberCapabilities_SupportedMessageReceiveTimeouts = new ExpandedNodeId(UAModel.FXAC.Variables.IFunctionalEntityType_SubscriberCapabilities_SupportedMessageReceiveTimeouts, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId IFunctionalEntityType_SubscriberCapabilities_SupportedPublishingIntervals = new ExpandedNodeId(UAModel.FXAC.Variables.IFunctionalEntityType_SubscriberCapabilities_SupportedPublishingIntervals, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId IFunctionalEntityType_SubscriberCapabilities_SupportedQos = new ExpandedNodeId(UAModel.FXAC.Variables.IFunctionalEntityType_SubscriberCapabilities_SupportedQos, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId IFunctionalEntityType_Verify_InputArguments = new ExpandedNodeId(UAModel.FXAC.Variables.IFunctionalEntityType_Verify_InputArguments, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId IFunctionalEntityType_Verify_OutputArguments = new ExpandedNodeId(UAModel.FXAC.Variables.IFunctionalEntityType_Verify_OutputArguments, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId ConnectionEndpointType_CleanupTimeout = new ExpandedNodeId(UAModel.FXAC.Variables.ConnectionEndpointType_CleanupTimeout, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId ConnectionEndpointType_InputVariables = new ExpandedNodeId(UAModel.FXAC.Variables.ConnectionEndpointType_InputVariables, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId ConnectionEndpointType_IsPersistent = new ExpandedNodeId(UAModel.FXAC.Variables.ConnectionEndpointType_IsPersistent, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId ConnectionEndpointType_OutputVariables = new ExpandedNodeId(UAModel.FXAC.Variables.ConnectionEndpointType_OutputVariables, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId ConnectionEndpointType_RelatedEndpoint = new ExpandedNodeId(UAModel.FXAC.Variables.ConnectionEndpointType_RelatedEndpoint, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId ConnectionEndpointType_Status = new ExpandedNodeId(UAModel.FXAC.Variables.ConnectionEndpointType_Status, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId PubSubConnectionEndpointType_Mode = new ExpandedNodeId(UAModel.FXAC.Variables.PubSubConnectionEndpointType_Mode, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId ControlGroupType_ControlGroup_EstablishControl_InputArguments = new ExpandedNodeId(UAModel.FXAC.Variables.ControlGroupType_ControlGroup_EstablishControl_InputArguments, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId ControlGroupType_ControlGroup_EstablishControl_OutputArguments = new ExpandedNodeId(UAModel.FXAC.Variables.ControlGroupType_ControlGroup_EstablishControl_OutputArguments, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId ControlGroupType_ControlGroup_IsControlled = new ExpandedNodeId(UAModel.FXAC.Variables.ControlGroupType_ControlGroup_IsControlled, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId ControlGroupType_ControlGroup_ListToBlock_Lock_Locked = new ExpandedNodeId(UAModel.FXAC.Variables.ControlGroupType_ControlGroup_ListToBlock_Lock_Locked, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId ControlGroupType_ControlGroup_ListToBlock_Lock_LockingClient = new ExpandedNodeId(UAModel.FXAC.Variables.ControlGroupType_ControlGroup_ListToBlock_Lock_LockingClient, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId ControlGroupType_ControlGroup_ListToBlock_Lock_LockingUser = new ExpandedNodeId(UAModel.FXAC.Variables.ControlGroupType_ControlGroup_ListToBlock_Lock_LockingUser, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId ControlGroupType_ControlGroup_ListToBlock_Lock_RemainingLockTime = new ExpandedNodeId(UAModel.FXAC.Variables.ControlGroupType_ControlGroup_ListToBlock_Lock_RemainingLockTime, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId ControlGroupType_ControlGroup_ListToBlock_Lock_InitLock_InputArguments = new ExpandedNodeId(UAModel.FXAC.Variables.ControlGroupType_ControlGroup_ListToBlock_Lock_InitLock_InputArguments, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId ControlGroupType_ControlGroup_ListToBlock_Lock_InitLock_OutputArguments = new ExpandedNodeId(UAModel.FXAC.Variables.ControlGroupType_ControlGroup_ListToBlock_Lock_InitLock_OutputArguments, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId ControlGroupType_ControlGroup_ListToBlock_Lock_RenewLock_OutputArguments = new ExpandedNodeId(UAModel.FXAC.Variables.ControlGroupType_ControlGroup_ListToBlock_Lock_RenewLock_OutputArguments, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId ControlGroupType_ControlGroup_ListToBlock_Lock_ExitLock_OutputArguments = new ExpandedNodeId(UAModel.FXAC.Variables.ControlGroupType_ControlGroup_ListToBlock_Lock_ExitLock_OutputArguments, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId ControlGroupType_ControlGroup_ListToBlock_Lock_BreakLock_OutputArguments = new ExpandedNodeId(UAModel.FXAC.Variables.ControlGroupType_ControlGroup_ListToBlock_Lock_BreakLock_OutputArguments, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId ControlGroupType_ControlGroup_ListToRestrict_Lock_Locked = new ExpandedNodeId(UAModel.FXAC.Variables.ControlGroupType_ControlGroup_ListToRestrict_Lock_Locked, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId ControlGroupType_ControlGroup_ListToRestrict_Lock_LockingClient = new ExpandedNodeId(UAModel.FXAC.Variables.ControlGroupType_ControlGroup_ListToRestrict_Lock_LockingClient, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId ControlGroupType_ControlGroup_ListToRestrict_Lock_LockingUser = new ExpandedNodeId(UAModel.FXAC.Variables.ControlGroupType_ControlGroup_ListToRestrict_Lock_LockingUser, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId ControlGroupType_ControlGroup_ListToRestrict_Lock_RemainingLockTime = new ExpandedNodeId(UAModel.FXAC.Variables.ControlGroupType_ControlGroup_ListToRestrict_Lock_RemainingLockTime, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId ControlGroupType_ControlGroup_ListToRestrict_Lock_InitLock_InputArguments = new ExpandedNodeId(UAModel.FXAC.Variables.ControlGroupType_ControlGroup_ListToRestrict_Lock_InitLock_InputArguments, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId ControlGroupType_ControlGroup_ListToRestrict_Lock_InitLock_OutputArguments = new ExpandedNodeId(UAModel.FXAC.Variables.ControlGroupType_ControlGroup_ListToRestrict_Lock_InitLock_OutputArguments, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId ControlGroupType_ControlGroup_ListToRestrict_Lock_RenewLock_OutputArguments = new ExpandedNodeId(UAModel.FXAC.Variables.ControlGroupType_ControlGroup_ListToRestrict_Lock_RenewLock_OutputArguments, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId ControlGroupType_ControlGroup_ListToRestrict_Lock_ExitLock_OutputArguments = new ExpandedNodeId(UAModel.FXAC.Variables.ControlGroupType_ControlGroup_ListToRestrict_Lock_ExitLock_OutputArguments, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId ControlGroupType_ControlGroup_ListToRestrict_Lock_BreakLock_OutputArguments = new ExpandedNodeId(UAModel.FXAC.Variables.ControlGroupType_ControlGroup_ListToRestrict_Lock_BreakLock_OutputArguments, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId ControlGroupType_ControlGroup_ReassignControl_InputArguments = new ExpandedNodeId(UAModel.FXAC.Variables.ControlGroupType_ControlGroup_ReassignControl_InputArguments, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId ControlGroupType_ControlGroup_ReassignControl_OutputArguments = new ExpandedNodeId(UAModel.FXAC.Variables.ControlGroupType_ControlGroup_ReassignControl_OutputArguments, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId ControlGroupType_EstablishControl_InputArguments = new ExpandedNodeId(UAModel.FXAC.Variables.ControlGroupType_EstablishControl_InputArguments, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId ControlGroupType_EstablishControl_OutputArguments = new ExpandedNodeId(UAModel.FXAC.Variables.ControlGroupType_EstablishControl_OutputArguments, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId ControlGroupType_IsControlled = new ExpandedNodeId(UAModel.FXAC.Variables.ControlGroupType_IsControlled, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId ControlGroupType_ListToBlock_Lock_Locked = new ExpandedNodeId(UAModel.FXAC.Variables.ControlGroupType_ListToBlock_Lock_Locked, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId ControlGroupType_ListToBlock_Lock_LockingClient = new ExpandedNodeId(UAModel.FXAC.Variables.ControlGroupType_ListToBlock_Lock_LockingClient, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId ControlGroupType_ListToBlock_Lock_LockingUser = new ExpandedNodeId(UAModel.FXAC.Variables.ControlGroupType_ListToBlock_Lock_LockingUser, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId ControlGroupType_ListToBlock_Lock_RemainingLockTime = new ExpandedNodeId(UAModel.FXAC.Variables.ControlGroupType_ListToBlock_Lock_RemainingLockTime, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId ControlGroupType_ListToBlock_Lock_InitLock_InputArguments = new ExpandedNodeId(UAModel.FXAC.Variables.ControlGroupType_ListToBlock_Lock_InitLock_InputArguments, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId ControlGroupType_ListToBlock_Lock_InitLock_OutputArguments = new ExpandedNodeId(UAModel.FXAC.Variables.ControlGroupType_ListToBlock_Lock_InitLock_OutputArguments, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId ControlGroupType_ListToBlock_Lock_RenewLock_OutputArguments = new ExpandedNodeId(UAModel.FXAC.Variables.ControlGroupType_ListToBlock_Lock_RenewLock_OutputArguments, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId ControlGroupType_ListToBlock_Lock_ExitLock_OutputArguments = new ExpandedNodeId(UAModel.FXAC.Variables.ControlGroupType_ListToBlock_Lock_ExitLock_OutputArguments, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId ControlGroupType_ListToBlock_Lock_BreakLock_OutputArguments = new ExpandedNodeId(UAModel.FXAC.Variables.ControlGroupType_ListToBlock_Lock_BreakLock_OutputArguments, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId ControlGroupType_ListToRestrict_Lock_Locked = new ExpandedNodeId(UAModel.FXAC.Variables.ControlGroupType_ListToRestrict_Lock_Locked, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId ControlGroupType_ListToRestrict_Lock_LockingClient = new ExpandedNodeId(UAModel.FXAC.Variables.ControlGroupType_ListToRestrict_Lock_LockingClient, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId ControlGroupType_ListToRestrict_Lock_LockingUser = new ExpandedNodeId(UAModel.FXAC.Variables.ControlGroupType_ListToRestrict_Lock_LockingUser, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId ControlGroupType_ListToRestrict_Lock_RemainingLockTime = new ExpandedNodeId(UAModel.FXAC.Variables.ControlGroupType_ListToRestrict_Lock_RemainingLockTime, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId ControlGroupType_ListToRestrict_Lock_InitLock_InputArguments = new ExpandedNodeId(UAModel.FXAC.Variables.ControlGroupType_ListToRestrict_Lock_InitLock_InputArguments, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId ControlGroupType_ListToRestrict_Lock_InitLock_OutputArguments = new ExpandedNodeId(UAModel.FXAC.Variables.ControlGroupType_ListToRestrict_Lock_InitLock_OutputArguments, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId ControlGroupType_ListToRestrict_Lock_RenewLock_OutputArguments = new ExpandedNodeId(UAModel.FXAC.Variables.ControlGroupType_ListToRestrict_Lock_RenewLock_OutputArguments, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId ControlGroupType_ListToRestrict_Lock_ExitLock_OutputArguments = new ExpandedNodeId(UAModel.FXAC.Variables.ControlGroupType_ListToRestrict_Lock_ExitLock_OutputArguments, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId ControlGroupType_ListToRestrict_Lock_BreakLock_OutputArguments = new ExpandedNodeId(UAModel.FXAC.Variables.ControlGroupType_ListToRestrict_Lock_BreakLock_OutputArguments, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId ControlGroupType_ReassignControl_InputArguments = new ExpandedNodeId(UAModel.FXAC.Variables.ControlGroupType_ReassignControl_InputArguments, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId ControlGroupType_ReassignControl_OutputArguments = new ExpandedNodeId(UAModel.FXAC.Variables.ControlGroupType_ReassignControl_OutputArguments, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId AutomationComponentCapabilitiesType_Capability = new ExpandedNodeId(UAModel.FXAC.Variables.AutomationComponentCapabilitiesType_Capability, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId AutomationComponentCapabilitiesType_CommandBundleRequired = new ExpandedNodeId(UAModel.FXAC.Variables.AutomationComponentCapabilitiesType_CommandBundleRequired, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId AutomationComponentCapabilitiesType_MaxConnections = new ExpandedNodeId(UAModel.FXAC.Variables.AutomationComponentCapabilitiesType_MaxConnections, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId AutomationComponentCapabilitiesType_MaxConnectionsPerCall = new ExpandedNodeId(UAModel.FXAC.Variables.AutomationComponentCapabilitiesType_MaxConnectionsPerCall, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId AutomationComponentCapabilitiesType_MaxFunctionalEntities = new ExpandedNodeId(UAModel.FXAC.Variables.AutomationComponentCapabilitiesType_MaxFunctionalEntities, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId AutomationComponentCapabilitiesType_SupportsPersistence = new ExpandedNodeId(UAModel.FXAC.Variables.AutomationComponentCapabilitiesType_SupportsPersistence, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId ConnectionEndpointsFolderType_ConnectionEndpoint_CleanupTimeout = new ExpandedNodeId(UAModel.FXAC.Variables.ConnectionEndpointsFolderType_ConnectionEndpoint_CleanupTimeout, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId ConnectionEndpointsFolderType_ConnectionEndpoint_IsPersistent = new ExpandedNodeId(UAModel.FXAC.Variables.ConnectionEndpointsFolderType_ConnectionEndpoint_IsPersistent, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId ConnectionEndpointsFolderType_ConnectionEndpoint_RelatedEndpoint = new ExpandedNodeId(UAModel.FXAC.Variables.ConnectionEndpointsFolderType_ConnectionEndpoint_RelatedEndpoint, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId ConnectionEndpointsFolderType_ConnectionEndpoint_Status = new ExpandedNodeId(UAModel.FXAC.Variables.ConnectionEndpointsFolderType_ConnectionEndpoint_Status, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId ConnectionEndpointsFolderType_CommHealth = new ExpandedNodeId(UAModel.FXAC.Variables.ConnectionEndpointsFolderType_CommHealth, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId ControlGroupsFolderType_ControlGroup_EstablishControl_InputArguments = new ExpandedNodeId(UAModel.FXAC.Variables.ControlGroupsFolderType_ControlGroup_EstablishControl_InputArguments, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId ControlGroupsFolderType_ControlGroup_EstablishControl_OutputArguments = new ExpandedNodeId(UAModel.FXAC.Variables.ControlGroupsFolderType_ControlGroup_EstablishControl_OutputArguments, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId ControlGroupsFolderType_ControlGroup_IsControlled = new ExpandedNodeId(UAModel.FXAC.Variables.ControlGroupsFolderType_ControlGroup_IsControlled, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId ControlGroupsFolderType_ControlGroup_ListToBlock_Lock_Locked = new ExpandedNodeId(UAModel.FXAC.Variables.ControlGroupsFolderType_ControlGroup_ListToBlock_Lock_Locked, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId ControlGroupsFolderType_ControlGroup_ListToBlock_Lock_LockingClient = new ExpandedNodeId(UAModel.FXAC.Variables.ControlGroupsFolderType_ControlGroup_ListToBlock_Lock_LockingClient, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId ControlGroupsFolderType_ControlGroup_ListToBlock_Lock_LockingUser = new ExpandedNodeId(UAModel.FXAC.Variables.ControlGroupsFolderType_ControlGroup_ListToBlock_Lock_LockingUser, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId ControlGroupsFolderType_ControlGroup_ListToBlock_Lock_RemainingLockTime = new ExpandedNodeId(UAModel.FXAC.Variables.ControlGroupsFolderType_ControlGroup_ListToBlock_Lock_RemainingLockTime, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId ControlGroupsFolderType_ControlGroup_ListToBlock_Lock_InitLock_InputArguments = new ExpandedNodeId(UAModel.FXAC.Variables.ControlGroupsFolderType_ControlGroup_ListToBlock_Lock_InitLock_InputArguments, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId ControlGroupsFolderType_ControlGroup_ListToBlock_Lock_InitLock_OutputArguments = new ExpandedNodeId(UAModel.FXAC.Variables.ControlGroupsFolderType_ControlGroup_ListToBlock_Lock_InitLock_OutputArguments, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId ControlGroupsFolderType_ControlGroup_ListToBlock_Lock_RenewLock_OutputArguments = new ExpandedNodeId(UAModel.FXAC.Variables.ControlGroupsFolderType_ControlGroup_ListToBlock_Lock_RenewLock_OutputArguments, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId ControlGroupsFolderType_ControlGroup_ListToBlock_Lock_ExitLock_OutputArguments = new ExpandedNodeId(UAModel.FXAC.Variables.ControlGroupsFolderType_ControlGroup_ListToBlock_Lock_ExitLock_OutputArguments, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId ControlGroupsFolderType_ControlGroup_ListToBlock_Lock_BreakLock_OutputArguments = new ExpandedNodeId(UAModel.FXAC.Variables.ControlGroupsFolderType_ControlGroup_ListToBlock_Lock_BreakLock_OutputArguments, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId ControlGroupsFolderType_ControlGroup_ListToRestrict_Lock_Locked = new ExpandedNodeId(UAModel.FXAC.Variables.ControlGroupsFolderType_ControlGroup_ListToRestrict_Lock_Locked, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId ControlGroupsFolderType_ControlGroup_ListToRestrict_Lock_LockingClient = new ExpandedNodeId(UAModel.FXAC.Variables.ControlGroupsFolderType_ControlGroup_ListToRestrict_Lock_LockingClient, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId ControlGroupsFolderType_ControlGroup_ListToRestrict_Lock_LockingUser = new ExpandedNodeId(UAModel.FXAC.Variables.ControlGroupsFolderType_ControlGroup_ListToRestrict_Lock_LockingUser, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId ControlGroupsFolderType_ControlGroup_ListToRestrict_Lock_RemainingLockTime = new ExpandedNodeId(UAModel.FXAC.Variables.ControlGroupsFolderType_ControlGroup_ListToRestrict_Lock_RemainingLockTime, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId ControlGroupsFolderType_ControlGroup_ListToRestrict_Lock_InitLock_InputArguments = new ExpandedNodeId(UAModel.FXAC.Variables.ControlGroupsFolderType_ControlGroup_ListToRestrict_Lock_InitLock_InputArguments, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId ControlGroupsFolderType_ControlGroup_ListToRestrict_Lock_InitLock_OutputArguments = new ExpandedNodeId(UAModel.FXAC.Variables.ControlGroupsFolderType_ControlGroup_ListToRestrict_Lock_InitLock_OutputArguments, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId ControlGroupsFolderType_ControlGroup_ListToRestrict_Lock_RenewLock_OutputArguments = new ExpandedNodeId(UAModel.FXAC.Variables.ControlGroupsFolderType_ControlGroup_ListToRestrict_Lock_RenewLock_OutputArguments, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId ControlGroupsFolderType_ControlGroup_ListToRestrict_Lock_ExitLock_OutputArguments = new ExpandedNodeId(UAModel.FXAC.Variables.ControlGroupsFolderType_ControlGroup_ListToRestrict_Lock_ExitLock_OutputArguments, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId ControlGroupsFolderType_ControlGroup_ListToRestrict_Lock_BreakLock_OutputArguments = new ExpandedNodeId(UAModel.FXAC.Variables.ControlGroupsFolderType_ControlGroup_ListToRestrict_Lock_BreakLock_OutputArguments, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId ControlGroupsFolderType_ControlGroup_ReassignControl_InputArguments = new ExpandedNodeId(UAModel.FXAC.Variables.ControlGroupsFolderType_ControlGroup_ReassignControl_InputArguments, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId ControlGroupsFolderType_ControlGroup_ReassignControl_OutputArguments = new ExpandedNodeId(UAModel.FXAC.Variables.ControlGroupsFolderType_ControlGroup_ReassignControl_OutputArguments, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalEntityCapabilitiesType_Capability = new ExpandedNodeId(UAModel.FXAC.Variables.FunctionalEntityCapabilitiesType_Capability, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalEntityCapabilitiesType_FeedbackSignalRequired = new ExpandedNodeId(UAModel.FXAC.Variables.FunctionalEntityCapabilitiesType_FeedbackSignalRequired, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId ConfigurationDataFolderType_ConfigurationVariable = new ExpandedNodeId(UAModel.FXAC.Variables.ConfigurationDataFolderType_ConfigurationVariable, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId ConfigurationDataFolderType_ClearStoredVariables_InputArguments = new ExpandedNodeId(UAModel.FXAC.Variables.ConfigurationDataFolderType_ClearStoredVariables_InputArguments, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId ConfigurationDataFolderType_ClearStoredVariables_OutputArguments = new ExpandedNodeId(UAModel.FXAC.Variables.ConfigurationDataFolderType_ClearStoredVariables_OutputArguments, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId ConfigurationDataFolderType_ListStoredVariables_OutputArguments = new ExpandedNodeId(UAModel.FXAC.Variables.ConfigurationDataFolderType_ListStoredVariables_OutputArguments, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId ConfigurationDataFolderType_SetStoredVariables_InputArguments = new ExpandedNodeId(UAModel.FXAC.Variables.ConfigurationDataFolderType_SetStoredVariables_InputArguments, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId ConfigurationDataFolderType_SetStoredVariables_OutputArguments = new ExpandedNodeId(UAModel.FXAC.Variables.ConfigurationDataFolderType_SetStoredVariables_OutputArguments, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId ControlItemFolderType_Lock_Locked = new ExpandedNodeId(UAModel.FXAC.Variables.ControlItemFolderType_Lock_Locked, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId ControlItemFolderType_Lock_LockingClient = new ExpandedNodeId(UAModel.FXAC.Variables.ControlItemFolderType_Lock_LockingClient, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId ControlItemFolderType_Lock_LockingUser = new ExpandedNodeId(UAModel.FXAC.Variables.ControlItemFolderType_Lock_LockingUser, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId ControlItemFolderType_Lock_RemainingLockTime = new ExpandedNodeId(UAModel.FXAC.Variables.ControlItemFolderType_Lock_RemainingLockTime, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId ControlItemFolderType_Lock_InitLock_InputArguments = new ExpandedNodeId(UAModel.FXAC.Variables.ControlItemFolderType_Lock_InitLock_InputArguments, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId ControlItemFolderType_Lock_InitLock_OutputArguments = new ExpandedNodeId(UAModel.FXAC.Variables.ControlItemFolderType_Lock_InitLock_OutputArguments, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId ControlItemFolderType_Lock_RenewLock_OutputArguments = new ExpandedNodeId(UAModel.FXAC.Variables.ControlItemFolderType_Lock_RenewLock_OutputArguments, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId ControlItemFolderType_Lock_ExitLock_OutputArguments = new ExpandedNodeId(UAModel.FXAC.Variables.ControlItemFolderType_Lock_ExitLock_OutputArguments, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId ControlItemFolderType_Lock_BreakLock_OutputArguments = new ExpandedNodeId(UAModel.FXAC.Variables.ControlItemFolderType_Lock_BreakLock_OutputArguments, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId ControlItemFolderType_MaxInactiveLockTime = new ExpandedNodeId(UAModel.FXAC.Variables.ControlItemFolderType_MaxInactiveLockTime, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId InputsFolderType_InputGroup_SubscriberCapabilities_PreconfiguredDataSetOnly = new ExpandedNodeId(UAModel.FXAC.Variables.InputsFolderType_InputGroup_SubscriberCapabilities_PreconfiguredDataSetOnly, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId InputsFolderType_InputGroup_SubscriberCapabilities_PreconfiguredSubscribedDataSets = new ExpandedNodeId(UAModel.FXAC.Variables.InputsFolderType_InputGroup_SubscriberCapabilities_PreconfiguredSubscribedDataSets, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId InputsFolderType_InputGroup_SubscriberCapabilities_SupportedMessageReceiveTimeouts = new ExpandedNodeId(UAModel.FXAC.Variables.InputsFolderType_InputGroup_SubscriberCapabilities_SupportedMessageReceiveTimeouts, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId InputsFolderType_InputGroup_SubscriberCapabilities_SupportedPublishingIntervals = new ExpandedNodeId(UAModel.FXAC.Variables.InputsFolderType_InputGroup_SubscriberCapabilities_SupportedPublishingIntervals, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId InputsFolderType_InputGroup_SubscriberCapabilities_SupportedQos = new ExpandedNodeId(UAModel.FXAC.Variables.InputsFolderType_InputGroup_SubscriberCapabilities_SupportedQos, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId InputsFolderType_InputVariable = new ExpandedNodeId(UAModel.FXAC.Variables.InputsFolderType_InputVariable, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId InputsFolderType_SubscriberCapabilities_PreconfiguredDataSetOnly = new ExpandedNodeId(UAModel.FXAC.Variables.InputsFolderType_SubscriberCapabilities_PreconfiguredDataSetOnly, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId InputsFolderType_SubscriberCapabilities_PreconfiguredSubscribedDataSets = new ExpandedNodeId(UAModel.FXAC.Variables.InputsFolderType_SubscriberCapabilities_PreconfiguredSubscribedDataSets, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId InputsFolderType_SubscriberCapabilities_SupportedMessageReceiveTimeouts = new ExpandedNodeId(UAModel.FXAC.Variables.InputsFolderType_SubscriberCapabilities_SupportedMessageReceiveTimeouts, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId InputsFolderType_SubscriberCapabilities_SupportedPublishingIntervals = new ExpandedNodeId(UAModel.FXAC.Variables.InputsFolderType_SubscriberCapabilities_SupportedPublishingIntervals, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId InputsFolderType_SubscriberCapabilities_SupportedQos = new ExpandedNodeId(UAModel.FXAC.Variables.InputsFolderType_SubscriberCapabilities_SupportedQos, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId OutputsFolderType_OutputGroup_PublisherCapabilities_PreconfiguredDataSetOnly = new ExpandedNodeId(UAModel.FXAC.Variables.OutputsFolderType_OutputGroup_PublisherCapabilities_PreconfiguredDataSetOnly, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId OutputsFolderType_OutputGroup_PublisherCapabilities_PreconfiguredPublishedDataSets = new ExpandedNodeId(UAModel.FXAC.Variables.OutputsFolderType_OutputGroup_PublisherCapabilities_PreconfiguredPublishedDataSets, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId OutputsFolderType_OutputGroup_PublisherCapabilities_SupportedPublishingIntervals = new ExpandedNodeId(UAModel.FXAC.Variables.OutputsFolderType_OutputGroup_PublisherCapabilities_SupportedPublishingIntervals, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId OutputsFolderType_OutputGroup_PublisherCapabilities_SupportedQos = new ExpandedNodeId(UAModel.FXAC.Variables.OutputsFolderType_OutputGroup_PublisherCapabilities_SupportedQos, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId OutputsFolderType_OutputVariable = new ExpandedNodeId(UAModel.FXAC.Variables.OutputsFolderType_OutputVariable, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId OutputsFolderType_PublisherCapabilities_PreconfiguredDataSetOnly = new ExpandedNodeId(UAModel.FXAC.Variables.OutputsFolderType_PublisherCapabilities_PreconfiguredDataSetOnly, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId OutputsFolderType_PublisherCapabilities_PreconfiguredPublishedDataSets = new ExpandedNodeId(UAModel.FXAC.Variables.OutputsFolderType_PublisherCapabilities_PreconfiguredPublishedDataSets, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId OutputsFolderType_PublisherCapabilities_SupportedPublishingIntervals = new ExpandedNodeId(UAModel.FXAC.Variables.OutputsFolderType_PublisherCapabilities_SupportedPublishingIntervals, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId OutputsFolderType_PublisherCapabilities_SupportedQos = new ExpandedNodeId(UAModel.FXAC.Variables.OutputsFolderType_PublisherCapabilities_SupportedQos, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalEntityType_SubFunctionalEntity_ApplicationIdentifier = new ExpandedNodeId(UAModel.FXAC.Variables.FunctionalEntityType_SubFunctionalEntity_ApplicationIdentifier, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalEntityType_SubFunctionalEntity_AuthorAssignedIdentifier = new ExpandedNodeId(UAModel.FXAC.Variables.FunctionalEntityType_SubFunctionalEntity_AuthorAssignedIdentifier, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalEntityType_SubFunctionalEntity_AuthorAssignedVersion = new ExpandedNodeId(UAModel.FXAC.Variables.FunctionalEntityType_SubFunctionalEntity_AuthorAssignedVersion, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalEntityType_SubFunctionalEntity_AuthorUri = new ExpandedNodeId(UAModel.FXAC.Variables.FunctionalEntityType_SubFunctionalEntity_AuthorUri, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalEntityType_SubFunctionalEntity_Capabilities_FeedbackSignalRequired = new ExpandedNodeId(UAModel.FXAC.Variables.FunctionalEntityType_SubFunctionalEntity_Capabilities_FeedbackSignalRequired, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalEntityType_SubFunctionalEntity_ConfigurationData_ClearStoredVariables_InputArguments = new ExpandedNodeId(UAModel.FXAC.Variables.FunctionalEntityType_SubFunctionalEntity_ConfigurationData_ClearStoredVariables_InputArguments, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalEntityType_SubFunctionalEntity_ConfigurationData_ClearStoredVariables_OutputArguments = new ExpandedNodeId(UAModel.FXAC.Variables.FunctionalEntityType_SubFunctionalEntity_ConfigurationData_ClearStoredVariables_OutputArguments, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalEntityType_SubFunctionalEntity_ConfigurationData_ListStoredVariables_OutputArguments = new ExpandedNodeId(UAModel.FXAC.Variables.FunctionalEntityType_SubFunctionalEntity_ConfigurationData_ListStoredVariables_OutputArguments, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalEntityType_SubFunctionalEntity_ConfigurationData_SetStoredVariables_InputArguments = new ExpandedNodeId(UAModel.FXAC.Variables.FunctionalEntityType_SubFunctionalEntity_ConfigurationData_SetStoredVariables_InputArguments, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalEntityType_SubFunctionalEntity_ConfigurationData_SetStoredVariables_OutputArguments = new ExpandedNodeId(UAModel.FXAC.Variables.FunctionalEntityType_SubFunctionalEntity_ConfigurationData_SetStoredVariables_OutputArguments, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalEntityType_SubFunctionalEntity_InputData_SubscriberCapabilities_PreconfiguredDataSetOnly = new ExpandedNodeId(UAModel.FXAC.Variables.FunctionalEntityType_SubFunctionalEntity_InputData_SubscriberCapabilities_PreconfiguredDataSetOnly, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalEntityType_SubFunctionalEntity_InputData_SubscriberCapabilities_PreconfiguredSubscribedDataSets = new ExpandedNodeId(UAModel.FXAC.Variables.FunctionalEntityType_SubFunctionalEntity_InputData_SubscriberCapabilities_PreconfiguredSubscribedDataSets, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalEntityType_SubFunctionalEntity_InputData_SubscriberCapabilities_SupportedMessageReceiveTimeouts = new ExpandedNodeId(UAModel.FXAC.Variables.FunctionalEntityType_SubFunctionalEntity_InputData_SubscriberCapabilities_SupportedMessageReceiveTimeouts, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalEntityType_SubFunctionalEntity_InputData_SubscriberCapabilities_SupportedPublishingIntervals = new ExpandedNodeId(UAModel.FXAC.Variables.FunctionalEntityType_SubFunctionalEntity_InputData_SubscriberCapabilities_SupportedPublishingIntervals, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalEntityType_SubFunctionalEntity_InputData_SubscriberCapabilities_SupportedQos = new ExpandedNodeId(UAModel.FXAC.Variables.FunctionalEntityType_SubFunctionalEntity_InputData_SubscriberCapabilities_SupportedQos, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalEntityType_SubFunctionalEntity_OperationalHealth = new ExpandedNodeId(UAModel.FXAC.Variables.FunctionalEntityType_SubFunctionalEntity_OperationalHealth, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalEntityType_SubFunctionalEntity_OutputData_PublisherCapabilities_PreconfiguredDataSetOnly = new ExpandedNodeId(UAModel.FXAC.Variables.FunctionalEntityType_SubFunctionalEntity_OutputData_PublisherCapabilities_PreconfiguredDataSetOnly, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalEntityType_SubFunctionalEntity_OutputData_PublisherCapabilities_PreconfiguredPublishedDataSets = new ExpandedNodeId(UAModel.FXAC.Variables.FunctionalEntityType_SubFunctionalEntity_OutputData_PublisherCapabilities_PreconfiguredPublishedDataSets, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalEntityType_SubFunctionalEntity_OutputData_PublisherCapabilities_SupportedPublishingIntervals = new ExpandedNodeId(UAModel.FXAC.Variables.FunctionalEntityType_SubFunctionalEntity_OutputData_PublisherCapabilities_SupportedPublishingIntervals, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalEntityType_SubFunctionalEntity_OutputData_PublisherCapabilities_SupportedQos = new ExpandedNodeId(UAModel.FXAC.Variables.FunctionalEntityType_SubFunctionalEntity_OutputData_PublisherCapabilities_SupportedQos, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalEntityType_SubFunctionalEntity_PublisherCapabilities_PreconfiguredDataSetOnly = new ExpandedNodeId(UAModel.FXAC.Variables.FunctionalEntityType_SubFunctionalEntity_PublisherCapabilities_PreconfiguredDataSetOnly, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalEntityType_SubFunctionalEntity_PublisherCapabilities_PreconfiguredPublishedDataSets = new ExpandedNodeId(UAModel.FXAC.Variables.FunctionalEntityType_SubFunctionalEntity_PublisherCapabilities_PreconfiguredPublishedDataSets, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalEntityType_SubFunctionalEntity_PublisherCapabilities_SupportedPublishingIntervals = new ExpandedNodeId(UAModel.FXAC.Variables.FunctionalEntityType_SubFunctionalEntity_PublisherCapabilities_SupportedPublishingIntervals, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalEntityType_SubFunctionalEntity_PublisherCapabilities_SupportedQos = new ExpandedNodeId(UAModel.FXAC.Variables.FunctionalEntityType_SubFunctionalEntity_PublisherCapabilities_SupportedQos, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalEntityType_SubFunctionalEntity_SubscriberCapabilities_PreconfiguredDataSetOnly = new ExpandedNodeId(UAModel.FXAC.Variables.FunctionalEntityType_SubFunctionalEntity_SubscriberCapabilities_PreconfiguredDataSetOnly, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalEntityType_SubFunctionalEntity_SubscriberCapabilities_PreconfiguredSubscribedDataSets = new ExpandedNodeId(UAModel.FXAC.Variables.FunctionalEntityType_SubFunctionalEntity_SubscriberCapabilities_PreconfiguredSubscribedDataSets, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalEntityType_SubFunctionalEntity_SubscriberCapabilities_SupportedMessageReceiveTimeouts = new ExpandedNodeId(UAModel.FXAC.Variables.FunctionalEntityType_SubFunctionalEntity_SubscriberCapabilities_SupportedMessageReceiveTimeouts, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalEntityType_SubFunctionalEntity_SubscriberCapabilities_SupportedPublishingIntervals = new ExpandedNodeId(UAModel.FXAC.Variables.FunctionalEntityType_SubFunctionalEntity_SubscriberCapabilities_SupportedPublishingIntervals, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalEntityType_SubFunctionalEntity_SubscriberCapabilities_SupportedQos = new ExpandedNodeId(UAModel.FXAC.Variables.FunctionalEntityType_SubFunctionalEntity_SubscriberCapabilities_SupportedQos, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalEntityType_SubFunctionalEntity_Verify_InputArguments = new ExpandedNodeId(UAModel.FXAC.Variables.FunctionalEntityType_SubFunctionalEntity_Verify_InputArguments, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalEntityType_SubFunctionalEntity_Verify_OutputArguments = new ExpandedNodeId(UAModel.FXAC.Variables.FunctionalEntityType_SubFunctionalEntity_Verify_OutputArguments, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalEntityType_ApplicationIdentifier = new ExpandedNodeId(UAModel.FXAC.Variables.FunctionalEntityType_ApplicationIdentifier, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalEntityType_AuthorAssignedIdentifier = new ExpandedNodeId(UAModel.FXAC.Variables.FunctionalEntityType_AuthorAssignedIdentifier, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalEntityType_AuthorAssignedVersion = new ExpandedNodeId(UAModel.FXAC.Variables.FunctionalEntityType_AuthorAssignedVersion, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalEntityType_AuthorUri = new ExpandedNodeId(UAModel.FXAC.Variables.FunctionalEntityType_AuthorUri, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalEntityType_Capabilities_FeedbackSignalRequired = new ExpandedNodeId(UAModel.FXAC.Variables.FunctionalEntityType_Capabilities_FeedbackSignalRequired, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalEntityType_ConfigurationData_ClearStoredVariables_InputArguments = new ExpandedNodeId(UAModel.FXAC.Variables.FunctionalEntityType_ConfigurationData_ClearStoredVariables_InputArguments, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalEntityType_ConfigurationData_ClearStoredVariables_OutputArguments = new ExpandedNodeId(UAModel.FXAC.Variables.FunctionalEntityType_ConfigurationData_ClearStoredVariables_OutputArguments, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalEntityType_ConfigurationData_ListStoredVariables_OutputArguments = new ExpandedNodeId(UAModel.FXAC.Variables.FunctionalEntityType_ConfigurationData_ListStoredVariables_OutputArguments, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalEntityType_ConfigurationData_SetStoredVariables_InputArguments = new ExpandedNodeId(UAModel.FXAC.Variables.FunctionalEntityType_ConfigurationData_SetStoredVariables_InputArguments, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalEntityType_ConfigurationData_SetStoredVariables_OutputArguments = new ExpandedNodeId(UAModel.FXAC.Variables.FunctionalEntityType_ConfigurationData_SetStoredVariables_OutputArguments, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalEntityType_InputData_SubscriberCapabilities_PreconfiguredDataSetOnly = new ExpandedNodeId(UAModel.FXAC.Variables.FunctionalEntityType_InputData_SubscriberCapabilities_PreconfiguredDataSetOnly, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalEntityType_InputData_SubscriberCapabilities_PreconfiguredSubscribedDataSets = new ExpandedNodeId(UAModel.FXAC.Variables.FunctionalEntityType_InputData_SubscriberCapabilities_PreconfiguredSubscribedDataSets, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalEntityType_InputData_SubscriberCapabilities_SupportedMessageReceiveTimeouts = new ExpandedNodeId(UAModel.FXAC.Variables.FunctionalEntityType_InputData_SubscriberCapabilities_SupportedMessageReceiveTimeouts, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalEntityType_InputData_SubscriberCapabilities_SupportedPublishingIntervals = new ExpandedNodeId(UAModel.FXAC.Variables.FunctionalEntityType_InputData_SubscriberCapabilities_SupportedPublishingIntervals, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalEntityType_InputData_SubscriberCapabilities_SupportedQos = new ExpandedNodeId(UAModel.FXAC.Variables.FunctionalEntityType_InputData_SubscriberCapabilities_SupportedQos, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalEntityType_OperationalHealth = new ExpandedNodeId(UAModel.FXAC.Variables.FunctionalEntityType_OperationalHealth, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalEntityType_OutputData_PublisherCapabilities_PreconfiguredDataSetOnly = new ExpandedNodeId(UAModel.FXAC.Variables.FunctionalEntityType_OutputData_PublisherCapabilities_PreconfiguredDataSetOnly, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalEntityType_OutputData_PublisherCapabilities_PreconfiguredPublishedDataSets = new ExpandedNodeId(UAModel.FXAC.Variables.FunctionalEntityType_OutputData_PublisherCapabilities_PreconfiguredPublishedDataSets, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalEntityType_OutputData_PublisherCapabilities_SupportedPublishingIntervals = new ExpandedNodeId(UAModel.FXAC.Variables.FunctionalEntityType_OutputData_PublisherCapabilities_SupportedPublishingIntervals, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalEntityType_OutputData_PublisherCapabilities_SupportedQos = new ExpandedNodeId(UAModel.FXAC.Variables.FunctionalEntityType_OutputData_PublisherCapabilities_SupportedQos, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalEntityType_PublisherCapabilities_PreconfiguredDataSetOnly = new ExpandedNodeId(UAModel.FXAC.Variables.FunctionalEntityType_PublisherCapabilities_PreconfiguredDataSetOnly, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalEntityType_PublisherCapabilities_PreconfiguredPublishedDataSets = new ExpandedNodeId(UAModel.FXAC.Variables.FunctionalEntityType_PublisherCapabilities_PreconfiguredPublishedDataSets, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalEntityType_PublisherCapabilities_SupportedPublishingIntervals = new ExpandedNodeId(UAModel.FXAC.Variables.FunctionalEntityType_PublisherCapabilities_SupportedPublishingIntervals, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalEntityType_PublisherCapabilities_SupportedQos = new ExpandedNodeId(UAModel.FXAC.Variables.FunctionalEntityType_PublisherCapabilities_SupportedQos, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalEntityType_SubscriberCapabilities_PreconfiguredDataSetOnly = new ExpandedNodeId(UAModel.FXAC.Variables.FunctionalEntityType_SubscriberCapabilities_PreconfiguredDataSetOnly, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalEntityType_SubscriberCapabilities_PreconfiguredSubscribedDataSets = new ExpandedNodeId(UAModel.FXAC.Variables.FunctionalEntityType_SubscriberCapabilities_PreconfiguredSubscribedDataSets, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalEntityType_SubscriberCapabilities_SupportedMessageReceiveTimeouts = new ExpandedNodeId(UAModel.FXAC.Variables.FunctionalEntityType_SubscriberCapabilities_SupportedMessageReceiveTimeouts, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalEntityType_SubscriberCapabilities_SupportedPublishingIntervals = new ExpandedNodeId(UAModel.FXAC.Variables.FunctionalEntityType_SubscriberCapabilities_SupportedPublishingIntervals, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalEntityType_SubscriberCapabilities_SupportedQos = new ExpandedNodeId(UAModel.FXAC.Variables.FunctionalEntityType_SubscriberCapabilities_SupportedQos, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalEntityType_Verify_InputArguments = new ExpandedNodeId(UAModel.FXAC.Variables.FunctionalEntityType_Verify_InputArguments, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalEntityType_Verify_OutputArguments = new ExpandedNodeId(UAModel.FXAC.Variables.FunctionalEntityType_Verify_OutputArguments, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId FxAssetType_AssetId = new ExpandedNodeId(UAModel.FXAC.Variables.FxAssetType_AssetId, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId FxAssetType_BuildAssetNumber = new ExpandedNodeId(UAModel.FXAC.Variables.FxAssetType_BuildAssetNumber, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId FxAssetType_ComponentName = new ExpandedNodeId(UAModel.FXAC.Variables.FxAssetType_ComponentName, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId FxAssetType_Connectors_AssetConnector_Name = new ExpandedNodeId(UAModel.FXAC.Variables.FxAssetType_Connectors_AssetConnector_Name, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId FxAssetType_DeviceClass = new ExpandedNodeId(UAModel.FXAC.Variables.FxAssetType_DeviceClass, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId FxAssetType_DeviceHealth = new ExpandedNodeId(UAModel.FXAC.Variables.FxAssetType_DeviceHealth, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId FxAssetType_DeviceManual = new ExpandedNodeId(UAModel.FXAC.Variables.FxAssetType_DeviceManual, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId FxAssetType_DeviceRevision = new ExpandedNodeId(UAModel.FXAC.Variables.FxAssetType_DeviceRevision, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId FxAssetType_HardwareRevision = new ExpandedNodeId(UAModel.FXAC.Variables.FxAssetType_HardwareRevision, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId FxAssetType_MajorAssetVersion = new ExpandedNodeId(UAModel.FXAC.Variables.FxAssetType_MajorAssetVersion, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId FxAssetType_Manufacturer = new ExpandedNodeId(UAModel.FXAC.Variables.FxAssetType_Manufacturer, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId FxAssetType_ManufacturerUri = new ExpandedNodeId(UAModel.FXAC.Variables.FxAssetType_ManufacturerUri, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId FxAssetType_MinorAssetVersion = new ExpandedNodeId(UAModel.FXAC.Variables.FxAssetType_MinorAssetVersion, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId FxAssetType_Model = new ExpandedNodeId(UAModel.FXAC.Variables.FxAssetType_Model, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId FxAssetType_ProductCode = new ExpandedNodeId(UAModel.FXAC.Variables.FxAssetType_ProductCode, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId FxAssetType_ProductInstanceUri = new ExpandedNodeId(UAModel.FXAC.Variables.FxAssetType_ProductInstanceUri, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId FxAssetType_RevisionCounter = new ExpandedNodeId(UAModel.FXAC.Variables.FxAssetType_RevisionCounter, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId FxAssetType_SerialNumber = new ExpandedNodeId(UAModel.FXAC.Variables.FxAssetType_SerialNumber, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId FxAssetType_SoftwareRevision = new ExpandedNodeId(UAModel.FXAC.Variables.FxAssetType_SoftwareRevision, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId FxAssetType_SoftwareUpdate_PrepareForUpdate_CurrentState = new ExpandedNodeId(UAModel.FXAC.Variables.FxAssetType_SoftwareUpdate_PrepareForUpdate_CurrentState, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId FxAssetType_SoftwareUpdate_PrepareForUpdate_CurrentState_Id = new ExpandedNodeId(UAModel.FXAC.Variables.FxAssetType_SoftwareUpdate_PrepareForUpdate_CurrentState_Id, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId FxAssetType_SoftwareUpdate_Installation_CurrentState = new ExpandedNodeId(UAModel.FXAC.Variables.FxAssetType_SoftwareUpdate_Installation_CurrentState, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId FxAssetType_SoftwareUpdate_Installation_CurrentState_Id = new ExpandedNodeId(UAModel.FXAC.Variables.FxAssetType_SoftwareUpdate_Installation_CurrentState_Id, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId FxAssetType_SoftwareUpdate_Installation_InstallSoftwarePackage_InputArguments = new ExpandedNodeId(UAModel.FXAC.Variables.FxAssetType_SoftwareUpdate_Installation_InstallSoftwarePackage_InputArguments, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId FxAssetType_SoftwareUpdate_Installation_InstallFiles_InputArguments = new ExpandedNodeId(UAModel.FXAC.Variables.FxAssetType_SoftwareUpdate_Installation_InstallFiles_InputArguments, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId FxAssetType_SoftwareUpdate_PowerCycle_CurrentState = new ExpandedNodeId(UAModel.FXAC.Variables.FxAssetType_SoftwareUpdate_PowerCycle_CurrentState, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId FxAssetType_SoftwareUpdate_PowerCycle_CurrentState_Id = new ExpandedNodeId(UAModel.FXAC.Variables.FxAssetType_SoftwareUpdate_PowerCycle_CurrentState_Id, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId FxAssetType_SoftwareUpdate_Confirmation_CurrentState = new ExpandedNodeId(UAModel.FXAC.Variables.FxAssetType_SoftwareUpdate_Confirmation_CurrentState, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId FxAssetType_SoftwareUpdate_Confirmation_CurrentState_Id = new ExpandedNodeId(UAModel.FXAC.Variables.FxAssetType_SoftwareUpdate_Confirmation_CurrentState_Id, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId FxAssetType_SoftwareUpdate_Confirmation_ConfirmationTimeout = new ExpandedNodeId(UAModel.FXAC.Variables.FxAssetType_SoftwareUpdate_Confirmation_ConfirmationTimeout, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId FxAssetType_SoftwareUpdate_Parameters_ClientProcessingTimeout = new ExpandedNodeId(UAModel.FXAC.Variables.FxAssetType_SoftwareUpdate_Parameters_ClientProcessingTimeout, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId FxAssetType_SoftwareUpdate_Parameters_GenerateFileForRead_InputArguments = new ExpandedNodeId(UAModel.FXAC.Variables.FxAssetType_SoftwareUpdate_Parameters_GenerateFileForRead_InputArguments, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId FxAssetType_SoftwareUpdate_Parameters_GenerateFileForRead_OutputArguments = new ExpandedNodeId(UAModel.FXAC.Variables.FxAssetType_SoftwareUpdate_Parameters_GenerateFileForRead_OutputArguments, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId FxAssetType_SoftwareUpdate_Parameters_GenerateFileForWrite_InputArguments = new ExpandedNodeId(UAModel.FXAC.Variables.FxAssetType_SoftwareUpdate_Parameters_GenerateFileForWrite_InputArguments, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId FxAssetType_SoftwareUpdate_Parameters_GenerateFileForWrite_OutputArguments = new ExpandedNodeId(UAModel.FXAC.Variables.FxAssetType_SoftwareUpdate_Parameters_GenerateFileForWrite_OutputArguments, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId FxAssetType_SoftwareUpdate_Parameters_CloseAndCommit_InputArguments = new ExpandedNodeId(UAModel.FXAC.Variables.FxAssetType_SoftwareUpdate_Parameters_CloseAndCommit_InputArguments, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId FxAssetType_SoftwareUpdate_Parameters_CloseAndCommit_OutputArguments = new ExpandedNodeId(UAModel.FXAC.Variables.FxAssetType_SoftwareUpdate_Parameters_CloseAndCommit_OutputArguments, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId FxAssetType_SubBuildAssetNumber = new ExpandedNodeId(UAModel.FXAC.Variables.FxAssetType_SubBuildAssetNumber, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId FxAssetType_VerifyAsset_InputArguments = new ExpandedNodeId(UAModel.FXAC.Variables.FxAssetType_VerifyAsset_InputArguments, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId FxAssetType_VerifyAsset_OutputArguments = new ExpandedNodeId(UAModel.FXAC.Variables.FxAssetType_VerifyAsset_OutputArguments, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId PublisherCapabilitiesType_PreconfiguredDataSetOnly = new ExpandedNodeId(UAModel.FXAC.Variables.PublisherCapabilitiesType_PreconfiguredDataSetOnly, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId PublisherCapabilitiesType_PreconfiguredPublishedDataSets = new ExpandedNodeId(UAModel.FXAC.Variables.PublisherCapabilitiesType_PreconfiguredPublishedDataSets, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId PublisherCapabilitiesType_SupportedPublishingIntervals = new ExpandedNodeId(UAModel.FXAC.Variables.PublisherCapabilitiesType_SupportedPublishingIntervals, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId PublisherCapabilitiesType_SupportedQos = new ExpandedNodeId(UAModel.FXAC.Variables.PublisherCapabilitiesType_SupportedQos, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId SubscriberCapabilitiesType_PreconfiguredDataSetOnly = new ExpandedNodeId(UAModel.FXAC.Variables.SubscriberCapabilitiesType_PreconfiguredDataSetOnly, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId SubscriberCapabilitiesType_PreconfiguredSubscribedDataSets = new ExpandedNodeId(UAModel.FXAC.Variables.SubscriberCapabilitiesType_PreconfiguredSubscribedDataSets, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId SubscriberCapabilitiesType_SupportedMessageReceiveTimeouts = new ExpandedNodeId(UAModel.FXAC.Variables.SubscriberCapabilitiesType_SupportedMessageReceiveTimeouts, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId SubscriberCapabilitiesType_SupportedPublishingIntervals = new ExpandedNodeId(UAModel.FXAC.Variables.SubscriberCapabilitiesType_SupportedPublishingIntervals, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId SubscriberCapabilitiesType_SupportedQos = new ExpandedNodeId(UAModel.FXAC.Variables.SubscriberCapabilitiesType_SupportedQos, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId http___opcfoundation_org_UA_FX_AC__NamespaceUri = new ExpandedNodeId(UAModel.FXAC.Variables.http___opcfoundation_org_UA_FX_AC__NamespaceUri, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId http___opcfoundation_org_UA_FX_AC__NamespaceVersion = new ExpandedNodeId(UAModel.FXAC.Variables.http___opcfoundation_org_UA_FX_AC__NamespaceVersion, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId http___opcfoundation_org_UA_FX_AC__NamespacePublicationDate = new ExpandedNodeId(UAModel.FXAC.Variables.http___opcfoundation_org_UA_FX_AC__NamespacePublicationDate, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId http___opcfoundation_org_UA_FX_AC__IsNamespaceSubset = new ExpandedNodeId(UAModel.FXAC.Variables.http___opcfoundation_org_UA_FX_AC__IsNamespaceSubset, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId http___opcfoundation_org_UA_FX_AC__StaticNodeIdTypes = new ExpandedNodeId(UAModel.FXAC.Variables.http___opcfoundation_org_UA_FX_AC__StaticNodeIdTypes, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId http___opcfoundation_org_UA_FX_AC__StaticNumericNodeIdRange = new ExpandedNodeId(UAModel.FXAC.Variables.http___opcfoundation_org_UA_FX_AC__StaticNumericNodeIdRange, UAModel.FXAC.Namespaces.FXAC);

        /// <remarks />
        public static readonly ExpandedNodeId http___opcfoundation_org_UA_FX_AC__StaticStringNodeIdPattern = new ExpandedNodeId(UAModel.FXAC.Variables.http___opcfoundation_org_UA_FX_AC__StaticStringNodeIdPattern, UAModel.FXAC.Namespaces.FXAC);
    }
    #endregion

    #region VariableType Node Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class VariableTypeIds
    {
        /// <remarks />
        public static readonly ExpandedNodeId AggregatedHealthType = new ExpandedNodeId(UAModel.FXAC.VariableTypes.AggregatedHealthType, UAModel.FXAC.Namespaces.FXAC);
    }
    #endregion

    #region BrowseName Declarations
    /// <remarks />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class BrowseNames
    {
        /// <remarks />
        public const string AcDescriptorType = "AcDescriptorType";

        /// <remarks />
        public const string AggregatedDeviceHealth = "AggregatedDeviceHealth";

        /// <remarks />
        public const string AggregatedHealth = "AggregatedHealth";

        /// <remarks />
        public const string AggregatedHealthDataType = "AggregatedHealthDataType";

        /// <remarks />
        public const string AggregatedHealthType = "AggregatedHealthType";

        /// <remarks />
        public const string AggregatedOperationalHealth = "AggregatedOperationalHealth";

        /// <remarks />
        public const string ApplicationId = "ApplicationId";

        /// <remarks />
        public const string ApplicationIdentifier = "ApplicationIdentifier";

        /// <remarks />
        public const string ApplicationIdentifierDataType = "ApplicationIdentifierDataType";

        /// <remarks />
        public const string AssetConnectorType = "AssetConnectorType";

        /// <remarks />
        public const string Assets = "Assets";

        /// <remarks />
        public const string AuditConnectionCleanupEventType = "AuditConnectionCleanupEventType";

        /// <remarks />
        public const string AuditUaFxEventType = "AuditUaFxEventType";

        /// <remarks />
        public const string AuthorAssignedIdentifier = "AuthorAssignedIdentifier";

        /// <remarks />
        public const string AuthorAssignedVersion = "AuthorAssignedVersion";

        /// <remarks />
        public const string AuthorUri = "AuthorUri";

        /// <remarks />
        public const string AutomationComponentCapabilitiesType = "AutomationComponentCapabilitiesType";

        /// <remarks />
        public const string AutomationComponentType = "AutomationComponentType";

        /// <remarks />
        public const string BlockSize = "BlockSize";

        /// <remarks />
        public const string BuildAssetNumber = "BuildAssetNumber";

        /// <remarks />
        public const string Capabilities = "Capabilities";

        /// <remarks />
        public const string Capability = "<Capability>";

        /// <remarks />
        public const string Clamp = "<Clamp>";

        /// <remarks />
        public const string ClampBlockType = "ClampBlockType";

        /// <remarks />
        public const string ClampKindEnum = "ClampKindEnum";

        /// <remarks />
        public const string ClampType = "ClampType";

        /// <remarks />
        public const string CleanupTimeout = "CleanupTimeout";

        /// <remarks />
        public const string ClearStoredVariables = "ClearStoredVariables";

        /// <remarks />
        public const string ClearStoredVariablesMethodType = "ClearStoredVariablesMethodType";

        /// <remarks />
        public const string CloseConnections = "CloseConnections";

        /// <remarks />
        public const string CloseConnectionsMethodType = "CloseConnectionsMethodType";

        /// <remarks />
        public const string CommandBundleRequired = "CommandBundleRequired";

        /// <remarks />
        public const string CommHealth = "CommHealth";

        /// <remarks />
        public const string CommHealthOptionSet = "CommHealthOptionSet";

        /// <remarks />
        public const string ComponentCapabilities = "ComponentCapabilities";

        /// <remarks />
        public const string ConfigurationData = "ConfigurationData";

        /// <remarks />
        public const string ConfigurationDataFolderType = "ConfigurationDataFolderType";

        /// <remarks />
        public const string ConfigurationVariable = "<ConfigurationVariable>";

        /// <remarks />
        public const string ConformanceName = "ConformanceName";

        /// <remarks />
        public const string ConnectedTo = "ConnectedTo";

        /// <remarks />
        public const string ConnectionEndpoint = "<ConnectionEndpoint>";

        /// <remarks />
        public const string ConnectionEndpoints = "ConnectionEndpoints";

        /// <remarks />
        public const string ConnectionEndpointsFolderType = "ConnectionEndpointsFolderType";

        /// <remarks />
        public const string ConnectionEndpointStatusEnum = "ConnectionEndpointStatusEnum";

        /// <remarks />
        public const string ConnectionEndpointType = "ConnectionEndpointType";

        /// <remarks />
        public const string Connectors = "Connectors";

        /// <remarks />
        public const string ControlGroup = "<ControlGroup>";

        /// <remarks />
        public const string ControlGroups = "ControlGroups";

        /// <remarks />
        public const string ControlGroupsFolderType = "ControlGroupsFolderType";

        /// <remarks />
        public const string ControlGroupType = "ControlGroupType";

        /// <remarks />
        public const string ControlItemFolderType = "ControlItemFolderType";

        /// <remarks />
        public const string DescriptorFile = "DescriptorFile";

        /// <remarks />
        public const string DescriptorIdentifier = "DescriptorIdentifier";

        /// <remarks />
        public const string Descriptors = "Descriptors";

        /// <remarks />
        public const string DescriptorVersion = "DescriptorVersion";

        /// <remarks />
        public const string DeviceHealthOptionSet = "DeviceHealthOptionSet";

        /// <remarks />
        public const string EstablishConnections = "EstablishConnections";

        /// <remarks />
        public const string EstablishConnectionsMethodType = "EstablishConnectionsMethodType";

        /// <remarks />
        public const string EstablishControl = "EstablishControl";

        /// <remarks />
        public const string EstablishControlMethodType = "EstablishControlMethodType";

        /// <remarks />
        public const string FeedbackSignalRequired = "FeedbackSignalRequired";

        /// <remarks />
        public const string FunctionalEntities = "FunctionalEntities";

        /// <remarks />
        public const string FunctionalEntityCapabilitiesType = "FunctionalEntityCapabilitiesType";

        /// <remarks />
        public const string FunctionalEntityType = "FunctionalEntityType";

        /// <remarks />
        public const string FxAssetType = "FxAssetType";

        /// <remarks />
        public const string FxTimeUnitsEnum = "FxTimeUnitsEnum";

        /// <remarks />
        public const string FxVersion = "FxVersion";

        /// <remarks />
        public const string HasBuiltInAsset = "HasBuiltInAsset";

        /// <remarks />
        public const string HasCapability = "HasCapability";

        /// <remarks />
        public const string HasConnectionEndpoint = "HasConnectionEndpoint";

        /// <remarks />
        public const string HasControlGroup = "HasControlGroup";

        /// <remarks />
        public const string HasInputGroup = "HasInputGroup";

        /// <remarks />
        public const string HasOutputGroup = "HasOutputGroup";

        /// <remarks />
        public const string HasPart = "HasPart";

        /// <remarks />
        public const string HasSubFunctionalEntity = "HasSubFunctionalEntity";

        /// <remarks />
        public const string http___opcfoundation_org_UA_FX_AC_ = "http://opcfoundation.org/UA/FX/AC/";

        /// <remarks />
        public const string IAssetRevisionType = "IAssetRevisionType";

        /// <remarks />
        public const string Id = "Id";

        /// <remarks />
        public const string IFunctionalEntityType = "IFunctionalEntityType";

        /// <remarks />
        public const string InputData = "InputData";

        /// <remarks />
        public const string InputGroup = "<InputGroup>";

        /// <remarks />
        public const string InputsFolderType = "InputsFolderType";

        /// <remarks />
        public const string InputVariable = "<InputVariable>";

        /// <remarks />
        public const string InputVariables = "InputVariables";

        /// <remarks />
        public const string IntervalRange = "IntervalRange";

        /// <remarks />
        public const string IsControlled = "IsControlled";

        /// <remarks />
        public const string IsPartOfRedundantAssetSet = "IsPartOfRedundantAssetSet";

        /// <remarks />
        public const string IsPersistent = "IsPersistent";

        /// <remarks />
        public const string Kind = "Kind";

        /// <remarks />
        public const string ListOfRelated = "ListOfRelated";

        /// <remarks />
        public const string ListStoredVariables = "ListStoredVariables";

        /// <remarks />
        public const string ListStoredVariablesMethodType = "ListStoredVariablesMethodType";

        /// <remarks />
        public const string ListToBlock = "ListToBlock";

        /// <remarks />
        public const string ListToRestrict = "ListToRestrict";

        /// <remarks />
        public const string Lock = "Lock";

        /// <remarks />
        public const string LogicalId = "LogicalId";

        /// <remarks />
        public const string MajorAssetVersion = "MajorAssetVersion";

        /// <remarks />
        public const string MaxConnections = "MaxConnections";

        /// <remarks />
        public const string MaxConnectionsPerCall = "MaxConnectionsPerCall";

        /// <remarks />
        public const string MaxFunctionalEntities = "MaxFunctionalEntities";

        /// <remarks />
        public const string MaxInactiveLockTime = "MaxInactiveLockTime";

        /// <remarks />
        public const string MinorAssetVersion = "MinorAssetVersion";

        /// <remarks />
        public const string Mode = "Mode";

        /// <remarks />
        public const string Name = "Name";

        /// <remarks />
        public const string OperationalHealth = "OperationalHealth";

        /// <remarks />
        public const string OperationalHealthAlarms = "OperationalHealthAlarms";

        /// <remarks />
        public const string OperationalHealthOptionSet = "OperationalHealthOptionSet";

        /// <remarks />
        public const string OutputData = "OutputData";

        /// <remarks />
        public const string OutputGroup = "<OutputGroup>";

        /// <remarks />
        public const string OutputsFolderType = "OutputsFolderType";

        /// <remarks />
        public const string OutputVariable = "<OutputVariable>";

        /// <remarks />
        public const string OutputVariables = "OutputVariables";

        /// <remarks />
        public const string PreconfiguredDataSetOnly = "PreconfiguredDataSetOnly";

        /// <remarks />
        public const string PreconfiguredPublishedDataSets = "PreconfiguredPublishedDataSets";

        /// <remarks />
        public const string PreconfiguredSubscribedDataSets = "PreconfiguredSubscribedDataSets";

        /// <remarks />
        public const string PublisherCapabilities = "PublisherCapabilities";

        /// <remarks />
        public const string PublisherCapabilitiesType = "PublisherCapabilitiesType";

        /// <remarks />
        public const string PublisherQosDataType = "PublisherQosDataType";

        /// <remarks />
        public const string PubSubConnectionEndpointType = "PubSubConnectionEndpointType";

        /// <remarks />
        public const string ReassignControl = "ReassignControl";

        /// <remarks />
        public const string ReassignControlMethodType = "ReassignControlMethodType";

        /// <remarks />
        public const string RelatedEndpoint = "RelatedEndpoint";

        /// <remarks />
        public const string ReleaseControl = "ReleaseControl";

        /// <remarks />
        public const string RemovedEndpoint = "RemovedEndpoint";

        /// <remarks />
        public const string SetStoredVariables = "SetStoredVariables";

        /// <remarks />
        public const string SetStoredVariablesMethodType = "SetStoredVariablesMethodType";

        /// <remarks />
        public const string SlotType = "SlotType";

        /// <remarks />
        public const string SocketKindEnum = "SocketKindEnum";

        /// <remarks />
        public const string SocketType = "SocketType";

        /// <remarks />
        public const string Status = "Status";

        /// <remarks />
        public const string SubBuildAssetNumber = "SubBuildAssetNumber";

        /// <remarks />
        public const string SubFunctionalEntity = "<SubFunctionalEntity>";

        /// <remarks />
        public const string SubscriberCapabilities = "SubscriberCapabilities";

        /// <remarks />
        public const string SubscriberCapabilitiesType = "SubscriberCapabilitiesType";

        /// <remarks />
        public const string SubscriberQosDataType = "SubscriberQosDataType";

        /// <remarks />
        public const string SupportedMessageReceiveTimeouts = "SupportedMessageReceiveTimeouts";

        /// <remarks />
        public const string SupportedPublishingIntervals = "SupportedPublishingIntervals";

        /// <remarks />
        public const string SupportedQos = "SupportedQos";

        /// <remarks />
        public const string SupportsPersistence = "SupportsPersistence";

        /// <remarks />
        public const string ToDataSetReader = "ToDataSetReader";

        /// <remarks />
        public const string ToDataSetWriter = "ToDataSetWriter";

        /// <remarks />
        public const string TypeDictionary_BinarySchema = "TypeDictionary";

        /// <remarks />
        public const string TypeDictionary_XmlSchema = "TypeDictionary";

        /// <remarks />
        public const string Verify = "Verify";

        /// <remarks />
        public const string VerifyAsset = "VerifyAsset";

        /// <remarks />
        public const string VerifyAssetMethodType = "VerifyAssetMethodType";

        /// <remarks />
        public const string VerifyMethodType = "VerifyMethodType";
    }
    #endregion

    #region Namespace Declarations
    /// <remarks />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Namespaces
    {
        /// <summary>
        /// The URI for the FXAC namespace (.NET code namespace is 'UAModel.FXAC').
        /// </summary>
        public const string FXAC = "http://opcfoundation.org/UA/FX/AC/";

        /// <summary>
        /// The URI for the OpcUa namespace (.NET code namespace is 'Opc.Ua').
        /// </summary>
        public const string OpcUa = "http://opcfoundation.org/UA/";

        /// <summary>
        /// The URI for the OpcUaXsd namespace (.NET code namespace is 'Opc.Ua').
        /// </summary>
        public const string OpcUaXsd = "http://opcfoundation.org/UA/2008/02/Types.xsd";

        /// <summary>
        /// The URI for the DI namespace (.NET code namespace is 'UAModel.DI').
        /// </summary>
        public const string DI = "http://opcfoundation.org/UA/DI/";

        /// <summary>
        /// The URI for the FXData namespace (.NET code namespace is 'UAModel.FXData').
        /// </summary>
        public const string FXData = "http://opcfoundation.org/UA/FX/Data/";
    }
    #endregion
}