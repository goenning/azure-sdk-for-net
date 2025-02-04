// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Batch.Models
{
    internal static partial class BatchDiskCachingTypeExtensions
    {
        public static string ToSerialString(this BatchDiskCachingType value) => value switch
        {
            BatchDiskCachingType.None => "None",
            BatchDiskCachingType.ReadOnly => "ReadOnly",
            BatchDiskCachingType.ReadWrite => "ReadWrite",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown BatchDiskCachingType value.")
        };

        public static BatchDiskCachingType ToBatchDiskCachingType(this string value)
        {
            if (string.Equals(value, "None", StringComparison.InvariantCultureIgnoreCase)) return BatchDiskCachingType.None;
            if (string.Equals(value, "ReadOnly", StringComparison.InvariantCultureIgnoreCase)) return BatchDiskCachingType.ReadOnly;
            if (string.Equals(value, "ReadWrite", StringComparison.InvariantCultureIgnoreCase)) return BatchDiskCachingType.ReadWrite;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown BatchDiskCachingType value.");
        }
    }
}
