using UnityEngine;

[CreateAssetMenu]
public class SideMoveNoJump : MovementStyleBase
{
    public override void OnMove(CharacterController controller)
    {
        Position.x = Input.GetAxis("Horizontal");
        Position.y += gravity.value*Time.deltaTime;
        if (controller.isGrounded)
        {
            Position.y = 0;
        }
        Position.x *= moveSpeed;
        controller.Move(Position*Time.deltaTime);
    }
}
