// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301
{
    using static Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Extensions;

    /// <summary>Contains the DDoS protection settings of the public IP.</summary>
    public partial class DdosSettings :
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IDdosSettings,
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IDdosSettingsInternal
    {

        /// <summary>Backing field for <see cref="DdosCustomPolicy" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.ISubResourceAutoGenerated _ddosCustomPolicy;

        /// <summary>The DDoS custom policy associated with the public IP.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.ISubResourceAutoGenerated DdosCustomPolicy { get => (this._ddosCustomPolicy = this._ddosCustomPolicy ?? new Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.SubResourceAutoGenerated()); set => this._ddosCustomPolicy = value; }

        /// <summary>Resource ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Inlined)]
        public string DdosCustomPolicyId { get => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.ISubResourceAutoGeneratedInternal)DdosCustomPolicy).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.ISubResourceAutoGeneratedInternal)DdosCustomPolicy).Id = value ?? null; }

        /// <summary>Internal Acessors for DdosCustomPolicy</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.ISubResourceAutoGenerated Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IDdosSettingsInternal.DdosCustomPolicy { get => (this._ddosCustomPolicy = this._ddosCustomPolicy ?? new Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.SubResourceAutoGenerated()); set { {_ddosCustomPolicy = value;} } }

        /// <summary>Backing field for <see cref="ProtectedIP" /> property.</summary>
        private bool? _protectedIP;

        /// <summary>Enables DDoS protection on the public IP.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Owned)]
        public bool? ProtectedIP { get => this._protectedIP; set => this._protectedIP = value; }

        /// <summary>Backing field for <see cref="ProtectionCoverage" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.DdosSettingsProtectionCoverage? _protectionCoverage;

        /// <summary>
        /// The DDoS protection policy customizability of the public IP. Only standard coverage will have the ability to be customized.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.DdosSettingsProtectionCoverage? ProtectionCoverage { get => this._protectionCoverage; set => this._protectionCoverage = value; }

        /// <summary>Creates an new <see cref="DdosSettings" /> instance.</summary>
        public DdosSettings()
        {

        }
    }
    /// Contains the DDoS protection settings of the public IP.
    public partial interface IDdosSettings :
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.IJsonSerializable
    {
        /// <summary>Resource ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Resource ID.",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string DdosCustomPolicyId { get; set; }
        /// <summary>Enables DDoS protection on the public IP.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Enables DDoS protection on the public IP.",
        SerializedName = @"protectedIP",
        PossibleTypes = new [] { typeof(bool) })]
        bool? ProtectedIP { get; set; }
        /// <summary>
        /// The DDoS protection policy customizability of the public IP. Only standard coverage will have the ability to be customized.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The DDoS protection policy customizability of the public IP. Only standard coverage will have the ability to be customized.",
        SerializedName = @"protectionCoverage",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.DdosSettingsProtectionCoverage) })]
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.DdosSettingsProtectionCoverage? ProtectionCoverage { get; set; }

    }
    /// Contains the DDoS protection settings of the public IP.
    internal partial interface IDdosSettingsInternal

    {
        /// <summary>The DDoS custom policy associated with the public IP.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.ISubResourceAutoGenerated DdosCustomPolicy { get; set; }
        /// <summary>Resource ID.</summary>
        string DdosCustomPolicyId { get; set; }
        /// <summary>Enables DDoS protection on the public IP.</summary>
        bool? ProtectedIP { get; set; }
        /// <summary>
        /// The DDoS protection policy customizability of the public IP. Only standard coverage will have the ability to be customized.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.DdosSettingsProtectionCoverage? ProtectionCoverage { get; set; }

    }
}