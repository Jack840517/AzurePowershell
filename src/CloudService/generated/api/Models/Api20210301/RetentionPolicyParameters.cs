// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301
{
    using static Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Extensions;

    /// <summary>Parameters that define the retention policy for flow log.</summary>
    public partial class RetentionPolicyParameters :
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IRetentionPolicyParameters,
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IRetentionPolicyParametersInternal
    {

        /// <summary>Backing field for <see cref="Day" /> property.</summary>
        private int? _day;

        /// <summary>Number of days to retain flow log records.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Owned)]
        public int? Day { get => this._day; set => this._day = value; }

        /// <summary>Backing field for <see cref="Enabled" /> property.</summary>
        private bool? _enabled;

        /// <summary>Flag to enable/disable retention.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Owned)]
        public bool? Enabled { get => this._enabled; set => this._enabled = value; }

        /// <summary>Creates an new <see cref="RetentionPolicyParameters" /> instance.</summary>
        public RetentionPolicyParameters()
        {

        }
    }
    /// Parameters that define the retention policy for flow log.
    public partial interface IRetentionPolicyParameters :
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.IJsonSerializable
    {
        /// <summary>Number of days to retain flow log records.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Number of days to retain flow log records.",
        SerializedName = @"days",
        PossibleTypes = new [] { typeof(int) })]
        int? Day { get; set; }
        /// <summary>Flag to enable/disable retention.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Flag to enable/disable retention.",
        SerializedName = @"enabled",
        PossibleTypes = new [] { typeof(bool) })]
        bool? Enabled { get; set; }

    }
    /// Parameters that define the retention policy for flow log.
    internal partial interface IRetentionPolicyParametersInternal

    {
        /// <summary>Number of days to retain flow log records.</summary>
        int? Day { get; set; }
        /// <summary>Flag to enable/disable retention.</summary>
        bool? Enabled { get; set; }

    }
}