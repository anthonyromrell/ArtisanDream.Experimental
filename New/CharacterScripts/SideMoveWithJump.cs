using UnityEngine;

[CreateAssetMenu]
public class SideMoveWithJump : SideMoveNoJump
{
    public float JumpSpeed = 10;
    public int JumpCountMax = 2;
    
    private int jumpCount = 1;
    
    public override void OnMove(CharacterController controller)
    {
        if (Input.GetButtonDown("Jump")  &&  jumpCount < JumpCountMax)
        {
            Position.y = JumpSpeed;
            jumpCount++;
        }

        if (controller.isGrounded)
        {
            jumpCount = 1;
        }
        base.OnMove(controller);
    }
}
