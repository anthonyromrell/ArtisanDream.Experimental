using UnityEngine;

[CreateAssetMenu(menuName = "Game Control/Game Brain")]
public class GameBrain : ScriptableObject
{
    public GameStateBase CurrentState;
}