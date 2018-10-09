using System.Collections;
using UnityEngine;

namespace ArtisanDream.Experimental
{
	public class SnapOn : MonoBehaviour
	{
		private Vector3 position;
	
		private void OnTriggerEnter(Collider other)
		{
			print(other.transform.position);
			position = other.transform.position;
		}

		public void Call()
		{
			print(position);
			//transform.position = position;
			StartCoroutine(MoveTo());
		}

		IEnumerator MoveTo()
		{
			while (true)
			{
				yield return new WaitForFixedUpdate();
				transform.position = Vector3.Lerp(transform.position, position, 0.1f);
			}
		}
	}
}
