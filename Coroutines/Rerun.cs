using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu]
public class Rerun : ScriptableObject
{
	public int i = 10;
	public GameAction Action;
	public UnityEvent Event;

	public IEnumerator OnRun()
	{
		while (i > 0)
		{
			Event.Invoke();
			i--;
			yield return new WaitForFixedUpdate();
		}

		i = 10;
		yield return new WaitForSeconds(2);
		Action.RaiseNoArgs();
	}
}