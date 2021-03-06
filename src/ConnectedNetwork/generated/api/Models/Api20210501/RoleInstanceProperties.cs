// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Models.Api20210501
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.Extensions;

    /// <summary>The role instance properties of the network function.</summary>
    public partial class RoleInstanceProperties :
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Models.Api20210501.IRoleInstanceProperties,
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Models.Api20210501.IRoleInstancePropertiesInternal
    {

        /// <summary>Internal Acessors for ProvisioningState</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Support.ProvisioningState? Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Models.Api20210501.IRoleInstancePropertiesInternal.ProvisioningState { get => this._provisioningState; set { {_provisioningState = value;} } }

        /// <summary>Backing field for <see cref="OperationalState" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Support.OperationalState? _operationalState;

        /// <summary>The operational state of the role instance.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Origin(Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Support.OperationalState? OperationalState { get => this._operationalState; set => this._operationalState = value; }

        /// <summary>Backing field for <see cref="ProvisioningState" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Support.ProvisioningState? _provisioningState;

        /// <summary>The provisioning state of the RoleInstance resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Origin(Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Support.ProvisioningState? ProvisioningState { get => this._provisioningState; }

        /// <summary>Creates an new <see cref="RoleInstanceProperties" /> instance.</summary>
        public RoleInstanceProperties()
        {

        }
    }
    /// The role instance properties of the network function.
    public partial interface IRoleInstanceProperties :
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.IJsonSerializable
    {
        /// <summary>The operational state of the role instance.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The operational state of the role instance.",
        SerializedName = @"operationalState",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Support.OperationalState) })]
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Support.OperationalState? OperationalState { get; set; }
        /// <summary>The provisioning state of the RoleInstance resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The provisioning state of the RoleInstance resource.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Support.ProvisioningState) })]
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Support.ProvisioningState? ProvisioningState { get;  }

    }
    /// The role instance properties of the network function.
    internal partial interface IRoleInstancePropertiesInternal

    {
        /// <summary>The operational state of the role instance.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Support.OperationalState? OperationalState { get; set; }
        /// <summary>The provisioning state of the RoleInstance resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Support.ProvisioningState? ProvisioningState { get; set; }

    }
}