// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Support
{

    /// <summary>The size of the virtual machine.</summary>
    [System.ComponentModel.TypeConverter(typeof(Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Support.VirtualMachineSizeTypesTypeConverter))]
    public partial struct VirtualMachineSizeTypes :
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
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "Standard_D1_v2".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'Standard_D1_v2'", "Standard_D1_v2", global::System.Management.Automation.CompletionResultType.ParameterValue, "Standard_D1_v2");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "Standard_D2_v2".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'Standard_D2_v2'", "Standard_D2_v2", global::System.Management.Automation.CompletionResultType.ParameterValue, "Standard_D2_v2");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "Standard_D3_v2".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'Standard_D3_v2'", "Standard_D3_v2", global::System.Management.Automation.CompletionResultType.ParameterValue, "Standard_D3_v2");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "Standard_D4_v2".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'Standard_D4_v2'", "Standard_D4_v2", global::System.Management.Automation.CompletionResultType.ParameterValue, "Standard_D4_v2");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "Standard_D5_v2".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'Standard_D5_v2'", "Standard_D5_v2", global::System.Management.Automation.CompletionResultType.ParameterValue, "Standard_D5_v2");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "Standard_D11_v2".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'Standard_D11_v2'", "Standard_D11_v2", global::System.Management.Automation.CompletionResultType.ParameterValue, "Standard_D11_v2");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "Standard_D12_v2".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'Standard_D12_v2'", "Standard_D12_v2", global::System.Management.Automation.CompletionResultType.ParameterValue, "Standard_D12_v2");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "Standard_D13_v2".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'Standard_D13_v2'", "Standard_D13_v2", global::System.Management.Automation.CompletionResultType.ParameterValue, "Standard_D13_v2");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "Standard_DS1_v2".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'Standard_DS1_v2'", "Standard_DS1_v2", global::System.Management.Automation.CompletionResultType.ParameterValue, "Standard_DS1_v2");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "Standard_DS2_v2".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'Standard_DS2_v2'", "Standard_DS2_v2", global::System.Management.Automation.CompletionResultType.ParameterValue, "Standard_DS2_v2");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "Standard_DS3_v2".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'Standard_DS3_v2'", "Standard_DS3_v2", global::System.Management.Automation.CompletionResultType.ParameterValue, "Standard_DS3_v2");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "Standard_DS4_v2".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'Standard_DS4_v2'", "Standard_DS4_v2", global::System.Management.Automation.CompletionResultType.ParameterValue, "Standard_DS4_v2");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "Standard_DS5_v2".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'Standard_DS5_v2'", "Standard_DS5_v2", global::System.Management.Automation.CompletionResultType.ParameterValue, "Standard_DS5_v2");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "Standard_DS11_v2".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'Standard_DS11_v2'", "Standard_DS11_v2", global::System.Management.Automation.CompletionResultType.ParameterValue, "Standard_DS11_v2");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "Standard_DS12_v2".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'Standard_DS12_v2'", "Standard_DS12_v2", global::System.Management.Automation.CompletionResultType.ParameterValue, "Standard_DS12_v2");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "Standard_DS13_v2".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'Standard_DS13_v2'", "Standard_DS13_v2", global::System.Management.Automation.CompletionResultType.ParameterValue, "Standard_DS13_v2");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "Standard_F1".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'Standard_F1'", "Standard_F1", global::System.Management.Automation.CompletionResultType.ParameterValue, "Standard_F1");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "Standard_F2".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'Standard_F2'", "Standard_F2", global::System.Management.Automation.CompletionResultType.ParameterValue, "Standard_F2");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "Standard_F4".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'Standard_F4'", "Standard_F4", global::System.Management.Automation.CompletionResultType.ParameterValue, "Standard_F4");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "Standard_F8".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'Standard_F8'", "Standard_F8", global::System.Management.Automation.CompletionResultType.ParameterValue, "Standard_F8");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "Standard_F16".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'Standard_F16'", "Standard_F16", global::System.Management.Automation.CompletionResultType.ParameterValue, "Standard_F16");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "Standard_F1s".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'Standard_F1s'", "Standard_F1s", global::System.Management.Automation.CompletionResultType.ParameterValue, "Standard_F1s");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "Standard_F2s".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'Standard_F2s'", "Standard_F2s", global::System.Management.Automation.CompletionResultType.ParameterValue, "Standard_F2s");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "Standard_F4s".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'Standard_F4s'", "Standard_F4s", global::System.Management.Automation.CompletionResultType.ParameterValue, "Standard_F4s");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "Standard_F8s".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'Standard_F8s'", "Standard_F8s", global::System.Management.Automation.CompletionResultType.ParameterValue, "Standard_F8s");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "Standard_F16s".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'Standard_F16s'", "Standard_F16s", global::System.Management.Automation.CompletionResultType.ParameterValue, "Standard_F16s");
            }
        }
    }
}