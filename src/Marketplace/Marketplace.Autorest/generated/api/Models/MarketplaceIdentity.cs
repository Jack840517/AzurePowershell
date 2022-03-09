// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Runtime.Extensions;

    public partial class MarketplaceIdentity :
        Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.IMarketplaceIdentity,
        Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.IMarketplaceIdentityInternal
    {

        /// <summary>Backing field for <see cref="AdminRequestApprovalId" /> property.</summary>
        private string _adminRequestApprovalId;

        /// <summary>The admin request approval ID to get create or update</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Origin(Microsoft.Azure.PowerShell.Cmdlets.Marketplace.PropertyOrigin.Owned)]
        public string AdminRequestApprovalId { get => this._adminRequestApprovalId; set => this._adminRequestApprovalId = value; }

        /// <summary>Backing field for <see cref="CollectionId" /> property.</summary>
        private string _collectionId;

        /// <summary>The collection ID</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Origin(Microsoft.Azure.PowerShell.Cmdlets.Marketplace.PropertyOrigin.Owned)]
        public string CollectionId { get => this._collectionId; set => this._collectionId = value; }

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        /// <summary>Resource identity path</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Origin(Microsoft.Azure.PowerShell.Cmdlets.Marketplace.PropertyOrigin.Owned)]
        public string Id { get => this._id; set => this._id = value; }

        /// <summary>Backing field for <see cref="OfferId" /> property.</summary>
        private string _offerId;

        /// <summary>The offer ID to update or delete</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Origin(Microsoft.Azure.PowerShell.Cmdlets.Marketplace.PropertyOrigin.Owned)]
        public string OfferId { get => this._offerId; set => this._offerId = value; }

        /// <summary>Backing field for <see cref="PrivateStoreId" /> property.</summary>
        private string _privateStoreId;

        /// <summary>The store ID - must use the tenant ID</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Origin(Microsoft.Azure.PowerShell.Cmdlets.Marketplace.PropertyOrigin.Owned)]
        public string PrivateStoreId { get => this._privateStoreId; set => this._privateStoreId = value; }

        /// <summary>Backing field for <see cref="RequestApprovalId" /> property.</summary>
        private string _requestApprovalId;

        /// <summary>The request approval ID to get create or update</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Origin(Microsoft.Azure.PowerShell.Cmdlets.Marketplace.PropertyOrigin.Owned)]
        public string RequestApprovalId { get => this._requestApprovalId; set => this._requestApprovalId = value; }

        /// <summary>Creates an new <see cref="MarketplaceIdentity" /> instance.</summary>
        public MarketplaceIdentity()
        {

        }
    }
    public partial interface IMarketplaceIdentity :
        Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Runtime.IJsonSerializable
    {
        /// <summary>The admin request approval ID to get create or update</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The admin request approval ID to get create or update",
        SerializedName = @"adminRequestApprovalId",
        PossibleTypes = new [] { typeof(string) })]
        string AdminRequestApprovalId { get; set; }
        /// <summary>The collection ID</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The collection ID",
        SerializedName = @"collectionId",
        PossibleTypes = new [] { typeof(string) })]
        string CollectionId { get; set; }
        /// <summary>Resource identity path</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Resource identity path",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string Id { get; set; }
        /// <summary>The offer ID to update or delete</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The offer ID to update or delete",
        SerializedName = @"offerId",
        PossibleTypes = new [] { typeof(string) })]
        string OfferId { get; set; }
        /// <summary>The store ID - must use the tenant ID</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The store ID - must use the tenant ID",
        SerializedName = @"privateStoreId",
        PossibleTypes = new [] { typeof(string) })]
        string PrivateStoreId { get; set; }
        /// <summary>The request approval ID to get create or update</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The request approval ID to get create or update",
        SerializedName = @"requestApprovalId",
        PossibleTypes = new [] { typeof(string) })]
        string RequestApprovalId { get; set; }

    }
    internal partial interface IMarketplaceIdentityInternal

    {
        /// <summary>The admin request approval ID to get create or update</summary>
        string AdminRequestApprovalId { get; set; }
        /// <summary>The collection ID</summary>
        string CollectionId { get; set; }
        /// <summary>Resource identity path</summary>
        string Id { get; set; }
        /// <summary>The offer ID to update or delete</summary>
        string OfferId { get; set; }
        /// <summary>The store ID - must use the tenant ID</summary>
        string PrivateStoreId { get; set; }
        /// <summary>The request approval ID to get create or update</summary>
        string RequestApprovalId { get; set; }

    }
}