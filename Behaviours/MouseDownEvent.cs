using UnityEngine;
using UnityEngine.Events;

//Made By Anthony Romrell
namespace ArtisanDream.Experimental.Behaviours
{
	public class MouseDownEvent : MonoBehaviour
	{
		public UnityEvent Event;

		private void OnMouseDown()
		{
			Event.Invoke();
		}
	}
}
