using FontStashSharp;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using NvgSharp;

namespace BlendishSharp
{
	public static unsafe partial class Blendish
	{
		private static readonly Color BND_COLOR_TEXT = new Color(0.0f, 0.0f, 0.0f, 1.0f);
		private static readonly Color BND_COLOR_TEXT_SELECTED = new Color(1.0f, 1.0f, 1.0f, 1.0f);

		public static Theme bnd_theme = new Theme
		{
			backgroundColor = new Color(0.447f, 0.447f, 0.447f, 1.0f),
			regularTheme = new WidgetTheme
			{
				outlineColor = new Color(0.098f, 0.098f, 0.098f, 1.0f),
				itemColor = new Color(0.098f, 0.098f, 0.098f, 1.0f),
				innerColor = new Color(0.6f, 0.6f, 0.6f, 1.0f),
				innerSelectedColor = new Color(0.392f, 0.392f, 0.392f, 1.0f),
				textColor = BND_COLOR_TEXT, // color_text
				textSelectedColor = BND_COLOR_TEXT_SELECTED, // color_text_selected        
				shadeTop = 0, // shade_top
				shadeDown = 0 // shade_down
			},
			// toolTheme
			toolTheme = new WidgetTheme
			{
				outlineColor = new Color(0.098f, 0.098f, 0.098f, 1.0f), // color_outline
				itemColor = new Color(0.098f, 0.098f, 0.098f, 1.0f), // color_item
				innerColor = new Color(0.6f, 0.6f, 0.6f, 1.0f), // color_inner
				innerSelectedColor = new Color(0.392f, 00.392f, 0.392f, 1.0f), // color_inner_selected
				textColor = BND_COLOR_TEXT, // color_text
				textSelectedColor = BND_COLOR_TEXT_SELECTED, // color_text_selected        
				shadeTop = 15, // shade_top
				shadeDown = -15 // shade_down
			},
			// radioTheme
			radioTheme = new WidgetTheme
			{
				outlineColor = new Color(0.0f, 0.0f, 0.0f, 1.0f), // color_outline
				itemColor = new Color(1.0f, 1.0f, 1.0f, 1.0f), // color_item
				innerColor = new Color(0.275f, 0.275f, 0.275f, 1.0f), // color_inner
				innerSelectedColor = new Color(0.337f, 0.502f, 0.761f, 1.0f), // color_inner_selected
				textColor = BND_COLOR_TEXT_SELECTED, // color_text
				textSelectedColor = BND_COLOR_TEXT, // color_text_selected        
				shadeTop = 15, // shade_top
				shadeDown = -15 // shade_down
			},
			// textFieldTheme
			textFieldTheme = new WidgetTheme
			{
				outlineColor = new Color(0.098f, 0.098f, 0.098f, 1.0f), // color_outline
				itemColor = new Color(0.353f, 0.353f, 0.353f, 1.0f), // color_item
				innerColor = new Color(0.6f, 0.6f, 0.6f, 1.0f), // color_inner
				innerSelectedColor = new Color(0.6f, 0.6f, 0.6f, 1.0f), // color_inner_selected
				textColor = BND_COLOR_TEXT, // color_text
				textSelectedColor = BND_COLOR_TEXT_SELECTED, // color_text_selected        
				shadeTop = 0, // shade_top
				shadeDown = 25 // shade_down
			},
			// optionTheme
			optionTheme = new WidgetTheme
			{
				outlineColor = new Color(0.0f, 0.0f, 0.0f, 1.0f), // color_outline
				itemColor = new Color(1.0f, 1.0f, 1.0f, 1.0f), // color_item
				innerColor = new Color(0.275f, 0.275f, 0.275f, 1.0f), // color_inner
				innerSelectedColor = new Color(0.275f, 0.275f, 0.275f, 1.0f), // color_inner_selected
				textColor = BND_COLOR_TEXT, // color_text
				textSelectedColor = BND_COLOR_TEXT_SELECTED, // color_text_selected        
				shadeTop = 15, // shade_top
				shadeDown = -15 // shade_down
			},
			// choiceTheme
			choiceTheme = new WidgetTheme
			{
				outlineColor = new Color(0.0f, 0.0f, 0.0f, 1.0f), // color_outline
				itemColor = new Color(1.0f, 1.0f, 1.0f, 1.0f), // color_item
				innerColor = new Color(0.275f, 0.275f, 0.275f, 1.0f), // color_inner
				innerSelectedColor = new Color(0.275f, 0.275f, 0.275f, 1.0f), // color_inner_selected
				textColor = BND_COLOR_TEXT_SELECTED, // color_text
				textSelectedColor = new Color(0.8f, 0.8f, 0.8f, 1.0f), // color_text_selected        
				shadeTop = 15, // shade_top
				shadeDown = -15 // shade_down
			},
			// numberFieldTheme
			numberFieldTheme = new WidgetTheme
			{
				outlineColor = new Color(0.098f, 0.098f, 0.098f, 1.0f), // color_outline
				itemColor = new Color(0.353f, 0.353f, 0.353f, 1.0f), // color_item
				innerColor = new Color(0.706f, 0.706f, 0.706f, 1.0f), // color_inner
				innerSelectedColor = new Color(0.6f, 0.6f, 0.6f, 1.0f), // color_inner_selected
				textColor = BND_COLOR_TEXT, // color_text
				textSelectedColor = BND_COLOR_TEXT_SELECTED, // color_text_selected        
				shadeTop = -20, // shade_top
				shadeDown = 0 // shade_down
			},
			// sliderTheme
			sliderTheme = new WidgetTheme
			{
				outlineColor = new Color(0.098f, 0.098f, 0.098f, 1.0f), // color_outline
				itemColor = new Color(0.502f, 0.502f, 0.502f, 1.0f), // color_item
				innerColor = new Color(0.706f, 0.706f, 0.706f, 1.0f), // color_inner
				innerSelectedColor = new Color(0.6f, 0.6f, 0.6f, 1.0f), // color_inner_selected
				textColor = BND_COLOR_TEXT, // color_text
				textSelectedColor = BND_COLOR_TEXT_SELECTED, // color_text_selected        
				shadeTop = -20, // shade_top
				shadeDown = 0 // shade_down
			},
			// scrollBarTheme
			scrollBarTheme = new WidgetTheme
			{
				outlineColor = new Color(0.196f, 0.196f, 0.196f, 1.0f), // color_outline
				itemColor = new Color(0.502f, 0.502f, 0.502f, 1.0f), // color_item
				innerColor = new Color(0.314f, 0.314f, 0.314f, 0.706f), // color_inner
				innerSelectedColor = new Color(0.392f, 0.392f, 0.392f, 0.706f), // color_inner_selected
				textColor = BND_COLOR_TEXT, // color_text
				textSelectedColor = BND_COLOR_TEXT_SELECTED, // color_text_selected        
				shadeTop = 5, // shade_top
				shadeDown = -5 // shade_down
			},
			// tooltipTheme
			tooltipTheme = new WidgetTheme
			{
				outlineColor = new Color(0.0f, 0.0f, 0.0f, 1.0f), // color_outline
				itemColor = new Color(0.392f, 0.392f, 0.392f, 1.0f), // color_item
				innerColor = new Color(0.098f, 0.098f, 0.098f, 0.902f), // color_inner
				innerSelectedColor = new Color(0.176f, 0.176f, 0.176f, 0.902f), // color_inner_selected
				textColor = new Color(0.627f, 0.627f, 0.627f, 1.0f), // color_text
				textSelectedColor = BND_COLOR_TEXT_SELECTED, // color_text_selected        
				shadeTop = 0, // shade_top
				shadeDown = 0 // shade_down
			},
			// menuTheme
			menuTheme = new WidgetTheme
			{
				outlineColor = new Color(0.0f, 0.0f, 0.0f, 1.0f), // color_outline
				itemColor = new Color(0.392f, 0.392f, 0.392f, 1.0f), // color_item
				innerColor = new Color(0.098f, 0.098f, 0.098f, 0.902f), // color_inner
				innerSelectedColor = new Color(0.176f, 0.176f, 0.176f, 0.902f), // color_inner_selected
				textColor = new Color(0.627f, 0.627f, 0.627f, 1.0f), // color_text
				textSelectedColor = BND_COLOR_TEXT_SELECTED, // color_text_selected        
				shadeTop = 0, // shade_top
				shadeDown = 0 // shade_down
			},
			// menuItemTheme
			menuItemTheme = new WidgetTheme
			{
				outlineColor = new Color(0.0f, 0.0f, 0.0f, 1.0f), // color_outline
				itemColor = new Color(0.675f, 0.675f, 0.675f, 0.502f), // color_item
				innerColor = new Color(0.0f, 0.0f, 0.0f, 0.0f), // color_inner
				innerSelectedColor = new Color(0.337f, 0.502f, 0.761f, 1.0f), // color_inner_selected
				textColor = BND_COLOR_TEXT_SELECTED, // color_text
				textSelectedColor = BND_COLOR_TEXT, // color_text_selected        
				shadeTop = 38, // shade_top
				shadeDown = 0 // shade_down
			},
			// nodeTheme
			nodeTheme = new NodeTheme
			{
				nodeSelectedColor = new Color(0.945f, 0.345f, 0.0f, 1.0f), // nodeSelectedColor
				wiresColor = new Color(0.0f, 0.0f, 0.0f, 1.0f), // wiresColor
				textSelectedColor = new Color(0.498f, 0.439f, 0.439f, 1.0f), // textSelectedColor
				activeNodeColor = new Color(1.0f, 0.667f, 0.251f, 1.0f), // activeNodeColor
				wireSelectColor = new Color(1.0f, 1.0f, 1.0f, 1.0f), // wireSelectColor
				nodeBackdropColor = new Color(0.608f, 0.608f, 0.608f, 0.627f), // nodeBackdropColor
				noodleCurving = 5 // noodleCurving
			}
		};

