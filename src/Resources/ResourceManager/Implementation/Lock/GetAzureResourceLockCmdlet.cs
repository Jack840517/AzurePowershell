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
    using System;
    using System.Collections.Concurrent;
    using System.Management.Automation;
    using System.Threading.Tasks;
    using Microsoft.Azure.Commands.ResourceManager.Cmdlets.Extensions;
    using Microsoft.Azure.Commands.ResourceManager.Common;
    using Newtonsoft.Json.Linq;

    /// <summary>
    /// Gets the resource lock.
    /// </summary>
    [Cmdlet("Get", ResourceManager.Common.AzureRMConstants.AzureRMPrefix + "ResourceLock"), OutputType(typeof(PSObject))]
    public class GetAzureResourceLockCmdlet : ResourceLockManagementCmdletBase
    {
        /// <summary>
        /// Contains the errors that encountered while satifying the request.
        /// </summary>
        private readonly ConcurrentBag<ErrorRecord> errors = new ConcurrentBag<ErrorRecord>();

        /// <summary>
        /// Gets or sets the extension resource name parameter.
        /// </summary>
        [Alias("ExtensionResourceName", "Name")]
        [Parameter(ParameterSetName = ResourceLockManagementCmdletBase.ResourceGroupLevelLock, Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = "The name of the lock.")]
        [Parameter(ParameterSetName = ResourceLockManagementCmdletBase.ResourceGroupResourceLevelLock, Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = "The name of the lock.")]
        [Parameter(ParameterSetName = ResourceLockManagementCmdletBase.ScopeLevelLock, Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = "The name of the lock.")]
        [Parameter(ParameterSetName = ResourceLockManagementCmdletBase.SubscriptionLevelLock, Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = "The name of the lock.")]
        [Parameter(ParameterSetName = ResourceLockManagementCmdletBase.SubscriptionResourceLevelLock, Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = "The name of the lock.")]
        [ValidateNotNullOrEmpty]
        public string LockName { get; set; }

        /// <summary>
        /// Gets or sets the at-scope filter.
        /// </summary>
        [Parameter(Mandatory = false, HelpMessage = "When specified returns all locks at or above the specified scope, otherwise returns all locks at, above or below the scope.")]
        [ValidateNotNullOrEmpty]
        public SwitchParameter AtScope { get; set; }

        /// <summary>
        /// Executes the cmdlet.
        /// </summary>
        protected override void OnProcessRecord()
        {
            base.OnProcessRecord();
            PaginatedResponseHelper.ForEach(
                getFirstPage: () => this.GetResources(),
                getNextPage: nextLink => this.GetNextLink<JObject>(nextLink),
                cancellationToken: this.CancellationToken,
                action: resources => this.WriteObject(sendToPipeline: this.GetOutputObjects(resources), enumerateCollection: true));

            if (this.errors.Count != 0)
            {
                foreach (var error in this.errors)
                {
                    this.WriteError(error);
                }
            }
        }

        /// <summary>
        /// Queries the ARM cache and returns the cached resource that match the query specified.
        /// </summary>
        private async Task<ResponseWithContinuation<JObject[]>> GetResources()
        {
            var response = new ResponseWithContinuation<JObject[]> { Value = new JObject[0] };

            try
            {
                if (!string.IsNullOrWhiteSpace(this.LockName))
                {
                    var resource = await this.GetResource().ConfigureAwait(continueOnCapturedContext: false);

                    response.Value = resource.AsArray();
                }
                else
                {
                    response = await this.ListResourcesTypeCollection().ConfigureAwait(continueOnCapturedContext: false);
                }
            }
            catch (Exception ex)
            {
                if (ex.IsFatal())
                {
                    throw;
                }

                ex = (ex is AggregateException)
                    ? (ex as AggregateException).Flatten()
                    : ex;

                this.errors.Add(new ErrorRecord(ex, "ErrorGettingResourceLock", ErrorCategory.CloseError, null));
            }

            return response;
        }

        /// <summary>
        /// Gets a resource.
        /// </summary>
        private async Task<JObject> GetResource()
        {
            var resourceId = this.GetResourceId(this.LockName);

            return await this
                .GetResourcesClient()
                .GetResource<JObject>(
                    resourceId: resourceId,
                    apiVersion: this.LockApiVersion,
                    cancellationToken: this.CancellationToken.Value)
                .ConfigureAwait(continueOnCapturedContext: false);
        }

        /// <summary>
        /// Lists resources in a type collection.
        /// </summary>
        private async Task<ResponseWithContinuation<JObject[]>> ListResourcesTypeCollection()
        {
            var resourceCollectionId = this.GetResourceId(this.LockName);

            var filter = this.AtScope
                ? "$filter=atScope()"
                : null;

            return await this
                .GetResourcesClient()
                .ListObjectColleciton<JObject>(
                    resourceCollectionId: resourceCollectionId,
                    apiVersion: this.LockApiVersion,
                    cancellationToken: this.CancellationToken.Value,
                    odataQuery: filter)
                .ConfigureAwait(continueOnCapturedContext: false);
        }

        /// <summary>
        /// Gets the next set of resources using the <paramref name="nextLink"/>
        /// </summary>
        /// <param name="nextLink">The next link.</param>
        private Task<ResponseWithContinuation<TType[]>> GetNextLink<TType>(string nextLink)
        {
            return this
                .GetResourcesClient()
                .ListNextBatch<TType>(nextLink: nextLink, cancellationToken: this.CancellationToken.Value);
        }
    }
}
