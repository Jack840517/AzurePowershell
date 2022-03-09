// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Extensions;

    /// <summary>Body for a user invite request</summary>
    public partial class InviteBody :
        Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.IInviteBody,
        Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.IInviteBodyInternal
    {

        /// <summary>Backing field for <see cref="Text" /> property.</summary>
        private string _text;

        /// <summary>Custom text for the invite email.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.LabServices.PropertyOrigin.Owned)]
        public string Text { get => this._text; set => this._text = value; }

        /// <summary>Creates an new <see cref="InviteBody" /> instance.</summary>
        public InviteBody()
        {

        }
    }
    /// Body for a user invite request
    public partial interface IInviteBody :
        Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.IJsonSerializable
    {
        /// <summary>Custom text for the invite email.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Custom text for the invite email.",
        SerializedName = @"text",
        PossibleTypes = new [] { typeof(string) })]
        string Text { get; set; }

    }
    /// Body for a user invite request
    internal partial interface IInviteBodyInternal

    {
        /// <summary>Custom text for the invite email.</summary>
        string Text { get; set; }

    }
}