// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Extensions;

    /// <summary>User of a lab that can register for and use virtual machines within the lab.</summary>
    public partial class User :
        Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.IUser,
        Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.IUserInternal,
        Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20.IResource" />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20.IResource __resource = new Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20.Resource();

        /// <summary>
        /// The amount of usage quota time the user gets in addition to the lab usage quota.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.LabServices.PropertyOrigin.Inlined)]
        public global::System.TimeSpan? AdditionalUsageQuota { get => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.IUserUpdatePropertiesInternal)Property).AdditionalUsageQuota; set => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.IUserUpdatePropertiesInternal)Property).AdditionalUsageQuota = value ?? default(global::System.TimeSpan); }

        /// <summary>Display name of the user, for example user's full name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.LabServices.PropertyOrigin.Inlined)]
        public string DisplayName { get => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.IUserPropertiesInternal)Property).DisplayName; }

        /// <summary>Email address of the user.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.LabServices.PropertyOrigin.Inlined)]
        public string Email { get => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.IUserPropertiesInternal)Property).Email; set => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.IUserPropertiesInternal)Property).Email = value ; }

        /// <summary>
        /// Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.LabServices.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20.IResourceInternal)__resource).Id; }

        /// <summary>Date and time when the invitation message was sent to the user.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.LabServices.PropertyOrigin.Inlined)]
        public global::System.DateTime? InvitationSent { get => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.IUserPropertiesInternal)Property).InvitationSent; }

        /// <summary>State of the invitation message for the user.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.LabServices.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.LabServices.Support.InvitationState? InvitationState { get => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.IUserPropertiesInternal)Property).InvitationState; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20.IResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20.IResourceInternal)__resource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20.IResourceInternal)__resource).Id = value; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20.IResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20.IResourceInternal)__resource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20.IResourceInternal)__resource).Name = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20.IResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20.IResourceInternal)__resource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20.IResourceInternal)__resource).Type = value; }

        /// <summary>Internal Acessors for DisplayName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.IUserInternal.DisplayName { get => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.IUserPropertiesInternal)Property).DisplayName; set => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.IUserPropertiesInternal)Property).DisplayName = value; }

        /// <summary>Internal Acessors for InvitationSent</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.IUserInternal.InvitationSent { get => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.IUserPropertiesInternal)Property).InvitationSent; set => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.IUserPropertiesInternal)Property).InvitationSent = value; }

        /// <summary>Internal Acessors for InvitationState</summary>
        Microsoft.Azure.PowerShell.Cmdlets.LabServices.Support.InvitationState? Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.IUserInternal.InvitationState { get => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.IUserPropertiesInternal)Property).InvitationState; set => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.IUserPropertiesInternal)Property).InvitationState = value; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.IUserProperties Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.IUserInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.UserProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        Microsoft.Azure.PowerShell.Cmdlets.LabServices.Support.ProvisioningState? Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.IUserInternal.ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.IUserPropertiesInternal)Property).ProvisioningState; set => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.IUserPropertiesInternal)Property).ProvisioningState = value; }

        /// <summary>Internal Acessors for RegistrationState</summary>
        Microsoft.Azure.PowerShell.Cmdlets.LabServices.Support.RegistrationState? Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.IUserInternal.RegistrationState { get => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.IUserPropertiesInternal)Property).RegistrationState; set => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.IUserPropertiesInternal)Property).RegistrationState = value; }

        /// <summary>Internal Acessors for SystemData</summary>
        Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20.ISystemData Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.IUserInternal.SystemData { get => (this._systemData = this._systemData ?? new Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20.SystemData()); set { {_systemData = value;} } }

        /// <summary>Internal Acessors for TotalUsage</summary>
        global::System.TimeSpan? Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.IUserInternal.TotalUsage { get => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.IUserPropertiesInternal)Property).TotalUsage; set => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.IUserPropertiesInternal)Property).TotalUsage = value; }

        /// <summary>The name of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.LabServices.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20.IResourceInternal)__resource).Name; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.IUserProperties _property;

        /// <summary>User resource properties</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.LabServices.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.IUserProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.UserProperties()); set => this._property = value; }

        /// <summary>Current provisioning state of the user resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.LabServices.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.LabServices.Support.ProvisioningState? ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.IUserPropertiesInternal)Property).ProvisioningState; }

        /// <summary>State of the user's registration within the lab.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.LabServices.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.LabServices.Support.RegistrationState? RegistrationState { get => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.IUserPropertiesInternal)Property).RegistrationState; }

        /// <summary>Backing field for <see cref="SystemData" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20.ISystemData _systemData;

        /// <summary>Metadata pertaining to creation and last modification of the user resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.LabServices.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20.ISystemData SystemData { get => (this._systemData = this._systemData ?? new Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20.SystemData()); }

        /// <summary>The timestamp of resource creation (UTC).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.LabServices.PropertyOrigin.Inlined)]
        public global::System.DateTime? SystemDataCreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20.ISystemDataInternal)SystemData).CreatedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20.ISystemDataInternal)SystemData).CreatedAt = value ?? default(global::System.DateTime); }

        /// <summary>The identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.LabServices.PropertyOrigin.Inlined)]
        public string SystemDataCreatedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20.ISystemDataInternal)SystemData).CreatedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20.ISystemDataInternal)SystemData).CreatedBy = value ?? null; }

        /// <summary>The type of identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.LabServices.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.LabServices.Support.CreatedByType? SystemDataCreatedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20.ISystemDataInternal)SystemData).CreatedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20.ISystemDataInternal)SystemData).CreatedByType = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Support.CreatedByType)""); }

        /// <summary>The timestamp of resource last modification (UTC)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.LabServices.PropertyOrigin.Inlined)]
        public global::System.DateTime? SystemDataLastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20.ISystemDataInternal)SystemData).LastModifiedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20.ISystemDataInternal)SystemData).LastModifiedAt = value ?? default(global::System.DateTime); }

        /// <summary>The identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.LabServices.PropertyOrigin.Inlined)]
        public string SystemDataLastModifiedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20.ISystemDataInternal)SystemData).LastModifiedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20.ISystemDataInternal)SystemData).LastModifiedBy = value ?? null; }

        /// <summary>The type of identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.LabServices.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.LabServices.Support.CreatedByType? SystemDataLastModifiedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20.ISystemDataInternal)SystemData).LastModifiedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20.ISystemDataInternal)SystemData).LastModifiedByType = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Support.CreatedByType)""); }

        /// <summary>How long the user has used their virtual machines in this lab.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.LabServices.PropertyOrigin.Inlined)]
        public global::System.TimeSpan? TotalUsage { get => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.IUserPropertiesInternal)Property).TotalUsage; }

        /// <summary>
        /// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.LabServices.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20.IResourceInternal)__resource).Type; }

        /// <summary>Creates an new <see cref="User" /> instance.</summary>
        public User()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A < see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__resource), __resource);
            await eventListener.AssertObjectIsValid(nameof(__resource), __resource);
        }
    }
    /// User of a lab that can register for and use virtual machines within the lab.
    public partial interface IUser :
        Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20.IResource
    {
        /// <summary>
        /// The amount of usage quota time the user gets in addition to the lab usage quota.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The amount of usage quota time the user gets in addition to the lab usage quota.",
        SerializedName = @"additionalUsageQuota",
        PossibleTypes = new [] { typeof(global::System.TimeSpan) })]
        global::System.TimeSpan? AdditionalUsageQuota { get; set; }
        /// <summary>Display name of the user, for example user's full name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Display name of the user, for example user's full name.",
        SerializedName = @"displayName",
        PossibleTypes = new [] { typeof(string) })]
        string DisplayName { get;  }
        /// <summary>Email address of the user.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Email address of the user.",
        SerializedName = @"email",
        PossibleTypes = new [] { typeof(string) })]
        string Email { get; set; }
        /// <summary>Date and time when the invitation message was sent to the user.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Date and time when the invitation message was sent to the user.",
        SerializedName = @"invitationSent",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? InvitationSent { get;  }
        /// <summary>State of the invitation message for the user.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"State of the invitation message for the user.",
        SerializedName = @"invitationState",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.LabServices.Support.InvitationState) })]
        Microsoft.Azure.PowerShell.Cmdlets.LabServices.Support.InvitationState? InvitationState { get;  }
        /// <summary>Current provisioning state of the user resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Current provisioning state of the user resource.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.LabServices.Support.ProvisioningState) })]
        Microsoft.Azure.PowerShell.Cmdlets.LabServices.Support.ProvisioningState? ProvisioningState { get;  }
        /// <summary>State of the user's registration within the lab.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"State of the user's registration within the lab.",
        SerializedName = @"registrationState",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.LabServices.Support.RegistrationState) })]
        Microsoft.Azure.PowerShell.Cmdlets.LabServices.Support.RegistrationState? RegistrationState { get;  }
        /// <summary>The timestamp of resource creation (UTC).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The timestamp of resource creation (UTC).",
        SerializedName = @"createdAt",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? SystemDataCreatedAt { get; set; }
        /// <summary>The identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The identity that created the resource.",
        SerializedName = @"createdBy",
        PossibleTypes = new [] { typeof(string) })]
        string SystemDataCreatedBy { get; set; }
        /// <summary>The type of identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The type of identity that created the resource.",
        SerializedName = @"createdByType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.LabServices.Support.CreatedByType) })]
        Microsoft.Azure.PowerShell.Cmdlets.LabServices.Support.CreatedByType? SystemDataCreatedByType { get; set; }
        /// <summary>The timestamp of resource last modification (UTC)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The timestamp of resource last modification (UTC)",
        SerializedName = @"lastModifiedAt",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? SystemDataLastModifiedAt { get; set; }
        /// <summary>The identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The identity that last modified the resource.",
        SerializedName = @"lastModifiedBy",
        PossibleTypes = new [] { typeof(string) })]
        string SystemDataLastModifiedBy { get; set; }
        /// <summary>The type of identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The type of identity that last modified the resource.",
        SerializedName = @"lastModifiedByType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.LabServices.Support.CreatedByType) })]
        Microsoft.Azure.PowerShell.Cmdlets.LabServices.Support.CreatedByType? SystemDataLastModifiedByType { get; set; }
        /// <summary>How long the user has used their virtual machines in this lab.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"How long the user has used their virtual machines in this lab.",
        SerializedName = @"totalUsage",
        PossibleTypes = new [] { typeof(global::System.TimeSpan) })]
        global::System.TimeSpan? TotalUsage { get;  }

    }
    /// User of a lab that can register for and use virtual machines within the lab.
    internal partial interface IUserInternal :
        Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20.IResourceInternal
    {
        /// <summary>
        /// The amount of usage quota time the user gets in addition to the lab usage quota.
        /// </summary>
        global::System.TimeSpan? AdditionalUsageQuota { get; set; }
        /// <summary>Display name of the user, for example user's full name.</summary>
        string DisplayName { get; set; }
        /// <summary>Email address of the user.</summary>
        string Email { get; set; }
        /// <summary>Date and time when the invitation message was sent to the user.</summary>
        global::System.DateTime? InvitationSent { get; set; }
        /// <summary>State of the invitation message for the user.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.LabServices.Support.InvitationState? InvitationState { get; set; }
        /// <summary>User resource properties</summary>
        Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.IUserProperties Property { get; set; }
        /// <summary>Current provisioning state of the user resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.LabServices.Support.ProvisioningState? ProvisioningState { get; set; }
        /// <summary>State of the user's registration within the lab.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.LabServices.Support.RegistrationState? RegistrationState { get; set; }
        /// <summary>Metadata pertaining to creation and last modification of the user resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20.ISystemData SystemData { get; set; }
        /// <summary>The timestamp of resource creation (UTC).</summary>
        global::System.DateTime? SystemDataCreatedAt { get; set; }
        /// <summary>The identity that created the resource.</summary>
        string SystemDataCreatedBy { get; set; }
        /// <summary>The type of identity that created the resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.LabServices.Support.CreatedByType? SystemDataCreatedByType { get; set; }
        /// <summary>The timestamp of resource last modification (UTC)</summary>
        global::System.DateTime? SystemDataLastModifiedAt { get; set; }
        /// <summary>The identity that last modified the resource.</summary>
        string SystemDataLastModifiedBy { get; set; }
        /// <summary>The type of identity that last modified the resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.LabServices.Support.CreatedByType? SystemDataLastModifiedByType { get; set; }
        /// <summary>How long the user has used their virtual machines in this lab.</summary>
        global::System.TimeSpan? TotalUsage { get; set; }

    }
}