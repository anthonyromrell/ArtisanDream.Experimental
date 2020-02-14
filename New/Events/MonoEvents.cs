using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;

public class MonoEvents : MonoBehaviour
{
    [FormerlySerializedAs("StartEvent")] public UnityEvent startEvent;
    [FormerlySerializedAs("TriggerEnterEvent")] public UnityEvent triggerEnterEvent;
    [FormerlySerializedAs("MouseDownEvent")] public UnityEvent mouseDownEvent;

    private void Start()
    {
        startEvent.Invoke();
    }

    private void OnTriggerEnter(Collider other)
    {
        triggerEnterEvent.Invoke();
    }

    private void OnMouseDown()
    {
        mouseDownEvent.Invoke();
    }
}