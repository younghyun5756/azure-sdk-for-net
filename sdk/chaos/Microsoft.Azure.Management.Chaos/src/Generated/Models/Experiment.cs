// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Chaos.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Model that represents a Experiment resource.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class Experiment : TrackedResource
    {
        /// <summary>
        /// Initializes a new instance of the Experiment class.
        /// </summary>
        public Experiment()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Experiment class.
        /// </summary>
        /// <param name="location">The geo-location where the resource
        /// lives</param>
        /// <param name="steps">List of steps.</param>
        /// <param name="selectors">List of selectors.</param>
        /// <param name="id">Fully qualified resource ID for the resource. Ex -
        /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}</param>
        /// <param name="name">The name of the resource</param>
        /// <param name="type">The type of the resource. E.g.
        /// "Microsoft.Compute/virtualMachines" or
        /// "Microsoft.Storage/storageAccounts"</param>
        /// <param name="tags">Resource tags.</param>
        /// <param name="systemData">The system metadata of the experiment
        /// resource.</param>
        /// <param name="identity">The identity of the experiment
        /// resource.</param>
        /// <param name="startOnCreation">A boolean value that indicates if
        /// experiment should be started on creation or not.</param>
        public Experiment(string location, IList<Step> steps, IList<Selector> selectors, string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), SystemData systemData = default(SystemData), ResourceIdentity identity = default(ResourceIdentity), bool? startOnCreation = default(bool?))
            : base(location, id, name, type, tags)
        {
            SystemData = systemData;
            Identity = identity;
            Steps = steps;
            Selectors = selectors;
            StartOnCreation = startOnCreation;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the system metadata of the experiment resource.
        /// </summary>
        [JsonProperty(PropertyName = "systemData")]
        public SystemData SystemData { get; private set; }

        /// <summary>
        /// Gets or sets the identity of the experiment resource.
        /// </summary>
        [JsonProperty(PropertyName = "identity")]
        public ResourceIdentity Identity { get; set; }

        /// <summary>
        /// Gets or sets list of steps.
        /// </summary>
        [JsonProperty(PropertyName = "properties.steps")]
        public IList<Step> Steps { get; set; }

        /// <summary>
        /// Gets or sets list of selectors.
        /// </summary>
        [JsonProperty(PropertyName = "properties.selectors")]
        public IList<Selector> Selectors { get; set; }

        /// <summary>
        /// Gets or sets a boolean value that indicates if experiment should be
        /// started on creation or not.
        /// </summary>
        [JsonProperty(PropertyName = "properties.startOnCreation")]
        public bool? StartOnCreation { get; set; }

    }
}
