using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class Counter : MonoBehaviour
{
    public UnityEvent OnCount;
    public UnityEvent EndCount;

    public float Seconds = 4.0f;
    public int Numbers = 30;
    [SerializeField] private IWait waitObj;

    IEnumerator Start()
    {
        while (Numbers > 0)
        {
            OnCount.Invoke();
            yield return new WaitForSeconds(Seconds);
            Numbers--;
        }
        EndCount.Invoke();
    }

    public IWait WaitObj
    {
        get => waitObj;
        set => waitObj = value;
    }
}