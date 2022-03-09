// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support
{

    /// <summary>Name of the stage which is in progress.</summary>
    public partial struct StageName :
        System.IEquatable<StageName>
    {
        /// <summary>Order has been aborted.</summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.StageName Aborted = @"Aborted";

        /// <summary>Device has been received at Azure datacenter from the user.</summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.StageName AtAzureDc = @"AtAzureDC";

        /// <summary>Order has been cancelled.</summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.StageName Cancelled = @"Cancelled";

        /// <summary>Order has completed.</summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.StageName Completed = @"Completed";

        /// <summary>Order has completed with errors.</summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.StageName CompletedWithErrors = @"CompletedWithErrors";

        /// <summary>Order has completed with warnings.</summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.StageName CompletedWithWarnings = @"CompletedWithWarnings";

        /// <summary>Data copy from the device at Azure datacenter.</summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.StageName DataCopy = @"DataCopy";

        /// <summary>Device has been delivered to the user of the order.</summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.StageName Delivered = @"Delivered";

        /// <summary>An order has been created.</summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.StageName DeviceOrdered = @"DeviceOrdered";

        /// <summary>A device has been prepared for the order.</summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.StageName DevicePrepared = @"DevicePrepared";

        /// <summary>Device has been dispatched to the user of the order.</summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.StageName Dispatched = @"Dispatched";

        /// <summary>Order has failed due to issue detected at Azure datacenter.</summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.StageName FailedIssueDetectedAtAzureDc = @"Failed_IssueDetectedAtAzureDC";

        /// <summary>Order has failed due to issue reported by user.</summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.StageName FailedIssueReportedAtCustomer = @"Failed_IssueReportedAtCustomer";

        /// <summary>Device has been picked up from user and in transit to Azure datacenter.</summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.StageName PickedUp = @"PickedUp";

        /// <summary>Device is ready to be handed to customer from Azure DC.</summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.StageName ReadyToDispatchFromAzureDc = @"ReadyToDispatchFromAzureDC";

        /// <summary>Device can be dropped off at Azure DC.</summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.StageName ReadyToReceiveAtAzureDc = @"ReadyToReceiveAtAzureDC";

        /// <summary>the value for an instance of the <see cref="StageName" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to StageName</summary>
        /// <param name="value">the value to convert to an instance of <see cref="StageName" />.</param>
        internal static object CreateFrom(object value)
        {
            return new StageName(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type StageName</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.StageName e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type StageName (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is StageName && Equals((StageName)obj);
        }

        /// <summary>Returns hashCode for enum StageName</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Creates an instance of the <see cref="StageName" Enum class./></summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private StageName(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Returns string representation for StageName</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to StageName</summary>
        /// <param name="value">the value to convert to an instance of <see cref="StageName" />.</param>

        public static implicit operator StageName(string value)
        {
            return new StageName(value);
        }

        /// <summary>Implicit operator to convert StageName to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="StageName" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.StageName e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum StageName</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.StageName e1, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.StageName e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum StageName</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.StageName e1, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.StageName e2)
        {
            return e2.Equals(e1);
        }
    }
}