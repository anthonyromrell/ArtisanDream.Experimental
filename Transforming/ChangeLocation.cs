using UnityEngine;
using UnityEngine.Events;

public class ChangeLocation : MonoBehaviour
{
    public Vector3Data Location;
    public UnityEvent Event;

    public void MoveTo()
    {
        transform.position = Location.Value;
        Event.Invoke();
    }
}