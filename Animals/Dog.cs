using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : Mammal
{
	public string Bark;

	public void OnBark()
	{
		print(Bark);
	}	
}