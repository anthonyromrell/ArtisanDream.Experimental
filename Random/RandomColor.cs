using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class RandomColor : ScriptableObject
 {
 
 	public List<ColorID> ColorIdList;
 
 	public ColorID RandonColor;
 	
 	public void OnEnable()
 	{
 		var value = Random.Range(0, ColorIdList.Count);
 		RandonColor.Value = ColorIdList[value].Value;
 	}
 }