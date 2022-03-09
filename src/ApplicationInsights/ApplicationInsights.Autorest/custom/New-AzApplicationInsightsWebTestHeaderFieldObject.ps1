
# ----------------------------------------------------------------------------------
# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
# http://www.apache.org/licenses/LICENSE-2.0
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.
# Code generated by Microsoft (R) AutoRest Code Generator.Changes may cause incorrect behavior and will be lost if the code
# is regenerated.
# ----------------------------------------------------------------------------------

<#
.Synopsis
Create a in-memory object for HeaderField
.Description
Create a in-memory object for HeaderField

.Outputs
Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20180501Preview.HeaderField
.Link
https://docs.microsoft.com/powershell/module/az.ApplicationInsights/new-AzApplicationInsightsWebTestHeaderFieldObject
#>
function New-AzApplicationInsightsWebTestHeaderFieldObject {
    [OutputType('Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20180501Preview.HeaderField')]
    [CmdletBinding(PositionalBinding=$false)]
    Param(

        [Parameter(HelpMessage="The name of the header.")]
        [string]
        $Name,
        [Parameter(HelpMessage="The value of the header.")]
        [string]
        $Value
    )

    process {
        $Object = [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20180501Preview.HeaderField]::New()

        $Object.Name = $Name
        $Object.Value = $Value
        return $Object
    }
}
