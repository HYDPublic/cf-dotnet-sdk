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


using Newtonsoft.Json;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace CloudFoundry.CloudController.V3.Client.Data
{
    /// <summary>
    /// Data class used for deserializing the "CloudFoundry.CloudController.V3.Client.AppsExperimentalEndpoint.GetDetailedStatsForAppsProcess()" Response
    /// <para>For usage information, see online documentation at "http://apidocs.cloudfoundry.org/231/apps__experimental_/get_detailed_stats_for_an_app's_process.html"</para>
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public partial class GetDetailedStatsForAppsProcessResponse : CloudFoundry.CloudController.V3.Client.Data.Base.AbstractGetDetailedStatsForAppsProcessResponse
    {
    }
}

namespace CloudFoundry.CloudController.V3.Client.Data.Base
{
    /// <summary>
    /// Base abstract data class used for deserializing the "CloudFoundry.CloudController.V3.Client.AppsExperimentalEndpoint.GetDetailedStatsForAppsProcess()" Response
    /// <para>For usage information, see online documentation at "http://apidocs.cloudfoundry.org/231/apps__experimental_/get_detailed_stats_for_an_app's_process.html"</para>
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public abstract class AbstractGetDetailedStatsForAppsProcessResponse
    {

        /// <summary> 
        /// <para>The Type</para>
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Index</para>
        /// </summary>
        [JsonProperty("index", NullValueHandling = NullValueHandling.Ignore)]
        public int? Index
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The State</para>
        /// </summary>
        [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
        public string State
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Usage</para>
        /// </summary>
        [JsonProperty("usage", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, dynamic> Usage
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Host</para>
        /// </summary>
        [JsonProperty("host", NullValueHandling = NullValueHandling.Ignore)]
        public string Host
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Port</para>
        /// </summary>
        [JsonProperty("port", NullValueHandling = NullValueHandling.Ignore)]
        public int? Port
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Uptime</para>
        /// </summary>
        [JsonProperty("uptime", NullValueHandling = NullValueHandling.Ignore)]
        public int? Uptime
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Mem Quota</para>
        /// </summary>
        [JsonProperty("mem_quota", NullValueHandling = NullValueHandling.Ignore)]
        public int? MemQuota
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Disk Quota</para>
        /// </summary>
        [JsonProperty("disk_quota", NullValueHandling = NullValueHandling.Ignore)]
        public int? DiskQuota
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Fds Quota</para>
        /// </summary>
        [JsonProperty("fds_quota", NullValueHandling = NullValueHandling.Ignore)]
        public int? FdsQuota
        {
            get;
            set;
        }
    }
}