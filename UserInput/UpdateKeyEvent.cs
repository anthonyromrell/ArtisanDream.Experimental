using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;

public class UpdateKeyEvent : MonoBehaviour
{
	public GameAction action;
	public KeyCode code ;

	void Update () {
		if (Input.GetKey(code))
		{
			action.raiseNoArgs();
		}
	}
}
