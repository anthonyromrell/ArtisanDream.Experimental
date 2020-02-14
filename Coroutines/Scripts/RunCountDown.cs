using System.Collections;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

//Made By Anthony Romrell
namespace ArtisanDream.Experimental.Counter
{
	public class RunCountDown : MonoBehaviour
	{
		[FormerlySerializedAs("Seconds")] public float seconds = 1.0f;
		[FormerlySerializedAs("Number")] public int number = 3;
		private Text label;
	
		IEnumerator Start ()
		{
			label = GetComponent<Text>();

			while (number > 0)
			{
		    
				yield return new WaitForSeconds(seconds);
				label.text = number.ToString();
				number--;
			}
			//label.text = "";
			yield return new WaitForSeconds(1);
			label.text = "GO!";
		}

		private IEnumerator OnTriggerEnter(Collider other)
		{
			yield return new WaitForSeconds(5);
		}
	}
}