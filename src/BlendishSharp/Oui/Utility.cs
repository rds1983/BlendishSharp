using System;
using System.Runtime.InteropServices;
using Microsoft.Xna.Framework;

namespace OuiSharp
{
	unsafe partial class Oui
	{
		public static int ui_max(int a, int b)
		{
			return (int)(((a) > (b)) ? a : b);
		}

		public static int ui_min(int a, int b)
		{
			return (int)(((a) < (b)) ? a : b);
		}

		public static float ui_maxf(float a, float b)
		{
			return (float)(((a) > (b)) ? a : b);
		}

		public static float ui_minf(float a, float b)
		{
			return (float)(((a) < (b)) ? a : b);
		}

		private static void uiAddInputEvent(UIinputEvent ev)
		{
		}

		public static void uiClear()
		{
			Oui.ui_context.last_count = (int)(Oui.ui_context.count);
			Oui.ui_context.count = (int)(0);
			Oui.ui_context.datasize = (uint)(0);
			Oui.ui_context.hot_item = (int)(-1);
			UIitem items = Oui.ui_context.items;
			Oui.ui_context.items = Oui.ui_context.last_items;
			Oui.ui_context.last_items = items;
			for (int i = (int)(0); (i) < (Oui.ui_context.last_count); ++i)
			{
				Oui.ui_context.item_map[i] = (int)(-1);
			}
		}

		public static UIcontext uiCreateContext(uint item_capacity, uint buffer_capacity)
		{
			UIcontext ctx = new UIcontext();
			ctx.item_capacity = (uint)(item_capacity);
			ctx.buffer_capacity = (uint)(buffer_capacity);
			ctx.stage = (int)(Oui.UI_STAGE_PROCESS);
			ctx.items = new UIitem[item_capacity];
			ctx.last_items = (UIitem)(malloc((ulong)(sizeof(UIitem) * item_capacity)));
			ctx.item_map = (int*)(malloc((ulong)(sizeof(int) * item_capacity)));
			if ((buffer_capacity) != 0)
			{
				ctx.data = (byte*)(malloc((ulong)(buffer_capacity)));
			}

			UIcontext oldctx = Oui.ui_context;
			uiMakeCurrent(ctx);
			uiClear();
			uiClearState();
			uiMakeCurrent(oldctx);
			return ctx;
		}

		public static UIcontext uiGetContext()
		{
			return Oui.ui_context;
		}

		public static void uiSetButton(uint button, uint mod, int enabled)
		{
			ulong mask = (ulong)(1 << button);
			Oui.ui_context.buttons = (ulong)((enabled) != 0 ? (Oui.ui_context.buttons | mask) : (Oui.ui_context.buttons & ~mask));
			Oui.ui_context.active_button_modifier = (uint)(mod);
		}

		public static void uiClearInputEvents()
		{
			Oui.ui_context.eventcount = (int)(0);
			Oui.ui_context.scroll.X = (int)(0);
			Oui.ui_context.scroll.Y = (int)(0);
		}

		public static void uiSetKey(uint key, uint mod, int enabled)
		{
			UIinputEvent _event_ = new UIinputEvent(key, mod, (enabled) != 0 ? UIevent.UI_KEY_DOWN : UIevent.UI_KEY_UP);
			uiAddInputEvent((UIinputEvent)(_event_));
		}

		public static void uiSetChar(uint value)
		{
			UIinputEvent _event_ = new UIinputEvent(value, 0, UIevent.UI_CHAR);
			uiAddInputEvent((UIinputEvent)(_event_));
		}

		public static void uiSetScroll(int x, int y)
		{
			Oui.ui_context.scroll.X += (int)(x);
			Oui.ui_context.scroll.Y += (int)(y);
		}

		public static Vector2 uiGetScroll()
		{
			return (Vector2)(Oui.ui_context.scroll);
		}

