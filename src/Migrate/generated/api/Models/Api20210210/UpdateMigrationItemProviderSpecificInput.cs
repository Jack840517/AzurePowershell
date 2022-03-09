// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Extensions;

    /// <summary>Update migration item provider specific input.</summary>
    public partial class UpdateMigrationItemProviderSpecificInput :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IUpdateMigrationItemProviderSpecificInput,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IUpdateMigrationItemProviderSpecificInputInternal
    {

        /// <summary>Backing field for <see cref="InstanceType" /> property.</summary>
        private string _instanceType;

        /// <summary>The class type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string InstanceType { get => this._instanceType; set => this._instanceType = value; }

        /// <summary>
        /// Creates an new <see cref="UpdateMigrationItemProviderSpecificInput" /> instance.
        /// </summary>
        public UpdateMigrationItemProviderSpecificInput()
        {

        }
    }
    /// Update migration item provider specific input.
    public partial interface IUpdateMigrationItemProviderSpecificInput :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IJsonSerializable
    {
        /// <summary>The class type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The class type.",
        SerializedName = @"instanceType",
        PossibleTypes = new [] { typeof(string) })]
        string InstanceType { get; set; }

    }
    /// Update migration item provider specific input.
    internal partial interface IUpdateMigrationItemProviderSpecificInputInternal

    {
        /// <summary>The class type.</summary>
        string InstanceType { get; set; }

    }
}