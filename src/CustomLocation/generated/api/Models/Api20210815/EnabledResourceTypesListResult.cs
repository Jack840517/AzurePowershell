// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20210815
{
    using static Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Runtime.Extensions;

    /// <summary>List of EnabledResourceTypes definition.</summary>
    public partial class EnabledResourceTypesListResult :
        Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20210815.IEnabledResourceTypesListResult,
        Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20210815.IEnabledResourceTypesListResultInternal
    {

        /// <summary>Internal Acessors for NextLink</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20210815.IEnabledResourceTypesListResultInternal.NextLink { get => this._nextLink; set { {_nextLink = value;} } }

        /// <summary>Internal Acessors for Value</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20210815.IEnabledResourceType[] Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20210815.IEnabledResourceTypesListResultInternal.Value { get => this._value; set { {_value = value;} } }

        /// <summary>Backing field for <see cref="NextLink" /> property.</summary>
        private string _nextLink;

        /// <summary>The URL to use for getting the next set of results.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Origin(Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.PropertyOrigin.Owned)]
        public string NextLink { get => this._nextLink; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20210815.IEnabledResourceType[] _value;

        /// <summary>The list of EnabledResourceTypes available for a customLocation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Origin(Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20210815.IEnabledResourceType[] Value { get => this._value; }

        /// <summary>Creates an new <see cref="EnabledResourceTypesListResult" /> instance.</summary>
        public EnabledResourceTypesListResult()
        {

        }
    }
    /// List of EnabledResourceTypes definition.
    public partial interface IEnabledResourceTypesListResult :
        Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Runtime.IJsonSerializable
    {
        /// <summary>The URL to use for getting the next set of results.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The URL to use for getting the next set of results.",
        SerializedName = @"nextLink",
        PossibleTypes = new [] { typeof(string) })]
        string NextLink { get;  }
        /// <summary>The list of EnabledResourceTypes available for a customLocation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The list of EnabledResourceTypes available for a customLocation.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20210815.IEnabledResourceType) })]
        Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20210815.IEnabledResourceType[] Value { get;  }

    }
    /// List of EnabledResourceTypes definition.
    internal partial interface IEnabledResourceTypesListResultInternal

    {
        /// <summary>The URL to use for getting the next set of results.</summary>
        string NextLink { get; set; }
        /// <summary>The list of EnabledResourceTypes available for a customLocation.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20210815.IEnabledResourceType[] Value { get; set; }

    }
}