// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501
{
    using Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.PowerShell;

    /// <summary>The properties that can be updated for a server.</summary>
    [System.ComponentModel.TypeConverter(typeof(ServerPropertiesForUpdateTypeConverter))]
    public partial class ServerPropertiesForUpdate
    {

        /// <summary>
        /// <c>AfterDeserializeDictionary</c> will be called after the deserialization has finished, allowing customization of the
        /// object before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>

        partial void AfterDeserializeDictionary(global::System.Collections.IDictionary content);

        /// <summary>
        /// <c>AfterDeserializePSObject</c> will be called after the deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>

        partial void AfterDeserializePSObject(global::System.Management.Automation.PSObject content);

        /// <summary>
        /// <c>BeforeDeserializeDictionary</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.ServerPropertiesForUpdate"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesForUpdate" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesForUpdate DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new ServerPropertiesForUpdate(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.ServerPropertiesForUpdate"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesForUpdate" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesForUpdate DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new ServerPropertiesForUpdate(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="ServerPropertiesForUpdate" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesForUpdate FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.ServerPropertiesForUpdate"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal ServerPropertiesForUpdate(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Storage"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesForUpdateInternal)this).Storage = (Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IStorage) content.GetValueForProperty("Storage",((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesForUpdateInternal)this).Storage, Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.StorageTypeConverter.ConvertFrom);
            }
            if (content.Contains("Backup"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesForUpdateInternal)this).Backup = (Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IBackup) content.GetValueForProperty("Backup",((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesForUpdateInternal)this).Backup, Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.BackupTypeConverter.ConvertFrom);
            }
            if (content.Contains("HighAvailability"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesForUpdateInternal)this).HighAvailability = (Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IHighAvailability) content.GetValueForProperty("HighAvailability",((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesForUpdateInternal)this).HighAvailability, Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.HighAvailabilityTypeConverter.ConvertFrom);
            }
            if (content.Contains("MaintenanceWindow"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesForUpdateInternal)this).MaintenanceWindow = (Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IMaintenanceWindow) content.GetValueForProperty("MaintenanceWindow",((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesForUpdateInternal)this).MaintenanceWindow, Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.MaintenanceWindowTypeConverter.ConvertFrom);
            }
            if (content.Contains("AdministratorLoginPassword"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesForUpdateInternal)this).AdministratorLoginPassword = (System.Security.SecureString) content.GetValueForProperty("AdministratorLoginPassword",((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesForUpdateInternal)this).AdministratorLoginPassword, (object ss) => (System.Security.SecureString)ss);
            }
            if (content.Contains("ReplicationRole"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesForUpdateInternal)this).ReplicationRole = (Microsoft.Azure.PowerShell.Cmdlets.MySql.Support.ReplicationRole?) content.GetValueForProperty("ReplicationRole",((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesForUpdateInternal)this).ReplicationRole, Microsoft.Azure.PowerShell.Cmdlets.MySql.Support.ReplicationRole.CreateFrom);
            }
            if (content.Contains("StorageIop"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesForUpdateInternal)this).StorageIop = (int?) content.GetValueForProperty("StorageIop",((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesForUpdateInternal)this).StorageIop, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("StorageSku"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesForUpdateInternal)this).StorageSku = (string) content.GetValueForProperty("StorageSku",((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesForUpdateInternal)this).StorageSku, global::System.Convert.ToString);
            }
            if (content.Contains("HighAvailabilityMode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesForUpdateInternal)this).HighAvailabilityMode = (Microsoft.Azure.PowerShell.Cmdlets.MySql.Support.HighAvailabilityMode?) content.GetValueForProperty("HighAvailabilityMode",((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesForUpdateInternal)this).HighAvailabilityMode, Microsoft.Azure.PowerShell.Cmdlets.MySql.Support.HighAvailabilityMode.CreateFrom);
            }
            if (content.Contains("HighAvailabilityState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesForUpdateInternal)this).HighAvailabilityState = (Microsoft.Azure.PowerShell.Cmdlets.MySql.Support.HighAvailabilityState?) content.GetValueForProperty("HighAvailabilityState",((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesForUpdateInternal)this).HighAvailabilityState, Microsoft.Azure.PowerShell.Cmdlets.MySql.Support.HighAvailabilityState.CreateFrom);
            }
            if (content.Contains("MaintenanceWindowCustomWindow"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesForUpdateInternal)this).MaintenanceWindowCustomWindow = (string) content.GetValueForProperty("MaintenanceWindowCustomWindow",((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesForUpdateInternal)this).MaintenanceWindowCustomWindow, global::System.Convert.ToString);
            }
            if (content.Contains("MaintenanceWindowStartHour"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesForUpdateInternal)this).MaintenanceWindowStartHour = (int?) content.GetValueForProperty("MaintenanceWindowStartHour",((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesForUpdateInternal)this).MaintenanceWindowStartHour, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("MaintenanceWindowStartMinute"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesForUpdateInternal)this).MaintenanceWindowStartMinute = (int?) content.GetValueForProperty("MaintenanceWindowStartMinute",((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesForUpdateInternal)this).MaintenanceWindowStartMinute, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("StorageSizeGb"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesForUpdateInternal)this).StorageSizeGb = (int?) content.GetValueForProperty("StorageSizeGb",((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesForUpdateInternal)this).StorageSizeGb, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("StorageAutoGrow"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesForUpdateInternal)this).StorageAutoGrow = (Microsoft.Azure.PowerShell.Cmdlets.MySql.Support.EnableStatusEnum?) content.GetValueForProperty("StorageAutoGrow",((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesForUpdateInternal)this).StorageAutoGrow, Microsoft.Azure.PowerShell.Cmdlets.MySql.Support.EnableStatusEnum.CreateFrom);
            }
            if (content.Contains("BackupRetentionDay"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesForUpdateInternal)this).BackupRetentionDay = (int?) content.GetValueForProperty("BackupRetentionDay",((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesForUpdateInternal)this).BackupRetentionDay, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("BackupGeoRedundantBackup"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesForUpdateInternal)this).BackupGeoRedundantBackup = (Microsoft.Azure.PowerShell.Cmdlets.MySql.Support.EnableStatusEnum?) content.GetValueForProperty("BackupGeoRedundantBackup",((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesForUpdateInternal)this).BackupGeoRedundantBackup, Microsoft.Azure.PowerShell.Cmdlets.MySql.Support.EnableStatusEnum.CreateFrom);
            }
            if (content.Contains("BackupEarliestRestoreDate"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesForUpdateInternal)this).BackupEarliestRestoreDate = (global::System.DateTime?) content.GetValueForProperty("BackupEarliestRestoreDate",((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesForUpdateInternal)this).BackupEarliestRestoreDate, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("HighAvailabilityStandbyAvailabilityZone"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesForUpdateInternal)this).HighAvailabilityStandbyAvailabilityZone = (string) content.GetValueForProperty("HighAvailabilityStandbyAvailabilityZone",((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesForUpdateInternal)this).HighAvailabilityStandbyAvailabilityZone, global::System.Convert.ToString);
            }
            if (content.Contains("MaintenanceWindowDayOfWeek"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesForUpdateInternal)this).MaintenanceWindowDayOfWeek = (int?) content.GetValueForProperty("MaintenanceWindowDayOfWeek",((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesForUpdateInternal)this).MaintenanceWindowDayOfWeek, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.ServerPropertiesForUpdate"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal ServerPropertiesForUpdate(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Storage"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesForUpdateInternal)this).Storage = (Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IStorage) content.GetValueForProperty("Storage",((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesForUpdateInternal)this).Storage, Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.StorageTypeConverter.ConvertFrom);
            }
            if (content.Contains("Backup"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesForUpdateInternal)this).Backup = (Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IBackup) content.GetValueForProperty("Backup",((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesForUpdateInternal)this).Backup, Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.BackupTypeConverter.ConvertFrom);
            }
            if (content.Contains("HighAvailability"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesForUpdateInternal)this).HighAvailability = (Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IHighAvailability) content.GetValueForProperty("HighAvailability",((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesForUpdateInternal)this).HighAvailability, Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.HighAvailabilityTypeConverter.ConvertFrom);
            }
            if (content.Contains("MaintenanceWindow"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesForUpdateInternal)this).MaintenanceWindow = (Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IMaintenanceWindow) content.GetValueForProperty("MaintenanceWindow",((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesForUpdateInternal)this).MaintenanceWindow, Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.MaintenanceWindowTypeConverter.ConvertFrom);
            }
            if (content.Contains("AdministratorLoginPassword"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesForUpdateInternal)this).AdministratorLoginPassword = (System.Security.SecureString) content.GetValueForProperty("AdministratorLoginPassword",((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesForUpdateInternal)this).AdministratorLoginPassword, (object ss) => (System.Security.SecureString)ss);
            }
            if (content.Contains("ReplicationRole"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesForUpdateInternal)this).ReplicationRole = (Microsoft.Azure.PowerShell.Cmdlets.MySql.Support.ReplicationRole?) content.GetValueForProperty("ReplicationRole",((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesForUpdateInternal)this).ReplicationRole, Microsoft.Azure.PowerShell.Cmdlets.MySql.Support.ReplicationRole.CreateFrom);
            }
            if (content.Contains("StorageIop"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesForUpdateInternal)this).StorageIop = (int?) content.GetValueForProperty("StorageIop",((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesForUpdateInternal)this).StorageIop, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("StorageSku"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesForUpdateInternal)this).StorageSku = (string) content.GetValueForProperty("StorageSku",((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesForUpdateInternal)this).StorageSku, global::System.Convert.ToString);
            }
            if (content.Contains("HighAvailabilityMode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesForUpdateInternal)this).HighAvailabilityMode = (Microsoft.Azure.PowerShell.Cmdlets.MySql.Support.HighAvailabilityMode?) content.GetValueForProperty("HighAvailabilityMode",((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesForUpdateInternal)this).HighAvailabilityMode, Microsoft.Azure.PowerShell.Cmdlets.MySql.Support.HighAvailabilityMode.CreateFrom);
            }
            if (content.Contains("HighAvailabilityState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesForUpdateInternal)this).HighAvailabilityState = (Microsoft.Azure.PowerShell.Cmdlets.MySql.Support.HighAvailabilityState?) content.GetValueForProperty("HighAvailabilityState",((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesForUpdateInternal)this).HighAvailabilityState, Microsoft.Azure.PowerShell.Cmdlets.MySql.Support.HighAvailabilityState.CreateFrom);
            }
            if (content.Contains("MaintenanceWindowCustomWindow"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesForUpdateInternal)this).MaintenanceWindowCustomWindow = (string) content.GetValueForProperty("MaintenanceWindowCustomWindow",((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesForUpdateInternal)this).MaintenanceWindowCustomWindow, global::System.Convert.ToString);
            }
            if (content.Contains("MaintenanceWindowStartHour"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesForUpdateInternal)this).MaintenanceWindowStartHour = (int?) content.GetValueForProperty("MaintenanceWindowStartHour",((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesForUpdateInternal)this).MaintenanceWindowStartHour, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("MaintenanceWindowStartMinute"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesForUpdateInternal)this).MaintenanceWindowStartMinute = (int?) content.GetValueForProperty("MaintenanceWindowStartMinute",((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesForUpdateInternal)this).MaintenanceWindowStartMinute, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("StorageSizeGb"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesForUpdateInternal)this).StorageSizeGb = (int?) content.GetValueForProperty("StorageSizeGb",((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesForUpdateInternal)this).StorageSizeGb, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("StorageAutoGrow"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesForUpdateInternal)this).StorageAutoGrow = (Microsoft.Azure.PowerShell.Cmdlets.MySql.Support.EnableStatusEnum?) content.GetValueForProperty("StorageAutoGrow",((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesForUpdateInternal)this).StorageAutoGrow, Microsoft.Azure.PowerShell.Cmdlets.MySql.Support.EnableStatusEnum.CreateFrom);
            }
            if (content.Contains("BackupRetentionDay"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesForUpdateInternal)this).BackupRetentionDay = (int?) content.GetValueForProperty("BackupRetentionDay",((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesForUpdateInternal)this).BackupRetentionDay, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("BackupGeoRedundantBackup"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesForUpdateInternal)this).BackupGeoRedundantBackup = (Microsoft.Azure.PowerShell.Cmdlets.MySql.Support.EnableStatusEnum?) content.GetValueForProperty("BackupGeoRedundantBackup",((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesForUpdateInternal)this).BackupGeoRedundantBackup, Microsoft.Azure.PowerShell.Cmdlets.MySql.Support.EnableStatusEnum.CreateFrom);
            }
            if (content.Contains("BackupEarliestRestoreDate"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesForUpdateInternal)this).BackupEarliestRestoreDate = (global::System.DateTime?) content.GetValueForProperty("BackupEarliestRestoreDate",((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesForUpdateInternal)this).BackupEarliestRestoreDate, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("HighAvailabilityStandbyAvailabilityZone"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesForUpdateInternal)this).HighAvailabilityStandbyAvailabilityZone = (string) content.GetValueForProperty("HighAvailabilityStandbyAvailabilityZone",((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesForUpdateInternal)this).HighAvailabilityStandbyAvailabilityZone, global::System.Convert.ToString);
            }
            if (content.Contains("MaintenanceWindowDayOfWeek"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesForUpdateInternal)this).MaintenanceWindowDayOfWeek = (int?) content.GetValueForProperty("MaintenanceWindowDayOfWeek",((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerPropertiesForUpdateInternal)this).MaintenanceWindowDayOfWeek, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// The properties that can be updated for a server.
    [System.ComponentModel.TypeConverter(typeof(ServerPropertiesForUpdateTypeConverter))]
    public partial interface IServerPropertiesForUpdate

    {

    }
}