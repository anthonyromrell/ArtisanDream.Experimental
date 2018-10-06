using ArtisanDream.Tools.Actions;
using UnityEngine;

namespace ArtisanDream.Experimental.Behaviours
{
    public class SendTransform : MonoBehaviour
    {
        public GameAction Send;

        private void Start()
        {
            Send.Call(transform);
        }
    }
}