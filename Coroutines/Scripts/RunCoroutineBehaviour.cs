using UnityEngine;

public class RunCoroutineBehaviour : MonoBehaviour
{
    public GameAction GetCoroutineObject;
    public GameAction CoroutineActionRun;
    private IRunCoroutine objectToRun;
    
    void Start()
    {
        GetCoroutineObject.Raise += GetObjectHandler;
        CoroutineActionRun.RaiseNoArgs += RunCoroutineActionHandler;
    }

    private void GetObjectHandler (object obj)
    {
        objectToRun = obj as IRunCoroutine;
    }

    private void RunCoroutineActionHandler()
    {
        StartCoroutine(objectToRun.RunCoroutine());
    }
}