// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201
{
    using static Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.Extensions;

    /// <summary>Virtual Machine Properties</summary>
    public partial class VirtualMachineProperties :
        Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.IVirtualMachineProperties,
        Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.IVirtualMachinePropertiesInternal
    {

        /// <summary>Backing field for <see cref="DisplayName" /> property.</summary>
        private string _displayName;

        /// <summary>Display name of the VM.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMware.PropertyOrigin.Owned)]
        public string DisplayName { get => this._displayName; }

        /// <summary>Backing field for <see cref="FolderPath" /> property.</summary>
        private string _folderPath;

        /// <summary>
        /// Path to virtual machine's folder starting from datacenter virtual machine folder
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMware.PropertyOrigin.Owned)]
        public string FolderPath { get => this._folderPath; }

        /// <summary>Internal Acessors for DisplayName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.IVirtualMachinePropertiesInternal.DisplayName { get => this._displayName; set { {_displayName = value;} } }

        /// <summary>Internal Acessors for FolderPath</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.IVirtualMachinePropertiesInternal.FolderPath { get => this._folderPath; set { {_folderPath = value;} } }

        /// <summary>Internal Acessors for MoRefId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.IVirtualMachinePropertiesInternal.MoRefId { get => this._moRefId; set { {_moRefId = value;} } }

        /// <summary>Internal Acessors for RestrictMovement</summary>
        Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.VirtualMachineRestrictMovementState? Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.IVirtualMachinePropertiesInternal.RestrictMovement { get => this._restrictMovement; set { {_restrictMovement = value;} } }

        /// <summary>Backing field for <see cref="MoRefId" /> property.</summary>
        private string _moRefId;

        /// <summary>Virtual machine managed object reference id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMware.PropertyOrigin.Owned)]
        public string MoRefId { get => this._moRefId; }

        /// <summary>Backing field for <see cref="RestrictMovement" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.VirtualMachineRestrictMovementState? _restrictMovement;

        /// <summary>Whether VM DRS-driven movement is restricted (enabled) or not (disabled)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMware.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.VirtualMachineRestrictMovementState? RestrictMovement { get => this._restrictMovement; }

        /// <summary>Creates an new <see cref="VirtualMachineProperties" /> instance.</summary>
        public VirtualMachineProperties()
        {

        }
    }
    /// Virtual Machine Properties
    public partial interface IVirtualMachineProperties :
        Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.IJsonSerializable
    {
        /// <summary>Display name of the VM.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Display name of the VM.",
        SerializedName = @"displayName",
        PossibleTypes = new [] { typeof(string) })]
        string DisplayName { get;  }
        /// <summary>
        /// Path to virtual machine's folder starting from datacenter virtual machine folder
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Path to virtual machine's folder starting from datacenter virtual machine folder",
        SerializedName = @"folderPath",
        PossibleTypes = new [] { typeof(string) })]
        string FolderPath { get;  }
        /// <summary>Virtual machine managed object reference id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Virtual machine managed object reference id",
        SerializedName = @"moRefId",
        PossibleTypes = new [] { typeof(string) })]
        string MoRefId { get;  }
        /// <summary>Whether VM DRS-driven movement is restricted (enabled) or not (disabled)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Whether VM DRS-driven movement is restricted (enabled) or not (disabled)",
        SerializedName = @"restrictMovement",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.VirtualMachineRestrictMovementState) })]
        Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.VirtualMachineRestrictMovementState? RestrictMovement { get;  }

    }
    /// Virtual Machine Properties
    internal partial interface IVirtualMachinePropertiesInternal

    {
        /// <summary>Display name of the VM.</summary>
        string DisplayName { get; set; }
        /// <summary>
        /// Path to virtual machine's folder starting from datacenter virtual machine folder
        /// </summary>
        string FolderPath { get; set; }
        /// <summary>Virtual machine managed object reference id</summary>
        string MoRefId { get; set; }
        /// <summary>Whether VM DRS-driven movement is restricted (enabled) or not (disabled)</summary>
        Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.VirtualMachineRestrictMovementState? RestrictMovement { get; set; }

    }
}