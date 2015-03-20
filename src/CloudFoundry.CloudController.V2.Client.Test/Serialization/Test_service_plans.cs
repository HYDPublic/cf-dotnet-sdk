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
    public class ServicePlansTest
    {

        [TestMethod]
        public void TestUpdateServicePlanDeprecatedRequest()
        {
            string json = @"{
  ""name"": ""100mb"",
  ""free"": true,
  ""description"": ""Let's you put data in your database!"",
  ""service_guid"": ""bccdc3a8-65ee-41c5-9dbc-1cb159c11d8b""
}";

            UpdateServicePlanDeprecatedRequest request = new UpdateServicePlanDeprecatedRequest();

            request.Name = "100mb";
            request.Free = true;
            request.Description = "Let's you put data in your database!";
            request.ServiceGuid = new Guid("bccdc3a8-65ee-41c5-9dbc-1cb159c11d8b");
            string result = JsonConvert.SerializeObject(request, Formatting.None);
            Assert.AreEqual(TestUtil.ToUnformatedJsonString(json), result);
        }
        [TestMethod]
        public void TestCreateServicePlanDeprecatedRequest()
        {
            string json = @"{
  ""name"": ""100mb"",
  ""free"": true,
  ""description"": ""Let's you put data in your database!"",
  ""service_guid"": ""3327f1f3-c208-4ccc-a07a-14651076234d""
}";

            CreateServicePlanDeprecatedRequest request = new CreateServicePlanDeprecatedRequest();

            request.Name = "100mb";
            request.Free = true;
            request.Description = "Let's you put data in your database!";
            request.ServiceGuid = new Guid("3327f1f3-c208-4ccc-a07a-14651076234d");
            string result = JsonConvert.SerializeObject(request, Formatting.None);
            Assert.AreEqual(TestUtil.ToUnformatedJsonString(json), result);
        }
    }
}
