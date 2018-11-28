using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class PerpetualCounter : MonoBehaviour
{
    public UnityEvent OnCount;
    public FloatData Seconds;

    private IEnumerator Start()
    {
        while (true)
        {
            yield return new WaitForSeconds(Seconds.Value);
            OnCount.Invoke();
        }
    }

    public void Restart()
    {
        StartCoroutine(Start());
    }
}