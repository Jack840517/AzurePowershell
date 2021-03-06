//  
// Copyright (c) Microsoft.  All rights reserved.
// 
//  Licensed under the Apache License, Version 2.0 (the "License");
//  you may not use this file except in compliance with the License.
//  You may obtain a copy of the License at
//    http://www.apache.org/licenses/LICENSE-2.0
// 
//  Unless required by applicable law or agreed to in writing, software
//  distributed under the License is distributed on an "AS IS" BASIS,
//  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//  See the License for the specific language governing permissions and
//  limitations under the License.

namespace Microsoft.Azure.Commands.ApiManagement.ServiceManagement.Commands
{
    using System;
    using System.Management.Automation;
    using Models;
    using Properties;

    [Cmdlet("New", ResourceManager.Common.AzureRMConstants.AzureRMPrefix + "ApiManagementApiRevision", SupportsShouldProcess = true)]
    [OutputType(typeof(PsApiManagementApi))]
    public class NewAzureApiManagementApiRevision : AzureApiManagementCmdletBase
    {
        [Parameter(
            ValueFromPipeline = true,
            Mandatory = true,
            HelpMessage = "Instance of PsApiManagementContext. This parameter is required.")]
        [ValidateNotNullOrEmpty]
        public PsApiManagementContext Context { get; set; }

        [Parameter(
            ValueFromPipelineByPropertyName = true,
            Mandatory = true,
            HelpMessage = "Identifier for API whose Revision is to be created. ")]
        [ValidateNotNullOrEmpty]
        public String ApiId { get; set; }

        [Parameter(
            ValueFromPipelineByPropertyName = true,
            Mandatory = true,
            HelpMessage = "Revision Identifier of the Api.")]
        [ValidateNotNullOrEmpty]
        public String ApiRevision { get; set; }

        [Parameter(
            ValueFromPipelineByPropertyName = true,
            Mandatory = false,
            HelpMessage = "Api Revision Description. This parameter is optional.")]
        public String ApiRevisionDescription { get; set; }

        [Parameter(
            ValueFromPipelineByPropertyName = true,
            Mandatory = false,
            HelpMessage = "Api Revision identifier of the source API. This parameter is optional. If specified the new revision will be created after copying " +
            "all operations, policies and tags from the SourceApiRevision.")]
        public String SourceApiRevision { get; set; }

        [Parameter(
            ValueFromPipelineByPropertyName = true,
            Mandatory = false,
            HelpMessage = "A URL of the web service exposing the API in the Backend service. " +
            "This URL will be used by Azure API Management only, and will not be made public. " +
            "Must be 1 to 2000 characters long. This parameter is optional. If specified it will override the serviceurl of the SourceApi.")]
        [ValidateNotNullOrEmpty]
        public String ServiceUrl { get; set; }

        public override void ExecuteApiManagementCmdlet()
        {
            if (ShouldProcess(ApiRevision, Resources.CreateApiRevision))
            {
                var newApi = Client.ApiCreateRevision(
                    Context,
                    ApiId,
                    ApiRevision,
                    SourceApiRevision,
                    ServiceUrl,
                    ApiRevisionDescription);
                WriteObject(newApi);
            }
        }
    }
}
