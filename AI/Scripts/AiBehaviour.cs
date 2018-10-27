using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Events;

//Made By Anthony Romrell
public class AiBehaviour : MonoBehaviour
{
    private NavMeshAgent agent;
    public AiBrain Brain;
    public AiBase OnStart, OnEnter, OnExit;
    private Coroutine coroutine;
    public GameAction TransferCoroutine;

    void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    private void Start()
    {
        TransferCoroutine.RaiseNoArgs = StartCoroutine;
        Brain.Base = OnStart;
        coroutine = StartCoroutine(Brain.Base.Nav(agent));
    }

    private void StartCoroutine()
    {
        OnCall(coroutine);
    }

    private void OnTriggerEnter(Collider other)
    {
        Brain.Base = OnEnter;
        OnCall(coroutine);
    }

    private void OnTriggerExit(Collider other)
    {
        Brain.Base = OnExit;
        OnCall(coroutine);
    }

    private void OnCall(Coroutine c)
    {
        StopCoroutine(c);
        coroutine = StartCoroutine(Brain.Base.Nav(agent));
    }
}