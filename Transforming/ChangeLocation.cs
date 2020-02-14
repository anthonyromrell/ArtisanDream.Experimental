using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;

public class ChangeLocation : MonoBehaviour
{
    [FormerlySerializedAs("Location")] public Vector3Data location;
    public UnityEvent Event;

    public void MoveTo()
    {
        transform.position = location.value;
        Event.Invoke();
    }
}