		private static int bnd_icon_image = -1;
		private static int bnd_font = -1;

		private static bool _fontLoaded;
		private static readonly TextRow[] _rows = new TextRow[32];
		private static readonly GlyphPosition[] glyphs = new GlyphPosition[1024];

		static Blendish()
		{
			for (var i = 0; i < _rows.Length; ++i) _rows[i] = new TextRow();
		}

		public static int DefaultIconImageId { get; private set; } = -1;

		public static int DefaultFontId { get; private set; } = -1;

		public static void bndSetDefaultResources(this NvgContext context, GraphicsDevice device)
		{
			if (!_fontLoaded)
			{
				DefaultFontId = context.CreateFontMem("system", Resources.CreateTtfSystemByteArray());
				var texture = Resources.CreateIcons(device);
				var data = new byte[texture.Width * texture.Height * 4];
				texture.GetData(data);

				DefaultIconImageId = context.CreateImageRGBA(texture.Width, texture.Height, 0, data);

				_fontLoaded = true;
			}

			bnd_font = DefaultFontId;
			bnd_icon_image = DefaultIconImageId;
		}

		public static void bndSetTheme(Theme theme)
		{
			bnd_theme = theme;
		}

		public static Theme bndGetTheme()
		{
			return bnd_theme;
		}

		public static void bndSetIconImage(int image)
		{
			bnd_icon_image = image;
		}

		public static void bndSetFont(int font)
		{
			bnd_font = font;
		}

		public static void bndLabel(this NvgContext ctx, float x, float y, float w, float h, BNDicon? iconid,
			string label)
		{
			bndIconLabelValue(ctx, x, y, w, h, iconid, bnd_theme.regularTheme.textColor,
				(int)BNDtextAlignment.BND_LEFT, 13, label, null);
		}

		public static void bndToolButton(this NvgContext ctx, float x, float y, float w, float h, BNDcornerFlags flags,
			BNDwidgetState state, BNDicon? iconid, string label)
		{
			var cr = stackalloc float[4];
			var shade_top = new Color();
			var shade_down = new Color();
			bndSelectCorners(cr, 4, flags);
			bndBevelInset(ctx, x, y, w, h, cr[2], cr[3]);
			bndInnerColors(ref shade_top, ref shade_down, bnd_theme.toolTheme, state, 1);
			bndInnerBox(ctx, x, y, w, h, cr[0], cr[1], cr[2], cr[3], shade_top, shade_down);
			bndOutlineBox(ctx, x, y, w, h, cr[0], cr[1], cr[2], cr[3],
				bnd_theme.toolTheme.outlineColor.bndTransparent());
			bndIconLabelValue(ctx, x, y, w, h, iconid, bndTextColor(bnd_theme.toolTheme, state),
				BNDtextAlignment.BND_CENTER, 13, label, null);
		}

