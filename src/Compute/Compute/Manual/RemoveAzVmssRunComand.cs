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

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using Microsoft.Azure.Commands.Compute.Automation.Models;
using Microsoft.Azure.Commands.ResourceManager.Common.ArgumentCompleters;
using Microsoft.Azure.Management.Compute;
using Microsoft.Azure.Management.Compute.Models;
using Microsoft.WindowsAzure.Commands.Utilities.Common;
using System.Security;

namespace Microsoft.Azure.Commands.Compute.Automation
{
    [Cmdlet(VerbsCommon.Remove, ResourceManager.Common.AzureRMConstants.AzureRMPrefix + "VmssRunCommand", DefaultParameterSetName = "DefaultParameter", SupportsShouldProcess = true)]
    [OutputType(typeof(PSRunCommandResult))]
    public partial class RemoveVmssRunCommand : ComputeAutomationBaseCmdlet
    {

        [Parameter(
            ParameterSetName = "DefaultParameter",
            Position = 0,
            Mandatory = true,
            ValueFromPipelineByPropertyName = true)]
        [ResourceGroupCompleter]
        public string ResourceGroupName { get; set; }

        [Parameter(
            ParameterSetName = "DefaultParameter",
            Position = 1,
            Mandatory = true,
            ValueFromPipelineByPropertyName = true)]
        [ResourceNameCompleter("Microsoft.Compute/virtualMachineScaleSets", "ResourceGroupName")]
        public string VMScaleSetName { get; set; }

        [Parameter(
            Mandatory = true,
            ParameterSetName = "DefaultParameter")]
        [AllowNull]
        [Alias("Name")]
        public string RunCommandName { get; set; }

        [Parameter(Mandatory = false, HelpMessage = "Run cmdlet in the background")]
        public SwitchParameter AsJob { get; set; }

        public override void ExecuteCmdlet()
        {

            string resourceGroupName;
            string vmScaleSetName;
            resourceGroupName = this.ResourceGroupName;
            vmScaleSetName = this.VMScaleSetName;

            var expand = new Microsoft.Rest.Azure.OData.ODataQuery<VirtualMachineScaleSetVM>();
            expand.Expand = "instanceView";
            var vmList = VirtualMachineScaleSetVMsClient.List(resourceGroupName, vmScaleSetName, expand);
            var resultList = vmList.ToList();
            var nextPageLink = vmList.NextPageLink;
            while (!string.IsNullOrEmpty(nextPageLink))
            {
                var pageResult = VirtualMachineScaleSetVMsClient.ListNext(nextPageLink);
                foreach (var pageItem in pageResult)
                {
                    resultList.Add(pageItem);
                }
                nextPageLink = pageResult.NextPageLink;
            }
            List<VirtualMachineScaleSetVM> listOfVms = new List<VirtualMachineScaleSetVM>(resultList);

            Rest.Azure.AzureOperationResponse result = null;
            foreach (VirtualMachineScaleSetVM vm in listOfVms)
            {
                result = VirtualMachineScaleSetVMRunCommandsClient.BeginDeleteWithHttpMessagesAsync(resourceGroupName, vmScaleSetName, vm.InstanceId, this.RunCommandName).GetAwaiter().GetResult();
            }

            PSOperationStatusResponse output = new PSOperationStatusResponse
            {
                StartTime = this.StartTime,
                EndTime = DateTime.Now
            };

            if (result != null && result.Request != null && result.Request.RequestUri != null)
            {
                output.Name = GetOperationIdFromUrlString(result.Request.RequestUri.ToString());
            }

            WriteObject(output);
        }
    }
}