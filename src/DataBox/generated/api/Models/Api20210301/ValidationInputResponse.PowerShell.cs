// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301
{
    using Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.PowerShell;

    /// <summary>
    /// Minimum properties that should be present in each individual validation response.
    /// </summary>
    [System.ComponentModel.TypeConverter(typeof(ValidationInputResponseTypeConverter))]
    public partial class ValidationInputResponse
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.ValidationInputResponse"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IValidationInputResponse" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IValidationInputResponse DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new ValidationInputResponse(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.ValidationInputResponse"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IValidationInputResponse" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IValidationInputResponse DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new ValidationInputResponse(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="ValidationInputResponse" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IValidationInputResponse FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.SerializationMode.IncludeAll)?.ToString();

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.ValidationInputResponse"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal ValidationInputResponse(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Error"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IValidationInputResponseInternal)this).Error = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.ICloudError) content.GetValueForProperty("Error",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IValidationInputResponseInternal)this).Error, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.CloudErrorTypeConverter.ConvertFrom);
            }
            if (content.Contains("ValidationType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IValidationInputResponseInternal)this).ValidationType = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.ValidationInputDiscriminator) content.GetValueForProperty("ValidationType",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IValidationInputResponseInternal)this).ValidationType, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.ValidationInputDiscriminator.CreateFrom);
            }
            if (content.Contains("Code"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IValidationInputResponseInternal)this).Code = (string) content.GetValueForProperty("Code",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IValidationInputResponseInternal)this).Code, global::System.Convert.ToString);
            }
            if (content.Contains("Message"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IValidationInputResponseInternal)this).Message = (string) content.GetValueForProperty("Message",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IValidationInputResponseInternal)this).Message, global::System.Convert.ToString);
            }
            if (content.Contains("Target"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IValidationInputResponseInternal)this).Target = (string) content.GetValueForProperty("Target",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IValidationInputResponseInternal)this).Target, global::System.Convert.ToString);
            }
            if (content.Contains("Detail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IValidationInputResponseInternal)this).Detail = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.ICloudError[]) content.GetValueForProperty("Detail",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IValidationInputResponseInternal)this).Detail, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.ICloudError>(__y, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.CloudErrorTypeConverter.ConvertFrom));
            }
            if (content.Contains("AdditionalInfo"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IValidationInputResponseInternal)this).AdditionalInfo = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IAdditionalErrorInfo[]) content.GetValueForProperty("AdditionalInfo",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IValidationInputResponseInternal)this).AdditionalInfo, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IAdditionalErrorInfo>(__y, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.AdditionalErrorInfoTypeConverter.ConvertFrom));
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.ValidationInputResponse"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal ValidationInputResponse(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Error"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IValidationInputResponseInternal)this).Error = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.ICloudError) content.GetValueForProperty("Error",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IValidationInputResponseInternal)this).Error, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.CloudErrorTypeConverter.ConvertFrom);
            }
            if (content.Contains("ValidationType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IValidationInputResponseInternal)this).ValidationType = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.ValidationInputDiscriminator) content.GetValueForProperty("ValidationType",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IValidationInputResponseInternal)this).ValidationType, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.ValidationInputDiscriminator.CreateFrom);
            }
            if (content.Contains("Code"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IValidationInputResponseInternal)this).Code = (string) content.GetValueForProperty("Code",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IValidationInputResponseInternal)this).Code, global::System.Convert.ToString);
            }
            if (content.Contains("Message"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IValidationInputResponseInternal)this).Message = (string) content.GetValueForProperty("Message",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IValidationInputResponseInternal)this).Message, global::System.Convert.ToString);
            }
            if (content.Contains("Target"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IValidationInputResponseInternal)this).Target = (string) content.GetValueForProperty("Target",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IValidationInputResponseInternal)this).Target, global::System.Convert.ToString);
            }
            if (content.Contains("Detail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IValidationInputResponseInternal)this).Detail = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.ICloudError[]) content.GetValueForProperty("Detail",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IValidationInputResponseInternal)this).Detail, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.ICloudError>(__y, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.CloudErrorTypeConverter.ConvertFrom));
            }
            if (content.Contains("AdditionalInfo"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IValidationInputResponseInternal)this).AdditionalInfo = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IAdditionalErrorInfo[]) content.GetValueForProperty("AdditionalInfo",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IValidationInputResponseInternal)this).AdditionalInfo, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IAdditionalErrorInfo>(__y, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.AdditionalErrorInfoTypeConverter.ConvertFrom));
            }
            AfterDeserializePSObject(content);
        }
    }
    /// Minimum properties that should be present in each individual validation response.
    [System.ComponentModel.TypeConverter(typeof(ValidationInputResponseTypeConverter))]
    public partial interface IValidationInputResponse

    {

    }
}