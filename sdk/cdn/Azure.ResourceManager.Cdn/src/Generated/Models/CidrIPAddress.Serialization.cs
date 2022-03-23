// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Cdn.Models
{
    public partial class CidrIPAddress : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(BaseIPAddress))
            {
                writer.WritePropertyName("baseIpAddress");
                writer.WriteStringValue(BaseIPAddress);
            }
            if (Optional.IsDefined(PrefixLength))
            {
                writer.WritePropertyName("prefixLength");
                writer.WriteNumberValue(PrefixLength.Value);
            }
            writer.WriteEndObject();
        }

        internal static CidrIPAddress DeserializeCidrIPAddress(JsonElement element)
        {
            Optional<string> baseIpAddress = default;
            Optional<int> prefixLength = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("baseIpAddress"))
                {
                    baseIpAddress = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("prefixLength"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    prefixLength = property.Value.GetInt32();
                    continue;
                }
            }
            return new CidrIPAddress(baseIpAddress.Value, Optional.ToNullable(prefixLength));
        }
    }
}
