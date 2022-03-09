// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210
{
    using Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.PowerShell;

    /// <summary>A2A Vm managed disk update details.</summary>
    [System.ComponentModel.TypeConverter(typeof(A2AvmManagedDiskUpdateDetailsTypeConverter))]
    public partial class A2AvmManagedDiskUpdateDetails
    {

        /// <summary>
        /// <c>AfterDeserializeDictionary</c> will be called after the deserialization has finished, allowing customization of the
        /// object before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>

        partial void AfterDeserializeDictionary(global::System.Collections.IDictionary content);

        /// <summary>
        /// <c>AfterDeserializePSObject</c> will be called after the deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>

        partial void AfterDeserializePSObject(global::System.Management.Automation.PSObject content);

        /// <summary>
        /// <c>BeforeDeserializeDictionary</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.A2AvmManagedDiskUpdateDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal A2AvmManagedDiskUpdateDetails(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AvmManagedDiskUpdateDetailsInternal)this).DiskEncryptionInfo = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IDiskEncryptionInfo) content.GetValueForProperty("DiskEncryptionInfo",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AvmManagedDiskUpdateDetailsInternal)this).DiskEncryptionInfo, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.DiskEncryptionInfoTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AvmManagedDiskUpdateDetailsInternal)this).DiskId = (string) content.GetValueForProperty("DiskId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AvmManagedDiskUpdateDetailsInternal)this).DiskId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AvmManagedDiskUpdateDetailsInternal)this).RecoveryTargetDiskAccountType = (string) content.GetValueForProperty("RecoveryTargetDiskAccountType",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AvmManagedDiskUpdateDetailsInternal)this).RecoveryTargetDiskAccountType, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AvmManagedDiskUpdateDetailsInternal)this).RecoveryReplicaDiskAccountType = (string) content.GetValueForProperty("RecoveryReplicaDiskAccountType",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AvmManagedDiskUpdateDetailsInternal)this).RecoveryReplicaDiskAccountType, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AvmManagedDiskUpdateDetailsInternal)this).FailoverDiskName = (string) content.GetValueForProperty("FailoverDiskName",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AvmManagedDiskUpdateDetailsInternal)this).FailoverDiskName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AvmManagedDiskUpdateDetailsInternal)this).TfoDiskName = (string) content.GetValueForProperty("TfoDiskName",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AvmManagedDiskUpdateDetailsInternal)this).TfoDiskName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AvmManagedDiskUpdateDetailsInternal)this).DiskEncryptionInfoDiskEncryptionKeyInfo = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IDiskEncryptionKeyInfo) content.GetValueForProperty("DiskEncryptionInfoDiskEncryptionKeyInfo",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AvmManagedDiskUpdateDetailsInternal)this).DiskEncryptionInfoDiskEncryptionKeyInfo, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.DiskEncryptionKeyInfoTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AvmManagedDiskUpdateDetailsInternal)this).DiskEncryptionInfoKeyEncryptionKeyInfo = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IKeyEncryptionKeyInfo) content.GetValueForProperty("DiskEncryptionInfoKeyEncryptionKeyInfo",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AvmManagedDiskUpdateDetailsInternal)this).DiskEncryptionInfoKeyEncryptionKeyInfo, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.KeyEncryptionKeyInfoTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AvmManagedDiskUpdateDetailsInternal)this).DiskEncryptionKeyInfoSecretIdentifier = (string) content.GetValueForProperty("DiskEncryptionKeyInfoSecretIdentifier",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AvmManagedDiskUpdateDetailsInternal)this).DiskEncryptionKeyInfoSecretIdentifier, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AvmManagedDiskUpdateDetailsInternal)this).KeyEncryptionKeyInfoKeyIdentifier = (string) content.GetValueForProperty("KeyEncryptionKeyInfoKeyIdentifier",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AvmManagedDiskUpdateDetailsInternal)this).KeyEncryptionKeyInfoKeyIdentifier, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AvmManagedDiskUpdateDetailsInternal)this).DiskEncryptionKeyInfoKeyVaultResourceArmId = (string) content.GetValueForProperty("DiskEncryptionKeyInfoKeyVaultResourceArmId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AvmManagedDiskUpdateDetailsInternal)this).DiskEncryptionKeyInfoKeyVaultResourceArmId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AvmManagedDiskUpdateDetailsInternal)this).KeyEncryptionKeyInfoKeyVaultResourceArmId = (string) content.GetValueForProperty("KeyEncryptionKeyInfoKeyVaultResourceArmId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AvmManagedDiskUpdateDetailsInternal)this).KeyEncryptionKeyInfoKeyVaultResourceArmId, global::System.Convert.ToString);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.A2AvmManagedDiskUpdateDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal A2AvmManagedDiskUpdateDetails(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AvmManagedDiskUpdateDetailsInternal)this).DiskEncryptionInfo = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IDiskEncryptionInfo) content.GetValueForProperty("DiskEncryptionInfo",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AvmManagedDiskUpdateDetailsInternal)this).DiskEncryptionInfo, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.DiskEncryptionInfoTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AvmManagedDiskUpdateDetailsInternal)this).DiskId = (string) content.GetValueForProperty("DiskId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AvmManagedDiskUpdateDetailsInternal)this).DiskId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AvmManagedDiskUpdateDetailsInternal)this).RecoveryTargetDiskAccountType = (string) content.GetValueForProperty("RecoveryTargetDiskAccountType",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AvmManagedDiskUpdateDetailsInternal)this).RecoveryTargetDiskAccountType, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AvmManagedDiskUpdateDetailsInternal)this).RecoveryReplicaDiskAccountType = (string) content.GetValueForProperty("RecoveryReplicaDiskAccountType",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AvmManagedDiskUpdateDetailsInternal)this).RecoveryReplicaDiskAccountType, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AvmManagedDiskUpdateDetailsInternal)this).FailoverDiskName = (string) content.GetValueForProperty("FailoverDiskName",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AvmManagedDiskUpdateDetailsInternal)this).FailoverDiskName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AvmManagedDiskUpdateDetailsInternal)this).TfoDiskName = (string) content.GetValueForProperty("TfoDiskName",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AvmManagedDiskUpdateDetailsInternal)this).TfoDiskName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AvmManagedDiskUpdateDetailsInternal)this).DiskEncryptionInfoDiskEncryptionKeyInfo = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IDiskEncryptionKeyInfo) content.GetValueForProperty("DiskEncryptionInfoDiskEncryptionKeyInfo",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AvmManagedDiskUpdateDetailsInternal)this).DiskEncryptionInfoDiskEncryptionKeyInfo, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.DiskEncryptionKeyInfoTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AvmManagedDiskUpdateDetailsInternal)this).DiskEncryptionInfoKeyEncryptionKeyInfo = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IKeyEncryptionKeyInfo) content.GetValueForProperty("DiskEncryptionInfoKeyEncryptionKeyInfo",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AvmManagedDiskUpdateDetailsInternal)this).DiskEncryptionInfoKeyEncryptionKeyInfo, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.KeyEncryptionKeyInfoTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AvmManagedDiskUpdateDetailsInternal)this).DiskEncryptionKeyInfoSecretIdentifier = (string) content.GetValueForProperty("DiskEncryptionKeyInfoSecretIdentifier",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AvmManagedDiskUpdateDetailsInternal)this).DiskEncryptionKeyInfoSecretIdentifier, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AvmManagedDiskUpdateDetailsInternal)this).KeyEncryptionKeyInfoKeyIdentifier = (string) content.GetValueForProperty("KeyEncryptionKeyInfoKeyIdentifier",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AvmManagedDiskUpdateDetailsInternal)this).KeyEncryptionKeyInfoKeyIdentifier, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AvmManagedDiskUpdateDetailsInternal)this).DiskEncryptionKeyInfoKeyVaultResourceArmId = (string) content.GetValueForProperty("DiskEncryptionKeyInfoKeyVaultResourceArmId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AvmManagedDiskUpdateDetailsInternal)this).DiskEncryptionKeyInfoKeyVaultResourceArmId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AvmManagedDiskUpdateDetailsInternal)this).KeyEncryptionKeyInfoKeyVaultResourceArmId = (string) content.GetValueForProperty("KeyEncryptionKeyInfoKeyVaultResourceArmId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AvmManagedDiskUpdateDetailsInternal)this).KeyEncryptionKeyInfoKeyVaultResourceArmId, global::System.Convert.ToString);
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.A2AvmManagedDiskUpdateDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AvmManagedDiskUpdateDetails"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AvmManagedDiskUpdateDetails DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new A2AvmManagedDiskUpdateDetails(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.A2AvmManagedDiskUpdateDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AvmManagedDiskUpdateDetails"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AvmManagedDiskUpdateDetails DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new A2AvmManagedDiskUpdateDetails(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="A2AvmManagedDiskUpdateDetails" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AvmManagedDiskUpdateDetails FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// A2A Vm managed disk update details.
    [System.ComponentModel.TypeConverter(typeof(A2AvmManagedDiskUpdateDetailsTypeConverter))]
    public partial interface IA2AvmManagedDiskUpdateDetails

    {

    }
}