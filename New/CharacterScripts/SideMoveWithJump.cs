using UnityEngine;
using UnityEngine.Serialization;

[CreateAssetMenu]
public class SideMoveWithJump : SideMoveNoJump
{
    [FormerlySerializedAs("JumpSpeed")] public float jumpSpeed = 10;
    [FormerlySerializedAs("JumpCountMax")] public int jumpCountMax = 2;
    
    private int jumpCount = 1;
    
    public override void OnMove(CharacterController controller)
    {
        if (Input.GetButtonDown("Jump")  &&  jumpCount < jumpCountMax)
        {
            Position.y = jumpSpeed;
            jumpCount++;
        }

        if (controller.isGrounded)
        {
            jumpCount = 1;
        }
        base.OnMove(controller);
    }
}
