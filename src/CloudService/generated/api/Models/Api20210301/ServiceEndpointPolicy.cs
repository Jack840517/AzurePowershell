// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301
{
    using static Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Extensions;

    /// <summary>Service End point policy resource.</summary>
    public partial class ServiceEndpointPolicy :
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IServiceEndpointPolicy,
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IServiceEndpointPolicyInternal,
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IResource"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IResource __resource = new Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.Resource();

        /// <summary>A collection of contextual service endpoint policy.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Inlined)]
        public string[] ContextualServiceEndpointPolicy { get => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IServiceEndpointPolicyPropertiesFormatInternal)Property).ContextualServiceEndpointPolicy; set => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IServiceEndpointPolicyPropertiesFormatInternal)Property).ContextualServiceEndpointPolicy = value ?? null /* arrayOf */; }

        /// <summary>
        /// A collection of service endpoint policy definitions of the service endpoint policy.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IServiceEndpointPolicyDefinition[] Definition { get => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IServiceEndpointPolicyPropertiesFormatInternal)Property).ServiceEndpointPolicyDefinition; set => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IServiceEndpointPolicyPropertiesFormatInternal)Property).ServiceEndpointPolicyDefinition = value ?? null /* arrayOf */; }

        /// <summary>Backing field for <see cref="Etag" /> property.</summary>
        private string _etag;

        /// <summary>A unique read-only string that changes whenever the resource is updated.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Owned)]
        public string Etag { get => this._etag; }

        /// <summary>Resource ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IResourceInternal)__resource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IResourceInternal)__resource).Id = value ?? null; }

        /// <summary>Backing field for <see cref="Kind" /> property.</summary>
        private string _kind;

        /// <summary>
        /// Kind of service endpoint policy. This is metadata used for the Azure portal experience.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Owned)]
        public string Kind { get => this._kind; }

        /// <summary>Resource location.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Inherited)]
        public string Location { get => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IResourceInternal)__resource).Location; set => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IResourceInternal)__resource).Location = value ?? null; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IResourceInternal)__resource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IResourceInternal)__resource).Name = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IResourceInternal)__resource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IResourceInternal)__resource).Type = value; }

        /// <summary>Internal Acessors for Etag</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IServiceEndpointPolicyInternal.Etag { get => this._etag; set { {_etag = value;} } }

        /// <summary>Internal Acessors for Kind</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IServiceEndpointPolicyInternal.Kind { get => this._kind; set { {_kind = value;} } }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IServiceEndpointPolicyPropertiesFormat Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IServiceEndpointPolicyInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.ServiceEndpointPolicyPropertiesFormat()); set { {_property = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.ProvisioningState? Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IServiceEndpointPolicyInternal.ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IServiceEndpointPolicyPropertiesFormatInternal)Property).ProvisioningState; set => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IServiceEndpointPolicyPropertiesFormatInternal)Property).ProvisioningState = value; }

        /// <summary>Internal Acessors for ResourceGuid</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IServiceEndpointPolicyInternal.ResourceGuid { get => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IServiceEndpointPolicyPropertiesFormatInternal)Property).ResourceGuid; set => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IServiceEndpointPolicyPropertiesFormatInternal)Property).ResourceGuid = value; }

        /// <summary>Internal Acessors for Subnet</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.ISubnet[] Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IServiceEndpointPolicyInternal.Subnet { get => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IServiceEndpointPolicyPropertiesFormatInternal)Property).Subnet; set => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IServiceEndpointPolicyPropertiesFormatInternal)Property).Subnet = value; }

        /// <summary>Resource name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IResourceInternal)__resource).Name; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IServiceEndpointPolicyPropertiesFormat _property;

        /// <summary>Properties of the service end point policy.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IServiceEndpointPolicyPropertiesFormat Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.ServiceEndpointPolicyPropertiesFormat()); set => this._property = value; }

        /// <summary>The provisioning state of the service endpoint policy resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.ProvisioningState? ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IServiceEndpointPolicyPropertiesFormatInternal)Property).ProvisioningState; }

        /// <summary>The resource GUID property of the service endpoint policy resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Inlined)]
        public string ResourceGuid { get => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IServiceEndpointPolicyPropertiesFormatInternal)Property).ResourceGuid; }

        /// <summary>The alias indicating if the policy belongs to a service</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Inlined)]
        public string ServiceAlias { get => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IServiceEndpointPolicyPropertiesFormatInternal)Property).ServiceAlias; set => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IServiceEndpointPolicyPropertiesFormatInternal)Property).ServiceAlias = value ?? null; }

        /// <summary>A collection of references to subnets.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.ISubnet[] Subnet { get => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IServiceEndpointPolicyPropertiesFormatInternal)Property).Subnet; }

        /// <summary>Resource tags.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IResourceTags Tag { get => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IResourceInternal)__resource).Tag; set => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IResourceInternal)__resource).Tag = value ?? null /* model class */; }

        /// <summary>Resource type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IResourceInternal)__resource).Type; }

        /// <summary>Creates an new <see cref="ServiceEndpointPolicy" /> instance.</summary>
        public ServiceEndpointPolicy()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A < see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__resource), __resource);
            await eventListener.AssertObjectIsValid(nameof(__resource), __resource);
        }
    }
    /// Service End point policy resource.
    public partial interface IServiceEndpointPolicy :
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IResource
    {
        /// <summary>A collection of contextual service endpoint policy.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"A collection of contextual service endpoint policy.",
        SerializedName = @"contextualServiceEndpointPolicies",
        PossibleTypes = new [] { typeof(string) })]
        string[] ContextualServiceEndpointPolicy { get; set; }
        /// <summary>
        /// A collection of service endpoint policy definitions of the service endpoint policy.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"A collection of service endpoint policy definitions of the service endpoint policy.",
        SerializedName = @"serviceEndpointPolicyDefinitions",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IServiceEndpointPolicyDefinition) })]
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IServiceEndpointPolicyDefinition[] Definition { get; set; }
        /// <summary>A unique read-only string that changes whenever the resource is updated.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"A unique read-only string that changes whenever the resource is updated.",
        SerializedName = @"etag",
        PossibleTypes = new [] { typeof(string) })]
        string Etag { get;  }
        /// <summary>
        /// Kind of service endpoint policy. This is metadata used for the Azure portal experience.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Kind of service endpoint policy. This is metadata used for the Azure portal experience.",
        SerializedName = @"kind",
        PossibleTypes = new [] { typeof(string) })]
        string Kind { get;  }
        /// <summary>The provisioning state of the service endpoint policy resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The provisioning state of the service endpoint policy resource.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.ProvisioningState) })]
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.ProvisioningState? ProvisioningState { get;  }
        /// <summary>The resource GUID property of the service endpoint policy resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The resource GUID property of the service endpoint policy resource.",
        SerializedName = @"resourceGuid",
        PossibleTypes = new [] { typeof(string) })]
        string ResourceGuid { get;  }
        /// <summary>The alias indicating if the policy belongs to a service</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The alias indicating if the policy belongs to a service",
        SerializedName = @"serviceAlias",
        PossibleTypes = new [] { typeof(string) })]
        string ServiceAlias { get; set; }
        /// <summary>A collection of references to subnets.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"A collection of references to subnets.",
        SerializedName = @"subnets",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.ISubnet) })]
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.ISubnet[] Subnet { get;  }

    }
    /// Service End point policy resource.
    internal partial interface IServiceEndpointPolicyInternal :
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IResourceInternal
    {
        /// <summary>A collection of contextual service endpoint policy.</summary>
        string[] ContextualServiceEndpointPolicy { get; set; }
        /// <summary>
        /// A collection of service endpoint policy definitions of the service endpoint policy.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IServiceEndpointPolicyDefinition[] Definition { get; set; }
        /// <summary>A unique read-only string that changes whenever the resource is updated.</summary>
        string Etag { get; set; }
        /// <summary>
        /// Kind of service endpoint policy. This is metadata used for the Azure portal experience.
        /// </summary>
        string Kind { get; set; }
        /// <summary>Properties of the service end point policy.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IServiceEndpointPolicyPropertiesFormat Property { get; set; }
        /// <summary>The provisioning state of the service endpoint policy resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.ProvisioningState? ProvisioningState { get; set; }
        /// <summary>The resource GUID property of the service endpoint policy resource.</summary>
        string ResourceGuid { get; set; }
        /// <summary>The alias indicating if the policy belongs to a service</summary>
        string ServiceAlias { get; set; }
        /// <summary>A collection of references to subnets.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.ISubnet[] Subnet { get; set; }

    }
}