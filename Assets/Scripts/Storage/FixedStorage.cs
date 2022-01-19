using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnityEngine;

public class FixedStorage<T> : TileStorage<T>
{
	private T[,] tiles;

	public override T GetTile(int x, int y)
	{
		if (x >= 0 && x < tiles.GetLength(0) && y >= 0 && y < tiles.GetLength(1))
		{
			return tiles[x, y];
		}
		
		return default(T);
	}

	public override void SetTile(int x, int y, T tile)
	{
		if (x >= 0 && x < tiles.GetLength(0) && y >= 0 && y < tiles.GetLength(1))
		{
			tiles[x, y] = tile;
		}
	}

	public FixedStorage(MapProperties properties) : base(properties)
	{
		this.properties = properties;

		tiles = new T[properties.width, properties.height];
	}
}