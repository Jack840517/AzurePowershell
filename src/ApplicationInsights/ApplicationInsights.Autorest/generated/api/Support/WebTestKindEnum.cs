// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Support
{

    /// <summary>The kind of web test this is, valid choices are ping, multistep, and standard.</summary>
    public partial struct WebTestKindEnum :
        System.IEquatable<WebTestKindEnum>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Support.WebTestKindEnum Multistep = @"multistep";

        public static Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Support.WebTestKindEnum Ping = @"ping";

        public static Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Support.WebTestKindEnum Standard = @"standard";

        /// <summary>the value for an instance of the <see cref="WebTestKindEnum" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to WebTestKindEnum</summary>
        /// <param name="value">the value to convert to an instance of <see cref="WebTestKindEnum" />.</param>
        internal static object CreateFrom(object value)
        {
            return new WebTestKindEnum(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type WebTestKindEnum</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Support.WebTestKindEnum e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type WebTestKindEnum (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is WebTestKindEnum && Equals((WebTestKindEnum)obj);
        }

        /// <summary>Returns hashCode for enum WebTestKindEnum</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Returns string representation for WebTestKindEnum</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Creates an instance of the <see cref="WebTestKindEnum" Enum class./></summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private WebTestKindEnum(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Implicit operator to convert string to WebTestKindEnum</summary>
        /// <param name="value">the value to convert to an instance of <see cref="WebTestKindEnum" />.</param>

        public static implicit operator WebTestKindEnum(string value)
        {
            return new WebTestKindEnum(value);
        }

        /// <summary>Implicit operator to convert WebTestKindEnum to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="WebTestKindEnum" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Support.WebTestKindEnum e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum WebTestKindEnum</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Support.WebTestKindEnum e1, Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Support.WebTestKindEnum e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum WebTestKindEnum</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Support.WebTestKindEnum e1, Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Support.WebTestKindEnum e2)
        {
            return e2.Equals(e1);
        }
    }
}