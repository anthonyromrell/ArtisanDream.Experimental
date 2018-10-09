using UnityEngine;

namespace ArtisanDream.Experimental
{
	[CreateAssetMenu]
	//Made By Anthony Romrell
	public class InstanceObject : ScriptableObject
	{
		public void Call(GameObject instance)
		{
			Instantiate(instance);
		}
	}
}