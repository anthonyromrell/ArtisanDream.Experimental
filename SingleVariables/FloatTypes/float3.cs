using UnityEngine;

namespace ArtisanDream.Experimental.FloatTypes
{
	public class Float3
	{
		public float X, Y, Z;

		public Float3(float x, float y, float z)
		{
			this.X = x;
			this.Y = y;
			this.Z = z;
		}

		public Vector3 V3;
	}
}