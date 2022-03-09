// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview
{
    using Microsoft.Azure.PowerShell.Cmdlets.Quota.Runtime.PowerShell;

    /// <summary>Quota request status details.</summary>
    [System.ComponentModel.TypeConverter(typeof(QuotaRequestStatusDetailsTypeConverter))]
    public partial class QuotaRequestStatusDetails
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.QuotaRequestStatusDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.IQuotaRequestStatusDetails"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.IQuotaRequestStatusDetails DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new QuotaRequestStatusDetails(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.QuotaRequestStatusDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.IQuotaRequestStatusDetails"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.IQuotaRequestStatusDetails DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new QuotaRequestStatusDetails(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="QuotaRequestStatusDetails" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.IQuotaRequestStatusDetails FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.Quota.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.QuotaRequestStatusDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal QuotaRequestStatusDetails(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Limit"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.IQuotaRequestStatusDetailsInternal)this).Limit = (Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.ILimitObject) content.GetValueForProperty("Limit",((Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.IQuotaRequestStatusDetailsInternal)this).Limit, Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.LimitObjectTypeConverter.ConvertFrom);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.IQuotaRequestStatusDetailsInternal)this).Name = (Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.IResourceName) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.IQuotaRequestStatusDetailsInternal)this).Name, Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.ResourceNameTypeConverter.ConvertFrom);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.IQuotaRequestStatusDetailsInternal)this).ProvisioningState = (Microsoft.Azure.PowerShell.Cmdlets.Quota.Support.QuotaRequestState?) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.IQuotaRequestStatusDetailsInternal)this).ProvisioningState, Microsoft.Azure.PowerShell.Cmdlets.Quota.Support.QuotaRequestState.CreateFrom);
            }
            if (content.Contains("Message"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.IQuotaRequestStatusDetailsInternal)this).Message = (string) content.GetValueForProperty("Message",((Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.IQuotaRequestStatusDetailsInternal)this).Message, global::System.Convert.ToString);
            }
            if (content.Contains("Unit"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.IQuotaRequestStatusDetailsInternal)this).Unit = (string) content.GetValueForProperty("Unit",((Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.IQuotaRequestStatusDetailsInternal)this).Unit, global::System.Convert.ToString);
            }
            if (content.Contains("ResourceType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.IQuotaRequestStatusDetailsInternal)this).ResourceType = (string) content.GetValueForProperty("ResourceType",((Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.IQuotaRequestStatusDetailsInternal)this).ResourceType, global::System.Convert.ToString);
            }
            if (content.Contains("QuotaPeriod"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.IQuotaRequestStatusDetailsInternal)this).QuotaPeriod = (string) content.GetValueForProperty("QuotaPeriod",((Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.IQuotaRequestStatusDetailsInternal)this).QuotaPeriod, global::System.Convert.ToString);
            }
            if (content.Contains("Property"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.IQuotaRequestStatusDetailsInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.IAny) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.IQuotaRequestStatusDetailsInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.AnyTypeConverter.ConvertFrom);
            }
            if (content.Contains("LimitObjectType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.IQuotaRequestStatusDetailsInternal)this).LimitObjectType = (string) content.GetValueForProperty("LimitObjectType",((Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.IQuotaRequestStatusDetailsInternal)this).LimitObjectType, global::System.Convert.ToString);
            }
            if (content.Contains("LimitValue"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.IQuotaRequestStatusDetailsInternal)this).LimitValue = (int) content.GetValueForProperty("LimitValue",((Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.IQuotaRequestStatusDetailsInternal)this).LimitValue, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("LimitType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.IQuotaRequestStatusDetailsInternal)this).LimitType = (Microsoft.Azure.PowerShell.Cmdlets.Quota.Support.QuotaLimitTypes?) content.GetValueForProperty("LimitType",((Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.IQuotaRequestStatusDetailsInternal)this).LimitType, Microsoft.Azure.PowerShell.Cmdlets.Quota.Support.QuotaLimitTypes.CreateFrom);
            }
            if (content.Contains("NameValue"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.IQuotaRequestStatusDetailsInternal)this).NameValue = (string) content.GetValueForProperty("NameValue",((Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.IQuotaRequestStatusDetailsInternal)this).NameValue, global::System.Convert.ToString);
            }
            if (content.Contains("NameLocalizedValue"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.IQuotaRequestStatusDetailsInternal)this).NameLocalizedValue = (string) content.GetValueForProperty("NameLocalizedValue",((Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.IQuotaRequestStatusDetailsInternal)this).NameLocalizedValue, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.QuotaRequestStatusDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal QuotaRequestStatusDetails(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Limit"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.IQuotaRequestStatusDetailsInternal)this).Limit = (Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.ILimitObject) content.GetValueForProperty("Limit",((Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.IQuotaRequestStatusDetailsInternal)this).Limit, Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.LimitObjectTypeConverter.ConvertFrom);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.IQuotaRequestStatusDetailsInternal)this).Name = (Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.IResourceName) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.IQuotaRequestStatusDetailsInternal)this).Name, Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.ResourceNameTypeConverter.ConvertFrom);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.IQuotaRequestStatusDetailsInternal)this).ProvisioningState = (Microsoft.Azure.PowerShell.Cmdlets.Quota.Support.QuotaRequestState?) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.IQuotaRequestStatusDetailsInternal)this).ProvisioningState, Microsoft.Azure.PowerShell.Cmdlets.Quota.Support.QuotaRequestState.CreateFrom);
            }
            if (content.Contains("Message"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.IQuotaRequestStatusDetailsInternal)this).Message = (string) content.GetValueForProperty("Message",((Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.IQuotaRequestStatusDetailsInternal)this).Message, global::System.Convert.ToString);
            }
            if (content.Contains("Unit"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.IQuotaRequestStatusDetailsInternal)this).Unit = (string) content.GetValueForProperty("Unit",((Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.IQuotaRequestStatusDetailsInternal)this).Unit, global::System.Convert.ToString);
            }
            if (content.Contains("ResourceType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.IQuotaRequestStatusDetailsInternal)this).ResourceType = (string) content.GetValueForProperty("ResourceType",((Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.IQuotaRequestStatusDetailsInternal)this).ResourceType, global::System.Convert.ToString);
            }
            if (content.Contains("QuotaPeriod"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.IQuotaRequestStatusDetailsInternal)this).QuotaPeriod = (string) content.GetValueForProperty("QuotaPeriod",((Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.IQuotaRequestStatusDetailsInternal)this).QuotaPeriod, global::System.Convert.ToString);
            }
            if (content.Contains("Property"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.IQuotaRequestStatusDetailsInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.IAny) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.IQuotaRequestStatusDetailsInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.AnyTypeConverter.ConvertFrom);
            }
            if (content.Contains("LimitObjectType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.IQuotaRequestStatusDetailsInternal)this).LimitObjectType = (string) content.GetValueForProperty("LimitObjectType",((Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.IQuotaRequestStatusDetailsInternal)this).LimitObjectType, global::System.Convert.ToString);
            }
            if (content.Contains("LimitValue"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.IQuotaRequestStatusDetailsInternal)this).LimitValue = (int) content.GetValueForProperty("LimitValue",((Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.IQuotaRequestStatusDetailsInternal)this).LimitValue, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("LimitType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.IQuotaRequestStatusDetailsInternal)this).LimitType = (Microsoft.Azure.PowerShell.Cmdlets.Quota.Support.QuotaLimitTypes?) content.GetValueForProperty("LimitType",((Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.IQuotaRequestStatusDetailsInternal)this).LimitType, Microsoft.Azure.PowerShell.Cmdlets.Quota.Support.QuotaLimitTypes.CreateFrom);
            }
            if (content.Contains("NameValue"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.IQuotaRequestStatusDetailsInternal)this).NameValue = (string) content.GetValueForProperty("NameValue",((Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.IQuotaRequestStatusDetailsInternal)this).NameValue, global::System.Convert.ToString);
            }
            if (content.Contains("NameLocalizedValue"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.IQuotaRequestStatusDetailsInternal)this).NameLocalizedValue = (string) content.GetValueForProperty("NameLocalizedValue",((Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.IQuotaRequestStatusDetailsInternal)this).NameLocalizedValue, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

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
    /// Quota request status details.
    [System.ComponentModel.TypeConverter(typeof(QuotaRequestStatusDetailsTypeConverter))]
    public partial interface IQuotaRequestStatusDetails

    {

    }
}