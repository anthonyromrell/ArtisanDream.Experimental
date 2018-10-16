using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

//Made By Anthony Romrell
public class AiBehaviour : MonoBehaviour
{
	private Animator anims;
	public AiBrain Brain;
	
	void Awake ()
	{
		anims = GetComponent<Animator>();
		anims.GetBehaviour<AiStateMachine>().Agent = GetComponent<NavMeshAgent>();
	}

	private void Start()
	{
		anims.SetTrigger(Brain.StartingState.ToString());
	}

	private void OnTriggerEnter(Collider other)
	{
		anims.SetTrigger(Brain.TriggerEnterState.ToString());
	}
	
	private void OnTriggerExit(Collider other)
	{
		anims.SetTrigger(Brain.TriggerExitState.ToString());
	}
}