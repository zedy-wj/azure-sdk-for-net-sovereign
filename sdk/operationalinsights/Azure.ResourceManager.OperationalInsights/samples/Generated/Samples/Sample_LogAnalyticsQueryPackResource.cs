// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.OperationalInsights.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.OperationalInsights.Samples
{
    public partial class Sample_LogAnalyticsQueryPackResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_QueryPackGet()
        {
            // Generated from example definition: specification/operationalinsights/resource-manager/Microsoft.OperationalInsights/stable/2019-09-01/examples/QueryPacksGet.json
            // this example is just showing the usage of "QueryPacks_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this LogAnalyticsQueryPackResource created on azure
            // for more information of creating LogAnalyticsQueryPackResource, please refer to the document of LogAnalyticsQueryPackResource
            string subscriptionId = "86dc51d3-92ed-4d7e-947a-775ea79b4919";
            string resourceGroupName = "my-resource-group";
            string queryPackName = "my-querypack";
            ResourceIdentifier logAnalyticsQueryPackResourceId = LogAnalyticsQueryPackResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, queryPackName);
            LogAnalyticsQueryPackResource logAnalyticsQueryPack = client.GetLogAnalyticsQueryPackResource(logAnalyticsQueryPackResourceId);

            // invoke the operation
            LogAnalyticsQueryPackResource result = await logAnalyticsQueryPack.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            LogAnalyticsQueryPackData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_QueryPacksDelete()
        {
            // Generated from example definition: specification/operationalinsights/resource-manager/Microsoft.OperationalInsights/stable/2019-09-01/examples/QueryPacksDelete.json
            // this example is just showing the usage of "QueryPacks_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this LogAnalyticsQueryPackResource created on azure
            // for more information of creating LogAnalyticsQueryPackResource, please refer to the document of LogAnalyticsQueryPackResource
            string subscriptionId = "86dc51d3-92ed-4d7e-947a-775ea79b4919";
            string resourceGroupName = "my-resource-group";
            string queryPackName = "my-querypack";
            ResourceIdentifier logAnalyticsQueryPackResourceId = LogAnalyticsQueryPackResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, queryPackName);
            LogAnalyticsQueryPackResource logAnalyticsQueryPack = client.GetLogAnalyticsQueryPackResource(logAnalyticsQueryPackResourceId);

            // invoke the operation
            await logAnalyticsQueryPack.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_QueryPackUpdateTagsOnly()
        {
            // Generated from example definition: specification/operationalinsights/resource-manager/Microsoft.OperationalInsights/stable/2019-09-01/examples/QueryPacksUpdateTagsOnly.json
            // this example is just showing the usage of "QueryPacks_UpdateTags" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this LogAnalyticsQueryPackResource created on azure
            // for more information of creating LogAnalyticsQueryPackResource, please refer to the document of LogAnalyticsQueryPackResource
            string subscriptionId = "subid";
            string resourceGroupName = "my-resource-group";
            string queryPackName = "my-querypack";
            ResourceIdentifier logAnalyticsQueryPackResourceId = LogAnalyticsQueryPackResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, queryPackName);
            LogAnalyticsQueryPackResource logAnalyticsQueryPack = client.GetLogAnalyticsQueryPackResource(logAnalyticsQueryPackResourceId);

            // invoke the operation
            LogAnalyticsQueryPackPatch patch = new LogAnalyticsQueryPackPatch
            {
                Tags =
{
["Tag1"] = "Value1",
["Tag2"] = "Value2"
},
            };
            LogAnalyticsQueryPackResource result = await logAnalyticsQueryPack.UpdateAsync(patch);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            LogAnalyticsQueryPackData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task SearchQueries_QuerySearch()
        {
            // Generated from example definition: specification/operationalinsights/resource-manager/Microsoft.OperationalInsights/stable/2019-09-01/examples/QueryPackQueriesSearch.json
            // this example is just showing the usage of "Queries_Search" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this LogAnalyticsQueryPackResource created on azure
            // for more information of creating LogAnalyticsQueryPackResource, please refer to the document of LogAnalyticsQueryPackResource
            string subscriptionId = "86dc51d3-92ed-4d7e-947a-775ea79b4918";
            string resourceGroupName = "my-resource-group";
            string queryPackName = "my-querypack";
            ResourceIdentifier logAnalyticsQueryPackResourceId = LogAnalyticsQueryPackResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, queryPackName);
            LogAnalyticsQueryPackResource logAnalyticsQueryPack = client.GetLogAnalyticsQueryPackResource(logAnalyticsQueryPackResourceId);

            // invoke the operation and iterate over the result
            LogAnalyticsQuerySearchProperties querySearchProperties = new LogAnalyticsQuerySearchProperties
            {
                Related = new LogAnalyticsQuerySearchRelatedMetadata
                {
                    Categories = { "other", "analytics" },
                },
                Tags =
{
["my-label"] = {"label1"}
},
            };
            long? top = 3L;
            bool? includeBody = true;
            await foreach (LogAnalyticsQueryResource item in logAnalyticsQueryPack.SearchQueriesAsync(querySearchProperties, top: top, includeBody: includeBody))
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                LogAnalyticsQueryData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }
    }
}
