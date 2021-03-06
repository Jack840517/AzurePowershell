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

<#
.SYNOPSIS
Tests Managed Application definition CRUD operations
#>
function Test-ManagedApplicationDefinitionCRUD
{
	# Setup
	$rgname = Get-ResourceGroupName
	$appDefName = Get-ResourceName
	$rglocation = "EastUS2EUAP"
	$display = "myAppDefPoSH"

	# Test
	New-AzResourceGroup -Name $rgname -Location $rglocation

	$actual = New-AzManagedApplicationDefinition -Name $appDefName -ResourceGroupName $rgname -DisplayName $display -Description "Test" -Location $rglocation -LockLevel ReadOnly -PackageFileUri https://testclinew.blob.core.windows.net/files/vivekMAD.zip -Authorization 5e91139a-c94b-462e-a6ff-1ee95e8aac07:8e3af657-a8ff-443c-a75c-2fe8c4bcb635
	$expected = Get-AzManagedApplicationDefinition -Name $appDefName -ResourceGroupName $rgname
	Assert-AreEqual $expected.Name $actual.Name
	Assert-AreEqual $expected.ManagedApplicationDefinitionId $actual.ManagedApplicationDefinitionId
	Assert-AreEqual $expected.Properties.DisplayName $actual.Properties.DisplayName
	Assert-NotNull($actual.Properties.Authorizations)

	$actual = Set-AzManagedApplicationDefinition -ResourceId $expected.ManagedApplicationDefinitionId -PackageFileUri https://testclinew.blob.core.windows.net/files/vivekMAD.zip -Description "updated"
	$expected = Get-AzManagedApplicationDefinition -Name $appDefName -ResourceGroupName $rgname
	Assert-AreEqual $expected.Properties.description $actual.Properties.Description

	$list = Get-AzManagedApplicationDefinition -ResourceGroupName $rgname
	Assert-AreEqual 1 @($list).Count

	$remove = Remove-AzManagedApplicationDefinition -Name $appDefName -ResourceGroupName $rgname -Force
	Assert-AreEqual True $remove

}