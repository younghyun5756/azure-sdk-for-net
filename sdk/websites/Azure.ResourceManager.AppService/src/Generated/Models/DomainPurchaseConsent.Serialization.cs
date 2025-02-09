// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class DomainPurchaseConsent : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(AgreementKeys))
            {
                writer.WritePropertyName("agreementKeys"u8);
                writer.WriteStartArray();
                foreach (var item in AgreementKeys)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(AgreedBy))
            {
                writer.WritePropertyName("agreedBy"u8);
                writer.WriteStringValue(AgreedBy);
            }
            if (Optional.IsDefined(AgreedOn))
            {
                writer.WritePropertyName("agreedAt"u8);
                writer.WriteStringValue(AgreedOn.Value, "O");
            }
            writer.WriteEndObject();
        }

        internal static DomainPurchaseConsent DeserializeDomainPurchaseConsent(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<string>> agreementKeys = default;
            Optional<string> agreedBy = default;
            Optional<DateTimeOffset> agreedAt = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("agreementKeys"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    agreementKeys = array;
                    continue;
                }
                if (property.NameEquals("agreedBy"u8))
                {
                    agreedBy = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("agreedAt"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    agreedAt = property.Value.GetDateTimeOffset("O");
                    continue;
                }
            }
            return new DomainPurchaseConsent(Optional.ToList(agreementKeys), agreedBy.Value, Optional.ToNullable(agreedAt));
        }
    }
}
