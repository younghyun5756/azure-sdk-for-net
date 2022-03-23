// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.EventHubs.Models
{
    internal partial class EventHubNamespaceIdListResult
    {
        internal static EventHubNamespaceIdListResult DeserializeEventHubNamespaceIdListResult(JsonElement element)
        {
            Optional<IReadOnlyList<SubResource>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<SubResource> array = new List<SubResource>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(JsonSerializer.Deserialize<SubResource>(item.ToString()));
                    }
                    value = array;
                    continue;
                }
            }
            return new EventHubNamespaceIdListResult(Optional.ToList(value));
        }
    }
}
