// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Extensions;

    /// <summary>Job custom data details.</summary>
    public partial class JobPropertiesAutoGenerated :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IJobPropertiesAutoGenerated,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IJobPropertiesAutoGeneratedInternal
    {

        /// <summary>Backing field for <see cref="ActivityId" /> property.</summary>
        private string _activityId;

        /// <summary>The activity id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string ActivityId { get => this._activityId; set => this._activityId = value; }

        /// <summary>Backing field for <see cref="AllowedAction" /> property.</summary>
        private string[] _allowedAction;

        /// <summary>The Allowed action the job.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string[] AllowedAction { get => this._allowedAction; set => this._allowedAction = value; }

        /// <summary>Backing field for <see cref="CustomDetail" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IJobDetails _customDetail;

        /// <summary>The custom job details like test failover job details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IJobDetails CustomDetail { get => (this._customDetail = this._customDetail ?? new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.JobDetails()); set => this._customDetail = value; }

        /// <summary>
        /// The affected object properties like source server, source cloud, target server, target cloud etc. based on the workflow
        /// object details.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IJobDetailsAffectedObjectDetails CustomDetailAffectedObjectDetail { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IJobDetailsInternal)CustomDetail).AffectedObjectDetail; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IJobDetailsInternal)CustomDetail).AffectedObjectDetail = value ?? null /* model class */; }

        /// <summary>Gets the type of job details (see JobDetailsTypes enum for possible values).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string CustomDetailInstanceType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IJobDetailsInternal)CustomDetail).InstanceType; }

        /// <summary>Backing field for <see cref="EndTime" /> property.</summary>
        private global::System.DateTime? _endTime;

        /// <summary>The end time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public global::System.DateTime? EndTime { get => this._endTime; set => this._endTime = value; }

        /// <summary>Backing field for <see cref="Error" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IJobErrorDetails[] _error;

        /// <summary>The errors.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IJobErrorDetails[] Error { get => this._error; set => this._error = value; }

        /// <summary>Backing field for <see cref="FriendlyName" /> property.</summary>
        private string _friendlyName;

        /// <summary>The DisplayName.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string FriendlyName { get => this._friendlyName; set => this._friendlyName = value; }

        /// <summary>Internal Acessors for CustomDetail</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IJobDetails Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IJobPropertiesAutoGeneratedInternal.CustomDetail { get => (this._customDetail = this._customDetail ?? new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.JobDetails()); set { {_customDetail = value;} } }

        /// <summary>Internal Acessors for CustomDetailInstanceType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IJobPropertiesAutoGeneratedInternal.CustomDetailInstanceType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IJobDetailsInternal)CustomDetail).InstanceType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IJobDetailsInternal)CustomDetail).InstanceType = value; }

        /// <summary>Backing field for <see cref="ScenarioName" /> property.</summary>
        private string _scenarioName;

        /// <summary>The ScenarioName.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string ScenarioName { get => this._scenarioName; set => this._scenarioName = value; }

        /// <summary>Backing field for <see cref="StartTime" /> property.</summary>
        private global::System.DateTime? _startTime;

        /// <summary>The start time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public global::System.DateTime? StartTime { get => this._startTime; set => this._startTime = value; }

        /// <summary>Backing field for <see cref="State" /> property.</summary>
        private string _state;

        /// <summary>
        /// The status of the Job. It is one of these values - NotStarted, InProgress, Succeeded, Failed, Cancelled, Suspended or
        /// Other.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string State { get => this._state; set => this._state = value; }

        /// <summary>Backing field for <see cref="StateDescription" /> property.</summary>
        private string _stateDescription;

        /// <summary>
        /// The description of the state of the Job. For e.g. - For Succeeded state, description can be Completed, PartiallySucceeded,
        /// CompletedWithInformation or Skipped.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string StateDescription { get => this._stateDescription; set => this._stateDescription = value; }

        /// <summary>Backing field for <see cref="TargetInstanceType" /> property.</summary>
        private string _targetInstanceType;

        /// <summary>
        /// The type of the affected object which is of Microsoft.Azure.SiteRecovery.V2015_11_10.AffectedObjectType class.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string TargetInstanceType { get => this._targetInstanceType; set => this._targetInstanceType = value; }

        /// <summary>Backing field for <see cref="TargetObjectId" /> property.</summary>
        private string _targetObjectId;

        /// <summary>The affected Object Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string TargetObjectId { get => this._targetObjectId; set => this._targetObjectId = value; }

        /// <summary>Backing field for <see cref="TargetObjectName" /> property.</summary>
        private string _targetObjectName;

        /// <summary>The name of the affected object.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string TargetObjectName { get => this._targetObjectName; set => this._targetObjectName = value; }

        /// <summary>Backing field for <see cref="Task" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IAsrTask[] _task;

        /// <summary>The tasks.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IAsrTask[] Task { get => this._task; set => this._task = value; }

        /// <summary>Creates an new <see cref="JobPropertiesAutoGenerated" /> instance.</summary>
        public JobPropertiesAutoGenerated()
        {

        }
    }
    /// Job custom data details.
    public partial interface IJobPropertiesAutoGenerated :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IJsonSerializable
    {
        /// <summary>The activity id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The activity id.",
        SerializedName = @"activityId",
        PossibleTypes = new [] { typeof(string) })]
        string ActivityId { get; set; }
        /// <summary>The Allowed action the job.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The Allowed action the job.",
        SerializedName = @"allowedActions",
        PossibleTypes = new [] { typeof(string) })]
        string[] AllowedAction { get; set; }
        /// <summary>
        /// The affected object properties like source server, source cloud, target server, target cloud etc. based on the workflow
        /// object details.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The affected object properties like source server, source cloud, target server, target cloud etc. based on the workflow object details.",
        SerializedName = @"affectedObjectDetails",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IJobDetailsAffectedObjectDetails) })]
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IJobDetailsAffectedObjectDetails CustomDetailAffectedObjectDetail { get; set; }
        /// <summary>Gets the type of job details (see JobDetailsTypes enum for possible values).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Gets the type of job details (see JobDetailsTypes enum for possible values).",
        SerializedName = @"instanceType",
        PossibleTypes = new [] { typeof(string) })]
        string CustomDetailInstanceType { get;  }
        /// <summary>The end time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The end time.",
        SerializedName = @"endTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? EndTime { get; set; }
        /// <summary>The errors.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The errors.",
        SerializedName = @"errors",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IJobErrorDetails) })]
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IJobErrorDetails[] Error { get; set; }
        /// <summary>The DisplayName.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The DisplayName.",
        SerializedName = @"friendlyName",
        PossibleTypes = new [] { typeof(string) })]
        string FriendlyName { get; set; }
        /// <summary>The ScenarioName.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The ScenarioName.",
        SerializedName = @"scenarioName",
        PossibleTypes = new [] { typeof(string) })]
        string ScenarioName { get; set; }
        /// <summary>The start time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The start time.",
        SerializedName = @"startTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? StartTime { get; set; }
        /// <summary>
        /// The status of the Job. It is one of these values - NotStarted, InProgress, Succeeded, Failed, Cancelled, Suspended or
        /// Other.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The status of the Job. It is one of these values - NotStarted, InProgress, Succeeded, Failed, Cancelled, Suspended or Other.",
        SerializedName = @"state",
        PossibleTypes = new [] { typeof(string) })]
        string State { get; set; }
        /// <summary>
        /// The description of the state of the Job. For e.g. - For Succeeded state, description can be Completed, PartiallySucceeded,
        /// CompletedWithInformation or Skipped.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The description of the state of the Job. For e.g. - For Succeeded state, description can be Completed, PartiallySucceeded, CompletedWithInformation or Skipped.",
        SerializedName = @"stateDescription",
        PossibleTypes = new [] { typeof(string) })]
        string StateDescription { get; set; }
        /// <summary>
        /// The type of the affected object which is of Microsoft.Azure.SiteRecovery.V2015_11_10.AffectedObjectType class.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The type of the affected object which is of Microsoft.Azure.SiteRecovery.V2015_11_10.AffectedObjectType class.",
        SerializedName = @"targetInstanceType",
        PossibleTypes = new [] { typeof(string) })]
        string TargetInstanceType { get; set; }
        /// <summary>The affected Object Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The affected Object Id.",
        SerializedName = @"targetObjectId",
        PossibleTypes = new [] { typeof(string) })]
        string TargetObjectId { get; set; }
        /// <summary>The name of the affected object.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The name of the affected object.",
        SerializedName = @"targetObjectName",
        PossibleTypes = new [] { typeof(string) })]
        string TargetObjectName { get; set; }
        /// <summary>The tasks.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The tasks.",
        SerializedName = @"tasks",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IAsrTask) })]
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IAsrTask[] Task { get; set; }

    }
    /// Job custom data details.
    internal partial interface IJobPropertiesAutoGeneratedInternal

    {
        /// <summary>The activity id.</summary>
        string ActivityId { get; set; }
        /// <summary>The Allowed action the job.</summary>
        string[] AllowedAction { get; set; }
        /// <summary>The custom job details like test failover job details.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IJobDetails CustomDetail { get; set; }
        /// <summary>
        /// The affected object properties like source server, source cloud, target server, target cloud etc. based on the workflow
        /// object details.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IJobDetailsAffectedObjectDetails CustomDetailAffectedObjectDetail { get; set; }
        /// <summary>Gets the type of job details (see JobDetailsTypes enum for possible values).</summary>
        string CustomDetailInstanceType { get; set; }
        /// <summary>The end time.</summary>
        global::System.DateTime? EndTime { get; set; }
        /// <summary>The errors.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IJobErrorDetails[] Error { get; set; }
        /// <summary>The DisplayName.</summary>
        string FriendlyName { get; set; }
        /// <summary>The ScenarioName.</summary>
        string ScenarioName { get; set; }
        /// <summary>The start time.</summary>
        global::System.DateTime? StartTime { get; set; }
        /// <summary>
        /// The status of the Job. It is one of these values - NotStarted, InProgress, Succeeded, Failed, Cancelled, Suspended or
        /// Other.
        /// </summary>
        string State { get; set; }
        /// <summary>
        /// The description of the state of the Job. For e.g. - For Succeeded state, description can be Completed, PartiallySucceeded,
        /// CompletedWithInformation or Skipped.
        /// </summary>
        string StateDescription { get; set; }
        /// <summary>
        /// The type of the affected object which is of Microsoft.Azure.SiteRecovery.V2015_11_10.AffectedObjectType class.
        /// </summary>
        string TargetInstanceType { get; set; }
        /// <summary>The affected Object Id.</summary>
        string TargetObjectId { get; set; }
        /// <summary>The name of the affected object.</summary>
        string TargetObjectName { get; set; }
        /// <summary>The tasks.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IAsrTask[] Task { get; set; }

    }
}