		public static void bndRadioButton(this NvgContext ctx, float x, float y, float w, float h, BNDcornerFlags flags,
			BNDwidgetState state, BNDicon? iconid, string label)
		{
			var cr = stackalloc float[4];
			var shade_top = new Color();
			var shade_down = new Color();
			bndSelectCorners(cr, 4, flags);
			bndBevelInset(ctx, x, y, w, h, cr[2], cr[3]);
			bndInnerColors(ref shade_top, ref shade_down, bnd_theme.radioTheme, state, 1);
			bndInnerBox(ctx, x, y, w, h, cr[0], cr[1], cr[2], cr[3], shade_top, shade_down);
			bndOutlineBox(ctx, x, y, w, h, cr[0], cr[1], cr[2], cr[3],
				bnd_theme.radioTheme.outlineColor.bndTransparent());
			bndIconLabelValue(ctx, x, y, w, h, iconid, bndTextColor(bnd_theme.radioTheme, state),
				BNDtextAlignment.BND_CENTER, 13, label, null);
		}

		public static int bndTextFieldTextPosition(this NvgContext ctx, float x, float y, float w, float h,
			BNDicon? iconid, string text, int px, int py)
		{
			return bndIconLabelTextPosition(ctx, x, y, w, h, iconid, 13, text, px, py);
		}

		public static void bndTextField(this NvgContext ctx, float x, float y, float w, float h, BNDcornerFlags flags,
			BNDwidgetState state, BNDicon? iconid, string text, int cbegin, int cend)
		{
			var cr = stackalloc float[4];
			var shade_top = new Color();
			var shade_down = new Color();
			bndSelectCorners(cr, 4, flags);
			bndBevelInset(ctx, x, y, w, h, cr[2], cr[3]);
			bndInnerColors(ref shade_top, ref shade_down, bnd_theme.textFieldTheme, state, 0);
			bndInnerBox(ctx, x, y, w, h, cr[0], cr[1], cr[2], cr[3], shade_top, shade_down);
			bndOutlineBox(ctx, x, y, w, h, cr[0], cr[1], cr[2], cr[3],
				bnd_theme.textFieldTheme.outlineColor.bndTransparent());
			if (state != BNDwidgetState.BND_ACTIVE) cend = -1;

			bndIconLabelCaret(ctx, x, y, w, h, iconid, bndTextColor(bnd_theme.textFieldTheme, state), 13, text,
				bnd_theme.textFieldTheme.itemColor, cbegin, cend);
		}

		public static void bndOptionButton(this NvgContext ctx, float x, float y, float w, float h,
			BNDwidgetState state, string label)
		{
			float ox = 0;
			float oy = 0;
			var shade_top = new Color();
			var shade_down = new Color();
			ox = x;
			oy = y + h - 15 - 3;
			bndBevelInset(ctx, ox, oy, 14, 15, 4, 4);
			bndInnerColors(ref shade_top, ref shade_down, bnd_theme.optionTheme, state, 1);
			bndInnerBox(ctx, ox, oy, 14, 15, 4, 4, 4, 4, shade_top, shade_down);
			bndOutlineBox(ctx, ox, oy, 14, 15, 4, 4, 4, 4, bnd_theme.optionTheme.outlineColor.bndTransparent());
			if (state == BNDwidgetState.BND_ACTIVE)
				bndCheck(ctx, ox, oy, bnd_theme.optionTheme.itemColor.bndTransparent());

			bndIconLabelValue(ctx, x + 12, y, w - 12, h, null, bndTextColor(bnd_theme.optionTheme, state),
				(int)BNDtextAlignment.BND_LEFT, 13, label, null);
		}

		public static void bndChoiceButton(this NvgContext ctx, float x, float y, float w, float h,
			BNDcornerFlags flags, BNDwidgetState state, BNDicon? iconid, string label)
		{
			var cr = stackalloc float[4];
			var shade_top = new Color();
			var shade_down = new Color();
			bndSelectCorners(cr, 4, flags);
			bndBevelInset(ctx, x, y, w, h, cr[2], cr[3]);
			bndInnerColors(ref shade_top, ref shade_down, bnd_theme.choiceTheme, state, 1);
			bndInnerBox(ctx, x, y, w, h, cr[0], cr[1], cr[2], cr[3], shade_top, shade_down);
			bndOutlineBox(ctx, x, y, w, h, cr[0], cr[1], cr[2], cr[3],
				bnd_theme.choiceTheme.outlineColor.bndTransparent());
			bndIconLabelValue(ctx, x, y, w, h, iconid, bndTextColor(bnd_theme.choiceTheme, state),
				(int)BNDtextAlignment.BND_LEFT, 13, label, null);
			bndUpDownArrow(ctx, x + w - 10, y + 10, 5, bnd_theme.choiceTheme.itemColor.bndTransparent());
		}

		public static void bndColorButton(this NvgContext ctx, float x, float y, float w, float h, BNDcornerFlags flags,
			Color color)
		{
			var cr = stackalloc float[4];
			bndSelectCorners(cr, 4, flags);
			bndBevelInset(ctx, x, y, w, h, cr[2], cr[3]);
			bndInnerBox(ctx, x, y, w, h, cr[0], cr[1], cr[2], cr[3], color, color);
			bndOutlineBox(ctx, x, y, w, h, cr[0], cr[1], cr[2], cr[3],
				bnd_theme.toolTheme.outlineColor.bndTransparent());
		}

		public static void bndNumberField(this NvgContext ctx, float x, float y, float w, float h, BNDcornerFlags flags,
			BNDwidgetState state, string label, string value)
		{
			var cr = stackalloc float[4];
			var shade_top = new Color();
			var shade_down = new Color();
			bndSelectCorners(cr, 10, flags);
			bndBevelInset(ctx, x, y, w, h, cr[2], cr[3]);
			bndInnerColors(ref shade_top, ref shade_down, bnd_theme.numberFieldTheme, state, 0);
			bndInnerBox(ctx, x, y, w, h, cr[0], cr[1], cr[2], cr[3], shade_top, shade_down);
			bndOutlineBox(ctx, x, y, w, h, cr[0], cr[1], cr[2], cr[3],
				bnd_theme.numberFieldTheme.outlineColor.bndTransparent());
			bndIconLabelValue(ctx, x, y, w, h, null, bndTextColor(bnd_theme.numberFieldTheme, state),
				BNDtextAlignment.BND_CENTER, 13, label, value);
			bndArrow(ctx, x + 8, y + 10, -4, bnd_theme.numberFieldTheme.itemColor.bndTransparent());
			bndArrow(ctx, x + w - 8, y + 10, 4, bnd_theme.numberFieldTheme.itemColor.bndTransparent());
		}

