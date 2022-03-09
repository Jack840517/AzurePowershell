// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Extensions;

    /// <summary>
    /// Represents an Azure Active Directory object. The directoryObject type is the base type for many other directory entity
    /// types.
    /// </summary>
    public partial class MicrosoftGraphDirectoryObject :
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphDirectoryObject,
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphDirectoryObjectInternal,
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphEntity"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphEntity __microsoftGraphEntity = new Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.MicrosoftGraphEntity();

        /// <summary>Backing field for <see cref="DeletedDateTime" /> property.</summary>
        private global::System.DateTime? _deletedDateTime;

        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.PropertyOrigin.Owned)]
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.DoNotFormat]
        public global::System.DateTime? DeletedDateTime { get => this._deletedDateTime; set => this._deletedDateTime = value; }

        /// <summary>Backing field for <see cref="DisplayName" /> property.</summary>
        private string _displayName;

        /// <summary>The name displayed in directory</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.PropertyOrigin.Owned)]
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.FormatTable(Index = 0)]
        public string DisplayName { get => this._displayName; set => this._displayName = value; }

        /// <summary>Read-only.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.FormatTable(Index = 1)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphEntityInternal)__microsoftGraphEntity).Id; }

        /// <summary>Internal Acessors for OdataId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphDirectoryObjectInternal.OdataId { get => this._odataId; set { {_odataId = value;} } }

        /// <summary>Internal Acessors for OdataType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphDirectoryObjectInternal.OdataType { get => this._odataType; set { {_odataType = value;} } }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphEntityInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphEntityInternal)__microsoftGraphEntity).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphEntityInternal)__microsoftGraphEntity).Id = value; }

        /// <summary>Backing field for <see cref="OdataId" /> property.</summary>
        private string _odataId;

        /// <summary>The full id of object in directory</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.PropertyOrigin.Owned)]
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.DoNotFormat]
        public string OdataId { get => this._odataId; }

        /// <summary>Backing field for <see cref="OdataType" /> property.</summary>
        private string _odataType;

        /// <summary>The type of object in directory</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.PropertyOrigin.Owned)]
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.FormatTable(Index = 2)]
        public string OdataType { get => this._odataType; }

        /// <summary>Creates an new <see cref="MicrosoftGraphDirectoryObject" /> instance.</summary>
        public MicrosoftGraphDirectoryObject()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A < see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__microsoftGraphEntity), __microsoftGraphEntity);
            await eventListener.AssertObjectIsValid(nameof(__microsoftGraphEntity), __microsoftGraphEntity);
        }
    }
    /// Represents an Azure Active Directory object. The directoryObject type is the base type for many other directory entity
    /// types.
    public partial interface IMicrosoftGraphDirectoryObject :
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphEntity
    {
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"deletedDateTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? DeletedDateTime { get; set; }
        /// <summary>The name displayed in directory</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The name displayed in directory",
        SerializedName = @"displayName",
        PossibleTypes = new [] { typeof(string) })]
        string DisplayName { get; set; }
        /// <summary>The full id of object in directory</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The full id of object in directory",
        SerializedName = @"@odata.id",
        PossibleTypes = new [] { typeof(string) })]
        string OdataId { get;  }
        /// <summary>The type of object in directory</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The type of object in directory",
        SerializedName = @"@odata.type",
        PossibleTypes = new [] { typeof(string) })]
        string OdataType { get;  }

    }
    /// Represents an Azure Active Directory object. The directoryObject type is the base type for many other directory entity
    /// types.
    internal partial interface IMicrosoftGraphDirectoryObjectInternal :
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphEntityInternal
    {
        global::System.DateTime? DeletedDateTime { get; set; }
        /// <summary>The name displayed in directory</summary>
        string DisplayName { get; set; }
        /// <summary>The full id of object in directory</summary>
        string OdataId { get; set; }
        /// <summary>The type of object in directory</summary>
        string OdataType { get; set; }

    }
}