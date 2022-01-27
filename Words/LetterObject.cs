using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Words/Letter")]
public class LetterObject : ScriptableObject
{
	public Sprite letterSprite;
	public NameID id;
	public AiPatrol patrol;
}
