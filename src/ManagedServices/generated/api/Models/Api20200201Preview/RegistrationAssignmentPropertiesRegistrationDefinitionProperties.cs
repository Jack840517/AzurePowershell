// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Runtime.Extensions;

    /// <summary>
    /// The properties of the registration definition associated with the registration assignment.
    /// </summary>
    public partial class RegistrationAssignmentPropertiesRegistrationDefinitionProperties :
        Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IRegistrationAssignmentPropertiesRegistrationDefinitionProperties,
        Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IRegistrationAssignmentPropertiesRegistrationDefinitionPropertiesInternal
    {

        /// <summary>Backing field for <see cref="Authorization" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IAuthorization[] _authorization;

        /// <summary>
        /// The collection of authorization objects describing the access Azure Active Directory principals in the managedBy tenant
        /// will receive on the delegated resource in the managed tenant.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IAuthorization[] Authorization { get => this._authorization; set => this._authorization = value; }

        /// <summary>Backing field for <see cref="Description" /> property.</summary>
        private string _description;

        /// <summary>The description of the registration definition.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.PropertyOrigin.Owned)]
        public string Description { get => this._description; set => this._description = value; }

        /// <summary>Backing field for <see cref="EligibleAuthorization" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IEligibleAuthorization[] _eligibleAuthorization;

        /// <summary>
        /// The collection of eligible authorization objects describing the just-in-time access Azure Active Directory principals
        /// in the managedBy tenant will receive on the delegated resource in the managed tenant.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IEligibleAuthorization[] EligibleAuthorization { get => this._eligibleAuthorization; set => this._eligibleAuthorization = value; }

        /// <summary>Backing field for <see cref="ManagedByTenantId" /> property.</summary>
        private string _managedByTenantId;

        /// <summary>The identifier of the managedBy tenant.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.PropertyOrigin.Owned)]
        public string ManagedByTenantId { get => this._managedByTenantId; set => this._managedByTenantId = value; }

        /// <summary>Backing field for <see cref="ManagedByTenantName" /> property.</summary>
        private string _managedByTenantName;

        /// <summary>The name of the managedBy tenant.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.PropertyOrigin.Owned)]
        public string ManagedByTenantName { get => this._managedByTenantName; set => this._managedByTenantName = value; }

        /// <summary>Backing field for <see cref="ManageeTenantId" /> property.</summary>
        private string _manageeTenantId;

        /// <summary>The identifier of the managed tenant.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.PropertyOrigin.Owned)]
        public string ManageeTenantId { get => this._manageeTenantId; set => this._manageeTenantId = value; }

        /// <summary>Backing field for <see cref="ManageeTenantName" /> property.</summary>
        private string _manageeTenantName;

        /// <summary>The name of the managed tenant.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.PropertyOrigin.Owned)]
        public string ManageeTenantName { get => this._manageeTenantName; set => this._manageeTenantName = value; }

        /// <summary>Backing field for <see cref="ProvisioningState" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Support.ProvisioningState? _provisioningState;

        /// <summary>The current provisioning state of the registration definition.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Support.ProvisioningState? ProvisioningState { get => this._provisioningState; set => this._provisioningState = value; }

        /// <summary>Backing field for <see cref="RegistrationDefinitionName" /> property.</summary>
        private string _registrationDefinitionName;

        /// <summary>The name of the registration definition.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.PropertyOrigin.Owned)]
        public string RegistrationDefinitionName { get => this._registrationDefinitionName; set => this._registrationDefinitionName = value; }

        /// <summary>
        /// Creates an new <see cref="RegistrationAssignmentPropertiesRegistrationDefinitionProperties" /> instance.
        /// </summary>
        public RegistrationAssignmentPropertiesRegistrationDefinitionProperties()
        {

        }
    }
    /// The properties of the registration definition associated with the registration assignment.
    public partial interface IRegistrationAssignmentPropertiesRegistrationDefinitionProperties :
        Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Runtime.IJsonSerializable
    {
        /// <summary>
        /// The collection of authorization objects describing the access Azure Active Directory principals in the managedBy tenant
        /// will receive on the delegated resource in the managed tenant.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The collection of authorization objects describing the access Azure Active Directory principals in the managedBy tenant will receive on the delegated resource in the managed tenant.",
        SerializedName = @"authorizations",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IAuthorization) })]
        Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IAuthorization[] Authorization { get; set; }
        /// <summary>The description of the registration definition.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The description of the registration definition.",
        SerializedName = @"description",
        PossibleTypes = new [] { typeof(string) })]
        string Description { get; set; }
        /// <summary>
        /// The collection of eligible authorization objects describing the just-in-time access Azure Active Directory principals
        /// in the managedBy tenant will receive on the delegated resource in the managed tenant.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The collection of eligible authorization objects describing the just-in-time access Azure Active Directory principals in the managedBy tenant will receive on the delegated resource in the managed tenant.",
        SerializedName = @"eligibleAuthorizations",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IEligibleAuthorization) })]
        Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IEligibleAuthorization[] EligibleAuthorization { get; set; }
        /// <summary>The identifier of the managedBy tenant.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The identifier of the managedBy tenant.",
        SerializedName = @"managedByTenantId",
        PossibleTypes = new [] { typeof(string) })]
        string ManagedByTenantId { get; set; }
        /// <summary>The name of the managedBy tenant.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The name of the managedBy tenant.",
        SerializedName = @"managedByTenantName",
        PossibleTypes = new [] { typeof(string) })]
        string ManagedByTenantName { get; set; }
        /// <summary>The identifier of the managed tenant.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The identifier of the managed tenant.",
        SerializedName = @"manageeTenantId",
        PossibleTypes = new [] { typeof(string) })]
        string ManageeTenantId { get; set; }
        /// <summary>The name of the managed tenant.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The name of the managed tenant.",
        SerializedName = @"manageeTenantName",
        PossibleTypes = new [] { typeof(string) })]
        string ManageeTenantName { get; set; }
        /// <summary>The current provisioning state of the registration definition.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The current provisioning state of the registration definition.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Support.ProvisioningState) })]
        Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Support.ProvisioningState? ProvisioningState { get; set; }
        /// <summary>The name of the registration definition.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The name of the registration definition.",
        SerializedName = @"registrationDefinitionName",
        PossibleTypes = new [] { typeof(string) })]
        string RegistrationDefinitionName { get; set; }

    }
    /// The properties of the registration definition associated with the registration assignment.
    internal partial interface IRegistrationAssignmentPropertiesRegistrationDefinitionPropertiesInternal

    {
        /// <summary>
        /// The collection of authorization objects describing the access Azure Active Directory principals in the managedBy tenant
        /// will receive on the delegated resource in the managed tenant.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IAuthorization[] Authorization { get; set; }
        /// <summary>The description of the registration definition.</summary>
        string Description { get; set; }
        /// <summary>
        /// The collection of eligible authorization objects describing the just-in-time access Azure Active Directory principals
        /// in the managedBy tenant will receive on the delegated resource in the managed tenant.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IEligibleAuthorization[] EligibleAuthorization { get; set; }
        /// <summary>The identifier of the managedBy tenant.</summary>
        string ManagedByTenantId { get; set; }
        /// <summary>The name of the managedBy tenant.</summary>
        string ManagedByTenantName { get; set; }
        /// <summary>The identifier of the managed tenant.</summary>
        string ManageeTenantId { get; set; }
        /// <summary>The name of the managed tenant.</summary>
        string ManageeTenantName { get; set; }
        /// <summary>The current provisioning state of the registration definition.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Support.ProvisioningState? ProvisioningState { get; set; }
        /// <summary>The name of the registration definition.</summary>
        string RegistrationDefinitionName { get; set; }

    }
}