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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Management.Automation;
using Microsoft.Azure.Commands.Sql.DataSync.Model;
using Microsoft.Azure.Management.Sql.Models;

namespace Microsoft.Azure.Commands.Sql.DataSync.Cmdlet
{
    /// <summary>
    /// Cmdlet to update an existing sync member
    /// </summary>
    [Cmdlet("Update", ResourceManager.Common.AzureRMConstants.AzureRMPrefix + "SqlSyncMember", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium), OutputType(typeof(AzureSqlSyncMemberModel))]
    public class UpdateAzureSqlSyncMember : AzureSqlSyncMemberCmdletBase
    {
        /// <summary>
        /// Gets or sets the sync member name
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true,
            HelpMessage = "The sync member name.")]
        [Alias("SyncMemberName")]
        [ValidateNotNullOrEmpty]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the credential (username and password) of the Azure SQL Database. 
        /// </summary>
        [Parameter(Mandatory = false, HelpMessage = "The credential (username and password) of the Azure SQL Database.")]
        public PSCredential MemberDatabaseCredential { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to use private link connection
        /// </summary>
        [Parameter(Mandatory = false, HelpMessage = "Whether to use private link when connecting to this sync member.")]
        public bool? UsePrivateLinkConnection { get; set; }

        /// <summary>
        /// Gets or sets the sync member resource Id
        /// </summary>
        /// <value>
        /// The sync member database id (only for sync member using Azure SQL Database), e.g. "subscriptions/{subscriptionId}/resourceGroups/{syncDatabaseResourceGroup01}/servers/{syncMemberServer01}/databases/{syncMemberDatabaseName01}"
        /// </value>
        /// <remarks>
        /// This needs to be a sync member sql azure database id (i.e. full arm uri) so that we can validate calling user's R/W access to this database via RBAC.
        /// </remarks>
        [Parameter(Mandatory = false, HelpMessage = "The resource ID for the sync member database, used if UsePrivateLinkConnection is set to true.")]
        public string SyncMemberAzureDatabaseResourceId { get; set; }

        /// <summary>
        /// Get the entities from the service
        /// </summary>
        /// <returns>The list of entities</returns>
        protected override IEnumerable<AzureSqlSyncMemberModel> GetEntity()
        {
            return new List<AzureSqlSyncMemberModel>() { 
               ModelAdapter.GetSyncMember(this.ResourceGroupName, this.ServerName, this.DatabaseName, this.SyncGroupName, this.Name)
            };
        }

        /// <summary>
        /// Create the model from user input
        /// </summary>
        /// <param name="model">Model retrieved from service</param>
        /// <returns>The model that was passed in</returns>
        protected override IEnumerable<AzureSqlSyncMemberModel> ApplyUserInputToModel(IEnumerable<AzureSqlSyncMemberModel> model)
        {
            AzureSqlSyncMemberModel newModel = model.First();

            if (MyInvocation.BoundParameters.ContainsKey(nameof(UsePrivateLinkConnection)))
            {
                if (this.UsePrivateLinkConnection.GetValueOrDefault() && !MyInvocation.BoundParameters.ContainsKey(nameof(SyncMemberAzureDatabaseResourceId)))
                {
                    throw new PSArgumentException(
                        Microsoft.Azure.Commands.Sql.Properties.Resources.SyncMemberIdRequired, nameof(SyncMemberAzureDatabaseResourceId));
                }

                newModel.UsePrivateLinkConnection = this.UsePrivateLinkConnection;
                newModel.SyncMemberAzureDatabaseResourceId = this.SyncMemberAzureDatabaseResourceId;
            }

            if (MyInvocation.BoundParameters.ContainsKey("MemberDatabaseCredential"))
            {
                newModel.MemberDatabaseUserName = this.MemberDatabaseCredential.UserName;
                newModel.MemberDatabasePassword = this.MemberDatabaseCredential.Password;
            }
            else
            {
                newModel.MemberDatabaseUserName = null;
                newModel.MemberDatabasePassword = null;
            }

            return model;
        }

        /// <summary>
        /// Update the sync member
        /// </summary>
        /// <param name="entity">The output of apply user input to model</param>
        /// <returns>The input entity</returns>
        protected override IEnumerable<AzureSqlSyncMemberModel> PersistChanges(IEnumerable<AzureSqlSyncMemberModel> entity)
        {
            return new List<AzureSqlSyncMemberModel>() {
                ModelAdapter.UpdateSyncMember(entity.First())
            };
        }
    }
}
