// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201
{
    using static Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.Extensions;

    /// <summary>Dimensions of a configuration.</summary>
    public partial class Dimensions
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
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.Json.JsonObject into a new instance of <see cref="Dimensions" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal Dimensions(Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_length = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.Json.JsonNumber>("length"), out var __jsonLength) ? (double?)__jsonLength : Length;}
            {_height = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.Json.JsonNumber>("height"), out var __jsonHeight) ? (double?)__jsonHeight : Height;}
            {_width = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.Json.JsonNumber>("width"), out var __jsonWidth) ? (double?)__jsonWidth : Width;}
            {_lengthHeightUnit = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.Json.JsonString>("lengthHeightUnit"), out var __jsonLengthHeightUnit) ? (string)__jsonLengthHeightUnit : (string)LengthHeightUnit;}
            {_weight = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.Json.JsonNumber>("weight"), out var __jsonWeight) ? (double?)__jsonWeight : Weight;}
            {_depth = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.Json.JsonNumber>("depth"), out var __jsonDepth) ? (double?)__jsonDepth : Depth;}
            {_weightUnit = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.Json.JsonString>("weightUnit"), out var __jsonWeightUnit) ? (string)__jsonWeightUnit : (string)WeightUnit;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IDimensions.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IDimensions.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IDimensions FromJson(Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.Json.JsonObject json ? new Dimensions(json) : null;
        }

        /// <summary>
        /// Serializes this instance of <see cref="Dimensions" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="Dimensions" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.Json.JsonNode" />.
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
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != this._length ? (Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.Json.JsonNumber((double)this._length) : null, "length" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != this._height ? (Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.Json.JsonNumber((double)this._height) : null, "height" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != this._width ? (Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.Json.JsonNumber((double)this._width) : null, "width" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._lengthHeightUnit)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.Json.JsonString(this._lengthHeightUnit.ToString()) : null, "lengthHeightUnit" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != this._weight ? (Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.Json.JsonNumber((double)this._weight) : null, "weight" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != this._depth ? (Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.Json.JsonNumber((double)this._depth) : null, "depth" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._weightUnit)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.Json.JsonString(this._weightUnit.ToString()) : null, "weightUnit" ,container.Add );
            }
            AfterToJson(ref container);
            return container;
        }
    }
}