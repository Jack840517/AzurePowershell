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

using Microsoft.Azure.Commands.Sql.RecommendedAction.Model;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Management.Automation;
using Microsoft.Azure.Management.Sql.LegacySdk.Models;

namespace Microsoft.Azure.Commands.Sql.RecommendedAction.Cmdlet
{
    /// <summary>
    /// Defines the Set-AzSqlDatabaseRecommendedActionState cmdlet
    /// </summary>
    [Cmdlet("Set", ResourceManager.Common.AzureRMConstants.AzureRMPrefix + "SqlDatabaseRecommendedActionState",SupportsShouldProcess = true), OutputType(typeof(AzureSqlDatabaseRecommendedActionModel))]
    public class SetAzureSqlDatabaseRecommendedActionState : AzureSqlDatabaseRecommendedActionCmdletBase
    {
        /// <summary>
        /// Gets or sets the name of the recommended action.
        /// </summary>
        [Parameter(Mandatory = true,
            ValueFromPipelineByPropertyName = true,
            HelpMessage = "Azure SQL Database RecommendedAction name.")]
        [ValidateNotNullOrEmpty]
        public string RecommendedActionName { get; set; }

        /// <summary>
        /// Gets or sets the new state of Azure SQL Database Recommended Action.
        /// </summary>
        [Parameter(Mandatory = true,
            ValueFromPipelineByPropertyName = true,
            HelpMessage = "The new state of Azure SQL Database Recommended Action.")]
        [ValidateNotNullOrEmpty]
        public RecommendedActionState State { get; set; }

        /// <summary>
        /// Gets entities from the service.
        /// </summary>
        /// <returns>A list of entities</returns>
        protected override IEnumerable<AzureSqlDatabaseRecommendedActionModel> GetEntity()
        {
            return new List<AzureSqlDatabaseRecommendedActionModel>() {
                ModelAdapter.GetDatabaseRecommendedAction(this.ResourceGroupName, this.ServerName, this.DatabaseName, this.AdvisorName, this.RecommendedActionName)
            };
        }

        /// <summary>
        /// Create the model from user input
        /// </summary>
        /// <param name="model">Model retrieved from service</param>
        /// <returns>The model that was passed in</returns>
        protected override IEnumerable<AzureSqlDatabaseRecommendedActionModel> ApplyUserInputToModel(IEnumerable<AzureSqlDatabaseRecommendedActionModel> model)
        {
            List<AzureSqlDatabaseRecommendedActionModel> newEntity = new List<AzureSqlDatabaseRecommendedActionModel>();
            newEntity.Add(new AzureSqlDatabaseRecommendedActionModel()
            {
                ResourceGroupName = ResourceGroupName,
                ServerName = ServerName,
                DatabaseName = DatabaseName,
                AdvisorName = AdvisorName,
                RecommendedActionName = RecommendedActionName,
                State = new RecommendedActionStateInfo()
                {
                    CurrentValue = State.ToString()
                }
            });

            return newEntity;
        }

        /// <summary>
        /// Update the recommended action
        /// </summary>
        /// <param name="entity">The output of apply user input to model</param>
        /// <returns>The input entity</returns>
        protected override IEnumerable<AzureSqlDatabaseRecommendedActionModel> PersistChanges(IEnumerable<AzureSqlDatabaseRecommendedActionModel> entity)
        {
            return new List<AzureSqlDatabaseRecommendedActionModel>() {
                ModelAdapter.UpdateState(entity.Single())
            };
        }

        /// <summary>
        /// Entry point for the cmdlet
        /// </summary>
        public override void ExecuteCmdlet()
        {
            if (!ShouldProcess(
                    string.Format(CultureInfo.InvariantCulture, Properties.Resources.SetRecommendedActionStateDescription, this.RecommendedActionName, this.State),
                    string.Format(CultureInfo.InvariantCulture, Properties.Resources.SetRecommendedActionStateWarning, this.RecommendedActionName, this.State),
                    Properties.Resources.ShouldProcessCaption))
            {
                return;
            }

            base.ExecuteCmdlet();
        }
    }
}
