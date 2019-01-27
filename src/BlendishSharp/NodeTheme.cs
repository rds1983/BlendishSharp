using System;
using Microsoft.Xna.Framework;

namespace BlendishSharp
{
	public class NodeTheme
	{
		public Color nodeSelectedColor;
		public Color wiresColor;
		public Color textSelectedColor;
		public Color activeNodeColor;
		public Color wireSelectColor;
		public Color nodeBackdropColor;
		public int noodleCurving;

		public Color bndNodeWireColor(BNDwidgetState state)
		{
			switch (state)
			{
				default:
				case BNDwidgetState.BND_DEFAULT:
					return (Color)(new Color((float)(0.5f), (float)(0.5f), (float)(0.5f)));
				case BNDwidgetState.BND_HOVER:
					return (Color)(wireSelectColor);
				case BNDwidgetState.BND_ACTIVE:
					return (Color)(activeNodeColor);
			}
		}
	}
}
