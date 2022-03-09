// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201
{
    using static Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.Extensions;

    /// <summary>List of orders.</summary>
    public partial class OrderResourceList :
        Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IOrderResourceList,
        Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IOrderResourceListInternal
    {

        /// <summary>Internal Acessors for Value</summary>
        Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IOrderResource[] Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IOrderResourceListInternal.Value { get => this._value; set { {_value = value;} } }

        /// <summary>Backing field for <see cref="NextLink" /> property.</summary>
        private string _nextLink;

        /// <summary>Link for the next set of order resources.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Origin(Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.PropertyOrigin.Owned)]
        public string NextLink { get => this._nextLink; set => this._nextLink = value; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IOrderResource[] _value;

        /// <summary>List of order resources.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Origin(Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IOrderResource[] Value { get => this._value; }

        /// <summary>Creates an new <see cref="OrderResourceList" /> instance.</summary>
        public OrderResourceList()
        {

        }
    }
    /// List of orders.
    public partial interface IOrderResourceList :
        Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.IJsonSerializable
    {
        /// <summary>Link for the next set of order resources.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Link for the next set of order resources.",
        SerializedName = @"nextLink",
        PossibleTypes = new [] { typeof(string) })]
        string NextLink { get; set; }
        /// <summary>List of order resources.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"List of order resources.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IOrderResource) })]
        Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IOrderResource[] Value { get;  }

    }
    /// List of orders.
    internal partial interface IOrderResourceListInternal

    {
        /// <summary>Link for the next set of order resources.</summary>
        string NextLink { get; set; }
        /// <summary>List of order resources.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IOrderResource[] Value { get; set; }

    }
}