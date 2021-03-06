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

using Microsoft.Azure.Commands.Consumption.Test.ScenarioTests.ScenarioTest;
using Microsoft.Azure.Commands.ScenarioTest;
using Microsoft.WindowsAzure.Commands.ScenarioTest;
using Xunit;
using Microsoft.WindowsAzure.Commands.Test.Utilities.Common;
using Xunit.Abstractions;
using Microsoft.Azure.ServiceManagement.Common.Models;

namespace Microsoft.Azure.Commands.Consumption.Test.ScenarioTests
{
    public class UsageDetailsTests : RMTestBase
    {
        public XunitTracingInterceptor _logger;

        public UsageDetailsTests(Xunit.Abstractions.ITestOutputHelper output)
        {
            _logger = new XunitTracingInterceptor(output);
            XunitTracingInterceptor.AddToContext(_logger);
            TestExecutionHelpers.SetUpSessionAndProfile();
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestListUsageDetails()
        {
            TestController.NewInstance.RunPowerShellTest(_logger, "Test-ListUsageDetails");
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestListUsageDetailsWithMeterDetailsExpand()
        {
            TestController.NewInstance.RunPowerShellTest(_logger, "Test-ListUsageDetailsWithMeterDetailsExpand");
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestListUsageDetailsWithDateFilter()
        {
            TestController.NewInstance.RunPowerShellTest(_logger, "Test-ListUsageDetailsWithDateFilter");
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestListBillingPeriodUsageDetails()
        {
            TestController.NewInstance.RunPowerShellTest(_logger, "Test-ListBillingPeriodUsageDetails");
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestListBillingPeriodUsageDetailsWithFilterOnInstanceName()
        {
            TestController.NewInstance.RunPowerShellTest(_logger, "Test-ListBillingPeriodUsageDetailsWithFilterOnInstanceName");
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestListBillingPeriodUsageDetailsWithDateFilter()
        {
            TestController.NewInstance.RunPowerShellTest(_logger, "Test-ListBillingPeriodUsageDetailsWithDateFilter");
        }

    }
}
