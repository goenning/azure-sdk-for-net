// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    /// <summary> A request to check whether a container registry name is available. </summary>
    public partial class RegistryNameCheckContent
    {
        /// <summary> Initializes a new instance of RegistryNameCheckContent. </summary>
        /// <param name="name"> The name of the container registry. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public RegistryNameCheckContent(string name)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            Name = name;
            ContainerRegistryResourceType = ContainerRegistryResourceType.MicrosoftContainerRegistryRegistries;
        }

        /// <summary> The name of the container registry. </summary>
        public string Name { get; }
        /// <summary> The resource type of the container registry. This field must be set to &apos;Microsoft.ContainerRegistry/registries&apos;. </summary>
        public ContainerRegistryResourceType ContainerRegistryResourceType { get; }
    }
}
