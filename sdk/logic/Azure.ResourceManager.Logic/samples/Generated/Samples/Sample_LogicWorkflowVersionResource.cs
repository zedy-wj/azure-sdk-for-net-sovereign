// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Logic.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.Logic.Samples
{
    public partial class Sample_LogicWorkflowVersionResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetAWorkflowVersion()
        {
            // Generated from example definition: specification/logic/resource-manager/Microsoft.Logic/stable/2019-05-01/examples/WorkflowVersions_Get.json
            // this example is just showing the usage of "WorkflowVersions_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this LogicWorkflowVersionResource created on azure
            // for more information of creating LogicWorkflowVersionResource, please refer to the document of LogicWorkflowVersionResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "test-resource-group";
            string workflowName = "test-workflow";
            string versionId = "08586676824806722526";
            ResourceIdentifier logicWorkflowVersionResourceId = LogicWorkflowVersionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workflowName, versionId);
            LogicWorkflowVersionResource logicWorkflowVersion = client.GetLogicWorkflowVersionResource(logicWorkflowVersionResourceId);

            // invoke the operation
            LogicWorkflowVersionResource result = await logicWorkflowVersion.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            LogicWorkflowVersionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetCallbackUrlWorkflowVersionTrigger_GetTheCallbackUrlForATriggerOfAWorkflowVersion()
        {
            // Generated from example definition: specification/logic/resource-manager/Microsoft.Logic/stable/2019-05-01/examples/WorkflowVersionTriggers_ListCallbackUrl.json
            // this example is just showing the usage of "WorkflowVersionTriggers_ListCallbackUrl" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this LogicWorkflowVersionResource created on azure
            // for more information of creating LogicWorkflowVersionResource, please refer to the document of LogicWorkflowVersionResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "testResourceGroup";
            string workflowName = "testWorkflowName";
            string versionId = "testWorkflowVersionId";
            ResourceIdentifier logicWorkflowVersionResourceId = LogicWorkflowVersionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workflowName, versionId);
            LogicWorkflowVersionResource logicWorkflowVersion = client.GetLogicWorkflowVersionResource(logicWorkflowVersionResourceId);

            // invoke the operation
            string triggerName = "testTriggerName";
            ListOperationCallbackUrlParameterInfo info = new ListOperationCallbackUrlParameterInfo
            {
                NotAfter = DateTimeOffset.Parse("2017-03-05T08:00:00Z"),
                KeyType = LogicKeyType.Primary,
            };
            LogicWorkflowTriggerCallbackUri result = await logicWorkflowVersion.GetCallbackUrlWorkflowVersionTriggerAsync(triggerName, info: info);

            Console.WriteLine($"Succeeded: {result}");
        }
    }
}
