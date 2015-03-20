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
    public class SpacesTest
    {

        [TestMethod]
        public void TestCreateSpaceRequest()
        {
            string json = @"{
  ""name"": ""development"",
  ""organization_guid"": ""81bb558b-2aad-4d52-90a6-893094f300a8""
}";

            CreateSpaceRequest request = new CreateSpaceRequest();

            request.Name = "development";
            request.OrganizationGuid = new Guid("81bb558b-2aad-4d52-90a6-893094f300a8");
            string result = JsonConvert.SerializeObject(request, Formatting.None);
            Assert.AreEqual(TestUtil.ToUnformatedJsonString(json), result);
        }
        [TestMethod]
        public void TestUpdateSpaceRequest()
        {
            string json = @"{
  ""name"": ""New Space Name""
}";

            UpdateSpaceRequest request = new UpdateSpaceRequest();

            request.Name = "New Space Name";
            string result = JsonConvert.SerializeObject(request, Formatting.None);
            Assert.AreEqual(TestUtil.ToUnformatedJsonString(json), result);
        }
    }
}
