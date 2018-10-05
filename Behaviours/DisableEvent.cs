using UnityEngine;
using UnityEngine.Events;

//Made By Anthony Romrell
namespace ArtisanDream.Experimental.Behaviours
{
	public class DisableEvent : MonoBehaviour
	{
		public UnityEvent Event;

		private void OnDisable()
		{
			Event.Invoke();
		}
	}
}
