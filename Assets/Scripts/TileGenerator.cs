using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class TileGenerator
{
	protected MapProperties properties;
	protected TileStorage<Tile> storage;

	public abstract void GenerateTiles();

	public TileGenerator(MapProperties properties, TileStorage<Tile> storage)
	{
		this.properties = properties;
		this.storage = storage;
	}
}