﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Engine.Core.Textures.Contracts
{
	/// <summary>
	/// Represents a texture service.
	/// </summary>
	public interface ITextureService
	{
		/// <summary>
		/// Gets the texture.
		/// </summary>
		/// <param name="textureName">The texture name.</param>
		/// <returns>The texture.</returns>
		public Texture2D GetTexture(string textureName);

		/// <summary>
		/// Gets the texture name.
		/// </summary>
		/// <param name="spritesheet">The sprite sheet.</param>
		/// <param name="spritesheetBox">The spritesheet box.</param>
		/// <returns>The texture name.</returns>
		public string GetTextureName(string spritesheet, Rectangle spritesheetBox);
	}
}