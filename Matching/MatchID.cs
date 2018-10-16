using ArtisanDream.Experimental.Objects;
using UnityEngine;
using UnityEngine.Events;

    public class MatchId : MonoBehaviour
    {
        public NameId Id;
        public UnityEvent OnMatch;

        private void OnTriggerEnter(Collider other)
        {
            var id = other.GetComponent<ObjectId>().Id;
            Call(id);
        }

        public void Call(NameId id)
        {
            if (id == Id)
            {
                OnMatch.Invoke();
            }
        }
    }