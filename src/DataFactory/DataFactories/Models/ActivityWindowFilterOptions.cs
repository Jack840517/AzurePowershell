
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

namespace Microsoft.Azure.Commands.DataFactories
{
    public class ActivityWindowFilterOptions
    {
        public string ResourceGroupName { get; set; }

        public string DataFactoryName { get; set; }

        public string DatasetName { get; set; }

        public string PipelineName { get; set; }

        public string ActivityName { get; set; }

        public string WindowState { get; set; }

        public string WindowSubstate { get; set; }

        public string Filter { get; set; }

        public string OrderBy { get; set; }

        public DateTime? WindowStart { get; set; }

        public DateTime? WindowEnd { get; set; }

        public DateTime? RunStart { get; set; }

        public DateTime? RunEnd { get; set; }

        public int? Top { get; set; }

        public string NextLink { get; set; }
    }
}
