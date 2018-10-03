using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movements : MonoBehaviour {

	public enum MovementType
	{
		MoveX,
		MoveY,
		MoveZ
	}

	public MovementType CurrentMovementType;

	public Vector3 Movement;
	public float Speed;

	
	// Update is called once per frame
	void Update () {
		switch (CurrentMovementType)
		{
				case MovementType.MoveX:
					Movement.x = Speed;
					break;
				case MovementType.MoveY:
					Movement.y = Speed;
					break;
				case MovementType.MoveZ:
					Movement.z = Speed;
					break;
		}
		transform.Rotate(Movement*Time.deltaTime);
	}
}
