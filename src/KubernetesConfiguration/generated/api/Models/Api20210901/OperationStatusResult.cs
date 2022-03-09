// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20210901
{
    using static Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Runtime.Extensions;

    /// <summary>The current status of an async operation.</summary>
    public partial class OperationStatusResult :
        Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20210901.IOperationStatusResult,
        Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20210901.IOperationStatusResultInternal
    {

        /// <summary>The error additional info.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20.IErrorAdditionalInfo[] AdditionalInfo { get => ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20.IErrorDetailInternal)Error).AdditionalInfo; }

        /// <summary>The error code.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.PropertyOrigin.Inlined)]
        public string Code { get => ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20.IErrorDetailInternal)Error).Code; }

        /// <summary>The error details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20.IErrorDetail[] Detail { get => ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20.IErrorDetailInternal)Error).Detail; }

        /// <summary>Backing field for <see cref="Error" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20.IErrorDetail _error;

        /// <summary>The error detail.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20.IErrorDetail Error { get => (this._error = this._error ?? new Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20.ErrorDetail()); set => this._error = value; }

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        /// <summary>Fully qualified ID for the async operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.PropertyOrigin.Owned)]
        public string Id { get => this._id; set => this._id = value; }

        /// <summary>The error message.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.PropertyOrigin.Inlined)]
        public string Message { get => ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20.IErrorDetailInternal)Error).Message; }

        /// <summary>Internal Acessors for AdditionalInfo</summary>
        Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20.IErrorAdditionalInfo[] Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20210901.IOperationStatusResultInternal.AdditionalInfo { get => ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20.IErrorDetailInternal)Error).AdditionalInfo; set => ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20.IErrorDetailInternal)Error).AdditionalInfo = value; }

        /// <summary>Internal Acessors for Code</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20210901.IOperationStatusResultInternal.Code { get => ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20.IErrorDetailInternal)Error).Code; set => ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20.IErrorDetailInternal)Error).Code = value; }

        /// <summary>Internal Acessors for Detail</summary>
        Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20.IErrorDetail[] Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20210901.IOperationStatusResultInternal.Detail { get => ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20.IErrorDetailInternal)Error).Detail; set => ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20.IErrorDetailInternal)Error).Detail = value; }

        /// <summary>Internal Acessors for Error</summary>
        Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20.IErrorDetail Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20210901.IOperationStatusResultInternal.Error { get => (this._error = this._error ?? new Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20.ErrorDetail()); set { {_error = value;} } }

        /// <summary>Internal Acessors for Message</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20210901.IOperationStatusResultInternal.Message { get => ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20.IErrorDetailInternal)Error).Message; set => ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20.IErrorDetailInternal)Error).Message = value; }

        /// <summary>Internal Acessors for Target</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20210901.IOperationStatusResultInternal.Target { get => ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20.IErrorDetailInternal)Error).Target; set => ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20.IErrorDetailInternal)Error).Target = value; }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>Name of the async operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20210901.IOperationStatusResultProperties _property;

        /// <summary>Additional information, if available.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20210901.IOperationStatusResultProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20210901.OperationStatusResultProperties()); set => this._property = value; }

        /// <summary>Gets the resource group name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.PropertyOrigin.Owned)]
        public string ResourceGroupName { get => (new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/").Match(this.Id).Success ? new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/").Match(this.Id).Groups["resourceGroupName"].Value : null); }

        /// <summary>Backing field for <see cref="Status" /> property.</summary>
        private string _status;

        /// <summary>Operation status.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.PropertyOrigin.Owned)]
        public string Status { get => this._status; set => this._status = value; }

        /// <summary>The error target.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.PropertyOrigin.Inlined)]
        public string Target { get => ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20.IErrorDetailInternal)Error).Target; }

        /// <summary>Creates an new <see cref="OperationStatusResult" /> instance.</summary>
        public OperationStatusResult()
        {

        }
    }
    /// The current status of an async operation.
    public partial interface IOperationStatusResult :
        Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Runtime.IJsonSerializable
    {
        /// <summary>The error additional info.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The error additional info.",
        SerializedName = @"additionalInfo",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20.IErrorAdditionalInfo) })]
        Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20.IErrorAdditionalInfo[] AdditionalInfo { get;  }
        /// <summary>The error code.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The error code.",
        SerializedName = @"code",
        PossibleTypes = new [] { typeof(string) })]
        string Code { get;  }
        /// <summary>The error details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The error details.",
        SerializedName = @"details",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20.IErrorDetail) })]
        Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20.IErrorDetail[] Detail { get;  }
        /// <summary>Fully qualified ID for the async operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Fully qualified ID for the async operation.",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string Id { get; set; }
        /// <summary>The error message.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The error message.",
        SerializedName = @"message",
        PossibleTypes = new [] { typeof(string) })]
        string Message { get;  }
        /// <summary>Name of the async operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Name of the async operation.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }
        /// <summary>Additional information, if available.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Additional information, if available.",
        SerializedName = @"properties",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20210901.IOperationStatusResultProperties) })]
        Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20210901.IOperationStatusResultProperties Property { get; set; }
        /// <summary>Operation status.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Operation status.",
        SerializedName = @"status",
        PossibleTypes = new [] { typeof(string) })]
        string Status { get; set; }
        /// <summary>The error target.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The error target.",
        SerializedName = @"target",
        PossibleTypes = new [] { typeof(string) })]
        string Target { get;  }

    }
    /// The current status of an async operation.
    internal partial interface IOperationStatusResultInternal

    {
        /// <summary>The error additional info.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20.IErrorAdditionalInfo[] AdditionalInfo { get; set; }
        /// <summary>The error code.</summary>
        string Code { get; set; }
        /// <summary>The error details.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20.IErrorDetail[] Detail { get; set; }
        /// <summary>The error detail.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20.IErrorDetail Error { get; set; }
        /// <summary>Fully qualified ID for the async operation.</summary>
        string Id { get; set; }
        /// <summary>The error message.</summary>
        string Message { get; set; }
        /// <summary>Name of the async operation.</summary>
        string Name { get; set; }
        /// <summary>Additional information, if available.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20210901.IOperationStatusResultProperties Property { get; set; }
        /// <summary>Operation status.</summary>
        string Status { get; set; }
        /// <summary>The error target.</summary>
        string Target { get; set; }

    }
}