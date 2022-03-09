
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
Creates an order item.
Existing order item cannot be updated with this api and should instead be updated with the Update order item API.
.Description
Creates an order item.
Existing order item cannot be updated with this api and should instead be updated with the Update order item API.
.Example
PS C:\> $contactDetail = New-AzEdgeOrderContactDetailsObject -ContactName ContactName -EmailList @("emailId") -Phone Phone
PS C:\> $ShippingDetails = New-AzEdgeOrderShippingAddressObject -StreetAddress1 "101 TOWNSEND ST" -StateOrProvince "CA" -Country "US" -City "San Francisco" -PostalCode "94107" -AddressType "Commercial"
PS C:\> $HierarchyInformation=New-AzEdgeOrderHierarchyInformationObject -ProductFamilyName "azurestackedge" -ProductLineName "azurestackedge" -ProductName "azurestackedgegpu" -ConfigurationName "EdgeP_High"
PS C:\> $details = New-AzEdgeOrderOrderItemDetailsObject -OrderItemType "Purchase"  -ProductDetail  @{"HierarchyInformation"=$HierarchyInformation}
PS C:\> $orderItem = New-AzEdgeOrderItem -Name "examplePowershell" -ResourceGroupName ResourceGroup -ForwardAddressContactDetail $contactDetail -Location "eastus" -OrderId "/subscriptions/"SubscriptionId"/resourceGroups/resourceGroupName/providers/Microsoft.EdgeOrder/locations/eastus/orders/pwOrderItem11" -OrderItemDetail $details -SubscriptionId SubscriptionId -ForwardShippingAddress $ShippingDetails

PS C:\> $orderItem = New-AzEdgeOrderItem -Name "examplePowershell" -ResourceGroupName "resourceGroupName" -ForwardAddressContactDetail $contactDetail -Location "eastus" -OrderId "/subscriptions/"SubscriptionId"/resourceGroups/resourceGroupName/providers/Microsoft.EdgeOrder/locations/eastus/orders/pwOrderItem11" -OrderItemDetail $details -SubscriptionId SubscriptionId -ForwardShippingAddress $ShippingDetails
PS C:\> $DebugPreference = "Continue"
# You can use `$DebugPreference = "Continue"`, with any example/usecase to get exact details of error in below format when creation command fails.
# {
#   "Error": {
#     "Code": "StaticValidationGenericCountryCodeHasInvalidLength",
#     "Message": "The attribute country code does not meet length constraints.\r\nEnter a value with 2 characters for country code.",
#     "Details": [
#       null
#     ],
#     "Target": null
#   }
# } 
PS C:\> $orderItem = New-AzEdgeOrderItem -Name "examplePowershell" -ResourceGroupName "resourceGroupName" -ForwardAddressContactDetail $contactDetail -Location "eastus" -OrderId "/subscriptions/"SubscriptionId"/resourceGroups/resourceGroupName/providers/Microsoft.EdgeOrder/locations/eastus/orders/pwOrderItem11" -OrderItemDetail $details -SubscriptionId SubscriptionId -ForwardShippingAddress $ShippingDetails
PS C:\> $orderItem | fl

ForwardAddressContactDetail    : Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.ContactDetails
ForwardAddressShippingAddress  : Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.ShippingAddress
ForwardAddressValidationStatus : Valid
Id                             : /subscriptions/SubscriptionId/resourceGroups/resourceGroupName/providers/Microsoft.EdgeOrder/orderItems/examplePowershell
Location                       : eastus
Name                           : examplePowershell
OrderId                        : /subscriptions/SubscriptionId/resourceGroups/resourceGroupName/providers/Microsoft.EdgeOrder/locations/eastus/orders/pwOrderItem11
OrderItemDetail                : Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.OrderItemDetails
ReturnAddressContactDetail     : Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.ContactDetails
ReturnAddressShippingAddress   : Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.ShippingAddress
ReturnAddressValidationStatus  :
StartTime                      : 11/16/2021 10:34:51 AM
SystemData                     : Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20.SystemData
Tag                            : Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20.TrackedResourceTags
Type                           : Microsoft.EdgeOrder/orderItems

.Example
PS C:\> $contactDetail = New-AzEdgeOrderContactDetailsObject -ContactName "ContactName2" -EmailList $env.EmailList -Phone $env.Phone
PS C:\> $ShippingDetails = New-AzEdgeOrderShippingAddressObject -StreetAddress1 $env.StreetAddress1 -StateOrProvince $env.StateOrProvince -Country $env.Country -City $env.City -PostalCode $env.PostalCode -AddressType $env.AddressType
PS C:\> $HierarchyInformation=New-AzEdgeOrderHierarchyInformationObject -ProductFamilyName "azurestackedge" -ProductLineName "azurestackedge" -ProductName "azurestackedgegpu" -ConfigurationName "EdgeP_High"
PS C:\> $preference = New-AzEdgeOrderPreferencesObject -EncryptionPreference @{DoubleEncryptionStatus = "Disabled"} -TransportPreference @{PreferredShipmentType = "MicrosoftManaged"} -ManagementResourcePreference @{PreferredManagementResourceId = "/subscriptions/managementSubscriptionId/resourceGroups/resourceGroupName/providers/Microsoft.DataBoxEdge/DataBoxEdgeDevices/1GPUtest"}
PS C:\> $details = New-AzEdgeOrderOrderItemDetailsObject -OrderItemType "Purchase"  -ProductDetail  @{"HierarchyInformation"=$HierarchyInformation} -Preference $preference
PS C:\> New-AzEdgeOrderItem -Name "OrderItemNameWithPref" -ResourceGroupName "resourceGroupName" -ForwardAddressContactDetail $contactDetail -Location "eastus" -OrderId "/subscriptions/SubscriptionId/resourceGroups/resourceGroupName/providers/Microsoft.EdgeOrder/locations/eastus/orders/pwPrefOrder" -OrderItemDetail $details -SubscriptionId $env.SubscriptionId -ForwardShippingAddress $ShippingDetails

