using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnityEngine;

public class FlatFileSaveLoad : TileSaveLoad
{
	public override void SaveTiles()
	{
		throw new System.NotImplementedException();

		/*File.WriteAllLines("map.txt",
			Enumerable.Range(0, properties.width)
			.Select(row => Enumerable.Range(0, properties.height)
			.Select(col => storage[row, col]).ToString()));*/
	}

	public override void LoadTiles()
	{
		throw new System.NotImplementedException();
	}

	public FlatFileSaveLoad(MapProperties properties, TileStorage<Tile> storage) : base(properties, storage)
	{
		this.properties = properties;
		this.storage = storage;
	}
}