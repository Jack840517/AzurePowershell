// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Support
{

    /// <summary>Describes whether the order item is cancellable or not.</summary>
    public partial struct OrderItemCancellationEnum :
        System.IEquatable<OrderItemCancellationEnum>
    {
        /// <summary>Order item can be cancelled without fee.</summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Support.OrderItemCancellationEnum Cancellable = @"Cancellable";

        /// <summary>Order item can be cancelled with fee.</summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Support.OrderItemCancellationEnum CancellableWithFee = @"CancellableWithFee";

        /// <summary>Order item not cancellable.</summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Support.OrderItemCancellationEnum NotCancellable = @"NotCancellable";

        /// <summary>the value for an instance of the <see cref="OrderItemCancellationEnum" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to OrderItemCancellationEnum</summary>
        /// <param name="value">the value to convert to an instance of <see cref="OrderItemCancellationEnum" />.</param>
        internal static object CreateFrom(object value)
        {
            return new OrderItemCancellationEnum(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type OrderItemCancellationEnum</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Support.OrderItemCancellationEnum e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type OrderItemCancellationEnum (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is OrderItemCancellationEnum && Equals((OrderItemCancellationEnum)obj);
        }

        /// <summary>Returns hashCode for enum OrderItemCancellationEnum</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Creates an instance of the <see cref="OrderItemCancellationEnum" Enum class./></summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private OrderItemCancellationEnum(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Returns string representation for OrderItemCancellationEnum</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to OrderItemCancellationEnum</summary>
        /// <param name="value">the value to convert to an instance of <see cref="OrderItemCancellationEnum" />.</param>

        public static implicit operator OrderItemCancellationEnum(string value)
        {
            return new OrderItemCancellationEnum(value);
        }

        /// <summary>Implicit operator to convert OrderItemCancellationEnum to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="OrderItemCancellationEnum" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Support.OrderItemCancellationEnum e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum OrderItemCancellationEnum</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Support.OrderItemCancellationEnum e1, Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Support.OrderItemCancellationEnum e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum OrderItemCancellationEnum</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Support.OrderItemCancellationEnum e1, Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Support.OrderItemCancellationEnum e2)
        {
            return e2.Equals(e1);
        }
    }
}