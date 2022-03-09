// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210901
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Runtime.Extensions;

    /// <summary>The container group list response that contains the container group properties.</summary>
    public partial class ContainerGroupListResult :
        Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210901.IContainerGroupListResult,
        Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210901.IContainerGroupListResultInternal
    {

        /// <summary>Backing field for <see cref="NextLink" /> property.</summary>
        private string _nextLink;

        /// <summary>The URI to fetch the next page of container groups.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.PropertyOrigin.Owned)]
        public string NextLink { get => this._nextLink; set => this._nextLink = value; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210901.IContainerGroup[] _value;

        /// <summary>The list of container groups.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210901.IContainerGroup[] Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="ContainerGroupListResult" /> instance.</summary>
        public ContainerGroupListResult()
        {

        }
    }
    /// The container group list response that contains the container group properties.
    public partial interface IContainerGroupListResult :
        Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Runtime.IJsonSerializable
    {
        /// <summary>The URI to fetch the next page of container groups.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The URI to fetch the next page of container groups.",
        SerializedName = @"nextLink",
        PossibleTypes = new [] { typeof(string) })]
        string NextLink { get; set; }
        /// <summary>The list of container groups.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The list of container groups.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210901.IContainerGroup) })]
        Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210901.IContainerGroup[] Value { get; set; }

    }
    /// The container group list response that contains the container group properties.
    internal partial interface IContainerGroupListResultInternal

    {
        /// <summary>The URI to fetch the next page of container groups.</summary>
        string NextLink { get; set; }
        /// <summary>The list of container groups.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210901.IContainerGroup[] Value { get; set; }

    }
}