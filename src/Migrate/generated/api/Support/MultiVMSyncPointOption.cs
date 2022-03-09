// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support
{

    /// <summary>
    /// A value indicating whether multi VM sync enabled VMs should use multi VM sync points for failover.
    /// </summary>
    public partial struct MultiVMSyncPointOption :
        System.IEquatable<MultiVMSyncPointOption>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.MultiVMSyncPointOption UseMultiVMSyncRecoveryPoint = @"UseMultiVmSyncRecoveryPoint";

        public static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.MultiVMSyncPointOption UsePerVMRecoveryPoint = @"UsePerVmRecoveryPoint";

        /// <summary>the value for an instance of the <see cref="MultiVMSyncPointOption" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to MultiVMSyncPointOption</summary>
        /// <param name="value">the value to convert to an instance of <see cref="MultiVMSyncPointOption" />.</param>
        internal static object CreateFrom(object value)
        {
            return new MultiVMSyncPointOption(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type MultiVMSyncPointOption</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.MultiVMSyncPointOption e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type MultiVMSyncPointOption (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is MultiVMSyncPointOption && Equals((MultiVMSyncPointOption)obj);
        }

        /// <summary>Returns hashCode for enum MultiVMSyncPointOption</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Creates an instance of the <see cref="MultiVMSyncPointOption" Enum class./></summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private MultiVMSyncPointOption(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Returns string representation for MultiVMSyncPointOption</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to MultiVMSyncPointOption</summary>
        /// <param name="value">the value to convert to an instance of <see cref="MultiVMSyncPointOption" />.</param>

        public static implicit operator MultiVMSyncPointOption(string value)
        {
            return new MultiVMSyncPointOption(value);
        }

        /// <summary>Implicit operator to convert MultiVMSyncPointOption to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="MultiVMSyncPointOption" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.MultiVMSyncPointOption e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum MultiVMSyncPointOption</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.MultiVMSyncPointOption e1, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.MultiVMSyncPointOption e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum MultiVMSyncPointOption</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.MultiVMSyncPointOption e1, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.MultiVMSyncPointOption e2)
        {
            return e2.Equals(e1);
        }
    }
}