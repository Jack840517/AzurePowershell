// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Models.Api20211001
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Runtime.Extensions;

    /// <summary>The paginated list of connected Clusters</summary>
    public partial class ConnectedClusterList :
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Models.Api20211001.IConnectedClusterList,
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Models.Api20211001.IConnectedClusterListInternal
    {

        /// <summary>Backing field for <see cref="NextLink" /> property.</summary>
        private string _nextLink;

        /// <summary>The link to fetch the next page of connected cluster</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Origin(Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.PropertyOrigin.Owned)]
        public string NextLink { get => this._nextLink; set => this._nextLink = value; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Models.Api20211001.IConnectedCluster[] _value;

        /// <summary>The list of connected clusters</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Origin(Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Models.Api20211001.IConnectedCluster[] Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="ConnectedClusterList" /> instance.</summary>
        public ConnectedClusterList()
        {

        }
    }
    /// The paginated list of connected Clusters
    public partial interface IConnectedClusterList :
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Runtime.IJsonSerializable
    {
        /// <summary>The link to fetch the next page of connected cluster</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The link to fetch the next page of connected cluster",
        SerializedName = @"nextLink",
        PossibleTypes = new [] { typeof(string) })]
        string NextLink { get; set; }
        /// <summary>The list of connected clusters</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The list of connected clusters",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Models.Api20211001.IConnectedCluster) })]
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Models.Api20211001.IConnectedCluster[] Value { get; set; }

    }
    /// The paginated list of connected Clusters
    internal partial interface IConnectedClusterListInternal

    {
        /// <summary>The link to fetch the next page of connected cluster</summary>
        string NextLink { get; set; }
        /// <summary>The list of connected clusters</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Models.Api20211001.IConnectedCluster[] Value { get; set; }

    }
}