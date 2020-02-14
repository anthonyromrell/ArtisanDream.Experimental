using UnityEngine;

[CreateAssetMenu]
public class DebugObj : ScriptableObject
{
    public void OnDebug (string message)
    {
        Debug.Log(message);
    }
    
    public void OnDebug(FloatDataObj obj)
    {
        Debug.Log(obj.value);
    }
}