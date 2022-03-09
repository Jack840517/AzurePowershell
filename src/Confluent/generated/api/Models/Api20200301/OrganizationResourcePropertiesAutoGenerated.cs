// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Confluent.Models.Api20200301
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Confluent.Runtime.Extensions;

    /// <summary>Organization resource properties</summary>
    public partial class OrganizationResourcePropertiesAutoGenerated :
        Microsoft.Azure.PowerShell.Cmdlets.Confluent.Models.Api20200301.IOrganizationResourcePropertiesAutoGenerated,
        Microsoft.Azure.PowerShell.Cmdlets.Confluent.Models.Api20200301.IOrganizationResourcePropertiesAutoGeneratedInternal,
        Microsoft.Azure.PowerShell.Cmdlets.Confluent.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.Confluent.Models.Api20200301.IOrganizationResourceProperties"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Confluent.Models.Api20200301.IOrganizationResourceProperties __organizationResourceProperties = new Microsoft.Azure.PowerShell.Cmdlets.Confluent.Models.Api20200301.OrganizationResourceProperties();

        /// <summary>The creation time of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Confluent.Origin(Microsoft.Azure.PowerShell.Cmdlets.Confluent.PropertyOrigin.Inherited)]
        public global::System.DateTime? CreatedTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.Confluent.Models.Api20200301.IOrganizationResourcePropertiesInternal)__organizationResourceProperties).CreatedTime; }

        /// <summary>Internal Acessors for CreatedTime</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.Confluent.Models.Api20200301.IOrganizationResourcePropertiesInternal.CreatedTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.Confluent.Models.Api20200301.IOrganizationResourcePropertiesInternal)__organizationResourceProperties).CreatedTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.Confluent.Models.Api20200301.IOrganizationResourcePropertiesInternal)__organizationResourceProperties).CreatedTime = value; }

        /// <summary>Internal Acessors for OfferDetailStatus</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Confluent.Support.SaaSOfferStatus? Microsoft.Azure.PowerShell.Cmdlets.Confluent.Models.Api20200301.IOrganizationResourcePropertiesInternal.OfferDetailStatus { get => ((Microsoft.Azure.PowerShell.Cmdlets.Confluent.Models.Api20200301.IOrganizationResourcePropertiesInternal)__organizationResourceProperties).OfferDetailStatus; set => ((Microsoft.Azure.PowerShell.Cmdlets.Confluent.Models.Api20200301.IOrganizationResourcePropertiesInternal)__organizationResourceProperties).OfferDetailStatus = value; }

        /// <summary>Internal Acessors for OrganizationId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Confluent.Models.Api20200301.IOrganizationResourcePropertiesInternal.OrganizationId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Confluent.Models.Api20200301.IOrganizationResourcePropertiesInternal)__organizationResourceProperties).OrganizationId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Confluent.Models.Api20200301.IOrganizationResourcePropertiesInternal)__organizationResourceProperties).OrganizationId = value; }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Confluent.Support.ProvisionState? Microsoft.Azure.PowerShell.Cmdlets.Confluent.Models.Api20200301.IOrganizationResourcePropertiesInternal.ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.Confluent.Models.Api20200301.IOrganizationResourcePropertiesInternal)__organizationResourceProperties).ProvisioningState; set => ((Microsoft.Azure.PowerShell.Cmdlets.Confluent.Models.Api20200301.IOrganizationResourcePropertiesInternal)__organizationResourceProperties).ProvisioningState = value; }

        /// <summary>Internal Acessors for SsoUrl</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Confluent.Models.Api20200301.IOrganizationResourcePropertiesInternal.SsoUrl { get => ((Microsoft.Azure.PowerShell.Cmdlets.Confluent.Models.Api20200301.IOrganizationResourcePropertiesInternal)__organizationResourceProperties).SsoUrl; set => ((Microsoft.Azure.PowerShell.Cmdlets.Confluent.Models.Api20200301.IOrganizationResourcePropertiesInternal)__organizationResourceProperties).SsoUrl = value; }

        /// <summary>Confluent offer detail</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Confluent.Origin(Microsoft.Azure.PowerShell.Cmdlets.Confluent.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.Confluent.Models.Api20200301.IOfferDetail OfferDetail { get => ((Microsoft.Azure.PowerShell.Cmdlets.Confluent.Models.Api20200301.IOrganizationResourcePropertiesInternal)__organizationResourceProperties).OfferDetail; set => ((Microsoft.Azure.PowerShell.Cmdlets.Confluent.Models.Api20200301.IOrganizationResourcePropertiesInternal)__organizationResourceProperties).OfferDetail = value ?? null /* model class */; }

        /// <summary>Offer Id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Confluent.Origin(Microsoft.Azure.PowerShell.Cmdlets.Confluent.PropertyOrigin.Inherited)]
        public string OfferDetailId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Confluent.Models.Api20200301.IOrganizationResourcePropertiesInternal)__organizationResourceProperties).OfferDetailId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Confluent.Models.Api20200301.IOrganizationResourcePropertiesInternal)__organizationResourceProperties).OfferDetailId = value ?? null; }

        /// <summary>Offer Plan Id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Confluent.Origin(Microsoft.Azure.PowerShell.Cmdlets.Confluent.PropertyOrigin.Inherited)]
        public string OfferDetailPlanId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Confluent.Models.Api20200301.IOrganizationResourcePropertiesInternal)__organizationResourceProperties).OfferDetailPlanId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Confluent.Models.Api20200301.IOrganizationResourcePropertiesInternal)__organizationResourceProperties).OfferDetailPlanId = value ?? null; }

        /// <summary>Offer Plan Name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Confluent.Origin(Microsoft.Azure.PowerShell.Cmdlets.Confluent.PropertyOrigin.Inherited)]
        public string OfferDetailPlanName { get => ((Microsoft.Azure.PowerShell.Cmdlets.Confluent.Models.Api20200301.IOrganizationResourcePropertiesInternal)__organizationResourceProperties).OfferDetailPlanName; set => ((Microsoft.Azure.PowerShell.Cmdlets.Confluent.Models.Api20200301.IOrganizationResourcePropertiesInternal)__organizationResourceProperties).OfferDetailPlanName = value ?? null; }

        /// <summary>Publisher Id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Confluent.Origin(Microsoft.Azure.PowerShell.Cmdlets.Confluent.PropertyOrigin.Inherited)]
        public string OfferDetailPublisherId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Confluent.Models.Api20200301.IOrganizationResourcePropertiesInternal)__organizationResourceProperties).OfferDetailPublisherId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Confluent.Models.Api20200301.IOrganizationResourcePropertiesInternal)__organizationResourceProperties).OfferDetailPublisherId = value ?? null; }

        /// <summary>SaaS Offer Status</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Confluent.Origin(Microsoft.Azure.PowerShell.Cmdlets.Confluent.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.Confluent.Support.SaaSOfferStatus? OfferDetailStatus { get => ((Microsoft.Azure.PowerShell.Cmdlets.Confluent.Models.Api20200301.IOrganizationResourcePropertiesInternal)__organizationResourceProperties).OfferDetailStatus; }

        /// <summary>Offer Plan Term unit</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Confluent.Origin(Microsoft.Azure.PowerShell.Cmdlets.Confluent.PropertyOrigin.Inherited)]
        public string OfferDetailTermUnit { get => ((Microsoft.Azure.PowerShell.Cmdlets.Confluent.Models.Api20200301.IOrganizationResourcePropertiesInternal)__organizationResourceProperties).OfferDetailTermUnit; set => ((Microsoft.Azure.PowerShell.Cmdlets.Confluent.Models.Api20200301.IOrganizationResourcePropertiesInternal)__organizationResourceProperties).OfferDetailTermUnit = value ?? null; }

        /// <summary>Id of the Confluent organization.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Confluent.Origin(Microsoft.Azure.PowerShell.Cmdlets.Confluent.PropertyOrigin.Inherited)]
        public string OrganizationId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Confluent.Models.Api20200301.IOrganizationResourcePropertiesInternal)__organizationResourceProperties).OrganizationId; }

        /// <summary>Provision states for confluent RP</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Confluent.Origin(Microsoft.Azure.PowerShell.Cmdlets.Confluent.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.Confluent.Support.ProvisionState? ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.Confluent.Models.Api20200301.IOrganizationResourcePropertiesInternal)__organizationResourceProperties).ProvisioningState; }

        /// <summary>SSO url for the Confluent organization.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Confluent.Origin(Microsoft.Azure.PowerShell.Cmdlets.Confluent.PropertyOrigin.Inherited)]
        public string SsoUrl { get => ((Microsoft.Azure.PowerShell.Cmdlets.Confluent.Models.Api20200301.IOrganizationResourcePropertiesInternal)__organizationResourceProperties).SsoUrl; }

        /// <summary>Subscriber detail</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Confluent.Origin(Microsoft.Azure.PowerShell.Cmdlets.Confluent.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.Confluent.Models.Api20200301.IUserDetail UserDetail { get => ((Microsoft.Azure.PowerShell.Cmdlets.Confluent.Models.Api20200301.IOrganizationResourcePropertiesInternal)__organizationResourceProperties).UserDetail; set => ((Microsoft.Azure.PowerShell.Cmdlets.Confluent.Models.Api20200301.IOrganizationResourcePropertiesInternal)__organizationResourceProperties).UserDetail = value ?? null /* model class */; }

        /// <summary>Email address</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Confluent.Origin(Microsoft.Azure.PowerShell.Cmdlets.Confluent.PropertyOrigin.Inherited)]
        public string UserDetailEmailAddress { get => ((Microsoft.Azure.PowerShell.Cmdlets.Confluent.Models.Api20200301.IOrganizationResourcePropertiesInternal)__organizationResourceProperties).UserDetailEmailAddress; set => ((Microsoft.Azure.PowerShell.Cmdlets.Confluent.Models.Api20200301.IOrganizationResourcePropertiesInternal)__organizationResourceProperties).UserDetailEmailAddress = value ?? null; }

        /// <summary>First name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Confluent.Origin(Microsoft.Azure.PowerShell.Cmdlets.Confluent.PropertyOrigin.Inherited)]
        public string UserDetailFirstName { get => ((Microsoft.Azure.PowerShell.Cmdlets.Confluent.Models.Api20200301.IOrganizationResourcePropertiesInternal)__organizationResourceProperties).UserDetailFirstName; set => ((Microsoft.Azure.PowerShell.Cmdlets.Confluent.Models.Api20200301.IOrganizationResourcePropertiesInternal)__organizationResourceProperties).UserDetailFirstName = value ?? null; }

        /// <summary>Last name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Confluent.Origin(Microsoft.Azure.PowerShell.Cmdlets.Confluent.PropertyOrigin.Inherited)]
        public string UserDetailLastName { get => ((Microsoft.Azure.PowerShell.Cmdlets.Confluent.Models.Api20200301.IOrganizationResourcePropertiesInternal)__organizationResourceProperties).UserDetailLastName; set => ((Microsoft.Azure.PowerShell.Cmdlets.Confluent.Models.Api20200301.IOrganizationResourcePropertiesInternal)__organizationResourceProperties).UserDetailLastName = value ?? null; }

        /// <summary>
        /// Creates an new <see cref="OrganizationResourcePropertiesAutoGenerated" /> instance.
        /// </summary>
        public OrganizationResourcePropertiesAutoGenerated()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Confluent.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A < see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.Confluent.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__organizationResourceProperties), __organizationResourceProperties);
            await eventListener.AssertObjectIsValid(nameof(__organizationResourceProperties), __organizationResourceProperties);
        }
    }
    /// Organization resource properties
    public partial interface IOrganizationResourcePropertiesAutoGenerated :
        Microsoft.Azure.PowerShell.Cmdlets.Confluent.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Confluent.Models.Api20200301.IOrganizationResourceProperties
    {

    }
    /// Organization resource properties
    internal partial interface IOrganizationResourcePropertiesAutoGeneratedInternal :
        Microsoft.Azure.PowerShell.Cmdlets.Confluent.Models.Api20200301.IOrganizationResourcePropertiesInternal
    {

    }
}