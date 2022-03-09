// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview
{
    using Microsoft.Azure.PowerShell.Cmdlets.Quota.Runtime.PowerShell;

    /// <summary>Quota limit.</summary>
    [System.ComponentModel.TypeConverter(typeof(CurrentQuotaLimitBaseTypeConverter))]
    public partial class CurrentQuotaLimitBase
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
        /// <c>OverrideToString</c> will be called if it is implemented. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="stringResult">/// instance serialized to a string, normally it is a Json</param>
        /// <param name="returnNow">/// set returnNow to true if you provide a customized OverrideToString function</param>

        partial void OverrideToString(ref string stringResult, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.CurrentQuotaLimitBase"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal CurrentQuotaLimitBase(global::System.Collections.IDictionary content)
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
                ((Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.ICurrentQuotaLimitBaseInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.IQuotaProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.ICurrentQuotaLimitBaseInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.QuotaPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.ICurrentQuotaLimitBaseInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.ICurrentQuotaLimitBaseInternal)this).Id, global::System.Convert.ToString);
            }
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.ICurrentQuotaLimitBaseInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.ICurrentQuotaLimitBaseInternal)this).Type, global::System.Convert.ToString);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.ICurrentQuotaLimitBaseInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.ICurrentQuotaLimitBaseInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("ETag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.ICurrentQuotaLimitBaseInternal)this).ETag = (string) content.GetValueForProperty("ETag",((Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.ICurrentQuotaLimitBaseInternal)this).ETag, global::System.Convert.ToString);
            }
            if (content.Contains("AnyProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.ICurrentQuotaLimitBaseInternal)this).AnyProperty = (Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.IAny) content.GetValueForProperty("AnyProperty",((Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.ICurrentQuotaLimitBaseInternal)this).AnyProperty, Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.AnyTypeConverter.ConvertFrom);
            }
            if (content.Contains("PropertiesName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.ICurrentQuotaLimitBaseInternal)this).PropertiesName = (Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.IResourceName) content.GetValueForProperty("PropertiesName",((Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.ICurrentQuotaLimitBaseInternal)this).PropertiesName, Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.ResourceNameTypeConverter.ConvertFrom);
            }
            if (content.Contains("Limit"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.ICurrentQuotaLimitBaseInternal)this).Limit = (Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.ILimitJsonObject) content.GetValueForProperty("Limit",((Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.ICurrentQuotaLimitBaseInternal)this).Limit, Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.LimitJsonObjectTypeConverter.ConvertFrom);
            }
            if (content.Contains("Unit"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.ICurrentQuotaLimitBaseInternal)this).Unit = (string) content.GetValueForProperty("Unit",((Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.ICurrentQuotaLimitBaseInternal)this).Unit, global::System.Convert.ToString);
            }
            if (content.Contains("ResourceType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.ICurrentQuotaLimitBaseInternal)this).ResourceType = (string) content.GetValueForProperty("ResourceType",((Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.ICurrentQuotaLimitBaseInternal)this).ResourceType, global::System.Convert.ToString);
            }
            if (content.Contains("QuotaPeriod"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.ICurrentQuotaLimitBaseInternal)this).QuotaPeriod = (string) content.GetValueForProperty("QuotaPeriod",((Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.ICurrentQuotaLimitBaseInternal)this).QuotaPeriod, global::System.Convert.ToString);
            }
            if (content.Contains("IsQuotaApplicable"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.ICurrentQuotaLimitBaseInternal)this).IsQuotaApplicable = (bool?) content.GetValueForProperty("IsQuotaApplicable",((Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.ICurrentQuotaLimitBaseInternal)this).IsQuotaApplicable, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("NameValue"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.ICurrentQuotaLimitBaseInternal)this).NameValue = (string) content.GetValueForProperty("NameValue",((Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.ICurrentQuotaLimitBaseInternal)this).NameValue, global::System.Convert.ToString);
            }
            if (content.Contains("NameLocalizedValue"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.ICurrentQuotaLimitBaseInternal)this).NameLocalizedValue = (string) content.GetValueForProperty("NameLocalizedValue",((Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.ICurrentQuotaLimitBaseInternal)this).NameLocalizedValue, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.CurrentQuotaLimitBase"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal CurrentQuotaLimitBase(global::System.Management.Automation.PSObject content)
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
                ((Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.ICurrentQuotaLimitBaseInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.IQuotaProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.ICurrentQuotaLimitBaseInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.QuotaPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.ICurrentQuotaLimitBaseInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.ICurrentQuotaLimitBaseInternal)this).Id, global::System.Convert.ToString);
            }
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.ICurrentQuotaLimitBaseInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.ICurrentQuotaLimitBaseInternal)this).Type, global::System.Convert.ToString);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.ICurrentQuotaLimitBaseInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.ICurrentQuotaLimitBaseInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("ETag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.ICurrentQuotaLimitBaseInternal)this).ETag = (string) content.GetValueForProperty("ETag",((Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.ICurrentQuotaLimitBaseInternal)this).ETag, global::System.Convert.ToString);
            }
            if (content.Contains("AnyProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.ICurrentQuotaLimitBaseInternal)this).AnyProperty = (Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.IAny) content.GetValueForProperty("AnyProperty",((Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.ICurrentQuotaLimitBaseInternal)this).AnyProperty, Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.AnyTypeConverter.ConvertFrom);
            }
            if (content.Contains("PropertiesName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.ICurrentQuotaLimitBaseInternal)this).PropertiesName = (Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.IResourceName) content.GetValueForProperty("PropertiesName",((Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.ICurrentQuotaLimitBaseInternal)this).PropertiesName, Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.ResourceNameTypeConverter.ConvertFrom);
            }
            if (content.Contains("Limit"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.ICurrentQuotaLimitBaseInternal)this).Limit = (Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.ILimitJsonObject) content.GetValueForProperty("Limit",((Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.ICurrentQuotaLimitBaseInternal)this).Limit, Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.LimitJsonObjectTypeConverter.ConvertFrom);
            }
            if (content.Contains("Unit"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.ICurrentQuotaLimitBaseInternal)this).Unit = (string) content.GetValueForProperty("Unit",((Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.ICurrentQuotaLimitBaseInternal)this).Unit, global::System.Convert.ToString);
            }
            if (content.Contains("ResourceType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.ICurrentQuotaLimitBaseInternal)this).ResourceType = (string) content.GetValueForProperty("ResourceType",((Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.ICurrentQuotaLimitBaseInternal)this).ResourceType, global::System.Convert.ToString);
            }
            if (content.Contains("QuotaPeriod"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.ICurrentQuotaLimitBaseInternal)this).QuotaPeriod = (string) content.GetValueForProperty("QuotaPeriod",((Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.ICurrentQuotaLimitBaseInternal)this).QuotaPeriod, global::System.Convert.ToString);
            }
            if (content.Contains("IsQuotaApplicable"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.ICurrentQuotaLimitBaseInternal)this).IsQuotaApplicable = (bool?) content.GetValueForProperty("IsQuotaApplicable",((Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.ICurrentQuotaLimitBaseInternal)this).IsQuotaApplicable, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("NameValue"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.ICurrentQuotaLimitBaseInternal)this).NameValue = (string) content.GetValueForProperty("NameValue",((Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.ICurrentQuotaLimitBaseInternal)this).NameValue, global::System.Convert.ToString);
            }
            if (content.Contains("NameLocalizedValue"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.ICurrentQuotaLimitBaseInternal)this).NameLocalizedValue = (string) content.GetValueForProperty("NameLocalizedValue",((Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.ICurrentQuotaLimitBaseInternal)this).NameLocalizedValue, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.CurrentQuotaLimitBase"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.ICurrentQuotaLimitBase" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.ICurrentQuotaLimitBase DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new CurrentQuotaLimitBase(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.CurrentQuotaLimitBase"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.ICurrentQuotaLimitBase" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.ICurrentQuotaLimitBase DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new CurrentQuotaLimitBase(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="CurrentQuotaLimitBase" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.ICurrentQuotaLimitBase FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.Quota.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.Quota.Runtime.SerializationMode.IncludeAll)?.ToString();

        public override string ToString()
        {
            var returnNow = false;
            var result = global::System.String.Empty;
            OverrideToString(ref result, ref returnNow);
            if (returnNow)
            {
                return result;
            }
            return ToJsonString();
        }
    }
    /// Quota limit.
    [System.ComponentModel.TypeConverter(typeof(CurrentQuotaLimitBaseTypeConverter))]
    public partial interface ICurrentQuotaLimitBase

    {

    }
}