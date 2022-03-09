namespace Microsoft.Azure.PowerShell.Cmdlets.Maps.Models.Api20210201
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Maps.Runtime.Extensions;

    /// <summary>
    /// Dimension of map account, for example API Category, Api Name, Result Type, and Response Code.
    /// </summary>
    public partial class Dimension
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.Maps.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json erialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.Maps.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.Maps.Runtime.Json.JsonObject container);

        /// <summary>
        /// <c>BeforeFromJson</c> will be called before the json deserialization has commenced, allowing complete customization of
        /// the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        /// <param name="returnNow">Determines if the rest of the deserialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.Maps.Runtime.Json.JsonObject json, ref bool returnNow);

        /// <summary>
        /// <c>BeforeToJson</c> will be called before the json serialization has commenced, allowing complete customization of the
        /// object before it is serialized.
        /// If you wish to disable the default serialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.Maps.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.Maps.Runtime.Json.JsonObject into a new instance of <see cref="Dimension" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.Maps.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal Dimension(Microsoft.Azure.PowerShell.Cmdlets.Maps.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_name = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Maps.Runtime.Json.JsonString>("name"), out var __jsonName) ? (string)__jsonName : (string)Name;}
            {_displayName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Maps.Runtime.Json.JsonString>("displayName"), out var __jsonDisplayName) ? (string)__jsonDisplayName : (string)DisplayName;}
            {_internalName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Maps.Runtime.Json.JsonString>("internalName"), out var __jsonInternalName) ? (string)__jsonInternalName : (string)InternalName;}
            {_internalMetricName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Maps.Runtime.Json.JsonString>("internalMetricName"), out var __jsonInternalMetricName) ? (string)__jsonInternalMetricName : (string)InternalMetricName;}
            {_sourceMdmNamespace = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Maps.Runtime.Json.JsonString>("sourceMdmNamespace"), out var __jsonSourceMdmNamespace) ? (string)__jsonSourceMdmNamespace : (string)SourceMdmNamespace;}
            {_toBeExportedToShoebox = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Maps.Runtime.Json.JsonBoolean>("toBeExportedToShoebox"), out var __jsonToBeExportedToShoebox) ? (bool?)__jsonToBeExportedToShoebox : ToBeExportedToShoebox;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Maps.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.Maps.Models.Api20210201.IDimension.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Maps.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.Maps.Models.Api20210201.IDimension.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Maps.Models.Api20210201.IDimension FromJson(Microsoft.Azure.PowerShell.Cmdlets.Maps.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.Maps.Runtime.Json.JsonObject json ? new Dimension(json) : null;
        }

        /// <summary>
        /// Serializes this instance of <see cref="Dimension" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Maps.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.Maps.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.Maps.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="Dimension" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Maps.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.Maps.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.Maps.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.Maps.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.Maps.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            AddIf( null != (((object)this._name)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Maps.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Maps.Runtime.Json.JsonString(this._name.ToString()) : null, "name" ,container.Add );
            AddIf( null != (((object)this._displayName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Maps.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Maps.Runtime.Json.JsonString(this._displayName.ToString()) : null, "displayName" ,container.Add );
            AddIf( null != (((object)this._internalName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Maps.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Maps.Runtime.Json.JsonString(this._internalName.ToString()) : null, "internalName" ,container.Add );
            AddIf( null != (((object)this._internalMetricName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Maps.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Maps.Runtime.Json.JsonString(this._internalMetricName.ToString()) : null, "internalMetricName" ,container.Add );
            AddIf( null != (((object)this._sourceMdmNamespace)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Maps.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Maps.Runtime.Json.JsonString(this._sourceMdmNamespace.ToString()) : null, "sourceMdmNamespace" ,container.Add );
            AddIf( null != this._toBeExportedToShoebox ? (Microsoft.Azure.PowerShell.Cmdlets.Maps.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.Maps.Runtime.Json.JsonBoolean((bool)this._toBeExportedToShoebox) : null, "toBeExportedToShoebox" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}