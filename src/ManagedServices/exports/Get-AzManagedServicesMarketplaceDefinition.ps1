
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
Get the marketplace registration definition for the marketplace identifier.
.Description
Get the marketplace registration definition for the marketplace identifier.
.Example
PS C:\> Get-AzManagedServicesMarketplaceDefinition -MarketplaceIdentifier marketplace_test.managed_offer.managed_plan1.1.0.1 | Format-List Id, PlanProduct, PlanPublisher, PlanName, PlanVersion

Id            : /providers/Microsoft.ManagedServices/marketplaceRegistrationDefinitions/marketplace_test.managed_offer.managed_plan1.1.0.1
PlanProduct   : managed_offer
PlanPublisher : marketplace_test
PlanName      : managed_plan1
PlanVersion   : 1.0.1

.Inputs
Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.IManagedServicesIdentity
.Outputs
Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IMarketplaceRegistrationDefinition
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

INPUTOBJECT <IManagedServicesIdentity>: Identity Parameter
  [Id <String>]: Resource identity path
  [MarketplaceIdentifier <String>]: The Azure Marketplace identifier. Expected formats: {publisher}.{product[-preview]}.{planName}.{version} or {publisher}.{product[-preview]}.{planName} or {publisher}.{product[-preview]} or {publisher}).
  [RegistrationAssignmentId <String>]: The GUID of the registration assignment.
  [RegistrationDefinitionId <String>]: The GUID of the registration definition.
  [Scope <String>]: The scope of the resource.
.Link
https://docs.microsoft.com/powershell/module/az.managedservices/get-azmanagedservicesmarketplacedefinition
#>
function Get-AzManagedServicesMarketplaceDefinition {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IMarketplaceRegistrationDefinition])]
[CmdletBinding(DefaultParameterSetName='ListWithScope', PositionalBinding=$false)]
param(
    [Parameter(ParameterSetName='ListWithScope')]
    [Parameter(ParameterSetName='GetWithScope')]
    [Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Runtime.DefaultInfo(Script='"subscriptions/" + (Get-AzContext).Subscription.Id')]
    [System.String]
    # The scope of the resource.
    ${Scope},

    [Parameter(ParameterSetName='GetWithoutScope', Mandatory)]
    [Parameter(ParameterSetName='GetWithScope', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Category('Path')]
    [System.String]
    # The Azure Marketplace identifier.
    # Expected formats: {publisher}.{product[-preview]}.{planName}.{version} or {publisher}.{product[-preview]}.{planName} or {publisher}.{product[-preview]} or {publisher}).
    ${MarketplaceIdentifier},

    [Parameter(ParameterSetName='GetViaIdentity', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.IManagedServicesIdentity]
    # Identity Parameter
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
    ${InputObject},

    [Parameter(ParameterSetName='ListWithScope')]
    [Parameter(ParameterSetName='ListWithoutScope')]
    [Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Category('Query')]
    [System.String]
    # The filter query parameter to filter marketplace registration definitions by plan identifier, publisher, version etc.
    ${Filter},

    [Parameter(ParameterSetName='GetWithoutScope', Mandatory)]
    [Parameter(ParameterSetName='ListWithoutScope', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Category('Query')]
    [System.Management.Automation.SwitchParameter]
    # The filter query parameter to filter marketplace registration definitions by plan identifier, publisher, version etc.
    ${Tenant},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Category('Runtime')]
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
            ListWithScope = 'Az.ManagedServices.custom\Get-AzManagedServicesMarketplaceDefinition';
            GetWithoutScope = 'Az.ManagedServices.custom\Get-AzManagedServicesMarketplaceDefinition';
            GetWithScope = 'Az.ManagedServices.custom\Get-AzManagedServicesMarketplaceDefinition';
            GetViaIdentity = 'Az.ManagedServices.custom\Get-AzManagedServicesMarketplaceDefinition';
            ListWithoutScope = 'Az.ManagedServices.custom\Get-AzManagedServicesMarketplaceDefinition';
        }
        if (('ListWithScope', 'GetWithScope') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('Scope')) {
            $PSBoundParameters['Scope'] = "subscriptions/" + (Get-AzContext).Subscription.Id
        }
        $cmdInfo = Get-Command -Name $mapping[$parameterSet]
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Runtime.MessageAttributeHelper]::ProcessCustomAttributesAtRuntime($cmdInfo, $MyInvocation, $parameterSet, $PSCmdlet)
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