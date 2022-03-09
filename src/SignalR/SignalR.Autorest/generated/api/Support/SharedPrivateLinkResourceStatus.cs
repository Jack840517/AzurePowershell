// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Support
{

    /// <summary>Status of the shared private link resource</summary>
    public partial struct SharedPrivateLinkResourceStatus :
        System.IEquatable<SharedPrivateLinkResourceStatus>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Support.SharedPrivateLinkResourceStatus Approved = @"Approved";

        public static Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Support.SharedPrivateLinkResourceStatus Disconnected = @"Disconnected";

        public static Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Support.SharedPrivateLinkResourceStatus Pending = @"Pending";

        public static Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Support.SharedPrivateLinkResourceStatus Rejected = @"Rejected";

        public static Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Support.SharedPrivateLinkResourceStatus Timeout = @"Timeout";

        /// <summary>
        /// the value for an instance of the <see cref="SharedPrivateLinkResourceStatus" /> Enum.
        /// </summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to SharedPrivateLinkResourceStatus</summary>
        /// <param name="value">the value to convert to an instance of <see cref="SharedPrivateLinkResourceStatus" />.</param>
        internal static object CreateFrom(object value)
        {
            return new SharedPrivateLinkResourceStatus(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type SharedPrivateLinkResourceStatus</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Support.SharedPrivateLinkResourceStatus e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>
        /// Compares values of enum type SharedPrivateLinkResourceStatus (override for Object)
        /// </summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is SharedPrivateLinkResourceStatus && Equals((SharedPrivateLinkResourceStatus)obj);
        }

        /// <summary>Returns hashCode for enum SharedPrivateLinkResourceStatus</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>
        /// Creates an instance of the <see cref="SharedPrivateLinkResourceStatus" Enum class./>
        /// </summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private SharedPrivateLinkResourceStatus(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Returns string representation for SharedPrivateLinkResourceStatus</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to SharedPrivateLinkResourceStatus</summary>
        /// <param name="value">the value to convert to an instance of <see cref="SharedPrivateLinkResourceStatus" />.</param>

        public static implicit operator SharedPrivateLinkResourceStatus(string value)
        {
            return new SharedPrivateLinkResourceStatus(value);
        }

        /// <summary>Implicit operator to convert SharedPrivateLinkResourceStatus to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="SharedPrivateLinkResourceStatus" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Support.SharedPrivateLinkResourceStatus e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum SharedPrivateLinkResourceStatus</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Support.SharedPrivateLinkResourceStatus e1, Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Support.SharedPrivateLinkResourceStatus e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum SharedPrivateLinkResourceStatus</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Support.SharedPrivateLinkResourceStatus e1, Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Support.SharedPrivateLinkResourceStatus e2)
        {
            return e2.Equals(e1);
        }
    }
}