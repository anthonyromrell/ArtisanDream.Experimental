using UnityEngine;

[CreateAssetMenu(fileName = "Draggable", menuName = "Draggable/Drag With Rotation")]
public class DragFreeRotation : DragRotationBase
{
	private float distance;
	
	public override void OnMouseDrag()
	{
		distance = Input.GetAxis(AxisName) * Speed;
	
		
	}
}