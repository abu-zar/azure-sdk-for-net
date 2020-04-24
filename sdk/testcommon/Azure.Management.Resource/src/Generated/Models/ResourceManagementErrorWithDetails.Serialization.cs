// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Resource.Models
{
    public partial class ResourceManagementErrorWithDetails
    {
        internal static ResourceManagementErrorWithDetails DeserializeResourceManagementErrorWithDetails(JsonElement element)
        {
            string code = default;
            string message = default;
            string target = default;
            IReadOnlyList<ResourceManagementErrorWithDetails> details = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("code"))
                {
                    code = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("message"))
                {
                    message = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("target"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    target = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("details"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ResourceManagementErrorWithDetails> array = new List<ResourceManagementErrorWithDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(DeserializeResourceManagementErrorWithDetails(item));
                        }
                    }
                    details = array;
                    continue;
                }
            }
            return new ResourceManagementErrorWithDetails(code, message, target, details);
        }
    }
}
