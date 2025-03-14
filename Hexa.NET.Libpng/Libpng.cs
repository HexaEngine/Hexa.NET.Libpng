namespace Hexa.NET.Libpng
{
    using HexaGen.Runtime;
    using System.Diagnostics;
    using System.Runtime.InteropServices;

    public static class LibpngConfig
    {
        public static bool AotStaticLink;
    }

    public unsafe static partial class Libpng
    {
        static Libpng()
        {
            if (LibpngConfig.AotStaticLink)
            {
                InitApi(new NativeLibraryContext(Process.GetCurrentProcess().MainModule!.BaseAddress));
            }
            else
            {
                InitApi(new NativeLibraryContext(LibraryLoader.LoadLibrary(GetLibraryName, null)));
            }
        }


        [NativeName(NativeNameType.Const, "PNG_HEADER_VERSION_STRING")]
        [NativeName(NativeNameType.Value, "\" libpng version \"PNG_LIBPNG_VER_STRING\"\\n\"")]
        public const string PNG_HEADER_VERSION_STRING = $" libpng version {PNG_LIBPNG_VER_STRING}\n";


        public const int PNG_COLOR_TYPE_PALETTE = (PNG_COLOR_MASK_COLOR | PNG_COLOR_MASK_PALETTE);
        public const int PNG_COLOR_TYPE_RGB = (PNG_COLOR_MASK_COLOR);
        public const int PNG_COLOR_TYPE_RGB_ALPHA = (PNG_COLOR_MASK_COLOR | PNG_COLOR_MASK_ALPHA);
        public const int PNG_COLOR_TYPE_GRAY_ALPHA = (PNG_COLOR_MASK_ALPHA);
        /* aliases */
        public const int PNG_COLOR_TYPE_RGBA = PNG_COLOR_TYPE_RGB_ALPHA;
        public const int PNG_COLOR_TYPE_GA = PNG_COLOR_TYPE_GRAY_ALPHA;

        public static string GetLibraryName()
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                return "libpng16d";
            }
            
            return "libpng";
        }
    }
}
