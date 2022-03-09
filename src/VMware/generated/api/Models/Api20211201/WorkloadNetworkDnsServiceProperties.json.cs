// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201
{
    using static Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.Extensions;

    /// <summary>NSX DNS Service Properties</summary>
    public partial class WorkloadNetworkDnsServiceProperties
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json erialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.Json.JsonObject container);

        /// <summary>
        /// <c>BeforeFromJson</c> will be called before the json deserialization has commenced, allowing complete customization of
        /// the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        /// <param name="returnNow">Determines if the rest of the deserialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.Json.JsonObject json, ref bool returnNow);

        /// <summary>
        /// <c>BeforeToJson</c> will be called before the json serialization has commenced, allowing complete customization of the
        /// object before it is serialized.
        /// If you wish to disable the default serialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.IWorkloadNetworkDnsServiceProperties.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.IWorkloadNetworkDnsServiceProperties.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.IWorkloadNetworkDnsServiceProperties FromJson(Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.Json.JsonObject json ? new WorkloadNetworkDnsServiceProperties(json) : null;
        }

        /// <summary>
        /// Serializes this instance of <see cref="WorkloadNetworkDnsServiceProperties" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.Json.JsonNode"
        /// />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="WorkloadNetworkDnsServiceProperties" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            AddIf( null != (((object)this._displayName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.Json.JsonString(this._displayName.ToString()) : null, "displayName" ,container.Add );
            AddIf( null != (((object)this._dnsServiceIP)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.Json.JsonString(this._dnsServiceIP.ToString()) : null, "dnsServiceIp" ,container.Add );
            AddIf( null != (((object)this._defaultDnsZone)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.Json.JsonString(this._defaultDnsZone.ToString()) : null, "defaultDnsZone" ,container.Add );
            if (null != this._fqdnZone)
            {
                var __w = new Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.Json.XNodeArray();
                foreach( var __x in this._fqdnZone )
                {
                    AddIf(null != (((object)__x)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.Json.JsonString(__x.ToString()) : null ,__w.Add);
                }
                container.Add("fqdnZones",__w);
            }
            AddIf( null != (((object)this._logLevel)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.Json.JsonString(this._logLevel.ToString()) : null, "logLevel" ,container.Add );
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._status)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.Json.JsonString(this._status.ToString()) : null, "status" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._provisioningState)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.Json.JsonString(this._provisioningState.ToString()) : null, "provisioningState" ,container.Add );
            }
            AddIf( null != this._revision ? (Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.Json.JsonNumber((long)this._revision) : null, "revision" ,container.Add );
            AfterToJson(ref container);
            return container;
        }

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.Json.JsonObject into a new instance of <see cref="WorkloadNetworkDnsServiceProperties" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal WorkloadNetworkDnsServiceProperties(Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_displayName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.Json.JsonString>("displayName"), out var __jsonDisplayName) ? (string)__jsonDisplayName : (string)DisplayName;}
            {_dnsServiceIP = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.Json.JsonString>("dnsServiceIp"), out var __jsonDnsServiceIP) ? (string)__jsonDnsServiceIP : (string)DnsServiceIP;}
            {_defaultDnsZone = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.Json.JsonString>("defaultDnsZone"), out var __jsonDefaultDnsZone) ? (string)__jsonDefaultDnsZone : (string)DefaultDnsZone;}
            {_fqdnZone = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.Json.JsonArray>("fqdnZones"), out var __jsonFqdnZones) ? If( __jsonFqdnZones as Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.Json.JsonArray, out var __v) ? new global::System.Func<string[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__v, (__u)=>(string) (__u is Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.Json.JsonString __t ? (string)(__t.ToString()) : null)) ))() : null : FqdnZone;}
            {_logLevel = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.Json.JsonString>("logLevel"), out var __jsonLogLevel) ? (string)__jsonLogLevel : (string)LogLevel;}
            {_status = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.Json.JsonString>("status"), out var __jsonStatus) ? (string)__jsonStatus : (string)Status;}
            {_provisioningState = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.Json.JsonString>("provisioningState"), out var __jsonProvisioningState) ? (string)__jsonProvisioningState : (string)ProvisioningState;}
            {_revision = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.Json.JsonNumber>("revision"), out var __jsonRevision) ? (long?)__jsonRevision : Revision;}
            AfterFromJson(json);
        }
    }
}