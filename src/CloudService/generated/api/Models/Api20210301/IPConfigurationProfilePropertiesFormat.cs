// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301
{
    using static Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Extensions;

    /// <summary>IP configuration profile properties.</summary>
    public partial class IPConfigurationProfilePropertiesFormat :
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IIPConfigurationProfilePropertiesFormat,
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IIPConfigurationProfilePropertiesFormatInternal
    {

        /// <summary>Internal Acessors for ProvisioningState</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.ProvisioningState? Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IIPConfigurationProfilePropertiesFormatInternal.ProvisioningState { get => this._provisioningState; set { {_provisioningState = value;} } }

        /// <summary>Backing field for <see cref="ProvisioningState" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.ProvisioningState? _provisioningState;

        /// <summary>The provisioning state of the IP configuration profile resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.ProvisioningState? ProvisioningState { get => this._provisioningState; }

        /// <summary>Backing field for <see cref="Subnet" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.ISubnet _subnet;

        /// <summary>
        /// The reference to the subnet resource to create a container network interface ip configuration.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.ISubnet Subnet { get => (this._subnet = this._subnet ?? new Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.Subnet()); set => this._subnet = value; }

        /// <summary>Creates an new <see cref="IPConfigurationProfilePropertiesFormat" /> instance.</summary>
        public IPConfigurationProfilePropertiesFormat()
        {

        }
    }
    /// IP configuration profile properties.
    public partial interface IIPConfigurationProfilePropertiesFormat :
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.IJsonSerializable
    {
        /// <summary>The provisioning state of the IP configuration profile resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The provisioning state of the IP configuration profile resource.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.ProvisioningState) })]
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.ProvisioningState? ProvisioningState { get;  }
        /// <summary>
        /// The reference to the subnet resource to create a container network interface ip configuration.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The reference to the subnet resource to create a container network interface ip configuration.",
        SerializedName = @"subnet",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.ISubnet) })]
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.ISubnet Subnet { get; set; }

    }
    /// IP configuration profile properties.
    internal partial interface IIPConfigurationProfilePropertiesFormatInternal

    {
        /// <summary>The provisioning state of the IP configuration profile resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.ProvisioningState? ProvisioningState { get; set; }
        /// <summary>
        /// The reference to the subnet resource to create a container network interface ip configuration.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.ISubnet Subnet { get; set; }

    }
}