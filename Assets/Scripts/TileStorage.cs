using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class TileStorage<T>
{
	protected MapProperties properties;

	public abstract T GetTile(int x, int y);
	public abstract void SetTile(int x, int y, T tile);

	public TileStorage(MapProperties properties)
	{
		this.properties = properties;
	}
}