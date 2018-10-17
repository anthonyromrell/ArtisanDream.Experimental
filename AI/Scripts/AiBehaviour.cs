using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

//Made By Anthony Romrell
public class AiBehaviour : MonoBehaviour
{
	private NavMeshAgent agent;
	//private Animator anims;
	public AiBrain Brain;
	public AiBase OnStart, OnEnter, OnExit;
	
	void Awake ()
	{
		agent = GetComponent<NavMeshAgent>();
	//	anims = GetComponent<Animator>();
	//	anims.GetBehaviour<AiStateMachine>().Agent = GetComponent<NavMeshAgent>();
	}

	private void Start()
	{
		Brain.Base = OnStart;
		//	anims.SetTrigger(Brain.StartingState.ToString());
	}

	private void OnTriggerEnter(Collider other)
	{
		Brain.Base = OnEnter;
	//	anims.SetTrigger(Brain.TriggerEnterState.ToString());
	}
	
	private void OnTriggerExit(Collider other)
	{
		Brain.Base = OnExit;
	//	anims.SetTrigger(Brain.TriggerExitState.ToString());
	}

	private void Update()
	{
		Brain.Base.Navigate(agent);
	}
}