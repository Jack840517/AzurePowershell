// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20210901
{
    using static Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Runtime.Extensions;

    /// <summary>Scope of the extension. It can be either Cluster or Namespace; but not both.</summary>
    public partial class Scope :
        Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20210901.IScope,
        Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20210901.IScopeInternal
    {

        /// <summary>Backing field for <see cref="Cluster" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20210901.IScopeCluster _cluster;

        /// <summary>Specifies that the scope of the extension is Cluster</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20210901.IScopeCluster Cluster { get => (this._cluster = this._cluster ?? new Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20210901.ScopeCluster()); set => this._cluster = value; }

        /// <summary>
        /// Namespace where the extension Release must be placed, for a Cluster scoped extension. If this namespace does not exist,
        /// it will be created
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.PropertyOrigin.Inlined)]
        public string ClusterReleaseNamespace { get => ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20210901.IScopeClusterInternal)Cluster).ReleaseNamespace; set => ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20210901.IScopeClusterInternal)Cluster).ReleaseNamespace = value ?? null; }

        /// <summary>Internal Acessors for Cluster</summary>
        Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20210901.IScopeCluster Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20210901.IScopeInternal.Cluster { get => (this._cluster = this._cluster ?? new Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20210901.ScopeCluster()); set { {_cluster = value;} } }

        /// <summary>Internal Acessors for Namespace</summary>
        Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20210901.IScopeNamespace Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20210901.IScopeInternal.Namespace { get => (this._namespace = this._namespace ?? new Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20210901.ScopeNamespace()); set { {_namespace = value;} } }

        /// <summary>Backing field for <see cref="Namespace" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20210901.IScopeNamespace _namespace;

        /// <summary>Specifies that the scope of the extension is Namespace</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20210901.IScopeNamespace Namespace { get => (this._namespace = this._namespace ?? new Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20210901.ScopeNamespace()); set => this._namespace = value; }

        /// <summary>
        /// Namespace where the extension will be created for an Namespace scoped extension. If this namespace does not exist, it
        /// will be created
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.PropertyOrigin.Inlined)]
        public string NamespaceTargetNamespace { get => ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20210901.IScopeNamespaceInternal)Namespace).TargetNamespace; set => ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20210901.IScopeNamespaceInternal)Namespace).TargetNamespace = value ?? null; }

        /// <summary>Creates an new <see cref="Scope" /> instance.</summary>
        public Scope()
        {

        }
    }
    /// Scope of the extension. It can be either Cluster or Namespace; but not both.
    public partial interface IScope :
        Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Runtime.IJsonSerializable
    {
        /// <summary>
        /// Namespace where the extension Release must be placed, for a Cluster scoped extension. If this namespace does not exist,
        /// it will be created
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Namespace where the extension Release must be placed, for a Cluster scoped extension.  If this namespace does not exist, it will be created",
        SerializedName = @"releaseNamespace",
        PossibleTypes = new [] { typeof(string) })]
        string ClusterReleaseNamespace { get; set; }
        /// <summary>
        /// Namespace where the extension will be created for an Namespace scoped extension. If this namespace does not exist, it
        /// will be created
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Namespace where the extension will be created for an Namespace scoped extension.  If this namespace does not exist, it will be created",
        SerializedName = @"targetNamespace",
        PossibleTypes = new [] { typeof(string) })]
        string NamespaceTargetNamespace { get; set; }

    }
    /// Scope of the extension. It can be either Cluster or Namespace; but not both.
    internal partial interface IScopeInternal

    {
        /// <summary>Specifies that the scope of the extension is Cluster</summary>
        Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20210901.IScopeCluster Cluster { get; set; }
        /// <summary>
        /// Namespace where the extension Release must be placed, for a Cluster scoped extension. If this namespace does not exist,
        /// it will be created
        /// </summary>
        string ClusterReleaseNamespace { get; set; }
        /// <summary>Specifies that the scope of the extension is Namespace</summary>
        Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20210901.IScopeNamespace Namespace { get; set; }
        /// <summary>
        /// Namespace where the extension will be created for an Namespace scoped extension. If this namespace does not exist, it
        /// will be created
        /// </summary>
        string NamespaceTargetNamespace { get; set; }

    }
}