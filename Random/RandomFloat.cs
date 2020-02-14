using UnityEngine;
using UnityEngine.Serialization;

[CreateAssetMenu(menuName = "Random/Float")]
public class RandomFloat : FloatData
{
  
    [FormerlySerializedAs("ValueRange")] [Range(0, 25)] public float valueRange;

    public float Randomize()
    {
        value = Mathf.RoundToInt(UnityEngine.Random.Range(0, valueRange));
        return value;
    }
}