		public static bool uiGetLastButton(int button)
		{
			return (Oui.ui_context.last_buttons & (ulong)(1 << button)) != 0;
		}

		public static bool uiGetButton(int button)
		{
			return (Oui.ui_context.buttons & (ulong)(1 << button)) != 0;
		}

		public static bool uiButtonPressed(int button)
		{
			return (!uiGetLastButton((int)(button))) && ((uiGetButton(button)));
		}

		public static bool uiButtonReleased(int button)
		{
			return (uiGetLastButton((int)(button))) && (!uiGetButton(button));
		}

		public static void uiSetCursor(int x, int y)
		{
			Oui.ui_context.cursor.X = (int)(x);
			Oui.ui_context.cursor.Y = (int)(y);
		}

		public static Vector2 uiGetCursor()
		{
			return (Vector2)(Oui.ui_context.cursor);
		}

		public static Vector2 uiGetCursorStart()
		{
			return (Vector2)(Oui.ui_context.start_cursor);
		}

		public static Vector2 uiGetCursorDelta()
		{
			Vector2 result = new Vector2(Oui.ui_context.cursor.X - Oui.ui_context.last_cursor.X, Oui.ui_context.cursor.Y - Oui.ui_context.last_cursor.Y);
			return (Vector2)(result);
		}

		public static Vector2 uiGetCursorStartDelta()
		{
			Vector2 result = new Vector2(Oui.ui_context.cursor.X - Oui.ui_context.start_cursor.X, Oui.ui_context.cursor.Y - Oui.ui_context.start_cursor.Y);
			return (Vector2)(result);
		}

		public static uint uiGetKey()
		{
			return (uint)(Oui.ui_context.active_key);
		}

		public static uint uiGetModifier()
		{
			return (uint)(Oui.ui_context.active_modifier);
		}

		public static int uiGetItemCount()
		{
			return (int)(Oui.ui_context.count);
		}

		public static int uiGetLastItemCount()
		{
			return (int)(Oui.ui_context.last_count);
		}

		public static uint uiGetAllocSize()
		{
			return (uint)(Oui.ui_context.datasize);
		}

		public static UIitem uiItemPtr(int item)
		{
			return Oui.ui_context.items[item];
		}

		public static UIitem uiLastItemPtr(int item)
		{
			return Oui.ui_context.last_items[item];
		}

		public static int uiGetHotItem()
		{
			return (int)(Oui.ui_context.hot_item);
		}

		public static void uiFocus(int item)
		{
			Oui.ui_context.focus_item = (int)(item);
		}

		public static void uiValidateStateItems()
		{
			Oui.ui_context.last_hot_item = (int)(uiRecoverItem((int)(Oui.ui_context.last_hot_item)));
			Oui.ui_context.active_item = (int)(uiRecoverItem((int)(Oui.ui_context.active_item)));
			Oui.ui_context.focus_item = (int)(uiRecoverItem((int)(Oui.ui_context.focus_item)));
			Oui.ui_context.last_click_item = (int)(uiRecoverItem((int)(Oui.ui_context.last_click_item)));
		}

		public static int uiGetFocusedItem()
		{
			return (int)(Oui.ui_context.focus_item);
		}

		public static void uiBeginLayout()
		{
			uiClear();
			Oui.ui_context.stage = (int)(UI_STAGE_LAYOUT);
		}

		public static void uiClearState()
		{
			Oui.ui_context.last_hot_item = (int)(-1);
			Oui.ui_context.active_item = (int)(-1);
			Oui.ui_context.focus_item = (int)(-1);
			Oui.ui_context.last_click_item = (int)(-1);
		}

		public static int uiItem()
		{
			int idx = (int)(Oui.ui_context.count++);
			UIitem item = uiItemPtr((int)(idx));
			memset(item, (int)(0), (ulong)(sizeof(UIitem)));
			item.firstkid = (int)(-1);
			item.nextitem = (int)(-1);
			return (int)(idx);
		}

