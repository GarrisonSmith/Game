﻿using Engine.Physics.Models.Contracts;
using System;

namespace Engine.Drawing.Models.Contracts
{
	/// <summary>
	/// Represents something that can be drawn.
	/// </summary>
	public interface IAmDrawable : IHavePosition, IDisposable
	{    
		/// <summary>
		/// Gets the sprite.
		/// </summary>
		public Sprite Sprite { get; }
	}
}