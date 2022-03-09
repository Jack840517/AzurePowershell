// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.StreamAnalytics.Support
{

    /// <summary>
    /// Valid values are JobStorageAccount and SystemAccount. If set to JobStorageAccount, this requires the user to also specify
    /// jobStorageAccount property. .
    /// </summary>
    public partial struct ContentStoragePolicy :
        System.IEquatable<ContentStoragePolicy>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.StreamAnalytics.Support.ContentStoragePolicy JobStorageAccount = @"JobStorageAccount";

        public static Microsoft.Azure.PowerShell.Cmdlets.StreamAnalytics.Support.ContentStoragePolicy SystemAccount = @"SystemAccount";

        /// <summary>the value for an instance of the <see cref="ContentStoragePolicy" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Creates an instance of the <see cref="ContentStoragePolicy" Enum class./></summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private ContentStoragePolicy(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Conversion from arbitrary object to ContentStoragePolicy</summary>
        /// <param name="value">the value to convert to an instance of <see cref="ContentStoragePolicy" />.</param>
        internal static object CreateFrom(object value)
        {
            return new ContentStoragePolicy(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type ContentStoragePolicy</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.StreamAnalytics.Support.ContentStoragePolicy e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type ContentStoragePolicy (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is ContentStoragePolicy && Equals((ContentStoragePolicy)obj);
        }

        /// <summary>Returns hashCode for enum ContentStoragePolicy</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Returns string representation for ContentStoragePolicy</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to ContentStoragePolicy</summary>
        /// <param name="value">the value to convert to an instance of <see cref="ContentStoragePolicy" />.</param>

        public static implicit operator ContentStoragePolicy(string value)
        {
            return new ContentStoragePolicy(value);
        }

        /// <summary>Implicit operator to convert ContentStoragePolicy to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="ContentStoragePolicy" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.StreamAnalytics.Support.ContentStoragePolicy e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum ContentStoragePolicy</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.StreamAnalytics.Support.ContentStoragePolicy e1, Microsoft.Azure.PowerShell.Cmdlets.StreamAnalytics.Support.ContentStoragePolicy e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum ContentStoragePolicy</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.StreamAnalytics.Support.ContentStoragePolicy e1, Microsoft.Azure.PowerShell.Cmdlets.StreamAnalytics.Support.ContentStoragePolicy e2)
        {
            return e2.Equals(e1);
        }
    }
}