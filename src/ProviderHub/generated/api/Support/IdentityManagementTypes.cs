// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Support
{

    public partial struct IdentityManagementTypes :
        System.IEquatable<IdentityManagementTypes>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Support.IdentityManagementTypes Actor = @"Actor";

        public static Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Support.IdentityManagementTypes DelegatedResourceIdentity = @"DelegatedResourceIdentity";

        public static Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Support.IdentityManagementTypes NotSpecified = @"NotSpecified";

        public static Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Support.IdentityManagementTypes SystemAssigned = @"SystemAssigned";

        public static Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Support.IdentityManagementTypes UserAssigned = @"UserAssigned";

        /// <summary>the value for an instance of the <see cref="IdentityManagementTypes" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to IdentityManagementTypes</summary>
        /// <param name="value">the value to convert to an instance of <see cref="IdentityManagementTypes" />.</param>
        internal static object CreateFrom(object value)
        {
            return new IdentityManagementTypes(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type IdentityManagementTypes</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Support.IdentityManagementTypes e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type IdentityManagementTypes (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is IdentityManagementTypes && Equals((IdentityManagementTypes)obj);
        }

        /// <summary>Returns hashCode for enum IdentityManagementTypes</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Creates an instance of the <see cref="IdentityManagementTypes" Enum class./></summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private IdentityManagementTypes(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Returns string representation for IdentityManagementTypes</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to IdentityManagementTypes</summary>
        /// <param name="value">the value to convert to an instance of <see cref="IdentityManagementTypes" />.</param>

        public static implicit operator IdentityManagementTypes(string value)
        {
            return new IdentityManagementTypes(value);
        }

        /// <summary>Implicit operator to convert IdentityManagementTypes to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="IdentityManagementTypes" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Support.IdentityManagementTypes e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum IdentityManagementTypes</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Support.IdentityManagementTypes e1, Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Support.IdentityManagementTypes e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum IdentityManagementTypes</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Support.IdentityManagementTypes e1, Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Support.IdentityManagementTypes e2)
        {
            return e2.Equals(e1);
        }
    }
}