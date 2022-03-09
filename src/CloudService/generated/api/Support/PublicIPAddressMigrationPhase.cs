// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support
{

    /// <summary>Migration phase of Public IP Address.</summary>
    public partial struct PublicIPAddressMigrationPhase :
        System.IEquatable<PublicIPAddressMigrationPhase>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.PublicIPAddressMigrationPhase Abort = @"Abort";

        public static Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.PublicIPAddressMigrationPhase Commit = @"Commit";

        public static Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.PublicIPAddressMigrationPhase Committed = @"Committed";

        public static Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.PublicIPAddressMigrationPhase None = @"None";

        public static Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.PublicIPAddressMigrationPhase Prepare = @"Prepare";

        /// <summary>
        /// the value for an instance of the <see cref="PublicIPAddressMigrationPhase" /> Enum.
        /// </summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to PublicIPAddressMigrationPhase</summary>
        /// <param name="value">the value to convert to an instance of <see cref="PublicIPAddressMigrationPhase" />.</param>
        internal static object CreateFrom(object value)
        {
            return new PublicIPAddressMigrationPhase(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type PublicIPAddressMigrationPhase</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.PublicIPAddressMigrationPhase e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>
        /// Compares values of enum type PublicIPAddressMigrationPhase (override for Object)
        /// </summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is PublicIPAddressMigrationPhase && Equals((PublicIPAddressMigrationPhase)obj);
        }

        /// <summary>Returns hashCode for enum PublicIPAddressMigrationPhase</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>
        /// Creates an instance of the <see cref="PublicIPAddressMigrationPhase" Enum class./>
        /// </summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private PublicIPAddressMigrationPhase(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Returns string representation for PublicIPAddressMigrationPhase</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to PublicIPAddressMigrationPhase</summary>
        /// <param name="value">the value to convert to an instance of <see cref="PublicIPAddressMigrationPhase" />.</param>

        public static implicit operator PublicIPAddressMigrationPhase(string value)
        {
            return new PublicIPAddressMigrationPhase(value);
        }

        /// <summary>Implicit operator to convert PublicIPAddressMigrationPhase to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="PublicIPAddressMigrationPhase" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.PublicIPAddressMigrationPhase e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum PublicIPAddressMigrationPhase</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.PublicIPAddressMigrationPhase e1, Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.PublicIPAddressMigrationPhase e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum PublicIPAddressMigrationPhase</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.PublicIPAddressMigrationPhase e1, Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.PublicIPAddressMigrationPhase e2)
        {
            return e2.Equals(e1);
        }
    }
}