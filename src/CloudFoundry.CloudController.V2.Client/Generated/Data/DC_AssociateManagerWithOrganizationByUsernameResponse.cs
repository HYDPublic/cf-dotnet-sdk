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

using CloudFoundry.CloudController.V2.Client.Interfaces;
using Newtonsoft.Json;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace CloudFoundry.CloudController.V2.Client.Data
{
    /// <summary>
    /// Data class used for deserializing the "CloudFoundry.CloudController.V2.Client.OrganizationsEndpoint.AssociateManagerWithOrganizationByUsername()" Response
    /// <para>For usage information, see online documentation at "http://apidocs.cloudfoundry.org/241/organizations/associate_manager_with_the_organization_by_username.html"</para>
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public partial class AssociateManagerWithOrganizationByUsernameResponse : CloudFoundry.CloudController.V2.Client.Data.Base.AbstractAssociateManagerWithOrganizationByUsernameResponse
    {
    }
}

namespace CloudFoundry.CloudController.V2.Client.Data.Base
{
    /// <summary>
    /// Base abstract data class used for deserializing the "CloudFoundry.CloudController.V2.Client.OrganizationsEndpoint.AssociateManagerWithOrganizationByUsername()" Response
    /// <para>For usage information, see online documentation at "http://apidocs.cloudfoundry.org/241/organizations/associate_manager_with_the_organization_by_username.html"</para>
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public abstract class AbstractAssociateManagerWithOrganizationByUsernameResponse : IResponse
    {
        /// <summary>
        /// Contains the Metadata for this Entity
        /// </summary>
        public Metadata EntityMetadata
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Name</para>
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Billing Enabled</para>
        /// </summary>
        [JsonProperty("billing_enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? BillingEnabled
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Quota Definition Guid</para>
        /// </summary>
        [JsonProperty("quota_definition_guid", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? QuotaDefinitionGuid
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Status</para>
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Quota Definition Url</para>
        /// </summary>
        [JsonProperty("quota_definition_url", NullValueHandling = NullValueHandling.Ignore)]
        public string QuotaDefinitionUrl
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Spaces Url</para>
        /// </summary>
        [JsonProperty("spaces_url", NullValueHandling = NullValueHandling.Ignore)]
        public string SpacesUrl
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Domains Url</para>
        /// </summary>
        [JsonProperty("domains_url", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainsUrl
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Private Domains Url</para>
        /// </summary>
        [JsonProperty("private_domains_url", NullValueHandling = NullValueHandling.Ignore)]
        public string PrivateDomainsUrl
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Users Url</para>
        /// </summary>
        [JsonProperty("users_url", NullValueHandling = NullValueHandling.Ignore)]
        public string UsersUrl
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Managers Url</para>
        /// </summary>
        [JsonProperty("managers_url", NullValueHandling = NullValueHandling.Ignore)]
        public string ManagersUrl
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Billing Managers Url</para>
        /// </summary>
        [JsonProperty("billing_managers_url", NullValueHandling = NullValueHandling.Ignore)]
        public string BillingManagersUrl
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Auditors Url</para>
        /// </summary>
        [JsonProperty("auditors_url", NullValueHandling = NullValueHandling.Ignore)]
        public string AuditorsUrl
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The App Events Url</para>
        /// </summary>
        [JsonProperty("app_events_url", NullValueHandling = NullValueHandling.Ignore)]
        public string AppEventsUrl
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Space Quota Definitions Url</para>
        /// </summary>
        [JsonProperty("space_quota_definitions_url", NullValueHandling = NullValueHandling.Ignore)]
        public string SpaceQuotaDefinitionsUrl
        {
            get;
            set;
        }
    }
}