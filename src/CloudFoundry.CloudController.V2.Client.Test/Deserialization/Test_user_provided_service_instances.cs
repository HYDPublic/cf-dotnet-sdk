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
    public class UserProvidedServiceInstancesTest
    {


        [TestMethod]
        public void TestCreateUserProvidedServiceInstanceResponse()
        {
            string json = @"{
  ""metadata"": {
    ""guid"": ""c350fa6d-5eb1-4d82-872d-b35ff42c94f8"",
    ""url"": ""/v2/user_provided_service_instances/c350fa6d-5eb1-4d82-872d-b35ff42c94f8"",
    ""created_at"": ""2015-03-19T13:19:41+00:00"",
    ""updated_at"": null
  },
  ""entity"": {
    ""name"": ""my-user-provided-instance"",
    ""credentials"": {
      ""somekey"": ""somevalue""
    },
    ""space_guid"": ""c79f9382-b875-4bb1-ac5b-ed9eb7a091de"",
    ""type"": ""user_provided_service_instance"",
    ""syslog_drain_url"": ""syslog://example.com"",
    ""space_url"": ""/v2/spaces/c79f9382-b875-4bb1-ac5b-ed9eb7a091de"",
    ""service_bindings_url"": ""/v2/user_provided_service_instances/c350fa6d-5eb1-4d82-872d-b35ff42c94f8/service_bindings""
  }
}";

            CreateUserProvidedServiceInstanceResponse obj = Utilities.DeserializeJson<CreateUserProvidedServiceInstanceResponse>(json);

            Assert.AreEqual("c350fa6d-5eb1-4d82-872d-b35ff42c94f8", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/user_provided_service_instances/c350fa6d-5eb1-4d82-872d-b35ff42c94f8", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
            Assert.AreEqual("2015-03-19T13:19:41+00:00", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("my-user-provided-instance", TestUtil.ToTestableString(obj.Name), true);
            Assert.AreEqual("c79f9382-b875-4bb1-ac5b-ed9eb7a091de", TestUtil.ToTestableString(obj.SpaceGuid), true);
            Assert.AreEqual("user_provided_service_instance", TestUtil.ToTestableString(obj.Type), true);
            Assert.AreEqual("syslog://example.com", TestUtil.ToTestableString(obj.SyslogDrainUrl), true);
            Assert.AreEqual("/v2/spaces/c79f9382-b875-4bb1-ac5b-ed9eb7a091de", TestUtil.ToTestableString(obj.SpaceUrl), true);
            Assert.AreEqual("/v2/user_provided_service_instances/c350fa6d-5eb1-4d82-872d-b35ff42c94f8/service_bindings", TestUtil.ToTestableString(obj.ServiceBindingsUrl), true);
        }

        [TestMethod]
        public void TestRetrieveUserProvidedServiceInstanceResponse()
        {
            string json = @"{
  ""metadata"": {
    ""guid"": ""0df64f1a-70f4-4c9d-95e2-e074dc8b2c1e"",
    ""url"": ""/v2/user_provided_service_instances/0df64f1a-70f4-4c9d-95e2-e074dc8b2c1e"",
    ""created_at"": ""2015-03-19T13:19:41+00:00"",
    ""updated_at"": null
  },
  ""entity"": {
    ""name"": ""name-260"",
    ""credentials"": {
      ""creds-key-151"": ""creds-val-151""
    },
    ""space_guid"": ""95570700-b046-4aaa-9493-d8bb149b1648"",
    ""type"": ""user_provided_service_instance"",
    ""syslog_drain_url"": ""https://foo.com/url-25"",
    ""space_url"": ""/v2/spaces/95570700-b046-4aaa-9493-d8bb149b1648"",
    ""service_bindings_url"": ""/v2/user_provided_service_instances/0df64f1a-70f4-4c9d-95e2-e074dc8b2c1e/service_bindings""
  }
}";

            RetrieveUserProvidedServiceInstanceResponse obj = Utilities.DeserializeJson<RetrieveUserProvidedServiceInstanceResponse>(json);

            Assert.AreEqual("0df64f1a-70f4-4c9d-95e2-e074dc8b2c1e", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/user_provided_service_instances/0df64f1a-70f4-4c9d-95e2-e074dc8b2c1e", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
            Assert.AreEqual("2015-03-19T13:19:41+00:00", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("name-260", TestUtil.ToTestableString(obj.Name), true);
            Assert.AreEqual("95570700-b046-4aaa-9493-d8bb149b1648", TestUtil.ToTestableString(obj.SpaceGuid), true);
            Assert.AreEqual("user_provided_service_instance", TestUtil.ToTestableString(obj.Type), true);
            Assert.AreEqual("https://foo.com/url-25", TestUtil.ToTestableString(obj.SyslogDrainUrl), true);
            Assert.AreEqual("/v2/spaces/95570700-b046-4aaa-9493-d8bb149b1648", TestUtil.ToTestableString(obj.SpaceUrl), true);
            Assert.AreEqual("/v2/user_provided_service_instances/0df64f1a-70f4-4c9d-95e2-e074dc8b2c1e/service_bindings", TestUtil.ToTestableString(obj.ServiceBindingsUrl), true);
        }

        [TestMethod]
        public void TestListAllServiceBindingsForUserProvidedServiceInstanceResponse()
        {
            string json = @"{
  ""total_results"": 1,
  ""total_pages"": 1,
  ""prev_url"": null,
  ""next_url"": null,
  ""resources"": [
    {
      ""metadata"": {
        ""guid"": ""71cb6103-be3a-4cd2-a6b5-a407b0d244ef"",
        ""url"": ""/v2/service_bindings/71cb6103-be3a-4cd2-a6b5-a407b0d244ef"",
        ""created_at"": ""2015-03-19T13:19:41+00:00"",
        ""updated_at"": null
      },
      ""entity"": {
        ""app_guid"": ""484a5805-7ebd-4653-a1e4-a917bf73b955"",
        ""service_instance_guid"": ""4ffa7ff8-a5fb-4c68-8319-ec58b1a84b21"",
        ""credentials"": {
          ""creds-key-148"": ""creds-val-148""
        },
        ""binding_options"": {

        },
        ""gateway_data"": null,
        ""gateway_name"": """",
        ""syslog_drain_url"": null,
        ""app_url"": ""/v2/apps/484a5805-7ebd-4653-a1e4-a917bf73b955"",
        ""service_instance_url"": ""/v2/user_provided_service_instances/4ffa7ff8-a5fb-4c68-8319-ec58b1a84b21""
      }
    }
  ]
}";

            PagedResponseCollection<ListAllServiceBindingsForUserProvidedServiceInstanceResponse> page = Utilities.DeserializePage<ListAllServiceBindingsForUserProvidedServiceInstanceResponse>(json);

            Assert.AreEqual("1", TestUtil.ToTestableString(page.Properties.TotalResults), true);
            Assert.AreEqual("1", TestUtil.ToTestableString(page.Properties.TotalPages), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page.Properties.PreviousUrl), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page.Properties.NextUrl), true);
            Assert.AreEqual("71cb6103-be3a-4cd2-a6b5-a407b0d244ef", TestUtil.ToTestableString(page[0].EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/service_bindings/71cb6103-be3a-4cd2-a6b5-a407b0d244ef", TestUtil.ToTestableString(page[0].EntityMetadata.Url), true);
            Assert.AreEqual("2015-03-19T13:19:41+00:00", TestUtil.ToTestableString(page[0].EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("484a5805-7ebd-4653-a1e4-a917bf73b955", TestUtil.ToTestableString(page[0].AppGuid), true);
            Assert.AreEqual("4ffa7ff8-a5fb-4c68-8319-ec58b1a84b21", TestUtil.ToTestableString(page[0].ServiceInstanceGuid), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].GatewayData), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].GatewayName), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].SyslogDrainUrl), true);
            Assert.AreEqual("/v2/apps/484a5805-7ebd-4653-a1e4-a917bf73b955", TestUtil.ToTestableString(page[0].AppUrl), true);
            Assert.AreEqual("/v2/user_provided_service_instances/4ffa7ff8-a5fb-4c68-8319-ec58b1a84b21", TestUtil.ToTestableString(page[0].ServiceInstanceUrl), true);
        }

        [TestMethod]
        public void TestListAllUserProvidedServiceInstancesResponse()
        {
            string json = @"{
  ""total_results"": 1,
  ""total_pages"": 1,
  ""prev_url"": null,
  ""next_url"": null,
  ""resources"": [
    {
      ""metadata"": {
        ""guid"": ""f230c70d-d4b6-4a5d-a419-daef2957ce98"",
        ""url"": ""/v2/user_provided_service_instances/f230c70d-d4b6-4a5d-a419-daef2957ce98"",
        ""created_at"": ""2015-03-19T13:19:41+00:00"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""name-279"",
        ""credentials"": {
          ""creds-key-163"": ""creds-val-163""
        },
        ""space_guid"": ""b9d95416-cdd8-4311-8a54-89e1847486d0"",
        ""type"": ""user_provided_service_instance"",
        ""syslog_drain_url"": ""https://foo.com/url-29"",
        ""space_url"": ""/v2/spaces/b9d95416-cdd8-4311-8a54-89e1847486d0"",
        ""service_bindings_url"": ""/v2/user_provided_service_instances/f230c70d-d4b6-4a5d-a419-daef2957ce98/service_bindings""
      }
    }
  ]
}";

            PagedResponseCollection<ListAllUserProvidedServiceInstancesResponse> page = Utilities.DeserializePage<ListAllUserProvidedServiceInstancesResponse>(json);

            Assert.AreEqual("1", TestUtil.ToTestableString(page.Properties.TotalResults), true);
            Assert.AreEqual("1", TestUtil.ToTestableString(page.Properties.TotalPages), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page.Properties.PreviousUrl), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page.Properties.NextUrl), true);
            Assert.AreEqual("f230c70d-d4b6-4a5d-a419-daef2957ce98", TestUtil.ToTestableString(page[0].EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/user_provided_service_instances/f230c70d-d4b6-4a5d-a419-daef2957ce98", TestUtil.ToTestableString(page[0].EntityMetadata.Url), true);
            Assert.AreEqual("2015-03-19T13:19:41+00:00", TestUtil.ToTestableString(page[0].EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("name-279", TestUtil.ToTestableString(page[0].Name), true);
            Assert.AreEqual("b9d95416-cdd8-4311-8a54-89e1847486d0", TestUtil.ToTestableString(page[0].SpaceGuid), true);
            Assert.AreEqual("user_provided_service_instance", TestUtil.ToTestableString(page[0].Type), true);
            Assert.AreEqual("https://foo.com/url-29", TestUtil.ToTestableString(page[0].SyslogDrainUrl), true);
            Assert.AreEqual("/v2/spaces/b9d95416-cdd8-4311-8a54-89e1847486d0", TestUtil.ToTestableString(page[0].SpaceUrl), true);
            Assert.AreEqual("/v2/user_provided_service_instances/f230c70d-d4b6-4a5d-a419-daef2957ce98/service_bindings", TestUtil.ToTestableString(page[0].ServiceBindingsUrl), true);
        }

        [TestMethod]
        public void TestUpdateUserProvidedServiceInstanceResponse()
        {
            string json = @"{
  ""metadata"": {
    ""guid"": ""8aa1dd42-1fca-4177-8124-4d6778664992"",
    ""url"": ""/v2/user_provided_service_instances/8aa1dd42-1fca-4177-8124-4d6778664992"",
    ""created_at"": ""2015-03-19T13:19:41+00:00"",
    ""updated_at"": ""2015-03-19T13:19:41+00:00""
  },
  ""entity"": {
    ""name"": ""name-271"",
    ""credentials"": {
      ""somekey"": ""somenewvalue""
    },
    ""space_guid"": ""4a728182-781e-4ed4-9b04-4a95567556a4"",
    ""type"": ""user_provided_service_instance"",
    ""syslog_drain_url"": ""https://foo.com/url-27"",
    ""space_url"": ""/v2/spaces/4a728182-781e-4ed4-9b04-4a95567556a4"",
    ""service_bindings_url"": ""/v2/user_provided_service_instances/8aa1dd42-1fca-4177-8124-4d6778664992/service_bindings""
  }
}";

            UpdateUserProvidedServiceInstanceResponse obj = Utilities.DeserializeJson<UpdateUserProvidedServiceInstanceResponse>(json);

            Assert.AreEqual("8aa1dd42-1fca-4177-8124-4d6778664992", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/user_provided_service_instances/8aa1dd42-1fca-4177-8124-4d6778664992", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
            Assert.AreEqual("2015-03-19T13:19:41+00:00", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
            Assert.AreEqual("2015-03-19T13:19:41+00:00", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("name-271", TestUtil.ToTestableString(obj.Name), true);
            Assert.AreEqual("4a728182-781e-4ed4-9b04-4a95567556a4", TestUtil.ToTestableString(obj.SpaceGuid), true);
            Assert.AreEqual("user_provided_service_instance", TestUtil.ToTestableString(obj.Type), true);
            Assert.AreEqual("https://foo.com/url-27", TestUtil.ToTestableString(obj.SyslogDrainUrl), true);
            Assert.AreEqual("/v2/spaces/4a728182-781e-4ed4-9b04-4a95567556a4", TestUtil.ToTestableString(obj.SpaceUrl), true);
            Assert.AreEqual("/v2/user_provided_service_instances/8aa1dd42-1fca-4177-8124-4d6778664992/service_bindings", TestUtil.ToTestableString(obj.ServiceBindingsUrl), true);
        }
    }
}