		public static void bndSlider(this NvgContext ctx, float x, float y, float w, float h, BNDcornerFlags flags,
			BNDwidgetState state, float progress, string label, string value)
		{
			var cr = stackalloc float[4];
			var shade_top = new Color();
			var shade_down = new Color();
			bndSelectCorners(cr, 10, flags);
			bndBevelInset(ctx, x, y, w, h, cr[2], cr[3]);
			bndInnerColors(ref shade_top, ref shade_down, bnd_theme.sliderTheme, state, 0);
			bndInnerBox(ctx, x, y, w, h, cr[0], cr[1], cr[2], cr[3], shade_top, shade_down);
			if (state == BNDwidgetState.BND_ACTIVE)
			{
				shade_top = bnd_theme.sliderTheme.itemColor.bndOffsetColor(bnd_theme.sliderTheme.shadeTop);
				shade_down = bnd_theme.sliderTheme.itemColor.bndOffsetColor(bnd_theme.sliderTheme.shadeDown);
			}
			else
			{
				shade_top = bnd_theme.sliderTheme.itemColor.bndOffsetColor(bnd_theme.sliderTheme.shadeDown);
				shade_down = bnd_theme.sliderTheme.itemColor.bndOffsetColor(bnd_theme.sliderTheme.shadeTop);
			}

			ctx.Scissor(x, y, 8 + (w - 8) * bnd_clamp(progress, 0, 1), h);
			bndInnerBox(ctx, x, y, w, h, cr[0], cr[1], cr[2], cr[3], shade_top, shade_down);
			ctx.ResetScissor();
			bndOutlineBox(ctx, x, y, w, h, cr[0], cr[1], cr[2], cr[3],
				bnd_theme.sliderTheme.outlineColor.bndTransparent());
			bndIconLabelValue(ctx, x, y, w, h, null, bndTextColor(bnd_theme.sliderTheme, state),
				BNDtextAlignment.BND_CENTER, 13, label, value);
		}

		public static void bndScrollBar(this NvgContext ctx, float x, float y, float w, float h, BNDwidgetState state,
			float offset, float size)
		{
			bndBevelInset(ctx, x, y, w, h, 7, 7);
			bndInnerBox(ctx, x, y, w, h, 7, 7, 7, 7,
				bnd_theme.scrollBarTheme.innerColor.bndOffsetColor(3 * bnd_theme.scrollBarTheme.shadeDown),
				bnd_theme.scrollBarTheme.innerColor.bndOffsetColor(3 * bnd_theme.scrollBarTheme.shadeTop));
			bndOutlineBox(ctx, x, y, w, h, 7, 7, 7, 7, bnd_theme.scrollBarTheme.outlineColor.bndTransparent());
			var itemColor =
				bnd_theme.scrollBarTheme.itemColor.bndOffsetColor(state == BNDwidgetState.BND_ACTIVE ? 15 : 0);
			bndScrollHandleRect(&x, &y, &w, &h, offset, size);
			bndInnerBox(ctx, x, y, w, h, 7, 7, 7, 7, itemColor.bndOffsetColor(3 * bnd_theme.scrollBarTheme.shadeTop),
				itemColor.bndOffsetColor(3 * bnd_theme.scrollBarTheme.shadeDown));
			bndOutlineBox(ctx, x, y, w, h, 7, 7, 7, 7, bnd_theme.scrollBarTheme.outlineColor.bndTransparent());
		}

		public static void bndMenuBackground(this NvgContext ctx, float x, float y, float w, float h,
			BNDcornerFlags flags)
		{
			var cr = stackalloc float[4];
			var shade_top = new Color();
			var shade_down = new Color();
			bndSelectCorners(cr, 3, flags);
			bndInnerColors(ref shade_top, ref shade_down, bnd_theme.menuTheme, (int)BNDwidgetState.BND_DEFAULT, 0);
			bndInnerBox(ctx, x, y, w, h + 1, cr[0], cr[1], cr[2], cr[3], shade_top, shade_down);
			bndOutlineBox(ctx, x, y, w, h + 1, cr[0], cr[1], cr[2], cr[3],
				bnd_theme.menuTheme.outlineColor.bndTransparent());
			bndDropShadow(ctx, x, y, w, h, 3, 12, (float)0.5);
		}

		public static void bndTooltipBackground(this NvgContext ctx, float x, float y, float w, float h)
		{
			var shade_top = new Color();
			var shade_down = new Color();
			bndInnerColors(ref shade_top, ref shade_down, bnd_theme.tooltipTheme, (int)BNDwidgetState.BND_DEFAULT, 0);
			bndInnerBox(ctx, x, y, w, h + 1, 3, 3, 3, 3, shade_top, shade_down);
			bndOutlineBox(ctx, x, y, w, h + 1, 3, 3, 3, 3, bnd_theme.tooltipTheme.outlineColor.bndTransparent());
			bndDropShadow(ctx, x, y, w, h, 3, 12, (float)0.5);
		}

		public static void bndMenuLabel(this NvgContext ctx, float x, float y, float w, float h, BNDicon? iconid,
			string label)
		{
			bndIconLabelValue(ctx, x, y, w, h, iconid, bnd_theme.menuTheme.textColor, (int)BNDtextAlignment.BND_LEFT,
				13, label, null);
		}

		public static void bndMenuItem(this NvgContext ctx, float x, float y, float w, float h, BNDwidgetState state,
			BNDicon? iconid, string label)
		{
			if (state != BNDwidgetState.BND_DEFAULT)
			{
				bndInnerBox(ctx, x, y, w, h, 0, 0, 0, 0,
					bnd_theme.menuItemTheme.innerSelectedColor.bndOffsetColor(bnd_theme.menuItemTheme.shadeTop),
					bnd_theme.menuItemTheme.innerSelectedColor.bndOffsetColor(bnd_theme.menuItemTheme.shadeDown));
				state = BNDwidgetState.BND_ACTIVE;
			}

			bndIconLabelValue(ctx, x, y, w, h, iconid, bndTextColor(bnd_theme.menuItemTheme, state),
				(int)BNDtextAlignment.BND_LEFT, 13, label, null);
		}

		public static void bndNodePort(this NvgContext ctx, float x, float y, BNDwidgetState state, Color color)
		{
			ctx.BeginPath();
			ctx.Circle(x, y, BND_NODE_PORT_RADIUS);
			ctx.StrokeColor(bnd_theme.nodeTheme.wiresColor);
			ctx.StrokeWidth(1.0f);
			ctx.Stroke();
			ctx.FillColor(state != BNDwidgetState.BND_DEFAULT ? color.bndOffsetColor(15) : color);
			ctx.Fill();
		}

		internal static float fabsf(float a)
		{
			return a >= 0.0f ? a : -a;
		}

