using UnityEngine;

//Made By Anthony Romrell
public class InstanceObject : MonoBehaviour
{

	public GameObject Instance;
	
	private void Start()
	{
		Instantiate(Instance);
	}
}
