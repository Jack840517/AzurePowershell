// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301
{
    using Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.PowerShell;

    /// <summary>Job Properties</summary>
    [System.ComponentModel.TypeConverter(typeof(JobPropertiesTypeConverter))]
    public partial class JobProperties
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.JobProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IJobProperties" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IJobProperties DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new JobProperties(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.JobProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IJobProperties" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IJobProperties DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new JobProperties(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="JobProperties" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IJobProperties FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.JobProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal JobProperties(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Error"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IJobPropertiesInternal)this).Error = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.ICloudError) content.GetValueForProperty("Error",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IJobPropertiesInternal)this).Error, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.CloudErrorTypeConverter.ConvertFrom);
            }
            if (content.Contains("DeliveryInfo"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IJobPropertiesInternal)this).DeliveryInfo = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IJobDeliveryInfo) content.GetValueForProperty("DeliveryInfo",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IJobPropertiesInternal)this).DeliveryInfo, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.JobDeliveryInfoTypeConverter.ConvertFrom);
            }
            if (content.Contains("TransferType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IJobPropertiesInternal)this).TransferType = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.TransferType) content.GetValueForProperty("TransferType",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IJobPropertiesInternal)this).TransferType, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.TransferType.CreateFrom);
            }
            if (content.Contains("IsCancellable"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IJobPropertiesInternal)this).IsCancellable = (bool?) content.GetValueForProperty("IsCancellable",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IJobPropertiesInternal)this).IsCancellable, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("IsDeletable"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IJobPropertiesInternal)this).IsDeletable = (bool?) content.GetValueForProperty("IsDeletable",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IJobPropertiesInternal)this).IsDeletable, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("IsShippingAddressEditable"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IJobPropertiesInternal)this).IsShippingAddressEditable = (bool?) content.GetValueForProperty("IsShippingAddressEditable",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IJobPropertiesInternal)this).IsShippingAddressEditable, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("IsPrepareToShipEnabled"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IJobPropertiesInternal)this).IsPrepareToShipEnabled = (bool?) content.GetValueForProperty("IsPrepareToShipEnabled",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IJobPropertiesInternal)this).IsPrepareToShipEnabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("Status"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IJobPropertiesInternal)this).Status = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.StageName?) content.GetValueForProperty("Status",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IJobPropertiesInternal)this).Status, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.StageName.CreateFrom);
            }
            if (content.Contains("StartTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IJobPropertiesInternal)this).StartTime = (global::System.DateTime?) content.GetValueForProperty("StartTime",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IJobPropertiesInternal)this).StartTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("Detail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IJobPropertiesInternal)this).Detail = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IJobDetails) content.GetValueForProperty("Detail",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IJobPropertiesInternal)this).Detail, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.JobDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("CancellationReason"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IJobPropertiesInternal)this).CancellationReason = (string) content.GetValueForProperty("CancellationReason",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IJobPropertiesInternal)this).CancellationReason, global::System.Convert.ToString);
            }
            if (content.Contains("DeliveryType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IJobPropertiesInternal)this).DeliveryType = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.JobDeliveryType?) content.GetValueForProperty("DeliveryType",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IJobPropertiesInternal)this).DeliveryType, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.JobDeliveryType.CreateFrom);
            }
            if (content.Contains("IsCancellableWithoutFee"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IJobPropertiesInternal)this).IsCancellableWithoutFee = (bool?) content.GetValueForProperty("IsCancellableWithoutFee",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IJobPropertiesInternal)this).IsCancellableWithoutFee, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("Code"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IJobPropertiesInternal)this).Code = (string) content.GetValueForProperty("Code",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IJobPropertiesInternal)this).Code, global::System.Convert.ToString);
            }
            if (content.Contains("Message"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IJobPropertiesInternal)this).Message = (string) content.GetValueForProperty("Message",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IJobPropertiesInternal)this).Message, global::System.Convert.ToString);
            }
            if (content.Contains("Target"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IJobPropertiesInternal)this).Target = (string) content.GetValueForProperty("Target",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IJobPropertiesInternal)this).Target, global::System.Convert.ToString);
            }
            if (content.Contains("ErrorDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IJobPropertiesInternal)this).ErrorDetail = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.ICloudError[]) content.GetValueForProperty("ErrorDetail",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IJobPropertiesInternal)this).ErrorDetail, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.ICloudError>(__y, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.CloudErrorTypeConverter.ConvertFrom));
            }
            if (content.Contains("AdditionalInfo"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IJobPropertiesInternal)this).AdditionalInfo = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IAdditionalErrorInfo[]) content.GetValueForProperty("AdditionalInfo",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IJobPropertiesInternal)this).AdditionalInfo, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IAdditionalErrorInfo>(__y, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.AdditionalErrorInfoTypeConverter.ConvertFrom));
            }
            if (content.Contains("DeliveryInfoScheduledDateTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IJobPropertiesInternal)this).DeliveryInfoScheduledDateTime = (global::System.DateTime?) content.GetValueForProperty("DeliveryInfoScheduledDateTime",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IJobPropertiesInternal)this).DeliveryInfoScheduledDateTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.JobProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal JobProperties(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Error"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IJobPropertiesInternal)this).Error = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.ICloudError) content.GetValueForProperty("Error",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IJobPropertiesInternal)this).Error, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.CloudErrorTypeConverter.ConvertFrom);
            }
            if (content.Contains("DeliveryInfo"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IJobPropertiesInternal)this).DeliveryInfo = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IJobDeliveryInfo) content.GetValueForProperty("DeliveryInfo",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IJobPropertiesInternal)this).DeliveryInfo, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.JobDeliveryInfoTypeConverter.ConvertFrom);
            }
            if (content.Contains("TransferType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IJobPropertiesInternal)this).TransferType = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.TransferType) content.GetValueForProperty("TransferType",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IJobPropertiesInternal)this).TransferType, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.TransferType.CreateFrom);
            }
            if (content.Contains("IsCancellable"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IJobPropertiesInternal)this).IsCancellable = (bool?) content.GetValueForProperty("IsCancellable",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IJobPropertiesInternal)this).IsCancellable, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("IsDeletable"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IJobPropertiesInternal)this).IsDeletable = (bool?) content.GetValueForProperty("IsDeletable",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IJobPropertiesInternal)this).IsDeletable, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("IsShippingAddressEditable"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IJobPropertiesInternal)this).IsShippingAddressEditable = (bool?) content.GetValueForProperty("IsShippingAddressEditable",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IJobPropertiesInternal)this).IsShippingAddressEditable, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("IsPrepareToShipEnabled"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IJobPropertiesInternal)this).IsPrepareToShipEnabled = (bool?) content.GetValueForProperty("IsPrepareToShipEnabled",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IJobPropertiesInternal)this).IsPrepareToShipEnabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("Status"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IJobPropertiesInternal)this).Status = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.StageName?) content.GetValueForProperty("Status",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IJobPropertiesInternal)this).Status, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.StageName.CreateFrom);
            }
            if (content.Contains("StartTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IJobPropertiesInternal)this).StartTime = (global::System.DateTime?) content.GetValueForProperty("StartTime",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IJobPropertiesInternal)this).StartTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("Detail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IJobPropertiesInternal)this).Detail = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IJobDetails) content.GetValueForProperty("Detail",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IJobPropertiesInternal)this).Detail, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.JobDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("CancellationReason"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IJobPropertiesInternal)this).CancellationReason = (string) content.GetValueForProperty("CancellationReason",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IJobPropertiesInternal)this).CancellationReason, global::System.Convert.ToString);
            }
            if (content.Contains("DeliveryType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IJobPropertiesInternal)this).DeliveryType = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.JobDeliveryType?) content.GetValueForProperty("DeliveryType",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IJobPropertiesInternal)this).DeliveryType, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.JobDeliveryType.CreateFrom);
            }
            if (content.Contains("IsCancellableWithoutFee"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IJobPropertiesInternal)this).IsCancellableWithoutFee = (bool?) content.GetValueForProperty("IsCancellableWithoutFee",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IJobPropertiesInternal)this).IsCancellableWithoutFee, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("Code"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IJobPropertiesInternal)this).Code = (string) content.GetValueForProperty("Code",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IJobPropertiesInternal)this).Code, global::System.Convert.ToString);
            }
            if (content.Contains("Message"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IJobPropertiesInternal)this).Message = (string) content.GetValueForProperty("Message",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IJobPropertiesInternal)this).Message, global::System.Convert.ToString);
            }
            if (content.Contains("Target"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IJobPropertiesInternal)this).Target = (string) content.GetValueForProperty("Target",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IJobPropertiesInternal)this).Target, global::System.Convert.ToString);
            }
            if (content.Contains("ErrorDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IJobPropertiesInternal)this).ErrorDetail = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.ICloudError[]) content.GetValueForProperty("ErrorDetail",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IJobPropertiesInternal)this).ErrorDetail, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.ICloudError>(__y, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.CloudErrorTypeConverter.ConvertFrom));
            }
            if (content.Contains("AdditionalInfo"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IJobPropertiesInternal)this).AdditionalInfo = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IAdditionalErrorInfo[]) content.GetValueForProperty("AdditionalInfo",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IJobPropertiesInternal)this).AdditionalInfo, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IAdditionalErrorInfo>(__y, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.AdditionalErrorInfoTypeConverter.ConvertFrom));
            }
            if (content.Contains("DeliveryInfoScheduledDateTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IJobPropertiesInternal)this).DeliveryInfoScheduledDateTime = (global::System.DateTime?) content.GetValueForProperty("DeliveryInfoScheduledDateTime",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IJobPropertiesInternal)this).DeliveryInfoScheduledDateTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Job Properties
    [System.ComponentModel.TypeConverter(typeof(JobPropertiesTypeConverter))]
    public partial interface IJobProperties

    {

    }
}