// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210801
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Runtime.Extensions;

    /// <summary>Resource SKU Details</summary>
    public partial class ResourceSkuInfo :
        Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210801.IResourceSkuInfo,
        Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210801.IResourceSkuInfoInternal
    {

        /// <summary>Backing field for <see cref="ApiVersion" /> property.</summary>
        private string _apiVersion;

        /// <summary>StoragePool RP API version</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Origin(Microsoft.Azure.PowerShell.Cmdlets.DiskPool.PropertyOrigin.Owned)]
        public string ApiVersion { get => this._apiVersion; }

        /// <summary>Backing field for <see cref="Capability" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210801.IResourceSkuCapability[] _capability;

        /// <summary>List of additional capabilities for StoragePool resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Origin(Microsoft.Azure.PowerShell.Cmdlets.DiskPool.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210801.IResourceSkuCapability[] Capability { get => this._capability; }

        /// <summary>Backing field for <see cref="LocationInfo" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210801.IResourceSkuLocationInfo _locationInfo;

        /// <summary>Zones and zone capabilities in those locations where the SKU is available.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Origin(Microsoft.Azure.PowerShell.Cmdlets.DiskPool.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210801.IResourceSkuLocationInfo LocationInfo { get => (this._locationInfo = this._locationInfo ?? new Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210801.ResourceSkuLocationInfo()); }

        /// <summary>Location of the SKU</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Origin(Microsoft.Azure.PowerShell.Cmdlets.DiskPool.PropertyOrigin.Inlined)]
        public string LocationInfoLocation { get => ((Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210801.IResourceSkuLocationInfoInternal)LocationInfo).Location; }

        /// <summary>List of availability zones where the SKU is supported.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Origin(Microsoft.Azure.PowerShell.Cmdlets.DiskPool.PropertyOrigin.Inlined)]
        public string[] LocationInfoZone { get => ((Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210801.IResourceSkuLocationInfoInternal)LocationInfo).Zone; }

        /// <summary>Details of capabilities available to a SKU in specific zones.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Origin(Microsoft.Azure.PowerShell.Cmdlets.DiskPool.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210801.IResourceSkuZoneDetails[] LocationInfoZoneDetail { get => ((Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210801.IResourceSkuLocationInfoInternal)LocationInfo).ZoneDetail; }

        /// <summary>Internal Acessors for ApiVersion</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210801.IResourceSkuInfoInternal.ApiVersion { get => this._apiVersion; set { {_apiVersion = value;} } }

        /// <summary>Internal Acessors for Capability</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210801.IResourceSkuCapability[] Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210801.IResourceSkuInfoInternal.Capability { get => this._capability; set { {_capability = value;} } }

        /// <summary>Internal Acessors for LocationInfo</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210801.IResourceSkuLocationInfo Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210801.IResourceSkuInfoInternal.LocationInfo { get => (this._locationInfo = this._locationInfo ?? new Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210801.ResourceSkuLocationInfo()); set { {_locationInfo = value;} } }

        /// <summary>Internal Acessors for LocationInfoLocation</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210801.IResourceSkuInfoInternal.LocationInfoLocation { get => ((Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210801.IResourceSkuLocationInfoInternal)LocationInfo).Location; set => ((Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210801.IResourceSkuLocationInfoInternal)LocationInfo).Location = value; }

        /// <summary>Internal Acessors for LocationInfoZone</summary>
        string[] Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210801.IResourceSkuInfoInternal.LocationInfoZone { get => ((Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210801.IResourceSkuLocationInfoInternal)LocationInfo).Zone; set => ((Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210801.IResourceSkuLocationInfoInternal)LocationInfo).Zone = value; }

        /// <summary>Internal Acessors for LocationInfoZoneDetail</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210801.IResourceSkuZoneDetails[] Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210801.IResourceSkuInfoInternal.LocationInfoZoneDetail { get => ((Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210801.IResourceSkuLocationInfoInternal)LocationInfo).ZoneDetail; set => ((Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210801.IResourceSkuLocationInfoInternal)LocationInfo).ZoneDetail = value; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210801.IResourceSkuInfoInternal.Name { get => this._name; set { {_name = value;} } }

        /// <summary>Internal Acessors for ResourceType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210801.IResourceSkuInfoInternal.ResourceType { get => this._resourceType; set { {_resourceType = value;} } }

        /// <summary>Internal Acessors for Restriction</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210801.IResourceSkuRestrictions[] Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210801.IResourceSkuInfoInternal.Restriction { get => this._restriction; set { {_restriction = value;} } }

        /// <summary>Internal Acessors for Tier</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210801.IResourceSkuInfoInternal.Tier { get => this._tier; set { {_tier = value;} } }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>Sku name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Origin(Microsoft.Azure.PowerShell.Cmdlets.DiskPool.PropertyOrigin.Owned)]
        public string Name { get => this._name; }

        /// <summary>Backing field for <see cref="ResourceType" /> property.</summary>
        private string _resourceType;

        /// <summary>StoragePool resource type</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Origin(Microsoft.Azure.PowerShell.Cmdlets.DiskPool.PropertyOrigin.Owned)]
        public string ResourceType { get => this._resourceType; }

        /// <summary>Backing field for <see cref="Restriction" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210801.IResourceSkuRestrictions[] _restriction;

        /// <summary>
        /// The restrictions because of which SKU cannot be used. This is empty if there are no restrictions.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Origin(Microsoft.Azure.PowerShell.Cmdlets.DiskPool.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210801.IResourceSkuRestrictions[] Restriction { get => this._restriction; }

        /// <summary>Backing field for <see cref="Tier" /> property.</summary>
        private string _tier;

        /// <summary>Sku tier</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Origin(Microsoft.Azure.PowerShell.Cmdlets.DiskPool.PropertyOrigin.Owned)]
        public string Tier { get => this._tier; }

        /// <summary>Creates an new <see cref="ResourceSkuInfo" /> instance.</summary>
        public ResourceSkuInfo()
        {

        }
    }
    /// Resource SKU Details
    public partial interface IResourceSkuInfo :
        Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Runtime.IJsonSerializable
    {
        /// <summary>StoragePool RP API version</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"StoragePool RP API version",
        SerializedName = @"apiVersion",
        PossibleTypes = new [] { typeof(string) })]
        string ApiVersion { get;  }
        /// <summary>List of additional capabilities for StoragePool resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"List of additional capabilities for StoragePool resource.",
        SerializedName = @"capabilities",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210801.IResourceSkuCapability) })]
        Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210801.IResourceSkuCapability[] Capability { get;  }
        /// <summary>Location of the SKU</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Location of the SKU",
        SerializedName = @"location",
        PossibleTypes = new [] { typeof(string) })]
        string LocationInfoLocation { get;  }
        /// <summary>List of availability zones where the SKU is supported.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"List of availability zones where the SKU is supported.",
        SerializedName = @"zones",
        PossibleTypes = new [] { typeof(string) })]
        string[] LocationInfoZone { get;  }
        /// <summary>Details of capabilities available to a SKU in specific zones.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Details of capabilities available to a SKU in specific zones.",
        SerializedName = @"zoneDetails",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210801.IResourceSkuZoneDetails) })]
        Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210801.IResourceSkuZoneDetails[] LocationInfoZoneDetail { get;  }
        /// <summary>Sku name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Sku name",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get;  }
        /// <summary>StoragePool resource type</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"StoragePool resource type",
        SerializedName = @"resourceType",
        PossibleTypes = new [] { typeof(string) })]
        string ResourceType { get;  }
        /// <summary>
        /// The restrictions because of which SKU cannot be used. This is empty if there are no restrictions.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The restrictions because of which SKU cannot be used. This is empty if there are no restrictions.",
        SerializedName = @"restrictions",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210801.IResourceSkuRestrictions) })]
        Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210801.IResourceSkuRestrictions[] Restriction { get;  }
        /// <summary>Sku tier</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Sku tier",
        SerializedName = @"tier",
        PossibleTypes = new [] { typeof(string) })]
        string Tier { get;  }

    }
    /// Resource SKU Details
    internal partial interface IResourceSkuInfoInternal

    {
        /// <summary>StoragePool RP API version</summary>
        string ApiVersion { get; set; }
        /// <summary>List of additional capabilities for StoragePool resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210801.IResourceSkuCapability[] Capability { get; set; }
        /// <summary>Zones and zone capabilities in those locations where the SKU is available.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210801.IResourceSkuLocationInfo LocationInfo { get; set; }
        /// <summary>Location of the SKU</summary>
        string LocationInfoLocation { get; set; }
        /// <summary>List of availability zones where the SKU is supported.</summary>
        string[] LocationInfoZone { get; set; }
        /// <summary>Details of capabilities available to a SKU in specific zones.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210801.IResourceSkuZoneDetails[] LocationInfoZoneDetail { get; set; }
        /// <summary>Sku name</summary>
        string Name { get; set; }
        /// <summary>StoragePool resource type</summary>
        string ResourceType { get; set; }
        /// <summary>
        /// The restrictions because of which SKU cannot be used. This is empty if there are no restrictions.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210801.IResourceSkuRestrictions[] Restriction { get; set; }
        /// <summary>Sku tier</summary>
        string Tier { get; set; }

    }
}