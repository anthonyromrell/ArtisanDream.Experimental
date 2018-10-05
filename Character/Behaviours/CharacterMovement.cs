using ArtisanDream.Experimental.Character.MovePatterns;
using UnityEngine;

//Made By Anthony Romrell
namespace ArtisanDream.Experimental.Character.Behaviours
{
	[RequireComponent(typeof(CharacterController))]

	public class CharacterMovement : MonoBehaviour 
	{
	
		private CharacterController controller;
		public MovePattern Pattern;

		private void Start()
		{
			controller = GetComponent<CharacterController>();
		}

		void Update() {
			Pattern.Invoke(controller, transform);
		}
	}
}