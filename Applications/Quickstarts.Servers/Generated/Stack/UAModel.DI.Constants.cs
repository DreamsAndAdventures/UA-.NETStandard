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

namespace UAModel.DI
{
    #region DataType Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class DataTypes
    {
        /// <remarks />
        public const uint DeviceHealthEnumeration = 6244;

        /// <remarks />
        public const uint FetchResultDataType = 6522;

        /// <remarks />
        public const uint TransferResultErrorDataType = 15888;

        /// <remarks />
        public const uint TransferResultDataDataType = 15889;

        /// <remarks />
        public const uint ParameterResultDataType = 6525;

        /// <remarks />
        public const uint SoftwareVersionFileType = 331;

        /// <remarks />
        public const uint UpdateBehavior = 333;
    }
    #endregion

    #region Method Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Methods
    {
        /// <remarks />
        public const uint TopologyElementType_Lock_InitLock = 6166;

        /// <remarks />
        public const uint TopologyElementType_Lock_RenewLock = 6169;

        /// <remarks />
        public const uint TopologyElementType_Lock_ExitLock = 6171;

        /// <remarks />
        public const uint TopologyElementType_Lock_BreakLock = 6173;

        /// <remarks />
        public const uint ISupportInfoType_DocumentationFiles_DocumentFileId_Open = 36;

        /// <remarks />
        public const uint ISupportInfoType_DocumentationFiles_DocumentFileId_Close = 39;

        /// <remarks />
        public const uint ISupportInfoType_DocumentationFiles_DocumentFileId_Read = 63;

        /// <remarks />
        public const uint ISupportInfoType_DocumentationFiles_DocumentFileId_Write = 66;

        /// <remarks />
        public const uint ISupportInfoType_DocumentationFiles_DocumentFileId_GetPosition = 68;

        /// <remarks />
        public const uint ISupportInfoType_DocumentationFiles_DocumentFileId_SetPosition = 71;

        /// <remarks />
        public const uint ComponentType_Lock_InitLock = 6166;

        /// <remarks />
        public const uint ComponentType_Lock_RenewLock = 6169;

        /// <remarks />
        public const uint ComponentType_Lock_ExitLock = 6171;

        /// <remarks />
        public const uint ComponentType_Lock_BreakLock = 6173;

        /// <remarks />
        public const uint DeviceType_Lock_InitLock = 6166;

        /// <remarks />
        public const uint DeviceType_Lock_RenewLock = 6169;

        /// <remarks />
        public const uint DeviceType_Lock_ExitLock = 6171;

        /// <remarks />
        public const uint DeviceType_Lock_BreakLock = 6173;

        /// <remarks />
        public const uint DeviceType_CPIdentifier_Lock_InitLock = 6166;

        /// <remarks />
        public const uint DeviceType_CPIdentifier_Lock_RenewLock = 6169;

        /// <remarks />
        public const uint DeviceType_CPIdentifier_Lock_ExitLock = 6171;

        /// <remarks />
        public const uint DeviceType_CPIdentifier_Lock_BreakLock = 6173;

        /// <remarks />
        public const uint SoftwareType_Lock_InitLock = 6166;

        /// <remarks />
        public const uint SoftwareType_Lock_RenewLock = 6169;

        /// <remarks />
        public const uint SoftwareType_Lock_ExitLock = 6171;

        /// <remarks />
        public const uint SoftwareType_Lock_BreakLock = 6173;

        /// <remarks />
        public const uint BlockType_Lock_InitLock = 6166;

        /// <remarks />
        public const uint BlockType_Lock_RenewLock = 6169;

        /// <remarks />
        public const uint BlockType_Lock_ExitLock = 6171;

        /// <remarks />
        public const uint BlockType_Lock_BreakLock = 6173;

        /// <remarks />
        public const uint NetworkType_CPIdentifier_Lock_InitLock = 6166;

        /// <remarks />
        public const uint NetworkType_CPIdentifier_Lock_RenewLock = 6169;

        /// <remarks />
        public const uint NetworkType_CPIdentifier_Lock_ExitLock = 6171;

        /// <remarks />
        public const uint NetworkType_CPIdentifier_Lock_BreakLock = 6173;

        /// <remarks />
        public const uint NetworkType_Lock_InitLock = 6299;

        /// <remarks />
        public const uint NetworkType_Lock_RenewLock = 6302;

        /// <remarks />
        public const uint NetworkType_Lock_ExitLock = 6304;

        /// <remarks />
        public const uint NetworkType_Lock_BreakLock = 6306;

        /// <remarks />
        public const uint ConnectionPointType_Lock_InitLock = 6166;

        /// <remarks />
        public const uint ConnectionPointType_Lock_RenewLock = 6169;

        /// <remarks />
        public const uint ConnectionPointType_Lock_ExitLock = 6171;

        /// <remarks />
        public const uint ConnectionPointType_Lock_BreakLock = 6173;

        /// <remarks />
        public const uint ConnectionPointType_NetworkIdentifier_Lock_InitLock = 6299;

        /// <remarks />
        public const uint ConnectionPointType_NetworkIdentifier_Lock_RenewLock = 6302;

        /// <remarks />
        public const uint ConnectionPointType_NetworkIdentifier_Lock_ExitLock = 6304;

        /// <remarks />
        public const uint ConnectionPointType_NetworkIdentifier_Lock_BreakLock = 6306;

        /// <remarks />
        public const uint TransferServicesType_TransferToDevice = 6527;

        /// <remarks />
        public const uint TransferServicesType_TransferFromDevice = 6529;

        /// <remarks />
        public const uint TransferServicesType_FetchTransferResultData = 6531;

        /// <remarks />
        public const uint LockingServicesType_InitLock = 6393;

        /// <remarks />
        public const uint LockingServicesType_RenewLock = 6396;

        /// <remarks />
        public const uint LockingServicesType_ExitLock = 6398;

        /// <remarks />
        public const uint LockingServicesType_BreakLock = 6400;

        /// <remarks />
        public const uint SoftwareUpdateType_PrepareForUpdate_Prepare = 19;

        /// <remarks />
        public const uint SoftwareUpdateType_PrepareForUpdate_Abort = 20;

        /// <remarks />
        public const uint SoftwareUpdateType_Installation_Resume = 61;

        /// <remarks />
        public const uint SoftwareUpdateType_Confirmation_Confirm = 112;

        /// <remarks />
        public const uint SoftwareUpdateType_Parameters_GenerateFileForRead = 124;

        /// <remarks />
        public const uint SoftwareUpdateType_Parameters_GenerateFileForWrite = 127;

        /// <remarks />
        public const uint SoftwareUpdateType_Parameters_CloseAndCommit = 130;

        /// <remarks />
        public const uint PackageLoadingType_FileTransfer_GenerateFileForRead = 142;

        /// <remarks />
        public const uint PackageLoadingType_FileTransfer_GenerateFileForWrite = 145;

        /// <remarks />
        public const uint PackageLoadingType_FileTransfer_CloseAndCommit = 148;

        /// <remarks />
        public const uint DirectLoadingType_FileTransfer_GenerateFileForRead = 142;

        /// <remarks />
        public const uint DirectLoadingType_FileTransfer_GenerateFileForWrite = 145;

        /// <remarks />
        public const uint DirectLoadingType_FileTransfer_CloseAndCommit = 148;

        /// <remarks />
        public const uint CachedLoadingType_FileTransfer_GenerateFileForRead = 142;

        /// <remarks />
        public const uint CachedLoadingType_FileTransfer_GenerateFileForWrite = 145;

        /// <remarks />
        public const uint CachedLoadingType_FileTransfer_CloseAndCommit = 148;

        /// <remarks />
        public const uint CachedLoadingType_GetUpdateBehavior = 189;

        /// <remarks />
        public const uint FileSystemLoadingType_FileSystem_CreateDirectory = 195;

        /// <remarks />
        public const uint FileSystemLoadingType_FileSystem_CreateFile = 198;

        /// <remarks />
        public const uint FileSystemLoadingType_FileSystem_DeleteFileSystemObject = 201;

        /// <remarks />
        public const uint FileSystemLoadingType_FileSystem_MoveOrCopy = 203;

        /// <remarks />
        public const uint FileSystemLoadingType_GetUpdateBehavior = 206;

        /// <remarks />
        public const uint FileSystemLoadingType_ValidateFiles = 209;

        /// <remarks />
        public const uint PrepareForUpdateStateMachineType_Prepare = 228;

        /// <remarks />
        public const uint PrepareForUpdateStateMachineType_Abort = 229;

        /// <remarks />
        public const uint PrepareForUpdateStateMachineType_Resume = 230;

        /// <remarks />
        public const uint InstallationStateMachineType_InstallSoftwarePackage = 265;

        /// <remarks />
        public const uint InstallationStateMachineType_InstallFiles = 268;

        /// <remarks />
        public const uint InstallationStateMachineType_Resume = 270;

        /// <remarks />
        public const uint ConfirmationStateMachineType_Confirm = 321;

        /// <remarks />
        public const string LockingServicesType_InitLockMethodType = "";

        /// <remarks />
        public const string LockingServicesType_RenewLockMethodType = "";

        /// <remarks />
        public const string LockingServicesType_ExitLockMethodType = "";

        /// <remarks />
        public const string LockingServicesType_BreakLockMethodType = "";

        /// <remarks />
        public const string TransferServicesType_TransferToDeviceMethodType = "";

        /// <remarks />
        public const string TransferServicesType_TransferFromDeviceMethodType = "";

        /// <remarks />
        public const string TransferServicesType_FetchTransferResultDataMethodType = "";

        /// <remarks />
        public const string CachedLoadingType_GetUpdateBehaviorMethodType = "";

        /// <remarks />
        public const string FileSystemLoadingType_ValidateFilesMethodType = "";

        /// <remarks />
        public const string InstallationStateMachineType_InstallSoftwarePackageMethodType = "";

        /// <remarks />
        public const string InstallationStateMachineType_InstallFilesMethodType = "";
    }
    #endregion

    #region Object Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Objects
    {
        /// <remarks />
        public const uint OPCUADINamespaceMetadata = 15001;

        /// <remarks />
        public const uint DeviceSet = 5001;

        /// <remarks />
        public const uint DeviceFeatures = 15034;

        /// <remarks />
        public const uint NetworkSet = 6078;

        /// <remarks />
        public const uint DeviceTopology = 6094;

        /// <remarks />
        public const uint TopologyElementType_ParameterSet = 5002;

        /// <remarks />
        public const uint TopologyElementType_MethodSet = 5003;

        /// <remarks />
        public const uint TopologyElementType_GroupIdentifier = 6567;

        /// <remarks />
        public const uint TopologyElementType_Identification = 6014;

        /// <remarks />
        public const uint TopologyElementType_Lock = 6161;

        /// <remarks />
        public const uint IDeviceHealthType_DeviceHealthAlarms = 15053;

        /// <remarks />
        public const uint ISupportInfoType_DeviceTypeImage = 15055;

        /// <remarks />
        public const uint ISupportInfoType_Documentation = 15057;

        /// <remarks />
        public const uint ISupportInfoType_DocumentationFiles = 27;

        /// <remarks />
        public const uint ISupportInfoType_DocumentationFiles_DocumentFileId = 28;

        /// <remarks />
        public const uint ISupportInfoType_ProtocolSupport = 15059;

        /// <remarks />
        public const uint ISupportInfoType_ImageSet = 15061;

        /// <remarks />
        public const uint DeviceType_CPIdentifier = 6571;

        /// <remarks />
        public const uint DeviceType_CPIdentifier_NetworkAddress = 6592;

        /// <remarks />
        public const uint DeviceType_DeviceHealthAlarms = 15105;

        /// <remarks />
        public const uint DeviceType_DeviceTypeImage = 6209;

        /// <remarks />
        public const uint DeviceType_Documentation = 6211;

        /// <remarks />
        public const uint DeviceType_ProtocolSupport = 6213;

        /// <remarks />
        public const uint DeviceType_ImageSet = 6215;

        /// <remarks />
        public const uint ConfigurableObjectType_SupportedTypes = 5004;

        /// <remarks />
        public const uint ConfigurableObjectType_ObjectIdentifier = 6026;

        /// <remarks />
        public const uint FunctionalGroupType_GroupIdentifier = 6027;

        /// <remarks />
        public const uint NetworkType_ProfileIdentifier = 6596;

        /// <remarks />
        public const uint NetworkType_CPIdentifier = 6248;

        /// <remarks />
        public const uint NetworkType_CPIdentifier_NetworkAddress = 6292;

        /// <remarks />
        public const uint NetworkType_Lock = 6294;

        /// <remarks />
        public const uint ConnectionPointType_NetworkAddress = 6354;

        /// <remarks />
        public const uint ConnectionPointType_ProfileIdentifier = 6499;

        /// <remarks />
        public const uint ConnectionPointType_NetworkIdentifier = 6599;

        /// <remarks />
        public const uint SoftwareUpdateType_Loading = 2;

        /// <remarks />
        public const uint SoftwareUpdateType_PrepareForUpdate = 4;

        /// <remarks />
        public const uint SoftwareUpdateType_Installation = 40;

        /// <remarks />
        public const uint SoftwareUpdateType_PowerCycle = 76;

        /// <remarks />
        public const uint SoftwareUpdateType_Confirmation = 98;

        /// <remarks />
        public const uint SoftwareUpdateType_Parameters = 122;

        /// <remarks />
        public const uint PackageLoadingType_CurrentVersion = 139;

        /// <remarks />
        public const uint PackageLoadingType_FileTransfer = 140;

        /// <remarks />
        public const uint CachedLoadingType_PendingVersion = 187;

        /// <remarks />
        public const uint CachedLoadingType_FallbackVersion = 188;

        /// <remarks />
        public const uint FileSystemLoadingType_FileSystem = 194;

        /// <remarks />
        public const uint PrepareForUpdateStateMachineType_Idle = 231;

        /// <remarks />
        public const uint PrepareForUpdateStateMachineType_Preparing = 233;

        /// <remarks />
        public const uint PrepareForUpdateStateMachineType_PreparedForUpdate = 235;

        /// <remarks />
        public const uint PrepareForUpdateStateMachineType_Resuming = 237;

        /// <remarks />
        public const uint PrepareForUpdateStateMachineType_IdleToPreparing = 239;

        /// <remarks />
        public const uint PrepareForUpdateStateMachineType_PreparingToIdle = 241;

        /// <remarks />
        public const uint PrepareForUpdateStateMachineType_PreparingToPreparedForUpdate = 243;

        /// <remarks />
        public const uint PrepareForUpdateStateMachineType_PreparedForUpdateToResuming = 245;

        /// <remarks />
        public const uint PrepareForUpdateStateMachineType_ResumingToIdle = 247;

        /// <remarks />
        public const uint InstallationStateMachineType_Idle = 271;

        /// <remarks />
        public const uint InstallationStateMachineType_Installing = 273;

        /// <remarks />
        public const uint InstallationStateMachineType_Error = 275;

        /// <remarks />
        public const uint InstallationStateMachineType_IdleToInstalling = 277;

        /// <remarks />
        public const uint InstallationStateMachineType_InstallingToIdle = 279;

        /// <remarks />
        public const uint InstallationStateMachineType_InstallingToError = 281;

        /// <remarks />
        public const uint InstallationStateMachineType_ErrorToIdle = 283;

        /// <remarks />
        public const uint PowerCycleStateMachineType_NotWaitingForPowerCycle = 299;

        /// <remarks />
        public const uint PowerCycleStateMachineType_WaitingForPowerCycle = 301;

        /// <remarks />
        public const uint PowerCycleStateMachineType_NotWaitingForPowerCycleToWaitingForPowerCycle = 303;

        /// <remarks />
        public const uint PowerCycleStateMachineType_WaitingForPowerCycleToNotWaitingForPowerCycle = 305;

        /// <remarks />
        public const uint ConfirmationStateMachineType_NotWaitingForConfirm = 323;

        /// <remarks />
        public const uint ConfirmationStateMachineType_WaitingForConfirm = 325;

        /// <remarks />
        public const uint ConfirmationStateMachineType_NotWaitingForConfirmToWaitingForConfirm = 327;

        /// <remarks />
        public const uint ConfirmationStateMachineType_WaitingForConfirmToNotWaitingForConfirm = 329;

        /// <remarks />
        public const uint FetchResultDataType_Encoding_DefaultBinary = 6551;

        /// <remarks />
        public const uint TransferResultErrorDataType_Encoding_DefaultBinary = 15891;

        /// <remarks />
        public const uint TransferResultDataDataType_Encoding_DefaultBinary = 15892;

        /// <remarks />
        public const uint ParameterResultDataType_Encoding_DefaultBinary = 6554;

        /// <remarks />
        public const uint FetchResultDataType_Encoding_DefaultXml = 6535;

        /// <remarks />
        public const uint TransferResultErrorDataType_Encoding_DefaultXml = 15900;

        /// <remarks />
        public const uint TransferResultDataDataType_Encoding_DefaultXml = 15901;

        /// <remarks />
        public const uint ParameterResultDataType_Encoding_DefaultXml = 6538;

        /// <remarks />
        public const uint FetchResultDataType_Encoding_DefaultJson = 15909;

        /// <remarks />
        public const uint TransferResultErrorDataType_Encoding_DefaultJson = 15910;

        /// <remarks />
        public const uint TransferResultDataDataType_Encoding_DefaultJson = 15911;

        /// <remarks />
        public const uint ParameterResultDataType_Encoding_DefaultJson = 15912;
    }
    #endregion

    #region ObjectType Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectTypes
    {
        /// <remarks />
        public const uint TopologyElementType = 1001;

        /// <remarks />
        public const uint IVendorNameplateType = 15035;

        /// <remarks />
        public const uint ITagNameplateType = 15048;

        /// <remarks />
        public const uint IDeviceHealthType = 15051;

        /// <remarks />
        public const uint ISupportInfoType = 15054;

        /// <remarks />
        public const uint ComponentType = 15063;

        /// <remarks />
        public const uint DeviceType = 1002;

        /// <remarks />
        public const uint SoftwareType = 15106;

        /// <remarks />
        public const uint BlockType = 1003;

        /// <remarks />
        public const uint DeviceHealthDiagnosticAlarmType = 15143;

        /// <remarks />
        public const uint FailureAlarmType = 15292;

        /// <remarks />
        public const uint CheckFunctionAlarmType = 15441;

        /// <remarks />
        public const uint OffSpecAlarmType = 15590;

        /// <remarks />
        public const uint MaintenanceRequiredAlarmType = 15739;

        /// <remarks />
        public const uint ConfigurableObjectType = 1004;

        /// <remarks />
        public const uint BaseLifetimeIndicationType = 473;

        /// <remarks />
        public const uint TimeIndicationType = 474;

        /// <remarks />
        public const uint NumberOfPartsIndicationType = 475;

        /// <remarks />
        public const uint NumberOfUsagesIndicationType = 476;

        /// <remarks />
        public const uint LengthIndicationType = 477;

        /// <remarks />
        public const uint DiameterIndicationType = 478;

        /// <remarks />
        public const uint SubstanceVolumeIndicationType = 479;

        /// <remarks />
        public const uint FunctionalGroupType = 1005;

        /// <remarks />
        public const uint ProtocolType = 1006;

        /// <remarks />
        public const uint IOperationCounterType = 480;

        /// <remarks />
        public const uint NetworkType = 6247;

        /// <remarks />
        public const uint ConnectionPointType = 6308;

        /// <remarks />
        public const uint TransferServicesType = 6526;

        /// <remarks />
        public const uint LockingServicesType = 6388;

        /// <remarks />
        public const uint SoftwareUpdateType = 1;

        /// <remarks />
        public const uint SoftwareLoadingType = 135;

        /// <remarks />
        public const uint PackageLoadingType = 137;

        /// <remarks />
        public const uint DirectLoadingType = 153;

        /// <remarks />
        public const uint CachedLoadingType = 171;

        /// <remarks />
        public const uint FileSystemLoadingType = 192;

        /// <remarks />
        public const uint SoftwareVersionType = 212;

        /// <remarks />
        public const uint PrepareForUpdateStateMachineType = 213;

        /// <remarks />
        public const uint InstallationStateMachineType = 249;

        /// <remarks />
        public const uint PowerCycleStateMachineType = 285;

        /// <remarks />
        public const uint ConfirmationStateMachineType = 307;
    }
    #endregion

