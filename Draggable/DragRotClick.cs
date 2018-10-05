namespace ArtisanDream.Experimental.Draggable
{
	public class DragRotClick : DragRotationBase
	{
		private bool canRot;
	
		public override void OnMouseDrag()
		{
			canRot = true;
		}
	}
}