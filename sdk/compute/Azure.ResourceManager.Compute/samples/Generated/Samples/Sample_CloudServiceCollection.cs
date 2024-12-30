// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Compute.Models;
using Azure.ResourceManager.Resources;
using NUnit.Framework;

namespace Azure.ResourceManager.Compute.Samples
{
    public partial class Sample_CloudServiceCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_CreateNewCloudServiceWithMultipleRoles()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/CloudserviceRP/stable/2022-09-04/examples/CloudService_Create_WithMultiRole.json
            // this example is just showing the usage of "CloudServices_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "ConstosoRG";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this CloudServiceResource
            CloudServiceCollection collection = resourceGroupResource.GetCloudServices();

            // invoke the operation
            string cloudServiceName = "{cs-name}";
            CloudServiceData data = new CloudServiceData(new AzureLocation("westus"))
            {
                PackageUri = new Uri("{PackageUrl}"),
                Configuration = "{ServiceConfiguration}",
                UpgradeMode = CloudServiceUpgradeMode.Auto,
                Roles = {new CloudServiceRoleProfileProperties
{
Name = "ContosoFrontend",
Sku = new CloudServiceRoleSku
{
Name = "Standard_D1_v2",
Tier = "Standard",
Capacity = 1L,
},
}, new CloudServiceRoleProfileProperties
{
Name = "ContosoBackend",
Sku = new CloudServiceRoleSku
{
Name = "Standard_D1_v2",
Tier = "Standard",
Capacity = 1L,
},
}},
                NetworkProfile = new CloudServiceNetworkProfile
                {
                    LoadBalancerConfigurations = {new CloudServiceLoadBalancerConfiguration("contosolb", new LoadBalancerFrontendIPConfiguration[]
{
new LoadBalancerFrontendIPConfiguration("contosofe")
{
PublicIPAddressId = new ResourceIdentifier("/subscriptions/{subscription-id}/resourceGroups/ConstosoRG/providers/Microsoft.Network/publicIPAddresses/contosopublicip"),
}
})},
                },
            };
            ArmOperation<CloudServiceResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, cloudServiceName, data);
            CloudServiceResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            CloudServiceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_CreateNewCloudServiceWithMultipleRolesInASpecificAvailabilityZone()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/CloudserviceRP/stable/2022-09-04/examples/CloudService_Create_WithMultiRole_WithZones.json
            // this example is just showing the usage of "CloudServices_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "ConstosoRG";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this CloudServiceResource
            CloudServiceCollection collection = resourceGroupResource.GetCloudServices();

            // invoke the operation
            string cloudServiceName = "{cs-name}";
            CloudServiceData data = new CloudServiceData(new AzureLocation("westus"))
            {
                Zones = { "1" },
                PackageUri = new Uri("{PackageUrl}"),
                Configuration = "{ServiceConfiguration}",
                UpgradeMode = CloudServiceUpgradeMode.Auto,
                Roles = {new CloudServiceRoleProfileProperties
{
Name = "ContosoFrontend",
Sku = new CloudServiceRoleSku
{
Name = "Standard_D1_v2",
Tier = "Standard",
Capacity = 1L,
},
}, new CloudServiceRoleProfileProperties
{
Name = "ContosoBackend",
Sku = new CloudServiceRoleSku
{
Name = "Standard_D1_v2",
Tier = "Standard",
Capacity = 1L,
},
}},
                NetworkProfile = new CloudServiceNetworkProfile
                {
                    LoadBalancerConfigurations = {new CloudServiceLoadBalancerConfiguration("contosolb", new LoadBalancerFrontendIPConfiguration[]
{
new LoadBalancerFrontendIPConfiguration("contosofe")
{
PublicIPAddressId = new ResourceIdentifier("/subscriptions/{subscription-id}/resourceGroups/ConstosoRG/providers/Microsoft.Network/publicIPAddresses/contosopublicip"),
}
})},
                },
            };
            ArmOperation<CloudServiceResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, cloudServiceName, data);
            CloudServiceResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            CloudServiceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_CreateNewCloudServiceWithSingleRole()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/CloudserviceRP/stable/2022-09-04/examples/CloudService_Create_WithSingleRole.json
            // this example is just showing the usage of "CloudServices_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "ConstosoRG";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this CloudServiceResource
            CloudServiceCollection collection = resourceGroupResource.GetCloudServices();

            // invoke the operation
            string cloudServiceName = "{cs-name}";
            CloudServiceData data = new CloudServiceData(new AzureLocation("westus"))
            {
                PackageUri = new Uri("{PackageUrl}"),
                Configuration = "{ServiceConfiguration}",
                UpgradeMode = CloudServiceUpgradeMode.Auto,
                Roles = {new CloudServiceRoleProfileProperties
{
Name = "ContosoFrontend",
Sku = new CloudServiceRoleSku
{
Name = "Standard_D1_v2",
Tier = "Standard",
Capacity = 1L,
},
}},
                NetworkProfile = new CloudServiceNetworkProfile
                {
                    LoadBalancerConfigurations = {new CloudServiceLoadBalancerConfiguration("myLoadBalancer", new LoadBalancerFrontendIPConfiguration[]
{
new LoadBalancerFrontendIPConfiguration("myfe")
{
PublicIPAddressId = new ResourceIdentifier("/subscriptions/{subscription-id}/resourceGroups/ConstosoRG/providers/Microsoft.Network/publicIPAddresses/myPublicIP"),
}
})},
                },
            };
            ArmOperation<CloudServiceResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, cloudServiceName, data);
            CloudServiceResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            CloudServiceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_CreateNewCloudServiceWithSingleRoleAndCertificateFromKeyVault()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/CloudserviceRP/stable/2022-09-04/examples/CloudService_Create_WithSingleRoleAndCertificate.json
            // this example is just showing the usage of "CloudServices_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "ConstosoRG";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this CloudServiceResource
            CloudServiceCollection collection = resourceGroupResource.GetCloudServices();

            // invoke the operation
            string cloudServiceName = "{cs-name}";
            CloudServiceData data = new CloudServiceData(new AzureLocation("westus"))
            {
                PackageUri = new Uri("{PackageUrl}"),
                Configuration = "{ServiceConfiguration}",
                UpgradeMode = CloudServiceUpgradeMode.Auto,
                Roles = {new CloudServiceRoleProfileProperties
{
Name = "ContosoFrontend",
Sku = new CloudServiceRoleSku
{
Name = "Standard_D1_v2",
Tier = "Standard",
Capacity = 1L,
},
}},
                OSSecrets = {new CloudServiceVaultSecretGroup
{
SourceVaultId = new ResourceIdentifier("/subscriptions/{subscription-id}/resourceGroups/ConstosoRG/providers/Microsoft.KeyVault/vaults/{keyvault-name}"),
VaultCertificates = {new CloudServiceVaultCertificate
{
CertificateUri = new Uri("https://{keyvault-name}.vault.azure.net:443/secrets/ContosoCertificate/{secret-id}"),
}},
}},
                NetworkProfile = new CloudServiceNetworkProfile
                {
                    LoadBalancerConfigurations = {new CloudServiceLoadBalancerConfiguration("contosolb", new LoadBalancerFrontendIPConfiguration[]
{
new LoadBalancerFrontendIPConfiguration("contosofe")
{
PublicIPAddressId = new ResourceIdentifier("/subscriptions/{subscription-id}/resourceGroups/ConstosoRG/providers/Microsoft.Network/publicIPAddresses/contosopublicip"),
}
})},
                },
            };
            ArmOperation<CloudServiceResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, cloudServiceName, data);
            CloudServiceResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            CloudServiceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_CreateNewCloudServiceWithSingleRoleAndRDPExtension()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/CloudserviceRP/stable/2022-09-04/examples/CloudService_Create_WithSingleRoleAndRDP.json
            // this example is just showing the usage of "CloudServices_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "ConstosoRG";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this CloudServiceResource
            CloudServiceCollection collection = resourceGroupResource.GetCloudServices();

            // invoke the operation
            string cloudServiceName = "{cs-name}";
            CloudServiceData data = new CloudServiceData(new AzureLocation("westus"))
            {
                PackageUri = new Uri("{PackageUrl}"),
                Configuration = "{ServiceConfiguration}",
                UpgradeMode = CloudServiceUpgradeMode.Auto,
                Roles = {new CloudServiceRoleProfileProperties
{
Name = "ContosoFrontend",
Sku = new CloudServiceRoleSku
{
Name = "Standard_D1_v2",
Tier = "Standard",
Capacity = 1L,
},
}},
                NetworkProfile = new CloudServiceNetworkProfile
                {
                    LoadBalancerConfigurations = {new CloudServiceLoadBalancerConfiguration("contosolb", new LoadBalancerFrontendIPConfiguration[]
{
new LoadBalancerFrontendIPConfiguration("contosofe")
{
PublicIPAddressId = new ResourceIdentifier("/subscriptions/{subscription-id}/resourceGroups/ConstosoRG/providers/Microsoft.Network/publicIPAddresses/contosopublicip"),
}
})},
                },
                Extensions = {new CloudServiceExtension
{
Name = "RDPExtension",
Publisher = "Microsoft.Windows.Azure.Extensions",
CloudServiceExtensionPropertiesType = "RDP",
TypeHandlerVersion = "1.2",
AutoUpgradeMinorVersion = false,
Settings = BinaryData.FromObjectAsJson("<PublicConfig><UserName>UserAzure</UserName><Expiration>10/22/2021 15:05:45</Expiration></PublicConfig>"),
ProtectedSettings = BinaryData.FromObjectAsJson("<PrivateConfig><Password>{password}</Password></PrivateConfig>"),
}},
            };
            ArmOperation<CloudServiceResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, cloudServiceName, data);
            CloudServiceResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            CloudServiceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetCloudServiceWithMultipleRolesAndRDPExtension()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/CloudserviceRP/stable/2022-09-04/examples/CloudService_Get_WithMultiRoleAndRDP.json
            // this example is just showing the usage of "CloudServices_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "ConstosoRG";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this CloudServiceResource
            CloudServiceCollection collection = resourceGroupResource.GetCloudServices();

            // invoke the operation
            string cloudServiceName = "{cs-name}";
            CloudServiceResource result = await collection.GetAsync(cloudServiceName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            CloudServiceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_ListCloudServicesInAResourceGroup()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/CloudserviceRP/stable/2022-09-04/examples/CloudService_List_ByResourceGroup.json
            // this example is just showing the usage of "CloudServices_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "ConstosoRG";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this CloudServiceResource
            CloudServiceCollection collection = resourceGroupResource.GetCloudServices();

            // invoke the operation and iterate over the result
            await foreach (CloudServiceResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                CloudServiceData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_GetCloudServiceWithMultipleRolesAndRDPExtension()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/CloudserviceRP/stable/2022-09-04/examples/CloudService_Get_WithMultiRoleAndRDP.json
            // this example is just showing the usage of "CloudServices_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "ConstosoRG";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this CloudServiceResource
            CloudServiceCollection collection = resourceGroupResource.GetCloudServices();

            // invoke the operation
            string cloudServiceName = "{cs-name}";
            bool result = await collection.ExistsAsync(cloudServiceName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_GetCloudServiceWithMultipleRolesAndRDPExtension()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/CloudserviceRP/stable/2022-09-04/examples/CloudService_Get_WithMultiRoleAndRDP.json
            // this example is just showing the usage of "CloudServices_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "ConstosoRG";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this CloudServiceResource
            CloudServiceCollection collection = resourceGroupResource.GetCloudServices();

            // invoke the operation
            string cloudServiceName = "{cs-name}";
            NullableResponse<CloudServiceResource> response = await collection.GetIfExistsAsync(cloudServiceName);
            CloudServiceResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                CloudServiceData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
