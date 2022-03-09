// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20210701
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Extensions;

    /// <summary>Class representing a secret store resource.</summary>
    public partial class SecretStoreResource :
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20210701.ISecretStoreResource,
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20210701.ISecretStoreResourceInternal
    {

        /// <summary>Backing field for <see cref="SecretStoreType" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.SecretStoreType _secretStoreType;

        /// <summary>Gets or sets the type of secret store</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.SecretStoreType SecretStoreType { get => this._secretStoreType; set => this._secretStoreType = value; }

        /// <summary>Backing field for <see cref="Uri" /> property.</summary>
        private string _uri;

        /// <summary>Uri to get to the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Owned)]
        public string Uri { get => this._uri; set => this._uri = value; }

        /// <summary>Creates an new <see cref="SecretStoreResource" /> instance.</summary>
        public SecretStoreResource()
        {

        }
    }
    /// Class representing a secret store resource.
    public partial interface ISecretStoreResource :
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.IJsonSerializable
    {
        /// <summary>Gets or sets the type of secret store</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Gets or sets the type of secret store",
        SerializedName = @"secretStoreType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.SecretStoreType) })]
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.SecretStoreType SecretStoreType { get; set; }
        /// <summary>Uri to get to the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Uri to get to the resource",
        SerializedName = @"uri",
        PossibleTypes = new [] { typeof(string) })]
        string Uri { get; set; }

    }
    /// Class representing a secret store resource.
    internal partial interface ISecretStoreResourceInternal

    {
        /// <summary>Gets or sets the type of secret store</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.SecretStoreType SecretStoreType { get; set; }
        /// <summary>Uri to get to the resource</summary>
        string Uri { get; set; }

    }
}