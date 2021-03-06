
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
Create a in-memory object for PSCredentialExecutionParameter
.Description
Create a in-memory object for PSCredentialExecutionParameter
.Example
PS C:\> New-AzVMwarePSCredentialExecutionParameterObject -Name azps_test_credentialvalue -Password "passwordValue" -Username "usernameValue"

Name                      Type       Password      Username
----                      ----       --------      --------
azps_test_credentialvalue Credential passwordValue usernameValue

.Outputs
Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.PsCredentialExecutionParameter
.Link
https://docs.microsoft.com/powershell/module/az.VMware/new-AzVMwarePSCredentialExecutionParameterObject
#>
function New-AzVMwarePSCredentialExecutionParameterObject {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.PSCredentialExecutionParameter])]
[CmdletBinding(PositionalBinding=$false)]
param(
    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Body')]
    [System.String]
    # The parameter name.
    ${Name},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Body')]
    [System.String]
    # password for login.
    ${Password},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Body')]
    [System.String]
    # username for login.
    ${Username}
)

begin {
    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer)) {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $parameterSet = $PSCmdlet.ParameterSetName
        $mapping = @{
            __AllParameterSets = 'Az.VMware.custom\New-AzVMwarePSCredentialExecutionParameterObject';
        }
        $cmdInfo = Get-Command -Name $mapping[$parameterSet]
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.MessageAttributeHelper]::ProcessCustomAttributesAtRuntime($cmdInfo, $MyInvocation, $parameterSet, $PSCmdlet)
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
