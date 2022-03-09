namespace Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Extensions;

    /// <summary>Collection of static site functions.</summary>
    public partial class StaticSiteFunctionOverviewCollection :
        Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IStaticSiteFunctionOverviewCollection,
        Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IStaticSiteFunctionOverviewCollectionInternal
    {

        /// <summary>Internal Acessors for NextLink</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IStaticSiteFunctionOverviewCollectionInternal.NextLink { get => this._nextLink; set { {_nextLink = value;} } }

        /// <summary>Backing field for <see cref="NextLink" /> property.</summary>
        private string _nextLink;

        /// <summary>Link to next page of resources.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Websites.Origin(Microsoft.Azure.PowerShell.Cmdlets.Websites.PropertyOrigin.Owned)]
        public string NextLink { get => this._nextLink; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IStaticSiteFunctionOverviewArmResource[] _value;

        /// <summary>Collection of resources.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Websites.Origin(Microsoft.Azure.PowerShell.Cmdlets.Websites.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IStaticSiteFunctionOverviewArmResource[] Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="StaticSiteFunctionOverviewCollection" /> instance.</summary>
        public StaticSiteFunctionOverviewCollection()
        {

        }
    }
    /// Collection of static site functions.
    public partial interface IStaticSiteFunctionOverviewCollection :
        Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.IJsonSerializable
    {
        /// <summary>Link to next page of resources.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Link to next page of resources.",
        SerializedName = @"nextLink",
        PossibleTypes = new [] { typeof(string) })]
        string NextLink { get;  }
        /// <summary>Collection of resources.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Collection of resources.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IStaticSiteFunctionOverviewArmResource) })]
        Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IStaticSiteFunctionOverviewArmResource[] Value { get; set; }

    }
    /// Collection of static site functions.
    internal partial interface IStaticSiteFunctionOverviewCollectionInternal

    {
        /// <summary>Link to next page of resources.</summary>
        string NextLink { get; set; }
        /// <summary>Collection of resources.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IStaticSiteFunctionOverviewArmResource[] Value { get; set; }

    }
}