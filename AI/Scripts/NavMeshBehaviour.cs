using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class NavMeshBehaviour : MonoBehaviour
{
	private NavMeshAgent navMeshAgent;
	public AiBase AiBase;
    
	void Start ()
	{
		navMeshAgent = GetComponent<NavMeshAgent>();
	}

	void Update () {
		AiBase.Navigate(navMeshAgent);
	}
}