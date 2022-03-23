// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> An update to an Azure SQL job agent. </summary>
    internal partial class PatchableJobAgentData
    {
        /// <summary> Initializes a new instance of PatchableJobAgentData. </summary>
        public PatchableJobAgentData()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Resource tags. </summary>
        public IDictionary<string, string> Tags { get; }
    }
}
