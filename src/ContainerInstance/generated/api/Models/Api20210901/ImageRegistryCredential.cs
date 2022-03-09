// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210901
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Runtime.Extensions;

    /// <summary>Image registry credential.</summary>
    public partial class ImageRegistryCredential :
        Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210901.IImageRegistryCredential,
        Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210901.IImageRegistryCredentialInternal
    {

        /// <summary>Backing field for <see cref="Identity" /> property.</summary>
        private string _identity;

        /// <summary>The identity for the private registry.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.PropertyOrigin.Owned)]
        public string Identity { get => this._identity; set => this._identity = value; }

        /// <summary>Backing field for <see cref="IdentityUrl" /> property.</summary>
        private string _identityUrl;

        /// <summary>The identity URL for the private registry.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.PropertyOrigin.Owned)]
        public string IdentityUrl { get => this._identityUrl; set => this._identityUrl = value; }

        /// <summary>Backing field for <see cref="Password" /> property.</summary>
        private string _password;

        /// <summary>The password for the private registry.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.PropertyOrigin.Owned)]
        public string Password { get => this._password; set => this._password = value; }

        /// <summary>Backing field for <see cref="Server" /> property.</summary>
        private string _server;

        /// <summary>The Docker image registry server without a protocol such as "http" and "https".</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.PropertyOrigin.Owned)]
        public string Server { get => this._server; set => this._server = value; }

        /// <summary>Backing field for <see cref="Username" /> property.</summary>
        private string _username;

        /// <summary>The username for the private registry.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.PropertyOrigin.Owned)]
        public string Username { get => this._username; set => this._username = value; }

        /// <summary>Creates an new <see cref="ImageRegistryCredential" /> instance.</summary>
        public ImageRegistryCredential()
        {

        }
    }
    /// Image registry credential.
    public partial interface IImageRegistryCredential :
        Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Runtime.IJsonSerializable
    {
        /// <summary>The identity for the private registry.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The identity for the private registry.",
        SerializedName = @"identity",
        PossibleTypes = new [] { typeof(string) })]
        string Identity { get; set; }
        /// <summary>The identity URL for the private registry.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The identity URL for the private registry.",
        SerializedName = @"identityUrl",
        PossibleTypes = new [] { typeof(string) })]
        string IdentityUrl { get; set; }
        /// <summary>The password for the private registry.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The password for the private registry.",
        SerializedName = @"password",
        PossibleTypes = new [] { typeof(string) })]
        string Password { get; set; }
        /// <summary>The Docker image registry server without a protocol such as "http" and "https".</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The Docker image registry server without a protocol such as ""http"" and ""https"".",
        SerializedName = @"server",
        PossibleTypes = new [] { typeof(string) })]
        string Server { get; set; }
        /// <summary>The username for the private registry.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The username for the private registry.",
        SerializedName = @"username",
        PossibleTypes = new [] { typeof(string) })]
        string Username { get; set; }

    }
    /// Image registry credential.
    internal partial interface IImageRegistryCredentialInternal

    {
        /// <summary>The identity for the private registry.</summary>
        string Identity { get; set; }
        /// <summary>The identity URL for the private registry.</summary>
        string IdentityUrl { get; set; }
        /// <summary>The password for the private registry.</summary>
        string Password { get; set; }
        /// <summary>The Docker image registry server without a protocol such as "http" and "https".</summary>
        string Server { get; set; }
        /// <summary>The username for the private registry.</summary>
        string Username { get; set; }

    }
}