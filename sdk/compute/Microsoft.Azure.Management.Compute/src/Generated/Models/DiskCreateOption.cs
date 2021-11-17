// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Compute.Models
{

    /// <summary>
    /// Defines values for DiskCreateOption.
    /// </summary>
    public static class DiskCreateOption
    {
        /// <summary>
        /// Create an empty data disk of a size given by diskSizeGB.
        /// </summary>
        public const string Empty = "Empty";
        /// <summary>
        /// Disk will be attached to a VM.
        /// </summary>
        public const string Attach = "Attach";
        /// <summary>
        /// Create a new disk from a platform image specified by the given
        /// imageReference or galleryImageReference.
        /// </summary>
        public const string FromImage = "FromImage";
        /// <summary>
        /// Create a disk by importing from a blob specified by a sourceUri in
        /// a storage account specified by storageAccountId.
        /// </summary>
        public const string Import = "Import";
        /// <summary>
        /// Create a new disk or snapshot by copying from a disk or snapshot
        /// specified by the given sourceResourceId.
        /// </summary>
        public const string Copy = "Copy";
        /// <summary>
        /// Create a new disk by copying from a backup recovery point.
        /// </summary>
        public const string Restore = "Restore";
        /// <summary>
        /// Create a new disk by obtaining a write token and using it to
        /// directly upload the contents of the disk.
        /// </summary>
        public const string Upload = "Upload";
        /// <summary>
        /// Create a new disk by using a deep copy process, where the resource
        /// creation is considered complete only after all data has been copied
        /// from the source.
        /// </summary>
        public const string CopyStart = "CopyStart";
        /// <summary>
        /// Similar to Import create option. Create a new TrustedLaunch or
        /// ConfidentialVM supported disk by importing additional VM guest
        /// state blob specified by securityDataUri in storage account
        /// specified by storageAccountId
        /// </summary>
        public const string ImportSecure = "ImportSecure";
        /// <summary>
        /// Similar to Upload create option. Create a new TrustedLaunch or
        /// ConfidentialVM supported disk and upload using write token in both
        /// disk and VM guest state blob
        /// </summary>
        public const string UploadPreparedSecure = "UploadPreparedSecure";
    }
}
