// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.VMware.Support
{

    /// <summary>The state of the ExpressRoute Circuit Authorization provisioning</summary>
    public partial struct ExpressRouteAuthorizationProvisioningState :
        System.IEquatable<ExpressRouteAuthorizationProvisioningState>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.ExpressRouteAuthorizationProvisioningState Failed = @"Failed";

        public static Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.ExpressRouteAuthorizationProvisioningState Succeeded = @"Succeeded";

        public static Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.ExpressRouteAuthorizationProvisioningState Updating = @"Updating";

        /// <summary>
        /// the value for an instance of the <see cref="ExpressRouteAuthorizationProvisioningState" /> Enum.
        /// </summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to ExpressRouteAuthorizationProvisioningState</summary>
        /// <param name="value">the value to convert to an instance of <see cref="ExpressRouteAuthorizationProvisioningState" />.</param>
        internal static object CreateFrom(object value)
        {
            return new ExpressRouteAuthorizationProvisioningState(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type ExpressRouteAuthorizationProvisioningState</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.ExpressRouteAuthorizationProvisioningState e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>
        /// Compares values of enum type ExpressRouteAuthorizationProvisioningState (override for Object)
        /// </summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is ExpressRouteAuthorizationProvisioningState && Equals((ExpressRouteAuthorizationProvisioningState)obj);
        }

        /// <summary>
        /// Creates an instance of the <see cref="ExpressRouteAuthorizationProvisioningState" Enum class./>
        /// </summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private ExpressRouteAuthorizationProvisioningState(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Returns hashCode for enum ExpressRouteAuthorizationProvisioningState</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Returns string representation for ExpressRouteAuthorizationProvisioningState</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>
        /// Implicit operator to convert string to ExpressRouteAuthorizationProvisioningState
        /// </summary>
        /// <param name="value">the value to convert to an instance of <see cref="ExpressRouteAuthorizationProvisioningState" />.</param>

        public static implicit operator ExpressRouteAuthorizationProvisioningState(string value)
        {
            return new ExpressRouteAuthorizationProvisioningState(value);
        }

        /// <summary>
        /// Implicit operator to convert ExpressRouteAuthorizationProvisioningState to string
        /// </summary>
        /// <param name="e">the value to convert to an instance of <see cref="ExpressRouteAuthorizationProvisioningState" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.ExpressRouteAuthorizationProvisioningState e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum ExpressRouteAuthorizationProvisioningState</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.ExpressRouteAuthorizationProvisioningState e1, Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.ExpressRouteAuthorizationProvisioningState e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum ExpressRouteAuthorizationProvisioningState</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.ExpressRouteAuthorizationProvisioningState e1, Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.ExpressRouteAuthorizationProvisioningState e2)
        {
            return e2.Equals(e1);
        }
    }
}