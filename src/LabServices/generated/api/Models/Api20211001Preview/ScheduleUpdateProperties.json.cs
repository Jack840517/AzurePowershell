// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Extensions;

    /// <summary>Schedule resource properties used for updates.</summary>
    public partial class ScheduleUpdateProperties
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
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.IScheduleUpdateProperties.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.IScheduleUpdateProperties.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.IScheduleUpdateProperties FromJson(Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Json.JsonObject json ? new ScheduleUpdateProperties(json) : null;
        }

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Json.JsonObject into a new instance of <see cref="ScheduleUpdateProperties" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal ScheduleUpdateProperties(Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_recurrencePattern = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Json.JsonObject>("recurrencePattern"), out var __jsonRecurrencePattern) ? Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.RecurrencePattern.FromJson(__jsonRecurrencePattern) : RecurrencePattern;}
            {_startAt = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Json.JsonString>("startAt"), out var __jsonStartAt) ? global::System.DateTime.TryParse((string)__jsonStartAt, global::System.Globalization.CultureInfo.InvariantCulture, global::System.Globalization.DateTimeStyles.AdjustToUniversal, out var __jsonStartAtValue) ? __jsonStartAtValue : StartAt : StartAt;}
            {_stopAt = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Json.JsonString>("stopAt"), out var __jsonStopAt) ? global::System.DateTime.TryParse((string)__jsonStopAt, global::System.Globalization.CultureInfo.InvariantCulture, global::System.Globalization.DateTimeStyles.AdjustToUniversal, out var __jsonStopAtValue) ? __jsonStopAtValue : StopAt : StopAt;}
            {_timeZoneId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Json.JsonString>("timeZoneId"), out var __jsonTimeZoneId) ? (string)__jsonTimeZoneId : (string)TimeZoneId;}
            {_note = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Json.JsonString>("notes"), out var __jsonNotes) ? (string)__jsonNotes : (string)Note;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="ScheduleUpdateProperties" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="ScheduleUpdateProperties" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Json.JsonNode" />.
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
            AddIf( null != this._recurrencePattern ? (Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Json.JsonNode) this._recurrencePattern.ToJson(null,serializationMode) : null, "recurrencePattern" ,container.Add );
            AddIf( null != this._startAt ? (Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Json.JsonString(this._startAt?.ToString(@"yyyy'-'MM'-'dd'T'HH':'mm':'ss.fffffffK",global::System.Globalization.CultureInfo.InvariantCulture)) : null, "startAt" ,container.Add );
            AddIf( null != this._stopAt ? (Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Json.JsonString(this._stopAt?.ToString(@"yyyy'-'MM'-'dd'T'HH':'mm':'ss.fffffffK",global::System.Globalization.CultureInfo.InvariantCulture)) : null, "stopAt" ,container.Add );
            AddIf( null != (((object)this._timeZoneId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Json.JsonString(this._timeZoneId.ToString()) : null, "timeZoneId" ,container.Add );
            AddIf( null != (((object)this._note)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Json.JsonString(this._note.ToString()) : null, "notes" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}