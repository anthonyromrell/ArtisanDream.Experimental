using UnityEngine;

[CreateAssetMenu(menuName = "Random/Number")]
public class RandomValue : ScriptableObject
{
    public FloatData RandomNumber;

    [Range(0, 10)] public float ValueRange;

    public void Randomize()
    {
        RandomNumber.Value = Mathf.RoundToInt(UnityEngine.Random.Range(0, ValueRange));
    }
}