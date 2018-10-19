using UnityEngine;

[CreateAssetMenu(menuName = "Game Control/RunGame")]
public class RunGame : GameStateBase
{
    public override void StartState()
    {
        Debug.Log("Start Playing Game");
    }

    public override void RunState()
    {
        Debug.Log("Playing Game");
    }
}