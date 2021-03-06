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

using Microsoft.Azure.Commands.DataLakeAnalytics.Models;
using Microsoft.Azure.Management.DataLake.Analytics.Models;
using System.Collections.Generic;
using System.Management.Automation;

namespace Microsoft.Azure.Commands.DataLakeAnalytics
{
    [Cmdlet("Get", ResourceManager.Common.AzureRMConstants.AzureRMPrefix + "DataLakeAnalyticsCatalogItem"),OutputType(typeof(CatalogItem))]
    [Alias("Get-AdlCatalogItem")]
    public class GetAzureDataLakeAnalyticsCatalogItem : DataLakeAnalyticsCmdletBase
    {
        [Parameter(ValueFromPipelineByPropertyName = true, Position = 0, Mandatory = true,
            HelpMessage = "The account name to retrieve the catalog item(s) from.")]
        [ValidateNotNullOrEmpty]
        [Alias("AccountName")]
        public string Account { get; set; }

        [Parameter(ValueFromPipelineByPropertyName = true, Position = 1, Mandatory = true,
            HelpMessage = "The type of the catalog item(s) to retrieve.")]
        [ValidateNotNullOrEmpty]
        public DataLakeAnalyticsEnums.CatalogItemType ItemType { get; set; }

        [Parameter(ValueFromPipelineByPropertyName = true, Position = 2, Mandatory = false,
            HelpMessage = "The catalog item path to search within, in the format:" +
                          "'DatabaseName.<optionalSecondPart>.<optionalThirdPart>.<optionalTableStatsName>'." +
                          "This is required for all catalog item types except database list")]
        [ValidateNotNullOrEmpty]
        public CatalogPathInstance Path { get; set; }

        public override void ExecuteCmdlet()
        {
            var itemList = DataLakeAnalyticsClient.GetCatalogItem(Account, Path, ItemType);
            if (itemList.Count == 1)
            {
                WriteObject(itemList[0]);
            }
            else
            {
                WriteObject(itemList, true);
            }
        }
    }
}
