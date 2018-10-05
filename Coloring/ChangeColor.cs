using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class ChangeColor : ScriptableObject
{
	public ColorData ObjectColor;
	
	//private SpriteRenderer sRenderer;

	public void Invoke(SpriteRenderer sRenderer)
	{
		//sRenderer = GetComponent<SpriteRenderer>();
		sRenderer.color = ObjectColor.Value;
	}
	
	public void Invoke(Material sRenderer)
	{
		//sRenderer = GetComponent<SpriteRenderer>();
		sRenderer.color = ObjectColor.Value;
	}
}