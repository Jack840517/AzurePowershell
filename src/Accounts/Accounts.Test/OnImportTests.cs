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

using System.IO;

using Microsoft.Azure.Commands.Common.Authentication;
using Microsoft.Azure.Commands.Common.Authentication.Abstractions;
using Microsoft.WindowsAzure.Commands.ScenarioTest;

using Moq;

using Xunit;

namespace Microsoft.Azure.Commands.Profile.Test
{
    public class OnImportTests
    {

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        //Verify no error happens if user profile path is inaccessible
        public void UserProfilePathInAccessible()
        {
            var cmdlt = new ConnectAzureRmAccountCommand();

            // Setup
            var mockChecker = new Mock<TokenCachePersistenceChecker>();
            mockChecker.Setup(c => c.Verify()).Throws(new FileNotFoundException());
            cmdlt.TokenCachePersistenceChecker = mockChecker.Object;

            // Act
            cmdlt.OnImport();

            //Verify
            Assert.Equal(AzureSession.Instance.ARMContextSaveMode, ContextSaveMode.Process);
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void PersistenceCheckReturnFalse()
        {
            // Setup
            var cmdlt = new ConnectAzureRmAccountCommand();
            var mockChecker = new Mock<TokenCachePersistenceChecker>();
            mockChecker.Setup(f => f.Verify()).Returns(false);
            cmdlt.TokenCachePersistenceChecker = mockChecker.Object;

            // Act
            cmdlt.OnImport();

            //Verify
            Assert.Equal(AzureSession.Instance.ARMContextSaveMode, ContextSaveMode.Process);
        }
    }
}