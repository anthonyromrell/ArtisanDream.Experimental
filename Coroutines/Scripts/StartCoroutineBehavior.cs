using UnityEngine;
using UnityEngine.Serialization;

public class StartCoroutineBehavior : MonoBehaviour
{
    [SerializeField] private Object coroutineObj;
    public IRunCoroutine CoroutineObj { private get; set; }
    [FormerlySerializedAs("CanRunAtStart")] public bool canRunAtStart;
    
    private void Start()
    {
        CoroutineObj = coroutineObj as IRunCoroutine;
        if (CoroutineObj != null && canRunAtStart) StartCoroutine(CoroutineObj.RunCoroutine());
    }

    public void Run()
    {
        CoroutineObj = coroutineObj as IRunCoroutine;
        StartCoroutine(CoroutineObj.RunCoroutine());
    }
}
