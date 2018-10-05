using ArtisanDream.Tools.Objects;
using UnityEngine;

namespace ArtisanDream.Experimental.FloatTypes
{
	[CreateAssetMenu(fileName = "FloatBool")]
	public class FloatBool : FloatData 
	{
		public string InputType;
		public override float Value => UnityEngine.Input.GetButton(InputType) ? value : 0;
	}
}