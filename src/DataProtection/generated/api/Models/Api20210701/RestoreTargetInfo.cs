// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20210701
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Extensions;

    /// <summary>Class encapsulating restore target parameters</summary>
    public partial class RestoreTargetInfo :
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20210701.IRestoreTargetInfo,
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20210701.IRestoreTargetInfoInternal,
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20210701.IRestoreTargetInfoBase"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20210701.IRestoreTargetInfoBase __restoreTargetInfoBase = new Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20210701.RestoreTargetInfoBase();

        /// <summary>Backing field for <see cref="DatasourceAuthCredentials" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20210701.IAuthCredentials _datasourceAuthCredentials;

        /// <summary>Credentials to use to authenticate with data source provider.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20210701.IAuthCredentials DatasourceAuthCredentials { get => (this._datasourceAuthCredentials = this._datasourceAuthCredentials ?? new Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20210701.AuthCredentials()); set => this._datasourceAuthCredentials = value; }

        /// <summary>Backing field for <see cref="DatasourceInfo" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20210701.IDatasource _datasourceInfo;

        /// <summary>Information of target DS</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20210701.IDatasource DatasourceInfo { get => (this._datasourceInfo = this._datasourceInfo ?? new Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20210701.Datasource()); set => this._datasourceInfo = value; }

        /// <summary>Backing field for <see cref="DatasourceSetInfo" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20210701.IDatasourceSet _datasourceSetInfo;

        /// <summary>Information of target DS Set</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20210701.IDatasourceSet DatasourceSetInfo { get => (this._datasourceSetInfo = this._datasourceSetInfo ?? new Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20210701.DatasourceSet()); set => this._datasourceSetInfo = value; }

        /// <summary>Internal Acessors for RecoveryOption</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20210701.IRestoreTargetInfoBaseInternal.RecoveryOption { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20210701.IRestoreTargetInfoBaseInternal)__restoreTargetInfoBase).RecoveryOption; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20210701.IRestoreTargetInfoBaseInternal)__restoreTargetInfoBase).RecoveryOption = value; }

        /// <summary>Type of Datasource object, used to initialize the right inherited type</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inherited)]
        public string ObjectType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20210701.IRestoreTargetInfoBaseInternal)__restoreTargetInfoBase).ObjectType; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20210701.IRestoreTargetInfoBaseInternal)__restoreTargetInfoBase).ObjectType = value ; }

        /// <summary>Recovery Option</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inherited)]
        public string RecoveryOption { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20210701.IRestoreTargetInfoBaseInternal)__restoreTargetInfoBase).RecoveryOption; }

        /// <summary>Target Restore region</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inherited)]
        public string RestoreLocation { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20210701.IRestoreTargetInfoBaseInternal)__restoreTargetInfoBase).RestoreLocation; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20210701.IRestoreTargetInfoBaseInternal)__restoreTargetInfoBase).RestoreLocation = value ?? null; }

        /// <summary>Creates an new <see cref="RestoreTargetInfo" /> instance.</summary>
        public RestoreTargetInfo()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A < see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__restoreTargetInfoBase), __restoreTargetInfoBase);
            await eventListener.AssertObjectIsValid(nameof(__restoreTargetInfoBase), __restoreTargetInfoBase);
        }
    }
    /// Class encapsulating restore target parameters
    public partial interface IRestoreTargetInfo :
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20210701.IRestoreTargetInfoBase
    {
        /// <summary>Credentials to use to authenticate with data source provider.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Credentials to use to authenticate with data source provider.",
        SerializedName = @"datasourceAuthCredentials",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20210701.IAuthCredentials) })]
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20210701.IAuthCredentials DatasourceAuthCredentials { get; set; }
        /// <summary>Information of target DS</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Information of target DS",
        SerializedName = @"datasourceInfo",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20210701.IDatasource) })]
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20210701.IDatasource DatasourceInfo { get; set; }
        /// <summary>Information of target DS Set</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Information of target DS Set",
        SerializedName = @"datasourceSetInfo",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20210701.IDatasourceSet) })]
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20210701.IDatasourceSet DatasourceSetInfo { get; set; }

    }
    /// Class encapsulating restore target parameters
    internal partial interface IRestoreTargetInfoInternal :
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20210701.IRestoreTargetInfoBaseInternal
    {
        /// <summary>Credentials to use to authenticate with data source provider.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20210701.IAuthCredentials DatasourceAuthCredentials { get; set; }
        /// <summary>Information of target DS</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20210701.IDatasource DatasourceInfo { get; set; }
        /// <summary>Information of target DS Set</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20210701.IDatasourceSet DatasourceSetInfo { get; set; }

    }
}