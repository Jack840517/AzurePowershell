// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Extensions;

    /// <summary>Schedule resource properties</summary>
    public partial class ScheduleProperties :
        Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.IScheduleProperties,
        Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.ISchedulePropertiesInternal,
        Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.IScheduleUpdateProperties"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.IScheduleUpdateProperties __scheduleUpdateProperties = new Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.ScheduleUpdateProperties();

        /// <summary>Internal Acessors for ProvisioningState</summary>
        Microsoft.Azure.PowerShell.Cmdlets.LabServices.Support.ProvisioningState? Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.ISchedulePropertiesInternal.ProvisioningState { get => this._provisioningState; set { {_provisioningState = value;} } }

        /// <summary>Notes for this schedule.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.LabServices.PropertyOrigin.Inherited)]
        public string Note { get => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.IScheduleUpdatePropertiesInternal)__scheduleUpdateProperties).Note; set => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.IScheduleUpdatePropertiesInternal)__scheduleUpdateProperties).Note = value ?? null; }

        /// <summary>Backing field for <see cref="ProvisioningState" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.LabServices.Support.ProvisioningState? _provisioningState;

        /// <summary>Current provisioning state of the schedule.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.LabServices.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.LabServices.Support.ProvisioningState? ProvisioningState { get => this._provisioningState; }

        /// <summary>The recurrence pattern of the scheduled actions.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.LabServices.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.IRecurrencePattern RecurrencePattern { get => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.IScheduleUpdatePropertiesInternal)__scheduleUpdateProperties).RecurrencePattern; set => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.IScheduleUpdatePropertiesInternal)__scheduleUpdateProperties).RecurrencePattern = value ?? null /* model class */; }

        /// <summary>When the recurrence will expire. This date is inclusive.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.LabServices.PropertyOrigin.Inherited)]
        public global::System.DateTime? RecurrencePatternExpirationDate { get => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.IScheduleUpdatePropertiesInternal)__scheduleUpdateProperties).RecurrencePatternExpirationDate; set => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.IScheduleUpdatePropertiesInternal)__scheduleUpdateProperties).RecurrencePatternExpirationDate = value ?? default(global::System.DateTime); }

        /// <summary>The frequency of the recurrence.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.LabServices.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.LabServices.Support.RecurrenceFrequency? RecurrencePatternFrequency { get => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.IScheduleUpdatePropertiesInternal)__scheduleUpdateProperties).RecurrencePatternFrequency; set => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.IScheduleUpdatePropertiesInternal)__scheduleUpdateProperties).RecurrencePatternFrequency = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Support.RecurrenceFrequency)""); }

        /// <summary>
        /// The interval to invoke the schedule on. For example, interval = 2 and RecurrenceFrequency.Daily will run every 2 days.
        /// When no interval is supplied, an interval of 1 is used.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.LabServices.PropertyOrigin.Inherited)]
        public int? RecurrencePatternInterval { get => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.IScheduleUpdatePropertiesInternal)__scheduleUpdateProperties).RecurrencePatternInterval; set => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.IScheduleUpdatePropertiesInternal)__scheduleUpdateProperties).RecurrencePatternInterval = value ?? default(int); }

        /// <summary>The week days the schedule runs. Used for when the Frequency is set to Weekly.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.LabServices.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.LabServices.Support.WeekDay[] RecurrencePatternWeekDay { get => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.IScheduleUpdatePropertiesInternal)__scheduleUpdateProperties).RecurrencePatternWeekDay; set => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.IScheduleUpdatePropertiesInternal)__scheduleUpdateProperties).RecurrencePatternWeekDay = value ?? null /* arrayOf */; }

        /// <summary>
        /// When lab user virtual machines will be started. Timestamp offsets will be ignored and timeZoneId is used instead.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.LabServices.PropertyOrigin.Inherited)]
        public global::System.DateTime? StartAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.IScheduleUpdatePropertiesInternal)__scheduleUpdateProperties).StartAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.IScheduleUpdatePropertiesInternal)__scheduleUpdateProperties).StartAt = value ?? default(global::System.DateTime); }

        /// <summary>
        /// When lab user virtual machines will be stopped. Timestamp offsets will be ignored and timeZoneId is used instead.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.LabServices.PropertyOrigin.Inherited)]
        public global::System.DateTime? StopAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.IScheduleUpdatePropertiesInternal)__scheduleUpdateProperties).StopAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.IScheduleUpdatePropertiesInternal)__scheduleUpdateProperties).StopAt = value ?? default(global::System.DateTime); }

        /// <summary>The IANA timezone id for the schedule.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.LabServices.PropertyOrigin.Inherited)]
        public string TimeZoneId { get => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.IScheduleUpdatePropertiesInternal)__scheduleUpdateProperties).TimeZoneId; set => ((Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.IScheduleUpdatePropertiesInternal)__scheduleUpdateProperties).TimeZoneId = value ?? null; }

        /// <summary>Creates an new <see cref="ScheduleProperties" /> instance.</summary>
        public ScheduleProperties()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A < see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__scheduleUpdateProperties), __scheduleUpdateProperties);
            await eventListener.AssertObjectIsValid(nameof(__scheduleUpdateProperties), __scheduleUpdateProperties);
        }
    }
    /// Schedule resource properties
    public partial interface IScheduleProperties :
        Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.IScheduleUpdateProperties
    {
        /// <summary>Current provisioning state of the schedule.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Current provisioning state of the schedule.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.LabServices.Support.ProvisioningState) })]
        Microsoft.Azure.PowerShell.Cmdlets.LabServices.Support.ProvisioningState? ProvisioningState { get;  }

    }
    /// Schedule resource properties
    internal partial interface ISchedulePropertiesInternal :
        Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.IScheduleUpdatePropertiesInternal
    {
        /// <summary>Current provisioning state of the schedule.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.LabServices.Support.ProvisioningState? ProvisioningState { get; set; }

    }
}