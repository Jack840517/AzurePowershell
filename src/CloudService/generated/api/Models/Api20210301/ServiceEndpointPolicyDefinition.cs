// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301
{
    using static Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Extensions;

    /// <summary>Service Endpoint policy definitions.</summary>
    public partial class ServiceEndpointPolicyDefinition :
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IServiceEndpointPolicyDefinition,
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IServiceEndpointPolicyDefinitionInternal,
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.ISubResourceAutoGenerated"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.ISubResourceAutoGenerated __subResourceAutoGenerated = new Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.SubResourceAutoGenerated();

        /// <summary>A description for this rule. Restricted to 140 chars.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Inlined)]
        public string Description { get => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IServiceEndpointPolicyDefinitionPropertiesFormatInternal)Property).Description; set => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IServiceEndpointPolicyDefinitionPropertiesFormatInternal)Property).Description = value ?? null; }

        /// <summary>Backing field for <see cref="Etag" /> property.</summary>
        private string _etag;

        /// <summary>A unique read-only string that changes whenever the resource is updated.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Owned)]
        public string Etag { get => this._etag; }

        /// <summary>Resource ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.ISubResourceAutoGeneratedInternal)__subResourceAutoGenerated).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.ISubResourceAutoGeneratedInternal)__subResourceAutoGenerated).Id = value ?? null; }

        /// <summary>Internal Acessors for Etag</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IServiceEndpointPolicyDefinitionInternal.Etag { get => this._etag; set { {_etag = value;} } }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IServiceEndpointPolicyDefinitionPropertiesFormat Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IServiceEndpointPolicyDefinitionInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.ServiceEndpointPolicyDefinitionPropertiesFormat()); set { {_property = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.ProvisioningState? Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IServiceEndpointPolicyDefinitionInternal.ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IServiceEndpointPolicyDefinitionPropertiesFormatInternal)Property).ProvisioningState; set => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IServiceEndpointPolicyDefinitionPropertiesFormatInternal)Property).ProvisioningState = value; }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>
        /// The name of the resource that is unique within a resource group. This name can be used to access the resource.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IServiceEndpointPolicyDefinitionPropertiesFormat _property;

        /// <summary>Properties of the service endpoint policy definition.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IServiceEndpointPolicyDefinitionPropertiesFormat Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.ServiceEndpointPolicyDefinitionPropertiesFormat()); set => this._property = value; }

        /// <summary>The provisioning state of the service endpoint policy definition resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.ProvisioningState? ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IServiceEndpointPolicyDefinitionPropertiesFormatInternal)Property).ProvisioningState; }

        /// <summary>Service endpoint name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Inlined)]
        public string Service { get => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IServiceEndpointPolicyDefinitionPropertiesFormatInternal)Property).Service; set => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IServiceEndpointPolicyDefinitionPropertiesFormatInternal)Property).Service = value ?? null; }

        /// <summary>A list of service resources.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Inlined)]
        public string[] ServiceResource { get => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IServiceEndpointPolicyDefinitionPropertiesFormatInternal)Property).ServiceResource; set => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IServiceEndpointPolicyDefinitionPropertiesFormatInternal)Property).ServiceResource = value ?? null /* arrayOf */; }

        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private string _type;

        /// <summary>The type of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Owned)]
        public string Type { get => this._type; set => this._type = value; }

        /// <summary>Creates an new <see cref="ServiceEndpointPolicyDefinition" /> instance.</summary>
        public ServiceEndpointPolicyDefinition()
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
            await eventListener.AssertNotNull(nameof(__subResourceAutoGenerated), __subResourceAutoGenerated);
            await eventListener.AssertObjectIsValid(nameof(__subResourceAutoGenerated), __subResourceAutoGenerated);
        }
    }
    /// Service Endpoint policy definitions.
    public partial interface IServiceEndpointPolicyDefinition :
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.ISubResourceAutoGenerated
    {
        /// <summary>A description for this rule. Restricted to 140 chars.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"A description for this rule. Restricted to 140 chars.",
        SerializedName = @"description",
        PossibleTypes = new [] { typeof(string) })]
        string Description { get; set; }
        /// <summary>A unique read-only string that changes whenever the resource is updated.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"A unique read-only string that changes whenever the resource is updated.",
        SerializedName = @"etag",
        PossibleTypes = new [] { typeof(string) })]
        string Etag { get;  }
        /// <summary>
        /// The name of the resource that is unique within a resource group. This name can be used to access the resource.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The name of the resource that is unique within a resource group. This name can be used to access the resource.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }
        /// <summary>The provisioning state of the service endpoint policy definition resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The provisioning state of the service endpoint policy definition resource.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.ProvisioningState) })]
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.ProvisioningState? ProvisioningState { get;  }
        /// <summary>Service endpoint name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Service endpoint name.",
        SerializedName = @"service",
        PossibleTypes = new [] { typeof(string) })]
        string Service { get; set; }
        /// <summary>A list of service resources.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"A list of service resources.",
        SerializedName = @"serviceResources",
        PossibleTypes = new [] { typeof(string) })]
        string[] ServiceResource { get; set; }
        /// <summary>The type of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The type of the resource.",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        string Type { get; set; }

    }
    /// Service Endpoint policy definitions.
    internal partial interface IServiceEndpointPolicyDefinitionInternal :
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.ISubResourceAutoGeneratedInternal
    {
        /// <summary>A description for this rule. Restricted to 140 chars.</summary>
        string Description { get; set; }
        /// <summary>A unique read-only string that changes whenever the resource is updated.</summary>
        string Etag { get; set; }
        /// <summary>
        /// The name of the resource that is unique within a resource group. This name can be used to access the resource.
        /// </summary>
        string Name { get; set; }
        /// <summary>Properties of the service endpoint policy definition.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IServiceEndpointPolicyDefinitionPropertiesFormat Property { get; set; }
        /// <summary>The provisioning state of the service endpoint policy definition resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.ProvisioningState? ProvisioningState { get; set; }
        /// <summary>Service endpoint name.</summary>
        string Service { get; set; }
        /// <summary>A list of service resources.</summary>
        string[] ServiceResource { get; set; }
        /// <summary>The type of the resource.</summary>
        string Type { get; set; }

    }
}