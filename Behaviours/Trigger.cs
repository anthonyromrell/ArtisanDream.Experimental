
using ArtisanDream.Tools.Functions;
using ArtisanDream.Tools.Objects;
using UnityEngine;

namespace ArtisanDream.Experimental.Behaviours
{
	public class Trigger : MonoBehaviour
	{
		public FloatBase Data;
		public FunctionBase Work;
	
		private void OnTriggerEnter(Collider other)
		{
			Work.Run(Data);
		}
	}
}