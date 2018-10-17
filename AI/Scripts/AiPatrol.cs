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
	
	public List<PatrolPoint> PatrolPoints { get ; set; }

	private void OnEnable()
	{
		i = 0;
		PatrolPoints.Clear();
		if (AddPointsToList != null) AddPointsToList.Call += AddPatrolPoints;
		if (AddPointList != null) AddPointList.Call += AddPatrolPointList;
	}

	private void AddPatrolPoints(object obj)
	{
		PatrolPoints.Add(obj as PatrolPoint);
	}
	
	private void AddPatrolPointList (object obj)
	{
		PatrolPoints = obj as List<PatrolPoint>;
	}
	
	public override void Navigate(NavMeshAgent ai)
	{
		ai.destination = PatrolPoints[0].Value;
		if ((ai.remainingDistance > 0)) return;
	}
}