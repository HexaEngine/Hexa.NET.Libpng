// See https://aka.ms/new-console-template for more information
using HexaGen;
using HexaGen.Patching;

List<string> headers = ["include/main.h"];
List<string> allowedHeaders = [..Directory.GetFiles("include")];
allowedHeaders.RemoveAll(x => x.Contains("zlib.h")|| x.Contains("zconf.h"));

BatchGenerator batch = new();
batch
    .Setup<CsCodeGenerator>("generator.json")
    .AddPrePatch(new NamingPatch(["Png"], NamingPatchOptions.None))
    .Generate(headers, "../../../../Hexa.NET.Libpng/Generated",allowedHeaders);