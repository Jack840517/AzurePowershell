// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Quota.Runtime.Extensions;

    public partial class OperationList :
        Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.IOperationList,
        Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.IOperationListInternal
    {

        /// <summary>Backing field for <see cref="NextLink" /> property.</summary>
        private string _nextLink;

        /// <summary>URL to get the next page of items.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Quota.Origin(Microsoft.Azure.PowerShell.Cmdlets.Quota.PropertyOrigin.Owned)]
        public string NextLink { get => this._nextLink; set => this._nextLink = value; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.IOperationResponse[] _value;

        [Microsoft.Azure.PowerShell.Cmdlets.Quota.Origin(Microsoft.Azure.PowerShell.Cmdlets.Quota.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.IOperationResponse[] Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="OperationList" /> instance.</summary>
        public OperationList()
        {

        }
    }
    public partial interface IOperationList :
        Microsoft.Azure.PowerShell.Cmdlets.Quota.Runtime.IJsonSerializable
    {
        /// <summary>URL to get the next page of items.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Quota.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"URL to get the next page of items.",
        SerializedName = @"nextLink",
        PossibleTypes = new [] { typeof(string) })]
        string NextLink { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.Quota.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.IOperationResponse) })]
        Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.IOperationResponse[] Value { get; set; }

    }
    internal partial interface IOperationListInternal

    {
        /// <summary>URL to get the next page of items.</summary>
        string NextLink { get; set; }

        Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.IOperationResponse[] Value { get; set; }

    }
}