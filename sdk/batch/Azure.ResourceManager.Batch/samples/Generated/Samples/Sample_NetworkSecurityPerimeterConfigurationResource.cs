// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;

namespace Azure.ResourceManager.Batch.Samples
{
    public partial class Sample_NetworkSecurityPerimeterConfigurationResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetNspConfiguration()
        {
            // Generated from example definition: specification/batch/resource-manager/Microsoft.Batch/stable/2024-07-01/examples/NspConfigurationGet.json
            // this example is just showing the usage of "NetworkSecurityPerimeter_GetConfiguration" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkSecurityPerimeterConfigurationResource created on azure
            // for more information of creating NetworkSecurityPerimeterConfigurationResource, please refer to the document of NetworkSecurityPerimeterConfigurationResource
            string subscriptionId = "subid";
            string resourceGroupName = "default-azurebatch-japaneast";
            string accountName = "sampleacct";
            string networkSecurityPerimeterConfigurationName = "00000000-0000-0000-0000-000000000000.sampleassociation";
            ResourceIdentifier networkSecurityPerimeterConfigurationResourceId = NetworkSecurityPerimeterConfigurationResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, networkSecurityPerimeterConfigurationName);
            NetworkSecurityPerimeterConfigurationResource networkSecurityPerimeterConfiguration = client.GetNetworkSecurityPerimeterConfigurationResource(networkSecurityPerimeterConfigurationResourceId);

            // invoke the operation
            NetworkSecurityPerimeterConfigurationResource result = await networkSecurityPerimeterConfiguration.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            NetworkSecurityPerimeterConfigurationData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task ReconcileConfiguration_ReconcileNspConfiguration()
        {
            // Generated from example definition: specification/batch/resource-manager/Microsoft.Batch/stable/2024-07-01/examples/NspConfigurationReconcile.json
            // this example is just showing the usage of "NetworkSecurityPerimeter_ReconcileConfiguration" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkSecurityPerimeterConfigurationResource created on azure
            // for more information of creating NetworkSecurityPerimeterConfigurationResource, please refer to the document of NetworkSecurityPerimeterConfigurationResource
            string subscriptionId = "subid";
            string resourceGroupName = "default-azurebatch-japaneast";
            string accountName = "sampleacct";
            string networkSecurityPerimeterConfigurationName = "00000000-0000-0000-0000-000000000000.sampleassociation";
            ResourceIdentifier networkSecurityPerimeterConfigurationResourceId = NetworkSecurityPerimeterConfigurationResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, networkSecurityPerimeterConfigurationName);
            NetworkSecurityPerimeterConfigurationResource networkSecurityPerimeterConfiguration = client.GetNetworkSecurityPerimeterConfigurationResource(networkSecurityPerimeterConfigurationResourceId);

            // invoke the operation
            await networkSecurityPerimeterConfiguration.ReconcileConfigurationAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }
    }
}
