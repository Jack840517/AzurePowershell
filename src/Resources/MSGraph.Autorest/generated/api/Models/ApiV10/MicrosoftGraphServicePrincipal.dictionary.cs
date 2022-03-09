// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Extensions;

    public partial class MicrosoftGraphServicePrincipal :
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.IAssociativeArray<global::System.Object>
    {
        protected global::System.Collections.Generic.Dictionary<global::System.String,global::System.Object> __additionalProperties = new global::System.Collections.Generic.Dictionary<global::System.String,global::System.Object>();

        global::System.Collections.Generic.IDictionary<global::System.String,global::System.Object> Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.IAssociativeArray<global::System.Object>.AdditionalProperties { get => __additionalProperties; }

        public global::System.Object this[global::System.String index] { get => __additionalProperties[index]; set => __additionalProperties[index] = value; }

        /// <param name="key"></param>
        /// <param name="value"></param>
        public void Add(global::System.String key, global::System.Object value) => __additionalProperties.Add( key, value);

        public void Clear() => __additionalProperties.Clear();

        /// <param name="key"></param>
        public bool ContainsKey(global::System.String key) => __additionalProperties.ContainsKey( key);

        /// <param name="source"></param>
        public void CopyFrom(global::System.Collections.IDictionary source)
        {
            if (null != source)
            {
                foreach( var property in  Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.PowerShell.TypeConverterExtensions.GetFilteredProperties(source, new global::System.Collections.Generic.HashSet<global::System.String>() { "AccountEnabled","AddIn","AlternativeName","AppDescription","AppDisplayName","AppId","ApplicationTemplateId","AppOwnerOrganizationId","AppRoleAssignmentRequired","AppRole","Description","DisabledByMicrosoftStatus","Homepage","KeyCredentials","LoginUrl","LogoutUrl","Note","NotificationEmailAddress","Oauth2PermissionScope","PasswordCredentials","PreferredSingleSignOnMode","PreferredTokenSigningKeyThumbprint","ReplyUrl","ServicePrincipalName","ServicePrincipalType","SignInAudience","Tag","TokenEncryptionKeyId","AppRoleAssignedTo","AppRoleAssignment","ClaimsMappingPolicy","CreatedObject","DelegatedPermissionClassification","Endpoint","HomeRealmDiscoveryPolicy","MemberOf","Oauth2PermissionGrant","OwnedObject","Owner","TokenIssuancePolicy","TokenLifetimePolicy","TransitiveMemberOf","Info","SamlSingleSignOnSetting","Id","DeletedDateTime","DisplayName","OdataType","OdataId" } ) )
                {
                    if ((null != property.Key && null != property.Value))
                    {
                        this.__additionalProperties.Add(property.Key.ToString(), global::System.Management.Automation.LanguagePrimitives.ConvertTo<global::System.Object>( property.Value));
                    }
                }
            }
        }

        /// <param name="source"></param>
        public void CopyFrom(global::System.Management.Automation.PSObject source)
        {
            if (null != source)
            {
                foreach( var property in  Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.PowerShell.TypeConverterExtensions.GetFilteredProperties(source, new global::System.Collections.Generic.HashSet<global::System.String>() { "AccountEnabled","AddIn","AlternativeName","AppDescription","AppDisplayName","AppId","ApplicationTemplateId","AppOwnerOrganizationId","AppRoleAssignmentRequired","AppRole","Description","DisabledByMicrosoftStatus","Homepage","KeyCredentials","LoginUrl","LogoutUrl","Note","NotificationEmailAddress","Oauth2PermissionScope","PasswordCredentials","PreferredSingleSignOnMode","PreferredTokenSigningKeyThumbprint","ReplyUrl","ServicePrincipalName","ServicePrincipalType","SignInAudience","Tag","TokenEncryptionKeyId","AppRoleAssignedTo","AppRoleAssignment","ClaimsMappingPolicy","CreatedObject","DelegatedPermissionClassification","Endpoint","HomeRealmDiscoveryPolicy","MemberOf","Oauth2PermissionGrant","OwnedObject","Owner","TokenIssuancePolicy","TokenLifetimePolicy","TransitiveMemberOf","Info","SamlSingleSignOnSetting","Id","DeletedDateTime","DisplayName","OdataType","OdataId" } ) )
                {
                    if ((null != property.Key && null != property.Value))
                    {
                        this.__additionalProperties.Add(property.Key.ToString(), global::System.Management.Automation.LanguagePrimitives.ConvertTo<global::System.Object>( property.Value));
                    }
                }
            }
        }

        /// <param name="key"></param>
        public bool Remove(global::System.String key) => __additionalProperties.Remove( key);

        /// <param name="key"></param>
        /// <param name="value"></param>
        public bool TryGetValue(global::System.String key, out global::System.Object value) => __additionalProperties.TryGetValue( key, out value);

        /// <param name="source"></param>

        public static implicit operator global::System.Collections.Generic.Dictionary<global::System.String,global::System.Object>(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.MicrosoftGraphServicePrincipal source) => source.__additionalProperties;
    }
}