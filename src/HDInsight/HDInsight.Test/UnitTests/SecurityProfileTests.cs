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

using System.Management.Automation;
using Microsoft.Azure.Commands.HDInsight.Models;
using Microsoft.WindowsAzure.Commands.Common;
using Microsoft.WindowsAzure.Commands.ScenarioTest;
using Moq;
using Xunit;

namespace Microsoft.Azure.Commands.HDInsight.Test
{
    public class SecurityProfileTests : HDInsightTestBase
    {
        public SecurityProfileTests(Xunit.Abstractions.ITestOutputHelper output)
        {
            ServiceManagement.Common.Models.XunitTracingInterceptor.AddToContext(new ServiceManagement.Common.Models.XunitTracingInterceptor(output));
            base.SetupTestsForManagement();
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void CanCreateNewSecurityProfile()
        {
            SetupConfirmation(commandRuntimeMock);

            var config = new AzureHDInsightConfig();
            var newconfigcmdlet = new AddAzureHDInsightSecurityProfile()
            {
                CommandRuntime = commandRuntimeMock.Object,
                HDInsightManagementClient = hdinsightManagementMock.Object,
                Config = config,
                DomainResourceId = "/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/fakerg/providers/Microsoft.AAD/domainServices/domain.com",
                DomainUserCredential = new PSCredential("username","pass".ConvertToSecureString()),
                OrganizationalUnitDN = "OUDN",
                LdapsUrls = new[]
                {
                    "ldapsUrl"
                },
                ClusterUsersGroupDNs = new []
                {
                    "usersGroupDn"
                }
            };

            newconfigcmdlet.ExecuteCmdlet();
            commandRuntimeMock.Verify(
                f =>
                    f.WriteObject(
                        It.Is<AzureHDInsightConfig>(
                            c =>
                                c.ClusterType == ClusterType &&
                                c.AdditionalStorageAccounts.Count == 0 &&
                                c.Configurations.Count == 0 &&
                                string.IsNullOrEmpty(c.WorkerNodeSize) &&
                                string.IsNullOrEmpty(c.StorageAccountKey) &&
                                string.IsNullOrEmpty(c.StorageAccountResourceId) &&
                                string.IsNullOrEmpty(c.HeadNodeSize) &&
                                string.IsNullOrEmpty(c.ZookeeperNodeSize) &&
                                c.HiveMetastore == null &&
                                c.OozieMetastore == null &&
                                c.ScriptActions.Count == 0 &&
                                c.SecurityProfile.DomainResourceId.Equals(newconfigcmdlet.DomainResourceId) &&
                                c.SecurityProfile.DomainUserCredential.UserName.Equals(newconfigcmdlet.DomainUserCredential.UserName) &&
                                c.SecurityProfile.OrganizationalUnitDN.Equals(newconfigcmdlet.OrganizationalUnitDN) &&
                                c.SecurityProfile.LdapsUrls.ArrayToString("").Equals(newconfigcmdlet.LdapsUrls.ArrayToString("")) &&
                                c.SecurityProfile.ClusterUsersGroupDNs.ArrayToString("").Equals(newconfigcmdlet.ClusterUsersGroupDNs.ArrayToString("")))),
                Times.Once);
        }
    }
}
