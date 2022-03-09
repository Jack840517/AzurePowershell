// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Datadog.Support
{

    /// <summary>
    /// Flag specifying the Marketplace Subscription Status of the resource. If payment is not made in time, the resource will
    /// go in Suspended state.
    /// </summary>
    [System.ComponentModel.TypeConverter(typeof(Microsoft.Azure.PowerShell.Cmdlets.Datadog.Support.MarketplaceSubscriptionStatusTypeConverter))]
    public partial struct MarketplaceSubscriptionStatus :
        System.Management.Automation.IArgumentCompleter
    {

        /// <summary>
        /// Implementations of this function are called by PowerShell to complete arguments.
        /// </summary>
        /// <param name="commandName">The name of the command that needs argument completion.</param>
        /// <param name="parameterName">The name of the parameter that needs argument completion.</param>
        /// <param name="wordToComplete">The (possibly empty) word being completed.</param>
        /// <param name="commandAst">The command ast in case it is needed for completion.</param>
        /// <param name="fakeBoundParameters">This parameter is similar to $PSBoundParameters, except that sometimes PowerShell cannot
        /// or will not attempt to evaluate an argument, in which case you may need to use commandAst.</param>
        /// <returns>
        /// A collection of completion results, most like with ResultType set to ParameterValue.
        /// </returns>
        public global::System.Collections.Generic.IEnumerable<global::System.Management.Automation.CompletionResult> CompleteArgument(global::System.String commandName, global::System.String parameterName, global::System.String wordToComplete, global::System.Management.Automation.Language.CommandAst commandAst, global::System.Collections.IDictionary fakeBoundParameters)
        {
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "Provisioning".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("Provisioning", "Provisioning", global::System.Management.Automation.CompletionResultType.ParameterValue, "Provisioning");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "Active".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("Active", "Active", global::System.Management.Automation.CompletionResultType.ParameterValue, "Active");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "Suspended".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("Suspended", "Suspended", global::System.Management.Automation.CompletionResultType.ParameterValue, "Suspended");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "Unsubscribed".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("Unsubscribed", "Unsubscribed", global::System.Management.Automation.CompletionResultType.ParameterValue, "Unsubscribed");
            }
        }
    }
}