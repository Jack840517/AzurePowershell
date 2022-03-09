// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210
{
    using Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.PowerShell;

    /// <summary>Process server details.</summary>
    [System.ComponentModel.TypeConverter(typeof(ProcessServerDetailsTypeConverter))]
    public partial class ProcessServerDetails
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ProcessServerDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IProcessServerDetails" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IProcessServerDetails DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new ProcessServerDetails(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ProcessServerDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IProcessServerDetails" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IProcessServerDetails DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new ProcessServerDetails(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="ProcessServerDetails" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IProcessServerDetails FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ProcessServerDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal ProcessServerDetails(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IProcessServerDetailsInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IProcessServerDetailsInternal)this).Id, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IProcessServerDetailsInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IProcessServerDetailsInternal)this).Name, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IProcessServerDetailsInternal)this).BiosId = (string) content.GetValueForProperty("BiosId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IProcessServerDetailsInternal)this).BiosId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IProcessServerDetailsInternal)this).FabricObjectId = (string) content.GetValueForProperty("FabricObjectId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IProcessServerDetailsInternal)this).FabricObjectId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IProcessServerDetailsInternal)this).Fqdn = (string) content.GetValueForProperty("Fqdn",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IProcessServerDetailsInternal)this).Fqdn, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IProcessServerDetailsInternal)this).Version = (string) content.GetValueForProperty("Version",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IProcessServerDetailsInternal)this).Version, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IProcessServerDetailsInternal)this).LastHeartbeatUtc = (global::System.DateTime?) content.GetValueForProperty("LastHeartbeatUtc",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IProcessServerDetailsInternal)this).LastHeartbeatUtc, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IProcessServerDetailsInternal)this).TotalMemoryInByte = (long?) content.GetValueForProperty("TotalMemoryInByte",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IProcessServerDetailsInternal)this).TotalMemoryInByte, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IProcessServerDetailsInternal)this).AvailableMemoryInByte = (long?) content.GetValueForProperty("AvailableMemoryInByte",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IProcessServerDetailsInternal)this).AvailableMemoryInByte, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IProcessServerDetailsInternal)this).UsedMemoryInByte = (long?) content.GetValueForProperty("UsedMemoryInByte",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IProcessServerDetailsInternal)this).UsedMemoryInByte, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IProcessServerDetailsInternal)this).MemoryUsagePercentage = (double?) content.GetValueForProperty("MemoryUsagePercentage",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IProcessServerDetailsInternal)this).MemoryUsagePercentage, (__y)=> (double) global::System.Convert.ChangeType(__y, typeof(double)));
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IProcessServerDetailsInternal)this).TotalSpaceInByte = (long?) content.GetValueForProperty("TotalSpaceInByte",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IProcessServerDetailsInternal)this).TotalSpaceInByte, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IProcessServerDetailsInternal)this).AvailableSpaceInByte = (long?) content.GetValueForProperty("AvailableSpaceInByte",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IProcessServerDetailsInternal)this).AvailableSpaceInByte, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IProcessServerDetailsInternal)this).UsedSpaceInByte = (long?) content.GetValueForProperty("UsedSpaceInByte",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IProcessServerDetailsInternal)this).UsedSpaceInByte, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IProcessServerDetailsInternal)this).FreeSpacePercentage = (double?) content.GetValueForProperty("FreeSpacePercentage",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IProcessServerDetailsInternal)this).FreeSpacePercentage, (__y)=> (double) global::System.Convert.ChangeType(__y, typeof(double)));
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IProcessServerDetailsInternal)this).ThroughputUploadPendingDataInByte = (long?) content.GetValueForProperty("ThroughputUploadPendingDataInByte",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IProcessServerDetailsInternal)this).ThroughputUploadPendingDataInByte, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IProcessServerDetailsInternal)this).ThroughputInByte = (long?) content.GetValueForProperty("ThroughputInByte",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IProcessServerDetailsInternal)this).ThroughputInByte, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IProcessServerDetailsInternal)this).ProcessorUsagePercentage = (double?) content.GetValueForProperty("ProcessorUsagePercentage",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IProcessServerDetailsInternal)this).ProcessorUsagePercentage, (__y)=> (double) global::System.Convert.ChangeType(__y, typeof(double)));
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IProcessServerDetailsInternal)this).ThroughputStatus = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.RcmComponentStatus?) content.GetValueForProperty("ThroughputStatus",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IProcessServerDetailsInternal)this).ThroughputStatus, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.RcmComponentStatus.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IProcessServerDetailsInternal)this).SystemLoad = (long?) content.GetValueForProperty("SystemLoad",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IProcessServerDetailsInternal)this).SystemLoad, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IProcessServerDetailsInternal)this).SystemLoadStatus = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.RcmComponentStatus?) content.GetValueForProperty("SystemLoadStatus",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IProcessServerDetailsInternal)this).SystemLoadStatus, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.RcmComponentStatus.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IProcessServerDetailsInternal)this).DiskUsageStatus = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.RcmComponentStatus?) content.GetValueForProperty("DiskUsageStatus",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IProcessServerDetailsInternal)this).DiskUsageStatus, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.RcmComponentStatus.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IProcessServerDetailsInternal)this).MemoryUsageStatus = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.RcmComponentStatus?) content.GetValueForProperty("MemoryUsageStatus",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IProcessServerDetailsInternal)this).MemoryUsageStatus, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.RcmComponentStatus.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IProcessServerDetailsInternal)this).ProcessorUsageStatus = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.RcmComponentStatus?) content.GetValueForProperty("ProcessorUsageStatus",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IProcessServerDetailsInternal)this).ProcessorUsageStatus, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.RcmComponentStatus.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IProcessServerDetailsInternal)this).Health = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.ProtectionHealth?) content.GetValueForProperty("Health",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IProcessServerDetailsInternal)this).Health, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.ProtectionHealth.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IProcessServerDetailsInternal)this).HealthError = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IHealthError[]) content.GetValueForProperty("HealthError",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IProcessServerDetailsInternal)this).HealthError, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IHealthError>(__y, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.HealthErrorTypeConverter.ConvertFrom));
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IProcessServerDetailsInternal)this).HistoricHealth = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.ProtectionHealth?) content.GetValueForProperty("HistoricHealth",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IProcessServerDetailsInternal)this).HistoricHealth, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.ProtectionHealth.CreateFrom);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ProcessServerDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal ProcessServerDetails(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IProcessServerDetailsInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IProcessServerDetailsInternal)this).Id, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IProcessServerDetailsInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IProcessServerDetailsInternal)this).Name, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IProcessServerDetailsInternal)this).BiosId = (string) content.GetValueForProperty("BiosId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IProcessServerDetailsInternal)this).BiosId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IProcessServerDetailsInternal)this).FabricObjectId = (string) content.GetValueForProperty("FabricObjectId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IProcessServerDetailsInternal)this).FabricObjectId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IProcessServerDetailsInternal)this).Fqdn = (string) content.GetValueForProperty("Fqdn",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IProcessServerDetailsInternal)this).Fqdn, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IProcessServerDetailsInternal)this).Version = (string) content.GetValueForProperty("Version",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IProcessServerDetailsInternal)this).Version, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IProcessServerDetailsInternal)this).LastHeartbeatUtc = (global::System.DateTime?) content.GetValueForProperty("LastHeartbeatUtc",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IProcessServerDetailsInternal)this).LastHeartbeatUtc, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IProcessServerDetailsInternal)this).TotalMemoryInByte = (long?) content.GetValueForProperty("TotalMemoryInByte",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IProcessServerDetailsInternal)this).TotalMemoryInByte, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IProcessServerDetailsInternal)this).AvailableMemoryInByte = (long?) content.GetValueForProperty("AvailableMemoryInByte",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IProcessServerDetailsInternal)this).AvailableMemoryInByte, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IProcessServerDetailsInternal)this).UsedMemoryInByte = (long?) content.GetValueForProperty("UsedMemoryInByte",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IProcessServerDetailsInternal)this).UsedMemoryInByte, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IProcessServerDetailsInternal)this).MemoryUsagePercentage = (double?) content.GetValueForProperty("MemoryUsagePercentage",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IProcessServerDetailsInternal)this).MemoryUsagePercentage, (__y)=> (double) global::System.Convert.ChangeType(__y, typeof(double)));
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IProcessServerDetailsInternal)this).TotalSpaceInByte = (long?) content.GetValueForProperty("TotalSpaceInByte",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IProcessServerDetailsInternal)this).TotalSpaceInByte, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IProcessServerDetailsInternal)this).AvailableSpaceInByte = (long?) content.GetValueForProperty("AvailableSpaceInByte",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IProcessServerDetailsInternal)this).AvailableSpaceInByte, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IProcessServerDetailsInternal)this).UsedSpaceInByte = (long?) content.GetValueForProperty("UsedSpaceInByte",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IProcessServerDetailsInternal)this).UsedSpaceInByte, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IProcessServerDetailsInternal)this).FreeSpacePercentage = (double?) content.GetValueForProperty("FreeSpacePercentage",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IProcessServerDetailsInternal)this).FreeSpacePercentage, (__y)=> (double) global::System.Convert.ChangeType(__y, typeof(double)));
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IProcessServerDetailsInternal)this).ThroughputUploadPendingDataInByte = (long?) content.GetValueForProperty("ThroughputUploadPendingDataInByte",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IProcessServerDetailsInternal)this).ThroughputUploadPendingDataInByte, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IProcessServerDetailsInternal)this).ThroughputInByte = (long?) content.GetValueForProperty("ThroughputInByte",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IProcessServerDetailsInternal)this).ThroughputInByte, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IProcessServerDetailsInternal)this).ProcessorUsagePercentage = (double?) content.GetValueForProperty("ProcessorUsagePercentage",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IProcessServerDetailsInternal)this).ProcessorUsagePercentage, (__y)=> (double) global::System.Convert.ChangeType(__y, typeof(double)));
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IProcessServerDetailsInternal)this).ThroughputStatus = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.RcmComponentStatus?) content.GetValueForProperty("ThroughputStatus",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IProcessServerDetailsInternal)this).ThroughputStatus, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.RcmComponentStatus.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IProcessServerDetailsInternal)this).SystemLoad = (long?) content.GetValueForProperty("SystemLoad",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IProcessServerDetailsInternal)this).SystemLoad, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IProcessServerDetailsInternal)this).SystemLoadStatus = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.RcmComponentStatus?) content.GetValueForProperty("SystemLoadStatus",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IProcessServerDetailsInternal)this).SystemLoadStatus, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.RcmComponentStatus.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IProcessServerDetailsInternal)this).DiskUsageStatus = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.RcmComponentStatus?) content.GetValueForProperty("DiskUsageStatus",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IProcessServerDetailsInternal)this).DiskUsageStatus, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.RcmComponentStatus.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IProcessServerDetailsInternal)this).MemoryUsageStatus = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.RcmComponentStatus?) content.GetValueForProperty("MemoryUsageStatus",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IProcessServerDetailsInternal)this).MemoryUsageStatus, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.RcmComponentStatus.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IProcessServerDetailsInternal)this).ProcessorUsageStatus = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.RcmComponentStatus?) content.GetValueForProperty("ProcessorUsageStatus",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IProcessServerDetailsInternal)this).ProcessorUsageStatus, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.RcmComponentStatus.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IProcessServerDetailsInternal)this).Health = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.ProtectionHealth?) content.GetValueForProperty("Health",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IProcessServerDetailsInternal)this).Health, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.ProtectionHealth.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IProcessServerDetailsInternal)this).HealthError = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IHealthError[]) content.GetValueForProperty("HealthError",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IProcessServerDetailsInternal)this).HealthError, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IHealthError>(__y, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.HealthErrorTypeConverter.ConvertFrom));
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IProcessServerDetailsInternal)this).HistoricHealth = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.ProtectionHealth?) content.GetValueForProperty("HistoricHealth",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IProcessServerDetailsInternal)this).HistoricHealth, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.ProtectionHealth.CreateFrom);
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Process server details.
    [System.ComponentModel.TypeConverter(typeof(ProcessServerDetailsTypeConverter))]
    public partial interface IProcessServerDetails

    {

    }
}