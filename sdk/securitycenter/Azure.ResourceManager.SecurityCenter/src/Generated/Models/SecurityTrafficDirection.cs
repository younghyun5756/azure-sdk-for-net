// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> The rule&apos;s direction. </summary>
    public readonly partial struct SecurityTrafficDirection : IEquatable<SecurityTrafficDirection>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SecurityTrafficDirection"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SecurityTrafficDirection(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string InboundValue = "Inbound";
        private const string OutboundValue = "Outbound";

        /// <summary> Inbound. </summary>
        public static SecurityTrafficDirection Inbound { get; } = new SecurityTrafficDirection(InboundValue);
        /// <summary> Outbound. </summary>
        public static SecurityTrafficDirection Outbound { get; } = new SecurityTrafficDirection(OutboundValue);
        /// <summary> Determines if two <see cref="SecurityTrafficDirection"/> values are the same. </summary>
        public static bool operator ==(SecurityTrafficDirection left, SecurityTrafficDirection right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SecurityTrafficDirection"/> values are not the same. </summary>
        public static bool operator !=(SecurityTrafficDirection left, SecurityTrafficDirection right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="SecurityTrafficDirection"/>. </summary>
        public static implicit operator SecurityTrafficDirection(string value) => new SecurityTrafficDirection(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SecurityTrafficDirection other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SecurityTrafficDirection other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
