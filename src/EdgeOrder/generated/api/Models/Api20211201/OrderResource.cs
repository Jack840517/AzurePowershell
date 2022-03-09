// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201
{
    using static Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.Extensions;

    /// <summary>
    /// Specifies the properties or parameters for an order. Order is a grouping of one or more order items.
    /// </summary>
    public partial class OrderResource :
        Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IOrderResource,
        Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IOrderResourceInternal,
        Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20.IResource" />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20.IResource __resource = new Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20.Resource();

        /// <summary>Display name of the resource stage.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Origin(Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.PropertyOrigin.Inlined)]
        public string CurrentStageDisplayName { get => ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IOrderPropertiesInternal)Property).CurrentStageDisplayName; }

        /// <summary>Stage name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Origin(Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Support.StageName? CurrentStageName { get => ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IOrderPropertiesInternal)Property).CurrentStageName; }

        /// <summary>Stage start time</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Origin(Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.PropertyOrigin.Inlined)]
        public global::System.DateTime? CurrentStageStartTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IOrderPropertiesInternal)Property).CurrentStageStartTime; }

        /// <summary>Stage status.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Origin(Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Support.StageStatus? CurrentStageStatus { get => ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IOrderPropertiesInternal)Property).CurrentStageStatus; }

        /// <summary>
        /// Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Origin(Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20.IResourceInternal)__resource).Id; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20.IResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20.IResourceInternal)__resource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20.IResourceInternal)__resource).Id = value; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20.IResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20.IResourceInternal)__resource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20.IResourceInternal)__resource).Name = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20.IResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20.IResourceInternal)__resource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20.IResourceInternal)__resource).Type = value; }

        /// <summary>Internal Acessors for CurrentStage</summary>
        Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IStageDetails Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IOrderResourceInternal.CurrentStage { get => ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IOrderPropertiesInternal)Property).CurrentStage; set => ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IOrderPropertiesInternal)Property).CurrentStage = value; }

        /// <summary>Internal Acessors for CurrentStageDisplayName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IOrderResourceInternal.CurrentStageDisplayName { get => ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IOrderPropertiesInternal)Property).CurrentStageDisplayName; set => ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IOrderPropertiesInternal)Property).CurrentStageDisplayName = value; }

        /// <summary>Internal Acessors for CurrentStageName</summary>
        Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Support.StageName? Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IOrderResourceInternal.CurrentStageName { get => ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IOrderPropertiesInternal)Property).CurrentStageName; set => ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IOrderPropertiesInternal)Property).CurrentStageName = value; }

        /// <summary>Internal Acessors for CurrentStageStartTime</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IOrderResourceInternal.CurrentStageStartTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IOrderPropertiesInternal)Property).CurrentStageStartTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IOrderPropertiesInternal)Property).CurrentStageStartTime = value; }

        /// <summary>Internal Acessors for CurrentStageStatus</summary>
        Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Support.StageStatus? Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IOrderResourceInternal.CurrentStageStatus { get => ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IOrderPropertiesInternal)Property).CurrentStageStatus; set => ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IOrderPropertiesInternal)Property).CurrentStageStatus = value; }

        /// <summary>Internal Acessors for OrderItemId</summary>
        string[] Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IOrderResourceInternal.OrderItemId { get => ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IOrderPropertiesInternal)Property).OrderItemId; set => ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IOrderPropertiesInternal)Property).OrderItemId = value; }

        /// <summary>Internal Acessors for OrderStageHistory</summary>
        Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IStageDetails[] Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IOrderResourceInternal.OrderStageHistory { get => ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IOrderPropertiesInternal)Property).OrderStageHistory; set => ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IOrderPropertiesInternal)Property).OrderStageHistory = value; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IOrderProperties Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IOrderResourceInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.OrderProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for SystemData</summary>
        Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20.ISystemData Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IOrderResourceInternal.SystemData { get => (this._systemData = this._systemData ?? new Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20.SystemData()); set { {_systemData = value;} } }

        /// <summary>The name of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Origin(Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20.IResourceInternal)__resource).Name; }

        /// <summary>List of order item ARM Ids which are part of an order.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Origin(Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.PropertyOrigin.Inlined)]
        public string[] OrderItemId { get => ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IOrderPropertiesInternal)Property).OrderItemId; }

        /// <summary>Order status history.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Origin(Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IStageDetails[] OrderStageHistory { get => ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IOrderPropertiesInternal)Property).OrderStageHistory; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IOrderProperties _property;

        /// <summary>Order properties</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Origin(Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IOrderProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.OrderProperties()); set => this._property = value; }

        /// <summary>Backing field for <see cref="SystemData" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20.ISystemData _systemData;

        /// <summary>Represents resource creation and update time</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Origin(Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20.ISystemData SystemData { get => (this._systemData = this._systemData ?? new Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20.SystemData()); }

        /// <summary>
        /// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Origin(Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20.IResourceInternal)__resource).Type; }

        /// <summary>Creates an new <see cref="OrderResource" /> instance.</summary>
        public OrderResource()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A < see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__resource), __resource);
            await eventListener.AssertObjectIsValid(nameof(__resource), __resource);
        }
    }
    /// Specifies the properties or parameters for an order. Order is a grouping of one or more order items.
    public partial interface IOrderResource :
        Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20.IResource
    {
        /// <summary>Display name of the resource stage.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Display name of the resource stage.",
        SerializedName = @"displayName",
        PossibleTypes = new [] { typeof(string) })]
        string CurrentStageDisplayName { get;  }
        /// <summary>Stage name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Stage name",
        SerializedName = @"stageName",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Support.StageName) })]
        Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Support.StageName? CurrentStageName { get;  }
        /// <summary>Stage start time</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Stage start time",
        SerializedName = @"startTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? CurrentStageStartTime { get;  }
        /// <summary>Stage status.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Stage status.",
        SerializedName = @"stageStatus",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Support.StageStatus) })]
        Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Support.StageStatus? CurrentStageStatus { get;  }
        /// <summary>List of order item ARM Ids which are part of an order.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"List of order item ARM Ids which are part of an order.",
        SerializedName = @"orderItemIds",
        PossibleTypes = new [] { typeof(string) })]
        string[] OrderItemId { get;  }
        /// <summary>Order status history.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Order status history.",
        SerializedName = @"orderStageHistory",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IStageDetails) })]
        Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IStageDetails[] OrderStageHistory { get;  }
        /// <summary>Represents resource creation and update time</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Represents resource creation and update time",
        SerializedName = @"systemData",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20.ISystemData) })]
        Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20.ISystemData SystemData { get;  }

    }
    /// Specifies the properties or parameters for an order. Order is a grouping of one or more order items.
    internal partial interface IOrderResourceInternal :
        Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20.IResourceInternal
    {
        /// <summary>Order current status.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IStageDetails CurrentStage { get; set; }
        /// <summary>Display name of the resource stage.</summary>
        string CurrentStageDisplayName { get; set; }
        /// <summary>Stage name</summary>
        Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Support.StageName? CurrentStageName { get; set; }
        /// <summary>Stage start time</summary>
        global::System.DateTime? CurrentStageStartTime { get; set; }
        /// <summary>Stage status.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Support.StageStatus? CurrentStageStatus { get; set; }
        /// <summary>List of order item ARM Ids which are part of an order.</summary>
        string[] OrderItemId { get; set; }
        /// <summary>Order status history.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IStageDetails[] OrderStageHistory { get; set; }
        /// <summary>Order properties</summary>
        Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IOrderProperties Property { get; set; }
        /// <summary>Represents resource creation and update time</summary>
        Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20.ISystemData SystemData { get; set; }

    }
}