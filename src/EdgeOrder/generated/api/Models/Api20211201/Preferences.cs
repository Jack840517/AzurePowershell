// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201
{
    using static Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.Extensions;

    /// <summary>Preferences related to the order</summary>
    public partial class Preferences :
        Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IPreferences,
        Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IPreferencesInternal
    {

        /// <summary>Backing field for <see cref="EncryptionPreference" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IEncryptionPreferences _encryptionPreference;

        /// <summary>Preferences related to the Encryption.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Origin(Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IEncryptionPreferences EncryptionPreference { get => (this._encryptionPreference = this._encryptionPreference ?? new Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.EncryptionPreferences()); set => this._encryptionPreference = value; }

        /// <summary>Backing field for <see cref="ManagementResourcePreference" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IManagementResourcePreferences _managementResourcePreference;

        /// <summary>Preferences related to the Management resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Origin(Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IManagementResourcePreferences ManagementResourcePreference { get => (this._managementResourcePreference = this._managementResourcePreference ?? new Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.ManagementResourcePreferences()); set => this._managementResourcePreference = value; }

        /// <summary>Backing field for <see cref="NotificationPreference" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.INotificationPreference[] _notificationPreference;

        /// <summary>Notification preferences.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Origin(Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.INotificationPreference[] NotificationPreference { get => this._notificationPreference; set => this._notificationPreference = value; }

        /// <summary>Backing field for <see cref="TransportPreference" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.ITransportPreferences _transportPreference;

        /// <summary>Preferences related to the shipment logistics of the order.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Origin(Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.ITransportPreferences TransportPreference { get => (this._transportPreference = this._transportPreference ?? new Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.TransportPreferences()); set => this._transportPreference = value; }

        /// <summary>Creates an new <see cref="Preferences" /> instance.</summary>
        public Preferences()
        {

        }
    }
    /// Preferences related to the order
    public partial interface IPreferences :
        Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.IJsonSerializable
    {
        /// <summary>Preferences related to the Encryption.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Preferences related to the Encryption.",
        SerializedName = @"encryptionPreferences",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IEncryptionPreferences) })]
        Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IEncryptionPreferences EncryptionPreference { get; set; }
        /// <summary>Preferences related to the Management resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Preferences related to the Management resource.",
        SerializedName = @"managementResourcePreferences",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IManagementResourcePreferences) })]
        Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IManagementResourcePreferences ManagementResourcePreference { get; set; }
        /// <summary>Notification preferences.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Notification preferences.",
        SerializedName = @"notificationPreferences",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.INotificationPreference) })]
        Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.INotificationPreference[] NotificationPreference { get; set; }
        /// <summary>Preferences related to the shipment logistics of the order.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Preferences related to the shipment logistics of the order.",
        SerializedName = @"transportPreferences",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.ITransportPreferences) })]
        Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.ITransportPreferences TransportPreference { get; set; }

    }
    /// Preferences related to the order
    internal partial interface IPreferencesInternal

    {
        /// <summary>Preferences related to the Encryption.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IEncryptionPreferences EncryptionPreference { get; set; }
        /// <summary>Preferences related to the Management resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IManagementResourcePreferences ManagementResourcePreference { get; set; }
        /// <summary>Notification preferences.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.INotificationPreference[] NotificationPreference { get; set; }
        /// <summary>Preferences related to the shipment logistics of the order.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.ITransportPreferences TransportPreference { get; set; }

    }
}