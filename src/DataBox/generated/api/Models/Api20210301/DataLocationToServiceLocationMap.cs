// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Extensions;

    /// <summary>Map of data location to service location</summary>
    public partial class DataLocationToServiceLocationMap :
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IDataLocationToServiceLocationMap,
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IDataLocationToServiceLocationMapInternal
    {

        /// <summary>Backing field for <see cref="DataLocation" /> property.</summary>
        private string _dataLocation;

        /// <summary>Location of the data.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public string DataLocation { get => this._dataLocation; }

        /// <summary>Internal Acessors for DataLocation</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IDataLocationToServiceLocationMapInternal.DataLocation { get => this._dataLocation; set { {_dataLocation = value;} } }

        /// <summary>Internal Acessors for ServiceLocation</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IDataLocationToServiceLocationMapInternal.ServiceLocation { get => this._serviceLocation; set { {_serviceLocation = value;} } }

        /// <summary>Backing field for <see cref="ServiceLocation" /> property.</summary>
        private string _serviceLocation;

        /// <summary>Location of the service.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public string ServiceLocation { get => this._serviceLocation; }

        /// <summary>Creates an new <see cref="DataLocationToServiceLocationMap" /> instance.</summary>
        public DataLocationToServiceLocationMap()
        {

        }
    }
    /// Map of data location to service location
    public partial interface IDataLocationToServiceLocationMap :
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.IJsonSerializable
    {
        /// <summary>Location of the data.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Location of the data.",
        SerializedName = @"dataLocation",
        PossibleTypes = new [] { typeof(string) })]
        string DataLocation { get;  }
        /// <summary>Location of the service.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Location of the service.",
        SerializedName = @"serviceLocation",
        PossibleTypes = new [] { typeof(string) })]
        string ServiceLocation { get;  }

    }
    /// Map of data location to service location
    internal partial interface IDataLocationToServiceLocationMapInternal

    {
        /// <summary>Location of the data.</summary>
        string DataLocation { get; set; }
        /// <summary>Location of the service.</summary>
        string ServiceLocation { get; set; }

    }
}