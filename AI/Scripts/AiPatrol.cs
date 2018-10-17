using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Events;

[CreateAssetMenu(fileName = "Hunt", menuName = "Ai/Function/Patrol")]
public class AiPatrol : AiBase
{

	public UnityEvent EndPatrol;
	
	private int i = 0;

	public GameAction AddPointsToList;
	public GameAction AddPointList;
	public float distance = 0;
	
	public List<Transform> PatrolPoints { get ; set; }

	private void OnEnable()
	{
		i = 0;
		PatrolPoints.Clear();
		if (AddPointsToList != null) AddPointsToList.Call += AddPatrolPoints;
		if (AddPointList != null) AddPointList.Call += AddPatrolPointList;
	}

	private void AddPatrolPoints(object obj)
	{
		PatrolPoints.Add(obj as Transform);
	}
	
	private void AddPatrolPointList (object obj)
	{
		PatrolPoints = obj as List<Transform>;
	}
	
	public override void Navigate(NavMeshAgent ai)
	{
		ai.speed = Speed.Value;
		ai.angularSpeed = AngularSpeed.Value;
		if (ai.remainingDistance <= distance)
		{
			Debug.Log(ai.remainingDistance);
			Debug.Log(i);
			if (i < PatrolPoints.Count - 1)
			{
				i++;
			} else
			{
				EndPatrol.Invoke();
			}
		}
		ai.destination = PatrolPoints[i].position;
	}

	public void RestartPatrol()
	{
		i = 0;
	}
}