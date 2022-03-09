// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20210701
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Extensions;

    /// <summary>List Restore Ranges Request</summary>
    public partial class AzureBackupFindRestorableTimeRangesRequest :
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20210701.IAzureBackupFindRestorableTimeRangesRequest,
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20210701.IAzureBackupFindRestorableTimeRangesRequestInternal
    {

        /// <summary>Backing field for <see cref="EndTime" /> property.</summary>
        private string _endTime;

        /// <summary>End time for the List Restore Ranges request. ISO 8601 format.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Owned)]
        public string EndTime { get => this._endTime; set => this._endTime = value; }

        /// <summary>Backing field for <see cref="SourceDataStoreType" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.RestoreSourceDataStoreType _sourceDataStoreType;

        /// <summary>Gets or sets the type of the source data store.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.RestoreSourceDataStoreType SourceDataStoreType { get => this._sourceDataStoreType; set => this._sourceDataStoreType = value; }

        /// <summary>Backing field for <see cref="StartTime" /> property.</summary>
        private string _startTime;

        /// <summary>Start time for the List Restore Ranges request. ISO 8601 format.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Owned)]
        public string StartTime { get => this._startTime; set => this._startTime = value; }

        /// <summary>
        /// Creates an new <see cref="AzureBackupFindRestorableTimeRangesRequest" /> instance.
        /// </summary>
        public AzureBackupFindRestorableTimeRangesRequest()
        {

        }
    }
    /// List Restore Ranges Request
    public partial interface IAzureBackupFindRestorableTimeRangesRequest :
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.IJsonSerializable
    {
        /// <summary>End time for the List Restore Ranges request. ISO 8601 format.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"End time for the List Restore Ranges request. ISO 8601 format.",
        SerializedName = @"endTime",
        PossibleTypes = new [] { typeof(string) })]
        string EndTime { get; set; }
        /// <summary>Gets or sets the type of the source data store.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Gets or sets the type of the source data store.",
        SerializedName = @"sourceDataStoreType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.RestoreSourceDataStoreType) })]
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.RestoreSourceDataStoreType SourceDataStoreType { get; set; }
        /// <summary>Start time for the List Restore Ranges request. ISO 8601 format.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Start time for the List Restore Ranges request. ISO 8601 format.",
        SerializedName = @"startTime",
        PossibleTypes = new [] { typeof(string) })]
        string StartTime { get; set; }

    }
    /// List Restore Ranges Request
    internal partial interface IAzureBackupFindRestorableTimeRangesRequestInternal

    {
        /// <summary>End time for the List Restore Ranges request. ISO 8601 format.</summary>
        string EndTime { get; set; }
        /// <summary>Gets or sets the type of the source data store.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.RestoreSourceDataStoreType SourceDataStoreType { get; set; }
        /// <summary>Start time for the List Restore Ranges request. ISO 8601 format.</summary>
        string StartTime { get; set; }

    }
}