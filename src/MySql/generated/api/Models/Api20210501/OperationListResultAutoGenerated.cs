// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501
{
    using static Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Extensions;

    /// <summary>A list of resource provider operations.</summary>
    public partial class OperationListResultAutoGenerated :
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IOperationListResultAutoGenerated,
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IOperationListResultAutoGeneratedInternal
    {

        /// <summary>Backing field for <see cref="NextLink" /> property.</summary>
        private string _nextLink;

        /// <summary>URL client should use to fetch the next page (per server side paging).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Owned)]
        public string NextLink { get => this._nextLink; set => this._nextLink = value; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IOperationAutoGenerated[] _value;

        /// <summary>Collection of available operation details</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IOperationAutoGenerated[] Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="OperationListResultAutoGenerated" /> instance.</summary>
        public OperationListResultAutoGenerated()
        {

        }
    }
    /// A list of resource provider operations.
    public partial interface IOperationListResultAutoGenerated :
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.IJsonSerializable
    {
        /// <summary>URL client should use to fetch the next page (per server side paging).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"URL client should use to fetch the next page (per server side paging).",
        SerializedName = @"nextLink",
        PossibleTypes = new [] { typeof(string) })]
        string NextLink { get; set; }
        /// <summary>Collection of available operation details</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Collection of available operation details",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IOperationAutoGenerated) })]
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IOperationAutoGenerated[] Value { get; set; }

    }
    /// A list of resource provider operations.
    internal partial interface IOperationListResultAutoGeneratedInternal

    {
        /// <summary>URL client should use to fetch the next page (per server side paging).</summary>
        string NextLink { get; set; }
        /// <summary>Collection of available operation details</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IOperationAutoGenerated[] Value { get; set; }

    }
}