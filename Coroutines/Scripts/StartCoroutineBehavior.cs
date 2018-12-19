using UnityEngine;

public class StartCoroutineBehavior : MonoBehaviour
{
    [SerializeField] private Object coroutineObj;
    public IRunCoroutine CoroutineObj { private get; set; }
    public bool CanRunAtStart;
    
    private void Start()
    {
        CoroutineObj = coroutineObj as IRunCoroutine;
        if (CoroutineObj != null && CanRunAtStart) StartCoroutine(CoroutineObj.RunCoroutine());
    }

    public void Run()
    {
        CoroutineObj = coroutineObj as IRunCoroutine;
        StartCoroutine(CoroutineObj.RunCoroutine());
    }
}
