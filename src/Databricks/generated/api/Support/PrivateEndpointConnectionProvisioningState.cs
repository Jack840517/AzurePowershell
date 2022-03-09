// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support
{

    /// <summary>The current provisioning state.</summary>
    public partial struct PrivateEndpointConnectionProvisioningState :
        System.IEquatable<PrivateEndpointConnectionProvisioningState>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.PrivateEndpointConnectionProvisioningState Creating = @"Creating";

        public static Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.PrivateEndpointConnectionProvisioningState Deleting = @"Deleting";

        public static Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.PrivateEndpointConnectionProvisioningState Failed = @"Failed";

        public static Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.PrivateEndpointConnectionProvisioningState Succeeded = @"Succeeded";

        public static Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.PrivateEndpointConnectionProvisioningState Updating = @"Updating";

        /// <summary>
        /// the value for an instance of the <see cref="PrivateEndpointConnectionProvisioningState" /> Enum.
        /// </summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to PrivateEndpointConnectionProvisioningState</summary>
        /// <param name="value">the value to convert to an instance of <see cref="PrivateEndpointConnectionProvisioningState" />.</param>
        internal static object CreateFrom(object value)
        {
            return new PrivateEndpointConnectionProvisioningState(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type PrivateEndpointConnectionProvisioningState</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.PrivateEndpointConnectionProvisioningState e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>
        /// Compares values of enum type PrivateEndpointConnectionProvisioningState (override for Object)
        /// </summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is PrivateEndpointConnectionProvisioningState && Equals((PrivateEndpointConnectionProvisioningState)obj);
        }

        /// <summary>Returns hashCode for enum PrivateEndpointConnectionProvisioningState</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>
        /// Creates an instance of the <see cref="PrivateEndpointConnectionProvisioningState" Enum class./>
        /// </summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private PrivateEndpointConnectionProvisioningState(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Returns string representation for PrivateEndpointConnectionProvisioningState</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>
        /// Implicit operator to convert string to PrivateEndpointConnectionProvisioningState
        /// </summary>
        /// <param name="value">the value to convert to an instance of <see cref="PrivateEndpointConnectionProvisioningState" />.</param>

        public static implicit operator PrivateEndpointConnectionProvisioningState(string value)
        {
            return new PrivateEndpointConnectionProvisioningState(value);
        }

        /// <summary>
        /// Implicit operator to convert PrivateEndpointConnectionProvisioningState to string
        /// </summary>
        /// <param name="e">the value to convert to an instance of <see cref="PrivateEndpointConnectionProvisioningState" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.PrivateEndpointConnectionProvisioningState e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum PrivateEndpointConnectionProvisioningState</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.PrivateEndpointConnectionProvisioningState e1, Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.PrivateEndpointConnectionProvisioningState e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum PrivateEndpointConnectionProvisioningState</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.PrivateEndpointConnectionProvisioningState e1, Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.PrivateEndpointConnectionProvisioningState e2)
        {
            return e2.Equals(e1);
        }
    }
}