using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Events;

//Made By Anthony Romrell
public class AiBehaviour : MonoBehaviour
{
	private NavMeshAgent agent;
	public AiBrain Brain;
	public AiBase OnStart, OnEnter, OnExit, OnStop;
	private Coroutine coroutine;
	public UnityEvent Event;
	public GameAction TransferCoroutine;
	
	void Awake ()
	{
		agent = GetComponent<NavMeshAgent>();
	}

	private void Start()
	{
		TransferCoroutine.RaiseNoArgs = CallNoArgs;
		Brain.Base = OnStart;
		coroutine = StartCoroutine(Brain.Base.Nav(agent));
	}

	private void CallNoArgs()
	{
		OnCall(coroutine);
	}

	private void OnTriggerEnter(Collider other)
	{
		print(other);
		Brain.Base = OnEnter;
		OnCall(coroutine);
	}
	
	private void OnTriggerExit(Collider other)
	{
		print(other);
		Brain.Base = OnExit;
		OnCall(coroutine);
	}
	
	
	private void OnCall(Coroutine c)
	{
		StopCoroutine(c);
		coroutine = StartCoroutine(Brain.Base.Nav(agent));
	}

}