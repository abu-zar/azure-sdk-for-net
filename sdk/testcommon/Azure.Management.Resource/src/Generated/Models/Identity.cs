// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Management.Resource.Models
{
    /// <summary> Identity for the resource. </summary>
    public partial class Identity
    {
        /// <summary> Initializes a new instance of Identity. </summary>
        public Identity()
        {
        }

        /// <summary> Initializes a new instance of Identity. </summary>
        /// <param name="principalId"> The principal id of resource identity. </param>
        /// <param name="tenantId"> The tenant id of resource. </param>
        /// <param name="type"> The identity type. </param>
        internal Identity(string principalId, string tenantId, string type)
        {
            PrincipalId = principalId;
            TenantId = tenantId;
            Type = type;
        }

        /// <summary> The principal id of resource identity. </summary>
        public string PrincipalId { get; }
        /// <summary> The tenant id of resource. </summary>
        public string TenantId { get; }
        /// <summary> The identity type. </summary>
        public string Type { get; set; }
    }
}
