// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201
{
    using static Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.Extensions;

    /// <summary>Holds details about billing type and its meter guids</summary>
    public partial class MeterDetails
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json erialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.Json.JsonObject container);

        /// <summary>
        /// <c>BeforeFromJson</c> will be called before the json deserialization has commenced, allowing complete customization of
        /// the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        /// <param name="returnNow">Determines if the rest of the deserialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.Json.JsonObject json, ref bool returnNow);

        /// <summary>
        /// <c>BeforeToJson</c> will be called before the json serialization has commenced, allowing complete customization of the
        /// object before it is serialized.
        /// If you wish to disable the default serialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IMeterDetails.
        /// Note: the Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IMeterDetails interface is polymorphic, and
        /// the precise model class that will get deserialized is determined at runtime based on the payload.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IMeterDetails.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IMeterDetails FromJson(Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.Json.JsonNode node)
        {
            if (!(node is Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.Json.JsonObject json))
            {
                return null;
            }
            // Polymorphic type -- select the appropriate constructor using the discriminator

            switch ( json.StringProperty("billingType") )
            {
                case "Pav2":
                {
                    return new Pav2MeterDetails(json);
                }
                case "Purchase":
                {
                    return new PurchaseMeterDetails(json);
                }
            }
            return new MeterDetails(json);
        }

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.Json.JsonObject into a new instance of <see cref="MeterDetails" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal MeterDetails(Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_billingType = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.Json.JsonString>("billingType"), out var __jsonBillingType) ? (string)__jsonBillingType : (string)BillingType;}
            {_multiplier = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.Json.JsonNumber>("multiplier"), out var __jsonMultiplier) ? (double?)__jsonMultiplier : Multiplier;}
            {_chargingType = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.Json.JsonString>("chargingType"), out var __jsonChargingType) ? (string)__jsonChargingType : (string)ChargingType;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="MeterDetails" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="MeterDetails" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            AddIf( null != (((object)this._billingType)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.Json.JsonString(this._billingType.ToString()) : null, "billingType" ,container.Add );
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != this._multiplier ? (Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.Json.JsonNumber((double)this._multiplier) : null, "multiplier" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._chargingType)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.Json.JsonString(this._chargingType.ToString()) : null, "chargingType" ,container.Add );
            }
            AfterToJson(ref container);
            return container;
        }
    }
}