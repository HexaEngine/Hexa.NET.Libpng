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
	/// The type of a compression buffer list used by the write code. <br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct PngCompressionBuffer
	{
		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe PngCompressionBuffer* Next;

		/// <summary>
		/// actually zbuf_size <br/>
		/// </summary>
		public byte Output_0;


		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe PngCompressionBuffer(PngCompressionBuffer* next = default, byte* output = default)
		{
			Next = next;
			if (output != default(byte*))
			{
				Output_0 = output[0];
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe PngCompressionBuffer(PngCompressionBuffer* next = default, Span<byte> output = default)
		{
			Next = next;
			if (output != default(Span<byte>))
			{
				Output_0 = output[0];
			}
		}


	}

}
