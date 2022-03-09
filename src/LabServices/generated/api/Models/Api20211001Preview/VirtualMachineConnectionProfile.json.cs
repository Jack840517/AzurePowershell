// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Extensions;

    /// <summary>The connection information for the virtual machine</summary>
    public partial class VirtualMachineConnectionProfile
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
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.IVirtualMachineConnectionProfile.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.IVirtualMachineConnectionProfile.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.IVirtualMachineConnectionProfile FromJson(Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Json.JsonObject json ? new VirtualMachineConnectionProfile(json) : null;
        }

        /// <summary>
        /// Serializes this instance of <see cref="VirtualMachineConnectionProfile" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="VirtualMachineConnectionProfile" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Json.JsonNode" />.
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
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._privateIPAddress)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Json.JsonString(this._privateIPAddress.ToString()) : null, "privateIpAddress" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._sshAuthority)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Json.JsonString(this._sshAuthority.ToString()) : null, "sshAuthority" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._sshInBrowserUrl)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Json.JsonString(this._sshInBrowserUrl.ToString()) : null, "sshInBrowserUrl" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._rdpAuthority)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Json.JsonString(this._rdpAuthority.ToString()) : null, "rdpAuthority" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._rdpInBrowserUrl)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Json.JsonString(this._rdpInBrowserUrl.ToString()) : null, "rdpInBrowserUrl" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._adminUsername)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Json.JsonString(this._adminUsername.ToString()) : null, "adminUsername" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._nonAdminUsername)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Json.JsonString(this._nonAdminUsername.ToString()) : null, "nonAdminUsername" ,container.Add );
            }
            AfterToJson(ref container);
            return container;
        }

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Json.JsonObject into a new instance of <see cref="VirtualMachineConnectionProfile" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal VirtualMachineConnectionProfile(Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_privateIPAddress = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Json.JsonString>("privateIpAddress"), out var __jsonPrivateIPAddress) ? (string)__jsonPrivateIPAddress : (string)PrivateIPAddress;}
            {_sshAuthority = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Json.JsonString>("sshAuthority"), out var __jsonSshAuthority) ? (string)__jsonSshAuthority : (string)SshAuthority;}
            {_sshInBrowserUrl = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Json.JsonString>("sshInBrowserUrl"), out var __jsonSshInBrowserUrl) ? (string)__jsonSshInBrowserUrl : (string)SshInBrowserUrl;}
            {_rdpAuthority = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Json.JsonString>("rdpAuthority"), out var __jsonRdpAuthority) ? (string)__jsonRdpAuthority : (string)RdpAuthority;}
            {_rdpInBrowserUrl = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Json.JsonString>("rdpInBrowserUrl"), out var __jsonRdpInBrowserUrl) ? (string)__jsonRdpInBrowserUrl : (string)RdpInBrowserUrl;}
            {_adminUsername = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Json.JsonString>("adminUsername"), out var __jsonAdminUsername) ? (string)__jsonAdminUsername : (string)AdminUsername;}
            {_nonAdminUsername = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Json.JsonString>("nonAdminUsername"), out var __jsonNonAdminUsername) ? (string)__jsonNonAdminUsername : (string)NonAdminUsername;}
            AfterFromJson(json);
        }
    }
}