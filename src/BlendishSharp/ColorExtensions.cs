using Microsoft.Xna.Framework;

namespace BlendishSharp
{
	public static class ColorExtensions
	{
		public static Color bndTransparent(this Color color)
		{
			float a = color.A;
			a *= 0.643f;
			color.A = (byte)a;
			return (Color)(color);
		}

		public static Color bndOffsetColor(this Color color, int delta)
		{
			float offset = (float)((float)(delta) / 255.0f);
			return (Color)((delta) != 0 ? (new Color((float)(Blendish.bnd_clamp((float)(color.R / 255.0f + offset), (float)(0), (float)(1))),
			(float)(Blendish.bnd_clamp((float)(color.G / 255.0f + offset), (float)(0), (float)(1))),
			(float)(Blendish.bnd_clamp((float)(color.B / 255.0f + offset), (float)(0), (float)(1))), (float)(color.A / 255.0f))) : color);
		}
	}
}
