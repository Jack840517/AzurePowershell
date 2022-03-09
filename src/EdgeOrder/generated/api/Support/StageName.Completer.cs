// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Support
{

    /// <summary>Stage name</summary>
    [System.ComponentModel.TypeConverter(typeof(Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Support.StageNameTypeConverter))]
    public partial struct StageName :
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
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "Placed".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'Placed'", "Placed", global::System.Management.Automation.CompletionResultType.ParameterValue, "Placed");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "InReview".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'InReview'", "InReview", global::System.Management.Automation.CompletionResultType.ParameterValue, "InReview");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "Confirmed".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'Confirmed'", "Confirmed", global::System.Management.Automation.CompletionResultType.ParameterValue, "Confirmed");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "ReadyToShip".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'ReadyToShip'", "ReadyToShip", global::System.Management.Automation.CompletionResultType.ParameterValue, "ReadyToShip");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "Shipped".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'Shipped'", "Shipped", global::System.Management.Automation.CompletionResultType.ParameterValue, "Shipped");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "Delivered".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'Delivered'", "Delivered", global::System.Management.Automation.CompletionResultType.ParameterValue, "Delivered");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "InUse".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'InUse'", "InUse", global::System.Management.Automation.CompletionResultType.ParameterValue, "InUse");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "ReturnInitiated".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'ReturnInitiated'", "ReturnInitiated", global::System.Management.Automation.CompletionResultType.ParameterValue, "ReturnInitiated");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "ReturnPickedUp".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'ReturnPickedUp'", "ReturnPickedUp", global::System.Management.Automation.CompletionResultType.ParameterValue, "ReturnPickedUp");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "ReturnedToMicrosoft".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'ReturnedToMicrosoft'", "ReturnedToMicrosoft", global::System.Management.Automation.CompletionResultType.ParameterValue, "ReturnedToMicrosoft");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "ReturnCompleted".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'ReturnCompleted'", "ReturnCompleted", global::System.Management.Automation.CompletionResultType.ParameterValue, "ReturnCompleted");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "Cancelled".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'Cancelled'", "Cancelled", global::System.Management.Automation.CompletionResultType.ParameterValue, "Cancelled");
            }
        }
    }
}