using ArtisanDream.Experimental.Color;
using UnityEngine;

namespace ArtisanDream.Experimental.Behaviours
{
	public class TriggerInvoke : MonoBehaviour
	{
		public ChangeSpriteColor ChangeColor;
	
		private void OnTriggerEnter(Collider other)
		{
			ChangeColor.Invoke(other.GetComponent<SpriteRenderer>());
		}
	}
}