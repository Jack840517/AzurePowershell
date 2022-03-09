// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Extensions;

    public partial class DesktopVirtualizationIdentity
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json erialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Json.JsonObject container);

        /// <summary>
        /// <c>BeforeFromJson</c> will be called before the json deserialization has commenced, allowing complete customization of
        /// the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        /// <param name="returnNow">Determines if the rest of the deserialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Json.JsonObject json, ref bool returnNow);

        /// <summary>
        /// <c>BeforeToJson</c> will be called before the json serialization has commenced, allowing complete customization of the
        /// object before it is serialized.
        /// If you wish to disable the default serialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Json.JsonObject into a new instance of <see cref="DesktopVirtualizationIdentity" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal DesktopVirtualizationIdentity(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_subscriptionId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Json.JsonString>("subscriptionId"), out var __jsonSubscriptionId) ? (string)__jsonSubscriptionId : (string)SubscriptionId;}
            {_resourceGroupName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Json.JsonString>("resourceGroupName"), out var __jsonResourceGroupName) ? (string)__jsonResourceGroupName : (string)ResourceGroupName;}
            {_workspaceName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Json.JsonString>("workspaceName"), out var __jsonWorkspaceName) ? (string)__jsonWorkspaceName : (string)WorkspaceName;}
            {_scalingPlanName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Json.JsonString>("scalingPlanName"), out var __jsonScalingPlanName) ? (string)__jsonScalingPlanName : (string)ScalingPlanName;}
            {_hostPoolName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Json.JsonString>("hostPoolName"), out var __jsonHostPoolName) ? (string)__jsonHostPoolName : (string)HostPoolName;}
            {_applicationGroupName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Json.JsonString>("applicationGroupName"), out var __jsonApplicationGroupName) ? (string)__jsonApplicationGroupName : (string)ApplicationGroupName;}
            {_applicationName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Json.JsonString>("applicationName"), out var __jsonApplicationName) ? (string)__jsonApplicationName : (string)ApplicationName;}
            {_desktopName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Json.JsonString>("desktopName"), out var __jsonDesktopName) ? (string)__jsonDesktopName : (string)DesktopName;}
            {_sessionHostName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Json.JsonString>("sessionHostName"), out var __jsonSessionHostName) ? (string)__jsonSessionHostName : (string)SessionHostName;}
            {_userSessionId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Json.JsonString>("userSessionId"), out var __jsonUserSessionId) ? (string)__jsonUserSessionId : (string)UserSessionId;}
            {_msixPackageFullName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Json.JsonString>("msixPackageFullName"), out var __jsonMsixPackageFullName) ? (string)__jsonMsixPackageFullName : (string)MsixPackageFullName;}
            {_id = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Json.JsonString>("id"), out var __jsonId) ? (string)__jsonId : (string)Id;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.IDesktopVirtualizationIdentity.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.IDesktopVirtualizationIdentity.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.IDesktopVirtualizationIdentity FromJson(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Json.JsonObject json ? new DesktopVirtualizationIdentity(json) : null;
        }

        /// <summary>
        /// Serializes this instance of <see cref="DesktopVirtualizationIdentity" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="DesktopVirtualizationIdentity" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            AddIf( null != (((object)this._subscriptionId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Json.JsonString(this._subscriptionId.ToString()) : null, "subscriptionId" ,container.Add );
            AddIf( null != (((object)this._resourceGroupName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Json.JsonString(this._resourceGroupName.ToString()) : null, "resourceGroupName" ,container.Add );
            AddIf( null != (((object)this._workspaceName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Json.JsonString(this._workspaceName.ToString()) : null, "workspaceName" ,container.Add );
            AddIf( null != (((object)this._scalingPlanName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Json.JsonString(this._scalingPlanName.ToString()) : null, "scalingPlanName" ,container.Add );
            AddIf( null != (((object)this._hostPoolName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Json.JsonString(this._hostPoolName.ToString()) : null, "hostPoolName" ,container.Add );
            AddIf( null != (((object)this._applicationGroupName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Json.JsonString(this._applicationGroupName.ToString()) : null, "applicationGroupName" ,container.Add );
            AddIf( null != (((object)this._applicationName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Json.JsonString(this._applicationName.ToString()) : null, "applicationName" ,container.Add );
            AddIf( null != (((object)this._desktopName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Json.JsonString(this._desktopName.ToString()) : null, "desktopName" ,container.Add );
            AddIf( null != (((object)this._sessionHostName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Json.JsonString(this._sessionHostName.ToString()) : null, "sessionHostName" ,container.Add );
            AddIf( null != (((object)this._userSessionId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Json.JsonString(this._userSessionId.ToString()) : null, "userSessionId" ,container.Add );
            AddIf( null != (((object)this._msixPackageFullName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Json.JsonString(this._msixPackageFullName.ToString()) : null, "msixPackageFullName" ,container.Add );
            AddIf( null != (((object)this._id)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Json.JsonString(this._id.ToString()) : null, "id" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}