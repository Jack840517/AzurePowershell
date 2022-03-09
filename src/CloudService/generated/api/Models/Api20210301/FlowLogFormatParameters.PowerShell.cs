// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301
{
    using Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.PowerShell;

    /// <summary>Parameters that define the flow log format.</summary>
    [System.ComponentModel.TypeConverter(typeof(FlowLogFormatParametersTypeConverter))]
    public partial class FlowLogFormatParameters
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.FlowLogFormatParameters"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IFlowLogFormatParameters"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IFlowLogFormatParameters DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new FlowLogFormatParameters(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.FlowLogFormatParameters"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IFlowLogFormatParameters"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IFlowLogFormatParameters DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new FlowLogFormatParameters(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.FlowLogFormatParameters"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal FlowLogFormatParameters(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IFlowLogFormatParametersInternal)this).Type = (Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.FlowLogFormatType?) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IFlowLogFormatParametersInternal)this).Type, Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.FlowLogFormatType.CreateFrom);
            }
            if (content.Contains("Version"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IFlowLogFormatParametersInternal)this).Version = (int?) content.GetValueForProperty("Version",((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IFlowLogFormatParametersInternal)this).Version, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.FlowLogFormatParameters"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal FlowLogFormatParameters(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IFlowLogFormatParametersInternal)this).Type = (Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.FlowLogFormatType?) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IFlowLogFormatParametersInternal)this).Type, Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.FlowLogFormatType.CreateFrom);
            }
            if (content.Contains("Version"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IFlowLogFormatParametersInternal)this).Version = (int?) content.GetValueForProperty("Version",((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IFlowLogFormatParametersInternal)this).Version, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="FlowLogFormatParameters" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IFlowLogFormatParameters FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Parameters that define the flow log format.
    [System.ComponentModel.TypeConverter(typeof(FlowLogFormatParametersTypeConverter))]
    public partial interface IFlowLogFormatParameters

    {

    }
}