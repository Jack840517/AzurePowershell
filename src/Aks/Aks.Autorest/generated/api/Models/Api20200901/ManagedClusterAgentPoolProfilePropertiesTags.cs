// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20200901
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Extensions;

    /// <summary>Agent pool tags to be persisted on the agent pool virtual machine scale set.</summary>
    public partial class ManagedClusterAgentPoolProfilePropertiesTags :
        Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20200901.IManagedClusterAgentPoolProfilePropertiesTags,
        Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20200901.IManagedClusterAgentPoolProfilePropertiesTagsInternal
    {

        /// <summary>
        /// Creates an new <see cref="ManagedClusterAgentPoolProfilePropertiesTags" /> instance.
        /// </summary>
        public ManagedClusterAgentPoolProfilePropertiesTags()
        {

        }
    }
    /// Agent pool tags to be persisted on the agent pool virtual machine scale set.
    public partial interface IManagedClusterAgentPoolProfilePropertiesTags :
        Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.IAssociativeArray<string>
    {

    }
    /// Agent pool tags to be persisted on the agent pool virtual machine scale set.
    internal partial interface IManagedClusterAgentPoolProfilePropertiesTagsInternal

    {

    }
}