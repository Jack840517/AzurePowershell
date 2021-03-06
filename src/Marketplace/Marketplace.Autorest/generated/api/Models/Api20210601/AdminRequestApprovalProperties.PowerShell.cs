// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.Api20210601
{
    using Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Runtime.PowerShell;

    /// <summary>Admin approval request resource properties</summary>
    [System.ComponentModel.TypeConverter(typeof(AdminRequestApprovalPropertiesTypeConverter))]
    public partial class AdminRequestApprovalProperties
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.Api20210601.AdminRequestApprovalProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal AdminRequestApprovalProperties(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("OfferId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.Api20210601.IAdminRequestApprovalPropertiesInternal)this).OfferId = (string) content.GetValueForProperty("OfferId",((Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.Api20210601.IAdminRequestApprovalPropertiesInternal)this).OfferId, global::System.Convert.ToString);
            }
            if (content.Contains("DisplayName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.Api20210601.IAdminRequestApprovalPropertiesInternal)this).DisplayName = (string) content.GetValueForProperty("DisplayName",((Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.Api20210601.IAdminRequestApprovalPropertiesInternal)this).DisplayName, global::System.Convert.ToString);
            }
            if (content.Contains("PublisherId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.Api20210601.IAdminRequestApprovalPropertiesInternal)this).PublisherId = (string) content.GetValueForProperty("PublisherId",((Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.Api20210601.IAdminRequestApprovalPropertiesInternal)this).PublisherId, global::System.Convert.ToString);
            }
            if (content.Contains("AdminAction"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.Api20210601.IAdminRequestApprovalPropertiesInternal)this).AdminAction = (Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Support.AdminAction?) content.GetValueForProperty("AdminAction",((Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.Api20210601.IAdminRequestApprovalPropertiesInternal)this).AdminAction, Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Support.AdminAction.CreateFrom);
            }
            if (content.Contains("ApprovedPlan"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.Api20210601.IAdminRequestApprovalPropertiesInternal)this).ApprovedPlan = (string[]) content.GetValueForProperty("ApprovedPlan",((Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.Api20210601.IAdminRequestApprovalPropertiesInternal)this).ApprovedPlan, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("Comment"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.Api20210601.IAdminRequestApprovalPropertiesInternal)this).Comment = (string) content.GetValueForProperty("Comment",((Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.Api20210601.IAdminRequestApprovalPropertiesInternal)this).Comment, global::System.Convert.ToString);
            }
            if (content.Contains("Administrator"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.Api20210601.IAdminRequestApprovalPropertiesInternal)this).Administrator = (string) content.GetValueForProperty("Administrator",((Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.Api20210601.IAdminRequestApprovalPropertiesInternal)this).Administrator, global::System.Convert.ToString);
            }
            if (content.Contains("Plan"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.Api20210601.IAdminRequestApprovalPropertiesInternal)this).Plan = (Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.Api20210601.IPlanRequesterDetails[]) content.GetValueForProperty("Plan",((Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.Api20210601.IAdminRequestApprovalPropertiesInternal)this).Plan, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.Api20210601.IPlanRequesterDetails>(__y, Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.Api20210601.PlanRequesterDetailsTypeConverter.ConvertFrom));
            }
            if (content.Contains("CollectionId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.Api20210601.IAdminRequestApprovalPropertiesInternal)this).CollectionId = (string[]) content.GetValueForProperty("CollectionId",((Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.Api20210601.IAdminRequestApprovalPropertiesInternal)this).CollectionId, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.Api20210601.AdminRequestApprovalProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal AdminRequestApprovalProperties(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("OfferId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.Api20210601.IAdminRequestApprovalPropertiesInternal)this).OfferId = (string) content.GetValueForProperty("OfferId",((Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.Api20210601.IAdminRequestApprovalPropertiesInternal)this).OfferId, global::System.Convert.ToString);
            }
            if (content.Contains("DisplayName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.Api20210601.IAdminRequestApprovalPropertiesInternal)this).DisplayName = (string) content.GetValueForProperty("DisplayName",((Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.Api20210601.IAdminRequestApprovalPropertiesInternal)this).DisplayName, global::System.Convert.ToString);
            }
            if (content.Contains("PublisherId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.Api20210601.IAdminRequestApprovalPropertiesInternal)this).PublisherId = (string) content.GetValueForProperty("PublisherId",((Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.Api20210601.IAdminRequestApprovalPropertiesInternal)this).PublisherId, global::System.Convert.ToString);
            }
            if (content.Contains("AdminAction"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.Api20210601.IAdminRequestApprovalPropertiesInternal)this).AdminAction = (Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Support.AdminAction?) content.GetValueForProperty("AdminAction",((Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.Api20210601.IAdminRequestApprovalPropertiesInternal)this).AdminAction, Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Support.AdminAction.CreateFrom);
            }
            if (content.Contains("ApprovedPlan"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.Api20210601.IAdminRequestApprovalPropertiesInternal)this).ApprovedPlan = (string[]) content.GetValueForProperty("ApprovedPlan",((Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.Api20210601.IAdminRequestApprovalPropertiesInternal)this).ApprovedPlan, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("Comment"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.Api20210601.IAdminRequestApprovalPropertiesInternal)this).Comment = (string) content.GetValueForProperty("Comment",((Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.Api20210601.IAdminRequestApprovalPropertiesInternal)this).Comment, global::System.Convert.ToString);
            }
            if (content.Contains("Administrator"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.Api20210601.IAdminRequestApprovalPropertiesInternal)this).Administrator = (string) content.GetValueForProperty("Administrator",((Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.Api20210601.IAdminRequestApprovalPropertiesInternal)this).Administrator, global::System.Convert.ToString);
            }
            if (content.Contains("Plan"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.Api20210601.IAdminRequestApprovalPropertiesInternal)this).Plan = (Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.Api20210601.IPlanRequesterDetails[]) content.GetValueForProperty("Plan",((Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.Api20210601.IAdminRequestApprovalPropertiesInternal)this).Plan, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.Api20210601.IPlanRequesterDetails>(__y, Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.Api20210601.PlanRequesterDetailsTypeConverter.ConvertFrom));
            }
            if (content.Contains("CollectionId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.Api20210601.IAdminRequestApprovalPropertiesInternal)this).CollectionId = (string[]) content.GetValueForProperty("CollectionId",((Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.Api20210601.IAdminRequestApprovalPropertiesInternal)this).CollectionId, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.Api20210601.AdminRequestApprovalProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.Api20210601.IAdminRequestApprovalProperties"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.Api20210601.IAdminRequestApprovalProperties DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new AdminRequestApprovalProperties(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.Api20210601.AdminRequestApprovalProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.Api20210601.IAdminRequestApprovalProperties"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.Api20210601.IAdminRequestApprovalProperties DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new AdminRequestApprovalProperties(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="AdminRequestApprovalProperties" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.Api20210601.IAdminRequestApprovalProperties FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Admin approval request resource properties
    [System.ComponentModel.TypeConverter(typeof(AdminRequestApprovalPropertiesTypeConverter))]
    public partial interface IAdminRequestApprovalProperties

    {

    }
}