// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Purview.Cmdlets
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Extensions;
    using System;

    /// <summary>Creates or updates an account</summary>
    /// <remarks>
    /// [OpenAPI] CreateOrUpdate=>PUT:"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Purview/accounts/{accountName}"
    /// </remarks>
    [global::Microsoft.Azure.PowerShell.Cmdlets.Purview.InternalExport]
    [global::System.Management.Automation.Cmdlet(global::System.Management.Automation.VerbsCommon.New, @"AzPurviewAccount_CreateExpanded", SupportsShouldProcess = true)]
    [global::System.Management.Automation.OutputType(typeof(Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccount))]
    [global::Microsoft.Azure.PowerShell.Cmdlets.Purview.Description(@"Creates or updates an account")]
    [global::Microsoft.Azure.PowerShell.Cmdlets.Purview.Generated]
    public partial class NewAzPurviewAccount_CreateExpanded : global::System.Management.Automation.PSCmdlet,
        Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.IEventListener
    {
        /// <summary>A unique id generatd for the this cmdlet when it is instantiated.</summary>
        private string __correlationId = System.Guid.NewGuid().ToString();

        /// <summary>A copy of the Invocation Info (necessary to allow asJob to clone this cmdlet)</summary>
        private global::System.Management.Automation.InvocationInfo __invocationInfo;

        /// <summary>A unique id generatd for the this cmdlet when ProcessRecord() is called.</summary>
        private string __processRecordId;

        /// <summary>
        /// The <see cref="global::System.Threading.CancellationTokenSource" /> for this operation.
        /// </summary>
        private global::System.Threading.CancellationTokenSource _cancellationTokenSource = new global::System.Threading.CancellationTokenSource();

        /// <summary>Backing field for <see cref="AccountBody" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccount _accountBody= new Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.Account();

        /// <summary>Account resource</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccount AccountBody { get => this._accountBody; set => this._accountBody = value; }

        /// <summary>when specified, runs this cmdlet as a PowerShell job</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Run the command as a job")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Purview.Category(global::Microsoft.Azure.PowerShell.Cmdlets.Purview.ParameterCategory.Runtime)]
        public global::System.Management.Automation.SwitchParameter AsJob { get; set; }

        /// <summary>Wait for .NET debugger to attach</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "Wait for .NET debugger to attach")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Purview.Category(global::Microsoft.Azure.PowerShell.Cmdlets.Purview.ParameterCategory.Runtime)]
        public global::System.Management.Automation.SwitchParameter Break { get; set; }

        /// <summary>The reference to the client API class.</summary>
        public Microsoft.Azure.PowerShell.Cmdlets.Purview.Purview Client => Microsoft.Azure.PowerShell.Cmdlets.Purview.Module.Instance.ClientAPI;

        /// <summary>
        /// The credentials, account, tenant, and subscription used for communication with Azure
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The credentials, account, tenant, and subscription used for communication with Azure.")]
        [global::System.Management.Automation.ValidateNotNull]
        [global::System.Management.Automation.Alias("AzureRMContext", "AzureCredential")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Purview.Category(global::Microsoft.Azure.PowerShell.Cmdlets.Purview.ParameterCategory.Azure)]
        public global::System.Management.Automation.PSObject DefaultProfile { get; set; }

        /// <summary>SendAsync Pipeline Steps to be appended to the front of the pipeline</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "SendAsync Pipeline Steps to be appended to the front of the pipeline")]
        [global::System.Management.Automation.ValidateNotNull]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Purview.Category(global::Microsoft.Azure.PowerShell.Cmdlets.Purview.ParameterCategory.Runtime)]
        public Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.SendAsyncStep[] HttpPipelineAppend { get; set; }

        /// <summary>SendAsync Pipeline Steps to be prepended to the front of the pipeline</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "SendAsync Pipeline Steps to be prepended to the front of the pipeline")]
        [global::System.Management.Automation.ValidateNotNull]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Purview.Category(global::Microsoft.Azure.PowerShell.Cmdlets.Purview.ParameterCategory.Runtime)]
        public Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.SendAsyncStep[] HttpPipelinePrepend { get; set; }

        /// <summary>Identity Type</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Identity Type")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Purview.Category(global::Microsoft.Azure.PowerShell.Cmdlets.Purview.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Identity Type",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Purview.Support.Type) })]
        [global::System.Management.Automation.ArgumentCompleter(typeof(Microsoft.Azure.PowerShell.Cmdlets.Purview.Support.Type))]
        public Microsoft.Azure.PowerShell.Cmdlets.Purview.Support.Type IdentityType { get => AccountBody.IdentityType ?? ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Support.Type)""); set => AccountBody.IdentityType = value; }

        /// <summary>Accessor for our copy of the InvocationInfo.</summary>
        public global::System.Management.Automation.InvocationInfo InvocationInformation { get => __invocationInfo = __invocationInfo ?? this.MyInvocation ; set { __invocationInfo = value; } }

        /// <summary>Gets or sets the location.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Gets or sets the location.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Purview.Category(global::Microsoft.Azure.PowerShell.Cmdlets.Purview.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Gets or sets the location.",
        SerializedName = @"location",
        PossibleTypes = new [] { typeof(string) })]
        public string Location { get => AccountBody.Location ?? null; set => AccountBody.Location = value; }

        /// <summary>Gets or sets the managed resource group name</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Gets or sets the managed resource group name")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Purview.Category(global::Microsoft.Azure.PowerShell.Cmdlets.Purview.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Gets or sets the managed resource group name",
        SerializedName = @"managedResourceGroupName",
        PossibleTypes = new [] { typeof(string) })]
        public string ManagedResourceGroupName { get => AccountBody.ManagedResourceGroupName ?? null; set => AccountBody.ManagedResourceGroupName = value; }

        /// <summary>
        /// <see cref="IEventListener" /> cancellation delegate. Stops the cmdlet when called.
        /// </summary>
        global::System.Action Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.IEventListener.Cancel => _cancellationTokenSource.Cancel;

        /// <summary><see cref="IEventListener" /> cancellation token.</summary>
        global::System.Threading.CancellationToken Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.IEventListener.Token => _cancellationTokenSource.Token;

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>The name of the account.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "The name of the account.")]
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The name of the account.",
        SerializedName = @"accountName",
        PossibleTypes = new [] { typeof(string) })]
        [global::System.Management.Automation.Alias("AccountName")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Purview.Category(global::Microsoft.Azure.PowerShell.Cmdlets.Purview.ParameterCategory.Path)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>
        /// when specified, will make the remote call, and return an AsyncOperationResponse, letting the remote operation continue
        /// asynchronously.
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Run the command asynchronously")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Purview.Category(global::Microsoft.Azure.PowerShell.Cmdlets.Purview.ParameterCategory.Runtime)]
        public global::System.Management.Automation.SwitchParameter NoWait { get; set; }

        /// <summary>
        /// The instance of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.HttpPipeline" /> that the remote call will use.
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.HttpPipeline Pipeline { get; set; }

        /// <summary>The URI for the proxy server to use</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "The URI for the proxy server to use")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Purview.Category(global::Microsoft.Azure.PowerShell.Cmdlets.Purview.ParameterCategory.Runtime)]
        public global::System.Uri Proxy { get; set; }

        /// <summary>Credentials for a proxy server to use for the remote call</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "Credentials for a proxy server to use for the remote call")]
        [global::System.Management.Automation.ValidateNotNull]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Purview.Category(global::Microsoft.Azure.PowerShell.Cmdlets.Purview.ParameterCategory.Runtime)]
        public global::System.Management.Automation.PSCredential ProxyCredential { get; set; }

        /// <summary>Use the default credentials for the proxy</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "Use the default credentials for the proxy")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Purview.Category(global::Microsoft.Azure.PowerShell.Cmdlets.Purview.ParameterCategory.Runtime)]
        public global::System.Management.Automation.SwitchParameter ProxyUseDefaultCredentials { get; set; }

        /// <summary>Gets or sets the public network access.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Gets or sets the public network access.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Purview.Category(global::Microsoft.Azure.PowerShell.Cmdlets.Purview.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Gets or sets the public network access.",
        SerializedName = @"publicNetworkAccess",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Purview.Support.PublicNetworkAccess) })]
        [global::System.Management.Automation.ArgumentCompleter(typeof(Microsoft.Azure.PowerShell.Cmdlets.Purview.Support.PublicNetworkAccess))]
        public Microsoft.Azure.PowerShell.Cmdlets.Purview.Support.PublicNetworkAccess PublicNetworkAccess { get => AccountBody.PublicNetworkAccess ?? ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Support.PublicNetworkAccess)""); set => AccountBody.PublicNetworkAccess = value; }

        /// <summary>Backing field for <see cref="ResourceGroupName" /> property.</summary>
        private string _resourceGroupName;

        /// <summary>The resource group name.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "The resource group name.")]
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The resource group name.",
        SerializedName = @"resourceGroupName",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Purview.Category(global::Microsoft.Azure.PowerShell.Cmdlets.Purview.ParameterCategory.Path)]
        public string ResourceGroupName { get => this._resourceGroupName; set => this._resourceGroupName = value; }

        /// <summary>Gets or sets the sku capacity. Possible values include: 4, 16</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Gets or sets the sku capacity. Possible values include: 4, 16")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Purview.Category(global::Microsoft.Azure.PowerShell.Cmdlets.Purview.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Gets or sets the sku capacity. Possible values include: 4, 16",
        SerializedName = @"capacity",
        PossibleTypes = new [] { typeof(int) })]
        public int SkuCapacity { get => AccountBody.SkuCapacity ?? default(int); set => AccountBody.SkuCapacity = value; }

        /// <summary>Gets or sets the sku name.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Gets or sets the sku name.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Purview.Category(global::Microsoft.Azure.PowerShell.Cmdlets.Purview.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Gets or sets the sku name.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Purview.Support.Name) })]
        [global::System.Management.Automation.ArgumentCompleter(typeof(Microsoft.Azure.PowerShell.Cmdlets.Purview.Support.Name))]
        public Microsoft.Azure.PowerShell.Cmdlets.Purview.Support.Name SkuName { get => AccountBody.SkuName ?? ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Support.Name)""); set => AccountBody.SkuName = value; }

        /// <summary>Backing field for <see cref="SubscriptionId" /> property.</summary>
        private string _subscriptionId;

        /// <summary>The subscription identifier</summary>
        [global::System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "The subscription identifier")]
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The subscription identifier",
        SerializedName = @"subscriptionId",
        PossibleTypes = new [] { typeof(string) })]
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.DefaultInfo(
        Name = @"",
        Description =@"",
        Script = @"(Get-AzContext).Subscription.Id")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Purview.Category(global::Microsoft.Azure.PowerShell.Cmdlets.Purview.ParameterCategory.Path)]
        public string SubscriptionId { get => this._subscriptionId; set => this._subscriptionId = value; }

        /// <summary>Tags on the azure resource.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.Purview.ExportAs(typeof(global::System.Collections.Hashtable))]
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Tags on the azure resource.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Purview.Category(global::Microsoft.Azure.PowerShell.Cmdlets.Purview.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Tags on the azure resource.",
        SerializedName = @"tags",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.ITrackedResourceTags) })]
        public Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.ITrackedResourceTags Tag { get => AccountBody.Tag ?? null /* object */; set => AccountBody.Tag = value; }

        /// <summary>
        /// <c>overrideOnDefault</c> will be called before the regular onDefault has been processed, allowing customization of what
        /// happens on that response. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="responseMessage">the raw response message as an global::System.Net.Http.HttpResponseMessage.</param>
        /// <param name="response">the body result as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IErrorResponseModel"
        /// /> from the remote call</param>
        /// <param name="returnNow">/// Determines if the rest of the onDefault method should be processed, or if the method should
        /// return immediately (set to true to skip further processing )</param>

        partial void overrideOnDefault(global::System.Net.Http.HttpResponseMessage responseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IErrorResponseModel> response, ref global::System.Threading.Tasks.Task<bool> returnNow);

        /// <summary>
        /// <c>overrideOnOk</c> will be called before the regular onOk has been processed, allowing customization of what happens
        /// on that response. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="responseMessage">the raw response message as an global::System.Net.Http.HttpResponseMessage.</param>
        /// <param name="response">the body result as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccount"
        /// /> from the remote call</param>
        /// <param name="returnNow">/// Determines if the rest of the onOk method should be processed, or if the method should return
        /// immediately (set to true to skip further processing )</param>

        partial void overrideOnOk(global::System.Net.Http.HttpResponseMessage responseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccount> response, ref global::System.Threading.Tasks.Task<bool> returnNow);

        /// <summary>
        /// (overrides the default BeginProcessing method in global::System.Management.Automation.PSCmdlet)
        /// </summary>
        protected override void BeginProcessing()
        {
            Module.Instance.SetProxyConfiguration(Proxy, ProxyCredential, ProxyUseDefaultCredentials);
            if (Break)
            {
                Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.AttachDebugger.Break();
            }
            ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Events.CmdletBeginProcessing).Wait(); if( ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
        }

        /// <summary>Creates a duplicate instance of this cmdlet (via JSON serialization).</summary>
        /// <returns>a duplicate instance of NewAzPurviewAccount_CreateExpanded</returns>
        public Microsoft.Azure.PowerShell.Cmdlets.Purview.Cmdlets.NewAzPurviewAccount_CreateExpanded Clone()
        {
            var clone = new NewAzPurviewAccount_CreateExpanded();
            clone.__correlationId = this.__correlationId;
            clone.__processRecordId = this.__processRecordId;
            clone.DefaultProfile = this.DefaultProfile;
            clone.InvocationInformation = this.InvocationInformation;
            clone.Proxy = this.Proxy;
            clone.Pipeline = this.Pipeline;
            clone.AsJob = this.AsJob;
            clone.Break = this.Break;
            clone.ProxyCredential = this.ProxyCredential;
            clone.ProxyUseDefaultCredentials = this.ProxyUseDefaultCredentials;
            clone.HttpPipelinePrepend = this.HttpPipelinePrepend;
            clone.HttpPipelineAppend = this.HttpPipelineAppend;
            clone.AccountBody = this.AccountBody;
            clone.SubscriptionId = this.SubscriptionId;
            clone.ResourceGroupName = this.ResourceGroupName;
            clone.Name = this.Name;
            return clone;
        }

        /// <summary>Performs clean-up after the command execution</summary>
        protected override void EndProcessing()
        {
            ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Events.CmdletEndProcessing).Wait(); if( ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
        }

        /// <summary>Handles/Dispatches events during the call to the REST service.</summary>
        /// <param name="id">The message id</param>
        /// <param name="token">The message cancellation token. When this call is cancelled, this should be <c>true</c></param>
        /// <param name="messageData">Detailed message data for the message event.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the message is completed.
        /// </returns>
         async global::System.Threading.Tasks.Task Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.IEventListener.Signal(string id, global::System.Threading.CancellationToken token, global::System.Func<Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.EventData> messageData)
        {
            using( NoSynchronizationContext )
            {
                if (token.IsCancellationRequested)
                {
                    return ;
                }

                switch ( id )
                {
                    case Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Events.Verbose:
                    {
                        WriteVerbose($"{(messageData().Message ?? global::System.String.Empty)}");
                        return ;
                    }
                    case Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Events.Warning:
                    {
                        WriteWarning($"{(messageData().Message ?? global::System.String.Empty)}");
                        return ;
                    }
                    case Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Events.Information:
                    {
                        // When an operation supports asjob, Information messages must go thru verbose.
                        WriteVerbose($"INFORMATION: {(messageData().Message ?? global::System.String.Empty)}");
                        return ;
                    }
                    case Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Events.Debug:
                    {
                        WriteDebug($"{(messageData().Message ?? global::System.String.Empty)}");
                        return ;
                    }
                    case Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Events.Error:
                    {
                        WriteError(new global::System.Management.Automation.ErrorRecord( new global::System.Exception(messageData().Message), string.Empty, global::System.Management.Automation.ErrorCategory.NotSpecified, null ) );
                        return ;
                    }
                    case Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Events.DelayBeforePolling:
                    {
                        if (true == MyInvocation?.BoundParameters?.ContainsKey("NoWait"))
                        {
                            var data = messageData();
                            if (data.ResponseMessage is System.Net.Http.HttpResponseMessage response)
                            {
                                var asyncOperation = response.GetFirstHeader(@"Azure-AsyncOperation");
                                var location = response.GetFirstHeader(@"Location");
                                var uri = global::System.String.IsNullOrEmpty(asyncOperation) ? global::System.String.IsNullOrEmpty(location) ? response.RequestMessage.RequestUri.AbsoluteUri : location : asyncOperation;
                                WriteObject(new Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.PowerShell.AsyncOperationResponse { Target = uri });
                                // do nothing more.
                                data.Cancel();
                                return;
                            }
                        }
                        break;
                    }
                }
                await Microsoft.Azure.PowerShell.Cmdlets.Purview.Module.Instance.Signal(id, token, messageData, (i,t,m) => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.IEventListener)this).Signal(i,t,()=> Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.EventDataConverter.ConvertFrom( m() ) as Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.EventData ), InvocationInformation, this.ParameterSetName, __correlationId, __processRecordId, null );
                if (token.IsCancellationRequested)
                {
                    return ;
                }
                WriteDebug($"{id}: {(messageData().Message ?? global::System.String.Empty)}");
            }
        }

        /// <summary>
        /// Intializes a new instance of the <see cref="NewAzPurviewAccount_CreateExpanded" /> cmdlet class.
        /// </summary>
        public NewAzPurviewAccount_CreateExpanded()
        {

        }

        /// <summary>Performs execution of the command.</summary>
        protected override void ProcessRecord()
        {
            ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Events.CmdletProcessRecordStart).Wait(); if( ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
            __processRecordId = System.Guid.NewGuid().ToString();
            try
            {
                // work
                if (ShouldProcess($"Call remote 'AccountsCreateOrUpdate' operation"))
                {
                    if (true == MyInvocation?.BoundParameters?.ContainsKey("AsJob"))
                    {
                        var instance = this.Clone();
                        var job = new Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.PowerShell.AsyncJob(instance, this.MyInvocation.Line, this.MyInvocation.MyCommand.Name, this._cancellationTokenSource.Token, this._cancellationTokenSource.Cancel);
                        JobRepository.Add(job);
                        var task = instance.ProcessRecordAsync();
                        job.Monitor(task);
                        WriteObject(job);
                    }
                    else
                    {
                        using( var asyncCommandRuntime = new Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.PowerShell.AsyncCommandRuntime(this, ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.IEventListener)this).Token) )
                        {
                            asyncCommandRuntime.Wait( ProcessRecordAsync(),((Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.IEventListener)this).Token);
                        }
                    }
                }
            }
            catch (global::System.AggregateException aggregateException)
            {
                // unroll the inner exceptions to get the root cause
                foreach( var innerException in aggregateException.Flatten().InnerExceptions )
                {
                    ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Events.CmdletException, $"{innerException.GetType().Name} - {innerException.Message} : {innerException.StackTrace}").Wait(); if( ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                    // Write exception out to error channel.
                    WriteError( new global::System.Management.Automation.ErrorRecord(innerException,string.Empty, global::System.Management.Automation.ErrorCategory.NotSpecified, null) );
                }
            }
            catch (global::System.Exception exception) when ((exception as System.Management.Automation.PipelineStoppedException)== null || (exception as System.Management.Automation.PipelineStoppedException).InnerException != null)
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Events.CmdletException, $"{exception.GetType().Name} - {exception.Message} : {exception.StackTrace}").Wait(); if( ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                // Write exception out to error channel.
                WriteError( new global::System.Management.Automation.ErrorRecord(exception,string.Empty, global::System.Management.Automation.ErrorCategory.NotSpecified, null) );
            }
            finally
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Events.CmdletProcessRecordEnd).Wait();
            }
        }

        /// <summary>Performs execution of the command, working asynchronously if required.</summary>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the method is completed.
        /// </returns>
        protected async global::System.Threading.Tasks.Task ProcessRecordAsync()
        {
            using( NoSynchronizationContext )
            {
                await ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Events.CmdletProcessRecordAsyncStart); if( ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                await ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Events.CmdletGetPipeline); if( ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                Pipeline = Microsoft.Azure.PowerShell.Cmdlets.Purview.Module.Instance.CreatePipeline(InvocationInformation, __correlationId, __processRecordId, this.ParameterSetName);
                if (null != HttpPipelinePrepend)
                {
                    Pipeline.Prepend((this.CommandRuntime as Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.PowerShell.IAsyncCommandRuntimeExtensions)?.Wrap(HttpPipelinePrepend) ?? HttpPipelinePrepend);
                }
                if (null != HttpPipelineAppend)
                {
                    Pipeline.Append((this.CommandRuntime as Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.PowerShell.IAsyncCommandRuntimeExtensions)?.Wrap(HttpPipelineAppend) ?? HttpPipelineAppend);
                }
                // get the client instance
                try
                {
                    await ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Events.CmdletBeforeAPICall); if( ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                    await this.Client.AccountsCreateOrUpdate(SubscriptionId, ResourceGroupName, Name, AccountBody, onOk, onDefault, this, Pipeline);
                    await ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Events.CmdletAfterAPICall); if( ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                }
                catch (Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.UndeclaredResponseException urexception)
                {
                    WriteError(new global::System.Management.Automation.ErrorRecord(urexception, urexception.StatusCode.ToString(), global::System.Management.Automation.ErrorCategory.InvalidOperation, new {  SubscriptionId=SubscriptionId,ResourceGroupName=ResourceGroupName,Name=Name,body=AccountBody})
                    {
                      ErrorDetails = new global::System.Management.Automation.ErrorDetails(urexception.Message) { RecommendedAction = urexception.Action }
                    });
                }
                finally
                {
                    await ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Events.CmdletProcessRecordAsyncEnd);
                }
            }
        }

        /// <summary>Interrupts currently running code within the command.</summary>
        protected override void StopProcessing()
        {
            ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.IEventListener)this).Cancel();
            base.StopProcessing();
        }

        /// <summary>
        /// a delegate that is called when the remote service returns default (any response code not handled elsewhere).
        /// </summary>
        /// <param name="responseMessage">the raw response message as an global::System.Net.Http.HttpResponseMessage.</param>
        /// <param name="response">the body result as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IErrorResponseModel"
        /// /> from the remote call</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the method is completed.
        /// </returns>
        private async global::System.Threading.Tasks.Task onDefault(global::System.Net.Http.HttpResponseMessage responseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IErrorResponseModel> response)
        {
            using( NoSynchronizationContext )
            {
                var _returnNow = global::System.Threading.Tasks.Task<bool>.FromResult(false);
                overrideOnDefault(responseMessage, response, ref _returnNow);
                // if overrideOnDefault has returned true, then return right away.
                if ((null != _returnNow && await _returnNow))
                {
                    return ;
                }
                // Error Response : default
                var code = (await response)?.Code;
                var message = (await response)?.Message;
                if ((null == code || null == message))
                {
                    // Unrecognized Response. Create an error record based on what we have.
                    var ex = new Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.RestException<Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IErrorResponseModel>(responseMessage, await response);
                    WriteError( new global::System.Management.Automation.ErrorRecord(ex, ex.Code, global::System.Management.Automation.ErrorCategory.InvalidOperation, new { SubscriptionId=SubscriptionId, ResourceGroupName=ResourceGroupName, Name=Name, body=AccountBody })
                    {
                      ErrorDetails = new global::System.Management.Automation.ErrorDetails(ex.Message) { RecommendedAction = ex.Action }
                    });
                }
                else
                {
                    WriteError( new global::System.Management.Automation.ErrorRecord(new global::System.Exception($"[{code}] : {message}"), code?.ToString(), global::System.Management.Automation.ErrorCategory.InvalidOperation, new { SubscriptionId=SubscriptionId, ResourceGroupName=ResourceGroupName, Name=Name, body=AccountBody })
                    {
                      ErrorDetails = new global::System.Management.Automation.ErrorDetails(message) { RecommendedAction = global::System.String.Empty }
                    });
                }
            }
        }

        /// <summary>a delegate that is called when the remote service returns 200 (OK).</summary>
        /// <param name="responseMessage">the raw response message as an global::System.Net.Http.HttpResponseMessage.</param>
        /// <param name="response">the body result as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccount"
        /// /> from the remote call</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the method is completed.
        /// </returns>
        private async global::System.Threading.Tasks.Task onOk(global::System.Net.Http.HttpResponseMessage responseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccount> response)
        {
            using( NoSynchronizationContext )
            {
                var _returnNow = global::System.Threading.Tasks.Task<bool>.FromResult(false);
                overrideOnOk(responseMessage, response, ref _returnNow);
                // if overrideOnOk has returned true, then return right away.
                if ((null != _returnNow && await _returnNow))
                {
                    return ;
                }
                // onOk - response for 200 / application/json
                // (await response) // should be Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccount
                WriteObject((await response));
            }
        }
    }
}