using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

//Made By Anthony Romrell
public class DestroyEvent : MonoBehaviour
{
	public UnityEvent Event;

	private void OnDestroy()
	{
		Event.Invoke();
	}
}
