using UnityEngine;

namespace ArtisanDream.Experimental.Dragable
{
    public abstract class DragRotationBase : MonoBehaviour {

        public string AxisName = "Mouse X";
        public float Speed = 10.0F;
        //protected float distance;
        protected Vector3 Vectors;
 

        public abstract void OnMouseDrag ();
    }
}



