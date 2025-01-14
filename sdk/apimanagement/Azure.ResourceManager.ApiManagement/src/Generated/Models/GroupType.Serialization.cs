// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.ApiManagement.Models
{
    internal static partial class GroupTypeExtensions
    {
        public static string ToSerialString(this GroupType value) => value switch
        {
            GroupType.Custom => "custom",
            GroupType.System => "system",
            GroupType.External => "external",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown GroupType value.")
        };

        public static GroupType ToGroupType(this string value)
        {
            if (string.Equals(value, "custom", StringComparison.InvariantCultureIgnoreCase)) return GroupType.Custom;
            if (string.Equals(value, "system", StringComparison.InvariantCultureIgnoreCase)) return GroupType.System;
            if (string.Equals(value, "external", StringComparison.InvariantCultureIgnoreCase)) return GroupType.External;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown GroupType value.");
        }
    }
}
