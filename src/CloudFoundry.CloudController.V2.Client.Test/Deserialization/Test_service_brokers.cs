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

using CloudFoundry.CloudController.V2.Client;
using CloudFoundry.CloudController.V2.Client.Data;
using Microsoft.CSharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.CodeDom.Compiler;

namespace CloudFoundry.CloudController.V2.Test.Deserialization
{
    [TestClass]
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public class ServiceBrokersTest
    {


        [TestMethod]
        public void TestRetrieveServiceBrokerResponse()
        {
            string json = @"{
  ""metadata"": {
    ""guid"": ""eb5e9481-e4a9-41ac-bfc9-1f85fa0b507e"",
    ""url"": ""/v2/service_brokers/31aeb0e4-b081-434f-b7f9-ee50f4133f09"",
    ""created_at"": ""2016-03-21T10:59:32Z"",
    ""updated_at"": ""2016-03-21T10:59:32Z""
  },
  ""entity"": {
    ""name"": ""name-736"",
    ""broker_url"": ""https://foo.com/url-18"",
    ""auth_username"": ""auth_username-15"",
    ""space_guid"": ""eb5e9481-e4a9-41ac-bfc9-1f85fa0b507e""
  }
}";

            RetrieveServiceBrokerResponse obj = Utilities.DeserializeJson<RetrieveServiceBrokerResponse>(json);

            Assert.AreEqual("eb5e9481-e4a9-41ac-bfc9-1f85fa0b507e", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/service_brokers/31aeb0e4-b081-434f-b7f9-ee50f4133f09", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
            Assert.AreEqual("2016-03-21T10:59:32Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
            Assert.AreEqual("2016-03-21T10:59:32Z", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("name-736", TestUtil.ToTestableString(obj.Name), true);
            Assert.AreEqual("https://foo.com/url-18", TestUtil.ToTestableString(obj.BrokerUrl), true);
            Assert.AreEqual("auth_username-15", TestUtil.ToTestableString(obj.AuthUsername), true);
            Assert.AreEqual("eb5e9481-e4a9-41ac-bfc9-1f85fa0b507e", TestUtil.ToTestableString(obj.SpaceGuid), true);
        }

        [TestMethod]
        public void TestCreateServiceBrokerResponse()
        {
            string json = @"{
  ""metadata"": {
    ""guid"": ""a9f3a0e3-2e2e-4557-8957-9d24e56f514c"",
    ""created_at"": ""2016-03-21T10:59:32Z"",
    ""updated_at"": null,
    ""url"": ""/v2/service_brokers/142369df-c0d9-4f91-aaea-d33c7d264199""
  },
  ""entity"": {
    ""name"": ""service-broker-name"",
    ""broker_url"": ""https://broker.example.com"",
    ""auth_username"": ""admin"",
    ""space_guid"": null
  }
}";

            CreateServiceBrokerResponse obj = Utilities.DeserializeJson<CreateServiceBrokerResponse>(json);

            Assert.AreEqual("a9f3a0e3-2e2e-4557-8957-9d24e56f514c", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
            Assert.AreEqual("2016-03-21T10:59:32Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("/v2/service_brokers/142369df-c0d9-4f91-aaea-d33c7d264199", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
            Assert.AreEqual("service-broker-name", TestUtil.ToTestableString(obj.Name), true);
            Assert.AreEqual("https://broker.example.com", TestUtil.ToTestableString(obj.BrokerUrl), true);
            Assert.AreEqual("admin", TestUtil.ToTestableString(obj.AuthUsername), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.SpaceGuid), true);
        }

        [TestMethod]
        public void TestListAllServiceBrokersResponse()
        {
            string json = @"{
  ""total_results"": 3,
  ""total_pages"": 1,
  ""prev_url"": null,
  ""next_url"": null,
  ""resources"": [
    {
      ""metadata"": {
        ""guid"": ""3d4bc109-16cf-4b55-8d6b-203516d8b7d9"",
        ""url"": ""/v2/service_brokers/a741b744-bf6a-4cf6-8e16-b9574eb25840"",
        ""created_at"": ""2016-03-21T10:59:32Z"",
        ""updated_at"": ""2016-03-21T10:59:32Z""
      },
      ""entity"": {
        ""name"": ""name-742"",
        ""broker_url"": ""https://foo.com/url-21"",
        ""auth_username"": ""auth_username-18"",
        ""space_guid"": ""3d4bc109-16cf-4b55-8d6b-203516d8b7d9""
      }
    },
    {
      ""metadata"": {
        ""guid"": ""3d4bc109-16cf-4b55-8d6b-203516d8b7d9"",
        ""url"": ""/v2/service_brokers/18526169-95e2-434f-8cd6-cba05a692181"",
        ""created_at"": ""2016-03-21T10:59:32Z"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""name-743"",
        ""broker_url"": ""https://foo.com/url-22"",
        ""auth_username"": ""auth_username-19"",
        ""space_guid"": null
      }
    },
    {
      ""metadata"": {
        ""guid"": ""3d4bc109-16cf-4b55-8d6b-203516d8b7d9"",
        ""url"": ""/v2/service_brokers/fade36fa-8917-42d6-a2d9-fac78f2af6b0"",
        ""created_at"": ""2016-03-21T10:59:32Z"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""name-744"",
        ""broker_url"": ""https://foo.com/url-23"",
        ""auth_username"": ""auth_username-20"",
        ""space_guid"": null
      }
    }
  ]
}";

            PagedResponseCollection<ListAllServiceBrokersResponse> page = Utilities.DeserializePage<ListAllServiceBrokersResponse>(json, null);

            Assert.AreEqual("3", TestUtil.ToTestableString(page.Properties.TotalResults), true);
            Assert.AreEqual("1", TestUtil.ToTestableString(page.Properties.TotalPages), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page.Properties.PreviousUrl), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page.Properties.NextUrl), true);
            Assert.AreEqual("3d4bc109-16cf-4b55-8d6b-203516d8b7d9", TestUtil.ToTestableString(page[0].EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/service_brokers/a741b744-bf6a-4cf6-8e16-b9574eb25840", TestUtil.ToTestableString(page[0].EntityMetadata.Url), true);
            Assert.AreEqual("2016-03-21T10:59:32Z", TestUtil.ToTestableString(page[0].EntityMetadata.CreatedAt), true);
            Assert.AreEqual("2016-03-21T10:59:32Z", TestUtil.ToTestableString(page[0].EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("name-742", TestUtil.ToTestableString(page[0].Name), true);
            Assert.AreEqual("https://foo.com/url-21", TestUtil.ToTestableString(page[0].BrokerUrl), true);
            Assert.AreEqual("auth_username-18", TestUtil.ToTestableString(page[0].AuthUsername), true);
            Assert.AreEqual("3d4bc109-16cf-4b55-8d6b-203516d8b7d9", TestUtil.ToTestableString(page[0].SpaceGuid), true);
            Assert.AreEqual("3d4bc109-16cf-4b55-8d6b-203516d8b7d9", TestUtil.ToTestableString(page[1].EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/service_brokers/18526169-95e2-434f-8cd6-cba05a692181", TestUtil.ToTestableString(page[1].EntityMetadata.Url), true);
            Assert.AreEqual("2016-03-21T10:59:32Z", TestUtil.ToTestableString(page[1].EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[1].EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("name-743", TestUtil.ToTestableString(page[1].Name), true);
            Assert.AreEqual("https://foo.com/url-22", TestUtil.ToTestableString(page[1].BrokerUrl), true);
            Assert.AreEqual("auth_username-19", TestUtil.ToTestableString(page[1].AuthUsername), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[1].SpaceGuid), true);
            Assert.AreEqual("3d4bc109-16cf-4b55-8d6b-203516d8b7d9", TestUtil.ToTestableString(page[2].EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/service_brokers/fade36fa-8917-42d6-a2d9-fac78f2af6b0", TestUtil.ToTestableString(page[2].EntityMetadata.Url), true);
            Assert.AreEqual("2016-03-21T10:59:32Z", TestUtil.ToTestableString(page[2].EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[2].EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("name-744", TestUtil.ToTestableString(page[2].Name), true);
            Assert.AreEqual("https://foo.com/url-23", TestUtil.ToTestableString(page[2].BrokerUrl), true);
            Assert.AreEqual("auth_username-20", TestUtil.ToTestableString(page[2].AuthUsername), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[2].SpaceGuid), true);
        }

        [TestMethod]
        public void TestUpdateServiceBrokerResponse()
        {
            string json = @"{
  ""metadata"": {
    ""guid"": ""6e98ae76-30a3-4410-ac9a-2623749322ae"",
    ""created_at"": ""2016-03-21T10:59:32Z"",
    ""updated_at"": ""2016-03-21T10:59:32Z"",
    ""url"": ""/v2/service_brokers/d7cf4f91-8532-4ae2-8174-105a06389922""
  },
  ""entity"": {
    ""name"": ""name-754"",
    ""broker_url"": ""https://mybroker.example.com"",
    ""auth_username"": ""admin-user"",
    ""space_guid"": ""6e98ae76-30a3-4410-ac9a-2623749322ae""
  }
}";

            UpdateServiceBrokerResponse obj = Utilities.DeserializeJson<UpdateServiceBrokerResponse>(json);

            Assert.AreEqual("6e98ae76-30a3-4410-ac9a-2623749322ae", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
            Assert.AreEqual("2016-03-21T10:59:32Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
            Assert.AreEqual("2016-03-21T10:59:32Z", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("/v2/service_brokers/d7cf4f91-8532-4ae2-8174-105a06389922", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
            Assert.AreEqual("name-754", TestUtil.ToTestableString(obj.Name), true);
            Assert.AreEqual("https://mybroker.example.com", TestUtil.ToTestableString(obj.BrokerUrl), true);
            Assert.AreEqual("admin-user", TestUtil.ToTestableString(obj.AuthUsername), true);
            Assert.AreEqual("6e98ae76-30a3-4410-ac9a-2623749322ae", TestUtil.ToTestableString(obj.SpaceGuid), true);
        }
    }
}
