// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using Microsoft.Azure.Commands.Network.Models;
using System.Management.Automation;

namespace Microsoft.Azure.Commands.Network
{
    [Cmdlet("New", ResourceManager.Common.AzureRMConstants.AzureRMPrefix + "NetworkSecurityRuleConfig", DefaultParameterSetName = "SetByResource"), OutputType(typeof(PSSecurityRule))]
    public class NewAzureNetworkSecurityRuleConfigCommand : AzureNetworkSecurityRuleConfigBase
    {
        [Parameter(
            Mandatory = true,
            HelpMessage = "The name of the rule")]
        [ValidateNotNullOrEmpty]
        public override string Name { get; set; }

        public override void Execute()
        {
            base.Execute();

            if ((this.SourceAddressPrefix != null) && (this.SourceAddressPrefix.Length > 0) && (this.SourceApplicationSecurityGroup != null) && (this.SourceApplicationSecurityGroup.Length > 0))
            {
                throw new ArgumentException($"{nameof(SourceAddressPrefix)} and {nameof(SourceApplicationSecurityGroup)} cannot be used simultaneously.");
            }

            if ((this.SourceAddressPrefix != null) && (this.SourceAddressPrefix.Length > 0) && (this.SourceApplicationSecurityGroupId != null) && (this.SourceApplicationSecurityGroupId.Length > 0))
            {
                throw new ArgumentException($"{nameof(SourceAddressPrefix)} and {nameof(SourceApplicationSecurityGroupId)} cannot be used simultaneously.");
            }

            if ((this.DestinationAddressPrefix != null) && (this.DestinationAddressPrefix.Length > 0) && (this.DestinationApplicationSecurityGroup != null) && (this.DestinationApplicationSecurityGroup.Length > 0))
            {
                throw new ArgumentException($"{nameof(DestinationAddressPrefix)} and {nameof(DestinationApplicationSecurityGroup)} cannot be used simultaneously.");
            }

            if ((this.DestinationAddressPrefix != null) && (this.DestinationAddressPrefix.Length > 0) && (this.DestinationApplicationSecurityGroupId != null) && (this.DestinationApplicationSecurityGroupId.Length > 0))
            {
                throw new ArgumentException($"{nameof(DestinationAddressPrefix)} and {nameof(DestinationApplicationSecurityGroupId)} cannot be used simultaneously.");
            }

            var rule = new PSSecurityRule();

            rule.Name = this.Name;
            rule.Description = this.Description;
            rule.Protocol = this.Protocol;
            rule.SourcePortRange = this.SourcePortRange;
            rule.DestinationPortRange = this.DestinationPortRange;
            rule.SourceAddressPrefix = this.SourceAddressPrefix;
            rule.DestinationAddressPrefix = this.DestinationAddressPrefix;
            rule.Access = this.Access;
            rule.Priority = this.Priority;
            rule.Direction = this.Direction;

            SetSourceApplicationSecurityGroupInRule(rule);
            SetDestinationApplicationSecurityGroupInRule(rule);

            WriteObject(rule);
        }

    }
}
