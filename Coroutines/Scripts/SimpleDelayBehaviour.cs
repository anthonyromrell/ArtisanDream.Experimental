using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class SimpleDelayBehaviour : MonoBehaviour
{
    //public Object WaitObject;
    //public IWait Waitobj;
    public float Seconds;
    public UnityEvent Event;
    private WaitForSeconds wait;
    
    private void Start()
    {
        wait = new WaitForSeconds(Seconds);
    }

    public void Run()
    {
        StartCoroutine(IRunCoroutine());
    }
    
    // Start is called before the first frame update
    IEnumerator IRunCoroutine()
    {
        yield return wait;
        Event.Invoke();
    }
}
