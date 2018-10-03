using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfStatements : MonoBehaviour
{

	public int A;
	public int B;
	public int C;
	
	public string Password;
	public bool OnSwitch;
	public Material LampMaterial;
	
	void Update () {
		
		if (OnSwitch)
		{
			LampMaterial.color = Color.white;
		}
		else
		{
			LampMaterial.color = Color.black;
		}
		

		if (Password == "OU812")
		{
			print("Correct Password.");
		}
		else
		{
			print("Incorrect Password.");
		}

		if (A + B == C)
		{
			print("A plus B is equal to C.");
		}
		else
		{
			print("A plus B is not equal to C.");
		}		
	}
}