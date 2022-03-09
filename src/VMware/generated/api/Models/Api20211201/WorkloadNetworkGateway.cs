// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201
{
    using static Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.Extensions;

    /// <summary>NSX Gateway.</summary>
    public partial class WorkloadNetworkGateway :
        Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.IWorkloadNetworkGateway,
        Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.IWorkloadNetworkGatewayInternal,
        Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.IResource"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.IResource __resource = new Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.Resource();

        /// <summary>Display name of the DHCP entity.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMware.PropertyOrigin.Inlined)]
        public string DisplayName { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.IWorkloadNetworkGatewayPropertiesInternal)Property).DisplayName; set => ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.IWorkloadNetworkGatewayPropertiesInternal)Property).DisplayName = value ?? null; }

        /// <summary>Resource ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMware.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.IResourceInternal)__resource).Id; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.IResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.IResourceInternal)__resource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.IResourceInternal)__resource).Id = value; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.IResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.IResourceInternal)__resource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.IResourceInternal)__resource).Name = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.IResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.IResourceInternal)__resource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.IResourceInternal)__resource).Type = value; }

        /// <summary>Internal Acessors for Path</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.IWorkloadNetworkGatewayInternal.Path { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.IWorkloadNetworkGatewayPropertiesInternal)Property).Path; set => ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.IWorkloadNetworkGatewayPropertiesInternal)Property).Path = value; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.IWorkloadNetworkGatewayProperties Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.IWorkloadNetworkGatewayInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.WorkloadNetworkGatewayProperties()); set { {_property = value;} } }

        /// <summary>Resource name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMware.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.IResourceInternal)__resource).Name; }

        /// <summary>NSX Gateway Path.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMware.PropertyOrigin.Inlined)]
        public string Path { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.IWorkloadNetworkGatewayPropertiesInternal)Property).Path; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.IWorkloadNetworkGatewayProperties _property;

        /// <summary>Gateway properties.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMware.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.IWorkloadNetworkGatewayProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.WorkloadNetworkGatewayProperties()); set => this._property = value; }

        /// <summary>Gets the resource group name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMware.PropertyOrigin.Owned)]
        public string ResourceGroupName { get => (new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Success ? new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Groups["resourceGroupName"].Value : null); }

        /// <summary>Resource type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMware.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.IResourceInternal)__resource).Type; }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A < see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__resource), __resource);
            await eventListener.AssertObjectIsValid(nameof(__resource), __resource);
        }

        /// <summary>Creates an new <see cref="WorkloadNetworkGateway" /> instance.</summary>
        public WorkloadNetworkGateway()
        {

        }
    }
    /// NSX Gateway.
    public partial interface IWorkloadNetworkGateway :
        Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.IResource
    {
        /// <summary>Display name of the DHCP entity.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Display name of the DHCP entity.",
        SerializedName = @"displayName",
        PossibleTypes = new [] { typeof(string) })]
        string DisplayName { get; set; }
        /// <summary>NSX Gateway Path.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"NSX Gateway Path.",
        SerializedName = @"path",
        PossibleTypes = new [] { typeof(string) })]
        string Path { get;  }

    }
    /// NSX Gateway.
    internal partial interface IWorkloadNetworkGatewayInternal :
        Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.IResourceInternal
    {
        /// <summary>Display name of the DHCP entity.</summary>
        string DisplayName { get; set; }
        /// <summary>NSX Gateway Path.</summary>
        string Path { get; set; }
        /// <summary>Gateway properties.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.IWorkloadNetworkGatewayProperties Property { get; set; }

    }
}