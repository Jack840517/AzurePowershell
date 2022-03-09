namespace Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20200701
{
    using Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Runtime.PowerShell;

    /// <summary>Service resource</summary>
    [System.ComponentModel.TypeConverter(typeof(ServiceResourceTypeConverter))]
    public partial class ServiceResource
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20200701.ServiceResource"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20200701.IServiceResource" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20200701.IServiceResource DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new ServiceResource(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20200701.ServiceResource"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20200701.IServiceResource" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20200701.IServiceResource DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new ServiceResource(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="ServiceResource" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20200701.IServiceResource FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20200701.ServiceResource"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal ServiceResource(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20200701.IServiceResourceInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20200701.IClusterResourceProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20200701.IServiceResourceInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20200701.ClusterResourcePropertiesTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20200701.IServiceResourceInternal)this).Sku = (Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20200701.ISku) content.GetValueForProperty("Sku",((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20200701.IServiceResourceInternal)this).Sku, Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20200701.SkuTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20200701.IResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20200701.IResourceInternal)this).Id, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20200701.IResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20200701.IResourceInternal)this).Name, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20200701.IResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20200701.IResourceInternal)this).Type, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20200701.ITrackedResourceInternal)this).Location = (string) content.GetValueForProperty("Location",((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20200701.ITrackedResourceInternal)this).Location, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20200701.ITrackedResourceInternal)this).Tag = (Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20200701.ITrackedResourceTags) content.GetValueForProperty("Tag",((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20200701.ITrackedResourceInternal)this).Tag, Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20200701.TrackedResourceTagsTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20200701.IServiceResourceInternal)this).NetworkProfile = (Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20200701.INetworkProfile) content.GetValueForProperty("NetworkProfile",((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20200701.IServiceResourceInternal)this).NetworkProfile, Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20200701.NetworkProfileTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20200701.IServiceResourceInternal)this).SkuTier = (string) content.GetValueForProperty("SkuTier",((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20200701.IServiceResourceInternal)this).SkuTier, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20200701.IServiceResourceInternal)this).SkuName = (string) content.GetValueForProperty("SkuName",((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20200701.IServiceResourceInternal)this).SkuName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20200701.IServiceResourceInternal)this).ProvisioningState = (Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Support.ProvisioningState?) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20200701.IServiceResourceInternal)this).ProvisioningState, Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Support.ProvisioningState.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20200701.IServiceResourceInternal)this).NetworkProfileServiceCidr = (string) content.GetValueForProperty("NetworkProfileServiceCidr",((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20200701.IServiceResourceInternal)this).NetworkProfileServiceCidr, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20200701.IServiceResourceInternal)this).SkuCapacity = (int?) content.GetValueForProperty("SkuCapacity",((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20200701.IServiceResourceInternal)this).SkuCapacity, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20200701.IServiceResourceInternal)this).Version = (int?) content.GetValueForProperty("Version",((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20200701.IServiceResourceInternal)this).Version, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20200701.IServiceResourceInternal)this).ServiceId = (string) content.GetValueForProperty("ServiceId",((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20200701.IServiceResourceInternal)this).ServiceId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20200701.IServiceResourceInternal)this).NetworkProfileServiceRuntimeNetworkResourceGroup = (string) content.GetValueForProperty("NetworkProfileServiceRuntimeNetworkResourceGroup",((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20200701.IServiceResourceInternal)this).NetworkProfileServiceRuntimeNetworkResourceGroup, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20200701.IServiceResourceInternal)this).NetworkProfileAppNetworkResourceGroup = (string) content.GetValueForProperty("NetworkProfileAppNetworkResourceGroup",((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20200701.IServiceResourceInternal)this).NetworkProfileAppNetworkResourceGroup, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20200701.IServiceResourceInternal)this).NetworkProfileServiceRuntimeSubnetId = (string) content.GetValueForProperty("NetworkProfileServiceRuntimeSubnetId",((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20200701.IServiceResourceInternal)this).NetworkProfileServiceRuntimeSubnetId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20200701.IServiceResourceInternal)this).NetworkProfileOutboundIP = (Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20200701.INetworkProfileOutboundIPs) content.GetValueForProperty("NetworkProfileOutboundIP",((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20200701.IServiceResourceInternal)this).NetworkProfileOutboundIP, Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20200701.NetworkProfileOutboundIPsTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20200701.IServiceResourceInternal)this).NetworkProfileAppSubnetId = (string) content.GetValueForProperty("NetworkProfileAppSubnetId",((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20200701.IServiceResourceInternal)this).NetworkProfileAppSubnetId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20200701.IServiceResourceInternal)this).OutboundIPPublicIP = (string[]) content.GetValueForProperty("OutboundIPPublicIP",((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20200701.IServiceResourceInternal)this).OutboundIPPublicIP, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20200701.ServiceResource"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal ServiceResource(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20200701.IServiceResourceInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20200701.IClusterResourceProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20200701.IServiceResourceInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20200701.ClusterResourcePropertiesTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20200701.IServiceResourceInternal)this).Sku = (Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20200701.ISku) content.GetValueForProperty("Sku",((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20200701.IServiceResourceInternal)this).Sku, Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20200701.SkuTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20200701.IResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20200701.IResourceInternal)this).Id, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20200701.IResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20200701.IResourceInternal)this).Name, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20200701.IResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20200701.IResourceInternal)this).Type, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20200701.ITrackedResourceInternal)this).Location = (string) content.GetValueForProperty("Location",((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20200701.ITrackedResourceInternal)this).Location, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20200701.ITrackedResourceInternal)this).Tag = (Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20200701.ITrackedResourceTags) content.GetValueForProperty("Tag",((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20200701.ITrackedResourceInternal)this).Tag, Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20200701.TrackedResourceTagsTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20200701.IServiceResourceInternal)this).NetworkProfile = (Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20200701.INetworkProfile) content.GetValueForProperty("NetworkProfile",((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20200701.IServiceResourceInternal)this).NetworkProfile, Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20200701.NetworkProfileTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20200701.IServiceResourceInternal)this).SkuTier = (string) content.GetValueForProperty("SkuTier",((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20200701.IServiceResourceInternal)this).SkuTier, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20200701.IServiceResourceInternal)this).SkuName = (string) content.GetValueForProperty("SkuName",((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20200701.IServiceResourceInternal)this).SkuName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20200701.IServiceResourceInternal)this).ProvisioningState = (Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Support.ProvisioningState?) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20200701.IServiceResourceInternal)this).ProvisioningState, Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Support.ProvisioningState.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20200701.IServiceResourceInternal)this).NetworkProfileServiceCidr = (string) content.GetValueForProperty("NetworkProfileServiceCidr",((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20200701.IServiceResourceInternal)this).NetworkProfileServiceCidr, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20200701.IServiceResourceInternal)this).SkuCapacity = (int?) content.GetValueForProperty("SkuCapacity",((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20200701.IServiceResourceInternal)this).SkuCapacity, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20200701.IServiceResourceInternal)this).Version = (int?) content.GetValueForProperty("Version",((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20200701.IServiceResourceInternal)this).Version, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20200701.IServiceResourceInternal)this).ServiceId = (string) content.GetValueForProperty("ServiceId",((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20200701.IServiceResourceInternal)this).ServiceId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20200701.IServiceResourceInternal)this).NetworkProfileServiceRuntimeNetworkResourceGroup = (string) content.GetValueForProperty("NetworkProfileServiceRuntimeNetworkResourceGroup",((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20200701.IServiceResourceInternal)this).NetworkProfileServiceRuntimeNetworkResourceGroup, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20200701.IServiceResourceInternal)this).NetworkProfileAppNetworkResourceGroup = (string) content.GetValueForProperty("NetworkProfileAppNetworkResourceGroup",((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20200701.IServiceResourceInternal)this).NetworkProfileAppNetworkResourceGroup, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20200701.IServiceResourceInternal)this).NetworkProfileServiceRuntimeSubnetId = (string) content.GetValueForProperty("NetworkProfileServiceRuntimeSubnetId",((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20200701.IServiceResourceInternal)this).NetworkProfileServiceRuntimeSubnetId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20200701.IServiceResourceInternal)this).NetworkProfileOutboundIP = (Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20200701.INetworkProfileOutboundIPs) content.GetValueForProperty("NetworkProfileOutboundIP",((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20200701.IServiceResourceInternal)this).NetworkProfileOutboundIP, Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20200701.NetworkProfileOutboundIPsTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20200701.IServiceResourceInternal)this).NetworkProfileAppSubnetId = (string) content.GetValueForProperty("NetworkProfileAppSubnetId",((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20200701.IServiceResourceInternal)this).NetworkProfileAppSubnetId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20200701.IServiceResourceInternal)this).OutboundIPPublicIP = (string[]) content.GetValueForProperty("OutboundIPPublicIP",((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20200701.IServiceResourceInternal)this).OutboundIPPublicIP, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Service resource
    [System.ComponentModel.TypeConverter(typeof(ServiceResourceTypeConverter))]
    public partial interface IServiceResource

    {

    }
}