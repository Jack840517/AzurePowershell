// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Extensions;

    /// <summary>Base tracked resource type for all PATCH updates.</summary>
    public partial class TrackedResourceUpdate :
        Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.ITrackedResourceUpdate,
        Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.ITrackedResourceUpdateInternal
    {

        /// <summary>Backing field for <see cref="Tag" /> property.</summary>
        private string[] _tag;

        /// <summary>Resource tags.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.LabServices.PropertyOrigin.Owned)]
        public string[] Tag { get => this._tag; set => this._tag = value; }

        /// <summary>Creates an new <see cref="TrackedResourceUpdate" /> instance.</summary>
        public TrackedResourceUpdate()
        {

        }
    }
    /// Base tracked resource type for all PATCH updates.
    public partial interface ITrackedResourceUpdate :
        Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.IJsonSerializable
    {
        /// <summary>Resource tags.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Resource tags.",
        SerializedName = @"tags",
        PossibleTypes = new [] { typeof(string) })]
        string[] Tag { get; set; }

    }
    /// Base tracked resource type for all PATCH updates.
    internal partial interface ITrackedResourceUpdateInternal

    {
        /// <summary>Resource tags.</summary>
        string[] Tag { get; set; }

    }
}