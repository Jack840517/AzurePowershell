// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301
{
    using static Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Extensions;

    /// <summary>Application security group properties.</summary>
    public partial class ApplicationSecurityGroupPropertiesFormat :
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IApplicationSecurityGroupPropertiesFormat,
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IApplicationSecurityGroupPropertiesFormatInternal
    {

        /// <summary>Internal Acessors for ProvisioningState</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.ProvisioningState? Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IApplicationSecurityGroupPropertiesFormatInternal.ProvisioningState { get => this._provisioningState; set { {_provisioningState = value;} } }

        /// <summary>Internal Acessors for ResourceGuid</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IApplicationSecurityGroupPropertiesFormatInternal.ResourceGuid { get => this._resourceGuid; set { {_resourceGuid = value;} } }

        /// <summary>Backing field for <see cref="ProvisioningState" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.ProvisioningState? _provisioningState;

        /// <summary>The provisioning state of the application security group resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.ProvisioningState? ProvisioningState { get => this._provisioningState; }

        /// <summary>Backing field for <see cref="ResourceGuid" /> property.</summary>
        private string _resourceGuid;

        /// <summary>
        /// The resource GUID property of the application security group resource. It uniquely identifies a resource, even if the
        /// user changes its name or migrate the resource across subscriptions or resource groups.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Owned)]
        public string ResourceGuid { get => this._resourceGuid; }

        /// <summary>
        /// Creates an new <see cref="ApplicationSecurityGroupPropertiesFormat" /> instance.
        /// </summary>
        public ApplicationSecurityGroupPropertiesFormat()
        {

        }
    }
    /// Application security group properties.
    public partial interface IApplicationSecurityGroupPropertiesFormat :
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.IJsonSerializable
    {
        /// <summary>The provisioning state of the application security group resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The provisioning state of the application security group resource.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.ProvisioningState) })]
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.ProvisioningState? ProvisioningState { get;  }
        /// <summary>
        /// The resource GUID property of the application security group resource. It uniquely identifies a resource, even if the
        /// user changes its name or migrate the resource across subscriptions or resource groups.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The resource GUID property of the application security group resource. It uniquely identifies a resource, even if the user changes its name or migrate the resource across subscriptions or resource groups.",
        SerializedName = @"resourceGuid",
        PossibleTypes = new [] { typeof(string) })]
        string ResourceGuid { get;  }

    }
    /// Application security group properties.
    internal partial interface IApplicationSecurityGroupPropertiesFormatInternal

    {
        /// <summary>The provisioning state of the application security group resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.ProvisioningState? ProvisioningState { get; set; }
        /// <summary>
        /// The resource GUID property of the application security group resource. It uniquely identifies a resource, even if the
        /// user changes its name or migrate the resource across subscriptions or resource groups.
        /// </summary>
        string ResourceGuid { get; set; }

    }
}