		public static void bndColoredNodeWire(this NvgContext ctx, float x0, float y0, float x1, float y1, Color color0,
			Color color1)
		{
			var length = bnd_fmaxf(fabsf(x1 - x0), fabsf(y1 - y0));
			var delta = length * bnd_theme.nodeTheme.noodleCurving / 10.0f;
			ctx.BeginPath();
			ctx.MoveTo(x0, y0);
			ctx.BezierTo(x0 + delta, y0, x1 - delta, y1, x1, y1);
			var colorw = bnd_theme.nodeTheme.wiresColor;
			colorw.A = color0.A < color1.A ? color0.A : color1.A;
			ctx.StrokeColor(colorw);
			ctx.StrokeWidth(4);
			ctx.Stroke();
			ctx.StrokePaint(ctx.LinearGradient(x0, y0, x1, y1, color0, color1));
			ctx.StrokeWidth(2);
			ctx.Stroke();
		}

		public static void bndNodeWire(this NvgContext ctx, float x0, float y0, float x1, float y1,
			BNDwidgetState state0, BNDwidgetState state1)
		{
			bndColoredNodeWire(ctx, x0, y0, x1, y1, bndNodeWireColor(bnd_theme.nodeTheme, state0),
				bndNodeWireColor(bnd_theme.nodeTheme, state1));
		}

		public static void bndNodeBackground(this NvgContext ctx, float x, float y, float w, float h,
			BNDwidgetState state, BNDicon? iconid, string label, Color titleColor)
		{
			bndInnerBox(ctx, x, y, w, BND_NODE_TITLE_HEIGHT + 2, 8, 8, 0, 0,
				titleColor.bndOffsetColor(30).bndTransparent(), titleColor.bndTransparent());
			bndInnerBox(ctx, x, y + BND_NODE_TITLE_HEIGHT - 1, w, h + 2 - BND_NODE_TITLE_HEIGHT, 0, 0, 8, 8,
				bnd_theme.nodeTheme.nodeBackdropColor.bndTransparent(),
				bnd_theme.nodeTheme.nodeBackdropColor.bndTransparent());
			bndNodeIconLabel(ctx, x + BND_NODE_ARROW_AREA_WIDTH, y,
				w - BND_NODE_ARROW_AREA_WIDTH - BND_NODE_MARGIN_SIDE, BND_NODE_TITLE_HEIGHT, iconid,
				bnd_theme.regularTheme.textColor, titleColor.bndOffsetColor(30), (int)BNDtextAlignment.BND_LEFT, 13,
				label);
			Color borderColor;
			switch (state)
			{
				default:
					{
						borderColor = new Color(0, 0, (float)0);
						var arrowColor = titleColor.bndOffsetColor(-30);
					}
					break;
				case BNDwidgetState.BND_HOVER:
					{
						borderColor = bnd_theme.nodeTheme.nodeSelectedColor;
						var arrowColor = bnd_theme.nodeTheme.nodeSelectedColor;
					}
					break;
				case BNDwidgetState.BND_ACTIVE:
					{
						borderColor = bnd_theme.nodeTheme.activeNodeColor;
						var arrowColor = bnd_theme.nodeTheme.nodeSelectedColor;
					}
					break;
			}

			bndOutlineBox(ctx, x, y, w, h + 1, 8, 8, 8, 8, borderColor.bndTransparent());
			bndDropShadow(ctx, x, y, w, h, 8, 12, (float)0.5);
		}

		public static void bndSplitterWidgets(this NvgContext ctx, float x, float y, float w, float h)
		{
			var insetLight = bnd_theme.backgroundColor.bndOffsetColor(100).bndTransparent();
			var insetDark = bnd_theme.backgroundColor.bndOffsetColor(-100).bndTransparent();
			var inset = bnd_theme.backgroundColor.bndTransparent();
			var x2 = x + w;
			var y2 = y + h;
			ctx.BeginPath();
			ctx.MoveTo(x, y2 - 13);
			ctx.LineTo(x + 13, y2);
			ctx.MoveTo(x, y2 - 9);
			ctx.LineTo(x + 9, y2);
			ctx.MoveTo(x, y2 - 5);
			ctx.LineTo(x + 5, y2);
			ctx.MoveTo(x2 - 11, y);
			ctx.LineTo(x2, y + 11);
			ctx.MoveTo(x2 - 7, y);
			ctx.LineTo(x2, y + 7);
			ctx.MoveTo(x2 - 3, y);
			ctx.LineTo(x2, y + 3);
			ctx.StrokeColor(insetDark);
			ctx.Stroke();
			ctx.BeginPath();
			ctx.MoveTo(x, y2 - 11);
			ctx.LineTo(x + 11, y2);
			ctx.MoveTo(x, y2 - 7);
			ctx.LineTo(x + 7, y2);
			ctx.MoveTo(x, y2 - 3);
			ctx.LineTo(x + 3, y2);
			ctx.MoveTo(x2 - 13, y);
			ctx.LineTo(x2, y + 13);
			ctx.MoveTo(x2 - 9, y);
			ctx.LineTo(x2, y + 9);
			ctx.MoveTo(x2 - 5, y);
			ctx.LineTo(x2, y + 5);
			ctx.StrokeColor(insetLight);
			ctx.Stroke();
			ctx.BeginPath();
			ctx.MoveTo(x, y2 - 12);
			ctx.LineTo(x + 12, y2);
			ctx.MoveTo(x, y2 - 8);
			ctx.LineTo(x + 8, y2);
			ctx.MoveTo(x, y2 - 4);
			ctx.LineTo(x + 4, y2);
			ctx.MoveTo(x2 - 12, y);
			ctx.LineTo(x2, y + 12);
			ctx.MoveTo(x2 - 8, y);
			ctx.LineTo(x2, y + 8);
			ctx.MoveTo(x2 - 4, y);
			ctx.LineTo(x2, y + 4);
			ctx.StrokeColor(inset);
			ctx.Stroke();
		}

		public static void bndJoinAreaOverlay(this NvgContext ctx, float x, float y, float w, float h, bool vertical,
			bool mirror)
		{
			if (vertical)
			{
				var u = w;
				w = h;
				h = u;
			}

			var s = w < h ? w : h;
			float x0 = 0;
			float y0 = 0;
			float x1 = 0;
			float y1 = 0;
			if (mirror)
			{
				x0 = w;
				y0 = h;
				x1 = 0;
				y1 = 0;
				s = -s;
			}
			else
			{
				x0 = 0;
				y0 = 0;
				x1 = w;
				y1 = h;
			}

			var yc = (y0 + y1) * 0.5f;
			var s2 = s / 2.0f;
			var s4 = s / 4.0f;
			var s8 = s / 8.0f;
			var x4 = x0 + s4;
			var points = stackalloc Vector2[11];
			points[0] = new Vector2(x0, y0);
			points[1] = new Vector2(x1, y0);
			points[2] = new Vector2(x1, y1);
			points[3] = new Vector2(x0, y1);
			points[4] = new Vector2(x0, yc + s8);
			points[5] = new Vector2(x4, yc + s8);
			points[6] = new Vector2(x4, yc + s4);
			points[7] = new Vector2(x0 + s2, yc);
			points[8] = new Vector2(x4, yc - s4);
			points[9] = new Vector2(x4, yc - s8);
			points[10] = new Vector2(x0, yc - s8);

			ctx.BeginPath();

			if (!vertical)
				ctx.MoveTo(x + points[0].X, y + points[0].Y);
			else
				ctx.MoveTo(x + points[0].Y, y + points[0].X);

			for (var i = 1; i < 11; ++i)
				if (!vertical)
					ctx.LineTo(x + points[i].X, y + points[i].Y);
				else
					ctx.LineTo(x + points[i].Y, y + points[i].X);
			ctx.FillColor(new Color(0, 0, 0, (float)0.3));
			ctx.Fill();
		}

