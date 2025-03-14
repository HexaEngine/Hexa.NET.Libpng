namespace Hexa.NET.Libpng
{
    using HexaGen.Runtime;

    public unsafe static partial class Libpng
    {
        static Libpng()
        {
            InitApi();
        }


        [NativeName(NativeNameType.Const, "PNG_HEADER_VERSION_STRING")]
        [NativeName(NativeNameType.Value, "\" libpng version \"PNG_LIBPNG_VER_STRING\"\\n\"")]
        public const string PNG_HEADER_VERSION_STRING = $" libpng version {PNG_LIBPNG_VER_STRING}\n";

        public static string GetLibraryName()
        {
            return "libpng16";
        }
    }
}
