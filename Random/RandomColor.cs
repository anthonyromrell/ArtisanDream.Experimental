using System.Collections.Generic;
using ArtisanDream.Experimental.Color;
using UnityEngine;

namespace ArtisanDream.Experimental.Random
{
	[CreateAssetMenu]
	public class RandomColor : ScriptableObject
	{
 
		public List<ColorID> ColorIdList;
 
		public ColorID RandonColor;
 	
		public void OnEnable()
		{
			var value = UnityEngine.Random.Range(0, ColorIdList.Count);
			RandonColor.Value = ColorIdList[value].Value;
		}
	}
}