    #region ReferenceType Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ReferenceTypes
    {
        /// <remarks />
        public const uint ConnectsTo = 6030;

        /// <remarks />
        public const uint ConnectsToParent = 6467;

        /// <remarks />
        public const uint IsOnline = 6031;
    }
    #endregion

    #region Variable Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Variables
    {
        /// <remarks />
        public const uint OPCUADINamespaceMetadata_NamespaceUri = 15002;

        /// <remarks />
        public const uint OPCUADINamespaceMetadata_NamespaceVersion = 15003;

        /// <remarks />
        public const uint OPCUADINamespaceMetadata_NamespacePublicationDate = 15004;

        /// <remarks />
        public const uint OPCUADINamespaceMetadata_IsNamespaceSubset = 15005;

        /// <remarks />
        public const uint OPCUADINamespaceMetadata_StaticNodeIdTypes = 15006;

        /// <remarks />
        public const uint OPCUADINamespaceMetadata_StaticNumericNodeIdRange = 15007;

        /// <remarks />
        public const uint OPCUADINamespaceMetadata_StaticStringNodeIdPattern = 15008;

        /// <remarks />
        public const uint TopologyElementType_ParameterSet_ParameterIdentifier = 6017;

        /// <remarks />
        public const uint TopologyElementType_Lock_Locked = 6468;

        /// <remarks />
        public const uint TopologyElementType_Lock_LockingClient = 6163;

        /// <remarks />
        public const uint TopologyElementType_Lock_LockingUser = 6164;

        /// <remarks />
        public const uint TopologyElementType_Lock_RemainingLockTime = 6165;

        /// <remarks />
        public const uint TopologyElementType_Lock_InitLock_InputArguments = 6167;

        /// <remarks />
        public const uint TopologyElementType_Lock_InitLock_OutputArguments = 6168;

        /// <remarks />
        public const uint TopologyElementType_Lock_RenewLock_OutputArguments = 6170;

        /// <remarks />
        public const uint TopologyElementType_Lock_ExitLock_OutputArguments = 6172;

        /// <remarks />
        public const uint TopologyElementType_Lock_BreakLock_OutputArguments = 6174;

        /// <remarks />
        public const uint IVendorNameplateType_Manufacturer = 15036;

        /// <remarks />
        public const uint IVendorNameplateType_ManufacturerUri = 15037;

        /// <remarks />
        public const uint IVendorNameplateType_Model = 15038;

        /// <remarks />
        public const uint IVendorNameplateType_HardwareRevision = 15039;

        /// <remarks />
        public const uint IVendorNameplateType_SoftwareRevision = 15040;

        /// <remarks />
        public const uint IVendorNameplateType_DeviceRevision = 15041;

        /// <remarks />
        public const uint IVendorNameplateType_ProductCode = 15042;

        /// <remarks />
        public const uint IVendorNameplateType_DeviceManual = 15043;

        /// <remarks />
        public const uint IVendorNameplateType_DeviceClass = 15044;

        /// <remarks />
        public const uint IVendorNameplateType_SerialNumber = 15045;

        /// <remarks />
        public const uint IVendorNameplateType_ProductInstanceUri = 15046;

        /// <remarks />
        public const uint IVendorNameplateType_RevisionCounter = 15047;

        /// <remarks />
        public const uint IVendorNameplateType_SoftwareReleaseDate = 23;

        /// <remarks />
        public const uint IVendorNameplateType_PatchIdentifiers = 24;

        /// <remarks />
        public const uint ITagNameplateType_AssetId = 15049;

        /// <remarks />
        public const uint ITagNameplateType_ComponentName = 15050;

        /// <remarks />
        public const uint IDeviceHealthType_DeviceHealth = 15052;

        /// <remarks />
        public const uint ISupportInfoType_DeviceTypeImage_ImageIdentifier = 15056;

        /// <remarks />
        public const uint ISupportInfoType_Documentation_DocumentIdentifier = 15058;

        /// <remarks />
        public const uint ISupportInfoType_DocumentationFiles_DocumentFileId_Size = 29;

        /// <remarks />
        public const uint ISupportInfoType_DocumentationFiles_DocumentFileId_Writable = 30;

        /// <remarks />
        public const uint ISupportInfoType_DocumentationFiles_DocumentFileId_UserWritable = 31;

        /// <remarks />
        public const uint ISupportInfoType_DocumentationFiles_DocumentFileId_OpenCount = 32;

        /// <remarks />
        public const uint ISupportInfoType_DocumentationFiles_DocumentFileId_Open_InputArguments = 37;

        /// <remarks />
        public const uint ISupportInfoType_DocumentationFiles_DocumentFileId_Open_OutputArguments = 38;

        /// <remarks />
        public const uint ISupportInfoType_DocumentationFiles_DocumentFileId_Close_InputArguments = 62;

        /// <remarks />
        public const uint ISupportInfoType_DocumentationFiles_DocumentFileId_Read_InputArguments = 64;

        /// <remarks />
        public const uint ISupportInfoType_DocumentationFiles_DocumentFileId_Read_OutputArguments = 65;

        /// <remarks />
        public const uint ISupportInfoType_DocumentationFiles_DocumentFileId_Write_InputArguments = 67;

        /// <remarks />
        public const uint ISupportInfoType_DocumentationFiles_DocumentFileId_GetPosition_InputArguments = 69;

        /// <remarks />
        public const uint ISupportInfoType_DocumentationFiles_DocumentFileId_GetPosition_OutputArguments = 70;

        /// <remarks />
        public const uint ISupportInfoType_DocumentationFiles_DocumentFileId_SetPosition_InputArguments = 72;

        /// <remarks />
        public const uint ISupportInfoType_ProtocolSupport_ProtocolSupportIdentifier = 15060;

        /// <remarks />
        public const uint ISupportInfoType_ImageSet_ImageIdentifier = 15062;

        /// <remarks />
        public const uint ComponentType_Lock_Locked = 6468;

        /// <remarks />
        public const uint ComponentType_Lock_LockingClient = 6163;

        /// <remarks />
        public const uint ComponentType_Lock_LockingUser = 6164;

        /// <remarks />
        public const uint ComponentType_Lock_RemainingLockTime = 6165;

        /// <remarks />
        public const uint ComponentType_Lock_InitLock_InputArguments = 6167;

        /// <remarks />
        public const uint ComponentType_Lock_InitLock_OutputArguments = 6168;

        /// <remarks />
        public const uint ComponentType_Lock_RenewLock_OutputArguments = 6170;

        /// <remarks />
        public const uint ComponentType_Lock_ExitLock_OutputArguments = 6172;

        /// <remarks />
        public const uint ComponentType_Lock_BreakLock_OutputArguments = 6174;

        /// <remarks />
        public const uint ComponentType_Manufacturer = 15086;

        /// <remarks />
        public const uint ComponentType_ManufacturerUri = 15087;

        /// <remarks />
        public const uint ComponentType_Model = 15088;

        /// <remarks />
        public const uint ComponentType_HardwareRevision = 15089;

        /// <remarks />
        public const uint ComponentType_SoftwareRevision = 15090;

        /// <remarks />
        public const uint ComponentType_DeviceRevision = 15091;

        /// <remarks />
        public const uint ComponentType_ProductCode = 15092;

        /// <remarks />
        public const uint ComponentType_DeviceManual = 15093;

        /// <remarks />
        public const uint ComponentType_DeviceClass = 15094;

        /// <remarks />
        public const uint ComponentType_SerialNumber = 15095;

        /// <remarks />
        public const uint ComponentType_ProductInstanceUri = 15096;

        /// <remarks />
        public const uint ComponentType_RevisionCounter = 15097;

        /// <remarks />
        public const uint ComponentType_AssetId = 15098;

        /// <remarks />
        public const uint ComponentType_ComponentName = 15099;

        /// <remarks />
        public const uint DeviceType_Lock_Locked = 6468;

        /// <remarks />
        public const uint DeviceType_Lock_LockingClient = 6163;

        /// <remarks />
        public const uint DeviceType_Lock_LockingUser = 6164;

        /// <remarks />
        public const uint DeviceType_Lock_RemainingLockTime = 6165;

        /// <remarks />
        public const uint DeviceType_Lock_InitLock_InputArguments = 6167;

        /// <remarks />
        public const uint DeviceType_Lock_InitLock_OutputArguments = 6168;

        /// <remarks />
        public const uint DeviceType_Lock_RenewLock_OutputArguments = 6170;

        /// <remarks />
        public const uint DeviceType_Lock_ExitLock_OutputArguments = 6172;

        /// <remarks />
        public const uint DeviceType_Lock_BreakLock_OutputArguments = 6174;

        /// <remarks />
        public const uint DeviceType_Manufacturer = 6003;

        /// <remarks />
        public const uint DeviceType_ManufacturerUri = 15100;

        /// <remarks />
        public const uint DeviceType_Model = 6004;

        /// <remarks />
        public const uint DeviceType_HardwareRevision = 6008;

        /// <remarks />
        public const uint DeviceType_SoftwareRevision = 6007;

        /// <remarks />
        public const uint DeviceType_DeviceRevision = 6006;

        /// <remarks />
        public const uint DeviceType_ProductCode = 15101;

        /// <remarks />
        public const uint DeviceType_DeviceManual = 6005;

        /// <remarks />
        public const uint DeviceType_DeviceClass = 6470;

        /// <remarks />
        public const uint DeviceType_SerialNumber = 6001;

        /// <remarks />
        public const uint DeviceType_ProductInstanceUri = 15102;

        /// <remarks />
        public const uint DeviceType_RevisionCounter = 6002;

        /// <remarks />
        public const uint DeviceType_CPIdentifier_Lock_Locked = 6468;

        /// <remarks />
        public const uint DeviceType_CPIdentifier_Lock_LockingClient = 6163;

        /// <remarks />
        public const uint DeviceType_CPIdentifier_Lock_LockingUser = 6164;

        /// <remarks />
        public const uint DeviceType_CPIdentifier_Lock_RemainingLockTime = 6165;

        /// <remarks />
        public const uint DeviceType_CPIdentifier_Lock_InitLock_InputArguments = 6167;

        /// <remarks />
        public const uint DeviceType_CPIdentifier_Lock_InitLock_OutputArguments = 6168;

        /// <remarks />
        public const uint DeviceType_CPIdentifier_Lock_RenewLock_OutputArguments = 6170;

        /// <remarks />
        public const uint DeviceType_CPIdentifier_Lock_ExitLock_OutputArguments = 6172;

        /// <remarks />
        public const uint DeviceType_CPIdentifier_Lock_BreakLock_OutputArguments = 6174;

        /// <remarks />
        public const uint DeviceType_DeviceHealth = 6208;

        /// <remarks />
        public const uint DeviceType_DeviceTypeImage_ImageIdentifier = 6210;

        /// <remarks />
        public const uint DeviceType_Documentation_DocumentIdentifier = 6212;

        /// <remarks />
        public const uint DeviceType_ProtocolSupport_ProtocolSupportIdentifier = 6214;

        /// <remarks />
        public const uint DeviceType_ImageSet_ImageIdentifier = 6216;

        /// <remarks />
        public const uint SoftwareType_Lock_Locked = 6468;

        /// <remarks />
        public const uint SoftwareType_Lock_LockingClient = 6163;

        /// <remarks />
        public const uint SoftwareType_Lock_LockingUser = 6164;

        /// <remarks />
        public const uint SoftwareType_Lock_RemainingLockTime = 6165;

        /// <remarks />
        public const uint SoftwareType_Lock_InitLock_InputArguments = 6167;

        /// <remarks />
        public const uint SoftwareType_Lock_InitLock_OutputArguments = 6168;

        /// <remarks />
        public const uint SoftwareType_Lock_RenewLock_OutputArguments = 6170;

        /// <remarks />
        public const uint SoftwareType_Lock_ExitLock_OutputArguments = 6172;

        /// <remarks />
        public const uint SoftwareType_Lock_BreakLock_OutputArguments = 6174;

        /// <remarks />
        public const uint SoftwareType_Manufacturer = 15129;

        /// <remarks />
        public const uint SoftwareType_Model = 15131;

        /// <remarks />
        public const uint SoftwareType_SoftwareRevision = 15133;

        /// <remarks />
        public const uint BlockType_Lock_Locked = 6468;

        /// <remarks />
        public const uint BlockType_Lock_LockingClient = 6163;

        /// <remarks />
        public const uint BlockType_Lock_LockingUser = 6164;

        /// <remarks />
        public const uint BlockType_Lock_RemainingLockTime = 6165;

        /// <remarks />
        public const uint BlockType_Lock_InitLock_InputArguments = 6167;

        /// <remarks />
        public const uint BlockType_Lock_InitLock_OutputArguments = 6168;

        /// <remarks />
        public const uint BlockType_Lock_RenewLock_OutputArguments = 6170;

        /// <remarks />
        public const uint BlockType_Lock_ExitLock_OutputArguments = 6172;

        /// <remarks />
        public const uint BlockType_Lock_BreakLock_OutputArguments = 6174;

        /// <remarks />
        public const uint BlockType_RevisionCounter = 6009;

        /// <remarks />
        public const uint BlockType_ActualMode = 6010;

        /// <remarks />
        public const uint BlockType_PermittedMode = 6011;

        /// <remarks />
        public const uint BlockType_NormalMode = 6012;

        /// <remarks />
        public const uint BlockType_TargetMode = 6013;

        /// <remarks />
        public const uint LifetimeVariableType_StartValue = 469;

        /// <remarks />
        public const uint LifetimeVariableType_LimitValue = 470;

        /// <remarks />
        public const uint LifetimeVariableType_Indication = 471;

        /// <remarks />
        public const uint LifetimeVariableType_WarningValues = 472;

        /// <remarks />
        public const uint FunctionalGroupType_GroupIdentifier_UIElement = 6242;

        /// <remarks />
        public const uint FunctionalGroupType_UIElement = 6243;

        /// <remarks />
        public const uint DeviceHealthEnumeration_EnumStrings = 6450;

        /// <remarks />
        public const uint IOperationCounterType_PowerOnDuration = 481;

        /// <remarks />
        public const uint IOperationCounterType_OperationDuration = 482;

        /// <remarks />
        public const uint IOperationCounterType_OperationCycleCounter = 483;

        /// <remarks />
        public const uint NetworkType_CPIdentifier_Lock_Locked = 6468;

        /// <remarks />
        public const uint NetworkType_CPIdentifier_Lock_LockingClient = 6163;

        /// <remarks />
        public const uint NetworkType_CPIdentifier_Lock_LockingUser = 6164;

        /// <remarks />
        public const uint NetworkType_CPIdentifier_Lock_RemainingLockTime = 6165;

        /// <remarks />
        public const uint NetworkType_CPIdentifier_Lock_InitLock_InputArguments = 6167;

        /// <remarks />
        public const uint NetworkType_CPIdentifier_Lock_InitLock_OutputArguments = 6168;

        /// <remarks />
        public const uint NetworkType_CPIdentifier_Lock_RenewLock_OutputArguments = 6170;

        /// <remarks />
        public const uint NetworkType_CPIdentifier_Lock_ExitLock_OutputArguments = 6172;

        /// <remarks />
        public const uint NetworkType_CPIdentifier_Lock_BreakLock_OutputArguments = 6174;

        /// <remarks />
        public const uint NetworkType_Lock_Locked = 6497;

        /// <remarks />
        public const uint NetworkType_Lock_LockingClient = 6296;

        /// <remarks />
        public const uint NetworkType_Lock_LockingUser = 6297;

        /// <remarks />
        public const uint NetworkType_Lock_RemainingLockTime = 6298;

        /// <remarks />
        public const uint NetworkType_Lock_InitLock_InputArguments = 6300;

        /// <remarks />
        public const uint NetworkType_Lock_InitLock_OutputArguments = 6301;

        /// <remarks />
        public const uint NetworkType_Lock_RenewLock_OutputArguments = 6303;

        /// <remarks />
        public const uint NetworkType_Lock_ExitLock_OutputArguments = 6305;

        /// <remarks />
        public const uint NetworkType_Lock_BreakLock_OutputArguments = 6307;

        /// <remarks />
        public const uint ConnectionPointType_Lock_Locked = 6468;

        /// <remarks />
        public const uint ConnectionPointType_Lock_LockingClient = 6163;

        /// <remarks />
        public const uint ConnectionPointType_Lock_LockingUser = 6164;

        /// <remarks />
        public const uint ConnectionPointType_Lock_RemainingLockTime = 6165;

        /// <remarks />
        public const uint ConnectionPointType_Lock_InitLock_InputArguments = 6167;

        /// <remarks />
        public const uint ConnectionPointType_Lock_InitLock_OutputArguments = 6168;

        /// <remarks />
        public const uint ConnectionPointType_Lock_RenewLock_OutputArguments = 6170;

        /// <remarks />
        public const uint ConnectionPointType_Lock_ExitLock_OutputArguments = 6172;

        /// <remarks />
        public const uint ConnectionPointType_Lock_BreakLock_OutputArguments = 6174;

        /// <remarks />
        public const uint ConnectionPointType_NetworkIdentifier_Lock_Locked = 6497;

        /// <remarks />
        public const uint ConnectionPointType_NetworkIdentifier_Lock_LockingClient = 6296;

        /// <remarks />
        public const uint ConnectionPointType_NetworkIdentifier_Lock_LockingUser = 6297;

        /// <remarks />
        public const uint ConnectionPointType_NetworkIdentifier_Lock_RemainingLockTime = 6298;

        /// <remarks />
        public const uint ConnectionPointType_NetworkIdentifier_Lock_InitLock_InputArguments = 6300;

        /// <remarks />
        public const uint ConnectionPointType_NetworkIdentifier_Lock_InitLock_OutputArguments = 6301;

        /// <remarks />
        public const uint ConnectionPointType_NetworkIdentifier_Lock_RenewLock_OutputArguments = 6303;

        /// <remarks />
        public const uint ConnectionPointType_NetworkIdentifier_Lock_ExitLock_OutputArguments = 6305;

        /// <remarks />
        public const uint ConnectionPointType_NetworkIdentifier_Lock_BreakLock_OutputArguments = 6307;

        /// <remarks />
        public const uint TransferServicesType_TransferToDevice_OutputArguments = 6528;

        /// <remarks />
        public const uint TransferServicesType_TransferFromDevice_OutputArguments = 6530;

        /// <remarks />
        public const uint TransferServicesType_FetchTransferResultData_InputArguments = 6532;

        /// <remarks />
        public const uint TransferServicesType_FetchTransferResultData_OutputArguments = 6533;

        /// <remarks />
        public const uint MaxInactiveLockTime = 6387;

        /// <remarks />
        public const uint LockingServicesType_DefaultInstanceBrowseName = 15890;

        /// <remarks />
        public const uint LockingServicesType_Locked = 6534;

        /// <remarks />
        public const uint LockingServicesType_LockingClient = 6390;

        /// <remarks />
        public const uint LockingServicesType_LockingUser = 6391;

        /// <remarks />
        public const uint LockingServicesType_RemainingLockTime = 6392;

        /// <remarks />
        public const uint LockingServicesType_InitLock_InputArguments = 6394;

        /// <remarks />
        public const uint LockingServicesType_InitLock_OutputArguments = 6395;

        /// <remarks />
        public const uint LockingServicesType_RenewLock_OutputArguments = 6397;

        /// <remarks />
        public const uint LockingServicesType_ExitLock_OutputArguments = 6399;

        /// <remarks />
        public const uint LockingServicesType_BreakLock_OutputArguments = 6401;

        /// <remarks />
        public const uint SoftwareUpdateType_PrepareForUpdate_CurrentState = 5;

        /// <remarks />
        public const uint SoftwareUpdateType_PrepareForUpdate_CurrentState_Id = 6;

        /// <remarks />
        public const uint SoftwareUpdateType_Installation_CurrentState = 41;

        /// <remarks />
        public const uint SoftwareUpdateType_Installation_CurrentState_Id = 42;

        /// <remarks />
        public const uint SoftwareUpdateType_Installation_InstallSoftwarePackage_InputArguments = 266;

        /// <remarks />
        public const uint SoftwareUpdateType_Installation_InstallFiles_InputArguments = 269;

        /// <remarks />
        public const uint SoftwareUpdateType_PowerCycle_CurrentState = 77;

        /// <remarks />
        public const uint SoftwareUpdateType_PowerCycle_CurrentState_Id = 78;

        /// <remarks />
        public const uint SoftwareUpdateType_Confirmation_CurrentState = 99;

        /// <remarks />
        public const uint SoftwareUpdateType_Confirmation_CurrentState_Id = 100;

        /// <remarks />
        public const uint SoftwareUpdateType_Confirmation_ConfirmationTimeout = 113;

        /// <remarks />
        public const uint SoftwareUpdateType_Parameters_ClientProcessingTimeout = 123;

        /// <remarks />
        public const uint SoftwareUpdateType_Parameters_GenerateFileForRead_InputArguments = 125;

        /// <remarks />
        public const uint SoftwareUpdateType_Parameters_GenerateFileForRead_OutputArguments = 126;

        /// <remarks />
        public const uint SoftwareUpdateType_Parameters_GenerateFileForWrite_InputArguments = 128;

        /// <remarks />
        public const uint SoftwareUpdateType_Parameters_GenerateFileForWrite_OutputArguments = 129;

        /// <remarks />
        public const uint SoftwareUpdateType_Parameters_CloseAndCommit_InputArguments = 131;

        /// <remarks />
        public const uint SoftwareUpdateType_Parameters_CloseAndCommit_OutputArguments = 132;

        /// <remarks />
        public const uint SoftwareUpdateType_UpdateStatus = 133;

        /// <remarks />
        public const uint SoftwareUpdateType_VendorErrorCode = 402;

        /// <remarks />
        public const uint SoftwareUpdateType_DefaultInstanceBrowseName = 134;

        /// <remarks />
        public const uint SoftwareLoadingType_UpdateKey = 136;

        /// <remarks />
        public const uint PackageLoadingType_CurrentVersion_Manufacturer = 345;

        /// <remarks />
        public const uint PackageLoadingType_CurrentVersion_ManufacturerUri = 346;

        /// <remarks />
        public const uint PackageLoadingType_CurrentVersion_SoftwareRevision = 347;

        /// <remarks />
        public const uint PackageLoadingType_FileTransfer_ClientProcessingTimeout = 141;

        /// <remarks />
        public const uint PackageLoadingType_FileTransfer_GenerateFileForRead_InputArguments = 143;

        /// <remarks />
        public const uint PackageLoadingType_FileTransfer_GenerateFileForRead_OutputArguments = 144;

        /// <remarks />
        public const uint PackageLoadingType_FileTransfer_GenerateFileForWrite_InputArguments = 146;

        /// <remarks />
        public const uint PackageLoadingType_FileTransfer_GenerateFileForWrite_OutputArguments = 147;

        /// <remarks />
        public const uint PackageLoadingType_FileTransfer_CloseAndCommit_InputArguments = 149;

        /// <remarks />
        public const uint PackageLoadingType_FileTransfer_CloseAndCommit_OutputArguments = 150;

        /// <remarks />
        public const uint PackageLoadingType_ErrorMessage = 151;

        /// <remarks />
        public const uint PackageLoadingType_WriteBlockSize = 152;

        /// <remarks />
        public const uint DirectLoadingType_CurrentVersion_Manufacturer = 345;

        /// <remarks />
        public const uint DirectLoadingType_CurrentVersion_ManufacturerUri = 346;

        /// <remarks />
        public const uint DirectLoadingType_CurrentVersion_SoftwareRevision = 347;

        /// <remarks />
        public const uint DirectLoadingType_FileTransfer_ClientProcessingTimeout = 141;

        /// <remarks />
        public const uint DirectLoadingType_FileTransfer_GenerateFileForRead_InputArguments = 143;

        /// <remarks />
        public const uint DirectLoadingType_FileTransfer_GenerateFileForRead_OutputArguments = 144;

        /// <remarks />
        public const uint DirectLoadingType_FileTransfer_GenerateFileForWrite_InputArguments = 146;

        /// <remarks />
        public const uint DirectLoadingType_FileTransfer_GenerateFileForWrite_OutputArguments = 147;

        /// <remarks />
        public const uint DirectLoadingType_FileTransfer_CloseAndCommit_InputArguments = 149;

        /// <remarks />
        public const uint DirectLoadingType_FileTransfer_CloseAndCommit_OutputArguments = 150;

        /// <remarks />
        public const uint DirectLoadingType_UpdateBehavior = 169;

        /// <remarks />
        public const uint DirectLoadingType_WriteTimeout = 170;

        /// <remarks />
        public const uint CachedLoadingType_CurrentVersion_Manufacturer = 345;

        /// <remarks />
        public const uint CachedLoadingType_CurrentVersion_ManufacturerUri = 346;

        /// <remarks />
        public const uint CachedLoadingType_CurrentVersion_SoftwareRevision = 347;

        /// <remarks />
        public const uint CachedLoadingType_FileTransfer_ClientProcessingTimeout = 141;

        /// <remarks />
        public const uint CachedLoadingType_FileTransfer_GenerateFileForRead_InputArguments = 143;

        /// <remarks />
        public const uint CachedLoadingType_FileTransfer_GenerateFileForRead_OutputArguments = 144;

        /// <remarks />
        public const uint CachedLoadingType_FileTransfer_GenerateFileForWrite_InputArguments = 146;

        /// <remarks />
        public const uint CachedLoadingType_FileTransfer_GenerateFileForWrite_OutputArguments = 147;

        /// <remarks />
        public const uint CachedLoadingType_FileTransfer_CloseAndCommit_InputArguments = 149;

        /// <remarks />
        public const uint CachedLoadingType_FileTransfer_CloseAndCommit_OutputArguments = 150;

        /// <remarks />
        public const uint CachedLoadingType_PendingVersion_Manufacturer = 366;

        /// <remarks />
        public const uint CachedLoadingType_PendingVersion_ManufacturerUri = 367;

        /// <remarks />
        public const uint CachedLoadingType_PendingVersion_SoftwareRevision = 368;

        /// <remarks />
        public const uint CachedLoadingType_FallbackVersion_Manufacturer = 373;

        /// <remarks />
        public const uint CachedLoadingType_FallbackVersion_ManufacturerUri = 374;

        /// <remarks />
        public const uint CachedLoadingType_FallbackVersion_SoftwareRevision = 375;

        /// <remarks />
        public const uint CachedLoadingType_GetUpdateBehavior_InputArguments = 190;

        /// <remarks />
        public const uint CachedLoadingType_GetUpdateBehavior_OutputArguments = 191;

        /// <remarks />
        public const uint FileSystemLoadingType_FileSystem_CreateDirectory_InputArguments = 196;

        /// <remarks />
        public const uint FileSystemLoadingType_FileSystem_CreateDirectory_OutputArguments = 197;

        /// <remarks />
        public const uint FileSystemLoadingType_FileSystem_CreateFile_InputArguments = 199;

        /// <remarks />
        public const uint FileSystemLoadingType_FileSystem_CreateFile_OutputArguments = 200;

        /// <remarks />
        public const uint FileSystemLoadingType_FileSystem_DeleteFileSystemObject_InputArguments = 202;

        /// <remarks />
        public const uint FileSystemLoadingType_FileSystem_MoveOrCopy_InputArguments = 204;

        /// <remarks />
        public const uint FileSystemLoadingType_FileSystem_MoveOrCopy_OutputArguments = 205;

        /// <remarks />
        public const uint FileSystemLoadingType_GetUpdateBehavior_InputArguments = 207;

        /// <remarks />
        public const uint FileSystemLoadingType_GetUpdateBehavior_OutputArguments = 208;

        /// <remarks />
        public const uint FileSystemLoadingType_ValidateFiles_InputArguments = 210;

        /// <remarks />
        public const uint FileSystemLoadingType_ValidateFiles_OutputArguments = 211;

        /// <remarks />
        public const uint SoftwareVersionType_Manufacturer = 380;

        /// <remarks />
        public const uint SoftwareVersionType_ManufacturerUri = 381;

        /// <remarks />
        public const uint SoftwareVersionType_SoftwareRevision = 382;

        /// <remarks />
        public const uint SoftwareVersionType_PatchIdentifiers = 383;

        /// <remarks />
        public const uint SoftwareVersionType_ReleaseDate = 384;

        /// <remarks />
        public const uint SoftwareVersionType_ChangeLogReference = 385;

        /// <remarks />
        public const uint SoftwareVersionType_Hash = 386;

        /// <remarks />
        public const uint PrepareForUpdateStateMachineType_PercentComplete = 227;

        /// <remarks />
        public const uint PrepareForUpdateStateMachineType_Idle_StateNumber = 232;

        /// <remarks />
        public const uint PrepareForUpdateStateMachineType_Preparing_StateNumber = 234;

        /// <remarks />
        public const uint PrepareForUpdateStateMachineType_PreparedForUpdate_StateNumber = 236;

        /// <remarks />
        public const uint PrepareForUpdateStateMachineType_Resuming_StateNumber = 238;

        /// <remarks />
        public const uint PrepareForUpdateStateMachineType_IdleToPreparing_TransitionNumber = 240;

        /// <remarks />
        public const uint PrepareForUpdateStateMachineType_PreparingToIdle_TransitionNumber = 242;

        /// <remarks />
        public const uint PrepareForUpdateStateMachineType_PreparingToPreparedForUpdate_TransitionNumber = 244;

        /// <remarks />
        public const uint PrepareForUpdateStateMachineType_PreparedForUpdateToResuming_TransitionNumber = 246;

        /// <remarks />
        public const uint PrepareForUpdateStateMachineType_ResumingToIdle_TransitionNumber = 248;

        /// <remarks />
        public const uint InstallationStateMachineType_PercentComplete = 263;

        /// <remarks />
        public const uint InstallationStateMachineType_InstallationDelay = 264;

        /// <remarks />
        public const uint InstallationStateMachineType_InstallSoftwarePackage_InputArguments = 266;

        /// <remarks />
        public const uint InstallationStateMachineType_InstallFiles_InputArguments = 269;

        /// <remarks />
        public const uint InstallationStateMachineType_Idle_StateNumber = 272;

        /// <remarks />
        public const uint InstallationStateMachineType_Installing_StateNumber = 274;

        /// <remarks />
        public const uint InstallationStateMachineType_Error_StateNumber = 276;

        /// <remarks />
        public const uint InstallationStateMachineType_IdleToInstalling_TransitionNumber = 387;

        /// <remarks />
        public const uint InstallationStateMachineType_InstallingToIdle_TransitionNumber = 280;

        /// <remarks />
        public const uint InstallationStateMachineType_InstallingToError_TransitionNumber = 282;

        /// <remarks />
        public const uint InstallationStateMachineType_ErrorToIdle_TransitionNumber = 284;

        /// <remarks />
        public const uint PowerCycleStateMachineType_NotWaitingForPowerCycle_StateNumber = 300;

        /// <remarks />
        public const uint PowerCycleStateMachineType_WaitingForPowerCycle_StateNumber = 302;

        /// <remarks />
        public const uint PowerCycleStateMachineType_NotWaitingForPowerCycleToWaitingForPowerCycle_TransitionNumber = 304;

        /// <remarks />
        public const uint PowerCycleStateMachineType_WaitingForPowerCycleToNotWaitingForPowerCycle_TransitionNumber = 306;

        /// <remarks />
        public const uint ConfirmationStateMachineType_ConfirmationTimeout = 322;

        /// <remarks />
        public const uint ConfirmationStateMachineType_NotWaitingForConfirm_StateNumber = 324;

        /// <remarks />
        public const uint ConfirmationStateMachineType_WaitingForConfirm_StateNumber = 326;

        /// <remarks />
        public const uint ConfirmationStateMachineType_NotWaitingForConfirmToWaitingForConfirm_TransitionNumber = 328;

        /// <remarks />
        public const uint ConfirmationStateMachineType_WaitingForConfirmToNotWaitingForConfirm_TransitionNumber = 330;

        /// <remarks />
        public const uint SoftwareVersionFileType_EnumStrings = 332;

        /// <remarks />
        public const uint UpdateBehavior_OptionSetValues = 388;

        /// <remarks />
        public const uint OpcUaDi_BinarySchema = 6435;

        /// <remarks />
        public const uint OpcUaDi_XmlSchema = 6423;
    }
    #endregion

