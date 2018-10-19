using System.Collections;
using UnityEngine;

namespace ArtisanDream.Experimental
{
	public class SnapOn : MonoBehaviour
	{
		public FloatData Speed;
		public FloatData HoldTime;
		private Vector3 position;
		
		private void OnTriggerEnter(Collider other)
		{
			position = other.transform.position;
		}

		public void Call()
		{
			StartCoroutine(MoveTo());
			StartCoroutine(Stop());
		}

		private IEnumerator Stop()
		{
			yield return new WaitForSeconds(HoldTime.Value);
			StopAllCoroutines();
		}

		private IEnumerator MoveTo()
		{
			while (transform.position.x != position.x)
			{
				yield return new WaitForFixedUpdate();
				transform.position = Vector3.Lerp(transform.position, position, Speed.Value);
			}
		}
	}
}