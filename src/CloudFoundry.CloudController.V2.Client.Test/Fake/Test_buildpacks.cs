//------------------------------------------------------------------------------
// <auto-generated>
  //     This code was generated by a tool.
  //
  //     Changes to this file may cause incorrect behavior and will be lost if
  //     the code is regenerated.
  // </auto-generated>
//------------------------------------------------------------------------------

//
// This source code was auto-generated by cf-sdk-builder
//

using CloudFoundry.CloudController.V2.Client.Data;
using Microsoft.QualityTools.Testing.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.CodeDom.Compiler;
using System.Net;
using System.Threading.Tasks;

namespace CloudFoundry.CloudController.V2.Client.Test.Fake
{
    [TestClass]
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public class BuildpacksEndpoint
{
        [TestMethod]
        public void ListAllBuildpacksTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""total_results"": 3,
  ""total_pages"": 1,
  ""prev_url"": null,
  ""next_url"": null,
  ""resources"": [
    {
      ""metadata"": {
        ""guid"": ""0637be0a-f669-4b07-98b5-0ede300a34bf"",
        ""url"": ""/v2/buildpacks/177bc5f2-4422-4d56-b417-c6759f5fcc60"",
        ""created_at"": ""2016-03-21T10:59:56Z"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""name_1"",
        ""position"": 1,
        ""enabled"": true,
        ""locked"": false,
        ""filename"": ""name-2699""
      }
    },
    {
      ""metadata"": {
        ""guid"": ""0637be0a-f669-4b07-98b5-0ede300a34bf"",
        ""url"": ""/v2/buildpacks/e169c519-1337-41e4-b0c2-5cb86ed69f0a"",
        ""created_at"": ""2016-03-21T10:59:56Z"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""name_2"",
        ""position"": 2,
        ""enabled"": true,
        ""locked"": false,
        ""filename"": ""name-2700""
      }
    },
    {
      ""metadata"": {
        ""guid"": ""0637be0a-f669-4b07-98b5-0ede300a34bf"",
        ""url"": ""/v2/buildpacks/4a41a4ff-2e7c-4129-89d7-4f0e1e7c5db8"",
        ""created_at"": ""2016-03-21T10:59:56Z"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""name_3"",
        ""position"": 3,
        ""enabled"": true,
        ""locked"": false,
        ""filename"": ""name-2701""
      }
    }
  ]
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)200;
                var cfClient = clients.CreateCloudFoundryClient();


                var obj = cfClient.Buildpacks.ListAllBuildpacks().Result;

