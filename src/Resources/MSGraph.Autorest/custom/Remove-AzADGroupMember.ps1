
# ----------------------------------------------------------------------------------
# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the MIT License. See License.txt in the project root for license information.
# Code generated by Microsoft (R) AutoRest Code Generator.
# Changes may cause incorrect behavior and will be lost if the code is regenerated.
# ----------------------------------------------------------------------------------

<#
.Synopsis
Deletes member from group
Users, contacts, and groups that are members of this group.
HTTP Methods: GET (supported for all groups), POST (supported for security groups and mail-enabled security groups), DELETE (supported only for security groups) Read-only.
Nullable.
Supports $expand.
.Description
Deletes member from group
Users, contacts, and groups that are members of this group.
HTTP Methods: GET (supported for all groups), POST (supported for security groups and mail-enabled security groups), DELETE (supported only for security groups) Read-only.
Nullable.
Supports $expand.
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Inputs
System.Collections.Hashtable
.Outputs
System.Boolean
.Link
https://docs.microsoft.com/powershell/module/az.resources/remove-azadgroupmember
#>
function Remove-AzADGroupMember {
    [OutputType([System.Boolean])]
    [CmdletBinding(DefaultParameterSetName = 'ExplicitParameterSet ', PositionalBinding = $false, SupportsShouldProcess, ConfirmImpact = 'Medium')]
    param(
        [Parameter(ParameterSetName='MemberObjectIdWithGroupObjectId', Mandatory, HelpMessage = "The object Id of target group.")]
        [Parameter(ParameterSetName='MemberUPNWithGroupObjectIdParameterSet', Mandatory, HelpMessage = "The object Id of target group.")]
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Category('Path')]
        [System.String]
        # key: id of group
        ${GroupObjectId},

        [Parameter(ParameterSetName='MemberObjectIdWithGroupDisplayName', Mandatory, HelpMessage = "The display name of target group.")]
        [Parameter(ParameterSetName='MemberUPNWithGroupDisplayNameParameterSet', Mandatory, HelpMessage = "The display name of target group.")]
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Category('Path')]
        [System.String]
        ${GroupDisplayName},

        [Parameter(ParameterSetName='MemberObjectIdWithGroupObject', Mandatory, ValueFromPipeline, HelpMessage = "The target group object, could be used as pipeline input.")]
        [Parameter(ParameterSetName='MemberUPNWithGroupObjectParameterSet', Mandatory, ValueFromPipeline, HelpMessage = "The target group object, could be used as pipeline input.")]
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Category('Path')]
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.MicrosoftGraphGroup]
        ${GroupObject},
    
        [Parameter(ParameterSetName='MemberObjectIdWithGroupObjectId', Mandatory, HelpMessage = "The object Id of member to be removed from target group.")]
        [Parameter(ParameterSetName='MemberObjectIdWithGroupDisplayName', Mandatory, HelpMessage = "The object Id of member to be removed from target group.")]
        [Parameter(ParameterSetName='MemberObjectIdWithGroupObject', Mandatory, HelpMessage = "The object Id of member to be removed from target group.")]
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Category('Path')]
        [System.String[]]
        ${MemberObjectId},

        [Parameter(ParameterSetName='MemberUPNWithGroupObjectIdParameterSet', Mandatory, HelpMessage = "The user principal name of member to be removed from target group.")]
        [Parameter(ParameterSetName='MemberUPNWithGroupDisplayNameParameterSet', Mandatory, HelpMessage = "The user principal name of member to be removed from target group.")]
        [Parameter(ParameterSetName='MemberUPNWithGroupObjectParameterSet', Mandatory, HelpMessage = "The user principal name of member to be removed from target group.")]
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Category('Path')]
        [System.String[]]
        ${MemberUserPrincipalName},
    
        [Parameter()]
        [Alias("AzContext", "AzureRmContext", "AzureCredential")]
        [ValidateNotNull()]
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Category('Azure')]
        [System.Management.Automation.PSObject]
        # The credentials, account, tenant, and subscription used for communication with Azure.
        ${DefaultProfile},
    
        [Parameter(DontShow)]
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Category('Runtime')]
        [System.Management.Automation.SwitchParameter]
        # Wait for .NET debugger to attach
        ${Break},
    
        [Parameter(DontShow)]
        [ValidateNotNull()]
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Category('Runtime')]
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.SendAsyncStep[]]
        # SendAsync Pipeline Steps to be appended to the front of the pipeline
        ${HttpPipelineAppend},
    
        [Parameter(DontShow)]
        [ValidateNotNull()]
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Category('Runtime')]
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.SendAsyncStep[]]
        # SendAsync Pipeline Steps to be prepended to the front of the pipeline
        ${HttpPipelinePrepend},
    
        [Parameter()]
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Category('Runtime')]
        [System.Management.Automation.SwitchParameter]
        # Returns true when the command succeeds
        ${PassThru},
    
        [Parameter(DontShow)]
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Category('Runtime')]
        [System.Uri]
        # The URI for the proxy server to use
        ${Proxy},
    
        [Parameter(DontShow)]
        [ValidateNotNull()]
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Category('Runtime')]
        [System.Management.Automation.PSCredential]
        # Credentials for a proxy server to use for the remote call
        ${ProxyCredential},
    
        [Parameter(DontShow)]
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Category('Runtime')]
        [System.Management.Automation.SwitchParameter]
        # Use the default credentials for the proxy
        ${ProxyUseDefaultCredentials}
    )
    
    process {
        if ($PSBoundParameters['PassThru']) {
            $shouldPassThru = $PSBoundParameters['PassThru']
            $null = $PSBoundParameters.Remove('PassThru')
        }

        if ($PSBoundParameters['GroupDisplayName']) {
            $param = @{'DisplayName' = $PSBoundParameters['GroupDisplayName']}
            if ($PSBoundParameters['Debug']) {
                $param['Debug'] = $PSBoundParameters['Debug']
            }
            $PSBoundParameters['GroupId'] = (Get-AzADGroup @param).Id
            $null = $PSBoundParameters.Remove('GroupDisplayName')
        } elseif ($PSBoundParameters['GroupObject']) {
            $PSBoundParameters['GroupId'] = $PSBoundParameters['GroupObject'].Id
            $null = $PSBoundParameters.Remove('GroupObject')
        } else {
            $PSBoundParameters['GroupId'] = $PSBoundParameters['GroupObjectId']
            $null = $PSBoundParameters.Remove('GroupObjectId')
        }

        $members = @()
        if ($PSBoundParameters['MemberUserPrincipalName']) {
            foreach ($name in $PSBoundParameters['MemberUserPrincipalName']) {
                $members += (Get-AzADUser -UserPrincipalName $name).Id
            }
            $null = $PSBoundParameters.Remove('MemberUserPrincipalName')
        } else {
            $members += $PSBoundParameters['MemberObjectId']
            $null = $PSBoundParameters.Remove('MemberObjectId')
        }

        foreach ($member in $members) {
            $PSBoundParameters['MemberId'] = $member
            Az.MSGraph.internal\Remove-AzADGroupRefMember @PSBoundParameters
        }

        if ($shouldPassThru) {
            $PSCmdlet.WriteObject($true)
        }
    }
}
    