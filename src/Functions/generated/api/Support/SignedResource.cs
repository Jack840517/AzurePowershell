// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Functions.Support
{

    /// <summary>
    /// The signed services accessible with the service SAS. Possible values include: Blob (b), Container (c), File (f), Share
    /// (s).
    /// </summary>
    public partial struct SignedResource :
        System.IEquatable<SignedResource>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.SignedResource B = @"b";

        public static Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.SignedResource C = @"c";

        public static Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.SignedResource F = @"f";

        public static Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.SignedResource S = @"s";

        /// <summary>the value for an instance of the <see cref="SignedResource" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to SignedResource</summary>
        /// <param name="value">the value to convert to an instance of <see cref="SignedResource" />.</param>
        internal static object CreateFrom(object value)
        {
            return new SignedResource(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type SignedResource</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.SignedResource e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type SignedResource (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is SignedResource && Equals((SignedResource)obj);
        }

        /// <summary>Returns hashCode for enum SignedResource</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Creates an instance of the <see cref="SignedResource" Enum class./></summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private SignedResource(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Returns string representation for SignedResource</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to SignedResource</summary>
        /// <param name="value">the value to convert to an instance of <see cref="SignedResource" />.</param>

        public static implicit operator SignedResource(string value)
        {
            return new SignedResource(value);
        }

        /// <summary>Implicit operator to convert SignedResource to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="SignedResource" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.SignedResource e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum SignedResource</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.SignedResource e1, Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.SignedResource e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum SignedResource</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.SignedResource e1, Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.SignedResource e2)
        {
            return e2.Equals(e1);
        }
    }
}