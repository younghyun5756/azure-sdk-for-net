// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager;
using Azure.ResourceManager.DevCenter;
using Azure.ResourceManager.DevCenter.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DevCenter.Samples
{
    public partial class Sample_ProjectEnvironmentTypeCollection
    {
        // ProjectEnvironmentTypes_List
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_ProjectEnvironmentTypesList()
        {
            // Generated from example definition: specification/devcenter/resource-manager/Microsoft.DevCenter/preview/2022-08-01-preview/examples/ProjectEnvironmentTypes_List.json
            // this example is just showing the usage of "ProjectEnvironmentTypes_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ProjectResource created on azure
            // for more information of creating ProjectResource, please refer to the document of ProjectResource
            string subscriptionId = "{subscriptionId}";
            string resourceGroupName = "rg1";
            string projectName = "ContosoProj";
            ResourceIdentifier projectResourceId = ProjectResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, projectName);
            ProjectResource project = client.GetProjectResource(projectResourceId);

            // get the collection of this ProjectEnvironmentTypeResource
            ProjectEnvironmentTypeCollection collection = project.GetProjectEnvironmentTypes();

            // invoke the operation and iterate over the result
            await foreach (ProjectEnvironmentTypeResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ProjectEnvironmentTypeData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // ProjectEnvironmentTypes_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_ProjectEnvironmentTypesGet()
        {
            // Generated from example definition: specification/devcenter/resource-manager/Microsoft.DevCenter/preview/2022-08-01-preview/examples/ProjectEnvironmentTypes_Get.json
            // this example is just showing the usage of "ProjectEnvironmentTypes_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ProjectResource created on azure
            // for more information of creating ProjectResource, please refer to the document of ProjectResource
            string subscriptionId = "{subscriptionId}";
            string resourceGroupName = "rg1";
            string projectName = "ContosoProj";
            ResourceIdentifier projectResourceId = ProjectResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, projectName);
            ProjectResource project = client.GetProjectResource(projectResourceId);

            // get the collection of this ProjectEnvironmentTypeResource
            ProjectEnvironmentTypeCollection collection = project.GetProjectEnvironmentTypes();

            // invoke the operation
            string environmentTypeName = "{environmentTypeName}";
            ProjectEnvironmentTypeResource result = await collection.GetAsync(environmentTypeName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ProjectEnvironmentTypeData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // ProjectEnvironmentTypes_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_ProjectEnvironmentTypesGet()
        {
            // Generated from example definition: specification/devcenter/resource-manager/Microsoft.DevCenter/preview/2022-08-01-preview/examples/ProjectEnvironmentTypes_Get.json
            // this example is just showing the usage of "ProjectEnvironmentTypes_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ProjectResource created on azure
            // for more information of creating ProjectResource, please refer to the document of ProjectResource
            string subscriptionId = "{subscriptionId}";
            string resourceGroupName = "rg1";
            string projectName = "ContosoProj";
            ResourceIdentifier projectResourceId = ProjectResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, projectName);
            ProjectResource project = client.GetProjectResource(projectResourceId);

            // get the collection of this ProjectEnvironmentTypeResource
            ProjectEnvironmentTypeCollection collection = project.GetProjectEnvironmentTypes();

            // invoke the operation
            string environmentTypeName = "{environmentTypeName}";
            bool result = await collection.ExistsAsync(environmentTypeName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // ProjectEnvironmentTypes_CreateOrUpdate
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_ProjectEnvironmentTypesCreateOrUpdate()
        {
            // Generated from example definition: specification/devcenter/resource-manager/Microsoft.DevCenter/preview/2022-08-01-preview/examples/ProjectEnvironmentTypes_Put.json
            // this example is just showing the usage of "ProjectEnvironmentTypes_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ProjectResource created on azure
            // for more information of creating ProjectResource, please refer to the document of ProjectResource
            string subscriptionId = "{subscriptionId}";
            string resourceGroupName = "rg1";
            string projectName = "ContosoProj";
            ResourceIdentifier projectResourceId = ProjectResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, projectName);
            ProjectResource project = client.GetProjectResource(projectResourceId);

            // get the collection of this ProjectEnvironmentTypeResource
            ProjectEnvironmentTypeCollection collection = project.GetProjectEnvironmentTypes();

            // invoke the operation
            string environmentTypeName = "{environmentTypeName}";
            ProjectEnvironmentTypeData data = new ProjectEnvironmentTypeData(new AzureLocation("placeholder"))
            {
                Identity = new ManagedServiceIdentity("UserAssigned")
                {
                    UserAssignedIdentities =
{
[new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourcegroups/identityGroup/providers/Microsoft.ManagedIdentity/userAssignedIdentities/testidentity1")] = new UserAssignedIdentity(),
},
                },
                DeploymentTargetId = "/subscriptions/00000000-0000-0000-0000-000000000000",
                Status = EnableStatus.Enabled,
                Roles =
{
["4cbf0b6c-e750-441c-98a7-10da8387e4d6"] = new EnvironmentRole(),
},
                UserRoleAssignments =
{
["e45e3m7c-176e-416a-b466-0c5ec8298f8a"] = new UserRoleAssignmentValue()
{
Roles =
{
["4cbf0b6c-e750-441c-98a7-10da8387e4d6"] = new EnvironmentRole(),
},
},
},
                Tags =
{
["CostCenter"] = "RnD",
},
            };
            ArmOperation<ProjectEnvironmentTypeResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, environmentTypeName, data);
            ProjectEnvironmentTypeResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ProjectEnvironmentTypeData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
