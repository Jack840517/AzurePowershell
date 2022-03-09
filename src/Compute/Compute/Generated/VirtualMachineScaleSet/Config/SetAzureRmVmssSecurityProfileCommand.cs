﻿//
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

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using Microsoft.Azure.Commands.Compute.Automation.Models;
using Microsoft.Azure.Management.Compute.Models;
using Microsoft.WindowsAzure.Commands.Utilities.Common;
using Microsoft.Azure.Commands.ResourceManager.Common.ArgumentCompleters;

namespace Microsoft.Azure.Commands.Compute.Automation
{
    [Cmdlet(VerbsCommon.Set, ResourceManager.Common.AzureRMConstants.AzureRMPrefix + "VmssSecurityProfile")]
    [OutputType(typeof(PSVirtualMachineScaleSet))]
    public partial class SetAzureRmVmssSecurityProfileCommand : Microsoft.Azure.Commands.ResourceManager.Common.AzureRMCmdlet
    {
        [Parameter(
        Mandatory = true,
        Position = 0,
        ValueFromPipeline = true,
        ValueFromPipelineByPropertyName = true)]
        public PSVirtualMachineScaleSet VirtualMachineScaleSet { get; set; }

        [Parameter(
            HelpMessage = "Parameter to toggle vTPM on the VMs of the scale set",
            Mandatory = false,
            Position = 1,
            ValueFromPipelineByPropertyName = true)]
        [PSArgumentCompleter("TrustedLaunch")]
        public string SecurityType { get; set; }

        protected override void ProcessRecord()
        {
            Run();
        }

        private void Run()
        {
            if (this.IsParameterBound(c => c.SecurityType))
            {
                // Security Profile
                if (this.VirtualMachineScaleSet.VirtualMachineProfile == null)
                {
                    this.VirtualMachineScaleSet.VirtualMachineProfile = new PSVirtualMachineScaleSetVMProfile();
                }
                if (this.VirtualMachineScaleSet.VirtualMachineProfile.SecurityProfile == null)
                {
                    this.VirtualMachineScaleSet.VirtualMachineProfile.SecurityProfile = new SecurityProfile();
                }
                this.VirtualMachineScaleSet.VirtualMachineProfile.SecurityProfile.SecurityType = this.SecurityType;
            }
            WriteObject(this.VirtualMachineScaleSet);
        }

    }
}