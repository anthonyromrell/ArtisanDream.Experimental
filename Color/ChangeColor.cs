using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class ChangeColor : InvokeBase, IInvoke<SpriteRenderer>
{
	public ColorData ObjectColor;

	public void Invoke(SpriteRenderer obj)
	{
		Debug.Log("Color");
	}

	public override void Invoke(Object obj)
	{
		throw new System.NotImplementedException();
	}
}