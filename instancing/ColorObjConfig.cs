using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

[CreateAssetMenu]
public class ColorObjConfig : ScriptableObject
{
	[FormerlySerializedAs("Id")] public NameId id;
	[FormerlySerializedAs("Color")] public ColorData color;
}
