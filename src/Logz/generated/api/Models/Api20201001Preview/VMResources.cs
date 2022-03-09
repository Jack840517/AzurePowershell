// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Logz.Runtime.Extensions;

    /// <summary>VM Resource Ids</summary>
    public partial class VMResources :
        Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview.IVMResources,
        Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.Api20201001Preview.IVMResourcesInternal
    {

        /// <summary>Backing field for <see cref="AgentVersion" /> property.</summary>
        private string _agentVersion;

        /// <summary>Version of the Logz agent installed on the VM.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Logz.Origin(Microsoft.Azure.PowerShell.Cmdlets.Logz.PropertyOrigin.Owned)]
        [Microsoft.Azure.PowerShell.Cmdlets.Logz.DoNotFormat]
        public string AgentVersion { get => this._agentVersion; set => this._agentVersion = value; }

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        /// <summary>Request of a list vm host update operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Logz.Origin(Microsoft.Azure.PowerShell.Cmdlets.Logz.PropertyOrigin.Owned)]
        [Microsoft.Azure.PowerShell.Cmdlets.Logz.FormatTable(Index = 0)]
        public string Id { get => this._id; set => this._id = value; }

        /// <summary>Creates an new <see cref="VMResources" /> instance.</summary>
        public VMResources()
        {

        }
    }
    /// VM Resource Ids
    public partial interface IVMResources :
        Microsoft.Azure.PowerShell.Cmdlets.Logz.Runtime.IJsonSerializable
    {
        /// <summary>Version of the Logz agent installed on the VM.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Logz.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Version of the Logz agent installed on the VM.",
        SerializedName = @"agentVersion",
        PossibleTypes = new [] { typeof(string) })]
        string AgentVersion { get; set; }
        /// <summary>Request of a list vm host update operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Logz.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Request of a list vm host update operation.",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string Id { get; set; }

    }
    /// VM Resource Ids
    internal partial interface IVMResourcesInternal

    {
        /// <summary>Version of the Logz agent installed on the VM.</summary>
        string AgentVersion { get; set; }
        /// <summary>Request of a list vm host update operation.</summary>
        string Id { get; set; }

    }
}