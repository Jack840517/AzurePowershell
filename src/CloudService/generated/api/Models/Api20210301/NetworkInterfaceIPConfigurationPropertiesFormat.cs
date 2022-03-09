// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301
{
    using static Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Extensions;

    /// <summary>Properties of IP configuration.</summary>
    public partial class NetworkInterfaceIPConfigurationPropertiesFormat :
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.INetworkInterfaceIPConfigurationPropertiesFormat,
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.INetworkInterfaceIPConfigurationPropertiesFormatInternal
    {

        /// <summary>Backing field for <see cref="ApplicationGatewayBackendAddressPool" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IApplicationGatewayBackendAddressPool[] _applicationGatewayBackendAddressPool;

        /// <summary>The reference to ApplicationGatewayBackendAddressPool resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IApplicationGatewayBackendAddressPool[] ApplicationGatewayBackendAddressPool { get => this._applicationGatewayBackendAddressPool; set => this._applicationGatewayBackendAddressPool = value; }

        /// <summary>Backing field for <see cref="ApplicationSecurityGroup" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IApplicationSecurityGroup[] _applicationSecurityGroup;

        /// <summary>Application security groups in which the IP configuration is included.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IApplicationSecurityGroup[] ApplicationSecurityGroup { get => this._applicationSecurityGroup; set => this._applicationSecurityGroup = value; }

        /// <summary>Backing field for <see cref="GatewayLoadBalancer" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.ISubResourceAutoGenerated _gatewayLoadBalancer;

        /// <summary>The reference to gateway load balancer frontend IP.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.ISubResourceAutoGenerated GatewayLoadBalancer { get => (this._gatewayLoadBalancer = this._gatewayLoadBalancer ?? new Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.SubResourceAutoGenerated()); set => this._gatewayLoadBalancer = value; }

        /// <summary>Resource ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Inlined)]
        public string GatewayLoadBalancerId { get => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.ISubResourceAutoGeneratedInternal)GatewayLoadBalancer).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.ISubResourceAutoGeneratedInternal)GatewayLoadBalancer).Id = value ?? null; }

        /// <summary>Backing field for <see cref="LoadBalancerBackendAddressPool" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IBackendAddressPool[] _loadBalancerBackendAddressPool;

        /// <summary>The reference to LoadBalancerBackendAddressPool resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IBackendAddressPool[] LoadBalancerBackendAddressPool { get => this._loadBalancerBackendAddressPool; set => this._loadBalancerBackendAddressPool = value; }

        /// <summary>Backing field for <see cref="LoadBalancerInboundNatRule" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IInboundNatRule[] _loadBalancerInboundNatRule;

        /// <summary>A list of references of LoadBalancerInboundNatRules.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IInboundNatRule[] LoadBalancerInboundNatRule { get => this._loadBalancerInboundNatRule; set => this._loadBalancerInboundNatRule = value; }

        /// <summary>Internal Acessors for GatewayLoadBalancer</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.ISubResourceAutoGenerated Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.INetworkInterfaceIPConfigurationPropertiesFormatInternal.GatewayLoadBalancer { get => (this._gatewayLoadBalancer = this._gatewayLoadBalancer ?? new Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.SubResourceAutoGenerated()); set { {_gatewayLoadBalancer = value;} } }

        /// <summary>Internal Acessors for PrivateLinkConnectionProperty</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.INetworkInterfaceIPConfigurationPrivateLinkConnectionProperties Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.INetworkInterfaceIPConfigurationPropertiesFormatInternal.PrivateLinkConnectionProperty { get => (this._privateLinkConnectionProperty = this._privateLinkConnectionProperty ?? new Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.NetworkInterfaceIPConfigurationPrivateLinkConnectionProperties()); set { {_privateLinkConnectionProperty = value;} } }

        /// <summary>Internal Acessors for PrivateLinkConnectionPropertyFqdn</summary>
        string[] Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.INetworkInterfaceIPConfigurationPropertiesFormatInternal.PrivateLinkConnectionPropertyFqdn { get => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.INetworkInterfaceIPConfigurationPrivateLinkConnectionPropertiesInternal)PrivateLinkConnectionProperty).Fqdn; set => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.INetworkInterfaceIPConfigurationPrivateLinkConnectionPropertiesInternal)PrivateLinkConnectionProperty).Fqdn = value; }

        /// <summary>Internal Acessors for PrivateLinkConnectionPropertyGroupId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.INetworkInterfaceIPConfigurationPropertiesFormatInternal.PrivateLinkConnectionPropertyGroupId { get => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.INetworkInterfaceIPConfigurationPrivateLinkConnectionPropertiesInternal)PrivateLinkConnectionProperty).GroupId; set => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.INetworkInterfaceIPConfigurationPrivateLinkConnectionPropertiesInternal)PrivateLinkConnectionProperty).GroupId = value; }

        /// <summary>Internal Acessors for PrivateLinkConnectionPropertyRequiredMemberName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.INetworkInterfaceIPConfigurationPropertiesFormatInternal.PrivateLinkConnectionPropertyRequiredMemberName { get => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.INetworkInterfaceIPConfigurationPrivateLinkConnectionPropertiesInternal)PrivateLinkConnectionProperty).RequiredMemberName; set => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.INetworkInterfaceIPConfigurationPrivateLinkConnectionPropertiesInternal)PrivateLinkConnectionProperty).RequiredMemberName = value; }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.ProvisioningState? Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.INetworkInterfaceIPConfigurationPropertiesFormatInternal.ProvisioningState { get => this._provisioningState; set { {_provisioningState = value;} } }

        /// <summary>Backing field for <see cref="Primary" /> property.</summary>
        private bool? _primary;

        /// <summary>Whether this is a primary customer address on the network interface.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Owned)]
        public bool? Primary { get => this._primary; set => this._primary = value; }

        /// <summary>Backing field for <see cref="PrivateIPAddress" /> property.</summary>
        private string _privateIPAddress;

        /// <summary>Private IP address of the IP configuration.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Owned)]
        public string PrivateIPAddress { get => this._privateIPAddress; set => this._privateIPAddress = value; }

        /// <summary>Backing field for <see cref="PrivateIPAddressVersion" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.IPVersion? _privateIPAddressVersion;

        /// <summary>Whether the specific IP configuration is IPv4 or IPv6. Default is IPv4.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.IPVersion? PrivateIPAddressVersion { get => this._privateIPAddressVersion; set => this._privateIPAddressVersion = value; }

        /// <summary>Backing field for <see cref="PrivateIPAllocationMethod" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.IPAllocationMethod? _privateIPAllocationMethod;

        /// <summary>The private IP address allocation method.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.IPAllocationMethod? PrivateIPAllocationMethod { get => this._privateIPAllocationMethod; set => this._privateIPAllocationMethod = value; }

        /// <summary>Backing field for <see cref="PrivateLinkConnectionProperty" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.INetworkInterfaceIPConfigurationPrivateLinkConnectionProperties _privateLinkConnectionProperty;

        /// <summary>PrivateLinkConnection properties for the network interface.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.INetworkInterfaceIPConfigurationPrivateLinkConnectionProperties PrivateLinkConnectionProperty { get => (this._privateLinkConnectionProperty = this._privateLinkConnectionProperty ?? new Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.NetworkInterfaceIPConfigurationPrivateLinkConnectionProperties()); }

        /// <summary>List of FQDNs for current private link connection.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Inlined)]
        public string[] PrivateLinkConnectionPropertyFqdn { get => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.INetworkInterfaceIPConfigurationPrivateLinkConnectionPropertiesInternal)PrivateLinkConnectionProperty).Fqdn; }

        /// <summary>The group ID for current private link connection.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Inlined)]
        public string PrivateLinkConnectionPropertyGroupId { get => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.INetworkInterfaceIPConfigurationPrivateLinkConnectionPropertiesInternal)PrivateLinkConnectionProperty).GroupId; }

        /// <summary>The required member name for current private link connection.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Inlined)]
        public string PrivateLinkConnectionPropertyRequiredMemberName { get => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.INetworkInterfaceIPConfigurationPrivateLinkConnectionPropertiesInternal)PrivateLinkConnectionProperty).RequiredMemberName; }

        /// <summary>Backing field for <see cref="ProvisioningState" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.ProvisioningState? _provisioningState;

        /// <summary>The provisioning state of the network interface IP configuration.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.ProvisioningState? ProvisioningState { get => this._provisioningState; }

        /// <summary>Backing field for <see cref="PublicIPAddress" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IPublicIPAddress _publicIPAddress;

        /// <summary>Public IP address bound to the IP configuration.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IPublicIPAddress PublicIPAddress { get => (this._publicIPAddress = this._publicIPAddress ?? new Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.PublicIPAddress()); set => this._publicIPAddress = value; }

        /// <summary>Backing field for <see cref="Subnet" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.ISubnet _subnet;

        /// <summary>Subnet bound to the IP configuration.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.ISubnet Subnet { get => (this._subnet = this._subnet ?? new Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.Subnet()); set => this._subnet = value; }

        /// <summary>Backing field for <see cref="VirtualNetworkTap" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IVirtualNetworkTap[] _virtualNetworkTap;

        /// <summary>The reference to Virtual Network Taps.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IVirtualNetworkTap[] VirtualNetworkTap { get => this._virtualNetworkTap; set => this._virtualNetworkTap = value; }

        /// <summary>
        /// Creates an new <see cref="NetworkInterfaceIPConfigurationPropertiesFormat" /> instance.
        /// </summary>
        public NetworkInterfaceIPConfigurationPropertiesFormat()
        {

        }
    }
    /// Properties of IP configuration.
    public partial interface INetworkInterfaceIPConfigurationPropertiesFormat :
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.IJsonSerializable
    {
        /// <summary>The reference to ApplicationGatewayBackendAddressPool resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The reference to ApplicationGatewayBackendAddressPool resource.",
        SerializedName = @"applicationGatewayBackendAddressPools",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IApplicationGatewayBackendAddressPool) })]
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IApplicationGatewayBackendAddressPool[] ApplicationGatewayBackendAddressPool { get; set; }
        /// <summary>Application security groups in which the IP configuration is included.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Application security groups in which the IP configuration is included.",
        SerializedName = @"applicationSecurityGroups",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IApplicationSecurityGroup) })]
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IApplicationSecurityGroup[] ApplicationSecurityGroup { get; set; }
        /// <summary>Resource ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Resource ID.",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string GatewayLoadBalancerId { get; set; }
        /// <summary>The reference to LoadBalancerBackendAddressPool resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The reference to LoadBalancerBackendAddressPool resource.",
        SerializedName = @"loadBalancerBackendAddressPools",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IBackendAddressPool) })]
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IBackendAddressPool[] LoadBalancerBackendAddressPool { get; set; }
        /// <summary>A list of references of LoadBalancerInboundNatRules.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"A list of references of LoadBalancerInboundNatRules.",
        SerializedName = @"loadBalancerInboundNatRules",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IInboundNatRule) })]
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IInboundNatRule[] LoadBalancerInboundNatRule { get; set; }
        /// <summary>Whether this is a primary customer address on the network interface.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Whether this is a primary customer address on the network interface.",
        SerializedName = @"primary",
        PossibleTypes = new [] { typeof(bool) })]
        bool? Primary { get; set; }
        /// <summary>Private IP address of the IP configuration.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Private IP address of the IP configuration.",
        SerializedName = @"privateIPAddress",
        PossibleTypes = new [] { typeof(string) })]
        string PrivateIPAddress { get; set; }
        /// <summary>Whether the specific IP configuration is IPv4 or IPv6. Default is IPv4.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Whether the specific IP configuration is IPv4 or IPv6. Default is IPv4.",
        SerializedName = @"privateIPAddressVersion",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.IPVersion) })]
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.IPVersion? PrivateIPAddressVersion { get; set; }
        /// <summary>The private IP address allocation method.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The private IP address allocation method.",
        SerializedName = @"privateIPAllocationMethod",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.IPAllocationMethod) })]
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.IPAllocationMethod? PrivateIPAllocationMethod { get; set; }
        /// <summary>List of FQDNs for current private link connection.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"List of FQDNs for current private link connection.",
        SerializedName = @"fqdns",
        PossibleTypes = new [] { typeof(string) })]
        string[] PrivateLinkConnectionPropertyFqdn { get;  }
        /// <summary>The group ID for current private link connection.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The group ID for current private link connection.",
        SerializedName = @"groupId",
        PossibleTypes = new [] { typeof(string) })]
        string PrivateLinkConnectionPropertyGroupId { get;  }
        /// <summary>The required member name for current private link connection.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The required member name for current private link connection.",
        SerializedName = @"requiredMemberName",
        PossibleTypes = new [] { typeof(string) })]
        string PrivateLinkConnectionPropertyRequiredMemberName { get;  }
        /// <summary>The provisioning state of the network interface IP configuration.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The provisioning state of the network interface IP configuration.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.ProvisioningState) })]
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.ProvisioningState? ProvisioningState { get;  }
        /// <summary>Public IP address bound to the IP configuration.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Public IP address bound to the IP configuration.",
        SerializedName = @"publicIPAddress",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IPublicIPAddress) })]
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IPublicIPAddress PublicIPAddress { get; set; }
        /// <summary>Subnet bound to the IP configuration.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Subnet bound to the IP configuration.",
        SerializedName = @"subnet",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.ISubnet) })]
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.ISubnet Subnet { get; set; }
        /// <summary>The reference to Virtual Network Taps.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The reference to Virtual Network Taps.",
        SerializedName = @"virtualNetworkTaps",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IVirtualNetworkTap) })]
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IVirtualNetworkTap[] VirtualNetworkTap { get; set; }

    }
    /// Properties of IP configuration.
    internal partial interface INetworkInterfaceIPConfigurationPropertiesFormatInternal

    {
        /// <summary>The reference to ApplicationGatewayBackendAddressPool resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IApplicationGatewayBackendAddressPool[] ApplicationGatewayBackendAddressPool { get; set; }
        /// <summary>Application security groups in which the IP configuration is included.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IApplicationSecurityGroup[] ApplicationSecurityGroup { get; set; }
        /// <summary>The reference to gateway load balancer frontend IP.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.ISubResourceAutoGenerated GatewayLoadBalancer { get; set; }
        /// <summary>Resource ID.</summary>
        string GatewayLoadBalancerId { get; set; }
        /// <summary>The reference to LoadBalancerBackendAddressPool resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IBackendAddressPool[] LoadBalancerBackendAddressPool { get; set; }
        /// <summary>A list of references of LoadBalancerInboundNatRules.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IInboundNatRule[] LoadBalancerInboundNatRule { get; set; }
        /// <summary>Whether this is a primary customer address on the network interface.</summary>
        bool? Primary { get; set; }
        /// <summary>Private IP address of the IP configuration.</summary>
        string PrivateIPAddress { get; set; }
        /// <summary>Whether the specific IP configuration is IPv4 or IPv6. Default is IPv4.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.IPVersion? PrivateIPAddressVersion { get; set; }
        /// <summary>The private IP address allocation method.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.IPAllocationMethod? PrivateIPAllocationMethod { get; set; }
        /// <summary>PrivateLinkConnection properties for the network interface.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.INetworkInterfaceIPConfigurationPrivateLinkConnectionProperties PrivateLinkConnectionProperty { get; set; }
        /// <summary>List of FQDNs for current private link connection.</summary>
        string[] PrivateLinkConnectionPropertyFqdn { get; set; }
        /// <summary>The group ID for current private link connection.</summary>
        string PrivateLinkConnectionPropertyGroupId { get; set; }
        /// <summary>The required member name for current private link connection.</summary>
        string PrivateLinkConnectionPropertyRequiredMemberName { get; set; }
        /// <summary>The provisioning state of the network interface IP configuration.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.ProvisioningState? ProvisioningState { get; set; }
        /// <summary>Public IP address bound to the IP configuration.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IPublicIPAddress PublicIPAddress { get; set; }
        /// <summary>Subnet bound to the IP configuration.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.ISubnet Subnet { get; set; }
        /// <summary>The reference to Virtual Network Taps.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IVirtualNetworkTap[] VirtualNetworkTap { get; set; }

    }
}