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
using Newtonsoft.Json;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace CloudFoundry.CloudController.V2.Test.Serialization
{
    [TestClass]
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public class SecurityGroupsTest
    {

        [TestMethod]
        public void TestUpdateSecurityGroupRequest()
        {
            string json = @"{
  ""name"": ""new_name"",
  ""rules"": [

  ]
}";

            UpdateSecurityGroupRequest request = new UpdateSecurityGroupRequest();

            request.Name = "new_name";
            request.Rules = Array.ConvertAll(TestUtil.GetJsonArray(@"[]"), (p => (Dictionary<string, dynamic>)p));

            string result = JsonConvert.SerializeObject(request, Formatting.None);
            Assert.AreEqual(TestUtil.ToUnformatedJsonString(json), result);
        }
        [TestMethod]
        public void TestCreateSecurityGroupRequest()
        {
            string json = @"{
  ""name"": ""my_super_sec_group"",
  ""rules"": [
    {
      ""protocol"": ""icmp"",
      ""destination"": ""0.0.0.0/0"",
      ""type"": 0,
      ""code"": 1
    },
    {
      ""protocol"": ""tcp"",
      ""destination"": ""0.0.0.0/0"",
      ""ports"": ""2048-3000"",
      ""log"": true
    },
    {
      ""protocol"": ""udp"",
      ""destination"": ""0.0.0.0/0"",
      ""ports"": ""53, 5353""
    },
    {
      ""protocol"": ""all"",
      ""destination"": ""0.0.0.0/0""
    }
  ]
}";

            CreateSecurityGroupRequest request = new CreateSecurityGroupRequest();

            request.Name = "my_super_sec_group";
            request.Rules = Array.ConvertAll(TestUtil.GetJsonArray(@"[{""protocol"":""icmp"",""destination"":""0.0.0.0/0"",""type"":0,""code"":1},{""protocol"":""tcp"",""destination"":""0.0.0.0/0"",""ports"":""2048-3000"",""log"":true},{""protocol"":""udp"",""destination"":""0.0.0.0/0"",""ports"":""53, 5353""},{""protocol"":""all"",""destination"":""0.0.0.0/0""}]"), (p => (Dictionary<string, dynamic>)p));

            string result = JsonConvert.SerializeObject(request, Formatting.None);
            Assert.AreEqual(TestUtil.ToUnformatedJsonString(json), result);
        }
    }
}
