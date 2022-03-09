// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.LabServices.Support
{

    /// <summary>Days of the week.</summary>
    public partial struct WeekDay :
        System.IEquatable<WeekDay>
    {
        /// <summary>Schedule will run on Friday</summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.LabServices.Support.WeekDay Friday = @"Friday";

        /// <summary>Schedule will run on Monday</summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.LabServices.Support.WeekDay Monday = @"Monday";

        /// <summary>Schedule will run on Saturday</summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.LabServices.Support.WeekDay Saturday = @"Saturday";

        /// <summary>Schedule will run on Sunday</summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.LabServices.Support.WeekDay Sunday = @"Sunday";

        /// <summary>Schedule will run on Thursday</summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.LabServices.Support.WeekDay Thursday = @"Thursday";

        /// <summary>Schedule will run on Tuesday</summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.LabServices.Support.WeekDay Tuesday = @"Tuesday";

        /// <summary>Schedule will run on Wednesday</summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.LabServices.Support.WeekDay Wednesday = @"Wednesday";

        /// <summary>the value for an instance of the <see cref="WeekDay" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to WeekDay</summary>
        /// <param name="value">the value to convert to an instance of <see cref="WeekDay" />.</param>
        internal static object CreateFrom(object value)
        {
            return new WeekDay(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type WeekDay</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.LabServices.Support.WeekDay e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type WeekDay (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is WeekDay && Equals((WeekDay)obj);
        }

        /// <summary>Returns hashCode for enum WeekDay</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Returns string representation for WeekDay</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Creates an instance of the <see cref="WeekDay" Enum class./></summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private WeekDay(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Implicit operator to convert string to WeekDay</summary>
        /// <param name="value">the value to convert to an instance of <see cref="WeekDay" />.</param>

        public static implicit operator WeekDay(string value)
        {
            return new WeekDay(value);
        }

        /// <summary>Implicit operator to convert WeekDay to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="WeekDay" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.LabServices.Support.WeekDay e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum WeekDay</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.LabServices.Support.WeekDay e1, Microsoft.Azure.PowerShell.Cmdlets.LabServices.Support.WeekDay e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum WeekDay</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.LabServices.Support.WeekDay e1, Microsoft.Azure.PowerShell.Cmdlets.LabServices.Support.WeekDay e2)
        {
            return e2.Equals(e1);
        }
    }
}