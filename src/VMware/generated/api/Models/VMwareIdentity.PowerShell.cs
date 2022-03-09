// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.VMware.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.PowerShell;

    [System.ComponentModel.TypeConverter(typeof(VMwareIdentityTypeConverter))]
    public partial class VMwareIdentity
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.VMwareIdentity"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IVMwareIdentity" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IVMwareIdentity DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new VMwareIdentity(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.VMwareIdentity"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IVMwareIdentity" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IVMwareIdentity DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new VMwareIdentity(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="VMwareIdentity" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IVMwareIdentity FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.Json.JsonNode.Parse(jsonText));

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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.VMwareIdentity"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal VMwareIdentity(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("SubscriptionId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IVMwareIdentityInternal)this).SubscriptionId = (string) content.GetValueForProperty("SubscriptionId",((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IVMwareIdentityInternal)this).SubscriptionId, global::System.Convert.ToString);
            }
            if (content.Contains("Location"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IVMwareIdentityInternal)this).Location = (string) content.GetValueForProperty("Location",((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IVMwareIdentityInternal)this).Location, global::System.Convert.ToString);
            }
            if (content.Contains("ResourceGroupName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IVMwareIdentityInternal)this).ResourceGroupName = (string) content.GetValueForProperty("ResourceGroupName",((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IVMwareIdentityInternal)this).ResourceGroupName, global::System.Convert.ToString);
            }
            if (content.Contains("PrivateCloudName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IVMwareIdentityInternal)this).PrivateCloudName = (string) content.GetValueForProperty("PrivateCloudName",((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IVMwareIdentityInternal)this).PrivateCloudName, global::System.Convert.ToString);
            }
            if (content.Contains("ClusterName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IVMwareIdentityInternal)this).ClusterName = (string) content.GetValueForProperty("ClusterName",((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IVMwareIdentityInternal)this).ClusterName, global::System.Convert.ToString);
            }
            if (content.Contains("DatastoreName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IVMwareIdentityInternal)this).DatastoreName = (string) content.GetValueForProperty("DatastoreName",((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IVMwareIdentityInternal)this).DatastoreName, global::System.Convert.ToString);
            }
            if (content.Contains("HcxEnterpriseSiteName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IVMwareIdentityInternal)this).HcxEnterpriseSiteName = (string) content.GetValueForProperty("HcxEnterpriseSiteName",((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IVMwareIdentityInternal)this).HcxEnterpriseSiteName, global::System.Convert.ToString);
            }
            if (content.Contains("AuthorizationName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IVMwareIdentityInternal)this).AuthorizationName = (string) content.GetValueForProperty("AuthorizationName",((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IVMwareIdentityInternal)this).AuthorizationName, global::System.Convert.ToString);
            }
            if (content.Contains("GlobalReachConnectionName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IVMwareIdentityInternal)this).GlobalReachConnectionName = (string) content.GetValueForProperty("GlobalReachConnectionName",((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IVMwareIdentityInternal)this).GlobalReachConnectionName, global::System.Convert.ToString);
            }
            if (content.Contains("SegmentId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IVMwareIdentityInternal)this).SegmentId = (string) content.GetValueForProperty("SegmentId",((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IVMwareIdentityInternal)this).SegmentId, global::System.Convert.ToString);
            }
            if (content.Contains("DhcpId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IVMwareIdentityInternal)this).DhcpId = (string) content.GetValueForProperty("DhcpId",((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IVMwareIdentityInternal)this).DhcpId, global::System.Convert.ToString);
            }
            if (content.Contains("GatewayId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IVMwareIdentityInternal)this).GatewayId = (string) content.GetValueForProperty("GatewayId",((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IVMwareIdentityInternal)this).GatewayId, global::System.Convert.ToString);
            }
            if (content.Contains("PortMirroringId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IVMwareIdentityInternal)this).PortMirroringId = (string) content.GetValueForProperty("PortMirroringId",((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IVMwareIdentityInternal)this).PortMirroringId, global::System.Convert.ToString);
            }
            if (content.Contains("VMGroupId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IVMwareIdentityInternal)this).VMGroupId = (string) content.GetValueForProperty("VMGroupId",((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IVMwareIdentityInternal)this).VMGroupId, global::System.Convert.ToString);
            }
            if (content.Contains("VirtualMachineId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IVMwareIdentityInternal)this).VirtualMachineId = (string) content.GetValueForProperty("VirtualMachineId",((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IVMwareIdentityInternal)this).VirtualMachineId, global::System.Convert.ToString);
            }
            if (content.Contains("DnsServiceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IVMwareIdentityInternal)this).DnsServiceId = (string) content.GetValueForProperty("DnsServiceId",((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IVMwareIdentityInternal)this).DnsServiceId, global::System.Convert.ToString);
            }
            if (content.Contains("DnsZoneId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IVMwareIdentityInternal)this).DnsZoneId = (string) content.GetValueForProperty("DnsZoneId",((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IVMwareIdentityInternal)this).DnsZoneId, global::System.Convert.ToString);
            }
            if (content.Contains("PublicIPId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IVMwareIdentityInternal)this).PublicIPId = (string) content.GetValueForProperty("PublicIPId",((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IVMwareIdentityInternal)this).PublicIPId, global::System.Convert.ToString);
            }
            if (content.Contains("CloudLinkName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IVMwareIdentityInternal)this).CloudLinkName = (string) content.GetValueForProperty("CloudLinkName",((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IVMwareIdentityInternal)this).CloudLinkName, global::System.Convert.ToString);
            }
            if (content.Contains("AddonName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IVMwareIdentityInternal)this).AddonName = (string) content.GetValueForProperty("AddonName",((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IVMwareIdentityInternal)this).AddonName, global::System.Convert.ToString);
            }
            if (content.Contains("PlacementPolicyName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IVMwareIdentityInternal)this).PlacementPolicyName = (string) content.GetValueForProperty("PlacementPolicyName",((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IVMwareIdentityInternal)this).PlacementPolicyName, global::System.Convert.ToString);
            }
            if (content.Contains("ScriptPackageName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IVMwareIdentityInternal)this).ScriptPackageName = (string) content.GetValueForProperty("ScriptPackageName",((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IVMwareIdentityInternal)this).ScriptPackageName, global::System.Convert.ToString);
            }
            if (content.Contains("ScriptCmdletName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IVMwareIdentityInternal)this).ScriptCmdletName = (string) content.GetValueForProperty("ScriptCmdletName",((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IVMwareIdentityInternal)this).ScriptCmdletName, global::System.Convert.ToString);
            }
            if (content.Contains("ScriptExecutionName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IVMwareIdentityInternal)this).ScriptExecutionName = (string) content.GetValueForProperty("ScriptExecutionName",((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IVMwareIdentityInternal)this).ScriptExecutionName, global::System.Convert.ToString);
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IVMwareIdentityInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IVMwareIdentityInternal)this).Id, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.VMwareIdentity"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal VMwareIdentity(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("SubscriptionId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IVMwareIdentityInternal)this).SubscriptionId = (string) content.GetValueForProperty("SubscriptionId",((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IVMwareIdentityInternal)this).SubscriptionId, global::System.Convert.ToString);
            }
            if (content.Contains("Location"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IVMwareIdentityInternal)this).Location = (string) content.GetValueForProperty("Location",((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IVMwareIdentityInternal)this).Location, global::System.Convert.ToString);
            }
            if (content.Contains("ResourceGroupName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IVMwareIdentityInternal)this).ResourceGroupName = (string) content.GetValueForProperty("ResourceGroupName",((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IVMwareIdentityInternal)this).ResourceGroupName, global::System.Convert.ToString);
            }
            if (content.Contains("PrivateCloudName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IVMwareIdentityInternal)this).PrivateCloudName = (string) content.GetValueForProperty("PrivateCloudName",((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IVMwareIdentityInternal)this).PrivateCloudName, global::System.Convert.ToString);
            }
            if (content.Contains("ClusterName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IVMwareIdentityInternal)this).ClusterName = (string) content.GetValueForProperty("ClusterName",((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IVMwareIdentityInternal)this).ClusterName, global::System.Convert.ToString);
            }
            if (content.Contains("DatastoreName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IVMwareIdentityInternal)this).DatastoreName = (string) content.GetValueForProperty("DatastoreName",((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IVMwareIdentityInternal)this).DatastoreName, global::System.Convert.ToString);
            }
            if (content.Contains("HcxEnterpriseSiteName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IVMwareIdentityInternal)this).HcxEnterpriseSiteName = (string) content.GetValueForProperty("HcxEnterpriseSiteName",((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IVMwareIdentityInternal)this).HcxEnterpriseSiteName, global::System.Convert.ToString);
            }
            if (content.Contains("AuthorizationName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IVMwareIdentityInternal)this).AuthorizationName = (string) content.GetValueForProperty("AuthorizationName",((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IVMwareIdentityInternal)this).AuthorizationName, global::System.Convert.ToString);
            }
            if (content.Contains("GlobalReachConnectionName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IVMwareIdentityInternal)this).GlobalReachConnectionName = (string) content.GetValueForProperty("GlobalReachConnectionName",((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IVMwareIdentityInternal)this).GlobalReachConnectionName, global::System.Convert.ToString);
            }
            if (content.Contains("SegmentId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IVMwareIdentityInternal)this).SegmentId = (string) content.GetValueForProperty("SegmentId",((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IVMwareIdentityInternal)this).SegmentId, global::System.Convert.ToString);
            }
            if (content.Contains("DhcpId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IVMwareIdentityInternal)this).DhcpId = (string) content.GetValueForProperty("DhcpId",((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IVMwareIdentityInternal)this).DhcpId, global::System.Convert.ToString);
            }
            if (content.Contains("GatewayId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IVMwareIdentityInternal)this).GatewayId = (string) content.GetValueForProperty("GatewayId",((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IVMwareIdentityInternal)this).GatewayId, global::System.Convert.ToString);
            }
            if (content.Contains("PortMirroringId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IVMwareIdentityInternal)this).PortMirroringId = (string) content.GetValueForProperty("PortMirroringId",((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IVMwareIdentityInternal)this).PortMirroringId, global::System.Convert.ToString);
            }
            if (content.Contains("VMGroupId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IVMwareIdentityInternal)this).VMGroupId = (string) content.GetValueForProperty("VMGroupId",((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IVMwareIdentityInternal)this).VMGroupId, global::System.Convert.ToString);
            }
            if (content.Contains("VirtualMachineId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IVMwareIdentityInternal)this).VirtualMachineId = (string) content.GetValueForProperty("VirtualMachineId",((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IVMwareIdentityInternal)this).VirtualMachineId, global::System.Convert.ToString);
            }
            if (content.Contains("DnsServiceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IVMwareIdentityInternal)this).DnsServiceId = (string) content.GetValueForProperty("DnsServiceId",((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IVMwareIdentityInternal)this).DnsServiceId, global::System.Convert.ToString);
            }
            if (content.Contains("DnsZoneId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IVMwareIdentityInternal)this).DnsZoneId = (string) content.GetValueForProperty("DnsZoneId",((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IVMwareIdentityInternal)this).DnsZoneId, global::System.Convert.ToString);
            }
            if (content.Contains("PublicIPId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IVMwareIdentityInternal)this).PublicIPId = (string) content.GetValueForProperty("PublicIPId",((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IVMwareIdentityInternal)this).PublicIPId, global::System.Convert.ToString);
            }
            if (content.Contains("CloudLinkName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IVMwareIdentityInternal)this).CloudLinkName = (string) content.GetValueForProperty("CloudLinkName",((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IVMwareIdentityInternal)this).CloudLinkName, global::System.Convert.ToString);
            }
            if (content.Contains("AddonName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IVMwareIdentityInternal)this).AddonName = (string) content.GetValueForProperty("AddonName",((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IVMwareIdentityInternal)this).AddonName, global::System.Convert.ToString);
            }
            if (content.Contains("PlacementPolicyName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IVMwareIdentityInternal)this).PlacementPolicyName = (string) content.GetValueForProperty("PlacementPolicyName",((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IVMwareIdentityInternal)this).PlacementPolicyName, global::System.Convert.ToString);
            }
            if (content.Contains("ScriptPackageName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IVMwareIdentityInternal)this).ScriptPackageName = (string) content.GetValueForProperty("ScriptPackageName",((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IVMwareIdentityInternal)this).ScriptPackageName, global::System.Convert.ToString);
            }
            if (content.Contains("ScriptCmdletName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IVMwareIdentityInternal)this).ScriptCmdletName = (string) content.GetValueForProperty("ScriptCmdletName",((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IVMwareIdentityInternal)this).ScriptCmdletName, global::System.Convert.ToString);
            }
            if (content.Contains("ScriptExecutionName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IVMwareIdentityInternal)this).ScriptExecutionName = (string) content.GetValueForProperty("ScriptExecutionName",((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IVMwareIdentityInternal)this).ScriptExecutionName, global::System.Convert.ToString);
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IVMwareIdentityInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IVMwareIdentityInternal)this).Id, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }
    }
    [System.ComponentModel.TypeConverter(typeof(VMwareIdentityTypeConverter))]
    public partial interface IVMwareIdentity

    {

    }
}