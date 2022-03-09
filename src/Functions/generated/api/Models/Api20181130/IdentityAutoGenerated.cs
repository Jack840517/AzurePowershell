// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20181130
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.Extensions;

    /// <summary>Describes an identity resource.</summary>
    public partial class IdentityAutoGenerated :
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20181130.IIdentityAutoGenerated,
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20181130.IIdentityAutoGeneratedInternal,
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api10.ITrackedResource"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api10.ITrackedResource __trackedResource = new Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api10.TrackedResource();

        /// <summary>
        /// The id of the app associated with the identity. This is a random generated UUID by MSI.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Origin(Microsoft.Azure.PowerShell.Cmdlets.Functions.PropertyOrigin.Inlined)]
        public string ClientId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20181130.IUserAssignedIdentityPropertiesInternal)Property).ClientId; }

        /// <summary>
        /// Fully qualified resource Id for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Origin(Microsoft.Azure.PowerShell.Cmdlets.Functions.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api10.IResourceAutoGeneratedInternal)__trackedResource).Id; }

        /// <summary>The geo-location where the resource lives</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Origin(Microsoft.Azure.PowerShell.Cmdlets.Functions.PropertyOrigin.Inherited)]
        public string Location { get => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api10.ITrackedResourceInternal)__trackedResource).Location; set => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api10.ITrackedResourceInternal)__trackedResource).Location = value ; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api10.IResourceAutoGeneratedInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api10.IResourceAutoGeneratedInternal)__trackedResource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api10.IResourceAutoGeneratedInternal)__trackedResource).Id = value; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api10.IResourceAutoGeneratedInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api10.IResourceAutoGeneratedInternal)__trackedResource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api10.IResourceAutoGeneratedInternal)__trackedResource).Name = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api10.IResourceAutoGeneratedInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api10.IResourceAutoGeneratedInternal)__trackedResource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api10.IResourceAutoGeneratedInternal)__trackedResource).Type = value; }

        /// <summary>Internal Acessors for ClientId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20181130.IIdentityAutoGeneratedInternal.ClientId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20181130.IUserAssignedIdentityPropertiesInternal)Property).ClientId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20181130.IUserAssignedIdentityPropertiesInternal)Property).ClientId = value; }

        /// <summary>Internal Acessors for PrincipalId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20181130.IIdentityAutoGeneratedInternal.PrincipalId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20181130.IUserAssignedIdentityPropertiesInternal)Property).PrincipalId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20181130.IUserAssignedIdentityPropertiesInternal)Property).PrincipalId = value; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20181130.IUserAssignedIdentityProperties Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20181130.IIdentityAutoGeneratedInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20181130.UserAssignedIdentityProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for TenantId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20181130.IIdentityAutoGeneratedInternal.TenantId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20181130.IUserAssignedIdentityPropertiesInternal)Property).TenantId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20181130.IUserAssignedIdentityPropertiesInternal)Property).TenantId = value; }

        /// <summary>The name of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Origin(Microsoft.Azure.PowerShell.Cmdlets.Functions.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api10.IResourceAutoGeneratedInternal)__trackedResource).Name; }

        /// <summary>The id of the service principal object associated with the created identity.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Origin(Microsoft.Azure.PowerShell.Cmdlets.Functions.PropertyOrigin.Inlined)]
        public string PrincipalId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20181130.IUserAssignedIdentityPropertiesInternal)Property).PrincipalId; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20181130.IUserAssignedIdentityProperties _property;

        /// <summary>The properties associated with the identity.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Origin(Microsoft.Azure.PowerShell.Cmdlets.Functions.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20181130.IUserAssignedIdentityProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20181130.UserAssignedIdentityProperties()); }

        /// <summary>Resource tags.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Origin(Microsoft.Azure.PowerShell.Cmdlets.Functions.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api10.ITrackedResourceTags Tag { get => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api10.ITrackedResourceInternal)__trackedResource).Tag; set => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api10.ITrackedResourceInternal)__trackedResource).Tag = value ?? null /* model class */; }

        /// <summary>The id of the tenant which the identity belongs to.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Origin(Microsoft.Azure.PowerShell.Cmdlets.Functions.PropertyOrigin.Inlined)]
        public string TenantId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20181130.IUserAssignedIdentityPropertiesInternal)Property).TenantId; }

        /// <summary>
        /// The type of the resource. Ex- Microsoft.Compute/virtualMachines or Microsoft.Storage/storageAccounts.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Origin(Microsoft.Azure.PowerShell.Cmdlets.Functions.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api10.IResourceAutoGeneratedInternal)__trackedResource).Type; }

        /// <summary>Creates an new <see cref="IdentityAutoGenerated" /> instance.</summary>
        public IdentityAutoGenerated()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A < see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__trackedResource), __trackedResource);
            await eventListener.AssertObjectIsValid(nameof(__trackedResource), __trackedResource);
        }
    }
    /// Describes an identity resource.
    public partial interface IIdentityAutoGenerated :
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api10.ITrackedResource
    {
        /// <summary>
        /// The id of the app associated with the identity. This is a random generated UUID by MSI.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The id of the app associated with the identity. This is a random generated UUID by MSI.",
        SerializedName = @"clientId",
        PossibleTypes = new [] { typeof(string) })]
        string ClientId { get;  }
        /// <summary>The id of the service principal object associated with the created identity.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The id of the service principal object associated with the created identity.",
        SerializedName = @"principalId",
        PossibleTypes = new [] { typeof(string) })]
        string PrincipalId { get;  }
        /// <summary>The id of the tenant which the identity belongs to.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The id of the tenant which the identity belongs to.",
        SerializedName = @"tenantId",
        PossibleTypes = new [] { typeof(string) })]
        string TenantId { get;  }

    }
    /// Describes an identity resource.
    internal partial interface IIdentityAutoGeneratedInternal :
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api10.ITrackedResourceInternal
    {
        /// <summary>
        /// The id of the app associated with the identity. This is a random generated UUID by MSI.
        /// </summary>
        string ClientId { get; set; }
        /// <summary>The id of the service principal object associated with the created identity.</summary>
        string PrincipalId { get; set; }
        /// <summary>The properties associated with the identity.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20181130.IUserAssignedIdentityProperties Property { get; set; }
        /// <summary>The id of the tenant which the identity belongs to.</summary>
        string TenantId { get; set; }

    }
}