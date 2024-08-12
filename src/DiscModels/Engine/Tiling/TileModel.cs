﻿using DiskModels.Engine.Drawing;
using DiskModels.Engine.Physics.Contracts;
using DiskModels.Engine.Tiling.Contracts;
using System.Runtime.Serialization;

namespace DiskModels.Engine.Tiling
{
	[DataContract(Name = "tile")]
	public class TileModel : IAmATileModel
	{
		[DataMember(Name = "row", Order = 1)]
		public int Row { get; set; }

		[DataMember(Name = "column", Order = 2)]
		public int Column { get; set; }

		[DataMember(Name = "sprite", Order = 3)]
		public SpriteModel Sprite { get; set; }

		[DataMember(Name = "area", Order = 4)]
		public IAmAAreaModel Area { get; set; }
	}
}