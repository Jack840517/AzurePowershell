// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support
{

    /// <summary>The type of the load balancer.</summary>
    public partial struct LoadBalancerType :
        System.IEquatable<LoadBalancerType>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support.LoadBalancerType BreadthFirst = @"BreadthFirst";

        public static Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support.LoadBalancerType DepthFirst = @"DepthFirst";

        public static Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support.LoadBalancerType Persistent = @"Persistent";

        /// <summary>the value for an instance of the <see cref="LoadBalancerType" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to LoadBalancerType</summary>
        /// <param name="value">the value to convert to an instance of <see cref="LoadBalancerType" />.</param>
        internal static object CreateFrom(object value)
        {
            return new LoadBalancerType(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type LoadBalancerType</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support.LoadBalancerType e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type LoadBalancerType (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is LoadBalancerType && Equals((LoadBalancerType)obj);
        }

        /// <summary>Returns hashCode for enum LoadBalancerType</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Creates an instance of the <see cref="LoadBalancerType" Enum class./></summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private LoadBalancerType(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Returns string representation for LoadBalancerType</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to LoadBalancerType</summary>
        /// <param name="value">the value to convert to an instance of <see cref="LoadBalancerType" />.</param>

        public static implicit operator LoadBalancerType(string value)
        {
            return new LoadBalancerType(value);
        }

        /// <summary>Implicit operator to convert LoadBalancerType to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="LoadBalancerType" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support.LoadBalancerType e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum LoadBalancerType</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support.LoadBalancerType e1, Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support.LoadBalancerType e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum LoadBalancerType</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support.LoadBalancerType e1, Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support.LoadBalancerType e2)
        {
            return e2.Equals(e1);
        }
    }
}