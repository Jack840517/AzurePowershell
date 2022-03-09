// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Communication.Support
{

    /// <summary>
    /// Enum. Indicates the action type. "Internal" refers to actions that are for internal only APIs.
    /// </summary>
    public partial struct ActionType :
        System.IEquatable<ActionType>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.Communication.Support.ActionType Internal = @"Internal";

        /// <summary>the value for an instance of the <see cref="ActionType" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Creates an instance of the <see cref="ActionType" Enum class./></summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private ActionType(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Conversion from arbitrary object to ActionType</summary>
        /// <param name="value">the value to convert to an instance of <see cref="ActionType" />.</param>
        internal static object CreateFrom(object value)
        {
            return new ActionType(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type ActionType</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.Communication.Support.ActionType e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type ActionType (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is ActionType && Equals((ActionType)obj);
        }

        /// <summary>Returns hashCode for enum ActionType</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Returns string representation for ActionType</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to ActionType</summary>
        /// <param name="value">the value to convert to an instance of <see cref="ActionType" />.</param>

        public static implicit operator ActionType(string value)
        {
            return new ActionType(value);
        }

        /// <summary>Implicit operator to convert ActionType to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="ActionType" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.Communication.Support.ActionType e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum ActionType</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.Communication.Support.ActionType e1, Microsoft.Azure.PowerShell.Cmdlets.Communication.Support.ActionType e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum ActionType</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.Communication.Support.ActionType e1, Microsoft.Azure.PowerShell.Cmdlets.Communication.Support.ActionType e2)
        {
            return e2.Equals(e1);
        }
    }
}