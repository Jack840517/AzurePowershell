// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Extensions;

    /// <summary>vCenter properties.</summary>
    public partial class VCenterPropertiesAutoGenerated :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVCenterPropertiesAutoGenerated,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVCenterPropertiesAutoGeneratedInternal
    {

        /// <summary>Backing field for <see cref="DiscoveryStatus" /> property.</summary>
        private string _discoveryStatus;

        /// <summary>The VCenter discovery status.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string DiscoveryStatus { get => this._discoveryStatus; set => this._discoveryStatus = value; }

        /// <summary>Backing field for <see cref="FabricArmResourceName" /> property.</summary>
        private string _fabricArmResourceName;

        /// <summary>The ARM resource name of the fabric containing this VCenter.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string FabricArmResourceName { get => this._fabricArmResourceName; set => this._fabricArmResourceName = value; }

        /// <summary>Backing field for <see cref="FriendlyName" /> property.</summary>
        private string _friendlyName;

        /// <summary>Friendly name of the vCenter.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string FriendlyName { get => this._friendlyName; set => this._friendlyName = value; }

        /// <summary>Backing field for <see cref="HealthError" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IHealthError[] _healthError;

        /// <summary>The health errors for this VCenter.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IHealthError[] HealthError { get => this._healthError; set => this._healthError = value; }

        /// <summary>Backing field for <see cref="IPAddress" /> property.</summary>
        private string _iPAddress;

        /// <summary>The IP address of the vCenter.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string IPAddress { get => this._iPAddress; set => this._iPAddress = value; }

        /// <summary>Backing field for <see cref="InfrastructureId" /> property.</summary>
        private string _infrastructureId;

        /// <summary>The infrastructure Id of vCenter.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string InfrastructureId { get => this._infrastructureId; set => this._infrastructureId = value; }

        /// <summary>Backing field for <see cref="InternalId" /> property.</summary>
        private string _internalId;

        /// <summary>VCenter internal ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string InternalId { get => this._internalId; set => this._internalId = value; }

        /// <summary>Backing field for <see cref="LastHeartbeat" /> property.</summary>
        private global::System.DateTime? _lastHeartbeat;

        /// <summary>The time when the last heartbeat was received by vCenter.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public global::System.DateTime? LastHeartbeat { get => this._lastHeartbeat; set => this._lastHeartbeat = value; }

        /// <summary>Backing field for <see cref="Port" /> property.</summary>
        private string _port;

        /// <summary>The port number for discovery.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string Port { get => this._port; set => this._port = value; }

        /// <summary>Backing field for <see cref="ProcessServerId" /> property.</summary>
        private string _processServerId;

        /// <summary>The process server Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string ProcessServerId { get => this._processServerId; set => this._processServerId = value; }

        /// <summary>Backing field for <see cref="RunAsAccountId" /> property.</summary>
        private string _runAsAccountId;

        /// <summary>The account Id which has privileges to discover the vCenter.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string RunAsAccountId { get => this._runAsAccountId; set => this._runAsAccountId = value; }

        /// <summary>Creates an new <see cref="VCenterPropertiesAutoGenerated" /> instance.</summary>
        public VCenterPropertiesAutoGenerated()
        {

        }
    }
    /// vCenter properties.
    public partial interface IVCenterPropertiesAutoGenerated :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IJsonSerializable
    {
        /// <summary>The VCenter discovery status.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The VCenter discovery status.",
        SerializedName = @"discoveryStatus",
        PossibleTypes = new [] { typeof(string) })]
        string DiscoveryStatus { get; set; }
        /// <summary>The ARM resource name of the fabric containing this VCenter.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The ARM resource name of the fabric containing this VCenter.",
        SerializedName = @"fabricArmResourceName",
        PossibleTypes = new [] { typeof(string) })]
        string FabricArmResourceName { get; set; }
        /// <summary>Friendly name of the vCenter.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Friendly name of the vCenter.",
        SerializedName = @"friendlyName",
        PossibleTypes = new [] { typeof(string) })]
        string FriendlyName { get; set; }
        /// <summary>The health errors for this VCenter.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The health errors for this VCenter.",
        SerializedName = @"healthErrors",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IHealthError) })]
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IHealthError[] HealthError { get; set; }
        /// <summary>The IP address of the vCenter.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The IP address of the vCenter.",
        SerializedName = @"ipAddress",
        PossibleTypes = new [] { typeof(string) })]
        string IPAddress { get; set; }
        /// <summary>The infrastructure Id of vCenter.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The infrastructure Id of vCenter.",
        SerializedName = @"infrastructureId",
        PossibleTypes = new [] { typeof(string) })]
        string InfrastructureId { get; set; }
        /// <summary>VCenter internal ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"VCenter internal ID.",
        SerializedName = @"internalId",
        PossibleTypes = new [] { typeof(string) })]
        string InternalId { get; set; }
        /// <summary>The time when the last heartbeat was received by vCenter.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The time when the last heartbeat was received by vCenter.",
        SerializedName = @"lastHeartbeat",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? LastHeartbeat { get; set; }
        /// <summary>The port number for discovery.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The port number for discovery.",
        SerializedName = @"port",
        PossibleTypes = new [] { typeof(string) })]
        string Port { get; set; }
        /// <summary>The process server Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The process server Id.",
        SerializedName = @"processServerId",
        PossibleTypes = new [] { typeof(string) })]
        string ProcessServerId { get; set; }
        /// <summary>The account Id which has privileges to discover the vCenter.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The account Id which has privileges to discover the vCenter.",
        SerializedName = @"runAsAccountId",
        PossibleTypes = new [] { typeof(string) })]
        string RunAsAccountId { get; set; }

    }
    /// vCenter properties.
    internal partial interface IVCenterPropertiesAutoGeneratedInternal

    {
        /// <summary>The VCenter discovery status.</summary>
        string DiscoveryStatus { get; set; }
        /// <summary>The ARM resource name of the fabric containing this VCenter.</summary>
        string FabricArmResourceName { get; set; }
        /// <summary>Friendly name of the vCenter.</summary>
        string FriendlyName { get; set; }
        /// <summary>The health errors for this VCenter.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IHealthError[] HealthError { get; set; }
        /// <summary>The IP address of the vCenter.</summary>
        string IPAddress { get; set; }
        /// <summary>The infrastructure Id of vCenter.</summary>
        string InfrastructureId { get; set; }
        /// <summary>VCenter internal ID.</summary>
        string InternalId { get; set; }
        /// <summary>The time when the last heartbeat was received by vCenter.</summary>
        global::System.DateTime? LastHeartbeat { get; set; }
        /// <summary>The port number for discovery.</summary>
        string Port { get; set; }
        /// <summary>The process server Id.</summary>
        string ProcessServerId { get; set; }
        /// <summary>The account Id which has privileges to discover the vCenter.</summary>
        string RunAsAccountId { get; set; }

    }
}