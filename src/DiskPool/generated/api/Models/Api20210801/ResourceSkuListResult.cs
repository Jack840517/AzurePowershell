// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210801
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Runtime.Extensions;

    /// <summary>List Disk Pool skus operation response.</summary>
    public partial class ResourceSkuListResult :
        Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210801.IResourceSkuListResult,
        Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210801.IResourceSkuListResultInternal
    {

        /// <summary>Backing field for <see cref="NextLink" /> property.</summary>
        private string _nextLink;

        /// <summary>URI to fetch the next section of the paginated response.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Origin(Microsoft.Azure.PowerShell.Cmdlets.DiskPool.PropertyOrigin.Owned)]
        public string NextLink { get => this._nextLink; set => this._nextLink = value; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210801.IResourceSkuInfo[] _value;

        /// <summary>The list of StoragePool resource skus.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Origin(Microsoft.Azure.PowerShell.Cmdlets.DiskPool.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210801.IResourceSkuInfo[] Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="ResourceSkuListResult" /> instance.</summary>
        public ResourceSkuListResult()
        {

        }
    }
    /// List Disk Pool skus operation response.
    public partial interface IResourceSkuListResult :
        Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Runtime.IJsonSerializable
    {
        /// <summary>URI to fetch the next section of the paginated response.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"URI to fetch the next section of the paginated response.",
        SerializedName = @"nextLink",
        PossibleTypes = new [] { typeof(string) })]
        string NextLink { get; set; }
        /// <summary>The list of StoragePool resource skus.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The list of StoragePool resource skus.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210801.IResourceSkuInfo) })]
        Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210801.IResourceSkuInfo[] Value { get; set; }

    }
    /// List Disk Pool skus operation response.
    internal partial interface IResourceSkuListResultInternal

    {
        /// <summary>URI to fetch the next section of the paginated response.</summary>
        string NextLink { get; set; }
        /// <summary>The list of StoragePool resource skus.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210801.IResourceSkuInfo[] Value { get; set; }

    }
}