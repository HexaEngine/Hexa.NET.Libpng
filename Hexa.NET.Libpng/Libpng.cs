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

        public static string GetLibraryName()
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                return "libpng16";
            }
            
            return "libpng";
        }
    }
}
