// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Synapse.Runtime.Extensions;

    /// <summary>Class representing an update to a Kusto kusto pool.</summary>
    public partial class KustoPoolUpdate :
        Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IKustoPoolUpdate,
        Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IKustoPoolUpdateInternal,
        Microsoft.Azure.PowerShell.Cmdlets.Synapse.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api10.IResource" />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api10.IResource __resource = new Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api10.Resource();

        /// <summary>The Kusto Pool data ingestion URI.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Synapse.Origin(Microsoft.Azure.PowerShell.Cmdlets.Synapse.PropertyOrigin.Inlined)]
        public string DataIngestionUri { get => ((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IKustoPoolPropertiesInternal)Property).DataIngestionUri; }

        /// <summary>A boolean value that indicates if the purge operations are enabled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Synapse.Origin(Microsoft.Azure.PowerShell.Cmdlets.Synapse.PropertyOrigin.Inlined)]
        public bool? EnablePurge { get => ((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IKustoPoolPropertiesInternal)Property).EnablePurge; set => ((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IKustoPoolPropertiesInternal)Property).EnablePurge = value ?? default(bool); }

        /// <summary>A boolean value that indicates if the streaming ingest is enabled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Synapse.Origin(Microsoft.Azure.PowerShell.Cmdlets.Synapse.PropertyOrigin.Inlined)]
        public bool? EnableStreamingIngest { get => ((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IKustoPoolPropertiesInternal)Property).EnableStreamingIngest; set => ((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IKustoPoolPropertiesInternal)Property).EnableStreamingIngest = value ?? default(bool); }

        /// <summary>
        /// Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Synapse.Origin(Microsoft.Azure.PowerShell.Cmdlets.Synapse.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api10.IResourceInternal)__resource).Id; }

        /// <summary>The list of language extensions.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Synapse.Origin(Microsoft.Azure.PowerShell.Cmdlets.Synapse.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.ILanguageExtension[] LanguageExtensionValue { get => ((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IKustoPoolPropertiesInternal)Property).LanguageExtensionValue; set => ((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IKustoPoolPropertiesInternal)Property).LanguageExtensionValue = value ?? null /* arrayOf */; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api10.IResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api10.IResourceInternal)__resource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api10.IResourceInternal)__resource).Id = value; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api10.IResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api10.IResourceInternal)__resource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api10.IResourceInternal)__resource).Name = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api10.IResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api10.IResourceInternal)__resource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api10.IResourceInternal)__resource).Type = value; }

        /// <summary>Internal Acessors for DataIngestionUri</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IKustoPoolUpdateInternal.DataIngestionUri { get => ((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IKustoPoolPropertiesInternal)Property).DataIngestionUri; set => ((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IKustoPoolPropertiesInternal)Property).DataIngestionUri = value; }

        /// <summary>Internal Acessors for LanguageExtension</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.ILanguageExtensionsList Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IKustoPoolUpdateInternal.LanguageExtension { get => ((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IKustoPoolPropertiesInternal)Property).LanguageExtension; set => ((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IKustoPoolPropertiesInternal)Property).LanguageExtension = value; }

        /// <summary>Internal Acessors for OptimizedAutoscale</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IOptimizedAutoscale Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IKustoPoolUpdateInternal.OptimizedAutoscale { get => ((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IKustoPoolPropertiesInternal)Property).OptimizedAutoscale; set => ((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IKustoPoolPropertiesInternal)Property).OptimizedAutoscale = value; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IKustoPoolProperties Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IKustoPoolUpdateInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.KustoPoolProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Synapse.Support.ResourceProvisioningState? Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IKustoPoolUpdateInternal.ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IKustoPoolPropertiesInternal)Property).ProvisioningState; set => ((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IKustoPoolPropertiesInternal)Property).ProvisioningState = value; }

        /// <summary>Internal Acessors for Sku</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IAzureSku Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IKustoPoolUpdateInternal.Sku { get => (this._sku = this._sku ?? new Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.AzureSku()); set { {_sku = value;} } }

        /// <summary>Internal Acessors for State</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Synapse.Support.State? Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IKustoPoolUpdateInternal.State { get => ((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IKustoPoolPropertiesInternal)Property).State; set => ((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IKustoPoolPropertiesInternal)Property).State = value; }

        /// <summary>Internal Acessors for StateReason</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IKustoPoolUpdateInternal.StateReason { get => ((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IKustoPoolPropertiesInternal)Property).StateReason; set => ((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IKustoPoolPropertiesInternal)Property).StateReason = value; }

        /// <summary>Internal Acessors for Uri</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IKustoPoolUpdateInternal.Uri { get => ((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IKustoPoolPropertiesInternal)Property).Uri; set => ((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IKustoPoolPropertiesInternal)Property).Uri = value; }

        /// <summary>The name of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Synapse.Origin(Microsoft.Azure.PowerShell.Cmdlets.Synapse.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api10.IResourceInternal)__resource).Name; }

        /// <summary>
        /// A boolean value that indicate if the optimized autoscale feature is enabled or not.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Synapse.Origin(Microsoft.Azure.PowerShell.Cmdlets.Synapse.PropertyOrigin.Inlined)]
        public bool? OptimizedAutoscaleIsEnabled { get => ((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IKustoPoolPropertiesInternal)Property).OptimizedAutoscaleIsEnabled; set => ((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IKustoPoolPropertiesInternal)Property).OptimizedAutoscaleIsEnabled = value ?? default(bool); }

        /// <summary>Maximum allowed instances count.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Synapse.Origin(Microsoft.Azure.PowerShell.Cmdlets.Synapse.PropertyOrigin.Inlined)]
        public int? OptimizedAutoscaleMaximum { get => ((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IKustoPoolPropertiesInternal)Property).OptimizedAutoscaleMaximum; set => ((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IKustoPoolPropertiesInternal)Property).OptimizedAutoscaleMaximum = value ?? default(int); }

        /// <summary>Minimum allowed instances count.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Synapse.Origin(Microsoft.Azure.PowerShell.Cmdlets.Synapse.PropertyOrigin.Inlined)]
        public int? OptimizedAutoscaleMinimum { get => ((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IKustoPoolPropertiesInternal)Property).OptimizedAutoscaleMinimum; set => ((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IKustoPoolPropertiesInternal)Property).OptimizedAutoscaleMinimum = value ?? default(int); }

        /// <summary>The version of the template defined, for instance 1.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Synapse.Origin(Microsoft.Azure.PowerShell.Cmdlets.Synapse.PropertyOrigin.Inlined)]
        public int? OptimizedAutoscaleVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IKustoPoolPropertiesInternal)Property).OptimizedAutoscaleVersion; set => ((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IKustoPoolPropertiesInternal)Property).OptimizedAutoscaleVersion = value ?? default(int); }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IKustoPoolProperties _property;

        /// <summary>The kusto pool properties.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Synapse.Origin(Microsoft.Azure.PowerShell.Cmdlets.Synapse.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IKustoPoolProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.KustoPoolProperties()); set => this._property = value; }

        /// <summary>The provisioned state of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Synapse.Origin(Microsoft.Azure.PowerShell.Cmdlets.Synapse.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Synapse.Support.ResourceProvisioningState? ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IKustoPoolPropertiesInternal)Property).ProvisioningState; }

        /// <summary>Backing field for <see cref="Sku" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IAzureSku _sku;

        /// <summary>The SKU of the kusto pool.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Synapse.Origin(Microsoft.Azure.PowerShell.Cmdlets.Synapse.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IAzureSku Sku { get => (this._sku = this._sku ?? new Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.AzureSku()); set => this._sku = value; }

        /// <summary>The number of instances of the cluster.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Synapse.Origin(Microsoft.Azure.PowerShell.Cmdlets.Synapse.PropertyOrigin.Inlined)]
        public int? SkuCapacity { get => ((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IAzureSkuInternal)Sku).Capacity; set => ((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IAzureSkuInternal)Sku).Capacity = value ?? default(int); }

        /// <summary>SKU name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Synapse.Origin(Microsoft.Azure.PowerShell.Cmdlets.Synapse.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Synapse.Support.SkuName? SkuName { get => ((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IAzureSkuInternal)Sku).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IAzureSkuInternal)Sku).Name = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Support.SkuName)""); }

        /// <summary>SKU size.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Synapse.Origin(Microsoft.Azure.PowerShell.Cmdlets.Synapse.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Synapse.Support.SkuSize? SkuSize { get => ((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IAzureSkuInternal)Sku).Size; set => ((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IAzureSkuInternal)Sku).Size = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Support.SkuSize)""); }

        /// <summary>The state of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Synapse.Origin(Microsoft.Azure.PowerShell.Cmdlets.Synapse.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Synapse.Support.State? State { get => ((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IKustoPoolPropertiesInternal)Property).State; }

        /// <summary>The reason for the Kusto Pool's current state.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Synapse.Origin(Microsoft.Azure.PowerShell.Cmdlets.Synapse.PropertyOrigin.Inlined)]
        public string StateReason { get => ((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IKustoPoolPropertiesInternal)Property).StateReason; }

        /// <summary>Backing field for <see cref="Tag" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IKustoPoolUpdateTags _tag;

        /// <summary>Resource tags.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Synapse.Origin(Microsoft.Azure.PowerShell.Cmdlets.Synapse.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IKustoPoolUpdateTags Tag { get => (this._tag = this._tag ?? new Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.KustoPoolUpdateTags()); set => this._tag = value; }

        /// <summary>
        /// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Synapse.Origin(Microsoft.Azure.PowerShell.Cmdlets.Synapse.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api10.IResourceInternal)__resource).Type; }

        /// <summary>The Kusto Pool URI.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Synapse.Origin(Microsoft.Azure.PowerShell.Cmdlets.Synapse.PropertyOrigin.Inlined)]
        public string Uri { get => ((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IKustoPoolPropertiesInternal)Property).Uri; }

        /// <summary>The workspace unique identifier.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Synapse.Origin(Microsoft.Azure.PowerShell.Cmdlets.Synapse.PropertyOrigin.Inlined)]
        public string WorkspaceUid { get => ((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IKustoPoolPropertiesInternal)Property).WorkspaceUid; set => ((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IKustoPoolPropertiesInternal)Property).WorkspaceUid = value ?? null; }

        /// <summary>Creates an new <see cref="KustoPoolUpdate" /> instance.</summary>
        public KustoPoolUpdate()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Synapse.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A < see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.Synapse.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__resource), __resource);
            await eventListener.AssertObjectIsValid(nameof(__resource), __resource);
        }
    }
    /// Class representing an update to a Kusto kusto pool.
    public partial interface IKustoPoolUpdate :
        Microsoft.Azure.PowerShell.Cmdlets.Synapse.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api10.IResource
    {
        /// <summary>The Kusto Pool data ingestion URI.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Synapse.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The Kusto Pool data ingestion URI.",
        SerializedName = @"dataIngestionUri",
        PossibleTypes = new [] { typeof(string) })]
        string DataIngestionUri { get;  }
        /// <summary>A boolean value that indicates if the purge operations are enabled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Synapse.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"A boolean value that indicates if the purge operations are enabled.",
        SerializedName = @"enablePurge",
        PossibleTypes = new [] { typeof(bool) })]
        bool? EnablePurge { get; set; }
        /// <summary>A boolean value that indicates if the streaming ingest is enabled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Synapse.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"A boolean value that indicates if the streaming ingest is enabled.",
        SerializedName = @"enableStreamingIngest",
        PossibleTypes = new [] { typeof(bool) })]
        bool? EnableStreamingIngest { get; set; }
        /// <summary>The list of language extensions.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Synapse.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The list of language extensions.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.ILanguageExtension) })]
        Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.ILanguageExtension[] LanguageExtensionValue { get; set; }
        /// <summary>
        /// A boolean value that indicate if the optimized autoscale feature is enabled or not.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Synapse.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"A boolean value that indicate if the optimized autoscale feature is enabled or not.",
        SerializedName = @"isEnabled",
        PossibleTypes = new [] { typeof(bool) })]
        bool? OptimizedAutoscaleIsEnabled { get; set; }
        /// <summary>Maximum allowed instances count.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Synapse.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Maximum allowed instances count.",
        SerializedName = @"maximum",
        PossibleTypes = new [] { typeof(int) })]
        int? OptimizedAutoscaleMaximum { get; set; }
        /// <summary>Minimum allowed instances count.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Synapse.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Minimum allowed instances count.",
        SerializedName = @"minimum",
        PossibleTypes = new [] { typeof(int) })]
        int? OptimizedAutoscaleMinimum { get; set; }
        /// <summary>The version of the template defined, for instance 1.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Synapse.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The version of the template defined, for instance 1.",
        SerializedName = @"version",
        PossibleTypes = new [] { typeof(int) })]
        int? OptimizedAutoscaleVersion { get; set; }
        /// <summary>The provisioned state of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Synapse.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The provisioned state of the resource.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Synapse.Support.ResourceProvisioningState) })]
        Microsoft.Azure.PowerShell.Cmdlets.Synapse.Support.ResourceProvisioningState? ProvisioningState { get;  }
        /// <summary>The number of instances of the cluster.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Synapse.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The number of instances of the cluster.",
        SerializedName = @"capacity",
        PossibleTypes = new [] { typeof(int) })]
        int? SkuCapacity { get; set; }
        /// <summary>SKU name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Synapse.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"SKU name.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Synapse.Support.SkuName) })]
        Microsoft.Azure.PowerShell.Cmdlets.Synapse.Support.SkuName? SkuName { get; set; }
        /// <summary>SKU size.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Synapse.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"SKU size.",
        SerializedName = @"size",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Synapse.Support.SkuSize) })]
        Microsoft.Azure.PowerShell.Cmdlets.Synapse.Support.SkuSize? SkuSize { get; set; }
        /// <summary>The state of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Synapse.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The state of the resource.",
        SerializedName = @"state",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Synapse.Support.State) })]
        Microsoft.Azure.PowerShell.Cmdlets.Synapse.Support.State? State { get;  }
        /// <summary>The reason for the Kusto Pool's current state.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Synapse.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The reason for the Kusto Pool's current state.",
        SerializedName = @"stateReason",
        PossibleTypes = new [] { typeof(string) })]
        string StateReason { get;  }
        /// <summary>Resource tags.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Synapse.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Resource tags.",
        SerializedName = @"tags",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IKustoPoolUpdateTags) })]
        Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IKustoPoolUpdateTags Tag { get; set; }
        /// <summary>The Kusto Pool URI.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Synapse.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The Kusto Pool URI.",
        SerializedName = @"uri",
        PossibleTypes = new [] { typeof(string) })]
        string Uri { get;  }
        /// <summary>The workspace unique identifier.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Synapse.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The workspace unique identifier.",
        SerializedName = @"workspaceUID",
        PossibleTypes = new [] { typeof(string) })]
        string WorkspaceUid { get; set; }

    }
    /// Class representing an update to a Kusto kusto pool.
    internal partial interface IKustoPoolUpdateInternal :
        Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api10.IResourceInternal
    {
        /// <summary>The Kusto Pool data ingestion URI.</summary>
        string DataIngestionUri { get; set; }
        /// <summary>A boolean value that indicates if the purge operations are enabled.</summary>
        bool? EnablePurge { get; set; }
        /// <summary>A boolean value that indicates if the streaming ingest is enabled.</summary>
        bool? EnableStreamingIngest { get; set; }
        /// <summary>List of the Kusto Pool's language extensions.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.ILanguageExtensionsList LanguageExtension { get; set; }
        /// <summary>The list of language extensions.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.ILanguageExtension[] LanguageExtensionValue { get; set; }
        /// <summary>Optimized auto scale definition.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IOptimizedAutoscale OptimizedAutoscale { get; set; }
        /// <summary>
        /// A boolean value that indicate if the optimized autoscale feature is enabled or not.
        /// </summary>
        bool? OptimizedAutoscaleIsEnabled { get; set; }
        /// <summary>Maximum allowed instances count.</summary>
        int? OptimizedAutoscaleMaximum { get; set; }
        /// <summary>Minimum allowed instances count.</summary>
        int? OptimizedAutoscaleMinimum { get; set; }
        /// <summary>The version of the template defined, for instance 1.</summary>
        int? OptimizedAutoscaleVersion { get; set; }
        /// <summary>The kusto pool properties.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IKustoPoolProperties Property { get; set; }
        /// <summary>The provisioned state of the resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Synapse.Support.ResourceProvisioningState? ProvisioningState { get; set; }
        /// <summary>The SKU of the kusto pool.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IAzureSku Sku { get; set; }
        /// <summary>The number of instances of the cluster.</summary>
        int? SkuCapacity { get; set; }
        /// <summary>SKU name.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Synapse.Support.SkuName? SkuName { get; set; }
        /// <summary>SKU size.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Synapse.Support.SkuSize? SkuSize { get; set; }
        /// <summary>The state of the resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Synapse.Support.State? State { get; set; }
        /// <summary>The reason for the Kusto Pool's current state.</summary>
        string StateReason { get; set; }
        /// <summary>Resource tags.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IKustoPoolUpdateTags Tag { get; set; }
        /// <summary>The Kusto Pool URI.</summary>
        string Uri { get; set; }
        /// <summary>The workspace unique identifier.</summary>
        string WorkspaceUid { get; set; }

    }
}