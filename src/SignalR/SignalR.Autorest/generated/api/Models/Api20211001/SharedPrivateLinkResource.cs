// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20211001
{
    using static Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Runtime.Extensions;

    /// <summary>Describes a Shared Private Link Resource</summary>
    public partial class SharedPrivateLinkResource :
        Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20211001.ISharedPrivateLinkResource,
        Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20211001.ISharedPrivateLinkResourceInternal,
        Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20211001.IResource"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20211001.IResource __resource = new Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20211001.Resource();

        /// <summary>
        /// The group id from the provider of resource the shared private link resource is for
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Origin(Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.PropertyOrigin.Inlined)]
        public string GroupId { get => ((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20211001.ISharedPrivateLinkResourcePropertiesInternal)Property).GroupId; set => ((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20211001.ISharedPrivateLinkResourcePropertiesInternal)Property).GroupId = value ?? null; }

        /// <summary>Fully qualified resource Id for the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Origin(Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20211001.IResourceInternal)__resource).Id; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20211001.IResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20211001.IResourceInternal)__resource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20211001.IResourceInternal)__resource).Id = value; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20211001.IResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20211001.IResourceInternal)__resource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20211001.IResourceInternal)__resource).Name = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20211001.IResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20211001.IResourceInternal)__resource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20211001.IResourceInternal)__resource).Type = value; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20211001.ISharedPrivateLinkResourceProperties Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20211001.ISharedPrivateLinkResourceInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20211001.SharedPrivateLinkResourceProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Support.ProvisioningState? Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20211001.ISharedPrivateLinkResourceInternal.ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20211001.ISharedPrivateLinkResourcePropertiesInternal)Property).ProvisioningState; set => ((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20211001.ISharedPrivateLinkResourcePropertiesInternal)Property).ProvisioningState = value; }

        /// <summary>Internal Acessors for Status</summary>
        Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Support.SharedPrivateLinkResourceStatus? Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20211001.ISharedPrivateLinkResourceInternal.Status { get => ((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20211001.ISharedPrivateLinkResourcePropertiesInternal)Property).Status; set => ((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20211001.ISharedPrivateLinkResourcePropertiesInternal)Property).Status = value; }

        /// <summary>Internal Acessors for SystemData</summary>
        Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20.ISystemData Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20211001.ISharedPrivateLinkResourceInternal.SystemData { get => (this._systemData = this._systemData ?? new Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20.SystemData()); set { {_systemData = value;} } }

        /// <summary>The name of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Origin(Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20211001.IResourceInternal)__resource).Name; }

        /// <summary>The resource id of the resource the shared private link resource is for</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Origin(Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.PropertyOrigin.Inlined)]
        public string PrivateLinkResourceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20211001.ISharedPrivateLinkResourcePropertiesInternal)Property).PrivateLinkResourceId; set => ((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20211001.ISharedPrivateLinkResourcePropertiesInternal)Property).PrivateLinkResourceId = value ?? null; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20211001.ISharedPrivateLinkResourceProperties _property;

        /// <summary>Describes the properties of a Shared Private Link Resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Origin(Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20211001.ISharedPrivateLinkResourceProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20211001.SharedPrivateLinkResourceProperties()); set => this._property = value; }

        /// <summary>Provisioning state of the shared private link resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Origin(Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Support.ProvisioningState? ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20211001.ISharedPrivateLinkResourcePropertiesInternal)Property).ProvisioningState; }

        /// <summary>The request message for requesting approval of the shared private link resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Origin(Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.PropertyOrigin.Inlined)]
        public string RequestMessage { get => ((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20211001.ISharedPrivateLinkResourcePropertiesInternal)Property).RequestMessage; set => ((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20211001.ISharedPrivateLinkResourcePropertiesInternal)Property).RequestMessage = value ?? null; }

        /// <summary>Status of the shared private link resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Origin(Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Support.SharedPrivateLinkResourceStatus? Status { get => ((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20211001.ISharedPrivateLinkResourcePropertiesInternal)Property).Status; }

        /// <summary>Backing field for <see cref="SystemData" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20.ISystemData _systemData;

        /// <summary>Metadata pertaining to creation and last modification of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Origin(Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20.ISystemData SystemData { get => (this._systemData = this._systemData ?? new Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20.SystemData()); }

        /// <summary>The timestamp of resource creation (UTC).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Origin(Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.PropertyOrigin.Inlined)]
        public global::System.DateTime? SystemDataCreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20.ISystemDataInternal)SystemData).CreatedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20.ISystemDataInternal)SystemData).CreatedAt = value ?? default(global::System.DateTime); }

        /// <summary>The identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Origin(Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.PropertyOrigin.Inlined)]
        public string SystemDataCreatedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20.ISystemDataInternal)SystemData).CreatedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20.ISystemDataInternal)SystemData).CreatedBy = value ?? null; }

        /// <summary>The type of identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Origin(Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Support.CreatedByType? SystemDataCreatedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20.ISystemDataInternal)SystemData).CreatedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20.ISystemDataInternal)SystemData).CreatedByType = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Support.CreatedByType)""); }

        /// <summary>The timestamp of resource last modification (UTC)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Origin(Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.PropertyOrigin.Inlined)]
        public global::System.DateTime? SystemDataLastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20.ISystemDataInternal)SystemData).LastModifiedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20.ISystemDataInternal)SystemData).LastModifiedAt = value ?? default(global::System.DateTime); }

        /// <summary>The identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Origin(Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.PropertyOrigin.Inlined)]
        public string SystemDataLastModifiedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20.ISystemDataInternal)SystemData).LastModifiedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20.ISystemDataInternal)SystemData).LastModifiedBy = value ?? null; }

        /// <summary>The type of identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Origin(Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Support.CreatedByType? SystemDataLastModifiedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20.ISystemDataInternal)SystemData).LastModifiedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20.ISystemDataInternal)SystemData).LastModifiedByType = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Support.CreatedByType)""); }

        /// <summary>The type of the resource - e.g. "Microsoft.SignalRService/SignalR"</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Origin(Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20211001.IResourceInternal)__resource).Type; }

        /// <summary>Creates an new <see cref="SharedPrivateLinkResource" /> instance.</summary>
        public SharedPrivateLinkResource()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A < see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__resource), __resource);
            await eventListener.AssertObjectIsValid(nameof(__resource), __resource);
        }
    }
    /// Describes a Shared Private Link Resource
    public partial interface ISharedPrivateLinkResource :
        Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20211001.IResource
    {
        /// <summary>
        /// The group id from the provider of resource the shared private link resource is for
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The group id from the provider of resource the shared private link resource is for",
        SerializedName = @"groupId",
        PossibleTypes = new [] { typeof(string) })]
        string GroupId { get; set; }
        /// <summary>The resource id of the resource the shared private link resource is for</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The resource id of the resource the shared private link resource is for",
        SerializedName = @"privateLinkResourceId",
        PossibleTypes = new [] { typeof(string) })]
        string PrivateLinkResourceId { get; set; }
        /// <summary>Provisioning state of the shared private link resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Provisioning state of the shared private link resource",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Support.ProvisioningState) })]
        Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Support.ProvisioningState? ProvisioningState { get;  }
        /// <summary>The request message for requesting approval of the shared private link resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The request message for requesting approval of the shared private link resource",
        SerializedName = @"requestMessage",
        PossibleTypes = new [] { typeof(string) })]
        string RequestMessage { get; set; }
        /// <summary>Status of the shared private link resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Status of the shared private link resource",
        SerializedName = @"status",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Support.SharedPrivateLinkResourceStatus) })]
        Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Support.SharedPrivateLinkResourceStatus? Status { get;  }
        /// <summary>The timestamp of resource creation (UTC).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The timestamp of resource creation (UTC).",
        SerializedName = @"createdAt",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? SystemDataCreatedAt { get; set; }
        /// <summary>The identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The identity that created the resource.",
        SerializedName = @"createdBy",
        PossibleTypes = new [] { typeof(string) })]
        string SystemDataCreatedBy { get; set; }
        /// <summary>The type of identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The type of identity that created the resource.",
        SerializedName = @"createdByType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Support.CreatedByType) })]
        Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Support.CreatedByType? SystemDataCreatedByType { get; set; }
        /// <summary>The timestamp of resource last modification (UTC)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The timestamp of resource last modification (UTC)",
        SerializedName = @"lastModifiedAt",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? SystemDataLastModifiedAt { get; set; }
        /// <summary>The identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The identity that last modified the resource.",
        SerializedName = @"lastModifiedBy",
        PossibleTypes = new [] { typeof(string) })]
        string SystemDataLastModifiedBy { get; set; }
        /// <summary>The type of identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The type of identity that last modified the resource.",
        SerializedName = @"lastModifiedByType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Support.CreatedByType) })]
        Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Support.CreatedByType? SystemDataLastModifiedByType { get; set; }

    }
    /// Describes a Shared Private Link Resource
    internal partial interface ISharedPrivateLinkResourceInternal :
        Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20211001.IResourceInternal
    {
        /// <summary>
        /// The group id from the provider of resource the shared private link resource is for
        /// </summary>
        string GroupId { get; set; }
        /// <summary>The resource id of the resource the shared private link resource is for</summary>
        string PrivateLinkResourceId { get; set; }
        /// <summary>Describes the properties of a Shared Private Link Resource</summary>
        Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20211001.ISharedPrivateLinkResourceProperties Property { get; set; }
        /// <summary>Provisioning state of the shared private link resource</summary>
        Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Support.ProvisioningState? ProvisioningState { get; set; }
        /// <summary>The request message for requesting approval of the shared private link resource</summary>
        string RequestMessage { get; set; }
        /// <summary>Status of the shared private link resource</summary>
        Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Support.SharedPrivateLinkResourceStatus? Status { get; set; }
        /// <summary>Metadata pertaining to creation and last modification of the resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20.ISystemData SystemData { get; set; }
        /// <summary>The timestamp of resource creation (UTC).</summary>
        global::System.DateTime? SystemDataCreatedAt { get; set; }
        /// <summary>The identity that created the resource.</summary>
        string SystemDataCreatedBy { get; set; }
        /// <summary>The type of identity that created the resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Support.CreatedByType? SystemDataCreatedByType { get; set; }
        /// <summary>The timestamp of resource last modification (UTC)</summary>
        global::System.DateTime? SystemDataLastModifiedAt { get; set; }
        /// <summary>The identity that last modified the resource.</summary>
        string SystemDataLastModifiedBy { get; set; }
        /// <summary>The type of identity that last modified the resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Support.CreatedByType? SystemDataLastModifiedByType { get; set; }

    }
}