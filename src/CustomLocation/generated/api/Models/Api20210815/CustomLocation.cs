// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20210815
{
    using static Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Runtime.Extensions;

    /// <summary>Custom Locations definition.</summary>
    public partial class CustomLocation :
        Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20210815.ICustomLocation,
        Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20210815.ICustomLocationInternal,
        Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20.ITrackedResource"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20.ITrackedResource __trackedResource = new Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20.TrackedResource();

        /// <summary>The type of the Custom Locations authentication</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Origin(Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.DoNotFormat]
        public string AuthenticationType { get => ((Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20210815.ICustomLocationPropertiesInternal)Property).AuthenticationType; set => ((Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20210815.ICustomLocationPropertiesInternal)Property).AuthenticationType = value ?? null; }

        /// <summary>The kubeconfig value.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Origin(Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.DoNotFormat]
        public string AuthenticationValue { get => ((Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20210815.ICustomLocationPropertiesInternal)Property).AuthenticationValue; set => ((Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20210815.ICustomLocationPropertiesInternal)Property).AuthenticationValue = value ?? null; }

        /// <summary>
        /// Contains the reference to the add-on that contains charts to deploy CRDs and operators.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Origin(Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.DoNotFormat]
        public string[] ClusterExtensionId { get => ((Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20210815.ICustomLocationPropertiesInternal)Property).ClusterExtensionId; set => ((Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20210815.ICustomLocationPropertiesInternal)Property).ClusterExtensionId = value ?? null /* arrayOf */; }

        /// <summary>Display name for the Custom Locations location.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Origin(Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.DoNotFormat]
        public string DisplayName { get => ((Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20210815.ICustomLocationPropertiesInternal)Property).DisplayName; set => ((Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20210815.ICustomLocationPropertiesInternal)Property).DisplayName = value ?? null; }

        /// <summary>
        /// Connected Cluster or AKS Cluster. The Custom Locations RP will perform a checkAccess API for listAdminCredentials permissions.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Origin(Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.DoNotFormat]
        public string HostResourceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20210815.ICustomLocationPropertiesInternal)Property).HostResourceId; set => ((Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20210815.ICustomLocationPropertiesInternal)Property).HostResourceId = value ?? null; }

        /// <summary>Type of host the Custom Locations is referencing (Kubernetes, etc...).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Origin(Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.DoNotFormat]
        public Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Support.HostType? HostType { get => ((Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20210815.ICustomLocationPropertiesInternal)Property).HostType; set => ((Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20210815.ICustomLocationPropertiesInternal)Property).HostType = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Support.HostType)""); }

        /// <summary>
        /// Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Origin(Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.DoNotFormat]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20.IResourceInternal)__trackedResource).Id; }

        /// <summary>Backing field for <see cref="Identity" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20210815.IIdentity _identity;

        /// <summary>Identity for the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Origin(Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.PropertyOrigin.Owned)]
        [Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.DoNotFormat]
        internal Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20210815.IIdentity Identity { get => (this._identity = this._identity ?? new Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20210815.Identity()); set => this._identity = value; }

        /// <summary>The principal ID of resource identity.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Origin(Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.DoNotFormat]
        public string IdentityPrincipalId { get => ((Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20210815.IIdentityInternal)Identity).PrincipalId; }

        /// <summary>The tenant ID of resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Origin(Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.DoNotFormat]
        public string IdentityTenantId { get => ((Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20210815.IIdentityInternal)Identity).TenantId; }

        /// <summary>The identity type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Origin(Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.DoNotFormat]
        public Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Support.ResourceIdentityType? IdentityType { get => ((Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20210815.IIdentityInternal)Identity).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20210815.IIdentityInternal)Identity).Type = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Support.ResourceIdentityType)""); }

        /// <summary>The geo-location where the resource lives</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Origin(Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.FormatTable(Index = 0)]
        public string Location { get => ((Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20.ITrackedResourceInternal)__trackedResource).Location; set => ((Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20.ITrackedResourceInternal)__trackedResource).Location = value ; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20.IResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20.IResourceInternal)__trackedResource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20.IResourceInternal)__trackedResource).Id = value; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20.IResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20.IResourceInternal)__trackedResource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20.IResourceInternal)__trackedResource).Name = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20.IResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20.IResourceInternal)__trackedResource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20.IResourceInternal)__trackedResource).Type = value; }

        /// <summary>Internal Acessors for Authentication</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20210815.ICustomLocationPropertiesAuthentication Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20210815.ICustomLocationInternal.Authentication { get => ((Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20210815.ICustomLocationPropertiesInternal)Property).Authentication; set => ((Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20210815.ICustomLocationPropertiesInternal)Property).Authentication = value; }

        /// <summary>Internal Acessors for Identity</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20210815.IIdentity Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20210815.ICustomLocationInternal.Identity { get => (this._identity = this._identity ?? new Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20210815.Identity()); set { {_identity = value;} } }

        /// <summary>Internal Acessors for IdentityPrincipalId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20210815.ICustomLocationInternal.IdentityPrincipalId { get => ((Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20210815.IIdentityInternal)Identity).PrincipalId; set => ((Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20210815.IIdentityInternal)Identity).PrincipalId = value; }

        /// <summary>Internal Acessors for IdentityTenantId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20210815.ICustomLocationInternal.IdentityTenantId { get => ((Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20210815.IIdentityInternal)Identity).TenantId; set => ((Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20210815.IIdentityInternal)Identity).TenantId = value; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20210815.ICustomLocationProperties Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20210815.ICustomLocationInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20210815.CustomLocationProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20210815.ICustomLocationInternal.ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20210815.ICustomLocationPropertiesInternal)Property).ProvisioningState; set => ((Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20210815.ICustomLocationPropertiesInternal)Property).ProvisioningState = value; }

        /// <summary>Internal Acessors for SystemData</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20.ISystemData Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20210815.ICustomLocationInternal.SystemData { get => (this._systemData = this._systemData ?? new Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20.SystemData()); set { {_systemData = value;} } }

        /// <summary>The name of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Origin(Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.FormatTable(Index = 1)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20.IResourceInternal)__trackedResource).Name; }

        /// <summary>Kubernetes namespace that will be created on the specified cluster.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Origin(Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.FormatTable(Index = 2)]
        public string Namespace { get => ((Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20210815.ICustomLocationPropertiesInternal)Property).Namespace; set => ((Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20210815.ICustomLocationPropertiesInternal)Property).Namespace = value ?? null; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20210815.ICustomLocationProperties _property;

        /// <summary>The set of properties specific to a Custom Location</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Origin(Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.PropertyOrigin.Owned)]
        [Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.DoNotFormat]
        internal Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20210815.ICustomLocationProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20210815.CustomLocationProperties()); set => this._property = value; }

        /// <summary>Provisioning State for the Custom Location.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Origin(Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.DoNotFormat]
        public string ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20210815.ICustomLocationPropertiesInternal)Property).ProvisioningState; }

        /// <summary>Backing field for <see cref="SystemData" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20.ISystemData _systemData;

        /// <summary>Metadata pertaining to creation and last modification of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Origin(Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.PropertyOrigin.Owned)]
        [Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.DoNotFormat]
        internal Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20.ISystemData SystemData { get => (this._systemData = this._systemData ?? new Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20.SystemData()); }

        /// <summary>The timestamp of resource creation (UTC).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Origin(Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.DoNotFormat]
        public global::System.DateTime? SystemDataCreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20.ISystemDataInternal)SystemData).CreatedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20.ISystemDataInternal)SystemData).CreatedAt = value ?? default(global::System.DateTime); }

        /// <summary>The identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Origin(Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.DoNotFormat]
        public string SystemDataCreatedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20.ISystemDataInternal)SystemData).CreatedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20.ISystemDataInternal)SystemData).CreatedBy = value ?? null; }

        /// <summary>The type of identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Origin(Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.DoNotFormat]
        public Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Support.CreatedByType? SystemDataCreatedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20.ISystemDataInternal)SystemData).CreatedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20.ISystemDataInternal)SystemData).CreatedByType = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Support.CreatedByType)""); }

        /// <summary>The timestamp of resource last modification (UTC)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Origin(Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.DoNotFormat]
        public global::System.DateTime? SystemDataLastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20.ISystemDataInternal)SystemData).LastModifiedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20.ISystemDataInternal)SystemData).LastModifiedAt = value ?? default(global::System.DateTime); }

        /// <summary>The identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Origin(Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.DoNotFormat]
        public string SystemDataLastModifiedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20.ISystemDataInternal)SystemData).LastModifiedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20.ISystemDataInternal)SystemData).LastModifiedBy = value ?? null; }

        /// <summary>The type of identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Origin(Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.DoNotFormat]
        public Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Support.CreatedByType? SystemDataLastModifiedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20.ISystemDataInternal)SystemData).LastModifiedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20.ISystemDataInternal)SystemData).LastModifiedByType = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Support.CreatedByType)""); }

        /// <summary>Resource tags.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Origin(Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.DoNotFormat]
        public Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20.ITrackedResourceTags Tag { get => ((Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20.ITrackedResourceInternal)__trackedResource).Tag; set => ((Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20.ITrackedResourceInternal)__trackedResource).Tag = value ?? null /* model class */; }

        /// <summary>
        /// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Origin(Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.DoNotFormat]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20.IResourceInternal)__trackedResource).Type; }

        /// <summary>Creates an new <see cref="CustomLocation" /> instance.</summary>
        public CustomLocation()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A < see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__trackedResource), __trackedResource);
            await eventListener.AssertObjectIsValid(nameof(__trackedResource), __trackedResource);
        }
    }
    /// Custom Locations definition.
    public partial interface ICustomLocation :
        Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20.ITrackedResource
    {
        /// <summary>The type of the Custom Locations authentication</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The type of the Custom Locations authentication",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        string AuthenticationType { get; set; }
        /// <summary>The kubeconfig value.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The kubeconfig value.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(string) })]
        string AuthenticationValue { get; set; }
        /// <summary>
        /// Contains the reference to the add-on that contains charts to deploy CRDs and operators.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Contains the reference to the add-on that contains charts to deploy CRDs and operators.",
        SerializedName = @"clusterExtensionIds",
        PossibleTypes = new [] { typeof(string) })]
        string[] ClusterExtensionId { get; set; }
        /// <summary>Display name for the Custom Locations location.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Display name for the Custom Locations location.",
        SerializedName = @"displayName",
        PossibleTypes = new [] { typeof(string) })]
        string DisplayName { get; set; }
        /// <summary>
        /// Connected Cluster or AKS Cluster. The Custom Locations RP will perform a checkAccess API for listAdminCredentials permissions.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Connected Cluster or AKS Cluster. The Custom Locations RP will perform a checkAccess API for listAdminCredentials permissions.",
        SerializedName = @"hostResourceId",
        PossibleTypes = new [] { typeof(string) })]
        string HostResourceId { get; set; }
        /// <summary>Type of host the Custom Locations is referencing (Kubernetes, etc...).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Type of host the Custom Locations is referencing (Kubernetes, etc...).",
        SerializedName = @"hostType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Support.HostType) })]
        Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Support.HostType? HostType { get; set; }
        /// <summary>The principal ID of resource identity.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The principal ID of resource identity.",
        SerializedName = @"principalId",
        PossibleTypes = new [] { typeof(string) })]
        string IdentityPrincipalId { get;  }
        /// <summary>The tenant ID of resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The tenant ID of resource.",
        SerializedName = @"tenantId",
        PossibleTypes = new [] { typeof(string) })]
        string IdentityTenantId { get;  }
        /// <summary>The identity type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The identity type.",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Support.ResourceIdentityType) })]
        Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Support.ResourceIdentityType? IdentityType { get; set; }
        /// <summary>Kubernetes namespace that will be created on the specified cluster.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Kubernetes namespace that will be created on the specified cluster.",
        SerializedName = @"namespace",
        PossibleTypes = new [] { typeof(string) })]
        string Namespace { get; set; }
        /// <summary>Provisioning State for the Custom Location.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Provisioning State for the Custom Location.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(string) })]
        string ProvisioningState { get;  }
        /// <summary>The timestamp of resource creation (UTC).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The timestamp of resource creation (UTC).",
        SerializedName = @"createdAt",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? SystemDataCreatedAt { get; set; }
        /// <summary>The identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The identity that created the resource.",
        SerializedName = @"createdBy",
        PossibleTypes = new [] { typeof(string) })]
        string SystemDataCreatedBy { get; set; }
        /// <summary>The type of identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The type of identity that created the resource.",
        SerializedName = @"createdByType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Support.CreatedByType) })]
        Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Support.CreatedByType? SystemDataCreatedByType { get; set; }
        /// <summary>The timestamp of resource last modification (UTC)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The timestamp of resource last modification (UTC)",
        SerializedName = @"lastModifiedAt",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? SystemDataLastModifiedAt { get; set; }
        /// <summary>The identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The identity that last modified the resource.",
        SerializedName = @"lastModifiedBy",
        PossibleTypes = new [] { typeof(string) })]
        string SystemDataLastModifiedBy { get; set; }
        /// <summary>The type of identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The type of identity that last modified the resource.",
        SerializedName = @"lastModifiedByType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Support.CreatedByType) })]
        Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Support.CreatedByType? SystemDataLastModifiedByType { get; set; }

    }
    /// Custom Locations definition.
    internal partial interface ICustomLocationInternal :
        Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20.ITrackedResourceInternal
    {
        /// <summary>
        /// This is optional input that contains the authentication that should be used to generate the namespace.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20210815.ICustomLocationPropertiesAuthentication Authentication { get; set; }
        /// <summary>The type of the Custom Locations authentication</summary>
        string AuthenticationType { get; set; }
        /// <summary>The kubeconfig value.</summary>
        string AuthenticationValue { get; set; }
        /// <summary>
        /// Contains the reference to the add-on that contains charts to deploy CRDs and operators.
        /// </summary>
        string[] ClusterExtensionId { get; set; }
        /// <summary>Display name for the Custom Locations location.</summary>
        string DisplayName { get; set; }
        /// <summary>
        /// Connected Cluster or AKS Cluster. The Custom Locations RP will perform a checkAccess API for listAdminCredentials permissions.
        /// </summary>
        string HostResourceId { get; set; }
        /// <summary>Type of host the Custom Locations is referencing (Kubernetes, etc...).</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Support.HostType? HostType { get; set; }
        /// <summary>Identity for the resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20210815.IIdentity Identity { get; set; }
        /// <summary>The principal ID of resource identity.</summary>
        string IdentityPrincipalId { get; set; }
        /// <summary>The tenant ID of resource.</summary>
        string IdentityTenantId { get; set; }
        /// <summary>The identity type.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Support.ResourceIdentityType? IdentityType { get; set; }
        /// <summary>Kubernetes namespace that will be created on the specified cluster.</summary>
        string Namespace { get; set; }
        /// <summary>The set of properties specific to a Custom Location</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20210815.ICustomLocationProperties Property { get; set; }
        /// <summary>Provisioning State for the Custom Location.</summary>
        string ProvisioningState { get; set; }
        /// <summary>Metadata pertaining to creation and last modification of the resource</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20.ISystemData SystemData { get; set; }
        /// <summary>The timestamp of resource creation (UTC).</summary>
        global::System.DateTime? SystemDataCreatedAt { get; set; }
        /// <summary>The identity that created the resource.</summary>
        string SystemDataCreatedBy { get; set; }
        /// <summary>The type of identity that created the resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Support.CreatedByType? SystemDataCreatedByType { get; set; }
        /// <summary>The timestamp of resource last modification (UTC)</summary>
        global::System.DateTime? SystemDataLastModifiedAt { get; set; }
        /// <summary>The identity that last modified the resource.</summary>
        string SystemDataLastModifiedBy { get; set; }
        /// <summary>The type of identity that last modified the resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Support.CreatedByType? SystemDataLastModifiedByType { get; set; }

    }
}