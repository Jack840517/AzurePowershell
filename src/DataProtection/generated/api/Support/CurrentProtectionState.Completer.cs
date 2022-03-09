// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support
{

    /// <summary>Specifies the current protection state of the resource</summary>
    [System.ComponentModel.TypeConverter(typeof(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.CurrentProtectionStateTypeConverter))]
    public partial struct CurrentProtectionState :
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
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "Invalid".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'Invalid'", "Invalid", global::System.Management.Automation.CompletionResultType.ParameterValue, "Invalid");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "NotProtected".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'NotProtected'", "NotProtected", global::System.Management.Automation.CompletionResultType.ParameterValue, "NotProtected");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "ConfiguringProtection".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'ConfiguringProtection'", "ConfiguringProtection", global::System.Management.Automation.CompletionResultType.ParameterValue, "ConfiguringProtection");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "ProtectionConfigured".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'ProtectionConfigured'", "ProtectionConfigured", global::System.Management.Automation.CompletionResultType.ParameterValue, "ProtectionConfigured");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "BackupSchedulesSuspended".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'BackupSchedulesSuspended'", "BackupSchedulesSuspended", global::System.Management.Automation.CompletionResultType.ParameterValue, "BackupSchedulesSuspended");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "RetentionSchedulesSuspended".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'RetentionSchedulesSuspended'", "RetentionSchedulesSuspended", global::System.Management.Automation.CompletionResultType.ParameterValue, "RetentionSchedulesSuspended");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "ProtectionStopped".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'ProtectionStopped'", "ProtectionStopped", global::System.Management.Automation.CompletionResultType.ParameterValue, "ProtectionStopped");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "ProtectionError".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'ProtectionError'", "ProtectionError", global::System.Management.Automation.CompletionResultType.ParameterValue, "ProtectionError");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "ConfiguringProtectionFailed".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'ConfiguringProtectionFailed'", "ConfiguringProtectionFailed", global::System.Management.Automation.CompletionResultType.ParameterValue, "ConfiguringProtectionFailed");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "SoftDeleting".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'SoftDeleting'", "SoftDeleting", global::System.Management.Automation.CompletionResultType.ParameterValue, "SoftDeleting");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "SoftDeleted".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'SoftDeleted'", "SoftDeleted", global::System.Management.Automation.CompletionResultType.ParameterValue, "SoftDeleted");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "UpdatingProtection".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'UpdatingProtection'", "UpdatingProtection", global::System.Management.Automation.CompletionResultType.ParameterValue, "UpdatingProtection");
            }
        }
    }
}