Location Name                  Type
-------- ----                  ----
eastus   OrderItemNameWithPref Microsoft.EdgeOrder/orderItems

.Outputs
Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IOrderItemResource
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

FORWARDADDRESSCONTACTDETAIL <IContactDetails>: Contact details for the address
  ContactName <String>: Contact name of the person.
  EmailList <String[]>: List of Email-ids to be notified about job progress.
  Phone <String>: Phone number of the contact person.
  [Mobile <String>]: Mobile number of the contact person.
  [PhoneExtension <String>]: Phone extension number of the contact person.

FORWARDSHIPPINGADDRESS <IShippingAddress>: Shipping details for the address
  Country <String>: Name of the Country.
  StreetAddress1 <String>: Street Address line 1.
  [AddressType <AddressType?>]: Type of address.
  [City <String>]: Name of the City.
  [CompanyName <String>]: Name of the company.
  [PostalCode <String>]: Postal code.
  [StateOrProvince <String>]: Name of the State or Province.
  [StreetAddress2 <String>]: Street Address line 2.
  [StreetAddress3 <String>]: Street Address line 3.
  [ZipExtendedCode <String>]: Extended Zip Code.

ORDERITEMDETAIL <IOrderItemDetails>: Represents order item details.
  OrderItemType <OrderItemType>: Order item type.
  ProductDetail <IProductDetails>: Unique identifier for configuration.
    HierarchyInformation <IHierarchyInformation>: Hierarchy of the product which uniquely identifies the product
      [ConfigurationName <String>]: Represents configuration name that uniquely identifies configuration
      [ProductFamilyName <String>]: Represents product family name that uniquely identifies product family
      [ProductLineName <String>]: Represents product line name that uniquely identifies product line
      [ProductName <String>]: Represents product name that uniquely identifies product
  [NotificationEmailList <String[]>]: Additional notification email list
  [Preference <IPreferences>]: Customer notification Preferences
    [EncryptionPreference <IEncryptionPreferences>]: Preferences related to the Encryption.
      [DoubleEncryptionStatus <DoubleEncryptionStatus?>]: Double encryption status as entered by the customer. It is compulsory to give this parameter if the 'Deny' or 'Disabled' policy is configured.
    [ManagementResourcePreference <IManagementResourcePreferences>]: Preferences related to the Management resource.
      [PreferredManagementResourceId <String>]: Customer preferred Management resource ARM ID
    [NotificationPreference <INotificationPreference[]>]: Notification preferences.
      SendNotification <Boolean>: Notification is required or not.
      StageName <NotificationStageName>: Name of the stage.
    [TransportPreference <ITransportPreferences>]: Preferences related to the shipment logistics of the order.
      PreferredShipmentType <TransportShipmentTypes>: Indicates Shipment Logistics type that the customer preferred.
.Link
https://docs.microsoft.com/powershell/module/az.edgeorder/new-azedgeorderitem
#>
function New-AzEdgeOrderItem {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IOrderItemResource])]
[CmdletBinding(DefaultParameterSetName='CreateExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(Mandatory)]
    [Alias('OrderItemName')]
    [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Category('Path')]
    [System.String]
    # The name of the order item
    ${Name},

    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Category('Path')]
    [System.String]
    # The name of the resource group.
    # The name is case insensitive.
    ${ResourceGroupName},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String]
    # The ID of the target subscription.
    ${SubscriptionId},

    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IContactDetails]
    # Contact details for the address
    # To construct, see NOTES section for FORWARDADDRESSCONTACTDETAIL properties and create a hash table.
    ${ForwardAddressContactDetail},

    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Category('Body')]
    [System.String]
    # The geo-location where the resource lives
    ${Location},

    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Category('Body')]
    [System.String]
    # Id of the order to which order item belongs to
    ${OrderId},

    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IOrderItemDetails]
    # Represents order item details.
    # To construct, see NOTES section for ORDERITEMDETAIL properties and create a hash table.
    ${OrderItemDetail},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IShippingAddress]
    # Shipping details for the address
    # To construct, see NOTES section for FORWARDSHIPPINGADDRESS properties and create a hash table.
    ${ForwardShippingAddress},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.Info(PossibleTypes=([Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20.ITrackedResourceTags]))]
    [System.Collections.Hashtable]
    # Resource tags.
    ${Tag},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command as a job
    ${AsJob},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command asynchronously
    ${NoWait},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Category('Runtime')]
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
            CreateExpanded = 'Az.EdgeOrder.private\New-AzEdgeOrderItem_CreateExpanded';
        }
        if (('CreateExpanded') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('SubscriptionId')) {
            $PSBoundParameters['SubscriptionId'] = (Get-AzContext).Subscription.Id
        }
        $cmdInfo = Get-Command -Name $mapping[$parameterSet]
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.MessageAttributeHelper]::ProcessCustomAttributesAtRuntime($cmdInfo, $MyInvocation, $parameterSet, $PSCmdlet)
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