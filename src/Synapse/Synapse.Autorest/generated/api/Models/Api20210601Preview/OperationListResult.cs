// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Synapse.Runtime.Extensions;

    /// <summary>
    /// Result of the request to list REST API operations. It contains a list of operations and a URL nextLink to get the next
    /// set of results.
    /// </summary>
    public partial class OperationListResult :
        Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IOperationListResult,
        Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IOperationListResultInternal
    {

        /// <summary>Internal Acessors for NextLink</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IOperationListResultInternal.NextLink { get => this._nextLink; set { {_nextLink = value;} } }

        /// <summary>Backing field for <see cref="NextLink" /> property.</summary>
        private string _nextLink;

        /// <summary>The URL to get the next set of operation list results if there are any.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Synapse.Origin(Microsoft.Azure.PowerShell.Cmdlets.Synapse.PropertyOrigin.Owned)]
        public string NextLink { get => this._nextLink; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IOperation[] _value;

        /// <summary>The list of operations supported by the resource provider.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Synapse.Origin(Microsoft.Azure.PowerShell.Cmdlets.Synapse.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IOperation[] Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="OperationListResult" /> instance.</summary>
        public OperationListResult()
        {

        }
    }
    /// Result of the request to list REST API operations. It contains a list of operations and a URL nextLink to get the next
    /// set of results.
    public partial interface IOperationListResult :
        Microsoft.Azure.PowerShell.Cmdlets.Synapse.Runtime.IJsonSerializable
    {
        /// <summary>The URL to get the next set of operation list results if there are any.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Synapse.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The URL to get the next set of operation list results if there are any.",
        SerializedName = @"nextLink",
        PossibleTypes = new [] { typeof(string) })]
        string NextLink { get;  }
        /// <summary>The list of operations supported by the resource provider.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Synapse.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The list of operations supported by the resource provider.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IOperation) })]
        Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IOperation[] Value { get; set; }

    }
    /// Result of the request to list REST API operations. It contains a list of operations and a URL nextLink to get the next
    /// set of results.
    internal partial interface IOperationListResultInternal

    {
        /// <summary>The URL to get the next set of operation list results if there are any.</summary>
        string NextLink { get; set; }
        /// <summary>The list of operations supported by the resource provider.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IOperation[] Value { get; set; }

    }
}