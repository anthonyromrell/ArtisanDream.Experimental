using UnityEngine;


	[CreateAssetMenu(menuName = "Change/Render Color")]
	public class ChangeRenderColor : ScriptableObject
	{
		private ColorData Color;

		public void ColorSelection (ColorData c)
		{
			Color = c;
		}
	
		public void ChangeSprite (SpriteRenderer spriteRenderer)
		{
			spriteRenderer.color = Color.Value;
		}
		
		public void ChangeMaterial (Material material)
		{
			material.color = Color.Value;
		}
	}