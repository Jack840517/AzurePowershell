//
// Copyright (c) Microsoft and contributors.  All rights reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//
// See the License for the specific language governing permissions and
// limitations under the License.
//

// Warning: This code was generated by a tool.
//
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using AutoMapper;
using FROM = Microsoft.Azure.Management.Compute.Models;
using TO = Microsoft.Azure.Commands.Compute.Automation.Models;

namespace Microsoft.Azure.Commands.Compute.Automation.Models
{
    public class ComputeAutomationAutoMapperProfile : AutoMapper.Profile
    {
        private static IMapper _mapper = null;

        private static readonly object _lock = new object();

        public static IMapper Mapper
        {
            get
            {
                lock(_lock)
                {
                    if (_mapper == null)
                    {
                        Initialize();
                    }

                    return _mapper;
                }
            }
        }

        public override string ProfileName
        {
            get { return "ComputeAutomationAutoMapperProfile"; }
        }

        private static void Initialize()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<FROM.DedicatedHostGroup, TO.PSHostGroupList>();
                cfg.CreateMap<TO.PSHostGroupList, TO.PSHostGroup>();
                cfg.CreateMap<TO.PSHostGroup, TO.PSHostGroupList>();
                cfg.CreateMap<FROM.DedicatedHost, TO.PSHostList>();
                cfg.CreateMap<TO.PSHostList, TO.PSHost>();
                cfg.CreateMap<TO.PSHost, TO.PSHostList>();
                cfg.CreateMap<FROM.DiskEncryptionSet, TO.PSDiskEncryptionSetList>();
                cfg.CreateMap<TO.PSDiskEncryptionSetList, TO.PSDiskEncryptionSet>();
                cfg.CreateMap<TO.PSDiskEncryptionSet, TO.PSDiskEncryptionSetList>();
                cfg.CreateMap<FROM.Disk, TO.PSDiskList>()
                    .ForMember(c => c.Zones, o => o.Condition(r => (r.Zones != null)));
                cfg.CreateMap<TO.PSDiskList, TO.PSDisk>()
                    .ForMember(c => c.Zones, o => o.Condition(r => (r.Zones != null)));
                cfg.CreateMap<TO.PSDisk, TO.PSDiskList>()
                    .ForMember(c => c.Zones, o => o.Condition(r => (r.Zones != null)));
                cfg.CreateMap<FROM.Gallery, TO.PSGalleryList>();
                cfg.CreateMap<TO.PSGalleryList, TO.PSGallery>();
                cfg.CreateMap<TO.PSGallery, TO.PSGalleryList>();
                cfg.CreateMap<FROM.GalleryImage, TO.PSGalleryImageList>();
                cfg.CreateMap<TO.PSGalleryImageList, TO.PSGalleryImage>();
                cfg.CreateMap<TO.PSGalleryImage, TO.PSGalleryImageList>();
                cfg.CreateMap<FROM.GalleryImageVersion, TO.PSGalleryImageVersionList>();
                cfg.CreateMap<TO.PSGalleryImageVersionList, TO.PSGalleryImageVersion>();
                cfg.CreateMap<TO.PSGalleryImageVersion, TO.PSGalleryImageVersionList>();
                cfg.CreateMap<FROM.Image, TO.PSImageList>();
                cfg.CreateMap<TO.PSImageList, TO.PSImage>();
                cfg.CreateMap<TO.PSImage, TO.PSImageList>();
                cfg.CreateMap<FROM.ProximityPlacementGroup, TO.PSProximityPlacementGroupList>();
                cfg.CreateMap<TO.PSProximityPlacementGroupList, TO.PSProximityPlacementGroup>();
                cfg.CreateMap<TO.PSProximityPlacementGroup, TO.PSProximityPlacementGroupList>();
                cfg.CreateMap<FROM.Snapshot, TO.PSSnapshotList>();
                cfg.CreateMap<TO.PSSnapshotList, TO.PSSnapshot>();
                cfg.CreateMap<TO.PSSnapshot, TO.PSSnapshotList>();
                cfg.CreateMap<FROM.VirtualMachineScaleSet, TO.PSVirtualMachineScaleSetList>()
                    .ForMember(c => c.Zones, o => o.Condition(r => (r.Zones != null)));
                cfg.CreateMap<TO.PSVirtualMachineScaleSetList, TO.PSVirtualMachineScaleSet>()
                    .ForMember(c => c.Zones, o => o.Condition(r => (r.Zones != null)));
                cfg.CreateMap<TO.PSVirtualMachineScaleSet, TO.PSVirtualMachineScaleSetList>()
                    .ForMember(c => c.Zones, o => o.Condition(r => (r.Zones != null)));
                cfg.CreateMap<FROM.VirtualMachineScaleSetVM, TO.PSVirtualMachineScaleSetVMList>();
                cfg.CreateMap<TO.PSVirtualMachineScaleSetVMList, TO.PSVirtualMachineScaleSetVM>();
                cfg.CreateMap<TO.PSVirtualMachineScaleSetVM, TO.PSVirtualMachineScaleSetVMList>();
                cfg.CreateMap<FROM.Disk, FROM.DiskUpdate>();
                cfg.CreateMap<FROM.DiskUpdate, FROM.Disk>();
                cfg.CreateMap<FROM.DiskUpdate, TO.PSDiskUpdate>();
                cfg.CreateMap<TO.PSDiskUpdate, FROM.DiskUpdate>();
                cfg.CreateMap<FROM.Snapshot, FROM.SnapshotUpdate>();
                cfg.CreateMap<FROM.SnapshotUpdate, FROM.Snapshot>();
                cfg.CreateMap<FROM.SnapshotUpdate, TO.PSSnapshotUpdate>();
                cfg.CreateMap<TO.PSSnapshotUpdate, FROM.SnapshotUpdate>();
                cfg.CreateMap<FROM.DedicatedHostGroup, TO.PSHostGroup>();
                cfg.CreateMap<TO.PSHostGroup, FROM.DedicatedHostGroup>();
                cfg.CreateMap<FROM.DedicatedHost, TO.PSHost>();
                cfg.CreateMap<TO.PSHost, FROM.DedicatedHost>();
                cfg.CreateMap<FROM.DiskEncryptionSet, TO.PSDiskEncryptionSet>();
                cfg.CreateMap<TO.PSDiskEncryptionSet, FROM.DiskEncryptionSet>();
                cfg.CreateMap<FROM.Disk, TO.PSDisk>()
                    .ForMember(c => c.Zones, o => o.Condition(r => (r.Zones != null)));
                cfg.CreateMap<TO.PSDisk, FROM.Disk>()
                    .ForMember(c => c.Zones, o => o.Condition(r => (r.Zones != null)));
                cfg.CreateMap<FROM.AccessUri, TO.PSAccessUri>();
                cfg.CreateMap<TO.PSAccessUri, FROM.AccessUri>();
                cfg.CreateMap<FROM.Gallery, TO.PSGallery>();
                cfg.CreateMap<TO.PSGallery, FROM.Gallery>();
                cfg.CreateMap<FROM.GalleryImage, TO.PSGalleryImage>();
                cfg.CreateMap<TO.PSGalleryImage, FROM.GalleryImage>();
                cfg.CreateMap<FROM.GalleryImageVersion, TO.PSGalleryImageVersion>();
                cfg.CreateMap<TO.PSGalleryImageVersion, FROM.GalleryImageVersion>();
                cfg.CreateMap<FROM.Image, TO.PSImage>();
                cfg.CreateMap<TO.PSImage, FROM.Image>();
                cfg.CreateMap<FROM.LogAnalyticsOperationResult, TO.PSLogAnalyticsOperationResult>();
                cfg.CreateMap<TO.PSLogAnalyticsOperationResult, FROM.LogAnalyticsOperationResult>();
                cfg.CreateMap<FROM.ProximityPlacementGroup, TO.PSProximityPlacementGroup>();
                cfg.CreateMap<TO.PSProximityPlacementGroup, FROM.ProximityPlacementGroup>();
                cfg.CreateMap<FROM.ResourceSku, TO.PSResourceSku>();
                cfg.CreateMap<TO.PSResourceSku, FROM.ResourceSku>();
                cfg.CreateMap<FROM.Snapshot, TO.PSSnapshot>();
                cfg.CreateMap<TO.PSSnapshot, FROM.Snapshot>();
                cfg.CreateMap<FROM.RunCommandDocument, TO.PSRunCommandDocument>();
                cfg.CreateMap<TO.PSRunCommandDocument, FROM.RunCommandDocument>();
                cfg.CreateMap<FROM.RunCommandDocumentBase, TO.PSRunCommandDocumentBase>();
                cfg.CreateMap<TO.PSRunCommandDocumentBase, FROM.RunCommandDocumentBase>();
                cfg.CreateMap<FROM.RollingUpgradeStatusInfo, TO.PSRollingUpgradeStatusInfo>();
                cfg.CreateMap<TO.PSRollingUpgradeStatusInfo, FROM.RollingUpgradeStatusInfo>();
                cfg.CreateMap<FROM.VirtualMachineScaleSet, TO.PSVirtualMachineScaleSet>()
                    .ForMember(c => c.Zones, o => o.Condition(r => (r.Zones != null)));
                cfg.CreateMap<TO.PSVirtualMachineScaleSet, FROM.VirtualMachineScaleSet>()
                    .ForMember(c => c.Zones, o => o.Condition(r => (r.Zones != null)));
                cfg.CreateMap<FROM.RecoveryWalkResponse, TO.PSRecoveryWalkResponse>();
                cfg.CreateMap<TO.PSRecoveryWalkResponse, FROM.RecoveryWalkResponse>();
                cfg.CreateMap<FROM.VirtualMachineScaleSetInstanceView, TO.PSVirtualMachineScaleSetInstanceView>();
                cfg.CreateMap<TO.PSVirtualMachineScaleSetInstanceView, FROM.VirtualMachineScaleSetInstanceView>();
                cfg.CreateMap<FROM.UpgradeOperationHistoricalStatusInfo, TO.PSUpgradeOperationHistoricalStatusInfo>();
                cfg.CreateMap<TO.PSUpgradeOperationHistoricalStatusInfo, FROM.UpgradeOperationHistoricalStatusInfo>();
                cfg.CreateMap<FROM.VirtualMachineScaleSetSku, TO.PSVirtualMachineScaleSetSku>();
                cfg.CreateMap<TO.PSVirtualMachineScaleSetSku, FROM.VirtualMachineScaleSetSku>();
                cfg.CreateMap<FROM.VirtualMachineInstanceView, FROM.VirtualMachineScaleSetVMInstanceView>();
                cfg.CreateMap<FROM.VirtualMachineScaleSetVMInstanceView, FROM.VirtualMachineInstanceView>();
                cfg.CreateMap<FROM.VirtualMachineScaleSetVM, TO.PSVirtualMachineScaleSetVM>();
                cfg.CreateMap<TO.PSVirtualMachineScaleSetVM, FROM.VirtualMachineScaleSetVM>();
                cfg.CreateMap<FROM.VirtualMachineScaleSetVMInstanceView, TO.PSVirtualMachineScaleSetVMInstanceView>();
                cfg.CreateMap<TO.PSVirtualMachineScaleSetVMInstanceView, FROM.VirtualMachineScaleSetVMInstanceView>();
                cfg.CreateMap<FROM.RunCommandResult, TO.PSRunCommandResult>();
                cfg.CreateMap<TO.PSRunCommandResult, FROM.RunCommandResult>();
                cfg.CreateMap<FROM.VirtualMachineCaptureResult, TO.PSVirtualMachineCaptureResult>();
                cfg.CreateMap<TO.PSVirtualMachineCaptureResult, FROM.VirtualMachineCaptureResult>();
                cfg.CreateMap<FROM.VirtualMachineInstanceView, TO.PSVirtualMachineInstanceView>();
                cfg.CreateMap<TO.PSVirtualMachineInstanceView, FROM.VirtualMachineInstanceView>();
                cfg.CreateMap<FROM.VirtualMachineSize, TO.PSVirtualMachineSize>();
                cfg.CreateMap<TO.PSVirtualMachineSize, FROM.VirtualMachineSize>();

