using UnityEngine;
using UnityEngine.Serialization;

[CreateAssetMenu(menuName = "Coroutines/Wait For Seconds")]
public class WaitForSecondsObj : ScriptableObject, IWait
{
    [FormerlySerializedAs("Seconds")] public float seconds = 1;
    
    public object Obj { get; set; }

    public void Create()
    {
        Obj = new WaitForSeconds(seconds);
    }
}
    
public interface IWait
{
    object Obj { get; set; }
    void Create();
}