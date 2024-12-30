// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;

namespace Azure.ResourceManager.Network.Samples
{
    public partial class Sample_NetworkVirtualApplianceSkuResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_NetworkVirtualApplianceSkuGet()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-05-01/examples/NetworkVirtualApplianceSkuGet.json
            // this example is just showing the usage of "VirtualApplianceSkus_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkVirtualApplianceSkuResource created on azure
            // for more information of creating NetworkVirtualApplianceSkuResource, please refer to the document of NetworkVirtualApplianceSkuResource
            string subscriptionId = "subid";
            string skuName = "ciscoSdwan";
            ResourceIdentifier networkVirtualApplianceSkuResourceId = NetworkVirtualApplianceSkuResource.CreateResourceIdentifier(subscriptionId, skuName);
            NetworkVirtualApplianceSkuResource networkVirtualApplianceSku = client.GetNetworkVirtualApplianceSkuResource(networkVirtualApplianceSkuResourceId);

            // invoke the operation
            NetworkVirtualApplianceSkuResource result = await networkVirtualApplianceSku.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            NetworkVirtualApplianceSkuData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
