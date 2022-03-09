﻿// ----------------------------------------------------------------------------------
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

using Microsoft.WindowsAzure.Commands.ScenarioTest;
using Moq;
using System.Net;
using Xunit;

namespace Microsoft.Azure.Commands.DataFactories.Test.UnitTests
{
    public class RemoveDataFactoryTests : DataFactoryUnitTestBase
    {
        private RemoveAzureDataFactoryCommand cmdlet;

        public RemoveDataFactoryTests(Xunit.Abstractions.ITestOutputHelper output)
        {
            Azure.ServiceManagement.Common.Models.XunitTracingInterceptor.AddToContext(new Azure.ServiceManagement.Common.Models.XunitTracingInterceptor(output));
            base.SetupTest();

            cmdlet = new RemoveAzureDataFactoryCommand()
            {
                CommandRuntime = commandRuntimeMock.Object,
                DataFactoryClient = dataFactoriesClientMock.Object,
                Name = DataFactoryName,
                ResourceGroupName = ResourceGroupName,
                Force = true
            };
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void CanRemoveDataFactory()
        {
            HttpStatusCode expectedStatusCode = HttpStatusCode.OK;

            // Arrange
            dataFactoriesClientMock.Setup(f => f.DeleteDataFactory(ResourceGroupName, DataFactoryName))
                .Returns(expectedStatusCode)
                .Verifiable();

            commandRuntimeMock.Setup(f => f.ShouldProcess(It.IsAny<string>(), It.IsAny<string>()))
                .Returns(true)
                .Verifiable();

            // Action
            cmdlet.ExecuteCmdlet();

            // Assert
            dataFactoriesClientMock.VerifyAll();

            commandRuntimeMock.VerifyAll();
        }
    }
}
