// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Logz.Runtime.Extensions;

    /// <summary>Response of a list VM Host Update Operation.</summary>
    public partial class VMResourcesListResponse :
        Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview.IVMResourcesListResponse,
        Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview.IVMResourcesListResponseInternal
    {

        /// <summary>Backing field for <see cref="NextLink" /> property.</summary>
        private string _nextLink;

        /// <summary>Link to the next set of results, if any.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Logz.Origin(Microsoft.Azure.PowerShell.Cmdlets.Logz.PropertyOrigin.Owned)]
        public string NextLink { get => this._nextLink; set => this._nextLink = value; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview.IVMResources[] _value;

        /// <summary>Response of a list vm host update operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Logz.Origin(Microsoft.Azure.PowerShell.Cmdlets.Logz.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview.IVMResources[] Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="VMResourcesListResponse" /> instance.</summary>
        public VMResourcesListResponse()
        {

        }
    }
    /// Response of a list VM Host Update Operation.
    public partial interface IVMResourcesListResponse :
        Microsoft.Azure.PowerShell.Cmdlets.Logz.Runtime.IJsonSerializable
    {
        /// <summary>Link to the next set of results, if any.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Logz.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Link to the next set of results, if any.",
        SerializedName = @"nextLink",
        PossibleTypes = new [] { typeof(string) })]
        string NextLink { get; set; }
        /// <summary>Response of a list vm host update operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Logz.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Response of a list vm host update operation.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview.IVMResources) })]
        Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview.IVMResources[] Value { get; set; }

    }
    /// Response of a list VM Host Update Operation.
    internal partial interface IVMResourcesListResponseInternal

    {
        /// <summary>Link to the next set of results, if any.</summary>
        string NextLink { get; set; }
        /// <summary>Response of a list vm host update operation.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview.IVMResources[] Value { get; set; }

    }
}