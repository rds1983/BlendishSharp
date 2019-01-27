using System;
using System.Runtime.InteropServices;

namespace OuiSharp
{
	[StructLayout(LayoutKind.Sequential)]
	public struct UIinputEvent
	{
		public uint key;
		public uint mod;
		public UIevent _event_;

		public UIinputEvent(uint k, uint m, UIevent ev)
		{
			key = k;
			mod = m;
			_event_ = ev;
		}

		public static void uiAddInputEvent(UIinputEvent _event_)
		{
			if ((Oui.ui_context.eventcount) == (Oui.UI_MAX_INPUT_EVENTS)) return;
			Oui.ui_context.events[Oui.ui_context.eventcount++] = (UIinputEvent)(_event_);
		}
	}
}
