using UnityEngine;

[CreateAssetMenu]
public class PatrolPoint : ScriptableObject
{
	public Vector3 Value;

	public void UpdateData(Transform t)
	{
		Value = t.position;
	}
}
