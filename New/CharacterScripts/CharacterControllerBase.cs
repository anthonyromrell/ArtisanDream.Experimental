using UnityEngine;

[CreateAssetMenu]
public class CharacterControllerBase : ScriptableObject
{
    public MovementStyleBase MoveStyle;

    public void MoveController(CharacterController controller)
    {
        MoveStyle.OnMove(controller);
    }

    public void ChangeMoveStyle(MovementStyleBase style)
    {
        MoveStyle = style;
    }
}