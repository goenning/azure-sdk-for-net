// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.HDInsight.Models
{
    /// <summary> The table configuration for the Log Analytics integration. </summary>
    public partial class AzureMonitorTableConfiguration
    {
        /// <summary> Initializes a new instance of AzureMonitorTableConfiguration. </summary>
        public AzureMonitorTableConfiguration()
        {
        }

        /// <summary> Initializes a new instance of AzureMonitorTableConfiguration. </summary>
        /// <param name="name"> The name. </param>
        internal AzureMonitorTableConfiguration(string name)
        {
            Name = name;
        }

        /// <summary> The name. </summary>
        public string Name { get; set; }
    }
}
