// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support
{

    /// <summary>State of the private endpoint connection.</summary>
    public partial struct PrivateEndpointProvisioningState :
        System.IEquatable<PrivateEndpointProvisioningState>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.PrivateEndpointProvisioningState Approving = @"Approving";

        public static Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.PrivateEndpointProvisioningState Dropping = @"Dropping";

        public static Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.PrivateEndpointProvisioningState Failed = @"Failed";

        public static Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.PrivateEndpointProvisioningState Ready = @"Ready";

        public static Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.PrivateEndpointProvisioningState Rejecting = @"Rejecting";

        /// <summary>
        /// the value for an instance of the <see cref="PrivateEndpointProvisioningState" /> Enum.
        /// </summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to PrivateEndpointProvisioningState</summary>
        /// <param name="value">the value to convert to an instance of <see cref="PrivateEndpointProvisioningState" />.</param>
        internal static object CreateFrom(object value)
        {
            return new PrivateEndpointProvisioningState(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type PrivateEndpointProvisioningState</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.PrivateEndpointProvisioningState e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>
        /// Compares values of enum type PrivateEndpointProvisioningState (override for Object)
        /// </summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is PrivateEndpointProvisioningState && Equals((PrivateEndpointProvisioningState)obj);
        }

        /// <summary>Returns hashCode for enum PrivateEndpointProvisioningState</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>
        /// Creates an instance of the <see cref="PrivateEndpointProvisioningState" Enum class./>
        /// </summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private PrivateEndpointProvisioningState(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Returns string representation for PrivateEndpointProvisioningState</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to PrivateEndpointProvisioningState</summary>
        /// <param name="value">the value to convert to an instance of <see cref="PrivateEndpointProvisioningState" />.</param>

        public static implicit operator PrivateEndpointProvisioningState(string value)
        {
            return new PrivateEndpointProvisioningState(value);
        }

        /// <summary>Implicit operator to convert PrivateEndpointProvisioningState to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="PrivateEndpointProvisioningState" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.PrivateEndpointProvisioningState e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum PrivateEndpointProvisioningState</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.PrivateEndpointProvisioningState e1, Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.PrivateEndpointProvisioningState e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum PrivateEndpointProvisioningState</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.PrivateEndpointProvisioningState e1, Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.PrivateEndpointProvisioningState e2)
        {
            return e2.Equals(e1);
        }
    }
}