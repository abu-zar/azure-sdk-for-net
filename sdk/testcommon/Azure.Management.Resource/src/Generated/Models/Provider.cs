// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Management.Resource.Models
{
    /// <summary> Resource provider information. </summary>
    public partial class Provider
    {
        /// <summary> Initializes a new instance of Provider. </summary>
        internal Provider()
        {
        }

        /// <summary> Initializes a new instance of Provider. </summary>
        /// <param name="id"> The provider id. </param>
        /// <param name="namespace"> The namespace of the provider. </param>
        /// <param name="registrationState"> The registration state of the provider. </param>
        /// <param name="resourceTypes"> The collection of provider resource types. </param>
        internal Provider(string id, string @namespace, string registrationState, IReadOnlyList<ProviderResourceType> resourceTypes)
        {
            Id = id;
            Namespace = @namespace;
            RegistrationState = registrationState;
            ResourceTypes = resourceTypes;
        }

        /// <summary> The provider id. </summary>
        public string Id { get; }
        /// <summary> The namespace of the provider. </summary>
        public string Namespace { get; }
        /// <summary> The registration state of the provider. </summary>
        public string RegistrationState { get; }
        /// <summary> The collection of provider resource types. </summary>
        public IReadOnlyList<ProviderResourceType> ResourceTypes { get; }
    }
}
