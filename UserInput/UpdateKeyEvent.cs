using UnityEngine;
using UnityEngine.Events;

public class UpdateKeyEvent : MonoBehaviour
{
	public UnityEvent Event;
	public KeyCode Code ;
	
	void Update () {
		if (Input.GetKey(Code))
		{
			Event.Invoke();
		}
	}
}
