using UnityEngine;

namespace ArtisanDream.Experimental.GameStates
{
    [CreateAssetMenu(fileName = "GameBrain")]
    public class GameBrain : ScriptableObject
    {
        public GameStateBase CurrentState;
    }
}