using UnityEngine;

namespace ArtisanDream.Experimental.Objects
{
    [CreateAssetMenu(fileName = "TransformVariable")]
    public class TransformVariable : ScriptableObject
    {
        public Transform Value { get; set; }
    }
}