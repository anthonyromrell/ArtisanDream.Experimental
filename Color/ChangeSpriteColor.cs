using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSpriteColor : ScriptableObject
{
	private SpriteRenderer renderer;
	
	public void Invoke (ColorID color, SpriteRenderer spriteRenderer)
	{
		spriteRenderer.color = color.Value;
	}
}