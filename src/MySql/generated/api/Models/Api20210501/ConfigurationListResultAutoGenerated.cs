// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501
{
    using static Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Extensions;

    /// <summary>A list of server configurations.</summary>
    public partial class ConfigurationListResultAutoGenerated :
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IConfigurationListResultAutoGenerated,
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IConfigurationListResultAutoGeneratedInternal
    {

        /// <summary>Backing field for <see cref="NextLink" /> property.</summary>
        private string _nextLink;

        /// <summary>The link used to get the next page of operations.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Owned)]
        public string NextLink { get => this._nextLink; set => this._nextLink = value; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IConfigurationAutoGenerated[] _value;

        /// <summary>The list of server configurations.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IConfigurationAutoGenerated[] Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="ConfigurationListResultAutoGenerated" /> instance.</summary>
        public ConfigurationListResultAutoGenerated()
        {

        }
    }
    /// A list of server configurations.
    public partial interface IConfigurationListResultAutoGenerated :
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.IJsonSerializable
    {
        /// <summary>The link used to get the next page of operations.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The link used to get the next page of operations.",
        SerializedName = @"nextLink",
        PossibleTypes = new [] { typeof(string) })]
        string NextLink { get; set; }
        /// <summary>The list of server configurations.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The list of server configurations.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IConfigurationAutoGenerated) })]
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IConfigurationAutoGenerated[] Value { get; set; }

    }
    /// A list of server configurations.
    internal partial interface IConfigurationListResultAutoGeneratedInternal

    {
        /// <summary>The link used to get the next page of operations.</summary>
        string NextLink { get; set; }
        /// <summary>The list of server configurations.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IConfigurationAutoGenerated[] Value { get; set; }

    }
}