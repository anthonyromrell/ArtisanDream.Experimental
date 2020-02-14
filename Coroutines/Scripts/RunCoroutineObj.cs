using System.Collections;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;

[CreateAssetMenu(menuName = "Coroutines/Coroutine Object")]
public class RunCoroutineObj : ScriptableObject, IRunCoroutine
{
    [FormerlySerializedAs("ObjectToWork")] public Object objectToWork;
    private ICall calledWorkObject;
    [FormerlySerializedAs("SendThisCoroutine")] public GameAction sendThisCoroutine;
    [FormerlySerializedAs("RunThisCoroutine")] public GameAction runThisCoroutine;

    [FormerlySerializedAs("WaitObject")] public Object waitObject;
    public IWait WaitObj { private get; set; }
    
    public UnityEvent Event;

    public void OnEnable()
    {
        WaitObj = waitObject as IWait;
        calledWorkObject = objectToWork as ICall;
        WaitObj?.Create();
    }

    public void StartRun()
    {
        runThisCoroutine.raiseNoArgs();
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