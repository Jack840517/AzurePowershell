// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501
{
    using static Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Extensions;

    /// <summary>Represents a Configuration.</summary>
    public partial class ConfigurationForBatchUpdate :
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IConfigurationForBatchUpdate,
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IConfigurationForBatchUpdateInternal
    {

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IConfigurationForBatchUpdateProperties Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IConfigurationForBatchUpdateInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.ConfigurationForBatchUpdateProperties()); set { {_property = value;} } }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>Name of the configuration.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IConfigurationForBatchUpdateProperties _property;

        /// <summary>The properties can be updated for a configuration.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IConfigurationForBatchUpdateProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.ConfigurationForBatchUpdateProperties()); set => this._property = value; }

        /// <summary>Source of the configuration.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inlined)]
        public string Source { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IConfigurationForBatchUpdatePropertiesInternal)Property).Source; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IConfigurationForBatchUpdatePropertiesInternal)Property).Source = value ?? null; }

        /// <summary>Value of the configuration.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inlined)]
        public string Value { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IConfigurationForBatchUpdatePropertiesInternal)Property).Value; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IConfigurationForBatchUpdatePropertiesInternal)Property).Value = value ?? null; }

        /// <summary>Creates an new <see cref="ConfigurationForBatchUpdate" /> instance.</summary>
        public ConfigurationForBatchUpdate()
        {

        }
    }
    /// Represents a Configuration.
    public partial interface IConfigurationForBatchUpdate :
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.IJsonSerializable
    {
        /// <summary>Name of the configuration.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Name of the configuration.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }
        /// <summary>Source of the configuration.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Source of the configuration.",
        SerializedName = @"source",
        PossibleTypes = new [] { typeof(string) })]
        string Source { get; set; }
        /// <summary>Value of the configuration.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Value of the configuration.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(string) })]
        string Value { get; set; }

    }
    /// Represents a Configuration.
    internal partial interface IConfigurationForBatchUpdateInternal

    {
        /// <summary>Name of the configuration.</summary>
        string Name { get; set; }
        /// <summary>The properties can be updated for a configuration.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IConfigurationForBatchUpdateProperties Property { get; set; }
        /// <summary>Source of the configuration.</summary>
        string Source { get; set; }
        /// <summary>Value of the configuration.</summary>
        string Value { get; set; }

    }
}