// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.AppPlatform.Models
{
    /// <summary> Build service resource properties payload. </summary>
    public partial class BuildServiceProperties
    {
        /// <summary> Initializes a new instance of BuildServiceProperties. </summary>
        public BuildServiceProperties()
        {
        }

        /// <summary> Initializes a new instance of BuildServiceProperties. </summary>
        /// <param name="kPackVersion"> The installed KPack version in this build service. </param>
        /// <param name="provisioningState"> Provisioning state of the KPack build result. </param>
        /// <param name="resourceRequests"> The runtime resource configuration of this build service. </param>
        internal BuildServiceProperties(string kPackVersion, BuildServiceProvisioningState? provisioningState, BuildServicePropertiesResourceRequests resourceRequests)
        {
            KPackVersion = kPackVersion;
            ProvisioningState = provisioningState;
            ResourceRequests = resourceRequests;
        }

        /// <summary> The installed KPack version in this build service. </summary>
        public string KPackVersion { get; set; }
        /// <summary> Provisioning state of the KPack build result. </summary>
        public BuildServiceProvisioningState? ProvisioningState { get; }
        /// <summary> The runtime resource configuration of this build service. </summary>
        public BuildServicePropertiesResourceRequests ResourceRequests { get; set; }
    }
}
