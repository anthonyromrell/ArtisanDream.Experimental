﻿using UnityEngine;

public abstract class MovementStyleBase : ScriptableObject
{
    public float MoveSpeed = 10;
    public FloatData Gravity;
    protected Vector3 Position;
    
    public abstract void OnMove(CharacterController controller);
}