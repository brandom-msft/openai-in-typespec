// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace OpenAI.Images
{
    /// <summary> Enum for size in ImageVariationOptions. </summary>
    internal readonly partial struct ImageVariationOptionsSize : IEquatable<ImageVariationOptionsSize>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ImageVariationOptionsSize"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ImageVariationOptionsSize(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string _256x256Value = "256x256";
        private const string _512x512Value = "512x512";
        private const string _1024x1024Value = "1024x1024";

        /// <summary> 256x256. </summary>
        public static ImageVariationOptionsSize _256x256 { get; } = new ImageVariationOptionsSize(_256x256Value);
        /// <summary> 512x512. </summary>
        public static ImageVariationOptionsSize _512x512 { get; } = new ImageVariationOptionsSize(_512x512Value);
        /// <summary> 1024x1024. </summary>
        public static ImageVariationOptionsSize _1024x1024 { get; } = new ImageVariationOptionsSize(_1024x1024Value);
        /// <summary> Determines if two <see cref="ImageVariationOptionsSize"/> values are the same. </summary>
        public static bool operator ==(ImageVariationOptionsSize left, ImageVariationOptionsSize right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ImageVariationOptionsSize"/> values are not the same. </summary>
        public static bool operator !=(ImageVariationOptionsSize left, ImageVariationOptionsSize right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ImageVariationOptionsSize"/>. </summary>
        public static implicit operator ImageVariationOptionsSize(string value) => new ImageVariationOptionsSize(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ImageVariationOptionsSize other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ImageVariationOptionsSize other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
