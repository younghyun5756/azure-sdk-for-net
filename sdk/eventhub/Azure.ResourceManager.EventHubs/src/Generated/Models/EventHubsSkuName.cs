// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.EventHubs.Models
{
    /// <summary> Name of this SKU. </summary>
    public readonly partial struct EventHubsSkuName : IEquatable<EventHubsSkuName>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="EventHubsSkuName"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public EventHubsSkuName(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string BasicValue = "Basic";
        private const string StandardValue = "Standard";
        private const string PremiumValue = "Premium";

        /// <summary> Basic. </summary>
        public static EventHubsSkuName Basic { get; } = new EventHubsSkuName(BasicValue);
        /// <summary> Standard. </summary>
        public static EventHubsSkuName Standard { get; } = new EventHubsSkuName(StandardValue);
        /// <summary> Premium. </summary>
        public static EventHubsSkuName Premium { get; } = new EventHubsSkuName(PremiumValue);
        /// <summary> Determines if two <see cref="EventHubsSkuName"/> values are the same. </summary>
        public static bool operator ==(EventHubsSkuName left, EventHubsSkuName right) => left.Equals(right);
        /// <summary> Determines if two <see cref="EventHubsSkuName"/> values are not the same. </summary>
        public static bool operator !=(EventHubsSkuName left, EventHubsSkuName right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="EventHubsSkuName"/>. </summary>
        public static implicit operator EventHubsSkuName(string value) => new EventHubsSkuName(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is EventHubsSkuName other && Equals(other);
        /// <inheritdoc />
        public bool Equals(EventHubsSkuName other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
