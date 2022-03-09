// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.StreamAnalytics.Support
{

    /// <summary>
    /// Specifies the encoding of the incoming data in the case of input and the encoding of outgoing data in the case of output.
    /// </summary>
    public partial struct Encoding :
        System.IEquatable<Encoding>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.StreamAnalytics.Support.Encoding Utf8 = @"UTF8";

        /// <summary>the value for an instance of the <see cref="Encoding" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to Encoding</summary>
        /// <param name="value">the value to convert to an instance of <see cref="Encoding" />.</param>
        internal static object CreateFrom(object value)
        {
            return new Encoding(global::System.Convert.ToString(value));
        }

        /// <summary>Creates an instance of the <see cref="Encoding" Enum class./></summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private Encoding(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Compares values of enum type Encoding</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.StreamAnalytics.Support.Encoding e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type Encoding (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is Encoding && Equals((Encoding)obj);
        }

        /// <summary>Returns hashCode for enum Encoding</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Returns string representation for Encoding</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to Encoding</summary>
        /// <param name="value">the value to convert to an instance of <see cref="Encoding" />.</param>

        public static implicit operator Encoding(string value)
        {
            return new Encoding(value);
        }

        /// <summary>Implicit operator to convert Encoding to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="Encoding" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.StreamAnalytics.Support.Encoding e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum Encoding</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.StreamAnalytics.Support.Encoding e1, Microsoft.Azure.PowerShell.Cmdlets.StreamAnalytics.Support.Encoding e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum Encoding</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.StreamAnalytics.Support.Encoding e1, Microsoft.Azure.PowerShell.Cmdlets.StreamAnalytics.Support.Encoding e2)
        {
            return e2.Equals(e1);
        }
    }
}