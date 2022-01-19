using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class TileRender
{
	protected MapProperties properties;
	protected TileStorage<Tile> storage;

	public abstract void RenderTiles();

	public TileRender(MapProperties properties, TileStorage<Tile> storage)
	{
		this.properties = properties;
		this.storage = storage;
	}
}