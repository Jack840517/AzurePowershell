// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support
{

    /// <summary>The health.</summary>
    public partial struct ProtectionHealth :
        System.IEquatable<ProtectionHealth>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.ProtectionHealth Critical = @"Critical";

        public static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.ProtectionHealth None = @"None";

        public static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.ProtectionHealth Normal = @"Normal";

        public static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.ProtectionHealth Warning = @"Warning";

        /// <summary>the value for an instance of the <see cref="ProtectionHealth" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to ProtectionHealth</summary>
        /// <param name="value">the value to convert to an instance of <see cref="ProtectionHealth" />.</param>
        internal static object CreateFrom(object value)
        {
            return new ProtectionHealth(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type ProtectionHealth</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.ProtectionHealth e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type ProtectionHealth (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is ProtectionHealth && Equals((ProtectionHealth)obj);
        }

        /// <summary>Returns hashCode for enum ProtectionHealth</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Creates an instance of the <see cref="ProtectionHealth" Enum class./></summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private ProtectionHealth(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Returns string representation for ProtectionHealth</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to ProtectionHealth</summary>
        /// <param name="value">the value to convert to an instance of <see cref="ProtectionHealth" />.</param>

        public static implicit operator ProtectionHealth(string value)
        {
            return new ProtectionHealth(value);
        }

        /// <summary>Implicit operator to convert ProtectionHealth to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="ProtectionHealth" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.ProtectionHealth e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum ProtectionHealth</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.ProtectionHealth e1, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.ProtectionHealth e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum ProtectionHealth</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.ProtectionHealth e1, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.ProtectionHealth e2)
        {
            return e2.Equals(e1);
        }
    }
}