using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;

[CreateAssetMenu]
public class GameActionObj : ScriptableObject
{
    [FormerlySerializedAs("Action")] public UnityAction action;

    public void RaiseAction()
    {
        action?.Invoke();
    }
}