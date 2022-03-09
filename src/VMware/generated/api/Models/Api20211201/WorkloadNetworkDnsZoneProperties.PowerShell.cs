// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201
{
    using Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.PowerShell;

    /// <summary>NSX DNS Zone Properties</summary>
    [System.ComponentModel.TypeConverter(typeof(WorkloadNetworkDnsZonePropertiesTypeConverter))]
    public partial class WorkloadNetworkDnsZoneProperties
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.WorkloadNetworkDnsZoneProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.IWorkloadNetworkDnsZoneProperties"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.IWorkloadNetworkDnsZoneProperties DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new WorkloadNetworkDnsZoneProperties(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.WorkloadNetworkDnsZoneProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.IWorkloadNetworkDnsZoneProperties"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.IWorkloadNetworkDnsZoneProperties DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new WorkloadNetworkDnsZoneProperties(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="WorkloadNetworkDnsZoneProperties" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.IWorkloadNetworkDnsZoneProperties FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.SerializationMode.IncludeAll)?.ToString();

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

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.WorkloadNetworkDnsZoneProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal WorkloadNetworkDnsZoneProperties(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("DisplayName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.IWorkloadNetworkDnsZonePropertiesInternal)this).DisplayName = (string) content.GetValueForProperty("DisplayName",((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.IWorkloadNetworkDnsZonePropertiesInternal)this).DisplayName, global::System.Convert.ToString);
            }
            if (content.Contains("Domain"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.IWorkloadNetworkDnsZonePropertiesInternal)this).Domain = (string[]) content.GetValueForProperty("Domain",((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.IWorkloadNetworkDnsZonePropertiesInternal)this).Domain, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("DnsServerIP"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.IWorkloadNetworkDnsZonePropertiesInternal)this).DnsServerIP = (string[]) content.GetValueForProperty("DnsServerIP",((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.IWorkloadNetworkDnsZonePropertiesInternal)this).DnsServerIP, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("SourceIP"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.IWorkloadNetworkDnsZonePropertiesInternal)this).SourceIP = (string) content.GetValueForProperty("SourceIP",((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.IWorkloadNetworkDnsZonePropertiesInternal)this).SourceIP, global::System.Convert.ToString);
            }
            if (content.Contains("DnsService"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.IWorkloadNetworkDnsZonePropertiesInternal)this).DnsService = (long?) content.GetValueForProperty("DnsService",((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.IWorkloadNetworkDnsZonePropertiesInternal)this).DnsService, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.IWorkloadNetworkDnsZonePropertiesInternal)this).ProvisioningState = (Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.WorkloadNetworkDnsZoneProvisioningState?) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.IWorkloadNetworkDnsZonePropertiesInternal)this).ProvisioningState, Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.WorkloadNetworkDnsZoneProvisioningState.CreateFrom);
            }
            if (content.Contains("Revision"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.IWorkloadNetworkDnsZonePropertiesInternal)this).Revision = (long?) content.GetValueForProperty("Revision",((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.IWorkloadNetworkDnsZonePropertiesInternal)this).Revision, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.WorkloadNetworkDnsZoneProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal WorkloadNetworkDnsZoneProperties(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("DisplayName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.IWorkloadNetworkDnsZonePropertiesInternal)this).DisplayName = (string) content.GetValueForProperty("DisplayName",((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.IWorkloadNetworkDnsZonePropertiesInternal)this).DisplayName, global::System.Convert.ToString);
            }
            if (content.Contains("Domain"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.IWorkloadNetworkDnsZonePropertiesInternal)this).Domain = (string[]) content.GetValueForProperty("Domain",((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.IWorkloadNetworkDnsZonePropertiesInternal)this).Domain, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("DnsServerIP"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.IWorkloadNetworkDnsZonePropertiesInternal)this).DnsServerIP = (string[]) content.GetValueForProperty("DnsServerIP",((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.IWorkloadNetworkDnsZonePropertiesInternal)this).DnsServerIP, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("SourceIP"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.IWorkloadNetworkDnsZonePropertiesInternal)this).SourceIP = (string) content.GetValueForProperty("SourceIP",((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.IWorkloadNetworkDnsZonePropertiesInternal)this).SourceIP, global::System.Convert.ToString);
            }
            if (content.Contains("DnsService"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.IWorkloadNetworkDnsZonePropertiesInternal)this).DnsService = (long?) content.GetValueForProperty("DnsService",((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.IWorkloadNetworkDnsZonePropertiesInternal)this).DnsService, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.IWorkloadNetworkDnsZonePropertiesInternal)this).ProvisioningState = (Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.WorkloadNetworkDnsZoneProvisioningState?) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.IWorkloadNetworkDnsZonePropertiesInternal)this).ProvisioningState, Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.WorkloadNetworkDnsZoneProvisioningState.CreateFrom);
            }
            if (content.Contains("Revision"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.IWorkloadNetworkDnsZonePropertiesInternal)this).Revision = (long?) content.GetValueForProperty("Revision",((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.IWorkloadNetworkDnsZonePropertiesInternal)this).Revision, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            AfterDeserializePSObject(content);
        }
    }
    /// NSX DNS Zone Properties
    [System.ComponentModel.TypeConverter(typeof(WorkloadNetworkDnsZonePropertiesTypeConverter))]
    public partial interface IWorkloadNetworkDnsZoneProperties

    {

    }
}