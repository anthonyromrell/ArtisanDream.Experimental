using UnityEngine;

namespace ArtisanDream.Experimental.Transforming
{
	public class TransformObject : MonoBehaviour
	{
		public Vector3 Movement;
	
		void Update () {
			//transform.Translate(Movement);
			transform.Rotate(Movement);
		}
	}
}
