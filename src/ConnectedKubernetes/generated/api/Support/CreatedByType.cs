// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Support
{

    /// <summary>The type of identity that created the resource.</summary>
    public partial struct CreatedByType :
        System.IEquatable<CreatedByType>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Support.CreatedByType Application = @"Application";

        public static Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Support.CreatedByType Key = @"Key";

        public static Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Support.CreatedByType ManagedIdentity = @"ManagedIdentity";

        public static Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Support.CreatedByType User = @"User";

        /// <summary>the value for an instance of the <see cref="CreatedByType" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to CreatedByType</summary>
        /// <param name="value">the value to convert to an instance of <see cref="CreatedByType" />.</param>
        internal static object CreateFrom(object value)
        {
            return new CreatedByType(global::System.Convert.ToString(value));
        }

        /// <summary>Creates an instance of the <see cref="CreatedByType" Enum class./></summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private CreatedByType(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Compares values of enum type CreatedByType</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Support.CreatedByType e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type CreatedByType (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is CreatedByType && Equals((CreatedByType)obj);
        }

        /// <summary>Returns hashCode for enum CreatedByType</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Returns string representation for CreatedByType</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to CreatedByType</summary>
        /// <param name="value">the value to convert to an instance of <see cref="CreatedByType" />.</param>

        public static implicit operator CreatedByType(string value)
        {
            return new CreatedByType(value);
        }

        /// <summary>Implicit operator to convert CreatedByType to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="CreatedByType" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Support.CreatedByType e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum CreatedByType</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Support.CreatedByType e1, Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Support.CreatedByType e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum CreatedByType</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Support.CreatedByType e1, Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Support.CreatedByType e2)
        {
            return e2.Equals(e1);
        }
    }
}