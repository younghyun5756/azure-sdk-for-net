// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> The RoleInstanceProperties. </summary>
    public partial class RoleInstanceProperties
    {
        /// <summary> Initializes a new instance of RoleInstanceProperties. </summary>
        internal RoleInstanceProperties()
        {
        }

        /// <summary> Initializes a new instance of RoleInstanceProperties. </summary>
        /// <param name="networkProfile"> Describes the network profile for the role instance. </param>
        /// <param name="instanceView"> The instance view of the role instance. </param>
        internal RoleInstanceProperties(RoleInstanceNetworkProfile networkProfile, RoleInstanceView instanceView)
        {
            NetworkProfile = networkProfile;
            InstanceView = instanceView;
        }

        /// <summary> Describes the network profile for the role instance. </summary>
        internal RoleInstanceNetworkProfile NetworkProfile { get; }
        /// <summary> Specifies the list of resource Ids for the network interfaces associated with the role instance. </summary>
        public IReadOnlyList<WritableSubResource> NetworkInterfaces
        {
            get => NetworkProfile.NetworkInterfaces;
        }

        /// <summary> The instance view of the role instance. </summary>
        public RoleInstanceView InstanceView { get; }
    }
}
