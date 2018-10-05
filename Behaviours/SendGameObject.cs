using ArtisanDream.Tools.Actions;
using UnityEngine;

//Made By Anthony Romrell
namespace ArtisanDream.Experimental.Behaviours
{
    public class SendGameObject : MonoBehaviour
    {
        public GameAction Send;

        private void Start()
        {
            Send.Call(gameObject);
        }
    }
}