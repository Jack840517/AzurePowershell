// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Extensions;

    /// <summary>The operation meta service specification</summary>
    public partial class OperationMetaServiceSpecification :
        Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IOperationMetaServiceSpecification,
        Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IOperationMetaServiceSpecificationInternal
    {

        /// <summary>Backing field for <see cref="LogSpecification" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IOperationMetaLogSpecification[] _logSpecification;

        /// <summary>log specifications for the operation</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purview.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IOperationMetaLogSpecification[] LogSpecification { get => this._logSpecification; set => this._logSpecification = value; }

        /// <summary>Backing field for <see cref="MetricSpecification" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IOperationMetaMetricSpecification[] _metricSpecification;

        /// <summary>metric specifications for the operation</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purview.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IOperationMetaMetricSpecification[] MetricSpecification { get => this._metricSpecification; set => this._metricSpecification = value; }

        /// <summary>Creates an new <see cref="OperationMetaServiceSpecification" /> instance.</summary>
        public OperationMetaServiceSpecification()
        {

        }
    }
    /// The operation meta service specification
    public partial interface IOperationMetaServiceSpecification :
        Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.IJsonSerializable
    {
        /// <summary>log specifications for the operation</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"log specifications for the operation",
        SerializedName = @"logSpecifications",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IOperationMetaLogSpecification) })]
        Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IOperationMetaLogSpecification[] LogSpecification { get; set; }
        /// <summary>metric specifications for the operation</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"metric specifications for the operation",
        SerializedName = @"metricSpecifications",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IOperationMetaMetricSpecification) })]
        Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IOperationMetaMetricSpecification[] MetricSpecification { get; set; }

    }
    /// The operation meta service specification
    internal partial interface IOperationMetaServiceSpecificationInternal

    {
        /// <summary>log specifications for the operation</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IOperationMetaLogSpecification[] LogSpecification { get; set; }
        /// <summary>metric specifications for the operation</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IOperationMetaMetricSpecification[] MetricSpecification { get; set; }

    }
}