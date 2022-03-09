// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Extensions;

    /// <summary>preAuthorizedApplication</summary>
    public partial class MicrosoftGraphPreAuthorizedApplication :
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphPreAuthorizedApplication,
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphPreAuthorizedApplicationInternal
    {

        /// <summary>Backing field for <see cref="AppId" /> property.</summary>
        private string _appId;

        /// <summary>The unique identifier for the application.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.PropertyOrigin.Owned)]
        public string AppId { get => this._appId; set => this._appId = value; }

        /// <summary>Backing field for <see cref="DelegatedPermissionId" /> property.</summary>
        private string[] _delegatedPermissionId;

        /// <summary>The unique identifier for the oauth2PermissionScopes the application requires.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.PropertyOrigin.Owned)]
        public string[] DelegatedPermissionId { get => this._delegatedPermissionId; set => this._delegatedPermissionId = value; }

        /// <summary>Creates an new <see cref="MicrosoftGraphPreAuthorizedApplication" /> instance.</summary>
        public MicrosoftGraphPreAuthorizedApplication()
        {

        }
    }
    /// preAuthorizedApplication
    public partial interface IMicrosoftGraphPreAuthorizedApplication :
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.IAssociativeArray<global::System.Object>
    {
        /// <summary>The unique identifier for the application.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The unique identifier for the application.",
        SerializedName = @"appId",
        PossibleTypes = new [] { typeof(string) })]
        string AppId { get; set; }
        /// <summary>The unique identifier for the oauth2PermissionScopes the application requires.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The unique identifier for the oauth2PermissionScopes the application requires.",
        SerializedName = @"delegatedPermissionIds",
        PossibleTypes = new [] { typeof(string) })]
        string[] DelegatedPermissionId { get; set; }

    }
    /// preAuthorizedApplication
    internal partial interface IMicrosoftGraphPreAuthorizedApplicationInternal

    {
        /// <summary>The unique identifier for the application.</summary>
        string AppId { get; set; }
        /// <summary>The unique identifier for the oauth2PermissionScopes the application requires.</summary>
        string[] DelegatedPermissionId { get; set; }

    }
}