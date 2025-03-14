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
	/// The same data as above but encoded as CIE XYZ values.  When this data comes<br/>
	/// from chromaticities the sum of the Y values is assumed to be 1.0<br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct PngXYZ
	{
		/// <summary>
		/// To be documented.
		/// </summary>
		public int RedX;

		/// <summary>
		/// To be documented.
		/// </summary>
		public int RedY;

		/// <summary>
		/// To be documented.
		/// </summary>
		public int RedZ;

		/// <summary>
		/// To be documented.
		/// </summary>
		public int GreenX;

		/// <summary>
		/// To be documented.
		/// </summary>
		public int GreenY;

		/// <summary>
		/// To be documented.
		/// </summary>
		public int GreenZ;

		/// <summary>
		/// To be documented.
		/// </summary>
		public int BlueX;

		/// <summary>
		/// To be documented.
		/// </summary>
		public int BlueY;

		/// <summary>
		/// To be documented.
		/// </summary>
		public int BlueZ;


		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe PngXYZ(int redX = default, int redY = default, int redZ = default, int greenX = default, int greenY = default, int greenZ = default, int blueX = default, int blueY = default, int blueZ = default)
		{
			RedX = redX;
			RedY = redY;
			RedZ = redZ;
			GreenX = greenX;
			GreenY = greenY;
			GreenZ = greenZ;
			BlueX = blueX;
			BlueY = blueY;
			BlueZ = blueZ;
		}


	}

}
