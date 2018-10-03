using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

//Made By Anthony Romrell
public class UpdateEvent : MonoBehaviour
{
	public UnityEvent Event;

	private void Update()
	{
		Event.Invoke();
	}
}
