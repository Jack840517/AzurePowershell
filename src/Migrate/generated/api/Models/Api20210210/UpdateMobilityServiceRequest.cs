// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Extensions;

    /// <summary>Request to update the mobility service on a protected item.</summary>
    public partial class UpdateMobilityServiceRequest :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IUpdateMobilityServiceRequest,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IUpdateMobilityServiceRequestInternal
    {

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IUpdateMobilityServiceRequestProperties Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IUpdateMobilityServiceRequestInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.UpdateMobilityServiceRequestProperties()); set { {_property = value;} } }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IUpdateMobilityServiceRequestProperties _property;

        /// <summary>The properties of the update mobility service request.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IUpdateMobilityServiceRequestProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.UpdateMobilityServiceRequestProperties()); set => this._property = value; }

        /// <summary>The CS run as account Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string RunAsAccountId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IUpdateMobilityServiceRequestPropertiesInternal)Property).RunAsAccountId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IUpdateMobilityServiceRequestPropertiesInternal)Property).RunAsAccountId = value ?? null; }

        /// <summary>Creates an new <see cref="UpdateMobilityServiceRequest" /> instance.</summary>
        public UpdateMobilityServiceRequest()
        {

        }
    }
    /// Request to update the mobility service on a protected item.
    public partial interface IUpdateMobilityServiceRequest :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IJsonSerializable
    {
        /// <summary>The CS run as account Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The CS run as account Id.",
        SerializedName = @"runAsAccountId",
        PossibleTypes = new [] { typeof(string) })]
        string RunAsAccountId { get; set; }

    }
    /// Request to update the mobility service on a protected item.
    internal partial interface IUpdateMobilityServiceRequestInternal

    {
        /// <summary>The properties of the update mobility service request.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IUpdateMobilityServiceRequestProperties Property { get; set; }
        /// <summary>The CS run as account Id.</summary>
        string RunAsAccountId { get; set; }

    }
}