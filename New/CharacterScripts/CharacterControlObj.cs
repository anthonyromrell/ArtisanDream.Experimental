using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;

[CreateAssetMenu]
public class CharacterControlObj : ScriptableObject
{
   [FormerlySerializedAs("MoveSpeed")] public float moveSpeed = 10;
   [FormerlySerializedAs("JumpSpeed")] public float jumpSpeed = 10;
   private int jumpCount = 1;
   [FormerlySerializedAs("JumpCountMax")] public int jumpCountMax = 2;
   [FormerlySerializedAs("Gravity")] public FloatDataObj gravity;
   
   private Vector3 position;
   
   public void OnMove(CharacterController controller)
   {
      if (Input.GetButtonDown("Jump")  &&  jumpCount < jumpCountMax)
      {
         position.y = jumpSpeed;
         jumpCount++;
      }

      if (controller.isGrounded)
      {
         jumpCount = 1;
         position.x = Input.GetAxis("Horizontal");
      }
      
      position.x = Input.GetAxis("Horizontal");
      position.y += gravity.value*Time.deltaTime;
      position.x *= moveSpeed;
      controller.Move(position*Time.deltaTime);
   }
}