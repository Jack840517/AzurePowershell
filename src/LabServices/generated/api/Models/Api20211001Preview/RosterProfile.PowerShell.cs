// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview
{
    using Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.PowerShell;

    /// <summary>The lab user list management profile.</summary>
    [System.ComponentModel.TypeConverter(typeof(RosterProfileTypeConverter))]
    public partial class RosterProfile
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.RosterProfile"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.IRosterProfile" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.IRosterProfile DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new RosterProfile(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.RosterProfile"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.IRosterProfile" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.IRosterProfile DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new RosterProfile(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="RosterProfile" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.IRosterProfile FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.RosterProfile"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal RosterProfile(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("ActiveDirectoryGroupId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.IRosterProfileInternal)this).ActiveDirectoryGroupId = (string) content.GetValueForProperty("ActiveDirectoryGroupId",((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.IRosterProfileInternal)this).ActiveDirectoryGroupId, global::System.Convert.ToString);
            }
            if (content.Contains("LtiContextId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.IRosterProfileInternal)this).LtiContextId = (string) content.GetValueForProperty("LtiContextId",((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.IRosterProfileInternal)this).LtiContextId, global::System.Convert.ToString);
            }
            if (content.Contains("LmsInstance"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.IRosterProfileInternal)this).LmsInstance = (string) content.GetValueForProperty("LmsInstance",((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.IRosterProfileInternal)this).LmsInstance, global::System.Convert.ToString);
            }
            if (content.Contains("LtiClientId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.IRosterProfileInternal)this).LtiClientId = (string) content.GetValueForProperty("LtiClientId",((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.IRosterProfileInternal)this).LtiClientId, global::System.Convert.ToString);
            }
            if (content.Contains("LtiRosterEndpoint"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.IRosterProfileInternal)this).LtiRosterEndpoint = (string) content.GetValueForProperty("LtiRosterEndpoint",((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.IRosterProfileInternal)this).LtiRosterEndpoint, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.RosterProfile"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal RosterProfile(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("ActiveDirectoryGroupId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.IRosterProfileInternal)this).ActiveDirectoryGroupId = (string) content.GetValueForProperty("ActiveDirectoryGroupId",((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.IRosterProfileInternal)this).ActiveDirectoryGroupId, global::System.Convert.ToString);
            }
            if (content.Contains("LtiContextId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.IRosterProfileInternal)this).LtiContextId = (string) content.GetValueForProperty("LtiContextId",((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.IRosterProfileInternal)this).LtiContextId, global::System.Convert.ToString);
            }
            if (content.Contains("LmsInstance"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.IRosterProfileInternal)this).LmsInstance = (string) content.GetValueForProperty("LmsInstance",((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.IRosterProfileInternal)this).LmsInstance, global::System.Convert.ToString);
            }
            if (content.Contains("LtiClientId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.IRosterProfileInternal)this).LtiClientId = (string) content.GetValueForProperty("LtiClientId",((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.IRosterProfileInternal)this).LtiClientId, global::System.Convert.ToString);
            }
            if (content.Contains("LtiRosterEndpoint"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.IRosterProfileInternal)this).LtiRosterEndpoint = (string) content.GetValueForProperty("LtiRosterEndpoint",((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.IRosterProfileInternal)this).LtiRosterEndpoint, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// The lab user list management profile.
    [System.ComponentModel.TypeConverter(typeof(RosterProfileTypeConverter))]
    public partial interface IRosterProfile

    {

    }
}