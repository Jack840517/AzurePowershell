// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20180501Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.Extensions;

    /// <summary>The collection of validation rule properties</summary>
    public partial class WebTestPropertiesValidationRules :
        Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20180501Preview.IWebTestPropertiesValidationRules,
        Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20180501Preview.IWebTestPropertiesValidationRulesInternal
    {

        /// <summary>Backing field for <see cref="ContentValidation" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20180501Preview.IWebTestPropertiesValidationRulesContentValidation _contentValidation;

        /// <summary>The collection of content validation properties</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20180501Preview.IWebTestPropertiesValidationRulesContentValidation ContentValidation { get => (this._contentValidation = this._contentValidation ?? new Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20180501Preview.WebTestPropertiesValidationRulesContentValidation()); set => this._contentValidation = value; }

        /// <summary>Content to look for in the return of the WebTest. Must not be null or empty.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.PropertyOrigin.Inlined)]
        public string ContentValidationContentMatch { get => ((Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20180501Preview.IWebTestPropertiesValidationRulesContentValidationInternal)ContentValidation).ContentMatch; set => ((Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20180501Preview.IWebTestPropertiesValidationRulesContentValidationInternal)ContentValidation).ContentMatch = value ?? null; }

        /// <summary>When set, this value makes the ContentMatch validation case insensitive.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.PropertyOrigin.Inlined)]
        public bool? ContentValidationIgnoreCase { get => ((Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20180501Preview.IWebTestPropertiesValidationRulesContentValidationInternal)ContentValidation).IgnoreCase; set => ((Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20180501Preview.IWebTestPropertiesValidationRulesContentValidationInternal)ContentValidation).IgnoreCase = value ?? default(bool); }

        /// <summary>
        /// When true, validation will pass if there is a match for the ContentMatch string. If false, validation will fail if there
        /// is a match
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.PropertyOrigin.Inlined)]
        public bool? ContentValidationPassIfTextFound { get => ((Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20180501Preview.IWebTestPropertiesValidationRulesContentValidationInternal)ContentValidation).PassIfTextFound; set => ((Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20180501Preview.IWebTestPropertiesValidationRulesContentValidationInternal)ContentValidation).PassIfTextFound = value ?? default(bool); }

        /// <summary>Backing field for <see cref="ExpectedHttpStatusCode" /> property.</summary>
        private int? _expectedHttpStatusCode;

        /// <summary>Validate that the WebTest returns the http status code provided.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.PropertyOrigin.Owned)]
        public int? ExpectedHttpStatusCode { get => this._expectedHttpStatusCode; set => this._expectedHttpStatusCode = value; }

        /// <summary>Backing field for <see cref="IgnoreHttpsStatusCode" /> property.</summary>
        private bool? _ignoreHttpsStatusCode;

        /// <summary>When set, validation will ignore the status code.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.PropertyOrigin.Owned)]
        public bool? IgnoreHttpsStatusCode { get => this._ignoreHttpsStatusCode; set => this._ignoreHttpsStatusCode = value; }

        /// <summary>Internal Acessors for ContentValidation</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20180501Preview.IWebTestPropertiesValidationRulesContentValidation Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20180501Preview.IWebTestPropertiesValidationRulesInternal.ContentValidation { get => (this._contentValidation = this._contentValidation ?? new Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20180501Preview.WebTestPropertiesValidationRulesContentValidation()); set { {_contentValidation = value;} } }

        /// <summary>Backing field for <see cref="SslCertRemainingLifetimeCheck" /> property.</summary>
        private int? _sslCertRemainingLifetimeCheck;

        /// <summary>
        /// A number of days to check still remain before the the existing SSL cert expires. Value must be positive and the SSLCheck
        /// must be set to true.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.PropertyOrigin.Owned)]
        public int? SslCertRemainingLifetimeCheck { get => this._sslCertRemainingLifetimeCheck; set => this._sslCertRemainingLifetimeCheck = value; }

        /// <summary>Backing field for <see cref="SslCheck" /> property.</summary>
        private bool? _sslCheck;

        /// <summary>Checks to see if the SSL cert is still valid.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.PropertyOrigin.Owned)]
        public bool? SslCheck { get => this._sslCheck; set => this._sslCheck = value; }

        /// <summary>Creates an new <see cref="WebTestPropertiesValidationRules" /> instance.</summary>
        public WebTestPropertiesValidationRules()
        {

        }
    }
    /// The collection of validation rule properties
    public partial interface IWebTestPropertiesValidationRules :
        Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.IJsonSerializable
    {
        /// <summary>Content to look for in the return of the WebTest. Must not be null or empty.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Content to look for in the return of the WebTest.  Must not be null or empty.",
        SerializedName = @"ContentMatch",
        PossibleTypes = new [] { typeof(string) })]
        string ContentValidationContentMatch { get; set; }
        /// <summary>When set, this value makes the ContentMatch validation case insensitive.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"When set, this value makes the ContentMatch validation case insensitive.",
        SerializedName = @"IgnoreCase",
        PossibleTypes = new [] { typeof(bool) })]
        bool? ContentValidationIgnoreCase { get; set; }
        /// <summary>
        /// When true, validation will pass if there is a match for the ContentMatch string. If false, validation will fail if there
        /// is a match
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"When true, validation will pass if there is a match for the ContentMatch string.  If false, validation will fail if there is a match",
        SerializedName = @"PassIfTextFound",
        PossibleTypes = new [] { typeof(bool) })]
        bool? ContentValidationPassIfTextFound { get; set; }
        /// <summary>Validate that the WebTest returns the http status code provided.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Validate that the WebTest returns the http status code provided.",
        SerializedName = @"ExpectedHttpStatusCode",
        PossibleTypes = new [] { typeof(int) })]
        int? ExpectedHttpStatusCode { get; set; }
        /// <summary>When set, validation will ignore the status code.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"When set, validation will ignore the status code.",
        SerializedName = @"IgnoreHttpsStatusCode",
        PossibleTypes = new [] { typeof(bool) })]
        bool? IgnoreHttpsStatusCode { get; set; }
        /// <summary>
        /// A number of days to check still remain before the the existing SSL cert expires. Value must be positive and the SSLCheck
        /// must be set to true.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"A number of days to check still remain before the the existing SSL cert expires.  Value must be positive and the SSLCheck must be set to true.",
        SerializedName = @"SSLCertRemainingLifetimeCheck",
        PossibleTypes = new [] { typeof(int) })]
        int? SslCertRemainingLifetimeCheck { get; set; }
        /// <summary>Checks to see if the SSL cert is still valid.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Checks to see if the SSL cert is still valid.",
        SerializedName = @"SSLCheck",
        PossibleTypes = new [] { typeof(bool) })]
        bool? SslCheck { get; set; }

    }
    /// The collection of validation rule properties
    internal partial interface IWebTestPropertiesValidationRulesInternal

    {
        /// <summary>The collection of content validation properties</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20180501Preview.IWebTestPropertiesValidationRulesContentValidation ContentValidation { get; set; }
        /// <summary>Content to look for in the return of the WebTest. Must not be null or empty.</summary>
        string ContentValidationContentMatch { get; set; }
        /// <summary>When set, this value makes the ContentMatch validation case insensitive.</summary>
        bool? ContentValidationIgnoreCase { get; set; }
        /// <summary>
        /// When true, validation will pass if there is a match for the ContentMatch string. If false, validation will fail if there
        /// is a match
        /// </summary>
        bool? ContentValidationPassIfTextFound { get; set; }
        /// <summary>Validate that the WebTest returns the http status code provided.</summary>
        int? ExpectedHttpStatusCode { get; set; }
        /// <summary>When set, validation will ignore the status code.</summary>
        bool? IgnoreHttpsStatusCode { get; set; }
        /// <summary>
        /// A number of days to check still remain before the the existing SSL cert expires. Value must be positive and the SSLCheck
        /// must be set to true.
        /// </summary>
        int? SslCertRemainingLifetimeCheck { get; set; }
        /// <summary>Checks to see if the SSL cert is still valid.</summary>
        bool? SslCheck { get; set; }

    }
}