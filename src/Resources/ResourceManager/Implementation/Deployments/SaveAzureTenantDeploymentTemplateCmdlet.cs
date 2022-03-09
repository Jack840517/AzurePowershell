﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

namespace Microsoft.Azure.Commands.ResourceManager.Cmdlets.Implementation
{
    using System.Management.Automation;
    using Microsoft.Azure.Commands.ResourceManager.Cmdlets.SdkModels;
    using Microsoft.Azure.Commands.ResourceManager.Cmdlets.SdkModels.Deployments;
    using Microsoft.Azure.Commands.ResourceManager.Cmdlets.Utilities;
    using Microsoft.Azure.Commands.ResourceManager.Common;
    using Microsoft.WindowsAzure.Commands.Utilities.Common;

    /// <summary>
    /// Saves the deployment template to a file on disk.
    /// </summary>
    [Cmdlet(VerbsData.Save, AzureRMConstants.AzureRMPrefix + "TenantDeploymentTemplate", SupportsShouldProcess = true,
        DefaultParameterSetName = SaveAzureTenantDeploymentTemplateCmdlet.DeploymentNameParameterSet), OutputType(typeof(PSTemplatePath))]
    public class SaveAzureTenantDeploymentTemplateCmdlet : ResourceManagerCmdletBase
    {
        /// <summary>
        /// The deployment name parameter set.
        /// </summary>
        internal const string DeploymentNameParameterSet = "SaveByDeploymentName";

        /// <summary>
        /// The deployment object parameter set.
        /// </summary>
        internal const string DeploymentObjectParameterSet = "SaveByDeploymentObject";

        /// <summary>
        /// Gets or sets the deployment name parameter.
        /// </summary>
        [Alias("Name")]
        [Parameter(ParameterSetName = SaveAzureTenantDeploymentTemplateCmdlet.DeploymentNameParameterSet,
            Mandatory = true, HelpMessage = "The deployment name.")]
        [ValidateNotNullOrEmpty]
        public string DeploymentName { get; set; }

        [Parameter(ParameterSetName = SaveAzureTenantDeploymentTemplateCmdlet.DeploymentObjectParameterSet,
            Mandatory = true, ValueFromPipeline = true, HelpMessage = "The deployment object.")]
        public PSDeployment DeploymentObject { get; set; }

        /// <summary>
        /// Gets or sets the file path.
        /// </summary>
        [Parameter(Mandatory = false, HelpMessage = "The output path of the template file.")]
        [ValidateNotNullOrEmpty]
        public string Path { get; set; }

        /// <summary>
        /// Gets or sets the force parameter.
        /// </summary>
        [Parameter(Mandatory = false, HelpMessage = "Do not ask for confirmation.")]
        public SwitchParameter Force { get; set; }

        /// <summary>
        /// Executes the cmdlet.
        /// </summary>
        protected override void OnProcessRecord()
        {
            base.OnProcessRecord();

            var options = new FilterDeploymentOptions(DeploymentScopeType.Tenant)
            {
                DeploymentName = !string.IsNullOrEmpty(this.DeploymentName) ? this.DeploymentName : this.DeploymentObject.DeploymentName
            };

            if (ShouldProcess(options.DeploymentName, VerbsData.Save))
            {
                var template = ResourceManagerSdkClient.GetDeploymentTemplateAtTenantScope(options.DeploymentName);

                string path = FileUtility.SaveTemplateFile(
                    templateName: options.DeploymentName,
                    contents: template,
                    outputPath:
                        string.IsNullOrEmpty(this.Path)
                            ? System.IO.Path.Combine(CurrentPath(), options.DeploymentName)
                            : this.TryResolvePath(this.Path),
                    overwrite: this.Force,
                    shouldContinue: ShouldContinue);

                WriteObject(new PSTemplatePath() { Path = path });
            }
        }
    }
}
