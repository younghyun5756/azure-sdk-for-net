// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;
using Azure.ResourceManager.Compute;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> The list operation result. </summary>
    internal partial class CloudServiceListResult
    {
        /// <summary> Initializes a new instance of CloudServiceListResult. </summary>
        /// <param name="value"> The list of resources. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal CloudServiceListResult(IEnumerable<CloudServiceData> value)
        {
            Argument.AssertNotNull(value, nameof(value));

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of CloudServiceListResult. </summary>
        /// <param name="value"> The list of resources. </param>
        /// <param name="nextLink"> The URI to fetch the next page of resources. Use this to get the next page of resources. Do this till nextLink is null to fetch all the resources. </param>
        internal CloudServiceListResult(IReadOnlyList<CloudServiceData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> The list of resources. </summary>
        public IReadOnlyList<CloudServiceData> Value { get; }
        /// <summary> The URI to fetch the next page of resources. Use this to get the next page of resources. Do this till nextLink is null to fetch all the resources. </summary>
        public string NextLink { get; }
    }
}