		public static float bndLabelWidth(this NvgContext ctx, BNDicon? iconid, string label)
		{
			var w = 8 + 8;
			if (iconid != null) w += 16;

			if (label != null && bnd_font >= 0)
			{
				ctx.FontFaceId(bnd_font);
				ctx.FontSize(13);

				var b = new Bounds();
				w += (int)ctx.TextBounds(1, 1, label, ref b);
			}

			return w;
		}

		public static float bndLabelHeight(this NvgContext ctx, BNDicon? iconid, string label, float width)
		{
			var h = BND_WIDGET_HEIGHT;
			width -= 4 * 2;
			if (iconid != null) width -= 16;

			if (label != null && bnd_font >= 0)
			{
				ctx.FontFaceId(bnd_font);
				ctx.FontSize(13);
				var bounds = new Bounds();
				ctx.TextBoxBounds(1, 1, width, label, ref bounds);
				var bh = 0;
				if (bh > h)
					h = bh;
			}

			return h;
		}

		public static void bndRoundedBox(this NvgContext ctx, float x, float y, float w, float h, float cr0, float cr1,
			float cr2, float cr3)
		{
			float d = 0;
			w = bnd_fmaxf(0, w);
			h = bnd_fmaxf(0, h);
			d = bnd_fminf(w, h);
			ctx.MoveTo(x, y + h * 0.5f);
			ctx.ArcTo(x, y, x + w, y, bnd_fminf(cr0, d / 2));
			ctx.ArcTo(x + w, y, x + w, y + h, bnd_fminf(cr1, d / 2));
			ctx.ArcTo(x + w, y + h, x, y + h, bnd_fminf(cr2, d / 2));
			ctx.ArcTo(x, y + h, x, y, bnd_fminf(cr3, d / 2));
			ctx.ClosePath();
		}

		public static void bndBevel(this NvgContext ctx, float x, float y, float w, float h)
		{
			ctx.StrokeWidth(1);
			x += 0.5f;
			y += 0.5f;
			w -= 1;
			h -= 1;
			ctx.BeginPath();
			ctx.MoveTo(x, y + h);
			ctx.LineTo(x + w, y + h);
			ctx.LineTo(x + w, y);
			ctx.StrokeColor(bnd_theme.backgroundColor.bndOffsetColor(-30).bndTransparent());
			ctx.Stroke();
			ctx.BeginPath();
			ctx.MoveTo(x, y + h);
			ctx.LineTo(x, y);
			ctx.LineTo(x + w, y);
			ctx.StrokeColor(bnd_theme.backgroundColor.bndOffsetColor(30).bndTransparent());
			ctx.Stroke();
		}

		public static void bndBevelInset(this NvgContext ctx, float x, float y, float w, float h, float cr2, float cr3)
		{
			float d = 0;
			y -= 0.5f;
			d = bnd_fminf(w, h);
			cr2 = bnd_fminf(cr2, d / 2);
			cr3 = bnd_fminf(cr3, d / 2);
			ctx.BeginPath();
			ctx.MoveTo(x + w, y + h - cr2);
			ctx.ArcTo(x + w, y + h, x, y + h, cr2);
			ctx.ArcTo(x, y + h, x, y, cr3);
			var bevelColor = bnd_theme.backgroundColor.bndOffsetColor(30);
			ctx.StrokeWidth(1);
			ctx.StrokePaint(ctx.LinearGradient(x, y + h - bnd_fmaxf(cr2, cr3) - 1, x, y + h - 1,
				new Color(bevelColor.R, bevelColor.G, bevelColor.B, (float)0), bevelColor));
			ctx.Stroke();
		}

		public static void bndBackground(this NvgContext ctx, float x, float y, float w, float h)
		{
			ctx.BeginPath();
			ctx.Rect(x, y, w, h);
			ctx.FillColor(bnd_theme.backgroundColor);
			ctx.Fill();
		}

		public static void bndIcon(this NvgContext ctx, float x, float y, BNDicon iconid)
		{
			var ix = 0;
			var iy = 0;
			var u = 0;
			var v = 0;
			if (bnd_icon_image < 0)
				return;
			ix = (int)iconid & 0xff;
			iy = ((int)iconid >> 8) & 0xff;
			u = 5 + ix * 21;
			v = 10 + iy * 21;
			ctx.BeginPath();
			ctx.Rect(x, y, 16, 16);
			ctx.FillPaint(ctx.ImagePattern(x - u, y - v, 602, 640, 0, bnd_icon_image, 1));
			ctx.Fill();
		}

		public static void bndDropShadow(this NvgContext ctx, float x, float y, float w, float h, float r,
			float feather, float alpha)
		{
			ctx.BeginPath();
			y += feather;
			h -= feather;
			ctx.MoveTo(x - feather, y - feather);
			ctx.LineTo(x, y - feather);
			ctx.LineTo(x, y + h - feather);
			ctx.ArcTo(x, y + h, x + r, y + h, r);
			ctx.ArcTo(x + w, y + h, x + w, y + h - r, r);
			ctx.LineTo(x + w, y - feather);
			ctx.LineTo(x + w + feather, y - feather);
			ctx.LineTo(x + w + feather, y + h + feather);
			ctx.LineTo(x - feather, y + h + feather);
			ctx.ClosePath();
			ctx.FillPaint(ctx.BoxGradient(x - feather * 0.5f, y - feather * 0.5f, w + feather, h + feather,
				r + feather * 0.5f, feather, new Color(0, 0, 0, alpha * alpha), new Color(0, 0, 0, (float)0)));
			ctx.Fill();
		}

