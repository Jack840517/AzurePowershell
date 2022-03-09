
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
Get the access keys of the resource.
.Description
Get the access keys of the resource.
.Example
PS C:\> Get-AzWebPubSubKey -ResourceGroupName psdemo -ResourceName psdemo-wps  | Format-List

PrimaryConnectionString   : Endpoint=https://psdemo-wps.webpubsub.azure.com;AccessKey=********;Version=1.0;
PrimaryKey                : ********
SecondaryConnectionString : Endpoint=https://psdemo-wps.webpubsub.azure.com;AccessKey=********;Version=1.0;
SecondaryKey              : ********
.Example
PS C:\> $wps = Get-AzWebPubSub -ResourceGroupName psdemo -ResourceName psdemo-wps
PS C:\> $wps | Get-AzWebPubSubKey | Format-List

PrimaryConnectionString   : Endpoint=https://psdemo-wps.webpubsub.azure.com;AccessKey=********;Version=1.0;
PrimaryKey                : ********
SecondaryConnectionString : Endpoint=https://psdemo-wps.webpubsub.azure.com;AccessKey=********;Version=1.0;
SecondaryKey              : ********

.Inputs
Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.IWebPubSubIdentity
.Outputs
Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20211001.IWebPubSubKeys
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

INPUTOBJECT <IWebPubSubIdentity>: Identity Parameter
  [HubName <String>]: The hub name.
  [Id <String>]: Resource identity path
  [Location <String>]: the region
  [PrivateEndpointConnectionName <String>]: The name of the private endpoint connection
  [ResourceGroupName <String>]: The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal.
  [ResourceName <String>]: The name of the resource.
  [SharedPrivateLinkResourceName <String>]: The name of the shared private link resource
  [SubscriptionId <String>]: Gets subscription Id which uniquely identify the Microsoft Azure subscription. The subscription ID forms part of the URI for every service call.
.Link
https://docs.microsoft.com/powershell/module/az.signalr/get-azwebpubsubkey
#>
function Get-AzWebPubSubKey {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20211001.IWebPubSubKeys])]
[CmdletBinding(DefaultParameterSetName='List', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(ParameterSetName='List', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Category('Path')]
    [System.String]
    # The name of the resource group that contains the resource.
    # You can obtain this value from the Azure Resource Manager API or the portal.
    ${ResourceGroupName},

    [Parameter(ParameterSetName='List', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Category('Path')]
    [System.String]
    # The name of the resource.
    ${ResourceName},

    [Parameter(ParameterSetName='List')]
    [Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String[]]
    # Gets subscription Id which uniquely identify the Microsoft Azure subscription.
    # The subscription ID forms part of the URI for every service call.
    ${SubscriptionId},

    [Parameter(ParameterSetName='ListViaIdentity', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.IWebPubSubIdentity]
    # Identity Parameter
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
    ${InputObject},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Use the default credentials for the proxy
    ${ProxyUseDefaultCredentials}
)

begin {
    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer)) {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $parameterSet = $PSCmdlet.ParameterSetName
        $mapping = @{
            List = 'Az.SignalR.private\Get-AzWebPubSubKey_List';
            ListViaIdentity = 'Az.SignalR.custom\Get-AzWebPubSubKey_ListViaIdentity';
        }
        if (('List') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('SubscriptionId')) {
            $PSBoundParameters['SubscriptionId'] = (Get-AzContext).Subscription.Id
        }
        $cmdInfo = Get-Command -Name $mapping[$parameterSet]
        [Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Runtime.MessageAttributeHelper]::ProcessCustomAttributesAtRuntime($cmdInfo, $MyInvocation, $parameterSet, $PSCmdlet)
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