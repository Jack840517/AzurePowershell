// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Quota.Runtime.Extensions;

    /// <summary>Quota request properties.</summary>
    public partial class QuotaRequestProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.IQuotaRequestProperties,
        Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.IQuotaRequestPropertiesInternal
    {

        /// <summary>Error code.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Quota.Origin(Microsoft.Azure.PowerShell.Cmdlets.Quota.PropertyOrigin.Inlined)]
        public string Code { get => ((Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.IServiceErrorDetailInternal)Error).Code; }

        /// <summary>Backing field for <see cref="Error" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.IServiceErrorDetail _error;

        /// <summary>Error details of the quota request.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Quota.Origin(Microsoft.Azure.PowerShell.Cmdlets.Quota.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.IServiceErrorDetail Error { get => (this._error = this._error ?? new Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.ServiceErrorDetail()); set => this._error = value; }

        /// <summary>Error message.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Quota.Origin(Microsoft.Azure.PowerShell.Cmdlets.Quota.PropertyOrigin.Inlined)]
        public string ErrorMessage { get => ((Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.IServiceErrorDetailInternal)Error).Message; }

        /// <summary>Backing field for <see cref="Message" /> property.</summary>
        private string _message;

        /// <summary>User-friendly status message.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Quota.Origin(Microsoft.Azure.PowerShell.Cmdlets.Quota.PropertyOrigin.Owned)]
        public string Message { get => this._message; }

        /// <summary>Internal Acessors for Code</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.IQuotaRequestPropertiesInternal.Code { get => ((Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.IServiceErrorDetailInternal)Error).Code; set => ((Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.IServiceErrorDetailInternal)Error).Code = value; }

        /// <summary>Internal Acessors for Error</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.IServiceErrorDetail Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.IQuotaRequestPropertiesInternal.Error { get => (this._error = this._error ?? new Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.ServiceErrorDetail()); set { {_error = value;} } }

        /// <summary>Internal Acessors for ErrorMessage</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.IQuotaRequestPropertiesInternal.ErrorMessage { get => ((Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.IServiceErrorDetailInternal)Error).Message; set => ((Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.IServiceErrorDetailInternal)Error).Message = value; }

        /// <summary>Internal Acessors for Message</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.IQuotaRequestPropertiesInternal.Message { get => this._message; set { {_message = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Quota.Support.QuotaRequestState? Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.IQuotaRequestPropertiesInternal.ProvisioningState { get => this._provisioningState; set { {_provisioningState = value;} } }

        /// <summary>Internal Acessors for RequestSubmitTime</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.IQuotaRequestPropertiesInternal.RequestSubmitTime { get => this._requestSubmitTime; set { {_requestSubmitTime = value;} } }

        /// <summary>Backing field for <see cref="ProvisioningState" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Quota.Support.QuotaRequestState? _provisioningState;

        /// <summary>The quota request status.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Quota.Origin(Microsoft.Azure.PowerShell.Cmdlets.Quota.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Quota.Support.QuotaRequestState? ProvisioningState { get => this._provisioningState; }

        /// <summary>Backing field for <see cref="RequestSubmitTime" /> property.</summary>
        private global::System.DateTime? _requestSubmitTime;

        /// <summary>
        /// The quota request submission time. The date conforms to the following format specified by the ISO 8601 standard: yyyy-MM-ddTHH:mm:ssZ
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Quota.Origin(Microsoft.Azure.PowerShell.Cmdlets.Quota.PropertyOrigin.Owned)]
        public global::System.DateTime? RequestSubmitTime { get => this._requestSubmitTime; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.ISubRequest[] _value;

        /// <summary>Quota request details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Quota.Origin(Microsoft.Azure.PowerShell.Cmdlets.Quota.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.ISubRequest[] Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="QuotaRequestProperties" /> instance.</summary>
        public QuotaRequestProperties()
        {

        }
    }
    /// Quota request properties.
    public partial interface IQuotaRequestProperties :
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
        /// <summary>Error message.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Quota.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Error message.",
        SerializedName = @"message",
        PossibleTypes = new [] { typeof(string) })]
        string ErrorMessage { get;  }
        /// <summary>User-friendly status message.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Quota.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"User-friendly status message.",
        SerializedName = @"message",
        PossibleTypes = new [] { typeof(string) })]
        string Message { get;  }
        /// <summary>The quota request status.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Quota.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The quota request status.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Quota.Support.QuotaRequestState) })]
        Microsoft.Azure.PowerShell.Cmdlets.Quota.Support.QuotaRequestState? ProvisioningState { get;  }
        /// <summary>
        /// The quota request submission time. The date conforms to the following format specified by the ISO 8601 standard: yyyy-MM-ddTHH:mm:ssZ
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Quota.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The quota request submission time. The date conforms to the following format specified by the ISO 8601 standard: yyyy-MM-ddTHH:mm:ssZ",
        SerializedName = @"requestSubmitTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? RequestSubmitTime { get;  }
        /// <summary>Quota request details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Quota.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Quota request details.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.ISubRequest) })]
        Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.ISubRequest[] Value { get; set; }

    }
    /// Quota request properties.
    internal partial interface IQuotaRequestPropertiesInternal

    {
        /// <summary>Error code.</summary>
        string Code { get; set; }
        /// <summary>Error details of the quota request.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.IServiceErrorDetail Error { get; set; }
        /// <summary>Error message.</summary>
        string ErrorMessage { get; set; }
        /// <summary>User-friendly status message.</summary>
        string Message { get; set; }
        /// <summary>The quota request status.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Quota.Support.QuotaRequestState? ProvisioningState { get; set; }
        /// <summary>
        /// The quota request submission time. The date conforms to the following format specified by the ISO 8601 standard: yyyy-MM-ddTHH:mm:ssZ
        /// </summary>
        global::System.DateTime? RequestSubmitTime { get; set; }
        /// <summary>Quota request details.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.ISubRequest[] Value { get; set; }

    }
}