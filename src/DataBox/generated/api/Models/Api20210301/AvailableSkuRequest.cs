// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Extensions;

    /// <summary>The filters for showing the available skus.</summary>
    public partial class AvailableSkuRequest :
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IAvailableSkuRequest,
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IAvailableSkuRequestInternal
    {

        /// <summary>Backing field for <see cref="Country" /> property.</summary>
        private string _country;

        /// <summary>
        /// ISO country code. Country for hardware shipment. For codes check: https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2#Officially_assigned_code_elements
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public string Country { get => this._country; set => this._country = value; }

        /// <summary>Backing field for <see cref="Location" /> property.</summary>
        private string _location;

        /// <summary>
        /// Location for data transfer. For locations check: https://management.azure.com/subscriptions/SUBSCRIPTIONID/locations?api-version=2018-01-01
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public string Location { get => this._location; set => this._location = value; }

        /// <summary>Backing field for <see cref="SkuName" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.SkuName[] _skuName;

        /// <summary>Sku Names to filter for available skus</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.SkuName[] SkuName { get => this._skuName; set => this._skuName = value; }

        /// <summary>Backing field for <see cref="TransferType" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.TransferType _transferType;

        /// <summary>Type of the transfer.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.TransferType TransferType { get => this._transferType; set => this._transferType = value; }

        /// <summary>Creates an new <see cref="AvailableSkuRequest" /> instance.</summary>
        public AvailableSkuRequest()
        {

        }
    }
    /// The filters for showing the available skus.
    public partial interface IAvailableSkuRequest :
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.IJsonSerializable
    {
        /// <summary>
        /// ISO country code. Country for hardware shipment. For codes check: https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2#Officially_assigned_code_elements
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"ISO country code. Country for hardware shipment. For codes check: https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2#Officially_assigned_code_elements",
        SerializedName = @"country",
        PossibleTypes = new [] { typeof(string) })]
        string Country { get; set; }
        /// <summary>
        /// Location for data transfer. For locations check: https://management.azure.com/subscriptions/SUBSCRIPTIONID/locations?api-version=2018-01-01
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Location for data transfer. For locations check: https://management.azure.com/subscriptions/SUBSCRIPTIONID/locations?api-version=2018-01-01",
        SerializedName = @"location",
        PossibleTypes = new [] { typeof(string) })]
        string Location { get; set; }
        /// <summary>Sku Names to filter for available skus</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Sku Names to filter for available skus",
        SerializedName = @"skuNames",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.SkuName) })]
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.SkuName[] SkuName { get; set; }
        /// <summary>Type of the transfer.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Type of the transfer.",
        SerializedName = @"transferType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.TransferType) })]
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.TransferType TransferType { get; set; }

    }
    /// The filters for showing the available skus.
    internal partial interface IAvailableSkuRequestInternal

    {
        /// <summary>
        /// ISO country code. Country for hardware shipment. For codes check: https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2#Officially_assigned_code_elements
        /// </summary>
        string Country { get; set; }
        /// <summary>
        /// Location for data transfer. For locations check: https://management.azure.com/subscriptions/SUBSCRIPTIONID/locations?api-version=2018-01-01
        /// </summary>
        string Location { get; set; }
        /// <summary>Sku Names to filter for available skus</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.SkuName[] SkuName { get; set; }
        /// <summary>Type of the transfer.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.TransferType TransferType { get; set; }

    }
}