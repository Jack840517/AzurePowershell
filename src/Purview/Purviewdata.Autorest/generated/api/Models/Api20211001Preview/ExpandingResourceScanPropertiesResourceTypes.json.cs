// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Extensions;

    public partial class ExpandingResourceScanPropertiesResourceTypes
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json erialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Json.JsonObject container);

        /// <summary>
        /// <c>BeforeFromJson</c> will be called before the json deserialization has commenced, allowing complete customization of
        /// the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        /// <param name="returnNow">Determines if the rest of the deserialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Json.JsonObject json, ref bool returnNow);

        /// <summary>
        /// <c>BeforeToJson</c> will be called before the json serialization has commenced, allowing complete customization of the
        /// object before it is serialized.
        /// If you wish to disable the default serialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Json.JsonObject into a new instance of <see cref="ExpandingResourceScanPropertiesResourceTypes"
        /// />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal ExpandingResourceScanPropertiesResourceTypes(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_none = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Json.JsonObject>("None"), out var __jsonNone) ? Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.ResourceTypeFilter.FromJson(__jsonNone) : None;}
            {_azureSubscription = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Json.JsonObject>("AzureSubscription"), out var __jsonAzureSubscription) ? Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.ResourceTypeFilter.FromJson(__jsonAzureSubscription) : AzureSubscription;}
            {_azureResourceGroup = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Json.JsonObject>("AzureResourceGroup"), out var __jsonAzureResourceGroup) ? Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.ResourceTypeFilter.FromJson(__jsonAzureResourceGroup) : AzureResourceGroup;}
            {_azureSynapseWorkspace = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Json.JsonObject>("AzureSynapseWorkspace"), out var __jsonAzureSynapseWorkspace) ? Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.ResourceTypeFilter.FromJson(__jsonAzureSynapseWorkspace) : AzureSynapseWorkspace;}
            {_azureSynapse = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Json.JsonObject>("AzureSynapse"), out var __jsonAzureSynapse) ? Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.ResourceTypeFilter.FromJson(__jsonAzureSynapse) : AzureSynapse;}
            {_adlsGen1 = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Json.JsonObject>("AdlsGen1"), out var __jsonAdlsGen1) ? Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.ResourceTypeFilter.FromJson(__jsonAdlsGen1) : AdlsGen1;}
            {_adlsGen2 = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Json.JsonObject>("AdlsGen2"), out var __jsonAdlsGen2) ? Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.ResourceTypeFilter.FromJson(__jsonAdlsGen2) : AdlsGen2;}
            {_amazonAccount = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Json.JsonObject>("AmazonAccount"), out var __jsonAmazonAccount) ? Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.ResourceTypeFilter.FromJson(__jsonAmazonAccount) : AmazonAccount;}
            {_amazonS3 = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Json.JsonObject>("AmazonS3"), out var __jsonAmazonS3) ? Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.ResourceTypeFilter.FromJson(__jsonAmazonS3) : AmazonS3;}
            {_amazonSql = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Json.JsonObject>("AmazonSql"), out var __jsonAmazonSql) ? Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.ResourceTypeFilter.FromJson(__jsonAmazonSql) : AmazonSql;}
            {_azureCosmosDb = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Json.JsonObject>("AzureCosmosDb"), out var __jsonAzureCosmosDb) ? Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.ResourceTypeFilter.FromJson(__jsonAzureCosmosDb) : AzureCosmosDb;}
            {_azureDataExplorer = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Json.JsonObject>("AzureDataExplorer"), out var __jsonAzureDataExplorer) ? Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.ResourceTypeFilter.FromJson(__jsonAzureDataExplorer) : AzureDataExplorer;}
            {_azureFileService = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Json.JsonObject>("AzureFileService"), out var __jsonAzureFileService) ? Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.ResourceTypeFilter.FromJson(__jsonAzureFileService) : AzureFileService;}
            {_azureSqlDatabase = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Json.JsonObject>("AzureSqlDatabase"), out var __jsonAzureSqlDatabase) ? Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.ResourceTypeFilter.FromJson(__jsonAzureSqlDatabase) : AzureSqlDatabase;}
            {_amazonPostgreSql = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Json.JsonObject>("AmazonPostgreSql"), out var __jsonAmazonPostgreSql) ? Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.ResourceTypeFilter.FromJson(__jsonAmazonPostgreSql) : AmazonPostgreSql;}
            {_azurePostgreSql = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Json.JsonObject>("AzurePostgreSql"), out var __jsonAzurePostgreSql) ? Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.ResourceTypeFilter.FromJson(__jsonAzurePostgreSql) : AzurePostgreSql;}
            {_sqlServerDatabase = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Json.JsonObject>("SqlServerDatabase"), out var __jsonSqlServerDatabase) ? Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.ResourceTypeFilter.FromJson(__jsonSqlServerDatabase) : SqlServerDatabase;}
            {_azureSqlDatabaseManagedInstance = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Json.JsonObject>("AzureSqlDatabaseManagedInstance"), out var __jsonAzureSqlDatabaseManagedInstance) ? Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.ResourceTypeFilter.FromJson(__jsonAzureSqlDatabaseManagedInstance) : AzureSqlDatabaseManagedInstance;}
            {_azureSqlDataWarehouse = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Json.JsonObject>("AzureSqlDataWarehouse"), out var __jsonAzureSqlDataWarehouse) ? Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.ResourceTypeFilter.FromJson(__jsonAzureSqlDataWarehouse) : AzureSqlDataWarehouse;}
            {_azureMySql = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Json.JsonObject>("AzureMySql"), out var __jsonAzureMySql) ? Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.ResourceTypeFilter.FromJson(__jsonAzureMySql) : AzureMySql;}
            {_azureStorage = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Json.JsonObject>("AzureStorage"), out var __jsonAzureStorage) ? Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.ResourceTypeFilter.FromJson(__jsonAzureStorage) : AzureStorage;}
            {_teradata = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Json.JsonObject>("Teradata"), out var __jsonTeradata) ? Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.ResourceTypeFilter.FromJson(__jsonTeradata) : Teradata;}
            {_oracle = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Json.JsonObject>("Oracle"), out var __jsonOracle) ? Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.ResourceTypeFilter.FromJson(__jsonOracle) : Oracle;}
            {_sapS4Hana = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Json.JsonObject>("SapS4Hana"), out var __jsonSapS4Hana) ? Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.ResourceTypeFilter.FromJson(__jsonSapS4Hana) : SapS4Hana;}
            {_sapEcc = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Json.JsonObject>("SapEcc"), out var __jsonSapEcc) ? Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.ResourceTypeFilter.FromJson(__jsonSapEcc) : SapEcc;}
            {_powerBi = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Json.JsonObject>("PowerBI"), out var __jsonPowerBi) ? Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.ResourceTypeFilter.FromJson(__jsonPowerBi) : PowerBi;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IExpandingResourceScanPropertiesResourceTypes.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IExpandingResourceScanPropertiesResourceTypes.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IExpandingResourceScanPropertiesResourceTypes FromJson(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Json.JsonObject json ? new ExpandingResourceScanPropertiesResourceTypes(json) : null;
        }

        /// <summary>
        /// Serializes this instance of <see cref="ExpandingResourceScanPropertiesResourceTypes" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Json.JsonNode"
        /// />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="ExpandingResourceScanPropertiesResourceTypes" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Json.JsonNode"
        /// />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            AddIf( null != this._none ? (Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Json.JsonNode) this._none.ToJson(null,serializationMode) : null, "None" ,container.Add );
            AddIf( null != this._azureSubscription ? (Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Json.JsonNode) this._azureSubscription.ToJson(null,serializationMode) : null, "AzureSubscription" ,container.Add );
            AddIf( null != this._azureResourceGroup ? (Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Json.JsonNode) this._azureResourceGroup.ToJson(null,serializationMode) : null, "AzureResourceGroup" ,container.Add );
            AddIf( null != this._azureSynapseWorkspace ? (Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Json.JsonNode) this._azureSynapseWorkspace.ToJson(null,serializationMode) : null, "AzureSynapseWorkspace" ,container.Add );
            AddIf( null != this._azureSynapse ? (Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Json.JsonNode) this._azureSynapse.ToJson(null,serializationMode) : null, "AzureSynapse" ,container.Add );
            AddIf( null != this._adlsGen1 ? (Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Json.JsonNode) this._adlsGen1.ToJson(null,serializationMode) : null, "AdlsGen1" ,container.Add );
            AddIf( null != this._adlsGen2 ? (Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Json.JsonNode) this._adlsGen2.ToJson(null,serializationMode) : null, "AdlsGen2" ,container.Add );
            AddIf( null != this._amazonAccount ? (Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Json.JsonNode) this._amazonAccount.ToJson(null,serializationMode) : null, "AmazonAccount" ,container.Add );
            AddIf( null != this._amazonS3 ? (Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Json.JsonNode) this._amazonS3.ToJson(null,serializationMode) : null, "AmazonS3" ,container.Add );
            AddIf( null != this._amazonSql ? (Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Json.JsonNode) this._amazonSql.ToJson(null,serializationMode) : null, "AmazonSql" ,container.Add );
            AddIf( null != this._azureCosmosDb ? (Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Json.JsonNode) this._azureCosmosDb.ToJson(null,serializationMode) : null, "AzureCosmosDb" ,container.Add );
            AddIf( null != this._azureDataExplorer ? (Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Json.JsonNode) this._azureDataExplorer.ToJson(null,serializationMode) : null, "AzureDataExplorer" ,container.Add );
            AddIf( null != this._azureFileService ? (Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Json.JsonNode) this._azureFileService.ToJson(null,serializationMode) : null, "AzureFileService" ,container.Add );
            AddIf( null != this._azureSqlDatabase ? (Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Json.JsonNode) this._azureSqlDatabase.ToJson(null,serializationMode) : null, "AzureSqlDatabase" ,container.Add );
            AddIf( null != this._amazonPostgreSql ? (Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Json.JsonNode) this._amazonPostgreSql.ToJson(null,serializationMode) : null, "AmazonPostgreSql" ,container.Add );
            AddIf( null != this._azurePostgreSql ? (Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Json.JsonNode) this._azurePostgreSql.ToJson(null,serializationMode) : null, "AzurePostgreSql" ,container.Add );
            AddIf( null != this._sqlServerDatabase ? (Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Json.JsonNode) this._sqlServerDatabase.ToJson(null,serializationMode) : null, "SqlServerDatabase" ,container.Add );
            AddIf( null != this._azureSqlDatabaseManagedInstance ? (Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Json.JsonNode) this._azureSqlDatabaseManagedInstance.ToJson(null,serializationMode) : null, "AzureSqlDatabaseManagedInstance" ,container.Add );
            AddIf( null != this._azureSqlDataWarehouse ? (Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Json.JsonNode) this._azureSqlDataWarehouse.ToJson(null,serializationMode) : null, "AzureSqlDataWarehouse" ,container.Add );
            AddIf( null != this._azureMySql ? (Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Json.JsonNode) this._azureMySql.ToJson(null,serializationMode) : null, "AzureMySql" ,container.Add );
            AddIf( null != this._azureStorage ? (Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Json.JsonNode) this._azureStorage.ToJson(null,serializationMode) : null, "AzureStorage" ,container.Add );
            AddIf( null != this._teradata ? (Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Json.JsonNode) this._teradata.ToJson(null,serializationMode) : null, "Teradata" ,container.Add );
            AddIf( null != this._oracle ? (Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Json.JsonNode) this._oracle.ToJson(null,serializationMode) : null, "Oracle" ,container.Add );
            AddIf( null != this._sapS4Hana ? (Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Json.JsonNode) this._sapS4Hana.ToJson(null,serializationMode) : null, "SapS4Hana" ,container.Add );
            AddIf( null != this._sapEcc ? (Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Json.JsonNode) this._sapEcc.ToJson(null,serializationMode) : null, "SapEcc" ,container.Add );
            AddIf( null != this._powerBi ? (Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Json.JsonNode) this._powerBi.ToJson(null,serializationMode) : null, "PowerBI" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}