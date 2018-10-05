using UnityEngine;

namespace ArtisanDream.Experimental.Transforming
{
	public class TransformObject : MonoBehaviour
	{

		public Vector3 Movement;
	
		// Use this for initialization
		void Start () {
		
		}
	
		// Update is called once per frame
		void Update () {
			//transform.Translate(Movement);
			transform.Rotate(Movement);
		}
	}
}
