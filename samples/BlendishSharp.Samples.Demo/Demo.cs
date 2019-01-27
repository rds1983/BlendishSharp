using NvgSharp;
using System;
using Microsoft.Xna.Framework;

namespace BlendishSharp.Samples.Demo
{
	public class Demo
	{
		public static float fmodf(float x, float y)
		{
			return x % y;
		}

		void draw_noodles(NvgContext vg, int x, int y)
		{
			int w = 200;
			int s = 70;

			vg.bndNodeBackground(x + w, y - 50, 100, 200, BNDwidgetState.BND_DEFAULT, BNDicon.BND_ICON_GHOST,
				"Default", new Color(0.392f, 0.392f, 0.392f));
			vg.bndNodeBackground(x + w + 120, y - 50, 100, 200, BNDwidgetState.BND_HOVER, BNDicon.BND_ICON_GHOST,
				"Hover", new Color(0.392f, 0.392f, 0.392f));
			vg.bndNodeBackground(x + w + 240, y - 50, 100, 200, BNDwidgetState.BND_ACTIVE, BNDicon.BND_ICON_GHOST,
				"Active", new Color(0.392f, 0.392f, 0.392f));

			for (int i = 0; i < 9; ++i)
			{
				int a = i % 3;
				int b = i / 3;
				vg.bndNodeWire(x, y + s * a, x + w, y + s * b, (BNDwidgetState)a, (BNDwidgetState)b);
			}

			vg.bndNodePort(x, y, BNDwidgetState.BND_DEFAULT, new Color(0.5f, 0.5f, 0.5f));
			vg.bndNodePort(x + w, y, BNDwidgetState.BND_DEFAULT, new Color(0.5f, 0.5f, 0.5f));
			vg.bndNodePort(x, y + s, BNDwidgetState.BND_HOVER, new Color(0.5f, 0.5f, 0.5f));
			vg.bndNodePort(x + w, y + s, BNDwidgetState.BND_HOVER, new Color(0.5f, 0.5f, 0.5f));
			vg.bndNodePort(x, y + 2 * s, BNDwidgetState.BND_ACTIVE, new Color(0.5f, 0.5f, 0.5f));
			vg.bndNodePort(x + w, y + 2 * s, BNDwidgetState.BND_ACTIVE, new Color(0.5f, 0.5f, 0.5f));
		}

