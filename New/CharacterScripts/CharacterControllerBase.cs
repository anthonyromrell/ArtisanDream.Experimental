using UnityEngine;
using UnityEngine.Serialization;

[CreateAssetMenu]
public class CharacterControllerBase : ScriptableObject
{
    [FormerlySerializedAs("MoveStyle")] public MovementStyleBase moveStyle;

    public void MoveController(CharacterController controller)
    {
        moveStyle.OnMove(controller);
    }

    public void ChangeMoveStyle(MovementStyleBase style)
    {
        moveStyle = style;
    }
}