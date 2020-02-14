using System.Collections;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;

public class SimpleDelayBehaviour : MonoBehaviour
{
    //public Object WaitObject;
    //public IWait Waitobj;
    [FormerlySerializedAs("Seconds")] public float seconds;
    public UnityEvent Event;
    private WaitForSeconds wait;
    
    private void Start()
    {
        wait = new WaitForSeconds(seconds);
    }

    public void Run()
    {
        StartCoroutine(RunCoroutine());
    }
    
    // Start is called before the first frame update
    IEnumerator RunCoroutine()
    {
        yield return wait;
        Event.Invoke();
    }
}
