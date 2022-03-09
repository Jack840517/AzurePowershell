// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210801
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Runtime.Extensions;

    /// <summary>Response properties for iSCSI Target operations.</summary>
    public partial class IscsiTargetProperties :
        Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210801.IIscsiTargetProperties,
        Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210801.IIscsiTargetPropertiesInternal
    {

        /// <summary>Backing field for <see cref="AclMode" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Support.IscsiTargetAclMode _aclMode;

        /// <summary>Mode for Target connectivity.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Origin(Microsoft.Azure.PowerShell.Cmdlets.DiskPool.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Support.IscsiTargetAclMode AclMode { get => this._aclMode; set => this._aclMode = value; }

        /// <summary>Backing field for <see cref="Endpoint" /> property.</summary>
        private string[] _endpoint;

        /// <summary>List of private IPv4 addresses to connect to the iSCSI Target.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Origin(Microsoft.Azure.PowerShell.Cmdlets.DiskPool.PropertyOrigin.Owned)]
        public string[] Endpoint { get => this._endpoint; set => this._endpoint = value; }

        /// <summary>Backing field for <see cref="Lun" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210801.IIscsiLun[] _lun;

        /// <summary>List of LUNs to be exposed through iSCSI Target.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Origin(Microsoft.Azure.PowerShell.Cmdlets.DiskPool.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210801.IIscsiLun[] Lun { get => this._lun; set => this._lun = value; }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Support.ProvisioningStates Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210801.IIscsiTargetPropertiesInternal.ProvisioningState { get => this._provisioningState; set { {_provisioningState = value;} } }

        /// <summary>Internal Acessors for Session</summary>
        string[] Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210801.IIscsiTargetPropertiesInternal.Session { get => this._session; set { {_session = value;} } }

        /// <summary>Backing field for <see cref="Port" /> property.</summary>
        private int? _port;

        /// <summary>The port used by iSCSI Target portal group.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Origin(Microsoft.Azure.PowerShell.Cmdlets.DiskPool.PropertyOrigin.Owned)]
        public int? Port { get => this._port; set => this._port = value; }

        /// <summary>Backing field for <see cref="ProvisioningState" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Support.ProvisioningStates _provisioningState;

        /// <summary>State of the operation on the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Origin(Microsoft.Azure.PowerShell.Cmdlets.DiskPool.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Support.ProvisioningStates ProvisioningState { get => this._provisioningState; }

        /// <summary>Backing field for <see cref="Session" /> property.</summary>
        private string[] _session;

        /// <summary>List of identifiers for active sessions on the iSCSI target</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Origin(Microsoft.Azure.PowerShell.Cmdlets.DiskPool.PropertyOrigin.Owned)]
        public string[] Session { get => this._session; }

        /// <summary>Backing field for <see cref="StaticAcls" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210801.IAcl[] _staticAcls;

        /// <summary>Access Control List (ACL) for an iSCSI Target; defines LUN masking policy</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Origin(Microsoft.Azure.PowerShell.Cmdlets.DiskPool.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210801.IAcl[] StaticAcls { get => this._staticAcls; set => this._staticAcls = value; }

        /// <summary>Backing field for <see cref="Status" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Support.OperationalStatus _status;

        /// <summary>Operational status of the iSCSI Target.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Origin(Microsoft.Azure.PowerShell.Cmdlets.DiskPool.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Support.OperationalStatus Status { get => this._status; set => this._status = value; }

        /// <summary>Backing field for <see cref="TargetIqn" /> property.</summary>
        private string _targetIqn;

        /// <summary>
        /// iSCSI Target IQN (iSCSI Qualified Name); example: "iqn.2005-03.org.iscsi:server".
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Origin(Microsoft.Azure.PowerShell.Cmdlets.DiskPool.PropertyOrigin.Owned)]
        public string TargetIqn { get => this._targetIqn; set => this._targetIqn = value; }

        /// <summary>Creates an new <see cref="IscsiTargetProperties" /> instance.</summary>
        public IscsiTargetProperties()
        {

        }
    }
    /// Response properties for iSCSI Target operations.
    public partial interface IIscsiTargetProperties :
        Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Runtime.IJsonSerializable
    {
        /// <summary>Mode for Target connectivity.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Mode for Target connectivity.",
        SerializedName = @"aclMode",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Support.IscsiTargetAclMode) })]
        Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Support.IscsiTargetAclMode AclMode { get; set; }
        /// <summary>List of private IPv4 addresses to connect to the iSCSI Target.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"List of private IPv4 addresses to connect to the iSCSI Target.",
        SerializedName = @"endpoints",
        PossibleTypes = new [] { typeof(string) })]
        string[] Endpoint { get; set; }
        /// <summary>List of LUNs to be exposed through iSCSI Target.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"List of LUNs to be exposed through iSCSI Target.",
        SerializedName = @"luns",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210801.IIscsiLun) })]
        Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210801.IIscsiLun[] Lun { get; set; }
        /// <summary>The port used by iSCSI Target portal group.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The port used by iSCSI Target portal group.",
        SerializedName = @"port",
        PossibleTypes = new [] { typeof(int) })]
        int? Port { get; set; }
        /// <summary>State of the operation on the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Runtime.Info(
        Required = true,
        ReadOnly = true,
        Description = @"State of the operation on the resource.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Support.ProvisioningStates) })]
        Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Support.ProvisioningStates ProvisioningState { get;  }
        /// <summary>List of identifiers for active sessions on the iSCSI target</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"List of identifiers for active sessions on the iSCSI target",
        SerializedName = @"sessions",
        PossibleTypes = new [] { typeof(string) })]
        string[] Session { get;  }
        /// <summary>Access Control List (ACL) for an iSCSI Target; defines LUN masking policy</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Access Control List (ACL) for an iSCSI Target; defines LUN masking policy",
        SerializedName = @"staticAcls",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210801.IAcl) })]
        Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210801.IAcl[] StaticAcls { get; set; }
        /// <summary>Operational status of the iSCSI Target.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Operational status of the iSCSI Target.",
        SerializedName = @"status",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Support.OperationalStatus) })]
        Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Support.OperationalStatus Status { get; set; }
        /// <summary>
        /// iSCSI Target IQN (iSCSI Qualified Name); example: "iqn.2005-03.org.iscsi:server".
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"iSCSI Target IQN (iSCSI Qualified Name); example: ""iqn.2005-03.org.iscsi:server"".",
        SerializedName = @"targetIqn",
        PossibleTypes = new [] { typeof(string) })]
        string TargetIqn { get; set; }

    }
    /// Response properties for iSCSI Target operations.
    internal partial interface IIscsiTargetPropertiesInternal

    {
        /// <summary>Mode for Target connectivity.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Support.IscsiTargetAclMode AclMode { get; set; }
        /// <summary>List of private IPv4 addresses to connect to the iSCSI Target.</summary>
        string[] Endpoint { get; set; }
        /// <summary>List of LUNs to be exposed through iSCSI Target.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210801.IIscsiLun[] Lun { get; set; }
        /// <summary>The port used by iSCSI Target portal group.</summary>
        int? Port { get; set; }
        /// <summary>State of the operation on the resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Support.ProvisioningStates ProvisioningState { get; set; }
        /// <summary>List of identifiers for active sessions on the iSCSI target</summary>
        string[] Session { get; set; }
        /// <summary>Access Control List (ACL) for an iSCSI Target; defines LUN masking policy</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210801.IAcl[] StaticAcls { get; set; }
        /// <summary>Operational status of the iSCSI Target.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Support.OperationalStatus Status { get; set; }
        /// <summary>
        /// iSCSI Target IQN (iSCSI Qualified Name); example: "iqn.2005-03.org.iscsi:server".
        /// </summary>
        string TargetIqn { get; set; }

    }
}