using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;

public class RunCoroutineBehaviour : MonoBehaviour
{
    [FormerlySerializedAs("GetCoroutineObject")] public GameAction getCoroutineObject;
    [FormerlySerializedAs("CoroutineActionRun")] public GameAction coroutineActionRun;
    private IRunCoroutine objectToRun;
    [FormerlySerializedAs("StartEvent")] public UnityEvent startEvent;

    private void Awake()
    {
        getCoroutineObject.raise += GetObjectHandler;
        coroutineActionRun.raiseNoArgs += RunCoroutineActionHandler;
    }

    private void Start()
    {
        startEvent.Invoke();
    }

    public void GetObjectHandler (object obj)
    {
        objectToRun = obj as IRunCoroutine;
    }

    public void RunCoroutineActionHandler()
    {
        StartCoroutine(objectToRun.RunCoroutine());
    }
}