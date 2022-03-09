// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview
{
    using Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Runtime.PowerShell;

    /// <summary>The properties of the registration assignment.</summary>
    [System.ComponentModel.TypeConverter(typeof(RegistrationAssignmentPropertiesTypeConverter))]
    public partial class RegistrationAssignmentProperties
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.RegistrationAssignmentProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IRegistrationAssignmentProperties"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IRegistrationAssignmentProperties DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new RegistrationAssignmentProperties(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.RegistrationAssignmentProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IRegistrationAssignmentProperties"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IRegistrationAssignmentProperties DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new RegistrationAssignmentProperties(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="RegistrationAssignmentProperties" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IRegistrationAssignmentProperties FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.RegistrationAssignmentProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal RegistrationAssignmentProperties(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("RegistrationDefinition"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IRegistrationAssignmentPropertiesInternal)this).RegistrationDefinition = (Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IRegistrationAssignmentPropertiesRegistrationDefinition) content.GetValueForProperty("RegistrationDefinition",((Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IRegistrationAssignmentPropertiesInternal)this).RegistrationDefinition, Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.RegistrationAssignmentPropertiesRegistrationDefinitionTypeConverter.ConvertFrom);
            }
            if (content.Contains("RegistrationDefinitionId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IRegistrationAssignmentPropertiesInternal)this).RegistrationDefinitionId = (string) content.GetValueForProperty("RegistrationDefinitionId",((Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IRegistrationAssignmentPropertiesInternal)this).RegistrationDefinitionId, global::System.Convert.ToString);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IRegistrationAssignmentPropertiesInternal)this).ProvisioningState = (Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Support.ProvisioningState?) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IRegistrationAssignmentPropertiesInternal)this).ProvisioningState, Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Support.ProvisioningState.CreateFrom);
            }
            if (content.Contains("RegistrationDefinitionPlan"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IRegistrationAssignmentPropertiesInternal)this).RegistrationDefinitionPlan = (Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IPlan) content.GetValueForProperty("RegistrationDefinitionPlan",((Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IRegistrationAssignmentPropertiesInternal)this).RegistrationDefinitionPlan, Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.PlanTypeConverter.ConvertFrom);
            }
            if (content.Contains("RegistrationDefinitionProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IRegistrationAssignmentPropertiesInternal)this).RegistrationDefinitionProperty = (Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IRegistrationAssignmentPropertiesRegistrationDefinitionProperties) content.GetValueForProperty("RegistrationDefinitionProperty",((Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IRegistrationAssignmentPropertiesInternal)this).RegistrationDefinitionProperty, Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.RegistrationAssignmentPropertiesRegistrationDefinitionPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IRegistrationAssignmentPropertiesInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IRegistrationAssignmentPropertiesInternal)this).Id, global::System.Convert.ToString);
            }
            if (content.Contains("RegistrationDefinitionType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IRegistrationAssignmentPropertiesInternal)this).RegistrationDefinitionType = (string) content.GetValueForProperty("RegistrationDefinitionType",((Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IRegistrationAssignmentPropertiesInternal)this).RegistrationDefinitionType, global::System.Convert.ToString);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IRegistrationAssignmentPropertiesInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IRegistrationAssignmentPropertiesInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("RegistrationDefinitionPropertiesProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IRegistrationAssignmentPropertiesInternal)this).RegistrationDefinitionPropertiesProvisioningState = (Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Support.ProvisioningState?) content.GetValueForProperty("RegistrationDefinitionPropertiesProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IRegistrationAssignmentPropertiesInternal)this).RegistrationDefinitionPropertiesProvisioningState, Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Support.ProvisioningState.CreateFrom);
            }
            if (content.Contains("PlanName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IRegistrationAssignmentPropertiesInternal)this).PlanName = (string) content.GetValueForProperty("PlanName",((Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IRegistrationAssignmentPropertiesInternal)this).PlanName, global::System.Convert.ToString);
            }
            if (content.Contains("PlanPublisher"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IRegistrationAssignmentPropertiesInternal)this).PlanPublisher = (string) content.GetValueForProperty("PlanPublisher",((Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IRegistrationAssignmentPropertiesInternal)this).PlanPublisher, global::System.Convert.ToString);
            }
            if (content.Contains("PlanProduct"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IRegistrationAssignmentPropertiesInternal)this).PlanProduct = (string) content.GetValueForProperty("PlanProduct",((Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IRegistrationAssignmentPropertiesInternal)this).PlanProduct, global::System.Convert.ToString);
            }
            if (content.Contains("PlanVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IRegistrationAssignmentPropertiesInternal)this).PlanVersion = (string) content.GetValueForProperty("PlanVersion",((Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IRegistrationAssignmentPropertiesInternal)this).PlanVersion, global::System.Convert.ToString);
            }
            if (content.Contains("Description"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IRegistrationAssignmentPropertiesInternal)this).Description = (string) content.GetValueForProperty("Description",((Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IRegistrationAssignmentPropertiesInternal)this).Description, global::System.Convert.ToString);
            }
            if (content.Contains("Authorization"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IRegistrationAssignmentPropertiesInternal)this).Authorization = (Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IAuthorization[]) content.GetValueForProperty("Authorization",((Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IRegistrationAssignmentPropertiesInternal)this).Authorization, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IAuthorization>(__y, Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.AuthorizationTypeConverter.ConvertFrom));
            }
            if (content.Contains("EligibleAuthorization"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IRegistrationAssignmentPropertiesInternal)this).EligibleAuthorization = (Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IEligibleAuthorization[]) content.GetValueForProperty("EligibleAuthorization",((Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IRegistrationAssignmentPropertiesInternal)this).EligibleAuthorization, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IEligibleAuthorization>(__y, Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.EligibleAuthorizationTypeConverter.ConvertFrom));
            }
            if (content.Contains("RegistrationDefinitionPropertiesRegistrationDefinitionName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IRegistrationAssignmentPropertiesInternal)this).RegistrationDefinitionPropertiesRegistrationDefinitionName = (string) content.GetValueForProperty("RegistrationDefinitionPropertiesRegistrationDefinitionName",((Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IRegistrationAssignmentPropertiesInternal)this).RegistrationDefinitionPropertiesRegistrationDefinitionName, global::System.Convert.ToString);
            }
            if (content.Contains("ManageeTenantId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IRegistrationAssignmentPropertiesInternal)this).ManageeTenantId = (string) content.GetValueForProperty("ManageeTenantId",((Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IRegistrationAssignmentPropertiesInternal)this).ManageeTenantId, global::System.Convert.ToString);
            }
            if (content.Contains("ManageeTenantName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IRegistrationAssignmentPropertiesInternal)this).ManageeTenantName = (string) content.GetValueForProperty("ManageeTenantName",((Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IRegistrationAssignmentPropertiesInternal)this).ManageeTenantName, global::System.Convert.ToString);
            }
            if (content.Contains("ManagedByTenantId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IRegistrationAssignmentPropertiesInternal)this).ManagedByTenantId = (string) content.GetValueForProperty("ManagedByTenantId",((Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IRegistrationAssignmentPropertiesInternal)this).ManagedByTenantId, global::System.Convert.ToString);
            }
            if (content.Contains("ManagedByTenantName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IRegistrationAssignmentPropertiesInternal)this).ManagedByTenantName = (string) content.GetValueForProperty("ManagedByTenantName",((Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IRegistrationAssignmentPropertiesInternal)this).ManagedByTenantName, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.RegistrationAssignmentProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal RegistrationAssignmentProperties(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("RegistrationDefinition"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IRegistrationAssignmentPropertiesInternal)this).RegistrationDefinition = (Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IRegistrationAssignmentPropertiesRegistrationDefinition) content.GetValueForProperty("RegistrationDefinition",((Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IRegistrationAssignmentPropertiesInternal)this).RegistrationDefinition, Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.RegistrationAssignmentPropertiesRegistrationDefinitionTypeConverter.ConvertFrom);
            }
            if (content.Contains("RegistrationDefinitionId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IRegistrationAssignmentPropertiesInternal)this).RegistrationDefinitionId = (string) content.GetValueForProperty("RegistrationDefinitionId",((Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IRegistrationAssignmentPropertiesInternal)this).RegistrationDefinitionId, global::System.Convert.ToString);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IRegistrationAssignmentPropertiesInternal)this).ProvisioningState = (Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Support.ProvisioningState?) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IRegistrationAssignmentPropertiesInternal)this).ProvisioningState, Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Support.ProvisioningState.CreateFrom);
            }
            if (content.Contains("RegistrationDefinitionPlan"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IRegistrationAssignmentPropertiesInternal)this).RegistrationDefinitionPlan = (Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IPlan) content.GetValueForProperty("RegistrationDefinitionPlan",((Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IRegistrationAssignmentPropertiesInternal)this).RegistrationDefinitionPlan, Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.PlanTypeConverter.ConvertFrom);
            }
            if (content.Contains("RegistrationDefinitionProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IRegistrationAssignmentPropertiesInternal)this).RegistrationDefinitionProperty = (Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IRegistrationAssignmentPropertiesRegistrationDefinitionProperties) content.GetValueForProperty("RegistrationDefinitionProperty",((Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IRegistrationAssignmentPropertiesInternal)this).RegistrationDefinitionProperty, Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.RegistrationAssignmentPropertiesRegistrationDefinitionPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IRegistrationAssignmentPropertiesInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IRegistrationAssignmentPropertiesInternal)this).Id, global::System.Convert.ToString);
            }
            if (content.Contains("RegistrationDefinitionType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IRegistrationAssignmentPropertiesInternal)this).RegistrationDefinitionType = (string) content.GetValueForProperty("RegistrationDefinitionType",((Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IRegistrationAssignmentPropertiesInternal)this).RegistrationDefinitionType, global::System.Convert.ToString);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IRegistrationAssignmentPropertiesInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IRegistrationAssignmentPropertiesInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("RegistrationDefinitionPropertiesProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IRegistrationAssignmentPropertiesInternal)this).RegistrationDefinitionPropertiesProvisioningState = (Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Support.ProvisioningState?) content.GetValueForProperty("RegistrationDefinitionPropertiesProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IRegistrationAssignmentPropertiesInternal)this).RegistrationDefinitionPropertiesProvisioningState, Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Support.ProvisioningState.CreateFrom);
            }
            if (content.Contains("PlanName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IRegistrationAssignmentPropertiesInternal)this).PlanName = (string) content.GetValueForProperty("PlanName",((Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IRegistrationAssignmentPropertiesInternal)this).PlanName, global::System.Convert.ToString);
            }
            if (content.Contains("PlanPublisher"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IRegistrationAssignmentPropertiesInternal)this).PlanPublisher = (string) content.GetValueForProperty("PlanPublisher",((Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IRegistrationAssignmentPropertiesInternal)this).PlanPublisher, global::System.Convert.ToString);
            }
            if (content.Contains("PlanProduct"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IRegistrationAssignmentPropertiesInternal)this).PlanProduct = (string) content.GetValueForProperty("PlanProduct",((Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IRegistrationAssignmentPropertiesInternal)this).PlanProduct, global::System.Convert.ToString);
            }
            if (content.Contains("PlanVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IRegistrationAssignmentPropertiesInternal)this).PlanVersion = (string) content.GetValueForProperty("PlanVersion",((Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IRegistrationAssignmentPropertiesInternal)this).PlanVersion, global::System.Convert.ToString);
            }
            if (content.Contains("Description"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IRegistrationAssignmentPropertiesInternal)this).Description = (string) content.GetValueForProperty("Description",((Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IRegistrationAssignmentPropertiesInternal)this).Description, global::System.Convert.ToString);
            }
            if (content.Contains("Authorization"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IRegistrationAssignmentPropertiesInternal)this).Authorization = (Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IAuthorization[]) content.GetValueForProperty("Authorization",((Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IRegistrationAssignmentPropertiesInternal)this).Authorization, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IAuthorization>(__y, Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.AuthorizationTypeConverter.ConvertFrom));
            }
            if (content.Contains("EligibleAuthorization"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IRegistrationAssignmentPropertiesInternal)this).EligibleAuthorization = (Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IEligibleAuthorization[]) content.GetValueForProperty("EligibleAuthorization",((Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IRegistrationAssignmentPropertiesInternal)this).EligibleAuthorization, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IEligibleAuthorization>(__y, Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.EligibleAuthorizationTypeConverter.ConvertFrom));
            }
            if (content.Contains("RegistrationDefinitionPropertiesRegistrationDefinitionName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IRegistrationAssignmentPropertiesInternal)this).RegistrationDefinitionPropertiesRegistrationDefinitionName = (string) content.GetValueForProperty("RegistrationDefinitionPropertiesRegistrationDefinitionName",((Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IRegistrationAssignmentPropertiesInternal)this).RegistrationDefinitionPropertiesRegistrationDefinitionName, global::System.Convert.ToString);
            }
            if (content.Contains("ManageeTenantId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IRegistrationAssignmentPropertiesInternal)this).ManageeTenantId = (string) content.GetValueForProperty("ManageeTenantId",((Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IRegistrationAssignmentPropertiesInternal)this).ManageeTenantId, global::System.Convert.ToString);
            }
            if (content.Contains("ManageeTenantName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IRegistrationAssignmentPropertiesInternal)this).ManageeTenantName = (string) content.GetValueForProperty("ManageeTenantName",((Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IRegistrationAssignmentPropertiesInternal)this).ManageeTenantName, global::System.Convert.ToString);
            }
            if (content.Contains("ManagedByTenantId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IRegistrationAssignmentPropertiesInternal)this).ManagedByTenantId = (string) content.GetValueForProperty("ManagedByTenantId",((Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IRegistrationAssignmentPropertiesInternal)this).ManagedByTenantId, global::System.Convert.ToString);
            }
            if (content.Contains("ManagedByTenantName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IRegistrationAssignmentPropertiesInternal)this).ManagedByTenantName = (string) content.GetValueForProperty("ManagedByTenantName",((Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IRegistrationAssignmentPropertiesInternal)this).ManagedByTenantName, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Runtime.SerializationMode.IncludeAll)?.ToString();

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
    /// The properties of the registration assignment.
    [System.ComponentModel.TypeConverter(typeof(RegistrationAssignmentPropertiesTypeConverter))]
    public partial interface IRegistrationAssignmentProperties

    {

    }
}