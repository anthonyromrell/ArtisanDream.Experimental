using System.Collections;
using UnityEngine;

[CreateAssetMenu(menuName = "Coroutines/Object")]
public class RunCoroutineObj : ScriptableObject, IRunCoroutine
{
    public float Seconds = 0.1f;
    public object ObjectToWork;
    private ICall CalledWorkObject;

    private void OnEnable()
    {
        CalledWorkObject = ObjectToWork as ICall;
    }

    public IEnumerator RunCoroutine()
    {
        while (true)
        {
            yield return new WaitForSeconds(Seconds);
            CalledWorkObject?.Call();
        }
    }
}

public interface IRunCoroutine
{
    IEnumerator RunCoroutine();
}