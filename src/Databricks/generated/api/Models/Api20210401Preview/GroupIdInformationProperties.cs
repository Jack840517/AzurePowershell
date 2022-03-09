// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.Extensions;

    /// <summary>The properties for a group information object</summary>
    public partial class GroupIdInformationProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IGroupIdInformationProperties,
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IGroupIdInformationPropertiesInternal
    {

        /// <summary>Backing field for <see cref="GroupId" /> property.</summary>
        private string _groupId;

        /// <summary>The group id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Databricks.PropertyOrigin.Owned)]
        public string GroupId { get => this._groupId; set => this._groupId = value; }

        /// <summary>Backing field for <see cref="RequiredMember" /> property.</summary>
        private string[] _requiredMember;

        /// <summary>The required members for a specific group id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Databricks.PropertyOrigin.Owned)]
        public string[] RequiredMember { get => this._requiredMember; set => this._requiredMember = value; }

        /// <summary>Backing field for <see cref="RequiredZoneName" /> property.</summary>
        private string[] _requiredZoneName;

        /// <summary>The required DNS zones for a specific group id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Databricks.PropertyOrigin.Owned)]
        public string[] RequiredZoneName { get => this._requiredZoneName; set => this._requiredZoneName = value; }

        /// <summary>Creates an new <see cref="GroupIdInformationProperties" /> instance.</summary>
        public GroupIdInformationProperties()
        {

        }
    }
    /// The properties for a group information object
    public partial interface IGroupIdInformationProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.IJsonSerializable
    {
        /// <summary>The group id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The group id",
        SerializedName = @"groupId",
        PossibleTypes = new [] { typeof(string) })]
        string GroupId { get; set; }
        /// <summary>The required members for a specific group id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The required members for a specific group id",
        SerializedName = @"requiredMembers",
        PossibleTypes = new [] { typeof(string) })]
        string[] RequiredMember { get; set; }
        /// <summary>The required DNS zones for a specific group id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The required DNS zones for a specific group id",
        SerializedName = @"requiredZoneNames",
        PossibleTypes = new [] { typeof(string) })]
        string[] RequiredZoneName { get; set; }

    }
    /// The properties for a group information object
    internal partial interface IGroupIdInformationPropertiesInternal

    {
        /// <summary>The group id</summary>
        string GroupId { get; set; }
        /// <summary>The required members for a specific group id</summary>
        string[] RequiredMember { get; set; }
        /// <summary>The required DNS zones for a specific group id</summary>
        string[] RequiredZoneName { get; set; }

    }
}