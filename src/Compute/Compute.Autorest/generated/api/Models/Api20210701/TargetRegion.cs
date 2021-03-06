// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.Extensions;

    /// <summary>Describes the target region information.</summary>
    public partial class TargetRegion :
        Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.ITargetRegion,
        Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.ITargetRegionInternal
    {

        /// <summary>Backing field for <see cref="Encryption" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IEncryptionImages _encryption;

        /// <summary>
        /// Optional. Allows users to provide customer managed keys for encrypting the OS and data disks in the gallery artifact.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Compute.Origin(Microsoft.Azure.PowerShell.Cmdlets.Compute.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IEncryptionImages Encryption { get => (this._encryption = this._encryption ?? new Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.EncryptionImages()); set => this._encryption = value; }

        /// <summary>A list of encryption specifications for data disk images.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Compute.Origin(Microsoft.Azure.PowerShell.Cmdlets.Compute.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IDataDiskImageEncryption[] EncryptionDataDiskImage { get => ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IEncryptionImagesInternal)Encryption).DataDiskImage; set => ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IEncryptionImagesInternal)Encryption).DataDiskImage = value ?? null /* arrayOf */; }

        /// <summary>Internal Acessors for Encryption</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IEncryptionImages Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.ITargetRegionInternal.Encryption { get => (this._encryption = this._encryption ?? new Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.EncryptionImages()); set { {_encryption = value;} } }

        /// <summary>Internal Acessors for EncryptionOSDiskImage</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IDiskImageEncryption Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.ITargetRegionInternal.EncryptionOSDiskImage { get => ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IEncryptionImagesInternal)Encryption).OSDiskImage; set => ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IEncryptionImagesInternal)Encryption).OSDiskImage = value; }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>The name of the region.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Compute.Origin(Microsoft.Azure.PowerShell.Cmdlets.Compute.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>A relative URI containing the resource ID of the disk encryption set.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Compute.Origin(Microsoft.Azure.PowerShell.Cmdlets.Compute.PropertyOrigin.Inlined)]
        public string OSDiskImageDiskEncryptionSetId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IEncryptionImagesInternal)Encryption).OSDiskImageDiskEncryptionSetId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IEncryptionImagesInternal)Encryption).OSDiskImageDiskEncryptionSetId = value ?? null; }

        /// <summary>Backing field for <see cref="RegionalReplicaCount" /> property.</summary>
        private int? _regionalReplicaCount;

        /// <summary>
        /// The number of replicas of the Image Version to be created per region. This property is updatable.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Compute.Origin(Microsoft.Azure.PowerShell.Cmdlets.Compute.PropertyOrigin.Owned)]
        public int? RegionalReplicaCount { get => this._regionalReplicaCount; set => this._regionalReplicaCount = value; }

        /// <summary>Backing field for <see cref="StorageAccountType" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Compute.Support.StorageAccountType? _storageAccountType;

        /// <summary>
        /// Specifies the storage account type to be used to store the image. This property is not updatable.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Compute.Origin(Microsoft.Azure.PowerShell.Cmdlets.Compute.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Compute.Support.StorageAccountType? StorageAccountType { get => this._storageAccountType; set => this._storageAccountType = value; }

        /// <summary>Creates an new <see cref="TargetRegion" /> instance.</summary>
        public TargetRegion()
        {

        }
    }
    /// Describes the target region information.
    public partial interface ITargetRegion :
        Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.IJsonSerializable
    {
        /// <summary>A list of encryption specifications for data disk images.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"A list of encryption specifications for data disk images.",
        SerializedName = @"dataDiskImages",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IDataDiskImageEncryption) })]
        Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IDataDiskImageEncryption[] EncryptionDataDiskImage { get; set; }
        /// <summary>The name of the region.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The name of the region.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }
        /// <summary>A relative URI containing the resource ID of the disk encryption set.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"A relative URI containing the resource ID of the disk encryption set.",
        SerializedName = @"diskEncryptionSetId",
        PossibleTypes = new [] { typeof(string) })]
        string OSDiskImageDiskEncryptionSetId { get; set; }
        /// <summary>
        /// The number of replicas of the Image Version to be created per region. This property is updatable.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The number of replicas of the Image Version to be created per region. This property is updatable.",
        SerializedName = @"regionalReplicaCount",
        PossibleTypes = new [] { typeof(int) })]
        int? RegionalReplicaCount { get; set; }
        /// <summary>
        /// Specifies the storage account type to be used to store the image. This property is not updatable.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Specifies the storage account type to be used to store the image. This property is not updatable.",
        SerializedName = @"storageAccountType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Compute.Support.StorageAccountType) })]
        Microsoft.Azure.PowerShell.Cmdlets.Compute.Support.StorageAccountType? StorageAccountType { get; set; }

    }
    /// Describes the target region information.
    internal partial interface ITargetRegionInternal

    {
        /// <summary>
        /// Optional. Allows users to provide customer managed keys for encrypting the OS and data disks in the gallery artifact.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IEncryptionImages Encryption { get; set; }
        /// <summary>A list of encryption specifications for data disk images.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IDataDiskImageEncryption[] EncryptionDataDiskImage { get; set; }
        /// <summary>This is the disk image encryption base class.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IDiskImageEncryption EncryptionOSDiskImage { get; set; }
        /// <summary>The name of the region.</summary>
        string Name { get; set; }
        /// <summary>A relative URI containing the resource ID of the disk encryption set.</summary>
        string OSDiskImageDiskEncryptionSetId { get; set; }
        /// <summary>
        /// The number of replicas of the Image Version to be created per region. This property is updatable.
        /// </summary>
        int? RegionalReplicaCount { get; set; }
        /// <summary>
        /// Specifies the storage account type to be used to store the image. This property is not updatable.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.Compute.Support.StorageAccountType? StorageAccountType { get; set; }

    }
}