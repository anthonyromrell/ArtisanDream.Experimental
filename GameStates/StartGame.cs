using UnityEngine;

[CreateAssetMenu(menuName = "Game Control/StartGame")]
public class StartGame : GameStateBase
{
    public override void StartState()
    {
        Debug.Log("Starting Game");
    }

    public override void RunState()
    {
        Debug.Log("Running Game Start");
    }
}