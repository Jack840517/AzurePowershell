// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20210801
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Runtime.Extensions;

    /// <summary>The operation error info.</summary>
    public partial class OperationErrorAdditionalInfo :
        Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20210801.IOperationErrorAdditionalInfo,
        Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20210801.IOperationErrorAdditionalInfoInternal
    {

        /// <summary>Backing field for <see cref="Info" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20210801.IMoveErrorInfo _info;

        /// <summary>The operation error info.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Origin(Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20210801.IMoveErrorInfo Info { get => (this._info = this._info ?? new Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20210801.MoveErrorInfo()); }

        /// <summary>The affected move resources.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Origin(Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20210801.IAffectedMoveResource[] InfoMoveResource { get => ((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20210801.IMoveErrorInfoInternal)Info).MoveResource; }

        /// <summary>Internal Acessors for Info</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20210801.IMoveErrorInfo Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20210801.IOperationErrorAdditionalInfoInternal.Info { get => (this._info = this._info ?? new Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20210801.MoveErrorInfo()); set { {_info = value;} } }

        /// <summary>Internal Acessors for InfoMoveResource</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20210801.IAffectedMoveResource[] Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20210801.IOperationErrorAdditionalInfoInternal.InfoMoveResource { get => ((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20210801.IMoveErrorInfoInternal)Info).MoveResource; set => ((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20210801.IMoveErrorInfoInternal)Info).MoveResource = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20210801.IOperationErrorAdditionalInfoInternal.Type { get => this._type; set { {_type = value;} } }

        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private string _type;

        /// <summary>The error type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Origin(Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.PropertyOrigin.Owned)]
        public string Type { get => this._type; }

        /// <summary>Creates an new <see cref="OperationErrorAdditionalInfo" /> instance.</summary>
        public OperationErrorAdditionalInfo()
        {

        }
    }
    /// The operation error info.
    public partial interface IOperationErrorAdditionalInfo :
        Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Runtime.IJsonSerializable
    {
        /// <summary>The affected move resources.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The affected move resources.",
        SerializedName = @"moveResources",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20210801.IAffectedMoveResource) })]
        Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20210801.IAffectedMoveResource[] InfoMoveResource { get;  }
        /// <summary>The error type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The error type.",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        string Type { get;  }

    }
    /// The operation error info.
    internal partial interface IOperationErrorAdditionalInfoInternal

    {
        /// <summary>The operation error info.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20210801.IMoveErrorInfo Info { get; set; }
        /// <summary>The affected move resources.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20210801.IAffectedMoveResource[] InfoMoveResource { get; set; }
        /// <summary>The error type.</summary>
        string Type { get; set; }

    }
}