// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support
{

    /// <summary>Defines secondary layer of software-based encryption enablement.</summary>
    public partial struct DoubleEncryption :
        System.IEquatable<DoubleEncryption>
    {
        /// <summary>Software-based encryption is disabled.</summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.DoubleEncryption Disabled = @"Disabled";

        /// <summary>Software-based encryption is enabled.</summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.DoubleEncryption Enabled = @"Enabled";

        /// <summary>the value for an instance of the <see cref="DoubleEncryption" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to DoubleEncryption</summary>
        /// <param name="value">the value to convert to an instance of <see cref="DoubleEncryption" />.</param>
        internal static object CreateFrom(object value)
        {
            return new DoubleEncryption(global::System.Convert.ToString(value));
        }

        /// <summary>Creates an instance of the <see cref="DoubleEncryption" Enum class./></summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private DoubleEncryption(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Compares values of enum type DoubleEncryption</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.DoubleEncryption e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type DoubleEncryption (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is DoubleEncryption && Equals((DoubleEncryption)obj);
        }

        /// <summary>Returns hashCode for enum DoubleEncryption</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Returns string representation for DoubleEncryption</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to DoubleEncryption</summary>
        /// <param name="value">the value to convert to an instance of <see cref="DoubleEncryption" />.</param>

        public static implicit operator DoubleEncryption(string value)
        {
            return new DoubleEncryption(value);
        }

        /// <summary>Implicit operator to convert DoubleEncryption to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="DoubleEncryption" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.DoubleEncryption e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum DoubleEncryption</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.DoubleEncryption e1, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.DoubleEncryption e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum DoubleEncryption</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.DoubleEncryption e1, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.DoubleEncryption e2)
        {
            return e2.Equals(e1);
        }
    }
}