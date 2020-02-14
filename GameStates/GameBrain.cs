using UnityEngine;
using UnityEngine.Serialization;

[CreateAssetMenu(menuName = "Game Control/Game Brain")]
public class GameBrain : ScriptableObject
{
    [FormerlySerializedAs("CurrentState")] public GameStateBase currentState;
}