// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Extensions;

    /// <summary>Job Resource Collection</summary>
    public partial class JobResourceList :
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IJobResourceList,
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IJobResourceListInternal
    {

        /// <summary>Backing field for <see cref="NextLink" /> property.</summary>
        private string _nextLink;

        /// <summary>Link for the next set of job resources.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public string NextLink { get => this._nextLink; set => this._nextLink = value; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IJobResource[] _value;

        /// <summary>List of job resources.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IJobResource[] Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="JobResourceList" /> instance.</summary>
        public JobResourceList()
        {

        }
    }
    /// Job Resource Collection
    public partial interface IJobResourceList :
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.IJsonSerializable
    {
        /// <summary>Link for the next set of job resources.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Link for the next set of job resources.",
        SerializedName = @"nextLink",
        PossibleTypes = new [] { typeof(string) })]
        string NextLink { get; set; }
        /// <summary>List of job resources.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"List of job resources.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IJobResource) })]
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IJobResource[] Value { get; set; }

    }
    /// Job Resource Collection
    internal partial interface IJobResourceListInternal

    {
        /// <summary>Link for the next set of job resources.</summary>
        string NextLink { get; set; }
        /// <summary>List of job resources.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IJobResource[] Value { get; set; }

    }
}