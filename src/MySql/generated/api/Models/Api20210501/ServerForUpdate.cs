// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501
{
    using static Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Extensions;

    /// <summary>Parameters allowed to update for a server.</summary>
    public partial class ServerForUpdate :
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerForUpdate,
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerForUpdateInternal
    {

        /// <summary>The password of the administrator login.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inlined)]
        public System.Security.SecureString AdministratorLoginPassword { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesForUpdateInternal)Property).AdministratorLoginPassword; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesForUpdateInternal)Property).AdministratorLoginPassword = value ?? null; }

        /// <summary>Earliest restore point creation time (ISO8601 format)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inlined)]
        public global::System.DateTime? BackupEarliestRestoreDate { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesForUpdateInternal)Property).BackupEarliestRestoreDate; }

        /// <summary>Whether or not geo redundant backup is enabled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.MySql.Support.EnableStatusEnum? BackupGeoRedundantBackup { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesForUpdateInternal)Property).BackupGeoRedundantBackup; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesForUpdateInternal)Property).BackupGeoRedundantBackup = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Support.EnableStatusEnum)""); }

        /// <summary>Backup retention days for the server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inlined)]
        public int? BackupRetentionDay { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesForUpdateInternal)Property).BackupRetentionDay; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesForUpdateInternal)Property).BackupRetentionDay = value ?? default(int); }

        /// <summary>High availability mode for a server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.MySql.Support.HighAvailabilityMode? HighAvailabilityMode { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesForUpdateInternal)Property).HighAvailabilityMode; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesForUpdateInternal)Property).HighAvailabilityMode = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Support.HighAvailabilityMode)""); }

        /// <summary>Availability zone of the standby server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inlined)]
        public string HighAvailabilityStandbyAvailabilityZone { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesForUpdateInternal)Property).HighAvailabilityStandbyAvailabilityZone; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesForUpdateInternal)Property).HighAvailabilityStandbyAvailabilityZone = value ?? null; }

        /// <summary>The state of server high availability.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.MySql.Support.HighAvailabilityState? HighAvailabilityState { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesForUpdateInternal)Property).HighAvailabilityState; }

        /// <summary>indicates whether custom window is enabled or disabled</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inlined)]
        public string MaintenanceWindowCustomWindow { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesForUpdateInternal)Property).MaintenanceWindowCustomWindow; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesForUpdateInternal)Property).MaintenanceWindowCustomWindow = value ?? null; }

        /// <summary>day of week for maintenance window</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inlined)]
        public int? MaintenanceWindowDayOfWeek { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesForUpdateInternal)Property).MaintenanceWindowDayOfWeek; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesForUpdateInternal)Property).MaintenanceWindowDayOfWeek = value ?? default(int); }

        /// <summary>start hour for maintenance window</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inlined)]
        public int? MaintenanceWindowStartHour { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesForUpdateInternal)Property).MaintenanceWindowStartHour; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesForUpdateInternal)Property).MaintenanceWindowStartHour = value ?? default(int); }

        /// <summary>start minute for maintenance window</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inlined)]
        public int? MaintenanceWindowStartMinute { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesForUpdateInternal)Property).MaintenanceWindowStartMinute; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesForUpdateInternal)Property).MaintenanceWindowStartMinute = value ?? default(int); }

        /// <summary>Internal Acessors for Backup</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IBackup Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerForUpdateInternal.Backup { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesForUpdateInternal)Property).Backup; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesForUpdateInternal)Property).Backup = value; }

        /// <summary>Internal Acessors for BackupEarliestRestoreDate</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerForUpdateInternal.BackupEarliestRestoreDate { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesForUpdateInternal)Property).BackupEarliestRestoreDate; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesForUpdateInternal)Property).BackupEarliestRestoreDate = value; }

        /// <summary>Internal Acessors for HighAvailability</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IHighAvailability Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerForUpdateInternal.HighAvailability { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesForUpdateInternal)Property).HighAvailability; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesForUpdateInternal)Property).HighAvailability = value; }

        /// <summary>Internal Acessors for HighAvailabilityState</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Support.HighAvailabilityState? Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerForUpdateInternal.HighAvailabilityState { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesForUpdateInternal)Property).HighAvailabilityState; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesForUpdateInternal)Property).HighAvailabilityState = value; }

        /// <summary>Internal Acessors for MaintenanceWindow</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IMaintenanceWindow Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerForUpdateInternal.MaintenanceWindow { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesForUpdateInternal)Property).MaintenanceWindow; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesForUpdateInternal)Property).MaintenanceWindow = value; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesForUpdate Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerForUpdateInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.ServerPropertiesForUpdate()); set { {_property = value;} } }

        /// <summary>Internal Acessors for Sku</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.ISkuAutoGenerated Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerForUpdateInternal.Sku { get => (this._sku = this._sku ?? new Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.SkuAutoGenerated()); set { {_sku = value;} } }

        /// <summary>Internal Acessors for Storage</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IStorage Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerForUpdateInternal.Storage { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesForUpdateInternal)Property).Storage; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesForUpdateInternal)Property).Storage = value; }

        /// <summary>Internal Acessors for StorageSku</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerForUpdateInternal.StorageSku { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesForUpdateInternal)Property).StorageSku; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesForUpdateInternal)Property).StorageSku = value; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesForUpdate _property;

        /// <summary>The properties that can be updated for a server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesForUpdate Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.ServerPropertiesForUpdate()); set => this._property = value; }

        /// <summary>The replication role of the server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.MySql.Support.ReplicationRole? ReplicationRole { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesForUpdateInternal)Property).ReplicationRole; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesForUpdateInternal)Property).ReplicationRole = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Support.ReplicationRole)""); }

        /// <summary>Backing field for <see cref="Sku" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.ISkuAutoGenerated _sku;

        /// <summary>The SKU (pricing tier) of the server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.ISkuAutoGenerated Sku { get => (this._sku = this._sku ?? new Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.SkuAutoGenerated()); set => this._sku = value; }

        /// <summary>The name of the sku, e.g. Standard_D32s_v3.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inlined)]
        public string SkuName { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.ISkuAutoGeneratedInternal)Sku).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.ISkuAutoGeneratedInternal)Sku).Name = value ?? null; }

        /// <summary>The tier of the particular SKU, e.g. GeneralPurpose.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.MySql.Support.SkuTier? SkuTier { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.ISkuAutoGeneratedInternal)Sku).Tier; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.ISkuAutoGeneratedInternal)Sku).Tier = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Support.SkuTier)""); }

        /// <summary>Enable Storage Auto Grow or not.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.MySql.Support.EnableStatusEnum? StorageAutoGrow { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesForUpdateInternal)Property).StorageAutoGrow; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesForUpdateInternal)Property).StorageAutoGrow = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Support.EnableStatusEnum)""); }

        /// <summary>Storage IOPS for a server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inlined)]
        public int? StorageIop { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesForUpdateInternal)Property).StorageIop; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesForUpdateInternal)Property).StorageIop = value ?? default(int); }

        /// <summary>Max storage size allowed for a server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inlined)]
        public int? StorageSizeGb { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesForUpdateInternal)Property).StorageSizeGb; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesForUpdateInternal)Property).StorageSizeGb = value ?? default(int); }

        /// <summary>The sku name of the server storage.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inlined)]
        public string StorageSku { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesForUpdateInternal)Property).StorageSku; }

        /// <summary>Backing field for <see cref="Tag" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerForUpdateTags _tag;

        /// <summary>Application-specific metadata in the form of key-value pairs.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerForUpdateTags Tag { get => (this._tag = this._tag ?? new Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.ServerForUpdateTags()); set => this._tag = value; }

        /// <summary>Creates an new <see cref="ServerForUpdate" /> instance.</summary>
        public ServerForUpdate()
        {

        }
    }
    /// Parameters allowed to update for a server.
    public partial interface IServerForUpdate :
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.IJsonSerializable
    {
        /// <summary>The password of the administrator login.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The password of the administrator login.",
        SerializedName = @"administratorLoginPassword",
        PossibleTypes = new [] { typeof(System.Security.SecureString) })]
        System.Security.SecureString AdministratorLoginPassword { get; set; }
        /// <summary>Earliest restore point creation time (ISO8601 format)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Earliest restore point creation time (ISO8601 format)",
        SerializedName = @"earliestRestoreDate",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? BackupEarliestRestoreDate { get;  }
        /// <summary>Whether or not geo redundant backup is enabled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Whether or not geo redundant backup is enabled.",
        SerializedName = @"geoRedundantBackup",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.MySql.Support.EnableStatusEnum) })]
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Support.EnableStatusEnum? BackupGeoRedundantBackup { get; set; }
        /// <summary>Backup retention days for the server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Backup retention days for the server.",
        SerializedName = @"backupRetentionDays",
        PossibleTypes = new [] { typeof(int) })]
        int? BackupRetentionDay { get; set; }
        /// <summary>High availability mode for a server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"High availability mode for a server.",
        SerializedName = @"mode",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.MySql.Support.HighAvailabilityMode) })]
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Support.HighAvailabilityMode? HighAvailabilityMode { get; set; }
        /// <summary>Availability zone of the standby server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Availability zone of the standby server.",
        SerializedName = @"standbyAvailabilityZone",
        PossibleTypes = new [] { typeof(string) })]
        string HighAvailabilityStandbyAvailabilityZone { get; set; }
        /// <summary>The state of server high availability.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The state of server high availability.",
        SerializedName = @"state",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.MySql.Support.HighAvailabilityState) })]
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Support.HighAvailabilityState? HighAvailabilityState { get;  }
        /// <summary>indicates whether custom window is enabled or disabled</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"indicates whether custom window is enabled or disabled",
        SerializedName = @"customWindow",
        PossibleTypes = new [] { typeof(string) })]
        string MaintenanceWindowCustomWindow { get; set; }
        /// <summary>day of week for maintenance window</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"day of week for maintenance window",
        SerializedName = @"dayOfWeek",
        PossibleTypes = new [] { typeof(int) })]
        int? MaintenanceWindowDayOfWeek { get; set; }
        /// <summary>start hour for maintenance window</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"start hour for maintenance window",
        SerializedName = @"startHour",
        PossibleTypes = new [] { typeof(int) })]
        int? MaintenanceWindowStartHour { get; set; }
        /// <summary>start minute for maintenance window</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"start minute for maintenance window",
        SerializedName = @"startMinute",
        PossibleTypes = new [] { typeof(int) })]
        int? MaintenanceWindowStartMinute { get; set; }
        /// <summary>The replication role of the server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The replication role of the server.",
        SerializedName = @"replicationRole",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.MySql.Support.ReplicationRole) })]
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Support.ReplicationRole? ReplicationRole { get; set; }
        /// <summary>The name of the sku, e.g. Standard_D32s_v3.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The name of the sku, e.g. Standard_D32s_v3.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string SkuName { get; set; }
        /// <summary>The tier of the particular SKU, e.g. GeneralPurpose.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The tier of the particular SKU, e.g. GeneralPurpose.",
        SerializedName = @"tier",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.MySql.Support.SkuTier) })]
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Support.SkuTier? SkuTier { get; set; }
        /// <summary>Enable Storage Auto Grow or not.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Enable Storage Auto Grow or not.",
        SerializedName = @"autoGrow",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.MySql.Support.EnableStatusEnum) })]
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Support.EnableStatusEnum? StorageAutoGrow { get; set; }
        /// <summary>Storage IOPS for a server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Storage IOPS for a server.",
        SerializedName = @"iops",
        PossibleTypes = new [] { typeof(int) })]
        int? StorageIop { get; set; }
        /// <summary>Max storage size allowed for a server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Max storage size allowed for a server.",
        SerializedName = @"storageSizeGB",
        PossibleTypes = new [] { typeof(int) })]
        int? StorageSizeGb { get; set; }
        /// <summary>The sku name of the server storage.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The sku name of the server storage.",
        SerializedName = @"storageSku",
        PossibleTypes = new [] { typeof(string) })]
        string StorageSku { get;  }
        /// <summary>Application-specific metadata in the form of key-value pairs.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Application-specific metadata in the form of key-value pairs.",
        SerializedName = @"tags",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerForUpdateTags) })]
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerForUpdateTags Tag { get; set; }

    }
    /// Parameters allowed to update for a server.
    internal partial interface IServerForUpdateInternal

    {
        /// <summary>The password of the administrator login.</summary>
        System.Security.SecureString AdministratorLoginPassword { get; set; }
        /// <summary>Backup related properties of a server.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IBackup Backup { get; set; }
        /// <summary>Earliest restore point creation time (ISO8601 format)</summary>
        global::System.DateTime? BackupEarliestRestoreDate { get; set; }
        /// <summary>Whether or not geo redundant backup is enabled.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Support.EnableStatusEnum? BackupGeoRedundantBackup { get; set; }
        /// <summary>Backup retention days for the server.</summary>
        int? BackupRetentionDay { get; set; }
        /// <summary>High availability related properties of a server.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IHighAvailability HighAvailability { get; set; }
        /// <summary>High availability mode for a server.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Support.HighAvailabilityMode? HighAvailabilityMode { get; set; }
        /// <summary>Availability zone of the standby server.</summary>
        string HighAvailabilityStandbyAvailabilityZone { get; set; }
        /// <summary>The state of server high availability.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Support.HighAvailabilityState? HighAvailabilityState { get; set; }
        /// <summary>Maintenance window of a server.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IMaintenanceWindow MaintenanceWindow { get; set; }
        /// <summary>indicates whether custom window is enabled or disabled</summary>
        string MaintenanceWindowCustomWindow { get; set; }
        /// <summary>day of week for maintenance window</summary>
        int? MaintenanceWindowDayOfWeek { get; set; }
        /// <summary>start hour for maintenance window</summary>
        int? MaintenanceWindowStartHour { get; set; }
        /// <summary>start minute for maintenance window</summary>
        int? MaintenanceWindowStartMinute { get; set; }
        /// <summary>The properties that can be updated for a server.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesForUpdate Property { get; set; }
        /// <summary>The replication role of the server.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Support.ReplicationRole? ReplicationRole { get; set; }
        /// <summary>The SKU (pricing tier) of the server.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.ISkuAutoGenerated Sku { get; set; }
        /// <summary>The name of the sku, e.g. Standard_D32s_v3.</summary>
        string SkuName { get; set; }
        /// <summary>The tier of the particular SKU, e.g. GeneralPurpose.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Support.SkuTier? SkuTier { get; set; }
        /// <summary>Storage related properties of a server.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IStorage Storage { get; set; }
        /// <summary>Enable Storage Auto Grow or not.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Support.EnableStatusEnum? StorageAutoGrow { get; set; }
        /// <summary>Storage IOPS for a server.</summary>
        int? StorageIop { get; set; }
        /// <summary>Max storage size allowed for a server.</summary>
        int? StorageSizeGb { get; set; }
        /// <summary>The sku name of the server storage.</summary>
        string StorageSku { get; set; }
        /// <summary>Application-specific metadata in the form of key-value pairs.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerForUpdateTags Tag { get; set; }

    }
}