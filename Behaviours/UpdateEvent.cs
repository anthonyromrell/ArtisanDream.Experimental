using UnityEngine;
using UnityEngine.Events;

//Made By Anthony Romrell
namespace ArtisanDream.Experimental.Behaviours
{
	public class UpdateEvent : MonoBehaviour
	{
		public UnityEvent Event;

		private void Update()
		{
			Event.Invoke();
		}
	}
}
