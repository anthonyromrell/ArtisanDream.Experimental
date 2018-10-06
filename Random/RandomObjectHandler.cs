using UnityEngine;
using UnityEngine.Events;

namespace ArtisanDream.Experimental.Random
{
	[CreateAssetMenu]
	public class RandomObjectHandler : ScriptableObject
	{

		public UnityEvent Event;

		public Object NewObject;
		public Object TypeOf;
	
		public RandomObjectSelector ObjectSelector;

		private void OnEnable()
		{
			Debug.Log(TypeOf.GetType());
			NewObject = (GameObject) ObjectSelector.ReturnRandomObject();
		}
	}
}
