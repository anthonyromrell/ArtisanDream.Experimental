using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;

[CreateAssetMenu]
public class Id : ScriptableObject
{
    [FormerlySerializedAs("MatchEvent")] public UnityEvent matchEvent;
}