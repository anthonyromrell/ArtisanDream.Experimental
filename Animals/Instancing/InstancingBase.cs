using UnityEngine;

[CreateAssetMenu]
public class InstancingBase : ScriptableObject
{
	private Vector3 position;
	
	public void InstanceObject (GameObject prefab)
	{
		position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		position.z = 0;
		Instantiate(prefab, position, Quaternion.identity);
	}
}