using UnityEngine;

namespace ArtisanDream.Experimental.Behaviours
{
    public class ChildObject : MonoBehaviour
    {
        public Transform Piece;

        private void Awake()
        {
            Piece = GetComponentInParent<ParentObject>().transform;
        }

        private void OnMouseDown()
        {
            Piece.position = transform.position;
        }
    }
}