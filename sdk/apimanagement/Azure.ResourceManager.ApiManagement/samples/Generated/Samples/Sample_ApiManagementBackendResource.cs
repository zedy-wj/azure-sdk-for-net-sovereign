// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using System.Xml;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.ApiManagement.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.ApiManagement.Samples
{
    public partial class Sample_ApiManagementBackendResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_ApiManagementGetBackend()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/preview/2023-03-01-preview/examples/ApiManagementGetBackend.json
            // this example is just showing the usage of "Backend_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ApiManagementBackendResource created on azure
            // for more information of creating ApiManagementBackendResource, please refer to the document of ApiManagementBackendResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string backendId = "sfbackend";
            ResourceIdentifier apiManagementBackendResourceId = ApiManagementBackendResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, backendId);
            ApiManagementBackendResource apiManagementBackend = client.GetApiManagementBackendResource(apiManagementBackendResourceId);

            // invoke the operation
            ApiManagementBackendResource result = await apiManagementBackend.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ApiManagementBackendData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_ApiManagementDeleteBackend()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/preview/2023-03-01-preview/examples/ApiManagementDeleteBackend.json
            // this example is just showing the usage of "Backend_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ApiManagementBackendResource created on azure
            // for more information of creating ApiManagementBackendResource, please refer to the document of ApiManagementBackendResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string backendId = "sfbackend";
            ResourceIdentifier apiManagementBackendResourceId = ApiManagementBackendResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, backendId);
            ApiManagementBackendResource apiManagementBackend = client.GetApiManagementBackendResource(apiManagementBackendResourceId);

            // invoke the operation
            ETag ifMatch = new ETag("*");
            await apiManagementBackend.DeleteAsync(WaitUntil.Completed, ifMatch);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_ApiManagementUpdateBackend()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/preview/2023-03-01-preview/examples/ApiManagementUpdateBackend.json
            // this example is just showing the usage of "Backend_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ApiManagementBackendResource created on azure
            // for more information of creating ApiManagementBackendResource, please refer to the document of ApiManagementBackendResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string backendId = "proxybackend";
            ResourceIdentifier apiManagementBackendResourceId = ApiManagementBackendResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, backendId);
            ApiManagementBackendResource apiManagementBackend = client.GetApiManagementBackendResource(apiManagementBackendResourceId);

            // invoke the operation
            ETag ifMatch = new ETag("*");
            ApiManagementBackendPatch patch = new ApiManagementBackendPatch
            {
                Description = "description5308",
                Tls = new BackendTlsProperties
                {
                    ShouldValidateCertificateChain = false,
                    ShouldValidateCertificateName = true,
                },
            };
            ApiManagementBackendResource result = await apiManagementBackend.UpdateAsync(ifMatch, patch);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ApiManagementBackendData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Reconnect_ApiManagementBackendReconnect()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/preview/2023-03-01-preview/examples/ApiManagementBackendReconnect.json
            // this example is just showing the usage of "Backend_Reconnect" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ApiManagementBackendResource created on azure
            // for more information of creating ApiManagementBackendResource, please refer to the document of ApiManagementBackendResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string backendId = "proxybackend";
            ResourceIdentifier apiManagementBackendResourceId = ApiManagementBackendResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, backendId);
            ApiManagementBackendResource apiManagementBackend = client.GetApiManagementBackendResource(apiManagementBackendResourceId);

            // invoke the operation
            BackendReconnectContract backendReconnectContract = new BackendReconnectContract
            {
                After = XmlConvert.ToTimeSpan("PT3S"),
            };
            await apiManagementBackend.ReconnectAsync(backendReconnectContract: backendReconnectContract);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetEntityTag_ApiManagementHeadBackend()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/preview/2023-03-01-preview/examples/ApiManagementHeadBackend.json
            // this example is just showing the usage of "Backend_GetEntityTag" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ApiManagementBackendResource created on azure
            // for more information of creating ApiManagementBackendResource, please refer to the document of ApiManagementBackendResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string backendId = "sfbackend";
            ResourceIdentifier apiManagementBackendResourceId = ApiManagementBackendResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, backendId);
            ApiManagementBackendResource apiManagementBackend = client.GetApiManagementBackendResource(apiManagementBackendResourceId);

            // invoke the operation
            bool result = await apiManagementBackend.GetEntityTagAsync();

            Console.WriteLine($"Succeeded: {result}");
        }
    }
}
