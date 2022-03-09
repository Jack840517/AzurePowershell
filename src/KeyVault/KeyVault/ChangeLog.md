<!--
    Please leave this section at the top of the change log.

    Changes for the upcoming release should go under the section titled "Upcoming Release", and should adhere to the following format:

    ## Upcoming Release
    * Overview of change #1
        - Additional information about change #1
    * Overview of change #2
        - Additional information about change #2
        - Additional information about change #2
    * Overview of change #3
    * Overview of change #4
        - Additional information about change #4

    ## YYYY.MM.DD - Version X.Y.Z (Previous Release)
    * Overview of change #1
        - Additional information about change #1
-->
## Upcoming Release

## Version 4.3.0
* `New-AzKeyVaultManagedHsm`: supported specifying how long a deleted managed hsm is retained by `SoftDeleteRetentionInDays` and enabling purge protection by `EnablePurgeProtection`
* `Update-AzKeyVaultManagedHsm`: supported enabling purge protection by `EnablePurgeProtection`
* `Get-AzKeyVaultManagedHsm`: Supported getting or listing deleted managed HSM(s)
* `Remove-AzKeyVaultManagedHsm`: Supported purging a specified deleted managed HSM

## Version 4.2.1
* Improved the error message of Az.KeyVault.Extension [#16798]
* Added default access policies for Key Vault key as "All but purge"
* Absorbed KeyOps from parameter when importing key from certificate on managed HSM [#16773]
* Fixed a bug when updating key operations on managed HSM [#16774]
* Fixed the issue when importing no-password certificate [#16742]

## Version 4.2.0
* Added cmdlets: `Invoke-AzKeyVaultKeyRotation`, `Get-AzKeyVaultKeyRotationPolicy` and `Set-AzKeyVaultKeyRotationPolicy`

## Version 4.1.0
* [Breaking Change] Renamed properties of `PSKeyVaultPermission` type to follow the pattern of Azure RBAC.
* Migrated AAD Graph API to MSGraph API.
* Added a message to `Set-AzKeyVaultAccessPolicy` stating that for the Permissions parameters, using the 'All' option will not include the 'Purge' permission.

## Version 3.6.1
* Added warning message of upcoming breaking change to `New-AzKeyVaultRoleDefinition` and `Get-AzKeyVaultRoleDefinition`.
    - To comply with the syntax of `New-AzRoleDefinition` and `Get-AzRoleDefinition` we are going to rename some of the properties of `PSKeyVaultPermission` model, which might affect these two cmdlets.
* Added warnings of upcoming breaking change of migrating to Microsoft Graph.

## Version 3.6.0
* Supported custom role definitions on managed HSM:
    - Create via `New-AzKeyVaultRoleDefinition`,
    - Delete via `Remove-AzKeyVaultRoleDefinition`,
    - Filter all custom roles via `Get-AzKeyVaultRoleDefinition -Custom`.
* Supported Encrypt/Decrypt/Wrap/Unwrap using keys [#15679]
* Enabled managing resources in other subscriptions without switching the context by adding `-Subscription <String>`.

## Version 3.5.0
* Supported adding EC keys in key vault [#15699]

## Version 3.4.5
* Removed duplicate list item in `Get-AzKeyVault` [#15164]
* Added `SecretManagement` tag to `Az.KeyVault` module [#15173]

## Version 3.4.4
* Provided key size for RSA key [#14819]

## Version 3.4.3
* Fixed a bug for `Get-AzKeyVaultSecret -IncludeVersions` when current version is disabled [#14740]
* Displayed error code and message when updating purged secret [#14800]

## Version 3.4.2
* Fixed a bug for `Get-AzKeyVaultSecret -AsPlainText` if the secret is not found [#14645]

## Version 3.4.1
* Supported upcoming new API design for `Export-AzKeyVaultSecurityDomain`
* Fixed several typos in cmdlet messages [#14341]

## Version 3.4.0
* Supported specifying key type and curve name when importing keys via a BYOK file

## Version 3.3.1
* Fixed an issue in Secret Management module

## Version 3.3.0
* Added a new parameter `-AsPlainText` to `Get-AzKeyVaultSecret` to directly return the secret in plain text [#13630]
* Supported selective restore a key from a managed HSM full backup [#13526]
* Fixed some minor issues [#13583] [#13584]
* Added missing return objects of `Get-Secret` in SecretManagement module
* Fixed an issue that may cause vault to be created without default access policy [#13687]

## Version 3.2.0
* Supported "all" as an option when setting key vault access policies
* Supported new version of SecretManagement module [#13366]
* Supported ByteArray, String, PSCredential and Hashtable for `SecretValue` in SecretManagementModule [#12190]
* [Breaking change] redesigned the API surface of cmdlets related to managed HSM.

## Version 3.1.0
* Supported updating key vault tag

## Version 3.0.0
* [Breaking Change] Deprecated parameter DisableSoftDelete in `New-AzKeyVault` and EnableSoftDelete in `Update-AzKeyVault`
* [Breaking Change] Removed attribute SecretValueText to avoid displaying SecretValue directly [#12266]
* Supported new resource type: managed HSM
    - CRUD of managed HSM and cmdlets to operate keys on managed HSM
    - Full HSM backup/restore, AES key creation, security domain backup/restore, RBAC

## Version 2.2.1
* Provided the detailed date of removing property SecretValueText

## Version 2.2.0
* Added support for RBAC authorization [#10557]
* Enhanced error handling in `Set-AzKeyVaultAccessPolicy` [#4007]

## Version 2.1.0
* Added warning messages for planning to disable soft delete
* Added warning messages for planning to remove attribute SecretValueText

## Version 2.0.0
* Removed two aliases: `New-AzKeyVaultCertificateAdministratorDetails` and `New-AzKeyVaultCertificateOrganizationDetails`
* Enabled soft delete by default when creating a key vault
* Network rules can be set to govern the accessibility from specific network locations when creating a key vault
* Added support to bring your own key (BYOK)
    - `Add-AzKeyVaultKey` supports generating a key exchange key
    - `Get-AzKeyVaultKey` supports downloading a public key in PEM format
* Updated the "KeyOps" part of the help document of `Add-AzKeyVaultKey`

## Version 1.6.0
* Added a new cmdlet `Update-AzKeyVault` that can enable soft delete and purge protection on a vault
* Added support to Microsoft.PowerShell.SecretManagement [#11178]
* Fixed error in the examples of `Remove-AzKeyVaultManagedStorageSasDefinition` [#11479]
* Added support to private endpoint

## Version 1.5.2
* Added breaking change attributes to `New-AzKeyVault`

## Version 1.5.1
* Fixed duplicated text for Add-AzKeyVaultKey.md

## Version 1.5.0
* Add Name alias to VaultName attribute to make Remove-AzureKeyVault consistent with New-AzureKeyVault.

## Version 1.4.0
* Update references in .psd1 to use relative path
* Fixed error accessing value that is potentially not set
* Elliptic Curve Cryptography Certificate Management
    - Added support to specify the Curve for Certificate Policies

## Version 1.3.1
* Fixed miscellaneous typos across module

## Version 1.3.0
* Added support to specify the KeySize for Certificate Policies

## Version 1.2.0
* Updated cmdlets with plural nouns to singular, and deprecated plural names.
* Fix documentation for wildcards

## Version 1.1.0
* Added wildcard support to KeyVault cmdlets

## Version 1.0.2
* Fix tagging on Set-AzKeyVaultSecret

## Version 1.0.1
* Update incorrect online help URLs

## Version 1.0.0
* General availability of `Az.KeyVault` module
* Remove deprecated PurgeDisabled property from PS models