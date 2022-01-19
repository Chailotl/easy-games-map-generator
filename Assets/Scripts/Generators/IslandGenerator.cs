using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IslandGenerator : TileGenerator
{
	public override void GenerateTiles()
	{
		Vector2 center = new Vector2(properties.width / 2, properties.height / 2);

		for (int x = 0; x < properties.width; ++x)
		{
			for (int y = 0; y < properties.height; ++y)
			{
				// Generate perlin noise
				float val = Mathf.PerlinNoise(x / 10f + properties.seed, y / 10f + properties.seed + 0.33f);
				val += Mathf.PerlinNoise(x / 25f + properties.seed, y / 25f + properties.seed + 0.25f) / 4f - 0.125f;

				// Sink the edges of the map into the water to make an island
				float dist = Vector2.Distance(center, new Vector2(x, y));
				val -= MapToCurve(dist / (properties.width / 2f));

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

	// Maps 0-1 to a curve
	private float MapToCurve(float i)
	{
		return Mathf.Pow(i, 4);
	}

	public IslandGenerator(MapProperties properties, TileStorage<Tile> storage) : base(properties, storage)
	{
		this.properties = properties;
		this.storage = storage;
	}
}
