// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20210701
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Extensions;

    /// <summary>Azure backup restore request</summary>
    public partial class AzureBackupRestoreRequest :
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20210701.IAzureBackupRestoreRequest,
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20210701.IAzureBackupRestoreRequestInternal
    {

        /// <summary>Backing field for <see cref="ObjectType" /> property.</summary>
        private string _objectType;

        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Owned)]
        public string ObjectType { get => this._objectType; set => this._objectType = value; }

        /// <summary>Backing field for <see cref="RestoreTargetInfo" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20210701.IRestoreTargetInfoBase _restoreTargetInfo;

        /// <summary>Gets or sets the restore target information.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20210701.IRestoreTargetInfoBase RestoreTargetInfo { get => (this._restoreTargetInfo = this._restoreTargetInfo ?? new Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20210701.RestoreTargetInfoBase()); set => this._restoreTargetInfo = value; }

        /// <summary>Backing field for <see cref="SourceDataStoreType" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.SourceDataStoreType _sourceDataStoreType;

        /// <summary>Gets or sets the type of the source data store.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.SourceDataStoreType SourceDataStoreType { get => this._sourceDataStoreType; set => this._sourceDataStoreType = value; }

        /// <summary>Creates an new <see cref="AzureBackupRestoreRequest" /> instance.</summary>
        public AzureBackupRestoreRequest()
        {

        }
    }
    /// Azure backup restore request
    public partial interface IAzureBackupRestoreRequest :
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.IJsonSerializable
    {
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"objectType",
        PossibleTypes = new [] { typeof(string) })]
        string ObjectType { get; set; }
        /// <summary>Gets or sets the restore target information.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Gets or sets the restore target information.",
        SerializedName = @"restoreTargetInfo",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20210701.IRestoreTargetInfoBase) })]
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20210701.IRestoreTargetInfoBase RestoreTargetInfo { get; set; }
        /// <summary>Gets or sets the type of the source data store.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Gets or sets the type of the source data store.",
        SerializedName = @"sourceDataStoreType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.SourceDataStoreType) })]
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.SourceDataStoreType SourceDataStoreType { get; set; }

    }
    /// Azure backup restore request
    internal partial interface IAzureBackupRestoreRequestInternal

    {
        string ObjectType { get; set; }
        /// <summary>Gets or sets the restore target information.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20210701.IRestoreTargetInfoBase RestoreTargetInfo { get; set; }
        /// <summary>Gets or sets the type of the source data store.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.SourceDataStoreType SourceDataStoreType { get; set; }

    }
}