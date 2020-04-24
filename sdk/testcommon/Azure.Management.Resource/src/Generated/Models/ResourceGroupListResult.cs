// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Management.Resource.Models
{
    /// <summary> List of resource groups. </summary>
    public partial class ResourceGroupListResult
    {
        /// <summary> Initializes a new instance of ResourceGroupListResult. </summary>
        /// <param name="nextLink"> The URL to get the next set of results. </param>
        internal ResourceGroupListResult(string nextLink)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }

            NextLink = nextLink;
        }

        /// <summary> Initializes a new instance of ResourceGroupListResult. </summary>
        /// <param name="value"> The list of resource groups. </param>
        /// <param name="nextLink"> The URL to get the next set of results. </param>
        internal ResourceGroupListResult(IReadOnlyList<ResourceGroup> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> The list of resource groups. </summary>
        public IReadOnlyList<ResourceGroup> Value { get; }
        /// <summary> The URL to get the next set of results. </summary>
        public string NextLink { get; }
    }
}