                cfg.CreateMap<FROM.VirtualMachineScaleSetVMProfile, TO.PSVirtualMachineScaleSetVMProfile>();
                cfg.CreateMap<TO.PSVirtualMachineScaleSetVMProfile, FROM.VirtualMachineScaleSetVMProfile>();
                cfg.CreateMap<FROM.VirtualMachineScaleSetExtensionProfile, TO.PSVirtualMachineScaleSetExtensionProfile>();
                cfg.CreateMap<TO.PSVirtualMachineScaleSetExtensionProfile, FROM.VirtualMachineScaleSetExtensionProfile>();
                cfg.CreateMap<FROM.VirtualMachineScaleSetExtension, TO.PSVirtualMachineScaleSetExtension>()
                    .ForMember(c => c.Type, o => o.MapFrom(r => r.Type1));
                cfg.CreateMap<TO.PSVirtualMachineScaleSetExtension, FROM.VirtualMachineScaleSetExtension>()
                    .ForMember(c => c.Type1, o => o.MapFrom(r => r.Type));

                cfg.CreateMap<FROM.DiskAccess, TO.PSDiskAccess>();
                cfg.CreateMap<TO.PSDiskAccess, FROM.DiskAccess>();
                cfg.CreateMap<FROM.DiskAccess, TO.PSDiskAccessList>();
                cfg.CreateMap<TO.PSDiskAccessList, TO.PSDiskAccess>();
                cfg.CreateMap<TO.PSDiskAccess, TO.PSDiskAccessList>();

