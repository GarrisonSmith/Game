﻿using Game.Drawing.Models.Contracts;

namespace Game.RunTime.Services.Contracts
{   
	/// <summary>
	/// Represents a runtime draw manager.
	/// </summary>
	public interface IRuntimeDrawService
	{
		/// <summary>
		/// Adds the draw data.
		/// </summary>
		/// <param name="layer">The layer.</param>
		/// <param name="drawable">The drawable.</param>
		public void AddDrawData(int layer, ICanBeDrawn drawable);

		/// <summary>
		/// Removes the draw data.
		/// </summary>
		/// <param name="layer">The layer.</param>
		/// <param name="drawable">The drawable.</param>
		public void RemoveDrawData(int layer, ICanBeDrawn drawable);

		/// <summary>
		/// Changes the draw data layer.
		/// </summary>
		/// <param name="layer">The layer.</param>
		/// <param name="drawable">The drawable.</param>
		public void ChangeDrawDataLayer(int layer, ICanBeDrawn drawable);
	}
}