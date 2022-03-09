namespace Microsoft.Azure.PowerShell.Cmdlets.Maps.Models.Api20210201
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Maps.Runtime.Extensions;

    /// <summary>Metric specification of operation.</summary>
    public partial class MetricSpecification :
        Microsoft.Azure.PowerShell.Cmdlets.Maps.Models.Api20210201.IMetricSpecification,
        Microsoft.Azure.PowerShell.Cmdlets.Maps.Models.Api20210201.IMetricSpecificationInternal
    {

        /// <summary>Backing field for <see cref="AggregationType" /> property.</summary>
        private string _aggregationType;

        /// <summary>Aggregation type could be Average.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Maps.Origin(Microsoft.Azure.PowerShell.Cmdlets.Maps.PropertyOrigin.Owned)]
        public string AggregationType { get => this._aggregationType; set => this._aggregationType = value; }

        /// <summary>Backing field for <see cref="Category" /> property.</summary>
        private string _category;

        /// <summary>The category this metric specification belong to, could be Capacity.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Maps.Origin(Microsoft.Azure.PowerShell.Cmdlets.Maps.PropertyOrigin.Owned)]
        public string Category { get => this._category; set => this._category = value; }

        /// <summary>Backing field for <see cref="Dimension" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Maps.Models.Api20210201.IDimension[] _dimension;

        /// <summary>Dimensions of map account.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Maps.Origin(Microsoft.Azure.PowerShell.Cmdlets.Maps.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Maps.Models.Api20210201.IDimension[] Dimension { get => this._dimension; set => this._dimension = value; }

        /// <summary>Backing field for <see cref="DisplayDescription" /> property.</summary>
        private string _displayDescription;

        /// <summary>Display description of metric specification.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Maps.Origin(Microsoft.Azure.PowerShell.Cmdlets.Maps.PropertyOrigin.Owned)]
        public string DisplayDescription { get => this._displayDescription; set => this._displayDescription = value; }

        /// <summary>Backing field for <see cref="DisplayName" /> property.</summary>
        private string _displayName;

        /// <summary>Display name of metric specification.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Maps.Origin(Microsoft.Azure.PowerShell.Cmdlets.Maps.PropertyOrigin.Owned)]
        public string DisplayName { get => this._displayName; set => this._displayName = value; }

        /// <summary>Backing field for <see cref="FillGapWithZero" /> property.</summary>
        private bool? _fillGapWithZero;

        /// <summary>The property to decide fill gap with zero or not.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Maps.Origin(Microsoft.Azure.PowerShell.Cmdlets.Maps.PropertyOrigin.Owned)]
        public bool? FillGapWithZero { get => this._fillGapWithZero; set => this._fillGapWithZero = value; }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>Name of metric specification.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Maps.Origin(Microsoft.Azure.PowerShell.Cmdlets.Maps.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Backing field for <see cref="ResourceIdDimensionNameOverride" /> property.</summary>
        private string _resourceIdDimensionNameOverride;

        /// <summary>Account Resource Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Maps.Origin(Microsoft.Azure.PowerShell.Cmdlets.Maps.PropertyOrigin.Owned)]
        public string ResourceIdDimensionNameOverride { get => this._resourceIdDimensionNameOverride; set => this._resourceIdDimensionNameOverride = value; }

        /// <summary>Backing field for <see cref="Unit" /> property.</summary>
        private string _unit;

        /// <summary>Unit could be Count.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Maps.Origin(Microsoft.Azure.PowerShell.Cmdlets.Maps.PropertyOrigin.Owned)]
        public string Unit { get => this._unit; set => this._unit = value; }

        /// <summary>Creates an new <see cref="MetricSpecification" /> instance.</summary>
        public MetricSpecification()
        {

        }
    }
    /// Metric specification of operation.
    public partial interface IMetricSpecification :
        Microsoft.Azure.PowerShell.Cmdlets.Maps.Runtime.IJsonSerializable
    {
        /// <summary>Aggregation type could be Average.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Maps.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Aggregation type could be Average.",
        SerializedName = @"aggregationType",
        PossibleTypes = new [] { typeof(string) })]
        string AggregationType { get; set; }
        /// <summary>The category this metric specification belong to, could be Capacity.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Maps.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The category this metric specification belong to, could be Capacity.",
        SerializedName = @"category",
        PossibleTypes = new [] { typeof(string) })]
        string Category { get; set; }
        /// <summary>Dimensions of map account.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Maps.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Dimensions of map account.",
        SerializedName = @"dimensions",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Maps.Models.Api20210201.IDimension) })]
        Microsoft.Azure.PowerShell.Cmdlets.Maps.Models.Api20210201.IDimension[] Dimension { get; set; }
        /// <summary>Display description of metric specification.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Maps.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Display description of metric specification.",
        SerializedName = @"displayDescription",
        PossibleTypes = new [] { typeof(string) })]
        string DisplayDescription { get; set; }
        /// <summary>Display name of metric specification.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Maps.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Display name of metric specification.",
        SerializedName = @"displayName",
        PossibleTypes = new [] { typeof(string) })]
        string DisplayName { get; set; }
        /// <summary>The property to decide fill gap with zero or not.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Maps.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The property to decide fill gap with zero or not.",
        SerializedName = @"fillGapWithZero",
        PossibleTypes = new [] { typeof(bool) })]
        bool? FillGapWithZero { get; set; }
        /// <summary>Name of metric specification.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Maps.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Name of metric specification.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }
        /// <summary>Account Resource Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Maps.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Account Resource Id.",
        SerializedName = @"resourceIdDimensionNameOverride",
        PossibleTypes = new [] { typeof(string) })]
        string ResourceIdDimensionNameOverride { get; set; }
        /// <summary>Unit could be Count.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Maps.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Unit could be Count.",
        SerializedName = @"unit",
        PossibleTypes = new [] { typeof(string) })]
        string Unit { get; set; }

    }
    /// Metric specification of operation.
    internal partial interface IMetricSpecificationInternal

    {
        /// <summary>Aggregation type could be Average.</summary>
        string AggregationType { get; set; }
        /// <summary>The category this metric specification belong to, could be Capacity.</summary>
        string Category { get; set; }
        /// <summary>Dimensions of map account.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Maps.Models.Api20210201.IDimension[] Dimension { get; set; }
        /// <summary>Display description of metric specification.</summary>
        string DisplayDescription { get; set; }
        /// <summary>Display name of metric specification.</summary>
        string DisplayName { get; set; }
        /// <summary>The property to decide fill gap with zero or not.</summary>
        bool? FillGapWithZero { get; set; }
        /// <summary>Name of metric specification.</summary>
        string Name { get; set; }
        /// <summary>Account Resource Id.</summary>
        string ResourceIdDimensionNameOverride { get; set; }
        /// <summary>Unit could be Count.</summary>
        string Unit { get; set; }

    }
}