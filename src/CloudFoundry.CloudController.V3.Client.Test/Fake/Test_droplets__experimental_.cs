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

using CloudFoundry.CloudController.V3.Client.Data;
using Microsoft.QualityTools.Testing.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.CodeDom.Compiler;
using System.Net;
using System.Threading.Tasks;

namespace CloudFoundry.CloudController.V3.Client.Test.Fake
{
    [TestClass]
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public class DropletsExperimentalEndpoint
{
        [TestMethod]
        public void ListAllDropletsTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""pagination"": {
    ""total_results"": 2,
    ""first"": {
      ""href"": ""/v3/droplets?order_by=-created_at=1=2""
    },
    ""last"": {
      ""href"": ""/v3/droplets?order_by=-created_at=1=2""
    },
    ""next"": null,
    ""previous"": null
  },
  ""resources"": [
    {
      ""guid"": ""4fd8545e-fd4a-429f-a231-f41d54be20b2"",
      ""state"": ""STAGED"",
      ""error"": null,
      ""lifecycle"": {
        ""type"": ""buildpack"",
        ""data"": {
          ""buildpack"": ""name-999"",
          ""stack"": ""name-1000""
        }
      },
      ""memory_limit"": 123,
      ""disk_limit"": 456,
      ""result"": {
        ""execution_metadata"": ""black-box-secrets"",
        ""process_types"": {
          ""web"": ""started""
        },
        ""hash"": {
          ""type"": ""sha1"",
          ""value"": ""my-hash""
        },
        ""buildpack"": ""https://github.com/cloudfoundry/detected-buildpack.git"",
        ""stack"": null
      },
      ""environment_variables"": {

      },
      ""created_at"": ""1970-01-01T00:00:02Z"",
      ""updated_at"": ""2016-03-21T10:59:39Z"",
      ""links"": {
        ""self"": {
          ""href"": ""/v3/droplets/8e2a7111-6a0c-4b0b-a383-7f0009a229b0""
        },
        ""package"": {
          ""href"": ""/v3/packages/84435e96-d87d-46d6-8e2b-c3cbb94e76a9""
        },
        ""app"": {
          ""href"": ""/v3/apps/4be31655-6d27-4be6-9f84-d2a909a5d378""
        },
        ""assign_current_droplet"": {
          ""href"": ""/v3/apps/4be31655-6d27-4be6-9f84-d2a909a5d378/current_droplet"",
          ""method"": ""PUT""
        }
      }
    },
    {
      ""guid"": ""4fd8545e-fd4a-429f-a231-f41d54be20b2"",
      ""state"": ""STAGING"",
      ""error"": null,
      ""lifecycle"": {
        ""type"": ""buildpack"",
        ""data"": {
          ""buildpack"": ""name-997"",
          ""stack"": ""name-998""
        }
      },
      ""memory_limit"": null,
      ""disk_limit"": null,
      ""result"": null,
      ""environment_variables"": {
        ""yuu"": ""huuu""
      },
      ""created_at"": ""1970-01-01T00:00:01Z"",
      ""updated_at"": ""2016-03-21T10:59:39Z"",
      ""links"": {
        ""self"": {
          ""href"": ""/v3/droplets/3becc673-95c6-473f-856e-9ccbfdccd3aa""
        },
        ""package"": {
          ""href"": ""/v3/packages/84435e96-d87d-46d6-8e2b-c3cbb94e76a9""
        },
        ""app"": {
          ""href"": ""/v3/apps/4be31655-6d27-4be6-9f84-d2a909a5d378""
        },
        ""assign_current_droplet"": {
          ""href"": ""/v3/apps/4be31655-6d27-4be6-9f84-d2a909a5d378/current_droplet"",
          ""method"": ""PUT""
        },
        ""buildpack"": {
          ""href"": ""/v2/buildpacks/aec545b9-5f57-4776-83aa-fe6d8c3e33fe""
        }
      }
    }
  ]
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)200;
                var cfClient = clients.CreateCloudFoundryClient();


                var obj = cfClient.DropletsExperimental.ListAllDroplets().Result;

