// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support
{

    /// <summary>Type of encryption key used for key encryption.</summary>
    public partial struct KekType :
        System.IEquatable<KekType>
    {
        /// <summary>Key encryption key is managed by the Customer.</summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.KekType CustomerManaged = @"CustomerManaged";

        /// <summary>Key encryption key is managed by Microsoft.</summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.KekType MicrosoftManaged = @"MicrosoftManaged";

        /// <summary>the value for an instance of the <see cref="KekType" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to KekType</summary>
        /// <param name="value">the value to convert to an instance of <see cref="KekType" />.</param>
        internal static object CreateFrom(object value)
        {
            return new KekType(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type KekType</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.KekType e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type KekType (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is KekType && Equals((KekType)obj);
        }

        /// <summary>Returns hashCode for enum KekType</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Creates an instance of the <see cref="KekType" Enum class./></summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private KekType(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Returns string representation for KekType</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to KekType</summary>
        /// <param name="value">the value to convert to an instance of <see cref="KekType" />.</param>

        public static implicit operator KekType(string value)
        {
            return new KekType(value);
        }

        /// <summary>Implicit operator to convert KekType to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="KekType" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.KekType e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum KekType</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.KekType e1, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.KekType e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum KekType</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.KekType e1, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.KekType e2)
        {
            return e2.Equals(e1);
        }
    }
}