		public static void uiNotifyItem(int item, int _event_)
		{
			if (Oui.ui_context.handler == null) return;
			UIitem pitem = uiItemPtr((int)(item));
			if ((pitem.flags & _event_) != 0)
			{
				Oui.ui_context.handler((int)(item), (int)(_event_));
			}

		}

		public static int uiLastChild(int item)
		{
			item = (int)(uiFirstChild((int)(item)));
			if ((item) < (0)) return (int)(-1);
			while ((1) != 0)
			{
				int nextitem = (int)(uiNextSibling((int)(item))); if ((nextitem) < (0)) return (int)(item); item = (int)(nextitem);
			}
		}

		public static int uiAppend(int item, int sibling)
		{
			UIitem pitem = uiItemPtr((int)(item));
			UIitem psibling = uiItemPtr((int)(sibling));
			psibling.nextitem = (int)(pitem.nextitem);
			psibling.flags |= (uint)(UI_ITEM_INSERTED);
			pitem.nextitem = (int)(sibling);
			return (int)(sibling);
		}

		public static int uiInsert(int item, int child)
		{
			UIitem pparent = uiItemPtr((int)(item));
			UIitem pchild = uiItemPtr((int)(child));
			if ((pparent.firstkid) < (0))
			{
				pparent.firstkid = (int)(child); pchild.flags |= (uint)(UI_ITEM_INSERTED);
			}
			else
			{
				uiAppend((int)(uiLastChild((int)(item))), (int)(child));
			}

			return (int)(child);
		}

		public static int uiInsertFront(int item, int child)
		{
			return (int)(uiInsert((int)(item), (int)(child)));
		}

		public static int uiInsertBack(int item, int child)
		{
			UIitem pparent = uiItemPtr((int)(item));
			UIitem pchild = uiItemPtr((int)(child));
			pchild.nextitem = (int)(pparent.firstkid);
			pparent.firstkid = (int)(child);
			pchild.flags |= (uint)(UI_ITEM_INSERTED);
			return (int)(child);
		}

		public static void uiSetFrozen(int item, int enable)
		{
			UIitem pitem = uiItemPtr((int)(item));
			if ((enable) != 0) pitem.flags |= (int)(UI_ITEM_FROZEN); else pitem.flags &= (int)(~UI_ITEM_FROZEN);
		}

		public static void uiSetSize(int item, int w, int h)
		{
			UIitem pitem = uiItemPtr((int)(item));
			pitem.size[0] = (short)(w);
			pitem.size[1] = (short)(h);
			if (w == 0) pitem.flags &= (int)(~UI_ITEM_HFIXED); else pitem.flags |= (int)(UI_ITEM_HFIXED);
			if (h == 0) pitem.flags &= (int)(~UI_ITEM_VFIXED); else pitem.flags |= (int)(UI_ITEM_VFIXED);
		}

		public static int uiGetWidth(int item)
		{
			return (int)(uiItemPtr((int)(item)).size[0]);
		}

		public static int uiGetHeight(int item)
		{
			return (int)(uiItemPtr((int)(item)).size[1]);
		}

		public static void uiSetLayout(int item, uint flags)
		{
			UIitem pitem = uiItemPtr((int)(item));
			pitem.flags &= (int)(~UI_ITEM_LAYOUT_MASK);
			pitem.flags |= (int)(flags & UI_ITEM_LAYOUT_MASK);
		}

		public static uint uiGetLayout(int item)
		{
			return (uint)(uiItemPtr((int)(item)).flags & UI_ITEM_LAYOUT_MASK);
		}

		public static void uiSetBox(int item, uint flags)
		{
			UIitem pitem = uiItemPtr((int)(item));
			pitem.flags &= (int)(~UI_ITEM_BOX_MASK);
			pitem.flags |= (int)(flags & UI_ITEM_BOX_MASK);
		}

