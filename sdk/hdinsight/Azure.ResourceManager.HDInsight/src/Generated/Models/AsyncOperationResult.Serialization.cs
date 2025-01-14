// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HDInsight.Models
{
    public partial class AsyncOperationResult
    {
        internal static AsyncOperationResult DeserializeAsyncOperationResult(JsonElement element)
        {
            Optional<AsyncOperationState> status = default;
            Optional<Errors> error = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("status"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    status = new AsyncOperationState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("error"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    error = Errors.DeserializeErrors(property.Value);
                    continue;
                }
            }
            return new AsyncOperationResult(Optional.ToNullable(status), error.Value);
        }
    }
}