		public void Render(NvgContext vg, int x, int y, float w, float h, float gameTime)
		{
			vg.Save();
			vg.Translate(x, y);

			vg.bndSplitterWidgets(0, 0, w, h);

			x = 10;
			y = 10;

			vg.bndToolButton(x, y, 120, Blendish.BND_WIDGET_HEIGHT, BNDcornerFlags.BND_CORNER_NONE, BNDwidgetState.BND_DEFAULT,
				BNDicon.BND_ICON_GHOST, "Default");
			y += 25;
			vg.bndToolButton(x, y, 120, Blendish.BND_WIDGET_HEIGHT, BNDcornerFlags.BND_CORNER_NONE, BNDwidgetState.BND_HOVER,
				BNDicon.BND_ICON_GHOST, "Hovered");
			y += 25;
			vg.bndToolButton(x, y, 120, Blendish.BND_WIDGET_HEIGHT, BNDcornerFlags.BND_CORNER_NONE, BNDwidgetState.BND_ACTIVE,
				BNDicon.BND_ICON_GHOST, "Active");

			y += 40;
			vg.bndRadioButton(x, y, 80, Blendish.BND_WIDGET_HEIGHT, BNDcornerFlags.BND_CORNER_NONE, BNDwidgetState.BND_DEFAULT,
				null, "Default");
			y += 25;
			vg.bndRadioButton(x, y, 80, Blendish.BND_WIDGET_HEIGHT, BNDcornerFlags.BND_CORNER_NONE, BNDwidgetState.BND_HOVER,
				null, "Hovered");
			y += 25;
			vg.bndRadioButton(x, y, 80, Blendish.BND_WIDGET_HEIGHT, BNDcornerFlags.BND_CORNER_NONE, BNDwidgetState.BND_ACTIVE,
				null, "Active");

			y += 25;
			vg.bndLabel(x, y, 120, Blendish.BND_WIDGET_HEIGHT, null, "Label:");
			y += Blendish.BND_WIDGET_HEIGHT;
			vg.bndChoiceButton(x, y, 80, Blendish.BND_WIDGET_HEIGHT, BNDcornerFlags.BND_CORNER_NONE, BNDwidgetState.BND_DEFAULT,
				null, "Default");
			y += 25;
			vg.bndChoiceButton(x, y, 80, Blendish.BND_WIDGET_HEIGHT, BNDcornerFlags.BND_CORNER_NONE, BNDwidgetState.BND_HOVER,
				null, "Hovered");
			y += 25;
			vg.bndChoiceButton(x, y, 80, Blendish.BND_WIDGET_HEIGHT, BNDcornerFlags.BND_CORNER_NONE, BNDwidgetState.BND_ACTIVE,
				null, "Active");

			y += 25;
			int ry = y;
			int rx = x;

			y = 10;
			x += 130;
			vg.bndOptionButton(x, y, 120, Blendish.BND_WIDGET_HEIGHT, BNDwidgetState.BND_DEFAULT, "Default");
			y += 25;
			vg.bndOptionButton(x, y, 120, Blendish.BND_WIDGET_HEIGHT, BNDwidgetState.BND_HOVER, "Hovered");
			y += 25;
			vg.bndOptionButton(x, y, 120, Blendish.BND_WIDGET_HEIGHT, BNDwidgetState.BND_ACTIVE, "Active");

			y += 40;
			vg.bndNumberField(x, y, 120, Blendish.BND_WIDGET_HEIGHT, BNDcornerFlags.BND_CORNER_DOWN, BNDwidgetState.BND_DEFAULT,
				"Top", "100");
			y += Blendish.BND_WIDGET_HEIGHT - 2;
			vg.bndNumberField(x, y, 120, Blendish.BND_WIDGET_HEIGHT, BNDcornerFlags.BND_CORNER_ALL, BNDwidgetState.BND_DEFAULT,
				"Center", "100");
			y += Blendish.BND_WIDGET_HEIGHT - 2;
			vg.bndNumberField(x, y, 120, Blendish.BND_WIDGET_HEIGHT, BNDcornerFlags.BND_CORNER_TOP, BNDwidgetState.BND_DEFAULT,
				"Bottom", "100");

			int mx = x - 30;
			int my = y - 12;
			int mw = 120;
			vg.bndMenuBackground(mx, my, mw, 120, BNDcornerFlags.BND_CORNER_TOP);
			vg.bndMenuLabel(mx, my, mw, Blendish.BND_WIDGET_HEIGHT, null, "Menu Title");
			my += Blendish.BND_WIDGET_HEIGHT - 2;
			vg.bndMenuItem(mx, my, mw, Blendish.BND_WIDGET_HEIGHT, BNDwidgetState.BND_DEFAULT,
				BNDicon.BND_ICON_FILE_FOLDER, "Default");
			my += Blendish.BND_WIDGET_HEIGHT - 2;
			vg.bndMenuItem(mx, my, mw, Blendish.BND_WIDGET_HEIGHT, BNDwidgetState.BND_HOVER,
				BNDicon.BND_ICON_FILE_BLANK, "Hovered");
			my += Blendish.BND_WIDGET_HEIGHT - 2;
			vg.bndMenuItem(mx, my, mw, Blendish.BND_WIDGET_HEIGHT, BNDwidgetState.BND_ACTIVE,
				BNDicon.BND_ICON_FILE_BLEND, "Active");

			y = 10;
			x += 130;
			int ox = x;
			vg.bndNumberField(x, y, 120, Blendish.BND_WIDGET_HEIGHT, BNDcornerFlags.BND_CORNER_NONE, BNDwidgetState.BND_DEFAULT,
				"Default", "100");
			y += 25;
			vg.bndNumberField(x, y, 120, Blendish.BND_WIDGET_HEIGHT, BNDcornerFlags.BND_CORNER_NONE, BNDwidgetState.BND_HOVER,
				"Hovered", "100");
			y += 25;
			vg.bndNumberField(x, y, 120, Blendish.BND_WIDGET_HEIGHT, BNDcornerFlags.BND_CORNER_NONE, BNDwidgetState.BND_ACTIVE,
				"Active", "100");

			y += 40;
			vg.bndRadioButton(x, y, 60, Blendish.BND_WIDGET_HEIGHT, BNDcornerFlags.BND_CORNER_RIGHT, BNDwidgetState.BND_DEFAULT,
				null, "One");
			x += 60 - 1;
			vg.bndRadioButton(x, y, 60, Blendish.BND_WIDGET_HEIGHT, BNDcornerFlags.BND_CORNER_ALL, BNDwidgetState.BND_DEFAULT,
				null, "Two");
			x += 60 - 1;
			vg.bndRadioButton(x, y, 60, Blendish.BND_WIDGET_HEIGHT, BNDcornerFlags.BND_CORNER_ALL, BNDwidgetState.BND_DEFAULT,
				null, "Three");
			x += 60 - 1;
			vg.bndRadioButton(x, y, 60, Blendish.BND_WIDGET_HEIGHT, BNDcornerFlags.BND_CORNER_LEFT, BNDwidgetState.BND_ACTIVE,
				null, "Butts");

			x = ox;
			y += 40;

			float progress_value = fmodf(gameTime / 10.0f, 1.0f);
			string progress_label;
			progress_label = string.Format("{0:0.00}", progress_value * 100 + 0.5f);
			vg.bndSlider(x, y, 240, Blendish.BND_WIDGET_HEIGHT, BNDcornerFlags.BND_CORNER_NONE, BNDwidgetState.BND_DEFAULT,
				progress_value, "Default", progress_label);
			y += 25;
			vg.bndSlider(x, y, 240, Blendish.BND_WIDGET_HEIGHT, BNDcornerFlags.BND_CORNER_NONE, BNDwidgetState.BND_HOVER,
				progress_value, "Hovered", progress_label);
			y += 25;
			vg.bndSlider(x, y, 240, Blendish.BND_WIDGET_HEIGHT, BNDcornerFlags.BND_CORNER_NONE, BNDwidgetState.BND_ACTIVE,
				progress_value, "Active", progress_label);

			int rw = x + 240 - rx;
			float s_offset = (float)Math.Sin(gameTime / 2.0f) * 0.5f + 0.5f;
			float s_size = (float)Math.Cos(gameTime / 3.11f) * 0.5f + 0.5f;

			vg.bndScrollBar(rx, ry, rw, Blendish.BND_SCROLLBAR_HEIGHT, BNDwidgetState.BND_DEFAULT, s_offset, s_size);
			ry += 20;
			vg.bndScrollBar(rx, ry, rw, Blendish.BND_SCROLLBAR_HEIGHT, BNDwidgetState.BND_HOVER, s_offset, s_size);
			ry += 20;
			vg.bndScrollBar(rx, ry, rw, Blendish.BND_SCROLLBAR_HEIGHT, BNDwidgetState.BND_ACTIVE, s_offset, s_size);

			string edit_text = "The quick brown fox";
			int t = (int)(gameTime * 2);
			int idx1 = (t / edit_text.Length) % edit_text.Length;
			int idx2 = idx1 + (t % (edit_text.Length - idx1));

			ry += 25;
			vg.bndTextField(rx, ry, 240, Blendish.BND_WIDGET_HEIGHT, BNDcornerFlags.BND_CORNER_NONE, BNDwidgetState.BND_DEFAULT,
				null, edit_text, idx1, idx2);
			ry += 25;
			vg.bndTextField(rx, ry, 240, Blendish.BND_WIDGET_HEIGHT, BNDcornerFlags.BND_CORNER_NONE, BNDwidgetState.BND_HOVER,
				null, edit_text, idx1, idx2);
			ry += 25;
			vg.bndTextField(rx, ry, 240, Blendish.BND_WIDGET_HEIGHT, BNDcornerFlags.BND_CORNER_NONE, BNDwidgetState.BND_ACTIVE,
				null, edit_text, idx1, idx2);

			draw_noodles(vg, 20, ry + 50);

			rx += rw + 20;
			ry = 10;
			vg.bndScrollBar(rx, ry, Blendish.BND_SCROLLBAR_WIDTH, 240, BNDwidgetState.BND_DEFAULT, s_offset, s_size);
			rx += 20;
			vg.bndScrollBar(rx, ry, Blendish.BND_SCROLLBAR_WIDTH, 240, BNDwidgetState.BND_HOVER, s_offset, s_size);
			rx += 20;
			vg.bndScrollBar(rx, ry, Blendish.BND_SCROLLBAR_WIDTH, 240, BNDwidgetState.BND_ACTIVE, s_offset, s_size);

			x = ox;
			y += 40;
			vg.bndToolButton(x, y, Blendish.BND_TOOL_WIDTH, Blendish.BND_WIDGET_HEIGHT, BNDcornerFlags.BND_CORNER_RIGHT,
				BNDwidgetState.BND_DEFAULT, BNDicon.BND_ICON_REC, null);
			x += Blendish.BND_TOOL_WIDTH - 1;
			vg.bndToolButton(x, y, Blendish.BND_TOOL_WIDTH, Blendish.BND_WIDGET_HEIGHT, BNDcornerFlags.BND_CORNER_ALL,
				BNDwidgetState.BND_DEFAULT, BNDicon.BND_ICON_PLAY, null);
			x += Blendish.BND_TOOL_WIDTH - 1;
			vg.bndToolButton(x, y, Blendish.BND_TOOL_WIDTH, Blendish.BND_WIDGET_HEIGHT, BNDcornerFlags.BND_CORNER_ALL,
				BNDwidgetState.BND_DEFAULT, BNDicon.BND_ICON_FF, null);
			x += Blendish.BND_TOOL_WIDTH - 1;
			vg.bndToolButton(x, y, Blendish.BND_TOOL_WIDTH, Blendish.BND_WIDGET_HEIGHT, BNDcornerFlags.BND_CORNER_ALL,
				BNDwidgetState.BND_DEFAULT, BNDicon.BND_ICON_REW, null);
			x += Blendish.BND_TOOL_WIDTH - 1;
			vg.bndToolButton(x, y, Blendish.BND_TOOL_WIDTH, Blendish.BND_WIDGET_HEIGHT, BNDcornerFlags.BND_CORNER_ALL,
				BNDwidgetState.BND_DEFAULT, BNDicon.BND_ICON_PAUSE, null);
			x += Blendish.BND_TOOL_WIDTH - 1;
			vg.bndToolButton(x, y, Blendish.BND_TOOL_WIDTH, Blendish.BND_WIDGET_HEIGHT, BNDcornerFlags.BND_CORNER_LEFT,
				BNDwidgetState.BND_DEFAULT, BNDicon.BND_ICON_PREV_KEYFRAME, null);
			x += Blendish.BND_TOOL_WIDTH - 1;
			x += 5;
			vg.bndRadioButton(x, y, Blendish.BND_TOOL_WIDTH, Blendish.BND_WIDGET_HEIGHT, BNDcornerFlags.BND_CORNER_RIGHT,
				BNDwidgetState.BND_DEFAULT, BNDicon.BND_ICON_MOD_CLOTH, null);
			x += Blendish.BND_TOOL_WIDTH - 1;
			vg.bndRadioButton(x, y, Blendish.BND_TOOL_WIDTH, Blendish.BND_WIDGET_HEIGHT, BNDcornerFlags.BND_CORNER_ALL,
				BNDwidgetState.BND_DEFAULT, BNDicon.BND_ICON_MOD_EXPLODE, null);
			x += Blendish.BND_TOOL_WIDTH - 1;
			vg.bndRadioButton(x, y, Blendish.BND_TOOL_WIDTH, Blendish.BND_WIDGET_HEIGHT, BNDcornerFlags.BND_CORNER_ALL,
				BNDwidgetState.BND_DEFAULT, BNDicon.BND_ICON_MOD_FLUIDSIM, null);
			x += Blendish.BND_TOOL_WIDTH - 1;
			vg.bndRadioButton(x, y, Blendish.BND_TOOL_WIDTH, Blendish.BND_WIDGET_HEIGHT, BNDcornerFlags.BND_CORNER_ALL,
				BNDwidgetState.BND_DEFAULT, BNDicon.BND_ICON_MOD_MULTIRES, null);
			x += Blendish.BND_TOOL_WIDTH - 1;
			vg.bndRadioButton(x, y, Blendish.BND_TOOL_WIDTH, Blendish.BND_WIDGET_HEIGHT, BNDcornerFlags.BND_CORNER_ALL,
				BNDwidgetState.BND_ACTIVE, BNDicon.BND_ICON_MOD_SMOKE, null);
			x += Blendish.BND_TOOL_WIDTH - 1;
			vg.bndRadioButton(x, y, Blendish.BND_TOOL_WIDTH, Blendish.BND_WIDGET_HEIGHT, BNDcornerFlags.BND_CORNER_LEFT,
				BNDwidgetState.BND_DEFAULT, BNDicon.BND_ICON_MOD_SOLIDIFY, null);

			vg.Restore();
		}
	}
}
