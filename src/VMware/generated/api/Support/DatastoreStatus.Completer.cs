// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.VMware.Support
{

    /// <summary>The operational status of the datastore</summary>
    [System.ComponentModel.TypeConverter(typeof(Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.DatastoreStatusTypeConverter))]
    public partial struct DatastoreStatus :
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
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "Unknown".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'Unknown'", "Unknown", global::System.Management.Automation.CompletionResultType.ParameterValue, "Unknown");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "Accessible".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'Accessible'", "Accessible", global::System.Management.Automation.CompletionResultType.ParameterValue, "Accessible");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "Inaccessible".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'Inaccessible'", "Inaccessible", global::System.Management.Automation.CompletionResultType.ParameterValue, "Inaccessible");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "Attached".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'Attached'", "Attached", global::System.Management.Automation.CompletionResultType.ParameterValue, "Attached");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "Detached".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'Detached'", "Detached", global::System.Management.Automation.CompletionResultType.ParameterValue, "Detached");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "LostCommunication".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'LostCommunication'", "LostCommunication", global::System.Management.Automation.CompletionResultType.ParameterValue, "LostCommunication");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "DeadOrError".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'DeadOrError'", "DeadOrError", global::System.Management.Automation.CompletionResultType.ParameterValue, "DeadOrError");
            }
        }
    }
}