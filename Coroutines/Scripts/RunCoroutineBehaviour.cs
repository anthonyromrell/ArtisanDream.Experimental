using UnityEngine;
using UnityEngine.Events;

public class RunCoroutineBehaviour : MonoBehaviour
{
    public GameAction GetCoroutineObject;
    public GameAction CoroutineActionRun;
    private IRunCoroutine objectToRun;
    public UnityEvent StartEvent;

    private void Awake()
    {
        GetCoroutineObject.Raise += GetObjectHandler;
        CoroutineActionRun.RaiseNoArgs += RunCoroutineActionHandler;
    }

    private void Start()
    {
        StartEvent.Invoke();
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