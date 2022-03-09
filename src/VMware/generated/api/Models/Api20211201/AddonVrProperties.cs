// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201
{
    using static Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.Extensions;

    /// <summary>The properties of a vSphere Replication (VR) addon</summary>
    public partial class AddonVrProperties :
        Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.IAddonVrProperties,
        Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.IAddonVrPropertiesInternal,
        Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.IAddonProperties"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.IAddonProperties __addonProperties = new Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.AddonProperties();

        /// <summary>The type of private cloud addon</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMware.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.AddonType AddonType { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.IAddonPropertiesInternal)__addonProperties).AddonType; set => ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.IAddonPropertiesInternal)__addonProperties).AddonType = value ; }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.AddonProvisioningState? Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.IAddonPropertiesInternal.ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.IAddonPropertiesInternal)__addonProperties).ProvisioningState; set => ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.IAddonPropertiesInternal)__addonProperties).ProvisioningState = value; }

        /// <summary>The state of the addon provisioning</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMware.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.AddonProvisioningState? ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.IAddonPropertiesInternal)__addonProperties).ProvisioningState; }

        /// <summary>Backing field for <see cref="VrsCount" /> property.</summary>
        private int _vrsCount;

        /// <summary>The vSphere Replication Server (VRS) count</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMware.PropertyOrigin.Owned)]
        public int VrsCount { get => this._vrsCount; set => this._vrsCount = value; }

        /// <summary>Creates an new <see cref="AddonVrProperties" /> instance.</summary>
        public AddonVrProperties()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A < see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__addonProperties), __addonProperties);
            await eventListener.AssertObjectIsValid(nameof(__addonProperties), __addonProperties);
        }
    }
    /// The properties of a vSphere Replication (VR) addon
    public partial interface IAddonVrProperties :
        Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.IAddonProperties
    {
        /// <summary>The vSphere Replication Server (VRS) count</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The vSphere Replication Server (VRS) count",
        SerializedName = @"vrsCount",
        PossibleTypes = new [] { typeof(int) })]
        int VrsCount { get; set; }

    }
    /// The properties of a vSphere Replication (VR) addon
    internal partial interface IAddonVrPropertiesInternal :
        Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.IAddonPropertiesInternal
    {
        /// <summary>The vSphere Replication Server (VRS) count</summary>
        int VrsCount { get; set; }

    }
}