		public static uint uiGetBox(int item)
		{
			return (uint)(uiItemPtr((int)(item)).flags & UI_ITEM_BOX_MASK);
		}

		public static void uiSetMargins(int item, short l, short t, short r, short b)
		{
			UIitem pitem = uiItemPtr((int)(item));
			pitem.margins[0] = (short)(l);
			pitem.margins[1] = (short)(t);
			pitem.margins[2] = (short)(r);
			pitem.margins[3] = (short)(b);
		}

		public static short uiGetMarginLeft(int item)
		{
			return (short)(uiItemPtr((int)(item)).margins[0]);
		}

		public static short uiGetMarginTop(int item)
		{
			return (short)(uiItemPtr((int)(item)).margins[1]);
		}

		public static short uiGetMarginRight(int item)
		{
			return (short)(uiItemPtr((int)(item)).margins[2]);
		}

		public static short uiGetMarginDown(int item)
		{
			return (short)(uiItemPtr((int)(item)).margins[3]);
		}

		public static void uiArrange(int item, int dim)
		{
			UIitem pitem = uiItemPtr((int)(item));
			switch (pitem.flags & UI_ITEM_BOX_MODEL_MASK)
			{
				case UIboxFlags.UI_COLUMN | UIboxFlags.UI_WRAP:
					{
						if ((dim) != 0)
						{
							uiArrangeStacked(pitem, (int)(1), (int)(1)); short offset = (short)(uiArrangeWrappedImposedSqueezed(pitem, (int)(0))); pitem.size[0] = (short)(offset - pitem.margins[0]);
						}
					}
					break;
				case UIboxFlags.UI_ROW | UIboxFlags.UI_WRAP:
					{
						if (dim == 0)
						{
							uiArrangeStacked(pitem, (int)(0), (int)(1));
						}
						else
						{
							uiArrangeWrappedImposedSqueezed(pitem, (int)(1));
						}
					}
					break;
				case UIboxFlags.UI_COLUMN:
				case UIboxFlags.UI_ROW:
					{
						if ((pitem.flags & 1) == ((uint)(dim))) uiArrangeStacked(pitem, (int)(dim), (int)(0)); else uiArrangeImposedSqueezed(pitem, (int)(dim));
					}
					break;
				default:
					{
						uiArrangeImposed(pitem, (int)(dim));
					}
					break;
			}

			int kid = (int)(uiFirstChild((int)(item)));
			while ((kid) >= (0))
			{
				uiArrange((int)(kid), (int)(dim)); kid = (int)(uiNextSibling((int)(kid)));
			}
		}

		public static int uiMapItems(int item1, int item2)
		{
			UIitem pitem1 = uiLastItemPtr((int)(item1));
			if ((item2) == (-1))
			{
				return (int)(0);
			}

			UIitem pitem2 = uiItemPtr((int)(item2));
			if (uiCompareItems(pitem1, pitem2) == 0)
			{
				return (int)(0);
			}

			int count = (int)(0);
			int failed = (int)(0);
			int kid1 = (int)(pitem1.firstkid);
			int kid2 = (int)(pitem2.firstkid);
			while (kid1 != -1)
			{
				UIitem pkid1 = uiLastItemPtr((int)(kid1)); count++; if (uiMapItems((int)(kid1), (int)(kid2)) == 0)
				{
					failed = (int)(count); break;
				}
				kid1 = (int)(pkid1.nextitem); if (kid2 != -1)
				{
					kid2 = (int)(uiItemPtr((int)(kid2)).nextitem);
				}
			}
			if (((count) != 0) && ((failed) == (1)))
			{
				return (int)(0);
			}

			Oui.ui_context.item_map[item1] = (int)(item2);
			return (int)(1);
		}

		public static int uiRecoverItem(int olditem)
		{
			if ((olditem) == (-1)) return (int)(-1);
			return (int)(Oui.ui_context.item_map[olditem]);
		}

