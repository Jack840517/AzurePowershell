// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support
{

    /// <summary>The fabric location.</summary>
    public partial struct RecoveryPlanActionLocation :
        System.IEquatable<RecoveryPlanActionLocation>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.RecoveryPlanActionLocation Primary = @"Primary";

        public static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.RecoveryPlanActionLocation Recovery = @"Recovery";

        /// <summary>
        /// the value for an instance of the <see cref="RecoveryPlanActionLocation" /> Enum.
        /// </summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to RecoveryPlanActionLocation</summary>
        /// <param name="value">the value to convert to an instance of <see cref="RecoveryPlanActionLocation" />.</param>
        internal static object CreateFrom(object value)
        {
            return new RecoveryPlanActionLocation(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type RecoveryPlanActionLocation</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.RecoveryPlanActionLocation e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type RecoveryPlanActionLocation (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is RecoveryPlanActionLocation && Equals((RecoveryPlanActionLocation)obj);
        }

        /// <summary>Returns hashCode for enum RecoveryPlanActionLocation</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Creates an instance of the <see cref="RecoveryPlanActionLocation" Enum class./></summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private RecoveryPlanActionLocation(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Returns string representation for RecoveryPlanActionLocation</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to RecoveryPlanActionLocation</summary>
        /// <param name="value">the value to convert to an instance of <see cref="RecoveryPlanActionLocation" />.</param>

        public static implicit operator RecoveryPlanActionLocation(string value)
        {
            return new RecoveryPlanActionLocation(value);
        }

        /// <summary>Implicit operator to convert RecoveryPlanActionLocation to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="RecoveryPlanActionLocation" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.RecoveryPlanActionLocation e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum RecoveryPlanActionLocation</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.RecoveryPlanActionLocation e1, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.RecoveryPlanActionLocation e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum RecoveryPlanActionLocation</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.RecoveryPlanActionLocation e1, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.RecoveryPlanActionLocation e2)
        {
            return e2.Equals(e1);
        }
    }
}