
using Microsoft.Xna.Framework;

namespace OuiSharp
{
	public unsafe class UIcontext
	{
		public uint item_capacity;
		public uint buffer_capacity;
		public ulong buttons;
		public ulong last_buttons;
		public Vector2 start_cursor = new Vector2();
		public Vector2 last_cursor = new Vector2();
		public Vector2 cursor = new Vector2();
		public Vector2 scroll = new Vector2();
		public int active_item;
		public int focus_item;
		public int last_hot_item;
		public int last_click_item;
		public int hot_item;
		public int state;
		public int stage;
		public uint active_key;
		public uint active_modifier;
		public uint active_button_modifier;
		public int last_timestamp;
		public int last_click_timestamp;
		public int clicks;
		public int count;
		public int last_count;
		public int eventcount;
		public uint datasize;
		public UIitem[] items;
		public byte* data;
		public UIitem[] last_items;
		public int* item_map;
		public UIinputEvent[] events = new UIinputEvent[Oui.UI_MAX_INPUT_EVENTS];
	}

/*	public static void uiMakeCurrent(UIcontext ctx)
	{
		Oui.ui_context = ctx;
	}

	public static void uiDestroyContext(UIcontext ctx)
	{
		if ((Oui.ui_context) == (ctx)) uiMakeCurrent(null);
		free(ctx.items);
		free(ctx.last_items);
		free(ctx.item_map);
		free(ctx.data);
		free(ctx);
	}*/
}
