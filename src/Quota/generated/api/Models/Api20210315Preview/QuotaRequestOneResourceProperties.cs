// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Quota.Runtime.Extensions;

    /// <summary>Quota request.</summary>
    public partial class QuotaRequestOneResourceProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.IQuotaRequestOneResourceProperties,
        Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.IQuotaRequestOneResourcePropertiesInternal
    {

        /// <summary>Error code.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Quota.Origin(Microsoft.Azure.PowerShell.Cmdlets.Quota.PropertyOrigin.Inlined)]
        public string Code { get => ((Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.IServiceErrorDetailInternal)Error).Code; }

        /// <summary>Backing field for <see cref="CurrentValue" /> property.</summary>
        private int? _currentValue;

        /// <summary>Usage information for the current resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Quota.Origin(Microsoft.Azure.PowerShell.Cmdlets.Quota.PropertyOrigin.Owned)]
        public int? CurrentValue { get => this._currentValue; }

        /// <summary>Backing field for <see cref="Error" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.IServiceErrorDetail _error;

        /// <summary>Error details of the quota request.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Quota.Origin(Microsoft.Azure.PowerShell.Cmdlets.Quota.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.IServiceErrorDetail Error { get => (this._error = this._error ?? new Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.ServiceErrorDetail()); set => this._error = value; }

        /// <summary>Error message.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Quota.Origin(Microsoft.Azure.PowerShell.Cmdlets.Quota.PropertyOrigin.Inlined)]
        public string ErrorMessage { get => ((Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.IServiceErrorDetailInternal)Error).Message; }

        /// <summary>Backing field for <see cref="IsQuotaApplicable" /> property.</summary>
        private bool? _isQuotaApplicable;

        /// <summary>States if quota can be requested for this resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Quota.Origin(Microsoft.Azure.PowerShell.Cmdlets.Quota.PropertyOrigin.Owned)]
        public bool? IsQuotaApplicable { get => this._isQuotaApplicable; }

        /// <summary>Backing field for <see cref="Limit" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.ILimitObject _limit;

        /// <summary>Resource quota limit properties.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Quota.Origin(Microsoft.Azure.PowerShell.Cmdlets.Quota.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.ILimitObject Limit { get => (this._limit = this._limit ?? new Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.LimitObject()); set => this._limit = value; }

        /// <summary>The limit object type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Quota.Origin(Microsoft.Azure.PowerShell.Cmdlets.Quota.PropertyOrigin.Inlined)]
        public string LimitObjectType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.ILimitJsonObjectInternal)Limit).Type; }

        /// <summary>The quota or usages limit types.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Quota.Origin(Microsoft.Azure.PowerShell.Cmdlets.Quota.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Quota.Support.QuotaLimitTypes? LimitType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.ILimitObjectInternal)Limit).LimitType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.ILimitObjectInternal)Limit).LimitType = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.Quota.Support.QuotaLimitTypes)""); }

        /// <summary>The quota/limit value</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Quota.Origin(Microsoft.Azure.PowerShell.Cmdlets.Quota.PropertyOrigin.Inlined)]
        public int? LimitValue { get => ((Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.ILimitObjectInternal)Limit).Value; set => ((Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.ILimitObjectInternal)Limit).Value = value ?? default(int); }

        /// <summary>Backing field for <see cref="Message" /> property.</summary>
        private string _message;

        /// <summary>User-friendly status message.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Quota.Origin(Microsoft.Azure.PowerShell.Cmdlets.Quota.PropertyOrigin.Owned)]
        public string Message { get => this._message; }

        /// <summary>Internal Acessors for Code</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.IQuotaRequestOneResourcePropertiesInternal.Code { get => ((Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.IServiceErrorDetailInternal)Error).Code; set => ((Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.IServiceErrorDetailInternal)Error).Code = value; }

        /// <summary>Internal Acessors for CurrentValue</summary>
        int? Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.IQuotaRequestOneResourcePropertiesInternal.CurrentValue { get => this._currentValue; set { {_currentValue = value;} } }

        /// <summary>Internal Acessors for Error</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.IServiceErrorDetail Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.IQuotaRequestOneResourcePropertiesInternal.Error { get => (this._error = this._error ?? new Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.ServiceErrorDetail()); set { {_error = value;} } }

        /// <summary>Internal Acessors for ErrorMessage</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.IQuotaRequestOneResourcePropertiesInternal.ErrorMessage { get => ((Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.IServiceErrorDetailInternal)Error).Message; set => ((Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.IServiceErrorDetailInternal)Error).Message = value; }

        /// <summary>Internal Acessors for IsQuotaApplicable</summary>
        bool? Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.IQuotaRequestOneResourcePropertiesInternal.IsQuotaApplicable { get => this._isQuotaApplicable; set { {_isQuotaApplicable = value;} } }

        /// <summary>Internal Acessors for Limit</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.ILimitObject Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.IQuotaRequestOneResourcePropertiesInternal.Limit { get => (this._limit = this._limit ?? new Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.LimitObject()); set { {_limit = value;} } }

        /// <summary>Internal Acessors for LimitObjectType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.IQuotaRequestOneResourcePropertiesInternal.LimitObjectType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.ILimitJsonObjectInternal)Limit).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.ILimitJsonObjectInternal)Limit).Type = value; }

        /// <summary>Internal Acessors for Message</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.IQuotaRequestOneResourcePropertiesInternal.Message { get => this._message; set { {_message = value;} } }

        /// <summary>Internal Acessors for Name</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.IResourceName Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.IQuotaRequestOneResourcePropertiesInternal.Name { get => (this._name = this._name ?? new Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.ResourceName()); set { {_name = value;} } }

        /// <summary>Internal Acessors for NameLocalizedValue</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.IQuotaRequestOneResourcePropertiesInternal.NameLocalizedValue { get => ((Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.IResourceNameInternal)Name).LocalizedValue; set => ((Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.IResourceNameInternal)Name).LocalizedValue = value; }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Quota.Support.QuotaRequestState? Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.IQuotaRequestOneResourcePropertiesInternal.ProvisioningState { get => this._provisioningState; set { {_provisioningState = value;} } }

        /// <summary>Internal Acessors for QuotaPeriod</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.IQuotaRequestOneResourcePropertiesInternal.QuotaPeriod { get => this._quotaPeriod; set { {_quotaPeriod = value;} } }

        /// <summary>Internal Acessors for RequestSubmitTime</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.IQuotaRequestOneResourcePropertiesInternal.RequestSubmitTime { get => this._requestSubmitTime; set { {_requestSubmitTime = value;} } }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.IResourceName _name;

        /// <summary>
        /// Resource name provided by the resource provider. Use this property name when requesting quota.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Quota.Origin(Microsoft.Azure.PowerShell.Cmdlets.Quota.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.IResourceName Name { get => (this._name = this._name ?? new Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.ResourceName()); set => this._name = value; }

        /// <summary>Resource display name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Quota.Origin(Microsoft.Azure.PowerShell.Cmdlets.Quota.PropertyOrigin.Inlined)]
        public string NameLocalizedValue { get => ((Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.IResourceNameInternal)Name).LocalizedValue; }

        /// <summary>Resource name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Quota.Origin(Microsoft.Azure.PowerShell.Cmdlets.Quota.PropertyOrigin.Inlined)]
        public string NameValue { get => ((Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.IResourceNameInternal)Name).Value; set => ((Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.IResourceNameInternal)Name).Value = value ?? null; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.IAny _property;

        /// <summary>Additional properties for the specific resource provider.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Quota.Origin(Microsoft.Azure.PowerShell.Cmdlets.Quota.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.IAny Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Any()); set => this._property = value; }

        /// <summary>Backing field for <see cref="ProvisioningState" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Quota.Support.QuotaRequestState? _provisioningState;

        /// <summary>Quota request status.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Quota.Origin(Microsoft.Azure.PowerShell.Cmdlets.Quota.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Quota.Support.QuotaRequestState? ProvisioningState { get => this._provisioningState; }

        /// <summary>Backing field for <see cref="QuotaPeriod" /> property.</summary>
        private string _quotaPeriod;

        /// <summary>
        /// The time period over which the quota usage values are summarized. For example:
        /// *P1D (per one day)
        /// *PT1M (per one minute)
        /// *PT1S (per one second).
        /// This parameter is optional because, for some resources like compute, the period is irrelevant.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Quota.Origin(Microsoft.Azure.PowerShell.Cmdlets.Quota.PropertyOrigin.Owned)]
        public string QuotaPeriod { get => this._quotaPeriod; }

        /// <summary>Backing field for <see cref="RequestSubmitTime" /> property.</summary>
        private global::System.DateTime? _requestSubmitTime;

        /// <summary>
        /// Quota request submission time. The date conforms to the following ISO 8601 standard format: yyyy-MM-ddTHH:mm:ssZ.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Quota.Origin(Microsoft.Azure.PowerShell.Cmdlets.Quota.PropertyOrigin.Owned)]
        public global::System.DateTime? RequestSubmitTime { get => this._requestSubmitTime; }

        /// <summary>Backing field for <see cref="ResourceType" /> property.</summary>
        private string _resourceType;

        /// <summary>Resource type name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Quota.Origin(Microsoft.Azure.PowerShell.Cmdlets.Quota.PropertyOrigin.Owned)]
        public string ResourceType { get => this._resourceType; set => this._resourceType = value; }

        /// <summary>Backing field for <see cref="Unit" /> property.</summary>
        private string _unit;

        /// <summary>
        /// The quota limit units, such as Count and Bytes. When requesting quota, use the **unit** value returned in the GET response
        /// in the request body of your PUT operation.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Quota.Origin(Microsoft.Azure.PowerShell.Cmdlets.Quota.PropertyOrigin.Owned)]
        public string Unit { get => this._unit; set => this._unit = value; }

        /// <summary>Creates an new <see cref="QuotaRequestOneResourceProperties" /> instance.</summary>
        public QuotaRequestOneResourceProperties()
        {

        }
    }
    /// Quota request.
    public partial interface IQuotaRequestOneResourceProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Quota.Runtime.IJsonSerializable
    {
        /// <summary>Error code.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Quota.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Error code.",
        SerializedName = @"code",
        PossibleTypes = new [] { typeof(string) })]
        string Code { get;  }
        /// <summary>Usage information for the current resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Quota.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Usage information for the current resource.",
        SerializedName = @"currentValue",
        PossibleTypes = new [] { typeof(int) })]
        int? CurrentValue { get;  }
        /// <summary>Error message.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Quota.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Error message.",
        SerializedName = @"message",
        PossibleTypes = new [] { typeof(string) })]
        string ErrorMessage { get;  }
        /// <summary>States if quota can be requested for this resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Quota.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"States if quota can be requested for this resource.",
        SerializedName = @"isQuotaApplicable",
        PossibleTypes = new [] { typeof(bool) })]
        bool? IsQuotaApplicable { get;  }
        /// <summary>The limit object type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Quota.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The limit object type.",
        SerializedName = @"limitObjectType",
        PossibleTypes = new [] { typeof(string) })]
        string LimitObjectType { get;  }
        /// <summary>The quota or usages limit types.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Quota.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The quota or usages limit types.",
        SerializedName = @"limitType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Quota.Support.QuotaLimitTypes) })]
        Microsoft.Azure.PowerShell.Cmdlets.Quota.Support.QuotaLimitTypes? LimitType { get; set; }
        /// <summary>The quota/limit value</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Quota.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The quota/limit value",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(int) })]
        int? LimitValue { get; set; }
        /// <summary>User-friendly status message.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Quota.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"User-friendly status message.",
        SerializedName = @"message",
        PossibleTypes = new [] { typeof(string) })]
        string Message { get;  }
        /// <summary>Resource display name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Quota.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Resource display name.",
        SerializedName = @"localizedValue",
        PossibleTypes = new [] { typeof(string) })]
        string NameLocalizedValue { get;  }
        /// <summary>Resource name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Quota.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Resource name.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(string) })]
        string NameValue { get; set; }
        /// <summary>Additional properties for the specific resource provider.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Quota.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Additional properties for the specific resource provider.",
        SerializedName = @"properties",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.IAny) })]
        Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.IAny Property { get; set; }
        /// <summary>Quota request status.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Quota.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Quota request status.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Quota.Support.QuotaRequestState) })]
        Microsoft.Azure.PowerShell.Cmdlets.Quota.Support.QuotaRequestState? ProvisioningState { get;  }
        /// <summary>
        /// The time period over which the quota usage values are summarized. For example:
        /// *P1D (per one day)
        /// *PT1M (per one minute)
        /// *PT1S (per one second).
        /// This parameter is optional because, for some resources like compute, the period is irrelevant.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Quota.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The time period over which the quota usage values are summarized. For example:
        *P1D (per one day)
        *PT1M (per one minute)
        *PT1S (per one second).
        This parameter is optional because, for some resources like compute, the period is irrelevant.",
        SerializedName = @"quotaPeriod",
        PossibleTypes = new [] { typeof(string) })]
        string QuotaPeriod { get;  }
        /// <summary>
        /// Quota request submission time. The date conforms to the following ISO 8601 standard format: yyyy-MM-ddTHH:mm:ssZ.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Quota.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Quota request submission time. The date conforms to the following ISO 8601 standard format: yyyy-MM-ddTHH:mm:ssZ.",
        SerializedName = @"requestSubmitTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? RequestSubmitTime { get;  }
        /// <summary>Resource type name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Quota.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Resource type name.",
        SerializedName = @"resourceType",
        PossibleTypes = new [] { typeof(string) })]
        string ResourceType { get; set; }
        /// <summary>
        /// The quota limit units, such as Count and Bytes. When requesting quota, use the **unit** value returned in the GET response
        /// in the request body of your PUT operation.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Quota.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @" The quota limit units, such as Count and Bytes. When requesting quota, use the **unit** value returned in the GET response in the request body of your PUT operation.",
        SerializedName = @"unit",
        PossibleTypes = new [] { typeof(string) })]
        string Unit { get; set; }

    }
    /// Quota request.
    internal partial interface IQuotaRequestOneResourcePropertiesInternal

    {
        /// <summary>Error code.</summary>
        string Code { get; set; }
        /// <summary>Usage information for the current resource.</summary>
        int? CurrentValue { get; set; }
        /// <summary>Error details of the quota request.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.IServiceErrorDetail Error { get; set; }
        /// <summary>Error message.</summary>
        string ErrorMessage { get; set; }
        /// <summary>States if quota can be requested for this resource.</summary>
        bool? IsQuotaApplicable { get; set; }
        /// <summary>Resource quota limit properties.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.ILimitObject Limit { get; set; }
        /// <summary>The limit object type.</summary>
        string LimitObjectType { get; set; }
        /// <summary>The quota or usages limit types.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Quota.Support.QuotaLimitTypes? LimitType { get; set; }
        /// <summary>The quota/limit value</summary>
        int? LimitValue { get; set; }
        /// <summary>User-friendly status message.</summary>
        string Message { get; set; }
        /// <summary>
        /// Resource name provided by the resource provider. Use this property name when requesting quota.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.IResourceName Name { get; set; }
        /// <summary>Resource display name.</summary>
        string NameLocalizedValue { get; set; }
        /// <summary>Resource name.</summary>
        string NameValue { get; set; }
        /// <summary>Additional properties for the specific resource provider.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.IAny Property { get; set; }
        /// <summary>Quota request status.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Quota.Support.QuotaRequestState? ProvisioningState { get; set; }
        /// <summary>
        /// The time period over which the quota usage values are summarized. For example:
        /// *P1D (per one day)
        /// *PT1M (per one minute)
        /// *PT1S (per one second).
        /// This parameter is optional because, for some resources like compute, the period is irrelevant.
        /// </summary>
        string QuotaPeriod { get; set; }
        /// <summary>
        /// Quota request submission time. The date conforms to the following ISO 8601 standard format: yyyy-MM-ddTHH:mm:ssZ.
        /// </summary>
        global::System.DateTime? RequestSubmitTime { get; set; }
        /// <summary>Resource type name.</summary>
        string ResourceType { get; set; }
        /// <summary>
        /// The quota limit units, such as Count and Bytes. When requesting quota, use the **unit** value returned in the GET response
        /// in the request body of your PUT operation.
        /// </summary>
        string Unit { get; set; }

    }
}