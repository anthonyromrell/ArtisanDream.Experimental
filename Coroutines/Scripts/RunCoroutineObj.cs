using System.Collections;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(menuName = "Coroutines/Coroutine Object")]
public class RunCoroutineObj : ScriptableObject, IRunCoroutine
{
    public Object ObjectToWork;
    private ICall calledWorkObject;
    public GameAction SendThisCoroutine;
    public GameAction RunThisCoroutine;

    public Object WaitObject;
    public IWait WaitObj { private get; set; }
    
    public UnityEvent Event;

    public void OnEnable()
    {
        WaitObj = WaitObject as IWait;
        calledWorkObject = ObjectToWork as ICall;
        WaitObj?.Create();
    }

    public void StartRun()
    {
        RunThisCoroutine.RaiseNoArgs();
    }
    
    public IEnumerator RunCoroutine()
    {
        while (true)
        {
            yield return WaitObj.Obj;
            calledWorkObject?.Call();
            Event.Invoke();
        }
    }
}

public interface IRunCoroutine
{
    //Object WaitObject { get; set; }
    IWait WaitObj { set; }
    void OnEnable();
    IEnumerator RunCoroutine();
}