		public static void bndInnerBox(this NvgContext ctx, float x, float y, float w, float h, float cr0, float cr1,
			float cr2, float cr3, Color shade_top, Color shade_down)
		{
			ctx.BeginPath();
			bndRoundedBox(ctx, x + 1, y + 1, w - 2, h - 3, bnd_fmaxf(0, cr0 - 1), bnd_fmaxf(0, cr1 - 1),
				bnd_fmaxf(0, cr2 - 1), bnd_fmaxf(0, cr3 - 1));
			ctx.FillPaint(h - 2 > w
				? ctx.LinearGradient(x, y, x + w, y, shade_top, shade_down)
				: ctx.LinearGradient(x, y, x, y + h, shade_top, shade_down));
			ctx.Fill();
		}

		public static void bndOutlineBox(this NvgContext ctx, float x, float y, float w, float h, float cr0, float cr1,
			float cr2, float cr3, Color color)
		{
			ctx.BeginPath();
			bndRoundedBox(ctx, x + 0.5f, y + 0.5f, w - 1, h - 2, cr0, cr1, cr2, cr3);
			ctx.StrokeColor(color);
			ctx.StrokeWidth(1);
			ctx.Stroke();
		}

		public static void bndSelectCorners(float* radiuses, float r, BNDcornerFlags flags)
		{
			radiuses[0] = (flags & BNDcornerFlags.BND_CORNER_TOP_LEFT) != 0 ? 0 : r;
			radiuses[1] = (flags & BNDcornerFlags.BND_CORNER_TOP_RIGHT) != 0 ? 0 : r;
			radiuses[2] = (flags & BNDcornerFlags.BND_CORNER_DOWN_RIGHT) != 0 ? 0 : r;
			radiuses[3] = (flags & BNDcornerFlags.BND_CORNER_DOWN_LEFT) != 0 ? 0 : r;
		}

		public static void bndInnerColors(ref Color shade_top, ref Color shade_down, WidgetTheme theme,
			BNDwidgetState state, int flipActive)
		{
			switch (state)
			{
				default:
				case BNDwidgetState.BND_DEFAULT:
					{
						shade_top = theme.innerColor.bndOffsetColor(theme.shadeTop);
						shade_down = theme.innerColor.bndOffsetColor(theme.shadeDown);
					}
					break;
				case BNDwidgetState.BND_HOVER:
					{
						var color = theme.innerColor.bndOffsetColor(15);
						shade_top = color.bndOffsetColor(theme.shadeTop);
						shade_down = color.bndOffsetColor(theme.shadeDown);
					}
					break;
				case BNDwidgetState.BND_ACTIVE:
					{
						shade_top = theme.innerSelectedColor.bndOffsetColor(flipActive != 0
							? theme.shadeDown
							: theme.shadeTop);
						shade_down =
							theme.innerSelectedColor.bndOffsetColor(flipActive != 0 ? theme.shadeTop : theme.shadeDown);
					}
					break;
			}
		}

		public static Color bndTextColor(WidgetTheme theme, BNDwidgetState state)
		{
			return state == BNDwidgetState.BND_ACTIVE ? theme.textSelectedColor : theme.textColor;
		}

		public static void bndIconLabelValue(this NvgContext ctx, float x, float y, float w, float h, BNDicon? iconid,
			Color color, BNDtextAlignment align, float fontsize, string label, string value)
		{
			var pleft = (float)8;
			if (label != null)
			{
				if (iconid != null)
				{
					bndIcon(ctx, x + 4, y + 2, iconid.Value);
					pleft += 16;
				}

				if (bnd_font < 0)
					return;
				ctx.FontFaceId(bnd_font);
				ctx.FontSize(fontsize);
				ctx.BeginPath();
				ctx.FillColor(color);
				if (value != null)
				{
					var bounds = new Bounds();
					var label_width = ctx.TextBounds(1, 1, label, ref bounds);
					var sep_width = ctx.TextBounds(1, 1, ": ", ref bounds);
					ctx.TextAlign(Alignment.Left | Alignment.Baseline);
					x += pleft;
					if (align == BNDtextAlignment.BND_CENTER)
					{
						var width = label_width + sep_width + ctx.TextBounds(1, 1, value, ref bounds);
						x += (w - 8 - pleft - width) * 0.5f;
					}

					y += BND_WIDGET_HEIGHT - 7;
					ctx.Text(x, y, label);
					x += label_width;
					ctx.Text(x, y, ": ");
					x += sep_width;
					ctx.Text(x, y, value);
				}
				else
				{
					ctx.TextAlign(align == BNDtextAlignment.BND_LEFT
						? Alignment.Left | Alignment.Baseline
						: Alignment.Center | Alignment.Baseline);
					ctx.TextBox(x + pleft, y + BND_WIDGET_HEIGHT - 7, w - 8 - pleft, label);
				}
			}
			else if (iconid != null)
			{
				bndIcon(ctx, x + 2, y + 2, iconid.Value);
			}
		}

		public static void bndNodeIconLabel(this NvgContext ctx, float x, float y, float w, float h, BNDicon? iconid,
			Color color, Color shadowColor, BNDtextAlignment align, float fontsize, string label)
		{
			if (label != null && bnd_font >= 0)
			{
				ctx.FontFaceId(bnd_font);
				ctx.FontSize(fontsize);
				ctx.BeginPath();
				ctx.TextAlign(Alignment.Left | Alignment.Baseline);
				ctx.FillColor(shadowColor);
				ctx.FontBlur(1);
				ctx.TextBox(x + 1, y + h + 3 - 7, w, label);
				ctx.FillColor(color);
				ctx.FontBlur(0);
				ctx.TextBox(x, y + h + 2 - 7, w, label);
			}

			if (iconid != null) bndIcon(ctx, x + w - 16, y + 3, iconid.Value);
		}

		public static int bndIconLabelTextPosition(this NvgContext ctx, float x, float y, float w, float h,
			BNDicon? iconid, float fontsize, string label, int px, int py)
		{
			var bounds = new Bounds();
			var pleft = (float)4;
			if (label == null)
				return -1;
			if (iconid != null)
				pleft += 16;
			if (bnd_font < 0)
				return -1;
			x += pleft;
			y += BND_WIDGET_HEIGHT - 7;
			ctx.FontFaceId(bnd_font);
			ctx.FontSize(fontsize);
			ctx.TextAlign(Alignment.Left | Alignment.Baseline);
			w -= 4 + pleft;
			float asc = 0;
			float desc = 0;
			float lh = 0;
			StringSegment remaining;
			var nrows = ctx.TextBreakLines(label, w, _rows, out remaining);
			if (nrows == 0)
				return 0;
			ctx.TextBoxBounds(x, y, w, label, ref bounds);
			ctx.TextMetrics(out asc, out desc, out lh);
			var row = (int)bnd_clamp((int)((py - bounds.b2) / lh), 0, nrows - 1);

			var nglyphs = ctx.TextGlyphPositions(x, y, _rows[row].Str, glyphs);
			var col = 0;
			var p = 0;
			for (col = 0; col < nglyphs && glyphs[col].X < px; ++col) p = glyphs[col].Str.Location;
			if (col > 0 && col < nglyphs && glyphs[col].X - px < px - glyphs[col - 1].X)
				p = glyphs[col].Str.Location;
			return p;
		}

