// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701
{
    using Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.PowerShell;

    /// <summary>
    /// Specifies information about the gallery Application Version that you want to update.
    /// </summary>
    [System.ComponentModel.TypeConverter(typeof(GalleryApplicationVersionUpdateTypeConverter))]
    public partial class GalleryApplicationVersionUpdate
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.GalleryApplicationVersionUpdate"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryApplicationVersionUpdate"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryApplicationVersionUpdate DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new GalleryApplicationVersionUpdate(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.GalleryApplicationVersionUpdate"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryApplicationVersionUpdate"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryApplicationVersionUpdate DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new GalleryApplicationVersionUpdate(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="GalleryApplicationVersionUpdate" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryApplicationVersionUpdate FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.GalleryApplicationVersionUpdate"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal GalleryApplicationVersionUpdate(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryApplicationVersionUpdateInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryApplicationVersionProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryApplicationVersionUpdateInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.GalleryApplicationVersionPropertiesTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IUpdateResourceDefinitionInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IUpdateResourceDefinitionInternal)this).Id, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IUpdateResourceDefinitionInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IUpdateResourceDefinitionInternal)this).Name, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IUpdateResourceDefinitionInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IUpdateResourceDefinitionInternal)this).Type, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IUpdateResourceDefinitionInternal)this).Tag = (Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IUpdateResourceDefinitionTags) content.GetValueForProperty("Tag",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IUpdateResourceDefinitionInternal)this).Tag, Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.UpdateResourceDefinitionTagsTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryApplicationVersionUpdateInternal)this).ReplicationStatus = (Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IReplicationStatus) content.GetValueForProperty("ReplicationStatus",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryApplicationVersionUpdateInternal)this).ReplicationStatus, Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.ReplicationStatusTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryApplicationVersionUpdateInternal)this).PublishingProfile = (Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryApplicationVersionPublishingProfile) content.GetValueForProperty("PublishingProfile",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryApplicationVersionUpdateInternal)this).PublishingProfile, Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.GalleryApplicationVersionPublishingProfileTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryApplicationVersionUpdateInternal)this).ProvisioningState = (string) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryApplicationVersionUpdateInternal)this).ProvisioningState, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryApplicationVersionUpdateInternal)this).PublishingProfileReplicationMode = (Microsoft.Azure.PowerShell.Cmdlets.Compute.Support.ReplicationMode?) content.GetValueForProperty("PublishingProfileReplicationMode",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryApplicationVersionUpdateInternal)this).PublishingProfileReplicationMode, Microsoft.Azure.PowerShell.Cmdlets.Compute.Support.ReplicationMode.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryApplicationVersionUpdateInternal)this).ReplicationStatusSummary = (Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IRegionalReplicationStatus[]) content.GetValueForProperty("ReplicationStatusSummary",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryApplicationVersionUpdateInternal)this).ReplicationStatusSummary, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IRegionalReplicationStatus>(__y, Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.RegionalReplicationStatusTypeConverter.ConvertFrom));
            ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryApplicationVersionUpdateInternal)this).TargetRegion = (Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.ITargetRegion[]) content.GetValueForProperty("TargetRegion",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryApplicationVersionUpdateInternal)this).TargetRegion, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.ITargetRegion>(__y, Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.TargetRegionTypeConverter.ConvertFrom));
            ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryApplicationVersionUpdateInternal)this).ReplicaCount = (int?) content.GetValueForProperty("ReplicaCount",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryApplicationVersionUpdateInternal)this).ReplicaCount, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryApplicationVersionUpdateInternal)this).PublishingProfileExcludeFromLatest = (bool?) content.GetValueForProperty("PublishingProfileExcludeFromLatest",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryApplicationVersionUpdateInternal)this).PublishingProfileExcludeFromLatest, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryApplicationVersionUpdateInternal)this).PublishingProfilePublishedDate = (global::System.DateTime?) content.GetValueForProperty("PublishingProfilePublishedDate",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryApplicationVersionUpdateInternal)this).PublishingProfilePublishedDate, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryApplicationVersionUpdateInternal)this).PublishingProfileEndOfLifeDate = (global::System.DateTime?) content.GetValueForProperty("PublishingProfileEndOfLifeDate",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryApplicationVersionUpdateInternal)this).PublishingProfileEndOfLifeDate, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryApplicationVersionUpdateInternal)this).PublishingProfileStorageAccountType = (Microsoft.Azure.PowerShell.Cmdlets.Compute.Support.StorageAccountType?) content.GetValueForProperty("PublishingProfileStorageAccountType",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryApplicationVersionUpdateInternal)this).PublishingProfileStorageAccountType, Microsoft.Azure.PowerShell.Cmdlets.Compute.Support.StorageAccountType.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryApplicationVersionUpdateInternal)this).PublishingProfileSource = (Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IUserArtifactSource) content.GetValueForProperty("PublishingProfileSource",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryApplicationVersionUpdateInternal)this).PublishingProfileSource, Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.UserArtifactSourceTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryApplicationVersionUpdateInternal)this).PublishingProfileManageAction = (Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IUserArtifactManage) content.GetValueForProperty("PublishingProfileManageAction",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryApplicationVersionUpdateInternal)this).PublishingProfileManageAction, Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.UserArtifactManageTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryApplicationVersionUpdateInternal)this).PublishingProfileEnableHealthCheck = (bool?) content.GetValueForProperty("PublishingProfileEnableHealthCheck",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryApplicationVersionUpdateInternal)this).PublishingProfileEnableHealthCheck, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryApplicationVersionUpdateInternal)this).ReplicationStatusAggregatedState = (Microsoft.Azure.PowerShell.Cmdlets.Compute.Support.AggregatedReplicationState?) content.GetValueForProperty("ReplicationStatusAggregatedState",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryApplicationVersionUpdateInternal)this).ReplicationStatusAggregatedState, Microsoft.Azure.PowerShell.Cmdlets.Compute.Support.AggregatedReplicationState.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryApplicationVersionUpdateInternal)this).PackageFileLink = (string) content.GetValueForProperty("PackageFileLink",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryApplicationVersionUpdateInternal)this).PackageFileLink, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryApplicationVersionUpdateInternal)this).DefaultConfigFileLink = (string) content.GetValueForProperty("DefaultConfigFileLink",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryApplicationVersionUpdateInternal)this).DefaultConfigFileLink, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryApplicationVersionUpdateInternal)this).Install = (string) content.GetValueForProperty("Install",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryApplicationVersionUpdateInternal)this).Install, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryApplicationVersionUpdateInternal)this).Remove = (string) content.GetValueForProperty("Remove",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryApplicationVersionUpdateInternal)this).Remove, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryApplicationVersionUpdateInternal)this).Update = (string) content.GetValueForProperty("Update",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryApplicationVersionUpdateInternal)this).Update, global::System.Convert.ToString);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.GalleryApplicationVersionUpdate"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal GalleryApplicationVersionUpdate(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryApplicationVersionUpdateInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryApplicationVersionProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryApplicationVersionUpdateInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.GalleryApplicationVersionPropertiesTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IUpdateResourceDefinitionInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IUpdateResourceDefinitionInternal)this).Id, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IUpdateResourceDefinitionInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IUpdateResourceDefinitionInternal)this).Name, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IUpdateResourceDefinitionInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IUpdateResourceDefinitionInternal)this).Type, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IUpdateResourceDefinitionInternal)this).Tag = (Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IUpdateResourceDefinitionTags) content.GetValueForProperty("Tag",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IUpdateResourceDefinitionInternal)this).Tag, Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.UpdateResourceDefinitionTagsTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryApplicationVersionUpdateInternal)this).ReplicationStatus = (Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IReplicationStatus) content.GetValueForProperty("ReplicationStatus",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryApplicationVersionUpdateInternal)this).ReplicationStatus, Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.ReplicationStatusTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryApplicationVersionUpdateInternal)this).PublishingProfile = (Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryApplicationVersionPublishingProfile) content.GetValueForProperty("PublishingProfile",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryApplicationVersionUpdateInternal)this).PublishingProfile, Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.GalleryApplicationVersionPublishingProfileTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryApplicationVersionUpdateInternal)this).ProvisioningState = (string) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryApplicationVersionUpdateInternal)this).ProvisioningState, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryApplicationVersionUpdateInternal)this).PublishingProfileReplicationMode = (Microsoft.Azure.PowerShell.Cmdlets.Compute.Support.ReplicationMode?) content.GetValueForProperty("PublishingProfileReplicationMode",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryApplicationVersionUpdateInternal)this).PublishingProfileReplicationMode, Microsoft.Azure.PowerShell.Cmdlets.Compute.Support.ReplicationMode.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryApplicationVersionUpdateInternal)this).ReplicationStatusSummary = (Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IRegionalReplicationStatus[]) content.GetValueForProperty("ReplicationStatusSummary",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryApplicationVersionUpdateInternal)this).ReplicationStatusSummary, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IRegionalReplicationStatus>(__y, Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.RegionalReplicationStatusTypeConverter.ConvertFrom));
            ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryApplicationVersionUpdateInternal)this).TargetRegion = (Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.ITargetRegion[]) content.GetValueForProperty("TargetRegion",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryApplicationVersionUpdateInternal)this).TargetRegion, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.ITargetRegion>(__y, Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.TargetRegionTypeConverter.ConvertFrom));
            ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryApplicationVersionUpdateInternal)this).ReplicaCount = (int?) content.GetValueForProperty("ReplicaCount",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryApplicationVersionUpdateInternal)this).ReplicaCount, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryApplicationVersionUpdateInternal)this).PublishingProfileExcludeFromLatest = (bool?) content.GetValueForProperty("PublishingProfileExcludeFromLatest",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryApplicationVersionUpdateInternal)this).PublishingProfileExcludeFromLatest, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryApplicationVersionUpdateInternal)this).PublishingProfilePublishedDate = (global::System.DateTime?) content.GetValueForProperty("PublishingProfilePublishedDate",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryApplicationVersionUpdateInternal)this).PublishingProfilePublishedDate, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryApplicationVersionUpdateInternal)this).PublishingProfileEndOfLifeDate = (global::System.DateTime?) content.GetValueForProperty("PublishingProfileEndOfLifeDate",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryApplicationVersionUpdateInternal)this).PublishingProfileEndOfLifeDate, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryApplicationVersionUpdateInternal)this).PublishingProfileStorageAccountType = (Microsoft.Azure.PowerShell.Cmdlets.Compute.Support.StorageAccountType?) content.GetValueForProperty("PublishingProfileStorageAccountType",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryApplicationVersionUpdateInternal)this).PublishingProfileStorageAccountType, Microsoft.Azure.PowerShell.Cmdlets.Compute.Support.StorageAccountType.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryApplicationVersionUpdateInternal)this).PublishingProfileSource = (Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IUserArtifactSource) content.GetValueForProperty("PublishingProfileSource",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryApplicationVersionUpdateInternal)this).PublishingProfileSource, Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.UserArtifactSourceTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryApplicationVersionUpdateInternal)this).PublishingProfileManageAction = (Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IUserArtifactManage) content.GetValueForProperty("PublishingProfileManageAction",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryApplicationVersionUpdateInternal)this).PublishingProfileManageAction, Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.UserArtifactManageTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryApplicationVersionUpdateInternal)this).PublishingProfileEnableHealthCheck = (bool?) content.GetValueForProperty("PublishingProfileEnableHealthCheck",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryApplicationVersionUpdateInternal)this).PublishingProfileEnableHealthCheck, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryApplicationVersionUpdateInternal)this).ReplicationStatusAggregatedState = (Microsoft.Azure.PowerShell.Cmdlets.Compute.Support.AggregatedReplicationState?) content.GetValueForProperty("ReplicationStatusAggregatedState",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryApplicationVersionUpdateInternal)this).ReplicationStatusAggregatedState, Microsoft.Azure.PowerShell.Cmdlets.Compute.Support.AggregatedReplicationState.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryApplicationVersionUpdateInternal)this).PackageFileLink = (string) content.GetValueForProperty("PackageFileLink",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryApplicationVersionUpdateInternal)this).PackageFileLink, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryApplicationVersionUpdateInternal)this).DefaultConfigFileLink = (string) content.GetValueForProperty("DefaultConfigFileLink",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryApplicationVersionUpdateInternal)this).DefaultConfigFileLink, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryApplicationVersionUpdateInternal)this).Install = (string) content.GetValueForProperty("Install",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryApplicationVersionUpdateInternal)this).Install, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryApplicationVersionUpdateInternal)this).Remove = (string) content.GetValueForProperty("Remove",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryApplicationVersionUpdateInternal)this).Remove, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryApplicationVersionUpdateInternal)this).Update = (string) content.GetValueForProperty("Update",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryApplicationVersionUpdateInternal)this).Update, global::System.Convert.ToString);
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Specifies information about the gallery Application Version that you want to update.
    [System.ComponentModel.TypeConverter(typeof(GalleryApplicationVersionUpdateTypeConverter))]
    public partial interface IGalleryApplicationVersionUpdate

    {

    }
}