                Assert.AreEqual("4fd8545e-fd4a-429f-a231-f41d54be20b2", TestUtil.ToTestableString(obj[0].Guid), true);
                Assert.AreEqual("STAGED", TestUtil.ToTestableString(obj[0].State), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].Error), true);
                Assert.AreEqual("123", TestUtil.ToTestableString(obj[0].MemoryLimit), true);
                Assert.AreEqual("456", TestUtil.ToTestableString(obj[0].DiskLimit), true);
                Assert.AreEqual("1970-01-01T00:00:02Z", TestUtil.ToTestableString(obj[0].CreatedAt), true);
                Assert.AreEqual("2016-03-21T10:59:39Z", TestUtil.ToTestableString(obj[0].UpdatedAt), true);
                Assert.AreEqual("4fd8545e-fd4a-429f-a231-f41d54be20b2", TestUtil.ToTestableString(obj[1].Guid), true);
                Assert.AreEqual("STAGING", TestUtil.ToTestableString(obj[1].State), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[1].Error), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[1].MemoryLimit), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[1].DiskLimit), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[1].Result), true);
                Assert.AreEqual("1970-01-01T00:00:01Z", TestUtil.ToTestableString(obj[1].CreatedAt), true);
                Assert.AreEqual("2016-03-21T10:59:39Z", TestUtil.ToTestableString(obj[1].UpdatedAt), true);

            }
        }

        [TestMethod]
        public void FiltersDropletsByStatesAppGuidsTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""pagination"": {
    ""total_results"": 2,
    ""first"": {
      ""href"": ""/v3/droplets?app_guids=1cbddf09-f2b3-4bc5-b3c9-b08c4af69c06=-created_at=1=2=STAGED%2CFAILED""
    },
    ""last"": {
      ""href"": ""/v3/droplets?app_guids=1cbddf09-f2b3-4bc5-b3c9-b08c4af69c06=-created_at=1=2=STAGED%2CFAILED""
    },
    ""next"": null,
    ""previous"": null
  },
  ""resources"": [
    {
      ""guid"": ""acee5efd-f2d1-4fec-86ed-b96c3e4e20ec"",
      ""state"": ""STAGED"",
      ""error"": null,
      ""lifecycle"": {
        ""type"": ""buildpack"",
        ""data"": {
          ""buildpack"": ""name-1023"",
          ""stack"": ""name-1024""
        }
      },
      ""memory_limit"": 123,
      ""disk_limit"": 456,
      ""result"": {
        ""execution_metadata"": ""black-box-secrets"",
        ""process_types"": {
          ""web"": ""started""
        },
        ""hash"": {
          ""type"": ""sha1"",
          ""value"": ""my-hash""
        },
        ""buildpack"": ""https://github.com/cloudfoundry/detected-buildpack.git"",
        ""stack"": null
      },
      ""environment_variables"": {

      },
      ""created_at"": ""1970-01-01T00:00:02Z"",
      ""updated_at"": ""2016-03-21T10:59:40Z"",
      ""links"": {
        ""self"": {
          ""href"": ""/v3/droplets/11da4776-617c-494c-acaf-29eea54f10c4""
        },
        ""package"": {
          ""href"": ""/v3/packages/029002df-ab65-44ca-ad22-f1f043e52da5""
        },
        ""app"": {
          ""href"": ""/v3/apps/1cbddf09-f2b3-4bc5-b3c9-b08c4af69c06""
        },
        ""assign_current_droplet"": {
          ""href"": ""/v3/apps/1cbddf09-f2b3-4bc5-b3c9-b08c4af69c06/current_droplet"",
          ""method"": ""PUT""
        }
      }
    },
    {
      ""guid"": ""acee5efd-f2d1-4fec-86ed-b96c3e4e20ec"",
      ""state"": ""FAILED"",
      ""error"": null,
      ""lifecycle"": {
        ""type"": ""buildpack"",
        ""data"": {
          ""buildpack"": ""name-1039"",
          ""stack"": ""name-1040""
        }
      },
      ""memory_limit"": null,
      ""disk_limit"": null,
      ""result"": {
        ""execution_metadata"": null,
        ""process_types"": null,
        ""hash"": {
          ""type"": ""sha1"",
          ""value"": ""my-hash""
        },
        ""buildpack"": ""https://github.com/cloudfoundry/my-buildpack.git"",
        ""stack"": null
      },
      ""environment_variables"": {

      },
      ""created_at"": ""1970-01-01T00:00:02Z"",
      ""updated_at"": ""2016-03-21T10:59:40Z"",
      ""links"": {
        ""self"": {
          ""href"": ""/v3/droplets/9b4f05c3-af7d-49ad-a9dd-d6e92e3df914""
        },
        ""package"": {
          ""href"": ""/v3/packages/029002df-ab65-44ca-ad22-f1f043e52da5""
        },
        ""app"": {
          ""href"": ""/v3/apps/1cbddf09-f2b3-4bc5-b3c9-b08c4af69c06""
        },
        ""assign_current_droplet"": {
          ""href"": ""/v3/apps/1cbddf09-f2b3-4bc5-b3c9-b08c4af69c06/current_droplet"",
          ""method"": ""PUT""
        }
      }
    }
  ]
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)200;
                var cfClient = clients.CreateCloudFoundryClient();


                var obj = cfClient.DropletsExperimental.FiltersDropletsByStatesAppGuids().Result;

                Assert.AreEqual("acee5efd-f2d1-4fec-86ed-b96c3e4e20ec", TestUtil.ToTestableString(obj[0].Guid), true);
                Assert.AreEqual("STAGED", TestUtil.ToTestableString(obj[0].State), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].Error), true);
                Assert.AreEqual("123", TestUtil.ToTestableString(obj[0].MemoryLimit), true);
                Assert.AreEqual("456", TestUtil.ToTestableString(obj[0].DiskLimit), true);
                Assert.AreEqual("1970-01-01T00:00:02Z", TestUtil.ToTestableString(obj[0].CreatedAt), true);
                Assert.AreEqual("2016-03-21T10:59:40Z", TestUtil.ToTestableString(obj[0].UpdatedAt), true);
                Assert.AreEqual("acee5efd-f2d1-4fec-86ed-b96c3e4e20ec", TestUtil.ToTestableString(obj[1].Guid), true);
                Assert.AreEqual("FAILED", TestUtil.ToTestableString(obj[1].State), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[1].Error), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[1].MemoryLimit), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[1].DiskLimit), true);
                Assert.AreEqual("1970-01-01T00:00:02Z", TestUtil.ToTestableString(obj[1].CreatedAt), true);
                Assert.AreEqual("2016-03-21T10:59:40Z", TestUtil.ToTestableString(obj[1].UpdatedAt), true);

            }
        }

        [TestMethod]
        public void GetDropletTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""guid"": ""693fbf2f-ddf4-4b92-b802-e8048fdc0c10"",
  ""state"": ""STAGED"",
  ""error"": ""example error"",
  ""lifecycle"": {
    ""type"": ""buildpack"",
    ""data"": {
      ""buildpack"": ""name-983"",
      ""stack"": ""name-984""
    }
  },
  ""memory_limit"": null,
  ""disk_limit"": null,
  ""result"": {
    ""execution_metadata"": null,
    ""process_types"": null,
    ""hash"": {
      ""type"": ""sha1"",
      ""value"": null
    },
    ""buildpack"": ""http://buildpack.git.url.com"",
    ""stack"": null
  },
  ""environment_variables"": {
    ""cloud"": ""foundry""
  },
  ""created_at"": ""2016-03-21T10:59:39Z"",
  ""updated_at"": ""2016-03-21T10:59:39Z"",
  ""links"": {
    ""self"": {
      ""href"": ""/v3/droplets/dc59aef0-c9fa-4222-916d-10520aa4234b""
    },
    ""package"": {
      ""href"": ""/v3/packages/65ccf9e7-8ad0-432b-9ece-963b0797d86a""
    },
    ""app"": {
      ""href"": ""/v3/apps/4eea3d12-2de6-4845-94e5-2110781c5273""
    },
    ""assign_current_droplet"": {
      ""href"": ""/v3/apps/4eea3d12-2de6-4845-94e5-2110781c5273/current_droplet"",
      ""method"": ""PUT""
    }
  }
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)200;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();


                var obj = cfClient.DropletsExperimental.GetDroplet(guid).Result;


                Assert.AreEqual("693fbf2f-ddf4-4b92-b802-e8048fdc0c10", TestUtil.ToTestableString(obj.Guid), true);
                Assert.AreEqual("STAGED", TestUtil.ToTestableString(obj.State), true);
                Assert.AreEqual("example error", TestUtil.ToTestableString(obj.Error), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.MemoryLimit), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.DiskLimit), true);
                Assert.AreEqual("2016-03-21T10:59:39Z", TestUtil.ToTestableString(obj.CreatedAt), true);
                Assert.AreEqual("2016-03-21T10:59:39Z", TestUtil.ToTestableString(obj.UpdatedAt), true);

            }
        }

        [TestMethod]
        public void DeleteDropletTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                clients.ExpectedStatusCode = (HttpStatusCode)204;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();


                cfClient.DropletsExperimental.DeleteDroplet(guid).Wait();

            }
        }

    }
}