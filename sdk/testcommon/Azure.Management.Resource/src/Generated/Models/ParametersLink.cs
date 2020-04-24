// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Management.Resource.Models
{
    /// <summary> Entity representing the reference to the deployment parameters. </summary>
    public partial class ParametersLink
    {
        /// <summary> Initializes a new instance of ParametersLink. </summary>
        /// <param name="uri"> URI referencing the template. </param>
        public ParametersLink(string uri)
        {
            if (uri == null)
            {
                throw new ArgumentNullException(nameof(uri));
            }

            Uri = uri;
        }

        /// <summary> Initializes a new instance of ParametersLink. </summary>
        /// <param name="uri"> URI referencing the template. </param>
        /// <param name="contentVersion"> If included it must match the ContentVersion in the template. </param>
        internal ParametersLink(string uri, string contentVersion)
        {
            Uri = uri;
            ContentVersion = contentVersion;
        }

        /// <summary> URI referencing the template. </summary>
        public string Uri { get; }
        /// <summary> If included it must match the ContentVersion in the template. </summary>
        public string ContentVersion { get; set; }
    }
}
