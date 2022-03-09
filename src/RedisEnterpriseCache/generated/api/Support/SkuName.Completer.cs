// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Support
{

    /// <summary>
    /// The type of RedisEnterprise cluster to deploy. Possible values: (Enterprise_E10, EnterpriseFlash_F300 etc.)
    /// </summary>
    [System.ComponentModel.TypeConverter(typeof(Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Support.SkuNameTypeConverter))]
    public partial struct SkuName :
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
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "Enterprise_E10".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("Enterprise_E10", "Enterprise_E10", global::System.Management.Automation.CompletionResultType.ParameterValue, "Enterprise_E10");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "Enterprise_E20".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("Enterprise_E20", "Enterprise_E20", global::System.Management.Automation.CompletionResultType.ParameterValue, "Enterprise_E20");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "Enterprise_E50".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("Enterprise_E50", "Enterprise_E50", global::System.Management.Automation.CompletionResultType.ParameterValue, "Enterprise_E50");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "Enterprise_E100".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("Enterprise_E100", "Enterprise_E100", global::System.Management.Automation.CompletionResultType.ParameterValue, "Enterprise_E100");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "EnterpriseFlash_F300".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("EnterpriseFlash_F300", "EnterpriseFlash_F300", global::System.Management.Automation.CompletionResultType.ParameterValue, "EnterpriseFlash_F300");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "EnterpriseFlash_F700".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("EnterpriseFlash_F700", "EnterpriseFlash_F700", global::System.Management.Automation.CompletionResultType.ParameterValue, "EnterpriseFlash_F700");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "EnterpriseFlash_F1500".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("EnterpriseFlash_F1500", "EnterpriseFlash_F1500", global::System.Management.Automation.CompletionResultType.ParameterValue, "EnterpriseFlash_F1500");
            }
        }
    }
}