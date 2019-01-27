using System;
using System.Runtime.InteropServices;
using FontStashSharp;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using NvgSharp;

namespace BlendishSharp
{
	public unsafe static partial class Blendish
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
				shadeDown = 0, // shade_down
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
				shadeDown = -15, // shade_down
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
				shadeDown = -15, // shade_down
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
				shadeDown = 25, // shade_down
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
				shadeDown = -15, // shade_down
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
				shadeDown = -15, // shade_down
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
				shadeDown = 0, // shade_down
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
				shadeDown = 0, // shade_down
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
				shadeDown = -5, // shade_down
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
				shadeDown = 0, // shade_down
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
				shadeDown = 0, // shade_down
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
				shadeDown = 0, // shade_down
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
				noodleCurving = 5, // noodleCurving
			},
		};
		private static int bnd_icon_image = (int)(-1), _defaultIconImage = -1;
		private static int bnd_font = (int)(-1), _defaultFont = -1;

		private static bool _fontLoaded = false;

		public static int DefaultIconImageId
		{
			get
			{
				return _defaultIconImage;
			}
		}

		public static int DefaultFontId
		{
			get
			{
				return _defaultFont;
			}
		}

		public static void bndSetDefaultResources(this NvgContext context, GraphicsDevice device)
		{
			if (!_fontLoaded)
			{
				_defaultFont = context.CreateFontMem("system", Resources.CreateTtfSystemByteArray());
				var texture = Resources.CreateIcons(device);
				var data = new byte[texture.Width * texture.Height * 4];
				texture.GetData(data);

				_defaultIconImage = context.CreateImageRGBA(texture.Width, texture.Height, 0, data);

				_fontLoaded = true;
			}

			bnd_font = _defaultFont;
			bnd_icon_image = _defaultIconImage;
		}

		public static void bndSetTheme(Theme theme)
		{
			bnd_theme = (Theme)(theme);
		}

		public static Theme bndGetTheme()
		{
			return bnd_theme;
		}

		public static void bndSetIconImage(int image)
		{
			bnd_icon_image = (int)(image);
		}

		public static void bndSetFont(int font)
		{
			bnd_font = (int)(font);
		}

		public static void bndLabel(this NvgContext ctx, float x, float y, float w, float h, BNDicon? iconid, string label)
		{
			bndIconLabelValue(ctx, (float)(x), (float)(y), (float)(w), (float)(h), iconid, (Color)(bnd_theme.regularTheme.textColor), (int)(BNDtextAlignment.BND_LEFT), (float)(13), label, null);
		}

		public static void bndToolButton(this NvgContext ctx, float x, float y, float w, float h, BNDcornerFlags flags, BNDwidgetState state, BNDicon? iconid, string label)
		{
			float* cr = stackalloc float[4];
			Color shade_top = new Color();
			Color shade_down = new Color();
			bndSelectCorners(cr, (float)(4), flags);
			bndBevelInset(ctx, (float)(x), (float)(y), (float)(w), (float)(h), (float)(cr[2]), (float)(cr[3]));
			bndInnerColors(ref shade_top, ref shade_down, bnd_theme.toolTheme, state, (int)(1));
			bndInnerBox(ctx, (float)(x), (float)(y), (float)(w), (float)(h), (float)(cr[0]), (float)(cr[1]), (float)(cr[2]), (float)(cr[3]), (Color)(shade_top), (Color)(shade_down));
			bndOutlineBox(ctx, (float)(x), (float)(y), (float)(w), (float)(h), (float)(cr[0]), (float)(cr[1]), (float)(cr[2]), (float)(cr[3]), (Color)(ColorExtensions.bndTransparent((Color)(bnd_theme.toolTheme.outlineColor))));
			bndIconLabelValue(ctx, (float)(x), (float)(y), (float)(w), (float)(h), iconid, (Color)(bndTextColor(bnd_theme.toolTheme, state)), BNDtextAlignment.BND_CENTER, (float)(13), label, null);
		}

		public static void bndRadioButton(this NvgContext ctx, float x, float y, float w, float h, BNDcornerFlags flags, BNDwidgetState state, BNDicon? iconid, string label)
		{
			float* cr = stackalloc float[4];
			Color shade_top = new Color();
			Color shade_down = new Color();
			bndSelectCorners(cr, (float)(4), flags);
			bndBevelInset(ctx, (float)(x), (float)(y), (float)(w), (float)(h), (float)(cr[2]), (float)(cr[3]));
			bndInnerColors(ref shade_top, ref shade_down, bnd_theme.radioTheme, state, (int)(1));
			bndInnerBox(ctx, (float)(x), (float)(y), (float)(w), (float)(h), (float)(cr[0]), (float)(cr[1]), (float)(cr[2]), (float)(cr[3]), (Color)(shade_top), (Color)(shade_down));
			bndOutlineBox(ctx, (float)(x), (float)(y), (float)(w), (float)(h), (float)(cr[0]), (float)(cr[1]), (float)(cr[2]), (float)(cr[3]), (Color)(ColorExtensions.bndTransparent((Color)(bnd_theme.radioTheme.outlineColor))));
			bndIconLabelValue(ctx, (float)(x), (float)(y), (float)(w), (float)(h), iconid, (Color)(bndTextColor(bnd_theme.radioTheme, state)), BNDtextAlignment.BND_CENTER, (float)(13), label, null);
		}

		public static int bndTextFieldTextPosition(this NvgContext ctx, float x, float y, float w, float h, BNDicon? iconid, string text, int px, int py)
		{
			return (int)(bndIconLabelTextPosition(ctx, (float)(x), (float)(y), (float)(w), (float)(h), iconid, (float)(13), text, (int)(px), (int)(py)));
		}

		public static void bndTextField(this NvgContext ctx, float x, float y, float w, float h, BNDcornerFlags flags, BNDwidgetState state, BNDicon? iconid, string text, int cbegin, int cend)
		{
			float* cr = stackalloc float[4];
			Color shade_top = new Color();
			Color shade_down = new Color();
			bndSelectCorners(cr, (float)(4), flags);
			bndBevelInset(ctx, (float)(x), (float)(y), (float)(w), (float)(h), (float)(cr[2]), (float)(cr[3]));
			bndInnerColors(ref shade_top, ref shade_down, bnd_theme.textFieldTheme, state, (int)(0));
			bndInnerBox(ctx, (float)(x), (float)(y), (float)(w), (float)(h), (float)(cr[0]), (float)(cr[1]), (float)(cr[2]), (float)(cr[3]), (Color)(shade_top), (Color)(shade_down));
			bndOutlineBox(ctx, (float)(x), (float)(y), (float)(w), (float)(h), (float)(cr[0]), (float)(cr[1]), (float)(cr[2]), (float)(cr[3]), (Color)(ColorExtensions.bndTransparent((Color)(bnd_theme.textFieldTheme.outlineColor))));
			if (state != BNDwidgetState.BND_ACTIVE)
			{
				cend = (int)(-1);
			}

			bndIconLabelCaret(ctx, (float)(x), (float)(y), (float)(w), (float)(h), iconid, (Color)(bndTextColor(bnd_theme.textFieldTheme, state)), (float)(13), text, (Color)(bnd_theme.textFieldTheme.itemColor), (int)(cbegin), (int)(cend));
		}

		public static void bndOptionButton(this NvgContext ctx, float x, float y, float w, float h, BNDwidgetState state, string label)
		{
			float ox = 0;
			float oy = 0;
			Color shade_top = new Color();
			Color shade_down = new Color();
			ox = (float)(x);
			oy = (float)(y + h - 15 - 3);
			bndBevelInset(ctx, (float)(ox), (float)(oy), (float)(14), (float)(15), (float)(4), (float)(4));
			bndInnerColors(ref shade_top, ref shade_down, bnd_theme.optionTheme, state, (int)(1));
			bndInnerBox(ctx, (float)(ox), (float)(oy), (float)(14), (float)(15), (float)(4), (float)(4), (float)(4), (float)(4), (Color)(shade_top), (Color)(shade_down));
			bndOutlineBox(ctx, (float)(ox), (float)(oy), (float)(14), (float)(15), (float)(4), (float)(4), (float)(4), (float)(4), (Color)(ColorExtensions.bndTransparent((Color)(bnd_theme.optionTheme.outlineColor))));
			if ((state) == (BNDwidgetState.BND_ACTIVE))
			{
				bndCheck(ctx, (float)(ox), (float)(oy), (Color)(ColorExtensions.bndTransparent((Color)(bnd_theme.optionTheme.itemColor))));
			}

			bndIconLabelValue(ctx, (float)(x + 12), (float)(y), (float)(w - 12), (float)(h), null, (Color)(bndTextColor(bnd_theme.optionTheme, state)), (int)(BNDtextAlignment.BND_LEFT), (float)(13), label, null);
		}

		public static void bndChoiceButton(this NvgContext ctx, float x, float y, float w, float h, BNDcornerFlags flags, BNDwidgetState state, BNDicon? iconid, string label)
		{
			float* cr = stackalloc float[4];
			Color shade_top = new Color();
			Color shade_down = new Color();
			bndSelectCorners(cr, (float)(4), flags);
			bndBevelInset(ctx, (float)(x), (float)(y), (float)(w), (float)(h), (float)(cr[2]), (float)(cr[3]));
			bndInnerColors(ref shade_top, ref shade_down, bnd_theme.choiceTheme, state, (int)(1));
			bndInnerBox(ctx, (float)(x), (float)(y), (float)(w), (float)(h), (float)(cr[0]), (float)(cr[1]), (float)(cr[2]), (float)(cr[3]), (Color)(shade_top), (Color)(shade_down));
			bndOutlineBox(ctx, (float)(x), (float)(y), (float)(w), (float)(h), (float)(cr[0]), (float)(cr[1]), (float)(cr[2]), (float)(cr[3]), (Color)(ColorExtensions.bndTransparent((Color)(bnd_theme.choiceTheme.outlineColor))));
			bndIconLabelValue(ctx, (float)(x), (float)(y), (float)(w), (float)(h), iconid, (Color)(bndTextColor(bnd_theme.choiceTheme, state)), (int)(BNDtextAlignment.BND_LEFT), (float)(13), label, null);
			bndUpDownArrow(ctx, (float)(x + w - 10), (float)(y + 10), (float)(5), (Color)(ColorExtensions.bndTransparent((Color)(bnd_theme.choiceTheme.itemColor))));
		}

		public static void bndColorButton(this NvgContext ctx, float x, float y, float w, float h, BNDcornerFlags flags, Color color)
		{
			float* cr = stackalloc float[4];
			bndSelectCorners(cr, (float)(4), flags);
			bndBevelInset(ctx, (float)(x), (float)(y), (float)(w), (float)(h), (float)(cr[2]), (float)(cr[3]));
			bndInnerBox(ctx, (float)(x), (float)(y), (float)(w), (float)(h), (float)(cr[0]), (float)(cr[1]), (float)(cr[2]), (float)(cr[3]), (Color)(color), (Color)(color));
			bndOutlineBox(ctx, (float)(x), (float)(y), (float)(w), (float)(h), (float)(cr[0]), (float)(cr[1]), (float)(cr[2]), (float)(cr[3]), (Color)(ColorExtensions.bndTransparent((Color)(bnd_theme.toolTheme.outlineColor))));
		}

		public static void bndNumberField(this NvgContext ctx, float x, float y, float w, float h, BNDcornerFlags flags, BNDwidgetState state, string label, string value)
		{
			float* cr = stackalloc float[4];
			Color shade_top = new Color();
			Color shade_down = new Color();
			bndSelectCorners(cr, (float)(10), flags);
			bndBevelInset(ctx, (float)(x), (float)(y), (float)(w), (float)(h), (float)(cr[2]), (float)(cr[3]));
			bndInnerColors(ref shade_top, ref shade_down, bnd_theme.numberFieldTheme, state, (int)(0));
			bndInnerBox(ctx, (float)(x), (float)(y), (float)(w), (float)(h), (float)(cr[0]), (float)(cr[1]), (float)(cr[2]), (float)(cr[3]), (Color)(shade_top), (Color)(shade_down));
			bndOutlineBox(ctx, (float)(x), (float)(y), (float)(w), (float)(h), (float)(cr[0]), (float)(cr[1]), (float)(cr[2]), (float)(cr[3]), (Color)(ColorExtensions.bndTransparent((Color)(bnd_theme.numberFieldTheme.outlineColor))));
			bndIconLabelValue(ctx, (float)(x), (float)(y), (float)(w), (float)(h), null, (Color)(bndTextColor(bnd_theme.numberFieldTheme, state)), BNDtextAlignment.BND_CENTER, (float)(13), label, value);
			bndArrow(ctx, (float)(x + 8), (float)(y + 10), (float)(-4), (Color)(ColorExtensions.bndTransparent((Color)(bnd_theme.numberFieldTheme.itemColor))));
			bndArrow(ctx, (float)(x + w - 8), (float)(y + 10), (float)(4), (Color)(ColorExtensions.bndTransparent((Color)(bnd_theme.numberFieldTheme.itemColor))));
		}

		public static void bndSlider(this NvgContext ctx, float x, float y, float w, float h, BNDcornerFlags flags, BNDwidgetState state, float progress, string label, string value)
		{
			float* cr = stackalloc float[4];
			Color shade_top = new Color();
			Color shade_down = new Color();
			bndSelectCorners(cr, (float)(10), flags);
			bndBevelInset(ctx, (float)(x), (float)(y), (float)(w), (float)(h), (float)(cr[2]), (float)(cr[3]));
			bndInnerColors(ref shade_top, ref shade_down, bnd_theme.sliderTheme, state, (int)(0));
			bndInnerBox(ctx, (float)(x), (float)(y), (float)(w), (float)(h), (float)(cr[0]), (float)(cr[1]), (float)(cr[2]), (float)(cr[3]), (Color)(shade_top), (Color)(shade_down));
			if ((state) == (BNDwidgetState.BND_ACTIVE))
			{
				shade_top = (Color)(ColorExtensions.bndOffsetColor((Color)(bnd_theme.sliderTheme.itemColor), (int)(bnd_theme.sliderTheme.shadeTop)));
				shade_down = (Color)(ColorExtensions.bndOffsetColor((Color)(bnd_theme.sliderTheme.itemColor), (int)(bnd_theme.sliderTheme.shadeDown)));
			}
			else
			{
				shade_top = (Color)(ColorExtensions.bndOffsetColor((Color)(bnd_theme.sliderTheme.itemColor), (int)(bnd_theme.sliderTheme.shadeDown)));
				shade_down = (Color)(ColorExtensions.bndOffsetColor((Color)(bnd_theme.sliderTheme.itemColor), (int)(bnd_theme.sliderTheme.shadeTop)));
			}

			ctx.Scissor((float)(x), (float)(y), (float)(8 + (w - 8) * bnd_clamp((float)(progress), (float)(0), (float)(1))), (float)(h));
			bndInnerBox(ctx, (float)(x), (float)(y), (float)(w), (float)(h), (float)(cr[0]), (float)(cr[1]), (float)(cr[2]), (float)(cr[3]), (Color)(shade_top), (Color)(shade_down));
			ctx.ResetScissor();
			bndOutlineBox(ctx, (float)(x), (float)(y), (float)(w), (float)(h), (float)(cr[0]), (float)(cr[1]), (float)(cr[2]), (float)(cr[3]), (Color)(ColorExtensions.bndTransparent((Color)(bnd_theme.sliderTheme.outlineColor))));
			bndIconLabelValue(ctx, (float)(x), (float)(y), (float)(w), (float)(h), null, (Color)(bndTextColor(bnd_theme.sliderTheme, state)), BNDtextAlignment.BND_CENTER, (float)(13), label, value);
		}

		public static void bndScrollBar(this NvgContext ctx, float x, float y, float w, float h, BNDwidgetState state, float offset, float size)
		{
			bndBevelInset(ctx, (float)(x), (float)(y), (float)(w), (float)(h), (float)(7), (float)(7));
			bndInnerBox(ctx, (float)(x), (float)(y), (float)(w), (float)(h), (float)(7), (float)(7), (float)(7), (float)(7), (Color)(ColorExtensions.bndOffsetColor((Color)(bnd_theme.scrollBarTheme.innerColor), (int)(3 * bnd_theme.scrollBarTheme.shadeDown))), (Color)(ColorExtensions.bndOffsetColor((Color)(bnd_theme.scrollBarTheme.innerColor), (int)(3 * bnd_theme.scrollBarTheme.shadeTop))));
			bndOutlineBox(ctx, (float)(x), (float)(y), (float)(w), (float)(h), (float)(7), (float)(7), (float)(7), (float)(7), (Color)(ColorExtensions.bndTransparent((Color)(bnd_theme.scrollBarTheme.outlineColor))));
			Color itemColor = (Color)(ColorExtensions.bndOffsetColor((Color)(bnd_theme.scrollBarTheme.itemColor), (int)(((state) == (BNDwidgetState.BND_ACTIVE)) ? 15 : 0)));
			bndScrollHandleRect(&x, &y, &w, &h, (float)(offset), (float)(size));
			bndInnerBox(ctx, (float)(x), (float)(y), (float)(w), (float)(h), (float)(7), (float)(7), (float)(7), (float)(7), (Color)(ColorExtensions.bndOffsetColor((Color)(itemColor), (int)(3 * bnd_theme.scrollBarTheme.shadeTop))), (Color)(ColorExtensions.bndOffsetColor((Color)(itemColor), (int)(3 * bnd_theme.scrollBarTheme.shadeDown))));
			bndOutlineBox(ctx, (float)(x), (float)(y), (float)(w), (float)(h), (float)(7), (float)(7), (float)(7), (float)(7), (Color)(ColorExtensions.bndTransparent((Color)(bnd_theme.scrollBarTheme.outlineColor))));
		}

		public static void bndMenuBackground(this NvgContext ctx, float x, float y, float w, float h, BNDcornerFlags flags)
		{
			float* cr = stackalloc float[4];
			Color shade_top = new Color();
			Color shade_down = new Color();
			bndSelectCorners(cr, (float)(3), flags);
			bndInnerColors(ref shade_top, ref shade_down, bnd_theme.menuTheme, (int)(BNDwidgetState.BND_DEFAULT), (int)(0));
			bndInnerBox(ctx, (float)(x), (float)(y), (float)(w), (float)(h + 1), (float)(cr[0]), (float)(cr[1]), (float)(cr[2]), (float)(cr[3]), (Color)(shade_top), (Color)(shade_down));
			bndOutlineBox(ctx, (float)(x), (float)(y), (float)(w), (float)(h + 1), (float)(cr[0]), (float)(cr[1]), (float)(cr[2]), (float)(cr[3]), (Color)(ColorExtensions.bndTransparent((Color)(bnd_theme.menuTheme.outlineColor))));
			bndDropShadow(ctx, (float)(x), (float)(y), (float)(w), (float)(h), (float)(3), (float)(12), (float)(0.5));
		}

		public static void bndTooltipBackground(this NvgContext ctx, float x, float y, float w, float h)
		{
			Color shade_top = new Color();
			Color shade_down = new Color();
			bndInnerColors(ref shade_top, ref shade_down, bnd_theme.tooltipTheme, (int)(BNDwidgetState.BND_DEFAULT), (int)(0));
			bndInnerBox(ctx, (float)(x), (float)(y), (float)(w), (float)(h + 1), (float)(3), (float)(3), (float)(3), (float)(3), (Color)(shade_top), (Color)(shade_down));
			bndOutlineBox(ctx, (float)(x), (float)(y), (float)(w), (float)(h + 1), (float)(3), (float)(3), (float)(3), (float)(3), (Color)(ColorExtensions.bndTransparent((Color)(bnd_theme.tooltipTheme.outlineColor))));
			bndDropShadow(ctx, (float)(x), (float)(y), (float)(w), (float)(h), (float)(3), (float)(12), (float)(0.5));
		}

		public static void bndMenuLabel(this NvgContext ctx, float x, float y, float w, float h, BNDicon? iconid, string label)
		{
			bndIconLabelValue(ctx, (float)(x), (float)(y), (float)(w), (float)(h), iconid, (Color)(bnd_theme.menuTheme.textColor), (int)(BNDtextAlignment.BND_LEFT), (float)(13), label, null);
		}

		public static void bndMenuItem(this NvgContext ctx, float x, float y, float w, float h, BNDwidgetState state, BNDicon? iconid, string label)
		{
			if (state != BNDwidgetState.BND_DEFAULT)
			{
				bndInnerBox(ctx, (float)(x), (float)(y), (float)(w), (float)(h), (float)(0), (float)(0), (float)(0), (float)(0), (Color)(ColorExtensions.bndOffsetColor((Color)(bnd_theme.menuItemTheme.innerSelectedColor), (int)(bnd_theme.menuItemTheme.shadeTop))), (Color)(ColorExtensions.bndOffsetColor((Color)(bnd_theme.menuItemTheme.innerSelectedColor), (int)(bnd_theme.menuItemTheme.shadeDown))));
				state = BNDwidgetState.BND_ACTIVE;
			}

			bndIconLabelValue(ctx, (float)(x), (float)(y), (float)(w), (float)(h), iconid, (Color)(bndTextColor(bnd_theme.menuItemTheme, state)), (int)(BNDtextAlignment.BND_LEFT), (float)(13), label, null);
		}

		public static void bndNodePort(this NvgContext ctx, float x, float y, BNDwidgetState state, Color color)
		{
			ctx.BeginPath();
			ctx.Circle((float)(x), (float)(y), (float)(BND_NODE_PORT_RADIUS));
			ctx.StrokeColor((Color)(bnd_theme.nodeTheme.wiresColor));
			ctx.StrokeWidth((float)(1.0f));
			ctx.Stroke();
			ctx.FillColor((Color)((state != BNDwidgetState.BND_DEFAULT) ? ColorExtensions.bndOffsetColor((Color)(color), (int)(15)) : color));
			ctx.Fill();
		}

		internal static float fabsf(float a)
		{
			return (float)((a) >= (0.0f) ? a : -a);
		}

		public static void bndColoredNodeWire(this NvgContext ctx, float x0, float y0, float x1, float y1, Color color0, Color color1)
		{
			float length = (float)(bnd_fmaxf((float)(fabsf((float)(x1 - x0))), (float)(fabsf((float)(y1 - y0)))));
			float delta = (float)(length * (float)(bnd_theme.nodeTheme.noodleCurving) / 10.0f);
			ctx.BeginPath();
			ctx.MoveTo((float)(x0), (float)(y0));
			ctx.BezierTo((float)(x0 + delta), (float)(y0), (float)(x1 - delta), (float)(y1), (float)(x1), (float)(y1));
			Color colorw = (Color)(bnd_theme.nodeTheme.wiresColor);
			colorw.A = (((color0.A) < (color1.A)) ? color0.A : color1.A);
			ctx.StrokeColor((Color)(colorw));
			ctx.StrokeWidth((float)(4));
			ctx.Stroke();
			ctx.StrokePaint((ctx.LinearGradient((float)(x0), (float)(y0), (float)(x1), (float)(y1), (Color)(color0), (Color)(color1))));
			ctx.StrokeWidth((float)(2));
			ctx.Stroke();
		}

		public static void bndNodeWire(this NvgContext ctx, float x0, float y0, float x1, float y1, BNDwidgetState state0, BNDwidgetState state1)
		{
			bndColoredNodeWire(ctx, (float)(x0), (float)(y0), (float)(x1), (float)(y1), (Color)(bndNodeWireColor(bnd_theme.nodeTheme, state0)), (Color)(bndNodeWireColor(bnd_theme.nodeTheme, state1)));
		}

		public static void bndNodeBackground(this NvgContext ctx, float x, float y, float w, float h, BNDwidgetState state, BNDicon? iconid, string label, Color titleColor)
		{
			bndInnerBox(ctx, (float)(x), (float)(y), (float)(w), (float)(BND_NODE_TITLE_HEIGHT + 2), (float)(8), (float)(8), (float)(0), (float)(0), (Color)(ColorExtensions.bndTransparent((Color)(ColorExtensions.bndOffsetColor((Color)(titleColor), (int)(30))))), (Color)(ColorExtensions.bndTransparent((Color)(titleColor))));
			bndInnerBox(ctx, (float)(x), (float)(y + BND_NODE_TITLE_HEIGHT - 1), (float)(w), (float)(h + 2 - BND_NODE_TITLE_HEIGHT), (float)(0), (float)(0), (float)(8), (float)(8), (Color)(ColorExtensions.bndTransparent((Color)(bnd_theme.nodeTheme.nodeBackdropColor))), (Color)(ColorExtensions.bndTransparent((Color)(bnd_theme.nodeTheme.nodeBackdropColor))));
			bndNodeIconLabel(ctx, (float)(x + BND_NODE_ARROW_AREA_WIDTH), (float)(y), (float)(w - BND_NODE_ARROW_AREA_WIDTH - BND_NODE_MARGIN_SIDE), (float)(BND_NODE_TITLE_HEIGHT), iconid, (Color)(bnd_theme.regularTheme.textColor), (Color)(ColorExtensions.bndOffsetColor((Color)(titleColor), (int)(30))), (int)(BNDtextAlignment.BND_LEFT), (float)(13), label);
			Color arrowColor = new Color();
			Color borderColor = new Color();
			switch (state)
			{
				default:
				case BNDwidgetState.BND_DEFAULT:
					{
						borderColor = (Color)(new Color((float)(0), (float)(0), (float)(0)));
						arrowColor = (Color)(ColorExtensions.bndOffsetColor((Color)(titleColor), (int)(-30)));
					}
					break;
				case BNDwidgetState.BND_HOVER:
					{
						borderColor = (Color)(bnd_theme.nodeTheme.nodeSelectedColor);
						arrowColor = (Color)(bnd_theme.nodeTheme.nodeSelectedColor);
					}
					break;
				case BNDwidgetState.BND_ACTIVE:
					{
						borderColor = (Color)(bnd_theme.nodeTheme.activeNodeColor);
						arrowColor = (Color)(bnd_theme.nodeTheme.nodeSelectedColor);
					}
					break;
			}

			bndOutlineBox(ctx, (float)(x), (float)(y), (float)(w), (float)(h + 1), (float)(8), (float)(8), (float)(8), (float)(8), (Color)(ColorExtensions.bndTransparent((Color)(borderColor))));
			bndDropShadow(ctx, (float)(x), (float)(y), (float)(w), (float)(h), (float)(8), (float)(12), (float)(0.5));
		}

		public static void bndSplitterWidgets(this NvgContext ctx, float x, float y, float w, float h)
		{
			Color insetLight = (Color)(ColorExtensions.bndTransparent((Color)(ColorExtensions.bndOffsetColor((Color)(bnd_theme.backgroundColor), (int)(100)))));
			Color insetDark = (Color)(ColorExtensions.bndTransparent((Color)(ColorExtensions.bndOffsetColor((Color)(bnd_theme.backgroundColor), (int)(-100)))));
			Color inset = (Color)(ColorExtensions.bndTransparent((Color)(bnd_theme.backgroundColor)));
			float x2 = (float)(x + w);
			float y2 = (float)(y + h);
			ctx.BeginPath();
			ctx.MoveTo((float)(x), (float)(y2 - 13));
			ctx.LineTo((float)(x + 13), (float)(y2));
			ctx.MoveTo((float)(x), (float)(y2 - 9));
			ctx.LineTo((float)(x + 9), (float)(y2));
			ctx.MoveTo((float)(x), (float)(y2 - 5));
			ctx.LineTo((float)(x + 5), (float)(y2));
			ctx.MoveTo((float)(x2 - 11), (float)(y));
			ctx.LineTo((float)(x2), (float)(y + 11));
			ctx.MoveTo((float)(x2 - 7), (float)(y));
			ctx.LineTo((float)(x2), (float)(y + 7));
			ctx.MoveTo((float)(x2 - 3), (float)(y));
			ctx.LineTo((float)(x2), (float)(y + 3));
			ctx.StrokeColor((Color)(insetDark));
			ctx.Stroke();
			ctx.BeginPath();
			ctx.MoveTo((float)(x), (float)(y2 - 11));
			ctx.LineTo((float)(x + 11), (float)(y2));
			ctx.MoveTo((float)(x), (float)(y2 - 7));
			ctx.LineTo((float)(x + 7), (float)(y2));
			ctx.MoveTo((float)(x), (float)(y2 - 3));
			ctx.LineTo((float)(x + 3), (float)(y2));
			ctx.MoveTo((float)(x2 - 13), (float)(y));
			ctx.LineTo((float)(x2), (float)(y + 13));
			ctx.MoveTo((float)(x2 - 9), (float)(y));
			ctx.LineTo((float)(x2), (float)(y + 9));
			ctx.MoveTo((float)(x2 - 5), (float)(y));
			ctx.LineTo((float)(x2), (float)(y + 5));
			ctx.StrokeColor((Color)(insetLight));
			ctx.Stroke();
			ctx.BeginPath();
			ctx.MoveTo((float)(x), (float)(y2 - 12));
			ctx.LineTo((float)(x + 12), (float)(y2));
			ctx.MoveTo((float)(x), (float)(y2 - 8));
			ctx.LineTo((float)(x + 8), (float)(y2));
			ctx.MoveTo((float)(x), (float)(y2 - 4));
			ctx.LineTo((float)(x + 4), (float)(y2));
			ctx.MoveTo((float)(x2 - 12), (float)(y));
			ctx.LineTo((float)(x2), (float)(y + 12));
			ctx.MoveTo((float)(x2 - 8), (float)(y));
			ctx.LineTo((float)(x2), (float)(y + 8));
			ctx.MoveTo((float)(x2 - 4), (float)(y));
			ctx.LineTo((float)(x2), (float)(y + 4));
			ctx.StrokeColor((Color)(inset));
			ctx.Stroke();
		}

		public static void bndJoinAreaOverlay(this NvgContext ctx, float x, float y, float w, float h, bool vertical, bool mirror)
		{
			if (vertical)
			{
				float u = (float)(w);
				w = (float)(h);
				h = (float)(u);
			}

			float s = (float)(((w) < (h)) ? w : h);
			float x0 = 0;
			float y0 = 0;
			float x1 = 0;
			float y1 = 0;
			if (mirror)
			{
				x0 = (float)(w);
				y0 = (float)(h);
				x1 = (float)(0);
				y1 = (float)(0);
				s = (float)(-s);
			}
			else
			{
				x0 = (float)(0);
				y0 = (float)(0);
				x1 = (float)(w);
				y1 = (float)(h);
			}

			float yc = (float)((y0 + y1) * 0.5f);
			float s2 = (float)(s / 2.0f);
			float s4 = (float)(s / 4.0f);
			float s8 = (float)(s / 8.0f);
			float x4 = (float)(x0 + s4);
			Vector2* points = stackalloc Vector2[11];
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
			{
				ctx.MoveTo((float)(x + points[0].X), (float)(y + points[0].Y));

			}
			else
			{
				ctx.MoveTo((float)(x + points[0].Y), (float)(y + points[0].X));
			}

			for (int i = 1; i < 11; ++i)
			{
				if (!vertical)
				{
					ctx.LineTo((float)(x + points[i].X), (float)(y + points[i].Y));

				}
				else
				{
					ctx.LineTo((float)(x + points[i].Y), (float)(y + points[i].X));
				}
			}
			ctx.FillColor((Color)(new Color((float)(0), (float)(0), (float)(0), (float)(0.3))));
			ctx.Fill();
		}

		public static float bndLabelWidth(this NvgContext ctx, BNDicon? iconid, string label)
		{
			int w = (int)(8 + 8);
			if (iconid != null)
			{
				w += (int)(16);
			}

			if (((label) != null) && ((bnd_font) >= (0)))
			{
				ctx.FontFaceId((int)(bnd_font));
				ctx.FontSize((float)(13));

				Bounds b = new Bounds();
				w += (int)(ctx.TextBounds((float)(1), (float)(1), label, ref b));
			}

			return (float)(w);
		}

		public static float bndLabelHeight(this NvgContext ctx, BNDicon? iconid, string label, float width)
		{
			int h = (int)(BND_WIDGET_HEIGHT);
			width -= (float)(4 * 2);
			if (iconid != null)
			{
				width -= (float)(16);
			}

			if (((label) != null) && ((bnd_font) >= (0)))
			{
				ctx.FontFaceId((int)(bnd_font));
				ctx.FontSize((float)(13));
				Bounds bounds = new Bounds();
				ctx.TextBoxBounds((float)(1), (float)(1), (float)(width), label, ref bounds);
				int bh = 0;
				if ((bh) > (h))
					h = (int)(bh);
			}

			return (float)(h);
		}

		public static void bndRoundedBox(this NvgContext ctx, float x, float y, float w, float h, float cr0, float cr1, float cr2, float cr3)
		{
			float d = 0;
			w = (float)(bnd_fmaxf((float)(0), (float)(w)));
			h = (float)(bnd_fmaxf((float)(0), (float)(h)));
			d = (float)(bnd_fminf((float)(w), (float)(h)));
			ctx.MoveTo((float)(x), (float)(y + h * 0.5f));
			ctx.ArcTo((float)(x), (float)(y), (float)(x + w), (float)(y), (float)(bnd_fminf((float)(cr0), (float)(d / 2))));
			ctx.ArcTo((float)(x + w), (float)(y), (float)(x + w), (float)(y + h), (float)(bnd_fminf((float)(cr1), (float)(d / 2))));
			ctx.ArcTo((float)(x + w), (float)(y + h), (float)(x), (float)(y + h), (float)(bnd_fminf((float)(cr2), (float)(d / 2))));
			ctx.ArcTo((float)(x), (float)(y + h), (float)(x), (float)(y), (float)(bnd_fminf((float)(cr3), (float)(d / 2))));
			ctx.ClosePath();
		}

		public static void bndBevel(this NvgContext ctx, float x, float y, float w, float h)
		{
			ctx.StrokeWidth((float)(1));
			x += (float)(0.5f);
			y += (float)(0.5f);
			w -= (float)(1);
			h -= (float)(1);
			ctx.BeginPath();
			ctx.MoveTo((float)(x), (float)(y + h));
			ctx.LineTo((float)(x + w), (float)(y + h));
			ctx.LineTo((float)(x + w), (float)(y));
			ctx.StrokeColor((Color)(ColorExtensions.bndTransparent((Color)(ColorExtensions.bndOffsetColor((Color)(bnd_theme.backgroundColor), (int)(-30))))));
			ctx.Stroke();
			ctx.BeginPath();
			ctx.MoveTo((float)(x), (float)(y + h));
			ctx.LineTo((float)(x), (float)(y));
			ctx.LineTo((float)(x + w), (float)(y));
			ctx.StrokeColor((Color)(ColorExtensions.bndTransparent((Color)(ColorExtensions.bndOffsetColor((Color)(bnd_theme.backgroundColor), (int)(30))))));
			ctx.Stroke();
		}

		public static void bndBevelInset(this NvgContext ctx, float x, float y, float w, float h, float cr2, float cr3)
		{
			float d = 0;
			y -= (float)(0.5f);
			d = (float)(bnd_fminf((float)(w), (float)(h)));
			cr2 = (float)(bnd_fminf((float)(cr2), (float)(d / 2)));
			cr3 = (float)(bnd_fminf((float)(cr3), (float)(d / 2)));
			ctx.BeginPath();
			ctx.MoveTo((float)(x + w), (float)(y + h - cr2));
			ctx.ArcTo((float)(x + w), (float)(y + h), (float)(x), (float)(y + h), (float)(cr2));
			ctx.ArcTo((float)(x), (float)(y + h), (float)(x), (float)(y), (float)(cr3));
			Color bevelColor = (Color)(ColorExtensions.bndOffsetColor((Color)(bnd_theme.backgroundColor), (int)(30)));
			ctx.StrokeWidth((float)(1));
			ctx.StrokePaint((ctx.LinearGradient((float)(x), (float)(y + h - bnd_fmaxf((float)(cr2), (float)(cr3)) - 1), (float)(x), (float)(y + h - 1),
				(Color)(new Color(bevelColor.R, bevelColor.G, bevelColor.B, (float)(0))), (Color)(bevelColor))));
			ctx.Stroke();
		}

		public static void bndBackground(this NvgContext ctx, float x, float y, float w, float h)
		{
			ctx.BeginPath();
			ctx.Rect((float)(x), (float)(y), (float)(w), (float)(h));
			ctx.FillColor((Color)(bnd_theme.backgroundColor));
			ctx.Fill();
		}

		public static void bndIcon(this NvgContext ctx, float x, float y, BNDicon iconid)
		{
			int ix = 0;
			int iy = 0;
			int u = 0;
			int v = 0;
			if ((bnd_icon_image) < (0))
				return;
			ix = (int)((int)iconid & 0xff);
			iy = (int)(((int)iconid >> 8) & 0xff);
			u = (int)(5 + ix * 21);
			v = (int)(10 + iy * 21);
			ctx.BeginPath();
			ctx.Rect((float)(x), (float)(y), (float)(16), (float)(16));
			ctx.FillPaint((ctx.ImagePattern((float)(x - u), (float)(y - v), (float)(602), (float)(640), (float)(0), (int)(bnd_icon_image), (float)(1))));
			ctx.Fill();
		}

		public static void bndDropShadow(this NvgContext ctx, float x, float y, float w, float h, float r, float feather, float alpha)
		{
			ctx.BeginPath();
			y += (float)(feather);
			h -= (float)(feather);
			ctx.MoveTo((float)(x - feather), (float)(y - feather));
			ctx.LineTo((float)(x), (float)(y - feather));
			ctx.LineTo((float)(x), (float)(y + h - feather));
			ctx.ArcTo((float)(x), (float)(y + h), (float)(x + r), (float)(y + h), (float)(r));
			ctx.ArcTo((float)(x + w), (float)(y + h), (float)(x + w), (float)(y + h - r), (float)(r));
			ctx.LineTo((float)(x + w), (float)(y - feather));
			ctx.LineTo((float)(x + w + feather), (float)(y - feather));
			ctx.LineTo((float)(x + w + feather), (float)(y + h + feather));
			ctx.LineTo((float)(x - feather), (float)(y + h + feather));
			ctx.ClosePath();
			ctx.FillPaint((ctx.BoxGradient((float)(x - feather * 0.5f), (float)(y - feather * 0.5f), (float)(w + feather), (float)(h + feather), (float)(r + feather * 0.5f), (float)(feather), (Color)(new Color((float)(0), (float)(0), (float)(0), (float)(alpha * alpha))), (Color)(new Color((float)(0), (float)(0), (float)(0), (float)(0))))));
			ctx.Fill();
		}

		public static void bndInnerBox(this NvgContext ctx, float x, float y, float w, float h, float cr0, float cr1, float cr2, float cr3, Color shade_top, Color shade_down)
		{
			ctx.BeginPath();
			bndRoundedBox(ctx, (float)(x + 1), (float)(y + 1), (float)(w - 2), (float)(h - 3), (float)(bnd_fmaxf((float)(0), (float)(cr0 - 1))), (float)(bnd_fmaxf((float)(0), (float)(cr1 - 1))), (float)(bnd_fmaxf((float)(0), (float)(cr2 - 1))), (float)(bnd_fmaxf((float)(0), (float)(cr3 - 1))));
			ctx.FillPaint((((h - 2) > (w)) ? ctx.LinearGradient((float)(x), (float)(y), (float)(x + w), (float)(y), (Color)(shade_top), (Color)(shade_down)) : ctx.LinearGradient((float)(x), (float)(y), (float)(x), (float)(y + h), (Color)(shade_top), (Color)(shade_down))));
			ctx.Fill();
		}

		public static void bndOutlineBox(this NvgContext ctx, float x, float y, float w, float h, float cr0, float cr1, float cr2, float cr3, Color color)
		{
			ctx.BeginPath();
			bndRoundedBox(ctx, (float)(x + 0.5f), (float)(y + 0.5f), (float)(w - 1), (float)(h - 2), (float)(cr0), (float)(cr1), (float)(cr2), (float)(cr3));
			ctx.StrokeColor((Color)(color));
			ctx.StrokeWidth((float)(1));
			ctx.Stroke();
		}

		public static void bndSelectCorners(float* radiuses, float r, BNDcornerFlags flags)
		{
			radiuses[0] = (float)((flags & BNDcornerFlags.BND_CORNER_TOP_LEFT) != 0 ? 0 : r);
			radiuses[1] = (float)((flags & BNDcornerFlags.BND_CORNER_TOP_RIGHT) != 0 ? 0 : r);
			radiuses[2] = (float)((flags & BNDcornerFlags.BND_CORNER_DOWN_RIGHT) != 0 ? 0 : r);
			radiuses[3] = (float)((flags & BNDcornerFlags.BND_CORNER_DOWN_LEFT) != 0 ? 0 : r);
		}

		public static void bndInnerColors(ref Color shade_top, ref Color shade_down, WidgetTheme theme, BNDwidgetState state, int flipActive)
		{
			switch (state)
			{
				default:
				case BNDwidgetState.BND_DEFAULT:
					{
						shade_top = (Color)(ColorExtensions.bndOffsetColor((Color)(theme.innerColor), (int)(theme.shadeTop)));
						shade_down = (Color)(ColorExtensions.bndOffsetColor((Color)(theme.innerColor), (int)(theme.shadeDown)));
					}
					break;
				case BNDwidgetState.BND_HOVER:
					{
						Color color = (Color)(ColorExtensions.bndOffsetColor((Color)(theme.innerColor), (int)(15)));
						shade_top = (Color)(ColorExtensions.bndOffsetColor((Color)(color), (int)(theme.shadeTop)));
						shade_down = (Color)(ColorExtensions.bndOffsetColor((Color)(color), (int)(theme.shadeDown)));
					}
					break;
				case BNDwidgetState.BND_ACTIVE:
					{
						shade_top = (Color)(ColorExtensions.bndOffsetColor((Color)(theme.innerSelectedColor), (int)((flipActive) != 0 ? theme.shadeDown : theme.shadeTop)));
						shade_down = (Color)(ColorExtensions.bndOffsetColor((Color)(theme.innerSelectedColor), (int)((flipActive) != 0 ? theme.shadeTop : theme.shadeDown)));
					}
					break;
			}

		}

		public static Color bndTextColor(WidgetTheme theme, BNDwidgetState state)
		{
			return (Color)(((state) == (BNDwidgetState.BND_ACTIVE)) ? theme.textSelectedColor : theme.textColor);
		}

		public static void bndIconLabelValue(this NvgContext ctx, float x, float y, float w, float h, BNDicon? iconid, Color color, BNDtextAlignment align, float fontsize, string label, string value)
		{
			float pleft = (float)(8);
			if ((label) != null)
			{
				if (iconid != null)
				{
					bndIcon(ctx, (float)(x + 4), (float)(y + 2), iconid.Value);
					pleft += (float)(16);
				}
				if ((bnd_font) < (0))
					return;
				ctx.FontFaceId((int)(bnd_font));
				ctx.FontSize((float)(fontsize));
				ctx.BeginPath();
				ctx.FillColor((Color)(color));
				if ((value) != null)
				{
					var bounds = new Bounds();
					float label_width = (float)(ctx.TextBounds((float)(1), (float)(1), label, ref bounds));
					float sep_width = (float)(ctx.TextBounds((float)(1), (float)(1), ": ", ref bounds));
					ctx.TextAlign((Alignment.Left | Alignment.Baseline));
					x += (float)(pleft);
					if ((align) == (BNDtextAlignment.BND_CENTER))
					{
						float width = (float)(label_width + sep_width + ctx.TextBounds((float)(1), (float)(1), value, ref bounds));
						x += (float)(((w - 8 - pleft) - width) * 0.5f);
					}
					y += (float)(BND_WIDGET_HEIGHT - 7);
					ctx.Text((float)(x), (float)(y), label);
					x += (float)(label_width);
					ctx.Text((float)(x), (float)(y), ": ");
					x += (float)(sep_width);
					ctx.Text((float)(x), (float)(y), value);
				}
				else
				{
					ctx.TextAlign((((align) == (BNDtextAlignment.BND_LEFT)) ? (Alignment.Left | Alignment.Baseline) : (Alignment.Center | Alignment.Baseline)));
					ctx.TextBox((float)(x + pleft), (float)(y + BND_WIDGET_HEIGHT - 7), (float)(w - 8 - pleft), label);
				}
			}
			else if (iconid != null)
			{
				bndIcon(ctx, (float)(x + 2), (float)(y + 2), iconid.Value);
			}

		}

		public static void bndNodeIconLabel(this NvgContext ctx, float x, float y, float w, float h, BNDicon? iconid, Color color, Color shadowColor, BNDtextAlignment align, float fontsize, string label)
		{
			if (((label) != null) && ((bnd_font) >= (0)))
			{
				ctx.FontFaceId((int)(bnd_font));
				ctx.FontSize((float)(fontsize));
				ctx.BeginPath();
				ctx.TextAlign((Alignment.Left | Alignment.Baseline));
				ctx.FillColor((Color)(shadowColor));
				ctx.FontBlur((float)(1));
				ctx.TextBox((float)(x + 1), (float)(y + h + 3 - 7), (float)(w), label);
				ctx.FillColor((Color)(color));
				ctx.FontBlur((float)(0));
				ctx.TextBox((float)(x), (float)(y + h + 2 - 7), (float)(w), label);
			}

			if (iconid != null)
			{
				bndIcon(ctx, (float)(x + w - 16), (float)(y + 3), iconid.Value);
			}
		}
		public static int bndIconLabelTextPosition(this NvgContext ctx, float x, float y, float w, float h, BNDicon? iconid, float fontsize, string label, int px, int py)
		{
			var bounds = new Bounds();
			float pleft = (float)(4);
			if (label == null)
				return (int)(-1);
			if (iconid != null)
				pleft += (float)(16);
			if ((bnd_font) < (0))
				return (int)(-1);
			x += (float)(pleft);
			y += (float)(BND_WIDGET_HEIGHT - 7);
			ctx.FontFaceId((int)(bnd_font));
			ctx.FontSize((float)(fontsize));
			ctx.TextAlign((Alignment.Left | Alignment.Baseline));
			w -= (float)(4 + pleft);
			float asc = 0;
			float desc = 0;
			float lh = 0;
			TextRow[] rows = new TextRow[32];
			StringSegment remaining;
			int nrows = (int)(ctx.TextBreakLines(label, (float)(w), rows, out remaining));
			if ((nrows) == (0))
				return (int)(0);
			ctx.TextBoxBounds((float)(x), (float)(y), (float)(w), label, ref bounds);
			ctx.TextMetrics(out asc, out desc, out lh);
			int row = (int)(bnd_clamp((float)((int)((py - bounds.b2) / lh)), (float)(0), (float)(nrows - 1)));

			GlyphPosition[] glyphs = new GlyphPosition[1024];
			int nglyphs = (int)(ctx.TextGlyphPositions((float)(x), (float)(y), rows[row].Str, glyphs));
			int col = 0;
			int p = (int)(0);
			for (col = (int)(0); ((col) < (nglyphs)) && ((glyphs[col].X) < (px)); ++col)
			{
				p = (int)(glyphs[col].Str.Location);
			}
			if ((((col) > (0)) && ((col) < (nglyphs))) && ((glyphs[col].X - px) < (px - glyphs[col - 1].X)))
				p = (int)(glyphs[col].Str.Location);
			return (int)(p);
		}

		public static void bndCaretPosition(this NvgContext ctx, float x, float y, float desc, float lineHeight, int caret, TextRow[] rows, int nrows, out int cr, out float cx, out float cy)
		{
			GlyphPosition[] glyphs = new GlyphPosition[1024];
			int r = 0;
			for (r = (int)(0); ((r) < (nrows)) && ((rows[r].Str.Location + rows[r].Str.Length) < (caret)); ++r)
			{
			}
			cr = (int)(r);
			cx = (float)(x);
			cy = (float)(y - lineHeight - desc + r * lineHeight);
			if ((nrows) == (0))
				return;
			cx = (float)(rows[r].MinX);
			var nglyphs = ctx.TextGlyphPositions((float)(x), (float)(y), rows[r].Str, glyphs);
			for (int i = (int)(0); i < nglyphs; ++i)
			{
				cx = (float)(glyphs[i].X);
				if ((glyphs[i].Str.Location) == (caret))
					break;
			}
		}

		public static void bndIconLabelCaret(this NvgContext ctx, float x, float y, float w, float h, BNDicon? iconid, Color color, float fontsize, string label, Color caretcolor, int cbegin, int cend)
		{
			float pleft = (float)(4);
			if (label == null)
				return;
			if (iconid != null)
			{
				bndIcon(ctx, (float)(x + 4), (float)(y + 2), iconid.Value);
				pleft += (float)(16);
			}

			if ((bnd_font) < (0))
				return;
			x += (float)(pleft);
			y += (float)(BND_WIDGET_HEIGHT - 7);
			ctx.FontFaceId((int)(bnd_font));
			ctx.FontSize((float)(fontsize));
			ctx.TextAlign((Alignment.Left | Alignment.Baseline));
			w -= (float)(4 + pleft);
			if ((cend) >= (cbegin))
			{
				int c0r = 0;
				int c1r = 0;
				float c0x = 0;
				float c0y = 0;
				float c1x = 0;
				float c1y = 0;
				float asc = 0;
				float desc = 0;
				float lh = 0;
				StringSegment remaining;
				TextRow[] rows = new TextRow[32];
				int nrows = (int)(ctx.TextBreakLines(label, (float)(w), rows, out remaining));
				ctx.TextMetrics(out asc, out desc, out lh);
				bndCaretPosition(ctx, (float)(x), (float)(y), (float)(desc), (float)(lh), cbegin, rows, (int)(nrows), out c0r, out c0x, out c0y);
				bndCaretPosition(ctx, (float)(x), (float)(y), (float)(desc), (float)(lh), cend, rows, (int)(nrows), out c1r, out c1x, out c1y);
				ctx.BeginPath();
				if ((cbegin) == (cend))
				{
					ctx.FillColor((Color)(new Color((float)(0.337), (float)(0.502), (float)(0.761))));
					ctx.Rect((float)(c0x - 1), (float)(c0y), (float)(2), (float)(lh + 1));
				}
				else
				{
					ctx.FillColor((Color)(caretcolor));
					if ((c0r) == (c1r))
					{
						ctx.Rect((float)(c0x - 1), (float)(c0y), (float)(c1x - c0x + 1), (float)(lh + 1));
					}
					else
					{
						int blk = (int)(c1r - c0r - 1);
						ctx.Rect((float)(c0x - 1), (float)(c0y), (float)(x + w - c0x + 1), (float)(lh + 1));
						ctx.Rect((float)(x), (float)(c1y), (float)(c1x - x + 1), (float)(lh + 1));
						if ((blk) != 0)
							ctx.Rect((float)(x), (float)(c0y + lh), (float)(w), (float)(blk * lh + 1));
					}
				}
				ctx.Fill();
			}

			ctx.BeginPath();
			ctx.FillColor((Color)(color));
			ctx.TextBox((float)(x), (float)(y), (float)(w), label);
		}

		public static void bndCheck(this NvgContext ctx, float ox, float oy, Color color)
		{
			ctx.BeginPath();
			ctx.StrokeWidth((float)(2));
			ctx.StrokeColor((Color)(color));
			ctx.LineCap(LineCap.Butt);
			ctx.LineJoin(LineCap.Miter);
			ctx.MoveTo((float)(ox + 4), (float)(oy + 5));
			ctx.LineTo((float)(ox + 7), (float)(oy + 8));
			ctx.LineTo((float)(ox + 14), (float)(oy + 1));
			ctx.Stroke();
		}

		public static void bndArrow(this NvgContext ctx, float x, float y, float s, Color color)
		{
			ctx.BeginPath();
			ctx.MoveTo((float)(x), (float)(y));
			ctx.LineTo((float)(x - s), (float)(y + s));
			ctx.LineTo((float)(x - s), (float)(y - s));
			ctx.ClosePath();
			ctx.FillColor((Color)(color));
			ctx.Fill();
		}

		public static void bndUpDownArrow(this NvgContext ctx, float x, float y, float s, Color color)
		{
			float w = 0;
			ctx.BeginPath();
			w = (float)(1.1f * s);
			ctx.MoveTo((float)(x), (float)(y - 1));
			ctx.LineTo((float)(x + 0.5 * w), (float)(y - s - 1));
			ctx.LineTo((float)(x + w), (float)(y - 1));
			ctx.ClosePath();
			ctx.MoveTo((float)(x), (float)(y + 1));
			ctx.LineTo((float)(x + 0.5 * w), (float)(y + s + 1));
			ctx.LineTo((float)(x + w), (float)(y + 1));
			ctx.ClosePath();
			ctx.FillColor((Color)(color));
			ctx.Fill();
		}

		public static void bndNodeArrowDown(this NvgContext ctx, float x, float y, float s, Color color)
		{
			float w = 0;
			ctx.BeginPath();
			w = (float)(1.0f * s);
			ctx.MoveTo((float)(x), (float)(y));
			ctx.LineTo((float)(x + 0.5 * w), (float)(y - s));
			ctx.LineTo((float)(x - 0.5 * w), (float)(y - s));
			ctx.ClosePath();
			ctx.FillColor((Color)(color));
			ctx.Fill();
		}

		public static void bndScrollHandleRect(float* x, float* y, float* w, float* h, float offset, float size)
		{
			size = (float)(bnd_clamp((float)(size), (float)(0), (float)(1)));
			offset = (float)(bnd_clamp((float)(offset), (float)(0), (float)(1)));
			if ((*h) > (*w))
			{
				float hs = (float)(bnd_fmaxf((float)(size * (*h)), (float)((*w) + 1)));
				*y = (float)((*y) + ((*h) - hs) * offset);
				*h = (float)(hs);
			}
			else
			{
				float ws = (float)(bnd_fmaxf((float)(size * (*w)), (float)((*h) - 1)));
				*x = (float)((*x) + ((*w) - ws) * offset);
				*w = (float)(ws);
			}
		}

		public static Color bndNodeWireColor(NodeTheme theme, BNDwidgetState state)
		{
			switch (state)
			{
				default:
				case BNDwidgetState.BND_DEFAULT:
					return (Color)(new Color((float)(0.5f), (float)(0.5f), (float)(0.5f)));
				case BNDwidgetState.BND_HOVER:
					return (Color)(theme.wireSelectColor);
				case BNDwidgetState.BND_ACTIVE:
					return (Color)(theme.activeNodeColor);
			}
		}
	}
}
