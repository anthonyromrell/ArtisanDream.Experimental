using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

[CreateAssetMenu(menuName = "Random/Color")]
	public class RandomColor : ScriptableObject
	{
 
		[FormerlySerializedAs("ColorIdList")] public List<ColorData> colorIdList;
 
		[FormerlySerializedAs("RandonColor")] public ColorData randonColor;
 	
		public void OnEnable()
		{
			var value = UnityEngine.Random.Range(0, colorIdList.Count);
			randonColor.value = colorIdList[value].value;
		}
	}
