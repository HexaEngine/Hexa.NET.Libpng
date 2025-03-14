// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System;
using HexaGen.Runtime;
using System.Numerics;
using Hexa.NET.ZLib;

namespace Hexa.NET.Libpng
{
	/// <summary>
	/// The following decodes the appropriate chunks, and does error correction,<br/>
	/// then calls the appropriate callback for the chunk if it is valid.<br/>
	/// </summary>
	[Flags]
	public enum PngHandleResultCode : int
	{
		/// <summary>
		/// bad crc or known and bad format or too long <br/>
		/// </summary>
		HandledError = unchecked(0),

		/// <summary>
		/// not saved in the unknown chunk list <br/>
		/// </summary>
		HandledDiscarded = unchecked(1),

		/// <summary>
		/// saved in the unknown chunk list <br/>
		/// </summary>
		HandledSaved = unchecked(2),

		/// <summary>
		/// known, supported and handled without error <br/>
		/// </summary>
		HandledOk = unchecked(3),
	}
}
