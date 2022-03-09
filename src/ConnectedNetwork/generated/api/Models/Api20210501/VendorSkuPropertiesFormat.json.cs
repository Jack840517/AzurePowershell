// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Models.Api20210501
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.Extensions;

    /// <summary>Sku properties</summary>
    public partial class VendorSkuPropertiesFormat
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json erialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.Json.JsonObject container);

        /// <summary>
        /// <c>BeforeFromJson</c> will be called before the json deserialization has commenced, allowing complete customization of
        /// the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        /// <param name="returnNow">Determines if the rest of the deserialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.Json.JsonObject json, ref bool returnNow);

        /// <summary>
        /// <c>BeforeToJson</c> will be called before the json serialization has commenced, allowing complete customization of the
        /// object before it is serialized.
        /// If you wish to disable the default serialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Models.Api20210501.IVendorSkuPropertiesFormat.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Models.Api20210501.IVendorSkuPropertiesFormat.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Models.Api20210501.IVendorSkuPropertiesFormat FromJson(Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.Json.JsonObject json ? new VendorSkuPropertiesFormat(json) : null;
        }

        /// <summary>
        /// Serializes this instance of <see cref="VendorSkuPropertiesFormat" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="VendorSkuPropertiesFormat" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            AddIf( null != this._networkFunctionTemplate ? (Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.Json.JsonNode) this._networkFunctionTemplate.ToJson(null,serializationMode) : null, "networkFunctionTemplate" ,container.Add );
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._provisioningState)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.Json.JsonString(this._provisioningState.ToString()) : null, "provisioningState" ,container.Add );
            }
            AddIf( null != (((object)this._skuType)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.Json.JsonString(this._skuType.ToString()) : null, "skuType" ,container.Add );
            AddIf( null != (((object)this._deploymentMode)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.Json.JsonString(this._deploymentMode.ToString()) : null, "deploymentMode" ,container.Add );
            AddIf( null != (((object)this._networkFunctionType)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.Json.JsonString(this._networkFunctionType.ToString()) : null, "networkFunctionType" ,container.Add );
            AddIf( null != this._preview ? (Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.Json.JsonBoolean((bool)this._preview) : null, "preview" ,container.Add );
            AddIf( null != this._managedApplicationParameter ? (Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.Json.JsonNode) this._managedApplicationParameter.ToJson(null,serializationMode) : null, "managedApplicationParameters" ,container.Add );
            AddIf( null != this._managedApplicationTemplate ? (Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.Json.JsonNode) this._managedApplicationTemplate.ToJson(null,serializationMode) : null, "managedApplicationTemplate" ,container.Add );
            AfterToJson(ref container);
            return container;
        }

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.Json.JsonObject into a new instance of <see cref="VendorSkuPropertiesFormat" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal VendorSkuPropertiesFormat(Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_networkFunctionTemplate = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.Json.JsonObject>("networkFunctionTemplate"), out var __jsonNetworkFunctionTemplate) ? Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Models.Api20210501.NetworkFunctionTemplate.FromJson(__jsonNetworkFunctionTemplate) : NetworkFunctionTemplate;}
            {_provisioningState = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.Json.JsonString>("provisioningState"), out var __jsonProvisioningState) ? (string)__jsonProvisioningState : (string)ProvisioningState;}
            {_skuType = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.Json.JsonString>("skuType"), out var __jsonSkuType) ? (string)__jsonSkuType : (string)SkuType;}
            {_deploymentMode = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.Json.JsonString>("deploymentMode"), out var __jsonDeploymentMode) ? (string)__jsonDeploymentMode : (string)DeploymentMode;}
            {_networkFunctionType = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.Json.JsonString>("networkFunctionType"), out var __jsonNetworkFunctionType) ? (string)__jsonNetworkFunctionType : (string)NetworkFunctionType;}
            {_preview = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.Json.JsonBoolean>("preview"), out var __jsonPreview) ? (bool?)__jsonPreview : Preview;}
            {_managedApplicationParameter = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.Json.JsonObject>("managedApplicationParameters"), out var __jsonManagedApplicationParameters) ? Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Models.Api20210501.VendorSkuPropertiesFormatManagedApplicationParameters.FromJson(__jsonManagedApplicationParameters) : ManagedApplicationParameter;}
            {_managedApplicationTemplate = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.Json.JsonObject>("managedApplicationTemplate"), out var __jsonManagedApplicationTemplate) ? Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Models.Api20210501.VendorSkuPropertiesFormatManagedApplicationTemplate.FromJson(__jsonManagedApplicationTemplate) : ManagedApplicationTemplate;}
            AfterFromJson(json);
        }
    }
}