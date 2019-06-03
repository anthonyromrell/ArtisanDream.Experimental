using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu]
public class FloatDataObj : ScriptableObject
{
    public float Value;

    public UnityEvent MinValueEvent, MaxValueEvent;
    
    public void UpdateValue (float amount)
    {
        Value += amount;
    }
    
    public void ResetValue (float amount)
    {
        Value = amount;
    }
    
    public void CheckMinValue(float minValue)
    {
        if (Value <= minValue)
        {
            Value = minValue;
            MinValueEvent.Invoke();
        }
    }

    public void CheckMaxValue(float maxValue)
    {
        if (Value >= maxValue)
        {
            Value = maxValue;
            MaxValueEvent.Invoke();
        }
    }
}
