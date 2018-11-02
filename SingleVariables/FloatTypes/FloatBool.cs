﻿using UnityEngine;
 
 [CreateAssetMenu(menuName = "Floats/Float Bool")]
 public class FloatBool : FloatData
 {
     public string InputType;
     public override float Value
     {
         get { return Input.GetButton(InputType) ? value : 0; }
     }
 }