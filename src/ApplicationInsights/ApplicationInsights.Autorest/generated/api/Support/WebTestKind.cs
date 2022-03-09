// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Support
{

    /// <summary>The kind of WebTest that this web test watches. Choices are ping and multistep.</summary>
    public partial struct WebTestKind :
        System.IEquatable<WebTestKind>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Support.WebTestKind Multistep = @"multistep";

        public static Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Support.WebTestKind Ping = @"ping";

        /// <summary>the value for an instance of the <see cref="WebTestKind" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to WebTestKind</summary>
        /// <param name="value">the value to convert to an instance of <see cref="WebTestKind" />.</param>
        internal static object CreateFrom(object value)
        {
            return new WebTestKind(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type WebTestKind</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Support.WebTestKind e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type WebTestKind (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is WebTestKind && Equals((WebTestKind)obj);
        }

        /// <summary>Returns hashCode for enum WebTestKind</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Returns string representation for WebTestKind</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Creates an instance of the <see cref="WebTestKind" Enum class./></summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private WebTestKind(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Implicit operator to convert string to WebTestKind</summary>
        /// <param name="value">the value to convert to an instance of <see cref="WebTestKind" />.</param>

        public static implicit operator WebTestKind(string value)
        {
            return new WebTestKind(value);
        }

        /// <summary>Implicit operator to convert WebTestKind to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="WebTestKind" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Support.WebTestKind e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum WebTestKind</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Support.WebTestKind e1, Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Support.WebTestKind e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum WebTestKind</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Support.WebTestKind e1, Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Support.WebTestKind e2)
        {
            return e2.Equals(e1);
        }
    }
}