using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
	// For easy selection from the Unity inspector
	private enum GeneratorType { Random, Simple, Island };
	[SerializeField]
	private GeneratorType generatorType;
	
	private enum StorageType { Fixed };
	[SerializeField]
	private StorageType storageType;

	[SerializeField]
	private int mapWidth = 25;
	[SerializeField]
	private int mapHeight = 25;

	[SerializeField]
	private bool randomSeed = true;
	[SerializeField]
	private int seed = 0;


	private MapProperties properties;
	private TileStorage<Tile> storage;
	private TileSaveLoad saveload;
	private TileGenerator generator;
	private TileRender render;

	void Start()
	{
		if (!randomSeed) { Random.InitState(seed); }

		// Initialize map generator
		properties = new MapProperties(mapWidth, mapHeight, Random.Range(0f, 10f));

		storage = GetTileStorage<Tile>(properties);
		saveload = new FlatFileSaveLoad(properties, storage);
		generator = GetTileGenerator(properties, storage);
		render = new BasicRender(properties, storage);

		// Generate and render
		generator.GenerateTiles();
		render.RenderTiles();
	}

	// For easy selection from the Unity inspector
	private TileStorage<T> GetTileStorage<T>(MapProperties p)
	{
		switch (storageType)
		{
			case StorageType.Fixed: return new FixedStorage<T>(p);
			default: return null;
		}
	}

	private TileGenerator GetTileGenerator(MapProperties p, TileStorage<Tile> s)
	{
		switch (generatorType)
		{
			case GeneratorType.Random: return new RandomGenerator(p, s);
			case GeneratorType.Simple: return new SimpleGenerator(p, s);
			case GeneratorType.Island: return new IslandGenerator(p, s);
			default: return null;
		}
	}
}