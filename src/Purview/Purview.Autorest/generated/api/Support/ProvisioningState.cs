// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Purview.Support
{

    /// <summary>Gets or sets the state of the provisioning.</summary>
    public partial struct ProvisioningState :
        System.IEquatable<ProvisioningState>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.Purview.Support.ProvisioningState Canceled = @"Canceled";

        public static Microsoft.Azure.PowerShell.Cmdlets.Purview.Support.ProvisioningState Creating = @"Creating";

        public static Microsoft.Azure.PowerShell.Cmdlets.Purview.Support.ProvisioningState Deleting = @"Deleting";

        public static Microsoft.Azure.PowerShell.Cmdlets.Purview.Support.ProvisioningState Failed = @"Failed";

        public static Microsoft.Azure.PowerShell.Cmdlets.Purview.Support.ProvisioningState Moving = @"Moving";

        public static Microsoft.Azure.PowerShell.Cmdlets.Purview.Support.ProvisioningState SoftDeleted = @"SoftDeleted";

        public static Microsoft.Azure.PowerShell.Cmdlets.Purview.Support.ProvisioningState SoftDeleting = @"SoftDeleting";

        public static Microsoft.Azure.PowerShell.Cmdlets.Purview.Support.ProvisioningState Succeeded = @"Succeeded";

        public static Microsoft.Azure.PowerShell.Cmdlets.Purview.Support.ProvisioningState Unknown = @"Unknown";

        /// <summary>the value for an instance of the <see cref="ProvisioningState" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to ProvisioningState</summary>
        /// <param name="value">the value to convert to an instance of <see cref="ProvisioningState" />.</param>
        internal static object CreateFrom(object value)
        {
            return new ProvisioningState(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type ProvisioningState</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.Purview.Support.ProvisioningState e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type ProvisioningState (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is ProvisioningState && Equals((ProvisioningState)obj);
        }

        /// <summary>Returns hashCode for enum ProvisioningState</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Creates an instance of the <see cref="ProvisioningState" Enum class./></summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private ProvisioningState(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Returns string representation for ProvisioningState</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to ProvisioningState</summary>
        /// <param name="value">the value to convert to an instance of <see cref="ProvisioningState" />.</param>

        public static implicit operator ProvisioningState(string value)
        {
            return new ProvisioningState(value);
        }

        /// <summary>Implicit operator to convert ProvisioningState to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="ProvisioningState" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.Purview.Support.ProvisioningState e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum ProvisioningState</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.Purview.Support.ProvisioningState e1, Microsoft.Azure.PowerShell.Cmdlets.Purview.Support.ProvisioningState e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum ProvisioningState</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.Purview.Support.ProvisioningState e1, Microsoft.Azure.PowerShell.Cmdlets.Purview.Support.ProvisioningState e2)
        {
            return e2.Equals(e1);
        }
    }
}