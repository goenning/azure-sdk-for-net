// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Logic;

namespace Azure.ResourceManager.Logic.Models
{
    internal partial class BatchConfigurationCollection
    {
        internal static BatchConfigurationCollection DeserializeBatchConfigurationCollection(JsonElement element)
        {
            Optional<IReadOnlyList<BatchConfigurationData>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<BatchConfigurationData> array = new List<BatchConfigurationData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(BatchConfigurationData.DeserializeBatchConfigurationData(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new BatchConfigurationCollection(Optional.ToList(value));
        }
    }
}
