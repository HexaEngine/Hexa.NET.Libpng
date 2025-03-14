using HexaGen.Runtime;
using System.Diagnostics;

namespace Hexa.NET.Libpng
{
    /// <summary>
    /// To be documented.
    /// </summary>
    [NativeName(NativeNameType.Typedef, "FILE")]
#if NET5_0_OR_GREATER
    [DebuggerDisplay("{DebuggerDisplay,nq}")]
#endif
    public readonly partial struct FILE : IEquatable<FILE>
    {
        public FILE(nint handle)
        { Handle = handle; }

        public nint Handle { get; }
        public bool IsNull => Handle == 0;
        public static FILE Null => new FILE(0);

        public static implicit operator FILE(nint handle) => new FILE(handle);

        public static bool operator ==(FILE left, FILE right) => left.Handle == right.Handle;

        public static bool operator !=(FILE left, FILE right) => left.Handle != right.Handle;

        public static bool operator ==(FILE left, nint right) => left.Handle == right;

        public static bool operator !=(FILE left, nint right) => left.Handle != right;

        public bool Equals(FILE other) => Handle == other.Handle;

        /// <inheritdoc/>
        public override bool Equals(object? obj) => obj is FILE handle && Equals(handle);

        /// <inheritdoc/>
        public override int GetHashCode() => Handle.GetHashCode();

#if NET5_0_OR_GREATER
        private string DebuggerDisplay => string.Format("PngUnknownChunkpp [0x{0}]", Handle.ToString("X"));
#endif
    }
}