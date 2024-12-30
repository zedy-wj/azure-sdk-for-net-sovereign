// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Resources;
using NUnit.Framework;

namespace Azure.ResourceManager.Compute.Samples
{
    public partial class Sample_DiskAccessCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_CreateADiskAccessResource()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/DiskRP/stable/2024-03-02/examples/diskAccessExamples/DiskAccess_Create.json
            // this example is just showing the usage of "DiskAccesses_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "myResourceGroup";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this DiskAccessResource
            DiskAccessCollection collection = resourceGroupResource.GetDiskAccesses();

            // invoke the operation
            string diskAccessName = "myDiskAccess";
            DiskAccessData data = new DiskAccessData(new AzureLocation("West US"));
            ArmOperation<DiskAccessResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, diskAccessName, data);
            DiskAccessResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DiskAccessData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetInformationAboutADiskAccessResourceWithPrivateEndpoints()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/DiskRP/stable/2024-03-02/examples/diskAccessExamples/DiskAccess_Get_WithPrivateEndpoints.json
            // this example is just showing the usage of "DiskAccesses_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "myResourceGroup";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this DiskAccessResource
            DiskAccessCollection collection = resourceGroupResource.GetDiskAccesses();

            // invoke the operation
            string diskAccessName = "myDiskAccess";
            DiskAccessResource result = await collection.GetAsync(diskAccessName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DiskAccessData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetInformationAboutADiskAccessResource()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/DiskRP/stable/2024-03-02/examples/diskAccessExamples/DiskAccess_Get.json
            // this example is just showing the usage of "DiskAccesses_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "myResourceGroup";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this DiskAccessResource
            DiskAccessCollection collection = resourceGroupResource.GetDiskAccesses();

            // invoke the operation
            string diskAccessName = "myDiskAccess";
            DiskAccessResource result = await collection.GetAsync(diskAccessName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DiskAccessData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_ListAllDiskAccessResourcesInAResourceGroup()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/DiskRP/stable/2024-03-02/examples/diskAccessExamples/DiskAccess_ListByResourceGroup.json
            // this example is just showing the usage of "DiskAccesses_ListByResourceGroup" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "myResourceGroup";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this DiskAccessResource
            DiskAccessCollection collection = resourceGroupResource.GetDiskAccesses();

            // invoke the operation and iterate over the result
            await foreach (DiskAccessResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                DiskAccessData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_GetInformationAboutADiskAccessResourceWithPrivateEndpoints()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/DiskRP/stable/2024-03-02/examples/diskAccessExamples/DiskAccess_Get_WithPrivateEndpoints.json
            // this example is just showing the usage of "DiskAccesses_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "myResourceGroup";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this DiskAccessResource
            DiskAccessCollection collection = resourceGroupResource.GetDiskAccesses();

            // invoke the operation
            string diskAccessName = "myDiskAccess";
            bool result = await collection.ExistsAsync(diskAccessName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_GetInformationAboutADiskAccessResource()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/DiskRP/stable/2024-03-02/examples/diskAccessExamples/DiskAccess_Get.json
            // this example is just showing the usage of "DiskAccesses_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "myResourceGroup";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this DiskAccessResource
            DiskAccessCollection collection = resourceGroupResource.GetDiskAccesses();

            // invoke the operation
            string diskAccessName = "myDiskAccess";
            bool result = await collection.ExistsAsync(diskAccessName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_GetInformationAboutADiskAccessResourceWithPrivateEndpoints()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/DiskRP/stable/2024-03-02/examples/diskAccessExamples/DiskAccess_Get_WithPrivateEndpoints.json
            // this example is just showing the usage of "DiskAccesses_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "myResourceGroup";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this DiskAccessResource
            DiskAccessCollection collection = resourceGroupResource.GetDiskAccesses();

            // invoke the operation
            string diskAccessName = "myDiskAccess";
            NullableResponse<DiskAccessResource> response = await collection.GetIfExistsAsync(diskAccessName);
            DiskAccessResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                DiskAccessData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_GetInformationAboutADiskAccessResource()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/DiskRP/stable/2024-03-02/examples/diskAccessExamples/DiskAccess_Get.json
            // this example is just showing the usage of "DiskAccesses_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "myResourceGroup";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this DiskAccessResource
            DiskAccessCollection collection = resourceGroupResource.GetDiskAccesses();

            // invoke the operation
            string diskAccessName = "myDiskAccess";
            NullableResponse<DiskAccessResource> response = await collection.GetIfExistsAsync(diskAccessName);
            DiskAccessResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                DiskAccessData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
