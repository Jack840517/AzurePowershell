// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.VMware.Support
{

    /// <summary>The type of execution parameter</summary>
    public partial struct ScriptExecutionParameterType :
        System.IEquatable<ScriptExecutionParameterType>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.ScriptExecutionParameterType Credential = @"Credential";

        public static Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.ScriptExecutionParameterType SecureValue = @"SecureValue";

        public static Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.ScriptExecutionParameterType Value = @"Value";

        /// <summary>
        /// the value for an instance of the <see cref="ScriptExecutionParameterType" /> Enum.
        /// </summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to ScriptExecutionParameterType</summary>
        /// <param name="value">the value to convert to an instance of <see cref="ScriptExecutionParameterType" />.</param>
        internal static object CreateFrom(object value)
        {
            return new ScriptExecutionParameterType(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type ScriptExecutionParameterType</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.ScriptExecutionParameterType e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type ScriptExecutionParameterType (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is ScriptExecutionParameterType && Equals((ScriptExecutionParameterType)obj);
        }

        /// <summary>Returns hashCode for enum ScriptExecutionParameterType</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>
        /// Creates an instance of the <see cref="ScriptExecutionParameterType" Enum class./>
        /// </summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private ScriptExecutionParameterType(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Returns string representation for ScriptExecutionParameterType</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to ScriptExecutionParameterType</summary>
        /// <param name="value">the value to convert to an instance of <see cref="ScriptExecutionParameterType" />.</param>

        public static implicit operator ScriptExecutionParameterType(string value)
        {
            return new ScriptExecutionParameterType(value);
        }

        /// <summary>Implicit operator to convert ScriptExecutionParameterType to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="ScriptExecutionParameterType" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.ScriptExecutionParameterType e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum ScriptExecutionParameterType</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.ScriptExecutionParameterType e1, Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.ScriptExecutionParameterType e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum ScriptExecutionParameterType</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.ScriptExecutionParameterType e1, Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.ScriptExecutionParameterType e2)
        {
            return e2.Equals(e1);
        }
    }
}