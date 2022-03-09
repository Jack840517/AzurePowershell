// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Support
{

    /// <summary>Type of link</summary>
    public partial struct LinkType :
        System.IEquatable<LinkType>
    {
        /// <summary>Link to product documentation</summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Support.LinkType Documentation = @"Documentation";

        /// <summary>Generic link.</summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Support.LinkType Generic = @"Generic";

        /// <summary>Link to know more</summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Support.LinkType KnowMore = @"KnowMore";

        /// <summary>Link to sign up for products</summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Support.LinkType SignUp = @"SignUp";

        /// <summary>Link to product specification.</summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Support.LinkType Specification = @"Specification";

        /// <summary>Terms and conditions link.</summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Support.LinkType TermsAndConditions = @"TermsAndConditions";

        /// <summary>the value for an instance of the <see cref="LinkType" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to LinkType</summary>
        /// <param name="value">the value to convert to an instance of <see cref="LinkType" />.</param>
        internal static object CreateFrom(object value)
        {
            return new LinkType(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type LinkType</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Support.LinkType e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type LinkType (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is LinkType && Equals((LinkType)obj);
        }

        /// <summary>Returns hashCode for enum LinkType</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Creates an instance of the <see cref="LinkType" Enum class./></summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private LinkType(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Returns string representation for LinkType</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to LinkType</summary>
        /// <param name="value">the value to convert to an instance of <see cref="LinkType" />.</param>

        public static implicit operator LinkType(string value)
        {
            return new LinkType(value);
        }

        /// <summary>Implicit operator to convert LinkType to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="LinkType" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Support.LinkType e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum LinkType</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Support.LinkType e1, Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Support.LinkType e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum LinkType</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Support.LinkType e1, Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Support.LinkType e2)
        {
            return e2.Equals(e1);
        }
    }
}