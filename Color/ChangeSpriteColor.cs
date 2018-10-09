using UnityEngine;


	[CreateAssetMenu]
	public class ChangeSpriteColor : ScriptableObject
	{
		public ColorData Color;
	
		public void Invoke (SpriteRenderer spriteRenderer)
		{
			spriteRenderer.color = Color.Value;
		}
	}