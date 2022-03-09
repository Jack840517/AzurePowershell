// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501
{
    using static Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Extensions;

    /// <summary>Location capabilities.</summary>
    public partial class CapabilityProperties :
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.ICapabilityProperties,
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.ICapabilityPropertiesInternal
    {

        /// <summary>Internal Acessors for SupportedFlexibleServerEdition</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerEditionCapability[] Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.ICapabilityPropertiesInternal.SupportedFlexibleServerEdition { get => this._supportedFlexibleServerEdition; set { {_supportedFlexibleServerEdition = value;} } }

        /// <summary>Internal Acessors for SupportedGeoBackupRegion</summary>
        string[] Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.ICapabilityPropertiesInternal.SupportedGeoBackupRegion { get => this._supportedGeoBackupRegion; set { {_supportedGeoBackupRegion = value;} } }

        /// <summary>Internal Acessors for SupportedHaMode</summary>
        string[] Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.ICapabilityPropertiesInternal.SupportedHaMode { get => this._supportedHaMode; set { {_supportedHaMode = value;} } }

        /// <summary>Internal Acessors for Zone</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.ICapabilityPropertiesInternal.Zone { get => this._zone; set { {_zone = value;} } }

        /// <summary>Backing field for <see cref="SupportedFlexibleServerEdition" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerEditionCapability[] _supportedFlexibleServerEdition;

        /// <summary>A list of supported flexible server editions.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerEditionCapability[] SupportedFlexibleServerEdition { get => this._supportedFlexibleServerEdition; }

        /// <summary>Backing field for <see cref="SupportedGeoBackupRegion" /> property.</summary>
        private string[] _supportedGeoBackupRegion;

        /// <summary>supported geo backup regions</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Owned)]
        public string[] SupportedGeoBackupRegion { get => this._supportedGeoBackupRegion; }

        /// <summary>Backing field for <see cref="SupportedHaMode" /> property.</summary>
        private string[] _supportedHaMode;

        /// <summary>Supported high availability mode</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Owned)]
        public string[] SupportedHaMode { get => this._supportedHaMode; }

        /// <summary>Backing field for <see cref="Zone" /> property.</summary>
        private string _zone;

        /// <summary>zone name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Owned)]
        public string Zone { get => this._zone; }

        /// <summary>Creates an new <see cref="CapabilityProperties" /> instance.</summary>
        public CapabilityProperties()
        {

        }
    }
    /// Location capabilities.
    public partial interface ICapabilityProperties :
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.IJsonSerializable
    {
        /// <summary>A list of supported flexible server editions.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"A list of supported flexible server editions.",
        SerializedName = @"supportedFlexibleServerEditions",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerEditionCapability) })]
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerEditionCapability[] SupportedFlexibleServerEdition { get;  }
        /// <summary>supported geo backup regions</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"supported geo backup regions",
        SerializedName = @"supportedGeoBackupRegions",
        PossibleTypes = new [] { typeof(string) })]
        string[] SupportedGeoBackupRegion { get;  }
        /// <summary>Supported high availability mode</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Supported high availability mode",
        SerializedName = @"supportedHAMode",
        PossibleTypes = new [] { typeof(string) })]
        string[] SupportedHaMode { get;  }
        /// <summary>zone name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"zone name",
        SerializedName = @"zone",
        PossibleTypes = new [] { typeof(string) })]
        string Zone { get;  }

    }
    /// Location capabilities.
    internal partial interface ICapabilityPropertiesInternal

    {
        /// <summary>A list of supported flexible server editions.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerEditionCapability[] SupportedFlexibleServerEdition { get; set; }
        /// <summary>supported geo backup regions</summary>
        string[] SupportedGeoBackupRegion { get; set; }
        /// <summary>Supported high availability mode</summary>
        string[] SupportedHaMode { get; set; }
        /// <summary>zone name</summary>
        string Zone { get; set; }

    }
}