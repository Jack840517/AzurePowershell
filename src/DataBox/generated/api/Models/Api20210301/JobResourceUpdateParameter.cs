// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Extensions;

    /// <summary>The JobResourceUpdateParameter.</summary>
    public partial class JobResourceUpdateParameter :
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IJobResourceUpdateParameter,
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IJobResourceUpdateParameterInternal
    {

        /// <summary>Contact details for notification and shipping.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IContactDetails DetailContactDetail { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IUpdateJobPropertiesInternal)Property).DetailContactDetail; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IUpdateJobPropertiesInternal)Property).DetailContactDetail = value ?? null /* model class */; }

        /// <summary>Key encryption key for the job.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IKeyEncryptionKey DetailKeyEncryptionKey { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IUpdateJobPropertiesInternal)Property).DetailKeyEncryptionKey; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IUpdateJobPropertiesInternal)Property).DetailKeyEncryptionKey = value ?? null /* model class */; }

        /// <summary>Shipping address of the customer.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IShippingAddress DetailShippingAddress { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IUpdateJobPropertiesInternal)Property).DetailShippingAddress; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IUpdateJobPropertiesInternal)Property).DetailShippingAddress = value ?? null /* model class */; }

        /// <summary>Backing field for <see cref="Identity" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IResourceIdentity _identity;

        /// <summary>Msi identity of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IResourceIdentity Identity { get => (this._identity = this._identity ?? new Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.ResourceIdentity()); set => this._identity = value; }

        /// <summary>Service Principal Id backing the Msi</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public string IdentityPrincipalId { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IResourceIdentityInternal)Identity).PrincipalId; }

        /// <summary>Home Tenant Id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public string IdentityTenantId { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IResourceIdentityInternal)Identity).TenantId; }

        /// <summary>Identity type</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public string IdentityType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IResourceIdentityInternal)Identity).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IResourceIdentityInternal)Identity).Type = value ?? null; }

        /// <summary>User Assigned Identities</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IResourceIdentityUserAssignedIdentities IdentityUserAssignedIdentity { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IResourceIdentityInternal)Identity).UserAssignedIdentity; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IResourceIdentityInternal)Identity).UserAssignedIdentity = value ?? null /* model class */; }

        /// <summary>Internal Acessors for Detail</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IUpdateJobDetails Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IJobResourceUpdateParameterInternal.Detail { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IUpdateJobPropertiesInternal)Property).Detail; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IUpdateJobPropertiesInternal)Property).Detail = value; }

        /// <summary>Internal Acessors for Identity</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IResourceIdentity Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IJobResourceUpdateParameterInternal.Identity { get => (this._identity = this._identity ?? new Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.ResourceIdentity()); set { {_identity = value;} } }

        /// <summary>Internal Acessors for IdentityPrincipalId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IJobResourceUpdateParameterInternal.IdentityPrincipalId { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IResourceIdentityInternal)Identity).PrincipalId; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IResourceIdentityInternal)Identity).PrincipalId = value; }

        /// <summary>Internal Acessors for IdentityTenantId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IJobResourceUpdateParameterInternal.IdentityTenantId { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IResourceIdentityInternal)Identity).TenantId; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IResourceIdentityInternal)Identity).TenantId = value; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IUpdateJobProperties Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IJobResourceUpdateParameterInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.UpdateJobProperties()); set { {_property = value;} } }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IUpdateJobProperties _property;

        /// <summary>Properties of a job to be updated.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IUpdateJobProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.UpdateJobProperties()); set => this._property = value; }

        /// <summary>Backing field for <see cref="Tag" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IJobResourceUpdateParameterTags _tag;

        /// <summary>
        /// The list of key value pairs that describe the resource. These tags can be used in viewing and grouping this resource (across
        /// resource groups).
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IJobResourceUpdateParameterTags Tag { get => (this._tag = this._tag ?? new Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.JobResourceUpdateParameterTags()); set => this._tag = value; }

        /// <summary>Creates an new <see cref="JobResourceUpdateParameter" /> instance.</summary>
        public JobResourceUpdateParameter()
        {

        }
    }
    /// The JobResourceUpdateParameter.
    public partial interface IJobResourceUpdateParameter :
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.IJsonSerializable
    {
        /// <summary>Contact details for notification and shipping.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Contact details for notification and shipping.",
        SerializedName = @"contactDetails",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IContactDetails) })]
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IContactDetails DetailContactDetail { get; set; }
        /// <summary>Key encryption key for the job.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Key encryption key for the job.",
        SerializedName = @"keyEncryptionKey",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IKeyEncryptionKey) })]
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IKeyEncryptionKey DetailKeyEncryptionKey { get; set; }
        /// <summary>Shipping address of the customer.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Shipping address of the customer.",
        SerializedName = @"shippingAddress",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IShippingAddress) })]
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IShippingAddress DetailShippingAddress { get; set; }
        /// <summary>Service Principal Id backing the Msi</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Service Principal Id backing the Msi",
        SerializedName = @"principalId",
        PossibleTypes = new [] { typeof(string) })]
        string IdentityPrincipalId { get;  }
        /// <summary>Home Tenant Id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Home Tenant Id",
        SerializedName = @"tenantId",
        PossibleTypes = new [] { typeof(string) })]
        string IdentityTenantId { get;  }
        /// <summary>Identity type</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Identity type",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        string IdentityType { get; set; }
        /// <summary>User Assigned Identities</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"User Assigned Identities",
        SerializedName = @"userAssignedIdentities",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IResourceIdentityUserAssignedIdentities) })]
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IResourceIdentityUserAssignedIdentities IdentityUserAssignedIdentity { get; set; }
        /// <summary>
        /// The list of key value pairs that describe the resource. These tags can be used in viewing and grouping this resource (across
        /// resource groups).
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The list of key value pairs that describe the resource. These tags can be used in viewing and grouping this resource (across resource groups).",
        SerializedName = @"tags",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IJobResourceUpdateParameterTags) })]
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IJobResourceUpdateParameterTags Tag { get; set; }

    }
    /// The JobResourceUpdateParameter.
    internal partial interface IJobResourceUpdateParameterInternal

    {
        /// <summary>Details of a job to be updated.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IUpdateJobDetails Detail { get; set; }
        /// <summary>Contact details for notification and shipping.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IContactDetails DetailContactDetail { get; set; }
        /// <summary>Key encryption key for the job.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IKeyEncryptionKey DetailKeyEncryptionKey { get; set; }
        /// <summary>Shipping address of the customer.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IShippingAddress DetailShippingAddress { get; set; }
        /// <summary>Msi identity of the resource</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IResourceIdentity Identity { get; set; }
        /// <summary>Service Principal Id backing the Msi</summary>
        string IdentityPrincipalId { get; set; }
        /// <summary>Home Tenant Id</summary>
        string IdentityTenantId { get; set; }
        /// <summary>Identity type</summary>
        string IdentityType { get; set; }
        /// <summary>User Assigned Identities</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IResourceIdentityUserAssignedIdentities IdentityUserAssignedIdentity { get; set; }
        /// <summary>Properties of a job to be updated.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IUpdateJobProperties Property { get; set; }
        /// <summary>
        /// The list of key value pairs that describe the resource. These tags can be used in viewing and grouping this resource (across
        /// resource groups).
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IJobResourceUpdateParameterTags Tag { get; set; }

    }
}