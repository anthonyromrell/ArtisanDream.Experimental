using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;


public class MatchById : MonoBehaviour
{
    public Id[] idObj;
    public UnityEvent startEvent;
    public List<UnityEvent> events;

    private void Start()
    {
        startEvent.Invoke();
    }

    public void ConfigEvents()
    {
        foreach (var obj in idObj)
        {
            var newEvent = new UnityEvent();
            newEvent.AddListener(obj.matchEvent.Invoke);
            events.Add(newEvent);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        var otherIdObj = other.GetComponent<MatchById>();

        foreach (var otherObj in otherIdObj.idObj)
        {
            for (var index = 0; index < idObj.Length; index++)
            {
                var obj = idObj[index];
                if (obj != otherObj) continue;
                if (events.Count > 0) events[index].Invoke();
            }
        }      
    }
}
