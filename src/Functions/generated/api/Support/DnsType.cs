// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Functions.Support
{

    /// <summary>Current DNS type</summary>
    public partial struct DnsType :
        System.IEquatable<DnsType>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.DnsType AzureDns = @"AzureDns";

        public static Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.DnsType DefaultDomainRegistrarDns = @"DefaultDomainRegistrarDns";

        /// <summary>the value for an instance of the <see cref="DnsType" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to DnsType</summary>
        /// <param name="value">the value to convert to an instance of <see cref="DnsType" />.</param>
        internal static object CreateFrom(object value)
        {
            return new DnsType(global::System.Convert.ToString(value));
        }

        /// <summary>Creates an instance of the <see cref="DnsType" Enum class./></summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private DnsType(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Compares values of enum type DnsType</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.DnsType e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type DnsType (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is DnsType && Equals((DnsType)obj);
        }

        /// <summary>Returns hashCode for enum DnsType</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Returns string representation for DnsType</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to DnsType</summary>
        /// <param name="value">the value to convert to an instance of <see cref="DnsType" />.</param>

        public static implicit operator DnsType(string value)
        {
            return new DnsType(value);
        }

        /// <summary>Implicit operator to convert DnsType to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="DnsType" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.DnsType e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum DnsType</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.DnsType e1, Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.DnsType e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum DnsType</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.DnsType e1, Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.DnsType e2)
        {
            return e2.Equals(e1);
        }
    }
}