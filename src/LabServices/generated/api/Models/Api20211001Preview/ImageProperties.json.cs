// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Extensions;

    /// <summary>Properties of an image resource.</summary>
    public partial class ImageProperties
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json erialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Json.JsonObject container);

        /// <summary>
        /// <c>BeforeFromJson</c> will be called before the json deserialization has commenced, allowing complete customization of
        /// the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        /// <param name="returnNow">Determines if the rest of the deserialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Json.JsonObject json, ref bool returnNow);

        /// <summary>
        /// <c>BeforeToJson</c> will be called before the json serialization has commenced, allowing complete customization of the
        /// object before it is serialized.
        /// If you wish to disable the default serialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.IImageProperties.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.IImageProperties.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.IImageProperties FromJson(Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Json.JsonObject json ? new ImageProperties(json) : null;
        }

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Json.JsonObject into a new instance of <see cref="ImageProperties" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal ImageProperties(Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            __imageUpdateProperties = new Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.ImageUpdateProperties(json);
            {_provisioningState = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Json.JsonString>("provisioningState"), out var __jsonProvisioningState) ? (string)__jsonProvisioningState : (string)ProvisioningState;}
            {_displayName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Json.JsonString>("displayName"), out var __jsonDisplayName) ? (string)__jsonDisplayName : (string)DisplayName;}
            {_description = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Json.JsonString>("description"), out var __jsonDescription) ? (string)__jsonDescription : (string)Description;}
            {_iconUrl = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Json.JsonString>("iconUrl"), out var __jsonIconUrl) ? (string)__jsonIconUrl : (string)IconUrl;}
            {_author = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Json.JsonString>("author"), out var __jsonAuthor) ? (string)__jsonAuthor : (string)Author;}
            {_oSType = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Json.JsonString>("osType"), out var __jsonOSType) ? (string)__jsonOSType : (string)OSType;}
            {_plan = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Json.JsonString>("plan"), out var __jsonPlan) ? (string)__jsonPlan : (string)Plan;}
            {_termsStatus = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Json.JsonString>("termsStatus"), out var __jsonTermsStatus) ? (string)__jsonTermsStatus : (string)TermsStatus;}
            {_offer = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Json.JsonString>("offer"), out var __jsonOffer) ? (string)__jsonOffer : (string)Offer;}
            {_publisher = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Json.JsonString>("publisher"), out var __jsonPublisher) ? (string)__jsonPublisher : (string)Publisher;}
            {_sku = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Json.JsonString>("sku"), out var __jsonSku) ? (string)__jsonSku : (string)Sku;}
            {_version = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Json.JsonString>("version"), out var __jsonVersion) ? (string)__jsonVersion : (string)Version;}
            {_sharedGalleryId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Json.JsonString>("sharedGalleryId"), out var __jsonSharedGalleryId) ? (string)__jsonSharedGalleryId : (string)SharedGalleryId;}
            {_availableRegion = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Json.JsonArray>("availableRegions"), out var __jsonAvailableRegions) ? If( __jsonAvailableRegions as Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Json.JsonArray, out var __v) ? new global::System.Func<string[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__v, (__u)=>(string) (__u is Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Json.JsonString __t ? (string)(__t.ToString()) : null)) ))() : null : AvailableRegion;}
            {_oSState = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Json.JsonString>("osState"), out var __jsonOSState) ? (string)__jsonOSState : (string)OSState;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="ImageProperties" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="ImageProperties" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            __imageUpdateProperties?.ToJson(container, serializationMode);
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._provisioningState)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Json.JsonString(this._provisioningState.ToString()) : null, "provisioningState" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._displayName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Json.JsonString(this._displayName.ToString()) : null, "displayName" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._description)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Json.JsonString(this._description.ToString()) : null, "description" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._iconUrl)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Json.JsonString(this._iconUrl.ToString()) : null, "iconUrl" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._author)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Json.JsonString(this._author.ToString()) : null, "author" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._oSType)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Json.JsonString(this._oSType.ToString()) : null, "osType" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._plan)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Json.JsonString(this._plan.ToString()) : null, "plan" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._termsStatus)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Json.JsonString(this._termsStatus.ToString()) : null, "termsStatus" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._offer)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Json.JsonString(this._offer.ToString()) : null, "offer" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._publisher)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Json.JsonString(this._publisher.ToString()) : null, "publisher" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._sku)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Json.JsonString(this._sku.ToString()) : null, "sku" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._version)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Json.JsonString(this._version.ToString()) : null, "version" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._sharedGalleryId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Json.JsonString(this._sharedGalleryId.ToString()) : null, "sharedGalleryId" ,container.Add );
            }
            if (null != this._availableRegion)
            {
                var __w = new Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Json.XNodeArray();
                foreach( var __x in this._availableRegion )
                {
                    AddIf(null != (((object)__x)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Json.JsonString(__x.ToString()) : null ,__w.Add);
                }
                container.Add("availableRegions",__w);
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._oSState)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Json.JsonString(this._oSState.ToString()) : null, "osState" ,container.Add );
            }
            AfterToJson(ref container);
            return container;
        }
    }
}