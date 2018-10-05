using UnityEngine;

namespace ArtisanDream.Experimental.Behaviours
{
    public class DestroyAsset : MonoBehaviour
    {
        public void DestroyThis()
        {
            Destroy(gameObject);
        }
    }
}