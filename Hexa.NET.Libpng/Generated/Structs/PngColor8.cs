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
	/// To be documented.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct PngColor8
	{
		/// <summary>
		/// for use in red green blue files <br/>
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
		/// for use in grayscale files <br/>
		/// </summary>
		public byte Gray;

		/// <summary>
		/// for alpha channel files <br/>
		/// </summary>
		public byte Alpha;


		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe PngColor8(byte red = default, byte green = default, byte blue = default, byte gray = default, byte alpha = default)
		{
			Red = red;
			Green = green;
			Blue = blue;
			Gray = gray;
			Alpha = alpha;
		}


	}

}
