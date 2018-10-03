using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
