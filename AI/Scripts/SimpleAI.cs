using System.Collections;
using UnityEngine;
using UnityEngine.AI;

public class SimpleAI : MonoBehaviour
{
	public Transform Destination;
	private NavMeshAgent agent;

	void Start ()
	{
		agent = GetComponent<NavMeshAgent>();
	}
	
	void Update ()
	{
		agent.destination = Destination.position;
	}
}
