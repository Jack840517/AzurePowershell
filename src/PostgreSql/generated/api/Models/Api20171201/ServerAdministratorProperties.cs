// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201
{
    using static Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Extensions;

    /// <summary>The properties of an server Administrator.</summary>
    public partial class ServerAdministratorProperties :
        Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.IServerAdministratorProperties,
        Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.IServerAdministratorPropertiesInternal
    {

        /// <summary>Backing field for <see cref="AdministratorType" /> property.</summary>
        private string _administratorType= @"ActiveDirectory";

        /// <summary>The type of administrator.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Origin(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.PropertyOrigin.Owned)]
        public string AdministratorType { get => this._administratorType; }

        /// <summary>Backing field for <see cref="Login" /> property.</summary>
        private string _login;

        /// <summary>The server administrator login account name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Origin(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.PropertyOrigin.Owned)]
        public string Login { get => this._login; set => this._login = value; }

        /// <summary>Internal Acessors for AdministratorType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.IServerAdministratorPropertiesInternal.AdministratorType { get => this._administratorType; set { {_administratorType = value;} } }

        /// <summary>Backing field for <see cref="Sid" /> property.</summary>
        private string _sid;

        /// <summary>The server administrator Sid (Secure ID).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Origin(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.PropertyOrigin.Owned)]
        public string Sid { get => this._sid; set => this._sid = value; }

        /// <summary>Backing field for <see cref="TenantId" /> property.</summary>
        private string _tenantId;

        /// <summary>The server Active Directory Administrator tenant id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Origin(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.PropertyOrigin.Owned)]
        public string TenantId { get => this._tenantId; set => this._tenantId = value; }

        /// <summary>Creates an new <see cref="ServerAdministratorProperties" /> instance.</summary>
        public ServerAdministratorProperties()
        {

        }
    }
    /// The properties of an server Administrator.
    public partial interface IServerAdministratorProperties :
        Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.IJsonSerializable
    {
        /// <summary>The type of administrator.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Info(
        Required = true,
        ReadOnly = true,
        Description = @"The type of administrator.",
        SerializedName = @"administratorType",
        PossibleTypes = new [] { typeof(string) })]
        string AdministratorType { get;  }
        /// <summary>The server administrator login account name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The server administrator login account name.",
        SerializedName = @"login",
        PossibleTypes = new [] { typeof(string) })]
        string Login { get; set; }
        /// <summary>The server administrator Sid (Secure ID).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The server administrator Sid (Secure ID).",
        SerializedName = @"sid",
        PossibleTypes = new [] { typeof(string) })]
        string Sid { get; set; }
        /// <summary>The server Active Directory Administrator tenant id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The server Active Directory Administrator tenant id.",
        SerializedName = @"tenantId",
        PossibleTypes = new [] { typeof(string) })]
        string TenantId { get; set; }

    }
    /// The properties of an server Administrator.
    internal partial interface IServerAdministratorPropertiesInternal

    {
        /// <summary>The type of administrator.</summary>
        string AdministratorType { get; set; }
        /// <summary>The server administrator login account name.</summary>
        string Login { get; set; }
        /// <summary>The server administrator Sid (Secure ID).</summary>
        string Sid { get; set; }
        /// <summary>The server Active Directory Administrator tenant id.</summary>
        string TenantId { get; set; }

    }
}