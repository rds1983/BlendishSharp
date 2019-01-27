using System;
using System.Runtime.InteropServices;

namespace OuiSharp
{
	[StructLayout(LayoutKind.Sequential)]
	public struct UIhandleEntry
	{
		public uint key;
		public int item;
	}
}
