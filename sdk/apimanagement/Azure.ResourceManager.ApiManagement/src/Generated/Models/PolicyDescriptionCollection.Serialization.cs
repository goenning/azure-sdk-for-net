// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ApiManagement.Models
{
    internal partial class PolicyDescriptionCollection
    {
        internal static PolicyDescriptionCollection DeserializePolicyDescriptionCollection(JsonElement element)
        {
            Optional<IReadOnlyList<PolicyDescriptionContract>> value = default;
            Optional<long> count = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<PolicyDescriptionContract> array = new List<PolicyDescriptionContract>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PolicyDescriptionContract.DeserializePolicyDescriptionContract(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("count"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    count = property.Value.GetInt64();
                    continue;
                }
            }
            return new PolicyDescriptionCollection(Optional.ToList(value), Optional.ToNullable(count));
        }
    }
}
