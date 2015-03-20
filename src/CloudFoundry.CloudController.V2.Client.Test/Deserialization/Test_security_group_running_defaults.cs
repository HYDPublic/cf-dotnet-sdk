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
    public class SecurityGroupRunningDefaultsTest
    {


        [TestMethod]
        public void TestSetSecurityGroupAsDefaultForRunningAppsResponse()
        {
            string json = @"{
  ""metadata"": {
    ""guid"": ""28b24c58-4e6f-4f20-9ea5-4f19c11c7ca5"",
    ""url"": ""/v2/config/running_security_groups/28b24c58-4e6f-4f20-9ea5-4f19c11c7ca5"",
    ""created_at"": ""2015-03-19T13:19:58+00:00"",
    ""updated_at"": ""2015-03-19T13:19:58+00:00""
  },
  ""entity"": {
    ""name"": ""name-1884"",
    ""rules"": [
      {
        ""protocol"": ""udp"",
        ""ports"": ""8080"",
        ""destination"": ""198.41.191.47/1""
      }
    ],
    ""running_default"": true,
    ""staging_default"": false
  }
}";

            SetSecurityGroupAsDefaultForRunningAppsResponse obj = Utilities.DeserializeJson<SetSecurityGroupAsDefaultForRunningAppsResponse>(json);

            Assert.AreEqual("28b24c58-4e6f-4f20-9ea5-4f19c11c7ca5", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/config/running_security_groups/28b24c58-4e6f-4f20-9ea5-4f19c11c7ca5", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
            Assert.AreEqual("2015-03-19T13:19:58+00:00", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
            Assert.AreEqual("2015-03-19T13:19:58+00:00", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("name-1884", TestUtil.ToTestableString(obj.Name), true);
            Assert.AreEqual("true", TestUtil.ToTestableString(obj.RunningDefault), true);
            Assert.AreEqual("false", TestUtil.ToTestableString(obj.StagingDefault), true);
        }

        [TestMethod]
        public void TestReturnSecurityGroupsUsedForRunningAppsResponse()
        {
            string json = @"{
  ""total_results"": 1,
  ""total_pages"": 1,
  ""prev_url"": null,
  ""next_url"": null,
  ""resources"": [
    {
      ""metadata"": {
        ""guid"": ""3de8e2cd-2dba-4505-a2e4-d10ae6d8d70b"",
        ""url"": ""/v2/config/running_security_groups/3de8e2cd-2dba-4505-a2e4-d10ae6d8d70b"",
        ""created_at"": ""2015-03-19T13:19:58+00:00"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""name-1883"",
        ""rules"": [
          {
            ""protocol"": ""udp"",
            ""ports"": ""8080"",
            ""destination"": ""198.41.191.47/1""
          }
        ],
        ""running_default"": true,
        ""staging_default"": false
      }
    }
  ]
}";

            PagedResponseCollection<ReturnSecurityGroupsUsedForRunningAppsResponse> page = Utilities.DeserializePage<ReturnSecurityGroupsUsedForRunningAppsResponse>(json);

            Assert.AreEqual("1", TestUtil.ToTestableString(page.Properties.TotalResults), true);
            Assert.AreEqual("1", TestUtil.ToTestableString(page.Properties.TotalPages), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page.Properties.PreviousUrl), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page.Properties.NextUrl), true);
            Assert.AreEqual("3de8e2cd-2dba-4505-a2e4-d10ae6d8d70b", TestUtil.ToTestableString(page[0].EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/config/running_security_groups/3de8e2cd-2dba-4505-a2e4-d10ae6d8d70b", TestUtil.ToTestableString(page[0].EntityMetadata.Url), true);
            Assert.AreEqual("2015-03-19T13:19:58+00:00", TestUtil.ToTestableString(page[0].EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("name-1883", TestUtil.ToTestableString(page[0].Name), true);
            Assert.AreEqual("true", TestUtil.ToTestableString(page[0].RunningDefault), true);
            Assert.AreEqual("false", TestUtil.ToTestableString(page[0].StagingDefault), true);
        }
    }
}
