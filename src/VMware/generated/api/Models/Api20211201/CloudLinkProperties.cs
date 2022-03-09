// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201
{
    using static Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.Extensions;

    /// <summary>The properties of a cloud link.</summary>
    public partial class CloudLinkProperties :
        Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.ICloudLinkProperties,
        Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.ICloudLinkPropertiesInternal
    {

        /// <summary>Backing field for <see cref="LinkedCloud" /> property.</summary>
        private string _linkedCloud;

        /// <summary>Identifier of the other private cloud participating in the link.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMware.PropertyOrigin.Owned)]
        public string LinkedCloud { get => this._linkedCloud; set => this._linkedCloud = value; }

        /// <summary>Internal Acessors for Status</summary>
        Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.CloudLinkStatus? Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.ICloudLinkPropertiesInternal.Status { get => this._status; set { {_status = value;} } }

        /// <summary>Backing field for <see cref="Status" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.CloudLinkStatus? _status;

        /// <summary>The state of the cloud link.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMware.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.CloudLinkStatus? Status { get => this._status; }

        /// <summary>Creates an new <see cref="CloudLinkProperties" /> instance.</summary>
        public CloudLinkProperties()
        {

        }
    }
    /// The properties of a cloud link.
    public partial interface ICloudLinkProperties :
        Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.IJsonSerializable
    {
        /// <summary>Identifier of the other private cloud participating in the link.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Identifier of the other private cloud participating in the link.",
        SerializedName = @"linkedCloud",
        PossibleTypes = new [] { typeof(string) })]
        string LinkedCloud { get; set; }
        /// <summary>The state of the cloud link.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The state of the cloud link.",
        SerializedName = @"status",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.CloudLinkStatus) })]
        Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.CloudLinkStatus? Status { get;  }

    }
    /// The properties of a cloud link.
    internal partial interface ICloudLinkPropertiesInternal

    {
        /// <summary>Identifier of the other private cloud participating in the link.</summary>
        string LinkedCloud { get; set; }
        /// <summary>The state of the cloud link.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.CloudLinkStatus? Status { get; set; }

    }
}