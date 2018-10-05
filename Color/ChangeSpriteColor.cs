using UnityEngine;

namespace ArtisanDream.Experimental.Color
{
	[CreateAssetMenu]
	public class ChangeSpriteColor : ScriptableObject
	{
		public ColorID Color;
	
		public void Invoke (SpriteRenderer spriteRenderer)
		{
			spriteRenderer.color = Color.Value;
		}
	}
}