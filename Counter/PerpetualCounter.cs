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
            OnCount.Invoke();
            yield return new WaitForSeconds(Seconds.Value);
        }
    }

    public void Restart()
    {
        StartCoroutine(Start());
    }
}