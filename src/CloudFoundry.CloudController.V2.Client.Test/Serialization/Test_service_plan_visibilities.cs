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
    public class ServicePlanVisibilitiesTest
    {

        [TestMethod]
        public void TestCreateServicePlanVisibilityRequest()
        {
            string json = @"{
  ""service_plan_guid"": ""17cd1b02-911e-435a-95ff-7c8622ee37d1"",
  ""organization_guid"": ""270e154f-d455-4acf-acc7-ec9e53357d81""
}";

            CreateServicePlanVisibilityRequest request = new CreateServicePlanVisibilityRequest();

            request.ServicePlanGuid = new Guid("17cd1b02-911e-435a-95ff-7c8622ee37d1");
            request.OrganizationGuid = new Guid("270e154f-d455-4acf-acc7-ec9e53357d81");
            string result = JsonConvert.SerializeObject(request, Formatting.None);
            Assert.AreEqual(TestUtil.ToUnformatedJsonString(json), result);
        }
        [TestMethod]
        public void TestUpdateServicePlanVisibilityRequest()
        {
            string json = @"{
  ""service_plan_guid"": ""032e2c7f-8fbf-4575-9b79-a2c7711f7b5e"",
  ""organization_guid"": ""c4145921-eb8e-4210-9e8c-46290d02e4d8""
}";

            UpdateServicePlanVisibilityRequest request = new UpdateServicePlanVisibilityRequest();

            request.ServicePlanGuid = new Guid("032e2c7f-8fbf-4575-9b79-a2c7711f7b5e");
            request.OrganizationGuid = new Guid("c4145921-eb8e-4210-9e8c-46290d02e4d8");
            string result = JsonConvert.SerializeObject(request, Formatting.None);
            Assert.AreEqual(TestUtil.ToUnformatedJsonString(json), result);
        }
    }
}
