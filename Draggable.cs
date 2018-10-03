using UnityEngine;

public class Draggable : MonoBehaviour
{
	private Vector3 myPosition;
	private Vector3 previousPosition;
	private Camera Cam;

	private void Start()
	{
		Cam = Camera.main;
	}

	private void OnMouseDown()
	{
		previousPosition = transform.position - Cam.ScreenToWorldPoint(Input.mousePosition);
	}

	void OnMouseDrag ()
	{
		myPosition = Cam.ScreenToWorldPoint(Input.mousePosition) + previousPosition;
		myPosition.z = 0;
		transform.position = myPosition;
	}
}