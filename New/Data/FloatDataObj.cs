using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;

[CreateAssetMenu]
public class FloatDataObj : ScriptableObject
{
    [FormerlySerializedAs("Value")] public float value;

    [FormerlySerializedAs("MinValueEvent")] public UnityEvent minValueEvent;
    [FormerlySerializedAs("MaxValueEvent")] public UnityEvent maxValueEvent;

    public void UpdateValue (float amount)
    {
        value += amount;
    }
    
    public void ResetValue (float amount)
    {
        value = amount;
    }
    
    public void CheckMinValue(float minValue)
    {
        if (value <= minValue)
        {
            value = minValue;
            minValueEvent.Invoke();
        }
    }

    public void CheckMaxValue(float maxValue)
    {
        if (value >= maxValue)
        {
            value = maxValue;
            maxValueEvent.Invoke();
        }
    }
}
