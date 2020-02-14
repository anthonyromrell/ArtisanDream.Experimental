using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;

public class UpdateKeyEvent : MonoBehaviour
{
	public UnityEvent Event;
	[FormerlySerializedAs("Code")] public KeyCode code ;
	
	void Update () {
		if (Input.GetKey(code))
		{
			Event.Invoke();
		}
	}
}