		public static void uiRemapItem(int olditem, int newitem)
		{
			Oui.ui_context.item_map[olditem] = (int)(newitem);
		}

		public static void uiEndLayout()
		{
			if ((Oui.ui_context.count) != 0)
			{
				uiComputeSize((int)(0), (int)(0)); uiArrange((int)(0), (int)(0)); uiComputeSize((int)(0), (int)(1)); uiArrange((int)(0), (int)(1)); if ((Oui.ui_context.last_count) != 0)
				{
					uiMapItems((int)(0), (int)(0));
				}
			}

			uiValidateStateItems();
			if ((Oui.ui_context.count) != 0)
			{
				uiUpdateHotItem();
			}

			Oui.ui_context.stage = (int)(UI_STAGE_POST_LAYOUT);
		}

		public static Rectangle uiGetRect(int item)
		{
			UIitem pitem = uiItemPtr((int)(item));
			Rectangle rc = new Rectangle(pitem.margins[0], pitem.margins[1], pitem.size[0], pitem.size[1]);
			return (Rectangle)(rc);
		}

		public static int uiFirstChild(int item)
		{
			return (int)(uiItemPtr((int)(item)).firstkid);
		}

		public static int uiNextSibling(int item)
		{
			return (int)(uiItemPtr((int)(item)).nextitem);
		}

		public static void* uiAllocHandle(int item, uint size)
		{
			UIitem pitem = uiItemPtr((int)(item));
			pitem.handle = Oui.ui_context.data + Oui.ui_context.datasize;
			pitem.flags |= (uint)(UI_ITEM_DATA);
			Oui.ui_context.datasize += (uint)(size);
			return pitem.handle;
		}

		public static void uiSetHandle(int item, void* handle)
		{
			UIitem pitem = uiItemPtr((int)(item));
			pitem.handle = handle;
		}

		public static void* uiGetHandle(int item)
		{
			return uiItemPtr((int)(item)).handle;
		}

		public static void uiSetEvents(int item, uint flags)
		{
			UIitem pitem = uiItemPtr((int)(item));
			pitem.flags &= (uint)(~UI_ITEM_EVENT_MASK);
			pitem.flags |= (uint)(flags & UI_ITEM_EVENT_MASK);
		}

		public static uint uiGetEvents(int item)
		{
			return (uint)(uiItemPtr((int)(item)).flags & UI_ITEM_EVENT_MASK);
		}

		public static void uiSetFlags(int item, uint flags)
		{
			UIitem pitem = uiItemPtr((int)(item));
			pitem.flags &= (uint)(~UI_USERMASK);
			pitem.flags |= (uint)(flags & UI_USERMASK);
		}

		public static uint uiGetFlags(int item)
		{
			return (uint)(uiItemPtr((int)(item)).flags & UI_USERMASK);
		}

		public static int uiContains(int item, int x, int y)
		{
			Rectangle rect = (Rectangle)(uiGetRect((int)(item)));
			x -= (int)(rect.X);
			y -= (int)(rect.Y);
			if (((((x) >= (0)) && ((y) >= (0))) && ((x) < (rect.w))) && ((y) < (rect.h))) return (int)(1);
			return (int)(0);
		}

		public static int uiFindItem(int item, int x, int y, uint flags, uint mask)
		{
			UIitem pitem = uiItemPtr((int)(item));
			if ((pitem.flags & UI_ITEM_FROZEN) != 0) return (int)(-1);
			if ((uiContains((int)(item), (int)(x), (int)(y))) != 0)
			{
				int best_hit = (int)(-1); int kid = (int)(uiFirstChild((int)(item))); while ((kid) >= (0))
				{
					int hit = (int)(uiFindItem((int)(kid), (int)(x), (int)(y), (uint)(flags), (uint)(mask))); if ((hit) >= (0))
					{
						best_hit = (int)(hit);
					}
					kid = (int)(uiNextSibling((int)(kid)));
				}
				if ((best_hit) >= (0))
				{
					return (int)(best_hit);
				}
				if ((((mask) == (UI_ANY)) && (((flags) == (UI_ANY)) || ((pitem.flags & flags) != 0))) || ((pitem.flags & flags) == (mask)))
				{
					return (int)(item);
				}
			}

			return (int)(-1);
		}