    #region VariableType Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class VariableTypes
    {
        /// <remarks />
        public const uint LifetimeVariableType = 468;

        /// <remarks />
        public const uint UIElementType = 6246;
    }
    #endregion

    #region DataType Node Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class DataTypeIds
    {
        /// <remarks />
        public static readonly ExpandedNodeId DeviceHealthEnumeration = new ExpandedNodeId(UAModel.DI.DataTypes.DeviceHealthEnumeration, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId FetchResultDataType = new ExpandedNodeId(UAModel.DI.DataTypes.FetchResultDataType, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId TransferResultErrorDataType = new ExpandedNodeId(UAModel.DI.DataTypes.TransferResultErrorDataType, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId TransferResultDataDataType = new ExpandedNodeId(UAModel.DI.DataTypes.TransferResultDataDataType, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId ParameterResultDataType = new ExpandedNodeId(UAModel.DI.DataTypes.ParameterResultDataType, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId SoftwareVersionFileType = new ExpandedNodeId(UAModel.DI.DataTypes.SoftwareVersionFileType, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId UpdateBehavior = new ExpandedNodeId(UAModel.DI.DataTypes.UpdateBehavior, UAModel.DI.Namespaces.DI);
    }
    #endregion

    #region Method Node Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class MethodIds
    {
        /// <remarks />
        public static readonly ExpandedNodeId TopologyElementType_Lock_InitLock = new ExpandedNodeId(UAModel.DI.Methods.TopologyElementType_Lock_InitLock, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId TopologyElementType_Lock_RenewLock = new ExpandedNodeId(UAModel.DI.Methods.TopologyElementType_Lock_RenewLock, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId TopologyElementType_Lock_ExitLock = new ExpandedNodeId(UAModel.DI.Methods.TopologyElementType_Lock_ExitLock, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId TopologyElementType_Lock_BreakLock = new ExpandedNodeId(UAModel.DI.Methods.TopologyElementType_Lock_BreakLock, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId ISupportInfoType_DocumentationFiles_DocumentFileId_Open = new ExpandedNodeId(UAModel.DI.Methods.ISupportInfoType_DocumentationFiles_DocumentFileId_Open, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId ISupportInfoType_DocumentationFiles_DocumentFileId_Close = new ExpandedNodeId(UAModel.DI.Methods.ISupportInfoType_DocumentationFiles_DocumentFileId_Close, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId ISupportInfoType_DocumentationFiles_DocumentFileId_Read = new ExpandedNodeId(UAModel.DI.Methods.ISupportInfoType_DocumentationFiles_DocumentFileId_Read, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId ISupportInfoType_DocumentationFiles_DocumentFileId_Write = new ExpandedNodeId(UAModel.DI.Methods.ISupportInfoType_DocumentationFiles_DocumentFileId_Write, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId ISupportInfoType_DocumentationFiles_DocumentFileId_GetPosition = new ExpandedNodeId(UAModel.DI.Methods.ISupportInfoType_DocumentationFiles_DocumentFileId_GetPosition, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId ISupportInfoType_DocumentationFiles_DocumentFileId_SetPosition = new ExpandedNodeId(UAModel.DI.Methods.ISupportInfoType_DocumentationFiles_DocumentFileId_SetPosition, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId ComponentType_Lock_InitLock = new ExpandedNodeId(UAModel.DI.Methods.ComponentType_Lock_InitLock, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId ComponentType_Lock_RenewLock = new ExpandedNodeId(UAModel.DI.Methods.ComponentType_Lock_RenewLock, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId ComponentType_Lock_ExitLock = new ExpandedNodeId(UAModel.DI.Methods.ComponentType_Lock_ExitLock, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId ComponentType_Lock_BreakLock = new ExpandedNodeId(UAModel.DI.Methods.ComponentType_Lock_BreakLock, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId DeviceType_Lock_InitLock = new ExpandedNodeId(UAModel.DI.Methods.DeviceType_Lock_InitLock, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId DeviceType_Lock_RenewLock = new ExpandedNodeId(UAModel.DI.Methods.DeviceType_Lock_RenewLock, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId DeviceType_Lock_ExitLock = new ExpandedNodeId(UAModel.DI.Methods.DeviceType_Lock_ExitLock, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId DeviceType_Lock_BreakLock = new ExpandedNodeId(UAModel.DI.Methods.DeviceType_Lock_BreakLock, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId DeviceType_CPIdentifier_Lock_InitLock = new ExpandedNodeId(UAModel.DI.Methods.DeviceType_CPIdentifier_Lock_InitLock, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId DeviceType_CPIdentifier_Lock_RenewLock = new ExpandedNodeId(UAModel.DI.Methods.DeviceType_CPIdentifier_Lock_RenewLock, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId DeviceType_CPIdentifier_Lock_ExitLock = new ExpandedNodeId(UAModel.DI.Methods.DeviceType_CPIdentifier_Lock_ExitLock, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId DeviceType_CPIdentifier_Lock_BreakLock = new ExpandedNodeId(UAModel.DI.Methods.DeviceType_CPIdentifier_Lock_BreakLock, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId SoftwareType_Lock_InitLock = new ExpandedNodeId(UAModel.DI.Methods.SoftwareType_Lock_InitLock, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId SoftwareType_Lock_RenewLock = new ExpandedNodeId(UAModel.DI.Methods.SoftwareType_Lock_RenewLock, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId SoftwareType_Lock_ExitLock = new ExpandedNodeId(UAModel.DI.Methods.SoftwareType_Lock_ExitLock, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId SoftwareType_Lock_BreakLock = new ExpandedNodeId(UAModel.DI.Methods.SoftwareType_Lock_BreakLock, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId BlockType_Lock_InitLock = new ExpandedNodeId(UAModel.DI.Methods.BlockType_Lock_InitLock, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId BlockType_Lock_RenewLock = new ExpandedNodeId(UAModel.DI.Methods.BlockType_Lock_RenewLock, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId BlockType_Lock_ExitLock = new ExpandedNodeId(UAModel.DI.Methods.BlockType_Lock_ExitLock, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId BlockType_Lock_BreakLock = new ExpandedNodeId(UAModel.DI.Methods.BlockType_Lock_BreakLock, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId NetworkType_CPIdentifier_Lock_InitLock = new ExpandedNodeId(UAModel.DI.Methods.NetworkType_CPIdentifier_Lock_InitLock, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId NetworkType_CPIdentifier_Lock_RenewLock = new ExpandedNodeId(UAModel.DI.Methods.NetworkType_CPIdentifier_Lock_RenewLock, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId NetworkType_CPIdentifier_Lock_ExitLock = new ExpandedNodeId(UAModel.DI.Methods.NetworkType_CPIdentifier_Lock_ExitLock, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId NetworkType_CPIdentifier_Lock_BreakLock = new ExpandedNodeId(UAModel.DI.Methods.NetworkType_CPIdentifier_Lock_BreakLock, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId NetworkType_Lock_InitLock = new ExpandedNodeId(UAModel.DI.Methods.NetworkType_Lock_InitLock, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId NetworkType_Lock_RenewLock = new ExpandedNodeId(UAModel.DI.Methods.NetworkType_Lock_RenewLock, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId NetworkType_Lock_ExitLock = new ExpandedNodeId(UAModel.DI.Methods.NetworkType_Lock_ExitLock, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId NetworkType_Lock_BreakLock = new ExpandedNodeId(UAModel.DI.Methods.NetworkType_Lock_BreakLock, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId ConnectionPointType_Lock_InitLock = new ExpandedNodeId(UAModel.DI.Methods.ConnectionPointType_Lock_InitLock, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId ConnectionPointType_Lock_RenewLock = new ExpandedNodeId(UAModel.DI.Methods.ConnectionPointType_Lock_RenewLock, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId ConnectionPointType_Lock_ExitLock = new ExpandedNodeId(UAModel.DI.Methods.ConnectionPointType_Lock_ExitLock, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId ConnectionPointType_Lock_BreakLock = new ExpandedNodeId(UAModel.DI.Methods.ConnectionPointType_Lock_BreakLock, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId ConnectionPointType_NetworkIdentifier_Lock_InitLock = new ExpandedNodeId(UAModel.DI.Methods.ConnectionPointType_NetworkIdentifier_Lock_InitLock, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId ConnectionPointType_NetworkIdentifier_Lock_RenewLock = new ExpandedNodeId(UAModel.DI.Methods.ConnectionPointType_NetworkIdentifier_Lock_RenewLock, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId ConnectionPointType_NetworkIdentifier_Lock_ExitLock = new ExpandedNodeId(UAModel.DI.Methods.ConnectionPointType_NetworkIdentifier_Lock_ExitLock, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId ConnectionPointType_NetworkIdentifier_Lock_BreakLock = new ExpandedNodeId(UAModel.DI.Methods.ConnectionPointType_NetworkIdentifier_Lock_BreakLock, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId TransferServicesType_TransferToDevice = new ExpandedNodeId(UAModel.DI.Methods.TransferServicesType_TransferToDevice, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId TransferServicesType_TransferFromDevice = new ExpandedNodeId(UAModel.DI.Methods.TransferServicesType_TransferFromDevice, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId TransferServicesType_FetchTransferResultData = new ExpandedNodeId(UAModel.DI.Methods.TransferServicesType_FetchTransferResultData, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId LockingServicesType_InitLock = new ExpandedNodeId(UAModel.DI.Methods.LockingServicesType_InitLock, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId LockingServicesType_RenewLock = new ExpandedNodeId(UAModel.DI.Methods.LockingServicesType_RenewLock, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId LockingServicesType_ExitLock = new ExpandedNodeId(UAModel.DI.Methods.LockingServicesType_ExitLock, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId LockingServicesType_BreakLock = new ExpandedNodeId(UAModel.DI.Methods.LockingServicesType_BreakLock, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId SoftwareUpdateType_PrepareForUpdate_Prepare = new ExpandedNodeId(UAModel.DI.Methods.SoftwareUpdateType_PrepareForUpdate_Prepare, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId SoftwareUpdateType_PrepareForUpdate_Abort = new ExpandedNodeId(UAModel.DI.Methods.SoftwareUpdateType_PrepareForUpdate_Abort, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId SoftwareUpdateType_Installation_Resume = new ExpandedNodeId(UAModel.DI.Methods.SoftwareUpdateType_Installation_Resume, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId SoftwareUpdateType_Confirmation_Confirm = new ExpandedNodeId(UAModel.DI.Methods.SoftwareUpdateType_Confirmation_Confirm, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId SoftwareUpdateType_Parameters_GenerateFileForRead = new ExpandedNodeId(UAModel.DI.Methods.SoftwareUpdateType_Parameters_GenerateFileForRead, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId SoftwareUpdateType_Parameters_GenerateFileForWrite = new ExpandedNodeId(UAModel.DI.Methods.SoftwareUpdateType_Parameters_GenerateFileForWrite, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId SoftwareUpdateType_Parameters_CloseAndCommit = new ExpandedNodeId(UAModel.DI.Methods.SoftwareUpdateType_Parameters_CloseAndCommit, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId PackageLoadingType_FileTransfer_GenerateFileForRead = new ExpandedNodeId(UAModel.DI.Methods.PackageLoadingType_FileTransfer_GenerateFileForRead, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId PackageLoadingType_FileTransfer_GenerateFileForWrite = new ExpandedNodeId(UAModel.DI.Methods.PackageLoadingType_FileTransfer_GenerateFileForWrite, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId PackageLoadingType_FileTransfer_CloseAndCommit = new ExpandedNodeId(UAModel.DI.Methods.PackageLoadingType_FileTransfer_CloseAndCommit, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId DirectLoadingType_FileTransfer_GenerateFileForRead = new ExpandedNodeId(UAModel.DI.Methods.DirectLoadingType_FileTransfer_GenerateFileForRead, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId DirectLoadingType_FileTransfer_GenerateFileForWrite = new ExpandedNodeId(UAModel.DI.Methods.DirectLoadingType_FileTransfer_GenerateFileForWrite, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId DirectLoadingType_FileTransfer_CloseAndCommit = new ExpandedNodeId(UAModel.DI.Methods.DirectLoadingType_FileTransfer_CloseAndCommit, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId CachedLoadingType_FileTransfer_GenerateFileForRead = new ExpandedNodeId(UAModel.DI.Methods.CachedLoadingType_FileTransfer_GenerateFileForRead, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId CachedLoadingType_FileTransfer_GenerateFileForWrite = new ExpandedNodeId(UAModel.DI.Methods.CachedLoadingType_FileTransfer_GenerateFileForWrite, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId CachedLoadingType_FileTransfer_CloseAndCommit = new ExpandedNodeId(UAModel.DI.Methods.CachedLoadingType_FileTransfer_CloseAndCommit, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId CachedLoadingType_GetUpdateBehavior = new ExpandedNodeId(UAModel.DI.Methods.CachedLoadingType_GetUpdateBehavior, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId FileSystemLoadingType_FileSystem_CreateDirectory = new ExpandedNodeId(UAModel.DI.Methods.FileSystemLoadingType_FileSystem_CreateDirectory, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId FileSystemLoadingType_FileSystem_CreateFile = new ExpandedNodeId(UAModel.DI.Methods.FileSystemLoadingType_FileSystem_CreateFile, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId FileSystemLoadingType_FileSystem_DeleteFileSystemObject = new ExpandedNodeId(UAModel.DI.Methods.FileSystemLoadingType_FileSystem_DeleteFileSystemObject, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId FileSystemLoadingType_FileSystem_MoveOrCopy = new ExpandedNodeId(UAModel.DI.Methods.FileSystemLoadingType_FileSystem_MoveOrCopy, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId FileSystemLoadingType_GetUpdateBehavior = new ExpandedNodeId(UAModel.DI.Methods.FileSystemLoadingType_GetUpdateBehavior, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId FileSystemLoadingType_ValidateFiles = new ExpandedNodeId(UAModel.DI.Methods.FileSystemLoadingType_ValidateFiles, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId PrepareForUpdateStateMachineType_Prepare = new ExpandedNodeId(UAModel.DI.Methods.PrepareForUpdateStateMachineType_Prepare, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId PrepareForUpdateStateMachineType_Abort = new ExpandedNodeId(UAModel.DI.Methods.PrepareForUpdateStateMachineType_Abort, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId PrepareForUpdateStateMachineType_Resume = new ExpandedNodeId(UAModel.DI.Methods.PrepareForUpdateStateMachineType_Resume, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId InstallationStateMachineType_InstallSoftwarePackage = new ExpandedNodeId(UAModel.DI.Methods.InstallationStateMachineType_InstallSoftwarePackage, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId InstallationStateMachineType_InstallFiles = new ExpandedNodeId(UAModel.DI.Methods.InstallationStateMachineType_InstallFiles, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId InstallationStateMachineType_Resume = new ExpandedNodeId(UAModel.DI.Methods.InstallationStateMachineType_Resume, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId ConfirmationStateMachineType_Confirm = new ExpandedNodeId(UAModel.DI.Methods.ConfirmationStateMachineType_Confirm, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId LockingServicesType_InitLockMethodType = new ExpandedNodeId(UAModel.DI.Methods.LockingServicesType_InitLockMethodType, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId LockingServicesType_RenewLockMethodType = new ExpandedNodeId(UAModel.DI.Methods.LockingServicesType_RenewLockMethodType, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId LockingServicesType_ExitLockMethodType = new ExpandedNodeId(UAModel.DI.Methods.LockingServicesType_ExitLockMethodType, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId LockingServicesType_BreakLockMethodType = new ExpandedNodeId(UAModel.DI.Methods.LockingServicesType_BreakLockMethodType, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId TransferServicesType_TransferToDeviceMethodType = new ExpandedNodeId(UAModel.DI.Methods.TransferServicesType_TransferToDeviceMethodType, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId TransferServicesType_TransferFromDeviceMethodType = new ExpandedNodeId(UAModel.DI.Methods.TransferServicesType_TransferFromDeviceMethodType, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId TransferServicesType_FetchTransferResultDataMethodType = new ExpandedNodeId(UAModel.DI.Methods.TransferServicesType_FetchTransferResultDataMethodType, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId CachedLoadingType_GetUpdateBehaviorMethodType = new ExpandedNodeId(UAModel.DI.Methods.CachedLoadingType_GetUpdateBehaviorMethodType, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId FileSystemLoadingType_ValidateFilesMethodType = new ExpandedNodeId(UAModel.DI.Methods.FileSystemLoadingType_ValidateFilesMethodType, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId InstallationStateMachineType_InstallSoftwarePackageMethodType = new ExpandedNodeId(UAModel.DI.Methods.InstallationStateMachineType_InstallSoftwarePackageMethodType, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId InstallationStateMachineType_InstallFilesMethodType = new ExpandedNodeId(UAModel.DI.Methods.InstallationStateMachineType_InstallFilesMethodType, UAModel.DI.Namespaces.DI);
    }
    #endregion

    #region Object Node Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectIds
    {
        /// <remarks />
        public static readonly ExpandedNodeId OPCUADINamespaceMetadata = new ExpandedNodeId(UAModel.DI.Objects.OPCUADINamespaceMetadata, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId DeviceSet = new ExpandedNodeId(UAModel.DI.Objects.DeviceSet, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId DeviceFeatures = new ExpandedNodeId(UAModel.DI.Objects.DeviceFeatures, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId NetworkSet = new ExpandedNodeId(UAModel.DI.Objects.NetworkSet, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId DeviceTopology = new ExpandedNodeId(UAModel.DI.Objects.DeviceTopology, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId TopologyElementType_ParameterSet = new ExpandedNodeId(UAModel.DI.Objects.TopologyElementType_ParameterSet, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId TopologyElementType_MethodSet = new ExpandedNodeId(UAModel.DI.Objects.TopologyElementType_MethodSet, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId TopologyElementType_GroupIdentifier = new ExpandedNodeId(UAModel.DI.Objects.TopologyElementType_GroupIdentifier, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId TopologyElementType_Identification = new ExpandedNodeId(UAModel.DI.Objects.TopologyElementType_Identification, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId TopologyElementType_Lock = new ExpandedNodeId(UAModel.DI.Objects.TopologyElementType_Lock, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId IDeviceHealthType_DeviceHealthAlarms = new ExpandedNodeId(UAModel.DI.Objects.IDeviceHealthType_DeviceHealthAlarms, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId ISupportInfoType_DeviceTypeImage = new ExpandedNodeId(UAModel.DI.Objects.ISupportInfoType_DeviceTypeImage, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId ISupportInfoType_Documentation = new ExpandedNodeId(UAModel.DI.Objects.ISupportInfoType_Documentation, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId ISupportInfoType_DocumentationFiles = new ExpandedNodeId(UAModel.DI.Objects.ISupportInfoType_DocumentationFiles, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId ISupportInfoType_DocumentationFiles_DocumentFileId = new ExpandedNodeId(UAModel.DI.Objects.ISupportInfoType_DocumentationFiles_DocumentFileId, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId ISupportInfoType_ProtocolSupport = new ExpandedNodeId(UAModel.DI.Objects.ISupportInfoType_ProtocolSupport, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId ISupportInfoType_ImageSet = new ExpandedNodeId(UAModel.DI.Objects.ISupportInfoType_ImageSet, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId DeviceType_CPIdentifier = new ExpandedNodeId(UAModel.DI.Objects.DeviceType_CPIdentifier, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId DeviceType_CPIdentifier_NetworkAddress = new ExpandedNodeId(UAModel.DI.Objects.DeviceType_CPIdentifier_NetworkAddress, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId DeviceType_DeviceHealthAlarms = new ExpandedNodeId(UAModel.DI.Objects.DeviceType_DeviceHealthAlarms, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId DeviceType_DeviceTypeImage = new ExpandedNodeId(UAModel.DI.Objects.DeviceType_DeviceTypeImage, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId DeviceType_Documentation = new ExpandedNodeId(UAModel.DI.Objects.DeviceType_Documentation, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId DeviceType_ProtocolSupport = new ExpandedNodeId(UAModel.DI.Objects.DeviceType_ProtocolSupport, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId DeviceType_ImageSet = new ExpandedNodeId(UAModel.DI.Objects.DeviceType_ImageSet, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId ConfigurableObjectType_SupportedTypes = new ExpandedNodeId(UAModel.DI.Objects.ConfigurableObjectType_SupportedTypes, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId ConfigurableObjectType_ObjectIdentifier = new ExpandedNodeId(UAModel.DI.Objects.ConfigurableObjectType_ObjectIdentifier, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalGroupType_GroupIdentifier = new ExpandedNodeId(UAModel.DI.Objects.FunctionalGroupType_GroupIdentifier, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId NetworkType_ProfileIdentifier = new ExpandedNodeId(UAModel.DI.Objects.NetworkType_ProfileIdentifier, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId NetworkType_CPIdentifier = new ExpandedNodeId(UAModel.DI.Objects.NetworkType_CPIdentifier, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId NetworkType_CPIdentifier_NetworkAddress = new ExpandedNodeId(UAModel.DI.Objects.NetworkType_CPIdentifier_NetworkAddress, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId NetworkType_Lock = new ExpandedNodeId(UAModel.DI.Objects.NetworkType_Lock, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId ConnectionPointType_NetworkAddress = new ExpandedNodeId(UAModel.DI.Objects.ConnectionPointType_NetworkAddress, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId ConnectionPointType_ProfileIdentifier = new ExpandedNodeId(UAModel.DI.Objects.ConnectionPointType_ProfileIdentifier, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId ConnectionPointType_NetworkIdentifier = new ExpandedNodeId(UAModel.DI.Objects.ConnectionPointType_NetworkIdentifier, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId SoftwareUpdateType_Loading = new ExpandedNodeId(UAModel.DI.Objects.SoftwareUpdateType_Loading, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId SoftwareUpdateType_PrepareForUpdate = new ExpandedNodeId(UAModel.DI.Objects.SoftwareUpdateType_PrepareForUpdate, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId SoftwareUpdateType_Installation = new ExpandedNodeId(UAModel.DI.Objects.SoftwareUpdateType_Installation, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId SoftwareUpdateType_PowerCycle = new ExpandedNodeId(UAModel.DI.Objects.SoftwareUpdateType_PowerCycle, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId SoftwareUpdateType_Confirmation = new ExpandedNodeId(UAModel.DI.Objects.SoftwareUpdateType_Confirmation, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId SoftwareUpdateType_Parameters = new ExpandedNodeId(UAModel.DI.Objects.SoftwareUpdateType_Parameters, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId PackageLoadingType_CurrentVersion = new ExpandedNodeId(UAModel.DI.Objects.PackageLoadingType_CurrentVersion, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId PackageLoadingType_FileTransfer = new ExpandedNodeId(UAModel.DI.Objects.PackageLoadingType_FileTransfer, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId CachedLoadingType_PendingVersion = new ExpandedNodeId(UAModel.DI.Objects.CachedLoadingType_PendingVersion, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId CachedLoadingType_FallbackVersion = new ExpandedNodeId(UAModel.DI.Objects.CachedLoadingType_FallbackVersion, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId FileSystemLoadingType_FileSystem = new ExpandedNodeId(UAModel.DI.Objects.FileSystemLoadingType_FileSystem, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId PrepareForUpdateStateMachineType_Idle = new ExpandedNodeId(UAModel.DI.Objects.PrepareForUpdateStateMachineType_Idle, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId PrepareForUpdateStateMachineType_Preparing = new ExpandedNodeId(UAModel.DI.Objects.PrepareForUpdateStateMachineType_Preparing, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId PrepareForUpdateStateMachineType_PreparedForUpdate = new ExpandedNodeId(UAModel.DI.Objects.PrepareForUpdateStateMachineType_PreparedForUpdate, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId PrepareForUpdateStateMachineType_Resuming = new ExpandedNodeId(UAModel.DI.Objects.PrepareForUpdateStateMachineType_Resuming, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId PrepareForUpdateStateMachineType_IdleToPreparing = new ExpandedNodeId(UAModel.DI.Objects.PrepareForUpdateStateMachineType_IdleToPreparing, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId PrepareForUpdateStateMachineType_PreparingToIdle = new ExpandedNodeId(UAModel.DI.Objects.PrepareForUpdateStateMachineType_PreparingToIdle, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId PrepareForUpdateStateMachineType_PreparingToPreparedForUpdate = new ExpandedNodeId(UAModel.DI.Objects.PrepareForUpdateStateMachineType_PreparingToPreparedForUpdate, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId PrepareForUpdateStateMachineType_PreparedForUpdateToResuming = new ExpandedNodeId(UAModel.DI.Objects.PrepareForUpdateStateMachineType_PreparedForUpdateToResuming, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId PrepareForUpdateStateMachineType_ResumingToIdle = new ExpandedNodeId(UAModel.DI.Objects.PrepareForUpdateStateMachineType_ResumingToIdle, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId InstallationStateMachineType_Idle = new ExpandedNodeId(UAModel.DI.Objects.InstallationStateMachineType_Idle, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId InstallationStateMachineType_Installing = new ExpandedNodeId(UAModel.DI.Objects.InstallationStateMachineType_Installing, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId InstallationStateMachineType_Error = new ExpandedNodeId(UAModel.DI.Objects.InstallationStateMachineType_Error, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId InstallationStateMachineType_IdleToInstalling = new ExpandedNodeId(UAModel.DI.Objects.InstallationStateMachineType_IdleToInstalling, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId InstallationStateMachineType_InstallingToIdle = new ExpandedNodeId(UAModel.DI.Objects.InstallationStateMachineType_InstallingToIdle, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId InstallationStateMachineType_InstallingToError = new ExpandedNodeId(UAModel.DI.Objects.InstallationStateMachineType_InstallingToError, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId InstallationStateMachineType_ErrorToIdle = new ExpandedNodeId(UAModel.DI.Objects.InstallationStateMachineType_ErrorToIdle, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId PowerCycleStateMachineType_NotWaitingForPowerCycle = new ExpandedNodeId(UAModel.DI.Objects.PowerCycleStateMachineType_NotWaitingForPowerCycle, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId PowerCycleStateMachineType_WaitingForPowerCycle = new ExpandedNodeId(UAModel.DI.Objects.PowerCycleStateMachineType_WaitingForPowerCycle, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId PowerCycleStateMachineType_NotWaitingForPowerCycleToWaitingForPowerCycle = new ExpandedNodeId(UAModel.DI.Objects.PowerCycleStateMachineType_NotWaitingForPowerCycleToWaitingForPowerCycle, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId PowerCycleStateMachineType_WaitingForPowerCycleToNotWaitingForPowerCycle = new ExpandedNodeId(UAModel.DI.Objects.PowerCycleStateMachineType_WaitingForPowerCycleToNotWaitingForPowerCycle, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId ConfirmationStateMachineType_NotWaitingForConfirm = new ExpandedNodeId(UAModel.DI.Objects.ConfirmationStateMachineType_NotWaitingForConfirm, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId ConfirmationStateMachineType_WaitingForConfirm = new ExpandedNodeId(UAModel.DI.Objects.ConfirmationStateMachineType_WaitingForConfirm, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId ConfirmationStateMachineType_NotWaitingForConfirmToWaitingForConfirm = new ExpandedNodeId(UAModel.DI.Objects.ConfirmationStateMachineType_NotWaitingForConfirmToWaitingForConfirm, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId ConfirmationStateMachineType_WaitingForConfirmToNotWaitingForConfirm = new ExpandedNodeId(UAModel.DI.Objects.ConfirmationStateMachineType_WaitingForConfirmToNotWaitingForConfirm, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId FetchResultDataType_Encoding_DefaultBinary = new ExpandedNodeId(UAModel.DI.Objects.FetchResultDataType_Encoding_DefaultBinary, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId TransferResultErrorDataType_Encoding_DefaultBinary = new ExpandedNodeId(UAModel.DI.Objects.TransferResultErrorDataType_Encoding_DefaultBinary, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId TransferResultDataDataType_Encoding_DefaultBinary = new ExpandedNodeId(UAModel.DI.Objects.TransferResultDataDataType_Encoding_DefaultBinary, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId ParameterResultDataType_Encoding_DefaultBinary = new ExpandedNodeId(UAModel.DI.Objects.ParameterResultDataType_Encoding_DefaultBinary, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId FetchResultDataType_Encoding_DefaultXml = new ExpandedNodeId(UAModel.DI.Objects.FetchResultDataType_Encoding_DefaultXml, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId TransferResultErrorDataType_Encoding_DefaultXml = new ExpandedNodeId(UAModel.DI.Objects.TransferResultErrorDataType_Encoding_DefaultXml, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId TransferResultDataDataType_Encoding_DefaultXml = new ExpandedNodeId(UAModel.DI.Objects.TransferResultDataDataType_Encoding_DefaultXml, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId ParameterResultDataType_Encoding_DefaultXml = new ExpandedNodeId(UAModel.DI.Objects.ParameterResultDataType_Encoding_DefaultXml, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId FetchResultDataType_Encoding_DefaultJson = new ExpandedNodeId(UAModel.DI.Objects.FetchResultDataType_Encoding_DefaultJson, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId TransferResultErrorDataType_Encoding_DefaultJson = new ExpandedNodeId(UAModel.DI.Objects.TransferResultErrorDataType_Encoding_DefaultJson, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId TransferResultDataDataType_Encoding_DefaultJson = new ExpandedNodeId(UAModel.DI.Objects.TransferResultDataDataType_Encoding_DefaultJson, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId ParameterResultDataType_Encoding_DefaultJson = new ExpandedNodeId(UAModel.DI.Objects.ParameterResultDataType_Encoding_DefaultJson, UAModel.DI.Namespaces.DI);
    }
    #endregion

    #region ObjectType Node Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectTypeIds
    {
        /// <remarks />
        public static readonly ExpandedNodeId TopologyElementType = new ExpandedNodeId(UAModel.DI.ObjectTypes.TopologyElementType, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId IVendorNameplateType = new ExpandedNodeId(UAModel.DI.ObjectTypes.IVendorNameplateType, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId ITagNameplateType = new ExpandedNodeId(UAModel.DI.ObjectTypes.ITagNameplateType, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId IDeviceHealthType = new ExpandedNodeId(UAModel.DI.ObjectTypes.IDeviceHealthType, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId ISupportInfoType = new ExpandedNodeId(UAModel.DI.ObjectTypes.ISupportInfoType, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId ComponentType = new ExpandedNodeId(UAModel.DI.ObjectTypes.ComponentType, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId DeviceType = new ExpandedNodeId(UAModel.DI.ObjectTypes.DeviceType, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId SoftwareType = new ExpandedNodeId(UAModel.DI.ObjectTypes.SoftwareType, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId BlockType = new ExpandedNodeId(UAModel.DI.ObjectTypes.BlockType, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId DeviceHealthDiagnosticAlarmType = new ExpandedNodeId(UAModel.DI.ObjectTypes.DeviceHealthDiagnosticAlarmType, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId FailureAlarmType = new ExpandedNodeId(UAModel.DI.ObjectTypes.FailureAlarmType, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId CheckFunctionAlarmType = new ExpandedNodeId(UAModel.DI.ObjectTypes.CheckFunctionAlarmType, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId OffSpecAlarmType = new ExpandedNodeId(UAModel.DI.ObjectTypes.OffSpecAlarmType, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId MaintenanceRequiredAlarmType = new ExpandedNodeId(UAModel.DI.ObjectTypes.MaintenanceRequiredAlarmType, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId ConfigurableObjectType = new ExpandedNodeId(UAModel.DI.ObjectTypes.ConfigurableObjectType, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId BaseLifetimeIndicationType = new ExpandedNodeId(UAModel.DI.ObjectTypes.BaseLifetimeIndicationType, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId TimeIndicationType = new ExpandedNodeId(UAModel.DI.ObjectTypes.TimeIndicationType, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId NumberOfPartsIndicationType = new ExpandedNodeId(UAModel.DI.ObjectTypes.NumberOfPartsIndicationType, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId NumberOfUsagesIndicationType = new ExpandedNodeId(UAModel.DI.ObjectTypes.NumberOfUsagesIndicationType, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId LengthIndicationType = new ExpandedNodeId(UAModel.DI.ObjectTypes.LengthIndicationType, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId DiameterIndicationType = new ExpandedNodeId(UAModel.DI.ObjectTypes.DiameterIndicationType, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId SubstanceVolumeIndicationType = new ExpandedNodeId(UAModel.DI.ObjectTypes.SubstanceVolumeIndicationType, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalGroupType = new ExpandedNodeId(UAModel.DI.ObjectTypes.FunctionalGroupType, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId ProtocolType = new ExpandedNodeId(UAModel.DI.ObjectTypes.ProtocolType, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId IOperationCounterType = new ExpandedNodeId(UAModel.DI.ObjectTypes.IOperationCounterType, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId NetworkType = new ExpandedNodeId(UAModel.DI.ObjectTypes.NetworkType, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId ConnectionPointType = new ExpandedNodeId(UAModel.DI.ObjectTypes.ConnectionPointType, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId TransferServicesType = new ExpandedNodeId(UAModel.DI.ObjectTypes.TransferServicesType, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId LockingServicesType = new ExpandedNodeId(UAModel.DI.ObjectTypes.LockingServicesType, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId SoftwareUpdateType = new ExpandedNodeId(UAModel.DI.ObjectTypes.SoftwareUpdateType, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId SoftwareLoadingType = new ExpandedNodeId(UAModel.DI.ObjectTypes.SoftwareLoadingType, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId PackageLoadingType = new ExpandedNodeId(UAModel.DI.ObjectTypes.PackageLoadingType, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId DirectLoadingType = new ExpandedNodeId(UAModel.DI.ObjectTypes.DirectLoadingType, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId CachedLoadingType = new ExpandedNodeId(UAModel.DI.ObjectTypes.CachedLoadingType, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId FileSystemLoadingType = new ExpandedNodeId(UAModel.DI.ObjectTypes.FileSystemLoadingType, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId SoftwareVersionType = new ExpandedNodeId(UAModel.DI.ObjectTypes.SoftwareVersionType, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId PrepareForUpdateStateMachineType = new ExpandedNodeId(UAModel.DI.ObjectTypes.PrepareForUpdateStateMachineType, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId InstallationStateMachineType = new ExpandedNodeId(UAModel.DI.ObjectTypes.InstallationStateMachineType, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId PowerCycleStateMachineType = new ExpandedNodeId(UAModel.DI.ObjectTypes.PowerCycleStateMachineType, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId ConfirmationStateMachineType = new ExpandedNodeId(UAModel.DI.ObjectTypes.ConfirmationStateMachineType, UAModel.DI.Namespaces.DI);
    }
    #endregion

    #region ReferenceType Node Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ReferenceTypeIds
    {
        /// <remarks />
        public static readonly ExpandedNodeId ConnectsTo = new ExpandedNodeId(UAModel.DI.ReferenceTypes.ConnectsTo, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId ConnectsToParent = new ExpandedNodeId(UAModel.DI.ReferenceTypes.ConnectsToParent, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId IsOnline = new ExpandedNodeId(UAModel.DI.ReferenceTypes.IsOnline, UAModel.DI.Namespaces.DI);
    }
    #endregion

    #region Variable Node Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class VariableIds
    {
        /// <remarks />
        public static readonly ExpandedNodeId OPCUADINamespaceMetadata_NamespaceUri = new ExpandedNodeId(UAModel.DI.Variables.OPCUADINamespaceMetadata_NamespaceUri, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId OPCUADINamespaceMetadata_NamespaceVersion = new ExpandedNodeId(UAModel.DI.Variables.OPCUADINamespaceMetadata_NamespaceVersion, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId OPCUADINamespaceMetadata_NamespacePublicationDate = new ExpandedNodeId(UAModel.DI.Variables.OPCUADINamespaceMetadata_NamespacePublicationDate, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId OPCUADINamespaceMetadata_IsNamespaceSubset = new ExpandedNodeId(UAModel.DI.Variables.OPCUADINamespaceMetadata_IsNamespaceSubset, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId OPCUADINamespaceMetadata_StaticNodeIdTypes = new ExpandedNodeId(UAModel.DI.Variables.OPCUADINamespaceMetadata_StaticNodeIdTypes, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId OPCUADINamespaceMetadata_StaticNumericNodeIdRange = new ExpandedNodeId(UAModel.DI.Variables.OPCUADINamespaceMetadata_StaticNumericNodeIdRange, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId OPCUADINamespaceMetadata_StaticStringNodeIdPattern = new ExpandedNodeId(UAModel.DI.Variables.OPCUADINamespaceMetadata_StaticStringNodeIdPattern, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId TopologyElementType_ParameterSet_ParameterIdentifier = new ExpandedNodeId(UAModel.DI.Variables.TopologyElementType_ParameterSet_ParameterIdentifier, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId TopologyElementType_Lock_Locked = new ExpandedNodeId(UAModel.DI.Variables.TopologyElementType_Lock_Locked, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId TopologyElementType_Lock_LockingClient = new ExpandedNodeId(UAModel.DI.Variables.TopologyElementType_Lock_LockingClient, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId TopologyElementType_Lock_LockingUser = new ExpandedNodeId(UAModel.DI.Variables.TopologyElementType_Lock_LockingUser, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId TopologyElementType_Lock_RemainingLockTime = new ExpandedNodeId(UAModel.DI.Variables.TopologyElementType_Lock_RemainingLockTime, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId TopologyElementType_Lock_InitLock_InputArguments = new ExpandedNodeId(UAModel.DI.Variables.TopologyElementType_Lock_InitLock_InputArguments, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId TopologyElementType_Lock_InitLock_OutputArguments = new ExpandedNodeId(UAModel.DI.Variables.TopologyElementType_Lock_InitLock_OutputArguments, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId TopologyElementType_Lock_RenewLock_OutputArguments = new ExpandedNodeId(UAModel.DI.Variables.TopologyElementType_Lock_RenewLock_OutputArguments, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId TopologyElementType_Lock_ExitLock_OutputArguments = new ExpandedNodeId(UAModel.DI.Variables.TopologyElementType_Lock_ExitLock_OutputArguments, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId TopologyElementType_Lock_BreakLock_OutputArguments = new ExpandedNodeId(UAModel.DI.Variables.TopologyElementType_Lock_BreakLock_OutputArguments, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId IVendorNameplateType_Manufacturer = new ExpandedNodeId(UAModel.DI.Variables.IVendorNameplateType_Manufacturer, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId IVendorNameplateType_ManufacturerUri = new ExpandedNodeId(UAModel.DI.Variables.IVendorNameplateType_ManufacturerUri, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId IVendorNameplateType_Model = new ExpandedNodeId(UAModel.DI.Variables.IVendorNameplateType_Model, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId IVendorNameplateType_HardwareRevision = new ExpandedNodeId(UAModel.DI.Variables.IVendorNameplateType_HardwareRevision, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId IVendorNameplateType_SoftwareRevision = new ExpandedNodeId(UAModel.DI.Variables.IVendorNameplateType_SoftwareRevision, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId IVendorNameplateType_DeviceRevision = new ExpandedNodeId(UAModel.DI.Variables.IVendorNameplateType_DeviceRevision, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId IVendorNameplateType_ProductCode = new ExpandedNodeId(UAModel.DI.Variables.IVendorNameplateType_ProductCode, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId IVendorNameplateType_DeviceManual = new ExpandedNodeId(UAModel.DI.Variables.IVendorNameplateType_DeviceManual, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId IVendorNameplateType_DeviceClass = new ExpandedNodeId(UAModel.DI.Variables.IVendorNameplateType_DeviceClass, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId IVendorNameplateType_SerialNumber = new ExpandedNodeId(UAModel.DI.Variables.IVendorNameplateType_SerialNumber, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId IVendorNameplateType_ProductInstanceUri = new ExpandedNodeId(UAModel.DI.Variables.IVendorNameplateType_ProductInstanceUri, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId IVendorNameplateType_RevisionCounter = new ExpandedNodeId(UAModel.DI.Variables.IVendorNameplateType_RevisionCounter, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId IVendorNameplateType_SoftwareReleaseDate = new ExpandedNodeId(UAModel.DI.Variables.IVendorNameplateType_SoftwareReleaseDate, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId IVendorNameplateType_PatchIdentifiers = new ExpandedNodeId(UAModel.DI.Variables.IVendorNameplateType_PatchIdentifiers, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId ITagNameplateType_AssetId = new ExpandedNodeId(UAModel.DI.Variables.ITagNameplateType_AssetId, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId ITagNameplateType_ComponentName = new ExpandedNodeId(UAModel.DI.Variables.ITagNameplateType_ComponentName, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId IDeviceHealthType_DeviceHealth = new ExpandedNodeId(UAModel.DI.Variables.IDeviceHealthType_DeviceHealth, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId ISupportInfoType_DeviceTypeImage_ImageIdentifier = new ExpandedNodeId(UAModel.DI.Variables.ISupportInfoType_DeviceTypeImage_ImageIdentifier, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId ISupportInfoType_Documentation_DocumentIdentifier = new ExpandedNodeId(UAModel.DI.Variables.ISupportInfoType_Documentation_DocumentIdentifier, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId ISupportInfoType_DocumentationFiles_DocumentFileId_Size = new ExpandedNodeId(UAModel.DI.Variables.ISupportInfoType_DocumentationFiles_DocumentFileId_Size, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId ISupportInfoType_DocumentationFiles_DocumentFileId_Writable = new ExpandedNodeId(UAModel.DI.Variables.ISupportInfoType_DocumentationFiles_DocumentFileId_Writable, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId ISupportInfoType_DocumentationFiles_DocumentFileId_UserWritable = new ExpandedNodeId(UAModel.DI.Variables.ISupportInfoType_DocumentationFiles_DocumentFileId_UserWritable, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId ISupportInfoType_DocumentationFiles_DocumentFileId_OpenCount = new ExpandedNodeId(UAModel.DI.Variables.ISupportInfoType_DocumentationFiles_DocumentFileId_OpenCount, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId ISupportInfoType_DocumentationFiles_DocumentFileId_Open_InputArguments = new ExpandedNodeId(UAModel.DI.Variables.ISupportInfoType_DocumentationFiles_DocumentFileId_Open_InputArguments, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId ISupportInfoType_DocumentationFiles_DocumentFileId_Open_OutputArguments = new ExpandedNodeId(UAModel.DI.Variables.ISupportInfoType_DocumentationFiles_DocumentFileId_Open_OutputArguments, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId ISupportInfoType_DocumentationFiles_DocumentFileId_Close_InputArguments = new ExpandedNodeId(UAModel.DI.Variables.ISupportInfoType_DocumentationFiles_DocumentFileId_Close_InputArguments, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId ISupportInfoType_DocumentationFiles_DocumentFileId_Read_InputArguments = new ExpandedNodeId(UAModel.DI.Variables.ISupportInfoType_DocumentationFiles_DocumentFileId_Read_InputArguments, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId ISupportInfoType_DocumentationFiles_DocumentFileId_Read_OutputArguments = new ExpandedNodeId(UAModel.DI.Variables.ISupportInfoType_DocumentationFiles_DocumentFileId_Read_OutputArguments, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId ISupportInfoType_DocumentationFiles_DocumentFileId_Write_InputArguments = new ExpandedNodeId(UAModel.DI.Variables.ISupportInfoType_DocumentationFiles_DocumentFileId_Write_InputArguments, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId ISupportInfoType_DocumentationFiles_DocumentFileId_GetPosition_InputArguments = new ExpandedNodeId(UAModel.DI.Variables.ISupportInfoType_DocumentationFiles_DocumentFileId_GetPosition_InputArguments, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId ISupportInfoType_DocumentationFiles_DocumentFileId_GetPosition_OutputArguments = new ExpandedNodeId(UAModel.DI.Variables.ISupportInfoType_DocumentationFiles_DocumentFileId_GetPosition_OutputArguments, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId ISupportInfoType_DocumentationFiles_DocumentFileId_SetPosition_InputArguments = new ExpandedNodeId(UAModel.DI.Variables.ISupportInfoType_DocumentationFiles_DocumentFileId_SetPosition_InputArguments, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId ISupportInfoType_ProtocolSupport_ProtocolSupportIdentifier = new ExpandedNodeId(UAModel.DI.Variables.ISupportInfoType_ProtocolSupport_ProtocolSupportIdentifier, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId ISupportInfoType_ImageSet_ImageIdentifier = new ExpandedNodeId(UAModel.DI.Variables.ISupportInfoType_ImageSet_ImageIdentifier, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId ComponentType_Lock_Locked = new ExpandedNodeId(UAModel.DI.Variables.ComponentType_Lock_Locked, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId ComponentType_Lock_LockingClient = new ExpandedNodeId(UAModel.DI.Variables.ComponentType_Lock_LockingClient, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId ComponentType_Lock_LockingUser = new ExpandedNodeId(UAModel.DI.Variables.ComponentType_Lock_LockingUser, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId ComponentType_Lock_RemainingLockTime = new ExpandedNodeId(UAModel.DI.Variables.ComponentType_Lock_RemainingLockTime, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId ComponentType_Lock_InitLock_InputArguments = new ExpandedNodeId(UAModel.DI.Variables.ComponentType_Lock_InitLock_InputArguments, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId ComponentType_Lock_InitLock_OutputArguments = new ExpandedNodeId(UAModel.DI.Variables.ComponentType_Lock_InitLock_OutputArguments, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId ComponentType_Lock_RenewLock_OutputArguments = new ExpandedNodeId(UAModel.DI.Variables.ComponentType_Lock_RenewLock_OutputArguments, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId ComponentType_Lock_ExitLock_OutputArguments = new ExpandedNodeId(UAModel.DI.Variables.ComponentType_Lock_ExitLock_OutputArguments, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId ComponentType_Lock_BreakLock_OutputArguments = new ExpandedNodeId(UAModel.DI.Variables.ComponentType_Lock_BreakLock_OutputArguments, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId ComponentType_Manufacturer = new ExpandedNodeId(UAModel.DI.Variables.ComponentType_Manufacturer, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId ComponentType_ManufacturerUri = new ExpandedNodeId(UAModel.DI.Variables.ComponentType_ManufacturerUri, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId ComponentType_Model = new ExpandedNodeId(UAModel.DI.Variables.ComponentType_Model, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId ComponentType_HardwareRevision = new ExpandedNodeId(UAModel.DI.Variables.ComponentType_HardwareRevision, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId ComponentType_SoftwareRevision = new ExpandedNodeId(UAModel.DI.Variables.ComponentType_SoftwareRevision, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId ComponentType_DeviceRevision = new ExpandedNodeId(UAModel.DI.Variables.ComponentType_DeviceRevision, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId ComponentType_ProductCode = new ExpandedNodeId(UAModel.DI.Variables.ComponentType_ProductCode, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId ComponentType_DeviceManual = new ExpandedNodeId(UAModel.DI.Variables.ComponentType_DeviceManual, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId ComponentType_DeviceClass = new ExpandedNodeId(UAModel.DI.Variables.ComponentType_DeviceClass, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId ComponentType_SerialNumber = new ExpandedNodeId(UAModel.DI.Variables.ComponentType_SerialNumber, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId ComponentType_ProductInstanceUri = new ExpandedNodeId(UAModel.DI.Variables.ComponentType_ProductInstanceUri, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId ComponentType_RevisionCounter = new ExpandedNodeId(UAModel.DI.Variables.ComponentType_RevisionCounter, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId ComponentType_AssetId = new ExpandedNodeId(UAModel.DI.Variables.ComponentType_AssetId, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId ComponentType_ComponentName = new ExpandedNodeId(UAModel.DI.Variables.ComponentType_ComponentName, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId DeviceType_Lock_Locked = new ExpandedNodeId(UAModel.DI.Variables.DeviceType_Lock_Locked, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId DeviceType_Lock_LockingClient = new ExpandedNodeId(UAModel.DI.Variables.DeviceType_Lock_LockingClient, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId DeviceType_Lock_LockingUser = new ExpandedNodeId(UAModel.DI.Variables.DeviceType_Lock_LockingUser, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId DeviceType_Lock_RemainingLockTime = new ExpandedNodeId(UAModel.DI.Variables.DeviceType_Lock_RemainingLockTime, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId DeviceType_Lock_InitLock_InputArguments = new ExpandedNodeId(UAModel.DI.Variables.DeviceType_Lock_InitLock_InputArguments, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId DeviceType_Lock_InitLock_OutputArguments = new ExpandedNodeId(UAModel.DI.Variables.DeviceType_Lock_InitLock_OutputArguments, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId DeviceType_Lock_RenewLock_OutputArguments = new ExpandedNodeId(UAModel.DI.Variables.DeviceType_Lock_RenewLock_OutputArguments, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId DeviceType_Lock_ExitLock_OutputArguments = new ExpandedNodeId(UAModel.DI.Variables.DeviceType_Lock_ExitLock_OutputArguments, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId DeviceType_Lock_BreakLock_OutputArguments = new ExpandedNodeId(UAModel.DI.Variables.DeviceType_Lock_BreakLock_OutputArguments, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId DeviceType_Manufacturer = new ExpandedNodeId(UAModel.DI.Variables.DeviceType_Manufacturer, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId DeviceType_ManufacturerUri = new ExpandedNodeId(UAModel.DI.Variables.DeviceType_ManufacturerUri, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId DeviceType_Model = new ExpandedNodeId(UAModel.DI.Variables.DeviceType_Model, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId DeviceType_HardwareRevision = new ExpandedNodeId(UAModel.DI.Variables.DeviceType_HardwareRevision, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId DeviceType_SoftwareRevision = new ExpandedNodeId(UAModel.DI.Variables.DeviceType_SoftwareRevision, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId DeviceType_DeviceRevision = new ExpandedNodeId(UAModel.DI.Variables.DeviceType_DeviceRevision, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId DeviceType_ProductCode = new ExpandedNodeId(UAModel.DI.Variables.DeviceType_ProductCode, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId DeviceType_DeviceManual = new ExpandedNodeId(UAModel.DI.Variables.DeviceType_DeviceManual, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId DeviceType_DeviceClass = new ExpandedNodeId(UAModel.DI.Variables.DeviceType_DeviceClass, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId DeviceType_SerialNumber = new ExpandedNodeId(UAModel.DI.Variables.DeviceType_SerialNumber, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId DeviceType_ProductInstanceUri = new ExpandedNodeId(UAModel.DI.Variables.DeviceType_ProductInstanceUri, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId DeviceType_RevisionCounter = new ExpandedNodeId(UAModel.DI.Variables.DeviceType_RevisionCounter, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId DeviceType_CPIdentifier_Lock_Locked = new ExpandedNodeId(UAModel.DI.Variables.DeviceType_CPIdentifier_Lock_Locked, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId DeviceType_CPIdentifier_Lock_LockingClient = new ExpandedNodeId(UAModel.DI.Variables.DeviceType_CPIdentifier_Lock_LockingClient, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId DeviceType_CPIdentifier_Lock_LockingUser = new ExpandedNodeId(UAModel.DI.Variables.DeviceType_CPIdentifier_Lock_LockingUser, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId DeviceType_CPIdentifier_Lock_RemainingLockTime = new ExpandedNodeId(UAModel.DI.Variables.DeviceType_CPIdentifier_Lock_RemainingLockTime, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId DeviceType_CPIdentifier_Lock_InitLock_InputArguments = new ExpandedNodeId(UAModel.DI.Variables.DeviceType_CPIdentifier_Lock_InitLock_InputArguments, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId DeviceType_CPIdentifier_Lock_InitLock_OutputArguments = new ExpandedNodeId(UAModel.DI.Variables.DeviceType_CPIdentifier_Lock_InitLock_OutputArguments, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId DeviceType_CPIdentifier_Lock_RenewLock_OutputArguments = new ExpandedNodeId(UAModel.DI.Variables.DeviceType_CPIdentifier_Lock_RenewLock_OutputArguments, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId DeviceType_CPIdentifier_Lock_ExitLock_OutputArguments = new ExpandedNodeId(UAModel.DI.Variables.DeviceType_CPIdentifier_Lock_ExitLock_OutputArguments, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId DeviceType_CPIdentifier_Lock_BreakLock_OutputArguments = new ExpandedNodeId(UAModel.DI.Variables.DeviceType_CPIdentifier_Lock_BreakLock_OutputArguments, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId DeviceType_DeviceHealth = new ExpandedNodeId(UAModel.DI.Variables.DeviceType_DeviceHealth, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId DeviceType_DeviceTypeImage_ImageIdentifier = new ExpandedNodeId(UAModel.DI.Variables.DeviceType_DeviceTypeImage_ImageIdentifier, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId DeviceType_Documentation_DocumentIdentifier = new ExpandedNodeId(UAModel.DI.Variables.DeviceType_Documentation_DocumentIdentifier, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId DeviceType_ProtocolSupport_ProtocolSupportIdentifier = new ExpandedNodeId(UAModel.DI.Variables.DeviceType_ProtocolSupport_ProtocolSupportIdentifier, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId DeviceType_ImageSet_ImageIdentifier = new ExpandedNodeId(UAModel.DI.Variables.DeviceType_ImageSet_ImageIdentifier, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId SoftwareType_Lock_Locked = new ExpandedNodeId(UAModel.DI.Variables.SoftwareType_Lock_Locked, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId SoftwareType_Lock_LockingClient = new ExpandedNodeId(UAModel.DI.Variables.SoftwareType_Lock_LockingClient, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId SoftwareType_Lock_LockingUser = new ExpandedNodeId(UAModel.DI.Variables.SoftwareType_Lock_LockingUser, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId SoftwareType_Lock_RemainingLockTime = new ExpandedNodeId(UAModel.DI.Variables.SoftwareType_Lock_RemainingLockTime, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId SoftwareType_Lock_InitLock_InputArguments = new ExpandedNodeId(UAModel.DI.Variables.SoftwareType_Lock_InitLock_InputArguments, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId SoftwareType_Lock_InitLock_OutputArguments = new ExpandedNodeId(UAModel.DI.Variables.SoftwareType_Lock_InitLock_OutputArguments, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId SoftwareType_Lock_RenewLock_OutputArguments = new ExpandedNodeId(UAModel.DI.Variables.SoftwareType_Lock_RenewLock_OutputArguments, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId SoftwareType_Lock_ExitLock_OutputArguments = new ExpandedNodeId(UAModel.DI.Variables.SoftwareType_Lock_ExitLock_OutputArguments, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId SoftwareType_Lock_BreakLock_OutputArguments = new ExpandedNodeId(UAModel.DI.Variables.SoftwareType_Lock_BreakLock_OutputArguments, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId SoftwareType_Manufacturer = new ExpandedNodeId(UAModel.DI.Variables.SoftwareType_Manufacturer, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId SoftwareType_Model = new ExpandedNodeId(UAModel.DI.Variables.SoftwareType_Model, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId SoftwareType_SoftwareRevision = new ExpandedNodeId(UAModel.DI.Variables.SoftwareType_SoftwareRevision, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId BlockType_Lock_Locked = new ExpandedNodeId(UAModel.DI.Variables.BlockType_Lock_Locked, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId BlockType_Lock_LockingClient = new ExpandedNodeId(UAModel.DI.Variables.BlockType_Lock_LockingClient, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId BlockType_Lock_LockingUser = new ExpandedNodeId(UAModel.DI.Variables.BlockType_Lock_LockingUser, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId BlockType_Lock_RemainingLockTime = new ExpandedNodeId(UAModel.DI.Variables.BlockType_Lock_RemainingLockTime, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId BlockType_Lock_InitLock_InputArguments = new ExpandedNodeId(UAModel.DI.Variables.BlockType_Lock_InitLock_InputArguments, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId BlockType_Lock_InitLock_OutputArguments = new ExpandedNodeId(UAModel.DI.Variables.BlockType_Lock_InitLock_OutputArguments, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId BlockType_Lock_RenewLock_OutputArguments = new ExpandedNodeId(UAModel.DI.Variables.BlockType_Lock_RenewLock_OutputArguments, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId BlockType_Lock_ExitLock_OutputArguments = new ExpandedNodeId(UAModel.DI.Variables.BlockType_Lock_ExitLock_OutputArguments, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId BlockType_Lock_BreakLock_OutputArguments = new ExpandedNodeId(UAModel.DI.Variables.BlockType_Lock_BreakLock_OutputArguments, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId BlockType_RevisionCounter = new ExpandedNodeId(UAModel.DI.Variables.BlockType_RevisionCounter, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId BlockType_ActualMode = new ExpandedNodeId(UAModel.DI.Variables.BlockType_ActualMode, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId BlockType_PermittedMode = new ExpandedNodeId(UAModel.DI.Variables.BlockType_PermittedMode, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId BlockType_NormalMode = new ExpandedNodeId(UAModel.DI.Variables.BlockType_NormalMode, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId BlockType_TargetMode = new ExpandedNodeId(UAModel.DI.Variables.BlockType_TargetMode, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId LifetimeVariableType_StartValue = new ExpandedNodeId(UAModel.DI.Variables.LifetimeVariableType_StartValue, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId LifetimeVariableType_LimitValue = new ExpandedNodeId(UAModel.DI.Variables.LifetimeVariableType_LimitValue, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId LifetimeVariableType_Indication = new ExpandedNodeId(UAModel.DI.Variables.LifetimeVariableType_Indication, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId LifetimeVariableType_WarningValues = new ExpandedNodeId(UAModel.DI.Variables.LifetimeVariableType_WarningValues, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalGroupType_GroupIdentifier_UIElement = new ExpandedNodeId(UAModel.DI.Variables.FunctionalGroupType_GroupIdentifier_UIElement, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId FunctionalGroupType_UIElement = new ExpandedNodeId(UAModel.DI.Variables.FunctionalGroupType_UIElement, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId DeviceHealthEnumeration_EnumStrings = new ExpandedNodeId(UAModel.DI.Variables.DeviceHealthEnumeration_EnumStrings, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId IOperationCounterType_PowerOnDuration = new ExpandedNodeId(UAModel.DI.Variables.IOperationCounterType_PowerOnDuration, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId IOperationCounterType_OperationDuration = new ExpandedNodeId(UAModel.DI.Variables.IOperationCounterType_OperationDuration, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId IOperationCounterType_OperationCycleCounter = new ExpandedNodeId(UAModel.DI.Variables.IOperationCounterType_OperationCycleCounter, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId NetworkType_CPIdentifier_Lock_Locked = new ExpandedNodeId(UAModel.DI.Variables.NetworkType_CPIdentifier_Lock_Locked, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId NetworkType_CPIdentifier_Lock_LockingClient = new ExpandedNodeId(UAModel.DI.Variables.NetworkType_CPIdentifier_Lock_LockingClient, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId NetworkType_CPIdentifier_Lock_LockingUser = new ExpandedNodeId(UAModel.DI.Variables.NetworkType_CPIdentifier_Lock_LockingUser, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId NetworkType_CPIdentifier_Lock_RemainingLockTime = new ExpandedNodeId(UAModel.DI.Variables.NetworkType_CPIdentifier_Lock_RemainingLockTime, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId NetworkType_CPIdentifier_Lock_InitLock_InputArguments = new ExpandedNodeId(UAModel.DI.Variables.NetworkType_CPIdentifier_Lock_InitLock_InputArguments, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId NetworkType_CPIdentifier_Lock_InitLock_OutputArguments = new ExpandedNodeId(UAModel.DI.Variables.NetworkType_CPIdentifier_Lock_InitLock_OutputArguments, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId NetworkType_CPIdentifier_Lock_RenewLock_OutputArguments = new ExpandedNodeId(UAModel.DI.Variables.NetworkType_CPIdentifier_Lock_RenewLock_OutputArguments, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId NetworkType_CPIdentifier_Lock_ExitLock_OutputArguments = new ExpandedNodeId(UAModel.DI.Variables.NetworkType_CPIdentifier_Lock_ExitLock_OutputArguments, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId NetworkType_CPIdentifier_Lock_BreakLock_OutputArguments = new ExpandedNodeId(UAModel.DI.Variables.NetworkType_CPIdentifier_Lock_BreakLock_OutputArguments, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId NetworkType_Lock_Locked = new ExpandedNodeId(UAModel.DI.Variables.NetworkType_Lock_Locked, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId NetworkType_Lock_LockingClient = new ExpandedNodeId(UAModel.DI.Variables.NetworkType_Lock_LockingClient, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId NetworkType_Lock_LockingUser = new ExpandedNodeId(UAModel.DI.Variables.NetworkType_Lock_LockingUser, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId NetworkType_Lock_RemainingLockTime = new ExpandedNodeId(UAModel.DI.Variables.NetworkType_Lock_RemainingLockTime, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId NetworkType_Lock_InitLock_InputArguments = new ExpandedNodeId(UAModel.DI.Variables.NetworkType_Lock_InitLock_InputArguments, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId NetworkType_Lock_InitLock_OutputArguments = new ExpandedNodeId(UAModel.DI.Variables.NetworkType_Lock_InitLock_OutputArguments, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId NetworkType_Lock_RenewLock_OutputArguments = new ExpandedNodeId(UAModel.DI.Variables.NetworkType_Lock_RenewLock_OutputArguments, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId NetworkType_Lock_ExitLock_OutputArguments = new ExpandedNodeId(UAModel.DI.Variables.NetworkType_Lock_ExitLock_OutputArguments, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId NetworkType_Lock_BreakLock_OutputArguments = new ExpandedNodeId(UAModel.DI.Variables.NetworkType_Lock_BreakLock_OutputArguments, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId ConnectionPointType_Lock_Locked = new ExpandedNodeId(UAModel.DI.Variables.ConnectionPointType_Lock_Locked, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId ConnectionPointType_Lock_LockingClient = new ExpandedNodeId(UAModel.DI.Variables.ConnectionPointType_Lock_LockingClient, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId ConnectionPointType_Lock_LockingUser = new ExpandedNodeId(UAModel.DI.Variables.ConnectionPointType_Lock_LockingUser, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId ConnectionPointType_Lock_RemainingLockTime = new ExpandedNodeId(UAModel.DI.Variables.ConnectionPointType_Lock_RemainingLockTime, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId ConnectionPointType_Lock_InitLock_InputArguments = new ExpandedNodeId(UAModel.DI.Variables.ConnectionPointType_Lock_InitLock_InputArguments, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId ConnectionPointType_Lock_InitLock_OutputArguments = new ExpandedNodeId(UAModel.DI.Variables.ConnectionPointType_Lock_InitLock_OutputArguments, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId ConnectionPointType_Lock_RenewLock_OutputArguments = new ExpandedNodeId(UAModel.DI.Variables.ConnectionPointType_Lock_RenewLock_OutputArguments, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId ConnectionPointType_Lock_ExitLock_OutputArguments = new ExpandedNodeId(UAModel.DI.Variables.ConnectionPointType_Lock_ExitLock_OutputArguments, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId ConnectionPointType_Lock_BreakLock_OutputArguments = new ExpandedNodeId(UAModel.DI.Variables.ConnectionPointType_Lock_BreakLock_OutputArguments, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId ConnectionPointType_NetworkIdentifier_Lock_Locked = new ExpandedNodeId(UAModel.DI.Variables.ConnectionPointType_NetworkIdentifier_Lock_Locked, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId ConnectionPointType_NetworkIdentifier_Lock_LockingClient = new ExpandedNodeId(UAModel.DI.Variables.ConnectionPointType_NetworkIdentifier_Lock_LockingClient, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId ConnectionPointType_NetworkIdentifier_Lock_LockingUser = new ExpandedNodeId(UAModel.DI.Variables.ConnectionPointType_NetworkIdentifier_Lock_LockingUser, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId ConnectionPointType_NetworkIdentifier_Lock_RemainingLockTime = new ExpandedNodeId(UAModel.DI.Variables.ConnectionPointType_NetworkIdentifier_Lock_RemainingLockTime, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId ConnectionPointType_NetworkIdentifier_Lock_InitLock_InputArguments = new ExpandedNodeId(UAModel.DI.Variables.ConnectionPointType_NetworkIdentifier_Lock_InitLock_InputArguments, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId ConnectionPointType_NetworkIdentifier_Lock_InitLock_OutputArguments = new ExpandedNodeId(UAModel.DI.Variables.ConnectionPointType_NetworkIdentifier_Lock_InitLock_OutputArguments, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId ConnectionPointType_NetworkIdentifier_Lock_RenewLock_OutputArguments = new ExpandedNodeId(UAModel.DI.Variables.ConnectionPointType_NetworkIdentifier_Lock_RenewLock_OutputArguments, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId ConnectionPointType_NetworkIdentifier_Lock_ExitLock_OutputArguments = new ExpandedNodeId(UAModel.DI.Variables.ConnectionPointType_NetworkIdentifier_Lock_ExitLock_OutputArguments, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId ConnectionPointType_NetworkIdentifier_Lock_BreakLock_OutputArguments = new ExpandedNodeId(UAModel.DI.Variables.ConnectionPointType_NetworkIdentifier_Lock_BreakLock_OutputArguments, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId TransferServicesType_TransferToDevice_OutputArguments = new ExpandedNodeId(UAModel.DI.Variables.TransferServicesType_TransferToDevice_OutputArguments, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId TransferServicesType_TransferFromDevice_OutputArguments = new ExpandedNodeId(UAModel.DI.Variables.TransferServicesType_TransferFromDevice_OutputArguments, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId TransferServicesType_FetchTransferResultData_InputArguments = new ExpandedNodeId(UAModel.DI.Variables.TransferServicesType_FetchTransferResultData_InputArguments, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId TransferServicesType_FetchTransferResultData_OutputArguments = new ExpandedNodeId(UAModel.DI.Variables.TransferServicesType_FetchTransferResultData_OutputArguments, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId MaxInactiveLockTime = new ExpandedNodeId(UAModel.DI.Variables.MaxInactiveLockTime, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId LockingServicesType_DefaultInstanceBrowseName = new ExpandedNodeId(UAModel.DI.Variables.LockingServicesType_DefaultInstanceBrowseName, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId LockingServicesType_Locked = new ExpandedNodeId(UAModel.DI.Variables.LockingServicesType_Locked, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId LockingServicesType_LockingClient = new ExpandedNodeId(UAModel.DI.Variables.LockingServicesType_LockingClient, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId LockingServicesType_LockingUser = new ExpandedNodeId(UAModel.DI.Variables.LockingServicesType_LockingUser, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId LockingServicesType_RemainingLockTime = new ExpandedNodeId(UAModel.DI.Variables.LockingServicesType_RemainingLockTime, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId LockingServicesType_InitLock_InputArguments = new ExpandedNodeId(UAModel.DI.Variables.LockingServicesType_InitLock_InputArguments, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId LockingServicesType_InitLock_OutputArguments = new ExpandedNodeId(UAModel.DI.Variables.LockingServicesType_InitLock_OutputArguments, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId LockingServicesType_RenewLock_OutputArguments = new ExpandedNodeId(UAModel.DI.Variables.LockingServicesType_RenewLock_OutputArguments, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId LockingServicesType_ExitLock_OutputArguments = new ExpandedNodeId(UAModel.DI.Variables.LockingServicesType_ExitLock_OutputArguments, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId LockingServicesType_BreakLock_OutputArguments = new ExpandedNodeId(UAModel.DI.Variables.LockingServicesType_BreakLock_OutputArguments, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId SoftwareUpdateType_PrepareForUpdate_CurrentState = new ExpandedNodeId(UAModel.DI.Variables.SoftwareUpdateType_PrepareForUpdate_CurrentState, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId SoftwareUpdateType_PrepareForUpdate_CurrentState_Id = new ExpandedNodeId(UAModel.DI.Variables.SoftwareUpdateType_PrepareForUpdate_CurrentState_Id, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId SoftwareUpdateType_Installation_CurrentState = new ExpandedNodeId(UAModel.DI.Variables.SoftwareUpdateType_Installation_CurrentState, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId SoftwareUpdateType_Installation_CurrentState_Id = new ExpandedNodeId(UAModel.DI.Variables.SoftwareUpdateType_Installation_CurrentState_Id, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId SoftwareUpdateType_Installation_InstallSoftwarePackage_InputArguments = new ExpandedNodeId(UAModel.DI.Variables.SoftwareUpdateType_Installation_InstallSoftwarePackage_InputArguments, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId SoftwareUpdateType_Installation_InstallFiles_InputArguments = new ExpandedNodeId(UAModel.DI.Variables.SoftwareUpdateType_Installation_InstallFiles_InputArguments, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId SoftwareUpdateType_PowerCycle_CurrentState = new ExpandedNodeId(UAModel.DI.Variables.SoftwareUpdateType_PowerCycle_CurrentState, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId SoftwareUpdateType_PowerCycle_CurrentState_Id = new ExpandedNodeId(UAModel.DI.Variables.SoftwareUpdateType_PowerCycle_CurrentState_Id, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId SoftwareUpdateType_Confirmation_CurrentState = new ExpandedNodeId(UAModel.DI.Variables.SoftwareUpdateType_Confirmation_CurrentState, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId SoftwareUpdateType_Confirmation_CurrentState_Id = new ExpandedNodeId(UAModel.DI.Variables.SoftwareUpdateType_Confirmation_CurrentState_Id, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId SoftwareUpdateType_Confirmation_ConfirmationTimeout = new ExpandedNodeId(UAModel.DI.Variables.SoftwareUpdateType_Confirmation_ConfirmationTimeout, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId SoftwareUpdateType_Parameters_ClientProcessingTimeout = new ExpandedNodeId(UAModel.DI.Variables.SoftwareUpdateType_Parameters_ClientProcessingTimeout, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId SoftwareUpdateType_Parameters_GenerateFileForRead_InputArguments = new ExpandedNodeId(UAModel.DI.Variables.SoftwareUpdateType_Parameters_GenerateFileForRead_InputArguments, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId SoftwareUpdateType_Parameters_GenerateFileForRead_OutputArguments = new ExpandedNodeId(UAModel.DI.Variables.SoftwareUpdateType_Parameters_GenerateFileForRead_OutputArguments, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId SoftwareUpdateType_Parameters_GenerateFileForWrite_InputArguments = new ExpandedNodeId(UAModel.DI.Variables.SoftwareUpdateType_Parameters_GenerateFileForWrite_InputArguments, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId SoftwareUpdateType_Parameters_GenerateFileForWrite_OutputArguments = new ExpandedNodeId(UAModel.DI.Variables.SoftwareUpdateType_Parameters_GenerateFileForWrite_OutputArguments, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId SoftwareUpdateType_Parameters_CloseAndCommit_InputArguments = new ExpandedNodeId(UAModel.DI.Variables.SoftwareUpdateType_Parameters_CloseAndCommit_InputArguments, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId SoftwareUpdateType_Parameters_CloseAndCommit_OutputArguments = new ExpandedNodeId(UAModel.DI.Variables.SoftwareUpdateType_Parameters_CloseAndCommit_OutputArguments, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId SoftwareUpdateType_UpdateStatus = new ExpandedNodeId(UAModel.DI.Variables.SoftwareUpdateType_UpdateStatus, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId SoftwareUpdateType_VendorErrorCode = new ExpandedNodeId(UAModel.DI.Variables.SoftwareUpdateType_VendorErrorCode, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId SoftwareUpdateType_DefaultInstanceBrowseName = new ExpandedNodeId(UAModel.DI.Variables.SoftwareUpdateType_DefaultInstanceBrowseName, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId SoftwareLoadingType_UpdateKey = new ExpandedNodeId(UAModel.DI.Variables.SoftwareLoadingType_UpdateKey, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId PackageLoadingType_CurrentVersion_Manufacturer = new ExpandedNodeId(UAModel.DI.Variables.PackageLoadingType_CurrentVersion_Manufacturer, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId PackageLoadingType_CurrentVersion_ManufacturerUri = new ExpandedNodeId(UAModel.DI.Variables.PackageLoadingType_CurrentVersion_ManufacturerUri, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId PackageLoadingType_CurrentVersion_SoftwareRevision = new ExpandedNodeId(UAModel.DI.Variables.PackageLoadingType_CurrentVersion_SoftwareRevision, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId PackageLoadingType_FileTransfer_ClientProcessingTimeout = new ExpandedNodeId(UAModel.DI.Variables.PackageLoadingType_FileTransfer_ClientProcessingTimeout, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId PackageLoadingType_FileTransfer_GenerateFileForRead_InputArguments = new ExpandedNodeId(UAModel.DI.Variables.PackageLoadingType_FileTransfer_GenerateFileForRead_InputArguments, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId PackageLoadingType_FileTransfer_GenerateFileForRead_OutputArguments = new ExpandedNodeId(UAModel.DI.Variables.PackageLoadingType_FileTransfer_GenerateFileForRead_OutputArguments, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId PackageLoadingType_FileTransfer_GenerateFileForWrite_InputArguments = new ExpandedNodeId(UAModel.DI.Variables.PackageLoadingType_FileTransfer_GenerateFileForWrite_InputArguments, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId PackageLoadingType_FileTransfer_GenerateFileForWrite_OutputArguments = new ExpandedNodeId(UAModel.DI.Variables.PackageLoadingType_FileTransfer_GenerateFileForWrite_OutputArguments, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId PackageLoadingType_FileTransfer_CloseAndCommit_InputArguments = new ExpandedNodeId(UAModel.DI.Variables.PackageLoadingType_FileTransfer_CloseAndCommit_InputArguments, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId PackageLoadingType_FileTransfer_CloseAndCommit_OutputArguments = new ExpandedNodeId(UAModel.DI.Variables.PackageLoadingType_FileTransfer_CloseAndCommit_OutputArguments, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId PackageLoadingType_ErrorMessage = new ExpandedNodeId(UAModel.DI.Variables.PackageLoadingType_ErrorMessage, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId PackageLoadingType_WriteBlockSize = new ExpandedNodeId(UAModel.DI.Variables.PackageLoadingType_WriteBlockSize, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId DirectLoadingType_CurrentVersion_Manufacturer = new ExpandedNodeId(UAModel.DI.Variables.DirectLoadingType_CurrentVersion_Manufacturer, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId DirectLoadingType_CurrentVersion_ManufacturerUri = new ExpandedNodeId(UAModel.DI.Variables.DirectLoadingType_CurrentVersion_ManufacturerUri, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId DirectLoadingType_CurrentVersion_SoftwareRevision = new ExpandedNodeId(UAModel.DI.Variables.DirectLoadingType_CurrentVersion_SoftwareRevision, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId DirectLoadingType_FileTransfer_ClientProcessingTimeout = new ExpandedNodeId(UAModel.DI.Variables.DirectLoadingType_FileTransfer_ClientProcessingTimeout, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId DirectLoadingType_FileTransfer_GenerateFileForRead_InputArguments = new ExpandedNodeId(UAModel.DI.Variables.DirectLoadingType_FileTransfer_GenerateFileForRead_InputArguments, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId DirectLoadingType_FileTransfer_GenerateFileForRead_OutputArguments = new ExpandedNodeId(UAModel.DI.Variables.DirectLoadingType_FileTransfer_GenerateFileForRead_OutputArguments, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId DirectLoadingType_FileTransfer_GenerateFileForWrite_InputArguments = new ExpandedNodeId(UAModel.DI.Variables.DirectLoadingType_FileTransfer_GenerateFileForWrite_InputArguments, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId DirectLoadingType_FileTransfer_GenerateFileForWrite_OutputArguments = new ExpandedNodeId(UAModel.DI.Variables.DirectLoadingType_FileTransfer_GenerateFileForWrite_OutputArguments, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId DirectLoadingType_FileTransfer_CloseAndCommit_InputArguments = new ExpandedNodeId(UAModel.DI.Variables.DirectLoadingType_FileTransfer_CloseAndCommit_InputArguments, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId DirectLoadingType_FileTransfer_CloseAndCommit_OutputArguments = new ExpandedNodeId(UAModel.DI.Variables.DirectLoadingType_FileTransfer_CloseAndCommit_OutputArguments, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId DirectLoadingType_UpdateBehavior = new ExpandedNodeId(UAModel.DI.Variables.DirectLoadingType_UpdateBehavior, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId DirectLoadingType_WriteTimeout = new ExpandedNodeId(UAModel.DI.Variables.DirectLoadingType_WriteTimeout, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId CachedLoadingType_CurrentVersion_Manufacturer = new ExpandedNodeId(UAModel.DI.Variables.CachedLoadingType_CurrentVersion_Manufacturer, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId CachedLoadingType_CurrentVersion_ManufacturerUri = new ExpandedNodeId(UAModel.DI.Variables.CachedLoadingType_CurrentVersion_ManufacturerUri, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId CachedLoadingType_CurrentVersion_SoftwareRevision = new ExpandedNodeId(UAModel.DI.Variables.CachedLoadingType_CurrentVersion_SoftwareRevision, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId CachedLoadingType_FileTransfer_ClientProcessingTimeout = new ExpandedNodeId(UAModel.DI.Variables.CachedLoadingType_FileTransfer_ClientProcessingTimeout, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId CachedLoadingType_FileTransfer_GenerateFileForRead_InputArguments = new ExpandedNodeId(UAModel.DI.Variables.CachedLoadingType_FileTransfer_GenerateFileForRead_InputArguments, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId CachedLoadingType_FileTransfer_GenerateFileForRead_OutputArguments = new ExpandedNodeId(UAModel.DI.Variables.CachedLoadingType_FileTransfer_GenerateFileForRead_OutputArguments, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId CachedLoadingType_FileTransfer_GenerateFileForWrite_InputArguments = new ExpandedNodeId(UAModel.DI.Variables.CachedLoadingType_FileTransfer_GenerateFileForWrite_InputArguments, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId CachedLoadingType_FileTransfer_GenerateFileForWrite_OutputArguments = new ExpandedNodeId(UAModel.DI.Variables.CachedLoadingType_FileTransfer_GenerateFileForWrite_OutputArguments, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId CachedLoadingType_FileTransfer_CloseAndCommit_InputArguments = new ExpandedNodeId(UAModel.DI.Variables.CachedLoadingType_FileTransfer_CloseAndCommit_InputArguments, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId CachedLoadingType_FileTransfer_CloseAndCommit_OutputArguments = new ExpandedNodeId(UAModel.DI.Variables.CachedLoadingType_FileTransfer_CloseAndCommit_OutputArguments, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId CachedLoadingType_PendingVersion_Manufacturer = new ExpandedNodeId(UAModel.DI.Variables.CachedLoadingType_PendingVersion_Manufacturer, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId CachedLoadingType_PendingVersion_ManufacturerUri = new ExpandedNodeId(UAModel.DI.Variables.CachedLoadingType_PendingVersion_ManufacturerUri, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId CachedLoadingType_PendingVersion_SoftwareRevision = new ExpandedNodeId(UAModel.DI.Variables.CachedLoadingType_PendingVersion_SoftwareRevision, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId CachedLoadingType_FallbackVersion_Manufacturer = new ExpandedNodeId(UAModel.DI.Variables.CachedLoadingType_FallbackVersion_Manufacturer, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId CachedLoadingType_FallbackVersion_ManufacturerUri = new ExpandedNodeId(UAModel.DI.Variables.CachedLoadingType_FallbackVersion_ManufacturerUri, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId CachedLoadingType_FallbackVersion_SoftwareRevision = new ExpandedNodeId(UAModel.DI.Variables.CachedLoadingType_FallbackVersion_SoftwareRevision, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId CachedLoadingType_GetUpdateBehavior_InputArguments = new ExpandedNodeId(UAModel.DI.Variables.CachedLoadingType_GetUpdateBehavior_InputArguments, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId CachedLoadingType_GetUpdateBehavior_OutputArguments = new ExpandedNodeId(UAModel.DI.Variables.CachedLoadingType_GetUpdateBehavior_OutputArguments, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId FileSystemLoadingType_FileSystem_CreateDirectory_InputArguments = new ExpandedNodeId(UAModel.DI.Variables.FileSystemLoadingType_FileSystem_CreateDirectory_InputArguments, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId FileSystemLoadingType_FileSystem_CreateDirectory_OutputArguments = new ExpandedNodeId(UAModel.DI.Variables.FileSystemLoadingType_FileSystem_CreateDirectory_OutputArguments, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId FileSystemLoadingType_FileSystem_CreateFile_InputArguments = new ExpandedNodeId(UAModel.DI.Variables.FileSystemLoadingType_FileSystem_CreateFile_InputArguments, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId FileSystemLoadingType_FileSystem_CreateFile_OutputArguments = new ExpandedNodeId(UAModel.DI.Variables.FileSystemLoadingType_FileSystem_CreateFile_OutputArguments, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId FileSystemLoadingType_FileSystem_DeleteFileSystemObject_InputArguments = new ExpandedNodeId(UAModel.DI.Variables.FileSystemLoadingType_FileSystem_DeleteFileSystemObject_InputArguments, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId FileSystemLoadingType_FileSystem_MoveOrCopy_InputArguments = new ExpandedNodeId(UAModel.DI.Variables.FileSystemLoadingType_FileSystem_MoveOrCopy_InputArguments, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId FileSystemLoadingType_FileSystem_MoveOrCopy_OutputArguments = new ExpandedNodeId(UAModel.DI.Variables.FileSystemLoadingType_FileSystem_MoveOrCopy_OutputArguments, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId FileSystemLoadingType_GetUpdateBehavior_InputArguments = new ExpandedNodeId(UAModel.DI.Variables.FileSystemLoadingType_GetUpdateBehavior_InputArguments, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId FileSystemLoadingType_GetUpdateBehavior_OutputArguments = new ExpandedNodeId(UAModel.DI.Variables.FileSystemLoadingType_GetUpdateBehavior_OutputArguments, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId FileSystemLoadingType_ValidateFiles_InputArguments = new ExpandedNodeId(UAModel.DI.Variables.FileSystemLoadingType_ValidateFiles_InputArguments, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId FileSystemLoadingType_ValidateFiles_OutputArguments = new ExpandedNodeId(UAModel.DI.Variables.FileSystemLoadingType_ValidateFiles_OutputArguments, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId SoftwareVersionType_Manufacturer = new ExpandedNodeId(UAModel.DI.Variables.SoftwareVersionType_Manufacturer, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId SoftwareVersionType_ManufacturerUri = new ExpandedNodeId(UAModel.DI.Variables.SoftwareVersionType_ManufacturerUri, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId SoftwareVersionType_SoftwareRevision = new ExpandedNodeId(UAModel.DI.Variables.SoftwareVersionType_SoftwareRevision, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId SoftwareVersionType_PatchIdentifiers = new ExpandedNodeId(UAModel.DI.Variables.SoftwareVersionType_PatchIdentifiers, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId SoftwareVersionType_ReleaseDate = new ExpandedNodeId(UAModel.DI.Variables.SoftwareVersionType_ReleaseDate, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId SoftwareVersionType_ChangeLogReference = new ExpandedNodeId(UAModel.DI.Variables.SoftwareVersionType_ChangeLogReference, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId SoftwareVersionType_Hash = new ExpandedNodeId(UAModel.DI.Variables.SoftwareVersionType_Hash, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId PrepareForUpdateStateMachineType_PercentComplete = new ExpandedNodeId(UAModel.DI.Variables.PrepareForUpdateStateMachineType_PercentComplete, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId PrepareForUpdateStateMachineType_Idle_StateNumber = new ExpandedNodeId(UAModel.DI.Variables.PrepareForUpdateStateMachineType_Idle_StateNumber, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId PrepareForUpdateStateMachineType_Preparing_StateNumber = new ExpandedNodeId(UAModel.DI.Variables.PrepareForUpdateStateMachineType_Preparing_StateNumber, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId PrepareForUpdateStateMachineType_PreparedForUpdate_StateNumber = new ExpandedNodeId(UAModel.DI.Variables.PrepareForUpdateStateMachineType_PreparedForUpdate_StateNumber, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId PrepareForUpdateStateMachineType_Resuming_StateNumber = new ExpandedNodeId(UAModel.DI.Variables.PrepareForUpdateStateMachineType_Resuming_StateNumber, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId PrepareForUpdateStateMachineType_IdleToPreparing_TransitionNumber = new ExpandedNodeId(UAModel.DI.Variables.PrepareForUpdateStateMachineType_IdleToPreparing_TransitionNumber, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId PrepareForUpdateStateMachineType_PreparingToIdle_TransitionNumber = new ExpandedNodeId(UAModel.DI.Variables.PrepareForUpdateStateMachineType_PreparingToIdle_TransitionNumber, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId PrepareForUpdateStateMachineType_PreparingToPreparedForUpdate_TransitionNumber = new ExpandedNodeId(UAModel.DI.Variables.PrepareForUpdateStateMachineType_PreparingToPreparedForUpdate_TransitionNumber, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId PrepareForUpdateStateMachineType_PreparedForUpdateToResuming_TransitionNumber = new ExpandedNodeId(UAModel.DI.Variables.PrepareForUpdateStateMachineType_PreparedForUpdateToResuming_TransitionNumber, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId PrepareForUpdateStateMachineType_ResumingToIdle_TransitionNumber = new ExpandedNodeId(UAModel.DI.Variables.PrepareForUpdateStateMachineType_ResumingToIdle_TransitionNumber, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId InstallationStateMachineType_PercentComplete = new ExpandedNodeId(UAModel.DI.Variables.InstallationStateMachineType_PercentComplete, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId InstallationStateMachineType_InstallationDelay = new ExpandedNodeId(UAModel.DI.Variables.InstallationStateMachineType_InstallationDelay, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId InstallationStateMachineType_InstallSoftwarePackage_InputArguments = new ExpandedNodeId(UAModel.DI.Variables.InstallationStateMachineType_InstallSoftwarePackage_InputArguments, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId InstallationStateMachineType_InstallFiles_InputArguments = new ExpandedNodeId(UAModel.DI.Variables.InstallationStateMachineType_InstallFiles_InputArguments, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId InstallationStateMachineType_Idle_StateNumber = new ExpandedNodeId(UAModel.DI.Variables.InstallationStateMachineType_Idle_StateNumber, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId InstallationStateMachineType_Installing_StateNumber = new ExpandedNodeId(UAModel.DI.Variables.InstallationStateMachineType_Installing_StateNumber, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId InstallationStateMachineType_Error_StateNumber = new ExpandedNodeId(UAModel.DI.Variables.InstallationStateMachineType_Error_StateNumber, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId InstallationStateMachineType_IdleToInstalling_TransitionNumber = new ExpandedNodeId(UAModel.DI.Variables.InstallationStateMachineType_IdleToInstalling_TransitionNumber, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId InstallationStateMachineType_InstallingToIdle_TransitionNumber = new ExpandedNodeId(UAModel.DI.Variables.InstallationStateMachineType_InstallingToIdle_TransitionNumber, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId InstallationStateMachineType_InstallingToError_TransitionNumber = new ExpandedNodeId(UAModel.DI.Variables.InstallationStateMachineType_InstallingToError_TransitionNumber, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId InstallationStateMachineType_ErrorToIdle_TransitionNumber = new ExpandedNodeId(UAModel.DI.Variables.InstallationStateMachineType_ErrorToIdle_TransitionNumber, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId PowerCycleStateMachineType_NotWaitingForPowerCycle_StateNumber = new ExpandedNodeId(UAModel.DI.Variables.PowerCycleStateMachineType_NotWaitingForPowerCycle_StateNumber, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId PowerCycleStateMachineType_WaitingForPowerCycle_StateNumber = new ExpandedNodeId(UAModel.DI.Variables.PowerCycleStateMachineType_WaitingForPowerCycle_StateNumber, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId PowerCycleStateMachineType_NotWaitingForPowerCycleToWaitingForPowerCycle_TransitionNumber = new ExpandedNodeId(UAModel.DI.Variables.PowerCycleStateMachineType_NotWaitingForPowerCycleToWaitingForPowerCycle_TransitionNumber, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId PowerCycleStateMachineType_WaitingForPowerCycleToNotWaitingForPowerCycle_TransitionNumber = new ExpandedNodeId(UAModel.DI.Variables.PowerCycleStateMachineType_WaitingForPowerCycleToNotWaitingForPowerCycle_TransitionNumber, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId ConfirmationStateMachineType_ConfirmationTimeout = new ExpandedNodeId(UAModel.DI.Variables.ConfirmationStateMachineType_ConfirmationTimeout, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId ConfirmationStateMachineType_NotWaitingForConfirm_StateNumber = new ExpandedNodeId(UAModel.DI.Variables.ConfirmationStateMachineType_NotWaitingForConfirm_StateNumber, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId ConfirmationStateMachineType_WaitingForConfirm_StateNumber = new ExpandedNodeId(UAModel.DI.Variables.ConfirmationStateMachineType_WaitingForConfirm_StateNumber, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId ConfirmationStateMachineType_NotWaitingForConfirmToWaitingForConfirm_TransitionNumber = new ExpandedNodeId(UAModel.DI.Variables.ConfirmationStateMachineType_NotWaitingForConfirmToWaitingForConfirm_TransitionNumber, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId ConfirmationStateMachineType_WaitingForConfirmToNotWaitingForConfirm_TransitionNumber = new ExpandedNodeId(UAModel.DI.Variables.ConfirmationStateMachineType_WaitingForConfirmToNotWaitingForConfirm_TransitionNumber, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId SoftwareVersionFileType_EnumStrings = new ExpandedNodeId(UAModel.DI.Variables.SoftwareVersionFileType_EnumStrings, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId UpdateBehavior_OptionSetValues = new ExpandedNodeId(UAModel.DI.Variables.UpdateBehavior_OptionSetValues, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId OpcUaDi_BinarySchema = new ExpandedNodeId(UAModel.DI.Variables.OpcUaDi_BinarySchema, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId OpcUaDi_XmlSchema = new ExpandedNodeId(UAModel.DI.Variables.OpcUaDi_XmlSchema, UAModel.DI.Namespaces.DI);
    }
    #endregion

    #region VariableType Node Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class VariableTypeIds
    {
        /// <remarks />
        public static readonly ExpandedNodeId LifetimeVariableType = new ExpandedNodeId(UAModel.DI.VariableTypes.LifetimeVariableType, UAModel.DI.Namespaces.DI);

        /// <remarks />
        public static readonly ExpandedNodeId UIElementType = new ExpandedNodeId(UAModel.DI.VariableTypes.UIElementType, UAModel.DI.Namespaces.DI);
    }
    #endregion

    #region BrowseName Declarations
    /// <remarks />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class BrowseNames
    {
        /// <remarks />
        public const string Abort = "Abort";

        /// <remarks />
        public const string ActualMode = "ActualMode";

        /// <remarks />
        public const string AssetId = "AssetId";

        /// <remarks />
        public const string BaseLifetimeIndicationType = "BaseLifetimeIndicationType";

        /// <remarks />
        public const string BlockType = "BlockType";

        /// <remarks />
        public const string BreakLock = "BreakLock";

        /// <remarks />
        public const string BreakLockMethodType = "BreakLockMethodType";

        /// <remarks />
        public const string CachedLoadingType = "CachedLoadingType";

        /// <remarks />
        public const string ChangeLogReference = "ChangeLogReference";

        /// <remarks />
        public const string CheckFunctionAlarmType = "CheckFunctionAlarmType";

        /// <remarks />
        public const string ComponentName = "ComponentName";

        /// <remarks />
        public const string ComponentType = "ComponentType";

        /// <remarks />
        public const string ConfigurableObjectType = "ConfigurableObjectType";

        /// <remarks />
        public const string Confirm = "Confirm";

        /// <remarks />
        public const string Confirmation = "Confirmation";

        /// <remarks />
        public const string ConfirmationStateMachineType = "ConfirmationStateMachineType";

        /// <remarks />
        public const string ConfirmationTimeout = "ConfirmationTimeout";

        /// <remarks />
        public const string ConnectionPointType = "ConnectionPointType";

        /// <remarks />
        public const string ConnectsTo = "ConnectsTo";

        /// <remarks />
        public const string ConnectsToParent = "ConnectsToParent";

        /// <remarks />
        public const string CPIdentifier = "<CPIdentifier>";

        /// <remarks />
        public const string CurrentVersion = "CurrentVersion";

        /// <remarks />
        public const string DeviceClass = "DeviceClass";

        /// <remarks />
        public const string DeviceFeatures = "DeviceFeatures";

        /// <remarks />
        public const string DeviceHealth = "DeviceHealth";

        /// <remarks />
        public const string DeviceHealthAlarms = "DeviceHealthAlarms";

        /// <remarks />
        public const string DeviceHealthDiagnosticAlarmType = "DeviceHealthDiagnosticAlarmType";

        /// <remarks />
        public const string DeviceHealthEnumeration = "DeviceHealthEnumeration";

        /// <remarks />
        public const string DeviceManual = "DeviceManual";

        /// <remarks />
        public const string DeviceRevision = "DeviceRevision";

        /// <remarks />
        public const string DeviceSet = "DeviceSet";

        /// <remarks />
        public const string DeviceTopology = "DeviceTopology";

        /// <remarks />
        public const string DeviceType = "DeviceType";

        /// <remarks />
        public const string DeviceTypeImage = "DeviceTypeImage";

        /// <remarks />
        public const string DiameterIndicationType = "DiameterIndicationType";

        /// <remarks />
        public const string DirectLoadingType = "DirectLoadingType";

        /// <remarks />
        public const string Documentation = "Documentation";

        /// <remarks />
        public const string DocumentationFiles = "DocumentationFiles";

        /// <remarks />
        public const string Error = "Error";

        /// <remarks />
        public const string ErrorMessage = "ErrorMessage";

        /// <remarks />
        public const string ErrorToIdle = "ErrorToIdle";

        /// <remarks />
        public const string ExitLock = "ExitLock";

        /// <remarks />
        public const string ExitLockMethodType = "ExitLockMethodType";

        /// <remarks />
        public const string FailureAlarmType = "FailureAlarmType";

        /// <remarks />
        public const string FallbackVersion = "FallbackVersion";

        /// <remarks />
        public const string FetchResultDataType = "FetchResultDataType";

        /// <remarks />
        public const string FetchTransferResultData = "FetchTransferResultData";

        /// <remarks />
        public const string FetchTransferResultDataMethodType = "FetchTransferResultDataMethodType";

        /// <remarks />
        public const string FileSystemLoadingType = "FileSystemLoadingType";

        /// <remarks />
        public const string FileTransfer = "FileTransfer";

        /// <remarks />
        public const string FunctionalGroupType = "FunctionalGroupType";

        /// <remarks />
        public const string GetUpdateBehavior = "GetUpdateBehavior";

        /// <remarks />
        public const string GetUpdateBehaviorMethodType = "GetUpdateBehaviorMethodType";

        /// <remarks />
        public const string GroupIdentifier = "<GroupIdentifier>";

        /// <remarks />
        public const string HardwareRevision = "HardwareRevision";

        /// <remarks />
        public const string Hash = "Hash";

        /// <remarks />
        public const string Identification = "Identification";

        /// <remarks />
        public const string IDeviceHealthType = "IDeviceHealthType";

        /// <remarks />
        public const string Idle = "Idle";

        /// <remarks />
        public const string IdleToInstalling = "IdleToInstalling";

        /// <remarks />
        public const string IdleToPreparing = "IdleToPreparing";

        /// <remarks />
        public const string ImageSet = "ImageSet";

        /// <remarks />
        public const string Indication = "Indication";

        /// <remarks />
        public const string InitLock = "InitLock";

        /// <remarks />
        public const string InitLockMethodType = "InitLockMethodType";

        /// <remarks />
        public const string Installation = "Installation";

        /// <remarks />
        public const string InstallationDelay = "InstallationDelay";

        /// <remarks />
        public const string InstallationStateMachineType = "InstallationStateMachineType";

        /// <remarks />
        public const string InstallFiles = "InstallFiles";

        /// <remarks />
        public const string InstallFilesMethodType = "InstallFilesMethodType";

        /// <remarks />
        public const string Installing = "Installing";

        /// <remarks />
        public const string InstallingToError = "InstallingToError";

        /// <remarks />
        public const string InstallingToIdle = "InstallingToIdle";

        /// <remarks />
        public const string InstallSoftwarePackage = "InstallSoftwarePackage";

        /// <remarks />
        public const string InstallSoftwarePackageMethodType = "InstallSoftwarePackageMethodType";

        /// <remarks />
        public const string IOperationCounterType = "IOperationCounterType";

        /// <remarks />
        public const string IsOnline = "IsOnline";

        /// <remarks />
        public const string ISupportInfoType = "ISupportInfoType";

        /// <remarks />
        public const string ITagNameplateType = "ITagNameplateType";

        /// <remarks />
        public const string IVendorNameplateType = "IVendorNameplateType";

        /// <remarks />
        public const string LengthIndicationType = "LengthIndicationType";

        /// <remarks />
        public const string LifetimeVariableType = "LifetimeVariableType";

        /// <remarks />
        public const string LimitValue = "LimitValue";

        /// <remarks />
        public const string Loading = "Loading";

        /// <remarks />
        public const string Lock = "Lock";

        /// <remarks />
        public const string Locked = "Locked";

        /// <remarks />
        public const string LockingClient = "LockingClient";

        /// <remarks />
        public const string LockingServicesType = "LockingServicesType";

        /// <remarks />
        public const string LockingUser = "LockingUser";

        /// <remarks />
        public const string MaintenanceRequiredAlarmType = "MaintenanceRequiredAlarmType";

        /// <remarks />
        public const string Manufacturer = "Manufacturer";

        /// <remarks />
        public const string ManufacturerUri = "ManufacturerUri";

        /// <remarks />
        public const string MaxInactiveLockTime = "MaxInactiveLockTime";

        /// <remarks />
        public const string MethodSet = "MethodSet";

        /// <remarks />
        public const string Model = "Model";

        /// <remarks />
        public const string NetworkAddress = "NetworkAddress";

        /// <remarks />
        public const string NetworkIdentifier = "<NetworkIdentifier>";

        /// <remarks />
        public const string NetworkSet = "NetworkSet";

        /// <remarks />
        public const string NetworkType = "NetworkType";

        /// <remarks />
        public const string NormalMode = "NormalMode";

        /// <remarks />
        public const string NotWaitingForConfirm = "NotWaitingForConfirm";

        /// <remarks />
        public const string NotWaitingForConfirmToWaitingForConfirm = "NotWaitingForConfirmToWaitingForConfirm";

        /// <remarks />
        public const string NotWaitingForPowerCycle = "NotWaitingForPowerCycle";

        /// <remarks />
        public const string NotWaitingForPowerCycleToWaitingForPowerCycle = "NotWaitingForPowerCycleToWaitingForPowerCycle";

        /// <remarks />
        public const string NumberOfPartsIndicationType = "NumberOfPartsIndicationType";

        /// <remarks />
        public const string NumberOfUsagesIndicationType = "NumberOfUsagesIndicationType";

        /// <remarks />
        public const string ObjectIdentifier = "<ObjectIdentifier>";

        /// <remarks />
        public const string OffSpecAlarmType = "OffSpecAlarmType";

        /// <remarks />
        public const string OnlineAccess = "OnlineAccess";

        /// <remarks />
        public const string OpcUaDi_BinarySchema = "Opc.Ua.Di";

        /// <remarks />
        public const string OpcUaDi_XmlSchema = "Opc.Ua.Di";

        /// <remarks />
        public const string OPCUADINamespaceMetadata = "http://opcfoundation.org/UA/DI/";

        /// <remarks />
        public const string OperationCycleCounter = "OperationCycleCounter";

        /// <remarks />
        public const string OperationDuration = "OperationDuration";

        /// <remarks />
        public const string PackageLoadingType = "PackageLoadingType";

        /// <remarks />
        public const string ParameterResultDataType = "ParameterResultDataType";

        /// <remarks />
        public const string Parameters = "Parameters";

        /// <remarks />
        public const string ParameterSet = "ParameterSet";

        /// <remarks />
        public const string PatchIdentifiers = "PatchIdentifiers";

        /// <remarks />
        public const string PendingVersion = "PendingVersion";

        /// <remarks />
        public const string PercentComplete = "PercentComplete";

        /// <remarks />
        public const string PermittedMode = "PermittedMode";

        /// <remarks />
        public const string PowerCycle = "PowerCycle";

        /// <remarks />
        public const string PowerCycleStateMachineType = "PowerCycleStateMachineType";

        /// <remarks />
        public const string PowerOnDuration = "PowerOnDuration";

        /// <remarks />
        public const string Prepare = "Prepare";

        /// <remarks />
        public const string PreparedForUpdate = "PreparedForUpdate";

        /// <remarks />
        public const string PreparedForUpdateToResuming = "PreparedForUpdateToResuming";

        /// <remarks />
        public const string PrepareForUpdate = "PrepareForUpdate";

        /// <remarks />
        public const string PrepareForUpdateStateMachineType = "PrepareForUpdateStateMachineType";

        /// <remarks />
        public const string Preparing = "Preparing";

        /// <remarks />
        public const string PreparingToIdle = "PreparingToIdle";

        /// <remarks />
        public const string PreparingToPreparedForUpdate = "PreparingToPreparedForUpdate";

        /// <remarks />
        public const string ProductCode = "ProductCode";

        /// <remarks />
        public const string ProductInstanceUri = "ProductInstanceUri";

        /// <remarks />
        public const string ProfileIdentifier = "<ProfileIdentifier>";

        /// <remarks />
        public const string ProtocolSupport = "ProtocolSupport";

        /// <remarks />
        public const string ProtocolType = "ProtocolType";

        /// <remarks />
        public const string ReleaseDate = "ReleaseDate";

        /// <remarks />
        public const string RemainingLockTime = "RemainingLockTime";

        /// <remarks />
        public const string RenewLock = "RenewLock";

        /// <remarks />
        public const string RenewLockMethodType = "RenewLockMethodType";

        /// <remarks />
        public const string Resume = "Resume";

        /// <remarks />
        public const string Resuming = "Resuming";

        /// <remarks />
        public const string ResumingToIdle = "ResumingToIdle";

        /// <remarks />
        public const string RevisionCounter = "RevisionCounter";

        /// <remarks />
        public const string SerialNumber = "SerialNumber";

        /// <remarks />
        public const string SoftwareLoadingType = "SoftwareLoadingType";

        /// <remarks />
        public const string SoftwareReleaseDate = "SoftwareReleaseDate";

        /// <remarks />
        public const string SoftwareRevision = "SoftwareRevision";

        /// <remarks />
        public const string SoftwareType = "SoftwareType";

        /// <remarks />
        public const string SoftwareUpdate = "SoftwareUpdate";

        /// <remarks />
        public const string SoftwareUpdateType = "SoftwareUpdateType";

        /// <remarks />
        public const string SoftwareVersionFileType = "SoftwareVersionFileType";

        /// <remarks />
        public const string SoftwareVersionType = "SoftwareVersionType";

        /// <remarks />
        public const string StartValue = "StartValue";

        /// <remarks />
        public const string SubstanceVolumeIndicationType = "SubstanceVolumeIndicationType";

        /// <remarks />
        public const string SupportedTypes = "SupportedTypes";

        /// <remarks />
        public const string TargetMode = "TargetMode";

        /// <remarks />
        public const string TimeIndicationType = "TimeIndicationType";

        /// <remarks />
        public const string TopologyElementType = "TopologyElementType";

        /// <remarks />
        public const string TransferFromDevice = "TransferFromDevice";

        /// <remarks />
        public const string TransferFromDeviceMethodType = "TransferFromDeviceMethodType";

        /// <remarks />
        public const string TransferResultDataDataType = "TransferResultDataDataType";

        /// <remarks />
        public const string TransferResultErrorDataType = "TransferResultErrorDataType";

        /// <remarks />
        public const string TransferServicesType = "TransferServicesType";

        /// <remarks />
        public const string TransferToDevice = "TransferToDevice";

        /// <remarks />
        public const string TransferToDeviceMethodType = "TransferToDeviceMethodType";

        /// <remarks />
        public const string UIElement = "UIElement";

        /// <remarks />
        public const string UIElementType = "UIElementType";

        /// <remarks />
        public const string UpdateBehavior = "UpdateBehavior";

        /// <remarks />
        public const string UpdateKey = "UpdateKey";

        /// <remarks />
        public const string UpdateStatus = "UpdateStatus";

        /// <remarks />
        public const string ValidateFiles = "ValidateFiles";

        /// <remarks />
        public const string ValidateFilesMethodType = "ValidateFilesMethodType";

        /// <remarks />
        public const string VendorErrorCode = "VendorErrorCode";

        /// <remarks />
        public const string WaitingForConfirm = "WaitingForConfirm";

        /// <remarks />
        public const string WaitingForConfirmToNotWaitingForConfirm = "WaitingForConfirmToNotWaitingForConfirm";

        /// <remarks />
        public const string WaitingForPowerCycle = "WaitingForPowerCycle";

        /// <remarks />
        public const string WaitingForPowerCycleToNotWaitingForPowerCycle = "WaitingForPowerCycleToNotWaitingForPowerCycle";

        /// <remarks />
        public const string WarningValues = "WarningValues";

        /// <remarks />
        public const string WriteBlockSize = "WriteBlockSize";

        /// <remarks />
        public const string WriteTimeout = "WriteTimeout";
    }
    #endregion

    #region Namespace Declarations
    /// <remarks />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Namespaces
    {
        /// <summary>
        /// The URI for the DI namespace (.NET code namespace is 'UAModel.DI').
        /// </summary>
        public const string DI = "http://opcfoundation.org/UA/DI/";

        /// <summary>
        /// The URI for the DIXsd namespace (.NET code namespace is 'UAModel.DI').
        /// </summary>
        public const string DIXsd = "http://opcfoundation.org/UA/DI/Types.xsd";

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