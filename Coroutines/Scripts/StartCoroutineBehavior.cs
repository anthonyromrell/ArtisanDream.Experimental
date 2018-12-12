using UnityEngine;

public class StartCoroutineBehavior : MonoBehaviour
{
    [SerializeField] private Object coroutineObj;
    public IRunCoroutine CoroutineObj { private get; set; }

    private void Awake()
    {
        CoroutineObj = coroutineObj as IRunCoroutine;
        if (CoroutineObj != null) StartCoroutine(CoroutineObj.RunCoroutine());
    }
}
