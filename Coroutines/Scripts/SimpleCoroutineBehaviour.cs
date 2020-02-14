using System.Collections;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;

public class SimpleCoroutineBehaviour : MonoBehaviour
{
    [FormerlySerializedAs("Seconds")] public float seconds = 1;
    private WaitForSeconds wait;
    public UnityEvent Event;

    private void Awake()
    {
        wait = new WaitForSeconds(seconds);
    }

    private IEnumerator Start()
    {
        while (true)
        {
            yield return wait;
            Event.Invoke();
        }
    }
}