                cfg.CreateMap<FROM.VirtualMachineAssessPatchesResult, TO.PSVirtualMachinePatchAssessmentResult>();
                cfg.CreateMap<TO.PSVirtualMachinePatchAssessmentResult, FROM.VirtualMachineAssessPatchesResult>();
                cfg.CreateMap<FROM.VirtualMachineInstallPatchesResult, TO.PSVirtualMachineInstallPatchesResult>();
                cfg.CreateMap<TO.PSVirtualMachineInstallPatchesResult, FROM.VirtualMachineInstallPatchesResult>();
                cfg.CreateMap<FROM.SshPublicKeyResource, TO.PSSshPublicKeyResource>();
                cfg.CreateMap<TO.PSSshPublicKeyResource, FROM.SshPublicKeyResource>();
                cfg.CreateMap<FROM.SshPublicKeyResource, TO.PSSshPublicKeyResourceList>();
                cfg.CreateMap<TO.PSSshPublicKeyResourceList, TO.PSSshPublicKeyResource>();
                cfg.CreateMap<TO.PSSshPublicKeyResource, TO.PSSshPublicKeyResourceList>();
                cfg.CreateMap<FROM.CapacityReservationGroup, TO.PSCapacityReservationGroup>();
                cfg.CreateMap<TO.PSCapacityReservationGroup, FROM.CapacityReservationGroup>();
                cfg.CreateMap<FROM.CapacityReservationGroup, TO.PSCapacityReservationGroupList>();
                cfg.CreateMap<TO.PSCapacityReservationGroupList, TO.PSCapacityReservationGroup>();
                cfg.CreateMap<TO.PSCapacityReservationGroup, TO.PSCapacityReservationGroupList>();
                cfg.CreateMap<FROM.CapacityReservation, TO.PSCapacityReservation>();
                cfg.CreateMap<TO.PSCapacityReservation, FROM.CapacityReservation>();
                cfg.CreateMap<FROM.CapacityReservation, TO.PSCapacityReservationList>();
                cfg.CreateMap<TO.PSCapacityReservationList, TO.PSCapacityReservation>();
                cfg.CreateMap<TO.PSCapacityReservation, TO.PSCapacityReservationList>();
                cfg.CreateMap<FROM.RestorePoint, TO.PSRestorePoint>();
                cfg.CreateMap<FROM.RestorePointCollection, TO.PSRestorePointCollection>();
            });
            _mapper = config.CreateMapper();
        }
    }
}