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
			transform.position = position;
		}
	}
}
