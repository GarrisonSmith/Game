﻿using DiscModels.Engine.Tiling;
using DiscModels.Engine.Tiling.Contracts;
using Engine.Tiling.Models;
using Engine.Tiling.Models.Contracts;

namespace Engine.Tiling.Services.Contracts
{
	/// <summary>
	/// Represents a tile service.
	/// </summary>
	public interface ITileService
	{
		/// <summary>
		/// Gets the tile map.
		/// </summary>
		/// <param name="tileMapModel">The tile map model.</param>
		/// <returns>The tile map.</returns>
		public TileMap GetTileMap(TileMapModel tileMapModel);

		/// <summary>
		/// Gets the tile map layer.
		/// </summary>
		/// <param name="tileMapLayerModel">The tile map layer model.</param>
		/// <returns>The tile map layer.</returns>
		public TileMapLayer GetTileMapLayer(TileMapLayerModel tileMapLayerModel);

		/// <summary>
		/// Gets the tile.
		/// </summary>
		/// <param name="tileModel">The tile model.</param>
		/// <returns>The tile.</returns>
		public IAmATile GetTile(IAmATileModel tileModel);
	}
}