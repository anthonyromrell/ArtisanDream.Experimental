using ArtisanDream.Tools.Actions;
using UnityEngine;

namespace ArtisanDream.Experimental.Behaviours
{
    public class ClickRunActionBehaviour : MonoBehaviour
    {
        public GameAction GameAction;

        private void OnMouseDown()
        {
            GameAction.Call(transform);
        }
    }
}