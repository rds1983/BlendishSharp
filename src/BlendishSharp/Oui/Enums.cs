using System;
using System.Runtime.InteropServices;

namespace OuiSharp
{
	public enum UIitemState
	{
		UI_COLD = 0,
		UI_HOT = 1,
		UI_ACTIVE = 2,
		UI_FROZEN = 3
	}

	public enum UIboxFlags
	{
		UI_ROW = 0x002,
		UI_COLUMN = 0x003,
		UI_LAYOUT = 0x000,
		UI_FLEX = 0x002,
		UI_NOWRAP = 0x000,
		UI_WRAP = 0x004,
		UI_START = 0x008,
		UI_MIDDLE = 0x000,
		UI_END = 0x010,
		UI_JUSTIFY = 0x018
	}

	public enum UIlayoutFlags
	{
		UI_LEFT = 0x020,
		UI_TOP = 0x040,
		UI_RIGHT = 0x080,
		UI_DOWN = 0x100,
		UI_HFILL = 0x0a0,
		UI_VFILL = 0x140,
		UI_HCENTER = 0x000,
		UI_VCENTER = 0x000,
		UI_CENTER = 0x000,
		UI_FILL = 0x1e0,
		UI_BREAK = 0x200
	}

	public enum UIevent
	{
		UI_BUTTON0_DOWN = 0x0400,
		UI_BUTTON0_UP = 0x0800,
		UI_BUTTON0_HOT_UP = 0x1000,
		UI_BUTTON0_CAPTURE = 0x2000,
		UI_BUTTON2_DOWN = 0x4000,
		UI_SCROLL = 0x8000,
		UI_KEY_DOWN = 0x10000,
		UI_KEY_UP = 0x20000,
		UI_CHAR = 0x40000
	}

	public enum UIstate
	{
		UI_STATE_IDLE = 0,
		UI_STATE_CAPTURE
	}

	public enum UIstage
	{
		UI_STAGE_LAYOUT = 0,
		UI_STAGE_POST_LAYOUT,
		UI_STAGE_PROCESS
	}
}