using System;
using System.Runtime.InteropServices;

namespace OuiSharp
{
	public class UIitem
	{
		public object handle;
		public int flags;
		public int firstkid;
		public int nextitem;
		public int[] margins = new int[4];
		public int[] size = new int[2];

/*		private static UIitem uiItemPtr(int index)
		{

		}

		private static int uiNextSibling(int index)
		{
		}


		public void uiComputeImposedSize(int dim)
		{
			int wdim = (int)(dim + 2);
			short need_size = (short)(0);
			int kid = (int)(firstkid);
			while ((kid) >= (0))
			{
				UIitem pkid = uiItemPtr((int)(kid));
				int kidsize = (int)(pkid.margins[dim] + pkid.size[dim] + pkid.margins[wdim]);
				need_size = (short)(Oui.ui_max((int)(need_size), (int)(kidsize)));
				kid = (int)(uiNextSibling((int)(kid)));
			}

			size[dim] = (short)(need_size);
		}

		public void uiComputeStackedSize(int dim)
		{
			int wdim = (int)(dim + 2);
			short need_size = (short)(0);
			int kid = (int)(firstkid);
			while ((kid) >= (0))
			{
				UIitem pkid = uiItemPtr((int)(kid));
				need_size += (short)(pkid.margins[dim] + pkid.size[dim] + pkid.margins[wdim]);
				kid = (int)(uiNextSibling((int)(kid)));
			}

			size[dim] = (short)(need_size);
		}

		public void uiComputeWrappedStackedSize(int dim)
		{
			int wdim = (int)(dim + 2);
			short need_size = (short)(0);
			short need_size2 = (short)(0);
			int kid = (int)(firstkid);
			while ((kid) >= (0))
			{
				UIitem pkid = uiItemPtr((int)(kid));
				if ((pkid.flags & (uint)UIlayoutFlags.UI_BREAK) != 0)
				{
					need_size2 = (short)(Oui.ui_max((int)(need_size2), (int)(need_size)));
					need_size = (short)(0);
				}

				need_size += (short)(pkid.margins[dim] + pkid.size[dim] + pkid.margins[wdim]);
				kid = (int)(uiNextSibling((int)(kid)));
			}

			size[dim] = (short)(Oui.ui_max((int)(need_size2), (int)(need_size)));
		}

		public void uiComputeWrappedSize(int dim)
		{
			int wdim = (int)(dim + 2);
			short need_size = (short)(0);
			short need_size2 = (short)(0);
			int kid = (int)(firstkid);
			while ((kid) >= (0))
			{
				UIitem pkid = uiItemPtr((int)(kid));
				if ((pkid.flags & (uint)UIlayoutFlags.UI_BREAK) != 0)
				{
					need_size2 += (short)(need_size);
					need_size = (short)(0);
				}

				int kidsize = (int)(pkid.margins[dim] + pkid.size[dim] + pkid.margins[wdim]);
				need_size = (short)(Oui.ui_max((int)(need_size), (int)(kidsize)));
				kid = (int)(uiNextSibling((int)(kid)));
			}

			size[dim] = (short)(need_size2 + need_size);
		}

		public void uiArrangeStacked(int dim, int wrap)
		{
			int wdim = (int)(dim + 2);
			short space = (short)(size[dim]);
			float max_x2 = (float)((float)(margins[dim]) + (float)(space));
			int start_kid = (int)(firstkid);
			while ((start_kid) >= (0))
			{
				short used = (short)(0);
				int count = (int)(0);
				int squeezed_count = (int)(0);
				int total = (int)(0);
				int hardbreak = (int)(0);
				int kid = (int)(start_kid);
				int end_kid = (int)(-1);
				while ((kid) >= (0))
				{
					UIitem pkid = uiItemPtr((int)(kid));
					int flags = (int)((pkid.flags & Oui.UI_ITEM_LAYOUT_MASK) >> dim);
					int fflags = (int)((pkid.flags & Oui.UI_ITEM_FIXED_MASK) >> dim);
					short extend = (short)(used);
					if ((flags & (uint)UIlayoutFlags.UI_HFILL) == (uint)(UIlayoutFlags.UI_HFILL))
					{
						count++;
						extend += (short)(pkid.margins[dim] + pkid.margins[wdim]);
					}
					else
					{
						if ((fflags & Oui.UI_ITEM_HFIXED) != Oui.UI_ITEM_HFIXED) squeezed_count++;
						extend += (short)(pkid.margins[dim] + pkid.size[dim] + pkid.margins[wdim]);
					}

					if (((wrap) != 0) && (((total) != 0) &&
										  (((extend) > (space)) || ((pkid.flags & (uint)UIlayoutFlags.UI_BREAK) != 0))))
					{
						end_kid = (int)(kid);
						hardbreak = (int)((pkid.flags & (uint)UIlayoutFlags.UI_BREAK) == (uint)(UIlayoutFlags.UI_BREAK) ? 1 : 0);
						pkid.flags |= (uint)(UIlayoutFlags.UI_BREAK);
						break;
					}
					else
					{
						used = (short)(extend);
						kid = (int)(uiNextSibling((int)(kid)));
					}

					total++;
				}

				int extra_space = (int)(space - used);
				float filler = (float)(0.0f);
				float spacer = (float)(0.0f);
				float extra_margin = (float)(0.0f);
				float eater = (float)(0.0f);
				if ((extra_space) > (0))
				{
					if ((count) != 0)
					{
						filler = (float)((float)(extra_space) / (float)(count));
					}
					else if ((total) != 0)
					{
						switch (flags & (uint)UIboxFlags.UI_JUSTIFY)
						{
							default:
								{
									extra_margin = (float)(extra_space / 2.0f);
								}
								break;
							case (uint)UIboxFlags.UI_JUSTIFY:
								{
									if ((wrap == 0) || ((end_kid != -1) && (hardbreak == 0)))
										spacer = (float)((float)(extra_space) / (float)(total - 1));
								}
								break;
							case (uint)UIboxFlags.UI_START:
								{
								}
								break;
							case (uint)UIboxFlags.UI_END:
								{
									extra_margin = (float)(extra_space);
								}
								break;
						}
					}
				}
				else if ((wrap == 0) && ((extra_space) < (0)))
				{
					eater = (float)((float)(extra_space) / (float)(squeezed_count));
				}

				float x = (float)(margins[dim]);
				float x1 = 0;
				kid = (int)(start_kid);
				while (kid != end_kid)
				{
					short ix0 = 0;
					short ix1 = 0;
					UIitem pkid = uiItemPtr((int)(kid));
					int flags = (int)((pkid.flags & Oui.UI_ITEM_LAYOUT_MASK) >> dim);
					int fflags = (int)((pkid.flags & Oui.UI_ITEM_FIXED_MASK) >> dim);
					x += (float)((float)(pkid.margins[dim]) + extra_margin);
					if ((flags & (uint)UIlayoutFlags.UI_HFILL) == (uint)(UIlayoutFlags.UI_HFILL))
					{
						x1 = (float)(x + filler);
					}
					else if ((fflags & Oui.UI_ITEM_HFIXED) == (Oui.UI_ITEM_HFIXED))
					{
						x1 = (float)(x + (float)(pkid.size[dim]));
					}
					else
					{
						x1 = (float)(x + Oui.ui_maxf((float)(0.0f), (float)((float)(pkid.size[dim]) + eater)));
					}

					ix0 = ((short)(x));
					if ((wrap) != 0)
						ix1 = ((short)(Oui.ui_minf((float)(max_x2 - (float)(pkid.margins[wdim])), (float)(x1))));
					else ix1 = ((short)(x1));
					pkid.margins[dim] = (short)(ix0);
					pkid.size[dim] = (short)(ix1 - ix0);
					x = (float)(x1 + (float)(pkid.margins[wdim]));
					kid = (int)(uiNextSibling((int)(kid)));
					extra_margin = (float)(spacer);
				}

				start_kid = (int)(end_kid);
			}
		}

		public void uiArrangeImposedRange(int dim, int start_kid, int end_kid, short offset, short space)
		{
			int wdim = (int)(dim + 2);
			int kid = (int)(start_kid);
			while (kid != end_kid)
			{
				UIitem pkid = uiItemPtr((int)(kid));
				int flags = (int)((pkid.flags & Oui.UI_ITEM_LAYOUT_MASK) >> dim);
				switch (flags & (uint)UIlayoutFlags.UI_HFILL)
				{
					default: break;
					case (uint)UIlayoutFlags.UI_HCENTER:
						{
							pkid.margins[dim] += (short)((space - pkid.size[dim]) / 2 - pkid.margins[wdim]);
						}
						break;
					case (uint)UIlayoutFlags.UI_RIGHT:
						{
							pkid.margins[dim] = (short)(space - pkid.size[dim] - pkid.margins[wdim]);
						}
						break;
					case (uint)UIlayoutFlags.UI_HFILL:
						{
							pkid.size[dim] = (short)(Oui.ui_max((int)(0),
								(int)(space - pkid.margins[dim] - pkid.margins[wdim])));
						}
						break;
				}

				pkid.margins[dim] += (short)(offset);
				kid = (int)(uiNextSibling((int)(kid)));
			}
		}

		public void uiArrangeImposed(int dim)
		{
			uiArrangeImposedRange((int)(dim), (int)(firstkid), (int)(-1), (short)(margins[dim]), (short)(size[dim]));
		}

		public void uiArrangeImposedSqueezedRange(int dim, int start_kid, int end_kid, short offset, short space)
		{
			int wdim = (int)(dim + 2);
			int kid = (int)(start_kid);
			while (kid != end_kid)
			{
				UIitem pkid = uiItemPtr((int)(kid));
				int flags = (int)((pkid.flags & Oui.UI_ITEM_LAYOUT_MASK) >> dim);
				short min_size =
					(short)(Oui.ui_max((int)(0), (int)(space - pkid.margins[dim] - pkid.margins[wdim])));
				switch (flags & (uint)UIlayoutFlags.UI_HFILL)
				{
					default:
						{
							pkid.size[dim] = (short)(Oui.ui_min((int)(pkid.size[dim]), (int)(min_size)));
						}
						break;
					case (uint)UIlayoutFlags.UI_HCENTER:
						{
							pkid.size[dim] = (short)(Oui.ui_min((int)(pkid.size[dim]), (int)(min_size)));
							pkid.margins[dim] += (short)((space - pkid.size[dim]) / 2 - pkid.margins[wdim]);
						}
						break;
					case (uint)UIlayoutFlags.UI_RIGHT:
						{
							pkid.size[dim] = (short)(Oui.ui_min((int)(pkid.size[dim]), (int)(min_size)));
							pkid.margins[dim] = (short)(space - pkid.size[dim] - pkid.margins[wdim]);
						}
						break;
					case (uint)UIlayoutFlags.UI_HFILL:
						{
							pkid.size[dim] = (short)(min_size);
						}
						break;
				}

				pkid.margins[dim] += (short)(offset);
				kid = (int)(uiNextSibling((int)(kid)));
			}
		}

		public void uiArrangeImposedSqueezed(int dim)
		{
			uiArrangeImposedSqueezedRange((int)(dim), (int)(firstkid), (int)(-1), (short)(margins[dim]), (short)(size[dim]));
		}

		public short uiArrangeWrappedImposedSqueezed(int dim)
		{
			int wdim = (int)(dim + 2);
			short offset = (short)(margins[dim]);
			short need_size = (short)(0);
			int kid = (int)(firstkid);
			int start_kid = (int)(kid);
			while ((kid) >= (0))
			{
				UIitem pkid = uiItemPtr((int)(kid));
				if ((pkid.flags & (uint)UIlayoutFlags.UI_BREAK) != 0)
				{
					uiArrangeImposedSqueezedRange((int)(dim), (int)(start_kid), (int)(kid), (short)(offset), (short)(need_size));
					offset += (short)(need_size);
					start_kid = (int)(kid);
					need_size = (short)(0);
				}

				int kidsize = (int)(pkid.margins[dim] + pkid.size[dim] + pkid.margins[wdim]);
				need_size = (short)(Oui.ui_max((int)(need_size), (int)(kidsize)));
				kid = (int)(uiNextSibling((int)(kid)));
			}

			uiArrangeImposedSqueezedRange((int)(dim), (int)(start_kid), (int)(-1), (short)(offset), (short)(need_size));
			offset += (short)(need_size);
			return (short)(offset);
		}

		public bool uiCompareItems(UIitem item1, UIitem item2)
		{
			return ((item1.flags & (uint)Oui.UI_ITEM_COMPARE_MASK) == (item2.flags & (uint)Oui.UI_ITEM_COMPARE_MASK));
		}

		public static void uiComputeSize(int item, int dim)
		{
			UIitem pitem = uiItemPtr((int)(item));
			int kid = (int)(pitem.firstkid);
			while ((kid) >= (0))
			{
				uiComputeSize((int)(kid), (int)(dim)); kid = (int)(uiNextSibling((int)(kid)));
			}
			if ((pitem.size[dim]) != 0) return;
			switch (pitem.flags & Oui.UI_ITEM_BOX_MODEL_MASK)
			{
				case UIboxFlags.UI_COLUMN | UIboxFlags.UI_WRAP:
					{
						if ((dim) != 0) uiComputeStackedSize(pitem, (int)(1)); else uiComputeImposedSize(pitem, (int)(0));
					}
					break;
				case UIboxFlags.UI_ROW | UIboxFlags.UI_WRAP:
					{
						if (dim == 0) uiComputeWrappedStackedSize(pitem, (int)(0)); else uiComputeWrappedSize(pitem, (int)(1));
					}
					break;
				case UIboxFlags.UI_COLUMN:
				case UIboxFlags.UI_ROW:
					{
						if ((pitem.flags & 1) == ((uint)(dim))) uiComputeStackedSize(pitem, (int)(dim)); else uiComputeImposedSize(pitem, (int)(dim));
					}
					break;
				default:
					{
						uiComputeImposedSize(pitem, (int)(dim));
					}
					break;
			}
		}*/
	}
}