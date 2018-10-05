using UnityEngine;

public class TriggerInvoke : MonoBehaviour
{
	public ChangeSpriteColor ChangeColor;
	
	private void OnTriggerEnter(Collider other)
	{
		ChangeColor.Invoke(other.GetComponent<SpriteRenderer>());
	}
}