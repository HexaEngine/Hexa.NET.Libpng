// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using HexaGen.Runtime;
using System.Numerics;
using Hexa.NET.ZLib;

namespace Hexa.NET.Libpng
{
	/// <summary>
	/// Three color definitions.  The order of the red, green, and blue, (and the<br/>
	/// exact size) is not important, although the size of the fields need to<br/>
	/// be png_byte or png_uint_16 (as defined below).<br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct PngColor
	{
		/// <summary>
		/// To be documented.
		/// </summary>
		public byte Red;

		/// <summary>
		/// To be documented.
		/// </summary>
		public byte Green;

		/// <summary>
		/// To be documented.
		/// </summary>
		public byte Blue;


		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe PngColor(byte red = default, byte green = default, byte blue = default)
		{
			Red = red;
			Green = green;
			Blue = blue;
		}


	}

}
