// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure;

namespace Azure.ResourceManager.Media.Models
{
    /// <summary> Status of media service operation. </summary>
    public partial class MediaServiceOperationStatus
    {
        /// <summary> Initializes a new instance of MediaServiceOperationStatus. </summary>
        /// <param name="name"> Operation identifier. </param>
        /// <param name="status"> Operation status. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="status"/> is null. </exception>
        internal MediaServiceOperationStatus(string name, string status)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (status == null)
            {
                throw new ArgumentNullException(nameof(status));
            }

            Name = name;
            Status = status;
        }

        /// <summary> Initializes a new instance of MediaServiceOperationStatus. </summary>
        /// <param name="name"> Operation identifier. </param>
        /// <param name="id"> Operation resource ID. </param>
        /// <param name="startOn"> Operation start time. </param>
        /// <param name="endOn"> Operation end time. </param>
        /// <param name="status"> Operation status. </param>
        /// <param name="error"> The error detail. </param>
        internal MediaServiceOperationStatus(string name, string id, DateTimeOffset? startOn, DateTimeOffset? endOn, string status, ResponseError error)
        {
            Name = name;
            Id = id;
            StartOn = startOn;
            EndOn = endOn;
            Status = status;
            Error = error;
        }

        /// <summary> Operation identifier. </summary>
        public string Name { get; }
        /// <summary> Operation resource ID. </summary>
        public string Id { get; }
        /// <summary> Operation start time. </summary>
        public DateTimeOffset? StartOn { get; }
        /// <summary> Operation end time. </summary>
        public DateTimeOffset? EndOn { get; }
        /// <summary> Operation status. </summary>
        public string Status { get; }
        /// <summary> The error detail. </summary>
        public ResponseError Error { get; }
    }
}
