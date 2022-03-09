// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801
{
    using Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.PowerShell;

    /// <summary>Web Job Information.</summary>
    [System.ComponentModel.TypeConverter(typeof(WebJobTypeConverter))]
    public partial class WebJob
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.WebJob"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IWebJob" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IWebJob DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new WebJob(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.WebJob"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IWebJob" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IWebJob DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new WebJob(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="WebJob" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IWebJob FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.SerializationMode.IncludeAll)?.ToString();

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.WebJob"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal WebJob(global::System.Collections.IDictionary content)
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
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IWebJobInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IWebJobProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IWebJobInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.WebJobPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IProxyOnlyResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IProxyOnlyResourceInternal)this).Id, global::System.Convert.ToString);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IProxyOnlyResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IProxyOnlyResourceInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("Kind"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IProxyOnlyResourceInternal)this).Kind = (string) content.GetValueForProperty("Kind",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IProxyOnlyResourceInternal)this).Kind, global::System.Convert.ToString);
            }
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IProxyOnlyResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IProxyOnlyResourceInternal)this).Type, global::System.Convert.ToString);
            }
            if (content.Contains("RunCommand"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IWebJobInternal)this).RunCommand = (string) content.GetValueForProperty("RunCommand",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IWebJobInternal)this).RunCommand, global::System.Convert.ToString);
            }
            if (content.Contains("Url"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IWebJobInternal)this).Url = (string) content.GetValueForProperty("Url",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IWebJobInternal)this).Url, global::System.Convert.ToString);
            }
            if (content.Contains("ExtraInfoUrl"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IWebJobInternal)this).ExtraInfoUrl = (string) content.GetValueForProperty("ExtraInfoUrl",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IWebJobInternal)this).ExtraInfoUrl, global::System.Convert.ToString);
            }
            if (content.Contains("WebJobType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IWebJobInternal)this).WebJobType = (Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.WebJobType?) content.GetValueForProperty("WebJobType",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IWebJobInternal)this).WebJobType, Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.WebJobType.CreateFrom);
            }
            if (content.Contains("Error"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IWebJobInternal)this).Error = (string) content.GetValueForProperty("Error",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IWebJobInternal)this).Error, global::System.Convert.ToString);
            }
            if (content.Contains("UsingSdk"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IWebJobInternal)this).UsingSdk = (bool?) content.GetValueForProperty("UsingSdk",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IWebJobInternal)this).UsingSdk, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("Setting"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IWebJobInternal)this).Setting = (Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IWebJobPropertiesSettings) content.GetValueForProperty("Setting",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IWebJobInternal)this).Setting, Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.WebJobPropertiesSettingsTypeConverter.ConvertFrom);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.WebJob"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal WebJob(global::System.Management.Automation.PSObject content)
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
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IWebJobInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IWebJobProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IWebJobInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.WebJobPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IProxyOnlyResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IProxyOnlyResourceInternal)this).Id, global::System.Convert.ToString);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IProxyOnlyResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IProxyOnlyResourceInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("Kind"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IProxyOnlyResourceInternal)this).Kind = (string) content.GetValueForProperty("Kind",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IProxyOnlyResourceInternal)this).Kind, global::System.Convert.ToString);
            }
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IProxyOnlyResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IProxyOnlyResourceInternal)this).Type, global::System.Convert.ToString);
            }
            if (content.Contains("RunCommand"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IWebJobInternal)this).RunCommand = (string) content.GetValueForProperty("RunCommand",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IWebJobInternal)this).RunCommand, global::System.Convert.ToString);
            }
            if (content.Contains("Url"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IWebJobInternal)this).Url = (string) content.GetValueForProperty("Url",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IWebJobInternal)this).Url, global::System.Convert.ToString);
            }
            if (content.Contains("ExtraInfoUrl"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IWebJobInternal)this).ExtraInfoUrl = (string) content.GetValueForProperty("ExtraInfoUrl",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IWebJobInternal)this).ExtraInfoUrl, global::System.Convert.ToString);
            }
            if (content.Contains("WebJobType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IWebJobInternal)this).WebJobType = (Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.WebJobType?) content.GetValueForProperty("WebJobType",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IWebJobInternal)this).WebJobType, Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.WebJobType.CreateFrom);
            }
            if (content.Contains("Error"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IWebJobInternal)this).Error = (string) content.GetValueForProperty("Error",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IWebJobInternal)this).Error, global::System.Convert.ToString);
            }
            if (content.Contains("UsingSdk"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IWebJobInternal)this).UsingSdk = (bool?) content.GetValueForProperty("UsingSdk",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IWebJobInternal)this).UsingSdk, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("Setting"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IWebJobInternal)this).Setting = (Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IWebJobPropertiesSettings) content.GetValueForProperty("Setting",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IWebJobInternal)this).Setting, Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.WebJobPropertiesSettingsTypeConverter.ConvertFrom);
            }
            AfterDeserializePSObject(content);
        }
    }
    /// Web Job Information.
    [System.ComponentModel.TypeConverter(typeof(WebJobTypeConverter))]
    public partial interface IWebJob

    {

    }
}