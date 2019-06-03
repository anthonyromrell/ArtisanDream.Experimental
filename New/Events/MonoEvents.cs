using UnityEngine;
using UnityEngine.Events;

public class MonoEvents : MonoBehaviour
{
    public UnityEvent StartEvent, TriggerEnterEvent, MouseDownEvent;

    private void Start()
    {
        StartEvent.Invoke();
    }

    private void OnTriggerEnter(Collider other)
    {
        TriggerEnterEvent.Invoke();
    }

    private void OnMouseDown()
    {
        MouseDownEvent.Invoke();
    }
}