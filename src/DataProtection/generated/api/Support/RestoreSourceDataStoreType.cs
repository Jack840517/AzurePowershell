// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support
{

    /// <summary>Gets or sets the type of the source data store.</summary>
    public partial struct RestoreSourceDataStoreType :
        System.IEquatable<RestoreSourceDataStoreType>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.RestoreSourceDataStoreType ArchiveStore = @"ArchiveStore";

        public static Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.RestoreSourceDataStoreType OperationalStore = @"OperationalStore";

        public static Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.RestoreSourceDataStoreType VaultStore = @"VaultStore";

        /// <summary>
        /// the value for an instance of the <see cref="RestoreSourceDataStoreType" /> Enum.
        /// </summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to RestoreSourceDataStoreType</summary>
        /// <param name="value">the value to convert to an instance of <see cref="RestoreSourceDataStoreType" />.</param>
        internal static object CreateFrom(object value)
        {
            return new RestoreSourceDataStoreType(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type RestoreSourceDataStoreType</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.RestoreSourceDataStoreType e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type RestoreSourceDataStoreType (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is RestoreSourceDataStoreType && Equals((RestoreSourceDataStoreType)obj);
        }

        /// <summary>Returns hashCode for enum RestoreSourceDataStoreType</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Creates an instance of the <see cref="RestoreSourceDataStoreType" Enum class./></summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private RestoreSourceDataStoreType(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Returns string representation for RestoreSourceDataStoreType</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to RestoreSourceDataStoreType</summary>
        /// <param name="value">the value to convert to an instance of <see cref="RestoreSourceDataStoreType" />.</param>

        public static implicit operator RestoreSourceDataStoreType(string value)
        {
            return new RestoreSourceDataStoreType(value);
        }

        /// <summary>Implicit operator to convert RestoreSourceDataStoreType to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="RestoreSourceDataStoreType" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.RestoreSourceDataStoreType e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum RestoreSourceDataStoreType</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.RestoreSourceDataStoreType e1, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.RestoreSourceDataStoreType e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum RestoreSourceDataStoreType</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.RestoreSourceDataStoreType e1, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.RestoreSourceDataStoreType e2)
        {
            return e2.Equals(e1);
        }
    }
}