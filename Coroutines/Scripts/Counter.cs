using System.Collections;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;

public class Counter : MonoBehaviour
{
    [FormerlySerializedAs("OnCount")] public UnityEvent onCount;
    [FormerlySerializedAs("EndCount")] public UnityEvent endCount;

    [FormerlySerializedAs("Seconds")] public float seconds = 4.0f;
    [FormerlySerializedAs("Numbers")] public int numbers = 30;
    [SerializeField] private IWait waitObj;

    IEnumerator Start()
    {
        while (numbers > 0)
        {
            onCount.Invoke();
            yield return new WaitForSeconds(seconds);
            numbers--;
        }
        endCount.Invoke();
    }

    public IWait WaitObj
    {
        get => waitObj;
        set => waitObj = value;
    }
}