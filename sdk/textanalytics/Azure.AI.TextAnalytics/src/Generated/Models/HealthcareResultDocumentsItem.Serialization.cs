// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.AI.TextAnalytics;
using Azure.Core;

namespace Azure.AI.TextAnalytics.Models
{
    internal partial class HealthcareResultDocumentsItem : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("entities");
            writer.WriteStartArray();
            foreach (var item in Entities)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            writer.WritePropertyName("relations");
            writer.WriteStartArray();
            foreach (var item in Relations)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            writer.WritePropertyName("id");
            writer.WriteStringValue(Id);
            writer.WritePropertyName("warnings");
            writer.WriteStartArray();
            foreach (var item in Warnings)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            if (Optional.IsDefined(Statistics))
            {
                writer.WritePropertyName("statistics");
                writer.WriteObjectValue(Statistics.Value);
            }
            writer.WriteEndObject();
        }

        internal static HealthcareResultDocumentsItem DeserializeHealthcareResultDocumentsItem(JsonElement element)
        {
            IList<HealthcareEntityInternal> entities = default;
            IList<HealthcareRelationInternal> relations = default;
            string id = default;
            IList<DocumentWarning> warnings = default;
            Optional<TextDocumentStatistics> statistics = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("entities"))
                {
                    List<HealthcareEntityInternal> array = new List<HealthcareEntityInternal>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(HealthcareEntityInternal.DeserializeHealthcareEntityInternal(item));
                    }
                    entities = array;
                    continue;
                }
                if (property.NameEquals("relations"))
                {
                    List<HealthcareRelationInternal> array = new List<HealthcareRelationInternal>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(HealthcareRelationInternal.DeserializeHealthcareRelationInternal(item));
                    }
                    relations = array;
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("warnings"))
                {
                    List<DocumentWarning> array = new List<DocumentWarning>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DocumentWarning.DeserializeDocumentWarning(item));
                    }
                    warnings = array;
                    continue;
                }
                if (property.NameEquals("statistics"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    statistics = TextDocumentStatistics.DeserializeTextDocumentStatistics(property.Value);
                    continue;
                }
            }
            return new HealthcareResultDocumentsItem(id, warnings, Optional.ToNullable(statistics), entities, relations);
        }
    }
}
