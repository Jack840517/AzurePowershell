// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Extensions;

    /// <summary>Properties of pre job creation validation response.</summary>
    public partial class ValidationResponseProperties :
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IValidationResponseProperties,
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IValidationResponsePropertiesInternal
    {

        /// <summary>Backing field for <see cref="IndividualResponseDetail" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IValidationInputResponse[] _individualResponseDetail;

        /// <summary>
        /// List of response details contain validationType and its response as key and value respectively.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IValidationInputResponse[] IndividualResponseDetail { get => this._individualResponseDetail; }

        /// <summary>Internal Acessors for IndividualResponseDetail</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IValidationInputResponse[] Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IValidationResponsePropertiesInternal.IndividualResponseDetail { get => this._individualResponseDetail; set { {_individualResponseDetail = value;} } }

        /// <summary>Internal Acessors for Status</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.OverallValidationStatus? Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IValidationResponsePropertiesInternal.Status { get => this._status; set { {_status = value;} } }

        /// <summary>Backing field for <see cref="Status" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.OverallValidationStatus? _status;

        /// <summary>Overall validation status.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.OverallValidationStatus? Status { get => this._status; }

        /// <summary>Creates an new <see cref="ValidationResponseProperties" /> instance.</summary>
        public ValidationResponseProperties()
        {

        }
    }
    /// Properties of pre job creation validation response.
    public partial interface IValidationResponseProperties :
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.IJsonSerializable
    {
        /// <summary>
        /// List of response details contain validationType and its response as key and value respectively.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"List of response details contain validationType and its response as key and value respectively.",
        SerializedName = @"individualResponseDetails",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IValidationInputResponse),typeof(Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IAddressValidationProperties) })]
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IValidationInputResponse[] IndividualResponseDetail { get;  }
        /// <summary>Overall validation status.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Overall validation status.",
        SerializedName = @"status",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.OverallValidationStatus) })]
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.OverallValidationStatus? Status { get;  }

    }
    /// Properties of pre job creation validation response.
    internal partial interface IValidationResponsePropertiesInternal

    {
        /// <summary>
        /// List of response details contain validationType and its response as key and value respectively.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IValidationInputResponse[] IndividualResponseDetail { get; set; }
        /// <summary>Overall validation status.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.OverallValidationStatus? Status { get; set; }

    }
}