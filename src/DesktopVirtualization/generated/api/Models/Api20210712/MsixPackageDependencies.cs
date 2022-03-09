// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20210712
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Extensions;

    /// <summary>Schema for MSIX Package Dependencies properties.</summary>
    public partial class MsixPackageDependencies :
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20210712.IMsixPackageDependencies,
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20210712.IMsixPackageDependenciesInternal
    {

        /// <summary>Backing field for <see cref="DependencyName" /> property.</summary>
        private string _dependencyName;

        /// <summary>Name of package dependency.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.PropertyOrigin.Owned)]
        public string DependencyName { get => this._dependencyName; set => this._dependencyName = value; }

        /// <summary>Backing field for <see cref="MinVersion" /> property.</summary>
        private string _minVersion;

        /// <summary>Dependency version required.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.PropertyOrigin.Owned)]
        public string MinVersion { get => this._minVersion; set => this._minVersion = value; }

        /// <summary>Backing field for <see cref="Publisher" /> property.</summary>
        private string _publisher;

        /// <summary>Name of dependency publisher.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.PropertyOrigin.Owned)]
        public string Publisher { get => this._publisher; set => this._publisher = value; }

        /// <summary>Creates an new <see cref="MsixPackageDependencies" /> instance.</summary>
        public MsixPackageDependencies()
        {

        }
    }
    /// Schema for MSIX Package Dependencies properties.
    public partial interface IMsixPackageDependencies :
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.IJsonSerializable
    {
        /// <summary>Name of package dependency.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Name of package dependency.",
        SerializedName = @"dependencyName",
        PossibleTypes = new [] { typeof(string) })]
        string DependencyName { get; set; }
        /// <summary>Dependency version required.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Dependency version required.",
        SerializedName = @"minVersion",
        PossibleTypes = new [] { typeof(string) })]
        string MinVersion { get; set; }
        /// <summary>Name of dependency publisher.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Name of dependency publisher.",
        SerializedName = @"publisher",
        PossibleTypes = new [] { typeof(string) })]
        string Publisher { get; set; }

    }
    /// Schema for MSIX Package Dependencies properties.
    internal partial interface IMsixPackageDependenciesInternal

    {
        /// <summary>Name of package dependency.</summary>
        string DependencyName { get; set; }
        /// <summary>Dependency version required.</summary>
        string MinVersion { get; set; }
        /// <summary>Name of dependency publisher.</summary>
        string Publisher { get; set; }

    }
}