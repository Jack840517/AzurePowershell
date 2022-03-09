// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20210815
{
    using Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Runtime.PowerShell;

    /// <summary>Custom Locations definition.</summary>
    [System.ComponentModel.TypeConverter(typeof(CustomLocationTypeConverter))]
    public partial class CustomLocation
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20210815.CustomLocation"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal CustomLocation(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20210815.ICustomLocationInternal)this).Identity = (Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20210815.IIdentity) content.GetValueForProperty("Identity",((Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20210815.ICustomLocationInternal)this).Identity, Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20210815.IdentityTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20210815.ICustomLocationInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20210815.ICustomLocationProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20210815.ICustomLocationInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20210815.CustomLocationPropertiesTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20210815.ICustomLocationInternal)this).SystemData = (Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20.ISystemData) content.GetValueForProperty("SystemData",((Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20210815.ICustomLocationInternal)this).SystemData, Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20.SystemDataTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20.IResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20.IResourceInternal)this).Id, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20.IResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20.IResourceInternal)this).Name, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20.IResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20.IResourceInternal)this).Type, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20.ITrackedResourceInternal)this).Tag = (Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20.ITrackedResourceTags) content.GetValueForProperty("Tag",((Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20.ITrackedResourceInternal)this).Tag, Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20.TrackedResourceTagsTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20.ITrackedResourceInternal)this).Location = (string) content.GetValueForProperty("Location",((Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20.ITrackedResourceInternal)this).Location, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20210815.ICustomLocationInternal)this).IdentityPrincipalId = (string) content.GetValueForProperty("IdentityPrincipalId",((Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20210815.ICustomLocationInternal)this).IdentityPrincipalId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20210815.ICustomLocationInternal)this).IdentityTenantId = (string) content.GetValueForProperty("IdentityTenantId",((Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20210815.ICustomLocationInternal)this).IdentityTenantId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20210815.ICustomLocationInternal)this).HostType = (Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Support.HostType?) content.GetValueForProperty("HostType",((Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20210815.ICustomLocationInternal)this).HostType, Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Support.HostType.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20210815.ICustomLocationInternal)this).SystemDataCreatedBy = (string) content.GetValueForProperty("SystemDataCreatedBy",((Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20210815.ICustomLocationInternal)this).SystemDataCreatedBy, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20210815.ICustomLocationInternal)this).SystemDataCreatedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataCreatedAt",((Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20210815.ICustomLocationInternal)this).SystemDataCreatedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20210815.ICustomLocationInternal)this).IdentityType = (Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Support.ResourceIdentityType?) content.GetValueForProperty("IdentityType",((Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20210815.ICustomLocationInternal)this).IdentityType, Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Support.ResourceIdentityType.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20210815.ICustomLocationInternal)this).Authentication = (Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20210815.ICustomLocationPropertiesAuthentication) content.GetValueForProperty("Authentication",((Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20210815.ICustomLocationInternal)this).Authentication, Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20210815.CustomLocationPropertiesAuthenticationTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20210815.ICustomLocationInternal)this).ClusterExtensionId = (string[]) content.GetValueForProperty("ClusterExtensionId",((Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20210815.ICustomLocationInternal)this).ClusterExtensionId, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            ((Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20210815.ICustomLocationInternal)this).DisplayName = (string) content.GetValueForProperty("DisplayName",((Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20210815.ICustomLocationInternal)this).DisplayName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20210815.ICustomLocationInternal)this).HostResourceId = (string) content.GetValueForProperty("HostResourceId",((Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20210815.ICustomLocationInternal)this).HostResourceId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20210815.ICustomLocationInternal)this).Namespace = (string) content.GetValueForProperty("Namespace",((Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20210815.ICustomLocationInternal)this).Namespace, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20210815.ICustomLocationInternal)this).ProvisioningState = (string) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20210815.ICustomLocationInternal)this).ProvisioningState, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20210815.ICustomLocationInternal)this).SystemDataCreatedByType = (Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Support.CreatedByType?) content.GetValueForProperty("SystemDataCreatedByType",((Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20210815.ICustomLocationInternal)this).SystemDataCreatedByType, Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Support.CreatedByType.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20210815.ICustomLocationInternal)this).SystemDataLastModifiedBy = (string) content.GetValueForProperty("SystemDataLastModifiedBy",((Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20210815.ICustomLocationInternal)this).SystemDataLastModifiedBy, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20210815.ICustomLocationInternal)this).SystemDataLastModifiedByType = (Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Support.CreatedByType?) content.GetValueForProperty("SystemDataLastModifiedByType",((Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20210815.ICustomLocationInternal)this).SystemDataLastModifiedByType, Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Support.CreatedByType.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20210815.ICustomLocationInternal)this).SystemDataLastModifiedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataLastModifiedAt",((Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20210815.ICustomLocationInternal)this).SystemDataLastModifiedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20210815.ICustomLocationInternal)this).AuthenticationType = (string) content.GetValueForProperty("AuthenticationType",((Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20210815.ICustomLocationInternal)this).AuthenticationType, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20210815.ICustomLocationInternal)this).AuthenticationValue = (string) content.GetValueForProperty("AuthenticationValue",((Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20210815.ICustomLocationInternal)this).AuthenticationValue, global::System.Convert.ToString);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20210815.CustomLocation"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal CustomLocation(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20210815.ICustomLocationInternal)this).Identity = (Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20210815.IIdentity) content.GetValueForProperty("Identity",((Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20210815.ICustomLocationInternal)this).Identity, Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20210815.IdentityTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20210815.ICustomLocationInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20210815.ICustomLocationProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20210815.ICustomLocationInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20210815.CustomLocationPropertiesTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20210815.ICustomLocationInternal)this).SystemData = (Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20.ISystemData) content.GetValueForProperty("SystemData",((Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20210815.ICustomLocationInternal)this).SystemData, Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20.SystemDataTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20.IResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20.IResourceInternal)this).Id, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20.IResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20.IResourceInternal)this).Name, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20.IResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20.IResourceInternal)this).Type, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20.ITrackedResourceInternal)this).Tag = (Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20.ITrackedResourceTags) content.GetValueForProperty("Tag",((Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20.ITrackedResourceInternal)this).Tag, Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20.TrackedResourceTagsTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20.ITrackedResourceInternal)this).Location = (string) content.GetValueForProperty("Location",((Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20.ITrackedResourceInternal)this).Location, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20210815.ICustomLocationInternal)this).IdentityPrincipalId = (string) content.GetValueForProperty("IdentityPrincipalId",((Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20210815.ICustomLocationInternal)this).IdentityPrincipalId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20210815.ICustomLocationInternal)this).IdentityTenantId = (string) content.GetValueForProperty("IdentityTenantId",((Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20210815.ICustomLocationInternal)this).IdentityTenantId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20210815.ICustomLocationInternal)this).HostType = (Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Support.HostType?) content.GetValueForProperty("HostType",((Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20210815.ICustomLocationInternal)this).HostType, Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Support.HostType.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20210815.ICustomLocationInternal)this).SystemDataCreatedBy = (string) content.GetValueForProperty("SystemDataCreatedBy",((Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20210815.ICustomLocationInternal)this).SystemDataCreatedBy, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20210815.ICustomLocationInternal)this).SystemDataCreatedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataCreatedAt",((Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20210815.ICustomLocationInternal)this).SystemDataCreatedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20210815.ICustomLocationInternal)this).IdentityType = (Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Support.ResourceIdentityType?) content.GetValueForProperty("IdentityType",((Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20210815.ICustomLocationInternal)this).IdentityType, Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Support.ResourceIdentityType.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20210815.ICustomLocationInternal)this).Authentication = (Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20210815.ICustomLocationPropertiesAuthentication) content.GetValueForProperty("Authentication",((Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20210815.ICustomLocationInternal)this).Authentication, Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20210815.CustomLocationPropertiesAuthenticationTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20210815.ICustomLocationInternal)this).ClusterExtensionId = (string[]) content.GetValueForProperty("ClusterExtensionId",((Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20210815.ICustomLocationInternal)this).ClusterExtensionId, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            ((Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20210815.ICustomLocationInternal)this).DisplayName = (string) content.GetValueForProperty("DisplayName",((Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20210815.ICustomLocationInternal)this).DisplayName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20210815.ICustomLocationInternal)this).HostResourceId = (string) content.GetValueForProperty("HostResourceId",((Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20210815.ICustomLocationInternal)this).HostResourceId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20210815.ICustomLocationInternal)this).Namespace = (string) content.GetValueForProperty("Namespace",((Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20210815.ICustomLocationInternal)this).Namespace, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20210815.ICustomLocationInternal)this).ProvisioningState = (string) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20210815.ICustomLocationInternal)this).ProvisioningState, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20210815.ICustomLocationInternal)this).SystemDataCreatedByType = (Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Support.CreatedByType?) content.GetValueForProperty("SystemDataCreatedByType",((Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20210815.ICustomLocationInternal)this).SystemDataCreatedByType, Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Support.CreatedByType.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20210815.ICustomLocationInternal)this).SystemDataLastModifiedBy = (string) content.GetValueForProperty("SystemDataLastModifiedBy",((Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20210815.ICustomLocationInternal)this).SystemDataLastModifiedBy, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20210815.ICustomLocationInternal)this).SystemDataLastModifiedByType = (Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Support.CreatedByType?) content.GetValueForProperty("SystemDataLastModifiedByType",((Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20210815.ICustomLocationInternal)this).SystemDataLastModifiedByType, Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Support.CreatedByType.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20210815.ICustomLocationInternal)this).SystemDataLastModifiedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataLastModifiedAt",((Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20210815.ICustomLocationInternal)this).SystemDataLastModifiedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20210815.ICustomLocationInternal)this).AuthenticationType = (string) content.GetValueForProperty("AuthenticationType",((Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20210815.ICustomLocationInternal)this).AuthenticationType, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20210815.ICustomLocationInternal)this).AuthenticationValue = (string) content.GetValueForProperty("AuthenticationValue",((Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20210815.ICustomLocationInternal)this).AuthenticationValue, global::System.Convert.ToString);
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20210815.CustomLocation"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20210815.ICustomLocation" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20210815.ICustomLocation DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new CustomLocation(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20210815.CustomLocation"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20210815.ICustomLocation" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20210815.ICustomLocation DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new CustomLocation(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="CustomLocation" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20210815.ICustomLocation FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Custom Locations definition.
    [System.ComponentModel.TypeConverter(typeof(CustomLocationTypeConverter))]
    public partial interface ICustomLocation

    {

    }
}