		public static void uiUpdateHotItem()
		{
			if (Oui.ui_context.count == 0) return;
			Oui.ui_context.hot_item = (int)(uiFindItem((int)(0), (int)(Oui.ui_context.cursor.X), (int)(Oui.ui_context.cursor.Y), (uint)((UIevent.UI_BUTTON0_DOWN | UIevent.UI_BUTTON0_UP | UIevent.UI_BUTTON0_HOT_UP | UIevent.UI_BUTTON0_CAPTURE) | (UIevent.UI_BUTTON2_DOWN)), (uint)(UI_ANY)));
		}

		public static int uiGetClicks()
		{
			return (int)(Oui.ui_context.clicks);
		}

		public static void uiProcess(int timestamp)
		{
			if ((Oui.ui_context.stage) == (Oui.UI_STAGE_PROCESS))
			{
				uiUpdateHotItem();
			}

			Oui.ui_context.stage = (int)(Oui.UI_STAGE_PROCESS);
			if (Oui.ui_context.count == 0)
			{
				uiClearInputEvents(); return;
			}

			int hot_item = (int)(Oui.ui_context.last_hot_item);
			int active_item = (int)(Oui.ui_context.active_item);
			int focus_item = (int)(Oui.ui_context.focus_item);
			if ((focus_item) >= (0))
			{
				for (int i = (int)(0); ; (i) < (Oui.ui_context._event_count); ++i) {
					Oui.ui_context.active_key = (uint)(Oui.ui_context._event_s[i].key); Oui.ui_context.active_modifier = (uint)(Oui.ui_context._event_s[i].mod); uiNotifyItem((int)(focus_item), (int)(Oui.ui_context._event_s[i]._event_));
				}
			}
			else
			{
				Oui.ui_context.focus_item = (int)(-1);
			}

			if (((Oui.ui_context.scroll.X) != 0) || ((Oui.ui_context.scroll.Y) != 0))
			{
				int scroll_item = (int)(uiFindItem((int)(0), (int)(Oui.ui_context.cursor.X), (int)(Oui.ui_context.cursor.Y), (uint)(UIevent.UI_SCROLL), (uint)(UI_ANY))); if ((scroll_item) >= (0))
				{
					uiNotifyItem((int)(scroll_item), (int)(UIevent.UI_SCROLL));
				}
			}

			uiClearInputEvents();
			int hot = (int)(Oui.ui_context.hot_item);
			switch (Oui.ui_context.state)
			{
				default:
				case UIstate.UI_STATE_IDLE:
					{
						Oui.ui_context.start_cursor = (Vector2)(Oui.ui_context.cursor); if ((uiGetButton((uint)(0))) != 0)
						{
							hot_item = (int)(-1); active_item = (int)(hot); if (active_item != focus_item)
							{
								focus_item = (int)(-1); Oui.ui_context.focus_item = (int)(-1);
							}
							if ((active_item) >= (0))
							{
								if (((timestamp - Oui.ui_context.last_click_timestamp) > (UI_CLICK_THRESHOLD)) || (Oui.ui_context.last_click_item != active_item))
								{
									Oui.ui_context.clicks = (int)(0);
								}
								Oui.ui_context.clicks++; Oui.ui_context.last_click_timestamp = (int)(timestamp); Oui.ui_context.last_click_item = (int)(active_item); Oui.ui_context.active_modifier = (uint)(Oui.ui_context.active_button_modifier); uiNotifyItem((int)(active_item), (int)(UIevent.UI_BUTTON0_DOWN));
							}
							Oui.ui_context.state = (int)(UIstate.UI_STATE_CAPTURE);
						}
						else if (((uiGetButton((uint)(2))) != 0) && (uiGetLastButton((int)(2)) == 0))
						{
							hot_item = (int)(-1); hot = (int)(uiFindItem((int)(0), (int)(Oui.ui_context.cursor.X), (int)(Oui.ui_context.cursor.Y), (uint)(UIevent.UI_BUTTON2_DOWN), (uint)(UI_ANY))); if ((hot) >= (0))
							{
								Oui.ui_context.active_modifier = (uint)(Oui.ui_context.active_button_modifier); uiNotifyItem((int)(hot), (int)(UIevent.UI_BUTTON2_DOWN));
							}
						}
						else
						{
							hot_item = (int)(hot);
						}
					}
					break;
				case UIstate.UI_STATE_CAPTURE:
					{
						if (uiGetButton((uint)(0)) == 0)
						{
							if ((active_item) >= (0))
							{
								Oui.ui_context.active_modifier = (uint)(Oui.ui_context.active_button_modifier); uiNotifyItem((int)(active_item), (int)(UIevent.UI_BUTTON0_UP)); if ((active_item) == (hot))
								{
									uiNotifyItem((int)(active_item), (int)(UIevent.UI_BUTTON0_HOT_UP));
								}
							}
							active_item = (int)(-1); Oui.ui_context.state = (int)(UIstate.UI_STATE_IDLE);
						}
						else
						{
							if ((active_item) >= (0))
							{
								Oui.ui_context.active_modifier = (uint)(Oui.ui_context.active_button_modifier); uiNotifyItem((int)(active_item), (int)(UIevent.UI_BUTTON0_CAPTURE));
							}
							if ((hot) == (active_item)) hot_item = (int)(hot); else hot_item = (int)(-1);
						}
					}
					break;
			}

			Oui.ui_context.last_cursor = (Vector2)(Oui.ui_context.cursor);
			Oui.ui_context.last_hot_item = (int)(hot_item);
			Oui.ui_context.active_item = (int)(active_item);
			Oui.ui_context.last_timestamp = (int)(timestamp);
			Oui.ui_context.last_buttons = (ulong)(Oui.ui_context.buttons);
		}

