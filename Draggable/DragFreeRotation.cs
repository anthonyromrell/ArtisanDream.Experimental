using UnityEngine;

namespace ArtisanDream.Experimental.Draggable
{
	public class DragFreeRotation : DragRotationBase
	{
		private float distance;

		public override void OnMouseDrag()
		{
			distance = Input.GetAxis(AxisName) * Speed;
		}
	}
}