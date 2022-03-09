// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Runtime.Extensions;

    public partial class ManagedServicesIdentity :
        Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.IManagedServicesIdentity,
        Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.IManagedServicesIdentityInternal
    {

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        /// <summary>Resource identity path</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.PropertyOrigin.Owned)]
        public string Id { get => this._id; set => this._id = value; }

        /// <summary>Backing field for <see cref="MarketplaceIdentifier" /> property.</summary>
        private string _marketplaceIdentifier;

        /// <summary>
        /// The Azure Marketplace identifier. Expected formats: {publisher}.{product[-preview]}.{planName}.{version} or {publisher}.{product[-preview]}.{planName}
        /// or {publisher}.{product[-preview]} or {publisher}).
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.PropertyOrigin.Owned)]
        public string MarketplaceIdentifier { get => this._marketplaceIdentifier; set => this._marketplaceIdentifier = value; }

        /// <summary>Backing field for <see cref="RegistrationAssignmentId" /> property.</summary>
        private string _registrationAssignmentId;

        /// <summary>The GUID of the registration assignment.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.PropertyOrigin.Owned)]
        public string RegistrationAssignmentId { get => this._registrationAssignmentId; set => this._registrationAssignmentId = value; }

        /// <summary>Backing field for <see cref="RegistrationDefinitionId" /> property.</summary>
        private string _registrationDefinitionId;

        /// <summary>The GUID of the registration definition.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.PropertyOrigin.Owned)]
        public string RegistrationDefinitionId { get => this._registrationDefinitionId; set => this._registrationDefinitionId = value; }

        /// <summary>Backing field for <see cref="Scope" /> property.</summary>
        private string _scope;

        /// <summary>The scope of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.PropertyOrigin.Owned)]
        public string Scope { get => this._scope; set => this._scope = value; }

        /// <summary>Creates an new <see cref="ManagedServicesIdentity" /> instance.</summary>
        public ManagedServicesIdentity()
        {

        }
    }
    public partial interface IManagedServicesIdentity :
        Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Runtime.IJsonSerializable
    {
        /// <summary>Resource identity path</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Resource identity path",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string Id { get; set; }
        /// <summary>
        /// The Azure Marketplace identifier. Expected formats: {publisher}.{product[-preview]}.{planName}.{version} or {publisher}.{product[-preview]}.{planName}
        /// or {publisher}.{product[-preview]} or {publisher}).
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The Azure Marketplace identifier. Expected formats: {publisher}.{product[-preview]}.{planName}.{version} or {publisher}.{product[-preview]}.{planName} or {publisher}.{product[-preview]} or {publisher}).",
        SerializedName = @"marketplaceIdentifier",
        PossibleTypes = new [] { typeof(string) })]
        string MarketplaceIdentifier { get; set; }
        /// <summary>The GUID of the registration assignment.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The GUID of the registration assignment.",
        SerializedName = @"registrationAssignmentId",
        PossibleTypes = new [] { typeof(string) })]
        string RegistrationAssignmentId { get; set; }
        /// <summary>The GUID of the registration definition.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The GUID of the registration definition.",
        SerializedName = @"registrationDefinitionId",
        PossibleTypes = new [] { typeof(string) })]
        string RegistrationDefinitionId { get; set; }
        /// <summary>The scope of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The scope of the resource.",
        SerializedName = @"scope",
        PossibleTypes = new [] { typeof(string) })]
        string Scope { get; set; }

    }
    internal partial interface IManagedServicesIdentityInternal

    {
        /// <summary>Resource identity path</summary>
        string Id { get; set; }
        /// <summary>
        /// The Azure Marketplace identifier. Expected formats: {publisher}.{product[-preview]}.{planName}.{version} or {publisher}.{product[-preview]}.{planName}
        /// or {publisher}.{product[-preview]} or {publisher}).
        /// </summary>
        string MarketplaceIdentifier { get; set; }
        /// <summary>The GUID of the registration assignment.</summary>
        string RegistrationAssignmentId { get; set; }
        /// <summary>The GUID of the registration definition.</summary>
        string RegistrationDefinitionId { get; set; }
        /// <summary>The scope of the resource.</summary>
        string Scope { get; set; }

    }
}