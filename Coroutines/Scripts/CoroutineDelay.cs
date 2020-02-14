using System.Collections;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;

[CreateAssetMenu(menuName = "Coroutines/Coroutine Delay")]
public class CoroutineDelay : ScriptableObject, IRunCoroutine
{
    public UnityEvent Event;
    [FormerlySerializedAs("WaitObject")] public Object waitObject;
    public IWait WaitObj { private get; set; }
    
    public void OnEnable()
    {
        WaitObj = waitObject as IWait;
        WaitObj?.Create();
    }
    
    public IEnumerator RunCoroutine()
    {
        yield return WaitObj.Obj;
        Event.Invoke();
    }
}
