// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.Api20210520
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Extensions;

    /// <summary>The Update Resource model definition.</summary>
    public partial class ResourceUpdate :
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.Api20210520.IResourceUpdate,
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.Api20210520.IResourceUpdateInternal
    {

        /// <summary>Backing field for <see cref="Tag" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.Api20210520.IResourceUpdateTags _tag;

        /// <summary>Resource tags</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Origin(Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.Api20210520.IResourceUpdateTags Tag { get => (this._tag = this._tag ?? new Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.Api20210520.ResourceUpdateTags()); set => this._tag = value; }

        /// <summary>Creates an new <see cref="ResourceUpdate" /> instance.</summary>
        public ResourceUpdate()
        {

        }
    }
    /// The Update Resource model definition.
    public partial interface IResourceUpdate :
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.IJsonSerializable
    {
        /// <summary>Resource tags</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Resource tags",
        SerializedName = @"tags",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.Api20210520.IResourceUpdateTags) })]
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.Api20210520.IResourceUpdateTags Tag { get; set; }

    }
    /// The Update Resource model definition.
    internal partial interface IResourceUpdateInternal

    {
        /// <summary>Resource tags</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.Api20210520.IResourceUpdateTags Tag { get; set; }

    }
}