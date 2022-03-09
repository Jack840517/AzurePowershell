// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Extensions;

    /// <summary>The Mitigate Job captured from request body for Mitigate API</summary>
    public partial class MitigateJobRequest :
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IMitigateJobRequest,
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IMitigateJobRequestInternal
    {

        /// <summary>Backing field for <see cref="CustomerResolutionCode" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.CustomerResolutionCode _customerResolutionCode;

        /// <summary>Resolution code for the job</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.CustomerResolutionCode CustomerResolutionCode { get => this._customerResolutionCode; set => this._customerResolutionCode = value; }

        /// <summary>Creates an new <see cref="MitigateJobRequest" /> instance.</summary>
        public MitigateJobRequest()
        {

        }
    }
    /// The Mitigate Job captured from request body for Mitigate API
    public partial interface IMitigateJobRequest :
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.IJsonSerializable
    {
        /// <summary>Resolution code for the job</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Resolution code for the job",
        SerializedName = @"customerResolutionCode",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.CustomerResolutionCode) })]
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.CustomerResolutionCode CustomerResolutionCode { get; set; }

    }
    /// The Mitigate Job captured from request body for Mitigate API
    internal partial interface IMitigateJobRequestInternal

    {
        /// <summary>Resolution code for the job</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.CustomerResolutionCode CustomerResolutionCode { get; set; }

    }
}