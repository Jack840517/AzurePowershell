// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Extensions;

    /// <summary>Account details of the data to be transferred</summary>
    public partial class DataAccountDetails :
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IDataAccountDetails,
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IDataAccountDetailsInternal
    {

        /// <summary>Backing field for <see cref="DataAccountType" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.DataAccountType _dataAccountType;

        /// <summary>Account Type of the data to be transferred.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.DataAccountType DataAccountType { get => this._dataAccountType; set => this._dataAccountType = value; }

        /// <summary>Backing field for <see cref="SharePassword" /> property.</summary>
        private string _sharePassword;

        /// <summary>
        /// Password for all the shares to be created on the device. Should not be passed for TransferType:ExportFromAzure jobs. If
        /// this is not passed, the service will generate password itself. This will not be returned in Get Call. Password Requirements
        /// : Password must be minimum of 12 and maximum of 64 characters. Password must have at least one uppercase alphabet, one
        /// number and one special character. Password cannot have the following characters : IilLoO0 Password can have only alphabets,
        /// numbers and these characters : @#\-$%^!+=;:_()]+
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public string SharePassword { get => this._sharePassword; set => this._sharePassword = value; }

        /// <summary>Creates an new <see cref="DataAccountDetails" /> instance.</summary>
        public DataAccountDetails()
        {

        }
    }
    /// Account details of the data to be transferred
    public partial interface IDataAccountDetails :
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.IJsonSerializable
    {
        /// <summary>Account Type of the data to be transferred.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Account Type of the data to be transferred.",
        SerializedName = @"dataAccountType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.DataAccountType) })]
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.DataAccountType DataAccountType { get; set; }
        /// <summary>
        /// Password for all the shares to be created on the device. Should not be passed for TransferType:ExportFromAzure jobs. If
        /// this is not passed, the service will generate password itself. This will not be returned in Get Call. Password Requirements
        /// : Password must be minimum of 12 and maximum of 64 characters. Password must have at least one uppercase alphabet, one
        /// number and one special character. Password cannot have the following characters : IilLoO0 Password can have only alphabets,
        /// numbers and these characters : @#\-$%^!+=;:_()]+
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Password for all the shares to be created on the device. Should not be passed for TransferType:ExportFromAzure jobs. If this is not passed, the service will generate password itself. This will not be returned in Get Call. Password Requirements :  Password must be minimum of 12 and maximum of 64 characters. Password must have at least one uppercase alphabet, one number and one special character. Password cannot have the following characters : IilLoO0 Password can have only alphabets, numbers and these characters : @#\-$%^!+=;:_()]+",
        SerializedName = @"sharePassword",
        PossibleTypes = new [] { typeof(string) })]
        string SharePassword { get; set; }

    }
    /// Account details of the data to be transferred
    internal partial interface IDataAccountDetailsInternal

    {
        /// <summary>Account Type of the data to be transferred.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.DataAccountType DataAccountType { get; set; }
        /// <summary>
        /// Password for all the shares to be created on the device. Should not be passed for TransferType:ExportFromAzure jobs. If
        /// this is not passed, the service will generate password itself. This will not be returned in Get Call. Password Requirements
        /// : Password must be minimum of 12 and maximum of 64 characters. Password must have at least one uppercase alphabet, one
        /// number and one special character. Password cannot have the following characters : IilLoO0 Password can have only alphabets,
        /// numbers and these characters : @#\-$%^!+=;:_()]+
        /// </summary>
        string SharePassword { get; set; }

    }
}