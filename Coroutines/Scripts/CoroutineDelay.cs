using System.Collections;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(menuName = "Coroutines/Coroutine Delay")]
public class CoroutineDelay : ScriptableObject, IRunCoroutine
{
    public UnityEvent Event;
    public Object WaitObject;
    public IWait WaitObj { private get; set; }
    
    public void OnEnable()
    {
        WaitObj = WaitObject as IWait;
        WaitObj?.Create();
    }
    
    public IEnumerator RunCoroutine()
    {
        yield return WaitObj.Obj;
        Event.Invoke();
    }
}
