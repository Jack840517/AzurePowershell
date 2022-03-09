// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Logz.Support
{

    /// <summary>Valid actions for a filtering tag. Exclusion takes priority over inclusion.</summary>
    public partial struct TagAction :
        System.IEquatable<TagAction>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.Logz.Support.TagAction Exclude = @"Exclude";

        public static Microsoft.Azure.PowerShell.Cmdlets.Logz.Support.TagAction Include = @"Include";

        /// <summary>the value for an instance of the <see cref="TagAction" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to TagAction</summary>
        /// <param name="value">the value to convert to an instance of <see cref="TagAction" />.</param>
        internal static object CreateFrom(object value)
        {
            return new TagAction(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type TagAction</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.Logz.Support.TagAction e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type TagAction (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is TagAction && Equals((TagAction)obj);
        }

        /// <summary>Returns hashCode for enum TagAction</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Creates an instance of the <see cref="TagAction" Enum class./></summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private TagAction(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Returns string representation for TagAction</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to TagAction</summary>
        /// <param name="value">the value to convert to an instance of <see cref="TagAction" />.</param>

        public static implicit operator TagAction(string value)
        {
            return new TagAction(value);
        }

        /// <summary>Implicit operator to convert TagAction to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="TagAction" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.Logz.Support.TagAction e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum TagAction</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.Logz.Support.TagAction e1, Microsoft.Azure.PowerShell.Cmdlets.Logz.Support.TagAction e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum TagAction</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.Logz.Support.TagAction e1, Microsoft.Azure.PowerShell.Cmdlets.Logz.Support.TagAction e2)
        {
            return e2.Equals(e1);
        }
    }
}