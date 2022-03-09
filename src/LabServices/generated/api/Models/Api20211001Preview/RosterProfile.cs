// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Extensions;

    /// <summary>The lab user list management profile.</summary>
    public partial class RosterProfile :
        Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.IRosterProfile,
        Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.IRosterProfileInternal
    {

        /// <summary>Backing field for <see cref="ActiveDirectoryGroupId" /> property.</summary>
        private string _activeDirectoryGroupId;

        /// <summary>
        /// The AAD group ID which this lab roster is populated from. Having this set enables AAD sync mode.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.LabServices.PropertyOrigin.Owned)]
        public string ActiveDirectoryGroupId { get => this._activeDirectoryGroupId; set => this._activeDirectoryGroupId = value; }

        /// <summary>Backing field for <see cref="LmsInstance" /> property.</summary>
        private string _lmsInstance;

        /// <summary>The base URI identifying the lms instance.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.LabServices.PropertyOrigin.Owned)]
        public string LmsInstance { get => this._lmsInstance; set => this._lmsInstance = value; }

        /// <summary>Backing field for <see cref="LtiClientId" /> property.</summary>
        private string _ltiClientId;

        /// <summary>The unique id of the azure lab services tool in the lms.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.LabServices.PropertyOrigin.Owned)]
        public string LtiClientId { get => this._ltiClientId; set => this._ltiClientId = value; }

        /// <summary>Backing field for <see cref="LtiContextId" /> property.</summary>
        private string _ltiContextId;

        /// <summary>The unique context identifier for the lab in the lms.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.LabServices.PropertyOrigin.Owned)]
        public string LtiContextId { get => this._ltiContextId; set => this._ltiContextId = value; }

        /// <summary>Backing field for <see cref="LtiRosterEndpoint" /> property.</summary>
        private string _ltiRosterEndpoint;

        /// <summary>
        /// The uri of the names and roles service endpoint on the lms for the class attached to this lab.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.LabServices.PropertyOrigin.Owned)]
        public string LtiRosterEndpoint { get => this._ltiRosterEndpoint; set => this._ltiRosterEndpoint = value; }

        /// <summary>Creates an new <see cref="RosterProfile" /> instance.</summary>
        public RosterProfile()
        {

        }
    }
    /// The lab user list management profile.
    public partial interface IRosterProfile :
        Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.IJsonSerializable
    {
        /// <summary>
        /// The AAD group ID which this lab roster is populated from. Having this set enables AAD sync mode.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The AAD group ID which this lab roster is populated from. Having this set enables AAD sync mode.",
        SerializedName = @"activeDirectoryGroupId",
        PossibleTypes = new [] { typeof(string) })]
        string ActiveDirectoryGroupId { get; set; }
        /// <summary>The base URI identifying the lms instance.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The base URI identifying the lms instance.",
        SerializedName = @"lmsInstance",
        PossibleTypes = new [] { typeof(string) })]
        string LmsInstance { get; set; }
        /// <summary>The unique id of the azure lab services tool in the lms.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The unique id of the azure lab services tool in the lms.",
        SerializedName = @"ltiClientId",
        PossibleTypes = new [] { typeof(string) })]
        string LtiClientId { get; set; }
        /// <summary>The unique context identifier for the lab in the lms.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The unique context identifier for the lab in the lms.",
        SerializedName = @"ltiContextId",
        PossibleTypes = new [] { typeof(string) })]
        string LtiContextId { get; set; }
        /// <summary>
        /// The uri of the names and roles service endpoint on the lms for the class attached to this lab.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The uri of the names and roles service endpoint on the lms for the class attached to this lab.",
        SerializedName = @"ltiRosterEndpoint",
        PossibleTypes = new [] { typeof(string) })]
        string LtiRosterEndpoint { get; set; }

    }
    /// The lab user list management profile.
    internal partial interface IRosterProfileInternal

    {
        /// <summary>
        /// The AAD group ID which this lab roster is populated from. Having this set enables AAD sync mode.
        /// </summary>
        string ActiveDirectoryGroupId { get; set; }
        /// <summary>The base URI identifying the lms instance.</summary>
        string LmsInstance { get; set; }
        /// <summary>The unique id of the azure lab services tool in the lms.</summary>
        string LtiClientId { get; set; }
        /// <summary>The unique context identifier for the lab in the lms.</summary>
        string LtiContextId { get; set; }
        /// <summary>
        /// The uri of the names and roles service endpoint on the lms for the class attached to this lab.
        /// </summary>
        string LtiRosterEndpoint { get; set; }

    }
}