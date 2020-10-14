using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Text;

namespace FontStashSharp
{
	public static class SpriteBatchExtensions
	{
		public static float DrawString(this SpriteBatch batch, DynamicSpriteFont font, string text, Vector2 pos, Color color,
			float scaleX = 1.0f, float scaleY = 1.0f, float depth = 0.0f)
		{
			var renderer = SpriteBatchRenderer.Instance;
			renderer.Batch = batch;
			return font.DrawText(renderer, pos.X, pos.Y, text, color, scaleX, scaleY, depth);
		}

		public static float DrawString(this SpriteBatch batch, DynamicSpriteFont font, string text, Vector2 pos, Color[] colors,
			float scaleX = 1.0f, float scaleY = 1.0f, float depth = 0.0f)
		{
			var renderer = SpriteBatchRenderer.Instance;
			renderer.Batch = batch;

			return font.DrawText(renderer, pos.X, pos.Y, text, colors, scaleX, scaleY, depth);
		}

		public static float DrawString(this SpriteBatch batch, DynamicSpriteFont font, StringBuilder text, Vector2 pos, Color color,
			float scaleX = 1.0f, float scaleY = 1.0f, float depth = 0.0f)
		{
			var renderer = SpriteBatchRenderer.Instance;
			renderer.Batch = batch;

			return font.DrawText(renderer, pos.X, pos.Y, text, color, scaleX, scaleY, depth);
		}

		public static float DrawString(this SpriteBatch batch, DynamicSpriteFont font, StringBuilder text, Vector2 pos, Color[] colors,
			float scaleX = 1.0f, float scaleY = 1.0f, float depth = 0.0f)
		{
			var renderer = SpriteBatchRenderer.Instance;
			renderer.Batch = batch;

			return font.DrawText(renderer, pos.X, pos.Y, text, colors, scaleX, scaleY, depth);
		}
	}
}