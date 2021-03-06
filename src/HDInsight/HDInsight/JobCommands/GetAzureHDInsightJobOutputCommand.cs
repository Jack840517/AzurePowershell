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

using Hyak.Common;
using Microsoft.Azure.Commands.HDInsight.Commands;
using Microsoft.Azure.Commands.HDInsight.Models;
using Microsoft.Azure.Commands.HDInsight.Models.Job;
using Microsoft.Azure.Commands.ResourceManager.Common.ArgumentCompleters;
using Microsoft.Azure.Management.HDInsight.Job.Models;
using Microsoft.Azure.Management.HDInsight.Models;
using Microsoft.WindowsAzure.Commands.Common;
using System;
using System.Collections.Generic;
using System.IO;
using System.Management.Automation;

namespace Microsoft.Azure.Commands.HDInsight
{
    [Cmdlet("Get", ResourceManager.Common.AzureRMConstants.AzureRMPrefix + "HDInsightJobOutput"), OutputType(typeof(string))]
    public class GetAzureHDInsightJobOutputCommand : HDInsightCmdletBase
    {
        #region Input Parameter Definitions

        [Parameter(Mandatory = true,
            Position = 0,
            HelpMessage = "The name of the cluster.")]
        public string ClusterName
        {
            get { return _clusterName; }
            set { _clusterName = value; }
        }

        [Parameter(Position = 1,
            Mandatory = true,
            HelpMessage = "The JobID of the jobDetails to stop.")]
        public string JobId { get; set; }

        [Parameter(Position = 2,
            HelpMessage = "The default container name.")]
        public string DefaultContainer { get; set; }

        [Parameter(Position = 3,
            HelpMessage = "The default storage account name.")]
        public string DefaultStorageAccountName { get; set; }

        [Parameter(Position = 4,
            HelpMessage = "The default storage account key.")]
        public string DefaultStorageAccountKey { get; set; }

        [Parameter(Mandatory = true,
            Position = 5,
            HelpMessage = "The credentials with which to connect to the cluster.")]
        [Alias("ClusterCredential")]
        public PSCredential HttpCredential
        {
            get
            {
                return _credential == null ? null : new PSCredential(_credential.Username, _credential.Password.ConvertToSecureString());
            }
            set
            {
                _credential = new BasicAuthenticationCloudCredentials
                {
                    Username = value.UserName,
                    Password = value.Password.ConvertToString()
                };
            }
        }

        [Parameter(HelpMessage = "Gets or sets the name of the resource group.")]
        [ResourceGroupCompleter]
        public string ResourceGroupName { get; set; }

        [Parameter(HelpMessage = "The type of job output.")]
        public JobDisplayOutputType DisplayOutputType { get; set; }

        #endregion

        private IStorageAccess storageAccess = null;

        public override void ExecuteCmdlet()
        {
            if (ResourceGroupName == null)
            {
                ResourceGroupName = GetResourceGroupByAccountName(ClusterName);
            }

            storageAccess = GetDefaultStorageAccess(ResourceGroupName, _clusterName);

            _clusterName = GetClusterConnection(ResourceGroupName, ClusterName);

            string output;
            switch (DisplayOutputType)
            {
                case JobDisplayOutputType.StandardError:
                    output = GetJobError(this.storageAccess);
                    break;
                default:
                    output = GetJobOutput(this.storageAccess);
                    break;
            }
            WriteObject(output);
        }

        internal string GetJobOutput(IStorageAccess storageAccess)
        {
            var output = HDInsightJobClient.GetJobOutput(JobId, storageAccess);
            var outputStr = Convert(output);
            return outputStr;
        }

        internal string GetJobError(IStorageAccess storageAccess)
        {
            var output = HDInsightJobClient.GetJobError(JobId, storageAccess);
            var outputStr = Convert(output);
            return outputStr;
        }

        private static string Convert(Stream stream)
        {
            var reader = new StreamReader(stream);
            var text = reader.ReadToEnd();
            return text;
        }

        private string GetStorageAccountKey(string resourceGroupName, string clusterName)
        {
            string storageAccountKey = null;
            string errorMessage = "Fails to retrieve storage account key. Please specify DefaultStorageAccountKey explicitly.";
            const string AuthorizationFailedCode = "AuthorizationFailed";

            try
            {
                IDictionary<string, string> coreSiteClusterConfiguration;
                HDInsightManagementClient.ListConfigurations(resourceGroupName, clusterName).Configurations.TryGetValue(ConfigurationKey.CoreSite, out coreSiteClusterConfiguration);
                coreSiteClusterConfiguration?.TryGetValue(Constants.ClusterConfiguration.StorageAccountKeyPrefix + DefaultStorageAccountName, out storageAccountKey);
            }
            catch (CloudException cloudEx)
            {
                if (cloudEx.Error.Code == AuthorizationFailedCode)
                {
                    errorMessage = "Insufficient permissions to retrieve storage account key. Please specify DefaultStorageAccountKey explicitly.";
                }
            }
            catch (Exception ex)
            {
                errorMessage = errorMessage + " Reason: " + ex.Message;
            }

            if (storageAccountKey == null)
            {
                throw new CloudException(errorMessage);
            }

            return storageAccountKey;
        }

        internal IStorageAccess GetDefaultStorageAccess(string resourceGroupName, string clusterName)
        {
            var StorageAccountSuffix = "";

            if (DefaultContainer == null && DefaultStorageAccountName == null && DefaultStorageAccountKey == null)
            {
                var DefaultStorageAccount = GetDefaultStorageAccount(resourceGroupName, clusterName);

                var wasbAccount = DefaultStorageAccount as AzureHDInsightWASBDefaultStorageAccount;

                if (wasbAccount != null)
                {
                    DefaultContainer = wasbAccount.StorageContainerName;
                    DefaultStorageAccountName = wasbAccount.StorageAccountName;
                    DefaultStorageAccountKey = GetStorageAccountKey(resourceGroupName, clusterName);
                    StorageAccountSuffix = DefaultContext.Environment.StorageEndpointSuffix;
                }
                else
                {
                    throw new CloudException("Unsupported default storage account type");
                }

            }

            return new AzureStorageAccess(DefaultStorageAccountName, DefaultStorageAccountKey, DefaultContainer, StorageAccountSuffix);
        }
    }
}
