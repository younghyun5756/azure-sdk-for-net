// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Network.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Network
{
    /// <summary> A class representing the P2SVpnGateway data model. </summary>
    public partial class P2SVpnGatewayData : NetworkResourceData
    {
        /// <summary> Initializes a new instance of P2SVpnGatewayData. </summary>
        public P2SVpnGatewayData()
        {
            P2SConnectionConfigurations = new ChangeTrackingList<P2SConnectionConfiguration>();
            CustomDnsServers = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of P2SVpnGatewayData. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="resourceType"> Resource type. </param>
        /// <param name="location"> Resource location. </param>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="virtualHub"> The VirtualHub to which the gateway belongs. </param>
        /// <param name="p2SConnectionConfigurations"> List of all p2s connection configurations of the gateway. </param>
        /// <param name="provisioningState"> The provisioning state of the P2S VPN gateway resource. </param>
        /// <param name="vpnGatewayScaleUnit"> The scale unit for this p2s vpn gateway. </param>
        /// <param name="vpnServerConfiguration"> The VpnServerConfiguration to which the p2sVpnGateway is attached to. </param>
        /// <param name="vpnClientConnectionHealth"> All P2S VPN clients&apos; connection health status. </param>
        /// <param name="customDnsServers"> List of all customer specified DNS servers IP addresses. </param>
        /// <param name="isRoutingPreferenceInternet"> Enable Routing Preference property for the Public IP Interface of the P2SVpnGateway. </param>
        internal P2SVpnGatewayData(string id, string name, string resourceType, string location, IDictionary<string, string> tags, string etag, WritableSubResource virtualHub, IList<P2SConnectionConfiguration> p2SConnectionConfigurations, ProvisioningState? provisioningState, int? vpnGatewayScaleUnit, WritableSubResource vpnServerConfiguration, VpnClientConnectionHealth vpnClientConnectionHealth, IList<string> customDnsServers, bool? isRoutingPreferenceInternet) : base(id, name, resourceType, location, tags)
        {
            Etag = etag;
            VirtualHub = virtualHub;
            P2SConnectionConfigurations = p2SConnectionConfigurations;
            ProvisioningState = provisioningState;
            VpnGatewayScaleUnit = vpnGatewayScaleUnit;
            VpnServerConfiguration = vpnServerConfiguration;
            VpnClientConnectionHealth = vpnClientConnectionHealth;
            CustomDnsServers = customDnsServers;
            IsRoutingPreferenceInternet = isRoutingPreferenceInternet;
        }

        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public string Etag { get; }
        /// <summary> The VirtualHub to which the gateway belongs. </summary>
        internal WritableSubResource VirtualHub { get; set; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier VirtualHubId
        {
            get => VirtualHub is null ? default : VirtualHub.Id;
            set
            {
                if (VirtualHub is null)
                    VirtualHub = new WritableSubResource();
                VirtualHub.Id = value;
            }
        }

        /// <summary> List of all p2s connection configurations of the gateway. </summary>
        public IList<P2SConnectionConfiguration> P2SConnectionConfigurations { get; }
        /// <summary> The provisioning state of the P2S VPN gateway resource. </summary>
        public ProvisioningState? ProvisioningState { get; }
        /// <summary> The scale unit for this p2s vpn gateway. </summary>
        public int? VpnGatewayScaleUnit { get; set; }
        /// <summary> The VpnServerConfiguration to which the p2sVpnGateway is attached to. </summary>
        internal WritableSubResource VpnServerConfiguration { get; set; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier VpnServerConfigurationId
        {
            get => VpnServerConfiguration is null ? default : VpnServerConfiguration.Id;
            set
            {
                if (VpnServerConfiguration is null)
                    VpnServerConfiguration = new WritableSubResource();
                VpnServerConfiguration.Id = value;
            }
        }

        /// <summary> All P2S VPN clients&apos; connection health status. </summary>
        public VpnClientConnectionHealth VpnClientConnectionHealth { get; }
        /// <summary> List of all customer specified DNS servers IP addresses. </summary>
        public IList<string> CustomDnsServers { get; }
        /// <summary> Enable Routing Preference property for the Public IP Interface of the P2SVpnGateway. </summary>
        public bool? IsRoutingPreferenceInternet { get; set; }
    }
}