		public static void bndCaretPosition(this NvgContext ctx, float x, float y, float desc, float lineHeight,
			int caret, TextRow[] rows, int nrows, out int cr, out float cx, out float cy)
		{
			var r = 0;
			for (r = 0; r < nrows && rows[r].Str.Location + rows[r].Str.Length < caret; ++r)
			{
			}

			cr = r;
			cx = x;
			cy = y - lineHeight - desc + r * lineHeight;
			if (nrows == 0)
				return;
			cx = rows[r].MinX;
			var nglyphs = ctx.TextGlyphPositions(x, y, rows[r].Str, glyphs);
			for (var i = 0; i < nglyphs; ++i)
			{
				cx = glyphs[i].X;
				if (glyphs[i].Str.Location == caret)
					break;
			}
		}


		public static void bndIconLabelCaret(this NvgContext ctx, float x, float y, float w, float h, BNDicon? iconid,
			Color color, float fontsize, string label, Color caretcolor, int cbegin, int cend)
		{
			var pleft = (float)4;
			if (label == null)
				return;
			if (iconid != null)
			{
				bndIcon(ctx, x + 4, y + 2, iconid.Value);
				pleft += 16;
			}

			if (bnd_font < 0)
				return;
			x += pleft;
			y += BND_WIDGET_HEIGHT - 7;
			ctx.FontFaceId(bnd_font);
			ctx.FontSize(fontsize);
			ctx.TextAlign(Alignment.Left | Alignment.Baseline);
			w -= 4 + pleft;
			if (cend >= cbegin)
			{
				var c0r = 0;
				var c1r = 0;
				float c0x = 0;
				float c0y = 0;
				float c1x = 0;
				float c1y = 0;
				float asc = 0;
				float desc = 0;
				float lh = 0;
				StringSegment remaining;
				var nrows = ctx.TextBreakLines(label, w, _rows, out remaining);
				ctx.TextMetrics(out asc, out desc, out lh);
				bndCaretPosition(ctx, x, y, desc, lh, cbegin, _rows, nrows, out c0r, out c0x, out c0y);
				bndCaretPosition(ctx, x, y, desc, lh, cend, _rows, nrows, out c1r, out c1x, out c1y);
				ctx.BeginPath();
				if (cbegin == cend)
				{
					ctx.FillColor(new Color((float)0.337, (float)0.502, (float)0.761));
					ctx.Rect(c0x - 1, c0y, 2, lh + 1);
				}
				else
				{
					ctx.FillColor(caretcolor);
					if (c0r == c1r)
					{
						ctx.Rect(c0x - 1, c0y, c1x - c0x + 1, lh + 1);
					}
					else
					{
						var blk = c1r - c0r - 1;
						ctx.Rect(c0x - 1, c0y, x + w - c0x + 1, lh + 1);
						ctx.Rect(x, c1y, c1x - x + 1, lh + 1);
						if (blk != 0)
							ctx.Rect(x, c0y + lh, w, blk * lh + 1);
					}
				}

				ctx.Fill();
			}

			ctx.BeginPath();
			ctx.FillColor(color);
			ctx.TextBox(x, y, w, label);
		}

		public static void bndCheck(this NvgContext ctx, float ox, float oy, Color color)
		{
			ctx.BeginPath();
			ctx.StrokeWidth(2);
			ctx.StrokeColor(color);
			ctx.LineCap(LineCap.Butt);
			ctx.LineJoin(LineCap.Miter);
			ctx.MoveTo(ox + 4, oy + 5);
			ctx.LineTo(ox + 7, oy + 8);
			ctx.LineTo(ox + 14, oy + 1);
			ctx.Stroke();
		}

		public static void bndArrow(this NvgContext ctx, float x, float y, float s, Color color)
		{
			ctx.BeginPath();
			ctx.MoveTo(x, y);
			ctx.LineTo(x - s, y + s);
			ctx.LineTo(x - s, y - s);
			ctx.ClosePath();
			ctx.FillColor(color);
			ctx.Fill();
		}

		public static void bndUpDownArrow(this NvgContext ctx, float x, float y, float s, Color color)
		{
			float w = 0;
			ctx.BeginPath();
			w = 1.1f * s;
			ctx.MoveTo(x, y - 1);
			ctx.LineTo((float)(x + 0.5 * w), y - s - 1);
			ctx.LineTo(x + w, y - 1);
			ctx.ClosePath();
			ctx.MoveTo(x, y + 1);
			ctx.LineTo((float)(x + 0.5 * w), y + s + 1);
			ctx.LineTo(x + w, y + 1);
			ctx.ClosePath();
			ctx.FillColor(color);
			ctx.Fill();
		}

		public static void bndNodeArrowDown(this NvgContext ctx, float x, float y, float s, Color color)
		{
			float w = 0;
			ctx.BeginPath();
			w = 1.0f * s;
			ctx.MoveTo(x, y);
			ctx.LineTo((float)(x + 0.5 * w), y - s);
			ctx.LineTo((float)(x - 0.5 * w), y - s);
			ctx.ClosePath();
			ctx.FillColor(color);
			ctx.Fill();
		}

		public static void bndScrollHandleRect(float* x, float* y, float* w, float* h, float offset, float size)
		{
			size = bnd_clamp(size, 0, 1);
			offset = bnd_clamp(offset, 0, 1);
			if (*h > *w)
			{
				var hs = bnd_fmaxf(size * *h, *w + 1);
				*y = *y + (*h - hs) * offset;
				*h = hs;
			}
			else
			{
				var ws = bnd_fmaxf(size * *w, *h - 1);
				*x = *x + (*w - ws) * offset;
				*w = ws;
			}
		}

		public static Color bndNodeWireColor(NodeTheme theme, BNDwidgetState state)
		{
			switch (state)
			{
				default:
				case BNDwidgetState.BND_DEFAULT:
					return new Color(0.5f, 0.5f, 0.5f);
				case BNDwidgetState.BND_HOVER:
					return theme.wireSelectColor;
				case BNDwidgetState.BND_ACTIVE:
					return theme.activeNodeColor;
			}
		}
	}
}