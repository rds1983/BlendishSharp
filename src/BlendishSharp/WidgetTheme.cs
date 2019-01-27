using System;
using System.Runtime.InteropServices;
using Microsoft.Xna.Framework;

namespace BlendishSharp
{
	public class WidgetTheme
	{
		public Color outlineColor;
		public Color itemColor;
		public Color innerColor;
		public Color innerSelectedColor;
		public Color textColor;
		public Color textSelectedColor;
		public int shadeTop;
		public int shadeDown;

		public Color TextColor(BNDwidgetState state)
		{
			return (((state) == (BNDwidgetState.BND_ACTIVE)) ? textSelectedColor : textColor);
		}
	}
}
