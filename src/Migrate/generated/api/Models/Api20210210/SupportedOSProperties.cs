// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Extensions;

    /// <summary>Supported operating systems properties.</summary>
    public partial class SupportedOSProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ISupportedOSProperties,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ISupportedOSPropertiesInternal
    {

        /// <summary>Backing field for <see cref="SupportedOSList" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ISupportedOSProperty[] _supportedOSList;

        /// <summary>The supported operating systems property list.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ISupportedOSProperty[] SupportedOSList { get => this._supportedOSList; set => this._supportedOSList = value; }

        /// <summary>Creates an new <see cref="SupportedOSProperties" /> instance.</summary>
        public SupportedOSProperties()
        {

        }
    }
    /// Supported operating systems properties.
    public partial interface ISupportedOSProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IJsonSerializable
    {
        /// <summary>The supported operating systems property list.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The supported operating systems property list.",
        SerializedName = @"supportedOsList",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ISupportedOSProperty) })]
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ISupportedOSProperty[] SupportedOSList { get; set; }

    }
    /// Supported operating systems properties.
    internal partial interface ISupportedOSPropertiesInternal

    {
        /// <summary>The supported operating systems property list.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ISupportedOSProperty[] SupportedOSList { get; set; }

    }
}