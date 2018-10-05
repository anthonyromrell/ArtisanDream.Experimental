using UnityEngine;
using UnityEngine.Events;

namespace ArtisanDream.Experimental.Behaviours
{
    public class TriggerEvent : MonoBehaviour
    {
        public UnityEvent Event;

        private void OnTriggerEnter(Collider other)
        {
            Event.Invoke();
        }
    }
}