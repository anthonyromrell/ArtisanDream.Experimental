using UnityEngine;

namespace ArtisanDream.Experimental.Snapping
{
	public class SnapOn : MonoBehaviour
	{
		private Vector3 position;
	
		private void OnTriggerEnter(Collider other)
		{
			print(other.transform.position);
			position = other.transform.position;
		}

		public void Invoke()
		{
			transform.position = position;
		}
	}
}
