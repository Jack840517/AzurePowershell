// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201
{
    using static Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.Extensions;

    /// <summary>Administrative credentials for accessing vCenter and NSX-T</summary>
    public partial class AdminCredentials :
        Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.IAdminCredentials,
        Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.IAdminCredentialsInternal
    {

        /// <summary>Internal Acessors for NsxtPassword</summary>
        System.Security.SecureString Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.IAdminCredentialsInternal.NsxtPassword { get => this._nsxtPassword; set { {_nsxtPassword = value;} } }

        /// <summary>Internal Acessors for NsxtUsername</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.IAdminCredentialsInternal.NsxtUsername { get => this._nsxtUsername; set { {_nsxtUsername = value;} } }

        /// <summary>Internal Acessors for VcenterPassword</summary>
        System.Security.SecureString Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.IAdminCredentialsInternal.VcenterPassword { get => this._vcenterPassword; set { {_vcenterPassword = value;} } }

        /// <summary>Internal Acessors for VcenterUsername</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.IAdminCredentialsInternal.VcenterUsername { get => this._vcenterUsername; set { {_vcenterUsername = value;} } }

        /// <summary>Backing field for <see cref="NsxtPassword" /> property.</summary>
        private System.Security.SecureString _nsxtPassword;

        /// <summary>NSX-T Manager password</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMware.PropertyOrigin.Owned)]
        public System.Security.SecureString NsxtPassword { get => this._nsxtPassword; }

        /// <summary>Backing field for <see cref="NsxtUsername" /> property.</summary>
        private string _nsxtUsername;

        /// <summary>NSX-T Manager username</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMware.PropertyOrigin.Owned)]
        public string NsxtUsername { get => this._nsxtUsername; }

        /// <summary>Backing field for <see cref="VcenterPassword" /> property.</summary>
        private System.Security.SecureString _vcenterPassword;

        /// <summary>vCenter admin password</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMware.PropertyOrigin.Owned)]
        public System.Security.SecureString VcenterPassword { get => this._vcenterPassword; }

        /// <summary>Backing field for <see cref="VcenterUsername" /> property.</summary>
        private string _vcenterUsername;

        /// <summary>vCenter admin username</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMware.PropertyOrigin.Owned)]
        public string VcenterUsername { get => this._vcenterUsername; }

        /// <summary>Creates an new <see cref="AdminCredentials" /> instance.</summary>
        public AdminCredentials()
        {

        }
    }
    /// Administrative credentials for accessing vCenter and NSX-T
    public partial interface IAdminCredentials :
        Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.IJsonSerializable
    {
        /// <summary>NSX-T Manager password</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"NSX-T Manager password",
        SerializedName = @"nsxtPassword",
        PossibleTypes = new [] { typeof(System.Security.SecureString) })]
        System.Security.SecureString NsxtPassword { get;  }
        /// <summary>NSX-T Manager username</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"NSX-T Manager username",
        SerializedName = @"nsxtUsername",
        PossibleTypes = new [] { typeof(string) })]
        string NsxtUsername { get;  }
        /// <summary>vCenter admin password</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"vCenter admin password",
        SerializedName = @"vcenterPassword",
        PossibleTypes = new [] { typeof(System.Security.SecureString) })]
        System.Security.SecureString VcenterPassword { get;  }
        /// <summary>vCenter admin username</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"vCenter admin username",
        SerializedName = @"vcenterUsername",
        PossibleTypes = new [] { typeof(string) })]
        string VcenterUsername { get;  }

    }
    /// Administrative credentials for accessing vCenter and NSX-T
    internal partial interface IAdminCredentialsInternal

    {
        /// <summary>NSX-T Manager password</summary>
        System.Security.SecureString NsxtPassword { get; set; }
        /// <summary>NSX-T Manager username</summary>
        string NsxtUsername { get; set; }
        /// <summary>vCenter admin password</summary>
        System.Security.SecureString VcenterPassword { get; set; }
        /// <summary>vCenter admin username</summary>
        string VcenterUsername { get; set; }

    }
}