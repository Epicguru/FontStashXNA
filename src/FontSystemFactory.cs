using FontStashSharp;
using Microsoft.Xna.Framework.Graphics;
using System.Collections;
using System.Collections.Generic;

namespace FontStashSharp
{
	public static class FontSystemFactory
	{
		private struct TextureEnumerator : IEnumerable<Texture2D>
		{
			readonly FontSystem _font;

			public TextureEnumerator(FontSystem font)
			{
				_font = font;
			}

			public IEnumerator<Texture2D> GetEnumerator()
			{
				foreach (var atlas in _font.Atlases)
				{
					var Texture2DWrapper = (Texture2DWrapper)atlas.Texture;
					yield return Texture2DWrapper.Texture;
				}
			}

			IEnumerator IEnumerable.GetEnumerator()
			{
				return GetEnumerator();
			}
		}

		public static IEnumerable<Texture2D> EnumerateTextures(this FontSystem fontSystem)
		{
			return new TextureEnumerator(fontSystem);
		}

		public static FontSystem Create(GraphicsDevice graphicsDevice, byte[] ttf,  int textureWidth, int textureHeight, int blurAmount = 0, int strokeAmount = 0)
		{
			var textureCreator = new Texture2DCreator(graphicsDevice);
			var result = new FontSystem(StbTrueTypeSharpFontLoader.Instance, textureCreator, textureWidth, textureHeight, blurAmount, strokeAmount);
			result.AddFont(ttf);

			return result;
		}
	}
}
