// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Attestation.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Attestation Providers List.
    /// </summary>
    public partial class AttestationProviderListResult
    {
        /// <summary>
        /// Initializes a new instance of the AttestationProviderListResult
        /// class.
        /// </summary>
        public AttestationProviderListResult()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AttestationProviderListResult
        /// class.
        /// </summary>
        /// <param name="value">Attestation Provider array.</param>
        public AttestationProviderListResult(IList<AttestationProvider> value = default(IList<AttestationProvider>))
        {
            Value = value;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets attestation Provider array.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<AttestationProvider> Value { get; set; }

    }
}