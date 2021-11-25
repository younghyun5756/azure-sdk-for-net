// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.AI.Language.Conversations
{
    /// <summary> The type of a target service. </summary>
    public readonly partial struct TargetKind : IEquatable<TargetKind>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="TargetKind"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public TargetKind(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string LuisValue = "luis";
        private const string ConversationValue = "conversation";
        private const string QuestionAnsweringValue = "question_answering";
        private const string NonLinkedValue = "non_linked";

        /// <summary> luis. </summary>
        public static TargetKind Luis { get; } = new TargetKind(LuisValue);
        /// <summary> conversation. </summary>
        public static TargetKind Conversation { get; } = new TargetKind(ConversationValue);
        /// <summary> question_answering. </summary>
        public static TargetKind QuestionAnswering { get; } = new TargetKind(QuestionAnsweringValue);
        /// <summary> non_linked. </summary>
        public static TargetKind NonLinked { get; } = new TargetKind(NonLinkedValue);
        /// <summary> Determines if two <see cref="TargetKind"/> values are the same. </summary>
        public static bool operator ==(TargetKind left, TargetKind right) => left.Equals(right);
        /// <summary> Determines if two <see cref="TargetKind"/> values are not the same. </summary>
        public static bool operator !=(TargetKind left, TargetKind right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="TargetKind"/>. </summary>
        public static implicit operator TargetKind(string value) => new TargetKind(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is TargetKind other && Equals(other);
        /// <inheritdoc />
        public bool Equals(TargetKind other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
