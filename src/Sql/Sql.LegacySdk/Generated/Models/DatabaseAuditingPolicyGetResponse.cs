// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using Microsoft.Azure;
using Microsoft.Azure.Management.Sql.LegacySdk.Models;

namespace Microsoft.Azure.Management.Sql.LegacySdk.Models
{
    /// <summary>
    /// Represents the response to a get database auditing policy request.
    /// </summary>
    public partial class DatabaseAuditingPolicyGetResponse : AzureOperationResponse
    {
        private DatabaseAuditingPolicy _auditingPolicy;
        
        /// <summary>
        /// Optional. Gets or sets the Azure Sql Database auditing policy.
        /// </summary>
        public DatabaseAuditingPolicy AuditingPolicy
        {
            get { return this._auditingPolicy; }
            set { this._auditingPolicy = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the DatabaseAuditingPolicyGetResponse
        /// class.
        /// </summary>
        public DatabaseAuditingPolicyGetResponse()
        {
        }
    }
}
