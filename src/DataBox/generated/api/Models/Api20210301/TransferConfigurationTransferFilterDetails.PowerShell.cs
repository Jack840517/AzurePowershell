// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301
{
    using Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.PowerShell;

    /// <summary>
    /// Map of filter type and the details to filter. This field is required only if the TransferConfigurationType is given as
    /// TransferUsingFilter.
    /// </summary>
    [System.ComponentModel.TypeConverter(typeof(TransferConfigurationTransferFilterDetailsTypeConverter))]
    public partial class TransferConfigurationTransferFilterDetails
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.TransferConfigurationTransferFilterDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.ITransferConfigurationTransferFilterDetails"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.ITransferConfigurationTransferFilterDetails DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new TransferConfigurationTransferFilterDetails(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.TransferConfigurationTransferFilterDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.ITransferConfigurationTransferFilterDetails"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.ITransferConfigurationTransferFilterDetails DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new TransferConfigurationTransferFilterDetails(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="TransferConfigurationTransferFilterDetails" />, deserializing the content from a
        /// json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.ITransferConfigurationTransferFilterDetails FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.SerializationMode.IncludeAll)?.ToString();

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.TransferConfigurationTransferFilterDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal TransferConfigurationTransferFilterDetails(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Include"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.ITransferConfigurationTransferFilterDetailsInternal)this).Include = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.ITransferFilterDetails) content.GetValueForProperty("Include",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.ITransferConfigurationTransferFilterDetailsInternal)this).Include, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.TransferFilterDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("IncludeBlobFilterDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.ITransferConfigurationTransferFilterDetailsInternal)this).IncludeBlobFilterDetail = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IBlobFilterDetails) content.GetValueForProperty("IncludeBlobFilterDetail",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.ITransferConfigurationTransferFilterDetailsInternal)this).IncludeBlobFilterDetail, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.BlobFilterDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("IncludeAzureFileFilterDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.ITransferConfigurationTransferFilterDetailsInternal)this).IncludeAzureFileFilterDetail = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IAzureFileFilterDetails) content.GetValueForProperty("IncludeAzureFileFilterDetail",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.ITransferConfigurationTransferFilterDetailsInternal)this).IncludeAzureFileFilterDetail, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.AzureFileFilterDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("IncludeDataAccountType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.ITransferConfigurationTransferFilterDetailsInternal)this).IncludeDataAccountType = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.DataAccountType) content.GetValueForProperty("IncludeDataAccountType",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.ITransferConfigurationTransferFilterDetailsInternal)this).IncludeDataAccountType, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.DataAccountType.CreateFrom);
            }
            if (content.Contains("IncludeFilterFileDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.ITransferConfigurationTransferFilterDetailsInternal)this).IncludeFilterFileDetail = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IFilterFileDetails[]) content.GetValueForProperty("IncludeFilterFileDetail",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.ITransferConfigurationTransferFilterDetailsInternal)this).IncludeFilterFileDetail, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IFilterFileDetails>(__y, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.FilterFileDetailsTypeConverter.ConvertFrom));
            }
            if (content.Contains("BlobFilterDetailContainerList"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.ITransferConfigurationTransferFilterDetailsInternal)this).BlobFilterDetailContainerList = (string[]) content.GetValueForProperty("BlobFilterDetailContainerList",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.ITransferConfigurationTransferFilterDetailsInternal)this).BlobFilterDetailContainerList, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("BlobFilterDetailBlobPrefixList"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.ITransferConfigurationTransferFilterDetailsInternal)this).BlobFilterDetailBlobPrefixList = (string[]) content.GetValueForProperty("BlobFilterDetailBlobPrefixList",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.ITransferConfigurationTransferFilterDetailsInternal)this).BlobFilterDetailBlobPrefixList, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("BlobFilterDetailBlobPathList"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.ITransferConfigurationTransferFilterDetailsInternal)this).BlobFilterDetailBlobPathList = (string[]) content.GetValueForProperty("BlobFilterDetailBlobPathList",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.ITransferConfigurationTransferFilterDetailsInternal)this).BlobFilterDetailBlobPathList, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("AzureFileFilterDetailFilePrefixList"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.ITransferConfigurationTransferFilterDetailsInternal)this).AzureFileFilterDetailFilePrefixList = (string[]) content.GetValueForProperty("AzureFileFilterDetailFilePrefixList",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.ITransferConfigurationTransferFilterDetailsInternal)this).AzureFileFilterDetailFilePrefixList, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("AzureFileFilterDetailFilePathList"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.ITransferConfigurationTransferFilterDetailsInternal)this).AzureFileFilterDetailFilePathList = (string[]) content.GetValueForProperty("AzureFileFilterDetailFilePathList",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.ITransferConfigurationTransferFilterDetailsInternal)this).AzureFileFilterDetailFilePathList, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("AzureFileFilterDetailFileShareList"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.ITransferConfigurationTransferFilterDetailsInternal)this).AzureFileFilterDetailFileShareList = (string[]) content.GetValueForProperty("AzureFileFilterDetailFileShareList",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.ITransferConfigurationTransferFilterDetailsInternal)this).AzureFileFilterDetailFileShareList, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.TransferConfigurationTransferFilterDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal TransferConfigurationTransferFilterDetails(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Include"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.ITransferConfigurationTransferFilterDetailsInternal)this).Include = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.ITransferFilterDetails) content.GetValueForProperty("Include",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.ITransferConfigurationTransferFilterDetailsInternal)this).Include, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.TransferFilterDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("IncludeBlobFilterDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.ITransferConfigurationTransferFilterDetailsInternal)this).IncludeBlobFilterDetail = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IBlobFilterDetails) content.GetValueForProperty("IncludeBlobFilterDetail",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.ITransferConfigurationTransferFilterDetailsInternal)this).IncludeBlobFilterDetail, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.BlobFilterDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("IncludeAzureFileFilterDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.ITransferConfigurationTransferFilterDetailsInternal)this).IncludeAzureFileFilterDetail = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IAzureFileFilterDetails) content.GetValueForProperty("IncludeAzureFileFilterDetail",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.ITransferConfigurationTransferFilterDetailsInternal)this).IncludeAzureFileFilterDetail, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.AzureFileFilterDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("IncludeDataAccountType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.ITransferConfigurationTransferFilterDetailsInternal)this).IncludeDataAccountType = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.DataAccountType) content.GetValueForProperty("IncludeDataAccountType",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.ITransferConfigurationTransferFilterDetailsInternal)this).IncludeDataAccountType, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.DataAccountType.CreateFrom);
            }
            if (content.Contains("IncludeFilterFileDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.ITransferConfigurationTransferFilterDetailsInternal)this).IncludeFilterFileDetail = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IFilterFileDetails[]) content.GetValueForProperty("IncludeFilterFileDetail",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.ITransferConfigurationTransferFilterDetailsInternal)this).IncludeFilterFileDetail, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IFilterFileDetails>(__y, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.FilterFileDetailsTypeConverter.ConvertFrom));
            }
            if (content.Contains("BlobFilterDetailContainerList"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.ITransferConfigurationTransferFilterDetailsInternal)this).BlobFilterDetailContainerList = (string[]) content.GetValueForProperty("BlobFilterDetailContainerList",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.ITransferConfigurationTransferFilterDetailsInternal)this).BlobFilterDetailContainerList, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("BlobFilterDetailBlobPrefixList"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.ITransferConfigurationTransferFilterDetailsInternal)this).BlobFilterDetailBlobPrefixList = (string[]) content.GetValueForProperty("BlobFilterDetailBlobPrefixList",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.ITransferConfigurationTransferFilterDetailsInternal)this).BlobFilterDetailBlobPrefixList, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("BlobFilterDetailBlobPathList"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.ITransferConfigurationTransferFilterDetailsInternal)this).BlobFilterDetailBlobPathList = (string[]) content.GetValueForProperty("BlobFilterDetailBlobPathList",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.ITransferConfigurationTransferFilterDetailsInternal)this).BlobFilterDetailBlobPathList, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("AzureFileFilterDetailFilePrefixList"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.ITransferConfigurationTransferFilterDetailsInternal)this).AzureFileFilterDetailFilePrefixList = (string[]) content.GetValueForProperty("AzureFileFilterDetailFilePrefixList",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.ITransferConfigurationTransferFilterDetailsInternal)this).AzureFileFilterDetailFilePrefixList, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("AzureFileFilterDetailFilePathList"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.ITransferConfigurationTransferFilterDetailsInternal)this).AzureFileFilterDetailFilePathList = (string[]) content.GetValueForProperty("AzureFileFilterDetailFilePathList",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.ITransferConfigurationTransferFilterDetailsInternal)this).AzureFileFilterDetailFilePathList, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("AzureFileFilterDetailFileShareList"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.ITransferConfigurationTransferFilterDetailsInternal)this).AzureFileFilterDetailFileShareList = (string[]) content.GetValueForProperty("AzureFileFilterDetailFileShareList",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.ITransferConfigurationTransferFilterDetailsInternal)this).AzureFileFilterDetailFileShareList, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            }
            AfterDeserializePSObject(content);
        }
    }
    /// Map of filter type and the details to filter. This field is required only if the TransferConfigurationType is given as
    /// TransferUsingFilter.
    [System.ComponentModel.TypeConverter(typeof(TransferConfigurationTransferFilterDetailsTypeConverter))]
    public partial interface ITransferConfigurationTransferFilterDetails

    {

    }
}