// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601
{
    using static Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Extensions;

    /// <summary>Represents a resource name availability.</summary>
    public partial class NameAvailabilityAutoGenerated :
        Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.INameAvailabilityAutoGenerated,
        Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.INameAvailabilityAutoGeneratedInternal
    {

        /// <summary>Backing field for <see cref="Message" /> property.</summary>
        private string _message;

        /// <summary>Error Message.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Origin(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.PropertyOrigin.Owned)]
        public string Message { get => this._message; set => this._message = value; }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>name of the PostgreSQL server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Origin(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Backing field for <see cref="NameAvailable" /> property.</summary>
        private bool? _nameAvailable;

        /// <summary>Indicates whether the resource name is available.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Origin(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.PropertyOrigin.Owned)]
        public bool? NameAvailable { get => this._nameAvailable; set => this._nameAvailable = value; }

        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private string _type;

        /// <summary>type of the server</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Origin(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.PropertyOrigin.Owned)]
        public string Type { get => this._type; set => this._type = value; }

        /// <summary>Creates an new <see cref="NameAvailabilityAutoGenerated" /> instance.</summary>
        public NameAvailabilityAutoGenerated()
        {

        }
    }
    /// Represents a resource name availability.
    public partial interface INameAvailabilityAutoGenerated :
        Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.IJsonSerializable
    {
        /// <summary>Error Message.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Error Message.",
        SerializedName = @"message",
        PossibleTypes = new [] { typeof(string) })]
        string Message { get; set; }
        /// <summary>name of the PostgreSQL server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"name of the PostgreSQL server.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }
        /// <summary>Indicates whether the resource name is available.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Indicates whether the resource name is available.",
        SerializedName = @"nameAvailable",
        PossibleTypes = new [] { typeof(bool) })]
        bool? NameAvailable { get; set; }
        /// <summary>type of the server</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"type of the server",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        string Type { get; set; }

    }
    /// Represents a resource name availability.
    internal partial interface INameAvailabilityAutoGeneratedInternal

    {
        /// <summary>Error Message.</summary>
        string Message { get; set; }
        /// <summary>name of the PostgreSQL server.</summary>
        string Name { get; set; }
        /// <summary>Indicates whether the resource name is available.</summary>
        bool? NameAvailable { get; set; }
        /// <summary>type of the server</summary>
        string Type { get; set; }

    }
}