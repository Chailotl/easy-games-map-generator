using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleGenerator : TileGenerator
{
	public override void GenerateTiles()
	{
		for (int x = 0; x < properties.width; ++x)
		{
			for (int y = 0; y < properties.height; ++y)
			{
				// Generate perlin noise
				float val = Mathf.PerlinNoise(x / 10f + properties.seed, y / 10f + properties.seed + 0.33f);
				val += Mathf.PerlinNoise(x / 25f + properties.seed, y / 25f + properties.seed + 0.25f) / 4f - 0.125f;

				// Map noise to a tileset
				uint tile = 1; // Grass
				if (val < 0.2) { tile = 4; } // Water
				else if (val < 0.35) { tile = 3; } // Dirt
				else if (val > 0.8) { tile = 5; } // Rock
				else if (val > 0.6) { tile = 2; } // Lava

				storage.SetTile(x, y, new Tile(tile));
			}
		}
	}

	public SimpleGenerator(MapProperties properties, TileStorage<Tile> storage) : base(properties, storage)
	{
		this.properties = properties;
		this.storage = storage;
	}
}
