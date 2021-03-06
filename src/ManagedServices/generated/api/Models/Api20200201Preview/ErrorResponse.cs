// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Runtime.Extensions;

    /// <summary>Error response.</summary>
    public partial class ErrorResponse :
        Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IErrorResponse,
        Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IErrorResponseInternal
    {

        /// <summary>The error code.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.PropertyOrigin.Inlined)]
        public string Code { get => ((Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IErrorDefinitionInternal)Error).Code; set => ((Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IErrorDefinitionInternal)Error).Code = value ?? null; }

        /// <summary>The internal error details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IErrorDefinition[] Detail { get => ((Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IErrorDefinitionInternal)Error).Detail; set => ((Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IErrorDefinitionInternal)Error).Detail = value ?? null /* arrayOf */; }

        /// <summary>Backing field for <see cref="Error" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IErrorDefinition _error;

        /// <summary>The error details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IErrorDefinition Error { get => (this._error = this._error ?? new Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.ErrorDefinition()); set => this._error = value; }

        /// <summary>The error message indicating why the operation failed.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.PropertyOrigin.Inlined)]
        public string Message { get => ((Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IErrorDefinitionInternal)Error).Message; set => ((Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IErrorDefinitionInternal)Error).Message = value ?? null; }

        /// <summary>Internal Acessors for Error</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IErrorDefinition Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IErrorResponseInternal.Error { get => (this._error = this._error ?? new Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.ErrorDefinition()); set { {_error = value;} } }

        /// <summary>Creates an new <see cref="ErrorResponse" /> instance.</summary>
        public ErrorResponse()
        {

        }
    }
    /// Error response.
    public partial interface IErrorResponse :
        Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Runtime.IJsonSerializable
    {
        /// <summary>The error code.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The error code.",
        SerializedName = @"code",
        PossibleTypes = new [] { typeof(string) })]
        string Code { get; set; }
        /// <summary>The internal error details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The internal error details.",
        SerializedName = @"details",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IErrorDefinition) })]
        Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IErrorDefinition[] Detail { get; set; }
        /// <summary>The error message indicating why the operation failed.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The error message indicating why the operation failed.",
        SerializedName = @"message",
        PossibleTypes = new [] { typeof(string) })]
        string Message { get; set; }

    }
    /// Error response.
    internal partial interface IErrorResponseInternal

    {
        /// <summary>The error code.</summary>
        string Code { get; set; }
        /// <summary>The internal error details.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IErrorDefinition[] Detail { get; set; }
        /// <summary>The error details.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IErrorDefinition Error { get; set; }
        /// <summary>The error message indicating why the operation failed.</summary>
        string Message { get; set; }

    }
}