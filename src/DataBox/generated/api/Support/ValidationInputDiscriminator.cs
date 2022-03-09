// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support
{

    /// <summary>Identifies the type of validation request.</summary>
    public partial struct ValidationInputDiscriminator :
        System.IEquatable<ValidationInputDiscriminator>
    {
        /// <summary>Identify request and response of address validation.</summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.ValidationInputDiscriminator ValidateAddress = @"ValidateAddress";

        /// <summary>
        /// Identify request and response of create order limit for subscription validation.
        /// </summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.ValidationInputDiscriminator ValidateCreateOrderLimit = @"ValidateCreateOrderLimit";

        /// <summary>Identify request and response of data transfer details validation.</summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.ValidationInputDiscriminator ValidateDataTransferDetails = @"ValidateDataTransferDetails";

        /// <summary>Identify request and response of preference validation.</summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.ValidationInputDiscriminator ValidatePreferences = @"ValidatePreferences";

        /// <summary>Identify request and response of active job limit for sku availability.</summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.ValidationInputDiscriminator ValidateSkuAvailability = @"ValidateSkuAvailability";

        /// <summary>
        /// Identify request and response for validation of subscription permission to create job.
        /// </summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.ValidationInputDiscriminator ValidateSubscriptionIsAllowedToCreateJob = @"ValidateSubscriptionIsAllowedToCreateJob";

        /// <summary>
        /// the value for an instance of the <see cref="ValidationInputDiscriminator" /> Enum.
        /// </summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to ValidationInputDiscriminator</summary>
        /// <param name="value">the value to convert to an instance of <see cref="ValidationInputDiscriminator" />.</param>
        internal static object CreateFrom(object value)
        {
            return new ValidationInputDiscriminator(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type ValidationInputDiscriminator</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.ValidationInputDiscriminator e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type ValidationInputDiscriminator (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is ValidationInputDiscriminator && Equals((ValidationInputDiscriminator)obj);
        }

        /// <summary>Returns hashCode for enum ValidationInputDiscriminator</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Returns string representation for ValidationInputDiscriminator</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>
        /// Creates an instance of the <see cref="ValidationInputDiscriminator" Enum class./>
        /// </summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private ValidationInputDiscriminator(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Implicit operator to convert string to ValidationInputDiscriminator</summary>
        /// <param name="value">the value to convert to an instance of <see cref="ValidationInputDiscriminator" />.</param>

        public static implicit operator ValidationInputDiscriminator(string value)
        {
            return new ValidationInputDiscriminator(value);
        }

        /// <summary>Implicit operator to convert ValidationInputDiscriminator to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="ValidationInputDiscriminator" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.ValidationInputDiscriminator e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum ValidationInputDiscriminator</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.ValidationInputDiscriminator e1, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.ValidationInputDiscriminator e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum ValidationInputDiscriminator</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.ValidationInputDiscriminator e1, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.ValidationInputDiscriminator e2)
        {
            return e2.Equals(e1);
        }
    }
}