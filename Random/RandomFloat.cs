using UnityEngine;

[CreateAssetMenu(menuName = "Random/Float")]
public class RandomFloat : FloatData
{
    public new float Value;

    [Range(0, 25)] public float ValueRange;

    public float Randomize()
    {
        Value = Mathf.RoundToInt(UnityEngine.Random.Range(0, ValueRange));
        return Value;
    }
}