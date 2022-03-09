// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201
{
    using static Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.Extensions;

    /// <summary>A list of NSX Virtual Machines</summary>
    public partial class WorkloadNetworkVirtualMachinesList :
        Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.IWorkloadNetworkVirtualMachinesList,
        Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.IWorkloadNetworkVirtualMachinesListInternal
    {

        /// <summary>Internal Acessors for NextLink</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.IWorkloadNetworkVirtualMachinesListInternal.NextLink { get => this._nextLink; set { {_nextLink = value;} } }

        /// <summary>Internal Acessors for Value</summary>
        Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.IWorkloadNetworkVirtualMachine[] Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.IWorkloadNetworkVirtualMachinesListInternal.Value { get => this._value; set { {_value = value;} } }

        /// <summary>Backing field for <see cref="NextLink" /> property.</summary>
        private string _nextLink;

        /// <summary>URL to get the next page if any</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMware.PropertyOrigin.Owned)]
        public string NextLink { get => this._nextLink; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.IWorkloadNetworkVirtualMachine[] _value;

        /// <summary>The items on the page</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMware.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.IWorkloadNetworkVirtualMachine[] Value { get => this._value; }

        /// <summary>Creates an new <see cref="WorkloadNetworkVirtualMachinesList" /> instance.</summary>
        public WorkloadNetworkVirtualMachinesList()
        {

        }
    }
    /// A list of NSX Virtual Machines
    public partial interface IWorkloadNetworkVirtualMachinesList :
        Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.IJsonSerializable
    {
        /// <summary>URL to get the next page if any</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"URL to get the next page if any",
        SerializedName = @"nextLink",
        PossibleTypes = new [] { typeof(string) })]
        string NextLink { get;  }
        /// <summary>The items on the page</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The items on the page",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.IWorkloadNetworkVirtualMachine) })]
        Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.IWorkloadNetworkVirtualMachine[] Value { get;  }

    }
    /// A list of NSX Virtual Machines
    internal partial interface IWorkloadNetworkVirtualMachinesListInternal

    {
        /// <summary>URL to get the next page if any</summary>
        string NextLink { get; set; }
        /// <summary>The items on the page</summary>
        Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.IWorkloadNetworkVirtualMachine[] Value { get; set; }

    }
}