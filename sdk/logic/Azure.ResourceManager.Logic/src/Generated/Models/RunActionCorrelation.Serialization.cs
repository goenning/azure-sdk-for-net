// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Logic.Models
{
    public partial class RunActionCorrelation : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ActionTrackingId))
            {
                writer.WritePropertyName("actionTrackingId");
                writer.WriteStringValue(ActionTrackingId);
            }
            if (Optional.IsDefined(ClientTrackingId))
            {
                writer.WritePropertyName("clientTrackingId");
                writer.WriteStringValue(ClientTrackingId);
            }
            if (Optional.IsCollectionDefined(ClientKeywords))
            {
                writer.WritePropertyName("clientKeywords");
                writer.WriteStartArray();
                foreach (var item in ClientKeywords)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static RunActionCorrelation DeserializeRunActionCorrelation(JsonElement element)
        {
            Optional<string> actionTrackingId = default;
            Optional<string> clientTrackingId = default;
            Optional<IList<string>> clientKeywords = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("actionTrackingId"))
                {
                    actionTrackingId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("clientTrackingId"))
                {
                    clientTrackingId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("clientKeywords"))
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
                    clientKeywords = array;
                    continue;
                }
            }
            return new RunActionCorrelation(clientTrackingId.Value, Optional.ToList(clientKeywords), actionTrackingId.Value);
        }
    }
}
