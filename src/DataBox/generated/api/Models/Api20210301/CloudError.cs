// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Extensions;

    /// <summary>Cloud error.</summary>
    public partial class CloudError :
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.ICloudError,
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.ICloudErrorInternal
    {

        /// <summary>Backing field for <see cref="AdditionalInfo" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IAdditionalErrorInfo[] _additionalInfo;

        /// <summary>Cloud error additional info.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IAdditionalErrorInfo[] AdditionalInfo { get => this._additionalInfo; }

        /// <summary>Backing field for <see cref="Code" /> property.</summary>
        private string _code;

        /// <summary>Cloud error code.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public string Code { get => this._code; set => this._code = value; }

        /// <summary>Backing field for <see cref="Detail" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.ICloudError[] _detail;

        /// <summary>Cloud error details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.ICloudError[] Detail { get => this._detail; }

        /// <summary>Backing field for <see cref="Message" /> property.</summary>
        private string _message;

        /// <summary>Cloud error message.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public string Message { get => this._message; set => this._message = value; }

        /// <summary>Internal Acessors for AdditionalInfo</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IAdditionalErrorInfo[] Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.ICloudErrorInternal.AdditionalInfo { get => this._additionalInfo; set { {_additionalInfo = value;} } }

        /// <summary>Internal Acessors for Detail</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.ICloudError[] Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.ICloudErrorInternal.Detail { get => this._detail; set { {_detail = value;} } }

        /// <summary>Backing field for <see cref="Target" /> property.</summary>
        private string _target;

        /// <summary>Cloud error target.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public string Target { get => this._target; set => this._target = value; }

        /// <summary>Creates an new <see cref="CloudError" /> instance.</summary>
        public CloudError()
        {

        }
    }
    /// Cloud error.
    public partial interface ICloudError :
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.IJsonSerializable
    {
        /// <summary>Cloud error additional info.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Cloud error additional info.",
        SerializedName = @"additionalInfo",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IAdditionalErrorInfo) })]
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IAdditionalErrorInfo[] AdditionalInfo { get;  }
        /// <summary>Cloud error code.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Cloud error code.",
        SerializedName = @"code",
        PossibleTypes = new [] { typeof(string) })]
        string Code { get; set; }
        /// <summary>Cloud error details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Cloud error details.",
        SerializedName = @"details",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.ICloudError) })]
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.ICloudError[] Detail { get;  }
        /// <summary>Cloud error message.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Cloud error message.",
        SerializedName = @"message",
        PossibleTypes = new [] { typeof(string) })]
        string Message { get; set; }
        /// <summary>Cloud error target.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Cloud error target.",
        SerializedName = @"target",
        PossibleTypes = new [] { typeof(string) })]
        string Target { get; set; }

    }
    /// Cloud error.
    internal partial interface ICloudErrorInternal

    {
        /// <summary>Cloud error additional info.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IAdditionalErrorInfo[] AdditionalInfo { get; set; }
        /// <summary>Cloud error code.</summary>
        string Code { get; set; }
        /// <summary>Cloud error details.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.ICloudError[] Detail { get; set; }
        /// <summary>Cloud error message.</summary>
        string Message { get; set; }
        /// <summary>Cloud error target.</summary>
        string Target { get; set; }

    }
}