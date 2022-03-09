// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401
{
    using Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.PowerShell;

    /// <summary>The blob container properties be listed out.</summary>
    [System.ComponentModel.TypeConverter(typeof(ListContainerItemTypeConverter))]
    public partial class ListContainerItem
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.ListContainerItem"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IListContainerItem" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IListContainerItem DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new ListContainerItem(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.ListContainerItem"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IListContainerItem" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IListContainerItem DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new ListContainerItem(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="ListContainerItem" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IListContainerItem FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.ListContainerItem"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal ListContainerItem(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Property"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IListContainerItemInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IContainerProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IListContainerItemInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.ContainerPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api10.IResourceAutoGeneratedInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api10.IResourceAutoGeneratedInternal)this).Id, global::System.Convert.ToString);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api10.IResourceAutoGeneratedInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api10.IResourceAutoGeneratedInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api10.IResourceAutoGeneratedInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api10.IResourceAutoGeneratedInternal)this).Type, global::System.Convert.ToString);
            }
            if (content.Contains("Etag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api10.IAzureEntityResourceInternal)this).Etag = (string) content.GetValueForProperty("Etag",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api10.IAzureEntityResourceInternal)this).Etag, global::System.Convert.ToString);
            }
            if (content.Contains("PublicAccess"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IListContainerItemInternal)this).PublicAccess = (Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.PublicAccess?) content.GetValueForProperty("PublicAccess",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IListContainerItemInternal)this).PublicAccess, Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.PublicAccess.CreateFrom);
            }
            if (content.Contains("LeaseStatus"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IListContainerItemInternal)this).LeaseStatus = (Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.LeaseStatus?) content.GetValueForProperty("LeaseStatus",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IListContainerItemInternal)this).LeaseStatus, Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.LeaseStatus.CreateFrom);
            }
            if (content.Contains("LeaseState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IListContainerItemInternal)this).LeaseState = (Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.LeaseState?) content.GetValueForProperty("LeaseState",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IListContainerItemInternal)this).LeaseState, Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.LeaseState.CreateFrom);
            }
            if (content.Contains("LeaseDuration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IListContainerItemInternal)this).LeaseDuration = (Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.LeaseDuration?) content.GetValueForProperty("LeaseDuration",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IListContainerItemInternal)this).LeaseDuration, Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.LeaseDuration.CreateFrom);
            }
            if (content.Contains("ImmutabilityPolicy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IListContainerItemInternal)this).ImmutabilityPolicy = (Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IImmutabilityPolicyProperties) content.GetValueForProperty("ImmutabilityPolicy",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IListContainerItemInternal)this).ImmutabilityPolicy, Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.ImmutabilityPolicyPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("LegalHold"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IListContainerItemInternal)this).LegalHold = (Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.ILegalHoldProperties) content.GetValueForProperty("LegalHold",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IListContainerItemInternal)this).LegalHold, Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.LegalHoldPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("LastModifiedTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IListContainerItemInternal)this).LastModifiedTime = (global::System.DateTime?) content.GetValueForProperty("LastModifiedTime",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IListContainerItemInternal)this).LastModifiedTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("Metadata"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IListContainerItemInternal)this).Metadata = (Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IContainerPropertiesMetadata) content.GetValueForProperty("Metadata",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IListContainerItemInternal)this).Metadata, Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.ContainerPropertiesMetadataTypeConverter.ConvertFrom);
            }
            if (content.Contains("HasLegalHold"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IListContainerItemInternal)this).HasLegalHold = (bool?) content.GetValueForProperty("HasLegalHold",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IListContainerItemInternal)this).HasLegalHold, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("HasImmutabilityPolicy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IListContainerItemInternal)this).HasImmutabilityPolicy = (bool?) content.GetValueForProperty("HasImmutabilityPolicy",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IListContainerItemInternal)this).HasImmutabilityPolicy, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("ImmutabilityPolicyProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IListContainerItemInternal)this).ImmutabilityPolicyProperty = (Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IImmutabilityPolicyProperty) content.GetValueForProperty("ImmutabilityPolicyProperty",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IListContainerItemInternal)this).ImmutabilityPolicyProperty, Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.ImmutabilityPolicyPropertyTypeConverter.ConvertFrom);
            }
            if (content.Contains("ImmutabilityPolicyEtag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IListContainerItemInternal)this).ImmutabilityPolicyEtag = (string) content.GetValueForProperty("ImmutabilityPolicyEtag",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IListContainerItemInternal)this).ImmutabilityPolicyEtag, global::System.Convert.ToString);
            }
            if (content.Contains("ImmutabilityPolicyUpdateHistory"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IListContainerItemInternal)this).ImmutabilityPolicyUpdateHistory = (Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IUpdateHistoryProperty[]) content.GetValueForProperty("ImmutabilityPolicyUpdateHistory",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IListContainerItemInternal)this).ImmutabilityPolicyUpdateHistory, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IUpdateHistoryProperty>(__y, Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.UpdateHistoryPropertyTypeConverter.ConvertFrom));
            }
            if (content.Contains("LegalHoldHasLegalHold"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IListContainerItemInternal)this).LegalHoldHasLegalHold = (bool?) content.GetValueForProperty("LegalHoldHasLegalHold",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IListContainerItemInternal)this).LegalHoldHasLegalHold, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("LegalHoldTag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IListContainerItemInternal)this).LegalHoldTag = (Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.ITagProperty[]) content.GetValueForProperty("LegalHoldTag",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IListContainerItemInternal)this).LegalHoldTag, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.ITagProperty>(__y, Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.TagPropertyTypeConverter.ConvertFrom));
            }
            if (content.Contains("ImmutabilityPeriodSinceCreationInDay"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IListContainerItemInternal)this).ImmutabilityPeriodSinceCreationInDay = (int) content.GetValueForProperty("ImmutabilityPeriodSinceCreationInDay",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IListContainerItemInternal)this).ImmutabilityPeriodSinceCreationInDay, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("State"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IListContainerItemInternal)this).State = (Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.ImmutabilityPolicyState?) content.GetValueForProperty("State",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IListContainerItemInternal)this).State, Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.ImmutabilityPolicyState.CreateFrom);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.ListContainerItem"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal ListContainerItem(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Property"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IListContainerItemInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IContainerProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IListContainerItemInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.ContainerPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api10.IResourceAutoGeneratedInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api10.IResourceAutoGeneratedInternal)this).Id, global::System.Convert.ToString);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api10.IResourceAutoGeneratedInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api10.IResourceAutoGeneratedInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api10.IResourceAutoGeneratedInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api10.IResourceAutoGeneratedInternal)this).Type, global::System.Convert.ToString);
            }
            if (content.Contains("Etag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api10.IAzureEntityResourceInternal)this).Etag = (string) content.GetValueForProperty("Etag",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api10.IAzureEntityResourceInternal)this).Etag, global::System.Convert.ToString);
            }
            if (content.Contains("PublicAccess"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IListContainerItemInternal)this).PublicAccess = (Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.PublicAccess?) content.GetValueForProperty("PublicAccess",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IListContainerItemInternal)this).PublicAccess, Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.PublicAccess.CreateFrom);
            }
            if (content.Contains("LeaseStatus"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IListContainerItemInternal)this).LeaseStatus = (Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.LeaseStatus?) content.GetValueForProperty("LeaseStatus",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IListContainerItemInternal)this).LeaseStatus, Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.LeaseStatus.CreateFrom);
            }
            if (content.Contains("LeaseState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IListContainerItemInternal)this).LeaseState = (Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.LeaseState?) content.GetValueForProperty("LeaseState",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IListContainerItemInternal)this).LeaseState, Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.LeaseState.CreateFrom);
            }
            if (content.Contains("LeaseDuration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IListContainerItemInternal)this).LeaseDuration = (Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.LeaseDuration?) content.GetValueForProperty("LeaseDuration",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IListContainerItemInternal)this).LeaseDuration, Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.LeaseDuration.CreateFrom);
            }
            if (content.Contains("ImmutabilityPolicy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IListContainerItemInternal)this).ImmutabilityPolicy = (Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IImmutabilityPolicyProperties) content.GetValueForProperty("ImmutabilityPolicy",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IListContainerItemInternal)this).ImmutabilityPolicy, Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.ImmutabilityPolicyPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("LegalHold"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IListContainerItemInternal)this).LegalHold = (Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.ILegalHoldProperties) content.GetValueForProperty("LegalHold",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IListContainerItemInternal)this).LegalHold, Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.LegalHoldPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("LastModifiedTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IListContainerItemInternal)this).LastModifiedTime = (global::System.DateTime?) content.GetValueForProperty("LastModifiedTime",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IListContainerItemInternal)this).LastModifiedTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("Metadata"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IListContainerItemInternal)this).Metadata = (Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IContainerPropertiesMetadata) content.GetValueForProperty("Metadata",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IListContainerItemInternal)this).Metadata, Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.ContainerPropertiesMetadataTypeConverter.ConvertFrom);
            }
            if (content.Contains("HasLegalHold"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IListContainerItemInternal)this).HasLegalHold = (bool?) content.GetValueForProperty("HasLegalHold",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IListContainerItemInternal)this).HasLegalHold, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("HasImmutabilityPolicy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IListContainerItemInternal)this).HasImmutabilityPolicy = (bool?) content.GetValueForProperty("HasImmutabilityPolicy",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IListContainerItemInternal)this).HasImmutabilityPolicy, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("ImmutabilityPolicyProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IListContainerItemInternal)this).ImmutabilityPolicyProperty = (Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IImmutabilityPolicyProperty) content.GetValueForProperty("ImmutabilityPolicyProperty",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IListContainerItemInternal)this).ImmutabilityPolicyProperty, Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.ImmutabilityPolicyPropertyTypeConverter.ConvertFrom);
            }
            if (content.Contains("ImmutabilityPolicyEtag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IListContainerItemInternal)this).ImmutabilityPolicyEtag = (string) content.GetValueForProperty("ImmutabilityPolicyEtag",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IListContainerItemInternal)this).ImmutabilityPolicyEtag, global::System.Convert.ToString);
            }
            if (content.Contains("ImmutabilityPolicyUpdateHistory"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IListContainerItemInternal)this).ImmutabilityPolicyUpdateHistory = (Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IUpdateHistoryProperty[]) content.GetValueForProperty("ImmutabilityPolicyUpdateHistory",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IListContainerItemInternal)this).ImmutabilityPolicyUpdateHistory, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IUpdateHistoryProperty>(__y, Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.UpdateHistoryPropertyTypeConverter.ConvertFrom));
            }
            if (content.Contains("LegalHoldHasLegalHold"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IListContainerItemInternal)this).LegalHoldHasLegalHold = (bool?) content.GetValueForProperty("LegalHoldHasLegalHold",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IListContainerItemInternal)this).LegalHoldHasLegalHold, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("LegalHoldTag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IListContainerItemInternal)this).LegalHoldTag = (Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.ITagProperty[]) content.GetValueForProperty("LegalHoldTag",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IListContainerItemInternal)this).LegalHoldTag, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.ITagProperty>(__y, Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.TagPropertyTypeConverter.ConvertFrom));
            }
            if (content.Contains("ImmutabilityPeriodSinceCreationInDay"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IListContainerItemInternal)this).ImmutabilityPeriodSinceCreationInDay = (int) content.GetValueForProperty("ImmutabilityPeriodSinceCreationInDay",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IListContainerItemInternal)this).ImmutabilityPeriodSinceCreationInDay, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("State"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IListContainerItemInternal)this).State = (Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.ImmutabilityPolicyState?) content.GetValueForProperty("State",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IListContainerItemInternal)this).State, Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.ImmutabilityPolicyState.CreateFrom);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// The blob container properties be listed out.
    [System.ComponentModel.TypeConverter(typeof(ListContainerItemTypeConverter))]
    public partial interface IListContainerItem

    {

    }
}