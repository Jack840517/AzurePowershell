// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.PowerShell.Cmdlets.Compute.Helpers.Storage.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The storage account blob inventory policy.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class BlobInventoryPolicy : Resource
    {
        /// <summary>
        /// Initializes a new instance of the BlobInventoryPolicy class.
        /// </summary>
        public BlobInventoryPolicy()
        {
            Policy = new BlobInventoryPolicySchema();
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the BlobInventoryPolicy class.
        /// </summary>
        /// <param name="policy">The storage account blob inventory policy
        /// object. It is composed of policy rules.</param>
        /// <param name="id">Fully qualified resource ID for the resource. Ex -
        /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}</param>
        /// <param name="name">The name of the resource</param>
        /// <param name="type">The type of the resource. E.g.
        /// "Microsoft.Compute/virtualMachines" or
        /// "Microsoft.Storage/storageAccounts"</param>
        /// <param name="lastModifiedTime">Returns the last modified date and
        /// time of the blob inventory policy.</param>
        public BlobInventoryPolicy(BlobInventoryPolicySchema policy, string id = default(string), string name = default(string), string type = default(string), System.DateTime? lastModifiedTime = default(System.DateTime?), SystemData systemData = default(SystemData))
            : base(id, name, type)
        {
            LastModifiedTime = lastModifiedTime;
            Policy = policy;
            SystemData = systemData;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets returns the last modified date and time of the blob inventory
        /// policy.
        /// </summary>
        [JsonProperty(PropertyName = "properties.lastModifiedTime")]
        public System.DateTime? LastModifiedTime { get; private set; }

        /// <summary>
        /// Gets or sets the storage account blob inventory policy object. It
        /// is composed of policy rules.
        /// </summary>
        [JsonProperty(PropertyName = "properties.policy")]
        public BlobInventoryPolicySchema Policy { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "systemData")]
        public SystemData SystemData { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Policy == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Policy");
            }
            if (Policy != null)
            {
                Policy.Validate();
            }
        }
    }
}