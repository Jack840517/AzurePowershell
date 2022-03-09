// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Runtime.Extensions;

    /// <summary>
    /// Defines the Azure Active Directory principal that can approve any just-in-time access requests by the principal defined
    /// in the EligibleAuthorization.
    /// </summary>
    public partial class EligibleApprover :
        Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IEligibleApprover,
        Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IEligibleApproverInternal
    {

        /// <summary>Backing field for <see cref="PrincipalId" /> property.</summary>
        private string _principalId;

        /// <summary>The identifier of the Azure Active Directory principal.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.PropertyOrigin.Owned)]
        public string PrincipalId { get => this._principalId; set => this._principalId = value; }

        /// <summary>Backing field for <see cref="PrincipalIdDisplayName" /> property.</summary>
        private string _principalIdDisplayName;

        /// <summary>The display name of the Azure Active Directory principal.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.PropertyOrigin.Owned)]
        public string PrincipalIdDisplayName { get => this._principalIdDisplayName; set => this._principalIdDisplayName = value; }

        /// <summary>Creates an new <see cref="EligibleApprover" /> instance.</summary>
        public EligibleApprover()
        {

        }
    }
    /// Defines the Azure Active Directory principal that can approve any just-in-time access requests by the principal defined
    /// in the EligibleAuthorization.
    public partial interface IEligibleApprover :
        Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Runtime.IJsonSerializable
    {
        /// <summary>The identifier of the Azure Active Directory principal.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The identifier of the Azure Active Directory principal.",
        SerializedName = @"principalId",
        PossibleTypes = new [] { typeof(string) })]
        string PrincipalId { get; set; }
        /// <summary>The display name of the Azure Active Directory principal.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The display name of the Azure Active Directory principal.",
        SerializedName = @"principalIdDisplayName",
        PossibleTypes = new [] { typeof(string) })]
        string PrincipalIdDisplayName { get; set; }

    }
    /// Defines the Azure Active Directory principal that can approve any just-in-time access requests by the principal defined
    /// in the EligibleAuthorization.
    internal partial interface IEligibleApproverInternal

    {
        /// <summary>The identifier of the Azure Active Directory principal.</summary>
        string PrincipalId { get; set; }
        /// <summary>The display name of the Azure Active Directory principal.</summary>
        string PrincipalIdDisplayName { get; set; }

    }
}