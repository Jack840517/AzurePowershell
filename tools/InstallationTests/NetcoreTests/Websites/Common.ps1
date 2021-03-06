# ----------------------------------------------------------------------------------
#
# Copyright Microsoft Corporation
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
# http://www.apache.org/licenses/LICENSE-2.0
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.
# ----------------------------------------------------------------------------------

function Get-RandomLetters
{
	return -join ((97..122) | Get-Random -Count 5 | % {[char]$_})
}

<#
.SYNOPSIS
Gets a website name for testing.
#>
function Get-WebsiteName
{
    return "someuniqueWebsite$(Get-RandomLetters)"
}

<#
.SYNOPSIS
Gets a website name for testing.
#>
function Get-TrafficManagerProfileName
{
    return "someuniqueTrafficManager"
}

<#
.SYNOPSIS
Gets a website name for testing.
#>
function Get-WebHostPlanName
{
    return "hostplan231" 
}

<#
.SYNOPSIS
Gets a resource group name for testing.
#>
function Get-ResourceGroupName
{
    return "rg$(Get-RandomLetters)"
}

<#
.SYNOPSIS
Gets a backup name for testing.
#>
function Get-BackupName
{
    return "someuniqueBackupName"
}

<#
.SYNOPSIS
Gets an aseName for testing.
#>
function Get-AseName
{
    return "someuniqueAseName"
}

<#
.SYNOPSIS
Gets the location for the Website. Default to West US if none found.
#>
function Get-Location
{
	$namespace = "Microsoft.Web"
	$type = "sites"
	$location = Get-AzureRmResourceProvider -ProviderNamespace $namespace | where {$_.ResourceTypes[0].ResourceTypeName -eq $type}

	if ($location -eq $null) 
	{  
		return "West US"  
	} else 
	{  
		return $location.Locations[0]  
	}
}

<#
.SYNOPSIS
Gets the location for the Website. Default to West US if none found.
#>
function Get-SecondaryLocation
{
	$namespace = "Microsoft.Web"
	$type = "sites"
	$location = Get-AzureRmResourceProvider -ProviderNamespace $namespace | where {$_.ResourceTypes[0].ResourceTypeName -eq $type}

	if ($location -eq $null) 
	{  
		return "East US"  
	} else 
	{  
		return $location.Locations[1]  
	}

	return "EastUS"
}

<#
.SYNOPSIS
Cleans the website
#>
function Clean-Website($resourceGroup, $websiteName)
{
	$result = Remove-AzureRmWebsite -ResourceGroupName $resourceGroup.ToString() -WebsiteName $websiteName.ToString() -Force
}

function PingWebApp($webApp)
{
	try 
	{
		$result = Invoke-WebRequest $webApp.HostNames[0] 
		$statusCode = $result.StatusCode
	} 
	catch [System.Net.WebException ] 
	{ 
		$statusCode = $_.Exception.Response.StatusCode
	}

		return $statusCode
}

# Create a SAS Uri
function Get-SasUri
{
    param ([string] $storageAccount, [string] $storageKey, [string] $container, [TimeSpan] $duration, [Microsoft.WindowsAzure.Storage.Blob.SharedAccessBlobPermissions] $type)

	$uri = "https://$storageAccount.blob.core.windows.net/$container"

	$destUri = New-Object -TypeName System.Uri($uri);
	$cred = New-Object -TypeName Microsoft.WindowsAzure.Storage.Auth.StorageCredentials($storageAccount, $storageKey);
	$destBlob = New-Object -TypeName Microsoft.WindowsAzure.Storage.Blob.CloudPageBlob($destUri, $cred);
	$policy = New-Object Microsoft.WindowsAzure.Storage.Blob.SharedAccessBlobPolicy;
	$policy.Permissions = $type;
	$policy.SharedAccessExpiryTime = (Get-Date).Add($duration);
	$uri += $destBlob.GetSharedAccessSignature($policy);

	return $uri;
}
