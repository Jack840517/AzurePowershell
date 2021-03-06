// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Extensions;

    /// <summary>Job details.</summary>
    public partial class JobDetails :
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IJobDetails,
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IJobDetailsInternal
    {

        /// <summary>Backing field for <see cref="Action" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.CustomerResolutionCode[] _action;

        /// <summary>Available actions on the job.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.CustomerResolutionCode[] Action { get => this._action; }

        /// <summary>Backing field for <see cref="ChainOfCustodySasKey" /> property.</summary>
        private string _chainOfCustodySasKey;

        /// <summary>Shared access key to download the chain of custody logs</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public string ChainOfCustodySasKey { get => this._chainOfCustodySasKey; }

        /// <summary>Backing field for <see cref="ContactDetail" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IContactDetails _contactDetail;

        /// <summary>Contact details for notification and shipping.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IContactDetails ContactDetail { get => (this._contactDetail = this._contactDetail ?? new Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.ContactDetails()); set => this._contactDetail = value; }

        /// <summary>Backing field for <see cref="CopyLogDetail" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.ICopyLogDetails[] _copyLogDetail;

        /// <summary>List of copy log details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.ICopyLogDetails[] CopyLogDetail { get => this._copyLogDetail; }

        /// <summary>Backing field for <see cref="DataExportDetail" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IDataExportDetails[] _dataExportDetail;

        /// <summary>Details of the data to be exported from azure.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IDataExportDetails[] DataExportDetail { get => this._dataExportDetail; set => this._dataExportDetail = value; }

        /// <summary>Backing field for <see cref="DataImportDetail" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IDataImportDetails[] _dataImportDetail;

        /// <summary>Details of the data to be imported into azure.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IDataImportDetails[] DataImportDetail { get => this._dataImportDetail; set => this._dataImportDetail = value; }

        /// <summary>Backing field for <see cref="DeliveryPackage" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IPackageShippingDetails _deliveryPackage;

        /// <summary>Delivery package shipping details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IPackageShippingDetails DeliveryPackage { get => (this._deliveryPackage = this._deliveryPackage ?? new Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.PackageShippingDetails()); }

        /// <summary>Backing field for <see cref="ExpectedDataSizeInTeraByte" /> property.</summary>
        private int? _expectedDataSizeInTeraByte;

        /// <summary>
        /// The expected size of the data, which needs to be transferred in this job, in terabytes.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public int? ExpectedDataSizeInTeraByte { get => this._expectedDataSizeInTeraByte; set => this._expectedDataSizeInTeraByte = value; }

        /// <summary>Backing field for <see cref="JobStage" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IJobStages[] _jobStage;

        /// <summary>List of stages that run in the job.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IJobStages[] JobStage { get => this._jobStage; }

        /// <summary>Backing field for <see cref="KeyEncryptionKey" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IKeyEncryptionKey _keyEncryptionKey;

        /// <summary>Details about which key encryption type is being used.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IKeyEncryptionKey KeyEncryptionKey { get => (this._keyEncryptionKey = this._keyEncryptionKey ?? new Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.KeyEncryptionKey()); set => this._keyEncryptionKey = value; }

        /// <summary>Backing field for <see cref="LastMitigationActionOnJob" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.ILastMitigationActionOnJob _lastMitigationActionOnJob;

        /// <summary>Last mitigation action performed on the job.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.ILastMitigationActionOnJob LastMitigationActionOnJob { get => (this._lastMitigationActionOnJob = this._lastMitigationActionOnJob ?? new Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.LastMitigationActionOnJob()); }

        /// <summary>Internal Acessors for Action</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.CustomerResolutionCode[] Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IJobDetailsInternal.Action { get => this._action; set { {_action = value;} } }

        /// <summary>Internal Acessors for ChainOfCustodySasKey</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IJobDetailsInternal.ChainOfCustodySasKey { get => this._chainOfCustodySasKey; set { {_chainOfCustodySasKey = value;} } }

        /// <summary>Internal Acessors for CopyLogDetail</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.ICopyLogDetails[] Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IJobDetailsInternal.CopyLogDetail { get => this._copyLogDetail; set { {_copyLogDetail = value;} } }

        /// <summary>Internal Acessors for DeliveryPackage</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IPackageShippingDetails Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IJobDetailsInternal.DeliveryPackage { get => (this._deliveryPackage = this._deliveryPackage ?? new Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.PackageShippingDetails()); set { {_deliveryPackage = value;} } }

        /// <summary>Internal Acessors for JobStage</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IJobStages[] Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IJobDetailsInternal.JobStage { get => this._jobStage; set { {_jobStage = value;} } }

        /// <summary>Internal Acessors for LastMitigationActionOnJob</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.ILastMitigationActionOnJob Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IJobDetailsInternal.LastMitigationActionOnJob { get => (this._lastMitigationActionOnJob = this._lastMitigationActionOnJob ?? new Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.LastMitigationActionOnJob()); set { {_lastMitigationActionOnJob = value;} } }

        /// <summary>Internal Acessors for ReturnPackage</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IPackageShippingDetails Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IJobDetailsInternal.ReturnPackage { get => (this._returnPackage = this._returnPackage ?? new Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.PackageShippingDetails()); set { {_returnPackage = value;} } }

        /// <summary>Internal Acessors for ReverseShipmentLabelSasKey</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IJobDetailsInternal.ReverseShipmentLabelSasKey { get => this._reverseShipmentLabelSasKey; set { {_reverseShipmentLabelSasKey = value;} } }

        /// <summary>Backing field for <see cref="Preference" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IPreferences _preference;

        /// <summary>Preferences for the order.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IPreferences Preference { get => (this._preference = this._preference ?? new Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.Preferences()); set => this._preference = value; }

        /// <summary>Backing field for <see cref="ReturnPackage" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IPackageShippingDetails _returnPackage;

        /// <summary>Return package shipping details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IPackageShippingDetails ReturnPackage { get => (this._returnPackage = this._returnPackage ?? new Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.PackageShippingDetails()); }

        /// <summary>Backing field for <see cref="ReverseShipmentLabelSasKey" /> property.</summary>
        private string _reverseShipmentLabelSasKey;

        /// <summary>Shared access key to download the return shipment label</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public string ReverseShipmentLabelSasKey { get => this._reverseShipmentLabelSasKey; }

        /// <summary>Backing field for <see cref="ShippingAddress" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IShippingAddress _shippingAddress;

        /// <summary>Shipping address of the customer.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IShippingAddress ShippingAddress { get => (this._shippingAddress = this._shippingAddress ?? new Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.ShippingAddress()); set => this._shippingAddress = value; }

        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.ClassDiscriminator _type;

        /// <summary>Indicates the type of job details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.ClassDiscriminator Type { get => this._type; set => this._type = value; }

        /// <summary>Creates an new <see cref="JobDetails" /> instance.</summary>
        public JobDetails()
        {

        }
    }
    /// Job details.
    public partial interface IJobDetails :
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.IJsonSerializable
    {
        /// <summary>Available actions on the job.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Available actions on the job.",
        SerializedName = @"actions",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.CustomerResolutionCode) })]
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.CustomerResolutionCode[] Action { get;  }
        /// <summary>Shared access key to download the chain of custody logs</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Shared access key to download the chain of custody logs",
        SerializedName = @"chainOfCustodySasKey",
        PossibleTypes = new [] { typeof(string) })]
        string ChainOfCustodySasKey { get;  }
        /// <summary>Contact details for notification and shipping.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Contact details for notification and shipping.",
        SerializedName = @"contactDetails",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IContactDetails) })]
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IContactDetails ContactDetail { get; set; }
        /// <summary>List of copy log details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"List of copy log details.",
        SerializedName = @"copyLogDetails",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.ICopyLogDetails) })]
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.ICopyLogDetails[] CopyLogDetail { get;  }
        /// <summary>Details of the data to be exported from azure.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Details of the data to be exported from azure.",
        SerializedName = @"dataExportDetails",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IDataExportDetails) })]
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IDataExportDetails[] DataExportDetail { get; set; }
        /// <summary>Details of the data to be imported into azure.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Details of the data to be imported into azure.",
        SerializedName = @"dataImportDetails",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IDataImportDetails) })]
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IDataImportDetails[] DataImportDetail { get; set; }
        /// <summary>Delivery package shipping details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Delivery package shipping details.",
        SerializedName = @"deliveryPackage",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IPackageShippingDetails) })]
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IPackageShippingDetails DeliveryPackage { get;  }
        /// <summary>
        /// The expected size of the data, which needs to be transferred in this job, in terabytes.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The expected size of the data, which needs to be transferred in this job, in terabytes.",
        SerializedName = @"expectedDataSizeInTeraBytes",
        PossibleTypes = new [] { typeof(int) })]
        int? ExpectedDataSizeInTeraByte { get; set; }
        /// <summary>List of stages that run in the job.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"List of stages that run in the job.",
        SerializedName = @"jobStages",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IJobStages) })]
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IJobStages[] JobStage { get;  }
        /// <summary>Details about which key encryption type is being used.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Details about which key encryption type is being used.",
        SerializedName = @"keyEncryptionKey",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IKeyEncryptionKey) })]
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IKeyEncryptionKey KeyEncryptionKey { get; set; }
        /// <summary>Last mitigation action performed on the job.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Last mitigation action performed on the job.",
        SerializedName = @"lastMitigationActionOnJob",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.ILastMitigationActionOnJob) })]
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.ILastMitigationActionOnJob LastMitigationActionOnJob { get;  }
        /// <summary>Preferences for the order.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Preferences for the order.",
        SerializedName = @"preferences",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IPreferences) })]
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IPreferences Preference { get; set; }
        /// <summary>Return package shipping details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Return package shipping details.",
        SerializedName = @"returnPackage",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IPackageShippingDetails) })]
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IPackageShippingDetails ReturnPackage { get;  }
        /// <summary>Shared access key to download the return shipment label</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Shared access key to download the return shipment label",
        SerializedName = @"reverseShipmentLabelSasKey",
        PossibleTypes = new [] { typeof(string) })]
        string ReverseShipmentLabelSasKey { get;  }
        /// <summary>Shipping address of the customer.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Shipping address of the customer.",
        SerializedName = @"shippingAddress",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IShippingAddress) })]
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IShippingAddress ShippingAddress { get; set; }
        /// <summary>Indicates the type of job details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Indicates the type of job details.",
        SerializedName = @"jobDetailsType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.ClassDiscriminator) })]
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.ClassDiscriminator Type { get; set; }

    }
    /// Job details.
    internal partial interface IJobDetailsInternal

    {
        /// <summary>Available actions on the job.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.CustomerResolutionCode[] Action { get; set; }
        /// <summary>Shared access key to download the chain of custody logs</summary>
        string ChainOfCustodySasKey { get; set; }
        /// <summary>Contact details for notification and shipping.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IContactDetails ContactDetail { get; set; }
        /// <summary>List of copy log details.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.ICopyLogDetails[] CopyLogDetail { get; set; }
        /// <summary>Details of the data to be exported from azure.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IDataExportDetails[] DataExportDetail { get; set; }
        /// <summary>Details of the data to be imported into azure.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IDataImportDetails[] DataImportDetail { get; set; }
        /// <summary>Delivery package shipping details.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IPackageShippingDetails DeliveryPackage { get; set; }
        /// <summary>
        /// The expected size of the data, which needs to be transferred in this job, in terabytes.
        /// </summary>
        int? ExpectedDataSizeInTeraByte { get; set; }
        /// <summary>List of stages that run in the job.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IJobStages[] JobStage { get; set; }
        /// <summary>Details about which key encryption type is being used.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IKeyEncryptionKey KeyEncryptionKey { get; set; }
        /// <summary>Last mitigation action performed on the job.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.ILastMitigationActionOnJob LastMitigationActionOnJob { get; set; }
        /// <summary>Preferences for the order.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IPreferences Preference { get; set; }
        /// <summary>Return package shipping details.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IPackageShippingDetails ReturnPackage { get; set; }
        /// <summary>Shared access key to download the return shipment label</summary>
        string ReverseShipmentLabelSasKey { get; set; }
        /// <summary>Shipping address of the customer.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IShippingAddress ShippingAddress { get; set; }
        /// <summary>Indicates the type of job details.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.ClassDiscriminator Type { get; set; }

    }
}