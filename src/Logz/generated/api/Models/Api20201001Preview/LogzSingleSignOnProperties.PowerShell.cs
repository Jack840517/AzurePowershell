// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview
{
    using Microsoft.Azure.PowerShell.Cmdlets.Logz.Runtime.PowerShell;

    [System.ComponentModel.TypeConverter(typeof(LogzSingleSignOnPropertiesTypeConverter))]
    public partial class LogzSingleSignOnProperties
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview.LogzSingleSignOnProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview.ILogzSingleSignOnProperties"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview.ILogzSingleSignOnProperties DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new LogzSingleSignOnProperties(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview.LogzSingleSignOnProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview.ILogzSingleSignOnProperties"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview.ILogzSingleSignOnProperties DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new LogzSingleSignOnProperties(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="LogzSingleSignOnProperties" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview.ILogzSingleSignOnProperties FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.Logz.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview.LogzSingleSignOnProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal LogzSingleSignOnProperties(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview.ILogzSingleSignOnPropertiesInternal)this).SingleSignOnState = (Microsoft.Azure.PowerShell.Cmdlets.Logz.Support.SingleSignOnStates?) content.GetValueForProperty("SingleSignOnState",((Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview.ILogzSingleSignOnPropertiesInternal)this).SingleSignOnState, Microsoft.Azure.PowerShell.Cmdlets.Logz.Support.SingleSignOnStates.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview.ILogzSingleSignOnPropertiesInternal)this).EnterpriseAppId = (string) content.GetValueForProperty("EnterpriseAppId",((Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview.ILogzSingleSignOnPropertiesInternal)this).EnterpriseAppId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview.ILogzSingleSignOnPropertiesInternal)this).SingleSignOnUrl = (string) content.GetValueForProperty("SingleSignOnUrl",((Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview.ILogzSingleSignOnPropertiesInternal)this).SingleSignOnUrl, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview.ILogzSingleSignOnPropertiesInternal)this).ProvisioningState = (Microsoft.Azure.PowerShell.Cmdlets.Logz.Support.ProvisioningState?) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview.ILogzSingleSignOnPropertiesInternal)this).ProvisioningState, Microsoft.Azure.PowerShell.Cmdlets.Logz.Support.ProvisioningState.CreateFrom);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview.LogzSingleSignOnProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal LogzSingleSignOnProperties(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview.ILogzSingleSignOnPropertiesInternal)this).SingleSignOnState = (Microsoft.Azure.PowerShell.Cmdlets.Logz.Support.SingleSignOnStates?) content.GetValueForProperty("SingleSignOnState",((Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview.ILogzSingleSignOnPropertiesInternal)this).SingleSignOnState, Microsoft.Azure.PowerShell.Cmdlets.Logz.Support.SingleSignOnStates.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview.ILogzSingleSignOnPropertiesInternal)this).EnterpriseAppId = (string) content.GetValueForProperty("EnterpriseAppId",((Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview.ILogzSingleSignOnPropertiesInternal)this).EnterpriseAppId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview.ILogzSingleSignOnPropertiesInternal)this).SingleSignOnUrl = (string) content.GetValueForProperty("SingleSignOnUrl",((Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview.ILogzSingleSignOnPropertiesInternal)this).SingleSignOnUrl, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview.ILogzSingleSignOnPropertiesInternal)this).ProvisioningState = (Microsoft.Azure.PowerShell.Cmdlets.Logz.Support.ProvisioningState?) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview.ILogzSingleSignOnPropertiesInternal)this).ProvisioningState, Microsoft.Azure.PowerShell.Cmdlets.Logz.Support.ProvisioningState.CreateFrom);
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.Logz.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    [System.ComponentModel.TypeConverter(typeof(LogzSingleSignOnPropertiesTypeConverter))]
    public partial interface ILogzSingleSignOnProperties

    {

    }
}