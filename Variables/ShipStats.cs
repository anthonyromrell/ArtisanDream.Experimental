using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ShipStats : MonoBehaviour
{

	public int Score = 100;
	public int Money = 1000;

	public float Health = 1.0f;
	public float FirePower = 20.0f;

	public string ShipName = "Titanic";
	public string FleetName;

	public Vector3 Movement;

	public Color ShipColor = Color.green;

	public Animation Anims;

	public UnityEvent Event;

}
