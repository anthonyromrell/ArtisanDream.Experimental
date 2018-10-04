using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class RandomObjectSelector : ScriptableObject
{
	public List<Object> ObjectList;
	
	public Object ReturnRandomObject()
	{
		var value = Random.Range(0, ObjectList.Count-1);
		return ObjectList[value];
	}
}