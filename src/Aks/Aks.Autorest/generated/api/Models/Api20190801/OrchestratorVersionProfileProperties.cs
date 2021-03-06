// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20190801
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Extensions;

    /// <summary>The properties of an orchestrator version profile.</summary>
    public partial class OrchestratorVersionProfileProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20190801.IOrchestratorVersionProfileProperties,
        Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20190801.IOrchestratorVersionProfilePropertiesInternal
    {

        /// <summary>Backing field for <see cref="Orchestrator" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20190801.IOrchestratorVersionProfile[] _orchestrator;

        /// <summary>List of orchestrator version profiles.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Aks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Aks.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20190801.IOrchestratorVersionProfile[] Orchestrator { get => this._orchestrator; set => this._orchestrator = value; }

        /// <summary>Creates an new <see cref="OrchestratorVersionProfileProperties" /> instance.</summary>
        public OrchestratorVersionProfileProperties()
        {

        }
    }
    /// The properties of an orchestrator version profile.
    public partial interface IOrchestratorVersionProfileProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.IJsonSerializable
    {
        /// <summary>List of orchestrator version profiles.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"List of orchestrator version profiles.",
        SerializedName = @"orchestrators",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20190801.IOrchestratorVersionProfile) })]
        Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20190801.IOrchestratorVersionProfile[] Orchestrator { get; set; }

    }
    /// The properties of an orchestrator version profile.
    internal partial interface IOrchestratorVersionProfilePropertiesInternal

    {
        /// <summary>List of orchestrator version profiles.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20190801.IOrchestratorVersionProfile[] Orchestrator { get; set; }

    }
}