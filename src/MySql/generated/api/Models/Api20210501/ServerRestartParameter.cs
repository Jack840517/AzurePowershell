// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501
{
    using static Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Extensions;

    /// <summary>Server restart parameters.</summary>
    public partial class ServerRestartParameter :
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerRestartParameter,
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerRestartParameterInternal
    {

        /// <summary>Backing field for <see cref="MaxFailoverSecond" /> property.</summary>
        private int? _maxFailoverSecond;

        /// <summary>The maximum allowed failover time in seconds.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Owned)]
        public int? MaxFailoverSecond { get => this._maxFailoverSecond; set => this._maxFailoverSecond = value; }

        /// <summary>Backing field for <see cref="RestartWithFailover" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.MySql.Support.EnableStatusEnum? _restartWithFailover;

        /// <summary>
        /// Whether or not failover to standby server when restarting a server with high availability enabled.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.MySql.Support.EnableStatusEnum? RestartWithFailover { get => this._restartWithFailover; set => this._restartWithFailover = value; }

        /// <summary>Creates an new <see cref="ServerRestartParameter" /> instance.</summary>
        public ServerRestartParameter()
        {

        }
    }
    /// Server restart parameters.
    public partial interface IServerRestartParameter :
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.IJsonSerializable
    {
        /// <summary>The maximum allowed failover time in seconds.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The maximum allowed failover time in seconds.",
        SerializedName = @"maxFailoverSeconds",
        PossibleTypes = new [] { typeof(int) })]
        int? MaxFailoverSecond { get; set; }
        /// <summary>
        /// Whether or not failover to standby server when restarting a server with high availability enabled.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Whether or not failover to standby server when restarting a server with high availability enabled.",
        SerializedName = @"restartWithFailover",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.MySql.Support.EnableStatusEnum) })]
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Support.EnableStatusEnum? RestartWithFailover { get; set; }

    }
    /// Server restart parameters.
    internal partial interface IServerRestartParameterInternal

    {
        /// <summary>The maximum allowed failover time in seconds.</summary>
        int? MaxFailoverSecond { get; set; }
        /// <summary>
        /// Whether or not failover to standby server when restarting a server with high availability enabled.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Support.EnableStatusEnum? RestartWithFailover { get; set; }

    }
}