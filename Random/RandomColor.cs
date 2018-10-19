using System.Collections.Generic;
using UnityEngine;

	[CreateAssetMenu(menuName = "Random/Color")]
	public class RandomColor : ScriptableObject
	{
 
		public List<ColorData> ColorIdList;
 
		public ColorData RandonColor;
 	
		public void OnEnable()
		{
			var value = UnityEngine.Random.Range(0, ColorIdList.Count);
			RandonColor.Value = ColorIdList[value].Value;
		}
	}
