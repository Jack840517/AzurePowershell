// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301
{
    using static Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Extensions;

    /// <summary>Route table resource.</summary>
    public partial class RouteTable :
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IRouteTable,
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IRouteTableInternal,
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IResource"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IResource __resource = new Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.Resource();

        /// <summary>
        /// Whether to disable the routes learned by BGP on that route table. True means disable.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Inlined)]
        public bool? DisableBgpRoutePropagation { get => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IRouteTablePropertiesFormatInternal)Property).DisableBgpRoutePropagation; set => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IRouteTablePropertiesFormatInternal)Property).DisableBgpRoutePropagation = value ?? default(bool); }

        /// <summary>Backing field for <see cref="Etag" /> property.</summary>
        private string _etag;

        /// <summary>A unique read-only string that changes whenever the resource is updated.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Owned)]
        public string Etag { get => this._etag; }

        /// <summary>Resource ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IResourceInternal)__resource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IResourceInternal)__resource).Id = value ?? null; }

        /// <summary>Resource location.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Inherited)]
        public string Location { get => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IResourceInternal)__resource).Location; set => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IResourceInternal)__resource).Location = value ?? null; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IResourceInternal)__resource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IResourceInternal)__resource).Name = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IResourceInternal)__resource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IResourceInternal)__resource).Type = value; }

        /// <summary>Internal Acessors for Etag</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IRouteTableInternal.Etag { get => this._etag; set { {_etag = value;} } }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IRouteTablePropertiesFormat Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IRouteTableInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.RouteTablePropertiesFormat()); set { {_property = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.ProvisioningState? Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IRouteTableInternal.ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IRouteTablePropertiesFormatInternal)Property).ProvisioningState; set => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IRouteTablePropertiesFormatInternal)Property).ProvisioningState = value; }

        /// <summary>Internal Acessors for ResourceGuid</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IRouteTableInternal.ResourceGuid { get => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IRouteTablePropertiesFormatInternal)Property).ResourceGuid; set => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IRouteTablePropertiesFormatInternal)Property).ResourceGuid = value; }

        /// <summary>Internal Acessors for Subnet</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.ISubnet[] Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IRouteTableInternal.Subnet { get => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IRouteTablePropertiesFormatInternal)Property).Subnet; set => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IRouteTablePropertiesFormatInternal)Property).Subnet = value; }

        /// <summary>Resource name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IResourceInternal)__resource).Name; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IRouteTablePropertiesFormat _property;

        /// <summary>Properties of the route table.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IRouteTablePropertiesFormat Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.RouteTablePropertiesFormat()); set => this._property = value; }

        /// <summary>The provisioning state of the route table resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.ProvisioningState? ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IRouteTablePropertiesFormatInternal)Property).ProvisioningState; }

        /// <summary>The resource GUID property of the route table.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Inlined)]
        public string ResourceGuid { get => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IRouteTablePropertiesFormatInternal)Property).ResourceGuid; }

        /// <summary>Collection of routes contained within a route table.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IRoute[] Route { get => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IRouteTablePropertiesFormatInternal)Property).Route; set => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IRouteTablePropertiesFormatInternal)Property).Route = value ?? null /* arrayOf */; }

        /// <summary>A collection of references to subnets.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.ISubnet[] Subnet { get => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IRouteTablePropertiesFormatInternal)Property).Subnet; }

        /// <summary>Resource tags.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IResourceTags Tag { get => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IResourceInternal)__resource).Tag; set => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IResourceInternal)__resource).Tag = value ?? null /* model class */; }

        /// <summary>Resource type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IResourceInternal)__resource).Type; }

        /// <summary>Creates an new <see cref="RouteTable" /> instance.</summary>
        public RouteTable()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A < see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__resource), __resource);
            await eventListener.AssertObjectIsValid(nameof(__resource), __resource);
        }
    }
    /// Route table resource.
    public partial interface IRouteTable :
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IResource
    {
        /// <summary>
        /// Whether to disable the routes learned by BGP on that route table. True means disable.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Whether to disable the routes learned by BGP on that route table. True means disable.",
        SerializedName = @"disableBgpRoutePropagation",
        PossibleTypes = new [] { typeof(bool) })]
        bool? DisableBgpRoutePropagation { get; set; }
        /// <summary>A unique read-only string that changes whenever the resource is updated.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"A unique read-only string that changes whenever the resource is updated.",
        SerializedName = @"etag",
        PossibleTypes = new [] { typeof(string) })]
        string Etag { get;  }
        /// <summary>The provisioning state of the route table resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The provisioning state of the route table resource.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.ProvisioningState) })]
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.ProvisioningState? ProvisioningState { get;  }
        /// <summary>The resource GUID property of the route table.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The resource GUID property of the route table.",
        SerializedName = @"resourceGuid",
        PossibleTypes = new [] { typeof(string) })]
        string ResourceGuid { get;  }
        /// <summary>Collection of routes contained within a route table.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Collection of routes contained within a route table.",
        SerializedName = @"routes",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IRoute) })]
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IRoute[] Route { get; set; }
        /// <summary>A collection of references to subnets.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"A collection of references to subnets.",
        SerializedName = @"subnets",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.ISubnet) })]
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.ISubnet[] Subnet { get;  }

    }
    /// Route table resource.
    internal partial interface IRouteTableInternal :
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IResourceInternal
    {
        /// <summary>
        /// Whether to disable the routes learned by BGP on that route table. True means disable.
        /// </summary>
        bool? DisableBgpRoutePropagation { get; set; }
        /// <summary>A unique read-only string that changes whenever the resource is updated.</summary>
        string Etag { get; set; }
        /// <summary>Properties of the route table.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IRouteTablePropertiesFormat Property { get; set; }
        /// <summary>The provisioning state of the route table resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.ProvisioningState? ProvisioningState { get; set; }
        /// <summary>The resource GUID property of the route table.</summary>
        string ResourceGuid { get; set; }
        /// <summary>Collection of routes contained within a route table.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IRoute[] Route { get; set; }
        /// <summary>A collection of references to subnets.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.ISubnet[] Subnet { get; set; }

    }
}