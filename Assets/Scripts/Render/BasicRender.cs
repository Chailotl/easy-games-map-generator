using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicRender : TileRender
{
	public override void RenderTiles()
	{
		for (int x = 0; x < properties.width; ++x)
		{
			for (int y = 0; y < properties.height; ++y)
			{
				Tile tile = storage.GetTile(x, y);
				Object.Instantiate(tile.GetPrefab(), new Vector3(x, 0, y), Quaternion.Euler(90, 0, 0));
			}
		}
	}

	public BasicRender(MapProperties properties, TileStorage<Tile> storage) : base(properties, storage)
	{
		this.properties = properties;
		this.storage = storage;
	}
}