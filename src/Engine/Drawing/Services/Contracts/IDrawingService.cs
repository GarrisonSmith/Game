﻿using Engine.Drawing.Models.Contracts;
using Microsoft.Xna.Framework;

namespace Engine.Drawing.Services.Contracts
{
	public interface IDrawingService
	{
		/// <summary>
		/// Draws the draw data. 
		/// </summary>
		/// <param name="gameTime">The game time.</param>
		/// <param name="drawable">The drawable.</param>
		public void Draw(GameTime gameTime, ICanBeDrawn drawable);
	}
}
