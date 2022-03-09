// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20210901
{
    using Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Runtime.PowerShell;

    /// <summary>The Extension Patch Request object.</summary>
    [System.ComponentModel.TypeConverter(typeof(PatchExtensionTypeConverter))]
    public partial class PatchExtension
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20210901.PatchExtension"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20210901.IPatchExtension"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20210901.IPatchExtension DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new PatchExtension(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20210901.PatchExtension"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20210901.IPatchExtension"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20210901.IPatchExtension DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new PatchExtension(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="PatchExtension" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20210901.IPatchExtension FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20210901.PatchExtension"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal PatchExtension(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20210901.IPatchExtensionInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20210901.IPatchExtensionProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20210901.IPatchExtensionInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20210901.PatchExtensionPropertiesTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20210901.IPatchExtensionInternal)this).AutoUpgradeMinorVersion = (bool?) content.GetValueForProperty("AutoUpgradeMinorVersion",((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20210901.IPatchExtensionInternal)this).AutoUpgradeMinorVersion, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20210901.IPatchExtensionInternal)this).ReleaseTrain = (string) content.GetValueForProperty("ReleaseTrain",((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20210901.IPatchExtensionInternal)this).ReleaseTrain, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20210901.IPatchExtensionInternal)this).Version = (string) content.GetValueForProperty("Version",((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20210901.IPatchExtensionInternal)this).Version, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20210901.IPatchExtensionInternal)this).ConfigurationSetting = (Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20210901.IPatchExtensionPropertiesConfigurationSettings) content.GetValueForProperty("ConfigurationSetting",((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20210901.IPatchExtensionInternal)this).ConfigurationSetting, Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20210901.PatchExtensionPropertiesConfigurationSettingsTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20210901.IPatchExtensionInternal)this).ConfigurationProtectedSetting = (Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20210901.IPatchExtensionPropertiesConfigurationProtectedSettings) content.GetValueForProperty("ConfigurationProtectedSetting",((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20210901.IPatchExtensionInternal)this).ConfigurationProtectedSetting, Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20210901.PatchExtensionPropertiesConfigurationProtectedSettingsTypeConverter.ConvertFrom);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20210901.PatchExtension"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal PatchExtension(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20210901.IPatchExtensionInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20210901.IPatchExtensionProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20210901.IPatchExtensionInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20210901.PatchExtensionPropertiesTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20210901.IPatchExtensionInternal)this).AutoUpgradeMinorVersion = (bool?) content.GetValueForProperty("AutoUpgradeMinorVersion",((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20210901.IPatchExtensionInternal)this).AutoUpgradeMinorVersion, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20210901.IPatchExtensionInternal)this).ReleaseTrain = (string) content.GetValueForProperty("ReleaseTrain",((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20210901.IPatchExtensionInternal)this).ReleaseTrain, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20210901.IPatchExtensionInternal)this).Version = (string) content.GetValueForProperty("Version",((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20210901.IPatchExtensionInternal)this).Version, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20210901.IPatchExtensionInternal)this).ConfigurationSetting = (Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20210901.IPatchExtensionPropertiesConfigurationSettings) content.GetValueForProperty("ConfigurationSetting",((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20210901.IPatchExtensionInternal)this).ConfigurationSetting, Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20210901.PatchExtensionPropertiesConfigurationSettingsTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20210901.IPatchExtensionInternal)this).ConfigurationProtectedSetting = (Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20210901.IPatchExtensionPropertiesConfigurationProtectedSettings) content.GetValueForProperty("ConfigurationProtectedSetting",((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20210901.IPatchExtensionInternal)this).ConfigurationProtectedSetting, Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20210901.PatchExtensionPropertiesConfigurationProtectedSettingsTypeConverter.ConvertFrom);
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Runtime.SerializationMode.IncludeAll)?.ToString();

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
    /// The Extension Patch Request object.
    [System.ComponentModel.TypeConverter(typeof(PatchExtensionTypeConverter))]
    public partial interface IPatchExtension

    {

    }
}