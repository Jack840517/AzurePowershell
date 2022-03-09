// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ChangeAnalysis.Support
{

    /// <summary>The change category.</summary>
    public partial struct ChangeCategory :
        System.IEquatable<ChangeCategory>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.ChangeAnalysis.Support.ChangeCategory System = @"System";

        public static Microsoft.Azure.PowerShell.Cmdlets.ChangeAnalysis.Support.ChangeCategory User = @"User";

        /// <summary>the value for an instance of the <see cref="ChangeCategory" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Creates an instance of the <see cref="ChangeCategory" Enum class./></summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private ChangeCategory(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Conversion from arbitrary object to ChangeCategory</summary>
        /// <param name="value">the value to convert to an instance of <see cref="ChangeCategory" />.</param>
        internal static object CreateFrom(object value)
        {
            return new ChangeCategory(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type ChangeCategory</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.ChangeAnalysis.Support.ChangeCategory e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type ChangeCategory (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is ChangeCategory && Equals((ChangeCategory)obj);
        }

        /// <summary>Returns hashCode for enum ChangeCategory</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Returns string representation for ChangeCategory</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to ChangeCategory</summary>
        /// <param name="value">the value to convert to an instance of <see cref="ChangeCategory" />.</param>

        public static implicit operator ChangeCategory(string value)
        {
            return new ChangeCategory(value);
        }

        /// <summary>Implicit operator to convert ChangeCategory to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="ChangeCategory" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.ChangeAnalysis.Support.ChangeCategory e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum ChangeCategory</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.ChangeAnalysis.Support.ChangeCategory e1, Microsoft.Azure.PowerShell.Cmdlets.ChangeAnalysis.Support.ChangeCategory e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum ChangeCategory</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.ChangeAnalysis.Support.ChangeCategory e1, Microsoft.Azure.PowerShell.Cmdlets.ChangeAnalysis.Support.ChangeCategory e2)
        {
            return e2.Equals(e1);
        }
    }
}