                Assert.AreEqual("3", TestUtil.ToTestableString(obj.Properties.TotalResults), true);
                Assert.AreEqual("1", TestUtil.ToTestableString(obj.Properties.TotalPages), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Properties.PreviousUrl), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Properties.NextUrl), true);
                Assert.AreEqual("0637be0a-f669-4b07-98b5-0ede300a34bf", TestUtil.ToTestableString(obj[0].EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/buildpacks/177bc5f2-4422-4d56-b417-c6759f5fcc60", TestUtil.ToTestableString(obj[0].EntityMetadata.Url), true);
                Assert.AreEqual("2016-03-21T10:59:56Z", TestUtil.ToTestableString(obj[0].EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("name_1", TestUtil.ToTestableString(obj[0].Name), true);
                Assert.AreEqual("1", TestUtil.ToTestableString(obj[0].Position), true);
                Assert.AreEqual("true", TestUtil.ToTestableString(obj[0].Enabled), true);
                Assert.AreEqual("false", TestUtil.ToTestableString(obj[0].Locked), true);
                Assert.AreEqual("name-2699", TestUtil.ToTestableString(obj[0].Filename), true);
                Assert.AreEqual("0637be0a-f669-4b07-98b5-0ede300a34bf", TestUtil.ToTestableString(obj[1].EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/buildpacks/e169c519-1337-41e4-b0c2-5cb86ed69f0a", TestUtil.ToTestableString(obj[1].EntityMetadata.Url), true);
                Assert.AreEqual("2016-03-21T10:59:56Z", TestUtil.ToTestableString(obj[1].EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[1].EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("name_2", TestUtil.ToTestableString(obj[1].Name), true);
                Assert.AreEqual("2", TestUtil.ToTestableString(obj[1].Position), true);
                Assert.AreEqual("true", TestUtil.ToTestableString(obj[1].Enabled), true);
                Assert.AreEqual("false", TestUtil.ToTestableString(obj[1].Locked), true);
                Assert.AreEqual("name-2700", TestUtil.ToTestableString(obj[1].Filename), true);
                Assert.AreEqual("0637be0a-f669-4b07-98b5-0ede300a34bf", TestUtil.ToTestableString(obj[2].EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/buildpacks/4a41a4ff-2e7c-4129-89d7-4f0e1e7c5db8", TestUtil.ToTestableString(obj[2].EntityMetadata.Url), true);
                Assert.AreEqual("2016-03-21T10:59:56Z", TestUtil.ToTestableString(obj[2].EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[2].EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("name_3", TestUtil.ToTestableString(obj[2].Name), true);
                Assert.AreEqual("3", TestUtil.ToTestableString(obj[2].Position), true);
                Assert.AreEqual("true", TestUtil.ToTestableString(obj[2].Enabled), true);
                Assert.AreEqual("false", TestUtil.ToTestableString(obj[2].Locked), true);
                Assert.AreEqual("name-2701", TestUtil.ToTestableString(obj[2].Filename), true);

            }
        }

        [TestMethod]
        public void RetrieveBuildpackTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""metadata"": {
    ""guid"": ""212d6297-4c6b-4d9d-8bc2-0bcab1fb7232"",
    ""url"": ""/v2/buildpacks/36ae9090-4c09-4cf8-9e21-3ef95fcb4692"",
    ""created_at"": ""2016-03-21T10:59:56Z"",
    ""updated_at"": null
  },
  ""entity"": {
    ""name"": ""name_1"",
    ""position"": 1,
    ""enabled"": true,
    ""locked"": false,
    ""filename"": ""name-2696""
  }
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)200;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();


                var obj = cfClient.Buildpacks.RetrieveBuildpack(guid).Result;


                Assert.AreEqual("212d6297-4c6b-4d9d-8bc2-0bcab1fb7232", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/buildpacks/36ae9090-4c09-4cf8-9e21-3ef95fcb4692", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
                Assert.AreEqual("2016-03-21T10:59:56Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("name_1", TestUtil.ToTestableString(obj.Name), true);
                Assert.AreEqual("1", TestUtil.ToTestableString(obj.Position), true);
                Assert.AreEqual("true", TestUtil.ToTestableString(obj.Enabled), true);
                Assert.AreEqual("false", TestUtil.ToTestableString(obj.Locked), true);
                Assert.AreEqual("name-2696", TestUtil.ToTestableString(obj.Filename), true);

            }
        }

        [TestMethod]
        public void DeleteBuildpackTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                clients.ExpectedStatusCode = (HttpStatusCode)204;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();


                cfClient.Buildpacks.DeleteBuildpack(guid).Wait();

            }
        }

        [TestMethod]
        public void ChangePositionOfBuildpackTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""metadata"": {
    ""guid"": ""b17dd5f1-f20b-473e-ab69-3d2a098061e1"",
    ""url"": ""/v2/buildpacks/f70af8b1-9f38-4041-ba73-95b9e9c67674"",
    ""created_at"": ""2016-03-21T10:59:55Z"",
    ""updated_at"": ""2016-03-21T10:59:55Z""
  },
  ""entity"": {
    ""name"": ""name_1"",
    ""position"": 3,
    ""enabled"": true,
    ""locked"": false,
    ""filename"": ""name-2684""
  }
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)201;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();

                ChangePositionOfBuildpackRequest value = new ChangePositionOfBuildpackRequest();


                var obj = cfClient.Buildpacks.ChangePositionOfBuildpack(guid, value).Result;


                Assert.AreEqual("b17dd5f1-f20b-473e-ab69-3d2a098061e1", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/buildpacks/f70af8b1-9f38-4041-ba73-95b9e9c67674", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
                Assert.AreEqual("2016-03-21T10:59:55Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
                Assert.AreEqual("2016-03-21T10:59:55Z", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("name_1", TestUtil.ToTestableString(obj.Name), true);
                Assert.AreEqual("3", TestUtil.ToTestableString(obj.Position), true);
                Assert.AreEqual("true", TestUtil.ToTestableString(obj.Enabled), true);
                Assert.AreEqual("false", TestUtil.ToTestableString(obj.Locked), true);
                Assert.AreEqual("name-2684", TestUtil.ToTestableString(obj.Filename), true);

            }
        }

        [TestMethod]
        public void CreatesAdminBuildpackTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""metadata"": {
    ""guid"": ""330556b4-2d07-4090-8300-dd2fcfeb5c3f"",
    ""url"": ""/v2/buildpacks/2044f638-4706-4c7d-a677-ed2ac6b19ed5"",
    ""created_at"": ""2016-03-21T10:59:56Z"",
    ""updated_at"": null
  },
  ""entity"": {
    ""name"": ""Golang_buildpack"",
    ""position"": 1,
    ""enabled"": true,
    ""locked"": false,
    ""filename"": null
  }
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)201;
                var cfClient = clients.CreateCloudFoundryClient();

                CreatesAdminBuildpackRequest value = new CreatesAdminBuildpackRequest();


                var obj = cfClient.Buildpacks.CreatesAdminBuildpack(value).Result;


                Assert.AreEqual("330556b4-2d07-4090-8300-dd2fcfeb5c3f", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/buildpacks/2044f638-4706-4c7d-a677-ed2ac6b19ed5", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
                Assert.AreEqual("2016-03-21T10:59:56Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("Golang_buildpack", TestUtil.ToTestableString(obj.Name), true);
                Assert.AreEqual("1", TestUtil.ToTestableString(obj.Position), true);
                Assert.AreEqual("true", TestUtil.ToTestableString(obj.Enabled), true);
                Assert.AreEqual("false", TestUtil.ToTestableString(obj.Locked), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Filename), true);

            }
        }

        [TestMethod]
        public void LockOrUnlockBuildpackTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""metadata"": {
    ""guid"": ""66863c0d-1007-46e6-b0f3-031fc11cc31b"",
    ""url"": ""/v2/buildpacks/fc0100cc-2bc0-4cd4-9dce-63f8c75ca36c"",
    ""created_at"": ""2016-03-21T10:59:55Z"",
    ""updated_at"": ""2016-03-21T10:59:55Z""
  },
  ""entity"": {
    ""name"": ""name_1"",
    ""position"": 1,
    ""enabled"": true,
    ""locked"": true,
    ""filename"": ""name-2690""
  }
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)201;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();

                LockOrUnlockBuildpackRequest value = new LockOrUnlockBuildpackRequest();


                var obj = cfClient.Buildpacks.LockOrUnlockBuildpack(guid, value).Result;


                Assert.AreEqual("66863c0d-1007-46e6-b0f3-031fc11cc31b", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/buildpacks/fc0100cc-2bc0-4cd4-9dce-63f8c75ca36c", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
                Assert.AreEqual("2016-03-21T10:59:55Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
                Assert.AreEqual("2016-03-21T10:59:55Z", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("name_1", TestUtil.ToTestableString(obj.Name), true);
                Assert.AreEqual("1", TestUtil.ToTestableString(obj.Position), true);
                Assert.AreEqual("true", TestUtil.ToTestableString(obj.Enabled), true);
                Assert.AreEqual("true", TestUtil.ToTestableString(obj.Locked), true);
                Assert.AreEqual("name-2690", TestUtil.ToTestableString(obj.Filename), true);

            }
        }

        [TestMethod]
        public void EnableOrDisableBuildpackTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""metadata"": {
    ""guid"": ""275315e5-ffd8-45dd-b55f-4d07b6eb788c"",
    ""url"": ""/v2/buildpacks/44124329-5601-4a2e-9321-a864e1b19f49"",
    ""created_at"": ""2016-03-21T10:59:55Z"",
    ""updated_at"": ""2016-03-21T10:59:55Z""
  },
  ""entity"": {
    ""name"": ""name_1"",
    ""position"": 1,
    ""enabled"": false,
    ""locked"": false,
    ""filename"": ""name-2687""
  }
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)201;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();

                EnableOrDisableBuildpackRequest value = new EnableOrDisableBuildpackRequest();


                var obj = cfClient.Buildpacks.EnableOrDisableBuildpack(guid, value).Result;


                Assert.AreEqual("275315e5-ffd8-45dd-b55f-4d07b6eb788c", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/buildpacks/44124329-5601-4a2e-9321-a864e1b19f49", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
                Assert.AreEqual("2016-03-21T10:59:55Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
                Assert.AreEqual("2016-03-21T10:59:55Z", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("name_1", TestUtil.ToTestableString(obj.Name), true);
                Assert.AreEqual("1", TestUtil.ToTestableString(obj.Position), true);
                Assert.AreEqual("false", TestUtil.ToTestableString(obj.Enabled), true);
                Assert.AreEqual("false", TestUtil.ToTestableString(obj.Locked), true);
                Assert.AreEqual("name-2687", TestUtil.ToTestableString(obj.Filename), true);

            }
        }

    }
}