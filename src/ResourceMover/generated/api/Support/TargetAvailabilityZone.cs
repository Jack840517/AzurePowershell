// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Support
{

    /// <summary>Gets or sets the target availability zone.</summary>
    public partial struct TargetAvailabilityZone :
        System.IEquatable<TargetAvailabilityZone>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Support.TargetAvailabilityZone Na = @"NA";

        public static Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Support.TargetAvailabilityZone One = @"1";

        public static Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Support.TargetAvailabilityZone Three = @"3";

        public static Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Support.TargetAvailabilityZone Two = @"2";

        /// <summary>the value for an instance of the <see cref="TargetAvailabilityZone" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to TargetAvailabilityZone</summary>
        /// <param name="value">the value to convert to an instance of <see cref="TargetAvailabilityZone" />.</param>
        internal static object CreateFrom(object value)
        {
            return new TargetAvailabilityZone(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type TargetAvailabilityZone</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Support.TargetAvailabilityZone e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type TargetAvailabilityZone (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is TargetAvailabilityZone && Equals((TargetAvailabilityZone)obj);
        }

        /// <summary>Returns hashCode for enum TargetAvailabilityZone</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Creates an instance of the <see cref="TargetAvailabilityZone" Enum class./></summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private TargetAvailabilityZone(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Returns string representation for TargetAvailabilityZone</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to TargetAvailabilityZone</summary>
        /// <param name="value">the value to convert to an instance of <see cref="TargetAvailabilityZone" />.</param>

        public static implicit operator TargetAvailabilityZone(string value)
        {
            return new TargetAvailabilityZone(value);
        }

        /// <summary>Implicit operator to convert TargetAvailabilityZone to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="TargetAvailabilityZone" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Support.TargetAvailabilityZone e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum TargetAvailabilityZone</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Support.TargetAvailabilityZone e1, Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Support.TargetAvailabilityZone e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum TargetAvailabilityZone</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Support.TargetAvailabilityZone e1, Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Support.TargetAvailabilityZone e2)
        {
            return e2.Equals(e1);
        }
    }
}