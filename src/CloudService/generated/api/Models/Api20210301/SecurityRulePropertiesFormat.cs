// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301
{
    using static Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Extensions;

    /// <summary>Security rule resource.</summary>
    public partial class SecurityRulePropertiesFormat :
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.ISecurityRulePropertiesFormat,
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.ISecurityRulePropertiesFormatInternal
    {

        /// <summary>Backing field for <see cref="Access" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.SecurityRuleAccess _access;

        /// <summary>The network traffic is allowed or denied.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.SecurityRuleAccess Access { get => this._access; set => this._access = value; }

        /// <summary>Backing field for <see cref="Description" /> property.</summary>
        private string _description;

        /// <summary>A description for this rule. Restricted to 140 chars.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Owned)]
        public string Description { get => this._description; set => this._description = value; }

        /// <summary>Backing field for <see cref="DestinationAddressPrefix" /> property.</summary>
        private string _destinationAddressPrefix;

        /// <summary>
        /// The destination address prefix. CIDR or destination IP range. Asterisk '*' can also be used to match all source IPs. Default
        /// tags such as 'VirtualNetwork', 'AzureLoadBalancer' and 'Internet' can also be used.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Owned)]
        public string DestinationAddressPrefix { get => this._destinationAddressPrefix; set => this._destinationAddressPrefix = value; }

        /// <summary>Backing field for <see cref="DestinationAddressPrefixes" /> property.</summary>
        private string[] _destinationAddressPrefixes;

        /// <summary>The destination address prefixes. CIDR or destination IP ranges.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Owned)]
        public string[] DestinationAddressPrefixes { get => this._destinationAddressPrefixes; set => this._destinationAddressPrefixes = value; }

        /// <summary>Backing field for <see cref="DestinationApplicationSecurityGroup" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IApplicationSecurityGroup[] _destinationApplicationSecurityGroup;

        /// <summary>The application security group specified as destination.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IApplicationSecurityGroup[] DestinationApplicationSecurityGroup { get => this._destinationApplicationSecurityGroup; set => this._destinationApplicationSecurityGroup = value; }

        /// <summary>Backing field for <see cref="DestinationPortRange" /> property.</summary>
        private string _destinationPortRange;

        /// <summary>
        /// The destination port or range. Integer or range between 0 and 65535. Asterisk '*' can also be used to match all ports.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Owned)]
        public string DestinationPortRange { get => this._destinationPortRange; set => this._destinationPortRange = value; }

        /// <summary>Backing field for <see cref="DestinationPortRanges" /> property.</summary>
        private string[] _destinationPortRanges;

        /// <summary>The destination port ranges.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Owned)]
        public string[] DestinationPortRanges { get => this._destinationPortRanges; set => this._destinationPortRanges = value; }

        /// <summary>Backing field for <see cref="Direction" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.SecurityRuleDirection _direction;

        /// <summary>
        /// The direction of the rule. The direction specifies if rule will be evaluated on incoming or outgoing traffic.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.SecurityRuleDirection Direction { get => this._direction; set => this._direction = value; }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.ProvisioningState? Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.ISecurityRulePropertiesFormatInternal.ProvisioningState { get => this._provisioningState; set { {_provisioningState = value;} } }

        /// <summary>Backing field for <see cref="Priority" /> property.</summary>
        private int? _priority;

        /// <summary>
        /// The priority of the rule. The value can be between 100 and 4096. The priority number must be unique for each rule in the
        /// collection. The lower the priority number, the higher the priority of the rule.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Owned)]
        public int? Priority { get => this._priority; set => this._priority = value; }

        /// <summary>Backing field for <see cref="Protocol" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.SecurityRuleProtocol _protocol;

        /// <summary>Network protocol this rule applies to.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.SecurityRuleProtocol Protocol { get => this._protocol; set => this._protocol = value; }

        /// <summary>Backing field for <see cref="ProvisioningState" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.ProvisioningState? _provisioningState;

        /// <summary>The provisioning state of the security rule resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.ProvisioningState? ProvisioningState { get => this._provisioningState; }

        /// <summary>Backing field for <see cref="SourceAddressPrefix" /> property.</summary>
        private string _sourceAddressPrefix;

        /// <summary>
        /// The CIDR or source IP range. Asterisk '*' can also be used to match all source IPs. Default tags such as 'VirtualNetwork',
        /// 'AzureLoadBalancer' and 'Internet' can also be used. If this is an ingress rule, specifies where network traffic originates
        /// from.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Owned)]
        public string SourceAddressPrefix { get => this._sourceAddressPrefix; set => this._sourceAddressPrefix = value; }

        /// <summary>Backing field for <see cref="SourceAddressPrefixes" /> property.</summary>
        private string[] _sourceAddressPrefixes;

        /// <summary>The CIDR or source IP ranges.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Owned)]
        public string[] SourceAddressPrefixes { get => this._sourceAddressPrefixes; set => this._sourceAddressPrefixes = value; }

        /// <summary>Backing field for <see cref="SourceApplicationSecurityGroup" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IApplicationSecurityGroup[] _sourceApplicationSecurityGroup;

        /// <summary>The application security group specified as source.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IApplicationSecurityGroup[] SourceApplicationSecurityGroup { get => this._sourceApplicationSecurityGroup; set => this._sourceApplicationSecurityGroup = value; }

        /// <summary>Backing field for <see cref="SourcePortRange" /> property.</summary>
        private string _sourcePortRange;

        /// <summary>
        /// The source port or range. Integer or range between 0 and 65535. Asterisk '*' can also be used to match all ports.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Owned)]
        public string SourcePortRange { get => this._sourcePortRange; set => this._sourcePortRange = value; }

        /// <summary>Backing field for <see cref="SourcePortRanges" /> property.</summary>
        private string[] _sourcePortRanges;

        /// <summary>The source port ranges.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Owned)]
        public string[] SourcePortRanges { get => this._sourcePortRanges; set => this._sourcePortRanges = value; }

        /// <summary>Creates an new <see cref="SecurityRulePropertiesFormat" /> instance.</summary>
        public SecurityRulePropertiesFormat()
        {

        }
    }
    /// Security rule resource.
    public partial interface ISecurityRulePropertiesFormat :
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.IJsonSerializable
    {
        /// <summary>The network traffic is allowed or denied.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The network traffic is allowed or denied.",
        SerializedName = @"access",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.SecurityRuleAccess) })]
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.SecurityRuleAccess Access { get; set; }
        /// <summary>A description for this rule. Restricted to 140 chars.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"A description for this rule. Restricted to 140 chars.",
        SerializedName = @"description",
        PossibleTypes = new [] { typeof(string) })]
        string Description { get; set; }
        /// <summary>
        /// The destination address prefix. CIDR or destination IP range. Asterisk '*' can also be used to match all source IPs. Default
        /// tags such as 'VirtualNetwork', 'AzureLoadBalancer' and 'Internet' can also be used.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The destination address prefix. CIDR or destination IP range. Asterisk '*' can also be used to match all source IPs. Default tags such as 'VirtualNetwork', 'AzureLoadBalancer' and 'Internet' can also be used.",
        SerializedName = @"destinationAddressPrefix",
        PossibleTypes = new [] { typeof(string) })]
        string DestinationAddressPrefix { get; set; }
        /// <summary>The destination address prefixes. CIDR or destination IP ranges.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The destination address prefixes. CIDR or destination IP ranges.",
        SerializedName = @"destinationAddressPrefixes",
        PossibleTypes = new [] { typeof(string) })]
        string[] DestinationAddressPrefixes { get; set; }
        /// <summary>The application security group specified as destination.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The application security group specified as destination.",
        SerializedName = @"destinationApplicationSecurityGroups",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IApplicationSecurityGroup) })]
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IApplicationSecurityGroup[] DestinationApplicationSecurityGroup { get; set; }
        /// <summary>
        /// The destination port or range. Integer or range between 0 and 65535. Asterisk '*' can also be used to match all ports.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The destination port or range. Integer or range between 0 and 65535. Asterisk '*' can also be used to match all ports.",
        SerializedName = @"destinationPortRange",
        PossibleTypes = new [] { typeof(string) })]
        string DestinationPortRange { get; set; }
        /// <summary>The destination port ranges.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The destination port ranges.",
        SerializedName = @"destinationPortRanges",
        PossibleTypes = new [] { typeof(string) })]
        string[] DestinationPortRanges { get; set; }
        /// <summary>
        /// The direction of the rule. The direction specifies if rule will be evaluated on incoming or outgoing traffic.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The direction of the rule. The direction specifies if rule will be evaluated on incoming or outgoing traffic.",
        SerializedName = @"direction",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.SecurityRuleDirection) })]
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.SecurityRuleDirection Direction { get; set; }
        /// <summary>
        /// The priority of the rule. The value can be between 100 and 4096. The priority number must be unique for each rule in the
        /// collection. The lower the priority number, the higher the priority of the rule.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The priority of the rule. The value can be between 100 and 4096. The priority number must be unique for each rule in the collection. The lower the priority number, the higher the priority of the rule.",
        SerializedName = @"priority",
        PossibleTypes = new [] { typeof(int) })]
        int? Priority { get; set; }
        /// <summary>Network protocol this rule applies to.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Network protocol this rule applies to.",
        SerializedName = @"protocol",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.SecurityRuleProtocol) })]
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.SecurityRuleProtocol Protocol { get; set; }
        /// <summary>The provisioning state of the security rule resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The provisioning state of the security rule resource.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.ProvisioningState) })]
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.ProvisioningState? ProvisioningState { get;  }
        /// <summary>
        /// The CIDR or source IP range. Asterisk '*' can also be used to match all source IPs. Default tags such as 'VirtualNetwork',
        /// 'AzureLoadBalancer' and 'Internet' can also be used. If this is an ingress rule, specifies where network traffic originates
        /// from.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The CIDR or source IP range. Asterisk '*' can also be used to match all source IPs. Default tags such as 'VirtualNetwork', 'AzureLoadBalancer' and 'Internet' can also be used. If this is an ingress rule, specifies where network traffic originates from.",
        SerializedName = @"sourceAddressPrefix",
        PossibleTypes = new [] { typeof(string) })]
        string SourceAddressPrefix { get; set; }
        /// <summary>The CIDR or source IP ranges.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The CIDR or source IP ranges.",
        SerializedName = @"sourceAddressPrefixes",
        PossibleTypes = new [] { typeof(string) })]
        string[] SourceAddressPrefixes { get; set; }
        /// <summary>The application security group specified as source.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The application security group specified as source.",
        SerializedName = @"sourceApplicationSecurityGroups",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IApplicationSecurityGroup) })]
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IApplicationSecurityGroup[] SourceApplicationSecurityGroup { get; set; }
        /// <summary>
        /// The source port or range. Integer or range between 0 and 65535. Asterisk '*' can also be used to match all ports.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The source port or range. Integer or range between 0 and 65535. Asterisk '*' can also be used to match all ports.",
        SerializedName = @"sourcePortRange",
        PossibleTypes = new [] { typeof(string) })]
        string SourcePortRange { get; set; }
        /// <summary>The source port ranges.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The source port ranges.",
        SerializedName = @"sourcePortRanges",
        PossibleTypes = new [] { typeof(string) })]
        string[] SourcePortRanges { get; set; }

    }
    /// Security rule resource.
    internal partial interface ISecurityRulePropertiesFormatInternal

    {
        /// <summary>The network traffic is allowed or denied.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.SecurityRuleAccess Access { get; set; }
        /// <summary>A description for this rule. Restricted to 140 chars.</summary>
        string Description { get; set; }
        /// <summary>
        /// The destination address prefix. CIDR or destination IP range. Asterisk '*' can also be used to match all source IPs. Default
        /// tags such as 'VirtualNetwork', 'AzureLoadBalancer' and 'Internet' can also be used.
        /// </summary>
        string DestinationAddressPrefix { get; set; }
        /// <summary>The destination address prefixes. CIDR or destination IP ranges.</summary>
        string[] DestinationAddressPrefixes { get; set; }
        /// <summary>The application security group specified as destination.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IApplicationSecurityGroup[] DestinationApplicationSecurityGroup { get; set; }
        /// <summary>
        /// The destination port or range. Integer or range between 0 and 65535. Asterisk '*' can also be used to match all ports.
        /// </summary>
        string DestinationPortRange { get; set; }
        /// <summary>The destination port ranges.</summary>
        string[] DestinationPortRanges { get; set; }
        /// <summary>
        /// The direction of the rule. The direction specifies if rule will be evaluated on incoming or outgoing traffic.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.SecurityRuleDirection Direction { get; set; }
        /// <summary>
        /// The priority of the rule. The value can be between 100 and 4096. The priority number must be unique for each rule in the
        /// collection. The lower the priority number, the higher the priority of the rule.
        /// </summary>
        int? Priority { get; set; }
        /// <summary>Network protocol this rule applies to.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.SecurityRuleProtocol Protocol { get; set; }
        /// <summary>The provisioning state of the security rule resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.ProvisioningState? ProvisioningState { get; set; }
        /// <summary>
        /// The CIDR or source IP range. Asterisk '*' can also be used to match all source IPs. Default tags such as 'VirtualNetwork',
        /// 'AzureLoadBalancer' and 'Internet' can also be used. If this is an ingress rule, specifies where network traffic originates
        /// from.
        /// </summary>
        string SourceAddressPrefix { get; set; }
        /// <summary>The CIDR or source IP ranges.</summary>
        string[] SourceAddressPrefixes { get; set; }
        /// <summary>The application security group specified as source.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IApplicationSecurityGroup[] SourceApplicationSecurityGroup { get; set; }
        /// <summary>
        /// The source port or range. Integer or range between 0 and 65535. Asterisk '*' can also be used to match all ports.
        /// </summary>
        string SourcePortRange { get; set; }
        /// <summary>The source port ranges.</summary>
        string[] SourcePortRanges { get; set; }

    }
}