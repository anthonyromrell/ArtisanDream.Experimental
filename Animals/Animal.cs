using UnityEngine;
using UnityEngine.Events;

namespace ArtisanDream.Experimental.Animals
{
	public class Animal : MonoBehaviour
	{
		public UnityEngine.Color AnimalColor = UnityEngine.Color.blue;
		public ParticleSystem Fx;
	
		public UnityEvent Event;
	
		public void OnMouseDown()
		{
			Event.Invoke();
		}

		public void Start()
		{
			GetComponent<Renderer>().material.color = AnimalColor;
		}
	}
}