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

namespace Microsoft.Azure.Commands.LogicApp.Cmdlets
{
    using System.Globalization;
    using Microsoft.Azure.Commands.LogicApp.Utilities;
    using System.Management.Automation;
    using ResourceManager.Common.ArgumentCompleters;

    /// <summary>
    /// Removes the integration account certificate. 
    /// </summary>
    [Cmdlet("Remove", ResourceManager.Common.AzureRMConstants.AzureRMPrefix + "IntegrationAccountCertificate", SupportsShouldProcess = true), OutputType(typeof(void))]
    public class RemoveAzureIntegrationAccountCertificateCommand : LogicAppBaseCmdlet
    {

        #region Input Parameters

        [Parameter(Mandatory = true, HelpMessage = "The integration account resource group name.",
            ValueFromPipelineByPropertyName = true)]
        [ResourceGroupCompleter]
        [ValidateNotNullOrEmpty]
        public string ResourceGroupName { get; set; }

        [Parameter(Mandatory = true, HelpMessage = "The integration account name.")]
        [ValidateNotNullOrEmpty]
        [Alias("IntegrationAccountName", "ResourceName")]
        public string Name { get; set; }

        [Parameter(Mandatory = true, HelpMessage = "The integration account certificate name.")]
        [ValidateNotNullOrEmpty]
        public string CertificateName { get; set; }

        [Parameter(Mandatory = false, HelpMessage = "Do not ask for confirmation.")]
        public SwitchParameter Force { get; set; }

        #endregion Input Parameters

        /// <summary>
        /// Executes the command to remove integration account certificate.
        /// </summary>
        public override void ExecuteCmdlet()
        {
            base.ExecuteCmdlet();
            ConfirmAction(Force.IsPresent,
                string.Format(CultureInfo.InvariantCulture, Properties.Resource.RemoveResourceWarning, "Microsoft.Logic/integrationAccounts/certificates", this.Name),
                string.Format(CultureInfo.InvariantCulture, Properties.Resource.RemoveResourceMessage, "Microsoft.Logic/integrationAccounts/certificates", this.Name),
                Name,
                () => {
                    IntegrationAccountClient.RemoveIntegrationAccountCertificate(this.ResourceGroupName, this.Name, this.CertificateName);
                });
        }
    }
}
