// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support
{

    /// <summary>Kind of the endpoint for the data connection</summary>
    public partial struct DataConnectionKind :
        System.IEquatable<DataConnectionKind>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.DataConnectionKind EventGrid = @"EventGrid";

        public static Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.DataConnectionKind EventHub = @"EventHub";

        public static Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.DataConnectionKind IotHub = @"IotHub";

        /// <summary>the value for an instance of the <see cref="DataConnectionKind" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to DataConnectionKind</summary>
        /// <param name="value">the value to convert to an instance of <see cref="DataConnectionKind" />.</param>
        internal static object CreateFrom(object value)
        {
            return new DataConnectionKind(global::System.Convert.ToString(value));
        }

        /// <summary>Creates an instance of the <see cref="DataConnectionKind" Enum class./></summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private DataConnectionKind(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Compares values of enum type DataConnectionKind</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.DataConnectionKind e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type DataConnectionKind (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is DataConnectionKind && Equals((DataConnectionKind)obj);
        }

        /// <summary>Returns hashCode for enum DataConnectionKind</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Returns string representation for DataConnectionKind</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to DataConnectionKind</summary>
        /// <param name="value">the value to convert to an instance of <see cref="DataConnectionKind" />.</param>

        public static implicit operator DataConnectionKind(string value)
        {
            return new DataConnectionKind(value);
        }

        /// <summary>Implicit operator to convert DataConnectionKind to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="DataConnectionKind" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.DataConnectionKind e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum DataConnectionKind</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.DataConnectionKind e1, Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.DataConnectionKind e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum DataConnectionKind</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.DataConnectionKind e1, Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.DataConnectionKind e2)
        {
            return e2.Equals(e1);
        }
    }
}