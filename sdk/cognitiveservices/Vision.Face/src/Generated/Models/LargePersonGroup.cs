// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.CognitiveServices.Vision.Face.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Large person group object.
    /// </summary>
    public partial class LargePersonGroup
    {
        /// <summary>
        /// Initializes a new instance of the LargePersonGroup class.
        /// </summary>
        public LargePersonGroup()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the LargePersonGroup class.
        /// </summary>
        /// <param name="largePersonGroupId">LargePersonGroupId of the target
        /// large person groups</param>
        /// <param name="name">User defined name, maximum length is
        /// 128.</param>
        /// <param name="userData">User specified data. Length should not
        /// exceed 16KB.</param>
        /// <param name="recognitionModel">Possible values include:
        /// 'recognition_01', 'recognition_02', 'recognition_03',
        /// 'recognition_04'</param>
        public LargePersonGroup(string largePersonGroupId, string name, string userData = default(string), string recognitionModel = default(string))
        {
            LargePersonGroupId = largePersonGroupId;
            Name = name;
            UserData = userData;
            RecognitionModel = recognitionModel;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets largePersonGroupId of the target large person groups
        /// </summary>
        [JsonProperty(PropertyName = "largePersonGroupId")]
        public string LargePersonGroupId { get; set; }

        /// <summary>
        /// Gets or sets user defined name, maximum length is 128.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets user specified data. Length should not exceed 16KB.
        /// </summary>
        [JsonProperty(PropertyName = "userData")]
        public string UserData { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'recognition_01',
        /// 'recognition_02', 'recognition_03', 'recognition_04'
        /// </summary>
        [JsonProperty(PropertyName = "recognitionModel")]
        public string RecognitionModel { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (LargePersonGroupId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "LargePersonGroupId");
            }
            if (Name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Name");
            }
            if (LargePersonGroupId != null)
            {
                if (LargePersonGroupId.Length > 64)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "LargePersonGroupId", 64);
                }
                if (!System.Text.RegularExpressions.Regex.IsMatch(LargePersonGroupId, "^[a-z0-9-_]+$"))
                {
                    throw new ValidationException(ValidationRules.Pattern, "LargePersonGroupId", "^[a-z0-9-_]+$");
                }
            }
            if (Name != null)
            {
                if (Name.Length > 128)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "Name", 128);
                }
                if (Name.Length < 1)
                {
                    throw new ValidationException(ValidationRules.MinLength, "Name", 1);
                }
            }
            if (UserData != null)
            {
                if (UserData.Length > 16384)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "UserData", 16384);
                }
            }
        }
    }
}
