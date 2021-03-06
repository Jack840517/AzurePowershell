// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.Api20210601
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Runtime.Extensions;

    /// <summary>Withdraw properties</summary>
    public partial class WithdrawProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.Api20210601.IWithdrawProperties,
        Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.Api20210601.IWithdrawPropertiesInternal
    {

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.Api20210601.IWithdrawDetails Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.Api20210601.IWithdrawPropertiesInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.Api20210601.WithdrawDetails()); set { {_property = value;} } }

        /// <summary>Gets or sets Plan Id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Origin(Microsoft.Azure.PowerShell.Cmdlets.Marketplace.PropertyOrigin.Inlined)]
        public string PlanId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.Api20210601.IWithdrawDetailsInternal)Property).PlanId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.Api20210601.IWithdrawDetailsInternal)Property).PlanId = value ?? null; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.Api20210601.IWithdrawDetails _property;

        /// <summary>Withdraw properties details</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Origin(Microsoft.Azure.PowerShell.Cmdlets.Marketplace.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.Api20210601.IWithdrawDetails Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.Api20210601.WithdrawDetails()); set => this._property = value; }

        /// <summary>The offer's publisher id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Origin(Microsoft.Azure.PowerShell.Cmdlets.Marketplace.PropertyOrigin.Inlined)]
        public string PublisherId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.Api20210601.IWithdrawDetailsInternal)Property).PublisherId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.Api20210601.IWithdrawDetailsInternal)Property).PublisherId = value ?? null; }

        /// <summary>Creates an new <see cref="WithdrawProperties" /> instance.</summary>
        public WithdrawProperties()
        {

        }
    }
    /// Withdraw properties
    public partial interface IWithdrawProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Runtime.IJsonSerializable
    {
        /// <summary>Gets or sets Plan Id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Gets or sets Plan Id ",
        SerializedName = @"planId",
        PossibleTypes = new [] { typeof(string) })]
        string PlanId { get; set; }
        /// <summary>The offer's publisher id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The offer's publisher id",
        SerializedName = @"publisherId",
        PossibleTypes = new [] { typeof(string) })]
        string PublisherId { get; set; }

    }
    /// Withdraw properties
    internal partial interface IWithdrawPropertiesInternal

    {
        /// <summary>Gets or sets Plan Id</summary>
        string PlanId { get; set; }
        /// <summary>Withdraw properties details</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.Api20210601.IWithdrawDetails Property { get; set; }
        /// <summary>The offer's publisher id</summary>
        string PublisherId { get; set; }

    }
}