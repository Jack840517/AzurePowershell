// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20211030Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Runtime.Extensions;

    /// <summary>Integration Runtime Monitoring Data.</summary>
    public partial class IntegrationRuntimeMonitoringData :
        Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20211030Preview.IIntegrationRuntimeMonitoringData,
        Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20211030Preview.IIntegrationRuntimeMonitoringDataInternal
    {

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20211030Preview.IIntegrationRuntimeMonitoringDataInternal.Name { get => this._name; set { {_name = value;} } }

        /// <summary>Internal Acessors for Node</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20211030Preview.INodeMonitoringData[] Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20211030Preview.IIntegrationRuntimeMonitoringDataInternal.Node { get => this._node; set { {_node = value;} } }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>The name of Integration Runtime.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataMigration.PropertyOrigin.Owned)]
        public string Name { get => this._name; }

        /// <summary>Backing field for <see cref="Node" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20211030Preview.INodeMonitoringData[] _node;

        /// <summary>Integration Runtime node monitoring data.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataMigration.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20211030Preview.INodeMonitoringData[] Node { get => this._node; }

        /// <summary>Creates an new <see cref="IntegrationRuntimeMonitoringData" /> instance.</summary>
        public IntegrationRuntimeMonitoringData()
        {

        }
    }
    /// Integration Runtime Monitoring Data.
    public partial interface IIntegrationRuntimeMonitoringData :
        Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Runtime.IJsonSerializable
    {
        /// <summary>The name of Integration Runtime.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The name of Integration Runtime.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get;  }
        /// <summary>Integration Runtime node monitoring data.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Integration Runtime node monitoring data.",
        SerializedName = @"nodes",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20211030Preview.INodeMonitoringData) })]
        Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20211030Preview.INodeMonitoringData[] Node { get;  }

    }
    /// Integration Runtime Monitoring Data.
    internal partial interface IIntegrationRuntimeMonitoringDataInternal

    {
        /// <summary>The name of Integration Runtime.</summary>
        string Name { get; set; }
        /// <summary>Integration Runtime node monitoring data.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20211030Preview.INodeMonitoringData[] Node { get; set; }

    }
}