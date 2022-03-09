// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.Api20210520
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Extensions;

    /// <summary>An Azure Arc PrivateLinkScope definition.</summary>
    public partial class HybridComputePrivateLinkScope :
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.Api20210520.IHybridComputePrivateLinkScope,
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.Api20210520.IHybridComputePrivateLinkScopeInternal,
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.Api20210520.IPrivateLinkScopesResource"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.Api20210520.IPrivateLinkScopesResource __privateLinkScopesResource = new Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.Api20210520.PrivateLinkScopesResource();

        /// <summary>Azure resource Id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Origin(Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.DoNotFormat]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.Api20210520.IPrivateLinkScopesResourceInternal)__privateLinkScopesResource).Id; }

        /// <summary>Resource location</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Origin(Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.FormatTable(Index = 1)]
        public string Location { get => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.Api20210520.IPrivateLinkScopesResourceInternal)__privateLinkScopesResource).Location; set => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.Api20210520.IPrivateLinkScopesResourceInternal)__privateLinkScopesResource).Location = value ; }

        /// <summary>Internal Acessors for PrivateLinkScopeId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.Api20210520.IHybridComputePrivateLinkScopeInternal.PrivateLinkScopeId { get => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.Api20210520.IHybridComputePrivateLinkScopePropertiesInternal)Property).PrivateLinkScopeId; set => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.Api20210520.IHybridComputePrivateLinkScopePropertiesInternal)Property).PrivateLinkScopeId = value; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.Api20210520.IHybridComputePrivateLinkScopeProperties Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.Api20210520.IHybridComputePrivateLinkScopeInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.Api20210520.HybridComputePrivateLinkScopeProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.Api20210520.IHybridComputePrivateLinkScopeInternal.ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.Api20210520.IHybridComputePrivateLinkScopePropertiesInternal)Property).ProvisioningState; set => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.Api20210520.IHybridComputePrivateLinkScopePropertiesInternal)Property).ProvisioningState = value; }

        /// <summary>Internal Acessors for SystemData</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.Api10.ISystemData Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.Api20210520.IHybridComputePrivateLinkScopeInternal.SystemData { get => (this._systemData = this._systemData ?? new Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.Api10.SystemData()); set { {_systemData = value;} } }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.Api20210520.IPrivateLinkScopesResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.Api20210520.IPrivateLinkScopesResourceInternal)__privateLinkScopesResource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.Api20210520.IPrivateLinkScopesResourceInternal)__privateLinkScopesResource).Id = value; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.Api20210520.IPrivateLinkScopesResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.Api20210520.IPrivateLinkScopesResourceInternal)__privateLinkScopesResource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.Api20210520.IPrivateLinkScopesResourceInternal)__privateLinkScopesResource).Name = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.Api20210520.IPrivateLinkScopesResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.Api20210520.IPrivateLinkScopesResourceInternal)__privateLinkScopesResource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.Api20210520.IPrivateLinkScopesResourceInternal)__privateLinkScopesResource).Type = value; }

        /// <summary>Azure resource name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Origin(Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.FormatTable(Index = 0)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.Api20210520.IPrivateLinkScopesResourceInternal)__privateLinkScopesResource).Name; }

        /// <summary>The Guid id of the private link scope.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Origin(Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.DoNotFormat]
        public string PrivateLinkScopeId { get => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.Api20210520.IHybridComputePrivateLinkScopePropertiesInternal)Property).PrivateLinkScopeId; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.Api20210520.IHybridComputePrivateLinkScopeProperties _property;

        /// <summary>Properties that define a Azure Arc PrivateLinkScope resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Origin(Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.PropertyOrigin.Owned)]
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.DoNotFormat]
        internal Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.Api20210520.IHybridComputePrivateLinkScopeProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.Api20210520.HybridComputePrivateLinkScopeProperties()); set => this._property = value; }

        /// <summary>
        /// Current state of this PrivateLinkScope: whether or not is has been provisioned within the resource group it is defined.
        /// Users cannot change this value but are able to read from it. Values will include Provisioning ,Succeeded, Canceled and
        /// Failed.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Origin(Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.FormatTable(Index = 3)]
        public string ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.Api20210520.IHybridComputePrivateLinkScopePropertiesInternal)Property).ProvisioningState; }

        /// <summary>
        /// Indicates whether machines associated with the private link scope can also use public Azure Arc service endpoints.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Origin(Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.FormatTable(Index = 2)]
        public Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Support.PublicNetworkAccessType? PublicNetworkAccess { get => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.Api20210520.IHybridComputePrivateLinkScopePropertiesInternal)Property).PublicNetworkAccess; set => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.Api20210520.IHybridComputePrivateLinkScopePropertiesInternal)Property).PublicNetworkAccess = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Support.PublicNetworkAccessType)""); }

        /// <summary>Backing field for <see cref="SystemData" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.Api10.ISystemData _systemData;

        /// <summary>The system meta data relating to this resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Origin(Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.PropertyOrigin.Owned)]
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.DoNotFormat]
        internal Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.Api10.ISystemData SystemData { get => (this._systemData = this._systemData ?? new Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.Api10.SystemData()); }

        /// <summary>The timestamp of resource creation (UTC).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Origin(Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.DoNotFormat]
        public global::System.DateTime? SystemDataCreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.Api10.ISystemDataInternal)SystemData).CreatedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.Api10.ISystemDataInternal)SystemData).CreatedAt = value ?? default(global::System.DateTime); }

        /// <summary>The identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Origin(Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.DoNotFormat]
        public string SystemDataCreatedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.Api10.ISystemDataInternal)SystemData).CreatedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.Api10.ISystemDataInternal)SystemData).CreatedBy = value ?? null; }

        /// <summary>The type of identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Origin(Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.DoNotFormat]
        public Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Support.CreatedByType? SystemDataCreatedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.Api10.ISystemDataInternal)SystemData).CreatedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.Api10.ISystemDataInternal)SystemData).CreatedByType = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Support.CreatedByType)""); }

        /// <summary>The timestamp of resource last modification (UTC)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Origin(Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.DoNotFormat]
        public global::System.DateTime? SystemDataLastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.Api10.ISystemDataInternal)SystemData).LastModifiedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.Api10.ISystemDataInternal)SystemData).LastModifiedAt = value ?? default(global::System.DateTime); }

        /// <summary>The identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Origin(Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.DoNotFormat]
        public string SystemDataLastModifiedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.Api10.ISystemDataInternal)SystemData).LastModifiedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.Api10.ISystemDataInternal)SystemData).LastModifiedBy = value ?? null; }

        /// <summary>The type of identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Origin(Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.DoNotFormat]
        public Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Support.CreatedByType? SystemDataLastModifiedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.Api10.ISystemDataInternal)SystemData).LastModifiedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.Api10.ISystemDataInternal)SystemData).LastModifiedByType = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Support.CreatedByType)""); }

        /// <summary>Resource tags</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Origin(Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.FormatTable(Index = 4)]
        public Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.Api20210520.IPrivateLinkScopesResourceTags Tag { get => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.Api20210520.IPrivateLinkScopesResourceInternal)__privateLinkScopesResource).Tag; set => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.Api20210520.IPrivateLinkScopesResourceInternal)__privateLinkScopesResource).Tag = value ?? null /* model class */; }

        /// <summary>Azure resource type</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Origin(Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.DoNotFormat]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.Api20210520.IPrivateLinkScopesResourceInternal)__privateLinkScopesResource).Type; }

        /// <summary>Creates an new <see cref="HybridComputePrivateLinkScope" /> instance.</summary>
        public HybridComputePrivateLinkScope()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A < see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__privateLinkScopesResource), __privateLinkScopesResource);
            await eventListener.AssertObjectIsValid(nameof(__privateLinkScopesResource), __privateLinkScopesResource);
        }
    }
    /// An Azure Arc PrivateLinkScope definition.
    public partial interface IHybridComputePrivateLinkScope :
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.Api20210520.IPrivateLinkScopesResource
    {
        /// <summary>The Guid id of the private link scope.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The Guid id of the private link scope.",
        SerializedName = @"privateLinkScopeId",
        PossibleTypes = new [] { typeof(string) })]
        string PrivateLinkScopeId { get;  }
        /// <summary>
        /// Current state of this PrivateLinkScope: whether or not is has been provisioned within the resource group it is defined.
        /// Users cannot change this value but are able to read from it. Values will include Provisioning ,Succeeded, Canceled and
        /// Failed.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Current state of this PrivateLinkScope: whether or not is has been provisioned within the resource group it is defined. Users cannot change this value but are able to read from it. Values will include Provisioning ,Succeeded, Canceled and Failed.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(string) })]
        string ProvisioningState { get;  }
        /// <summary>
        /// Indicates whether machines associated with the private link scope can also use public Azure Arc service endpoints.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Indicates whether machines associated with the private link scope can also use public Azure Arc service endpoints.",
        SerializedName = @"publicNetworkAccess",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Support.PublicNetworkAccessType) })]
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Support.PublicNetworkAccessType? PublicNetworkAccess { get; set; }
        /// <summary>The timestamp of resource creation (UTC).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The timestamp of resource creation (UTC).",
        SerializedName = @"createdAt",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? SystemDataCreatedAt { get; set; }
        /// <summary>The identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The identity that created the resource.",
        SerializedName = @"createdBy",
        PossibleTypes = new [] { typeof(string) })]
        string SystemDataCreatedBy { get; set; }
        /// <summary>The type of identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The type of identity that created the resource.",
        SerializedName = @"createdByType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Support.CreatedByType) })]
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Support.CreatedByType? SystemDataCreatedByType { get; set; }
        /// <summary>The timestamp of resource last modification (UTC)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The timestamp of resource last modification (UTC)",
        SerializedName = @"lastModifiedAt",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? SystemDataLastModifiedAt { get; set; }
        /// <summary>The identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The identity that last modified the resource.",
        SerializedName = @"lastModifiedBy",
        PossibleTypes = new [] { typeof(string) })]
        string SystemDataLastModifiedBy { get; set; }
        /// <summary>The type of identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The type of identity that last modified the resource.",
        SerializedName = @"lastModifiedByType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Support.CreatedByType) })]
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Support.CreatedByType? SystemDataLastModifiedByType { get; set; }

    }
    /// An Azure Arc PrivateLinkScope definition.
    internal partial interface IHybridComputePrivateLinkScopeInternal :
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.Api20210520.IPrivateLinkScopesResourceInternal
    {
        /// <summary>The Guid id of the private link scope.</summary>
        string PrivateLinkScopeId { get; set; }
        /// <summary>Properties that define a Azure Arc PrivateLinkScope resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.Api20210520.IHybridComputePrivateLinkScopeProperties Property { get; set; }
        /// <summary>
        /// Current state of this PrivateLinkScope: whether or not is has been provisioned within the resource group it is defined.
        /// Users cannot change this value but are able to read from it. Values will include Provisioning ,Succeeded, Canceled and
        /// Failed.
        /// </summary>
        string ProvisioningState { get; set; }
        /// <summary>
        /// Indicates whether machines associated with the private link scope can also use public Azure Arc service endpoints.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Support.PublicNetworkAccessType? PublicNetworkAccess { get; set; }
        /// <summary>The system meta data relating to this resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.Api10.ISystemData SystemData { get; set; }
        /// <summary>The timestamp of resource creation (UTC).</summary>
        global::System.DateTime? SystemDataCreatedAt { get; set; }
        /// <summary>The identity that created the resource.</summary>
        string SystemDataCreatedBy { get; set; }
        /// <summary>The type of identity that created the resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Support.CreatedByType? SystemDataCreatedByType { get; set; }
        /// <summary>The timestamp of resource last modification (UTC)</summary>
        global::System.DateTime? SystemDataLastModifiedAt { get; set; }
        /// <summary>The identity that last modified the resource.</summary>
        string SystemDataLastModifiedBy { get; set; }
        /// <summary>The type of identity that last modified the resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Support.CreatedByType? SystemDataLastModifiedByType { get; set; }

    }
}