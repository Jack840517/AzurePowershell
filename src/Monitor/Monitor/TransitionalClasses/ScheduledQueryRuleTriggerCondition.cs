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


namespace Microsoft.Azure.Management.Monitor.Management.Models
{
    public class ScheduledQueryRuleTriggerCondition : Monitor.Models.TriggerCondition
    {
        public ScheduledQueryRuleTriggerCondition() : base()
        { }
        /// <summary>
        /// Initializes a new instance of the ScheduledQueryRuleTriggerCondition class.
        /// </summary>
        /// <param name="triggerCondition">The condition that results in the Log Search rule.</param>
        public ScheduledQueryRuleTriggerCondition(Monitor.Models.TriggerCondition triggerCondition) :
            base(
                thresholdOperator: triggerCondition.ThresholdOperator,
                threshold: triggerCondition.Threshold,
                metricTrigger: triggerCondition.MetricTrigger)
        { }
    }
}
