using System.IO;
using Microsoft.Xna.Framework.Graphics;

namespace BlendishSharp
{
	internal static class Resources
	{
		public static byte[] CreateTtfSystemByteArray()
		{
			var assembly = typeof(Resources).Assembly;

			var path = "BlendishSharp.Resources.DejaVuSans.ttf";

			var ms = new MemoryStream();
			using (var stream = assembly.GetManifestResourceStream(path))
			{
				stream.CopyTo(ms);
			}

			return ms.ToArray();
		}

		public static Texture2D CreateIcons(GraphicsDevice device)
		{
			var assembly = typeof(Resources).Assembly;

			var path = "BlendishSharp.Resources.blender_icons16.png";

			var ms = new MemoryStream();
			Texture2D texture;
			using (var stream = assembly.GetManifestResourceStream(path))
			{
				texture = Texture2D.FromStream(device, stream);
			}

			return texture;
		}
	}
}
