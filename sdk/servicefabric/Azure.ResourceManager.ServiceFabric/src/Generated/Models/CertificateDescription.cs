// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.ServiceFabric.Models
{
    /// <summary> Describes the certificate details. </summary>
    public partial class CertificateDescription
    {
        /// <summary> Initializes a new instance of CertificateDescription. </summary>
        /// <param name="thumbprint"> Thumbprint of the primary certificate. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="thumbprint"/> is null. </exception>
        public CertificateDescription(string thumbprint)
        {
            if (thumbprint == null)
            {
                throw new ArgumentNullException(nameof(thumbprint));
            }

            Thumbprint = thumbprint;
        }

        /// <summary> Initializes a new instance of CertificateDescription. </summary>
        /// <param name="thumbprint"> Thumbprint of the primary certificate. </param>
        /// <param name="thumbprintSecondary"> Thumbprint of the secondary certificate. </param>
        /// <param name="x509StoreName"> The local certificate store location. </param>
        internal CertificateDescription(string thumbprint, string thumbprintSecondary, StoreName? x509StoreName)
        {
            Thumbprint = thumbprint;
            ThumbprintSecondary = thumbprintSecondary;
            X509StoreName = x509StoreName;
        }

        /// <summary> Thumbprint of the primary certificate. </summary>
        public string Thumbprint { get; set; }
        /// <summary> Thumbprint of the secondary certificate. </summary>
        public string ThumbprintSecondary { get; set; }
        /// <summary> The local certificate store location. </summary>
        public StoreName? X509StoreName { get; set; }
    }
}
