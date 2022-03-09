// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210801
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Runtime.Extensions;

    /// <summary>Request payload for Update Disk Pool request.</summary>
    public partial class DiskPoolUpdate :
        Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210801.IDiskPoolUpdate,
        Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210801.IDiskPoolUpdateInternal
    {

        /// <summary>List of Azure Managed Disks to attach to a Disk Pool.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Origin(Microsoft.Azure.PowerShell.Cmdlets.DiskPool.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210801.IDisk[] Disk { get => ((Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210801.IDiskPoolUpdatePropertiesInternal)Property).Disk; set => ((Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210801.IDiskPoolUpdatePropertiesInternal)Property).Disk = value ?? null /* arrayOf */; }

        /// <summary>Backing field for <see cref="ManagedBy" /> property.</summary>
        private string _managedBy;

        /// <summary>
        /// Azure resource id. Indicates if this resource is managed by another Azure resource.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Origin(Microsoft.Azure.PowerShell.Cmdlets.DiskPool.PropertyOrigin.Owned)]
        public string ManagedBy { get => this._managedBy; set => this._managedBy = value; }

        /// <summary>Backing field for <see cref="ManagedByExtended" /> property.</summary>
        private string[] _managedByExtended;

        /// <summary>List of Azure resource ids that manage this resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Origin(Microsoft.Azure.PowerShell.Cmdlets.DiskPool.PropertyOrigin.Owned)]
        public string[] ManagedByExtended { get => this._managedByExtended; set => this._managedByExtended = value; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210801.IDiskPoolUpdateProperties Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210801.IDiskPoolUpdateInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210801.DiskPoolUpdateProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for Sku</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210801.ISku Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210801.IDiskPoolUpdateInternal.Sku { get => (this._sku = this._sku ?? new Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210801.Sku()); set { {_sku = value;} } }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210801.IDiskPoolUpdateProperties _property;

        /// <summary>Properties for Disk Pool update request.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Origin(Microsoft.Azure.PowerShell.Cmdlets.DiskPool.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210801.IDiskPoolUpdateProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210801.DiskPoolUpdateProperties()); set => this._property = value; }

        /// <summary>Backing field for <see cref="Sku" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210801.ISku _sku;

        /// <summary>Determines the SKU of the Disk Pool</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Origin(Microsoft.Azure.PowerShell.Cmdlets.DiskPool.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210801.ISku Sku { get => (this._sku = this._sku ?? new Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210801.Sku()); set => this._sku = value; }

        /// <summary>Sku name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Origin(Microsoft.Azure.PowerShell.Cmdlets.DiskPool.PropertyOrigin.Inlined)]
        public string SkuName { get => ((Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210801.ISkuInternal)Sku).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210801.ISkuInternal)Sku).Name = value ?? null; }

        /// <summary>Sku tier</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Origin(Microsoft.Azure.PowerShell.Cmdlets.DiskPool.PropertyOrigin.Inlined)]
        public string SkuTier { get => ((Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210801.ISkuInternal)Sku).Tier; set => ((Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210801.ISkuInternal)Sku).Tier = value ?? null; }

        /// <summary>Backing field for <see cref="Tag" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210801.IDiskPoolUpdateTags _tag;

        /// <summary>Resource tags.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Origin(Microsoft.Azure.PowerShell.Cmdlets.DiskPool.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210801.IDiskPoolUpdateTags Tag { get => (this._tag = this._tag ?? new Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210801.DiskPoolUpdateTags()); set => this._tag = value; }

        /// <summary>Creates an new <see cref="DiskPoolUpdate" /> instance.</summary>
        public DiskPoolUpdate()
        {

        }
    }
    /// Request payload for Update Disk Pool request.
    public partial interface IDiskPoolUpdate :
        Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Runtime.IJsonSerializable
    {
        /// <summary>List of Azure Managed Disks to attach to a Disk Pool.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"List of Azure Managed Disks to attach to a Disk Pool.",
        SerializedName = @"disks",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210801.IDisk) })]
        Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210801.IDisk[] Disk { get; set; }
        /// <summary>
        /// Azure resource id. Indicates if this resource is managed by another Azure resource.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Azure resource id. Indicates if this resource is managed by another Azure resource.",
        SerializedName = @"managedBy",
        PossibleTypes = new [] { typeof(string) })]
        string ManagedBy { get; set; }
        /// <summary>List of Azure resource ids that manage this resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"List of Azure resource ids that manage this resource.",
        SerializedName = @"managedByExtended",
        PossibleTypes = new [] { typeof(string) })]
        string[] ManagedByExtended { get; set; }
        /// <summary>Sku name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Sku name",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string SkuName { get; set; }
        /// <summary>Sku tier</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Sku tier",
        SerializedName = @"tier",
        PossibleTypes = new [] { typeof(string) })]
        string SkuTier { get; set; }
        /// <summary>Resource tags.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Resource tags.",
        SerializedName = @"tags",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210801.IDiskPoolUpdateTags) })]
        Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210801.IDiskPoolUpdateTags Tag { get; set; }

    }
    /// Request payload for Update Disk Pool request.
    internal partial interface IDiskPoolUpdateInternal

    {
        /// <summary>List of Azure Managed Disks to attach to a Disk Pool.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210801.IDisk[] Disk { get; set; }
        /// <summary>
        /// Azure resource id. Indicates if this resource is managed by another Azure resource.
        /// </summary>
        string ManagedBy { get; set; }
        /// <summary>List of Azure resource ids that manage this resource.</summary>
        string[] ManagedByExtended { get; set; }
        /// <summary>Properties for Disk Pool update request.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210801.IDiskPoolUpdateProperties Property { get; set; }
        /// <summary>Determines the SKU of the Disk Pool</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210801.ISku Sku { get; set; }
        /// <summary>Sku name</summary>
        string SkuName { get; set; }
        /// <summary>Sku tier</summary>
        string SkuTier { get; set; }
        /// <summary>Resource tags.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210801.IDiskPoolUpdateTags Tag { get; set; }

    }
}