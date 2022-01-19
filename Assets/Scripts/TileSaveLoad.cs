using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class TileSaveLoad
{
	protected MapProperties properties;
	protected TileStorage<Tile> storage;

	public abstract void SaveTiles();
	public abstract void LoadTiles();

	public TileSaveLoad(MapProperties properties, TileStorage<Tile> storage)
	{
		this.properties = properties;
		this.storage = storage;
	}
}