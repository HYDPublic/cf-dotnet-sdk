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
        public void TestUpdateServiceBrokerResponse()
        {
            string json = @"{
  ""metadata"": {
    ""guid"": ""27d9caec-7901-4cf8-8c83-cc0575ce0129"",
    ""created_at"": ""2015-03-19T13:19:43+00:00"",
    ""updated_at"": ""2015-03-19T13:19:43+00:00"",
    ""url"": ""/v2/service_brokers/27d9caec-7901-4cf8-8c83-cc0575ce0129""
  },
  ""entity"": {
    ""name"": ""name-362"",
    ""broker_url"": ""https://mybroker.example.com"",
    ""auth_username"": ""admin-user""
  }
}";

            UpdateServiceBrokerResponse obj = Utilities.DeserializeJson<UpdateServiceBrokerResponse>(json);

            Assert.AreEqual("27d9caec-7901-4cf8-8c83-cc0575ce0129", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
            Assert.AreEqual("2015-03-19T13:19:43+00:00", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
            Assert.AreEqual("2015-03-19T13:19:43+00:00", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("/v2/service_brokers/27d9caec-7901-4cf8-8c83-cc0575ce0129", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
            Assert.AreEqual("name-362", TestUtil.ToTestableString(obj.Name), true);
            Assert.AreEqual("https://mybroker.example.com", TestUtil.ToTestableString(obj.BrokerUrl), true);
            Assert.AreEqual("admin-user", TestUtil.ToTestableString(obj.AuthUsername), true);
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
        ""guid"": ""9d7b08aa-6689-459d-b9dd-457e60c98d1a"",
        ""url"": ""/v2/service_brokers/9d7b08aa-6689-459d-b9dd-457e60c98d1a"",
        ""created_at"": ""2015-03-19T13:19:43+00:00"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""name-368"",
        ""broker_url"": ""https://foo.com/url-55"",
        ""auth_username"": ""auth_username-20""
      }
    },
    {
      ""metadata"": {
        ""guid"": ""8ac2f57d-3719-4311-ad3b-9a4aef49aada"",
        ""url"": ""/v2/service_brokers/8ac2f57d-3719-4311-ad3b-9a4aef49aada"",
        ""created_at"": ""2015-03-19T13:19:43+00:00"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""name-369"",
        ""broker_url"": ""https://foo.com/url-56"",
        ""auth_username"": ""auth_username-21""
      }
    },
    {
      ""metadata"": {
        ""guid"": ""ca246529-9783-42c6-a078-7e077834b4ad"",
        ""url"": ""/v2/service_brokers/ca246529-9783-42c6-a078-7e077834b4ad"",
        ""created_at"": ""2015-03-19T13:19:43+00:00"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""name-370"",
        ""broker_url"": ""https://foo.com/url-57"",
        ""auth_username"": ""auth_username-22""
      }
    }
  ]
}";

            PagedResponseCollection<ListAllServiceBrokersResponse> page = Utilities.DeserializePage<ListAllServiceBrokersResponse>(json);

            Assert.AreEqual("3", TestUtil.ToTestableString(page.Properties.TotalResults), true);
            Assert.AreEqual("1", TestUtil.ToTestableString(page.Properties.TotalPages), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page.Properties.PreviousUrl), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page.Properties.NextUrl), true);
            Assert.AreEqual("9d7b08aa-6689-459d-b9dd-457e60c98d1a", TestUtil.ToTestableString(page[0].EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/service_brokers/9d7b08aa-6689-459d-b9dd-457e60c98d1a", TestUtil.ToTestableString(page[0].EntityMetadata.Url), true);
            Assert.AreEqual("2015-03-19T13:19:43+00:00", TestUtil.ToTestableString(page[0].EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("name-368", TestUtil.ToTestableString(page[0].Name), true);
            Assert.AreEqual("https://foo.com/url-55", TestUtil.ToTestableString(page[0].BrokerUrl), true);
            Assert.AreEqual("auth_username-20", TestUtil.ToTestableString(page[0].AuthUsername), true);
            Assert.AreEqual("8ac2f57d-3719-4311-ad3b-9a4aef49aada", TestUtil.ToTestableString(page[1].EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/service_brokers/8ac2f57d-3719-4311-ad3b-9a4aef49aada", TestUtil.ToTestableString(page[1].EntityMetadata.Url), true);
            Assert.AreEqual("2015-03-19T13:19:43+00:00", TestUtil.ToTestableString(page[1].EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[1].EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("name-369", TestUtil.ToTestableString(page[1].Name), true);
            Assert.AreEqual("https://foo.com/url-56", TestUtil.ToTestableString(page[1].BrokerUrl), true);
            Assert.AreEqual("auth_username-21", TestUtil.ToTestableString(page[1].AuthUsername), true);
            Assert.AreEqual("ca246529-9783-42c6-a078-7e077834b4ad", TestUtil.ToTestableString(page[2].EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/service_brokers/ca246529-9783-42c6-a078-7e077834b4ad", TestUtil.ToTestableString(page[2].EntityMetadata.Url), true);
            Assert.AreEqual("2015-03-19T13:19:43+00:00", TestUtil.ToTestableString(page[2].EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[2].EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("name-370", TestUtil.ToTestableString(page[2].Name), true);
            Assert.AreEqual("https://foo.com/url-57", TestUtil.ToTestableString(page[2].BrokerUrl), true);
            Assert.AreEqual("auth_username-22", TestUtil.ToTestableString(page[2].AuthUsername), true);
        }

        [TestMethod]
        public void TestCreateServiceBrokerResponse()
        {
            string json = @"{
  ""metadata"": {
    ""guid"": ""f4449002-34bb-4786-af95-64f68a756e16"",
    ""created_at"": ""2015-03-19T13:19:43+00:00"",
    ""updated_at"": null,
    ""url"": ""/v2/service_brokers/f4449002-34bb-4786-af95-64f68a756e16""
  },
  ""entity"": {
    ""name"": ""service-broker-name"",
    ""broker_url"": ""https://broker.example.com"",
    ""auth_username"": ""admin""
  }
}";

            CreateServiceBrokerResponse obj = Utilities.DeserializeJson<CreateServiceBrokerResponse>(json);

            Assert.AreEqual("f4449002-34bb-4786-af95-64f68a756e16", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
            Assert.AreEqual("2015-03-19T13:19:43+00:00", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("/v2/service_brokers/f4449002-34bb-4786-af95-64f68a756e16", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
            Assert.AreEqual("service-broker-name", TestUtil.ToTestableString(obj.Name), true);
            Assert.AreEqual("https://broker.example.com", TestUtil.ToTestableString(obj.BrokerUrl), true);
            Assert.AreEqual("admin", TestUtil.ToTestableString(obj.AuthUsername), true);
        }

        [TestMethod]
        public void TestRetrieveServiceBrokerResponse()
        {
            string json = @"{
  ""metadata"": {
    ""guid"": ""2386d39a-de17-4135-abb4-ccdb3442943c"",
    ""url"": ""/v2/service_brokers/2386d39a-de17-4135-abb4-ccdb3442943c"",
    ""created_at"": ""2015-03-19T13:19:43+00:00"",
    ""updated_at"": null
  },
  ""entity"": {
    ""name"": ""name-356"",
    ""broker_url"": ""https://foo.com/url-43"",
    ""auth_username"": ""auth_username-8""
  }
}";

            RetrieveServiceBrokerResponse obj = Utilities.DeserializeJson<RetrieveServiceBrokerResponse>(json);

            Assert.AreEqual("2386d39a-de17-4135-abb4-ccdb3442943c", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/service_brokers/2386d39a-de17-4135-abb4-ccdb3442943c", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
            Assert.AreEqual("2015-03-19T13:19:43+00:00", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("name-356", TestUtil.ToTestableString(obj.Name), true);
            Assert.AreEqual("https://foo.com/url-43", TestUtil.ToTestableString(obj.BrokerUrl), true);
            Assert.AreEqual("auth_username-8", TestUtil.ToTestableString(obj.AuthUsername), true);
        }
    }
}
