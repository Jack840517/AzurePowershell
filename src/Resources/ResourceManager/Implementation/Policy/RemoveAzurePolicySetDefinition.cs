// ----------------------------------------------------------------------------------
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
    using Microsoft.Azure.Commands.ResourceManager.Cmdlets.Components;
    using Policy;
    using System;
    using System.Management.Automation;

    /// <summary>
    /// Removes the policy set definition.
    /// </summary>
    [Cmdlet("Remove", ResourceManager.Common.AzureRMConstants.AzureRMPrefix + "PolicySetDefinition", SupportsShouldProcess = true, DefaultParameterSetName = PolicyCmdletBase.NameParameterSet), OutputType(typeof(bool))]
    public class RemoveAzurePolicySetDefinitionCmdlet : PolicyCmdletBase
    {
        /// <summary>
        /// Gets or sets the policy set definition name parameter.
        /// </summary>
        [Parameter(ParameterSetName = PolicyCmdletBase.NameParameterSet, Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = PolicyHelpStrings.RemovePolicySetDefinitionNameHelp)]
        [Parameter(ParameterSetName = PolicyCmdletBase.ManagementGroupNameParameterSet, Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = PolicyHelpStrings.RemovePolicySetDefinitionNameHelp)]
        [Parameter(ParameterSetName = PolicyCmdletBase.SubscriptionIdParameterSet, Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = PolicyHelpStrings.RemovePolicySetDefinitionNameHelp)]
        [ValidateNotNullOrEmpty]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the policy set definition id parameter
        /// </summary>
        [Alias("ResourceId")]
        [Parameter(ParameterSetName = PolicyCmdletBase.IdParameterSet, Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = PolicyHelpStrings.RemovePolicySetDefinitionIdHelp)]
        [ValidateNotNullOrEmpty]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the force switch.
        /// </summary>
        [Parameter(Mandatory = false, HelpMessage = "Do not ask for confirmation.")]
        public SwitchParameter Force { get; set; }

        /// <summary>
        /// Gets or sets the policy set definition management group name parameter.
        /// </summary>
        [Parameter(ParameterSetName = PolicyCmdletBase.ManagementGroupNameParameterSet, Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = PolicyHelpStrings.RemovePolicySetDefinitionManagementGroupHelp)]
        [ValidateNotNullOrEmpty]
        public string ManagementGroupName { get; set; }

        /// <summary>
        /// Gets or sets the policy set definition subscription id parameter.
        /// </summary>
        [Parameter(ParameterSetName = PolicyCmdletBase.SubscriptionIdParameterSet, Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = PolicyHelpStrings.RemovePolicySetDefinitionSubscriptionIdHelp)]
        [ValidateNotNullOrEmpty]
        public Guid? SubscriptionId { get; set; }

        /// <summary>
        /// Gets or sets the policy set definition input object parameter.
        /// </summary>
        [Parameter(ParameterSetName = PolicyCmdletBase.InputObjectParameterSet, Mandatory = true, ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = PolicyHelpStrings.RemovePolicySetDefinitionInputObjectHelp)]
        public PsPolicySetDefinition InputObject { get; set; }

        /// <summary>
        /// Executes the cmdlet.
        /// </summary>
        protected override void OnProcessRecord()
        {
            base.OnProcessRecord();

            this.RunCmdlet();
        }

        /// <summary>
        /// Contains the cmdlet's execution logic.
        /// </summary>
        private void RunCmdlet()
        {
            base.OnProcessRecord();
            string resourceId = this.GetResourceId();
            var apiVersion = string.IsNullOrWhiteSpace(this.ApiVersion) ? Constants.PolicySetDefintionApiVersion : this.ApiVersion;

            this.ConfirmAction(
                this.Force,
                string.Format("Are you sure you want to delete the following policy set definition: {0}", resourceId),
                "Deleting the policy set definition...",
                resourceId,
                () =>
                {
                    var operationResult = this.GetResourcesClient()
                        .DeleteResource(
                            resourceId: resourceId,
                            apiVersion: apiVersion,
                            cancellationToken: this.CancellationToken.Value,
                            odataQuery: null)
                        .Result;

                    var managementUri = this.GetResourcesClient()
                        .GetResourceManagementRequestUri(
                            resourceId: resourceId,
                            apiVersion: apiVersion,
                            odataQuery: null);

                    var activity = string.Format("DELETE {0}", managementUri.PathAndQuery);

                    this.GetLongRunningOperationTracker(activityName: activity, isResourceCreateOrUpdate: false)
                        .WaitOnOperation(operationResult: operationResult);

                    this.WriteObject(true);
                });
        }

        /// <summary>
        /// Gets the resource Id from the supplied PowerShell parameters.
        /// </summary>
        private string GetResourceId()
        {
            return this.Id ?? this.InputObject?.ResourceId ?? this.MakePolicySetDefinitionId(this.ManagementGroupName, this.SubscriptionId, this.Name);
        }
    }
}
