using System.Collections.Generic;
using UnityEngine;

//Made By Anthony Romrell
public class AddPatrolPointsList : MonoBehaviour
{

	private List<Vector3Data> patrolPoints;
	public List<Transform> PointObjects;
	
	public GameAction OnSendAction;

	private void Start()
	{
		patrolPoints = new List<Vector3Data>();
		foreach (var obj in PointObjects)
		{
			UpdateInfo(obj);
		}
		SendAction();
	}

	public void UpdateInfo(Transform t)
	{
		Vector3Data temp = ScriptableObject.CreateInstance<Vector3Data>();
		temp.Value = t.position;
		patrolPoints.Add(temp);
	}

	public void SendAction()
	{
		OnSendAction.Raise(patrolPoints);
	}
}
