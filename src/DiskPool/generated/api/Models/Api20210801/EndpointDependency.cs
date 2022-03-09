// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210801
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Runtime.Extensions;

    /// <summary>
    /// A domain name that a service is reached at, including details of the current connection status.
    /// </summary>
    public partial class EndpointDependency :
        Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210801.IEndpointDependency,
        Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210801.IEndpointDependencyInternal
    {

        /// <summary>Backing field for <see cref="DomainName" /> property.</summary>
        private string _domainName;

        /// <summary>The domain name of the dependency.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Origin(Microsoft.Azure.PowerShell.Cmdlets.DiskPool.PropertyOrigin.Owned)]
        public string DomainName { get => this._domainName; set => this._domainName = value; }

        /// <summary>Backing field for <see cref="EndpointDetail" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210801.IEndpointDetail[] _endpointDetail;

        /// <summary>The IP Addresses and Ports used when connecting to DomainName.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Origin(Microsoft.Azure.PowerShell.Cmdlets.DiskPool.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210801.IEndpointDetail[] EndpointDetail { get => this._endpointDetail; set => this._endpointDetail = value; }

        /// <summary>Creates an new <see cref="EndpointDependency" /> instance.</summary>
        public EndpointDependency()
        {

        }
    }
    /// A domain name that a service is reached at, including details of the current connection status.
    public partial interface IEndpointDependency :
        Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Runtime.IJsonSerializable
    {
        /// <summary>The domain name of the dependency.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The domain name of the dependency.",
        SerializedName = @"domainName",
        PossibleTypes = new [] { typeof(string) })]
        string DomainName { get; set; }
        /// <summary>The IP Addresses and Ports used when connecting to DomainName.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The IP Addresses and Ports used when connecting to DomainName.",
        SerializedName = @"endpointDetails",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210801.IEndpointDetail) })]
        Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210801.IEndpointDetail[] EndpointDetail { get; set; }

    }
    /// A domain name that a service is reached at, including details of the current connection status.
    internal partial interface IEndpointDependencyInternal

    {
        /// <summary>The domain name of the dependency.</summary>
        string DomainName { get; set; }
        /// <summary>The IP Addresses and Ports used when connecting to DomainName.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210801.IEndpointDetail[] EndpointDetail { get; set; }

    }
}