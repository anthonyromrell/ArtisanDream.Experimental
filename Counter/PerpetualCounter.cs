using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class PerpetualCounter : MonoBehaviour
{
	public UnityEvent OnCount;
	public FloatData Seconds;

	IEnumerator Start () {
		while (true)
		{
			OnCount.Invoke();
			yield return new WaitForSeconds(Seconds.Value);
		}
	}
}