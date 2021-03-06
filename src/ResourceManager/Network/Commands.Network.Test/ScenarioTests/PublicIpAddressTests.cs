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

using Microsoft.Azure.ServiceManagemenet.Common.Models;
using Microsoft.WindowsAzure.Commands.ScenarioTest;
using Xunit;
using Xunit.Abstractions;

namespace Commands.Network.Test.ScenarioTests
{
    public class PublicIpAddressTests : Microsoft.WindowsAzure.Commands.Test.Utilities.Common.RMTestBase
    {
        public PublicIpAddressTests(ITestOutputHelper output)
        {
            XunitTracingInterceptor.AddToContext(new XunitTracingInterceptor(output));
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestPublicIpAddressCRUD()
        {
            NetworkResourcesController.NewInstance.RunPsTest("Test-PublicIpAddressCRUD");
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestPublicIpAddressCRUDNoDomainNameLabel()
        {
            NetworkResourcesController.NewInstance.RunPsTest("Test-PublicIpAddressCRUD-NoDomainNameLabel");
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestPublicIpAddressCRUDStaticAllocation()
        {
            NetworkResourcesController.NewInstance.RunPsTest("Test-PublicIpAddressCRUD-StaticAllocation");
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestPublicIpAddressCRUDEditDomainNameLavel()
        {
            NetworkResourcesController.NewInstance.RunPsTest("Test-PublicIpAddressCRUD-EditDomainNameLavel");
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestPublicIpAddressCRUDReverseFqdn()
        {
            NetworkResourcesController.NewInstance.RunPsTest("Test-PublicIpAddressCRUD-ReverseFqdn");
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestPublicIpAddressCRUDIpTag()
        {
            NetworkResourcesController.NewInstance.RunPsTest("Test-PublicIpAddressCRUD-IpTag");
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestPublicIpAddressIpVersion()
        {
            NetworkResourcesController.NewInstance.RunPsTest("Test-PublicIpAddressIpVersion");
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestPublicIpAddressVmss()
        {
            NetworkResourcesController.NewInstance.RunPsTest("Test-PublicIpAddressVmss");
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestPublicIpBasicSku()
        {
            NetworkResourcesController.NewInstance.RunPsTest("Test-PublicIpAddressCRUD-BasicSku");
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestPublicIpStandardSku()
        {
            NetworkResourcesController.NewInstance.RunPsTest("Test-PublicIpAddressCRUD-StandardSku");
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestPublicIpAddressZones()
        {
            NetworkResourcesController.NewInstance.RunPsTest("Test-PublicIpAddressZones");
        }
    }
}
