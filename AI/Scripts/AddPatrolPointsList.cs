using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

//Made By Anthony Romrell
public class AddPatrolPointsList : MonoBehaviour
{

	public List<PatrolPoint> PatrolPoints;
	
	public UnityEvent UpdateInfo;
	public GameAction SendAction;
	

	private void Start()
	{
		UpdateInfo.Invoke();
		SendAction.Raise(PatrolPoints);
	}

}
