using ArtisanDream.Experimental.Color;
using UnityEngine;

namespace ArtisanDream.Experimental.Behaviours
{
	public InvokeBase InvokeObject;
	
	private void OnTriggerEnter(Collider other)
	{
		InvokeObject.Invoke(other.GetComponent<SpriteRenderer>());
		print(other);
		//ChangeColor.Invoke(other.GetComponent<SpriteRenderer>());
	}
}