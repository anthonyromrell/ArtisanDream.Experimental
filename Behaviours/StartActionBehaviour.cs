using ArtisanDream.Tools.Actions;
using UnityEngine;

//Made By Anthony Romrell
namespace ArtisanDream.Experimental.Behaviours
{
    public class StartActionBehaviour : MonoBehaviour
    {
        public GameAction GameAction;

        private void Start()
        {
            GameAction.Call(transform);
        }
    }
}