// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Support
{

    /// <summary>
    /// The network access policy to determine if Azure Arc agents can use public Azure Arc service endpoints. Defaults to disabled
    /// (access to Azure Arc services only via private link).
    /// </summary>
    public partial struct PublicNetworkAccessType :
        System.IEquatable<PublicNetworkAccessType>
    {
        /// <summary>
        /// Does not allow Azure Arc agents to communicate with Azure Arc services over public (internet) endpoints. The agents must
        /// use the private link.
        /// </summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Support.PublicNetworkAccessType Disabled = @"Disabled";

        /// <summary>
        /// Allows Azure Arc agents to communicate with Azure Arc services over both public (internet) and private endpoints.
        /// </summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Support.PublicNetworkAccessType Enabled = @"Enabled";

        /// <summary>the value for an instance of the <see cref="PublicNetworkAccessType" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to PublicNetworkAccessType</summary>
        /// <param name="value">the value to convert to an instance of <see cref="PublicNetworkAccessType" />.</param>
        internal static object CreateFrom(object value)
        {
            return new PublicNetworkAccessType(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type PublicNetworkAccessType</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Support.PublicNetworkAccessType e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type PublicNetworkAccessType (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is PublicNetworkAccessType && Equals((PublicNetworkAccessType)obj);
        }

        /// <summary>Returns hashCode for enum PublicNetworkAccessType</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Creates an instance of the <see cref="PublicNetworkAccessType" Enum class./></summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private PublicNetworkAccessType(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Returns string representation for PublicNetworkAccessType</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to PublicNetworkAccessType</summary>
        /// <param name="value">the value to convert to an instance of <see cref="PublicNetworkAccessType" />.</param>

        public static implicit operator PublicNetworkAccessType(string value)
        {
            return new PublicNetworkAccessType(value);
        }

        /// <summary>Implicit operator to convert PublicNetworkAccessType to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="PublicNetworkAccessType" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Support.PublicNetworkAccessType e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum PublicNetworkAccessType</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Support.PublicNetworkAccessType e1, Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Support.PublicNetworkAccessType e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum PublicNetworkAccessType</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Support.PublicNetworkAccessType e1, Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Support.PublicNetworkAccessType e2)
        {
            return e2.Equals(e1);
        }
    }
}