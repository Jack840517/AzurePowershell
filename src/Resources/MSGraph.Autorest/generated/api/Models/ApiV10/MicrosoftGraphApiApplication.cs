// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Extensions;

    /// <summary>apiApplication</summary>
    public partial class MicrosoftGraphApiApplication :
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphApiApplication,
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphApiApplicationInternal
    {

        /// <summary>Backing field for <see cref="AcceptMappedClaim" /> property.</summary>
        private bool? _acceptMappedClaim;

        /// <summary>
        /// When true, allows an application to use claims mapping without specifying a custom signing key.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.PropertyOrigin.Owned)]
        public bool? AcceptMappedClaim { get => this._acceptMappedClaim; set => this._acceptMappedClaim = value; }

        /// <summary>Backing field for <see cref="KnownClientApplication" /> property.</summary>
        private string[] _knownClientApplication;

        /// <summary>
        /// Used for bundling consent if you have a solution that contains two parts: a client app and a custom web API app. If you
        /// set the appID of the client app to this value, the user only consents once to the client app. Azure AD knows that consenting
        /// to the client means implicitly consenting to the web API and automatically provisions service principals for both APIs
        /// at the same time. Both the client and the web API app must be registered in the same tenant.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.PropertyOrigin.Owned)]
        public string[] KnownClientApplication { get => this._knownClientApplication; set => this._knownClientApplication = value; }

        /// <summary>Backing field for <see cref="Oauth2PermissionScope" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphPermissionScope[] _oauth2PermissionScope;

        /// <summary>
        /// The definition of the delegated permissions exposed by the web API represented by this application registration. These
        /// delegated permissions may be requested by a client application, and may be granted by users or administrators during consent.
        /// Delegated permissions are sometimes referred to as OAuth 2.0 scopes.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphPermissionScope[] Oauth2PermissionScope { get => this._oauth2PermissionScope; set => this._oauth2PermissionScope = value; }

        /// <summary>Backing field for <see cref="PreAuthorizedApplication" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphPreAuthorizedApplication[] _preAuthorizedApplication;

        /// <summary>
        /// Lists the client applications that are pre-authorized with the specified delegated permissions to access this application's
        /// APIs. Users are not required to consent to any pre-authorized application (for the permissions specified). However, any
        /// additional permissions not listed in preAuthorizedApplications (requested through incremental consent for example) will
        /// require user consent.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphPreAuthorizedApplication[] PreAuthorizedApplication { get => this._preAuthorizedApplication; set => this._preAuthorizedApplication = value; }

        /// <summary>Backing field for <see cref="RequestedAccessTokenVersion" /> property.</summary>
        private int? _requestedAccessTokenVersion;

        /// <summary>
        /// Specifies the access token version expected by this resource. This changes the version and format of the JWT produced
        /// independent of the endpoint or client used to request the access token. The endpoint used, v1.0 or v2.0, is chosen by
        /// the client and only impacts the version of id_tokens. Resources need to explicitly configure requestedAccessTokenVersion
        /// to indicate the supported access token format. Possible values for requestedAccessTokenVersion are 1, 2, or null. If the
        /// value is null, this defaults to 1, which corresponds to the v1.0 endpoint. If signInAudience on the application is configured
        /// as AzureADandPersonalMicrosoftAccount, the value for this property must be 2
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.PropertyOrigin.Owned)]
        public int? RequestedAccessTokenVersion { get => this._requestedAccessTokenVersion; set => this._requestedAccessTokenVersion = value; }

        /// <summary>Creates an new <see cref="MicrosoftGraphApiApplication" /> instance.</summary>
        public MicrosoftGraphApiApplication()
        {

        }
    }
    /// apiApplication
    public partial interface IMicrosoftGraphApiApplication :
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.IAssociativeArray<global::System.Object>
    {
        /// <summary>
        /// When true, allows an application to use claims mapping without specifying a custom signing key.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"When true, allows an application to use claims mapping without specifying a custom signing key.",
        SerializedName = @"acceptMappedClaims",
        PossibleTypes = new [] { typeof(bool) })]
        bool? AcceptMappedClaim { get; set; }
        /// <summary>
        /// Used for bundling consent if you have a solution that contains two parts: a client app and a custom web API app. If you
        /// set the appID of the client app to this value, the user only consents once to the client app. Azure AD knows that consenting
        /// to the client means implicitly consenting to the web API and automatically provisions service principals for both APIs
        /// at the same time. Both the client and the web API app must be registered in the same tenant.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Used for bundling consent if you have a solution that contains two parts: a client app and a custom web API app. If you set the appID of the client app to this value, the user only consents once to the client app. Azure AD knows that consenting to the client means implicitly consenting to the web API and automatically provisions service principals for both APIs at the same time. Both the client and the web API app must be registered in the same tenant.",
        SerializedName = @"knownClientApplications",
        PossibleTypes = new [] { typeof(string) })]
        string[] KnownClientApplication { get; set; }
        /// <summary>
        /// The definition of the delegated permissions exposed by the web API represented by this application registration. These
        /// delegated permissions may be requested by a client application, and may be granted by users or administrators during consent.
        /// Delegated permissions are sometimes referred to as OAuth 2.0 scopes.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The definition of the delegated permissions exposed by the web API represented by this application registration. These delegated permissions may be requested by a client application, and may be granted by users or administrators during consent. Delegated permissions are sometimes referred to as OAuth 2.0 scopes.",
        SerializedName = @"oauth2PermissionScopes",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphPermissionScope) })]
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphPermissionScope[] Oauth2PermissionScope { get; set; }
        /// <summary>
        /// Lists the client applications that are pre-authorized with the specified delegated permissions to access this application's
        /// APIs. Users are not required to consent to any pre-authorized application (for the permissions specified). However, any
        /// additional permissions not listed in preAuthorizedApplications (requested through incremental consent for example) will
        /// require user consent.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Lists the client applications that are pre-authorized with the specified delegated permissions to access this application's APIs. Users are not required to consent to any pre-authorized application (for the permissions specified). However, any additional permissions not listed in preAuthorizedApplications (requested through incremental consent for example) will require user consent.",
        SerializedName = @"preAuthorizedApplications",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphPreAuthorizedApplication) })]
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphPreAuthorizedApplication[] PreAuthorizedApplication { get; set; }
        /// <summary>
        /// Specifies the access token version expected by this resource. This changes the version and format of the JWT produced
        /// independent of the endpoint or client used to request the access token. The endpoint used, v1.0 or v2.0, is chosen by
        /// the client and only impacts the version of id_tokens. Resources need to explicitly configure requestedAccessTokenVersion
        /// to indicate the supported access token format. Possible values for requestedAccessTokenVersion are 1, 2, or null. If the
        /// value is null, this defaults to 1, which corresponds to the v1.0 endpoint. If signInAudience on the application is configured
        /// as AzureADandPersonalMicrosoftAccount, the value for this property must be 2
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Specifies the access token version expected by this resource. This changes the version and format of the JWT produced independent of the endpoint or client used to request the access token.  The endpoint used, v1.0 or v2.0, is chosen by the client and only impacts the version of id_tokens. Resources need to explicitly configure requestedAccessTokenVersion to indicate the supported access token format.  Possible values for requestedAccessTokenVersion are 1, 2, or null. If the value is null, this defaults to 1, which corresponds to the v1.0 endpoint.  If signInAudience on the application is configured as AzureADandPersonalMicrosoftAccount, the value for this property must be 2",
        SerializedName = @"requestedAccessTokenVersion",
        PossibleTypes = new [] { typeof(int) })]
        int? RequestedAccessTokenVersion { get; set; }

    }
    /// apiApplication
    internal partial interface IMicrosoftGraphApiApplicationInternal

    {
        /// <summary>
        /// When true, allows an application to use claims mapping without specifying a custom signing key.
        /// </summary>
        bool? AcceptMappedClaim { get; set; }
        /// <summary>
        /// Used for bundling consent if you have a solution that contains two parts: a client app and a custom web API app. If you
        /// set the appID of the client app to this value, the user only consents once to the client app. Azure AD knows that consenting
        /// to the client means implicitly consenting to the web API and automatically provisions service principals for both APIs
        /// at the same time. Both the client and the web API app must be registered in the same tenant.
        /// </summary>
        string[] KnownClientApplication { get; set; }
        /// <summary>
        /// The definition of the delegated permissions exposed by the web API represented by this application registration. These
        /// delegated permissions may be requested by a client application, and may be granted by users or administrators during consent.
        /// Delegated permissions are sometimes referred to as OAuth 2.0 scopes.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphPermissionScope[] Oauth2PermissionScope { get; set; }
        /// <summary>
        /// Lists the client applications that are pre-authorized with the specified delegated permissions to access this application's
        /// APIs. Users are not required to consent to any pre-authorized application (for the permissions specified). However, any
        /// additional permissions not listed in preAuthorizedApplications (requested through incremental consent for example) will
        /// require user consent.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphPreAuthorizedApplication[] PreAuthorizedApplication { get; set; }
        /// <summary>
        /// Specifies the access token version expected by this resource. This changes the version and format of the JWT produced
        /// independent of the endpoint or client used to request the access token. The endpoint used, v1.0 or v2.0, is chosen by
        /// the client and only impacts the version of id_tokens. Resources need to explicitly configure requestedAccessTokenVersion
        /// to indicate the supported access token format. Possible values for requestedAccessTokenVersion are 1, 2, or null. If the
        /// value is null, this defaults to 1, which corresponds to the v1.0 endpoint. If signInAudience on the application is configured
        /// as AzureADandPersonalMicrosoftAccount, the value for this property must be 2
        /// </summary>
        int? RequestedAccessTokenVersion { get; set; }

    }
}