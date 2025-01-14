// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ContainerService.Models
{
    /// <summary> Egress endpoints which AKS agent nodes connect to for common purpose. </summary>
    public partial class OutboundEnvironmentEndpoint
    {
        /// <summary> Initializes a new instance of OutboundEnvironmentEndpoint. </summary>
        internal OutboundEnvironmentEndpoint()
        {
            Endpoints = new ChangeTrackingList<EndpointDependency>();
        }

        /// <summary> Initializes a new instance of OutboundEnvironmentEndpoint. </summary>
        /// <param name="category"> The category of endpoints accessed by the AKS agent node, e.g. azure-resource-management, apiserver, etc. </param>
        /// <param name="endpoints"> The endpoints that AKS agent nodes connect to. </param>
        internal OutboundEnvironmentEndpoint(string category, IReadOnlyList<EndpointDependency> endpoints)
        {
            Category = category;
            Endpoints = endpoints;
        }

        /// <summary> The category of endpoints accessed by the AKS agent node, e.g. azure-resource-management, apiserver, etc. </summary>
        public string Category { get; }
        /// <summary> The endpoints that AKS agent nodes connect to. </summary>
        public IReadOnlyList<EndpointDependency> Endpoints { get; }
    }
}
