// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201
{
    using Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.PowerShell;

    /// <summary>Return order item request body</summary>
    [System.ComponentModel.TypeConverter(typeof(ReturnOrderItemDetailsTypeConverter))]
    public partial class ReturnOrderItemDetails
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.ReturnOrderItemDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IReturnOrderItemDetails" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IReturnOrderItemDetails DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new ReturnOrderItemDetails(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.ReturnOrderItemDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IReturnOrderItemDetails" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IReturnOrderItemDetails DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new ReturnOrderItemDetails(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="ReturnOrderItemDetails" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IReturnOrderItemDetails FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.ReturnOrderItemDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal ReturnOrderItemDetails(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("ReturnAddress"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IReturnOrderItemDetailsInternal)this).ReturnAddress = (Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IAddressProperties) content.GetValueForProperty("ReturnAddress",((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IReturnOrderItemDetailsInternal)this).ReturnAddress, Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.AddressPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("ReturnReason"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IReturnOrderItemDetailsInternal)this).ReturnReason = (string) content.GetValueForProperty("ReturnReason",((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IReturnOrderItemDetailsInternal)this).ReturnReason, global::System.Convert.ToString);
            }
            if (content.Contains("ServiceTag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IReturnOrderItemDetailsInternal)this).ServiceTag = (string) content.GetValueForProperty("ServiceTag",((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IReturnOrderItemDetailsInternal)this).ServiceTag, global::System.Convert.ToString);
            }
            if (content.Contains("ShippingBoxRequired"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IReturnOrderItemDetailsInternal)this).ShippingBoxRequired = (bool?) content.GetValueForProperty("ShippingBoxRequired",((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IReturnOrderItemDetailsInternal)this).ShippingBoxRequired, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("ReturnAddressShippingAddress"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IReturnOrderItemDetailsInternal)this).ReturnAddressShippingAddress = (Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IShippingAddress) content.GetValueForProperty("ReturnAddressShippingAddress",((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IReturnOrderItemDetailsInternal)this).ReturnAddressShippingAddress, Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.ShippingAddressTypeConverter.ConvertFrom);
            }
            if (content.Contains("ReturnAddressContactDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IReturnOrderItemDetailsInternal)this).ReturnAddressContactDetail = (Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IContactDetails) content.GetValueForProperty("ReturnAddressContactDetail",((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IReturnOrderItemDetailsInternal)this).ReturnAddressContactDetail, Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.ContactDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("ReturnAddressValidationStatus"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IReturnOrderItemDetailsInternal)this).ReturnAddressValidationStatus = (Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Support.AddressValidationStatus?) content.GetValueForProperty("ReturnAddressValidationStatus",((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IReturnOrderItemDetailsInternal)this).ReturnAddressValidationStatus, Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Support.AddressValidationStatus.CreateFrom);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.ReturnOrderItemDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal ReturnOrderItemDetails(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("ReturnAddress"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IReturnOrderItemDetailsInternal)this).ReturnAddress = (Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IAddressProperties) content.GetValueForProperty("ReturnAddress",((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IReturnOrderItemDetailsInternal)this).ReturnAddress, Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.AddressPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("ReturnReason"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IReturnOrderItemDetailsInternal)this).ReturnReason = (string) content.GetValueForProperty("ReturnReason",((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IReturnOrderItemDetailsInternal)this).ReturnReason, global::System.Convert.ToString);
            }
            if (content.Contains("ServiceTag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IReturnOrderItemDetailsInternal)this).ServiceTag = (string) content.GetValueForProperty("ServiceTag",((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IReturnOrderItemDetailsInternal)this).ServiceTag, global::System.Convert.ToString);
            }
            if (content.Contains("ShippingBoxRequired"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IReturnOrderItemDetailsInternal)this).ShippingBoxRequired = (bool?) content.GetValueForProperty("ShippingBoxRequired",((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IReturnOrderItemDetailsInternal)this).ShippingBoxRequired, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("ReturnAddressShippingAddress"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IReturnOrderItemDetailsInternal)this).ReturnAddressShippingAddress = (Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IShippingAddress) content.GetValueForProperty("ReturnAddressShippingAddress",((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IReturnOrderItemDetailsInternal)this).ReturnAddressShippingAddress, Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.ShippingAddressTypeConverter.ConvertFrom);
            }
            if (content.Contains("ReturnAddressContactDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IReturnOrderItemDetailsInternal)this).ReturnAddressContactDetail = (Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IContactDetails) content.GetValueForProperty("ReturnAddressContactDetail",((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IReturnOrderItemDetailsInternal)this).ReturnAddressContactDetail, Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.ContactDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("ReturnAddressValidationStatus"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IReturnOrderItemDetailsInternal)this).ReturnAddressValidationStatus = (Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Support.AddressValidationStatus?) content.GetValueForProperty("ReturnAddressValidationStatus",((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IReturnOrderItemDetailsInternal)this).ReturnAddressValidationStatus, Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Support.AddressValidationStatus.CreateFrom);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Return order item request body
    [System.ComponentModel.TypeConverter(typeof(ReturnOrderItemDetailsTypeConverter))]
    public partial interface IReturnOrderItemDetails

    {

    }
}