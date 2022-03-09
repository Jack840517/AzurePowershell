#
# Module manifest for module 'Az'
#
# Generated by: Microsoft Corporation
#
# Generated on: 2/24/2022
#

@{

# Script module or binary module file associated with this manifest.
# RootModule = ''

# Version number of this module.
ModuleVersion = '7.3.0'

# Supported PSEditions
CompatiblePSEditions = 'Core', 'Desktop'

# ID used to uniquely identify this module
GUID = 'd48d710e-85cb-46a1-990f-22dae76f6b5f'

# Author of this module
Author = 'Microsoft Corporation'

# Company or vendor of this module
CompanyName = 'Microsoft Corporation'

# Copyright statement for this module
Copyright = 'Microsoft Corporation. All rights reserved.'

# Description of the functionality provided by this module
Description = 'Microsoft Azure PowerShell - Cmdlets to manage resources in Azure. This module is compatible with PowerShell and Windows PowerShell.
For more information about the Az module, please visit the following: https://docs.microsoft.com/powershell/azure/'

# Minimum version of the PowerShell engine required by this module
PowerShellVersion = '5.1'

# Name of the PowerShell host required by this module
# PowerShellHostName = ''

# Minimum version of the PowerShell host required by this module
# PowerShellHostVersion = ''

# Minimum version of Microsoft .NET Framework required by this module. This prerequisite is valid for the PowerShell Desktop edition only.
DotNetFrameworkVersion = '4.7.2'

# Minimum version of the common language runtime (CLR) required by this module. This prerequisite is valid for the PowerShell Desktop edition only.
# ClrVersion = ''

# Processor architecture (None, X86, Amd64) required by this module
# ProcessorArchitecture = ''

# Modules that must be imported into the global environment prior to importing this module
RequiredModules = @(@{ModuleName = 'Az.Accounts'; ModuleVersion = '2.7.3'; }, 
               @{ModuleName = 'Az.Advisor'; RequiredVersion = '1.1.2'; }, 
               @{ModuleName = 'Az.Aks'; RequiredVersion = '3.1.2'; }, 
               @{ModuleName = 'Az.AnalysisServices'; RequiredVersion = '1.1.4'; }, 
               @{ModuleName = 'Az.ApiManagement'; RequiredVersion = '2.3.1'; }, 
               @{ModuleName = 'Az.AppConfiguration'; RequiredVersion = '1.0.0'; }, 
               @{ModuleName = 'Az.ApplicationInsights'; RequiredVersion = '1.3.0'; }, 
               @{ModuleName = 'Az.Attestation'; RequiredVersion = '1.0.0'; }, 
               @{ModuleName = 'Az.Automation'; RequiredVersion = '1.7.3'; }, 
               @{ModuleName = 'Az.Batch'; RequiredVersion = '3.1.1'; }, 
               @{ModuleName = 'Az.Billing'; RequiredVersion = '2.0.0'; }, 
               @{ModuleName = 'Az.Cdn'; RequiredVersion = '1.8.1'; }, 
               @{ModuleName = 'Az.CloudService'; RequiredVersion = '1.1.0'; }, 
               @{ModuleName = 'Az.CognitiveServices'; RequiredVersion = '1.10.0'; }, 
               @{ModuleName = 'Az.Compute'; RequiredVersion = '4.24.0'; }, 
               @{ModuleName = 'Az.ContainerInstance'; RequiredVersion = '3.0.1'; }, 
               @{ModuleName = 'Az.ContainerRegistry'; RequiredVersion = '2.2.3'; }, 
               @{ModuleName = 'Az.CosmosDB'; RequiredVersion = '1.5.1'; }, 
               @{ModuleName = 'Az.DataBoxEdge'; RequiredVersion = '1.1.0'; }, 
               @{ModuleName = 'Az.Databricks'; RequiredVersion = '1.2.0'; }, 
               @{ModuleName = 'Az.DataFactory'; RequiredVersion = '1.16.4'; }, 
               @{ModuleName = 'Az.DataLakeAnalytics'; RequiredVersion = '1.0.2'; }, 
               @{ModuleName = 'Az.DataLakeStore'; RequiredVersion = '1.3.0'; }, 
               @{ModuleName = 'Az.DataShare'; RequiredVersion = '1.0.1'; }, 
               @{ModuleName = 'Az.DesktopVirtualization'; RequiredVersion = '3.1.0'; }, 
               @{ModuleName = 'Az.DeploymentManager'; RequiredVersion = '1.1.0'; }, 
               @{ModuleName = 'Az.DevTestLabs'; RequiredVersion = '1.0.2'; }, 
               @{ModuleName = 'Az.Dns'; RequiredVersion = '1.1.2'; }, 
               @{ModuleName = 'Az.EventGrid'; RequiredVersion = '1.3.0'; }, 
               @{ModuleName = 'Az.EventHub'; RequiredVersion = '1.11.0'; }, 
               @{ModuleName = 'Az.FrontDoor'; RequiredVersion = '1.9.0'; }, 
               @{ModuleName = 'Az.Functions'; RequiredVersion = '4.0.1'; }, 
               @{ModuleName = 'Az.HDInsight'; RequiredVersion = '5.0.0'; }, 
               @{ModuleName = 'Az.HealthcareApis'; RequiredVersion = '1.3.2'; }, 
               @{ModuleName = 'Az.IotHub'; RequiredVersion = '2.7.4'; }, 
               @{ModuleName = 'Az.KeyVault'; RequiredVersion = '4.3.0'; }, 
               @{ModuleName = 'Az.Kusto'; RequiredVersion = '2.0.0'; }, 
               @{ModuleName = 'Az.LogicApp'; RequiredVersion = '1.5.0'; }, 
               @{ModuleName = 'Az.MachineLearning'; RequiredVersion = '1.1.3'; }, 
               @{ModuleName = 'Az.Maintenance'; RequiredVersion = '1.2.0'; }, 
               @{ModuleName = 'Az.ManagedServices'; RequiredVersion = '3.0.0'; }, 
               @{ModuleName = 'Az.MarketplaceOrdering'; RequiredVersion = '1.0.2'; }, 
               @{ModuleName = 'Az.Media'; RequiredVersion = '1.1.1'; }, 
               @{ModuleName = 'Az.Migrate'; RequiredVersion = '1.1.2'; }, 
               @{ModuleName = 'Az.Monitor'; RequiredVersion = '3.0.1'; }, 
               @{ModuleName = 'Az.MySql'; RequiredVersion = '1.0.0'; }, 
               @{ModuleName = 'Az.Network'; RequiredVersion = '4.15.0'; }, 
               @{ModuleName = 'Az.NotificationHubs'; RequiredVersion = '1.1.1'; }, 
               @{ModuleName = 'Az.OperationalInsights'; RequiredVersion = '3.0.1'; }, 
               @{ModuleName = 'Az.PolicyInsights'; RequiredVersion = '1.5.0'; }, 
               @{ModuleName = 'Az.PostgreSql'; RequiredVersion = '1.0.0'; }, 
               @{ModuleName = 'Az.PowerBIEmbedded'; RequiredVersion = '1.1.2'; }, 
               @{ModuleName = 'Az.PrivateDns'; RequiredVersion = '1.0.3'; }, 
               @{ModuleName = 'Az.RecoveryServices'; RequiredVersion = '5.2.0'; }, 
               @{ModuleName = 'Az.RedisCache'; RequiredVersion = '1.6.0'; }, 
               @{ModuleName = 'Az.RedisEnterpriseCache'; RequiredVersion = '1.0.0'; }, 
               @{ModuleName = 'Az.Relay'; RequiredVersion = '1.0.3'; }, 
               @{ModuleName = 'Az.ResourceMover'; RequiredVersion = '1.1.0'; }, 
               @{ModuleName = 'Az.Resources'; RequiredVersion = '5.4.0'; }, 
               @{ModuleName = 'Az.Security'; RequiredVersion = '1.1.1'; }, 
               @{ModuleName = 'Az.SecurityInsights'; RequiredVersion = '1.1.0'; }, 
               @{ModuleName = 'Az.ServiceBus'; RequiredVersion = '1.8.0'; }, 
               @{ModuleName = 'Az.ServiceFabric'; RequiredVersion = '3.0.1'; }, 
               @{ModuleName = 'Az.SignalR'; RequiredVersion = '1.4.1'; }, 
               @{ModuleName = 'Az.Sql'; RequiredVersion = '3.7.1'; }, 
               @{ModuleName = 'Az.SqlVirtualMachine'; RequiredVersion = '1.1.0'; }, 
               @{ModuleName = 'Az.StackHCI'; RequiredVersion = '1.1.0'; }, 
               @{ModuleName = 'Az.Storage'; RequiredVersion = '4.3.0'; }, 
               @{ModuleName = 'Az.StorageSync'; RequiredVersion = '1.7.0'; }, 
               @{ModuleName = 'Az.StreamAnalytics'; RequiredVersion = '2.0.0'; }, 
               @{ModuleName = 'Az.Support'; RequiredVersion = '1.0.0'; }, 
               @{ModuleName = 'Az.Synapse'; RequiredVersion = '1.1.0'; }, 
               @{ModuleName = 'Az.TrafficManager'; RequiredVersion = '1.1.0'; }, 
               @{ModuleName = 'Az.Websites'; RequiredVersion = '2.10.0'; })

# Assemblies that must be loaded prior to importing this module
# RequiredAssemblies = @()

# Script files (.ps1) that are run in the caller's environment prior to importing this module.
# ScriptsToProcess = @()

# Type files (.ps1xml) to be loaded when importing this module
# TypesToProcess = @()

# Format files (.ps1xml) to be loaded when importing this module
# FormatsToProcess = @()

# Modules to import as nested modules of the module specified in RootModule/ModuleToProcess
# NestedModules = @()

# Functions to export from this module, for best performance, do not use wildcards and do not delete the entry, use an empty array if there are no functions to export.
FunctionsToExport = @()

# Cmdlets to export from this module, for best performance, do not use wildcards and do not delete the entry, use an empty array if there are no cmdlets to export.
CmdletsToExport = @()

# Variables to export from this module
# VariablesToExport = @()

# Aliases to export from this module, for best performance, do not use wildcards and do not delete the entry, use an empty array if there are no aliases to export.
AliasesToExport = @()

# DSC resources to export from this module
# DscResourcesToExport = @()

# List of all modules packaged with this module
# ModuleList = @()

# List of all files packaged with this module
# FileList = @()

# Private data to pass to the module specified in RootModule/ModuleToProcess. This may also contain a PSData hashtable with additional module metadata used by PowerShell.
PrivateData = @{

    PSData = @{

        # Tags applied to this module. These help with module discovery in online galleries.
        Tags = 'Azure','ARM','ResourceManager','Linux','AzureAutomationNotSupported'

        # A URL to the license for this module.
        LicenseUri = 'https://aka.ms/azps-license'

        # A URL to the main website for this project.
        ProjectUri = 'https://github.com/Azure/azure-powershell'

        # A URL to an icon representing this module.
        # IconUri = ''

        # ReleaseNotes of this module
        ReleaseNotes = '7.3.0 - March 2022
Az.Accounts
* Fixed the issue that authorization does not work in customized environment [#17157]
* Enabled Continue Access Evaluation for MSGraph
* Improved error message when login is blocked by AAD
* Improved error message when silent reauthentication failed
* Loaded System.Private.ServiceModel and System.ServiceModel.Primitives on Windows PowerShell [#17087]

Az.Aks
* Updated the breaking change warning messages [#16805]

Az.CloudService
* Fixed the issue of ''Get-AzCloudServiceNetworkInterface'' and ''Get-AzCloudServicePublicIPAddress''.

Az.Compute
* Upgraded Compute .NET SDK package reference to version 52.0.0
* Updated ''New-AzSshKey'' cmdlet to write file paths to generated keys to the Warning stream instead of the console.
* Added ''vCPUsAvailable'' and ''vCPUsPerCore'' integer parameters to the ''New-AzVm'', ''New-AzVmConfig'', and ''Update-AzVm'' cmdlets.

Az.ContainerInstance
* Fixed Identity Bug in ImageRegistryCredential

Az.Databricks
* Upgraded API version to 2021-04-01-preview

Az.DataFactory
* Updated ADF .Net SDK version to 5.2.0

Az.DataShare
* Added breaking change warning message due to update API version.

Az.EventHub
* Added MSI properties to New-AzEventHubNamespace and Set-AzEventHubNamespace. Adding New-AzEventHubEncryptionConfig.

Az.KeyVault
* ''New-AzKeyVaultManagedHsm'': supported specifying how long a deleted managed hsm is retained by ''SoftDeleteRetentionInDays'' and enabling purge protection by ''EnablePurgeProtection''
* ''Update-AzKeyVaultManagedHsm'': supported enabling purge protection by ''EnablePurgeProtection''
* ''Get-AzKeyVaultManagedHsm'': Supported getting or listing deleted managed HSM(s)
* ''Remove-AzKeyVaultManagedHsm'': Supported purging a specified deleted managed HSM

Az.Monitor
* Fixed an issue where users could not correctly ignore warning messages after setting environment variables [#17013]

Az.Network
* Added new property ''SqlSetting'' for Azure Firewall Policy cmdlets 
    - ''Get-AzFirewallPolicy'' 
    - ''New-AzFirewallPolicy''
    - ''Set-AzFirewallPolicy''
* Added new to create new ''SqlSetting'' object for creating Azure Firewall Policy
    - ''New-AzFirewallPolicySqlSetting''
* Added new cmdlet to support query Load Balancer inbound nat rule port mapping lists for backend addresses
    - ''Get-AzLoadBalancerBackendAddressInboundNatRulePortMapping''
    - Also updated cmdlets to support inbound nat rule V2 configurations
        - ''New-AzLoadBalancerInboundNatRuleConfig''
        - ''Set-AzLoadBalancerInboundNatRuleConfig''
        - ''Add-AzLoadBalancerInboundNatRuleConfig''

Az.RecoveryServices
* Azure Backup added support for ''Create new virtual machine'' and ''Replace existing virtual machine'' experience for Managed VMs in Restore-AzRecoveryServicesBackupItem cmdlet. To perform a VM restore to AlternateLocation use TargetVMName, TargetVNetName, TargetVNetResourceGroup, TargetSubnetName parameters. To perform a restore to a VM in OriginalLocation, do not provide TargetResourceGroupName and RestoreAsUnmanagedDisks parameters, refer examples for more details.

Az.Resources
* Fixed keycredential key format, from base64url to byte [#17131]
* Fixed add key credential overwrite existing one [#17088]
* Deleted parameter sets cannot be reached for ''New-AzADSericePrincipal''
* Marked ''ObjectType'' as ''Unknown'' if object is not found or current account has insufficient privileges to get object type for role assignment [#16981]
* Fixed that ''Get-AzRoleAssignment'' shows empty RoleDefinitionName for custom roles when not specifying scope [#16991]
* Unified the returned ''RoleDefinitionId'' in PSRoleAssignment to GUID [#16991]

Az.ServiceBus
* Added identity and encryption properties to New-AzServiceBusNamespace and Set-AzServiceBusNamespace.
* Added New-AzServiceBusEncryptionConfig

Az.Storage
* Supported download blob from managed disk account with Sas Uri and bearer token
    -  ''Get-AzStorageBlobContent'' 
* Supported create/upgrade storage account with ActiveDirectorySamAccountName and ActiveDirectoryAccountType
    -  ''New-AzStorageAccount''
    -  ''Set-AzStorageAccount''

Az.StorageSync
* Migrated Azure AD features in Az.StorageSync to MSGraph APIs. The cmdlets will call MSGraph API according to input parameters: New-AzStorageSyncCloudEndpoint
* Changed default parameter set of Invoke-AzStorageSyncChangeDetection to use full share detection

Az.Synapse
* Updated ''Update-AzSynapseSparkPool'' to support new parameter [-ForceApplySetting]
'

        # Prerelease string of this module
        # Prerelease = ''

        # Flag to indicate whether the module requires explicit user acceptance for install/update/save
        # RequireLicenseAcceptance = $false

        # External dependent modules of this module
        # ExternalModuleDependencies = @()

    } # End of PSData hashtable

 } # End of PrivateData hashtable

# HelpInfo URI of this module
# HelpInfoURI = ''

# Default prefix for commands exported from this module. Override the default prefix using Import-Module -Prefix.
# DefaultCommandPrefix = ''

}
