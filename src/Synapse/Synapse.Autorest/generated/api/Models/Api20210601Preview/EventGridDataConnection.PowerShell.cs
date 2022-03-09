// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview
{
    using Microsoft.Azure.PowerShell.Cmdlets.Synapse.Runtime.PowerShell;

    /// <summary>Class representing an Event Grid data connection.</summary>
    [System.ComponentModel.TypeConverter(typeof(EventGridDataConnectionTypeConverter))]
    public partial class EventGridDataConnection
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.EventGridDataConnection"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IEventGridDataConnection"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IEventGridDataConnection DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new EventGridDataConnection(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.EventGridDataConnection"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IEventGridDataConnection"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IEventGridDataConnection DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new EventGridDataConnection(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.EventGridDataConnection"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal EventGridDataConnection(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IEventGridDataConnectionInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IEventGridConnectionProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IEventGridDataConnectionInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.EventGridConnectionPropertiesTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api10.IResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api10.IResourceInternal)this).Id, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api10.IResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api10.IResourceInternal)this).Name, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api10.IResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api10.IResourceInternal)this).Type, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IDataConnectionInternal)this).SystemDataCreatedBy = (string) content.GetValueForProperty("SystemDataCreatedBy",((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IDataConnectionInternal)this).SystemDataCreatedBy, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IDataConnectionInternal)this).SystemDataCreatedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataCreatedAt",((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IDataConnectionInternal)this).SystemDataCreatedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IDataConnectionInternal)this).SystemDataCreatedByType = (Microsoft.Azure.PowerShell.Cmdlets.Synapse.Support.CreatedByType?) content.GetValueForProperty("SystemDataCreatedByType",((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IDataConnectionInternal)this).SystemDataCreatedByType, Microsoft.Azure.PowerShell.Cmdlets.Synapse.Support.CreatedByType.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IDataConnectionInternal)this).SystemDataLastModifiedBy = (string) content.GetValueForProperty("SystemDataLastModifiedBy",((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IDataConnectionInternal)this).SystemDataLastModifiedBy, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IDataConnectionInternal)this).SystemDataLastModifiedByType = (Microsoft.Azure.PowerShell.Cmdlets.Synapse.Support.CreatedByType?) content.GetValueForProperty("SystemDataLastModifiedByType",((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IDataConnectionInternal)this).SystemDataLastModifiedByType, Microsoft.Azure.PowerShell.Cmdlets.Synapse.Support.CreatedByType.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IDataConnectionInternal)this).SystemDataLastModifiedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataLastModifiedAt",((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IDataConnectionInternal)this).SystemDataLastModifiedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IDataConnectionInternal)this).SystemData = (Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api10.ISystemData) content.GetValueForProperty("SystemData",((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IDataConnectionInternal)this).SystemData, Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api10.SystemDataTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IDataConnectionInternal)this).Location = (string) content.GetValueForProperty("Location",((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IDataConnectionInternal)this).Location, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IDataConnectionInternal)this).Kind = (Microsoft.Azure.PowerShell.Cmdlets.Synapse.Support.DataConnectionKind) content.GetValueForProperty("Kind",((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IDataConnectionInternal)this).Kind, Microsoft.Azure.PowerShell.Cmdlets.Synapse.Support.DataConnectionKind.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IEventGridDataConnectionInternal)this).StorageAccountResourceId = (string) content.GetValueForProperty("StorageAccountResourceId",((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IEventGridDataConnectionInternal)this).StorageAccountResourceId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IEventGridDataConnectionInternal)this).EventHubResourceId = (string) content.GetValueForProperty("EventHubResourceId",((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IEventGridDataConnectionInternal)this).EventHubResourceId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IEventGridDataConnectionInternal)this).ConsumerGroup = (string) content.GetValueForProperty("ConsumerGroup",((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IEventGridDataConnectionInternal)this).ConsumerGroup, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IEventGridDataConnectionInternal)this).TableName = (string) content.GetValueForProperty("TableName",((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IEventGridDataConnectionInternal)this).TableName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IEventGridDataConnectionInternal)this).MappingRuleName = (string) content.GetValueForProperty("MappingRuleName",((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IEventGridDataConnectionInternal)this).MappingRuleName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IEventGridDataConnectionInternal)this).DataFormat = (Microsoft.Azure.PowerShell.Cmdlets.Synapse.Support.EventGridDataFormat?) content.GetValueForProperty("DataFormat",((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IEventGridDataConnectionInternal)this).DataFormat, Microsoft.Azure.PowerShell.Cmdlets.Synapse.Support.EventGridDataFormat.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IEventGridDataConnectionInternal)this).IgnoreFirstRecord = (bool?) content.GetValueForProperty("IgnoreFirstRecord",((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IEventGridDataConnectionInternal)this).IgnoreFirstRecord, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IEventGridDataConnectionInternal)this).BlobStorageEventType = (Microsoft.Azure.PowerShell.Cmdlets.Synapse.Support.BlobStorageEventType?) content.GetValueForProperty("BlobStorageEventType",((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IEventGridDataConnectionInternal)this).BlobStorageEventType, Microsoft.Azure.PowerShell.Cmdlets.Synapse.Support.BlobStorageEventType.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IEventGridDataConnectionInternal)this).ProvisioningState = (Microsoft.Azure.PowerShell.Cmdlets.Synapse.Support.ResourceProvisioningState?) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IEventGridDataConnectionInternal)this).ProvisioningState, Microsoft.Azure.PowerShell.Cmdlets.Synapse.Support.ResourceProvisioningState.CreateFrom);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.EventGridDataConnection"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal EventGridDataConnection(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IEventGridDataConnectionInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IEventGridConnectionProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IEventGridDataConnectionInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.EventGridConnectionPropertiesTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api10.IResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api10.IResourceInternal)this).Id, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api10.IResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api10.IResourceInternal)this).Name, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api10.IResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api10.IResourceInternal)this).Type, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IDataConnectionInternal)this).SystemDataCreatedBy = (string) content.GetValueForProperty("SystemDataCreatedBy",((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IDataConnectionInternal)this).SystemDataCreatedBy, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IDataConnectionInternal)this).SystemDataCreatedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataCreatedAt",((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IDataConnectionInternal)this).SystemDataCreatedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IDataConnectionInternal)this).SystemDataCreatedByType = (Microsoft.Azure.PowerShell.Cmdlets.Synapse.Support.CreatedByType?) content.GetValueForProperty("SystemDataCreatedByType",((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IDataConnectionInternal)this).SystemDataCreatedByType, Microsoft.Azure.PowerShell.Cmdlets.Synapse.Support.CreatedByType.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IDataConnectionInternal)this).SystemDataLastModifiedBy = (string) content.GetValueForProperty("SystemDataLastModifiedBy",((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IDataConnectionInternal)this).SystemDataLastModifiedBy, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IDataConnectionInternal)this).SystemDataLastModifiedByType = (Microsoft.Azure.PowerShell.Cmdlets.Synapse.Support.CreatedByType?) content.GetValueForProperty("SystemDataLastModifiedByType",((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IDataConnectionInternal)this).SystemDataLastModifiedByType, Microsoft.Azure.PowerShell.Cmdlets.Synapse.Support.CreatedByType.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IDataConnectionInternal)this).SystemDataLastModifiedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataLastModifiedAt",((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IDataConnectionInternal)this).SystemDataLastModifiedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IDataConnectionInternal)this).SystemData = (Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api10.ISystemData) content.GetValueForProperty("SystemData",((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IDataConnectionInternal)this).SystemData, Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api10.SystemDataTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IDataConnectionInternal)this).Location = (string) content.GetValueForProperty("Location",((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IDataConnectionInternal)this).Location, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IDataConnectionInternal)this).Kind = (Microsoft.Azure.PowerShell.Cmdlets.Synapse.Support.DataConnectionKind) content.GetValueForProperty("Kind",((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IDataConnectionInternal)this).Kind, Microsoft.Azure.PowerShell.Cmdlets.Synapse.Support.DataConnectionKind.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IEventGridDataConnectionInternal)this).StorageAccountResourceId = (string) content.GetValueForProperty("StorageAccountResourceId",((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IEventGridDataConnectionInternal)this).StorageAccountResourceId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IEventGridDataConnectionInternal)this).EventHubResourceId = (string) content.GetValueForProperty("EventHubResourceId",((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IEventGridDataConnectionInternal)this).EventHubResourceId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IEventGridDataConnectionInternal)this).ConsumerGroup = (string) content.GetValueForProperty("ConsumerGroup",((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IEventGridDataConnectionInternal)this).ConsumerGroup, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IEventGridDataConnectionInternal)this).TableName = (string) content.GetValueForProperty("TableName",((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IEventGridDataConnectionInternal)this).TableName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IEventGridDataConnectionInternal)this).MappingRuleName = (string) content.GetValueForProperty("MappingRuleName",((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IEventGridDataConnectionInternal)this).MappingRuleName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IEventGridDataConnectionInternal)this).DataFormat = (Microsoft.Azure.PowerShell.Cmdlets.Synapse.Support.EventGridDataFormat?) content.GetValueForProperty("DataFormat",((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IEventGridDataConnectionInternal)this).DataFormat, Microsoft.Azure.PowerShell.Cmdlets.Synapse.Support.EventGridDataFormat.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IEventGridDataConnectionInternal)this).IgnoreFirstRecord = (bool?) content.GetValueForProperty("IgnoreFirstRecord",((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IEventGridDataConnectionInternal)this).IgnoreFirstRecord, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IEventGridDataConnectionInternal)this).BlobStorageEventType = (Microsoft.Azure.PowerShell.Cmdlets.Synapse.Support.BlobStorageEventType?) content.GetValueForProperty("BlobStorageEventType",((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IEventGridDataConnectionInternal)this).BlobStorageEventType, Microsoft.Azure.PowerShell.Cmdlets.Synapse.Support.BlobStorageEventType.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IEventGridDataConnectionInternal)this).ProvisioningState = (Microsoft.Azure.PowerShell.Cmdlets.Synapse.Support.ResourceProvisioningState?) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IEventGridDataConnectionInternal)this).ProvisioningState, Microsoft.Azure.PowerShell.Cmdlets.Synapse.Support.ResourceProvisioningState.CreateFrom);
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="EventGridDataConnection" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IEventGridDataConnection FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.Synapse.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.Synapse.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Class representing an Event Grid data connection.
    [System.ComponentModel.TypeConverter(typeof(EventGridDataConnectionTypeConverter))]
    public partial interface IEventGridDataConnection

    {

    }
}