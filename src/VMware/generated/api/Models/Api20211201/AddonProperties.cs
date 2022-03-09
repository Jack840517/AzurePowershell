// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201
{
    using static Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.Extensions;

    /// <summary>The properties of an addon</summary>
    public partial class AddonProperties :
        Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.IAddonProperties,
        Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.IAddonPropertiesInternal
    {

        /// <summary>Backing field for <see cref="AddonType" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.AddonType _addonType;

        /// <summary>The type of private cloud addon</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMware.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.AddonType AddonType { get => this._addonType; set => this._addonType = value; }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.AddonProvisioningState? Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.IAddonPropertiesInternal.ProvisioningState { get => this._provisioningState; set { {_provisioningState = value;} } }

        /// <summary>Backing field for <see cref="ProvisioningState" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.AddonProvisioningState? _provisioningState;

        /// <summary>The state of the addon provisioning</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMware.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.AddonProvisioningState? ProvisioningState { get => this._provisioningState; }

        /// <summary>Creates an new <see cref="AddonProperties" /> instance.</summary>
        public AddonProperties()
        {

        }
    }
    /// The properties of an addon
    public partial interface IAddonProperties :
        Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.IJsonSerializable
    {
        /// <summary>The type of private cloud addon</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The type of private cloud addon",
        SerializedName = @"addonType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.AddonType) })]
        Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.AddonType AddonType { get; set; }
        /// <summary>The state of the addon provisioning</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The state of the addon provisioning",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.AddonProvisioningState) })]
        Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.AddonProvisioningState? ProvisioningState { get;  }

    }
    /// The properties of an addon
    internal partial interface IAddonPropertiesInternal

    {
        /// <summary>The type of private cloud addon</summary>
        Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.AddonType AddonType { get; set; }
        /// <summary>The state of the addon provisioning</summary>
        Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.AddonProvisioningState? ProvisioningState { get; set; }

    }
}