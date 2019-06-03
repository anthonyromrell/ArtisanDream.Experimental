using UnityEngine;

[CreateAssetMenu]
public class SideMoveNoJump : MovementStyleBase
{
    public override void OnMove(CharacterController controller)
    {
        Position.x = Input.GetAxis("Horizontal");
        Position.y += Gravity.Value*Time.deltaTime;
        if (controller.isGrounded)
        {
            Position.y = 0;
        }
        Position.x *= MoveSpeed;
        controller.Move(Position*Time.deltaTime);
    }
}
