// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701
{
    using Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.PowerShell;

    /// <summary>This is the OS disk image.</summary>
    [System.ComponentModel.TypeConverter(typeof(GalleryOSDiskImageTypeConverter))]
    public partial class GalleryOSDiskImage
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.GalleryOSDiskImage"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryOSDiskImage" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryOSDiskImage DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new GalleryOSDiskImage(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.GalleryOSDiskImage"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryOSDiskImage" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryOSDiskImage DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new GalleryOSDiskImage(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="GalleryOSDiskImage" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryOSDiskImage FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.GalleryOSDiskImage"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal GalleryOSDiskImage(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryDiskImageInternal)this).SourceId = (string) content.GetValueForProperty("SourceId",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryDiskImageInternal)this).SourceId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryDiskImageInternal)this).SourceUri = (string) content.GetValueForProperty("SourceUri",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryDiskImageInternal)this).SourceUri, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryDiskImageInternal)this).Source = (Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryArtifactVersionSource) content.GetValueForProperty("Source",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryDiskImageInternal)this).Source, Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.GalleryArtifactVersionSourceTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryDiskImageInternal)this).SizeInGb = (int?) content.GetValueForProperty("SizeInGb",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryDiskImageInternal)this).SizeInGb, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryDiskImageInternal)this).HostCaching = (Microsoft.Azure.PowerShell.Cmdlets.Compute.Support.HostCaching?) content.GetValueForProperty("HostCaching",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryDiskImageInternal)this).HostCaching, Microsoft.Azure.PowerShell.Cmdlets.Compute.Support.HostCaching.CreateFrom);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.GalleryOSDiskImage"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal GalleryOSDiskImage(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryDiskImageInternal)this).SourceId = (string) content.GetValueForProperty("SourceId",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryDiskImageInternal)this).SourceId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryDiskImageInternal)this).SourceUri = (string) content.GetValueForProperty("SourceUri",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryDiskImageInternal)this).SourceUri, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryDiskImageInternal)this).Source = (Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryArtifactVersionSource) content.GetValueForProperty("Source",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryDiskImageInternal)this).Source, Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.GalleryArtifactVersionSourceTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryDiskImageInternal)this).SizeInGb = (int?) content.GetValueForProperty("SizeInGb",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryDiskImageInternal)this).SizeInGb, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryDiskImageInternal)this).HostCaching = (Microsoft.Azure.PowerShell.Cmdlets.Compute.Support.HostCaching?) content.GetValueForProperty("HostCaching",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryDiskImageInternal)this).HostCaching, Microsoft.Azure.PowerShell.Cmdlets.Compute.Support.HostCaching.CreateFrom);
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// This is the OS disk image.
    [System.ComponentModel.TypeConverter(typeof(GalleryOSDiskImageTypeConverter))]
    public partial interface IGalleryOSDiskImage

    {

    }
}