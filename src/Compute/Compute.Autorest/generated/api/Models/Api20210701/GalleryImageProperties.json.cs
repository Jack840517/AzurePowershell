// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.Extensions;

    /// <summary>Describes the properties of a gallery image definition.</summary>
    public partial class GalleryImageProperties
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json erialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.Json.JsonObject container);

        /// <summary>
        /// <c>BeforeFromJson</c> will be called before the json deserialization has commenced, allowing complete customization of
        /// the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        /// <param name="returnNow">Determines if the rest of the deserialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.Json.JsonObject json, ref bool returnNow);

        /// <summary>
        /// <c>BeforeToJson</c> will be called before the json serialization has commenced, allowing complete customization of the
        /// object before it is serialized.
        /// If you wish to disable the default serialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryImageProperties.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryImageProperties.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryImageProperties FromJson(Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.Json.JsonObject json ? new GalleryImageProperties(json) : null;
        }

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.Json.JsonObject into a new instance of <see cref="GalleryImageProperties" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal GalleryImageProperties(Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_identifier = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.Json.JsonObject>("identifier"), out var __jsonIdentifier) ? Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.GalleryImageIdentifier.FromJson(__jsonIdentifier) : Identifier;}
            {_recommended = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.Json.JsonObject>("recommended"), out var __jsonRecommended) ? Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.RecommendedMachineConfiguration.FromJson(__jsonRecommended) : Recommended;}
            {_disallowed = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.Json.JsonObject>("disallowed"), out var __jsonDisallowed) ? Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.Disallowed.FromJson(__jsonDisallowed) : Disallowed;}
            {_purchasePlan = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.Json.JsonObject>("purchasePlan"), out var __jsonPurchasePlan) ? Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.ImagePurchasePlan.FromJson(__jsonPurchasePlan) : PurchasePlan;}
            {_description = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.Json.JsonString>("description"), out var __jsonDescription) ? (string)__jsonDescription : (string)Description;}
            {_eula = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.Json.JsonString>("eula"), out var __jsonEula) ? (string)__jsonEula : (string)Eula;}
            {_privacyStatementUri = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.Json.JsonString>("privacyStatementUri"), out var __jsonPrivacyStatementUri) ? (string)__jsonPrivacyStatementUri : (string)PrivacyStatementUri;}
            {_releaseNoteUri = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.Json.JsonString>("releaseNoteUri"), out var __jsonReleaseNoteUri) ? (string)__jsonReleaseNoteUri : (string)ReleaseNoteUri;}
            {_oSType = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.Json.JsonString>("osType"), out var __jsonOSType) ? (string)__jsonOSType : (string)OSType;}
            {_oSState = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.Json.JsonString>("osState"), out var __jsonOSState) ? (string)__jsonOSState : (string)OSState;}
            {_hyperVGeneration = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.Json.JsonString>("hyperVGeneration"), out var __jsonHyperVGeneration) ? (string)__jsonHyperVGeneration : (string)HyperVGeneration;}
            {_endOfLifeDate = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.Json.JsonString>("endOfLifeDate"), out var __jsonEndOfLifeDate) ? global::System.DateTime.TryParse((string)__jsonEndOfLifeDate, global::System.Globalization.CultureInfo.InvariantCulture, global::System.Globalization.DateTimeStyles.AdjustToUniversal, out var __jsonEndOfLifeDateValue) ? __jsonEndOfLifeDateValue : EndOfLifeDate : EndOfLifeDate;}
            {_provisioningState = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.Json.JsonString>("provisioningState"), out var __jsonProvisioningState) ? (string)__jsonProvisioningState : (string)ProvisioningState;}
            {_feature = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.Json.JsonArray>("features"), out var __jsonFeatures) ? If( __jsonFeatures as Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.Json.JsonArray, out var __v) ? new global::System.Func<Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryImageFeature[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__v, (__u)=>(Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryImageFeature) (Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.GalleryImageFeature.FromJson(__u) )) ))() : null : Feature;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="GalleryImageProperties" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="GalleryImageProperties" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            AddIf( null != this._identifier ? (Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.Json.JsonNode) this._identifier.ToJson(null,serializationMode) : null, "identifier" ,container.Add );
            AddIf( null != this._recommended ? (Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.Json.JsonNode) this._recommended.ToJson(null,serializationMode) : null, "recommended" ,container.Add );
            AddIf( null != this._disallowed ? (Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.Json.JsonNode) this._disallowed.ToJson(null,serializationMode) : null, "disallowed" ,container.Add );
            AddIf( null != this._purchasePlan ? (Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.Json.JsonNode) this._purchasePlan.ToJson(null,serializationMode) : null, "purchasePlan" ,container.Add );
            AddIf( null != (((object)this._description)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.Json.JsonString(this._description.ToString()) : null, "description" ,container.Add );
            AddIf( null != (((object)this._eula)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.Json.JsonString(this._eula.ToString()) : null, "eula" ,container.Add );
            AddIf( null != (((object)this._privacyStatementUri)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.Json.JsonString(this._privacyStatementUri.ToString()) : null, "privacyStatementUri" ,container.Add );
            AddIf( null != (((object)this._releaseNoteUri)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.Json.JsonString(this._releaseNoteUri.ToString()) : null, "releaseNoteUri" ,container.Add );
            AddIf( null != (((object)this._oSType)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.Json.JsonString(this._oSType.ToString()) : null, "osType" ,container.Add );
            AddIf( null != (((object)this._oSState)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.Json.JsonString(this._oSState.ToString()) : null, "osState" ,container.Add );
            AddIf( null != (((object)this._hyperVGeneration)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.Json.JsonString(this._hyperVGeneration.ToString()) : null, "hyperVGeneration" ,container.Add );
            AddIf( null != this._endOfLifeDate ? (Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.Json.JsonString(this._endOfLifeDate?.ToString(@"yyyy'-'MM'-'dd'T'HH':'mm':'ss.fffffffK",global::System.Globalization.CultureInfo.InvariantCulture)) : null, "endOfLifeDate" ,container.Add );
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._provisioningState)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.Json.JsonString(this._provisioningState.ToString()) : null, "provisioningState" ,container.Add );
            }
            if (null != this._feature)
            {
                var __w = new Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.Json.XNodeArray();
                foreach( var __x in this._feature )
                {
                    AddIf(__x?.ToJson(null, serializationMode) ,__w.Add);
                }
                container.Add("features",__w);
            }
            AfterToJson(ref container);
            return container;
        }
    }
}