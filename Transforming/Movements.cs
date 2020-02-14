using UnityEngine;
using UnityEngine.Serialization;

namespace ArtisanDream.Experimental.Transforming
{
	public class Movements : MonoBehaviour {

		public enum MovementType
		{
			MoveX,
			MoveY,
			MoveZ
		}

		[FormerlySerializedAs("CurrentMovementType")] public MovementType currentMovementType;

		[FormerlySerializedAs("Movement")] public Vector3 movement;
		[FormerlySerializedAs("Speed")] public float speed;

	
		// Update is called once per frame
		void Update () {
			switch (currentMovementType)
			{
				case MovementType.MoveX:
					movement.x = speed;
					break;
				case MovementType.MoveY:
					movement.y = speed;
					break;
				case MovementType.MoveZ:
					movement.z = speed;
					break;
			}
			transform.Rotate(movement*Time.deltaTime);
		}
	}
}
