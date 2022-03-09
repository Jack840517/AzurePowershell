// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.BareMetal.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.BareMetal.Runtime.Extensions;

    public partial class BareMetalIdentity :
        Microsoft.Azure.PowerShell.Cmdlets.BareMetal.Models.IBareMetalIdentity,
        Microsoft.Azure.PowerShell.Cmdlets.BareMetal.Models.IBareMetalIdentityInternal
    {

        /// <summary>Backing field for <see cref="AzureBareMetalInstanceName" /> property.</summary>
        private string _azureBareMetalInstanceName;

        /// <summary>Name of the Azure BareMetal on Azure instance.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BareMetal.Origin(Microsoft.Azure.PowerShell.Cmdlets.BareMetal.PropertyOrigin.Owned)]
        public string AzureBareMetalInstanceName { get => this._azureBareMetalInstanceName; set => this._azureBareMetalInstanceName = value; }

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        /// <summary>Resource identity path</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BareMetal.Origin(Microsoft.Azure.PowerShell.Cmdlets.BareMetal.PropertyOrigin.Owned)]
        public string Id { get => this._id; set => this._id = value; }

        /// <summary>Backing field for <see cref="ResourceGroupName" /> property.</summary>
        private string _resourceGroupName;

        /// <summary>The name of the resource group. The name is case insensitive.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BareMetal.Origin(Microsoft.Azure.PowerShell.Cmdlets.BareMetal.PropertyOrigin.Owned)]
        public string ResourceGroupName { get => this._resourceGroupName; set => this._resourceGroupName = value; }

        /// <summary>Backing field for <see cref="SubscriptionId" /> property.</summary>
        private string _subscriptionId;

        /// <summary>The ID of the target subscription.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BareMetal.Origin(Microsoft.Azure.PowerShell.Cmdlets.BareMetal.PropertyOrigin.Owned)]
        public string SubscriptionId { get => this._subscriptionId; set => this._subscriptionId = value; }

        /// <summary>Creates an new <see cref="BareMetalIdentity" /> instance.</summary>
        public BareMetalIdentity()
        {

        }
    }
    public partial interface IBareMetalIdentity :
        Microsoft.Azure.PowerShell.Cmdlets.BareMetal.Runtime.IJsonSerializable
    {
        /// <summary>Name of the Azure BareMetal on Azure instance.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BareMetal.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Name of the Azure BareMetal on Azure instance.",
        SerializedName = @"azureBareMetalInstanceName",
        PossibleTypes = new [] { typeof(string) })]
        string AzureBareMetalInstanceName { get; set; }
        /// <summary>Resource identity path</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BareMetal.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Resource identity path",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string Id { get; set; }
        /// <summary>The name of the resource group. The name is case insensitive.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BareMetal.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The name of the resource group. The name is case insensitive.",
        SerializedName = @"resourceGroupName",
        PossibleTypes = new [] { typeof(string) })]
        string ResourceGroupName { get; set; }
        /// <summary>The ID of the target subscription.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BareMetal.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The ID of the target subscription.",
        SerializedName = @"subscriptionId",
        PossibleTypes = new [] { typeof(string) })]
        string SubscriptionId { get; set; }

    }
    internal partial interface IBareMetalIdentityInternal

    {
        /// <summary>Name of the Azure BareMetal on Azure instance.</summary>
        string AzureBareMetalInstanceName { get; set; }
        /// <summary>Resource identity path</summary>
        string Id { get; set; }
        /// <summary>The name of the resource group. The name is case insensitive.</summary>
        string ResourceGroupName { get; set; }
        /// <summary>The ID of the target subscription.</summary>
        string SubscriptionId { get; set; }

    }
}