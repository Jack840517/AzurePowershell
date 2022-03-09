// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support
{

    /// <summary>PersonalDesktopAssignment type for HostPool.</summary>
    public partial struct PersonalDesktopAssignmentType :
        System.IEquatable<PersonalDesktopAssignmentType>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support.PersonalDesktopAssignmentType Automatic = @"Automatic";

        public static Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support.PersonalDesktopAssignmentType Direct = @"Direct";

        /// <summary>
        /// the value for an instance of the <see cref="PersonalDesktopAssignmentType" /> Enum.
        /// </summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to PersonalDesktopAssignmentType</summary>
        /// <param name="value">the value to convert to an instance of <see cref="PersonalDesktopAssignmentType" />.</param>
        internal static object CreateFrom(object value)
        {
            return new PersonalDesktopAssignmentType(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type PersonalDesktopAssignmentType</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support.PersonalDesktopAssignmentType e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>
        /// Compares values of enum type PersonalDesktopAssignmentType (override for Object)
        /// </summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is PersonalDesktopAssignmentType && Equals((PersonalDesktopAssignmentType)obj);
        }

        /// <summary>Returns hashCode for enum PersonalDesktopAssignmentType</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>
        /// Creates an instance of the <see cref="PersonalDesktopAssignmentType" Enum class./>
        /// </summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private PersonalDesktopAssignmentType(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Returns string representation for PersonalDesktopAssignmentType</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to PersonalDesktopAssignmentType</summary>
        /// <param name="value">the value to convert to an instance of <see cref="PersonalDesktopAssignmentType" />.</param>

        public static implicit operator PersonalDesktopAssignmentType(string value)
        {
            return new PersonalDesktopAssignmentType(value);
        }

        /// <summary>Implicit operator to convert PersonalDesktopAssignmentType to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="PersonalDesktopAssignmentType" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support.PersonalDesktopAssignmentType e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum PersonalDesktopAssignmentType</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support.PersonalDesktopAssignmentType e1, Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support.PersonalDesktopAssignmentType e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum PersonalDesktopAssignmentType</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support.PersonalDesktopAssignmentType e1, Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support.PersonalDesktopAssignmentType e2)
        {
            return e2.Equals(e1);
        }
    }
}