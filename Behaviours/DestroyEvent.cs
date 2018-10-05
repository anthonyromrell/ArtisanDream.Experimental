using UnityEngine;
using UnityEngine.Events;

//Made By Anthony Romrell
namespace ArtisanDream.Experimental.Behaviours
{
	public class DestroyEvent : MonoBehaviour
	{
		public UnityEvent Event;

		private void OnDestroy()
		{
			Event.Invoke();
		}
	}
}
