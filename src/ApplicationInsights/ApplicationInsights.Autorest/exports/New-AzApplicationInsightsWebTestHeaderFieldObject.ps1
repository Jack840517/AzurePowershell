
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
.Example
PS C:\> New-AzApplicationInsightsWebTestHeaderFieldObject -Name 'version' -Value '2.0.1'

Name    Value
----    -----
version 2.0.1

.Outputs
Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20180501Preview.HeaderField
.Link
https://docs.microsoft.com/powershell/module/az.ApplicationInsights/new-AzApplicationInsightsWebTestHeaderFieldObject
#>
function New-AzApplicationInsightsWebTestHeaderFieldObject {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20180501Preview.HeaderField])]
[CmdletBinding(PositionalBinding=$false)]
param(
    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Category('Body')]
    [System.String]
    # The name of the header.
    ${Name},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Category('Body')]
    [System.String]
    # The value of the header.
    ${Value}
)

begin {
    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer)) {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $parameterSet = $PSCmdlet.ParameterSetName
        $mapping = @{
            __AllParameterSets = 'Az.ApplicationInsights.custom\New-AzApplicationInsightsWebTestHeaderFieldObject';
        }
        $cmdInfo = Get-Command -Name $mapping[$parameterSet]
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.MessageAttributeHelper]::ProcessCustomAttributesAtRuntime($cmdInfo, $MyInvocation, $parameterSet, $PSCmdlet)
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand(($mapping[$parameterSet]), [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters}
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($MyInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }
}

process {
    try {
        $steppablePipeline.Process($_)
    } catch {
        throw
    }
}

end {
    try {
        $steppablePipeline.End()
    } catch {
        throw
    }
}
}
