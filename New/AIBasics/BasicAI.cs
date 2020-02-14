using UnityEngine;
using UnityEngine.Events;
using UnityEngine.AI;
using UnityEngine.Serialization;

[RequireComponent(typeof(NavMeshAgent))]
public class BasicAi : MonoBehaviour
{
    private NavMeshAgent agent;
    [FormerlySerializedAs("Player")] public Transform player;

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        agent.destination = player.position;
    }
}