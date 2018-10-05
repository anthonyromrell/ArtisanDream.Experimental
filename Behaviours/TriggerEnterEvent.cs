using UnityEngine;
using UnityEngine.Events;

//Made By Anthony Romrell
namespace ArtisanDream.Experimental.Behaviours
{
	public class TriggerEnterEvent : MonoBehaviour
	{
		public UnityEvent Event;

		private void OnTriggerEnter(Collider other)
		{
			Event.Invoke();
		}
	}
}
