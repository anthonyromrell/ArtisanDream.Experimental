using ArtisanDream.Tools.Objects;
using UnityEngine;

namespace ArtisanDream.Experimental.FloatTypes
{
	[CreateAssetMenu(fileName = "FloatBoolAndCount")]
	public class FloatBoolAndCount : FloatBool
	{
		public IntData Count;

		private void OnEnable()
		{
			Count.Value = 0;
		}

		public override float Value
		{
			get
			{
				if (Count.Value <= 0) return 0;
				if (!UnityEngine.Input.GetButtonDown(InputType)) return 0;
				Count.Value--;
				return value;
			}
		}
	}
}