// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.Api20210601
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Runtime.Extensions;

    /// <summary>
    /// Gets the request plans with indication on each plan whether is approved by the admin, has pending request or not requested
    /// yet
    /// </summary>
    public partial class QueryRequestApproval :
        Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.Api20210601.IQueryRequestApproval,
        Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.Api20210601.IQueryRequestApprovalInternal
    {

        /// <summary>Backing field for <see cref="Etag" /> property.</summary>
        private string _etag;

        /// <summary>Gets or sets e-tag field</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Origin(Microsoft.Azure.PowerShell.Cmdlets.Marketplace.PropertyOrigin.Owned)]
        public string Etag { get => this._etag; set => this._etag = value; }

        /// <summary>Backing field for <see cref="MessageCode" /> property.</summary>
        private long? _messageCode;

        /// <summary>Gets or sets the notification message id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Origin(Microsoft.Azure.PowerShell.Cmdlets.Marketplace.PropertyOrigin.Owned)]
        public long? MessageCode { get => this._messageCode; set => this._messageCode = value; }

        /// <summary>Backing field for <see cref="PlansDetail" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.Api20210601.IQueryRequestApprovalPlansDetails _plansDetail;

        /// <summary>Gets or sets the plans details</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Origin(Microsoft.Azure.PowerShell.Cmdlets.Marketplace.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.Api20210601.IQueryRequestApprovalPlansDetails PlansDetail { get => (this._plansDetail = this._plansDetail ?? new Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.Api20210601.QueryRequestApprovalPlansDetails()); set => this._plansDetail = value; }

        /// <summary>Backing field for <see cref="UniqueOfferId" /> property.</summary>
        private string _uniqueOfferId;

        /// <summary>Gets or sets unique offer id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Origin(Microsoft.Azure.PowerShell.Cmdlets.Marketplace.PropertyOrigin.Owned)]
        public string UniqueOfferId { get => this._uniqueOfferId; set => this._uniqueOfferId = value; }

        /// <summary>Creates an new <see cref="QueryRequestApproval" /> instance.</summary>
        public QueryRequestApproval()
        {

        }
    }
    /// Gets the request plans with indication on each plan whether is approved by the admin, has pending request or not requested
    /// yet
    public partial interface IQueryRequestApproval :
        Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Runtime.IJsonSerializable
    {
        /// <summary>Gets or sets e-tag field</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Gets or sets e-tag field ",
        SerializedName = @"etag",
        PossibleTypes = new [] { typeof(string) })]
        string Etag { get; set; }
        /// <summary>Gets or sets the notification message id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Gets or sets the notification message id",
        SerializedName = @"messageCode",
        PossibleTypes = new [] { typeof(long) })]
        long? MessageCode { get; set; }
        /// <summary>Gets or sets the plans details</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Gets or sets the plans details",
        SerializedName = @"plansDetails",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.Api20210601.IQueryRequestApprovalPlansDetails) })]
        Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.Api20210601.IQueryRequestApprovalPlansDetails PlansDetail { get; set; }
        /// <summary>Gets or sets unique offer id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Gets or sets unique offer id.",
        SerializedName = @"uniqueOfferId",
        PossibleTypes = new [] { typeof(string) })]
        string UniqueOfferId { get; set; }

    }
    /// Gets the request plans with indication on each plan whether is approved by the admin, has pending request or not requested
    /// yet
    internal partial interface IQueryRequestApprovalInternal

    {
        /// <summary>Gets or sets e-tag field</summary>
        string Etag { get; set; }
        /// <summary>Gets or sets the notification message id</summary>
        long? MessageCode { get; set; }
        /// <summary>Gets or sets the plans details</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.Api20210601.IQueryRequestApprovalPlansDetails PlansDetail { get; set; }
        /// <summary>Gets or sets unique offer id.</summary>
        string UniqueOfferId { get; set; }

    }
}