using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomGenerator : TileGenerator
{
	public override void GenerateTiles()
	{
		for (int x = 0; x < properties.width; ++x)
		{
			for (int y = 0; y < properties.height; ++y)
			{
				storage.SetTile(x, y, new Tile((uint)Random.Range(1, 6)));
			}
		}
	}

	public RandomGenerator(MapProperties properties, TileStorage<Tile> storage) : base(properties, storage)
	{
		this.properties = properties;
		this.storage = storage;
	}
}
