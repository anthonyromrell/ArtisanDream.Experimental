using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngineInternal;

[CreateAssetMenu]
public class RandomValue : ScriptableObject
{
	public FloatData RandomNumber;

	[Range(0,10)] public float ValueRange;
	
	public void Randomize()
	{
		RandomNumber.Value =  Mathf.RoundToInt(Random.Range(0, ValueRange));
	}
}
