// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Models.Api20210501
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.Extensions;

    /// <summary>Sku properties</summary>
    public partial class VendorSkuPropertiesFormat :
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Models.Api20210501.IVendorSkuPropertiesFormat,
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Models.Api20210501.IVendorSkuPropertiesFormatInternal
    {

        /// <summary>Backing field for <see cref="DeploymentMode" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Support.SkuDeploymentMode? _deploymentMode;

        /// <summary>The sku deployment mode.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Origin(Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Support.SkuDeploymentMode? DeploymentMode { get => this._deploymentMode; set => this._deploymentMode = value; }

        /// <summary>Backing field for <see cref="ManagedApplicationParameter" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Models.Api20210501.IVendorSkuPropertiesFormatManagedApplicationParameters _managedApplicationParameter;

        /// <summary>The parameters for the managed application to be supplied by the vendor.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Origin(Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Models.Api20210501.IVendorSkuPropertiesFormatManagedApplicationParameters ManagedApplicationParameter { get => (this._managedApplicationParameter = this._managedApplicationParameter ?? new Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Models.Api20210501.VendorSkuPropertiesFormatManagedApplicationParameters()); set => this._managedApplicationParameter = value; }

        /// <summary>Backing field for <see cref="ManagedApplicationTemplate" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Models.Api20210501.IVendorSkuPropertiesFormatManagedApplicationTemplate _managedApplicationTemplate;

        /// <summary>The template for the managed application deployment.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Origin(Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Models.Api20210501.IVendorSkuPropertiesFormatManagedApplicationTemplate ManagedApplicationTemplate { get => (this._managedApplicationTemplate = this._managedApplicationTemplate ?? new Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Models.Api20210501.VendorSkuPropertiesFormatManagedApplicationTemplate()); set => this._managedApplicationTemplate = value; }

        /// <summary>Internal Acessors for NetworkFunctionTemplate</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Models.Api20210501.INetworkFunctionTemplate Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Models.Api20210501.IVendorSkuPropertiesFormatInternal.NetworkFunctionTemplate { get => (this._networkFunctionTemplate = this._networkFunctionTemplate ?? new Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Models.Api20210501.NetworkFunctionTemplate()); set { {_networkFunctionTemplate = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Support.ProvisioningState? Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Models.Api20210501.IVendorSkuPropertiesFormatInternal.ProvisioningState { get => this._provisioningState; set { {_provisioningState = value;} } }

        /// <summary>Backing field for <see cref="NetworkFunctionTemplate" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Models.Api20210501.INetworkFunctionTemplate _networkFunctionTemplate;

        /// <summary>The template definition of the network function.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Origin(Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Models.Api20210501.INetworkFunctionTemplate NetworkFunctionTemplate { get => (this._networkFunctionTemplate = this._networkFunctionTemplate ?? new Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Models.Api20210501.NetworkFunctionTemplate()); set => this._networkFunctionTemplate = value; }

        /// <summary>An array of network function role definitions.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Origin(Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Models.Api20210501.INetworkFunctionRoleConfiguration[] NetworkFunctionTemplateNetworkFunctionRoleConfiguration { get => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Models.Api20210501.INetworkFunctionTemplateInternal)NetworkFunctionTemplate).NetworkFunctionRoleConfiguration; set => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Models.Api20210501.INetworkFunctionTemplateInternal)NetworkFunctionTemplate).NetworkFunctionRoleConfiguration = value ?? null /* arrayOf */; }

        /// <summary>Backing field for <see cref="NetworkFunctionType" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Support.NetworkFunctionType? _networkFunctionType;

        /// <summary>The network function type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Origin(Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Support.NetworkFunctionType? NetworkFunctionType { get => this._networkFunctionType; set => this._networkFunctionType = value; }

        /// <summary>Backing field for <see cref="Preview" /> property.</summary>
        private bool? _preview;

        /// <summary>Indicates if the vendor sku is in preview mode.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Origin(Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.PropertyOrigin.Owned)]
        public bool? Preview { get => this._preview; set => this._preview = value; }

        /// <summary>Backing field for <see cref="ProvisioningState" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Support.ProvisioningState? _provisioningState;

        /// <summary>The provisioning state of the vendor sku sub resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Origin(Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Support.ProvisioningState? ProvisioningState { get => this._provisioningState; }

        /// <summary>Backing field for <see cref="SkuType" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Support.SkuType? _skuType;

        /// <summary>The sku type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Origin(Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Support.SkuType? SkuType { get => this._skuType; set => this._skuType = value; }

        /// <summary>Creates an new <see cref="VendorSkuPropertiesFormat" /> instance.</summary>
        public VendorSkuPropertiesFormat()
        {

        }
    }
    /// Sku properties
    public partial interface IVendorSkuPropertiesFormat :
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.IJsonSerializable
    {
        /// <summary>The sku deployment mode.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The sku deployment mode.",
        SerializedName = @"deploymentMode",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Support.SkuDeploymentMode) })]
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Support.SkuDeploymentMode? DeploymentMode { get; set; }
        /// <summary>The parameters for the managed application to be supplied by the vendor.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The parameters for the managed application to be supplied by the vendor.",
        SerializedName = @"managedApplicationParameters",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Models.Api20210501.IVendorSkuPropertiesFormatManagedApplicationParameters) })]
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Models.Api20210501.IVendorSkuPropertiesFormatManagedApplicationParameters ManagedApplicationParameter { get; set; }
        /// <summary>The template for the managed application deployment.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The template for the managed application deployment.",
        SerializedName = @"managedApplicationTemplate",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Models.Api20210501.IVendorSkuPropertiesFormatManagedApplicationTemplate) })]
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Models.Api20210501.IVendorSkuPropertiesFormatManagedApplicationTemplate ManagedApplicationTemplate { get; set; }
        /// <summary>An array of network function role definitions.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"An array of network function role definitions.",
        SerializedName = @"networkFunctionRoleConfigurations",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Models.Api20210501.INetworkFunctionRoleConfiguration) })]
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Models.Api20210501.INetworkFunctionRoleConfiguration[] NetworkFunctionTemplateNetworkFunctionRoleConfiguration { get; set; }
        /// <summary>The network function type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The network function type.",
        SerializedName = @"networkFunctionType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Support.NetworkFunctionType) })]
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Support.NetworkFunctionType? NetworkFunctionType { get; set; }
        /// <summary>Indicates if the vendor sku is in preview mode.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Indicates if the vendor sku is in preview mode.",
        SerializedName = @"preview",
        PossibleTypes = new [] { typeof(bool) })]
        bool? Preview { get; set; }
        /// <summary>The provisioning state of the vendor sku sub resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The provisioning state of the vendor sku sub resource.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Support.ProvisioningState) })]
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Support.ProvisioningState? ProvisioningState { get;  }
        /// <summary>The sku type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The sku type.",
        SerializedName = @"skuType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Support.SkuType) })]
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Support.SkuType? SkuType { get; set; }

    }
    /// Sku properties
    internal partial interface IVendorSkuPropertiesFormatInternal

    {
        /// <summary>The sku deployment mode.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Support.SkuDeploymentMode? DeploymentMode { get; set; }
        /// <summary>The parameters for the managed application to be supplied by the vendor.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Models.Api20210501.IVendorSkuPropertiesFormatManagedApplicationParameters ManagedApplicationParameter { get; set; }
        /// <summary>The template for the managed application deployment.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Models.Api20210501.IVendorSkuPropertiesFormatManagedApplicationTemplate ManagedApplicationTemplate { get; set; }
        /// <summary>The template definition of the network function.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Models.Api20210501.INetworkFunctionTemplate NetworkFunctionTemplate { get; set; }
        /// <summary>An array of network function role definitions.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Models.Api20210501.INetworkFunctionRoleConfiguration[] NetworkFunctionTemplateNetworkFunctionRoleConfiguration { get; set; }
        /// <summary>The network function type.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Support.NetworkFunctionType? NetworkFunctionType { get; set; }
        /// <summary>Indicates if the vendor sku is in preview mode.</summary>
        bool? Preview { get; set; }
        /// <summary>The provisioning state of the vendor sku sub resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Support.ProvisioningState? ProvisioningState { get; set; }
        /// <summary>The sku type.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Support.SkuType? SkuType { get; set; }

    }
}