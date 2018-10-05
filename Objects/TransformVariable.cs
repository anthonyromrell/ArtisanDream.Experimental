using UnityEngine;

namespace ArtisanDream.Experimental.Objects
{
    [CreateAssetMenu(fileName = "TransformVariable")]
    public class Vector3Data : ScriptableObject
    {
        public Vector3 value;

        public Vector3 Value
        {
            get => value;
            set => this.value = value;
        }
    }
}