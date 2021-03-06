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

using Microsoft.Azure.Commands.DevTestLabs.Models;
using Microsoft.Azure.Commands.DevTestLabs.Properties;
using Microsoft.Azure.Management.DevTestLabs;
using Microsoft.Azure.Management.DevTestLabs.Models;
using Microsoft.Rest.Azure;
using System.Globalization;
using System.Management.Automation;

namespace Microsoft.Azure.Commands.DevTestLabs
{
    [Cmdlet("Set", ResourceManager.Common.AzureRMConstants.AzureRMPrefix + "DtlVMsPerLabPolicy",HelpUri = Constants.DevTestLabsHelpUri,DefaultParameterSetName = ParameterSetEnable,SupportsShouldProcess = true)]
    [OutputType(typeof(PSPolicy))]
    public class SetAzureRmDtlVMsPerLabPolicy : DtlPolicyCmdletBase
    {
        protected override string PolicyName
        {
            get
            {
                return WellKnownPolicyNames.MaxVmsAllowedPerLab;
            }
        }

        #region Input Parameter Definitions

        /// <summary>
        /// Maximum number of virtual machines.
        /// </summary>
        [Parameter(Mandatory = false,
            Position = 4,
            HelpMessage = "Maximum total number of virtual machines allowed in the lab.")]
        public int? MaxVMs { get; set; }

        #endregion Input Parameter Definitions

        public override void ExecuteCmdlet()
        {
            Policy inputPolicy = null;

            try
            {
                inputPolicy = DataServiceClient.Policies.Get(
                                LabName,
                                Constants.Default,
                                PolicyName);
            }
            catch (CloudException ex)
            {
                if (ex.Response.StatusCode != System.Net.HttpStatusCode.NotFound
                    || MaxVMs == null)
                {
                    throw;
                }
            }

            // Do nothing if user cancelled the operation
            var actionDescription = string.Format(CultureInfo.CurrentCulture,
                Resources.SavePolicyDescription,
                PolicyName,
                LabName);

            string actionWarning;

            if (inputPolicy == null)
            {
                inputPolicy = new Policy
                {
                    FactName = PolicyFactName.LabVmCount,
                    EvaluatorType = PolicyEvaluatorType.MaxValuePolicy,
                    Threshold = MaxVMs.Value.ToString(),
                    Status = Disable ? PolicyStatus.Disabled : PolicyStatus.Enabled
                };

                actionWarning = string.Format(CultureInfo.CurrentCulture,
                    Resources.CreatePolicyWarning,
                    PolicyName);
            }
            else
            {
                actionWarning = string.Format(CultureInfo.CurrentCulture,
                    Resources.AlterPolicyWarning,
                    PolicyName);

                if (MaxVMs.HasValue)
                {
                    inputPolicy.Threshold = MaxVMs.Value.ToString();
                }

                if (Disable)
                {
                    inputPolicy.Status = PolicyStatus.Disabled;
                }

                if (Enable)
                {
                    inputPolicy.Status = PolicyStatus.Enabled;
                }
            }

            if (!ShouldProcess(
                    actionDescription,
                    actionWarning,
                    Resources.ShouldProcessCaption))
            {
                return;
            }

            var outputPolicy = DataServiceClient.Policies.CreateOrUpdate(
                LabName,
                Constants.Default,
                PolicyName,
                inputPolicy
                );

            WriteObject(outputPolicy);
        }
    }
}
