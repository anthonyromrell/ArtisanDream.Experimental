using System.Collections;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Events;

//Made By Anthony Romrell
public class AiBehaviour : MonoBehaviour
{
    public UnityEvent RestartEvent, EndRestartEvent;
    
    public AiBase OnStart, OnEnter, OnExit;
    
    [HideInInspector]
    public AiBrain Brain;
    
    [HideInInspector]
    public AiPatrol Patrol;
    private Coroutine coroutine;
    private NavMeshAgent agent;

    public FloatData HoldTime;

    private void Start()
    {  
        Brain = ScriptableObject.CreateInstance<AiBrain>();
        Patrol = OnStart as AiPatrol;
        if (Patrol != null)
        {
            Patrol.SendCoroutine = ScriptableObject.CreateInstance<GameAction>();
            Patrol.SendCoroutine.RaiseNoArgs += CallCoroutine;
        }

        agent = GetComponent<NavMeshAgent>();
        Brain.Base = OnStart;
        coroutine = StartCoroutine(Brain.Base.Nav(agent));
    }

    private void CallCoroutine()
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
        if (agent.isActiveAndEnabled)
        {
            coroutine = StartCoroutine(Brain.Base.Nav(agent));
        }
    }

    public void ChangeBase(AiBase ai)
    {
        Brain.Base = ai;
    }

    public void Restart()
    {
        StartCoroutine(OnRestart());
    }

    private IEnumerator OnRestart()
    {
        RestartEvent.Invoke();
        yield return new WaitForSeconds(HoldTime.Value);
        EndRestartEvent.Invoke();
        agent.enabled = true;
        OnCall(coroutine);
    }
}