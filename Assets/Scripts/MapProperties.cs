using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapProperties
{
	public readonly int width;
	public readonly int height;
	public readonly float seed;

	public MapProperties(int width, int height, float seed)
	{
		this.width = width;
		this.height = height;
		this.seed = seed;
	}
}