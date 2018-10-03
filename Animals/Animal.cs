using UnityEngine;
using UnityEngine.Events;

public class Animal : MonoBehaviour
{
	public Color AnimalColor = Color.blue;
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