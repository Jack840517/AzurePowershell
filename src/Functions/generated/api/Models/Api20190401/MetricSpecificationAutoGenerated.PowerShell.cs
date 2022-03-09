// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401
{
    using Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.PowerShell;

    /// <summary>Metric specification of operation.</summary>
    [System.ComponentModel.TypeConverter(typeof(MetricSpecificationAutoGeneratedTypeConverter))]
    public partial class MetricSpecificationAutoGenerated
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.MetricSpecificationAutoGenerated"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IMetricSpecificationAutoGenerated"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IMetricSpecificationAutoGenerated DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new MetricSpecificationAutoGenerated(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.MetricSpecificationAutoGenerated"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IMetricSpecificationAutoGenerated"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IMetricSpecificationAutoGenerated DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new MetricSpecificationAutoGenerated(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="MetricSpecificationAutoGenerated" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IMetricSpecificationAutoGenerated FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.MetricSpecificationAutoGenerated"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal MetricSpecificationAutoGenerated(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IMetricSpecificationAutoGeneratedInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IMetricSpecificationAutoGeneratedInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("DisplayName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IMetricSpecificationAutoGeneratedInternal)this).DisplayName = (string) content.GetValueForProperty("DisplayName",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IMetricSpecificationAutoGeneratedInternal)this).DisplayName, global::System.Convert.ToString);
            }
            if (content.Contains("DisplayDescription"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IMetricSpecificationAutoGeneratedInternal)this).DisplayDescription = (string) content.GetValueForProperty("DisplayDescription",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IMetricSpecificationAutoGeneratedInternal)this).DisplayDescription, global::System.Convert.ToString);
            }
            if (content.Contains("Unit"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IMetricSpecificationAutoGeneratedInternal)this).Unit = (string) content.GetValueForProperty("Unit",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IMetricSpecificationAutoGeneratedInternal)this).Unit, global::System.Convert.ToString);
            }
            if (content.Contains("Dimension"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IMetricSpecificationAutoGeneratedInternal)this).Dimension = (Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IDimensionAutoGenerated[]) content.GetValueForProperty("Dimension",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IMetricSpecificationAutoGeneratedInternal)this).Dimension, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IDimensionAutoGenerated>(__y, Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.DimensionAutoGeneratedTypeConverter.ConvertFrom));
            }
            if (content.Contains("AggregationType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IMetricSpecificationAutoGeneratedInternal)this).AggregationType = (string) content.GetValueForProperty("AggregationType",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IMetricSpecificationAutoGeneratedInternal)this).AggregationType, global::System.Convert.ToString);
            }
            if (content.Contains("FillGapWithZero"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IMetricSpecificationAutoGeneratedInternal)this).FillGapWithZero = (bool?) content.GetValueForProperty("FillGapWithZero",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IMetricSpecificationAutoGeneratedInternal)this).FillGapWithZero, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("Category"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IMetricSpecificationAutoGeneratedInternal)this).Category = (string) content.GetValueForProperty("Category",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IMetricSpecificationAutoGeneratedInternal)this).Category, global::System.Convert.ToString);
            }
            if (content.Contains("ResourceIdDimensionNameOverride"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IMetricSpecificationAutoGeneratedInternal)this).ResourceIdDimensionNameOverride = (string) content.GetValueForProperty("ResourceIdDimensionNameOverride",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IMetricSpecificationAutoGeneratedInternal)this).ResourceIdDimensionNameOverride, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.MetricSpecificationAutoGenerated"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal MetricSpecificationAutoGenerated(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IMetricSpecificationAutoGeneratedInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IMetricSpecificationAutoGeneratedInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("DisplayName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IMetricSpecificationAutoGeneratedInternal)this).DisplayName = (string) content.GetValueForProperty("DisplayName",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IMetricSpecificationAutoGeneratedInternal)this).DisplayName, global::System.Convert.ToString);
            }
            if (content.Contains("DisplayDescription"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IMetricSpecificationAutoGeneratedInternal)this).DisplayDescription = (string) content.GetValueForProperty("DisplayDescription",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IMetricSpecificationAutoGeneratedInternal)this).DisplayDescription, global::System.Convert.ToString);
            }
            if (content.Contains("Unit"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IMetricSpecificationAutoGeneratedInternal)this).Unit = (string) content.GetValueForProperty("Unit",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IMetricSpecificationAutoGeneratedInternal)this).Unit, global::System.Convert.ToString);
            }
            if (content.Contains("Dimension"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IMetricSpecificationAutoGeneratedInternal)this).Dimension = (Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IDimensionAutoGenerated[]) content.GetValueForProperty("Dimension",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IMetricSpecificationAutoGeneratedInternal)this).Dimension, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IDimensionAutoGenerated>(__y, Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.DimensionAutoGeneratedTypeConverter.ConvertFrom));
            }
            if (content.Contains("AggregationType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IMetricSpecificationAutoGeneratedInternal)this).AggregationType = (string) content.GetValueForProperty("AggregationType",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IMetricSpecificationAutoGeneratedInternal)this).AggregationType, global::System.Convert.ToString);
            }
            if (content.Contains("FillGapWithZero"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IMetricSpecificationAutoGeneratedInternal)this).FillGapWithZero = (bool?) content.GetValueForProperty("FillGapWithZero",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IMetricSpecificationAutoGeneratedInternal)this).FillGapWithZero, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("Category"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IMetricSpecificationAutoGeneratedInternal)this).Category = (string) content.GetValueForProperty("Category",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IMetricSpecificationAutoGeneratedInternal)this).Category, global::System.Convert.ToString);
            }
            if (content.Contains("ResourceIdDimensionNameOverride"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IMetricSpecificationAutoGeneratedInternal)this).ResourceIdDimensionNameOverride = (string) content.GetValueForProperty("ResourceIdDimensionNameOverride",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IMetricSpecificationAutoGeneratedInternal)this).ResourceIdDimensionNameOverride, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Metric specification of operation.
    [System.ComponentModel.TypeConverter(typeof(MetricSpecificationAutoGeneratedTypeConverter))]
    public partial interface IMetricSpecificationAutoGenerated

    {

    }
}