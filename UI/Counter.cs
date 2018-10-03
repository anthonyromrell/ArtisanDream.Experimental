using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour
{
	private Text counterLabel;
	public float seconds = 1.0f;
	public int numbers = 3;

	IEnumerator Start ()
	{
		counterLabel = GetComponent<Text>();
		
		while (numbers > 0)
		{
			counterLabel.text = numbers.ToString();
			yield return new WaitForSeconds(seconds);
			numbers--;
		}
		
		counterLabel.text = "Go!";
		yield return new WaitForSeconds(2);
		counterLabel.text = "";
	}
}