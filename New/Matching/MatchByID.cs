using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class MatchByID : MonoBehaviour
{
    public ID[] IdObj;
    public UnityEvent StartEvent;
    public List<UnityEvent> Events;

    private void Start()
    {
        StartEvent.Invoke();
    }

    public void ConfigEvents()
    {
        foreach (var obj in IdObj)
        {
            var newEvent = new UnityEvent();
            newEvent.AddListener(obj.MatchEvent.Invoke);
            Events.Add(newEvent);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        var otherIdObj = other.GetComponent<MatchByID>();

        foreach (var otherObj in otherIdObj.IdObj)
        {
            for (var index = 0; index < IdObj.Length; index++)
            {
                var obj = IdObj[index];
                if (obj != otherObj) continue;
                if (Events.Count > 0) Events[index].Invoke();
            }
        }      
    }
}
