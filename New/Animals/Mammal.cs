using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;

[CreateAssetMenu]
public class Mammal : Animal
{
   [FormerlySerializedAs("FurCount")] public int furCount = 10000;
   [FormerlySerializedAs("FurColor")] public Color furColor = Color.black;
}
