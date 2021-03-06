// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201
{
    using static Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Extensions;

    public partial class ServerPrivateLinkServiceConnectionStateProperty :
        Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.IServerPrivateLinkServiceConnectionStateProperty,
        Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.IServerPrivateLinkServiceConnectionStatePropertyInternal
    {

        /// <summary>Backing field for <see cref="ActionsRequired" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.PrivateLinkServiceConnectionStateActionsRequire? _actionsRequired;

        /// <summary>The actions required for private link service connection.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Origin(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.PrivateLinkServiceConnectionStateActionsRequire? ActionsRequired { get => this._actionsRequired; }

        /// <summary>Backing field for <see cref="Description" /> property.</summary>
        private string _description;

        /// <summary>The private link service connection description.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Origin(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.PropertyOrigin.Owned)]
        public string Description { get => this._description; set => this._description = value; }

        /// <summary>Internal Acessors for ActionsRequired</summary>
        Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.PrivateLinkServiceConnectionStateActionsRequire? Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.IServerPrivateLinkServiceConnectionStatePropertyInternal.ActionsRequired { get => this._actionsRequired; set { {_actionsRequired = value;} } }

        /// <summary>Backing field for <see cref="Status" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.PrivateLinkServiceConnectionStateStatus _status;

        /// <summary>The private link service connection status.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Origin(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.PrivateLinkServiceConnectionStateStatus Status { get => this._status; set => this._status = value; }

        /// <summary>
        /// Creates an new <see cref="ServerPrivateLinkServiceConnectionStateProperty" /> instance.
        /// </summary>
        public ServerPrivateLinkServiceConnectionStateProperty()
        {

        }
    }
    public partial interface IServerPrivateLinkServiceConnectionStateProperty :
        Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.IJsonSerializable
    {
        /// <summary>The actions required for private link service connection.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The actions required for private link service connection.",
        SerializedName = @"actionsRequired",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.PrivateLinkServiceConnectionStateActionsRequire) })]
        Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.PrivateLinkServiceConnectionStateActionsRequire? ActionsRequired { get;  }
        /// <summary>The private link service connection description.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The private link service connection description.",
        SerializedName = @"description",
        PossibleTypes = new [] { typeof(string) })]
        string Description { get; set; }
        /// <summary>The private link service connection status.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The private link service connection status.",
        SerializedName = @"status",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.PrivateLinkServiceConnectionStateStatus) })]
        Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.PrivateLinkServiceConnectionStateStatus Status { get; set; }

    }
    internal partial interface IServerPrivateLinkServiceConnectionStatePropertyInternal

    {
        /// <summary>The actions required for private link service connection.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.PrivateLinkServiceConnectionStateActionsRequire? ActionsRequired { get; set; }
        /// <summary>The private link service connection description.</summary>
        string Description { get; set; }
        /// <summary>The private link service connection status.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.PrivateLinkServiceConnectionStateStatus Status { get; set; }

    }
}