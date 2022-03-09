// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Runtime.Extensions;

    /// <summary>Inner error containing list of errors.</summary>
    public partial class InnerError :
        Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.IInnerError,
        Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.IInnerErrorInternal
    {

        /// <summary>Creates an new <see cref="InnerError" /> instance.</summary>
        public InnerError()
        {

        }
    }
    /// Inner error containing list of errors.
    public partial interface IInnerError :
        Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Runtime.IAssociativeArray<global::System.Object>
    {

    }
    /// Inner error containing list of errors.
    internal partial interface IInnerErrorInternal

    {

    }
}