using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu]
public class GameActionObj : ScriptableObject
{
    public UnityAction Action;

    public void RaiseAction()
    {
        Action?.Invoke();
    }
}