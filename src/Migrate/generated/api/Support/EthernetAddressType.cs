// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support
{

    /// <summary>The source IP address type.</summary>
    public partial struct EthernetAddressType :
        System.IEquatable<EthernetAddressType>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.EthernetAddressType Dynamic = @"Dynamic";

        public static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.EthernetAddressType Static = @"Static";

        /// <summary>the value for an instance of the <see cref="EthernetAddressType" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to EthernetAddressType</summary>
        /// <param name="value">the value to convert to an instance of <see cref="EthernetAddressType" />.</param>
        internal static object CreateFrom(object value)
        {
            return new EthernetAddressType(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type EthernetAddressType</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.EthernetAddressType e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type EthernetAddressType (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is EthernetAddressType && Equals((EthernetAddressType)obj);
        }

        /// <summary>Creates an instance of the <see cref="EthernetAddressType" Enum class./></summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private EthernetAddressType(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Returns hashCode for enum EthernetAddressType</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Returns string representation for EthernetAddressType</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to EthernetAddressType</summary>
        /// <param name="value">the value to convert to an instance of <see cref="EthernetAddressType" />.</param>

        public static implicit operator EthernetAddressType(string value)
        {
            return new EthernetAddressType(value);
        }

        /// <summary>Implicit operator to convert EthernetAddressType to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="EthernetAddressType" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.EthernetAddressType e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum EthernetAddressType</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.EthernetAddressType e1, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.EthernetAddressType e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum EthernetAddressType</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.EthernetAddressType e1, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.EthernetAddressType e2)
        {
            return e2.Equals(e1);
        }
    }
}