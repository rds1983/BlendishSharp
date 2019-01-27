using System;
using System.Runtime.InteropServices;

namespace OuiSharp
{
	partial class Oui
	{
		public const int UI_MAX_DATASIZE = 4096;
		public const int UI_MAX_DEPTH = 64;
		public const int UI_MAX_INPUT_EVENTS = 64;
		public const int UI_CLICK_THRESHOLD = 250;

		public const uint UI_USERMASK = 0xff000000;
		public const uint UI_ANY = 0xffffffff;

		public const int UI_ITEM_BOX_MODEL_MASK = 0x000007;
		public const int UI_ITEM_BOX_MASK = 0x00001F;
		public const int UI_ITEM_LAYOUT_MASK = 0x0003E0;
		public const int UI_ITEM_EVENT_MASK = 0x07FC00;
		public const int UI_ITEM_FROZEN = 0x080000;
		public const int UI_ITEM_DATA = 0x100000;
		public const int UI_ITEM_INSERTED = 0x200000;
		public const int UI_ITEM_HFIXED = 0x400000;
		public const int UI_ITEM_VFIXED = 0x800000;
		public const int UI_ITEM_FIXED_MASK = 0xC00000;
		public const uint UI_ITEM_COMPARE_MASK = UI_ITEM_BOX_MODEL_MASK | (UI_ITEM_LAYOUT_MASK & (int)~UIlayoutFlags.UI_BREAK) | UI_ITEM_EVENT_MASK | UI_USERMASK;
	}
}
