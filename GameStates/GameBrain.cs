using UnityEngine;

namespace ArtisanDream.Experimental
{
    [CreateAssetMenu(fileName = "GameBrain")]
    public class GameBrain : ScriptableObject
    {
        public GameStateBase CurrentState;
    }
}