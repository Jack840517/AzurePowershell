// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20200401Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Runtime.Extensions;

    /// <summary>
    /// The response to an enumeration operation on inbound endpoints for a DNS resolver.
    /// </summary>
    public partial class InboundEndpointListResult :
        Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20200401Preview.IInboundEndpointListResult,
        Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20200401Preview.IInboundEndpointListResultInternal
    {

        /// <summary>Internal Acessors for NextLink</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20200401Preview.IInboundEndpointListResultInternal.NextLink { get => this._nextLink; set { {_nextLink = value;} } }

        /// <summary>Backing field for <see cref="NextLink" /> property.</summary>
        private string _nextLink;

        /// <summary>The continuation token for the next page of results.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Origin(Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.PropertyOrigin.Owned)]
        public string NextLink { get => this._nextLink; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20200401Preview.IInboundEndpoint[] _value;

        /// <summary>Enumeration of the inbound endpoints for a DNS resolver.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Origin(Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20200401Preview.IInboundEndpoint[] Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="InboundEndpointListResult" /> instance.</summary>
        public InboundEndpointListResult()
        {

        }
    }
    /// The response to an enumeration operation on inbound endpoints for a DNS resolver.
    public partial interface IInboundEndpointListResult :
        Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Runtime.IJsonSerializable
    {
        /// <summary>The continuation token for the next page of results.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The continuation token for the next page of results.",
        SerializedName = @"nextLink",
        PossibleTypes = new [] { typeof(string) })]
        string NextLink { get;  }
        /// <summary>Enumeration of the inbound endpoints for a DNS resolver.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Enumeration of the inbound endpoints for a DNS resolver.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20200401Preview.IInboundEndpoint) })]
        Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20200401Preview.IInboundEndpoint[] Value { get; set; }

    }
    /// The response to an enumeration operation on inbound endpoints for a DNS resolver.
    internal partial interface IInboundEndpointListResultInternal

    {
        /// <summary>The continuation token for the next page of results.</summary>
        string NextLink { get; set; }
        /// <summary>Enumeration of the inbound endpoints for a DNS resolver.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20200401Preview.IInboundEndpoint[] Value { get; set; }

    }
}