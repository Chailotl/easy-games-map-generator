using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct Tile
{
	// An enum would be preferable
	public readonly uint id;

	public Tile(uint id)
	{
		this.id = id;
	}

	// Not ideal but it works
	public GameObject GetPrefab()
	{
		switch (id)
		{
			case 1: return Resources.Load<GameObject>("Tiles/Grass");
			case 2: return Resources.Load<GameObject>("Tiles/Rock");
			case 3: return Resources.Load<GameObject>("Tiles/Dirt");
			case 4: return Resources.Load<GameObject>("Tiles/Water");
			case 5: return Resources.Load<GameObject>("Tiles/Lava");
			default: return Resources.Load<GameObject>("Tiles/Generic");
		}
	}
}