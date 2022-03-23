// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Hci.Models
{
    /// <summary> Status of Arc Extension for a particular node in HCI Cluster. </summary>
    public partial class PerNodeExtensionState
    {
        /// <summary> Initializes a new instance of PerNodeExtensionState. </summary>
        internal PerNodeExtensionState()
        {
        }

        /// <summary> Initializes a new instance of PerNodeExtensionState. </summary>
        /// <param name="name"> Name of the node in HCI Cluster. </param>
        /// <param name="extension"> Fully qualified resource ID for the particular Arc Extension on this node. </param>
        /// <param name="state"> State of Arc Extension in this node. </param>
        internal PerNodeExtensionState(string name, string extension, NodeExtensionState? state)
        {
            Name = name;
            Extension = extension;
            State = state;
        }

        /// <summary> Name of the node in HCI Cluster. </summary>
        public string Name { get; }
        /// <summary> Fully qualified resource ID for the particular Arc Extension on this node. </summary>
        public string Extension { get; }
        /// <summary> State of Arc Extension in this node. </summary>
        public NodeExtensionState? State { get; }
    }
}
