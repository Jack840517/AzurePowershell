// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Functions.Support
{

    /// <summary>
    /// The signed services accessible with the account SAS. Possible values include: Blob (b), Queue (q), Table (t), File (f).
    /// </summary>
    public partial struct Services :
        System.IEquatable<Services>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.Services B = @"b";

        public static Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.Services F = @"f";

        public static Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.Services Q = @"q";

        public static Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.Services T = @"t";

        /// <summary>the value for an instance of the <see cref="Services" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to Services</summary>
        /// <param name="value">the value to convert to an instance of <see cref="Services" />.</param>
        internal static object CreateFrom(object value)
        {
            return new Services(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type Services</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.Services e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type Services (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is Services && Equals((Services)obj);
        }

        /// <summary>Returns hashCode for enum Services</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Creates an instance of the <see cref="Services" Enum class./></summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private Services(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Returns string representation for Services</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to Services</summary>
        /// <param name="value">the value to convert to an instance of <see cref="Services" />.</param>

        public static implicit operator Services(string value)
        {
            return new Services(value);
        }

        /// <summary>Implicit operator to convert Services to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="Services" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.Services e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum Services</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.Services e1, Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.Services e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum Services</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.Services e1, Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.Services e2)
        {
            return e2.Equals(e1);
        }
    }
}