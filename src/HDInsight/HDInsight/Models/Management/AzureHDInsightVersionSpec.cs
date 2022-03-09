﻿// ----------------------------------------------------------------------------------
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

using Microsoft.Azure.Management.HDInsight.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Microsoft.Azure.Commands.HDInsight.Models.Management
{
    public class AzureHDInsightVersionSpec
    {
        public AzureHDInsightVersionSpec(VersionSpec versionSpec)
        {
            this.FriendlyName = versionSpec?.FriendlyName;
            this.DisplayName = versionSpec?.DisplayName;
            this.IsDefault = versionSpec?.IsDefault.ToString();  // ToDo: need to change IsDefault from string to bool, waiting for next major release
            this.ComponentVersions = versionSpec?.ComponentVersions;
        }

        public string FriendlyName { get; set; }
        public string DisplayName { get; set; }
        public string IsDefault { get; set; }
        public IDictionary<string, string> ComponentVersions { get; set; }
    }
}
