// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Media.Models
{
    /// <summary> Describes a list of inputs to a Job. </summary>
    public partial class JobInputs : JobInput
    {
        /// <summary> Initializes a new instance of JobInputs. </summary>
        public JobInputs()
        {
            Inputs = new ChangeTrackingList<JobInput>();
            OdataType = "#Microsoft.Media.JobInputs";
        }

        /// <summary> Initializes a new instance of JobInputs. </summary>
        /// <param name="odataType"> The discriminator for derived types. </param>
        /// <param name="inputs">
        /// List of inputs to a Job.
        /// Please note <see cref="JobInput"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="JobInputAsset"/>, <see cref="JobInputClip"/>, <see cref="JobInputHttp"/>, <see cref="JobInputSequence"/> and <see cref="JobInputs"/>.
        /// </param>
        internal JobInputs(string odataType, IList<JobInput> inputs) : base(odataType)
        {
            Inputs = inputs;
            OdataType = odataType ?? "#Microsoft.Media.JobInputs";
        }

        /// <summary>
        /// List of inputs to a Job.
        /// Please note <see cref="JobInput"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="JobInputAsset"/>, <see cref="JobInputClip"/>, <see cref="JobInputHttp"/>, <see cref="JobInputSequence"/> and <see cref="JobInputs"/>.
        /// </summary>
        public IList<JobInput> Inputs { get; }
    }
}
