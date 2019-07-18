using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Words/Letter Objects List")]
public class LetterObjectList : ScriptableObject
{
	public LetterObject[] letter;
}