using UnityEngine;
using UnityEngine.Serialization;

public abstract class MovementStyleBase : ScriptableObject
{
    [FormerlySerializedAs("MoveSpeed")] public float moveSpeed = 10;
    [FormerlySerializedAs("Gravity")] public FloatData gravity;
    protected Vector3 Position;
    
    public abstract void OnMove(CharacterController controller);
}