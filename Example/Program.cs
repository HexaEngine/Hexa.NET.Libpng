// See https://aka.ms/new-console-template for more information
using Hexa.NET.Libpng;
using HexaGen.Runtime;
using System.Runtime.InteropServices;

unsafe
{
    PngStruct* png = Libpng.CreateReadStruct(Libpng.PNG_LIBPNG_VER_STRING, null, null, null);
    
    PngInfo* info = Libpng.CreateInfoStruct(png);


    var fs = File.OpenRead("icon.png");

    unsafe void Read(PngStruct* png, byte* buffer, nuint size)
    {
        fs.ReadExactly(new Span<byte>(buffer, (int)size));
    }

    PngRwPtr readPtr = Read;
    GCHandle readHandle = GCHandle.Alloc(readPtr, GCHandleType.Normal);
    png->ReadDataFn = (void*)Utils.GetFunctionPointerForDelegate<PngRwPtr>(readPtr);
 
    Libpng.ReadInfo(png, info);

    uint width = Libpng.GetImageWidth(png, info);
    uint height = Libpng.GetImageHeight(png, info);
    byte colorType = Libpng.GetColorType(png, info);
    byte bitDepth = Libpng.GetBitDepth(png, info);

    if (bitDepth == 16)
        Libpng.SetStrip16(png);
  
    if (colorType == Libpng.PNG_COLOR_TYPE_PALETTE)
        Libpng.SetPaletteToRgb(png);

    // PNG_COLOR_TYPE_GRAY_ALPHA is always 8 or 16bit depth.
    if (colorType == Libpng.PNG_COLOR_TYPE_GRAY && bitDepth < 8)
        Libpng.SetExpandGray124To8(png);
   

    if (Libpng.GetValid(png, info, Libpng.PNG_INFO_tRNS) != 0)
        Libpng.SetTRNSToAlpha(png);

    if (colorType == Libpng.PNG_COLOR_TYPE_RGB ||
        colorType == Libpng.PNG_COLOR_TYPE_GRAY ||
        colorType == Libpng.PNG_COLOR_TYPE_PALETTE)
        Libpng.SetFiller(png, 0xFF, Libpng.PNG_FILLER_AFTER);

    if (colorType == Libpng.PNG_COLOR_TYPE_GRAY ||
        colorType == Libpng.PNG_COLOR_TYPE_GRAY_ALPHA)
        Libpng.SetGrayToRgb(png);

    Libpng.ReadUpdateInfo(png, info);

    byte** rowPointers = (byte**)NativeMemory.Alloc((nuint)(sizeof(byte*) * height));
    for (int y = 0; y < height; y++)
    {
        rowPointers[y] = (byte*)NativeMemory.Alloc(Libpng.GetRowbytes(png, info));
    }

    Libpng.ReadImage(png, rowPointers);

    readHandle.Free();
    fs.Close();

    Libpng.DestroyReadStruct(&png, &info, null);

    fs = File.Create("Output.png");

    png = Libpng.CreateWriteStruct(Libpng.PNG_LIBPNG_VER_STRING, null, null, null);

    info = Libpng.CreateInfoStruct(png);

    unsafe void Write(PngStruct* png, byte* buffer, nuint size)
    {
        fs.Write(new Span<byte>(buffer, (int)size));
    }

    PngRwPtr writePtr = Write;
    GCHandle writeHandle = GCHandle.Alloc(writePtr, GCHandleType.Normal);
    png->WriteDataFn = (void*)Utils.GetFunctionPointerForDelegate(writePtr);


    Libpng.SetIHDR(png, info, width, height, bitDepth, colorType, Libpng.PNG_INTERLACE_NONE, Libpng.PNG_COMPRESSION_TYPE_DEFAULT, Libpng.PNG_FILTER_TYPE_DEFAULT);
    Libpng.WriteInfo(png, info);

    Libpng.WriteImage(png, rowPointers);
    Libpng.WriteEnd(png, info);

    for (int y = 0; y < height; y++)
    {
        NativeMemory.Free(rowPointers[y]);
    }
    NativeMemory.Free(rowPointers);

    writeHandle.Free();
    fs.Close();

    Libpng.DestroyWriteStruct(&png, &info);
}

