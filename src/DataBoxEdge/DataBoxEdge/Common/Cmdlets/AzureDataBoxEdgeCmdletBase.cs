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

using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Azure.Commands.Common.Authentication;
using Microsoft.Azure.Commands.Common.Authentication.Abstractions;
using Microsoft.Azure.Commands.ResourceManager.Common;
using Microsoft.Azure.Management.DataBoxEdge;


namespace Microsoft.Azure.PowerShell.Cmdlets.DataBoxEdge.Common
{
    /// <summary>
    /// Base class of Azure Databox Cmdlet.
    /// </summary>
    public class AzureDataBoxEdgeCmdletBase : AzureRMCmdlet
    {
        private DataBoxEdgeManagementClient _dataBoxManagementClient;


        public static Dictionary<K, V> HashtableToDictionary<K, V>(Hashtable table)
        {
            return table
                .Cast<DictionaryEntry>()
                .ToDictionary(kvp => (K) kvp.Key, kvp => (V) kvp.Value);
        }

        /// <summary>
        /// Gets or sets the Databox management client.
        /// </summary>
        public DataBoxEdgeManagementClient DataBoxEdgeManagementClient
        {
            get
            {
                return _dataBoxManagementClient ??
                       (_dataBoxManagementClient =
                           AzureSession.Instance.ClientFactory.CreateArmClient<DataBoxEdgeManagementClient>(
                               DefaultProfile.DefaultContext,
                               AzureEnvironment.Endpoint.ResourceManager));
            }
            set { _dataBoxManagementClient = value; }
        }
    }
}