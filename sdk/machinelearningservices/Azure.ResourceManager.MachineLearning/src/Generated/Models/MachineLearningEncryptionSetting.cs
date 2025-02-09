// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> The MachineLearningEncryptionSetting. </summary>
    public partial class MachineLearningEncryptionSetting
    {
        /// <summary> Initializes a new instance of MachineLearningEncryptionSetting. </summary>
        /// <param name="status"> Indicates whether or not the encryption is enabled for the workspace. </param>
        /// <param name="keyVaultProperties"> Customer Key vault properties. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="keyVaultProperties"/> is null. </exception>
        public MachineLearningEncryptionSetting(MachineLearningEncryptionStatus status, MachineLearningEncryptionKeyVaultProperties keyVaultProperties)
        {
            Argument.AssertNotNull(keyVaultProperties, nameof(keyVaultProperties));

            Status = status;
            KeyVaultProperties = keyVaultProperties;
        }

        /// <summary> Initializes a new instance of MachineLearningEncryptionSetting. </summary>
        /// <param name="status"> Indicates whether or not the encryption is enabled for the workspace. </param>
        /// <param name="identity"> The identity that will be used to access the key vault for encryption at rest. </param>
        /// <param name="keyVaultProperties"> Customer Key vault properties. </param>
        internal MachineLearningEncryptionSetting(MachineLearningEncryptionStatus status, MachineLearningCmkIdentity identity, MachineLearningEncryptionKeyVaultProperties keyVaultProperties)
        {
            Status = status;
            Identity = identity;
            KeyVaultProperties = keyVaultProperties;
        }

        /// <summary> Indicates whether or not the encryption is enabled for the workspace. </summary>
        public MachineLearningEncryptionStatus Status { get; set; }
        /// <summary> The identity that will be used to access the key vault for encryption at rest. </summary>
        internal MachineLearningCmkIdentity Identity { get; set; }
        /// <summary> The ArmId of the user assigned identity that will be used to access the customer managed key vault. </summary>
        public ResourceIdentifier UserAssignedIdentity
        {
            get => Identity is null ? default : Identity.UserAssignedIdentity;
            set
            {
                if (Identity is null)
                    Identity = new MachineLearningCmkIdentity();
                Identity.UserAssignedIdentity = value;
            }
        }

        /// <summary> Customer Key vault properties. </summary>
        public MachineLearningEncryptionKeyVaultProperties KeyVaultProperties { get; set; }
    }
}
