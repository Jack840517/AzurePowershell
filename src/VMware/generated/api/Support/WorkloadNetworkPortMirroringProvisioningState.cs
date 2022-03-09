// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.VMware.Support
{

    /// <summary>The provisioning state</summary>
    public partial struct WorkloadNetworkPortMirroringProvisioningState :
        System.IEquatable<WorkloadNetworkPortMirroringProvisioningState>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.WorkloadNetworkPortMirroringProvisioningState Building = @"Building";

        public static Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.WorkloadNetworkPortMirroringProvisioningState Deleting = @"Deleting";

        public static Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.WorkloadNetworkPortMirroringProvisioningState Failed = @"Failed";

        public static Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.WorkloadNetworkPortMirroringProvisioningState Succeeded = @"Succeeded";

        public static Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.WorkloadNetworkPortMirroringProvisioningState Updating = @"Updating";

        /// <summary>
        /// the value for an instance of the <see cref="WorkloadNetworkPortMirroringProvisioningState" /> Enum.
        /// </summary>
        private string _value { get; set; }

        /// <summary>
        /// Conversion from arbitrary object to WorkloadNetworkPortMirroringProvisioningState
        /// </summary>
        /// <param name="value">the value to convert to an instance of <see cref="WorkloadNetworkPortMirroringProvisioningState" />.</param>
        internal static object CreateFrom(object value)
        {
            return new WorkloadNetworkPortMirroringProvisioningState(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type WorkloadNetworkPortMirroringProvisioningState</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.WorkloadNetworkPortMirroringProvisioningState e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>
        /// Compares values of enum type WorkloadNetworkPortMirroringProvisioningState (override for Object)
        /// </summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is WorkloadNetworkPortMirroringProvisioningState && Equals((WorkloadNetworkPortMirroringProvisioningState)obj);
        }

        /// <summary>Returns hashCode for enum WorkloadNetworkPortMirroringProvisioningState</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Returns string representation for WorkloadNetworkPortMirroringProvisioningState</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>
        /// Creates an instance of the <see cref="WorkloadNetworkPortMirroringProvisioningState" Enum class./>
        /// </summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private WorkloadNetworkPortMirroringProvisioningState(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>
        /// Implicit operator to convert string to WorkloadNetworkPortMirroringProvisioningState
        /// </summary>
        /// <param name="value">the value to convert to an instance of <see cref="WorkloadNetworkPortMirroringProvisioningState" />.</param>

        public static implicit operator WorkloadNetworkPortMirroringProvisioningState(string value)
        {
            return new WorkloadNetworkPortMirroringProvisioningState(value);
        }

        /// <summary>
        /// Implicit operator to convert WorkloadNetworkPortMirroringProvisioningState to string
        /// </summary>
        /// <param name="e">the value to convert to an instance of <see cref="WorkloadNetworkPortMirroringProvisioningState" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.WorkloadNetworkPortMirroringProvisioningState e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum WorkloadNetworkPortMirroringProvisioningState</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.WorkloadNetworkPortMirroringProvisioningState e1, Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.WorkloadNetworkPortMirroringProvisioningState e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum WorkloadNetworkPortMirroringProvisioningState</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.WorkloadNetworkPortMirroringProvisioningState e1, Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.WorkloadNetworkPortMirroringProvisioningState e2)
        {
            return e2.Equals(e1);
        }
    }
}