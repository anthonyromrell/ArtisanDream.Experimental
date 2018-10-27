using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(menuName = "Ai/Point")]
public class PatrolPoint : ScriptableObject
{
	public GameAction SendPoint;
	public UnityEvent UpdateData;

	private void OnEnable()
	{
		UpdateData.Invoke();
	}

	public void OnUpdateData(Transform t)
	{
		SendPoint.Raise(t);
	}
}
