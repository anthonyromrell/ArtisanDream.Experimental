using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
	private SpriteRenderer spr;
	
	void Start ()
	{
		spr = GetComponent<SpriteRenderer>();
	}
	
	public void Invoke (ColorID color)
	{
		spr.color = color.Value;
	}
}
