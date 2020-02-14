using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Words/Letter")]
public class LetterObject : ScriptableObject
{
	public Sprite letterSprite;
	public NameId id;
	public AiPatrol patrol;
}
