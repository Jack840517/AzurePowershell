// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201
{
    using static Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.Extensions;

    /// <summary>Represents order details.</summary>
    public partial class OrderProperties :
        Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IOrderProperties,
        Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IOrderPropertiesInternal
    {

        /// <summary>Backing field for <see cref="CurrentStage" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IStageDetails _currentStage;

        /// <summary>Order current status.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Origin(Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IStageDetails CurrentStage { get => (this._currentStage = this._currentStage ?? new Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.StageDetails()); }

        /// <summary>Display name of the resource stage.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Origin(Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.PropertyOrigin.Inlined)]
        public string CurrentStageDisplayName { get => ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IStageDetailsInternal)CurrentStage).DisplayName; }

        /// <summary>Stage name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Origin(Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Support.StageName? CurrentStageName { get => ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IStageDetailsInternal)CurrentStage).StageName; }

        /// <summary>Stage start time</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Origin(Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.PropertyOrigin.Inlined)]
        public global::System.DateTime? CurrentStageStartTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IStageDetailsInternal)CurrentStage).StartTime; }

        /// <summary>Stage status.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Origin(Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Support.StageStatus? CurrentStageStatus { get => ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IStageDetailsInternal)CurrentStage).StageStatus; }

        /// <summary>Internal Acessors for CurrentStage</summary>
        Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IStageDetails Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IOrderPropertiesInternal.CurrentStage { get => (this._currentStage = this._currentStage ?? new Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.StageDetails()); set { {_currentStage = value;} } }

        /// <summary>Internal Acessors for CurrentStageDisplayName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IOrderPropertiesInternal.CurrentStageDisplayName { get => ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IStageDetailsInternal)CurrentStage).DisplayName; set => ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IStageDetailsInternal)CurrentStage).DisplayName = value; }

        /// <summary>Internal Acessors for CurrentStageName</summary>
        Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Support.StageName? Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IOrderPropertiesInternal.CurrentStageName { get => ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IStageDetailsInternal)CurrentStage).StageName; set => ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IStageDetailsInternal)CurrentStage).StageName = value; }

        /// <summary>Internal Acessors for CurrentStageStartTime</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IOrderPropertiesInternal.CurrentStageStartTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IStageDetailsInternal)CurrentStage).StartTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IStageDetailsInternal)CurrentStage).StartTime = value; }

        /// <summary>Internal Acessors for CurrentStageStatus</summary>
        Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Support.StageStatus? Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IOrderPropertiesInternal.CurrentStageStatus { get => ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IStageDetailsInternal)CurrentStage).StageStatus; set => ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IStageDetailsInternal)CurrentStage).StageStatus = value; }

        /// <summary>Internal Acessors for OrderItemId</summary>
        string[] Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IOrderPropertiesInternal.OrderItemId { get => this._orderItemId; set { {_orderItemId = value;} } }

        /// <summary>Internal Acessors for OrderStageHistory</summary>
        Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IStageDetails[] Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IOrderPropertiesInternal.OrderStageHistory { get => this._orderStageHistory; set { {_orderStageHistory = value;} } }

        /// <summary>Backing field for <see cref="OrderItemId" /> property.</summary>
        private string[] _orderItemId;

        /// <summary>List of order item ARM Ids which are part of an order.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Origin(Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.PropertyOrigin.Owned)]
        public string[] OrderItemId { get => this._orderItemId; }

        /// <summary>Backing field for <see cref="OrderStageHistory" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IStageDetails[] _orderStageHistory;

        /// <summary>Order status history.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Origin(Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IStageDetails[] OrderStageHistory { get => this._orderStageHistory; }

        /// <summary>Creates an new <see cref="OrderProperties" /> instance.</summary>
        public OrderProperties()
        {

        }
    }
    /// Represents order details.
    public partial interface IOrderProperties :
        Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.IJsonSerializable
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

    }
    /// Represents order details.
    internal partial interface IOrderPropertiesInternal

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

    }
}