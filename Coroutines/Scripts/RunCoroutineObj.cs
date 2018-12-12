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
     
    public Object ObjectToWait;
    public IWait WaitObj { private get; set; }
    
    public UnityEvent Event;

    private void OnEnable()
    {
        WaitObj = ObjectToWait as IWait;
        calledWorkObject = ObjectToWork as ICall;
        WaitObj?.Create();
   //     SendThisCoroutine.Raise(this);
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
    IWait WaitObj { set; }
    IEnumerator RunCoroutine();
}