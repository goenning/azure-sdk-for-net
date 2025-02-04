// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SqlVirtualMachine.Models
{
    public partial class AssessmentSettings : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Enable))
            {
                writer.WritePropertyName("enable");
                writer.WriteBooleanValue(Enable.Value);
            }
            if (Optional.IsDefined(RunImmediately))
            {
                writer.WritePropertyName("runImmediately");
                writer.WriteBooleanValue(RunImmediately.Value);
            }
            if (Optional.IsDefined(Schedule))
            {
                writer.WritePropertyName("schedule");
                writer.WriteObjectValue(Schedule);
            }
            writer.WriteEndObject();
        }

        internal static AssessmentSettings DeserializeAssessmentSettings(JsonElement element)
        {
            Optional<bool> enable = default;
            Optional<bool> runImmediately = default;
            Optional<Schedule> schedule = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("enable"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    enable = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("runImmediately"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    runImmediately = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("schedule"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    schedule = Schedule.DeserializeSchedule(property.Value);
                    continue;
                }
            }
            return new AssessmentSettings(Optional.ToNullable(enable), Optional.ToNullable(runImmediately), schedule.Value);
        }
    }
}
