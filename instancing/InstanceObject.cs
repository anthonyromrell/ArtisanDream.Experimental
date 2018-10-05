using UnityEngine;

namespace ArtisanDream.Experimental.instancing
{
	[CreateAssetMenu]
//Made By Anthony Romrell
	public class InstanceObject : ScriptableObject
	{
		public void Invoke(GameObject instance)
		{
			Instantiate(instance);
		}
	}
}