// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Maps.Support
{

    /// <summary>Whether the operation refers to the primary or secondary key.</summary>
    public partial struct KeyType :
        System.IEquatable<KeyType>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.Maps.Support.KeyType Primary = @"primary";

        public static Microsoft.Azure.PowerShell.Cmdlets.Maps.Support.KeyType Secondary = @"secondary";

        /// <summary>the value for an instance of the <see cref="KeyType" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to KeyType</summary>
        /// <param name="value">the value to convert to an instance of <see cref="KeyType" />.</param>
        internal static object CreateFrom(object value)
        {
            return new KeyType(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type KeyType</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.Maps.Support.KeyType e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type KeyType (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is KeyType && Equals((KeyType)obj);
        }

        /// <summary>Returns hashCode for enum KeyType</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Creates an instance of the <see cref="KeyType" Enum class./></summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private KeyType(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Returns string representation for KeyType</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to KeyType</summary>
        /// <param name="value">the value to convert to an instance of <see cref="KeyType" />.</param>

        public static implicit operator KeyType(string value)
        {
            return new KeyType(value);
        }

        /// <summary>Implicit operator to convert KeyType to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="KeyType" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.Maps.Support.KeyType e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum KeyType</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.Maps.Support.KeyType e1, Microsoft.Azure.PowerShell.Cmdlets.Maps.Support.KeyType e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum KeyType</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.Maps.Support.KeyType e1, Microsoft.Azure.PowerShell.Cmdlets.Maps.Support.KeyType e2)
        {
            return e2.Equals(e1);
        }
    }
}