using UnityEngine;
using UnityEngine.Serialization;


public abstract class GameStateBase : ScriptableObject, IGameState
{
    [FormerlySerializedAs("Brain")] public GameBrain brain;

    public abstract void StartState();
    public abstract void RunState();
}

public interface IGameState
{
    void StartState();
    void RunState();
}