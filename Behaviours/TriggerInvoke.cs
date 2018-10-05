using UnityEngine;

public class TriggerInvoke : MonoBehaviour
{
	public InvokeBase InvokeObject;
	
	private void OnTriggerEnter(Collider other)
	{
		InvokeObject.Invoke(other.GetComponent<SpriteRenderer>());
		print(other);
		//ChangeColor.Invoke(other.GetComponent<SpriteRenderer>());
	}
}