		public static int uiIsActive(int item)
		{
			return (int)((Oui.ui_context.active_item) == (item) ? 1 : 0);
		}

		public static int uiIsHot(int item)
		{
			return (int)((Oui.ui_context.last_hot_item) == (item) ? 1 : 0);
		}

		public static int uiIsFocused(int item)
		{
			return (int)((Oui.ui_context.focus_item) == (item) ? 1 : 0);
		}

		public static int uiGetState(int item)
		{
			UIitem pitem = uiItemPtr((int)(item));
			if ((pitem.flags & UI_ITEM_FROZEN) != 0) return (int)(UIitemState.UI_FROZEN);
			if ((uiIsFocused((int)(item))) != 0)
			{
				if ((pitem.flags & (UIevent.UI_KEY_DOWN | UIevent.UI_CHAR | UIevent.UI_KEY_UP)) != 0) return (int)(UIitemState.UI_ACTIVE);
			}

			if ((uiIsActive((int)(item))) != 0)
			{
				if ((pitem.flags & (UIevent.UI_BUTTON0_CAPTURE | UIevent.UI_BUTTON0_UP)) != 0) return (int)(UIitemState.UI_ACTIVE); if (((pitem.flags & UIevent.UI_BUTTON0_HOT_UP) != 0) && ((uiIsHot((int)(item))) != 0)) return (int)(UIitemState.UI_ACTIVE); return (int)(UIitemState.UI_COLD);
			}
			else if ((uiIsHot((int)(item))) != 0)
			{
				return (int)(UIitemState.UI_HOT);
			}

			return (int)(UIitemState.UI_COLD);
		}
	}
}
